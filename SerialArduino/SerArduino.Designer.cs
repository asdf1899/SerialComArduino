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
            this.btnSave = new System.Windows.Forms.Button();
            this.edtCMD = new System.Windows.Forms.TextBox();
            this.lblCMD = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.lsbReceivedData = new System.Windows.Forms.ListBox();
            this.lsbSentData = new System.Windows.Forms.ListBox();
            this.lblSentData = new System.Windows.Forms.Label();
            this.lblReceivedData = new System.Windows.Forms.Label();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.asdfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnReceive = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.grbConfig.SuspendLayout();
            this.menu.SuspendLayout();
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
            this.edtCom.BackColor = System.Drawing.Color.Honeydew;
            this.edtCom.Location = new System.Drawing.Point(97, 20);
            this.edtCom.Name = "edtCom";
            this.edtCom.Size = new System.Drawing.Size(120, 20);
            this.edtCom.TabIndex = 1;
            // 
            // edtBauds
            // 
            this.edtBauds.BackColor = System.Drawing.Color.Honeydew;
            this.edtBauds.Location = new System.Drawing.Point(97, 55);
            this.edtBauds.Name = "edtBauds";
            this.edtBauds.Size = new System.Drawing.Size(120, 20);
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
            this.grbConfig.BackColor = System.Drawing.Color.SeaGreen;
            this.grbConfig.Controls.Add(this.btnSave);
            this.grbConfig.Controls.Add(this.edtCom);
            this.grbConfig.Controls.Add(this.edtBauds);
            this.grbConfig.Controls.Add(this.lblCOM);
            this.grbConfig.Controls.Add(this.lblBauds);
            this.grbConfig.Location = new System.Drawing.Point(16, 43);
            this.grbConfig.Name = "grbConfig";
            this.grbConfig.Size = new System.Drawing.Size(337, 99);
            this.grbConfig.TabIndex = 4;
            this.grbConfig.TabStop = false;
            this.grbConfig.Text = "Config";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Honeydew;
            this.btnSave.Location = new System.Drawing.Point(240, 55);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // edtCMD
            // 
            this.edtCMD.BackColor = System.Drawing.Color.Honeydew;
            this.edtCMD.Location = new System.Drawing.Point(113, 169);
            this.edtCMD.Name = "edtCMD";
            this.edtCMD.Size = new System.Drawing.Size(120, 20);
            this.edtCMD.TabIndex = 5;
            // 
            // lblCMD
            // 
            this.lblCMD.AutoSize = true;
            this.lblCMD.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCMD.Location = new System.Drawing.Point(37, 171);
            this.lblCMD.Name = "lblCMD";
            this.lblCMD.Size = new System.Drawing.Size(43, 18);
            this.lblCMD.TabIndex = 4;
            this.lblCMD.Text = "CMD";
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.Honeydew;
            this.btnSend.Location = new System.Drawing.Point(256, 165);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 6;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // lsbReceivedData
            // 
            this.lsbReceivedData.BackColor = System.Drawing.Color.Honeydew;
            this.lsbReceivedData.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lsbReceivedData.FormattingEnabled = true;
            this.lsbReceivedData.Location = new System.Drawing.Point(553, 231);
            this.lsbReceivedData.Name = "lsbReceivedData";
            this.lsbReceivedData.Size = new System.Drawing.Size(120, 173);
            this.lsbReceivedData.TabIndex = 7;
            // 
            // lsbSentData
            // 
            this.lsbSentData.BackColor = System.Drawing.Color.Honeydew;
            this.lsbSentData.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lsbSentData.FormattingEnabled = true;
            this.lsbSentData.Location = new System.Drawing.Point(113, 231);
            this.lsbSentData.Name = "lsbSentData";
            this.lsbSentData.Size = new System.Drawing.Size(120, 173);
            this.lsbSentData.TabIndex = 8;
            // 
            // lblSentData
            // 
            this.lblSentData.AutoSize = true;
            this.lblSentData.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSentData.Location = new System.Drawing.Point(37, 231);
            this.lblSentData.Name = "lblSentData";
            this.lblSentData.Size = new System.Drawing.Size(70, 18);
            this.lblSentData.TabIndex = 9;
            this.lblSentData.Text = "Sent data";
            // 
            // lblReceivedData
            // 
            this.lblReceivedData.AutoSize = true;
            this.lblReceivedData.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReceivedData.Location = new System.Drawing.Point(433, 231);
            this.lblReceivedData.Name = "lblReceivedData";
            this.lblReceivedData.Size = new System.Drawing.Size(101, 18);
            this.lblReceivedData.TabIndex = 10;
            this.lblReceivedData.Text = "Received data";
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.asdfToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(702, 24);
            this.menu.TabIndex = 11;
            this.menu.Text = "Menu";
            // 
            // asdfToolStripMenuItem
            // 
            this.asdfToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitToolStripMenuItem});
            this.asdfToolStripMenuItem.Name = "asdfToolStripMenuItem";
            this.asdfToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.asdfToolStripMenuItem.Text = "File";
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.BackColor = System.Drawing.Color.Honeydew;
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(97, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.BackColor = System.Drawing.Color.Honeydew;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // btnReceive
            // 
            this.btnReceive.BackColor = System.Drawing.Color.Honeydew;
            this.btnReceive.Location = new System.Drawing.Point(436, 293);
            this.btnReceive.Name = "btnReceive";
            this.btnReceive.Size = new System.Drawing.Size(75, 23);
            this.btnReceive.TabIndex = 12;
            this.btnReceive.Text = "Receive";
            this.btnReceive.UseVisualStyleBackColor = false;
            this.btnReceive.Click += new System.EventHandler(this.btnReceive_Click);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.Honeydew;
            this.btnStop.Location = new System.Drawing.Point(436, 336);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 13;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Honeydew;
            this.btnClear.Location = new System.Drawing.Point(436, 381);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(702, 420);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnReceive);
            this.Controls.Add(this.lblReceivedData);
            this.Controls.Add(this.lblSentData);
            this.Controls.Add(this.lsbSentData);
            this.Controls.Add(this.lsbReceivedData);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.edtCMD);
            this.Controls.Add(this.lblCMD);
            this.Controls.Add(this.grbConfig);
            this.Controls.Add(this.menu);
            this.MainMenuStrip = this.menu;
            this.Name = "FormMain";
            this.Text = "Arduino";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.grbConfig.ResumeLayout(false);
            this.grbConfig.PerformLayout();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCOM;
        private System.Windows.Forms.TextBox edtCom;
        private System.Windows.Forms.TextBox edtBauds;
        private System.Windows.Forms.Label lblBauds;
        private System.Windows.Forms.GroupBox grbConfig;
        private System.Windows.Forms.TextBox edtCMD;
        private System.Windows.Forms.Label lblCMD;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.ListBox lsbReceivedData;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ListBox lsbSentData;
        private System.Windows.Forms.Label lblSentData;
        private System.Windows.Forms.Label lblReceivedData;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem asdfToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button btnReceive;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnClear;
    }
}

