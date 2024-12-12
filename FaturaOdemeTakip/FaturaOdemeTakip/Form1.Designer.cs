namespace FaturaOdemeTakip
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DateTimePicker dateTimePickerFatura;
        private System.Windows.Forms.Button btnKontrolEt;
        private System.Windows.Forms.Label lblSonuc;
        private System.Windows.Forms.Timer timer;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dateTimePickerFatura = new System.Windows.Forms.DateTimePicker();
            this.btnKontrolEt = new System.Windows.Forms.Button();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dateTimePickerFatura
            // 
            this.dateTimePickerFatura.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFatura.Location = new System.Drawing.Point(187, 12);
            this.dateTimePickerFatura.Name = "dateTimePickerFatura";
            this.dateTimePickerFatura.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerFatura.TabIndex = 0;
            // 
            // btnKontrolEt
            // 
            this.btnKontrolEt.Location = new System.Drawing.Point(187, 52);
            this.btnKontrolEt.Name = "btnKontrolEt";
            this.btnKontrolEt.Size = new System.Drawing.Size(200, 30);
            this.btnKontrolEt.TabIndex = 1;
            this.btnKontrolEt.Text = "Ödeme Durumunu Kontrol Et";
            this.btnKontrolEt.UseVisualStyleBackColor = true;
            this.btnKontrolEt.Click += new System.EventHandler(this.btnKontrolEt_Click);
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Location = new System.Drawing.Point(12, 100);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(0, 16);
            this.lblSonuc.TabIndex = 2;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Fatura Son Ödeme Tarihi: ";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(488, 200);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.btnKontrolEt);
            this.Controls.Add(this.dateTimePickerFatura);
            this.Name = "Form1";
            this.Text = "Fatura ve Ödeme Takip";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label label1;
    }
}
