namespace Pong
{
    partial class EinstellungenDialog
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonMaximal = new System.Windows.Forms.RadioButton();
            this.radioButton1024 = new System.Windows.Forms.RadioButton();
            this.radioButton640 = new System.Windows.Forms.RadioButton();
            this.radioButton320 = new System.Windows.Forms.RadioButton();
            this.buttonAbbrechen = new System.Windows.Forms.Button();
            this.buttonUebernehmen = new System.Windows.Forms.Button();
            this.groupBoxFarben = new System.Windows.Forms.GroupBox();
            this.buttonSpielfeld = new System.Windows.Forms.Button();
            this.buttonBallSclaegerLinie = new System.Windows.Forms.Button();
            this.lblSpielfeld = new System.Windows.Forms.Label();
            this.lblRahmen = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.VorLiniePanel = new System.Windows.Forms.Panel();
            this.VorSpielfeldPanel = new System.Windows.Forms.Panel();
            this.VorSchalegerPanel = new System.Windows.Forms.Panel();
            this.VorBallPanel = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.groupBoxFarben.SuspendLayout();
            this.VorLiniePanel.SuspendLayout();
            this.VorSpielfeldPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonMaximal);
            this.groupBox1.Controls.Add(this.radioButton1024);
            this.groupBox1.Controls.Add(this.radioButton640);
            this.groupBox1.Controls.Add(this.radioButton320);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(325, 77);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Größe";
            // 
            // radioButtonMaximal
            // 
            this.radioButtonMaximal.AutoSize = true;
            this.radioButtonMaximal.Location = new System.Drawing.Point(252, 30);
            this.radioButtonMaximal.Name = "radioButtonMaximal";
            this.radioButtonMaximal.Size = new System.Drawing.Size(63, 17);
            this.radioButtonMaximal.TabIndex = 3;
            this.radioButtonMaximal.Text = "Maximal";
            this.radioButtonMaximal.UseVisualStyleBackColor = true;
            // 
            // radioButton1024
            // 
            this.radioButton1024.AutoSize = true;
            this.radioButton1024.Location = new System.Drawing.Point(169, 30);
            this.radioButton1024.Name = "radioButton1024";
            this.radioButton1024.Size = new System.Drawing.Size(77, 17);
            this.radioButton1024.TabIndex = 2;
            this.radioButton1024.Text = "1024 * 768";
            this.radioButton1024.UseVisualStyleBackColor = true;
            // 
            // radioButton640
            // 
            this.radioButton640.AutoSize = true;
            this.radioButton640.Checked = true;
            this.radioButton640.Location = new System.Drawing.Point(92, 30);
            this.radioButton640.Name = "radioButton640";
            this.radioButton640.Size = new System.Drawing.Size(71, 17);
            this.radioButton640.TabIndex = 1;
            this.radioButton640.TabStop = true;
            this.radioButton640.Text = "640 * 480";
            this.radioButton640.UseVisualStyleBackColor = true;
            // 
            // radioButton320
            // 
            this.radioButton320.AutoSize = true;
            this.radioButton320.Location = new System.Drawing.Point(15, 30);
            this.radioButton320.Name = "radioButton320";
            this.radioButton320.Size = new System.Drawing.Size(71, 17);
            this.radioButton320.TabIndex = 0;
            this.radioButton320.Text = "320 * 200";
            this.radioButton320.UseVisualStyleBackColor = true;
            // 
            // buttonAbbrechen
            // 
            this.buttonAbbrechen.Location = new System.Drawing.Point(263, 296);
            this.buttonAbbrechen.Name = "buttonAbbrechen";
            this.buttonAbbrechen.Size = new System.Drawing.Size(75, 23);
            this.buttonAbbrechen.TabIndex = 5;
            this.buttonAbbrechen.Text = "Abbrechen";
            this.buttonAbbrechen.UseVisualStyleBackColor = true;
            this.buttonAbbrechen.Click += new System.EventHandler(this.ButtonAbbrechen_Click);
            // 
            // buttonUebernehmen
            // 
            this.buttonUebernehmen.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonUebernehmen.Location = new System.Drawing.Point(12, 296);
            this.buttonUebernehmen.Name = "buttonUebernehmen";
            this.buttonUebernehmen.Size = new System.Drawing.Size(85, 23);
            this.buttonUebernehmen.TabIndex = 4;
            this.buttonUebernehmen.Text = "Übernehmen";
            this.buttonUebernehmen.UseVisualStyleBackColor = true;
            // 
            // groupBoxFarben
            // 
            this.groupBoxFarben.Controls.Add(this.buttonSpielfeld);
            this.groupBoxFarben.Controls.Add(this.buttonBallSclaegerLinie);
            this.groupBoxFarben.Controls.Add(this.lblSpielfeld);
            this.groupBoxFarben.Controls.Add(this.lblRahmen);
            this.groupBoxFarben.Location = new System.Drawing.Point(12, 102);
            this.groupBoxFarben.Name = "groupBoxFarben";
            this.groupBoxFarben.Size = new System.Drawing.Size(324, 78);
            this.groupBoxFarben.TabIndex = 6;
            this.groupBoxFarben.TabStop = false;
            this.groupBoxFarben.Text = "Farben";
            // 
            // buttonSpielfeld
            // 
            this.buttonSpielfeld.Location = new System.Drawing.Point(63, 48);
            this.buttonSpielfeld.Name = "buttonSpielfeld";
            this.buttonSpielfeld.Size = new System.Drawing.Size(27, 24);
            this.buttonSpielfeld.TabIndex = 3;
            this.buttonSpielfeld.Text = "...";
            this.buttonSpielfeld.UseVisualStyleBackColor = true;
            this.buttonSpielfeld.Click += new System.EventHandler(this.ButtonSpielfeld_Click);
            // 
            // buttonBallSclaegerLinie
            // 
            this.buttonBallSclaegerLinie.Location = new System.Drawing.Point(61, 11);
            this.buttonBallSclaegerLinie.Name = "buttonBallSclaegerLinie";
            this.buttonBallSclaegerLinie.Size = new System.Drawing.Size(30, 23);
            this.buttonBallSclaegerLinie.TabIndex = 2;
            this.buttonBallSclaegerLinie.Text = "...";
            this.buttonBallSclaegerLinie.UseVisualStyleBackColor = true;
            this.buttonBallSclaegerLinie.Click += new System.EventHandler(this.ButtonBallSclaegerLinie_Click);
            // 
            // lblSpielfeld
            // 
            this.lblSpielfeld.AutoSize = true;
            this.lblSpielfeld.Location = new System.Drawing.Point(8, 54);
            this.lblSpielfeld.Name = "lblSpielfeld";
            this.lblSpielfeld.Size = new System.Drawing.Size(47, 13);
            this.lblSpielfeld.TabIndex = 1;
            this.lblSpielfeld.Text = "Spielfeld";
            // 
            // lblRahmen
            // 
            this.lblRahmen.AutoSize = true;
            this.lblRahmen.Location = new System.Drawing.Point(8, 16);
            this.lblRahmen.Name = "lblRahmen";
            this.lblRahmen.Size = new System.Drawing.Size(47, 13);
            this.lblRahmen.TabIndex = 0;
            this.lblRahmen.Text = "Rahmen";
            // 
            // VorLiniePanel
            // 
            this.VorLiniePanel.Controls.Add(this.VorSpielfeldPanel);
            this.VorLiniePanel.Location = new System.Drawing.Point(21, 202);
            this.VorLiniePanel.Name = "VorLiniePanel";
            this.VorLiniePanel.Size = new System.Drawing.Size(315, 84);
            this.VorLiniePanel.TabIndex = 7;
            // 
            // VorSpielfeldPanel
            // 
            this.VorSpielfeldPanel.Controls.Add(this.VorBallPanel);
            this.VorSpielfeldPanel.Controls.Add(this.VorSchalegerPanel);
            this.VorSpielfeldPanel.Location = new System.Drawing.Point(9, 11);
            this.VorSpielfeldPanel.Name = "VorSpielfeldPanel";
            this.VorSpielfeldPanel.Size = new System.Drawing.Size(296, 61);
            this.VorSpielfeldPanel.TabIndex = 0;
            // 
            // VorSchalegerPanel
            // 
            this.VorSchalegerPanel.Location = new System.Drawing.Point(4, 16);
            this.VorSchalegerPanel.Name = "VorSchalegerPanel";
            this.VorSchalegerPanel.Size = new System.Drawing.Size(11, 44);
            this.VorSchalegerPanel.TabIndex = 0;
            // 
            // VorBallPanel
            // 
            this.VorBallPanel.Location = new System.Drawing.Point(43, 32);
            this.VorBallPanel.Name = "VorBallPanel";
            this.VorBallPanel.Size = new System.Drawing.Size(13, 13);
            this.VorBallPanel.TabIndex = 1;
            // 
            // EinstellungenDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 331);
            this.ControlBox = false;
            this.Controls.Add(this.VorLiniePanel);
            this.Controls.Add(this.groupBoxFarben);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonAbbrechen);
            this.Controls.Add(this.buttonUebernehmen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "EinstellungenDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Spielfeld";
            this.TopMost = true;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxFarben.ResumeLayout(false);
            this.groupBoxFarben.PerformLayout();
            this.VorLiniePanel.ResumeLayout(false);
            this.VorSpielfeldPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonMaximal;
        private System.Windows.Forms.RadioButton radioButton1024;
        private System.Windows.Forms.RadioButton radioButton640;
        private System.Windows.Forms.RadioButton radioButton320;
        private System.Windows.Forms.Button buttonAbbrechen;
        private System.Windows.Forms.Button buttonUebernehmen;
        private System.Windows.Forms.GroupBox groupBoxFarben;
        private System.Windows.Forms.Button buttonSpielfeld;
        private System.Windows.Forms.Button buttonBallSclaegerLinie;
        private System.Windows.Forms.Label lblSpielfeld;
        private System.Windows.Forms.Label lblRahmen;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ColorDialog colorDialog2;
        private System.Windows.Forms.Panel VorLiniePanel;
        private System.Windows.Forms.Panel VorSpielfeldPanel;
        private System.Windows.Forms.Panel VorBallPanel;
        private System.Windows.Forms.Panel VorSchalegerPanel;
    }
}