using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lhk.POS.Core.Util;
using lhk.POS.Data;

namespace lhk.POS.Data
{
    public class SqlFileInstallation
    {
        private readonly IDbContext _dbContext;

        public SqlFileInstallation(IDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public void InstallData()
        {
            var appSetting = ConfigurationManager.AppSettings.GetValues("create_sample_data");

            if (appSetting != null && appSetting.Count() > 0)
            {
                string filePath = Environment.CurrentDirectory + "\\" + appSetting[0];

                try
                {
                    if (File.Exists(filePath)) ExecuteSqlFile(filePath);
                }
                catch (Exception exc)
                {
                    AppLogger.logError(exc);
                }
            }
        }
        protected virtual void ExecuteSqlFile(string path)
        {
            var statements = new List<string>();

            using (var stream = File.OpenRead(path))
            using (var reader = new StreamReader(stream))
            {
                string statement = "";
                while ((statement = ReadNextStatementFromStream(reader)) != null)
                    statements.Add(statement);
            }

            foreach (string stmt in statements)
                _dbContext.ExecuteSqlCommand(stmt);
        }

        protected virtual string ReadNextStatementFromStream(StreamReader reader)
        {
            var sb = new StringBuilder();
            string lineOfText = "";
            while (true)
            {
                lineOfText = reader.ReadLine();
                if (lineOfText == null)
                {
                    if (sb.Length > 0)
                        return sb.ToString();
                    else
                        return null;
                }

                if (lineOfText.TrimEnd().ToUpper() == "GO")
                    break;

                sb.Append(lineOfText + Environment.NewLine);
            }

            return sb.ToString();
        }
    }
}
