
namespace GesRes
{
    partial class PlatsForm
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
            this.PlatHeaderPanel = new System.Windows.Forms.Panel();
            this.PlatpictureBox = new System.Windows.Forms.PictureBox();
            this.PlatTitleLabel = new System.Windows.Forms.Label();
            this.BrandpictureBox = new System.Windows.Forms.PictureBox();
            this.PlatFormpanel = new System.Windows.Forms.Panel();
            this.PrixTextBox = new System.Windows.Forms.TextBox();
            this.PrixLabel = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.Type_Plat_Label = new System.Windows.Forms.Label();
            this.Type_PlatTextBox = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.Libelle_Label = new System.Windows.Forms.Label();
            this.LibelleTextBox = new System.Windows.Forms.TextBox();
            this.PlatsListpanel = new System.Windows.Forms.Panel();
            this.PlatHeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PlatpictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BrandpictureBox)).BeginInit();
            this.PlatFormpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // PlatHeaderPanel
            // 
            this.PlatHeaderPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PlatHeaderPanel.Controls.Add(this.PlatpictureBox);
            this.PlatHeaderPanel.Controls.Add(this.PlatTitleLabel);
            this.PlatHeaderPanel.Controls.Add(this.BrandpictureBox);
            this.PlatHeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.PlatHeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.PlatHeaderPanel.Name = "PlatHeaderPanel";
            this.PlatHeaderPanel.Size = new System.Drawing.Size(1051, 134);
            this.PlatHeaderPanel.TabIndex = 1;
            // 
            // PlatpictureBox
            // 
            this.PlatpictureBox.Image = global::GesRes.Properties.Resources.Plat;
            this.PlatpictureBox.Location = new System.Drawing.Point(930, 12);
            this.PlatpictureBox.Name = "PlatpictureBox";
            this.PlatpictureBox.Size = new System.Drawing.Size(106, 102);
            this.PlatpictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PlatpictureBox.TabIndex = 4;
            this.PlatpictureBox.TabStop = false;
            // 
            // PlatTitleLabel
            // 
            this.PlatTitleLabel.AutoSize = true;
            this.PlatTitleLabel.Font = new System.Drawing.Font("Comic Sans MS", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlatTitleLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PlatTitleLabel.Location = new System.Drawing.Point(375, 41);
            this.PlatTitleLabel.Name = "PlatTitleLabel";
            this.PlatTitleLabel.Size = new System.Drawing.Size(293, 45);
            this.PlatTitleLabel.TabIndex = 2;
            this.PlatTitleLabel.Text = "Gestion des Plats";
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
            // PlatFormpanel
            // 
            this.PlatFormpanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PlatFormpanel.Controls.Add(this.PrixTextBox);
            this.PlatFormpanel.Controls.Add(this.PrixLabel);
            this.PlatFormpanel.Controls.Add(this.btnUpdate);
            this.PlatFormpanel.Controls.Add(this.Type_Plat_Label);
            this.PlatFormpanel.Controls.Add(this.Type_PlatTextBox);
            this.PlatFormpanel.Controls.Add(this.btnSubmit);
            this.PlatFormpanel.Controls.Add(this.Libelle_Label);
            this.PlatFormpanel.Controls.Add(this.LibelleTextBox);
            this.PlatFormpanel.Location = new System.Drawing.Point(37, 182);
            this.PlatFormpanel.Name = "PlatFormpanel";
            this.PlatFormpanel.Size = new System.Drawing.Size(308, 360);
            this.PlatFormpanel.TabIndex = 3;
            // 
            // PrixTextBox
            // 
            this.PrixTextBox.Location = new System.Drawing.Point(28, 213);
            this.PrixTextBox.Name = "PrixTextBox";
            this.PrixTextBox.Size = new System.Drawing.Size(221, 22);
            this.PrixTextBox.TabIndex = 7;
            // 
            // PrixLabel
            // 
            this.PrixLabel.AutoSize = true;
            this.PrixLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrixLabel.Location = new System.Drawing.Point(23, 171);
            this.PrixLabel.Name = "PrixLabel";
            this.PrixLabel.Size = new System.Drawing.Size(52, 29);
            this.PrixLabel.TabIndex = 6;
            this.PrixLabel.Text = "Prix";
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
            // Type_Plat_Label
            // 
            this.Type_Plat_Label.AutoSize = true;
            this.Type_Plat_Label.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Type_Plat_Label.Location = new System.Drawing.Point(23, 92);
            this.Type_Plat_Label.Name = "Type_Plat_Label";
            this.Type_Plat_Label.Size = new System.Drawing.Size(136, 29);
            this.Type_Plat_Label.TabIndex = 4;
            this.Type_Plat_Label.Text = "Type du Plat";
            // 
            // Type_PlatTextBox
            // 
            this.Type_PlatTextBox.Location = new System.Drawing.Point(28, 124);
            this.Type_PlatTextBox.Name = "Type_PlatTextBox";
            this.Type_PlatTextBox.Size = new System.Drawing.Size(221, 22);
            this.Type_PlatTextBox.TabIndex = 3;
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
            // Libelle_Label
            // 
            this.Libelle_Label.AutoSize = true;
            this.Libelle_Label.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Libelle_Label.Location = new System.Drawing.Point(23, 16);
            this.Libelle_Label.Name = "Libelle_Label";
            this.Libelle_Label.Size = new System.Drawing.Size(74, 29);
            this.Libelle_Label.TabIndex = 1;
            this.Libelle_Label.Text = "Libellé";
            // 
            // LibelleTextBox
            // 
            this.LibelleTextBox.Location = new System.Drawing.Point(28, 48);
            this.LibelleTextBox.Name = "LibelleTextBox";
            this.LibelleTextBox.Size = new System.Drawing.Size(221, 22);
            this.LibelleTextBox.TabIndex = 0;
            // 
            // PlatsListpanel
            // 
            this.PlatsListpanel.AutoScroll = true;
            this.PlatsListpanel.Location = new System.Drawing.Point(392, 152);
            this.PlatsListpanel.Name = "PlatsListpanel";
            this.PlatsListpanel.Size = new System.Drawing.Size(634, 419);
            this.PlatsListpanel.TabIndex = 4;
            // 
            // PlatsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 593);
            this.Controls.Add(this.PlatsListpanel);
            this.Controls.Add(this.PlatFormpanel);
            this.Controls.Add(this.PlatHeaderPanel);
            this.Name = "PlatsForm";
            this.Text = "PlatsForm";
            this.Load += new System.EventHandler(this.PlatsForm_Load);
            this.PlatHeaderPanel.ResumeLayout(false);
            this.PlatHeaderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PlatpictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BrandpictureBox)).EndInit();
            this.PlatFormpanel.ResumeLayout(false);
            this.PlatFormpanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PlatHeaderPanel;
        private System.Windows.Forms.PictureBox PlatpictureBox;
        private System.Windows.Forms.Label PlatTitleLabel;
        private System.Windows.Forms.PictureBox BrandpictureBox;
        private System.Windows.Forms.Panel PlatFormpanel;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label Type_Plat_Label;
        private System.Windows.Forms.TextBox Type_PlatTextBox;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label Libelle_Label;
        private System.Windows.Forms.TextBox LibelleTextBox;
        private System.Windows.Forms.Label PrixLabel;
        private System.Windows.Forms.TextBox PrixTextBox;
        private System.Windows.Forms.Panel PlatsListpanel;
    }
}