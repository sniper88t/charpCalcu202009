namespace WindowCalculator
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.va = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.vb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.vc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.vd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.vo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.vp = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.vq = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.vr = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.vh = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.ve = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.vf = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSetting = new System.Windows.Forms.Button();
            this.optRetrofit = new System.Windows.Forms.RadioButton();
            this.groupBrickmould = new System.Windows.Forms.GroupBox();
            this.opt5 = new System.Windows.Forms.RadioButton();
            this.opt4 = new System.Windows.Forms.RadioButton();
            this.opt3 = new System.Windows.Forms.RadioButton();
            this.opt2 = new System.Windows.Forms.RadioButton();
            this.opt1 = new System.Windows.Forms.RadioButton();
            this.label12 = new System.Windows.Forms.Label();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtResultB = new System.Windows.Forms.TextBox();
            this.txtResultC = new System.Windows.Forms.TextBox();
            this.txtResultD = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtHeightOne = new System.Windows.Forms.TextBox();
            this.txtHeightTwo = new System.Windows.Forms.TextBox();
            this.lblWH = new System.Windows.Forms.Label();
            this.txtWH = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnChart = new System.Windows.Forms.Button();
            this.prtDoc = new System.Drawing.Printing.PrintDocument();
            this.btnPrint = new System.Windows.Forms.Button();
            this.prtDialog = new System.Windows.Forms.PrintDialog();
            this.optBrickmould = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBrickmould.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // va
            // 
            this.va.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.va.Location = new System.Drawing.Point(88, 269);
            this.va.Name = "va";
            this.va.Size = new System.Drawing.Size(100, 26);
            this.va.TabIndex = 1;
            this.va.TextChanged += new System.EventHandler(this.onTrapzoidInputChanged);
            this.va.Validating += new System.ComponentModel.CancelEventHandler(this.number_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "a";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 304);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "b";
            // 
            // vb
            // 
            this.vb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vb.Location = new System.Drawing.Point(88, 301);
            this.vb.Name = "vb";
            this.vb.Size = new System.Drawing.Size(100, 26);
            this.vb.TabIndex = 3;
            this.vb.TextChanged += new System.EventHandler(this.onTrapzoidInputChanged);
            this.vb.Validating += new System.ComponentModel.CancelEventHandler(this.number_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(64, 336);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "c";
            // 
            // vc
            // 
            this.vc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vc.Location = new System.Drawing.Point(88, 333);
            this.vc.Name = "vc";
            this.vc.Size = new System.Drawing.Size(100, 26);
            this.vc.TabIndex = 5;
            this.vc.TextChanged += new System.EventHandler(this.onTrapzoidInputChanged);
            this.vc.Validating += new System.ComponentModel.CancelEventHandler(this.number_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(64, 368);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "d";
            // 
            // vd
            // 
            this.vd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vd.Location = new System.Drawing.Point(88, 365);
            this.vd.Name = "vd";
            this.vd.Size = new System.Drawing.Size(100, 26);
            this.vd.TabIndex = 7;
            this.vd.TextChanged += new System.EventHandler(this.onTrapzoidInputChanged);
            this.vd.Validating += new System.ComponentModel.CancelEventHandler(this.number_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(237, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "α";
            // 
            // vo
            // 
            this.vo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vo.Location = new System.Drawing.Point(261, 269);
            this.vo.Name = "vo";
            this.vo.Size = new System.Drawing.Size(100, 26);
            this.vo.TabIndex = 9;
            this.vo.TextChanged += new System.EventHandler(this.onTrapzoidInputChanged);
            this.vo.Validating += new System.ComponentModel.CancelEventHandler(this.number_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(237, 304);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "β";
            // 
            // vp
            // 
            this.vp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vp.Location = new System.Drawing.Point(261, 301);
            this.vp.Name = "vp";
            this.vp.Size = new System.Drawing.Size(100, 26);
            this.vp.TabIndex = 11;
            this.vp.TextChanged += new System.EventHandler(this.onTrapzoidInputChanged);
            this.vp.Validating += new System.ComponentModel.CancelEventHandler(this.number_Validating);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(237, 336);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "γ";
            // 
            // vq
            // 
            this.vq.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vq.Location = new System.Drawing.Point(261, 333);
            this.vq.Name = "vq";
            this.vq.ReadOnly = true;
            this.vq.Size = new System.Drawing.Size(100, 26);
            this.vq.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(237, 368);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "δ";
            // 
            // vr
            // 
            this.vr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vr.Location = new System.Drawing.Point(261, 365);
            this.vr.Name = "vr";
            this.vr.ReadOnly = true;
            this.vr.Size = new System.Drawing.Size(100, 26);
            this.vr.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(405, 272);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 20);
            this.label9.TabIndex = 18;
            this.label9.Text = "h";
            // 
            // vh
            // 
            this.vh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vh.Location = new System.Drawing.Point(429, 269);
            this.vh.Name = "vh";
            this.vh.Size = new System.Drawing.Size(100, 26);
            this.vh.TabIndex = 17;
            this.vh.TextChanged += new System.EventHandler(this.onTrapzoidInputChanged);
            this.vh.Validating += new System.ComponentModel.CancelEventHandler(this.number_Validating);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(405, 304);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(18, 20);
            this.label10.TabIndex = 20;
            this.label10.Text = "e";
            // 
            // ve
            // 
            this.ve.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ve.Location = new System.Drawing.Point(429, 301);
            this.ve.Name = "ve";
            this.ve.ReadOnly = true;
            this.ve.Size = new System.Drawing.Size(100, 26);
            this.ve.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(405, 336);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(14, 20);
            this.label11.TabIndex = 22;
            this.label11.Text = "f";
            // 
            // vf
            // 
            this.vf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vf.Location = new System.Drawing.Point(429, 333);
            this.vf.Name = "vf";
            this.vf.ReadOnly = true;
            this.vf.Size = new System.Drawing.Size(100, 26);
            this.vf.TabIndex = 21;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(429, 365);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 23);
            this.btnClear.TabIndex = 23;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.optBrickmould);
            this.groupBox1.Controls.Add(this.btnSetting);
            this.groupBox1.Controls.Add(this.optRetrofit);
            this.groupBox1.Location = new System.Drawing.Point(12, 397);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(600, 61);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            // 
            // optBrickmould
            // 
            this.optBrickmould.AutoSize = true;
            this.optBrickmould.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optBrickmould.Location = new System.Drawing.Point(244, 19);
            this.optBrickmould.Name = "optBrickmould";
            this.optBrickmould.Size = new System.Drawing.Size(105, 24);
            this.optBrickmould.TabIndex = 0;
            this.optBrickmould.Text = "Brickmould";
            this.optBrickmould.UseVisualStyleBackColor = true;
            this.optBrickmould.CheckedChanged += new System.EventHandler(this.optBrickmould_CheckedChanged);
            // 
            // btnSetting
            // 
            this.btnSetting.Location = new System.Drawing.Point(417, 19);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(100, 23);
            this.btnSetting.TabIndex = 23;
            this.btnSetting.Text = "Setting";
            this.btnSetting.UseVisualStyleBackColor = true;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // optRetrofit
            // 
            this.optRetrofit.AutoSize = true;
            this.optRetrofit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optRetrofit.Location = new System.Drawing.Point(56, 19);
            this.optRetrofit.Name = "optRetrofit";
            this.optRetrofit.Size = new System.Drawing.Size(80, 24);
            this.optRetrofit.TabIndex = 0;
            this.optRetrofit.Text = "Retrofit";
            this.optRetrofit.UseVisualStyleBackColor = true;
            this.optRetrofit.CheckedChanged += new System.EventHandler(this.optRetrofit_CheckedChanged);
            // 
            // groupBrickmould
            // 
            this.groupBrickmould.Controls.Add(this.opt5);
            this.groupBrickmould.Controls.Add(this.opt4);
            this.groupBrickmould.Controls.Add(this.opt3);
            this.groupBrickmould.Controls.Add(this.opt2);
            this.groupBrickmould.Controls.Add(this.opt1);
            this.groupBrickmould.Location = new System.Drawing.Point(12, 465);
            this.groupBrickmould.Name = "groupBrickmould";
            this.groupBrickmould.Size = new System.Drawing.Size(600, 59);
            this.groupBrickmould.TabIndex = 25;
            this.groupBrickmould.TabStop = false;
            this.groupBrickmould.Text = "Brickmould Size";
            // 
            // opt5
            // 
            this.opt5.AutoSize = true;
            this.opt5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opt5.Location = new System.Drawing.Point(475, 20);
            this.opt5.Name = "opt5";
            this.opt5.Size = new System.Drawing.Size(42, 24);
            this.opt5.TabIndex = 26;
            this.opt5.TabStop = true;
            this.opt5.Text = "2\"";
            this.opt5.UseVisualStyleBackColor = true;
            this.opt5.CheckedChanged += new System.EventHandler(this.opt_CheckedChanged);
            // 
            // opt4
            // 
            this.opt4.AutoSize = true;
            this.opt4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opt4.Location = new System.Drawing.Point(360, 20);
            this.opt4.Name = "opt4";
            this.opt4.Size = new System.Drawing.Size(69, 24);
            this.opt4.TabIndex = 27;
            this.opt4.TabStop = true;
            this.opt4.Text = "1-5/8\"";
            this.opt4.UseVisualStyleBackColor = true;
            this.opt4.CheckedChanged += new System.EventHandler(this.opt_CheckedChanged);
            // 
            // opt3
            // 
            this.opt3.AutoSize = true;
            this.opt3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opt3.Location = new System.Drawing.Point(245, 20);
            this.opt3.Name = "opt3";
            this.opt3.Size = new System.Drawing.Size(69, 24);
            this.opt3.TabIndex = 26;
            this.opt3.TabStop = true;
            this.opt3.Text = "1-1/4\"";
            this.opt3.UseVisualStyleBackColor = true;
            this.opt3.CheckedChanged += new System.EventHandler(this.opt_CheckedChanged);
            // 
            // opt2
            // 
            this.opt2.AutoSize = true;
            this.opt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opt2.Location = new System.Drawing.Point(144, 20);
            this.opt2.Name = "opt2";
            this.opt2.Size = new System.Drawing.Size(55, 24);
            this.opt2.TabIndex = 1;
            this.opt2.TabStop = true;
            this.opt2.Text = "5/8\"";
            this.opt2.UseVisualStyleBackColor = true;
            this.opt2.CheckedChanged += new System.EventHandler(this.opt_CheckedChanged);
            // 
            // opt1
            // 
            this.opt1.AutoSize = true;
            this.opt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opt1.Location = new System.Drawing.Point(56, 20);
            this.opt1.Name = "opt1";
            this.opt1.Size = new System.Drawing.Size(42, 24);
            this.opt1.TabIndex = 0;
            this.opt1.TabStop = true;
            this.opt1.Text = "0\"";
            this.opt1.UseVisualStyleBackColor = true;
            this.opt1.CheckedChanged += new System.EventHandler(this.opt_CheckedChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(323, 592);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 20);
            this.label12.TabIndex = 26;
            this.label12.Text = "Height:";
            // 
            // txtHeight
            // 
            this.txtHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHeight.Location = new System.Drawing.Point(409, 589);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.ReadOnly = true;
            this.txtHeight.Size = new System.Drawing.Size(109, 26);
            this.txtHeight.TabIndex = 27;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(64, 589);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(90, 20);
            this.label13.TabIndex = 28;
            this.label13.Text = "B:  Width = ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(65, 629);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(82, 20);
            this.label14.TabIndex = 29;
            this.label14.Text = "C: Width =";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(65, 673);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(87, 20);
            this.label15.TabIndex = 30;
            this.label15.Text = "D: Width = ";
            // 
            // txtResultB
            // 
            this.txtResultB.BackColor = System.Drawing.SystemColors.Control;
            this.txtResultB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultB.Location = new System.Drawing.Point(160, 588);
            this.txtResultB.Name = "txtResultB";
            this.txtResultB.Size = new System.Drawing.Size(127, 26);
            this.txtResultB.TabIndex = 31;
            // 
            // txtResultC
            // 
            this.txtResultC.BackColor = System.Drawing.SystemColors.Control;
            this.txtResultC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultC.Location = new System.Drawing.Point(160, 627);
            this.txtResultC.Name = "txtResultC";
            this.txtResultC.Size = new System.Drawing.Size(127, 26);
            this.txtResultC.TabIndex = 32;
            // 
            // txtResultD
            // 
            this.txtResultD.BackColor = System.Drawing.SystemColors.Control;
            this.txtResultD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultD.Location = new System.Drawing.Point(160, 672);
            this.txtResultD.Name = "txtResultD";
            this.txtResultD.Size = new System.Drawing.Size(127, 26);
            this.txtResultD.TabIndex = 33;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(322, 637);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(68, 20);
            this.label16.TabIndex = 34;
            this.label16.Text = "Height : ";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(323, 677);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(68, 20);
            this.label17.TabIndex = 35;
            this.label17.Text = "Height : ";
            // 
            // txtHeightOne
            // 
            this.txtHeightOne.BackColor = System.Drawing.SystemColors.Control;
            this.txtHeightOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHeightOne.Location = new System.Drawing.Point(409, 632);
            this.txtHeightOne.Name = "txtHeightOne";
            this.txtHeightOne.Size = new System.Drawing.Size(110, 26);
            this.txtHeightOne.TabIndex = 36;
            // 
            // txtHeightTwo
            // 
            this.txtHeightTwo.BackColor = System.Drawing.SystemColors.Control;
            this.txtHeightTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHeightTwo.Location = new System.Drawing.Point(409, 673);
            this.txtHeightTwo.Name = "txtHeightTwo";
            this.txtHeightTwo.Size = new System.Drawing.Size(109, 26);
            this.txtHeightTwo.TabIndex = 37;
            // 
            // lblWH
            // 
            this.lblWH.AutoSize = true;
            this.lblWH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWH.Location = new System.Drawing.Point(65, 542);
            this.lblWH.Name = "lblWH";
            this.lblWH.Size = new System.Drawing.Size(124, 20);
            this.lblWH.TabIndex = 38;
            this.lblWH.Text = "Window Height :";
            // 
            // txtWH
            // 
            this.txtWH.BackColor = System.Drawing.SystemColors.Window;
            this.txtWH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWH.Location = new System.Drawing.Point(190, 540);
            this.txtWH.Name = "txtWH";
            this.txtWH.Size = new System.Drawing.Size(130, 26);
            this.txtWH.TabIndex = 39;
            this.txtWH.TextChanged += new System.EventHandler(this.txtWH_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowCalculator.Properties.Resources.draft;
            this.pictureBox1.Location = new System.Drawing.Point(88, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(441, 228);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnChart
            // 
            this.btnChart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChart.Location = new System.Drawing.Point(493, 539);
            this.btnChart.Name = "btnChart";
            this.btnChart.Size = new System.Drawing.Size(105, 29);
            this.btnChart.TabIndex = 40;
            this.btnChart.Text = "Open Chart =>";
            this.btnChart.UseVisualStyleBackColor = true;
            this.btnChart.Click += new System.EventHandler(this.btnChart_Click);
            // 
            // prtDoc
            // 
            this.prtDoc.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.prtDoc_PrintPage);
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(362, 539);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(111, 29);
            this.btnPrint.TabIndex = 41;
            this.btnPrint.Text = "Print Result";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // prtDialog
            // 
            this.prtDialog.UseEXDialog = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 721);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnChart);
            this.Controls.Add(this.txtWH);
            this.Controls.Add(this.lblWH);
            this.Controls.Add(this.txtHeightTwo);
            this.Controls.Add(this.txtHeightOne);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtResultD);
            this.Controls.Add(this.txtResultC);
            this.Controls.Add(this.txtResultB);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.groupBrickmould);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.vf);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.ve);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.vh);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.vr);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.vq);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.vp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.vo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.vd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.vc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.vb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.va);
            this.Controls.Add(this.pictureBox1);
            this.KeyPreview = true;
            this.MaximumSize = new System.Drawing.Size(640, 760);
            this.MinimumSize = new System.Drawing.Size(640, 760);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBrickmould.ResumeLayout(false);
            this.groupBrickmould.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox va;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox vb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox vc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox vd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox vo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox vp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox vq;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox vr;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox vh;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox ve;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox vf;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.RadioButton optRetrofit;
        private System.Windows.Forms.RadioButton optBrickmould;
        private System.Windows.Forms.GroupBox groupBrickmould;
        private System.Windows.Forms.RadioButton opt5;
        private System.Windows.Forms.RadioButton opt4;
        private System.Windows.Forms.RadioButton opt3;
        private System.Windows.Forms.RadioButton opt2;
        private System.Windows.Forms.RadioButton opt1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtResultD;
        private System.Windows.Forms.TextBox txtResultC;
        private System.Windows.Forms.TextBox txtResultB;
        private System.Windows.Forms.TextBox txtHeightTwo;
        private System.Windows.Forms.TextBox txtHeightOne;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtWH;
        private System.Windows.Forms.Label lblWH;
        private System.Windows.Forms.Button btnChart;
        private System.Drawing.Printing.PrintDocument prtDoc;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.PrintDialog prtDialog;
    }
}

