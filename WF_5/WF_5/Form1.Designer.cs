namespace WF_5
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
            this.components = new System.ComponentModel.Container();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToolStripMenuItem1_Cut = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem1_Copy = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem1_Insert = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem1_Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripMenuItem1_SelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_New = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Open = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Save = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_SaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Edit = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Undo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripMenuItem_Cut = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Copy = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Insert = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripMenuItem_SelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Format = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Font = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_FontColor = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_BgColor = new System.Windows.Forms.ToolStripMenuItem();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.label1_AllSymbols = new System.Windows.Forms.Label();
            this.label1_SymbolsWOSpaces = new System.Windows.Forms.Label();
            this.label1_CountLines = new System.Windows.Forms.Label();
            this.label1_CreationData = new System.Windows.Forms.Label();
            this.contextMenuStrip2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.ContextMenuStrip = this.contextMenuStrip2;
            this.richTextBox1.EnableAutoDragDrop = true;
            this.richTextBox1.Location = new System.Drawing.Point(311, 27);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(514, 400);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem1_Cut,
            this.ToolStripMenuItem1_Copy,
            this.ToolStripMenuItem1_Insert,
            this.ToolStripMenuItem1_Delete,
            this.toolStripSeparator2,
            this.ToolStripMenuItem1_SelectAll});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(153, 142);
            // 
            // ToolStripMenuItem1_Cut
            // 
            this.ToolStripMenuItem1_Cut.Enabled = false;
            this.ToolStripMenuItem1_Cut.Name = "ToolStripMenuItem1_Cut";
            this.ToolStripMenuItem1_Cut.Size = new System.Drawing.Size(152, 22);
            this.ToolStripMenuItem1_Cut.Text = "Вырезать";
            // 
            // ToolStripMenuItem1_Copy
            // 
            this.ToolStripMenuItem1_Copy.Enabled = false;
            this.ToolStripMenuItem1_Copy.Name = "ToolStripMenuItem1_Copy";
            this.ToolStripMenuItem1_Copy.Size = new System.Drawing.Size(152, 22);
            this.ToolStripMenuItem1_Copy.Text = "Копировать";
            // 
            // ToolStripMenuItem1_Insert
            // 
            this.ToolStripMenuItem1_Insert.Enabled = false;
            this.ToolStripMenuItem1_Insert.Name = "ToolStripMenuItem1_Insert";
            this.ToolStripMenuItem1_Insert.Size = new System.Drawing.Size(152, 22);
            this.ToolStripMenuItem1_Insert.Text = "Вставить";
            // 
            // ToolStripMenuItem1_Delete
            // 
            this.ToolStripMenuItem1_Delete.Enabled = false;
            this.ToolStripMenuItem1_Delete.Name = "ToolStripMenuItem1_Delete";
            this.ToolStripMenuItem1_Delete.Size = new System.Drawing.Size(152, 22);
            this.ToolStripMenuItem1_Delete.Text = "Удалить";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(149, 6);
            // 
            // ToolStripMenuItem1_SelectAll
            // 
            this.ToolStripMenuItem1_SelectAll.Enabled = false;
            this.ToolStripMenuItem1_SelectAll.Name = "ToolStripMenuItem1_SelectAll";
            this.ToolStripMenuItem1_SelectAll.Size = new System.Drawing.Size(152, 22);
            this.ToolStripMenuItem1_SelectAll.Text = "Выделить все";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.ToolStripMenuItem_Edit,
            this.ToolStripMenuItem_Format});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(837, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_New,
            this.ToolStripMenuItem_Open,
            this.ToolStripMenuItem_Save,
            this.ToolStripMenuItem_SaveAs});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // ToolStripMenuItem_New
            // 
            this.ToolStripMenuItem_New.Name = "ToolStripMenuItem_New";
            this.ToolStripMenuItem_New.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.ToolStripMenuItem_New.Size = new System.Drawing.Size(172, 22);
            this.ToolStripMenuItem_New.Text = "Создать";
            // 
            // ToolStripMenuItem_Open
            // 
            this.ToolStripMenuItem_Open.Name = "ToolStripMenuItem_Open";
            this.ToolStripMenuItem_Open.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.ToolStripMenuItem_Open.Size = new System.Drawing.Size(172, 22);
            this.ToolStripMenuItem_Open.Text = "Открыть";
            // 
            // ToolStripMenuItem_Save
            // 
            this.ToolStripMenuItem_Save.Name = "ToolStripMenuItem_Save";
            this.ToolStripMenuItem_Save.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.ToolStripMenuItem_Save.Size = new System.Drawing.Size(172, 22);
            this.ToolStripMenuItem_Save.Text = "Сохранить";
            // 
            // ToolStripMenuItem_SaveAs
            // 
            this.ToolStripMenuItem_SaveAs.Name = "ToolStripMenuItem_SaveAs";
            this.ToolStripMenuItem_SaveAs.Size = new System.Drawing.Size(172, 22);
            this.ToolStripMenuItem_SaveAs.Text = "Сохранить как...";
            // 
            // ToolStripMenuItem_Edit
            // 
            this.ToolStripMenuItem_Edit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_Undo,
            this.toolStripSeparator3,
            this.ToolStripMenuItem_Cut,
            this.ToolStripMenuItem_Copy,
            this.ToolStripMenuItem_Insert,
            this.ToolStripMenuItem_Delete,
            this.toolStripSeparator1,
            this.ToolStripMenuItem_SelectAll});
            this.ToolStripMenuItem_Edit.Name = "ToolStripMenuItem_Edit";
            this.ToolStripMenuItem_Edit.Size = new System.Drawing.Size(59, 20);
            this.ToolStripMenuItem_Edit.Text = "Правка";
            // 
            // ToolStripMenuItem_Undo
            // 
            this.ToolStripMenuItem_Undo.Name = "ToolStripMenuItem_Undo";
            this.ToolStripMenuItem_Undo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.ToolStripMenuItem_Undo.Size = new System.Drawing.Size(190, 22);
            this.ToolStripMenuItem_Undo.Text = "Отменить";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(187, 6);
            // 
            // ToolStripMenuItem_Cut
            // 
            this.ToolStripMenuItem_Cut.Name = "ToolStripMenuItem_Cut";
            this.ToolStripMenuItem_Cut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.ToolStripMenuItem_Cut.Size = new System.Drawing.Size(190, 22);
            this.ToolStripMenuItem_Cut.Text = "Вырезать";
            // 
            // ToolStripMenuItem_Copy
            // 
            this.ToolStripMenuItem_Copy.Name = "ToolStripMenuItem_Copy";
            this.ToolStripMenuItem_Copy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.ToolStripMenuItem_Copy.Size = new System.Drawing.Size(190, 22);
            this.ToolStripMenuItem_Copy.Text = "Копировать";
            // 
            // ToolStripMenuItem_Insert
            // 
            this.ToolStripMenuItem_Insert.Name = "ToolStripMenuItem_Insert";
            this.ToolStripMenuItem_Insert.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.ToolStripMenuItem_Insert.Size = new System.Drawing.Size(190, 22);
            this.ToolStripMenuItem_Insert.Text = "Вставить";
            // 
            // ToolStripMenuItem_Delete
            // 
            this.ToolStripMenuItem_Delete.Name = "ToolStripMenuItem_Delete";
            this.ToolStripMenuItem_Delete.Size = new System.Drawing.Size(190, 22);
            this.ToolStripMenuItem_Delete.Text = "Удалить";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(187, 6);
            // 
            // ToolStripMenuItem_SelectAll
            // 
            this.ToolStripMenuItem_SelectAll.Name = "ToolStripMenuItem_SelectAll";
            this.ToolStripMenuItem_SelectAll.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.ToolStripMenuItem_SelectAll.Size = new System.Drawing.Size(190, 22);
            this.ToolStripMenuItem_SelectAll.Text = "Выделить все";
            // 
            // ToolStripMenuItem_Format
            // 
            this.ToolStripMenuItem_Format.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_Font,
            this.ToolStripMenuItem_FontColor,
            this.ToolStripMenuItem_BgColor});
            this.ToolStripMenuItem_Format.Name = "ToolStripMenuItem_Format";
            this.ToolStripMenuItem_Format.Size = new System.Drawing.Size(62, 20);
            this.ToolStripMenuItem_Format.Text = "Формат";
            // 
            // ToolStripMenuItem_Font
            // 
            this.ToolStripMenuItem_Font.Name = "ToolStripMenuItem_Font";
            this.ToolStripMenuItem_Font.Size = new System.Drawing.Size(148, 22);
            this.ToolStripMenuItem_Font.Text = "Шрифт";
            // 
            // ToolStripMenuItem_FontColor
            // 
            this.ToolStripMenuItem_FontColor.Name = "ToolStripMenuItem_FontColor";
            this.ToolStripMenuItem_FontColor.Size = new System.Drawing.Size(148, 22);
            this.ToolStripMenuItem_FontColor.Text = "Цвет шрифта";
            // 
            // ToolStripMenuItem_BgColor
            // 
            this.ToolStripMenuItem_BgColor.Name = "ToolStripMenuItem_BgColor";
            this.ToolStripMenuItem_BgColor.Size = new System.Drawing.Size(148, 22);
            this.ToolStripMenuItem_BgColor.Text = "Цвет фона";
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(13, 28);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(292, 442);
            this.treeView1.TabIndex = 2;
            // 
            // label1_AllSymbols
            // 
            this.label1_AllSymbols.AutoSize = true;
            this.label1_AllSymbols.Location = new System.Drawing.Point(314, 434);
            this.label1_AllSymbols.Name = "label1_AllSymbols";
            this.label1_AllSymbols.Size = new System.Drawing.Size(102, 13);
            this.label1_AllSymbols.TabIndex = 3;
            this.label1_AllSymbols.Text = "Всего символов: 0";
            // 
            // label1_SymbolsWOSpaces
            // 
            this.label1_SymbolsWOSpaces.AutoSize = true;
            this.label1_SymbolsWOSpaces.Location = new System.Drawing.Point(314, 455);
            this.label1_SymbolsWOSpaces.Name = "label1_SymbolsWOSpaces";
            this.label1_SymbolsWOSpaces.Size = new System.Drawing.Size(142, 13);
            this.label1_SymbolsWOSpaces.TabIndex = 4;
            this.label1_SymbolsWOSpaces.Text = "Символов без пробелов: 0";
            // 
            // label1_CountLines
            // 
            this.label1_CountLines.AutoSize = true;
            this.label1_CountLines.Location = new System.Drawing.Point(558, 433);
            this.label1_CountLines.Name = "label1_CountLines";
            this.label1_CountLines.Size = new System.Drawing.Size(81, 13);
            this.label1_CountLines.TabIndex = 5;
            this.label1_CountLines.Text = "Всего строк: 0";
            // 
            // label1_CreationData
            // 
            this.label1_CreationData.AutoSize = true;
            this.label1_CreationData.Location = new System.Drawing.Point(558, 455);
            this.label1_CreationData.Name = "label1_CreationData";
            this.label1_CreationData.Size = new System.Drawing.Size(87, 13);
            this.label1_CreationData.TabIndex = 6;
            this.label1_CreationData.Text = "Дата создания:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 482);
            this.Controls.Add(this.label1_CreationData);
            this.Controls.Add(this.label1_CountLines);
            this.Controls.Add(this.label1_SymbolsWOSpaces);
            this.Controls.Add(this.label1_AllSymbols);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.contextMenuStrip2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Open;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Save;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_SaveAs;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Edit;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Cut;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Copy;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Insert;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Delete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_SelectAll;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Format;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Font;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_FontColor;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem1_Cut;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem1_Copy;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem1_Insert;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem1_Delete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem1_SelectAll;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_New;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Undo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_BgColor;
        private System.Windows.Forms.Label label1_AllSymbols;
        private System.Windows.Forms.Label label1_SymbolsWOSpaces;
        private System.Windows.Forms.Label label1_CountLines;
        private System.Windows.Forms.Label label1_CreationData;
    }
}

