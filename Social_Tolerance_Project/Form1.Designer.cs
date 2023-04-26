namespace Social_Tolerance_Project
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
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sliderpeopleTypes = new System.Windows.Forms.TrackBar();
            this.trackBarXGrid = new System.Windows.Forms.TrackBar();
            this.trackBarTolerance = new System.Windows.Forms.TrackBar();
            this.lblTolerance = new System.Windows.Forms.Label();
            this.lblGridX = new System.Windows.Forms.Label();
            this.lblPeopleTypes = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBarUnoccupiedPercent = new System.Windows.Forms.TrackBar();
            this.lblPercentUnoccupied = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStep = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.UDredWeight = new System.Windows.Forms.NumericUpDown();
            this.lblWeights = new System.Windows.Forms.Label();
            this.lblRedWeight = new System.Windows.Forms.Label();
            this.UDblueWeight = new System.Windows.Forms.NumericUpDown();
            this.lblBlue = new System.Windows.Forms.Label();
            this.UDgreenWeight = new System.Windows.Forms.NumericUpDown();
            this.lblGreen = new System.Windows.Forms.Label();
            this.UDyellowWeight = new System.Windows.Forms.NumericUpDown();
            this.lblYellow = new System.Windows.Forms.Label();
            this.UDpurpleWeight = new System.Windows.Forms.NumericUpDown();
            this.lblPurple = new System.Windows.Forms.Label();
            this.lblToleranceValue = new System.Windows.Forms.Label();
            this.trackBarTimer = new System.Windows.Forms.TrackBar();
            this.lblTimeSpeed = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sliderpeopleTypes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarXGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTolerance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarUnoccupiedPercent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UDredWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UDblueWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UDgreenWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UDyellowWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UDpurpleWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTimer)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(974, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.helpToolStripMenuItem.Text = "&Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // sliderpeopleTypes
            // 
            this.sliderpeopleTypes.LargeChange = 3;
            this.sliderpeopleTypes.Location = new System.Drawing.Point(30, 77);
            this.sliderpeopleTypes.Maximum = 5;
            this.sliderpeopleTypes.Minimum = 2;
            this.sliderpeopleTypes.Name = "sliderpeopleTypes";
            this.sliderpeopleTypes.Size = new System.Drawing.Size(155, 45);
            this.sliderpeopleTypes.TabIndex = 1;
            this.sliderpeopleTypes.Value = 2;
            this.sliderpeopleTypes.Scroll += new System.EventHandler(this.sliderpeopleTypes_Scroll);
            // 
            // trackBarXGrid
            // 
            this.trackBarXGrid.Location = new System.Drawing.Point(30, 146);
            this.trackBarXGrid.Maximum = 190;
            this.trackBarXGrid.Minimum = 120;
            this.trackBarXGrid.Name = "trackBarXGrid";
            this.trackBarXGrid.Size = new System.Drawing.Size(155, 45);
            this.trackBarXGrid.TabIndex = 3;
            this.trackBarXGrid.TickFrequency = 5;
            this.trackBarXGrid.Value = 160;
            this.trackBarXGrid.Scroll += new System.EventHandler(this.trackBarXGrid_Scroll);
            // 
            // trackBarTolerance
            // 
            this.trackBarTolerance.Location = new System.Drawing.Point(30, 206);
            this.trackBarTolerance.Maximum = 100;
            this.trackBarTolerance.Minimum = 10;
            this.trackBarTolerance.Name = "trackBarTolerance";
            this.trackBarTolerance.Size = new System.Drawing.Size(155, 45);
            this.trackBarTolerance.TabIndex = 3;
            this.trackBarTolerance.TickFrequency = 10;
            this.trackBarTolerance.Value = 50;
            this.trackBarTolerance.Scroll += new System.EventHandler(this.trackBarTolerance_Scroll);
            // 
            // lblTolerance
            // 
            this.lblTolerance.AutoSize = true;
            this.lblTolerance.Location = new System.Drawing.Point(52, 241);
            this.lblTolerance.Name = "lblTolerance";
            this.lblTolerance.Size = new System.Drawing.Size(84, 13);
            this.lblTolerance.TabIndex = 5;
            this.lblTolerance.Text = "Tolerance Level";
            // 
            // lblGridX
            // 
            this.lblGridX.AutoSize = true;
            this.lblGridX.Location = new System.Drawing.Point(60, 178);
            this.lblGridX.Name = "lblGridX";
            this.lblGridX.Size = new System.Drawing.Size(105, 13);
            this.lblGridX.TabIndex = 7;
            this.lblGridX.Text = "Grid Size - 160 x 160";
            // 
            // lblPeopleTypes
            // 
            this.lblPeopleTypes.AutoSize = true;
            this.lblPeopleTypes.Location = new System.Drawing.Point(69, 109);
            this.lblPeopleTypes.Name = "lblPeopleTypes";
            this.lblPeopleTypes.Size = new System.Drawing.Size(84, 13);
            this.lblPeopleTypes.TabIndex = 8;
            this.lblPeopleTypes.Text = "Types of People";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 30);
            this.label1.TabIndex = 9;
            this.label1.Text = "Controls";
            // 
            // trackBarUnoccupiedPercent
            // 
            this.trackBarUnoccupiedPercent.Location = new System.Drawing.Point(30, 268);
            this.trackBarUnoccupiedPercent.Maximum = 30;
            this.trackBarUnoccupiedPercent.Minimum = 5;
            this.trackBarUnoccupiedPercent.Name = "trackBarUnoccupiedPercent";
            this.trackBarUnoccupiedPercent.Size = new System.Drawing.Size(155, 45);
            this.trackBarUnoccupiedPercent.TabIndex = 10;
            this.trackBarUnoccupiedPercent.TickFrequency = 5;
            this.trackBarUnoccupiedPercent.Value = 30;
            this.trackBarUnoccupiedPercent.Scroll += new System.EventHandler(this.trackBarUnoccupiedPercent_Scroll);
            // 
            // lblPercentUnoccupied
            // 
            this.lblPercentUnoccupied.AutoSize = true;
            this.lblPercentUnoccupied.Location = new System.Drawing.Point(51, 300);
            this.lblPercentUnoccupied.Name = "lblPercentUnoccupied";
            this.lblPercentUnoccupied.Size = new System.Drawing.Size(134, 13);
            this.lblPercentUnoccupied.TabIndex = 11;
            this.lblPercentUnoccupied.Text = "Percent Unoccupied (30%)";
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(32, 468);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 30);
            this.btnStart.TabIndex = 12;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.SteelBlue;
            this.btnStop.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.ForeColor = System.Drawing.Color.White;
            this.btnStop.Location = new System.Drawing.Point(32, 504);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 32);
            this.btnStop.TabIndex = 13;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStep
            // 
            this.btnStep.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnStep.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStep.Location = new System.Drawing.Point(132, 468);
            this.btnStep.Name = "btnStep";
            this.btnStep.Size = new System.Drawing.Size(75, 30);
            this.btnStep.TabIndex = 14;
            this.btnStep.Text = "Step";
            this.btnStep.UseVisualStyleBackColor = false;
            this.btnStep.Click += new System.EventHandler(this.btnStep_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(132, 504);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 32);
            this.btnReset.TabIndex = 15;
            this.btnReset.Text = "Repopulate";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // UDredWeight
            // 
            this.UDredWeight.Location = new System.Drawing.Point(16, 419);
            this.UDredWeight.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.UDredWeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.UDredWeight.Name = "UDredWeight";
            this.UDredWeight.Size = new System.Drawing.Size(33, 20);
            this.UDredWeight.TabIndex = 16;
            this.UDredWeight.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.UDredWeight.ValueChanged += new System.EventHandler(this.UDredWeight_ValueChanged);
            // 
            // lblWeights
            // 
            this.lblWeights.AutoSize = true;
            this.lblWeights.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeights.Location = new System.Drawing.Point(89, 400);
            this.lblWeights.Name = "lblWeights";
            this.lblWeights.Size = new System.Drawing.Size(64, 16);
            this.lblWeights.TabIndex = 17;
            this.lblWeights.Text = "Weights";
            // 
            // lblRedWeight
            // 
            this.lblRedWeight.AutoSize = true;
            this.lblRedWeight.Location = new System.Drawing.Point(22, 442);
            this.lblRedWeight.Name = "lblRedWeight";
            this.lblRedWeight.Size = new System.Drawing.Size(27, 13);
            this.lblRedWeight.TabIndex = 18;
            this.lblRedWeight.Text = "Red";
            // 
            // UDblueWeight
            // 
            this.UDblueWeight.Location = new System.Drawing.Point(55, 419);
            this.UDblueWeight.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.UDblueWeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.UDblueWeight.Name = "UDblueWeight";
            this.UDblueWeight.Size = new System.Drawing.Size(33, 20);
            this.UDblueWeight.TabIndex = 16;
            this.UDblueWeight.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.UDblueWeight.ValueChanged += new System.EventHandler(this.UDblueWeight_ValueChanged);
            // 
            // lblBlue
            // 
            this.lblBlue.AutoSize = true;
            this.lblBlue.Location = new System.Drawing.Point(61, 442);
            this.lblBlue.Name = "lblBlue";
            this.lblBlue.Size = new System.Drawing.Size(28, 13);
            this.lblBlue.TabIndex = 18;
            this.lblBlue.Text = "Blue";
            // 
            // UDgreenWeight
            // 
            this.UDgreenWeight.Location = new System.Drawing.Point(94, 419);
            this.UDgreenWeight.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.UDgreenWeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.UDgreenWeight.Name = "UDgreenWeight";
            this.UDgreenWeight.Size = new System.Drawing.Size(33, 20);
            this.UDgreenWeight.TabIndex = 16;
            this.UDgreenWeight.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.UDgreenWeight.ValueChanged += new System.EventHandler(this.UDgreenWeight_ValueChanged);
            // 
            // lblGreen
            // 
            this.lblGreen.AutoSize = true;
            this.lblGreen.Location = new System.Drawing.Point(95, 442);
            this.lblGreen.Name = "lblGreen";
            this.lblGreen.Size = new System.Drawing.Size(36, 13);
            this.lblGreen.TabIndex = 18;
            this.lblGreen.Text = "Green";
            // 
            // UDyellowWeight
            // 
            this.UDyellowWeight.Location = new System.Drawing.Point(136, 419);
            this.UDyellowWeight.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.UDyellowWeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.UDyellowWeight.Name = "UDyellowWeight";
            this.UDyellowWeight.Size = new System.Drawing.Size(33, 20);
            this.UDyellowWeight.TabIndex = 16;
            this.UDyellowWeight.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.UDyellowWeight.ValueChanged += new System.EventHandler(this.UDyellowWeight_ValueChanged);
            // 
            // lblYellow
            // 
            this.lblYellow.AutoSize = true;
            this.lblYellow.Location = new System.Drawing.Point(133, 442);
            this.lblYellow.Name = "lblYellow";
            this.lblYellow.Size = new System.Drawing.Size(38, 13);
            this.lblYellow.TabIndex = 18;
            this.lblYellow.Text = "Yellow";
            // 
            // UDpurpleWeight
            // 
            this.UDpurpleWeight.Location = new System.Drawing.Point(175, 419);
            this.UDpurpleWeight.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.UDpurpleWeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.UDpurpleWeight.Name = "UDpurpleWeight";
            this.UDpurpleWeight.Size = new System.Drawing.Size(33, 20);
            this.UDpurpleWeight.TabIndex = 16;
            this.UDpurpleWeight.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.UDpurpleWeight.ValueChanged += new System.EventHandler(this.UDpurpleWeight_ValueChanged);
            // 
            // lblPurple
            // 
            this.lblPurple.AutoSize = true;
            this.lblPurple.Location = new System.Drawing.Point(172, 442);
            this.lblPurple.Name = "lblPurple";
            this.lblPurple.Size = new System.Drawing.Size(37, 13);
            this.lblPurple.TabIndex = 18;
            this.lblPurple.Text = "Purple";
            // 
            // lblToleranceValue
            // 
            this.lblToleranceValue.AutoSize = true;
            this.lblToleranceValue.Location = new System.Drawing.Point(132, 241);
            this.lblToleranceValue.Name = "lblToleranceValue";
            this.lblToleranceValue.Size = new System.Drawing.Size(33, 13);
            this.lblToleranceValue.TabIndex = 19;
            this.lblToleranceValue.Text = "(50%)";
            // 
            // trackBarTimer
            // 
            this.trackBarTimer.LargeChange = 100;
            this.trackBarTimer.Location = new System.Drawing.Point(30, 330);
            this.trackBarTimer.Maximum = 100000;
            this.trackBarTimer.Minimum = 1;
            this.trackBarTimer.Name = "trackBarTimer";
            this.trackBarTimer.Size = new System.Drawing.Size(153, 45);
            this.trackBarTimer.TabIndex = 20;
            this.trackBarTimer.TickFrequency = 10000;
            this.trackBarTimer.Value = 100000;
            this.trackBarTimer.Scroll += new System.EventHandler(this.trackBarTimer_Scroll);
            // 
            // lblTimeSpeed
            // 
            this.lblTimeSpeed.AutoSize = true;
            this.lblTimeSpeed.Location = new System.Drawing.Point(69, 362);
            this.lblTimeSpeed.Name = "lblTimeSpeed";
            this.lblTimeSpeed.Size = new System.Drawing.Size(67, 13);
            this.lblTimeSpeed.TabIndex = 21;
            this.lblTimeSpeed.Text = "Timer Speed";
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(974, 565);
            this.Controls.Add(this.lblTimeSpeed);
            this.Controls.Add(this.trackBarTimer);
            this.Controls.Add(this.lblToleranceValue);
            this.Controls.Add(this.lblPurple);
            this.Controls.Add(this.lblYellow);
            this.Controls.Add(this.lblGreen);
            this.Controls.Add(this.lblBlue);
            this.Controls.Add(this.lblRedWeight);
            this.Controls.Add(this.lblWeights);
            this.Controls.Add(this.UDpurpleWeight);
            this.Controls.Add(this.UDyellowWeight);
            this.Controls.Add(this.UDgreenWeight);
            this.Controls.Add(this.UDblueWeight);
            this.Controls.Add(this.UDredWeight);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnStep);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblPercentUnoccupied);
            this.Controls.Add(this.trackBarUnoccupiedPercent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPeopleTypes);
            this.Controls.Add(this.lblGridX);
            this.Controls.Add(this.lblTolerance);
            this.Controls.Add(this.trackBarTolerance);
            this.Controls.Add(this.trackBarXGrid);
            this.Controls.Add(this.sliderpeopleTypes);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sliderpeopleTypes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarXGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTolerance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarUnoccupiedPercent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UDredWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UDblueWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UDgreenWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UDyellowWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UDpurpleWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTimer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.TrackBar sliderpeopleTypes;
        private System.Windows.Forms.TrackBar trackBarXGrid;
        private System.Windows.Forms.TrackBar trackBarTolerance;
        private System.Windows.Forms.Label lblTolerance;
        private System.Windows.Forms.Label lblGridX;
        private System.Windows.Forms.Label lblPeopleTypes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBarUnoccupiedPercent;
        private System.Windows.Forms.Label lblPercentUnoccupied;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStep;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.NumericUpDown UDredWeight;
        private System.Windows.Forms.Label lblWeights;
        private System.Windows.Forms.Label lblRedWeight;
        private System.Windows.Forms.NumericUpDown UDblueWeight;
        private System.Windows.Forms.Label lblBlue;
        private System.Windows.Forms.NumericUpDown UDgreenWeight;
        private System.Windows.Forms.Label lblGreen;
        private System.Windows.Forms.NumericUpDown UDyellowWeight;
        private System.Windows.Forms.Label lblYellow;
        private System.Windows.Forms.NumericUpDown UDpurpleWeight;
        private System.Windows.Forms.Label lblPurple;
        private System.Windows.Forms.Label lblToleranceValue;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TrackBar trackBarTimer;
        private System.Windows.Forms.Label lblTimeSpeed;
    }
}

