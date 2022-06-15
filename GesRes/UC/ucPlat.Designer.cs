
namespace GesRes.UC
{
    partial class ucPlat
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnModifier = new System.Windows.Forms.Button();
            this.bntSupprimer = new System.Windows.Forms.Button();
            this.PlatpictureBox = new System.Windows.Forms.PictureBox();
            this.Type_Plat_Label = new System.Windows.Forms.Label();
            this.LibelleLabel = new System.Windows.Forms.Label();
            this.PrixLabel = new System.Windows.Forms.Label();
            this.CurrencyLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PlatpictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btnModifier
            // 
            this.btnModifier.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnModifier.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifier.Location = new System.Drawing.Point(480, 75);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(121, 39);
            this.btnModifier.TabIndex = 12;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = false;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // bntSupprimer
            // 
            this.bntSupprimer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bntSupprimer.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntSupprimer.Location = new System.Drawing.Point(480, 21);
            this.bntSupprimer.Name = "bntSupprimer";
            this.bntSupprimer.Size = new System.Drawing.Size(121, 39);
            this.bntSupprimer.TabIndex = 11;
            this.bntSupprimer.Text = "Supprimer";
            this.bntSupprimer.UseVisualStyleBackColor = false;
            this.bntSupprimer.Click += new System.EventHandler(this.bntSupprimer_Click);
            // 
            // PlatpictureBox
            // 
            this.PlatpictureBox.Image = global::GesRes.Properties.Resources.Plat;
            this.PlatpictureBox.Location = new System.Drawing.Point(29, 12);
            this.PlatpictureBox.Name = "PlatpictureBox";
            this.PlatpictureBox.Size = new System.Drawing.Size(106, 102);
            this.PlatpictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PlatpictureBox.TabIndex = 10;
            this.PlatpictureBox.TabStop = false;
            // 
            // Type_Plat_Label
            // 
            this.Type_Plat_Label.AutoSize = true;
            this.Type_Plat_Label.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Type_Plat_Label.Location = new System.Drawing.Point(178, 56);
            this.Type_Plat_Label.Name = "Type_Plat_Label";
            this.Type_Plat_Label.Size = new System.Drawing.Size(109, 29);
            this.Type_Plat_Label.TabIndex = 13;
            this.Type_Plat_Label.Text = "Type_Plat";
            // 
            // LibelleLabel
            // 
            this.LibelleLabel.AutoSize = true;
            this.LibelleLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LibelleLabel.Location = new System.Drawing.Point(178, 12);
            this.LibelleLabel.Name = "LibelleLabel";
            this.LibelleLabel.Size = new System.Drawing.Size(74, 29);
            this.LibelleLabel.TabIndex = 14;
            this.LibelleLabel.Text = "Libelle";
            // 
            // PrixLabel
            // 
            this.PrixLabel.AutoSize = true;
            this.PrixLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrixLabel.Location = new System.Drawing.Point(178, 98);
            this.PrixLabel.Name = "PrixLabel";
            this.PrixLabel.Size = new System.Drawing.Size(52, 29);
            this.PrixLabel.TabIndex = 15;
            this.PrixLabel.Text = "Prix";
            // 
            // CurrencyLabel
            // 
            this.CurrencyLabel.AutoSize = true;
            this.CurrencyLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrencyLabel.Location = new System.Drawing.Point(236, 98);
            this.CurrencyLabel.Name = "CurrencyLabel";
            this.CurrencyLabel.Size = new System.Drawing.Size(42, 29);
            this.CurrencyLabel.TabIndex = 16;
            this.CurrencyLabel.Text = "DH";
            // 
            // ucPlat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.CurrencyLabel);
            this.Controls.Add(this.PrixLabel);
            this.Controls.Add(this.LibelleLabel);
            this.Controls.Add(this.Type_Plat_Label);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.bntSupprimer);
            this.Controls.Add(this.PlatpictureBox);
            this.Name = "ucPlat";
            this.Size = new System.Drawing.Size(638, 145);
            this.Load += new System.EventHandler(this.ucPlat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PlatpictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button bntSupprimer;
        private System.Windows.Forms.PictureBox PlatpictureBox;
        private System.Windows.Forms.Label Type_Plat_Label;
        private System.Windows.Forms.Label LibelleLabel;
        private System.Windows.Forms.Label PrixLabel;
        private System.Windows.Forms.Label CurrencyLabel;
    }
}
