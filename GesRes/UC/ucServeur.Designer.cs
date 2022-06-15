
namespace GesRes.UC
{
    partial class ucServeur
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
            this.ServeurpictureBox = new System.Windows.Forms.PictureBox();
            this.Nom_Label = new System.Windows.Forms.Label();
            this.Prenom_Label = new System.Windows.Forms.Label();
            this.btnModifier = new System.Windows.Forms.Button();
            this.bntSupprimer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ServeurpictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ServeurpictureBox
            // 
            this.ServeurpictureBox.Image = global::GesRes.Properties.Resources.waiter;
            this.ServeurpictureBox.Location = new System.Drawing.Point(3, 5);
            this.ServeurpictureBox.Name = "ServeurpictureBox";
            this.ServeurpictureBox.Size = new System.Drawing.Size(106, 102);
            this.ServeurpictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ServeurpictureBox.TabIndex = 5;
            this.ServeurpictureBox.TabStop = false;
            // 
            // Nom_Label
            // 
            this.Nom_Label.AutoSize = true;
            this.Nom_Label.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nom_Label.Location = new System.Drawing.Point(155, 14);
            this.Nom_Label.Name = "Nom_Label";
            this.Nom_Label.Size = new System.Drawing.Size(56, 29);
            this.Nom_Label.TabIndex = 6;
            this.Nom_Label.Text = "Nom";
            // 
            // Prenom_Label
            // 
            this.Prenom_Label.AutoSize = true;
            this.Prenom_Label.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Prenom_Label.Location = new System.Drawing.Point(155, 58);
            this.Prenom_Label.Name = "Prenom_Label";
            this.Prenom_Label.Size = new System.Drawing.Size(82, 29);
            this.Prenom_Label.TabIndex = 7;
            this.Prenom_Label.Text = "Prénom";
            // 
            // btnModifier
            // 
            this.btnModifier.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnModifier.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifier.Location = new System.Drawing.Point(342, 56);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(123, 39);
            this.btnModifier.TabIndex = 9;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = false;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // bntSupprimer
            // 
            this.bntSupprimer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bntSupprimer.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntSupprimer.Location = new System.Drawing.Point(342, 11);
            this.bntSupprimer.Name = "bntSupprimer";
            this.bntSupprimer.Size = new System.Drawing.Size(123, 39);
            this.bntSupprimer.TabIndex = 8;
            this.bntSupprimer.Text = "Supprimer";
            this.bntSupprimer.UseVisualStyleBackColor = false;
            this.bntSupprimer.Click += new System.EventHandler(this.bntSupprimer_Click);
            // 
            // ucServeur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.bntSupprimer);
            this.Controls.Add(this.Prenom_Label);
            this.Controls.Add(this.Nom_Label);
            this.Controls.Add(this.ServeurpictureBox);
            this.Name = "ucServeur";
            this.Size = new System.Drawing.Size(496, 110);
            this.Load += new System.EventHandler(this.ucServeur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ServeurpictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ServeurpictureBox;
        private System.Windows.Forms.Label Nom_Label;
        private System.Windows.Forms.Label Prenom_Label;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button bntSupprimer;
    }
}
