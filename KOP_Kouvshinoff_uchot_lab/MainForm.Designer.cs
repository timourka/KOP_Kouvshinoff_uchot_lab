namespace KOP_Kouvshinoff_uchot_lab
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
            customTree = new KOP_Labs.CustomTree();
            обновитьToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // contextMenuStrip
            // 
            contextMenuStrip.Items.AddRange(new ToolStripItem[] { добавлениеToolStripMenuItem, редактированиеToolStripMenuItem, удалениеToolStripMenuItem, обновитьToolStripMenuItem });
            contextMenuStrip.Name = "contextMenuStrip1";
            contextMenuStrip.ShowImageMargin = false;
            contextMenuStrip.Size = new Size(156, 114);
            // 
            // добавлениеToolStripMenuItem
            // 
            добавлениеToolStripMenuItem.Name = "добавлениеToolStripMenuItem";
            добавлениеToolStripMenuItem.Size = new Size(155, 22);
            добавлениеToolStripMenuItem.Text = "добавить";
            добавлениеToolStripMenuItem.Click += добавлениеToolStripMenuItem_Click;
            // 
            // редактированиеToolStripMenuItem
            // 
            редактированиеToolStripMenuItem.Name = "редактированиеToolStripMenuItem";
            редактированиеToolStripMenuItem.Size = new Size(155, 22);
            редактированиеToolStripMenuItem.Text = "редактировать";
            редактированиеToolStripMenuItem.Click += редактированиеToolStripMenuItem_Click;
            // 
            // удалениеToolStripMenuItem
            // 
            удалениеToolStripMenuItem.Name = "удалениеToolStripMenuItem";
            удалениеToolStripMenuItem.Size = new Size(155, 22);
            удалениеToolStripMenuItem.Text = "удалить";
            удалениеToolStripMenuItem.Click += удалениеToolStripMenuItem_Click;
            // 
            // customTree
            // 
            customTree.Dock = DockStyle.Fill;
            customTree.Hierarcy = null;
            customTree.Location = new Point(0, 0);
            customTree.Margin = new Padding(3, 2, 3, 2);
            customTree.Name = "customTree";
            customTree.Size = new Size(800, 450);
            customTree.TabIndex = 1;
            // 
            // обновитьToolStripMenuItem
            // 
            обновитьToolStripMenuItem.Name = "обновитьToolStripMenuItem";
            обновитьToolStripMenuItem.Size = new Size(155, 22);
            обновитьToolStripMenuItem.Text = "обновить";
            обновитьToolStripMenuItem.Click += обновитьToolStripMenuItem_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(customTree);
            Name = "MainForm";
            Text = "Main";
            contextMenuStrip.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ContextMenuStrip contextMenuStrip;
        private KOP_Labs.CustomTree customTree;
        private ToolStripMenuItem добавлениеToolStripMenuItem;
        private ToolStripMenuItem редактированиеToolStripMenuItem;
        private ToolStripMenuItem удалениеToolStripMenuItem;
        private ToolStripMenuItem обновитьToolStripMenuItem;
    }
}