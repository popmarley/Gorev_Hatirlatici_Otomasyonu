namespace Hatırlatma_Otomasyonu
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
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.btnKaydet = new System.Windows.Forms.Button();
			this.txtIsAdi = new System.Windows.Forms.TextBox();
			this.btnYapildi = new System.Windows.Forms.Button();
			this.lstYapilacaklar = new System.Windows.Forms.ListBox();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.lstYapilanlar = new System.Windows.Forms.ListBox();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.tabPage3.SuspendLayout();
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
			this.tabPage1.Controls.Add(this.btnKaydet);
			this.tabPage1.Controls.Add(this.txtIsAdi);
			this.tabPage1.Location = new System.Drawing.Point(4, 25);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(795, 423);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "tabPage1";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.lstYapilacaklar);
			this.tabPage2.Controls.Add(this.btnYapildi);
			this.tabPage2.Location = new System.Drawing.Point(4, 25);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(795, 423);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "tabPage2";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// btnKaydet
			// 
			this.btnKaydet.Location = new System.Drawing.Point(362, 249);
			this.btnKaydet.Name = "btnKaydet";
			this.btnKaydet.Size = new System.Drawing.Size(75, 23);
			this.btnKaydet.TabIndex = 3;
			this.btnKaydet.Text = "Kaydet";
			this.btnKaydet.UseVisualStyleBackColor = true;
			this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
			// 
			// txtIsAdi
			// 
			this.txtIsAdi.Location = new System.Drawing.Point(347, 150);
			this.txtIsAdi.Name = "txtIsAdi";
			this.txtIsAdi.Size = new System.Drawing.Size(100, 22);
			this.txtIsAdi.TabIndex = 2;
			// 
			// btnYapildi
			// 
			this.btnYapildi.Location = new System.Drawing.Point(356, 246);
			this.btnYapildi.Name = "btnYapildi";
			this.btnYapildi.Size = new System.Drawing.Size(75, 23);
			this.btnYapildi.TabIndex = 0;
			this.btnYapildi.Text = "Yapıldı";
			this.btnYapildi.UseVisualStyleBackColor = true;
			this.btnYapildi.Click += new System.EventHandler(this.btnYapildi_Click);
			// 
			// lstYapilacaklar
			// 
			this.lstYapilacaklar.FormattingEnabled = true;
			this.lstYapilacaklar.ItemHeight = 16;
			this.lstYapilacaklar.Location = new System.Drawing.Point(111, 54);
			this.lstYapilacaklar.Name = "lstYapilacaklar";
			this.lstYapilacaklar.Size = new System.Drawing.Size(200, 228);
			this.lstYapilacaklar.TabIndex = 1;
			// 
			// tabPage3
			// 
			this.tabPage3.Controls.Add(this.lstYapilanlar);
			this.tabPage3.Location = new System.Drawing.Point(4, 25);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage3.Size = new System.Drawing.Size(795, 423);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "tabPage3";
			this.tabPage3.UseVisualStyleBackColor = true;
			// 
			// lstYapilanlar
			// 
			this.lstYapilanlar.FormattingEnabled = true;
			this.lstYapilanlar.ItemHeight = 16;
			this.lstYapilanlar.Location = new System.Drawing.Point(8, 6);
			this.lstYapilanlar.Name = "lstYapilanlar";
			this.lstYapilanlar.Size = new System.Drawing.Size(208, 404);
			this.lstYapilanlar.TabIndex = 0;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.tabControl1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			this.tabPage3.ResumeLayout(false);
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
		private System.Windows.Forms.ListBox lstYapilanlar;
	}
}

