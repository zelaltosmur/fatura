using System;
using System.Windows.Forms;

namespace FaturaOdemeTakip
{
    public partial class Form1 : Form
    {
        private DateTime faturaTarihi;
        private bool isFaturaGeçti;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnKontrolEt_Click(object sender, EventArgs e)
        {
            // Kullanıcı tarafından seçilen fatura tarihi
            faturaTarihi = dateTimePickerFatura.Value;

            // Şu anki tarih
            DateTime bugun = DateTime.Now;

            timer.Start();

            // kontorl amaçlı
            if (faturaTarihi < bugun)
            {
                isFaturaGeçti = true;
                lblSonuc.Text = "Fatura ödeme tarihi geçti. Geçen süre hesaplanıyor...";
                lblSonuc.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                isFaturaGeçti = false;
                lblSonuc.Text = "Fatura ödeme tarihi henüz gelmedi. Kalan süre hesaplanıyor...";
                lblSonuc.ForeColor = System.Drawing.Color.Green;
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            DateTime bugun = DateTime.Now;
            TimeSpan fark;

            // Eğer fatura ödeme tarihi geçmişse, geçen süreyi hesapla
            if (isFaturaGeçti)
            {
                fark = bugun - faturaTarihi;
                lblSonuc.Text = $"Fatura ödeme tarihi geçti. {fark.Days} Gün, {fark.Hours} Saat, {fark.Minutes} Dakika, {fark.Seconds} Saniye geçti.";
            }
            // Eğer fatura ödeme tarihi gelmemişse, kalan süreyi hesapla
            else
            {
                fark = faturaTarihi - bugun;
                lblSonuc.Text = $"Fatura ödeme tarihi henüz gelmedi. Kalan süre: {fark.Days} Gün, {fark.Hours} Saat, {fark.Minutes} Dakika.";
            }
        }
    }
}
