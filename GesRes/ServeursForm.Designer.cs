
namespace GesRes
{
    partial class ServeursForm
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
            this.ServeurHeaderPanel = new System.Windows.Forms.Panel();
            this.ServeurpictureBox = new System.Windows.Forms.PictureBox();
            this.ServeurTitleLabel = new System.Windows.Forms.Label();
            this.BrandpictureBox = new System.Windows.Forms.PictureBox();
            this.ServeursListpanel = new System.Windows.Forms.Panel();
            this.TablesFormpanel = new System.Windows.Forms.Panel();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.Prenom_Label = new System.Windows.Forms.Label();
            this.PrenomTextBox = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.Nom_Label = new System.Windows.Forms.Label();
            this.NomTextBox = new System.Windows.Forms.TextBox();
            this.ServeurHeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ServeurpictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BrandpictureBox)).BeginInit();
            this.TablesFormpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ServeurHeaderPanel
            // 
            this.ServeurHeaderPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ServeurHeaderPanel.Controls.Add(this.ServeurpictureBox);
            this.ServeurHeaderPanel.Controls.Add(this.ServeurTitleLabel);
            this.ServeurHeaderPanel.Controls.Add(this.BrandpictureBox);
            this.ServeurHeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ServeurHeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.ServeurHeaderPanel.Name = "ServeurHeaderPanel";
            this.ServeurHeaderPanel.Size = new System.Drawing.Size(1048, 134);
            this.ServeurHeaderPanel.TabIndex = 0;
            // 
            // ServeurpictureBox
            // 
            this.ServeurpictureBox.Image = global::GesRes.Properties.Resources.waiter;
            this.ServeurpictureBox.Location = new System.Drawing.Point(930, 12);
            this.ServeurpictureBox.Name = "ServeurpictureBox";
            this.ServeurpictureBox.Size = new System.Drawing.Size(106, 102);
            this.ServeurpictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ServeurpictureBox.TabIndex = 4;
            this.ServeurpictureBox.TabStop = false;
            // 
            // ServeurTitleLabel
            // 
            this.ServeurTitleLabel.AutoSize = true;
            this.ServeurTitleLabel.Font = new System.Drawing.Font("Comic Sans MS", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServeurTitleLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ServeurTitleLabel.Location = new System.Drawing.Point(347, 40);
            this.ServeurTitleLabel.Name = "ServeurTitleLabel";
            this.ServeurTitleLabel.Size = new System.Drawing.Size(356, 45);
            this.ServeurTitleLabel.TabIndex = 2;
            this.ServeurTitleLabel.Text = "Gestion des Serveurs";
            // 
            // BrandpictureBox
            // 
            this.BrandpictureBox.Image = global::GesRes.Properties.Resources.Brand;
            this.BrandpictureBox.Location = new System.Drawing.Point(12, 12);
            this.BrandpictureBox.Name = "BrandpictureBox";
            this.BrandpictureBox.Size = new System.Drawing.Size(108, 102);
            this.BrandpictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BrandpictureBox.TabIndex = 1;
            this.BrandpictureBox.TabStop = false;
            // 
            // ServeursListpanel
            // 
            this.ServeursListpanel.AutoScroll = true;
            this.ServeursListpanel.Location = new System.Drawing.Point(355, 153);
            this.ServeursListpanel.Name = "ServeursListpanel";
            this.ServeursListpanel.Size = new System.Drawing.Size(681, 459);
            this.ServeursListpanel.TabIndex = 1;
            // 
            // TablesFormpanel
            // 
            this.TablesFormpanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TablesFormpanel.Controls.Add(this.btnUpdate);
            this.TablesFormpanel.Controls.Add(this.Prenom_Label);
            this.TablesFormpanel.Controls.Add(this.PrenomTextBox);
            this.TablesFormpanel.Controls.Add(this.btnSubmit);
            this.TablesFormpanel.Controls.Add(this.Nom_Label);
            this.TablesFormpanel.Controls.Add(this.NomTextBox);
            this.TablesFormpanel.Location = new System.Drawing.Point(23, 153);
            this.TablesFormpanel.Name = "TablesFormpanel";
            this.TablesFormpanel.Size = new System.Drawing.Size(308, 360);
            this.TablesFormpanel.TabIndex = 2;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUpdate.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(97, 252);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(114, 39);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Modifier";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Visible = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // Prenom_Label
            // 
            this.Prenom_Label.AutoSize = true;
            this.Prenom_Label.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Prenom_Label.Location = new System.Drawing.Point(23, 120);
            this.Prenom_Label.Name = "Prenom_Label";
            this.Prenom_Label.Size = new System.Drawing.Size(82, 29);
            this.Prenom_Label.TabIndex = 4;
            this.Prenom_Label.Text = "Prénom";
            // 
            // PrenomTextBox
            // 
            this.PrenomTextBox.Location = new System.Drawing.Point(26, 175);
            this.PrenomTextBox.Name = "PrenomTextBox";
            this.PrenomTextBox.Size = new System.Drawing.Size(221, 22);
            this.PrenomTextBox.TabIndex = 3;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSubmit.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(97, 297);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(114, 39);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "Enregistrer";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // Nom_Label
            // 
            this.Nom_Label.AutoSize = true;
            this.Nom_Label.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nom_Label.Location = new System.Drawing.Point(23, 16);
            this.Nom_Label.Name = "Nom_Label";
            this.Nom_Label.Size = new System.Drawing.Size(56, 29);
            this.Nom_Label.TabIndex = 1;
            this.Nom_Label.Text = "Nom";
            // 
            // NomTextBox
            // 
            this.NomTextBox.Location = new System.Drawing.Point(26, 67);
            this.NomTextBox.Name = "NomTextBox";
            this.NomTextBox.Size = new System.Drawing.Size(221, 22);
            this.NomTextBox.TabIndex = 0;
            // 
            // ServeursForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 624);
            this.Controls.Add(this.TablesFormpanel);
            this.Controls.Add(this.ServeursListpanel);
            this.Controls.Add(this.ServeurHeaderPanel);
            this.Name = "ServeursForm";
            this.Text = "ServeursForm";
            this.Load += new System.EventHandler(this.ServeursForm_Load);
            this.ServeurHeaderPanel.ResumeLayout(false);
            this.ServeurHeaderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ServeurpictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BrandpictureBox)).EndInit();
            this.TablesFormpanel.ResumeLayout(false);
            this.TablesFormpanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ServeurHeaderPanel;
        private System.Windows.Forms.PictureBox BrandpictureBox;
        private System.Windows.Forms.Label ServeurTitleLabel;
        private System.Windows.Forms.PictureBox ServeurpictureBox;
        private System.Windows.Forms.Panel ServeursListpanel;
        private System.Windows.Forms.Panel TablesFormpanel;
        private System.Windows.Forms.Label Prenom_Label;
        private System.Windows.Forms.TextBox PrenomTextBox;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label Nom_Label;
        private System.Windows.Forms.TextBox NomTextBox;
        private System.Windows.Forms.Button btnUpdate;
    }
}