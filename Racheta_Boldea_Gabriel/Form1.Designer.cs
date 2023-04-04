namespace Racheta_Boldea_Gabriel
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.r = new System.Windows.Forms.PictureBox();
            this.a1 = new System.Windows.Forms.PictureBox();
            this.a2 = new System.Windows.Forms.PictureBox();
            this.a3 = new System.Windows.Forms.PictureBox();
            this.viata_1 = new System.Windows.Forms.PictureBox();
            this.viata_3 = new System.Windows.Forms.PictureBox();
            this.viata_2 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.glont = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_scor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.r)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.a1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.a2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.a3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viata_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viata_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viata_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glont)).BeginInit();
            this.SuspendLayout();
            // 
            // r
            // 
            this.r.BackColor = System.Drawing.Color.Transparent;
            this.r.Image = global::Racheta_Boldea_Gabriel.Properties.Resources.racheta;
            this.r.Location = new System.Drawing.Point(156, 461);
            this.r.Name = "r";
            this.r.Size = new System.Drawing.Size(64, 90);
            this.r.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.r.TabIndex = 0;
            this.r.TabStop = false;
            // 
            // a1
            // 
            this.a1.BackColor = System.Drawing.Color.Transparent;
            this.a1.Image = global::Racheta_Boldea_Gabriel.Properties.Resources.asteroid1;
            this.a1.Location = new System.Drawing.Point(22, 54);
            this.a1.Name = "a1";
            this.a1.Size = new System.Drawing.Size(70, 65);
            this.a1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.a1.TabIndex = 1;
            this.a1.TabStop = false;
            this.a1.Tag = "asteroizi";
            // 
            // a2
            // 
            this.a2.BackColor = System.Drawing.Color.Transparent;
            this.a2.Image = global::Racheta_Boldea_Gabriel.Properties.Resources.asteroid1;
            this.a2.Location = new System.Drawing.Point(112, 12);
            this.a2.Name = "a2";
            this.a2.Size = new System.Drawing.Size(70, 65);
            this.a2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.a2.TabIndex = 2;
            this.a2.TabStop = false;
            this.a2.Tag = "asteroizi";
            // 
            // a3
            // 
            this.a3.BackColor = System.Drawing.Color.Transparent;
            this.a3.Image = global::Racheta_Boldea_Gabriel.Properties.Resources.asteroid1;
            this.a3.Location = new System.Drawing.Point(280, 66);
            this.a3.Name = "a3";
            this.a3.Size = new System.Drawing.Size(70, 65);
            this.a3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.a3.TabIndex = 3;
            this.a3.TabStop = false;
            this.a3.Tag = "asteroizi";
            // 
            // viata_1
            // 
            this.viata_1.BackColor = System.Drawing.Color.Transparent;
            this.viata_1.Image = global::Racheta_Boldea_Gabriel.Properties.Resources.viata;
            this.viata_1.Location = new System.Drawing.Point(12, 569);
            this.viata_1.Name = "viata_1";
            this.viata_1.Size = new System.Drawing.Size(35, 30);
            this.viata_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.viata_1.TabIndex = 4;
            this.viata_1.TabStop = false;
            // 
            // viata_3
            // 
            this.viata_3.BackColor = System.Drawing.Color.Transparent;
            this.viata_3.Image = global::Racheta_Boldea_Gabriel.Properties.Resources.viata;
            this.viata_3.Location = new System.Drawing.Point(94, 569);
            this.viata_3.Name = "viata_3";
            this.viata_3.Size = new System.Drawing.Size(35, 30);
            this.viata_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.viata_3.TabIndex = 5;
            this.viata_3.TabStop = false;
            // 
            // viata_2
            // 
            this.viata_2.BackColor = System.Drawing.Color.Transparent;
            this.viata_2.Image = global::Racheta_Boldea_Gabriel.Properties.Resources.viata;
            this.viata_2.Location = new System.Drawing.Point(53, 569);
            this.viata_2.Name = "viata_2";
            this.viata_2.Size = new System.Drawing.Size(35, 30);
            this.viata_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.viata_2.TabIndex = 6;
            this.viata_2.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // glont
            // 
            this.glont.BackColor = System.Drawing.Color.Transparent;
            this.glont.Image = global::Racheta_Boldea_Gabriel.Properties.Resources.laser;
            this.glont.Location = new System.Drawing.Point(176, 415);
            this.glont.Name = "glont";
            this.glont.Size = new System.Drawing.Size(25, 40);
            this.glont.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.glont.TabIndex = 7;
            this.glont.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(286, 575);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Scor:";
            // 
            // lbl_scor
            // 
            this.lbl_scor.AutoSize = true;
            this.lbl_scor.BackColor = System.Drawing.Color.Transparent;
            this.lbl_scor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_scor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lbl_scor.Location = new System.Drawing.Point(351, 575);
            this.lbl_scor.Name = "lbl_scor";
            this.lbl_scor.Size = new System.Drawing.Size(21, 24);
            this.lbl_scor.TabIndex = 9;
            this.lbl_scor.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Racheta_Boldea_Gabriel.Properties.Resources.fundal_3;
            this.ClientSize = new System.Drawing.Size(384, 611);
            this.Controls.Add(this.lbl_scor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.glont);
            this.Controls.Add(this.viata_2);
            this.Controls.Add(this.viata_3);
            this.Controls.Add(this.viata_1);
            this.Controls.Add(this.a3);
            this.Controls.Add(this.a2);
            this.Controls.Add(this.a1);
            this.Controls.Add(this.r);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(400, 650);
            this.MinimumSize = new System.Drawing.Size(400, 650);
            this.Name = "Form1";
            this.Text = "Racheta";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.r)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.a1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.a2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.a3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viata_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viata_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viata_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glont)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox r;
        private System.Windows.Forms.PictureBox a1;
        private System.Windows.Forms.PictureBox a2;
        private System.Windows.Forms.PictureBox a3;
        private System.Windows.Forms.PictureBox viata_1;
        private System.Windows.Forms.PictureBox viata_3;
        private System.Windows.Forms.PictureBox viata_2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox glont;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_scor;
    }
}

