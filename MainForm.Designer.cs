
namespace CestaZoznamApp
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnVyberPriecinok;
        private System.Windows.Forms.Button btnOdstranit;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.ListBox listBoxCesty;

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
            this.btnVyberPriecinok = new System.Windows.Forms.Button();
            this.btnOdstranit = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.listBoxCesty = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnVyberPriecinok
            // 
            this.btnVyberPriecinok.Location = new System.Drawing.Point(20, 20);
            this.btnVyberPriecinok.Name = "btnVyberPriecinok";
            this.btnVyberPriecinok.Size = new System.Drawing.Size(140, 30);
            this.btnVyberPriecinok.TabIndex = 0;
            this.btnVyberPriecinok.Text = "Vybrať priečinok";
            this.btnVyberPriecinok.Click += new System.EventHandler(this.btnVyberPriecinok_Click);
            // 
            // btnOdstranit
            // 
            this.btnOdstranit.Location = new System.Drawing.Point(170, 20);
            this.btnOdstranit.Name = "btnOdstranit";
            this.btnOdstranit.Size = new System.Drawing.Size(140, 30);
            this.btnOdstranit.TabIndex = 1;
            this.btnOdstranit.Text = "Odstrániť cestu";
            this.btnOdstranit.Click += new System.EventHandler(this.btnOdstranit_Click);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(320, 20);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 30);
            this.btnExport.TabIndex = 2;
            this.btnExport.Text = "Export";
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(405, 20);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(75, 30);
            this.btnImport.TabIndex = 3;
            this.btnImport.Text = "Import";
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // listBoxCesty
            // 
            this.listBoxCesty.FormattingEnabled = true;
            this.listBoxCesty.ItemHeight = 16;
            this.listBoxCesty.Location = new System.Drawing.Point(20, 60);
            this.listBoxCesty.Name = "listBoxCesty";
            this.listBoxCesty.Size = new System.Drawing.Size(460, 468);
            this.listBoxCesty.TabIndex = 4;
            this.listBoxCesty.DoubleClick += new System.EventHandler(this.listBoxCesty_DoubleClick);
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(496, 566);
            this.Controls.Add(this.btnVyberPriecinok);
            this.Controls.Add(this.btnOdstranit);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.listBoxCesty);
            this.Name = "MainForm";
            this.Text = "Zoznam priečinkov";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }
    }
}
