using GasPipeLine.DataBase;
using GasPipeLine.VM;
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
    public partial class AdministrationWindow : Form
    {
        User user = new User();
        public AdministrationWindow()
        {
            InitializeComponent();
          
        }

   
        private void AdministrationWindow_Load(object sender, EventArgs e)
        {

            PopulateGrid();

        }

        private void PopulateGrid()
        {
            GasPipelineDB db = new GasPipelineDB();
            try
            {
                dataGridView1.DataSource = db.User.ToList();
            }
            catch
            { 

            }
        }

        private void buttonGoBack_Click(object sender, EventArgs e)
        {
            MainWindow mnw = new MainWindow();
            mnw.Show();
            this.Hide();
        }
    }
}
