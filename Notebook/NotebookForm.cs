using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Printing;

namespace Notebook
{
    public partial class NotebookForm : Form
    {
        private string filename;
        private bool isFileChanged;
        public NotebookForm()
        {
            InitializeComponent();

            Init();
        }

        private void Init()
        {
            filename = "";
            isFileChanged = false;
            UpdateTitle();
        }

        private void CreateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveUnsavedFile();
            filename = "";
            richTextBox.Text = "";
            isFileChanged = false;
            UpdateTitle();
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveUnsavedFile();
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы|*.*";
            opf.RestoreDirectory = true;
            if (opf.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader input = new StreamReader(opf.FileName, GetActiveEncode()))
                {
                    richTextBox.Text = input.ReadToEnd();
                    filename = Path.GetFileName(opf.FileName);
                }
            }
            UpdateTitle();
        }

        Encoding GetActiveEncode()
        {
            foreach (ToolStripMenuItem item in EncodingToolStripMenuItem.DropDownItems)
            {
                if (item.Checked)
                {
                    switch (item.Name)
                    {
                        case "MenuSelectUTF":
                            return Encoding.UTF8;
                        case "MenuItemASCII":
                            return Encoding.ASCII;
                        case "MenuItemUnicode":
                            return Encoding.Unicode;
                        default:
                            return Encoding.UTF8;
                    }
                }
            }
            return Encoding.UTF8;
        }

        void MenuEncodeUncheck()
        {
            MenuItemUTF.Checked = false;
            MenuItemASCII.Checked = false;
            MenuItemUnicode.Checked = false;
        }

        private void MenuItemUTF_Click(object sender, EventArgs e)
        {
            MenuEncodeUncheck();
            ((ToolStripMenuItem)sender).Checked = true;

            EncodingName.Text = $"Кодировка: {((ToolStripMenuItem)sender).Text}";
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы|*.*";
            sfd.FileName = filename;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string SaveFilePath = sfd.FileName;
                if (Path.GetExtension(SaveFilePath).Length == 0) SaveFilePath += ".txt";
                if (File.Exists(SaveFilePath))
                {
                    if (MessageBox.Show(string.Format("Файл с именем {0} уже существует.\n\n Заменить?", Path.GetFileName(SaveFilePath)), "Замена файла", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.Yes)
                    {
                        return;
                    }
                }
                using (Stream stream = File.Create(SaveFilePath))
                using (StreamWriter output = new StreamWriter(stream, GetActiveEncode()))
                {
                    output.Write(richTextBox.Text);
                }
            }
            isFileChanged = false;
            UpdateTitle();
        }

        private void OnTextChanged(object sender, EventArgs e)
        {
            int charCount = richTextBox.Text.Length;
            CharacterСounter.Text = "Символов: " + charCount;


            if (!isFileChanged)
            {
                this.Text = this.Text.Replace('*', ' ');
                isFileChanged = true;
                this.Text = "*" + this.Text;
            }
        }

        private void UpdateTitle()
        {
            if (filename != "")
            {
                this.Text = filename + " - Notebook";
            }
            else
            {
                this.Text = "Новый текстовый документ - Notebook";
            }
        }

        private void SaveUnsavedFile()
        {
            if (isFileChanged)
            {
                DialogResult result = MessageBox.Show("Сохранить изменения в файле?", "Сохранение файла", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (result == DialogResult.Yes)
                {
                    SaveFileDialog sfd = new SaveFileDialog();
                    sfd.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы|*.*";
                    sfd.FileName = filename;
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        string SaveFilePath = sfd.FileName;
                        if (Path.GetExtension(SaveFilePath).Length == 0) SaveFilePath += ".txt";
                        if (File.Exists(SaveFilePath))
                        {
                            if (MessageBox.Show(string.Format("Файл с именем {0} уже существует.\n\n Заменить?", Path.GetFileName(SaveFilePath)), "Замена файла", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.Yes)
                            {
                                return;
                            }
                        }
                        using (Stream stream = File.Create(SaveFilePath))
                        using (StreamWriter output = new StreamWriter(stream, GetActiveEncode()))
                        {
                            output.Write(richTextBox.Text);
                        }
                    }
                    isFileChanged = false;
                    UpdateTitle();
                }
            }
        }
        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.Cut();
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.Copy();
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.Paste();
        }

        private void OnClosing(object sender, FormClosingEventArgs e)
        {
            SaveUnsavedFile();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PrintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDocument document = new PrintDocument();
            document.PrintPage += PrintPage;
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = document;
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                document.Print();
            }
        }

        private void PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString(richTextBox.Text, richTextBox.Font, new SolidBrush(richTextBox.ForeColor), 10, 10);
        }

        private void InfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Блокнот v1.0. 2024.\n\nБлокнот - это простое и удобное приложение для создания заметок, которое позволяет хранить и организовывать ваши идеи, мысли и напоминания. Оно идеально подходит для тех, кто хочет иметь легкий доступ к своим заметкам и быстро делать записи на своем ПК.", "Блокнот: сведения", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ChangeAllTextFontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox.Font = fontDialog.Font;
            }
        }

        private void ChangeSelectedTextFontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox.SelectionFont = fontDialog.Font;
            }
        }

        private void ChangeAllTextColorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox.ForeColor = colorDialog.Color;
            }
        }

        private void ChangeSelectedTextColorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox.SelectionColor = colorDialog.Color;
            }
        }
    }
}
