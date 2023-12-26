using GasPipeLine.DataBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GasPipeLine.Windows
{
    public partial class AutoWindow : Form
    {
        public AutoWindow()
        {
            InitializeComponent();
            txbPassword.UseSystemPasswordChar = true;
        }

        GasPipelineDB pipelineDB = new GasPipelineDB();
        
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (pipelineDB.User.Where(r => r.Login == txbLogin.Text && r.Password == txbPassword.Text).Count() > 0)
                {
                    WorkingWindow wrk = new WorkingWindow();
                    wrk.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Неверный логин или пароль.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Отсутствует база данных или подключение нарушено!");
            }
            
        }
    }
}
