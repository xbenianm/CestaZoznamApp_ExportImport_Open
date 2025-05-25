
using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace CestaZoznamApp
{
    public partial class MainForm : Form
    {
        private string cestaSuboru = Path.Combine(Application.StartupPath, "paths.txt");

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (File.Exists(cestaSuboru))
            {
                var riadky = File.ReadAllLines(cestaSuboru).Distinct().ToList();
                listBoxCesty.Items.AddRange(riadky.ToArray());
            }
        }

        private void btnVyberPriecinok_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dialog = new FolderBrowserDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    string vybranaCesta = dialog.SelectedPath;

                    if (!listBoxCesty.Items.Contains(vybranaCesta))
                    {
                        listBoxCesty.Items.Add(vybranaCesta);
                        File.AppendAllLines(cestaSuboru, new[] { vybranaCesta });
                    }
                }
            }
        }

        private void btnOdstranit_Click(object sender, EventArgs e)
        {
            if (listBoxCesty.SelectedItem != null)
            {
                listBoxCesty.Items.Remove(listBoxCesty.SelectedItem);
                File.WriteAllLines(cestaSuboru, listBoxCesty.Items.Cast<string>());
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveDialog = new SaveFileDialog())
            {
                saveDialog.Filter = "Text Files (*.txt)|*.txt";
                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllLines(saveDialog.FileName, listBoxCesty.Items.Cast<string>());
                }
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openDialog = new OpenFileDialog())
            {
                openDialog.Filter = "Text Files (*.txt)|*.txt";
                if (openDialog.ShowDialog() == DialogResult.OK)
                {
                    var lines = File.ReadAllLines(openDialog.FileName).Distinct();
                    foreach (var line in lines)
                    {
                        if (!listBoxCesty.Items.Contains(line))
                            listBoxCesty.Items.Add(line);
                    }
                    File.WriteAllLines(cestaSuboru, listBoxCesty.Items.Cast<string>());
                }
            }
        }

        private void listBoxCesty_DoubleClick(object sender, EventArgs e)
        {
            if (listBoxCesty.SelectedItem != null)
            {
                string cesta = listBoxCesty.SelectedItem.ToString();
                if (Directory.Exists(cesta))
                {
                    Process.Start("explorer.exe", cesta);
                }
                else
                {
                    MessageBox.Show("Priečinok neexistuje.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
