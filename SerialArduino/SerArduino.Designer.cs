namespace SerialArduino
{
    partial class FormMain
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Liberare le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCOM = new System.Windows.Forms.Label();
            this.edtCom = new System.Windows.Forms.TextBox();
            this.edtBauds = new System.Windows.Forms.TextBox();
            this.lblBauds = new System.Windows.Forms.Label();
            this.grbConfig = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblCMD = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.lsbReceivedData = new System.Windows.Forms.ListBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lsbSentData = new System.Windows.Forms.ListBox();
            this.lblSentData = new System.Windows.Forms.Label();
            this.lblReceivedData = new System.Windows.Forms.Label();
            this.grbConfig.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCOM
            // 
            this.lblCOM.AutoSize = true;
            this.lblCOM.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCOM.Location = new System.Drawing.Point(21, 22);
            this.lblCOM.Name = "lblCOM";
            this.lblCOM.Size = new System.Drawing.Size(48, 18);
            this.lblCOM.TabIndex = 0;
            this.lblCOM.Text = "COM:";
            // 
            // edtCom
            // 
            this.edtCom.Location = new System.Drawing.Point(86, 20);
            this.edtCom.Name = "edtCom";
            this.edtCom.Size = new System.Drawing.Size(100, 20);
            this.edtCom.TabIndex = 1;
            // 
            // edtBauds
            // 
            this.edtBauds.Location = new System.Drawing.Point(86, 55);
            this.edtBauds.Name = "edtBauds";
            this.edtBauds.Size = new System.Drawing.Size(100, 20);
            this.edtBauds.TabIndex = 3;
            // 
            // lblBauds
            // 
            this.lblBauds.AutoSize = true;
            this.lblBauds.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBauds.Location = new System.Drawing.Point(21, 55);
            this.lblBauds.Name = "lblBauds";
            this.lblBauds.Size = new System.Drawing.Size(59, 18);
            this.lblBauds.TabIndex = 2;
            this.lblBauds.Text = "BAUDS";
            // 
            // grbConfig
            // 
            this.grbConfig.Controls.Add(this.btnSave);
            this.grbConfig.Controls.Add(this.edtCom);
            this.grbConfig.Controls.Add(this.edtBauds);
            this.grbConfig.Controls.Add(this.lblCOM);
            this.grbConfig.Controls.Add(this.lblBauds);
            this.grbConfig.Location = new System.Drawing.Point(16, 43);
            this.grbConfig.Name = "grbConfig";
            this.grbConfig.Size = new System.Drawing.Size(287, 99);
            this.grbConfig.TabIndex = 4;
            this.grbConfig.TabStop = false;
            this.grbConfig.Text = "Config";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(102, 203);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            // 
            // lblCMD
            // 
            this.lblCMD.AutoSize = true;
            this.lblCMD.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCMD.Location = new System.Drawing.Point(37, 206);
            this.lblCMD.Name = "lblCMD";
            this.lblCMD.Size = new System.Drawing.Size(43, 18);
            this.lblCMD.TabIndex = 4;
            this.lblCMD.Text = "CMD";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(222, 200);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 6;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            // 
            // lsbReceivedData
            // 
            this.lsbReceivedData.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lsbReceivedData.FormattingEnabled = true;
            this.lsbReceivedData.Location = new System.Drawing.Point(487, 62);
            this.lsbReceivedData.Name = "lsbReceivedData";
            this.lsbReceivedData.Size = new System.Drawing.Size(120, 173);
            this.lsbReceivedData.TabIndex = 7;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(206, 55);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // lsbSentData
            // 
            this.lsbSentData.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lsbSentData.FormattingEnabled = true;
            this.lsbSentData.Location = new System.Drawing.Point(326, 62);
            this.lsbSentData.Name = "lsbSentData";
            this.lsbSentData.Size = new System.Drawing.Size(120, 173);
            this.lsbSentData.TabIndex = 8;
            // 
            // lblSentData
            // 
            this.lblSentData.AutoSize = true;
            this.lblSentData.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSentData.Location = new System.Drawing.Point(353, 36);
            this.lblSentData.Name = "lblSentData";
            this.lblSentData.Size = new System.Drawing.Size(70, 18);
            this.lblSentData.TabIndex = 9;
            this.lblSentData.Text = "Sent data";
            // 
            // lblReceivedData
            // 
            this.lblReceivedData.AutoSize = true;
            this.lblReceivedData.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReceivedData.Location = new System.Drawing.Point(496, 36);
            this.lblReceivedData.Name = "lblReceivedData";
            this.lblReceivedData.Size = new System.Drawing.Size(101, 18);
            this.lblReceivedData.TabIndex = 10;
            this.lblReceivedData.Text = "Received data";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 293);
            this.Controls.Add(this.lblReceivedData);
            this.Controls.Add(this.lblSentData);
            this.Controls.Add(this.lsbSentData);
            this.Controls.Add(this.lsbReceivedData);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblCMD);
            this.Controls.Add(this.grbConfig);
            this.Name = "FormMain";
            this.Text = "Arduino";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.grbConfig.ResumeLayout(false);
            this.grbConfig.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCOM;
        private System.Windows.Forms.TextBox edtCom;
        private System.Windows.Forms.TextBox edtBauds;
        private System.Windows.Forms.Label lblBauds;
        private System.Windows.Forms.GroupBox grbConfig;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblCMD;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.ListBox lsbReceivedData;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ListBox lsbSentData;
        private System.Windows.Forms.Label lblSentData;
        private System.Windows.Forms.Label lblReceivedData;
    }
}

