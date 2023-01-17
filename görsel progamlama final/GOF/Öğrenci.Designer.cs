namespace GOF
{
    partial class Öğrenci
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cmbBölüm = new System.Windows.Forms.ComboBox();
            this.dTarih = new System.Windows.Forms.DateTimePicker();
            this.mskÖgrNo = new System.Windows.Forms.MaskedTextBox();
            this.kytTarih = new System.Windows.Forms.DateTimePicker();
            this.txtÖgrAd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnÖgrKaydet = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnÖgrSil = new System.Windows.Forms.Button();
            this.btnÖgrGüncelle = new System.Windows.Forms.Button();
            this.labelId = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.01508F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.98492F));
            this.tableLayoutPanel1.Controls.Add(this.cmbBölüm, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.dTarih, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.mskÖgrNo, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.kytTarih, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtÖgrAd, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.labelId, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.51485F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.48515F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 0F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(398, 344);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // cmbBölüm
            // 
            this.cmbBölüm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbBölüm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBölüm.FormattingEnabled = true;
            this.cmbBölüm.Location = new System.Drawing.Point(214, 228);
            this.cmbBölüm.Name = "cmbBölüm";
            this.cmbBölüm.Size = new System.Drawing.Size(181, 21);
            this.cmbBölüm.TabIndex = 16;
            // 
            // dTarih
            // 
            this.dTarih.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dTarih.Location = new System.Drawing.Point(214, 174);
            this.dTarih.Name = "dTarih";
            this.dTarih.Size = new System.Drawing.Size(181, 20);
            this.dTarih.TabIndex = 15;
            // 
            // mskÖgrNo
            // 
            this.mskÖgrNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mskÖgrNo.Location = new System.Drawing.Point(214, 132);
            this.mskÖgrNo.Mask = "00000000000";
            this.mskÖgrNo.Name = "mskÖgrNo";
            this.mskÖgrNo.Size = new System.Drawing.Size(181, 20);
            this.mskÖgrNo.TabIndex = 14;
            this.mskÖgrNo.ValidatingType = typeof(int);
            // 
            // kytTarih
            // 
            this.kytTarih.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kytTarih.Enabled = false;
            this.kytTarih.Location = new System.Drawing.Point(214, 66);
            this.kytTarih.Name = "kytTarih";
            this.kytTarih.Size = new System.Drawing.Size(181, 20);
            this.kytTarih.TabIndex = 13;
            // 
            // txtÖgrAd
            // 
            this.txtÖgrAd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtÖgrAd.Location = new System.Drawing.Point(214, 3);
            this.txtÖgrAd.Name = "txtÖgrAd";
            this.txtÖgrAd.Size = new System.Drawing.Size(181, 20);
            this.txtÖgrAd.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(3, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kayıt Tarihi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(3, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Öğrenci No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Öğrenci Ad ve Soyad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(3, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Doğum Tarihi:";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.34146F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.65854F));
            this.tableLayoutPanel2.Controls.Add(this.btnÖgrKaydet, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 286);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(205, 54);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // btnÖgrKaydet
            // 
            this.btnÖgrKaydet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnÖgrKaydet.Location = new System.Drawing.Point(98, 3);
            this.btnÖgrKaydet.Name = "btnÖgrKaydet";
            this.btnÖgrKaydet.Size = new System.Drawing.Size(104, 48);
            this.btnÖgrKaydet.TabIndex = 7;
            this.btnÖgrKaydet.Text = "Kaydet";
            this.btnÖgrKaydet.UseVisualStyleBackColor = true;
            this.btnÖgrKaydet.Click += new System.EventHandler(this.btnÖgrKaydet_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(5, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 24);
            this.label6.TabIndex = 6;
            this.label6.Text = "İşlemler:";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 92F));
            this.tableLayoutPanel3.Controls.Add(this.btnÖgrSil, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnÖgrGüncelle, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(214, 286);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(181, 54);
            this.tableLayoutPanel3.TabIndex = 7;
            // 
            // btnÖgrSil
            // 
            this.btnÖgrSil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnÖgrSil.Location = new System.Drawing.Point(92, 3);
            this.btnÖgrSil.Name = "btnÖgrSil";
            this.btnÖgrSil.Size = new System.Drawing.Size(86, 48);
            this.btnÖgrSil.TabIndex = 2;
            this.btnÖgrSil.Text = "Sil";
            this.btnÖgrSil.UseVisualStyleBackColor = true;
            this.btnÖgrSil.Click += new System.EventHandler(this.btnÖgrSil_Click);
            // 
            // btnÖgrGüncelle
            // 
            this.btnÖgrGüncelle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnÖgrGüncelle.Location = new System.Drawing.Point(3, 3);
            this.btnÖgrGüncelle.Name = "btnÖgrGüncelle";
            this.btnÖgrGüncelle.Size = new System.Drawing.Size(83, 48);
            this.btnÖgrGüncelle.TabIndex = 1;
            this.btnÖgrGüncelle.Text = "Güncelle";
            this.btnÖgrGüncelle.UseVisualStyleBackColor = true;
            this.btnÖgrGüncelle.Click += new System.EventHandler(this.btnÖgrGüncelle_Click);
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(3, 343);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(35, 1);
            this.labelId.TabIndex = 17;
            this.labelId.Text = "label7";
            this.labelId.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Left;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(3, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 58);
            this.label5.TabIndex = 5;
            this.label5.Text = "Bölüm:";
            // 
            // Öğrenci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 344);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Öğrenci";
            this.Text = "Öğrenci";
            this.Load += new System.EventHandler(this.Öğrenci_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public System.Windows.Forms.ComboBox cmbBölüm;
        public System.Windows.Forms.DateTimePicker dTarih;
        public System.Windows.Forms.MaskedTextBox mskÖgrNo;
        public System.Windows.Forms.DateTimePicker kytTarih;
        public System.Windows.Forms.TextBox txtÖgrAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnÖgrKaydet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btnÖgrSil;
        private System.Windows.Forms.Button btnÖgrGüncelle;
        public System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label label5;
    }
}