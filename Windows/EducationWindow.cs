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
    public partial class EducationWindow : Form
    {
        public EducationWindow()
        {
            InitializeComponent();
        }

        private void buttonGoToMineWindow_Click(object sender, EventArgs e)
        {
            MainWindow mnw = new MainWindow();
            mnw.Show();
            this.Hide();
        }
    }
}
