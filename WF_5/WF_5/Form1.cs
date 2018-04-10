using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Создайте редактор на базе RichTextBox и добавьте в него возможность выбора из каталога и
//просмотра содержимого файла перетаскиванием файла на поле редактора.

namespace WF_5
{
    public partial class Form1 : Form
    {
        public TreeNode SelectedNode { get; set; }
        private List<string> File_To_Open;
        private OpenFileDialog openFile;
        private SaveFileDialog saveFile;
        public Form1()
        {
            InitializeComponent();
            Text = "Редактор";
            //делаем кнопки редактирования неактивными до загрузки файла
            contextMenuStrip2.Enabled = false;
            ToolStripMenuItem_Edit.Enabled = false;
            ToolStripMenuItem_Format.Enabled = false;
            ToolStripMenuItem_Save.Enabled = false;
            ToolStripMenuItem_SaveAs.Enabled = false;
            ToolStripMenuItem_Undo.Enabled = false;

            File_To_Open = new List<string>();
            FillDriveNodes();
            richTextBox1.EnableAutoDragDrop = true;
            richTextBox1.AllowDrop = true;
            // перетягиваем файл
            treeView1.BeforeSelect += TreeView1_BeforeSelect;
            treeView1.ItemDrag += TreeView1_ItemDrag;
            richTextBox1.DragEnter += RichTextBox1_DragEnter;
            richTextBox1.DragDrop += RichTextBox1_DragDrop;
            // создаем файл - присваиваем событие кнопкам
            ToolStripMenuItem_New.Click += Create_File;
            // открываем файл через Меню - присваиваем событие кнопке
            ToolStripMenuItem_Open.Click += Open_File;
            // сохраняем файл - присваиваем событие кнопке меню
            ToolStripMenuItem_Save.Click += Save_File;
            // сохранить как
            ToolStripMenuItem_SaveAs.Click += SaveAs_File;
            // выделить все
            ToolStripMenuItem_SelectAll.Click += SelectAll;
            ToolStripMenuItem1_SelectAll.Click += SelectAll;
            // копировать - присваиваем событие кнопкам
            ToolStripMenuItem_Copy.Click += Copy;
            ToolStripMenuItem1_Copy.Click += Copy;
            // вставить  - присваиваем событие кнопкам
            ToolStripMenuItem_Insert.Click += Paste;
            ToolStripMenuItem1_Insert.Click += Paste;
            // вырезать  - присваиваем событие кнопкам
            ToolStripMenuItem_Cut.Click += Cut;
            ToolStripMenuItem1_Cut.Click += Cut;
            // удалить  - присваиваем событие кнопкам
            ToolStripMenuItem_Delete.Click += Delete;
            ToolStripMenuItem1_Delete.Click += Delete;
            // отменить последнее действие
            ToolStripMenuItem_Undo.Click += Undo;
            // цвет фона
            ToolStripMenuItem_BgColor.Click += BgColor;
            // цвет шрифта
            ToolStripMenuItem_FontColor.Click += FontColor;
            // шрифт
            ToolStripMenuItem_Font.Click += Font;
            // изменения текста
            richTextBox1.TextChanged += RichTextBox1_TextChanged;
        }

        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {
            this.ToolStripMenuItem_Undo.Enabled = this.richTextBox1.CanUndo;
        }

        public void Font(object sender, EventArgs e)
        {
            FontDialog dialog = new FontDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionFont = dialog.Font;
            }
        }
        public void FontColor(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionColor = dialog.Color;
            }
        }
        public void BgColor(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.BackColor = dialog.Color;
            }
        }
        public void Undo(object sender, EventArgs e)
        {
            if (richTextBox1.CanUndo == true)
            {
                richTextBox1.Undo();
                //Удаляем из буфера отмены текстового поля сведения относительно последней операции.
                richTextBox1.ClearUndo();
            }
        }
        public void Delete(object sender, EventArgs e)
        {
            if (richTextBox1.SelectedText != "")
            {
                richTextBox1.SelectedText = "";
            }
        }
        public void Cut(object sender, EventArgs e)
        {
            if (richTextBox1.SelectedText != "")
            {
                richTextBox1.Cut();
            }
        }
        public void Paste(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }
        public void Copy(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionLength > 0)
            {
                richTextBox1.Copy();
            }
        }
        public void Create_File(object sender, EventArgs e)
        {
            //1. Появляется возможность вводить текст. Потом его можно сохранить стандартной процедурой Сохранить/ Сохранить как

            // richTextBox1.ReadOnly = false;
            // richTextBox1.Clear();
            //Активируем пункты меню
            //contextMenuStrip2.Enabled = true;
            //ToolStripMenuItem_Edit.Enabled = true;
            //ToolStripMenuItem_Format.Enabled = true;
            //ToolStripMenuItem_Save.Enabled = true;
            //ToolStripMenuItem_SaveAs.Enabled = true;

            //2. Создаем документ - сохраняем название и потом вводим текст.
            openFile = new OpenFileDialog();
            saveFile = new SaveFileDialog();
            saveFile.Filter = "All Files(*.*)|*.*|RTF files(*.rtf)|*.rtf|Txt files(*.txt)|*.txt";
            saveFile.FilterIndex = 2;
            if (saveFile.ShowDialog() == DialogResult.OK)
                richTextBox1.Clear();
            if (!File.Exists(saveFile.FileName))
            {
                FileStream newfile = File.Create(saveFile.FileName);
                richTextBox1.ReadOnly = false;
                newfile.Close();
                openFile.FileName = saveFile.FileName;
                Text = $"Файл - {openFile.FileName}";
                MessageBox.Show($"Новый файл {Path.GetFileName(openFile.FileName)} создан");
                //Активируем пункты меню
                Activating_Menu_Buttons();
            }
        }
        public void SelectAll(object sender, EventArgs e)
        {
            if (richTextBox1.Text != "")
            {
                richTextBox1.SelectAll();
            }
            else
            {
                MessageBox.Show("Пусто. Нечего выделять.");
            }
        }

        public void SaveAs_File(object sender, EventArgs e)
        {
            openFile = new OpenFileDialog();
            saveFile = new SaveFileDialog();
            saveFile.Filter = "All Files(*.*)|*.*|RTF files(*.rtf)|*.rtf|Txt files(*.txt)|*.txt";
            saveFile.FilterIndex = 2;
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                if (saveFile.FileName.EndsWith("rtf"))
                {
                    this.richTextBox1.SaveFile(saveFile.FileName, RichTextBoxStreamType.RichText);
                }
                else
                {
                    this.richTextBox1.SaveFile(saveFile.FileName, RichTextBoxStreamType.PlainText);
                }
                Text = $"Файл - {saveFile.FileName}";
                MessageBox.Show($"Файл {Path.GetFileName(openFile.FileName)} сохранен");
            }
        }
        public void Save_File(object sender, EventArgs e)
        {
            if (openFile.FileName != "")
            {
                if (openFile.FileName.EndsWith("rtf"))
                {
                    this.richTextBox1.SaveFile(openFile.FileName, RichTextBoxStreamType.RichText);
                }
                else
                {
                    this.richTextBox1.SaveFile(openFile.FileName, RichTextBoxStreamType.PlainText);
                }

                MessageBox.Show($"Файл {Path.GetFileName(openFile.FileName)} сохранен");
            }
        }

        public void Open_File(object sender, EventArgs e)
        {
            openFile = new OpenFileDialog();
            openFile.Filter = "All Files(*.*)|*.*|RTF files(*.rtf)|*.rtf|Txt files(*.txt)|*.txt";
            openFile.FilterIndex = 2;
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Clear();
                contextMenuStrip2.Enabled = true;
                try
                {
                    if (openFile.FileName.EndsWith("rtf"))
                    {
                        richTextBox1.LoadFile(openFile.FileName, RichTextBoxStreamType.RichText);
                    }
                    else
                    {
                        using (StreamReader reader = new StreamReader(openFile.FileName, Encoding.Default))
                        {
                            richTextBox1.Text = reader.ReadToEnd();
                        }
                    }

                    foreach (var VARIABLE in richTextBox1.Lines.ToList())
                    {
                        File_To_Open.Add(VARIABLE.ToString());
                    }
                    Text = openFile.FileName;
                    richTextBox1.BackColor = Color.White;
                    File_info();
                    //Активируем пункты меню
                    Activating_Menu_Buttons();
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Файл не выбран или поврежден", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Text = "Текстовый редактор";
                    openFile = null;
                }
            }
        }

        private void RichTextBox1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.Data.GetDataPresent(DataFormats.StringFormat) ? DragDropEffects.Copy : DragDropEffects.None;
        }

        private void RichTextBox1_DragDrop(object sender, DragEventArgs e)
        {
            string name = e.Data.GetData(DataFormats.Text).ToString();
            try
            {
                openFile = new OpenFileDialog();
                openFile.FileName = name;
                richTextBox1.Clear();
                if (openFile.FileName.EndsWith("rtf"))
                {
                    richTextBox1.LoadFile(openFile.FileName, RichTextBoxStreamType.RichText);
                }
                else
                {
                    using (StreamReader reader = new StreamReader(openFile.FileName, Encoding.Default))
                    {
                        richTextBox1.Text = reader.ReadToEnd();
                    }
                }
                foreach (var VARIABLE in richTextBox1.Lines.ToList())
                {
                    File_To_Open.Add(VARIABLE.ToString());
                }
                richTextBox1.BackColor = Color.White;
                Text = name;
                File_info();
                //Активируем пункты меню
                Activating_Menu_Buttons();
            }
            catch (Exception)
            {
                MessageBox.Show("Файл не выбран или поврежден", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Text = "Текстовый редактор";
                openFile = null;
            }
        }

        private void TreeView1_ItemDrag(object sender, ItemDragEventArgs e)
        {
            richTextBox1.ReadOnly = false;
            TreeNode tr = (TreeNode)e.Item;
            DoDragDrop(tr.FullPath, DragDropEffects.Copy | DragDropEffects.Move);
            if (openFile.FileName.EndsWith("rtf"))
            {
                richTextBox1.LoadFile(openFile.FileName, RichTextBoxStreamType.RichText);
            }
            else
            {
                using (StreamReader reader = new StreamReader(openFile.FileName, Encoding.Default))
                {
                    richTextBox1.Text = reader.ReadToEnd();
                }
            }
        }

        private void TreeView1_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            e.Node.Nodes.Clear();
            string[] dirs;
            string[] files;
            try
            {
                if (Directory.Exists(e.Node.FullPath))
                {
                    dirs = Directory.GetDirectories(e.Node.FullPath);
                    if (dirs.Length != 0)
                    {
                        for (int i = 0; i < dirs.Length; i++)
                        {
                            TreeNode dirNode = new TreeNode(new DirectoryInfo(dirs[i]).Name);
                            FillTreeNode(dirNode, dirs[i]);
                            e.Node.Nodes.Add(dirNode);
                        }
                    }
                    files = Directory.GetFiles(e.Node.FullPath);
                    for (int i = 0; i < files.Length; i++)
                    {
                        TreeNode fileNode = new TreeNode(Path.GetFileName(files[i]));
                        e.Node.Nodes.Add(fileNode);
                    }
                }
            }
            catch (Exception)
            {
                //MessageBox.Show("Что-то пошло не так!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void FillDriveNodes()
        {
            try
            {
                foreach (DriveInfo drive in DriveInfo.GetDrives())
                {
                    TreeNode driveNode = new TreeNode(drive.Name);
                    FillTreeNode(driveNode, drive.Name);
                    treeView1.Nodes.Add(driveNode);
                }
            }
            catch (Exception)
            {
                //MessageBox.Show("Что-то пошло не так!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void FillTreeNode(TreeNode driveNode, string path)
        {
            try
            {
                string[] dirs = Directory.GetDirectories(path);
                foreach (string dir in dirs)
                {
                    TreeNode dirNode = new TreeNode();
                    dirNode.Text = dir.Remove(0, dir.LastIndexOf("\\") + 1);
                    driveNode.Nodes.Add(dirNode);
                }
            }
            catch (Exception)
            {
                //MessageBox.Show("Что-то пошло не так!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void File_info()
        {
            label1_AllSymbols.Text = $@"Всего символов: {richTextBox1.Text.Length: ### ### ###}";
            label1_SymbolsWOSpaces.Text = $@"Символов без пробелов: {richTextBox1.Text.Replace(" ", "").Length: ### ### ###}";
            label1_CountLines.Text = $@"Всего строк: {(richTextBox1.Lines.Count()).ToString()}";
            label1_CreationData.Text = $@"Дата создания: {(File.GetCreationTime(openFile.FileName)).ToString()}";
        }

        private void Activating_Menu_Buttons()
        {
            contextMenuStrip2.Enabled = true;
            ToolStripMenuItem_Edit.Enabled = true;
            ToolStripMenuItem_Format.Enabled = true;
            ToolStripMenuItem_Save.Enabled = true;
            ToolStripMenuItem_SaveAs.Enabled = true;
            ToolStripMenuItem1_Cut.Enabled = true;
            ToolStripMenuItem1_Copy.Enabled = true;
            ToolStripMenuItem1_Insert.Enabled = true;
            ToolStripMenuItem1_Delete.Enabled = true;
            ToolStripMenuItem1_SelectAll.Enabled = true;
        }
    }
}