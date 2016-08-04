using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;
using System.Net.Mail;
using System.Net;
using System.IO;

namespace lhk.POS.Core.Util
{
    public class AutoSendMail
    {
        private Timer _sendingTimer;

        private string _title = "[Maintainance - {0}] Auto-Send mail - Log file";
        private string _content = "";
        private DateTime _currentDate;
        private List<int> _sendMailHours = new List<int>() { 8,14,18 };

        private static AutoSendMail _instance;
        public static AutoSendMail GetInstance()
        {
            if (_instance == null)
                _instance = new AutoSendMail();
            return _instance;
        }

        private AutoSendMail()
        {
            _sendingTimer = new Timer();
            _sendingTimer.AutoReset = true;
            _sendingTimer.Enabled = true;
            _sendingTimer.Elapsed += new ElapsedEventHandler(onTimerElapse);

            _sendingTimer.Interval = Constants.AUTOSENDMAIL_TIMER_INTERVAL;

            _currentDate = DateTime.Now;

            try
            {
                string hours = ConfigurationUtil.GetConfig(Constants.FIELD_CONFIGURATION_SEND_MAINTENANCE_MAIL_HOUR);
                _sendMailHours = hours.Split(',').Select(i => int.Parse(i)).ToList();
            }
            catch (Exception exc)
            {
                AppLogger.logError("[onTimerElapse]", exc.Message);
            }
        }

        ~AutoSendMail()
        {
            _sendingTimer.Stop();
            _sendingTimer = null;
        }

        protected void onTimerElapse(object source, System.Timers.ElapsedEventArgs e)
        {
            try
            {
                AppLogger.logInfo("[AutoSendMail]", "Begin onTimerElapse");

                if (_sendMailHours.Contains(DateTime.Now.Hour))
                {
                    SendMail();
                }

                AppLogger.logInfo("[AutoSendMail]", "Finish onTimerElapse");
            }
            catch (Exception exc)
            {
                AppLogger.logError("[onTimerElapse]", exc.Message);
            }
        }

        public void Start()
        {
            _sendingTimer.Start();
        }

        public void Stop()
        {
            _sendingTimer.Stop();
        }

        public void SendMail(string stationName = "")
        {
            try
            {
                string logFilePath = "Logs\\SystemLog.log." + DateTime.Now.AddDays(-1).ToString("yyyy-MM-dd");

                if (File.Exists(logFilePath) == false)
                {
                    return;
                }

                string addressToConfig = ConfigurationUtil.GetConfig(Constants.FIELD_CONFIGURATION_MAINTAINER_EMAIL_ADDRESS_TO);
                string addressTo = addressToConfig.Split(',').FirstOrDefault();
                var ccAdressList = addressToConfig.Split(',');

                string addressFrom = ConfigurationUtil.GetConfig(Constants.FIELD_CONFIGURATION_MAINTAINER_EMAIL_ADDRESS_FROM);
                string password = ConfigurationUtil.GetConfig(Constants.FIELD_CONFIGURATION_MAINTAINER_EMAIL_ADDRESS_PASS);

                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                client.SendCompleted += new SendCompletedEventHandler(SendMailComplete_Click);
                client.EnableSsl = true;
                MailAddress from = new MailAddress(addressFrom, "Maintainer");
                MailAddress to = new MailAddress(addressTo, "Maintainer");
                MailMessage message = new MailMessage(from, to);
                message.Body = _content;
                message.Subject = string.Format(_title,stationName);
                message.Attachments.Add(new Attachment(logFilePath));
                NetworkCredential myCreds = new NetworkCredential(addressFrom, password, "");
                client.Credentials = myCreds;

                foreach (var i in ccAdressList)
                {
                    if (i.Equals(addressTo) == false)
                    {
                        message.CC.Add(i);
                    }
                }


                client.Send(message);
            }
            catch (Exception exc)
            {
                AppLogger.logError("[SendMail]", exc.Message);
            }
        }

        private void SendMailComplete_Click(object sender, EventArgs e)
        {
            AppLogger.logInfo("[AutoSendMail]", "Send mail success!!!");
        }
    }
}
