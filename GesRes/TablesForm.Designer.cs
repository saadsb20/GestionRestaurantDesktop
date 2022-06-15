
namespace GesRes
{
    partial class TablesForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.TablesLabel = new System.Windows.Forms.Label();
            this.TablesFormpanel = new System.Windows.Forms.Panel();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.NB_Pers_Label = new System.Windows.Forms.Label();
            this.TablesTextBox = new System.Windows.Forms.TextBox();
            this.TablesListpanel = new System.Windows.Forms.Panel();
            this.UpdatePanel = new System.Windows.Forms.Panel();
            this.NmTableLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.TableNumero = new System.Windows.Forms.Label();
            this.UpdatetextBox = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.TablesFormpanel.SuspendLayout();
            this.UpdatePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.TablesLabel);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(947, 143);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // TablesLabel
            // 
            this.TablesLabel.AutoSize = true;
            this.TablesLabel.Font = new System.Drawing.Font("Comic Sans MS", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TablesLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TablesLabel.Location = new System.Drawing.Point(334, 48);
            this.TablesLabel.Name = "TablesLabel";
            this.TablesLabel.Size = new System.Drawing.Size(253, 45);
            this.TablesLabel.TabIndex = 2;
            this.TablesLabel.Text = "Gestion Tables";
            // 
            // TablesFormpanel
            // 
            this.TablesFormpanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TablesFormpanel.Controls.Add(this.btnSubmit);
            this.TablesFormpanel.Controls.Add(this.NB_Pers_Label);
            this.TablesFormpanel.Controls.Add(this.TablesTextBox);
            this.TablesFormpanel.Location = new System.Drawing.Point(27, 425);
            this.TablesFormpanel.Name = "TablesFormpanel";
            this.TablesFormpanel.Size = new System.Drawing.Size(268, 185);
            this.TablesFormpanel.TabIndex = 1;
            this.TablesFormpanel.Visible = false;
            this.TablesFormpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.TablesFormpanel_Paint);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSubmit.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(75, 123);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(114, 39);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "Enregistrer";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // NB_Pers_Label
            // 
            this.NB_Pers_Label.AutoSize = true;
            this.NB_Pers_Label.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NB_Pers_Label.Location = new System.Drawing.Point(23, 16);
            this.NB_Pers_Label.Name = "NB_Pers_Label";
            this.NB_Pers_Label.Size = new System.Drawing.Size(188, 29);
            this.NB_Pers_Label.TabIndex = 1;
            this.NB_Pers_Label.Text = "Nombre de Places";
            // 
            // TablesTextBox
            // 
            this.TablesTextBox.Location = new System.Drawing.Point(26, 67);
            this.TablesTextBox.Name = "TablesTextBox";
            this.TablesTextBox.Size = new System.Drawing.Size(221, 22);
            this.TablesTextBox.TabIndex = 0;
            // 
            // TablesListpanel
            // 
            this.TablesListpanel.AutoScroll = true;
            this.TablesListpanel.Location = new System.Drawing.Point(318, 166);
            this.TablesListpanel.Name = "TablesListpanel";
            this.TablesListpanel.Padding = new System.Windows.Forms.Padding(10);
            this.TablesListpanel.Size = new System.Drawing.Size(586, 444);
            this.TablesListpanel.TabIndex = 2;
            this.TablesListpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.TablesListpanel_Paint);
            // 
            // UpdatePanel
            // 
            this.UpdatePanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.UpdatePanel.Controls.Add(this.NmTableLabel);
            this.UpdatePanel.Controls.Add(this.label2);
            this.UpdatePanel.Controls.Add(this.btnUpdate);
            this.UpdatePanel.Controls.Add(this.TableNumero);
            this.UpdatePanel.Controls.Add(this.UpdatetextBox);
            this.UpdatePanel.Location = new System.Drawing.Point(27, 166);
            this.UpdatePanel.Name = "UpdatePanel";
            this.UpdatePanel.Size = new System.Drawing.Size(268, 232);
            this.UpdatePanel.TabIndex = 3;
            this.UpdatePanel.Visible = false;
            // 
            // NmTableLabel
            // 
            this.NmTableLabel.AutoSize = true;
            this.NmTableLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NmTableLabel.Location = new System.Drawing.Point(105, 17);
            this.NmTableLabel.Name = "NmTableLabel";
            this.NmTableLabel.Size = new System.Drawing.Size(55, 29);
            this.NmTableLabel.TabIndex = 4;
            this.NmTableLabel.Text = "Num";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre de Places";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUpdate.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(75, 163);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(114, 39);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Enregistrer";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // TableNumero
            // 
            this.TableNumero.AutoSize = true;
            this.TableNumero.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TableNumero.Location = new System.Drawing.Point(15, 17);
            this.TableNumero.Name = "TableNumero";
            this.TableNumero.Size = new System.Drawing.Size(102, 29);
            this.TableNumero.TabIndex = 1;
            this.TableNumero.Text = "Table :  ";
            // 
            // UpdatetextBox
            // 
            this.UpdatetextBox.Location = new System.Drawing.Point(26, 124);
            this.UpdatetextBox.Name = "UpdatetextBox";
            this.UpdatetextBox.Size = new System.Drawing.Size(221, 22);
            this.UpdatetextBox.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::GesRes.Properties.Resources.table;
            this.pictureBox2.Location = new System.Drawing.Point(808, 21);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(96, 87);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GesRes.Properties.Resources.Brand;
            this.pictureBox1.Location = new System.Drawing.Point(27, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(117, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // TablesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 654);
            this.Controls.Add(this.UpdatePanel);
            this.Controls.Add(this.TablesListpanel);
            this.Controls.Add(this.TablesFormpanel);
            this.Controls.Add(this.panel1);
            this.Name = "TablesForm";
            this.Text = "TablesForm";
            this.Load += new System.EventHandler(this.TablesForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.TablesFormpanel.ResumeLayout(false);
            this.TablesFormpanel.PerformLayout();
            this.UpdatePanel.ResumeLayout(false);
            this.UpdatePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label TablesLabel;
        private System.Windows.Forms.Panel TablesFormpanel;
        private System.Windows.Forms.Panel TablesListpanel;
        private System.Windows.Forms.TextBox TablesTextBox;
        private System.Windows.Forms.Label NB_Pers_Label;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Panel UpdatePanel;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label TableNumero;
        private System.Windows.Forms.TextBox UpdatetextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label NmTableLabel;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}