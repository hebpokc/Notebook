
namespace Notebook
{
    partial class NotebookForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotebookForm));
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PrintToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CopyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FontTypefaceSizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangeAllTextFontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangeSelectedTextFontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FontColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangeAllTextColorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangeSelectedTextColorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.EncodingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemUTF = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemASCII = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemUnicode = new System.Windows.Forms.ToolStripMenuItem();
            this.ReferenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.CharacterСounter = new System.Windows.Forms.ToolStripStatusLabel();
            this.EncodingName = new System.Windows.Forms.ToolStripStatusLabel();
            this.Menu.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.SystemColors.Control;
            this.Menu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.EditToolStripMenuItem,
            this.FontToolStripMenuItem,
            this.EncodingToolStripMenuItem,
            this.ReferenceToolStripMenuItem});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(790, 24);
            this.Menu.TabIndex = 0;
            this.Menu.Text = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreateToolStripMenuItem,
            this.OpenToolStripMenuItem,
            this.SaveToolStripMenuItem,
            this.PrintToolStripMenuItem,
            this.ExitToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.FileToolStripMenuItem.Text = "Файл";
            // 
            // CreateToolStripMenuItem
            // 
            this.CreateToolStripMenuItem.Name = "CreateToolStripMenuItem";
            this.CreateToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.CreateToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.CreateToolStripMenuItem.Text = "Создать";
            this.CreateToolStripMenuItem.Click += new System.EventHandler(this.CreateToolStripMenuItem_Click);
            // 
            // OpenToolStripMenuItem
            // 
            this.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            this.OpenToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.OpenToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.OpenToolStripMenuItem.Text = "Открыть...";
            this.OpenToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // SaveToolStripMenuItem
            // 
            this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            this.SaveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.SaveToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.SaveToolStripMenuItem.Text = "Сохранить";
            this.SaveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // PrintToolStripMenuItem
            // 
            this.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem";
            this.PrintToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.PrintToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.PrintToolStripMenuItem.Text = "Печать";
            this.PrintToolStripMenuItem.Click += new System.EventHandler(this.PrintToolStripMenuItem_Click);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.ExitToolStripMenuItem.Text = "Выход";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // EditToolStripMenuItem
            // 
            this.EditToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CutToolStripMenuItem,
            this.CopyToolStripMenuItem,
            this.PasteToolStripMenuItem});
            this.EditToolStripMenuItem.Name = "EditToolStripMenuItem";
            this.EditToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.EditToolStripMenuItem.Text = "Правка";
            // 
            // CutToolStripMenuItem
            // 
            this.CutToolStripMenuItem.Name = "CutToolStripMenuItem";
            this.CutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.CutToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.CutToolStripMenuItem.Text = "Вырезать";
            this.CutToolStripMenuItem.Click += new System.EventHandler(this.CutToolStripMenuItem_Click);
            // 
            // CopyToolStripMenuItem
            // 
            this.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem";
            this.CopyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.CopyToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.CopyToolStripMenuItem.Text = "Копировать";
            this.CopyToolStripMenuItem.Click += new System.EventHandler(this.CopyToolStripMenuItem_Click);
            // 
            // PasteToolStripMenuItem
            // 
            this.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem";
            this.PasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.PasteToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.PasteToolStripMenuItem.Text = "Вставить";
            this.PasteToolStripMenuItem.Click += new System.EventHandler(this.PasteToolStripMenuItem_Click);
            // 
            // FontToolStripMenuItem
            // 
            this.FontToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FontTypefaceSizeToolStripMenuItem,
            this.FontColorToolStripMenuItem});
            this.FontToolStripMenuItem.Name = "FontToolStripMenuItem";
            this.FontToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.FontToolStripMenuItem.Text = "Шрифт";
            // 
            // FontTypefaceSizeToolStripMenuItem
            // 
            this.FontTypefaceSizeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ChangeAllTextFontToolStripMenuItem,
            this.ChangeSelectedTextFontToolStripMenuItem});
            this.FontTypefaceSizeToolStripMenuItem.Name = "FontTypefaceSizeToolStripMenuItem";
            this.FontTypefaceSizeToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.FontTypefaceSizeToolStripMenuItem.Text = "Начертание | Размер";
            // 
            // ChangeAllTextFontToolStripMenuItem
            // 
            this.ChangeAllTextFontToolStripMenuItem.Name = "ChangeAllTextFontToolStripMenuItem";
            this.ChangeAllTextFontToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.ChangeAllTextFontToolStripMenuItem.Text = "Изменить весь текст";
            this.ChangeAllTextFontToolStripMenuItem.Click += new System.EventHandler(this.ChangeAllTextFontToolStripMenuItem_Click);
            // 
            // ChangeSelectedTextFontToolStripMenuItem
            // 
            this.ChangeSelectedTextFontToolStripMenuItem.Name = "ChangeSelectedTextFontToolStripMenuItem";
            this.ChangeSelectedTextFontToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.ChangeSelectedTextFontToolStripMenuItem.Text = "Изменить выделенный текст";
            this.ChangeSelectedTextFontToolStripMenuItem.Click += new System.EventHandler(this.ChangeSelectedTextFontToolStripMenuItem_Click);
            // 
            // FontColorToolStripMenuItem
            // 
            this.FontColorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ChangeAllTextColorToolStripMenuItem1,
            this.ChangeSelectedTextColorToolStripMenuItem1});
            this.FontColorToolStripMenuItem.Name = "FontColorToolStripMenuItem";
            this.FontColorToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.FontColorToolStripMenuItem.Text = "Цвет";
            // 
            // ChangeAllTextColorToolStripMenuItem1
            // 
            this.ChangeAllTextColorToolStripMenuItem1.Name = "ChangeAllTextColorToolStripMenuItem1";
            this.ChangeAllTextColorToolStripMenuItem1.Size = new System.Drawing.Size(232, 22);
            this.ChangeAllTextColorToolStripMenuItem1.Text = "Изменить весь текст";
            this.ChangeAllTextColorToolStripMenuItem1.Click += new System.EventHandler(this.ChangeAllTextColorToolStripMenuItem1_Click);
            // 
            // ChangeSelectedTextColorToolStripMenuItem1
            // 
            this.ChangeSelectedTextColorToolStripMenuItem1.Name = "ChangeSelectedTextColorToolStripMenuItem1";
            this.ChangeSelectedTextColorToolStripMenuItem1.Size = new System.Drawing.Size(232, 22);
            this.ChangeSelectedTextColorToolStripMenuItem1.Text = "Изменить выделенный текст";
            this.ChangeSelectedTextColorToolStripMenuItem1.Click += new System.EventHandler(this.ChangeSelectedTextColorToolStripMenuItem1_Click);
            // 
            // EncodingToolStripMenuItem
            // 
            this.EncodingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemUTF,
            this.MenuItemASCII,
            this.MenuItemUnicode});
            this.EncodingToolStripMenuItem.Name = "EncodingToolStripMenuItem";
            this.EncodingToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.EncodingToolStripMenuItem.Text = "Кодировка";
            // 
            // MenuItemUTF
            // 
            this.MenuItemUTF.Checked = true;
            this.MenuItemUTF.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MenuItemUTF.Name = "MenuItemUTF";
            this.MenuItemUTF.Size = new System.Drawing.Size(180, 22);
            this.MenuItemUTF.Text = "UTF-8";
            this.MenuItemUTF.Click += new System.EventHandler(this.MenuItemUTF_Click);
            // 
            // MenuItemASCII
            // 
            this.MenuItemASCII.Name = "MenuItemASCII";
            this.MenuItemASCII.Size = new System.Drawing.Size(180, 22);
            this.MenuItemASCII.Text = "ASCII";
            this.MenuItemASCII.Click += new System.EventHandler(this.MenuItemUTF_Click);
            // 
            // MenuItemUnicode
            // 
            this.MenuItemUnicode.Name = "MenuItemUnicode";
            this.MenuItemUnicode.Size = new System.Drawing.Size(180, 22);
            this.MenuItemUnicode.Text = "Unicode";
            this.MenuItemUnicode.Click += new System.EventHandler(this.MenuItemUTF_Click);
            // 
            // ReferenceToolStripMenuItem
            // 
            this.ReferenceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.InfoToolStripMenuItem});
            this.ReferenceToolStripMenuItem.Name = "ReferenceToolStripMenuItem";
            this.ReferenceToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.ReferenceToolStripMenuItem.Text = "Справка";
            // 
            // InfoToolStripMenuItem
            // 
            this.InfoToolStripMenuItem.Name = "InfoToolStripMenuItem";
            this.InfoToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.InfoToolStripMenuItem.Text = "О программе";
            this.InfoToolStripMenuItem.Click += new System.EventHandler(this.InfoToolStripMenuItem_Click);
            // 
            // richTextBox
            // 
            this.richTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox.Location = new System.Drawing.Point(0, 24);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(790, 553);
            this.richTextBox.TabIndex = 1;
            this.richTextBox.Text = "";
            this.richTextBox.TextChanged += new System.EventHandler(this.OnTextChanged);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CharacterСounter,
            this.EncodingName});
            this.statusStrip.Location = new System.Drawing.Point(0, 553);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.statusStrip.Size = new System.Drawing.Size(790, 24);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "statusStrip1";
            // 
            // CharacterСounter
            // 
            this.CharacterСounter.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)));
            this.CharacterСounter.Name = "CharacterСounter";
            this.CharacterСounter.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CharacterСounter.Size = new System.Drawing.Size(74, 19);
            this.CharacterСounter.Text = "Символов: ";
            // 
            // EncodingName
            // 
            this.EncodingName.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.EncodingName.Name = "EncodingName";
            this.EncodingName.Size = new System.Drawing.Size(107, 19);
            this.EncodingName.Text = "Кодировка: UTF-8";
            // 
            // NotebookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 577);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.Menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.Menu;
            this.Name = "NotebookForm";
            this.Text = "Notebook";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnClosing);
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CreateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.ToolStripMenuItem FontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EncodingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuItemASCII;
        private System.Windows.Forms.ToolStripMenuItem MenuItemUnicode;
        private System.Windows.Forms.ToolStripMenuItem MenuItemUTF;
        private System.Windows.Forms.ToolStripMenuItem EditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CopyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PrintToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ReferenceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem InfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FontTypefaceSizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FontColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ChangeAllTextFontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ChangeSelectedTextFontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ChangeAllTextColorToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ChangeSelectedTextColorToolStripMenuItem1;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel CharacterСounter;
        private System.Windows.Forms.ToolStripStatusLabel EncodingName;
    }
}

