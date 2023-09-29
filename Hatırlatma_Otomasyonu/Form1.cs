using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LicenseContext = OfficeOpenXml.LicenseContext;

namespace Hatırlatma_Otomasyonu
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}



		
		private void YapilacakIsEkle(string isAdi)
		{
			string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,"yapilacaklar_listesi.xlsx");
			FileInfo file = new FileInfo(path);
			ExcelPackage.LicenseContext = LicenseContext.NonCommercial;//Geliştirme amacıyla kullandığım için lisans matirisini ayarladım

			using (ExcelPackage package = new ExcelPackage(file))
			{
				ExcelWorksheet worksheet;
				if (package.Workbook.Worksheets.Count == 0)
				{
					worksheet = package.Workbook.Worksheets.Add("Yapilacaklar");
				}
				else
				{
					worksheet = package.Workbook.Worksheets[0];
				}

				int row = worksheet.Dimension?.Rows + 1 ?? 1;
				worksheet.Cells[row, 1].Value = isAdi;
				worksheet.Cells[row, 2].Value = DateTime.Now.ToString("yyyy-MM-dd HH:mm"); // Tarihi B sütununa ekleme
				package.Save();

				ListeyiGuncelle(); // Listeyi güncelleyin
				MessageBox.Show("İş başarıyla kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}


		private void YapilanIsEkleVeSil(string isAdi)
		{
			string pathYapilacaklar = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,  "yapilacaklar_listesi.xlsx");
			string pathYapilanlar = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,  "yapilanlar.xlsx");

			FileInfo fileYapilacaklar = new FileInfo(pathYapilacaklar);
			FileInfo fileYapilanlar = new FileInfo(pathYapilanlar);


			using (ExcelPackage packageYapilacaklar = new ExcelPackage(fileYapilacaklar))
			using (ExcelPackage packageYapilanlar = new ExcelPackage(fileYapilanlar))
			{
				// Yapilacaklar'dan silme
				var wsYapilacaklar = packageYapilacaklar.Workbook.Worksheets[0];
				for (int i = 1; i <= wsYapilacaklar.Dimension?.Rows; i++)
				{
					if (wsYapilacaklar.Cells[i, 1].Text == isAdi)
					{
						wsYapilacaklar.DeleteRow(i);
						break;
					}
				}

				// Yapilanlara ekleme
				ExcelWorksheet wsYapilanlar;
				if (packageYapilanlar.Workbook.Worksheets.Count == 0)
				{
					wsYapilanlar = packageYapilanlar.Workbook.Worksheets.Add("Yapilanlar");
				}
				else
				{
					wsYapilanlar = packageYapilanlar.Workbook.Worksheets[0];
				}

				int row = wsYapilanlar.Dimension?.Rows + 1 ?? 1;
				wsYapilanlar.Cells[row, 1].Value = isAdi;
				wsYapilanlar.Cells[row, 2].Value = DateTime.Now.ToString("yyyy-MM-dd HH:mm"); // Tarihi B sütununa ekleme


				packageYapilacaklar.Save();
				packageYapilanlar.Save();


				ListeyiGuncelle(); // Listeyi güncelleyin
				YapilanlariListele();
				MessageBox.Show("Veri başarıyla yapılanlar listesine eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		private void ListeyiGuncelle()
		{
			lstYapilacaklar.Items.Clear(); // Önce mevcut veriyi temizleyin.

			string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "yapilacaklar_listesi.xlsx");
			FileInfo file = new FileInfo(path);

			if (file.Exists)
			{
				ExcelPackage.LicenseContext = LicenseContext.NonCommercial;//Geliştirme amacıyla kullandığım için lisans matirisini ayarladım
				using (ExcelPackage package = new ExcelPackage(file))
				{
					ExcelWorksheet worksheet = package.Workbook.Worksheets[0];
					if (worksheet != null)
					{
						int totalRows = worksheet.Dimension?.Rows ?? 0;
						for (int i = 2; i <= totalRows; i++)//listbox da 2. sütundan başlama
						{
							lstYapilacaklar.Items.Add(worksheet.Cells[i, 1].Text);
						}
					}
				}
			}
		}


		private void YapilanlariListele()
		{
			string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "yapilanlar.xlsx");
			FileInfo file = new FileInfo(path);

			DataTable dt = new DataTable();
			dt.Columns.Add("Yapılan İşin Adı", typeof(string));
			dt.Columns.Add("Bitirme Zamanı", typeof(string));

			if (file.Exists)
			{
				using (ExcelPackage package = new ExcelPackage(file))
				{
					ExcelWorksheet worksheet = package.Workbook.Worksheets[0];
					if (worksheet != null)
					{
						int totalRows = worksheet.Dimension?.Rows ?? 0;
						for (int i = 2; i <= totalRows; i++)
						{
							DataRow row = dt.NewRow();
							row["Yapılan İşin Adı"] = worksheet.Cells[i, 1].Text;
							row["Bitirme Zamanı"] = worksheet.Cells[i, 2].Text;
							dt.Rows.Add(row);
						}
					}
				}
			}

			dgvYapilanlar.DataSource = dt;
		}



		private void btnKaydet_Click(object sender, EventArgs e)
		{
			YapilacakIsEkle(txtIsAdi.Text);
			txtIsAdi.Clear();
		}

		private void btnYapildi_Click(object sender, EventArgs e)
		{
			string isAdi = (string)lstYapilacaklar.SelectedItem;
			YapilanIsEkleVeSil(isAdi);
			lstYapilacaklar.Items.Remove(isAdi);
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			ListeyiGuncelle();
			YapilanlariListele();
		}
	}
}
