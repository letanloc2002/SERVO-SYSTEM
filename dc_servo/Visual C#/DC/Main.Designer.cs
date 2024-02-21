﻿namespace DC
{
    partial class Main
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
            this.SerialPort = new System.IO.Ports.SerialPort(this.components);
            this.TimerPort = new System.Windows.Forms.Timer(this.components);
            this.GraphPos = new ZedGraph.ZedGraphControl();
            this.GraphVel = new ZedGraph.ZedGraphControl();
            this.gbConnect = new System.Windows.Forms.GroupBox();
            this.btDisconnect = new System.Windows.Forms.Button();
            this.btConnect = new System.Windows.Forms.Button();
            this.cbBaudRate = new System.Windows.Forms.ComboBox();
            this.cbComName = new System.Windows.Forms.ComboBox();
            this.cbSeclectCom = new System.Windows.Forms.ComboBox();
            this.TimerGraph = new System.Windows.Forms.Timer(this.components);
            this.gbControl = new System.Windows.Forms.GroupBox();
            this.btExit = new System.Windows.Forms.Button();
            this.btScale = new System.Windows.Forms.Button();
            this.btReverse = new System.Windows.Forms.Button();
            this.btPause = new System.Windows.Forms.Button();
            this.btStop = new System.Windows.Forms.Button();
            this.btStart = new System.Windows.Forms.Button();
            this.grbSetVel = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btReSet = new System.Windows.Forms.Button();
            this.txtAcc = new System.Windows.Forms.TextBox();
            this.btSetPoint = new System.Windows.Forms.Button();
            this.txtVelocity = new System.Windows.Forms.TextBox();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.rbtVelocity = new System.Windows.Forms.RadioButton();
            this.rbtPosition = new System.Windows.Forms.RadioButton();
            this.gbCurrent = new System.Windows.Forms.GroupBox();
            this.label31 = new System.Windows.Forms.Label();
            this.txtError = new System.Windows.Forms.TextBox();
            this.label37 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.txtVel = new System.Windows.Forms.TextBox();
            this.txtPos = new System.Windows.Forms.TextBox();
            this.gbPID = new System.Windows.Forms.GroupBox();
            this.txtKdSet = new System.Windows.Forms.TextBox();
            this.txtKiSet = new System.Windows.Forms.TextBox();
            this.txtKpSet = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtKbSet = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtAnphaSet = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gbConnect.SuspendLayout();
            this.gbControl.SuspendLayout();
            this.grbSetVel.SuspendLayout();
            this.gbCurrent.SuspendLayout();
            this.gbPID.SuspendLayout();
            this.SuspendLayout();
            // 
            // SerialPort
            // 
            this.SerialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.SerialPort_DataReceived);
            // 
            // TimerPort
            // 
            this.TimerPort.Enabled = true;
            this.TimerPort.Tick += new System.EventHandler(this.TimerPort_Tick);
            // 
            // GraphPos
            // 
            this.GraphPos.Location = new System.Drawing.Point(1, 5);
            this.GraphPos.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.GraphPos.Name = "GraphPos";
            this.GraphPos.ScrollGrace = 0D;
            this.GraphPos.ScrollMaxX = 0D;
            this.GraphPos.ScrollMaxY = 0D;
            this.GraphPos.ScrollMaxY2 = 0D;
            this.GraphPos.ScrollMinX = 0D;
            this.GraphPos.ScrollMinY = 0D;
            this.GraphPos.ScrollMinY2 = 0D;
            this.GraphPos.Size = new System.Drawing.Size(1229, 418);
            this.GraphPos.TabIndex = 0;
            this.GraphPos.Load += new System.EventHandler(this.GraphPos_Load);
            // 
            // GraphVel
            // 
            this.GraphVel.Location = new System.Drawing.Point(1, 431);
            this.GraphVel.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.GraphVel.Name = "GraphVel";
            this.GraphVel.ScrollGrace = 0D;
            this.GraphVel.ScrollMaxX = 0D;
            this.GraphVel.ScrollMaxY = 0D;
            this.GraphVel.ScrollMaxY2 = 0D;
            this.GraphVel.ScrollMinX = 0D;
            this.GraphVel.ScrollMinY = 0D;
            this.GraphVel.ScrollMinY2 = 0D;
            this.GraphVel.Size = new System.Drawing.Size(1229, 418);
            this.GraphVel.TabIndex = 1;
            // 
            // gbConnect
            // 
            this.gbConnect.Controls.Add(this.btDisconnect);
            this.gbConnect.Controls.Add(this.btConnect);
            this.gbConnect.Controls.Add(this.cbBaudRate);
            this.gbConnect.Controls.Add(this.cbComName);
            this.gbConnect.Controls.Add(this.cbSeclectCom);
            this.gbConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbConnect.Location = new System.Drawing.Point(1251, 15);
            this.gbConnect.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbConnect.Name = "gbConnect";
            this.gbConnect.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbConnect.Size = new System.Drawing.Size(365, 105);
            this.gbConnect.TabIndex = 2;
            this.gbConnect.TabStop = false;
            this.gbConnect.Text = "Disconnect";
            // 
            // btDisconnect
            // 
            this.btDisconnect.Location = new System.Drawing.Point(259, 58);
            this.btDisconnect.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btDisconnect.Name = "btDisconnect";
            this.btDisconnect.Size = new System.Drawing.Size(95, 39);
            this.btDisconnect.TabIndex = 1;
            this.btDisconnect.Text = "Disconnect";
            this.btDisconnect.UseVisualStyleBackColor = true;
            this.btDisconnect.Click += new System.EventHandler(this.btDisconnect_Click);
            // 
            // btConnect
            // 
            this.btConnect.Location = new System.Drawing.Point(173, 58);
            this.btConnect.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btConnect.Name = "btConnect";
            this.btConnect.Size = new System.Drawing.Size(84, 39);
            this.btConnect.TabIndex = 1;
            this.btConnect.Text = "Connect";
            this.btConnect.UseVisualStyleBackColor = true;
            this.btConnect.Click += new System.EventHandler(this.btConnect_Click);
            // 
            // cbBaudRate
            // 
            this.cbBaudRate.FormattingEnabled = true;
            this.cbBaudRate.Location = new System.Drawing.Point(12, 63);
            this.cbBaudRate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbBaudRate.Name = "cbBaudRate";
            this.cbBaudRate.Size = new System.Drawing.Size(76, 25);
            this.cbBaudRate.TabIndex = 0;
            // 
            // cbComName
            // 
            this.cbComName.FormattingEnabled = true;
            this.cbComName.Location = new System.Drawing.Point(97, 63);
            this.cbComName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbComName.Name = "cbComName";
            this.cbComName.Size = new System.Drawing.Size(72, 25);
            this.cbComName.TabIndex = 0;
            // 
            // cbSeclectCom
            // 
            this.cbSeclectCom.FormattingEnabled = true;
            this.cbSeclectCom.Location = new System.Drawing.Point(12, 22);
            this.cbSeclectCom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbSeclectCom.Name = "cbSeclectCom";
            this.cbSeclectCom.Size = new System.Drawing.Size(323, 25);
            this.cbSeclectCom.TabIndex = 0;
            this.cbSeclectCom.SelectedIndexChanged += new System.EventHandler(this.cbSeclectCom_SelectedIndexChanged);
            // 
            // TimerGraph
            // 
            this.TimerGraph.Tick += new System.EventHandler(this.TimerGraph_Tick);
            // 
            // gbControl
            // 
            this.gbControl.Controls.Add(this.btExit);
            this.gbControl.Controls.Add(this.btScale);
            this.gbControl.Controls.Add(this.btReverse);
            this.gbControl.Controls.Add(this.btPause);
            this.gbControl.Controls.Add(this.btStop);
            this.gbControl.Controls.Add(this.btStart);
            this.gbControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbControl.Location = new System.Drawing.Point(1253, 666);
            this.gbControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbControl.Name = "gbControl";
            this.gbControl.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbControl.Size = new System.Drawing.Size(360, 183);
            this.gbControl.TabIndex = 3;
            this.gbControl.TabStop = false;
            this.gbControl.Text = "Control";
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(207, 130);
            this.btExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(112, 42);
            this.btExit.TabIndex = 0;
            this.btExit.Text = "Exit";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // btScale
            // 
            this.btScale.Location = new System.Drawing.Point(25, 130);
            this.btScale.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btScale.Name = "btScale";
            this.btScale.Size = new System.Drawing.Size(112, 42);
            this.btScale.TabIndex = 0;
            this.btScale.Text = "Sroll";
            this.btScale.UseVisualStyleBackColor = true;
            this.btScale.Click += new System.EventHandler(this.btScale_Click);
            // 
            // btReverse
            // 
            this.btReverse.Location = new System.Drawing.Point(207, 82);
            this.btReverse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btReverse.Name = "btReverse";
            this.btReverse.Size = new System.Drawing.Size(112, 42);
            this.btReverse.TabIndex = 0;
            this.btReverse.Text = "Reverse";
            this.btReverse.UseVisualStyleBackColor = true;
            this.btReverse.Click += new System.EventHandler(this.btReverse_Click);
            // 
            // btPause
            // 
            this.btPause.Location = new System.Drawing.Point(207, 34);
            this.btPause.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btPause.Name = "btPause";
            this.btPause.Size = new System.Drawing.Size(112, 42);
            this.btPause.TabIndex = 0;
            this.btPause.Text = "Pause";
            this.btPause.UseVisualStyleBackColor = true;
            this.btPause.Click += new System.EventHandler(this.btPause_Click);
            // 
            // btStop
            // 
            this.btStop.Location = new System.Drawing.Point(25, 82);
            this.btStop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btStop.Name = "btStop";
            this.btStop.Size = new System.Drawing.Size(112, 42);
            this.btStop.TabIndex = 0;
            this.btStop.Text = "Stop";
            this.btStop.UseVisualStyleBackColor = true;
            this.btStop.Click += new System.EventHandler(this.btStop_Click);
            // 
            // btStart
            // 
            this.btStart.Location = new System.Drawing.Point(25, 34);
            this.btStart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(112, 42);
            this.btStart.TabIndex = 0;
            this.btStart.Text = "Start";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // grbSetVel
            // 
            this.grbSetVel.Controls.Add(this.label6);
            this.grbSetVel.Controls.Add(this.label5);
            this.grbSetVel.Controls.Add(this.label4);
            this.grbSetVel.Controls.Add(this.btReSet);
            this.grbSetVel.Controls.Add(this.txtAcc);
            this.grbSetVel.Controls.Add(this.btSetPoint);
            this.grbSetVel.Controls.Add(this.txtVelocity);
            this.grbSetVel.Controls.Add(this.txtPosition);
            this.grbSetVel.Controls.Add(this.label17);
            this.grbSetVel.Controls.Add(this.rbtVelocity);
            this.grbSetVel.Controls.Add(this.rbtPosition);
            this.grbSetVel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grbSetVel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbSetVel.ForeColor = System.Drawing.Color.Black;
            this.grbSetVel.Location = new System.Drawing.Point(1252, 133);
            this.grbSetVel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbSetVel.Name = "grbSetVel";
            this.grbSetVel.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbSetVel.Size = new System.Drawing.Size(363, 148);
            this.grbSetVel.TabIndex = 51;
            this.grbSetVel.TabStop = false;
            this.grbSetVel.Text = "Set point";
            this.grbSetVel.Enter += new System.EventHandler(this.grbSetVel_Enter);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(176, 110);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 20);
            this.label6.TabIndex = 52;
            this.label6.Text = "(RPM)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(175, 69);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 20);
            this.label5.TabIndex = 51;
            this.label5.Text = "(Rad/s^2)";
            this.label5.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(175, 32);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 50;
            this.label4.Text = "(Rnd)";
            // 
            // btReSet
            // 
            this.btReSet.Location = new System.Drawing.Point(251, 96);
            this.btReSet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btReSet.Name = "btReSet";
            this.btReSet.Size = new System.Drawing.Size(100, 37);
            this.btReSet.TabIndex = 49;
            this.btReSet.Text = "Reset";
            this.btReSet.UseVisualStyleBackColor = true;
            this.btReSet.Click += new System.EventHandler(this.btReSet_Click);
            // 
            // txtAcc
            // 
            this.txtAcc.Location = new System.Drawing.Point(79, 65);
            this.txtAcc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAcc.Name = "txtAcc";
            this.txtAcc.Size = new System.Drawing.Size(93, 30);
            this.txtAcc.TabIndex = 48;
            this.txtAcc.Visible = false;
            // 
            // btSetPoint
            // 
            this.btSetPoint.Location = new System.Drawing.Point(251, 25);
            this.btSetPoint.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btSetPoint.Name = "btSetPoint";
            this.btSetPoint.Size = new System.Drawing.Size(100, 37);
            this.btSetPoint.TabIndex = 47;
            this.btSetPoint.Text = "Set";
            this.btSetPoint.UseVisualStyleBackColor = true;
            this.btSetPoint.Click += new System.EventHandler(this.btSetPoint_Click);
            // 
            // txtVelocity
            // 
            this.txtVelocity.Location = new System.Drawing.Point(79, 105);
            this.txtVelocity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtVelocity.Name = "txtVelocity";
            this.txtVelocity.Size = new System.Drawing.Size(93, 30);
            this.txtVelocity.TabIndex = 46;
            // 
            // txtPosition
            // 
            this.txtPosition.Location = new System.Drawing.Point(79, 28);
            this.txtPosition.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(93, 30);
            this.txtPosition.TabIndex = 45;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(24, 70);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(48, 24);
            this.label17.TabIndex = 44;
            this.label17.Text = "Acc.";
            this.label17.Visible = false;
            // 
            // rbtVelocity
            // 
            this.rbtVelocity.AutoSize = true;
            this.rbtVelocity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtVelocity.ForeColor = System.Drawing.Color.Black;
            this.rbtVelocity.Location = new System.Drawing.Point(5, 110);
            this.rbtVelocity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbtVelocity.Name = "rbtVelocity";
            this.rbtVelocity.Size = new System.Drawing.Size(64, 28);
            this.rbtVelocity.TabIndex = 0;
            this.rbtVelocity.Text = "Vel.";
            this.rbtVelocity.UseVisualStyleBackColor = true;
            this.rbtVelocity.CheckedChanged += new System.EventHandler(this.rbtVelocity_CheckedChanged);
            // 
            // rbtPosition
            // 
            this.rbtPosition.AutoSize = true;
            this.rbtPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtPosition.ForeColor = System.Drawing.Color.Black;
            this.rbtPosition.Location = new System.Drawing.Point(5, 30);
            this.rbtPosition.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbtPosition.Name = "rbtPosition";
            this.rbtPosition.Size = new System.Drawing.Size(68, 28);
            this.rbtPosition.TabIndex = 0;
            this.rbtPosition.Text = "Pos.";
            this.rbtPosition.UseVisualStyleBackColor = true;
            this.rbtPosition.CheckedChanged += new System.EventHandler(this.rbtPosition_CheckedChanged);
            // 
            // gbCurrent
            // 
            this.gbCurrent.Controls.Add(this.label31);
            this.gbCurrent.Controls.Add(this.txtError);
            this.gbCurrent.Controls.Add(this.label37);
            this.gbCurrent.Controls.Add(this.label38);
            this.gbCurrent.Controls.Add(this.txtVel);
            this.gbCurrent.Controls.Add(this.txtPos);
            this.gbCurrent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbCurrent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCurrent.ForeColor = System.Drawing.Color.Black;
            this.gbCurrent.Location = new System.Drawing.Point(1252, 482);
            this.gbCurrent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbCurrent.Name = "gbCurrent";
            this.gbCurrent.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbCurrent.Size = new System.Drawing.Size(363, 170);
            this.gbCurrent.TabIndex = 52;
            this.gbCurrent.TabStop = false;
            this.gbCurrent.Text = "Current Values";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.ForeColor = System.Drawing.Color.Black;
            this.label31.Location = new System.Drawing.Point(13, 132);
            this.label31.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(52, 24);
            this.label31.TabIndex = 43;
            this.label31.Text = "Error";
            // 
            // txtError
            // 
            this.txtError.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(175)))));
            this.txtError.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtError.Enabled = false;
            this.txtError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtError.ForeColor = System.Drawing.Color.Black;
            this.txtError.Location = new System.Drawing.Point(96, 130);
            this.txtError.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtError.Name = "txtError";
            this.txtError.Size = new System.Drawing.Size(93, 26);
            this.txtError.TabIndex = 42;
            this.txtError.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.ForeColor = System.Drawing.Color.Black;
            this.label37.Location = new System.Drawing.Point(12, 84);
            this.label37.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(73, 24);
            this.label37.TabIndex = 24;
            this.label37.Text = "V (rpm)";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label38.ForeColor = System.Drawing.Color.Black;
            this.label38.Location = new System.Drawing.Point(9, 41);
            this.label38.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(67, 24);
            this.label38.TabIndex = 23;
            this.label38.Text = "Round";
            this.label38.Click += new System.EventHandler(this.label38_Click);
            // 
            // txtVel
            // 
            this.txtVel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(175)))));
            this.txtVel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVel.Enabled = false;
            this.txtVel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVel.ForeColor = System.Drawing.Color.Black;
            this.txtVel.Location = new System.Drawing.Point(97, 84);
            this.txtVel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtVel.Name = "txtVel";
            this.txtVel.Size = new System.Drawing.Size(93, 26);
            this.txtVel.TabIndex = 0;
            this.txtVel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPos
            // 
            this.txtPos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(175)))));
            this.txtPos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPos.Enabled = false;
            this.txtPos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPos.ForeColor = System.Drawing.Color.Black;
            this.txtPos.Location = new System.Drawing.Point(97, 38);
            this.txtPos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPos.Name = "txtPos";
            this.txtPos.Size = new System.Drawing.Size(93, 26);
            this.txtPos.TabIndex = 0;
            this.txtPos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPos.TextChanged += new System.EventHandler(this.txtPos_TextChanged);
            // 
            // gbPID
            // 
            this.gbPID.Controls.Add(this.txtKdSet);
            this.gbPID.Controls.Add(this.txtKiSet);
            this.gbPID.Controls.Add(this.txtKpSet);
            this.gbPID.Controls.Add(this.label13);
            this.gbPID.Controls.Add(this.txtKbSet);
            this.gbPID.Controls.Add(this.label11);
            this.gbPID.Controls.Add(this.txtAnphaSet);
            this.gbPID.Controls.Add(this.label1);
            this.gbPID.Controls.Add(this.label2);
            this.gbPID.Controls.Add(this.label3);
            this.gbPID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbPID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPID.ForeColor = System.Drawing.Color.Black;
            this.gbPID.Location = new System.Drawing.Point(1253, 292);
            this.gbPID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbPID.Name = "gbPID";
            this.gbPID.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbPID.Size = new System.Drawing.Size(363, 174);
            this.gbPID.TabIndex = 53;
            this.gbPID.TabStop = false;
            this.gbPID.Text = "PID Parameters";
            // 
            // txtKdSet
            // 
            this.txtKdSet.Location = new System.Drawing.Point(47, 132);
            this.txtKdSet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtKdSet.Name = "txtKdSet";
            this.txtKdSet.Size = new System.Drawing.Size(113, 30);
            this.txtKdSet.TabIndex = 41;
            // 
            // txtKiSet
            // 
            this.txtKiSet.Location = new System.Drawing.Point(47, 82);
            this.txtKiSet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtKiSet.Name = "txtKiSet";
            this.txtKiSet.Size = new System.Drawing.Size(113, 30);
            this.txtKiSet.TabIndex = 41;
            // 
            // txtKpSet
            // 
            this.txtKpSet.Location = new System.Drawing.Point(47, 36);
            this.txtKpSet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtKpSet.Name = "txtKpSet";
            this.txtKpSet.Size = new System.Drawing.Size(113, 30);
            this.txtKpSet.TabIndex = 41;
            this.txtKpSet.TextChanged += new System.EventHandler(this.txtKpSet_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(204, 84);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(33, 24);
            this.label13.TabIndex = 40;
            this.label13.Text = "Kb";
            // 
            // txtKbSet
            // 
            this.txtKbSet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(175)))));
            this.txtKbSet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKbSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKbSet.ForeColor = System.Drawing.Color.Black;
            this.txtKbSet.Location = new System.Drawing.Point(247, 80);
            this.txtKbSet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtKbSet.Name = "txtKbSet";
            this.txtKbSet.Size = new System.Drawing.Size(101, 26);
            this.txtKbSet.TabIndex = 27;
            this.txtKbSet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(187, 137);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 24);
            this.label11.TabIndex = 38;
            this.label11.Text = "Alpha";
            // 
            // txtAnphaSet
            // 
            this.txtAnphaSet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(175)))));
            this.txtAnphaSet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAnphaSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnphaSet.ForeColor = System.Drawing.Color.Black;
            this.txtAnphaSet.Location = new System.Drawing.Point(247, 134);
            this.txtAnphaSet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAnphaSet.Name = "txtAnphaSet";
            this.txtAnphaSet.Size = new System.Drawing.Size(102, 26);
            this.txtAnphaSet.TabIndex = 29;
            this.txtAnphaSet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(13, 135);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 24);
            this.label1.TabIndex = 36;
            this.label1.Text = "Kd";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(13, 87);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 24);
            this.label2.TabIndex = 35;
            this.label2.Text = "Ki";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(12, 38);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 24);
            this.label3.TabIndex = 34;
            this.label3.Text = "Kp";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1628, 850);
            this.Controls.Add(this.grbSetVel);
            this.Controls.Add(this.gbCurrent);
            this.Controls.Add(this.gbPID);
            this.Controls.Add(this.gbControl);
            this.Controls.Add(this.gbConnect);
            this.Controls.Add(this.GraphVel);
            this.Controls.Add(this.GraphPos);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.gbConnect.ResumeLayout(false);
            this.gbControl.ResumeLayout(false);
            this.grbSetVel.ResumeLayout(false);
            this.grbSetVel.PerformLayout();
            this.gbCurrent.ResumeLayout(false);
            this.gbCurrent.PerformLayout();
            this.gbPID.ResumeLayout(false);
            this.gbPID.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.Ports.SerialPort SerialPort;
        private System.Windows.Forms.Timer TimerPort;
        private ZedGraph.ZedGraphControl GraphPos;
        private ZedGraph.ZedGraphControl GraphVel;
        private System.Windows.Forms.GroupBox gbConnect;
        private System.Windows.Forms.Button btDisconnect;
        private System.Windows.Forms.Button btConnect;
        private System.Windows.Forms.ComboBox cbBaudRate;
        private System.Windows.Forms.ComboBox cbSeclectCom;
        private System.Windows.Forms.Timer TimerGraph;
        private System.Windows.Forms.ComboBox cbComName;
        private System.Windows.Forms.GroupBox gbControl;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Button btScale;
        private System.Windows.Forms.Button btReverse;
        private System.Windows.Forms.Button btPause;
        private System.Windows.Forms.Button btStop;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.GroupBox grbSetVel;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.RadioButton rbtVelocity;
        private System.Windows.Forms.RadioButton rbtPosition;
        private System.Windows.Forms.GroupBox gbCurrent;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TextBox txtError;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.TextBox txtVel;
        private System.Windows.Forms.TextBox txtPos;
        private System.Windows.Forms.GroupBox gbPID;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtKbSet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPosition;
        private System.Windows.Forms.TextBox txtVelocity;
        private System.Windows.Forms.Button btSetPoint;
        private System.Windows.Forms.TextBox txtKpSet;
        private System.Windows.Forms.TextBox txtKdSet;
        private System.Windows.Forms.TextBox txtKiSet;
        private System.Windows.Forms.TextBox txtAcc;
        private System.Windows.Forms.Button btReSet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtAnphaSet;
    }
}

