
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
            this.lblGp = new System.Windows.Forms.Label();
            this.nudGp = new System.Windows.Forms.NumericUpDown();
            this.rbExact = new System.Windows.Forms.RadioButton();
            this.rbFast = new System.Windows.Forms.RadioButton();
            this.rbEasy = new System.Windows.Forms.RadioButton();
            this.gbDelay = new System.Windows.Forms.GroupBox();
            this.cbInstant = new System.Windows.Forms.CheckBox();
            this.cbTransition = new System.Windows.Forms.CheckBox();
            this.nudLoops = new System.Windows.Forms.NumericUpDown();
            this.lblLoops = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudGp)).BeginInit();
            this.gbDelay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLoops)).BeginInit();
            this.SuspendLayout();
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
            // gbDelay
            // 
            this.gbDelay.Controls.Add(this.rbExact);
            this.gbDelay.Controls.Add(this.rbEasy);
            this.gbDelay.Controls.Add(this.rbFast);
            this.gbDelay.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gbDelay.Location = new System.Drawing.Point(17, 66);
            this.gbDelay.Name = "gbDelay";
            this.gbDelay.Size = new System.Drawing.Size(200, 53);
            this.gbDelay.TabIndex = 6;
            this.gbDelay.TabStop = false;
            this.gbDelay.Text = "Delay in seconds:";
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
            this.btnCreate.Size = new System.Drawing.Size(484, 42);
            this.btnCreate.TabIndex = 12;
            this.btnCreate.Text = "Create beat";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(23, 187);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(57, 15);
            this.lblOutput.TabIndex = 13;
            this.lblOutput.Text = "Data here";
            // 
            // CRCAssist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 209);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.lblLoops);
            this.Controls.Add(this.nudLoops);
            this.Controls.Add(this.cbTransition);
            this.Controls.Add(this.cbInstant);
            this.Controls.Add(this.gbDelay);
            this.Controls.Add(this.nudGp);
            this.Controls.Add(this.lblGp);
            this.Name = "CRCAssist";
            this.Text = "CRCAssist";
            ((System.ComponentModel.ISupportInitialize)(this.nudGp)).EndInit();
            this.gbDelay.ResumeLayout(false);
            this.gbDelay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLoops)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblGp;
        private System.Windows.Forms.NumericUpDown nudGp;
        private System.Windows.Forms.RadioButton rbExact;
        private System.Windows.Forms.RadioButton rbFast;
        private System.Windows.Forms.RadioButton rbEasy;
        private System.Windows.Forms.GroupBox gbDelay;
        private System.Windows.Forms.CheckBox cbInstant;
        private System.Windows.Forms.CheckBox cbTransition;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label lblLoops;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.NumericUpDown nudLoops;
        private System.Windows.Forms.Label lblOutput;
    }
}

