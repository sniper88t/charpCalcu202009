using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowCalculator
{
    public partial class frmSetting : Form
    {
        string startupPath = System.IO.Directory.GetCurrentDirectory();
        double sRetrofit = 0.0;
        double sBrickmould = 0.0;
        double sMargin = 0.0;
        double sParam1 = 0.0;
        double sParam2 = 0.0;
        double sParam3 = 0.0;
        double sParam4 = 0.0;
        double sParam5 = 0.0;

        public frmSetting()
        {
            InitializeComponent();
            initialize();
        }

        private void initialize()
        {
           
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            saveDataSetting();
        }

        private void saveDataSetting()
        {
            try
            {
                sRetrofit = Convert.ToDouble(txtRetrofit.Text);
                sBrickmould = Convert.ToDouble(txtBrickmould);
                sMargin = Convert.ToDouble(txtMargin.Text);
                sParam1 = Convert.ToDouble(txtParam1.Text);
                sParam2 = Convert.ToDouble(txtParam2.Text);
                sParam3 = Convert.ToDouble(txtParam3.Text);
                sParam4 = Convert.ToDouble(txtParam4.Text);
                sParam5 = Convert.ToDouble(txtParam5.Text);

                string[] names = new string[] { sRetrofit.ToString(), sBrickmould.ToString(), sMargin.ToString(), sParam1.ToString(), sParam2.ToString(), sParam3.ToString(), sParam4.ToString(), sParam5.ToString() };

                using (StreamWriter sw = new StreamWriter(startupPath + "\\SettingInfo.txt"))
                {

                    foreach (string s in names)
                    {
                        sw.WriteLine(s);
                    }
                }

                //frmMain.dRetrofit
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
