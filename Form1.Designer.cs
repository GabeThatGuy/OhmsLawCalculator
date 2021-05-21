namespace Ohm_s_Law_Calculator___WindowsForms
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
            this.ggRSWVoltageSelector = new System.Windows.Forms.RadioButton();
            this.ggRSWCurrentSelector = new System.Windows.Forms.RadioButton();
            this.ggRSWResistanceSelector = new System.Windows.Forms.RadioButton();
            this.ggTxtDataInVolts = new System.Windows.Forms.TextBox();
            this.ggTxtDataInAmps = new System.Windows.Forms.TextBox();
            this.ggTxtDataInOhms = new System.Windows.Forms.TextBox();
            this.ggCmdBtnCalcVolts = new System.Windows.Forms.Button();
            this.ggBtnCmdCalcAmps = new System.Windows.Forms.Button();
            this.ggBtnCmdCalcOhms = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ggDataOutLblWatts = new System.Windows.Forms.Label();
            this.ggBtnCmdExit = new System.Windows.Forms.Button();
            this.ggDataOutTxtLblMem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ggBtnCmdVoltsMemRCL = new System.Windows.Forms.Button();
            this.ggBtnCmdAmpsMemRCL = new System.Windows.Forms.Button();
            this.ggBtnCmdOhmsMemRCL = new System.Windows.Forms.Button();
            this.ggBtnCmdVoltsMemSTO = new System.Windows.Forms.Button();
            this.ggBtnCmdAmpsMemSTO = new System.Windows.Forms.Button();
            this.ggBtnCmdOhmsMemSTO = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ggRSWVoltageSelector
            // 
            this.ggRSWVoltageSelector.AutoSize = true;
            this.ggRSWVoltageSelector.Location = new System.Drawing.Point(41, 37);
            this.ggRSWVoltageSelector.Name = "ggRSWVoltageSelector";
            this.ggRSWVoltageSelector.Size = new System.Drawing.Size(77, 21);
            this.ggRSWVoltageSelector.TabIndex = 0;
            this.ggRSWVoltageSelector.TabStop = true;
            this.ggRSWVoltageSelector.Text = "Voltage";
            this.ggRSWVoltageSelector.UseVisualStyleBackColor = true;
            this.ggRSWVoltageSelector.CheckedChanged += new System.EventHandler(this.ggRSWVoltageSelector_CheckedChanged);
            // 
            // ggRSWCurrentSelector
            // 
            this.ggRSWCurrentSelector.AutoSize = true;
            this.ggRSWCurrentSelector.Location = new System.Drawing.Point(189, 37);
            this.ggRSWCurrentSelector.Name = "ggRSWCurrentSelector";
            this.ggRSWCurrentSelector.Size = new System.Drawing.Size(76, 21);
            this.ggRSWCurrentSelector.TabIndex = 1;
            this.ggRSWCurrentSelector.TabStop = true;
            this.ggRSWCurrentSelector.Text = "Current";
            this.ggRSWCurrentSelector.UseVisualStyleBackColor = true;
            this.ggRSWCurrentSelector.CheckedChanged += new System.EventHandler(this.ggRSWCurrentSelector_CheckedChanged);
            // 
            // ggRSWResistanceSelector
            // 
            this.ggRSWResistanceSelector.AutoSize = true;
            this.ggRSWResistanceSelector.Location = new System.Drawing.Point(329, 37);
            this.ggRSWResistanceSelector.Name = "ggRSWResistanceSelector";
            this.ggRSWResistanceSelector.Size = new System.Drawing.Size(99, 21);
            this.ggRSWResistanceSelector.TabIndex = 2;
            this.ggRSWResistanceSelector.TabStop = true;
            this.ggRSWResistanceSelector.Text = "Resistance";
            this.ggRSWResistanceSelector.UseVisualStyleBackColor = true;
            this.ggRSWResistanceSelector.CheckedChanged += new System.EventHandler(this.ggRSWResistanceSelector_CheckedChanged);
            // 
            // ggTxtDataInVolts
            // 
            this.ggTxtDataInVolts.Location = new System.Drawing.Point(41, 123);
            this.ggTxtDataInVolts.Name = "ggTxtDataInVolts";
            this.ggTxtDataInVolts.Size = new System.Drawing.Size(287, 22);
            this.ggTxtDataInVolts.TabIndex = 3;
            // 
            // ggTxtDataInAmps
            // 
            this.ggTxtDataInAmps.Location = new System.Drawing.Point(41, 189);
            this.ggTxtDataInAmps.Name = "ggTxtDataInAmps";
            this.ggTxtDataInAmps.Size = new System.Drawing.Size(287, 22);
            this.ggTxtDataInAmps.TabIndex = 4;
            // 
            // ggTxtDataInOhms
            // 
            this.ggTxtDataInOhms.Location = new System.Drawing.Point(41, 253);
            this.ggTxtDataInOhms.Name = "ggTxtDataInOhms";
            this.ggTxtDataInOhms.Size = new System.Drawing.Size(287, 22);
            this.ggTxtDataInOhms.TabIndex = 5;
            // 
            // ggCmdBtnCalcVolts
            // 
            this.ggCmdBtnCalcVolts.Location = new System.Drawing.Point(334, 122);
            this.ggCmdBtnCalcVolts.Name = "ggCmdBtnCalcVolts";
            this.ggCmdBtnCalcVolts.Size = new System.Drawing.Size(27, 24);
            this.ggCmdBtnCalcVolts.TabIndex = 6;
            this.ggCmdBtnCalcVolts.Text = "Volts";
            this.ggCmdBtnCalcVolts.UseVisualStyleBackColor = true;
            this.ggCmdBtnCalcVolts.Click += new System.EventHandler(this.ggCmdBtnCalcVolts_Click);
            // 
            // ggBtnCmdCalcAmps
            // 
            this.ggBtnCmdCalcAmps.Location = new System.Drawing.Point(335, 188);
            this.ggBtnCmdCalcAmps.Name = "ggBtnCmdCalcAmps";
            this.ggBtnCmdCalcAmps.Size = new System.Drawing.Size(26, 24);
            this.ggBtnCmdCalcAmps.TabIndex = 7;
            this.ggBtnCmdCalcAmps.Text = "Amps (I)";
            this.ggBtnCmdCalcAmps.UseVisualStyleBackColor = true;
            this.ggBtnCmdCalcAmps.Click += new System.EventHandler(this.ggBtnCmdCalcAmps_Click);
            // 
            // ggBtnCmdCalcOhms
            // 
            this.ggBtnCmdCalcOhms.Location = new System.Drawing.Point(334, 251);
            this.ggBtnCmdCalcOhms.Name = "ggBtnCmdCalcOhms";
            this.ggBtnCmdCalcOhms.Size = new System.Drawing.Size(27, 24);
            this.ggBtnCmdCalcOhms.TabIndex = 8;
            this.ggBtnCmdCalcOhms.Text = "Ohms (Ω)";
            this.ggBtnCmdCalcOhms.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ggBtnCmdCalcOhms.UseVisualStyleBackColor = true;
            this.ggBtnCmdCalcOhms.Click += new System.EventHandler(this.ggBtnCmdCalcOhms_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 307);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Watts:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ggDataOutLblWatts
            // 
            this.ggDataOutLblWatts.AutoSize = true;
            this.ggDataOutLblWatts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ggDataOutLblWatts.Location = new System.Drawing.Point(132, 309);
            this.ggDataOutLblWatts.Name = "ggDataOutLblWatts";
            this.ggDataOutLblWatts.Size = new System.Drawing.Size(15, 24);
            this.ggDataOutLblWatts.TabIndex = 10;
            this.ggDataOutLblWatts.Text = " ";
            // 
            // ggBtnCmdExit
            // 
            this.ggBtnCmdExit.Location = new System.Drawing.Point(495, 335);
            this.ggBtnCmdExit.Name = "ggBtnCmdExit";
            this.ggBtnCmdExit.Size = new System.Drawing.Size(122, 41);
            this.ggBtnCmdExit.TabIndex = 11;
            this.ggBtnCmdExit.Text = "Exit";
            this.ggBtnCmdExit.UseVisualStyleBackColor = true;
            this.ggBtnCmdExit.Click += new System.EventHandler(this.ggBtnCmdExit_Click);
            // 
            // ggDataOutTxtLblMem
            // 
            this.ggDataOutTxtLblMem.Location = new System.Drawing.Point(495, 124);
            this.ggDataOutTxtLblMem.Multiline = true;
            this.ggDataOutTxtLblMem.Name = "ggDataOutTxtLblMem";
            this.ggDataOutTxtLblMem.Size = new System.Drawing.Size(122, 151);
            this.ggDataOutTxtLblMem.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(495, 49);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(125, 72);
            this.label2.TabIndex = 13;
            this.label2.Text = ":Memory Data";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // ggBtnCmdVoltsMemRCL
            // 
            this.ggBtnCmdVoltsMemRCL.Location = new System.Drawing.Point(367, 122);
            this.ggBtnCmdVoltsMemRCL.Name = "ggBtnCmdVoltsMemRCL";
            this.ggBtnCmdVoltsMemRCL.Size = new System.Drawing.Size(60, 23);
            this.ggBtnCmdVoltsMemRCL.TabIndex = 15;
            this.ggBtnCmdVoltsMemRCL.Text = "RCL";
            this.ggBtnCmdVoltsMemRCL.UseVisualStyleBackColor = true;
            this.ggBtnCmdVoltsMemRCL.Click += new System.EventHandler(this.ggBtnCmdVoltsMemRCL_Click);
            // 
            // ggBtnCmdAmpsMemRCL
            // 
            this.ggBtnCmdAmpsMemRCL.Location = new System.Drawing.Point(367, 188);
            this.ggBtnCmdAmpsMemRCL.Name = "ggBtnCmdAmpsMemRCL";
            this.ggBtnCmdAmpsMemRCL.Size = new System.Drawing.Size(60, 23);
            this.ggBtnCmdAmpsMemRCL.TabIndex = 16;
            this.ggBtnCmdAmpsMemRCL.Text = "RCL";
            this.ggBtnCmdAmpsMemRCL.UseVisualStyleBackColor = true;
            this.ggBtnCmdAmpsMemRCL.Click += new System.EventHandler(this.ggBtnCmdAmpsMemRCL_Click);
            // 
            // ggBtnCmdOhmsMemRCL
            // 
            this.ggBtnCmdOhmsMemRCL.Location = new System.Drawing.Point(367, 251);
            this.ggBtnCmdOhmsMemRCL.Name = "ggBtnCmdOhmsMemRCL";
            this.ggBtnCmdOhmsMemRCL.Size = new System.Drawing.Size(60, 23);
            this.ggBtnCmdOhmsMemRCL.TabIndex = 17;
            this.ggBtnCmdOhmsMemRCL.Text = "RCL";
            this.ggBtnCmdOhmsMemRCL.UseVisualStyleBackColor = true;
            this.ggBtnCmdOhmsMemRCL.Click += new System.EventHandler(this.ggBtnCmdOhmsMemRCL_Click);
            // 
            // ggBtnCmdVoltsMemSTO
            // 
            this.ggBtnCmdVoltsMemSTO.Location = new System.Drawing.Point(433, 122);
            this.ggBtnCmdVoltsMemSTO.Name = "ggBtnCmdVoltsMemSTO";
            this.ggBtnCmdVoltsMemSTO.Size = new System.Drawing.Size(56, 24);
            this.ggBtnCmdVoltsMemSTO.TabIndex = 18;
            this.ggBtnCmdVoltsMemSTO.Text = "STO";
            this.ggBtnCmdVoltsMemSTO.UseVisualStyleBackColor = true;
            this.ggBtnCmdVoltsMemSTO.Click += new System.EventHandler(this.ggBtnCmdVoltsMemSTO_Click);
            // 
            // ggBtnCmdAmpsMemSTO
            // 
            this.ggBtnCmdAmpsMemSTO.Location = new System.Drawing.Point(433, 188);
            this.ggBtnCmdAmpsMemSTO.Name = "ggBtnCmdAmpsMemSTO";
            this.ggBtnCmdAmpsMemSTO.Size = new System.Drawing.Size(56, 23);
            this.ggBtnCmdAmpsMemSTO.TabIndex = 19;
            this.ggBtnCmdAmpsMemSTO.Text = "STO";
            this.ggBtnCmdAmpsMemSTO.UseVisualStyleBackColor = true;
            this.ggBtnCmdAmpsMemSTO.Click += new System.EventHandler(this.ggBtnCmdAmpsMemSTO_Click);
            // 
            // ggBtnCmdOhmsMemSTO
            // 
            this.ggBtnCmdOhmsMemSTO.Location = new System.Drawing.Point(433, 251);
            this.ggBtnCmdOhmsMemSTO.Name = "ggBtnCmdOhmsMemSTO";
            this.ggBtnCmdOhmsMemSTO.Size = new System.Drawing.Size(56, 23);
            this.ggBtnCmdOhmsMemSTO.TabIndex = 20;
            this.ggBtnCmdOhmsMemSTO.Text = "STO";
            this.ggBtnCmdOhmsMemSTO.UseVisualStyleBackColor = true;
            this.ggBtnCmdOhmsMemSTO.Click += new System.EventHandler(this.ggBtnCmdOhmsMemSTO_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 388);
            this.Controls.Add(this.ggBtnCmdOhmsMemSTO);
            this.Controls.Add(this.ggBtnCmdAmpsMemSTO);
            this.Controls.Add(this.ggBtnCmdVoltsMemSTO);
            this.Controls.Add(this.ggBtnCmdOhmsMemRCL);
            this.Controls.Add(this.ggBtnCmdAmpsMemRCL);
            this.Controls.Add(this.ggBtnCmdVoltsMemRCL);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ggDataOutTxtLblMem);
            this.Controls.Add(this.ggBtnCmdExit);
            this.Controls.Add(this.ggDataOutLblWatts);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ggBtnCmdCalcOhms);
            this.Controls.Add(this.ggBtnCmdCalcAmps);
            this.Controls.Add(this.ggCmdBtnCalcVolts);
            this.Controls.Add(this.ggTxtDataInOhms);
            this.Controls.Add(this.ggTxtDataInAmps);
            this.Controls.Add(this.ggTxtDataInVolts);
            this.Controls.Add(this.ggRSWResistanceSelector);
            this.Controls.Add(this.ggRSWCurrentSelector);
            this.Controls.Add(this.ggRSWVoltageSelector);
            this.Name = "Form1";
            this.Text = "Ohm\'s Law Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton ggRSWVoltageSelector;
        private System.Windows.Forms.RadioButton ggRSWCurrentSelector;
        private System.Windows.Forms.RadioButton ggRSWResistanceSelector;
        private System.Windows.Forms.TextBox ggTxtDataInVolts;
        private System.Windows.Forms.TextBox ggTxtDataInAmps;
        private System.Windows.Forms.TextBox ggTxtDataInOhms;
        private System.Windows.Forms.Button ggCmdBtnCalcVolts;
        private System.Windows.Forms.Button ggBtnCmdCalcAmps;
        private System.Windows.Forms.Button ggBtnCmdCalcOhms;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ggDataOutLblWatts;
        private System.Windows.Forms.Button ggBtnCmdExit;
        private System.Windows.Forms.TextBox ggDataOutTxtLblMem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ggBtnCmdVoltsMemRCL;
        private System.Windows.Forms.Button ggBtnCmdAmpsMemRCL;
        private System.Windows.Forms.Button ggBtnCmdOhmsMemRCL;
        private System.Windows.Forms.Button ggBtnCmdVoltsMemSTO;
        private System.Windows.Forms.Button ggBtnCmdAmpsMemSTO;
        private System.Windows.Forms.Button ggBtnCmdOhmsMemSTO;
    }
}

