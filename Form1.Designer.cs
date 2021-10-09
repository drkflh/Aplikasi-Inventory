
namespace Aplikasi_Inventory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pilihgambar = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.kodebarang = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtkode = new System.Windows.Forms.TextBox();
            this.namabarang = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.caribarang = new System.Windows.Forms.Label();
            this.txtnama = new System.Windows.Forms.TextBox();
            this.txtstok = new System.Windows.Forms.TextBox();
            this.txttipe = new System.Windows.Forms.TextBox();
            this.txtharga = new System.Windows.Forms.TextBox();
            this.txtcari = new System.Windows.Forms.TextBox();
            this.save = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.Button();
            this.New = new System.Windows.Forms.Button();
            this.appData = new Aplikasi_Inventory.AppData();
            this.barangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.barangTableAdapter = new Aplikasi_Inventory.AppDataTableAdapters.BarangTableAdapter();
            this.kodebarangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namabarangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stokbarangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipeBarangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hargabarangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pilihgambar
            // 
            this.pilihgambar.Font = new System.Drawing.Font("LCDMono2", 8.249999F);
            this.pilihgambar.Location = new System.Drawing.Point(77, 207);
            this.pilihgambar.Name = "pilihgambar";
            this.pilihgambar.Size = new System.Drawing.Size(118, 22);
            this.pilihgambar.TabIndex = 0;
            this.pilihgambar.Text = "Pilih Gambar";
            this.pilihgambar.UseVisualStyleBackColor = true;
            this.pilihgambar.Click += new System.EventHandler(this.pilihgambar_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kodebarangDataGridViewTextBoxColumn,
            this.namabarangDataGridViewTextBoxColumn,
            this.stokbarangDataGridViewTextBoxColumn,
            this.tipeBarangDataGridViewTextBoxColumn,
            this.hargabarangDataGridViewTextBoxColumn,
            this.imageDataGridViewImageColumn});
            this.dataGridView.DataSource = this.barangBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(288, 41);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(541, 280);
            this.dataGridView.TabIndex = 1;
            this.dataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView_KeyDown);
            // 
            // kodebarang
            // 
            this.kodebarang.AutoSize = true;
            this.kodebarang.BackColor = System.Drawing.Color.Transparent;
            this.kodebarang.Font = new System.Drawing.Font("LCDMono2", 12F);
            this.kodebarang.Location = new System.Drawing.Point(19, 254);
            this.kodebarang.Name = "kodebarang";
            this.kodebarang.Size = new System.Drawing.Size(95, 14);
            this.kodebarang.TabIndex = 2;
            this.kodebarang.Text = "Kode Barang";
            this.kodebarang.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.pictureBox2);
            this.panel.Controls.Add(this.txtharga);
            this.panel.Controls.Add(this.txttipe);
            this.panel.Controls.Add(this.txtstok);
            this.panel.Controls.Add(this.txtnama);
            this.panel.Controls.Add(this.label4);
            this.panel.Controls.Add(this.label3);
            this.panel.Controls.Add(this.label2);
            this.panel.Controls.Add(this.namabarang);
            this.panel.Controls.Add(this.txtkode);
            this.panel.Controls.Add(this.pictureBox1);
            this.panel.Controls.Add(this.pilihgambar);
            this.panel.Controls.Add(this.kodebarang);
            this.panel.Location = new System.Drawing.Point(3, -4);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(263, 395);
            this.panel.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.barangBindingSource, "Image", true));
            this.pictureBox1.Location = new System.Drawing.Point(62, 76);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(146, 125);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txtkode
            // 
            this.txtkode.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtkode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.barangBindingSource, "Kodebarang", true));
            this.txtkode.Location = new System.Drawing.Point(146, 251);
            this.txtkode.Name = "txtkode";
            this.txtkode.Size = new System.Drawing.Size(100, 20);
            this.txtkode.TabIndex = 0;
            // 
            // namabarang
            // 
            this.namabarang.AutoSize = true;
            this.namabarang.BackColor = System.Drawing.Color.Transparent;
            this.namabarang.Font = new System.Drawing.Font("LCDMono2", 12F);
            this.namabarang.Location = new System.Drawing.Point(18, 281);
            this.namabarang.Name = "namabarang";
            this.namabarang.Size = new System.Drawing.Size(95, 14);
            this.namabarang.TabIndex = 6;
            this.namabarang.Text = "Nama Barang";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("LCDMono2", 12F);
            this.label2.Location = new System.Drawing.Point(18, 306);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 14);
            this.label2.TabIndex = 7;
            this.label2.Text = "Stok Barang";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("LCDMono2", 12F);
            this.label3.Location = new System.Drawing.Point(17, 333);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 14);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tipe Barang";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("LCDMono2", 12F);
            this.label4.Location = new System.Drawing.Point(17, 355);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 14);
            this.label4.TabIndex = 9;
            this.label4.Text = "Harga Barang";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // caribarang
            // 
            this.caribarang.AutoSize = true;
            this.caribarang.BackColor = System.Drawing.Color.Transparent;
            this.caribarang.Font = new System.Drawing.Font("LCDMono2", 12F);
            this.caribarang.Location = new System.Drawing.Point(287, 10);
            this.caribarang.Name = "caribarang";
            this.caribarang.Size = new System.Drawing.Size(39, 14);
            this.caribarang.TabIndex = 10;
            this.caribarang.Text = "Cari";
            // 
            // txtnama
            // 
            this.txtnama.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtnama.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.barangBindingSource, "Namabarang", true));
            this.txtnama.Location = new System.Drawing.Point(146, 277);
            this.txtnama.Name = "txtnama";
            this.txtnama.Size = new System.Drawing.Size(100, 20);
            this.txtnama.TabIndex = 1;
            // 
            // txtstok
            // 
            this.txtstok.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtstok.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.barangBindingSource, "Stokbarang", true));
            this.txtstok.Location = new System.Drawing.Point(146, 303);
            this.txtstok.Name = "txtstok";
            this.txtstok.Size = new System.Drawing.Size(100, 20);
            this.txtstok.TabIndex = 2;
            // 
            // txttipe
            // 
            this.txttipe.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txttipe.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.barangBindingSource, "TipeBarang", true));
            this.txttipe.Location = new System.Drawing.Point(146, 329);
            this.txttipe.Name = "txttipe";
            this.txttipe.Size = new System.Drawing.Size(100, 20);
            this.txttipe.TabIndex = 3;
            // 
            // txtharga
            // 
            this.txtharga.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtharga.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.barangBindingSource, "Hargabarang", true));
            this.txtharga.Location = new System.Drawing.Point(146, 355);
            this.txtharga.Name = "txtharga";
            this.txtharga.Size = new System.Drawing.Size(100, 20);
            this.txtharga.TabIndex = 4;
            // 
            // txtcari
            // 
            this.txtcari.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtcari.Location = new System.Drawing.Point(328, 6);
            this.txtcari.Name = "txtcari";
            this.txtcari.Size = new System.Drawing.Size(501, 20);
            this.txtcari.TabIndex = 1;
            this.txtcari.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcari_KeyPress);
            // 
            // save
            // 
            this.save.Font = new System.Drawing.Font("LCDMono2", 8.249999F);
            this.save.Location = new System.Drawing.Point(734, 331);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(95, 35);
            this.save.TabIndex = 5;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // Cancel
            // 
            this.Cancel.Font = new System.Drawing.Font("LCDMono2", 8.249999F);
            this.Cancel.Location = new System.Drawing.Point(633, 330);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(95, 35);
            this.Cancel.TabIndex = 4;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // edit
            // 
            this.edit.Font = new System.Drawing.Font("LCDMono2", 8.249999F);
            this.edit.Location = new System.Drawing.Point(532, 330);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(95, 34);
            this.edit.TabIndex = 3;
            this.edit.Text = "Edit";
            this.edit.UseVisualStyleBackColor = true;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // New
            // 
            this.New.Font = new System.Drawing.Font("LCDMono2", 8.249999F);
            this.New.Location = new System.Drawing.Point(431, 331);
            this.New.Name = "New";
            this.New.Size = new System.Drawing.Size(95, 33);
            this.New.TabIndex = 2;
            this.New.Text = "New";
            this.New.UseVisualStyleBackColor = true;
            this.New.Click += new System.EventHandler(this.New_Click);
            // 
            // appData
            // 
            this.appData.DataSetName = "AppData";
            this.appData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // barangBindingSource
            // 
            this.barangBindingSource.DataMember = "Barang";
            this.barangBindingSource.DataSource = this.appData;
            // 
            // barangTableAdapter
            // 
            this.barangTableAdapter.ClearBeforeFill = true;
            // 
            // kodebarangDataGridViewTextBoxColumn
            // 
            this.kodebarangDataGridViewTextBoxColumn.DataPropertyName = "Kodebarang";
            this.kodebarangDataGridViewTextBoxColumn.HeaderText = "Kodebarang";
            this.kodebarangDataGridViewTextBoxColumn.Name = "kodebarangDataGridViewTextBoxColumn";
            // 
            // namabarangDataGridViewTextBoxColumn
            // 
            this.namabarangDataGridViewTextBoxColumn.DataPropertyName = "Namabarang";
            this.namabarangDataGridViewTextBoxColumn.HeaderText = "Namabarang";
            this.namabarangDataGridViewTextBoxColumn.Name = "namabarangDataGridViewTextBoxColumn";
            // 
            // stokbarangDataGridViewTextBoxColumn
            // 
            this.stokbarangDataGridViewTextBoxColumn.DataPropertyName = "Stokbarang";
            this.stokbarangDataGridViewTextBoxColumn.HeaderText = "Stokbarang";
            this.stokbarangDataGridViewTextBoxColumn.Name = "stokbarangDataGridViewTextBoxColumn";
            // 
            // tipeBarangDataGridViewTextBoxColumn
            // 
            this.tipeBarangDataGridViewTextBoxColumn.DataPropertyName = "TipeBarang";
            this.tipeBarangDataGridViewTextBoxColumn.HeaderText = "TipeBarang";
            this.tipeBarangDataGridViewTextBoxColumn.Name = "tipeBarangDataGridViewTextBoxColumn";
            // 
            // hargabarangDataGridViewTextBoxColumn
            // 
            this.hargabarangDataGridViewTextBoxColumn.DataPropertyName = "Hargabarang";
            this.hargabarangDataGridViewTextBoxColumn.HeaderText = "Hargabarang";
            this.hargabarangDataGridViewTextBoxColumn.Name = "hargabarangDataGridViewTextBoxColumn";
            // 
            // imageDataGridViewImageColumn
            // 
            this.imageDataGridViewImageColumn.DataPropertyName = "Image";
            this.imageDataGridViewImageColumn.HeaderText = "Image";
            this.imageDataGridViewImageColumn.Name = "imageDataGridViewImageColumn";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(263, 67);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(841, 380);
            this.Controls.Add(this.New);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.save);
            this.Controls.Add(this.txtcari);
            this.Controls.Add(this.caribarang);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.dataGridView);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tejo Acc Management System";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button pilihgambar;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label kodebarang;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.TextBox txtkode;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtharga;
        private System.Windows.Forms.TextBox txttipe;
        private System.Windows.Forms.TextBox txtstok;
        private System.Windows.Forms.TextBox txtnama;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label namabarang;
        private System.Windows.Forms.Label caribarang;
        private System.Windows.Forms.TextBox txtcari;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Button New;
        private AppData appData;
        private System.Windows.Forms.BindingSource barangBindingSource;
        private AppDataTableAdapters.BarangTableAdapter barangTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodebarangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namabarangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stokbarangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipeBarangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hargabarangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn imageDataGridViewImageColumn;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

