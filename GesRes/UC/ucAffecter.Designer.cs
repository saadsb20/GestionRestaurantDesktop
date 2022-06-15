
namespace GesRes.UC
{
    partial class ucAffecter
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
            this.ServeurPictureBox = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.TableLabel = new System.Windows.Forms.Label();
            this.ServeurLabel = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ServeurPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // ServeurPictureBox
            // 
            this.ServeurPictureBox.Image = global::GesRes.Properties.Resources.waiter;
            this.ServeurPictureBox.Location = new System.Drawing.Point(17, 30);
            this.ServeurPictureBox.Name = "ServeurPictureBox";
            this.ServeurPictureBox.Size = new System.Drawing.Size(63, 64);
            this.ServeurPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ServeurPictureBox.TabIndex = 1;
            this.ServeurPictureBox.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GesRes.Properties.Resources.DateTime;
            this.pictureBox1.Location = new System.Drawing.Point(451, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::GesRes.Properties.Resources.table;
            this.pictureBox2.Location = new System.Drawing.Point(283, 30);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(63, 64);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // TableLabel
            // 
            this.TableLabel.AutoSize = true;
            this.TableLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TableLabel.Location = new System.Drawing.Point(352, 49);
            this.TableLabel.Name = "TableLabel";
            this.TableLabel.Size = new System.Drawing.Size(66, 29);
            this.TableLabel.TabIndex = 4;
            this.TableLabel.Text = "Table";
            // 
            // ServeurLabel
            // 
            this.ServeurLabel.AutoSize = true;
            this.ServeurLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServeurLabel.Location = new System.Drawing.Point(97, 49);
            this.ServeurLabel.Name = "ServeurLabel";
            this.ServeurLabel.Size = new System.Drawing.Size(89, 29);
            this.ServeurLabel.TabIndex = 5;
            this.ServeurLabel.Text = "Serveur";
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLabel.Location = new System.Drawing.Point(544, 49);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(58, 29);
            this.DateLabel.TabIndex = 6;
            this.DateLabel.Text = "Date";
            // 
            // ucAffecter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.ServeurLabel);
            this.Controls.Add(this.TableLabel);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ServeurPictureBox);
            this.Name = "ucAffecter";
            this.Size = new System.Drawing.Size(858, 132);
            this.Load += new System.EventHandler(this.ucAffecter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ServeurPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ServeurPictureBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label TableLabel;
        private System.Windows.Forms.Label ServeurLabel;
        private System.Windows.Forms.Label DateLabel;
    }
}
