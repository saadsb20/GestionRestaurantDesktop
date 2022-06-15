
namespace GesRes.UC
{
    partial class ucTable
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
            this.NumeroTable = new System.Windows.Forms.Label();
            this.NumeTableLabel = new System.Windows.Forms.Label();
            this.NombreDePersonnes = new System.Windows.Forms.Label();
            this.NbPersLabel = new System.Windows.Forms.Label();
            this.bntSupprimer = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NumeroTable
            // 
            this.NumeroTable.AutoSize = true;
            this.NumeroTable.Location = new System.Drawing.Point(16, 24);
            this.NumeroTable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NumeroTable.Name = "NumeroTable";
            this.NumeroTable.Size = new System.Drawing.Size(165, 27);
            this.NumeroTable.TabIndex = 0;
            this.NumeroTable.Text = "Table Numéro : ";
            // 
            // NumeTableLabel
            // 
            this.NumeTableLabel.AutoSize = true;
            this.NumeTableLabel.Location = new System.Drawing.Point(162, 24);
            this.NumeTableLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NumeTableLabel.Name = "NumeTableLabel";
            this.NumeTableLabel.Size = new System.Drawing.Size(55, 27);
            this.NumeTableLabel.TabIndex = 1;
            this.NumeTableLabel.Text = "label";
            // 
            // NombreDePersonnes
            // 
            this.NombreDePersonnes.AutoSize = true;
            this.NombreDePersonnes.Location = new System.Drawing.Point(16, 60);
            this.NombreDePersonnes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NombreDePersonnes.Name = "NombreDePersonnes";
            this.NombreDePersonnes.Size = new System.Drawing.Size(201, 27);
            this.NombreDePersonnes.TabIndex = 2;
            this.NombreDePersonnes.Text = "Nombre de Places : ";
            // 
            // NbPersLabel
            // 
            this.NbPersLabel.AutoSize = true;
            this.NbPersLabel.Location = new System.Drawing.Point(200, 60);
            this.NbPersLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NbPersLabel.Name = "NbPersLabel";
            this.NbPersLabel.Size = new System.Drawing.Size(55, 27);
            this.NbPersLabel.TabIndex = 3;
            this.NbPersLabel.Text = "label";
            // 
            // bntSupprimer
            // 
            this.bntSupprimer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bntSupprimer.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntSupprimer.Location = new System.Drawing.Point(288, 12);
            this.bntSupprimer.Name = "bntSupprimer";
            this.bntSupprimer.Size = new System.Drawing.Size(95, 39);
            this.bntSupprimer.TabIndex = 4;
            this.bntSupprimer.Text = "Supprimer";
            this.bntSupprimer.UseVisualStyleBackColor = false;
            this.bntSupprimer.Click += new System.EventHandler(this.bntSupprimer_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnModifier.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifier.Location = new System.Drawing.Point(288, 57);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(95, 39);
            this.btnModifier.TabIndex = 5;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = false;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // ucTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.bntSupprimer);
            this.Controls.Add(this.NbPersLabel);
            this.Controls.Add(this.NombreDePersonnes);
            this.Controls.Add(this.NumeTableLabel);
            this.Controls.Add(this.NumeroTable);
            this.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ucTable";
            this.Size = new System.Drawing.Size(408, 115);
            this.Load += new System.EventHandler(this.ucTable_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NumeroTable;
        private System.Windows.Forms.Label NumeTableLabel;
        private System.Windows.Forms.Label NombreDePersonnes;
        private System.Windows.Forms.Label NbPersLabel;
        private System.Windows.Forms.Button bntSupprimer;
        private System.Windows.Forms.Button btnModifier;
    }
}
