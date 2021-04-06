
namespace CRCAssist
{
    partial class CRCAssist
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.PictureBox pbSettings;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CRCAssist));
            this.lblGp = new System.Windows.Forms.Label();
            this.nudGp = new System.Windows.Forms.NumericUpDown();
            this.rbExact = new System.Windows.Forms.RadioButton();
            this.rbFast = new System.Windows.Forms.RadioButton();
            this.rbEasy = new System.Windows.Forms.RadioButton();
            this.gpDelay = new System.Windows.Forms.GroupBox();
            this.cbInstant = new System.Windows.Forms.CheckBox();
            this.cbTransition = new System.Windows.Forms.CheckBox();
            this.nudLoops = new System.Windows.Forms.NumericUpDown();
            this.lblLoops = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            this.btnCRC = new System.Windows.Forms.Button();
            this.pnlBeatmaker = new System.Windows.Forms.Panel();
            this.pbMore = new System.Windows.Forms.PictureBox();
            this.pnlSettings = new System.Windows.Forms.Panel();
            this.btnStCancel = new System.Windows.Forms.Button();
            this.btnStApply = new System.Windows.Forms.Button();
            this.btnStOK = new System.Windows.Forms.Button();
            this.lblSoundDelayInstruction = new System.Windows.Forms.Label();
            this.lblSoundDelayInfo = new System.Windows.Forms.Label();
            this.nudSoundDelay = new System.Windows.Forms.NumericUpDown();
            this.lblSoundDelay = new System.Windows.Forms.Label();
            this.pnlMore = new System.Windows.Forms.Panel();
            this.btnMApply = new System.Windows.Forms.Button();
            this.btnMBack = new System.Windows.Forms.Button();
            this.lblMGPs = new System.Windows.Forms.Label();
            this.lblMSec = new System.Windows.Forms.Label();
            this.lblConvert = new System.Windows.Forms.Label();
            this.nudMGPs = new System.Windows.Forms.NumericUpDown();
            this.nudMSecs = new System.Windows.Forms.NumericUpDown();
            pbSettings = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(pbSettings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGp)).BeginInit();
            this.gpDelay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLoops)).BeginInit();
            this.pnlBeatmaker.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMore)).BeginInit();
            this.pnlSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoundDelay)).BeginInit();
            this.pnlMore.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMGPs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMSecs)).BeginInit();
            this.SuspendLayout();
            // 
            // pbSettings
            // 
            pbSettings.Image = global::CRCAssist.Properties.Resources.SettingsIcon;
            pbSettings.Location = new System.Drawing.Point(481, 12);
            pbSettings.Name = "pbSettings";
            pbSettings.Size = new System.Drawing.Size(25, 25);
            pbSettings.TabIndex = 15;
            pbSettings.TabStop = false;
            pbSettings.Click += new System.EventHandler(this.pbSettings_Click);
            // 
            // lblGp
            // 
            this.lblGp.AutoSize = true;
            this.lblGp.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGp.Location = new System.Drawing.Point(17, 30);
            this.lblGp.Name = "lblGp";
            this.lblGp.Size = new System.Drawing.Size(132, 25);
            this.lblGp.TabIndex = 0;
            this.lblGp.Text = "Groundpunds:";
            // 
            // nudGp
            // 
            this.nudGp.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nudGp.Location = new System.Drawing.Point(155, 32);
            this.nudGp.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nudGp.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudGp.Name = "nudGp";
            this.nudGp.Size = new System.Drawing.Size(36, 27);
            this.nudGp.TabIndex = 1;
            this.nudGp.Value = new decimal(new int[] {
            54,
            0,
            0,
            0});
            this.nudGp.ValueChanged += new System.EventHandler(this.nudGp_ValueChanged);
            // 
            // rbExact
            // 
            this.rbExact.AutoSize = true;
            this.rbExact.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbExact.Location = new System.Drawing.Point(6, 22);
            this.rbExact.Name = "rbExact";
            this.rbExact.Size = new System.Drawing.Size(54, 29);
            this.rbExact.TabIndex = 3;
            this.rbExact.Text = "1.8";
            this.rbExact.UseVisualStyleBackColor = true;
            this.rbExact.CheckedChanged += new System.EventHandler(this.rbExact_CheckedChanged);
            // 
            // rbFast
            // 
            this.rbFast.AutoSize = true;
            this.rbFast.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbFast.Location = new System.Drawing.Point(66, 22);
            this.rbFast.Name = "rbFast";
            this.rbFast.Size = new System.Drawing.Size(54, 29);
            this.rbFast.TabIndex = 4;
            this.rbFast.Text = "1.9";
            this.rbFast.UseVisualStyleBackColor = true;
            this.rbFast.CheckedChanged += new System.EventHandler(this.rbFast_CheckedChanged);
            // 
            // rbEasy
            // 
            this.rbEasy.AutoSize = true;
            this.rbEasy.Checked = true;
            this.rbEasy.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbEasy.Location = new System.Drawing.Point(126, 22);
            this.rbEasy.Name = "rbEasy";
            this.rbEasy.Size = new System.Drawing.Size(54, 29);
            this.rbEasy.TabIndex = 5;
            this.rbEasy.TabStop = true;
            this.rbEasy.Text = "2.0";
            this.rbEasy.UseVisualStyleBackColor = true;
            this.rbEasy.CheckedChanged += new System.EventHandler(this.rbEasy_CheckedChanged);
            // 
            // gpDelay
            // 
            this.gpDelay.Controls.Add(this.rbExact);
            this.gpDelay.Controls.Add(this.rbEasy);
            this.gpDelay.Controls.Add(this.rbFast);
            this.gpDelay.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gpDelay.Location = new System.Drawing.Point(17, 66);
            this.gpDelay.Name = "gpDelay";
            this.gpDelay.Size = new System.Drawing.Size(200, 53);
            this.gpDelay.TabIndex = 6;
            this.gpDelay.TabStop = false;
            this.gpDelay.Text = "Delay in seconds:";
            // 
            // cbInstant
            // 
            this.cbInstant.AutoSize = true;
            this.cbInstant.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbInstant.Location = new System.Drawing.Point(268, 29);
            this.cbInstant.Name = "cbInstant";
            this.cbInstant.Size = new System.Drawing.Size(145, 29);
            this.cbInstant.TabIndex = 8;
            this.cbInstant.Text = "Start instantly";
            this.cbInstant.UseVisualStyleBackColor = true;
            this.cbInstant.CheckedChanged += new System.EventHandler(this.cbInstant_CheckedChanged);
            // 
            // cbTransition
            // 
            this.cbTransition.AutoSize = true;
            this.cbTransition.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbTransition.Location = new System.Drawing.Point(268, 64);
            this.cbTransition.Name = "cbTransition";
            this.cbTransition.Size = new System.Drawing.Size(233, 29);
            this.cbTransition.TabIndex = 9;
            this.cbTransition.Text = "Transition into CRC beat";
            this.cbTransition.UseVisualStyleBackColor = true;
            this.cbTransition.CheckedChanged += new System.EventHandler(this.cbTransition_CheckedChanged);
            // 
            // nudLoops
            // 
            this.nudLoops.Enabled = false;
            this.nudLoops.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nudLoops.Location = new System.Drawing.Point(434, 94);
            this.nudLoops.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudLoops.Name = "nudLoops";
            this.nudLoops.Size = new System.Drawing.Size(41, 27);
            this.nudLoops.TabIndex = 10;
            this.nudLoops.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudLoops.ValueChanged += new System.EventHandler(this.nudLoops_ValueChanged);
            // 
            // lblLoops
            // 
            this.lblLoops.AutoSize = true;
            this.lblLoops.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLoops.ForeColor = System.Drawing.Color.Gray;
            this.lblLoops.Location = new System.Drawing.Point(268, 92);
            this.lblLoops.Name = "lblLoops";
            this.lblLoops.Size = new System.Drawing.Size(144, 25);
            this.lblLoops.TabIndex = 11;
            this.lblLoops.Text = "CRC beat loops:";
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCreate.Location = new System.Drawing.Point(17, 138);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(360, 42);
            this.btnCreate.TabIndex = 12;
            this.btnCreate.Text = "Create beat";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(381, 185);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(128, 15);
            this.lblOutput.TabIndex = 13;
            this.lblOutput.Text = "CRCAssist by Lemerald";
            // 
            // btnCRC
            // 
            this.btnCRC.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCRC.Location = new System.Drawing.Point(383, 138);
            this.btnCRC.Name = "btnCRC";
            this.btnCRC.Size = new System.Drawing.Size(126, 42);
            this.btnCRC.TabIndex = 14;
            this.btnCRC.Text = "Only CRC";
            this.btnCRC.UseVisualStyleBackColor = true;
            this.btnCRC.Click += new System.EventHandler(this.btnCRC_Click);
            // 
            // pnlBeatmaker
            // 
            this.pnlBeatmaker.Controls.Add(this.pbMore);
            this.pnlBeatmaker.Controls.Add(this.btnCRC);
            this.pnlBeatmaker.Controls.Add(this.lblOutput);
            this.pnlBeatmaker.Controls.Add(this.btnCreate);
            this.pnlBeatmaker.Controls.Add(this.lblLoops);
            this.pnlBeatmaker.Controls.Add(this.nudLoops);
            this.pnlBeatmaker.Controls.Add(this.cbTransition);
            this.pnlBeatmaker.Controls.Add(this.cbInstant);
            this.pnlBeatmaker.Controls.Add(this.gpDelay);
            this.pnlBeatmaker.Controls.Add(this.nudGp);
            this.pnlBeatmaker.Controls.Add(this.lblGp);
            this.pnlBeatmaker.Controls.Add(pbSettings);
            this.pnlBeatmaker.Location = new System.Drawing.Point(0, 0);
            this.pnlBeatmaker.Name = "pnlBeatmaker";
            this.pnlBeatmaker.Size = new System.Drawing.Size(518, 209);
            this.pnlBeatmaker.TabIndex = 16;
            // 
            // pbMore
            // 
            this.pbMore.Image = global::CRCAssist.Properties.Resources.plus25;
            this.pbMore.Location = new System.Drawing.Point(451, 12);
            this.pbMore.Name = "pbMore";
            this.pbMore.Size = new System.Drawing.Size(24, 24);
            this.pbMore.TabIndex = 16;
            this.pbMore.TabStop = false;
            this.pbMore.Click += new System.EventHandler(this.pbMore_Click);
            // 
            // pnlSettings
            // 
            this.pnlSettings.Controls.Add(this.btnStCancel);
            this.pnlSettings.Controls.Add(this.btnStApply);
            this.pnlSettings.Controls.Add(this.btnStOK);
            this.pnlSettings.Controls.Add(this.lblSoundDelayInstruction);
            this.pnlSettings.Controls.Add(this.lblSoundDelayInfo);
            this.pnlSettings.Controls.Add(this.nudSoundDelay);
            this.pnlSettings.Controls.Add(this.lblSoundDelay);
            this.pnlSettings.Location = new System.Drawing.Point(0, 0);
            this.pnlSettings.Name = "pnlSettings";
            this.pnlSettings.Size = new System.Drawing.Size(518, 209);
            this.pnlSettings.TabIndex = 16;
            // 
            // btnStCancel
            // 
            this.btnStCancel.Location = new System.Drawing.Point(177, 174);
            this.btnStCancel.Name = "btnStCancel";
            this.btnStCancel.Size = new System.Drawing.Size(75, 23);
            this.btnStCancel.TabIndex = 6;
            this.btnStCancel.Text = "Cancel";
            this.btnStCancel.UseVisualStyleBackColor = true;
            this.btnStCancel.Click += new System.EventHandler(this.btnStCancel_Click);
            // 
            // btnStApply
            // 
            this.btnStApply.Location = new System.Drawing.Point(95, 174);
            this.btnStApply.Name = "btnStApply";
            this.btnStApply.Size = new System.Drawing.Size(75, 23);
            this.btnStApply.TabIndex = 5;
            this.btnStApply.Text = "Apply";
            this.btnStApply.UseVisualStyleBackColor = true;
            this.btnStApply.Click += new System.EventHandler(this.btnStApply_Click);
            // 
            // btnStOK
            // 
            this.btnStOK.Location = new System.Drawing.Point(13, 174);
            this.btnStOK.Name = "btnStOK";
            this.btnStOK.Size = new System.Drawing.Size(75, 23);
            this.btnStOK.TabIndex = 4;
            this.btnStOK.Text = "OK";
            this.btnStOK.UseVisualStyleBackColor = true;
            this.btnStOK.Click += new System.EventHandler(this.btnStOK_Click);
            // 
            // lblSoundDelayInstruction
            // 
            this.lblSoundDelayInstruction.AutoSize = true;
            this.lblSoundDelayInstruction.Location = new System.Drawing.Point(235, 17);
            this.lblSoundDelayInstruction.Name = "lblSoundDelayInstruction";
            this.lblSoundDelayInstruction.Size = new System.Drawing.Size(284, 30);
            this.lblSoundDelayInstruction.TabIndex = 3;
            this.lblSoundDelayInstruction.Text = "Increasing the value will make the sound play later,\r\ndecreasing the value will m" +
    "ake the sound play earlier";
            // 
            // lblSoundDelayInfo
            // 
            this.lblSoundDelayInfo.AutoSize = true;
            this.lblSoundDelayInfo.Location = new System.Drawing.Point(25, 49);
            this.lblSoundDelayInfo.Name = "lblSoundDelayInfo";
            this.lblSoundDelayInfo.Size = new System.Drawing.Size(236, 15);
            this.lblSoundDelayInfo.TabIndex = 2;
            this.lblSoundDelayInfo.Text = "Adjust the delay between the sounds in ms.";
            // 
            // nudSoundDelay
            // 
            this.nudSoundDelay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nudSoundDelay.Location = new System.Drawing.Point(148, 20);
            this.nudSoundDelay.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudSoundDelay.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.nudSoundDelay.Name = "nudSoundDelay";
            this.nudSoundDelay.Size = new System.Drawing.Size(81, 29);
            this.nudSoundDelay.TabIndex = 1;
            this.nudSoundDelay.Value = new decimal(new int[] {
            16,
            0,
            0,
            -2147483648});
            // 
            // lblSoundDelay
            // 
            this.lblSoundDelay.AutoSize = true;
            this.lblSoundDelay.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSoundDelay.Location = new System.Drawing.Point(25, 20);
            this.lblSoundDelay.Name = "lblSoundDelay";
            this.lblSoundDelay.Size = new System.Drawing.Size(116, 25);
            this.lblSoundDelay.TabIndex = 0;
            this.lblSoundDelay.Text = "Sound delay";
            // 
            // pnlMore
            // 
            this.pnlMore.Controls.Add(this.btnMApply);
            this.pnlMore.Controls.Add(this.btnMBack);
            this.pnlMore.Controls.Add(this.lblMGPs);
            this.pnlMore.Controls.Add(this.lblMSec);
            this.pnlMore.Controls.Add(this.lblConvert);
            this.pnlMore.Controls.Add(this.nudMGPs);
            this.pnlMore.Controls.Add(this.nudMSecs);
            this.pnlMore.Location = new System.Drawing.Point(0, 0);
            this.pnlMore.Name = "pnlMore";
            this.pnlMore.Size = new System.Drawing.Size(519, 209);
            this.pnlMore.TabIndex = 17;
            // 
            // btnMApply
            // 
            this.btnMApply.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMApply.Location = new System.Drawing.Point(189, 53);
            this.btnMApply.Name = "btnMApply";
            this.btnMApply.Size = new System.Drawing.Size(89, 29);
            this.btnMApply.TabIndex = 6;
            this.btnMApply.Text = "Apply GPs";
            this.btnMApply.UseVisualStyleBackColor = true;
            this.btnMApply.Click += new System.EventHandler(this.btnMApply_Click);
            // 
            // btnMBack
            // 
            this.btnMBack.Location = new System.Drawing.Point(433, 173);
            this.btnMBack.Name = "btnMBack";
            this.btnMBack.Size = new System.Drawing.Size(75, 23);
            this.btnMBack.TabIndex = 5;
            this.btnMBack.Text = "Back";
            this.btnMBack.UseVisualStyleBackColor = true;
            this.btnMBack.Click += new System.EventHandler(this.btnMBack_Click);
            // 
            // lblMGPs
            // 
            this.lblMGPs.AutoSize = true;
            this.lblMGPs.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMGPs.Location = new System.Drawing.Point(95, 36);
            this.lblMGPs.Name = "lblMGPs";
            this.lblMGPs.Size = new System.Drawing.Size(87, 15);
            this.lblMGPs.TabIndex = 4;
            this.lblMGPs.Text = "Groundpounds";
            // 
            // lblMSec
            // 
            this.lblMSec.AutoSize = true;
            this.lblMSec.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMSec.Location = new System.Drawing.Point(17, 36);
            this.lblMSec.Name = "lblMSec";
            this.lblMSec.Size = new System.Drawing.Size(51, 15);
            this.lblMSec.TabIndex = 3;
            this.lblMSec.Text = "Seconds";
            // 
            // lblConvert
            // 
            this.lblConvert.AutoSize = true;
            this.lblConvert.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblConvert.Location = new System.Drawing.Point(13, 15);
            this.lblConvert.Name = "lblConvert";
            this.lblConvert.Size = new System.Drawing.Size(265, 21);
            this.lblConvert.TabIndex = 2;
            this.lblConvert.Text = "Convert seconds to GPs or vice versa";
            // 
            // nudMGPs
            // 
            this.nudMGPs.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nudMGPs.Location = new System.Drawing.Point(98, 53);
            this.nudMGPs.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nudMGPs.Name = "nudMGPs";
            this.nudMGPs.Size = new System.Drawing.Size(51, 29);
            this.nudMGPs.TabIndex = 1;
            this.nudMGPs.ValueChanged += new System.EventHandler(this.nudMGPs_ValueChanged);
            this.nudMGPs.Enter += new System.EventHandler(this.nudMGPs_Enter);
            this.nudMGPs.Leave += new System.EventHandler(this.nudMGPs_Leave);
            // 
            // nudMSecs
            // 
            this.nudMSecs.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nudMSecs.Location = new System.Drawing.Point(17, 53);
            this.nudMSecs.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nudMSecs.Name = "nudMSecs";
            this.nudMSecs.Size = new System.Drawing.Size(51, 29);
            this.nudMSecs.TabIndex = 0;
            this.nudMSecs.ValueChanged += new System.EventHandler(this.nudMSecs_ValueChanged);
            this.nudMSecs.Enter += new System.EventHandler(this.nudMSecs_Enter);
            this.nudMSecs.Leave += new System.EventHandler(this.nudMSecs_Leave);
            // 
            // CRCAssist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 209);
            this.Controls.Add(this.pnlBeatmaker);
            this.Controls.Add(this.pnlSettings);
            this.Controls.Add(this.pnlMore);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CRCAssist";
            this.Text = "CRCAssist";
            ((System.ComponentModel.ISupportInitialize)(pbSettings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGp)).EndInit();
            this.gpDelay.ResumeLayout(false);
            this.gpDelay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLoops)).EndInit();
            this.pnlBeatmaker.ResumeLayout(false);
            this.pnlBeatmaker.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMore)).EndInit();
            this.pnlSettings.ResumeLayout(false);
            this.pnlSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoundDelay)).EndInit();
            this.pnlMore.ResumeLayout(false);
            this.pnlMore.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMGPs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMSecs)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Label lblGp;
        private System.Windows.Forms.NumericUpDown nudGp;
        private System.Windows.Forms.RadioButton rbExact;
        private System.Windows.Forms.RadioButton rbFast;
        private System.Windows.Forms.RadioButton rbEasy;
        private System.Windows.Forms.GroupBox gpDelay;
        private System.Windows.Forms.CheckBox cbInstant;
        private System.Windows.Forms.CheckBox cbTransition;
        private System.Windows.Forms.Label lblLoops;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.NumericUpDown nudLoops;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Button btnCRC;
        private System.Windows.Forms.Panel pnlBeatmaker;
        private System.Windows.Forms.Panel pnlSettings;
        private System.Windows.Forms.Label lblSoundDelay;
        private System.Windows.Forms.NumericUpDown nudSoundDelay;
        private System.Windows.Forms.Label lblSoundDelayInstruction;
        private System.Windows.Forms.Label lblSoundDelayInfo;
        private System.Windows.Forms.Button btnStCancel;
        private System.Windows.Forms.Button btnStApply;
        private System.Windows.Forms.Button btnStOK;
        private System.Windows.Forms.PictureBox pbMore;
        private System.Windows.Forms.Panel pnlMore;
        private System.Windows.Forms.Button btnMBack;
        private System.Windows.Forms.Label lblMGPs;
        private System.Windows.Forms.Label lblMSec;
        private System.Windows.Forms.Label lblConvert;
        private System.Windows.Forms.NumericUpDown nudMGPs;
        private System.Windows.Forms.NumericUpDown nudMSecs;
        private System.Windows.Forms.Button btnMApply;
    }
}

