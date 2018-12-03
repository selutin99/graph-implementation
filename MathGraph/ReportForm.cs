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

namespace MathGraph
{
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
            listBoxMatrix.HorizontalScrollbar = true;
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void экспортироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listBoxMatrix.Text != null)
            {
                string listBoxData="";

                SaveFileDialog savedialog = new SaveFileDialog();
                savedialog.Title = "Сохранить отчёт как...";
                savedialog.OverwritePrompt = true;
                savedialog.CheckPathExists = true;
                savedialog.Filter = "Text File | *.txt";


                if (savedialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        foreach (string str in listBoxMatrix.Items)
                        {
                            listBoxData += str + "\r\n";
                        }
                        File.WriteAllText(savedialog.FileName, listBoxData);
                        MessageBox.Show("Сохранение произведено успешно", "Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    catch
                    {
                        MessageBox.Show("Невозможно сохранить изображение", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
