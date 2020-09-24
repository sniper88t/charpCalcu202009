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
    public partial class frmMain : Form
    {
        string startupPath = System.IO.Directory.GetCurrentDirectory();
        double dRetrofit = 3.5;
        double dBrickmould = 4.5;
        double dMargin = 0.0625;
        double dParam1 = 0.125;
        double dParam2 = 0.625;
        double dParam3 = 1.25;
        double dParam4 = 1.625;
        double dParam5 = 2;
        double brickmouldParam = 0.125;

        double brickA = 0.0;
        double brickB = 0.0;
        double retrofitA = 0.0;
        double retrofitB = 0.0;
        double resultB = 0.0;
        double resultC = 0.0;
        double resultD = 0.0;
        double wHeight = 0.0;
        frmChart chartdlg = new frmChart();
        Dictionary<string, double> trapzoid = new Dictionary<string, double>();
        bool isCalculating = false;
        public frmMain()
        {
            InitializeComponent();
            initialize();
            optRetrofit.Checked = true;
            opt1.Checked = true;
        }

        private void initialize()
        {
            if (File.Exists(startupPath + "\\SettingInfo.txt"))
            {
                Console.WriteLine("File exists...");
                try
                {
                    List<string> termsList = new List<string>();
                    string[] terms = new string[8];
                    // Create an instance of StreamReader to read from a file.
                    // The using statement also closes the StreamReader.
                    using (StreamReader sr = new StreamReader(startupPath + "\\SettingInfo.txt"))
                    {
                        string line;
                        // Read and display lines from the file until 
                        // the end of the file is reached. 
                        while ((line = sr.ReadLine()) != null)
                        {
                            //Console.WriteLine(line);
                            termsList.Add(line);
                            terms = termsList.ToArray();
                        }
                    }
                    dRetrofit = Convert.ToDouble(terms[0]);
                    dBrickmould = Convert.ToDouble(terms[1]);
                    dMargin = Convert.ToDouble(terms[2]);
                    dParam1 = Convert.ToDouble(terms[3]);
                    dParam2 = Convert.ToDouble(terms[4]);
                    dParam3 = Convert.ToDouble(terms[5]);
                    dParam4 = Convert.ToDouble(terms[6]);
                    dParam5 = Convert.ToDouble(terms[7]);
                }
                catch (Exception e)
                {
                    // Let the user know what went wrong.
                    Console.WriteLine("The file could not be read:");
                    Console.WriteLine(e.Message);
                }
            }
            else
            {
                Console.WriteLine("File does not exist in the current directory!");
                try
                {
                    string[] names = new string[] { dRetrofit.ToString(), dBrickmould.ToString(), dMargin.ToString(), dParam1.ToString(), dParam2.ToString(), dParam3.ToString(), dParam4.ToString(), dParam5.ToString() };

                    using (StreamWriter sw = new StreamWriter(startupPath + "\\SettingInfo.txt"))
                    {

                        foreach (string s in names)
                        {
                            sw.WriteLine(s);
                        }
                    }
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                
            }
        }

        private void optRetrofit_CheckedChanged(object sender, EventArgs e)
        {
            groupBrickmould.Hide();
            if (trapzoid.Count == 4)
                doCaculate();
        }

        private void optBrickmould_CheckedChanged(object sender, EventArgs e)
        {
            groupBrickmould.Show();
            if (trapzoid.Count == 4)
                doCaculate();
        }

        private void opt_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton opt = (RadioButton)sender;
            if (opt.Checked)
            {
                switch (opt.Name)
                {
                    case "opt1":
                        brickmouldParam = dParam1;
                        break;
                    case "opt2":
                        brickmouldParam = dParam2;
                        break;
                    case "opt3":
                        brickmouldParam = dParam3;
                        break;
                    case "opt4":
                        brickmouldParam = dParam4;
                        break;
                    case "opt5":
                        brickmouldParam = dParam5;
                        break;
                }
            }
            if (trapzoid.Count == 4)
                doCaculate();
        }

        private void number_Validating(object sender, CancelEventArgs e)
        {
            TextBox input = (TextBox)sender;
            string inputName = input.Name;
            Control control = null;
            switch (inputName)
            {
                case "va":
                    control = va; break;
                case "vb":
                    control = vb; break;
                case "vc":
                    control = vc; break;
                case "vd":
                    control = vd; break;
                case "vo":
                    control = vo; break;
                case "vp":
                    control = vp; break;
                case "vh":
                    control = vh; break;
            }
            double val;
            if (!double.TryParse(input.Text, out val) && input.Text.Length > 0)
            {
                errorProvider.SetError(control, "Please input a number.");
            }
            else
            {
                errorProvider.SetError(control, string.Empty);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            isCalculating = false;
            trapzoid.Clear();
            va.Clear(); va.ReadOnly = false;
            vb.Clear(); vb.ReadOnly = false;
            vc.Clear(); vc.ReadOnly = false;
            vd.Clear(); vd.ReadOnly = false;
            vo.Clear(); vo.ReadOnly = false;
            vp.Clear(); vp.ReadOnly = false;
            vh.Clear(); vh.ReadOnly = false;
            vq.Clear();
            vr.Clear();
            vh.Clear();
            ve.Clear();
            vf.Clear();
            txtResultB.Clear();
            txtResultC.Clear();
            txtResultD.Clear();
            txtWH.Clear();
            txtHeight.Clear();
            txtHeightOne.Clear();
            txtHeightTwo.Clear();

            errorProvider.Clear();
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            frmSetting dlg = new frmSetting();

            dlg.txtRetrofit.Text = dRetrofit.ToString();
            dlg.txtBrickmould.Text = dBrickmould.ToString();
            dlg.txtMargin.Text = dMargin.ToString();
            dlg.txtParam1.Text = dParam1.ToString();
            dlg.txtParam2.Text = dParam2.ToString();
            dlg.txtParam3.Text = dParam3.ToString();
            dlg.txtParam4.Text = dParam4.ToString();
            dlg.txtParam5.Text = dParam5.ToString();

            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                Console.WriteLine("show dialog");
                dRetrofit = Convert.ToDouble(dlg.txtRetrofit.Text);
                dBrickmould = Convert.ToDouble(dlg.txtBrickmould.Text);
                dMargin = Convert.ToDouble(dlg.txtMargin.Text);
                dParam1 = Convert.ToDouble(dlg.txtParam1.Text);
                dParam2 = Convert.ToDouble(dlg.txtParam2.Text);
                dParam3 = Convert.ToDouble(dlg.txtParam3.Text);
                dParam4 = Convert.ToDouble(dlg.txtParam4.Text);
                dParam5 = Convert.ToDouble(dlg.txtParam5.Text);

                string[] names = new string[] { dRetrofit.ToString(), dBrickmould.ToString(), dMargin.ToString(), dParam1.ToString(), dParam2.ToString(), dParam3.ToString(), dParam4.ToString(), dParam5.ToString() };

                using (StreamWriter sw = new StreamWriter(startupPath + "\\SettingInfo.txt"))
                {

                    foreach (string s in names)
                    {
                        sw.WriteLine(s);
                    }
                }
                doCaculate();
                //frmMain.dRetrofit

            }

            dlg.Dispose();
        }

        private void onTrapzoidInputChanged(object sender, EventArgs e)
        {
            TextBox input = (TextBox)sender;
            string key = input.Name;
            double val;
            if (input.Focused && input.Text != "" && double.TryParse(input.Text, out val))
            {
                if (trapzoid.ContainsKey(key))
                    trapzoid.Remove(key);
                trapzoid.Add(key, val);
            } else if (input.Text == "")
            {
                if (trapzoid.ContainsKey(key))
                    trapzoid.Remove(key);
            }

            if (trapzoid.Count == 4)
                doCaculate();
        }

        private void doCaculate()
        {
            if (!isCalculating)
            {
                if (!trapzoid.ContainsKey("va")) va.ReadOnly = true;
                if (!trapzoid.ContainsKey("vb")) vb.ReadOnly = true;
                if (!trapzoid.ContainsKey("vc")) vc.ReadOnly = true;
                if (!trapzoid.ContainsKey("vd")) vd.ReadOnly = true;
                if (!trapzoid.ContainsKey("vo")) vo.ReadOnly = true;
                if (!trapzoid.ContainsKey("vp")) vp.ReadOnly = true;
                if (!trapzoid.ContainsKey("vh")) vh.ReadOnly = true;
            }

            isCalculating = true;

            try
            {
                double a = double.NaN;
                double b = double.NaN;
                double c = double.NaN;
                double d = double.NaN;
                double o = double.NaN;
                double p = double.NaN;
                double q = double.NaN;
                double r = double.NaN;
                double e = double.NaN;
                double f = double.NaN;
                double h = double.NaN;

                if (trapzoid.ContainsKey("va") &&
                    trapzoid.ContainsKey("vb") &&
                    trapzoid.ContainsKey("vc") &&
                    trapzoid.ContainsKey("vd"))
                {
                    a = trapzoid["va"];
                    b = trapzoid["vb"];
                    c = trapzoid["vc"];
                    d = trapzoid["vd"];

                    if (a == c && b != d)
                    {
                        MessageBox.Show("Application thinks that your values lead to a contradiction.\n Here is the reason: a=b=c=d", "Warning!", MessageBoxButtons.OK);
                        return;
                    }else if(a == c)
                    {
                        o = Math.PI / 2;
                        p = Math.PI / 2;
                        q = Math.PI / 2;
                        r = Math.PI / 2;
                        b = a;
                        d = c;
                        e = Math.Sqrt(b * b - 2 * b * c * Math.Cos(q) + c * c);
                        f = Math.Sqrt(c * c - 2 * c * d * Math.Cos(r) + d * d);
                        h = b * Math.Sin(p);
                    }
                    else
                    {
                        o = Math.Acos((d * d + (a - c) * (a - c) - b * b) / (2 * d * (a - c)));
                        r = Math.PI - o;
                        f = Math.Sqrt(c * c + d * d - 2 * c * d * Math.Cos(r));
                        p = Math.Acos((a * a + b * b - f * f) / (2 * a * b));
                        q = Math.PI - p;
                        e = Math.Sqrt(b * b + c * c - 2 * b * c * Math.Cos(q));
                        h = d * Math.Sin(o);
                    }
                } else
                if (trapzoid.ContainsKey("va") &&
                    trapzoid.ContainsKey("vb") &&
                    trapzoid.ContainsKey("vc") &&
                    trapzoid.ContainsKey("vo"))
                {
                    a = trapzoid["va"];
                    b = trapzoid["vb"];
                    c = trapzoid["vc"];
                    o = trapzoid["vo"] * Math.PI / 180;

                    if (a == c && b != d)
                    {
                        MessageBox.Show("Application thinks that your values lead to a contradiction.\n Here is the reason: a=b=c=d", "Warning!", MessageBoxButtons.OK);
                        return;
                    }
                    else if (a == c)
                    {
                        o = Math.PI / 2;
                        p = Math.PI / 2;
                        q = Math.PI / 2;
                        r = Math.PI / 2;
                        b = a;
                        d = c;
                        e = Math.Sqrt(b * b - 2 * b * c * Math.Cos(q) + c * c);
                        f = Math.Sqrt(c * c - 2 * c * d * Math.Cos(r) + d * d);
                        h = b * Math.Sin(p);
                    }
                    else
                    {
                        r = Math.PI - o;
                        p = Math.PI - o - Math.Asin(Math.Sin(o) * (a - c) / b);
                        q = Math.PI - p;
                        f = Math.Sqrt(a * a + b * b - 2 * a * b * Math.Cos(p));
                        e = Math.Sqrt(b * b + c * c - 2 * b * c * Math.Cos(q));
                        h = b * Math.Sin(p);
                        d = h / Math.Sin(o);
                    }
                    

                }else
                if (trapzoid.ContainsKey("va") &&
                    trapzoid.ContainsKey("vb") &&
                    trapzoid.ContainsKey("vc") &&
                    trapzoid.ContainsKey("vp"))
                {
                    a = trapzoid["va"];
                    b = trapzoid["vb"];
                    c = trapzoid["vc"];
                    p = trapzoid["vp"] * Math.PI / 180;

                    if (a == c && b != d)
                    {
                        MessageBox.Show("Application thinks that your values lead to a contradiction.\n Here is the reason: a=b=c=d", "Warning!", MessageBoxButtons.OK);
                        return;
                    }
                    else if (a == c)
                    {
                        o = Math.PI / 2;
                        p = Math.PI / 2;
                        q = Math.PI / 2;
                        r = Math.PI / 2;
                        b = a;
                        d = c;
                        e = Math.Sqrt(b * b - 2 * b * c * Math.Cos(q) + c * c);
                        f = Math.Sqrt(c * c - 2 * c * d * Math.Cos(r) + d * d);
                        h = b * Math.Sin(p);
                    }
                    else
                    {
                        q = Math.PI - p;
                        e = Math.Sqrt(b * b - 2 * b * c * Math.Cos(q) + c * c);
                        f = Math.Sqrt(a * a - 2 * a * b * Math.Cos(p) + b * b);
                        //d = Math.Sqrt(a * a - 2 * a * b * Math.Cos(p) - 2 * a * c + b * b + 2 * b * c * Math.Cos(p) + c * c);
                        double ac = a - c;
                        d = Math.Sqrt(ac * ac + b * b - 2 * ac * b * Math.Cos(p));
                        o = Math.Asin(Math.Sin(p) * b / d);
                        r = Math.PI - o;
                        //r = Math.Acos(0.5 * c * c + 0.5 * d * d - 0.5 * e * e / c * d)
                        h = b * Math.Sin(p);
                    }
                }else
                if (trapzoid.ContainsKey("va") &&
                    trapzoid.ContainsKey("vb") &&
                    trapzoid.ContainsKey("vc") &&
                    trapzoid.ContainsKey("vh"))
                {
                    a = trapzoid["va"];
                    b = trapzoid["vb"];
                    c = trapzoid["vc"];
                    h = trapzoid["vh"];

                    if (a == c && b != d)
                    {
                        MessageBox.Show("Application thinks that your values lead to a contradiction.\n Here is the reason: a=b=c=d", "Warning!", MessageBoxButtons.OK);
                        return;
                    }
                    else if (a == c)
                    {
                        o = Math.PI / 2;
                        p = Math.PI / 2;
                        q = Math.PI / 2;
                        r = Math.PI / 2;
                        b = a;
                        d = c;
                        e = Math.Sqrt(b * b - 2 * b * c * Math.Cos(q) + c * c);
                        f = Math.Sqrt(c * c - 2 * c * d * Math.Cos(r) + d * d);
                        h = b * Math.Sin(p);
                    }
                    else
                    {
                        p = Math.Asin(h / b);
                        q = -p + Math.PI;
                        f = Math.Sqrt(a * a - 2 * a * b * Math.Cos(p) + b * b);
                        e = Math.Sqrt(b * b - 2 * b * c * Math.Cos(q) + c * c);
                        d = Math.Sqrt(a * a - 2 * a * b * Math.Cos(p) - 2 * a * c + b * b + 2 * b * c * Math.Cos(p) + c * c);
                        r = Math.Acos((c * c + d * d - f * f) / (2 * c * d));
                        o = -r + Math.PI;
                    }
                }else
                if (trapzoid.ContainsKey("va") &&
                    trapzoid.ContainsKey("vb") &&
                    trapzoid.ContainsKey("vd") &&
                    trapzoid.ContainsKey("vo"))
                {
                    a = trapzoid["va"];
                    b = trapzoid["vb"];
                    d = trapzoid["vd"];
                    o = trapzoid["vo"] * Math.PI / 180;

                    r = - o + Math.PI;
                    e = Math.Sqrt(a * a - 2 * a * d * Math.Cos(o) + d * d);
                    h = d * Math.Sin(r);
                    p = -Math.Asin(h / b) + Math.PI;
                    q = -p + Math.PI;
                    f = Math.Sqrt(a * a - 2 * a * b * Math.Cos(p) + b * b);
                    c = (a * Math.Sin(o) - b * Math.Sin(- o - p + Math.PI))/Math.Sin(o);
                }else
                if (trapzoid.ContainsKey("va") &&
                    trapzoid.ContainsKey("vb") &&
                    trapzoid.ContainsKey("vd") &&
                    trapzoid.ContainsKey("vp"))
                {
                    a = trapzoid["va"];
                    b = trapzoid["vb"];
                    d = trapzoid["vd"];
                    p = trapzoid["vp"] * Math.PI / 180;

                    q = - p + Math.PI;
                    f = Math.Sqrt(a * a - 2 * a * b * Math.Cos(p) + b * b);
                    h = b * Math.Sin(p);
                    r = - Math.Asin(h / d) + Math.PI;
                    o = -r + Math.PI;
                    e = Math.Sqrt(a * a - 2 * a * d * Math.Cos(o) + d * d);                  
                    c = (a * Math.Sin(o) - b * Math.Sin(-o - p + Math.PI)) / Math.Sin(o);
                }else
                if (trapzoid.ContainsKey("va") &&
                    trapzoid.ContainsKey("vb") &&
                    trapzoid.ContainsKey("vd") &&
                    trapzoid.ContainsKey("vh"))
                {
                    a = trapzoid["va"];
                    b = trapzoid["vb"];
                    d = trapzoid["vd"];
                    h = trapzoid["vh"];

                    p = Math.Asin(h / b);
                    q = -p + Math.PI;
                    r = -Math.Asin(h / d) + Math.PI;
                    o = -r + Math.PI;
                    f = Math.Sqrt(a * a - 2 * a * b * Math.Cos(p) + b * b);
                    e = Math.Sqrt(a * a - 2 * a * d * Math.Cos(o) + d * d);
                    c = (a * Math.Sin(o) - b * Math.Sin(-o - p + Math.PI)) / Math.Sin(o);
                    
                }else
                if (trapzoid.ContainsKey("va") &&
                    trapzoid.ContainsKey("vb") &&
                    trapzoid.ContainsKey("vo") &&
                    trapzoid.ContainsKey("vp"))
                {
                    a = trapzoid["va"];
                    b = trapzoid["vb"];
                    o = trapzoid["vo"] * Math.PI / 180;
                    p = trapzoid["vp"] * Math.PI / 180;

                    r = -o + Math.PI;
                    q = -p + Math.PI;
                    f = Math.Sqrt(a * a - 2 * a * b * Math.Cos(p) + b * b);
                    h = b * Math.Sin(p);
                    d = h / Math.Sin(r);
                    e = Math.Sqrt(a * a - 2 * a * d * Math.Cos(o) + d * d);
                    c = (a * Math.Sin(o) - b * Math.Sin(-o - p + Math.PI)) / Math.Sin(o);

                }else
                if (trapzoid.ContainsKey("va") &&
                    trapzoid.ContainsKey("vb") &&
                    trapzoid.ContainsKey("vo") &&
                    trapzoid.ContainsKey("vh"))
                {
                    a = trapzoid["va"];
                    b = trapzoid["vb"];
                    o = trapzoid["vo"] * Math.PI / 180;
                    h = trapzoid["vh"];

                    r = -o + Math.PI;
                    p = Math.Asin(h / b);
                    q = -p + Math.PI;
                    f = Math.Sqrt(a * a - 2 * a * b * Math.Cos(p) + b * b);
                    d = h / Math.Sin(r);
                    e = Math.Sqrt(a * a - 2 * a * d * Math.Cos(o) + d * d);
                    c = (a * Math.Sin(o) - b * Math.Sin(-o - p + Math.PI)) / Math.Sin(o);

                }else
                if (trapzoid.ContainsKey("va") &&
                    trapzoid.ContainsKey("vb") &&
                    trapzoid.ContainsKey("vp") &&
                    trapzoid.ContainsKey("vh"))
                {
                    a = trapzoid["va"];
                    b = trapzoid["vb"];
                    p = trapzoid["vp"] * Math.PI / 180;
                    h = trapzoid["vh"];
                    MessageBox.Show("Application thinks that your values lead to a contradiction.\n Here is the reason: The following equation is valid: sin(beta)= h/b", "Warning!", MessageBoxButtons.OK);                  
                    return;
                }else
                if (trapzoid.ContainsKey("va") &&
                    trapzoid.ContainsKey("vc") &&
                    trapzoid.ContainsKey("vd") &&
                    trapzoid.ContainsKey("vo"))
                {
                    a = trapzoid["va"];
                    c = trapzoid["vc"];
                    d = trapzoid["vd"];
                    o = trapzoid["vo"] * Math.PI / 180;

                    if (a == c && b != d)
                    {
                        MessageBox.Show("Application thinks that your values lead to a contradiction.\n Here is the reason: a=b=c=d", "Warning!", MessageBoxButtons.OK);
                        return;
                    }
                    else if (a == c)
                    {
                        o = Math.PI / 2;
                        p = Math.PI / 2;
                        q = Math.PI / 2;
                        r = Math.PI / 2;
                        b = a;
                        d = c;
                        e = Math.Sqrt(b * b - 2 * b * c * Math.Cos(q) + c * c);
                        f = Math.Sqrt(c * c - 2 * c * d * Math.Cos(r) + d * d);
                        h = b * Math.Sin(p);
                    }
                    else
                    {
                        r = -o + Math.PI;
                        f = Math.Sqrt(c * c - 2 * c * d * Math.Cos(r) + d * d);
                        e = Math.Sqrt(a * a - 2 * a * d * Math.Cos(o) + d * d);
                        b = Math.Sqrt(a * a - 2 * a * c - 2 * a * d * Math.Cos(o) + c * c + 2 * c * d * Math.Cos(o) + d * d);
                        p = Math.Acos((0.5 * a * a + 0.5 * b * b - 0.5 * f * f) / (a * b));
                        q = -p + Math.PI;
                        h = b * Math.Sin(p);
                    }

                }else
                if (trapzoid.ContainsKey("va") &&
                    trapzoid.ContainsKey("vc") &&
                    trapzoid.ContainsKey("vd") &&
                    trapzoid.ContainsKey("vp"))
                {
                    a = trapzoid["va"];
                    c = trapzoid["vc"];
                    d = trapzoid["vd"];
                    p = trapzoid["vp"] * Math.PI / 180;

                    if (a == c && b != d)
                    {
                        MessageBox.Show("Application thinks that your values lead to a contradiction.\n Here is the reason: a=b=c=d", "Warning!", MessageBoxButtons.OK);
                        return;
                    }
                    else if (a == c)
                    {
                        o = Math.PI / 2;
                        p = Math.PI / 2;
                        q = Math.PI / 2;
                        r = Math.PI / 2;
                        b = a;
                        d = c;
                        e = Math.Sqrt(b * b - 2 * b * c * Math.Cos(q) + c * c);
                        f = Math.Sqrt(c * c - 2 * c * d * Math.Cos(r) + d * d);
                        h = b * Math.Sin(p);
                    }
                    else
                    {

                        q = -p + Math.PI;
                        r = -q - Math.Asin(-Math.Sin(q) * (a - c) / d) + Math.PI;
                        o = -r + Math.PI;
                        f = Math.Sqrt(c * c - 2 * c * d * Math.Cos(r) + d * d);
                        e = Math.Sqrt(a * a - 2 * a * d * Math.Cos(o) + d * d);
                        b = Math.Sqrt(a * a - 2* a* c - 2 * a * d * Math.Cos(o) + c * c + 2 * c * d * Math.Cos(o) + d * d);
                        h = b * Math.Sin(p);
                    }
                    //////

                }else
                if (trapzoid.ContainsKey("va") &&
                    trapzoid.ContainsKey("vc") &&
                    trapzoid.ContainsKey("vd") &&
                    trapzoid.ContainsKey("vh"))
                {
                    a = trapzoid["va"];
                    c = trapzoid["vc"];
                    d = trapzoid["vd"];
                    h = trapzoid["vh"];

                    if (a == c && b != d)
                    {
                        MessageBox.Show("Application thinks that your values lead to a contradiction.\n Here is the reason: a=b=c=d", "Warning!", MessageBoxButtons.OK);
                        return;
                    }
                    else if (a == c)
                    {
                        o = Math.PI / 2;
                        p = Math.PI / 2;
                        q = Math.PI / 2;
                        r = Math.PI / 2;
                        b = a;
                        d = c;
                        e = Math.Sqrt(b * b - 2 * b * c * Math.Cos(q) + c * c);
                        f = Math.Sqrt(c * c - 2 * c * d * Math.Cos(r) + d * d);
                        h = b * Math.Sin(p);
                    }
                    else
                    {
                        r = -Math.Asin(h / d) + Math.PI;
                        o = -r + Math.PI;
                        f = Math.Sqrt(c * c - 2 * c * d * Math.Cos(r) + d * d);
                        e = Math.Sqrt(a * a - 2 * a * d * Math.Cos(o) + d * d);
                        b = Math.Sqrt(a * a - 2 * a * c - 2 * a * d * Math.Cos(o) + c * c + 2 * c * d * Math.Cos(o) + d * d);
                        p = Math.Acos((0.5 * a * a + 0.5 * b * b - 0.5 * f * f) / (a * b));
                        q = -p + Math.PI;
                    }
                }else
                if (trapzoid.ContainsKey("va") &&
                    trapzoid.ContainsKey("vc") &&
                    trapzoid.ContainsKey("vo") &&
                    trapzoid.ContainsKey("vp"))
                {
                    a = trapzoid["va"];
                    c = trapzoid["vc"];
                    o = trapzoid["vo"] * Math.PI / 180;
                    p = trapzoid["vp"] * Math.PI / 180;

                    if (a == c && b != d)
                    {
                        MessageBox.Show("Application thinks that your values lead to a contradiction.\n Here is the reason: a=b=c=d", "Warning!", MessageBoxButtons.OK);
                        return;
                    }
                    else if (a == c)
                    {
                        o = Math.PI / 2;
                        p = Math.PI / 2;
                        q = Math.PI / 2;
                        r = Math.PI / 2;
                        b = a;
                        d = c;
                        e = Math.Sqrt(b * b - 2 * b * c * Math.Cos(q) + c * c);
                        f = Math.Sqrt(c * c - 2 * c * d * Math.Cos(r) + d * d);
                        h = b * Math.Sin(p);
                    }
                    else
                    {
                        q = -p + Math.PI;
                        r = -o + Math.PI;
                        b = (a * Math.Sin(o) - c * Math.Sin(o)) / (Math.Sin(-o - p + Math.PI));
                        f = Math.Sqrt(a * a - 2 * a * b * Math.Cos(p) + b * b);
                        e = Math.Sqrt(b * b - 2 * b * c * Math.Cos(q) + c * c);
                        d = Math.Sqrt(a * a - 2 * a * b * Math.Cos(p) - 2 * a * c + b * b + 2 * b * c * Math.Cos(p) + c * c);
                        h = b * Math.Sin(p);
                    }
                    
                }else
                if (trapzoid.ContainsKey("va") &&
                    trapzoid.ContainsKey("vc") &&
                    trapzoid.ContainsKey("vo") &&
                    trapzoid.ContainsKey("vh"))
                {
                    a = trapzoid["va"];
                    c = trapzoid["vc"];
                    o = trapzoid["vo"] * Math.PI / 180;
                    h = trapzoid["vh"];

                    if (a == c && b != d)
                    {
                        MessageBox.Show("Application thinks that your values lead to a contradiction.\n Here is the reason: a=b=c=d", "Warning!", MessageBoxButtons.OK);
                        return;
                    }
                    else if (a == c)
                    {
                        o = Math.PI / 2;
                        p = Math.PI / 2;
                        q = Math.PI / 2;
                        r = Math.PI / 2;
                        b = a;
                        d = c;
                        e = Math.Sqrt(b * b - 2 * b * c * Math.Cos(q) + c * c);
                        f = Math.Sqrt(c * c - 2 * c * d * Math.Cos(r) + d * d);
                        h = b * Math.Sin(p);
                    }
                    else
                    {
                        r = -o + Math.PI;
                        d = h / Math.Sin(r);
                        f = Math.Sqrt(c * c - 2 * c * d * Math.Cos(r) + d * d);
                        e = Math.Sqrt(a * a - 2 * a * d * Math.Cos(o) + d * d);
                        b = Math.Sqrt(a * a - 2 * a * c - 2 * a * d * Math.Cos(o) + c * c + 2 * c * d * Math.Cos(o) + d * d);
                        p = Math.Acos((0.5 * a * a + 0.5 * b * b - 0.5 * f * f) / (a * b));
                        q = -p + Math.PI;
                    }

                }else
                if (trapzoid.ContainsKey("va") &&
                    trapzoid.ContainsKey("vc") &&
                    trapzoid.ContainsKey("vp") &&
                    trapzoid.ContainsKey("vh"))
                {
                    a = trapzoid["va"];
                    c = trapzoid["vc"];
                    p = trapzoid["vp"] * Math.PI / 180;
                    h = trapzoid["vh"];

                    if (a == c && b != d)
                    {
                        MessageBox.Show("Application thinks that your values lead to a contradiction.\n Here is the reason: a=b=c=d", "Warning!", MessageBoxButtons.OK);
                        return;
                    }
                    else if (a == c)
                    {
                        o = Math.PI / 2;
                        p = Math.PI / 2;
                        q = Math.PI / 2;
                        r = Math.PI / 2;
                        b = a;
                        d = c;
                        e = Math.Sqrt(b * b - 2 * b * c * Math.Cos(q) + c * c);
                        f = Math.Sqrt(c * c - 2 * c * d * Math.Cos(r) + d * d);
                        h = b * Math.Sin(p);
                    }
                    else
                    {
                        q = -p + Math.PI;
                        b = h / Math.Sin(p);
                        f = Math.Sqrt(a * a - 2 * a * b * Math.Cos(p) + b * b);
                        e = Math.Sqrt(b * b - 2 * b * c * Math.Cos(q) + c * c);
                        d = Math.Sqrt(a * a - 2 * a * b * Math.Cos(p) - 2 * a * c + b * b + 2 * b * c * Math.Cos(p) + c * c);
                        r = Math.Acos((0.5 * c * c + 0.5 * d * d - 0.5 * f * f) / (c * d));
                        o = -r + Math.PI;
                    }
                }else
                if (trapzoid.ContainsKey("va") &&
                    trapzoid.ContainsKey("vd") &&
                    trapzoid.ContainsKey("vo") &&
                    trapzoid.ContainsKey("vp"))
                {
                    a = trapzoid["va"];
                    d = trapzoid["vd"];
                    o = trapzoid["vo"] * Math.PI / 180;
                    p = trapzoid["vp"] * Math.PI / 180;

                    r = -o + Math.PI;
                    q = -p + Math.PI;
                    e = Math.Sqrt(a * a - 2 * a * d * Math.Cos(o) + d * d);
                    h = d * Math.Sin(r);
                    b = h / Math.Sin(p);
                    f = Math.Sqrt(a * a - 2 * a * b * Math.Cos(p) + b * b);
                    c = (a * Math.Sin(o) - b * Math.Sin(- o - p + Math.PI)) / Math.Sin(o);                  
                }else
                if (trapzoid.ContainsKey("va") &&
                    trapzoid.ContainsKey("vd") &&
                    trapzoid.ContainsKey("vo") &&
                    trapzoid.ContainsKey("vh"))
                {
                    a = trapzoid["va"];
                    d = trapzoid["vd"];
                    o = trapzoid["vo"] * Math.PI / 180;
                    h = trapzoid["vh"];
                    MessageBox.Show("Application thinks that your values lead to a contradiction.\n Here is the reason: The following equation is valid: sin(alpha)= h/d", "Warning!", MessageBoxButtons.OK);
                    return;
                }else
                if (trapzoid.ContainsKey("va") &&
                    trapzoid.ContainsKey("vd") &&
                    trapzoid.ContainsKey("vp") &&
                    trapzoid.ContainsKey("vh"))
                {
                    a = trapzoid["va"];
                    d = trapzoid["vd"];
                    p = trapzoid["vp"] * Math.PI / 180;
                    h = trapzoid["vh"];

                    q = -p + Math.PI;
                    b = h / Math.Sin(p);
                    f = Math.Sqrt(a * a - 2 * a * b * Math.Cos(p) + b * b);
                    r = -Math.Asin(h / d) + Math.PI;
                    o = -r + Math.PI;
                    e = Math.Sqrt(a * a - 2 * a * d * Math.Cos(o) + d * d);                    
                    c = (a * Math.Sin(o) - b * Math.Sin(-o - p + Math.PI)) / Math.Sin(o);
                }else
                if (trapzoid.ContainsKey("va") &&
                    trapzoid.ContainsKey("vo") &&
                    trapzoid.ContainsKey("vp") &&
                    trapzoid.ContainsKey("vh"))
                {
                    a = trapzoid["va"];
                    o = trapzoid["vo"] * Math.PI / 180;
                    p = trapzoid["vp"] * Math.PI / 180;
                    h = trapzoid["vh"];

                    r = -o + Math.PI;
                    q = -p + Math.PI;
                    b = h / Math.Sin(p);
                    f = Math.Sqrt(a * a - 2 * a * b * Math.Cos(p) + b * b);
                    d = h / Math.Sin(r);
                    e = Math.Sqrt(a * a - 2 * a * d * Math.Cos(o) + d * d);
                    c = (a * Math.Sin(o) - b * Math.Sin(-o - p + Math.PI)) / Math.Sin(o);
                }else
                if (trapzoid.ContainsKey("vb") &&
                    trapzoid.ContainsKey("vc") &&
                    trapzoid.ContainsKey("vd") &&
                    trapzoid.ContainsKey("vo"))
                {
                    b = trapzoid["vb"];
                    c = trapzoid["vc"];
                    d = trapzoid["vd"];
                    o = trapzoid["vo"] * Math.PI / 180;

                    r = -o + Math.PI;
                    f = Math.Sqrt(c * c - 2 * c * d * Math.Cos(r) + d * d);
                    h = d * Math.Sin(r);
                    p = Math.Asin(h / b);
                    q = -p + Math.PI;
                    e = Math.Sqrt(b * b - 2 * b * c * Math.Cos(q) + c * c);
                    a = (b * Math.Sin(-o - p + Math.PI) + c * Math.Sin(o)) / Math.Sin(o);
                }else
                if (trapzoid.ContainsKey("vb") &&
                    trapzoid.ContainsKey("vc") &&
                    trapzoid.ContainsKey("vd") &&
                    trapzoid.ContainsKey("vp"))
                {
                    b = trapzoid["vb"];
                    c = trapzoid["vc"];
                    d = trapzoid["vd"];
                    p = trapzoid["vp"] * Math.PI / 180;

                    q = -p + Math.PI;
                    e = Math.Sqrt(b * b - 2 * b * c * Math.Cos(q) + c * c);
                    h = b * Math.Sin(p);
                    r = -Math.Asin(h / d) + Math.PI;
                    o = -r + Math.PI;
                    f = Math.Sqrt(c * c - 2 * c * d * Math.Cos(r) + d * d);                 
                    a = (b * Math.Sin(-o - p + Math.PI) + c * Math.Sin(o)) / Math.Sin(o);
                }else
                if (trapzoid.ContainsKey("vb") &&
                    trapzoid.ContainsKey("vc") &&
                    trapzoid.ContainsKey("vd") &&
                    trapzoid.ContainsKey("vh"))
                {
                    b = trapzoid["vb"];
                    c = trapzoid["vc"];
                    d = trapzoid["vd"];
                    h = trapzoid["vh"];

                    p = -Math.Asin(h / b) + Math.PI;
                    q = -p + Math.PI;
                    e = Math.Sqrt(b * b - 2 * b * c * Math.Cos(q) + c * c);
                    r = -Math.Asin(h / d) + Math.PI;
                    o = -r + Math.PI;
                    f = Math.Sqrt(c * c - 2 * c * d * Math.Cos(r) + d * d);
                    a = (b * Math.Sin(-o - p + Math.PI) + c * Math.Sin(o)) / Math.Sin(o);
                }else
                if (trapzoid.ContainsKey("vb") &&
                    trapzoid.ContainsKey("vc") &&
                    trapzoid.ContainsKey("vo") &&
                    trapzoid.ContainsKey("vp"))
                {
                    b = trapzoid["vb"];
                    c = trapzoid["vc"];
                    o = trapzoid["vo"] * Math.PI / 180;
                    p = trapzoid["vp"] * Math.PI / 180;

                    r = -o + Math.PI;
                    q = -p + Math.PI;
                    e = Math.Sqrt(b * b - 2 * b * c * Math.Cos(q) + c * c);
                    h = b * Math.Sin(p);
                    d = h / Math.Sin(r);
                    f = Math.Sqrt(c * c - 2 * c * d * Math.Cos(r) + d * d);
                    a = (b * Math.Sin(-o - p + Math.PI) + c * Math.Sin(o)) / Math.Sin(o);
                }else
                if (trapzoid.ContainsKey("vb") &&
                    trapzoid.ContainsKey("vc") &&
                    trapzoid.ContainsKey("vo") &&
                    trapzoid.ContainsKey("vh"))
                {
                    b = trapzoid["vb"];
                    c = trapzoid["vc"];
                    o = trapzoid["vo"] * Math.PI / 180;
                    h = trapzoid["vh"];

                    r = -o + Math.PI;
                    p = -Math.Asin(h / b) + Math.PI;
                    q = -p + Math.PI;
                    e = Math.Sqrt(b * b - 2 * b * c * Math.Cos(q) + c * c);
                    d = h / Math.Sin(r);
                    f = Math.Sqrt(c * c - 2 * c * d * Math.Cos(r) + d * d);
                    a = (b * Math.Sin(-o - p + Math.PI) + c * Math.Sin(o)) / Math.Sin(o);
                }else
                if (trapzoid.ContainsKey("vb") &&
                    trapzoid.ContainsKey("vc") &&
                    trapzoid.ContainsKey("vp") &&
                    trapzoid.ContainsKey("vh"))
                {
                    b = trapzoid["vb"];
                    c = trapzoid["vc"];
                    p = trapzoid["vp"] * Math.PI / 180;
                    h = trapzoid["vh"];
                    MessageBox.Show("Application thinks that your values lead to a contradiction.\n Here is the reason: The following equation is valid: sin(beta)= h/b", "Warning!", MessageBoxButtons.OK);
                    return;
                }else
                if (trapzoid.ContainsKey("vb") &&
                    trapzoid.ContainsKey("vd") &&
                    trapzoid.ContainsKey("vo") &&
                    trapzoid.ContainsKey("vp"))
                {
                    b = trapzoid["vb"];
                    d = trapzoid["vd"];
                    o = trapzoid["vo"] * Math.PI / 180;
                    p = trapzoid["vp"] * Math.PI / 180;
                    MessageBox.Show("Application thinks that your values lead to a contradiction.\n Here is the reason: The following equation is valid: The following equation is valid: dsin(a_a)/b=dsin(a_b)/d", "Warning!", MessageBoxButtons.OK);
                    return;
                }else
                if (trapzoid.ContainsKey("vb") &&
                    trapzoid.ContainsKey("vd") &&
                    trapzoid.ContainsKey("vo") &&
                    trapzoid.ContainsKey("vh"))
                {
                    b = trapzoid["vb"];
                    d = trapzoid["vd"];
                    o = trapzoid["vo"] * Math.PI / 180;
                    h = trapzoid["vh"];
                    MessageBox.Show("Application thinks that your values lead to a contradiction.\n Here is the reason: The following equation is valid: sin(alpha)= h/d", "Warning!", MessageBoxButtons.OK);
                    return;
                }else
                if (trapzoid.ContainsKey("vb") &&
                    trapzoid.ContainsKey("vd") &&
                    trapzoid.ContainsKey("vp") &&
                    trapzoid.ContainsKey("vh"))
                {
                    b = trapzoid["vb"];
                    d = trapzoid["vd"];
                    p = trapzoid["vp"] * Math.PI / 180;
                    h = trapzoid["vh"];
                    MessageBox.Show("Application thinks that your values lead to a contradiction.\n Here is the reason: The following equation is valid: sin(beta)= h/b", "Warning!", MessageBoxButtons.OK);
                    return;
                }else
                if (trapzoid.ContainsKey("vb") &&
                    trapzoid.ContainsKey("vo") &&
                    trapzoid.ContainsKey("vp") &&
                    trapzoid.ContainsKey("vh"))
                {
                    b = trapzoid["vb"];
                    o = trapzoid["vo"];
                    p = trapzoid["vp"] * Math.PI / 180;
                    h = trapzoid["vh"];
                    MessageBox.Show("Application thinks that your values lead to a contradiction.\n Here is the reason: The following equation is valid: sin(beta)= h/b", "Warning!", MessageBoxButtons.OK);
                    return;
                }else
                if (trapzoid.ContainsKey("vc") &&
                    trapzoid.ContainsKey("vd") &&
                    trapzoid.ContainsKey("vo") &&
                    trapzoid.ContainsKey("vp"))
                {
                    c = trapzoid["vc"];
                    d = trapzoid["vd"];
                    o = trapzoid["vo"] * Math.PI / 180;
                    p = trapzoid["vp"] * Math.PI / 180;

                    r = -o + Math.PI;
                    q = -p + Math.PI;
                    f = Math.Sqrt(c * c - 2 * c * d * Math.Cos(r) + d * d);
                    h = d * Math.Sin(r);
                    b = h / Math.Sin(p);
                    e = Math.Sqrt(b * b - 2 * b * c * Math.Cos(q) + c * c);              
                    a = (b * Math.Sin(-o - p + Math.PI) + c * Math.Sin(o)) / Math.Sin(o);
                }else
                if (trapzoid.ContainsKey("vc") &&
                    trapzoid.ContainsKey("vd") &&
                    trapzoid.ContainsKey("vo") &&
                    trapzoid.ContainsKey("vh"))
                {
                    c = trapzoid["vc"];
                    d = trapzoid["vd"];
                    o = trapzoid["vo"] * Math.PI / 180;
                    h = trapzoid["vh"];
                    MessageBox.Show("Application thinks that your values lead to a contradiction.\n Here is the reason: The following equation is valid: sin(alpha)= h/d", "Warning!", MessageBoxButtons.OK);
                    return;
                }else
                if (trapzoid.ContainsKey("vc") &&
                    trapzoid.ContainsKey("vd") &&
                    trapzoid.ContainsKey("vp") &&
                    trapzoid.ContainsKey("vh"))
                {
                    c = trapzoid["vc"];
                    d = trapzoid["vd"];
                    p = trapzoid["vp"] * Math.PI / 180;
                    h = trapzoid["vh"];
                    MessageBox.Show("Application thinks that your values lead to a contradiction.\n Here is the reason: The following equation is valid:  Sin(delta)=h/d", "Warning!", MessageBoxButtons.OK);
                    return;
                }else
                if (trapzoid.ContainsKey("vc") &&
                    trapzoid.ContainsKey("vo") &&
                    trapzoid.ContainsKey("vp") &&
                    trapzoid.ContainsKey("vh"))
                {
                    c = trapzoid["vc"];
                    o = trapzoid["vo"] * Math.PI / 180;
                    p = trapzoid["vp"] * Math.PI / 180;
                    h = trapzoid["vh"]; 

                    r = -o + Math.PI;
                    q = -p + Math.PI;
                    b = h / Math.Sin(p);
                    e = Math.Sqrt(b * b - 2 * b * c * Math.Cos(q) + c * c);
                    d = h / Math.Sin(r);
                    f = Math.Sqrt(c * c - 2 * c * d * Math.Cos(r) + d * d);
                    a = (b * Math.Sin(-o - p + Math.PI) + c * Math.Sin(o)) / Math.Sin(o);
                }else
                if (trapzoid.ContainsKey("vd") &&
                    trapzoid.ContainsKey("vo") &&
                    trapzoid.ContainsKey("vp") &&
                    trapzoid.ContainsKey("vh"))
                {
                    d = trapzoid["vd"];
                    o = trapzoid["vo"] * Math.PI / 180;
                    p = trapzoid["vp"] * Math.PI / 180;
                    h = trapzoid["vh"];
                    MessageBox.Show("Application thinks that your values lead to a contradiction.\n Here is the reason: The following equation is valid:  Sin(alpha)=h/d", "Warning!", MessageBoxButtons.OK);
                    return;
                }


                //triangle calculator SAS
               if (optBrickmould.Checked == true)
                {
                    brickA = 2 * dBrickmould * Math.Sin(o / 4);
                    brickB = 2 * dBrickmould * Math.Sin(p / 4);
                    if (txtWH.Text == "")
                    {
                        wHeight = 0.0;
                    }
                    else
                    {
                        wHeight = Convert.ToDouble(txtWH.Text);
                    }
                    wHeight = wHeight - brickmouldParam * 2;
                    resultC = c - brickA - brickB - 2 * dMargin;
                    resultB = b - brickmouldParam - brickB - dMargin;
                    resultD = d - brickmouldParam - brickA - dMargin;
                }
                else if (optRetrofit.Checked == true)
                {
                    retrofitA = dRetrofit * Math.Sin(o / 4);
                    retrofitB = dRetrofit * Math.Sin(p / 4);
                    if (txtWH.Text == "")
                    {
                        wHeight = 0.0;
                    }
                    else
                    {
                        wHeight = Convert.ToDouble(txtWH.Text);
                    }
                    
                    resultC = c - retrofitA - retrofitB - dMargin * 2;
                    resultB = b - retrofitB - dMargin;
                    resultD = d - retrofitA - dMargin;
                }


                o = o * 180 / Math.PI;
                o = Math.Round(o, MidpointRounding.AwayFromZero);
                p = p * 180 / Math.PI;
                q = q * 180 / Math.PI;
                r = r * 180 / Math.PI;

                if (!trapzoid.ContainsKey("va")) va.Text = a.ToString();
                if (!trapzoid.ContainsKey("vb")) vb.Text = b.ToString();
                if (!trapzoid.ContainsKey("vc")) vc.Text = c.ToString();
                if (!trapzoid.ContainsKey("vd")) vd.Text = d.ToString();
                if (!trapzoid.ContainsKey("ve")) vo.Text = o.ToString();
                if (!trapzoid.ContainsKey("vf")) vp.Text = p.ToString();
                vq.Text = q.ToString();
                vr.Text = r.ToString();
                ve.Text = e.ToString();
                vf.Text = f.ToString();
                if (!trapzoid.ContainsKey("vh")) vh.Text = h.ToString();

                txtResultB.Text = FractionConverter.Convert((decimal)resultB);
                txtResultC.Text = FractionConverter.Convert((decimal)resultC);
                txtResultD.Text = FractionConverter.Convert((decimal)resultD);
                txtHeight.Text = FractionConverter.Convert((decimal)wHeight);
                txtHeightOne.Text = FractionConverter.Convert((decimal)wHeight);
                txtHeightTwo.Text = FractionConverter.Convert((decimal)wHeight);

            }

            catch (Exception) { }
        }

        private void txtWH_TextChanged(object sender, EventArgs e)
        {
            
            if (txtWH.Text == "")
            {
                btnClear_Click(sender, e);
            }
            else
            {
                doCaculate();
            }

        }

        private void btnChart_Click(object sender, EventArgs e)
        {
            chartdlg.Show();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            prtDialog.Document = prtDoc;
            if(prtDialog.ShowDialog() == DialogResult.OK)
            {
                prtDoc.Print();
            }
        }

        private void prtDoc_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(txtResultB.Text, new Font("Arial", 40, FontStyle.Bold), Brushes.Black, 150, 125);
        }


        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.F1)
            {
                if (chartdlg.Visible == false)
                {                
                    chartdlg.Show();
                }
                else
                {
                    chartdlg.Hide();
                }
                
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }


    public static class FractionConverter
    {
        public static string Convert(decimal pvalue,
        bool skip_rounding = false, decimal dplaces = (decimal)0.0625)
        {
            decimal value = pvalue;

            if (!skip_rounding)
                value = FractionConverter.DecimalRound(pvalue, dplaces);

            if (value == Math.Round(value, 0)) // whole number check
                return value.ToString();

            // get the whole value of the fraction
            decimal mWhole = Math.Truncate(value);

            // get the fractional value
            decimal mFraction = value - mWhole;

            // initialize a numerator and denomintar
            uint mNumerator = 0;
            uint mDenomenator = 1;

            // ensure that there is actual a fraction
            if (mFraction > 0m)
            {
                // convert the value to a string so that
                // you can count the number of decimal places there are
                string strFraction = mFraction.ToString().Remove(0, 2);
                 
                // store the number of decimal places
                uint intFractLength = (uint)strFraction.Length;

                // set the numerator to have the proper amount of zeros
                mNumerator = (uint)Math.Pow(10, intFractLength);

                // parse the fraction value to an integer that equals
                // [fraction value] * 10^[number of decimal places]
                uint.TryParse(strFraction, out mDenomenator);

                // get the greatest common divisor for both numbers
                uint gcd = GreatestCommonDivisor(mDenomenator, mNumerator);

                // divide the numerator and the denominator by the greatest common divisor
                mNumerator = mNumerator / gcd;
                mDenomenator = mDenomenator / gcd;
            }

            // create a string builder
            StringBuilder mBuilder = new StringBuilder();

            // add the whole number if it's greater than 0
            if (mWhole > 0m)
            {
                mBuilder.Append(mWhole);
            }

            // add the fraction if it's greater than 0m
            if (mFraction > 0m)
            {
                if (mBuilder.Length > 0)
                {
                    mBuilder.Append(" ");
                }

                mBuilder.Append(mDenomenator);
                mBuilder.Append("/");
                mBuilder.Append(mNumerator);
            }

            return mBuilder.ToString();
        }

        // Converts fraction to decimal.
        // There are two formats a fraction greater than 1 can consist of
        // which this function will work for:
        //  Example: 4-1/2 or 4 1/2
        // Fractions less than 1 are in the format of 1/2, etc..
        public static decimal Convert(string value)
        {
            string[] dparse;
            string[] fparse;
            string whole = "0";
            string dec = "";
            decimal dReturn = 0;

            // check for '-' or ' ' separator between whole number and fraction
            dparse = value.Contains('-') ? value.Split('-') : value.Split(' ');
            int pcount = dparse.Count();

            // fraction greater than one.
            if (pcount == 2)
            {
                whole = dparse[0];
                dec = dparse[1];
            }
            // whole number or fraction less than 1.
            else if (pcount == 1)
                dec = dparse[0];

            // split out fractional part of value passed in.
            fparse = dec.Split('/');

            // check for fraction.
            if (fparse.Count() == 2)
            {
                try
                {
                    decimal d0 = System.Convert.ToDecimal(fparse[0]); // convert numerator
                    decimal d1 = System.Convert.ToDecimal(fparse[1]); // convert denominator
                    dReturn = d0 / d1; // divide the fraction (converts to decimal)
                    decimal dWhole = System.Convert.ToDecimal(whole); // convert
                                                                      // whole number part to decimal.

                    dReturn = dWhole + dReturn; // add whole number
                                                // and fractional part and we're done.
                }
                catch (Exception e)
                {
                    dReturn = 0;
                }
            }
            else
            // there is no fractional part of the input.
            {
                try
                {
                    dReturn = System.Convert.ToDecimal(whole + dec);
                }
                catch (Exception e)
                {
                    // bad input so return 0.
                    dReturn = 0;
                }
            }

            return dReturn;
        }

        private static uint GreatestCommonDivisor(uint valA, uint valB)
        {
            // return 0 if both values are 0 (no GSD)
            if (valA == 0 &&
              valB == 0)
            {
                return 0;
            }
            // return value b if only a == 0
            else if (valA == 0 &&
                  valB != 0)
            {
                return valB;
            }
            // return value a if only b == 0
            else if (valA != 0 && valB == 0)
            {
                return valA;
            }
            // actually find the GSD
            else
            {
                uint first = valA;
                uint second = valB;

                while (first != second)
                {
                    if (first > second)
                    {
                        first = first - second;
                    }
                    else
                    {
                        second = second - first;
                    }
                }

                return first;
            }

        }

        // Converts a value to feet and inches.
        // Examples:
        //  12.1667 converts to 12' 2"
        //  4 converts to 4'
        //  0.1667 converts to 2"
        public static bool ReformatForFeetAndInches
            (ref string line_type, bool zero_for_blank = true)
        {
            if (string.IsNullOrEmpty(line_type))
            {
                if (zero_for_blank)
                    line_type = "0'";
                return true;
            }

            decimal d = System.Convert.ToDecimal(line_type);
            decimal d1 = Math.Floor(d);
            decimal d2 = d - d1;
            d2 = Math.Round(d2 * 12, 2);

            string s1;
            string s2;

            s1 = d1 == 0 ? "" : d1.ToString() + "'";
            s2 = d2 == 0 ? "" : FractionConverter.Convert(d2) + @"""";

            line_type = string.Format(@"{0} {1}", s1, s2).Trim();

            if (string.IsNullOrEmpty(line_type))
            {
                if (zero_for_blank)
                    line_type = "0'";
                return true;
            }

            return true;
        }

        // Rounds a number to the nearest decimal.
        // For instance, carpenters do not want to see a number like 4/5.
        // That means nothing to them
        // and you'll have an angry carpenter on your hands
        // if you ask them cut a 2x4 to 36 and 4/5 inches.
        // So, we would want to convert to the nearest 1/16 of an inch.
        // Example: DecimalRound(0.8, 0.0625) Rounds 4/5 to 13/16 or 0.8125.
        private static decimal DecimalRound(decimal val, decimal places)
        {
            string sPlaces = FractionConverter.Convert(places, true);
            string[] s = sPlaces.Split('/');

            if (s.Count() == 2)
            {
                int nPlaces = System.Convert.ToInt32(s[1]);
                decimal d = Math.Round(val * nPlaces);
                return d / nPlaces;
            }

            return val;
        }
    }
}
