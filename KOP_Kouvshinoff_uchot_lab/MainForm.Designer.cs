﻿namespace KOP_Kouvshinoff_uchot_lab
{
    partial class MainForm
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
            components = new System.ComponentModel.Container();
            contextMenuStrip = new ContextMenuStrip(components);
            добавлениеToolStripMenuItem = new ToolStripMenuItem();
            редактированиеToolStripMenuItem = new ToolStripMenuItem();
            удалениеToolStripMenuItem = new ToolStripMenuItem();
            обновитьToolStripMenuItem = new ToolStripMenuItem();
            customTree = new KOP_Labs.CustomTree();
            menuStrip = new MenuStrip();
            справочникСложностейToolStripMenuItem = new ToolStripMenuItem();
            созданиеДокументаToolStripMenuItem = new ToolStripMenuItem();
            excelToolStripMenuItem = new ToolStripMenuItem();
            wordToolStripMenuItem = new ToolStripMenuItem();
            pdfToolStripMenuItem = new ToolStripMenuItem();
            customComponentExcelBigText = new Non_visual_components_Kouvshinoff.CustomComponentExcelBigText(components);
            componentDocumentWithTableMultiHeaderWord = new ComponentsLibraryNet60.DocumentWithTable.ComponentDocumentWithTableMultiHeaderWord(components);
            pdfPieChart = new CustomComponents.NonVisualComponents.PdfPieChart(components);
            contextMenuStrip.SuspendLayout();
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // contextMenuStrip
            // 
            contextMenuStrip.Items.AddRange(new ToolStripItem[] { добавлениеToolStripMenuItem, редактированиеToolStripMenuItem, удалениеToolStripMenuItem, обновитьToolStripMenuItem });
            contextMenuStrip.Name = "contextMenuStrip1";
            contextMenuStrip.ShowImageMargin = false;
            contextMenuStrip.Size = new Size(130, 92);
            // 
            // добавлениеToolStripMenuItem
            // 
            добавлениеToolStripMenuItem.Name = "добавлениеToolStripMenuItem";
            добавлениеToolStripMenuItem.Size = new Size(129, 22);
            добавлениеToolStripMenuItem.Text = "добавить";
            добавлениеToolStripMenuItem.Click += добавлениеToolStripMenuItem_Click;
            // 
            // редактированиеToolStripMenuItem
            // 
            редактированиеToolStripMenuItem.Name = "редактированиеToolStripMenuItem";
            редактированиеToolStripMenuItem.Size = new Size(129, 22);
            редактированиеToolStripMenuItem.Text = "редактировать";
            редактированиеToolStripMenuItem.Click += редактированиеToolStripMenuItem_Click;
            // 
            // удалениеToolStripMenuItem
            // 
            удалениеToolStripMenuItem.Name = "удалениеToolStripMenuItem";
            удалениеToolStripMenuItem.Size = new Size(129, 22);
            удалениеToolStripMenuItem.Text = "удалить";
            удалениеToolStripMenuItem.Click += удалениеToolStripMenuItem_Click;
            // 
            // обновитьToolStripMenuItem
            // 
            обновитьToolStripMenuItem.Name = "обновитьToolStripMenuItem";
            обновитьToolStripMenuItem.Size = new Size(129, 22);
            обновитьToolStripMenuItem.Text = "обновить";
            обновитьToolStripMenuItem.Click += обновитьToolStripMenuItem_Click;
            // 
            // customTree
            // 
            customTree.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            customTree.AutoSize = true;
            customTree.ContextMenuStrip = contextMenuStrip;
            customTree.Hierarcy = null;
            customTree.Location = new Point(12, 26);
            customTree.Margin = new Padding(3, 2, 3, 2);
            customTree.Name = "customTree";
            customTree.Size = new Size(776, 413);
            customTree.TabIndex = 1;
            // 
            // menuStrip
            // 
            menuStrip.Items.AddRange(new ToolStripItem[] { справочникСложностейToolStripMenuItem, созданиеДокументаToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(800, 24);
            menuStrip.TabIndex = 2;
            menuStrip.Text = "menuStrip1";
            // 
            // справочникСложностейToolStripMenuItem
            // 
            справочникСложностейToolStripMenuItem.Name = "справочникСложностейToolStripMenuItem";
            справочникСложностейToolStripMenuItem.Size = new Size(155, 20);
            справочникСложностейToolStripMenuItem.Text = "справочник сложностей";
            справочникСложностейToolStripMenuItem.Click += справочникСложностейToolStripMenuItem_Click;
            // 
            // созданиеДокументаToolStripMenuItem
            // 
            созданиеДокументаToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { excelToolStripMenuItem, wordToolStripMenuItem, pdfToolStripMenuItem });
            созданиеДокументаToolStripMenuItem.Name = "созданиеДокументаToolStripMenuItem";
            созданиеДокументаToolStripMenuItem.Size = new Size(130, 20);
            созданиеДокументаToolStripMenuItem.Text = "создание документа";
            // 
            // excelToolStripMenuItem
            // 
            excelToolStripMenuItem.Name = "excelToolStripMenuItem";
            excelToolStripMenuItem.Size = new Size(451, 22);
            excelToolStripMenuItem.Text = "документ в Excel по лабораторным, которые не сдавали студенты";
            excelToolStripMenuItem.Click += excelToolStripMenuItem_Click;
            // 
            // wordToolStripMenuItem
            // 
            wordToolStripMenuItem.Name = "wordToolStripMenuItem";
            wordToolStripMenuItem.Size = new Size(451, 22);
            wordToolStripMenuItem.Text = "отчет в Word с информацией по всем лабораторным";
            wordToolStripMenuItem.Click += wordToolStripMenuItem_Click;
            // 
            // pdfToolStripMenuItem
            // 
            pdfToolStripMenuItem.Name = "pdfToolStripMenuItem";
            pdfToolStripMenuItem.Size = new Size(451, 22);
            pdfToolStripMenuItem.Text = "Круговая диаграмма в Pdf, сколько сдаваемых лабораторных какой";
            pdfToolStripMenuItem.Click += pdfToolStripMenuItem_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip);
            Controls.Add(customTree);
            KeyPreview = true;
            MainMenuStrip = menuStrip;
            Name = "MainForm";
            Text = "Main";
            KeyDown += MainForm_KeyDown;
            contextMenuStrip.ResumeLayout(false);
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ContextMenuStrip contextMenuStrip;
        private KOP_Labs.CustomTree customTree;
        private ToolStripMenuItem добавлениеToolStripMenuItem;
        private ToolStripMenuItem редактированиеToolStripMenuItem;
        private ToolStripMenuItem удалениеToolStripMenuItem;
        private ToolStripMenuItem обновитьToolStripMenuItem;
        private MenuStrip menuStrip;
        private ToolStripMenuItem справочникСложностейToolStripMenuItem;
        private ToolStripMenuItem созданиеДокументаToolStripMenuItem;
        private ToolStripMenuItem excelToolStripMenuItem;
        private ToolStripMenuItem wordToolStripMenuItem;
        private ToolStripMenuItem pdfToolStripMenuItem;
        private Non_visual_components_Kouvshinoff.CustomComponentExcelBigText customComponentExcelBigText;
        private ComponentsLibraryNet60.DocumentWithTable.ComponentDocumentWithTableMultiHeaderWord componentDocumentWithTableMultiHeaderWord;
        private CustomComponents.NonVisualComponents.PdfPieChart pdfPieChart;
    }
}