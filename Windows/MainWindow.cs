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
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void buttonAboutProgramm_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программа GasPipe создана для моделирования газопроводной сети на местности.");
        }

        private void AutoButton_Click(object sender, EventArgs e)
        {
            AutoWindow auto = new AutoWindow();
            auto.Show();
            this.Hide();
        }

        private void buttonEducation_Click(object sender, EventArgs e)
        {
            EducationWindow edu = new EducationWindow();
            edu.Show();
            this.Hide();
        }

      
    }
}
