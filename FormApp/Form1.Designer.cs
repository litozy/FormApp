namespace FormApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbl_negara = new Label();
            input_negara = new TextBox();
            lbl_pelabuhan = new Label();
            input_pelabuhan = new TextBox();
            lbl_barang = new Label();
            input_barangdetail = new TextBox();
            lbl_harga = new Label();
            input_harga = new TextBox();
            lbl_tarif_bea_masuk = new Label();
            input_tarif = new TextBox();
            label2 = new Label();
            input_hasil = new TextBox();
            btn_total = new Button();
            input_code = new TextBox();
            SuspendLayout();
            // 
            // lbl_negara
            // 
            lbl_negara.AutoSize = true;
            lbl_negara.Location = new Point(41, 44);
            lbl_negara.Name = "lbl_negara";
            lbl_negara.Size = new Size(45, 15);
            lbl_negara.TabIndex = 1;
            lbl_negara.Text = "Negara";
            // 
            // input_negara
            // 
            input_negara.Location = new Point(150, 41);
            input_negara.Multiline = true;
            input_negara.Name = "input_negara";
            input_negara.Size = new Size(157, 23);
            input_negara.TabIndex = 2;
            // 
            // lbl_pelabuhan
            // 
            lbl_pelabuhan.AutoSize = true;
            lbl_pelabuhan.Location = new Point(41, 93);
            lbl_pelabuhan.Name = "lbl_pelabuhan";
            lbl_pelabuhan.Size = new Size(63, 15);
            lbl_pelabuhan.TabIndex = 3;
            lbl_pelabuhan.Text = "Pelabuhan";
            // 
            // input_pelabuhan
            // 
            input_pelabuhan.Location = new Point(150, 90);
            input_pelabuhan.Multiline = true;
            input_pelabuhan.Name = "input_pelabuhan";
            input_pelabuhan.Size = new Size(157, 23);
            input_pelabuhan.TabIndex = 4;
            // 
            // lbl_barang
            // 
            lbl_barang.AutoSize = true;
            lbl_barang.Location = new Point(41, 144);
            lbl_barang.Name = "lbl_barang";
            lbl_barang.Size = new Size(44, 15);
            lbl_barang.TabIndex = 5;
            lbl_barang.Text = "Barang";
            // 
            // input_barangdetail
            // 
            input_barangdetail.Location = new Point(150, 170);
            input_barangdetail.Multiline = true;
            input_barangdetail.Name = "input_barangdetail";
            input_barangdetail.Size = new Size(254, 96);
            input_barangdetail.TabIndex = 7;
            // 
            // lbl_harga
            // 
            lbl_harga.AutoSize = true;
            lbl_harga.Location = new Point(41, 308);
            lbl_harga.Name = "lbl_harga";
            lbl_harga.Size = new Size(39, 15);
            lbl_harga.TabIndex = 8;
            lbl_harga.Text = "Harga";
            // 
            // input_harga
            // 
            input_harga.Location = new Point(150, 305);
            input_harga.Multiline = true;
            input_harga.Name = "input_harga";
            input_harga.Size = new Size(157, 23);
            input_harga.TabIndex = 9;
            // 
            // lbl_tarif_bea_masuk
            // 
            lbl_tarif_bea_masuk.AutoSize = true;
            lbl_tarif_bea_masuk.Location = new Point(41, 361);
            lbl_tarif_bea_masuk.Name = "lbl_tarif_bea_masuk";
            lbl_tarif_bea_masuk.Size = new Size(89, 15);
            lbl_tarif_bea_masuk.TabIndex = 10;
            lbl_tarif_bea_masuk.Text = "Tarif Bea Masuk";
            // 
            // input_tarif
            // 
            input_tarif.Location = new Point(150, 358);
            input_tarif.Multiline = true;
            input_tarif.Name = "input_tarif";
            input_tarif.Size = new Size(59, 23);
            input_tarif.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(218, 361);
            label2.Name = "label2";
            label2.Size = new Size(17, 15);
            label2.TabIndex = 12;
            label2.Text = "%";
            // 
            // input_hasil
            // 
            input_hasil.Location = new Point(150, 398);
            input_hasil.Multiline = true;
            input_hasil.Name = "input_hasil";
            input_hasil.Size = new Size(157, 23);
            input_hasil.TabIndex = 13;
            // 
            // btn_total
            // 
            btn_total.Location = new Point(329, 398);
            btn_total.Name = "btn_total";
            btn_total.Size = new Size(75, 23);
            btn_total.TabIndex = 14;
            btn_total.Text = "Total";
            btn_total.UseVisualStyleBackColor = true;
            btn_total.Click += CalculateButton_Click;
            // 
            // input_code
            // 
            input_code.Location = new Point(150, 141);
            input_code.Name = "input_code";
            input_code.Size = new Size(157, 23);
            input_code.TabIndex = 16;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 510);
            Controls.Add(input_code);
            Controls.Add(btn_total);
            Controls.Add(input_hasil);
            Controls.Add(label2);
            Controls.Add(input_tarif);
            Controls.Add(lbl_tarif_bea_masuk);
            Controls.Add(input_harga);
            Controls.Add(lbl_harga);
            Controls.Add(input_barangdetail);
            Controls.Add(lbl_barang);
            Controls.Add(input_pelabuhan);
            Controls.Add(lbl_pelabuhan);
            Controls.Add(input_negara);
            Controls.Add(lbl_negara);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lbl_negara;
        private TextBox input_negara;
        private Label lbl_pelabuhan;
        private TextBox input_pelabuhan;
        private Label lbl_barang;
        private TextBox input_barangdetail;
        private Label lbl_harga;
        private TextBox input_harga;
        private Label lbl_tarif_bea_masuk;
        private TextBox input_tarif;
        private Label label2;
        private TextBox input_hasil;
        private Button btn_total;
        private TextBox input_code;
    }
}