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
    public partial class AdminWindow : Form
    {
        public AdminWindow()
        {
            InitializeComponent();
        }

        private void AdminWindow_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "gasPipelineDataSet.User". При необходимости она может быть перемещена или удалена.
            this.userTableAdapter.Fill(this.gasPipelineDataSet.User);

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
          
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {

        }
    }
}
