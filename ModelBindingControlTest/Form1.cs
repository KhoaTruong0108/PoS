using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using lhk.POS.Core.Domain;

namespace ModelBindingControlTest
{
    public partial class Form1 : Form
    {
        Model1 _model;
        public Form1()
        {
            InitializeComponent();

            _model = new Model1();

            dataGridView1.DataBindings.Add("DataSource", _model, "Users", true, DataSourceUpdateMode.OnPropertyChanged);

            comboBox1.DataBindings.Add("DataSource", _model, "Users", true, DataSourceUpdateMode.OnPropertyChanged);
            comboBox1.DataBindings.Add("SelectedItem", _model, "SelectedUser", true, DataSourceUpdateMode.OnPropertyChanged);

            comboBox1.ValueMember = "UserName";
            comboBox1.DisplayMember = "Id";

            InitData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = _model.SelectedUser.Id.ToString();
        }

        private void InitData()
        {
            IEnumerable<User> data = new BindingList<User>(){
                new User(){ Id = 1, Role="role", UserName="username"},
                new User(){ Id = 2, Role="role", UserName="username"},
                new User(){ Id = 3, Role="role", UserName="username"},
                new User(){ Id = 4, Role="role", UserName="username"},
                new User(){ Id = 5, Role="role", UserName="username"},
            };

            _model.Users = data;
        }

       
    }
}
