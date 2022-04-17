
namespace covidaplikace2._0
{
    partial class RegForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegForm));
            this.label1 = new System.Windows.Forms.Label();
            this.btninputJmeno = new System.Windows.Forms.TextBox();
            this.btninputPrijmeni = new System.Windows.Forms.TextBox();
            this.btnInputEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnInputHeslo = new System.Windows.Forms.TextBox();
            this.btnInputHesloPot = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnRegistrace = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Light", 12.25F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(154, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Jméno";
            // 
            // btninputJmeno
            // 
            this.btninputJmeno.Location = new System.Drawing.Point(225, 119);
            this.btninputJmeno.Name = "btninputJmeno";
            this.btninputJmeno.Size = new System.Drawing.Size(100, 20);
            this.btninputJmeno.TabIndex = 1;
            // 
            // btninputPrijmeni
            // 
            this.btninputPrijmeni.Location = new System.Drawing.Point(225, 154);
            this.btninputPrijmeni.Name = "btninputPrijmeni";
            this.btninputPrijmeni.Size = new System.Drawing.Size(100, 20);
            this.btninputPrijmeni.TabIndex = 2;
            // 
            // btnInputEmail
            // 
            this.btnInputEmail.Location = new System.Drawing.Point(225, 219);
            this.btnInputEmail.Name = "btnInputEmail";
            this.btnInputEmail.Size = new System.Drawing.Size(100, 20);
            this.btnInputEmail.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto Light", 12.25F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(145, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Příjmení";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto Light", 12.25F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(155, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto Light", 12.25F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(153, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Heslo";
            // 
            // btnInputHeslo
            // 
            this.btnInputHeslo.Location = new System.Drawing.Point(225, 262);
            this.btnInputHeslo.Name = "btnInputHeslo";
            this.btnInputHeslo.Size = new System.Drawing.Size(100, 20);
            this.btnInputHeslo.TabIndex = 7;
            // 
            // btnInputHesloPot
            // 
            this.btnInputHesloPot.Location = new System.Drawing.Point(225, 317);
            this.btnInputHesloPot.Name = "btnInputHesloPot";
            this.btnInputHesloPot.Size = new System.Drawing.Size(100, 20);
            this.btnInputHesloPot.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto Light", 12.25F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(84, 316);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Potvrzení hesla";
            // 
            // btnRegistrace
            // 
            this.btnRegistrace.BackColor = System.Drawing.Color.White;
            this.btnRegistrace.FlatAppearance.BorderSize = 0;
            this.btnRegistrace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrace.Font = new System.Drawing.Font("Roboto", 11.25F);
            this.btnRegistrace.Location = new System.Drawing.Point(202, 368);
            this.btnRegistrace.Name = "btnRegistrace";
            this.btnRegistrace.Size = new System.Drawing.Size(123, 36);
            this.btnRegistrace.TabIndex = 10;
            this.btnRegistrace.Text = "Registrovat";
            this.btnRegistrace.UseVisualStyleBackColor = false;
            this.btnRegistrace.Click += new System.EventHandler(this.btnRegistrace_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(109, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(342, 77);
            this.label6.TabIndex = 11;
            this.label6.Text = "Registrace";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(98)))), ((int)(((byte)(162)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(452, 366);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(73, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Roboto Light", 9.25F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(222, 285);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 15);
            this.label7.TabIndex = 20;
            this.label7.Text = "Informace o heslu";
            // 
            // RegForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(98)))), ((int)(((byte)(162)))));
            this.ClientSize = new System.Drawing.Size(537, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnRegistrace);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnInputHesloPot);
            this.Controls.Add(this.btnInputHeslo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnInputEmail);
            this.Controls.Add(this.btninputPrijmeni);
            this.Controls.Add(this.btninputJmeno);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "RegForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegForm";
            this.Load += new System.EventHandler(this.RegForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox btninputJmeno;
        private System.Windows.Forms.TextBox btninputPrijmeni;
        private System.Windows.Forms.TextBox btnInputEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox btnInputHeslo;
        private System.Windows.Forms.TextBox btnInputHesloPot;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnRegistrace;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
    }
}