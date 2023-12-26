using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GasPipeLine.Windows
{
    public partial class WorkingWindow : Form
    {
        public WorkingWindow()
        {
            InitializeComponent();
        }

        private void buttonBegin_Click(object sender, EventArgs e)
        {
            axMap1.CursorMode = MapWinGIS.tkCursorMode.cmMeasure;
        }

        private void buttonCarry_Click(object sender, EventArgs e)
        {
            axMap1.CursorMode = MapWinGIS.tkCursorMode.cmPan;
        }

        private void buttonScreen_Click(object sender, EventArgs e)
        {
            MakeScreenshot();
            MessageBox.Show("Результат сохранен");
        }
        public static void MakeScreenshot()
        {

            Rectangle bounds = Screen.GetBounds(Point.Empty);


            using (var bitmap = new Bitmap(bounds.Width, bounds.Height))
            {
                // создаем объект на котором можно рисовать
                using (var g = Graphics.FromImage(bitmap))
                {

                    g.CopyFromScreen(Point.Empty, Point.Empty, bounds.Size);
                }


                bitmap.Save(@"D:\screenshot_01.jpg", ImageFormat.Jpeg);
            }
        }

        private void buttonGoToMainWindow_Click(object sender, EventArgs e)
        {
            MainWindow mnw = new MainWindow();
            mnw.Show();
            this.Hide();
        }
    }
}
