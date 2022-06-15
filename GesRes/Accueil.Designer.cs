
namespace GesRes
{
    partial class Accueil
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

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.BrandPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TablePanel = new System.Windows.Forms.Panel();
            this.TableLabel = new System.Windows.Forms.Label();
            this.TablePictureBox = new System.Windows.Forms.PictureBox();
            this.ServeurPanel = new System.Windows.Forms.Panel();
            this.ServeurLabel = new System.Windows.Forms.Label();
            this.ServeurPictureBox = new System.Windows.Forms.PictureBox();
            this.PlatPanel = new System.Windows.Forms.Panel();
            this.PlatLabel = new System.Windows.Forms.Label();
            this.PlatPictureBox = new System.Windows.Forms.PictureBox();
            this.CommandePanel = new System.Windows.Forms.Panel();
            this.CommandeLabel = new System.Windows.Forms.Label();
            this.CommandePictureBox = new System.Windows.Forms.PictureBox();
            this.AffectationsPanel = new System.Windows.Forms.Panel();
            this.AffecterPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAffecter = new System.Windows.Forms.Button();
            this.TablecomboBox = new System.Windows.Forms.ComboBox();
            this.ServeurcomboBox = new System.Windows.Forms.ComboBox();
            this.Num_Table_Label = new System.Windows.Forms.Label();
            this.Num_Serv_Label = new System.Windows.Forms.Label();
            this.BrandPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.TablePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TablePictureBox)).BeginInit();
            this.ServeurPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ServeurPictureBox)).BeginInit();
            this.PlatPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PlatPictureBox)).BeginInit();
            this.CommandePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CommandePictureBox)).BeginInit();
            this.AffecterPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BrandPanel
            // 
            this.BrandPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BrandPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BrandPanel.Controls.Add(this.label1);
            this.BrandPanel.Controls.Add(this.pictureBox1);
            this.BrandPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.BrandPanel.Location = new System.Drawing.Point(0, 0);
            this.BrandPanel.Name = "BrandPanel";
            this.BrandPanel.Size = new System.Drawing.Size(1290, 151);
            this.BrandPanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(468, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "Gestion Restaurant";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GesRes.Properties.Resources.Brand;
            this.pictureBox1.Location = new System.Drawing.Point(26, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(108, 102);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // TablePanel
            // 
            this.TablePanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TablePanel.Controls.Add(this.TableLabel);
            this.TablePanel.Controls.Add(this.TablePictureBox);
            this.TablePanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TablePanel.Location = new System.Drawing.Point(84, 189);
            this.TablePanel.Name = "TablePanel";
            this.TablePanel.Size = new System.Drawing.Size(170, 148);
            this.TablePanel.TabIndex = 1;
            this.TablePanel.Click += new System.EventHandler(this.TablePanel_Click);
            // 
            // TableLabel
            // 
            this.TableLabel.AutoSize = true;
            this.TableLabel.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TableLabel.Location = new System.Drawing.Point(29, 95);
            this.TableLabel.Name = "TableLabel";
            this.TableLabel.Size = new System.Drawing.Size(107, 39);
            this.TableLabel.TabIndex = 1;
            this.TableLabel.Text = "Tables";
            this.TableLabel.Click += new System.EventHandler(this.TablePanel_Click);
            // 
            // TablePictureBox
            // 
            this.TablePictureBox.Image = global::GesRes.Properties.Resources.table;
            this.TablePictureBox.Location = new System.Drawing.Point(16, 14);
            this.TablePictureBox.Name = "TablePictureBox";
            this.TablePictureBox.Size = new System.Drawing.Size(135, 66);
            this.TablePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.TablePictureBox.TabIndex = 0;
            this.TablePictureBox.TabStop = false;
            this.TablePictureBox.Click += new System.EventHandler(this.TablePanel_Click);
            // 
            // ServeurPanel
            // 
            this.ServeurPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ServeurPanel.Controls.Add(this.ServeurLabel);
            this.ServeurPanel.Controls.Add(this.ServeurPictureBox);
            this.ServeurPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ServeurPanel.Location = new System.Drawing.Point(333, 189);
            this.ServeurPanel.Name = "ServeurPanel";
            this.ServeurPanel.Size = new System.Drawing.Size(170, 148);
            this.ServeurPanel.TabIndex = 2;
            this.ServeurPanel.Click += new System.EventHandler(this.ServeurPanel_Click);
            // 
            // ServeurLabel
            // 
            this.ServeurLabel.AutoSize = true;
            this.ServeurLabel.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServeurLabel.Location = new System.Drawing.Point(19, 95);
            this.ServeurLabel.Name = "ServeurLabel";
            this.ServeurLabel.Size = new System.Drawing.Size(137, 39);
            this.ServeurLabel.TabIndex = 2;
            this.ServeurLabel.Text = "Serveurs";
            this.ServeurLabel.Click += new System.EventHandler(this.ServeurPanel_Click);
            // 
            // ServeurPictureBox
            // 
            this.ServeurPictureBox.Image = global::GesRes.Properties.Resources.waiter;
            this.ServeurPictureBox.Location = new System.Drawing.Point(26, 14);
            this.ServeurPictureBox.Name = "ServeurPictureBox";
            this.ServeurPictureBox.Size = new System.Drawing.Size(124, 66);
            this.ServeurPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ServeurPictureBox.TabIndex = 0;
            this.ServeurPictureBox.TabStop = false;
            this.ServeurPictureBox.Click += new System.EventHandler(this.ServeurPanel_Click);
            // 
            // PlatPanel
            // 
            this.PlatPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PlatPanel.Controls.Add(this.PlatLabel);
            this.PlatPanel.Controls.Add(this.PlatPictureBox);
            this.PlatPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PlatPanel.Location = new System.Drawing.Point(84, 376);
            this.PlatPanel.Name = "PlatPanel";
            this.PlatPanel.Size = new System.Drawing.Size(170, 148);
            this.PlatPanel.TabIndex = 2;
            this.PlatPanel.Click += new System.EventHandler(this.PlatPanel_Click);
            // 
            // PlatLabel
            // 
            this.PlatLabel.AutoSize = true;
            this.PlatLabel.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlatLabel.Location = new System.Drawing.Point(45, 99);
            this.PlatLabel.Name = "PlatLabel";
            this.PlatLabel.Size = new System.Drawing.Size(83, 39);
            this.PlatLabel.TabIndex = 3;
            this.PlatLabel.Text = "Plats";
            this.PlatLabel.Click += new System.EventHandler(this.PlatPanel_Click);
            // 
            // PlatPictureBox
            // 
            this.PlatPictureBox.Image = global::GesRes.Properties.Resources.Plat;
            this.PlatPictureBox.Location = new System.Drawing.Point(27, 14);
            this.PlatPictureBox.Name = "PlatPictureBox";
            this.PlatPictureBox.Size = new System.Drawing.Size(124, 66);
            this.PlatPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PlatPictureBox.TabIndex = 3;
            this.PlatPictureBox.TabStop = false;
            this.PlatPictureBox.Click += new System.EventHandler(this.PlatPanel_Click);
            // 
            // CommandePanel
            // 
            this.CommandePanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CommandePanel.Controls.Add(this.CommandeLabel);
            this.CommandePanel.Controls.Add(this.CommandePictureBox);
            this.CommandePanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CommandePanel.Location = new System.Drawing.Point(333, 376);
            this.CommandePanel.Name = "CommandePanel";
            this.CommandePanel.Size = new System.Drawing.Size(170, 148);
            this.CommandePanel.TabIndex = 3;
            this.CommandePanel.Click += new System.EventHandler(this.CommandePanel_Click);
            // 
            // CommandeLabel
            // 
            this.CommandeLabel.AutoSize = true;
            this.CommandeLabel.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CommandeLabel.Location = new System.Drawing.Point(13, 99);
            this.CommandeLabel.Name = "CommandeLabel";
            this.CommandeLabel.Size = new System.Drawing.Size(146, 35);
            this.CommandeLabel.TabIndex = 3;
            this.CommandeLabel.Text = "Commandes";
            this.CommandeLabel.Click += new System.EventHandler(this.CommandePanel_Click);

            // 
            // CommandePictureBox
            // 
            this.CommandePictureBox.Image = global::GesRes.Properties.Resources.Commande;
            this.CommandePictureBox.Location = new System.Drawing.Point(26, 14);
            this.CommandePictureBox.Name = "CommandePictureBox";
            this.CommandePictureBox.Size = new System.Drawing.Size(124, 66);
            this.CommandePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CommandePictureBox.TabIndex = 3;
            this.CommandePictureBox.TabStop = false;
            this.CommandePictureBox.Click += new System.EventHandler(this.CommandePanel_Click);

            // 
            // AffectationsPanel
            // 
            this.AffectationsPanel.AutoScroll = true;
            this.AffectationsPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AffectationsPanel.Location = new System.Drawing.Point(185, 555);
            this.AffectationsPanel.Name = "AffectationsPanel";
            this.AffectationsPanel.Size = new System.Drawing.Size(900, 245);
            this.AffectationsPanel.TabIndex = 4;
            // 
            // AffecterPanel
            // 
            this.AffecterPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AffecterPanel.Controls.Add(this.panel1);
            this.AffecterPanel.Controls.Add(this.btnAffecter);
            this.AffecterPanel.Controls.Add(this.TablecomboBox);
            this.AffecterPanel.Controls.Add(this.ServeurcomboBox);
            this.AffecterPanel.Controls.Add(this.Num_Table_Label);
            this.AffecterPanel.Controls.Add(this.Num_Serv_Label);
            this.AffecterPanel.Location = new System.Drawing.Point(630, 189);
            this.AffecterPanel.Name = "AffecterPanel";
            this.AffecterPanel.Size = new System.Drawing.Size(578, 335);
            this.AffecterPanel.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(578, 59);
            this.panel1.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(54, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(481, 39);
            this.label2.TabIndex = 3;
            this.label2.Text = "Affecter les Serveurs aux Tables";
            // 
            // btnAffecter
            // 
            this.btnAffecter.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAffecter.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAffecter.Location = new System.Drawing.Point(226, 275);
            this.btnAffecter.Name = "btnAffecter";
            this.btnAffecter.Size = new System.Drawing.Size(146, 46);
            this.btnAffecter.TabIndex = 8;
            this.btnAffecter.Text = "Affecter";
            this.btnAffecter.UseVisualStyleBackColor = false;
            this.btnAffecter.Click += new System.EventHandler(this.btnAffecter_Click);
            // 
            // TablecomboBox
            // 
            this.TablecomboBox.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TablecomboBox.FormattingEnabled = true;
            this.TablecomboBox.Location = new System.Drawing.Point(30, 212);
            this.TablecomboBox.Name = "TablecomboBox";
            this.TablecomboBox.Size = new System.Drawing.Size(330, 33);
            this.TablecomboBox.TabIndex = 7;
            this.TablecomboBox.Text = "Tables";
            this.TablecomboBox.SelectedIndexChanged += new System.EventHandler(this.TablecomboBox_SelectedIndexChanged);
            // 
            // ServeurcomboBox
            // 
            this.ServeurcomboBox.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServeurcomboBox.FormattingEnabled = true;
            this.ServeurcomboBox.Location = new System.Drawing.Point(30, 125);
            this.ServeurcomboBox.Name = "ServeurcomboBox";
            this.ServeurcomboBox.Size = new System.Drawing.Size(330, 33);
            this.ServeurcomboBox.TabIndex = 5;
            this.ServeurcomboBox.Text = "Serveurs";
            this.ServeurcomboBox.SelectedIndexChanged += new System.EventHandler(this.ServeurcomboBox_SelectedIndexChanged);
            // 
            // Num_Table_Label
            // 
            this.Num_Table_Label.AutoSize = true;
            this.Num_Table_Label.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num_Table_Label.Location = new System.Drawing.Point(23, 170);
            this.Num_Table_Label.Name = "Num_Table_Label";
            this.Num_Table_Label.Size = new System.Drawing.Size(93, 39);
            this.Num_Table_Label.TabIndex = 4;
            this.Num_Table_Label.Text = "Table";
            // 
            // Num_Serv_Label
            // 
            this.Num_Serv_Label.AutoSize = true;
            this.Num_Serv_Label.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num_Serv_Label.Location = new System.Drawing.Point(23, 73);
            this.Num_Serv_Label.Name = "Num_Serv_Label";
            this.Num_Serv_Label.Size = new System.Drawing.Size(123, 39);
            this.Num_Serv_Label.TabIndex = 3;
            this.Num_Serv_Label.Text = "Serveur";
            // 
            // Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1290, 853);
            this.Controls.Add(this.AffecterPanel);
            this.Controls.Add(this.AffectationsPanel);
            this.Controls.Add(this.CommandePanel);
            this.Controls.Add(this.PlatPanel);
            this.Controls.Add(this.ServeurPanel);
            this.Controls.Add(this.TablePanel);
            this.Controls.Add(this.BrandPanel);
            this.Name = "Accueil";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.BrandPanel.ResumeLayout(false);
            this.BrandPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.TablePanel.ResumeLayout(false);
            this.TablePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TablePictureBox)).EndInit();
            this.ServeurPanel.ResumeLayout(false);
            this.ServeurPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ServeurPictureBox)).EndInit();
            this.PlatPanel.ResumeLayout(false);
            this.PlatPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PlatPictureBox)).EndInit();
            this.CommandePanel.ResumeLayout(false);
            this.CommandePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CommandePictureBox)).EndInit();
            this.AffecterPanel.ResumeLayout(false);
            this.AffecterPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BrandPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel TablePanel;
        private System.Windows.Forms.Panel ServeurPanel;
        private System.Windows.Forms.Panel PlatPanel;
        private System.Windows.Forms.Panel CommandePanel;
        private System.Windows.Forms.Panel AffectationsPanel;
        private System.Windows.Forms.PictureBox TablePictureBox;
        private System.Windows.Forms.Label TableLabel;
        private System.Windows.Forms.PictureBox ServeurPictureBox;
        private System.Windows.Forms.Label ServeurLabel;
        private System.Windows.Forms.PictureBox PlatPictureBox;
        private System.Windows.Forms.Label PlatLabel;
        private System.Windows.Forms.PictureBox CommandePictureBox;
        private System.Windows.Forms.Label CommandeLabel;
        private System.Windows.Forms.Panel AffecterPanel;
        private System.Windows.Forms.Label Num_Table_Label;
        private System.Windows.Forms.Label Num_Serv_Label;
        private System.Windows.Forms.ComboBox TablecomboBox;
        private System.Windows.Forms.ComboBox ServeurcomboBox;
        private System.Windows.Forms.Button btnAffecter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
    }
}

