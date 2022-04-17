
namespace covidaplikace2._0
{
    partial class ReportovaneOsobyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportovaneOsobyForm));
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jménoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.příjmeníDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonníKontaktDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumNarozeníDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.délkaKotaktuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.příznakyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.očkováníDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chráněnýKontaktDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loginDBDataSet_ReportovaneOsoby = new covidaplikace2._0.LoginDBDataSet_ReportovaneOsoby();
            this.tableReportTableAdapter = new covidaplikace2._0.LoginDBDataSet_ReportovaneOsobyTableAdapters.TableReportTableAdapter();
            this.label6 = new System.Windows.Forms.Label();
            this.backbtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginDBDataSet_ReportovaneOsoby)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(763, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 25);
            this.button1.TabIndex = 12;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.jménoDataGridViewTextBoxColumn,
            this.příjmeníDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.telefonníKontaktDataGridViewTextBoxColumn,
            this.datumNarozeníDataGridViewTextBoxColumn,
            this.délkaKotaktuDataGridViewTextBoxColumn,
            this.příznakyDataGridViewTextBoxColumn,
            this.očkováníDataGridViewTextBoxColumn,
            this.chráněnýKontaktDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tableReportBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 105);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 272);
            this.dataGridView1.TabIndex = 13;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // jménoDataGridViewTextBoxColumn
            // 
            this.jménoDataGridViewTextBoxColumn.DataPropertyName = "Jméno";
            this.jménoDataGridViewTextBoxColumn.HeaderText = "Jméno";
            this.jménoDataGridViewTextBoxColumn.Name = "jménoDataGridViewTextBoxColumn";
            // 
            // příjmeníDataGridViewTextBoxColumn
            // 
            this.příjmeníDataGridViewTextBoxColumn.DataPropertyName = "Příjmení";
            this.příjmeníDataGridViewTextBoxColumn.HeaderText = "Příjmení";
            this.příjmeníDataGridViewTextBoxColumn.Name = "příjmeníDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // telefonníKontaktDataGridViewTextBoxColumn
            // 
            this.telefonníKontaktDataGridViewTextBoxColumn.DataPropertyName = "Telefonní kontakt";
            this.telefonníKontaktDataGridViewTextBoxColumn.HeaderText = "Telefonní kontakt";
            this.telefonníKontaktDataGridViewTextBoxColumn.Name = "telefonníKontaktDataGridViewTextBoxColumn";
            // 
            // datumNarozeníDataGridViewTextBoxColumn
            // 
            this.datumNarozeníDataGridViewTextBoxColumn.DataPropertyName = "Datum narození";
            this.datumNarozeníDataGridViewTextBoxColumn.HeaderText = "Datum narození";
            this.datumNarozeníDataGridViewTextBoxColumn.Name = "datumNarozeníDataGridViewTextBoxColumn";
            // 
            // délkaKotaktuDataGridViewTextBoxColumn
            // 
            this.délkaKotaktuDataGridViewTextBoxColumn.DataPropertyName = "Délka kotaktu";
            this.délkaKotaktuDataGridViewTextBoxColumn.HeaderText = "Délka kotaktu";
            this.délkaKotaktuDataGridViewTextBoxColumn.Name = "délkaKotaktuDataGridViewTextBoxColumn";
            // 
            // příznakyDataGridViewTextBoxColumn
            // 
            this.příznakyDataGridViewTextBoxColumn.DataPropertyName = "Příznaky";
            this.příznakyDataGridViewTextBoxColumn.HeaderText = "Příznaky";
            this.příznakyDataGridViewTextBoxColumn.Name = "příznakyDataGridViewTextBoxColumn";
            // 
            // očkováníDataGridViewTextBoxColumn
            // 
            this.očkováníDataGridViewTextBoxColumn.DataPropertyName = "Očkování";
            this.očkováníDataGridViewTextBoxColumn.HeaderText = "Očkování";
            this.očkováníDataGridViewTextBoxColumn.Name = "očkováníDataGridViewTextBoxColumn";
            // 
            // chráněnýKontaktDataGridViewTextBoxColumn
            // 
            this.chráněnýKontaktDataGridViewTextBoxColumn.DataPropertyName = "Chráněný kontakt";
            this.chráněnýKontaktDataGridViewTextBoxColumn.HeaderText = "Chráněný kontakt";
            this.chráněnýKontaktDataGridViewTextBoxColumn.Name = "chráněnýKontaktDataGridViewTextBoxColumn";
            // 
            // tableReportBindingSource
            // 
            this.tableReportBindingSource.DataMember = "TableReport";
            this.tableReportBindingSource.DataSource = this.loginDBDataSet_ReportovaneOsoby;
            // 
            // loginDBDataSet_ReportovaneOsoby
            // 
            this.loginDBDataSet_ReportovaneOsoby.DataSetName = "LoginDBDataSet_ReportovaneOsoby";
            this.loginDBDataSet_ReportovaneOsoby.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableReportTableAdapter
            // 
            this.tableReportTableAdapter.ClearBeforeFill = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(103, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(589, 77);
            this.label6.TabIndex = 20;
            this.label6.Text = "Reportované osoby";
            // 
            // backbtn
            // 
            this.backbtn.BackColor = System.Drawing.Color.White;
            this.backbtn.FlatAppearance.BorderSize = 0;
            this.backbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backbtn.Font = new System.Drawing.Font("Roboto", 13.25F);
            this.backbtn.Location = new System.Drawing.Point(267, 402);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(250, 36);
            this.backbtn.TabIndex = 44;
            this.backbtn.Text = "Zpět";
            this.backbtn.UseVisualStyleBackColor = false;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(98)))), ((int)(((byte)(162)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(731, 384);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(57, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 45;
            this.pictureBox1.TabStop = false;
            // 
            // ReportovaneOsobyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(98)))), ((int)(((byte)(162)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Name = "ReportovaneOsobyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReportovaneOsobyForm";
            this.Load += new System.EventHandler(this.ReportovaneOsobyForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginDBDataSet_ReportovaneOsoby)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private LoginDBDataSet_ReportovaneOsoby loginDBDataSet_ReportovaneOsoby;
        private System.Windows.Forms.BindingSource tableReportBindingSource;
        private LoginDBDataSet_ReportovaneOsobyTableAdapters.TableReportTableAdapter tableReportTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jménoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn příjmeníDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonníKontaktDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumNarozeníDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn délkaKotaktuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn příznakyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn očkováníDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chráněnýKontaktDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}