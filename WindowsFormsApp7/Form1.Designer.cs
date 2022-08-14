
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    partial class Form1
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
        /// 
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_Start = new System.Windows.Forms.Button();
            this.txt_Database = new System.Windows.Forms.TextBox();
            this.btn_OpenFile = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.axAcroPDF_2D_Inst = new AxAcroPDFLib.AxAcroPDF();
            this.txt_2D_Inst_Layout = new System.Windows.Forms.TextBox();
            this.btn_load_Layout_2D = new System.Windows.Forms.Button();
            this.btn_2D_Update_Status = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.axAcroPDF_3A_Inst = new AxAcroPDFLib.AxAcroPDF();
            this.txt_3A_Inst_Layout = new System.Windows.Forms.TextBox();
            this.btn_load_Layout_3A = new System.Windows.Forms.Button();
            this.btn_3A_Update_Status = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.axAcroPDF_2C_Inst = new AxAcroPDFLib.AxAcroPDF();
            this.txt_2C_Inst_Layout = new System.Windows.Forms.TextBox();
            this.btn_load_Layout_2C_Click = new System.Windows.Forms.Button();
            this.btn_2C_Update_Status = new System.Windows.Forms.Button();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.axAcroPDF_2B_Inst = new AxAcroPDFLib.AxAcroPDF();
            this.txt_2B_Inst_Layout = new System.Windows.Forms.TextBox();
            this.btn_load_Layout_2B_Click = new System.Windows.Forms.Button();
            this.btn_2B_Update_Status = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chx_Zone_No_Equipment = new System.Windows.Forms.CheckBox();
            this.txt_MC_3th = new System.Windows.Forms.TextBox();
            this.txt_MC_2rd = new System.Windows.Forms.TextBox();
            this.txt_MC_1st = new System.Windows.Forms.TextBox();
            this.chx_MC_3th = new System.Windows.Forms.CheckBox();
            this.chx_MC_2nd = new System.Windows.Forms.CheckBox();
            this.chx_MC_1st = new System.Windows.Forms.CheckBox();
            this.chx_Zone_Termination_Done = new System.Windows.Forms.CheckBox();
            this.chx_Zone_Tray_Not_Done = new System.Windows.Forms.CheckBox();
            this.chx_Zone_Cable_Ready = new System.Windows.Forms.CheckBox();
            this.chx_Zone_Pulled = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btn_Close_App = new System.Windows.Forms.Button();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog3 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog4 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog5 = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF_2D_Inst)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF_3A_Inst)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF_2C_Inst)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF_2B_Inst)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(15, 111);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1833, 1019);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_Start);
            this.tabPage1.Controls.Add(this.txt_Database);
            this.tabPage1.Controls.Add(this.btn_OpenFile);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1825, 990);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "SETTING";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_Start
            // 
            this.btn_Start.BackColor = System.Drawing.SystemColors.Info;
            this.btn_Start.Location = new System.Drawing.Point(7, 105);
            this.btn_Start.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(184, 46);
            this.btn_Start.TabIndex = 6;
            this.btn_Start.Text = "Load DataBase";
            this.btn_Start.UseVisualStyleBackColor = false;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // txt_Database
            // 
            this.txt_Database.Location = new System.Drawing.Point(225, 34);
            this.txt_Database.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Database.Name = "txt_Database";
            this.txt_Database.Size = new System.Drawing.Size(687, 22);
            this.txt_Database.TabIndex = 6;
            // 
            // btn_OpenFile
            // 
            this.btn_OpenFile.BackColor = System.Drawing.SystemColors.Info;
            this.btn_OpenFile.Location = new System.Drawing.Point(7, 23);
            this.btn_OpenFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_OpenFile.Name = "btn_OpenFile";
            this.btn_OpenFile.Size = new System.Drawing.Size(184, 47);
            this.btn_OpenFile.TabIndex = 5;
            this.btn_OpenFile.Text = "Open DataBase";
            this.btn_OpenFile.UseVisualStyleBackColor = false;
            this.btn_OpenFile.Click += new System.EventHandler(this.btn_OpenFile_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.axAcroPDF_2D_Inst);
            this.tabPage2.Controls.Add(this.txt_2D_Inst_Layout);
            this.tabPage2.Controls.Add(this.btn_load_Layout_2D);
            this.tabPage2.Controls.Add(this.btn_2D_Update_Status);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(1825, 990);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "ZONE 2D";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // axAcroPDF_2D_Inst
            // 
            this.axAcroPDF_2D_Inst.Enabled = true;
            this.axAcroPDF_2D_Inst.Location = new System.Drawing.Point(12, 45);
            this.axAcroPDF_2D_Inst.Margin = new System.Windows.Forms.Padding(4);
            this.axAcroPDF_2D_Inst.Name = "axAcroPDF_2D_Inst";
            this.axAcroPDF_2D_Inst.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axAcroPDF_2D_Inst.OcxState")));
            this.axAcroPDF_2D_Inst.Size = new System.Drawing.Size(1809, 750);
            this.axAcroPDF_2D_Inst.TabIndex = 2;
            // 
            // txt_2D_Inst_Layout
            // 
            this.txt_2D_Inst_Layout.Location = new System.Drawing.Point(291, 10);
            this.txt_2D_Inst_Layout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_2D_Inst_Layout.Name = "txt_2D_Inst_Layout";
            this.txt_2D_Inst_Layout.Size = new System.Drawing.Size(1310, 22);
            this.txt_2D_Inst_Layout.TabIndex = 7;
            // 
            // btn_load_Layout_2D
            // 
            this.btn_load_Layout_2D.BackColor = System.Drawing.SystemColors.Info;
            this.btn_load_Layout_2D.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_load_Layout_2D.Location = new System.Drawing.Point(55, 7);
            this.btn_load_Layout_2D.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_load_Layout_2D.Name = "btn_load_Layout_2D";
            this.btn_load_Layout_2D.Size = new System.Drawing.Size(184, 30);
            this.btn_load_Layout_2D.TabIndex = 8;
            this.btn_load_Layout_2D.Text = "Open Layout 2D";
            this.btn_load_Layout_2D.UseVisualStyleBackColor = false;
            this.btn_load_Layout_2D.Click += new System.EventHandler(this.btn_load_Layout_2D_Click);
            // 
            // btn_2D_Update_Status
            // 
            this.btn_2D_Update_Status.BackColor = System.Drawing.SystemColors.Info;
            this.btn_2D_Update_Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_2D_Update_Status.Location = new System.Drawing.Point(1607, 5);
            this.btn_2D_Update_Status.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_2D_Update_Status.Name = "btn_2D_Update_Status";
            this.btn_2D_Update_Status.Size = new System.Drawing.Size(184, 30);
            this.btn_2D_Update_Status.TabIndex = 16;
            this.btn_2D_Update_Status.Text = "Update Status";
            this.btn_2D_Update_Status.UseVisualStyleBackColor = false;
            this.btn_2D_Update_Status.Click += new System.EventHandler(this.btn_2D_Update_Status_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.axAcroPDF_3A_Inst);
            this.tabPage3.Controls.Add(this.txt_3A_Inst_Layout);
            this.tabPage3.Controls.Add(this.btn_load_Layout_3A);
            this.tabPage3.Controls.Add(this.btn_3A_Update_Status);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage3.Size = new System.Drawing.Size(1825, 990);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "ZONE 3A";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // axAcroPDF_3A_Inst
            // 
            this.axAcroPDF_3A_Inst.Enabled = true;
            this.axAcroPDF_3A_Inst.Location = new System.Drawing.Point(7, 41);
            this.axAcroPDF_3A_Inst.Margin = new System.Windows.Forms.Padding(4);
            this.axAcroPDF_3A_Inst.Name = "axAcroPDF_3A_Inst";
            this.axAcroPDF_3A_Inst.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axAcroPDF_3A_Inst.OcxState")));
            this.axAcroPDF_3A_Inst.Size = new System.Drawing.Size(1810, 750);
            this.axAcroPDF_3A_Inst.TabIndex = 20;
            // 
            // txt_3A_Inst_Layout
            // 
            this.txt_3A_Inst_Layout.Location = new System.Drawing.Point(313, 9);
            this.txt_3A_Inst_Layout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_3A_Inst_Layout.Name = "txt_3A_Inst_Layout";
            this.txt_3A_Inst_Layout.Size = new System.Drawing.Size(1177, 22);
            this.txt_3A_Inst_Layout.TabIndex = 17;
            // 
            // btn_load_Layout_3A
            // 
            this.btn_load_Layout_3A.BackColor = System.Drawing.SystemColors.Info;
            this.btn_load_Layout_3A.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_load_Layout_3A.Location = new System.Drawing.Point(77, 6);
            this.btn_load_Layout_3A.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_load_Layout_3A.Name = "btn_load_Layout_3A";
            this.btn_load_Layout_3A.Size = new System.Drawing.Size(184, 30);
            this.btn_load_Layout_3A.TabIndex = 18;
            this.btn_load_Layout_3A.Text = "Open Layout 3A";
            this.btn_load_Layout_3A.UseVisualStyleBackColor = false;
            this.btn_load_Layout_3A.Click += new System.EventHandler(this.btn_load_Layout_3A_Click);
            // 
            // btn_3A_Update_Status
            // 
            this.btn_3A_Update_Status.BackColor = System.Drawing.SystemColors.Info;
            this.btn_3A_Update_Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_3A_Update_Status.Location = new System.Drawing.Point(1544, 6);
            this.btn_3A_Update_Status.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_3A_Update_Status.Name = "btn_3A_Update_Status";
            this.btn_3A_Update_Status.Size = new System.Drawing.Size(184, 30);
            this.btn_3A_Update_Status.TabIndex = 19;
            this.btn_3A_Update_Status.Text = "Update Status";
            this.btn_3A_Update_Status.UseVisualStyleBackColor = false;
            this.btn_3A_Update_Status.Click += new System.EventHandler(this.btn_3A_Update_Status_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.axAcroPDF_2C_Inst);
            this.tabPage4.Controls.Add(this.txt_2C_Inst_Layout);
            this.tabPage4.Controls.Add(this.btn_load_Layout_2C_Click);
            this.tabPage4.Controls.Add(this.btn_2C_Update_Status);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage4.Size = new System.Drawing.Size(1825, 990);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "ZONE 2C";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // axAcroPDF_2C_Inst
            // 
            this.axAcroPDF_2C_Inst.Enabled = true;
            this.axAcroPDF_2C_Inst.Location = new System.Drawing.Point(7, 42);
            this.axAcroPDF_2C_Inst.Margin = new System.Windows.Forms.Padding(4);
            this.axAcroPDF_2C_Inst.Name = "axAcroPDF_2C_Inst";
            this.axAcroPDF_2C_Inst.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axAcroPDF_2C_Inst.OcxState")));
            this.axAcroPDF_2C_Inst.Size = new System.Drawing.Size(1814, 750);
            this.axAcroPDF_2C_Inst.TabIndex = 17;
            // 
            // txt_2C_Inst_Layout
            // 
            this.txt_2C_Inst_Layout.Location = new System.Drawing.Point(284, 8);
            this.txt_2C_Inst_Layout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_2C_Inst_Layout.Name = "txt_2C_Inst_Layout";
            this.txt_2C_Inst_Layout.Size = new System.Drawing.Size(1177, 22);
            this.txt_2C_Inst_Layout.TabIndex = 18;
            // 
            // btn_load_Layout_2C_Click
            // 
            this.btn_load_Layout_2C_Click.BackColor = System.Drawing.SystemColors.Info;
            this.btn_load_Layout_2C_Click.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_load_Layout_2C_Click.Location = new System.Drawing.Point(48, 4);
            this.btn_load_Layout_2C_Click.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_load_Layout_2C_Click.Name = "btn_load_Layout_2C_Click";
            this.btn_load_Layout_2C_Click.Size = new System.Drawing.Size(184, 30);
            this.btn_load_Layout_2C_Click.TabIndex = 19;
            this.btn_load_Layout_2C_Click.Text = "Open Layout 2C";
            this.btn_load_Layout_2C_Click.UseVisualStyleBackColor = false;
            this.btn_load_Layout_2C_Click.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_2C_Update_Status
            // 
            this.btn_2C_Update_Status.BackColor = System.Drawing.SystemColors.Info;
            this.btn_2C_Update_Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_2C_Update_Status.Location = new System.Drawing.Point(1515, 4);
            this.btn_2C_Update_Status.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_2C_Update_Status.Name = "btn_2C_Update_Status";
            this.btn_2C_Update_Status.Size = new System.Drawing.Size(184, 30);
            this.btn_2C_Update_Status.TabIndex = 20;
            this.btn_2C_Update_Status.Text = "Update Status";
            this.btn_2C_Update_Status.UseVisualStyleBackColor = false;
            this.btn_2C_Update_Status.Click += new System.EventHandler(this.btn_2C_Update_Status_Click);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.axAcroPDF_2B_Inst);
            this.tabPage5.Controls.Add(this.txt_2B_Inst_Layout);
            this.tabPage5.Controls.Add(this.btn_load_Layout_2B_Click);
            this.tabPage5.Controls.Add(this.btn_2B_Update_Status);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage5.Size = new System.Drawing.Size(1825, 990);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "ZONE 2B";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // axAcroPDF_2B_Inst
            // 
            this.axAcroPDF_2B_Inst.Enabled = true;
            this.axAcroPDF_2B_Inst.Location = new System.Drawing.Point(7, 44);
            this.axAcroPDF_2B_Inst.Margin = new System.Windows.Forms.Padding(4);
            this.axAcroPDF_2B_Inst.Name = "axAcroPDF_2B_Inst";
            this.axAcroPDF_2B_Inst.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axAcroPDF_2B_Inst.OcxState")));
            this.axAcroPDF_2B_Inst.Size = new System.Drawing.Size(1810, 750);
            this.axAcroPDF_2B_Inst.TabIndex = 21;
            // 
            // txt_2B_Inst_Layout
            // 
            this.txt_2B_Inst_Layout.Location = new System.Drawing.Point(286, 10);
            this.txt_2B_Inst_Layout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_2B_Inst_Layout.Name = "txt_2B_Inst_Layout";
            this.txt_2B_Inst_Layout.Size = new System.Drawing.Size(1177, 22);
            this.txt_2B_Inst_Layout.TabIndex = 22;
            // 
            // btn_load_Layout_2B_Click
            // 
            this.btn_load_Layout_2B_Click.BackColor = System.Drawing.SystemColors.Info;
            this.btn_load_Layout_2B_Click.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_load_Layout_2B_Click.Location = new System.Drawing.Point(50, 6);
            this.btn_load_Layout_2B_Click.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_load_Layout_2B_Click.Name = "btn_load_Layout_2B_Click";
            this.btn_load_Layout_2B_Click.Size = new System.Drawing.Size(184, 30);
            this.btn_load_Layout_2B_Click.TabIndex = 23;
            this.btn_load_Layout_2B_Click.Text = "Open Layout 2B";
            this.btn_load_Layout_2B_Click.UseVisualStyleBackColor = false;
            this.btn_load_Layout_2B_Click.Click += new System.EventHandler(this.btn_load_Layout_2B_Click_Click);
            // 
            // btn_2B_Update_Status
            // 
            this.btn_2B_Update_Status.BackColor = System.Drawing.SystemColors.Info;
            this.btn_2B_Update_Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_2B_Update_Status.Location = new System.Drawing.Point(1517, 6);
            this.btn_2B_Update_Status.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_2B_Update_Status.Name = "btn_2B_Update_Status";
            this.btn_2B_Update_Status.Size = new System.Drawing.Size(184, 30);
            this.btn_2B_Update_Status.TabIndex = 24;
            this.btn_2B_Update_Status.Text = "Update Status";
            this.btn_2B_Update_Status.UseVisualStyleBackColor = false;
            this.btn_2B_Update_Status.Click += new System.EventHandler(this.btn_2B_Update_Status_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.Controls.Add(this.chx_Zone_No_Equipment);
            this.groupBox1.Controls.Add(this.txt_MC_3th);
            this.groupBox1.Controls.Add(this.txt_MC_2rd);
            this.groupBox1.Controls.Add(this.txt_MC_1st);
            this.groupBox1.Controls.Add(this.chx_MC_3th);
            this.groupBox1.Controls.Add(this.chx_MC_2nd);
            this.groupBox1.Controls.Add(this.chx_MC_1st);
            this.groupBox1.Controls.Add(this.chx_Zone_Termination_Done);
            this.groupBox1.Controls.Add(this.chx_Zone_Tray_Not_Done);
            this.groupBox1.Controls.Add(this.chx_Zone_Cable_Ready);
            this.groupBox1.Controls.Add(this.chx_Zone_Pulled);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(15, 62);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1828, 46);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Setting Display Status";
            // 
            // chx_Zone_No_Equipment
            // 
            this.chx_Zone_No_Equipment.AutoSize = true;
            this.chx_Zone_No_Equipment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chx_Zone_No_Equipment.ForeColor = System.Drawing.Color.DarkBlue;
            this.chx_Zone_No_Equipment.Location = new System.Drawing.Point(693, 10);
            this.chx_Zone_No_Equipment.Margin = new System.Windows.Forms.Padding(4);
            this.chx_Zone_No_Equipment.Name = "chx_Zone_No_Equipment";
            this.chx_Zone_No_Equipment.Size = new System.Drawing.Size(136, 24);
            this.chx_Zone_No_Equipment.TabIndex = 27;
            this.chx_Zone_No_Equipment.Text = "No Equipment";
            this.chx_Zone_No_Equipment.UseVisualStyleBackColor = true;
            // 
            // txt_MC_3th
            // 
            this.txt_MC_3th.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MC_3th.Location = new System.Drawing.Point(1609, 7);
            this.txt_MC_3th.Margin = new System.Windows.Forms.Padding(4);
            this.txt_MC_3th.Name = "txt_MC_3th";
            this.txt_MC_3th.Size = new System.Drawing.Size(73, 26);
            this.txt_MC_3th.TabIndex = 26;
            // 
            // txt_MC_2rd
            // 
            this.txt_MC_2rd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MC_2rd.Location = new System.Drawing.Point(1407, 7);
            this.txt_MC_2rd.Margin = new System.Windows.Forms.Padding(4);
            this.txt_MC_2rd.Name = "txt_MC_2rd";
            this.txt_MC_2rd.Size = new System.Drawing.Size(73, 26);
            this.txt_MC_2rd.TabIndex = 25;
            // 
            // txt_MC_1st
            // 
            this.txt_MC_1st.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MC_1st.Location = new System.Drawing.Point(1197, 7);
            this.txt_MC_1st.Margin = new System.Windows.Forms.Padding(4);
            this.txt_MC_1st.Name = "txt_MC_1st";
            this.txt_MC_1st.Size = new System.Drawing.Size(73, 26);
            this.txt_MC_1st.TabIndex = 24;
            // 
            // chx_MC_3th
            // 
            this.chx_MC_3th.AutoSize = true;
            this.chx_MC_3th.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chx_MC_3th.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.chx_MC_3th.Location = new System.Drawing.Point(1500, 10);
            this.chx_MC_3th.Margin = new System.Windows.Forms.Padding(4);
            this.chx_MC_3th.Name = "chx_MC_3th";
            this.chx_MC_3th.Size = new System.Drawing.Size(86, 24);
            this.chx_MC_3th.TabIndex = 23;
            this.chx_MC_3th.Text = "MC-3th";
            this.chx_MC_3th.UseVisualStyleBackColor = true;
            // 
            // chx_MC_2nd
            // 
            this.chx_MC_2nd.AutoSize = true;
            this.chx_MC_2nd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chx_MC_2nd.ForeColor = System.Drawing.Color.DeepPink;
            this.chx_MC_2nd.Location = new System.Drawing.Point(1291, 10);
            this.chx_MC_2nd.Margin = new System.Windows.Forms.Padding(4);
            this.chx_MC_2nd.Name = "chx_MC_2nd";
            this.chx_MC_2nd.Size = new System.Drawing.Size(90, 24);
            this.chx_MC_2nd.TabIndex = 22;
            this.chx_MC_2nd.Text = "MC-2nd";
            this.chx_MC_2nd.UseVisualStyleBackColor = true;
            // 
            // chx_MC_1st
            // 
            this.chx_MC_1st.AutoSize = true;
            this.chx_MC_1st.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chx_MC_1st.ForeColor = System.Drawing.Color.DarkMagenta;
            this.chx_MC_1st.Location = new System.Drawing.Point(1088, 10);
            this.chx_MC_1st.Margin = new System.Windows.Forms.Padding(4);
            this.chx_MC_1st.Name = "chx_MC_1st";
            this.chx_MC_1st.Size = new System.Drawing.Size(86, 24);
            this.chx_MC_1st.TabIndex = 21;
            this.chx_MC_1st.Text = "MC-1st";
            this.chx_MC_1st.UseVisualStyleBackColor = true;
            // 
            // chx_Zone_Termination_Done
            // 
            this.chx_Zone_Termination_Done.AutoSize = true;
            this.chx_Zone_Termination_Done.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chx_Zone_Termination_Done.ForeColor = System.Drawing.Color.YellowGreen;
            this.chx_Zone_Termination_Done.Location = new System.Drawing.Point(891, 10);
            this.chx_Zone_Termination_Done.Margin = new System.Windows.Forms.Padding(4);
            this.chx_Zone_Termination_Done.Name = "chx_Zone_Termination_Done";
            this.chx_Zone_Termination_Done.Size = new System.Drawing.Size(164, 24);
            this.chx_Zone_Termination_Done.TabIndex = 15;
            this.chx_Zone_Termination_Done.Text = "Termination Done";
            this.chx_Zone_Termination_Done.UseVisualStyleBackColor = true;
            // 
            // chx_Zone_Tray_Not_Done
            // 
            this.chx_Zone_Tray_Not_Done.AutoSize = true;
            this.chx_Zone_Tray_Not_Done.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chx_Zone_Tray_Not_Done.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.chx_Zone_Tray_Not_Done.Location = new System.Drawing.Point(528, 10);
            this.chx_Zone_Tray_Not_Done.Margin = new System.Windows.Forms.Padding(4);
            this.chx_Zone_Tray_Not_Done.Name = "chx_Zone_Tray_Not_Done";
            this.chx_Zone_Tray_Not_Done.Size = new System.Drawing.Size(140, 24);
            this.chx_Zone_Tray_Not_Done.TabIndex = 14;
            this.chx_Zone_Tray_Not_Done.Text = "Tray Not Done";
            this.chx_Zone_Tray_Not_Done.UseVisualStyleBackColor = true;
            // 
            // chx_Zone_Cable_Ready
            // 
            this.chx_Zone_Cable_Ready.AutoSize = true;
            this.chx_Zone_Cable_Ready.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chx_Zone_Cable_Ready.ForeColor = System.Drawing.Color.Yellow;
            this.chx_Zone_Cable_Ready.Location = new System.Drawing.Point(367, 10);
            this.chx_Zone_Cable_Ready.Margin = new System.Windows.Forms.Padding(4);
            this.chx_Zone_Cable_Ready.Name = "chx_Zone_Cable_Ready";
            this.chx_Zone_Cable_Ready.Size = new System.Drawing.Size(126, 24);
            this.chx_Zone_Cable_Ready.TabIndex = 13;
            this.chx_Zone_Cable_Ready.Text = "Cable Ready";
            this.chx_Zone_Cable_Ready.UseVisualStyleBackColor = true;
            // 
            // chx_Zone_Pulled
            // 
            this.chx_Zone_Pulled.AutoSize = true;
            this.chx_Zone_Pulled.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chx_Zone_Pulled.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.chx_Zone_Pulled.Location = new System.Drawing.Point(209, 10);
            this.chx_Zone_Pulled.Margin = new System.Windows.Forms.Padding(4);
            this.chx_Zone_Pulled.Name = "chx_Zone_Pulled";
            this.chx_Zone_Pulled.Size = new System.Drawing.Size(125, 24);
            this.chx_Zone_Pulled.TabIndex = 12;
            this.chx_Zone_Pulled.Text = "Cable Pulled";
            this.chx_Zone_Pulled.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp7.Properties.Resources.TPP_Logo__1_;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(15, -1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(139, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(615, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(517, 40);
            this.label1.TabIndex = 5;
            this.label1.Text = "OLEFINS INSTRUMENT AUTO STATUS";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "\"Excel Files|*.xls;*.xlsx;*.xlsm\";";
            // 
            // btn_Close_App
            // 
            this.btn_Close_App.BackColor = System.Drawing.SystemColors.Info;
            this.btn_Close_App.Location = new System.Drawing.Point(1719, 11);
            this.btn_Close_App.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Close_App.Name = "btn_Close_App";
            this.btn_Close_App.Size = new System.Drawing.Size(112, 34);
            this.btn_Close_App.TabIndex = 7;
            this.btn_Close_App.Text = "CLOSE";
            this.btn_Close_App.UseVisualStyleBackColor = false;
            this.btn_Close_App.Click += new System.EventHandler(this.button3_Click);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            this.openFileDialog2.Filter = "\"pdf files (*.pdf) |*.pdf;\"";
            // 
            // openFileDialog3
            // 
            this.openFileDialog3.FileName = "openFileDialog3";
            this.openFileDialog3.Filter = "\"pdf files (*.pdf) |*.pdf;\"";
            // 
            // openFileDialog4
            // 
            this.openFileDialog4.FileName = "openFileDialog4";
            this.openFileDialog4.Filter = "\"pdf files (*.pdf) |*.pdf;\"";
            // 
            // openFileDialog5
            // 
            this.openFileDialog5.FileName = "openFileDialog5";
            this.openFileDialog5.Filter = "\"pdf files (*.pdf) |*.pdf;\"";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1845, 1055);
            this.Controls.Add(this.btn_Close_App);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Instrument Auto Status";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF_2D_Inst)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF_3A_Inst)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF_2C_Inst)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF_2B_Inst)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private PictureBox pictureBox1;
        private Label label1;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private TextBox txt_Database;
        private Button btn_OpenFile;
        private OpenFileDialog openFileDialog1;
        private Button btn_Start;
        private Button btn_Close_App;
        private GroupBox groupBox1;
        private Button btn_load_Layout_2D;
        private TextBox txt_2D_Inst_Layout;
        private OpenFileDialog openFileDialog2;
        private Button btn_2D_Update_Status;
        private CheckBox chx_Zone_Termination_Done;
        private CheckBox chx_Zone_Tray_Not_Done;
        private CheckBox chx_Zone_Cable_Ready;
        private CheckBox chx_Zone_Pulled;
        private TextBox txt_MC_3th;
        private TextBox txt_MC_2rd;
        private TextBox txt_MC_1st;
        private CheckBox chx_MC_3th;
        private CheckBox chx_MC_2nd;
        private CheckBox chx_MC_1st;
        private AxAcroPDFLib.AxAcroPDF axAcroPDF_2C_Inst;
        private TextBox txt_2C_Inst_Layout;
        private Button btn_load_Layout_2C_Click;
        private Button btn_2C_Update_Status;
        private OpenFileDialog openFileDialog3;
        private AxAcroPDFLib.AxAcroPDF axAcroPDF_2D_Inst;
        private AxAcroPDFLib.AxAcroPDF axAcroPDF_3A_Inst;
        private TextBox txt_3A_Inst_Layout;
        private Button btn_load_Layout_3A;
        private Button btn_3A_Update_Status;
        private OpenFileDialog openFileDialog4;
        private CheckBox chx_Zone_No_Equipment;
        private AxAcroPDFLib.AxAcroPDF axAcroPDF_2B_Inst;
        private TextBox txt_2B_Inst_Layout;
        private Button btn_load_Layout_2B_Click;
        private Button btn_2B_Update_Status;
        private OpenFileDialog openFileDialog5;
    }
}

