﻿namespace Hatırlatma_Otomasyonu
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.btnKaydet = new System.Windows.Forms.Button();
			this.txtIsAdi = new System.Windows.Forms.TextBox();
			this.btnYapildi = new System.Windows.Forms.Button();
			this.lstYapilacaklar = new System.Windows.Forms.ListBox();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.dgvYapilanlar = new System.Windows.Forms.DataGridView();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.tabPage3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvYapilanlar)).BeginInit();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(803, 452);
			this.tabControl1.TabIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.BackColor = System.Drawing.Color.Transparent;
			this.tabPage1.Controls.Add(this.label1);
			this.tabPage1.Controls.Add(this.btnKaydet);
			this.tabPage1.Controls.Add(this.txtIsAdi);
			this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.tabPage1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.tabPage1.Location = new System.Drawing.Point(4, 25);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.tabPage1.Size = new System.Drawing.Size(795, 423);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Hatırlatma Ekleme";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.label2);
			this.tabPage2.Controls.Add(this.lstYapilacaklar);
			this.tabPage2.Controls.Add(this.btnYapildi);
			this.tabPage2.Location = new System.Drawing.Point(4, 25);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(795, 423);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Yapılacak İşler";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// btnKaydet
			// 
			this.btnKaydet.Location = new System.Drawing.Point(359, 213);
			this.btnKaydet.Name = "btnKaydet";
			this.btnKaydet.Size = new System.Drawing.Size(75, 32);
			this.btnKaydet.TabIndex = 3;
			this.btnKaydet.Text = "Kaydet";
			this.btnKaydet.UseVisualStyleBackColor = true;
			this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
			// 
			// txtIsAdi
			// 
			this.txtIsAdi.Location = new System.Drawing.Point(229, 167);
			this.txtIsAdi.Name = "txtIsAdi";
			this.txtIsAdi.Size = new System.Drawing.Size(347, 22);
			this.txtIsAdi.TabIndex = 2;
			// 
			// btnYapildi
			// 
			this.btnYapildi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnYapildi.Location = new System.Drawing.Point(359, 299);
			this.btnYapildi.Name = "btnYapildi";
			this.btnYapildi.Size = new System.Drawing.Size(75, 33);
			this.btnYapildi.TabIndex = 0;
			this.btnYapildi.Text = "Yapıldı";
			this.btnYapildi.UseVisualStyleBackColor = true;
			this.btnYapildi.Click += new System.EventHandler(this.btnYapildi_Click);
			// 
			// lstYapilacaklar
			// 
			this.lstYapilacaklar.FormattingEnabled = true;
			this.lstYapilacaklar.ItemHeight = 16;
			this.lstYapilacaklar.Location = new System.Drawing.Point(260, 76);
			this.lstYapilacaklar.Name = "lstYapilacaklar";
			this.lstYapilacaklar.Size = new System.Drawing.Size(298, 180);
			this.lstYapilacaklar.TabIndex = 1;
			// 
			// tabPage3
			// 
			this.tabPage3.Controls.Add(this.dgvYapilanlar);
			this.tabPage3.Controls.Add(this.label3);
			this.tabPage3.Location = new System.Drawing.Point(4, 25);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage3.Size = new System.Drawing.Size(795, 423);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "Yapılan İşler Listesi";
			this.tabPage3.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(339, 137);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(132, 16);
			this.label1.TabIndex = 4;
			this.label1.Text = "Yapılacak İşin Adı";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.Location = new System.Drawing.Point(332, 47);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(144, 16);
			this.label2.TabIndex = 2;
			this.label2.Text = "Yapılacaklar Listesi";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label3.Location = new System.Drawing.Point(329, 42);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(143, 16);
			this.label3.TabIndex = 1;
			this.label3.Text = "Yapılan İşler Listesi";
			// 
			// dgvYapilanlar
			// 
			this.dgvYapilanlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvYapilanlar.Location = new System.Drawing.Point(187, 73);
			this.dgvYapilanlar.Name = "dgvYapilanlar";
			this.dgvYapilanlar.RowHeadersWidth = 51;
			this.dgvYapilanlar.RowTemplate.Height = 24;
			this.dgvYapilanlar.Size = new System.Drawing.Size(426, 313);
			this.dgvYapilanlar.TabIndex = 2;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.tabControl1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Hatırlatıcı V1.2";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			this.tabPage3.ResumeLayout(false);
			this.tabPage3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvYapilanlar)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.Button btnKaydet;
		private System.Windows.Forms.TextBox txtIsAdi;
		private System.Windows.Forms.ListBox lstYapilacaklar;
		private System.Windows.Forms.Button btnYapildi;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DataGridView dgvYapilanlar;
	}
}

