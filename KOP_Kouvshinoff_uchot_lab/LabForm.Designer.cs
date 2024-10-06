namespace KOP_Kouvshinoff_uchot_lab
{
    partial class LabForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBoxTheme = new TextBox();
            textBoxTask = new TextBox();
            customComboBoxDifficulty = new Visual_components_Kouvshinoff.CustomComboBox();
            controlInputNullableDoubleAverageScore = new ControlsLibraryNet60.Input.ControlInputNullableDouble();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel4 = new Panel();
            panel3 = new Panel();
            panel2 = new Panel();
            panel1 = new Panel();
            panel5 = new Panel();
            buttonSave = new Button();
            buttonCancel = new Button();
            tableLayoutPanel1.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 6);
            label1.Name = "label1";
            label1.Size = new Size(123, 15);
            label1.TabIndex = 0;
            label1.Text = "Тема лабораторной: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 6);
            label2.Name = "label2";
            label2.Size = new Size(188, 15);
            label2.TabIndex = 1;
            label2.Text = "Задание в лабораторной работе:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Location = new Point(3, 5);
            label3.Name = "label3";
            label3.Size = new Size(116, 15);
            label3.TabIndex = 2;
            label3.Text = "Сложность работы:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Location = new Point(3, 3);
            label4.Name = "label4";
            label4.Size = new Size(129, 15);
            label4.TabIndex = 3;
            label4.Text = "Средний бал сдавших";
            // 
            // textBoxTheme
            // 
            textBoxTheme.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxTheme.Location = new Point(132, 3);
            textBoxTheme.Multiline = true;
            textBoxTheme.Name = "textBoxTheme";
            textBoxTheme.Size = new Size(456, 29);
            textBoxTheme.TabIndex = 4;
            // 
            // textBoxTask
            // 
            textBoxTask.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxTask.Location = new Point(197, 3);
            textBoxTask.Multiline = true;
            textBoxTask.Name = "textBoxTask";
            textBoxTask.Size = new Size(391, 29);
            textBoxTask.TabIndex = 5;
            // 
            // customComboBoxDifficulty
            // 
            customComboBoxDifficulty.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            customComboBoxDifficulty.Location = new Point(125, 5);
            customComboBoxDifficulty.Name = "customComboBoxDifficulty";
            customComboBoxDifficulty.selectedString = "";
            customComboBoxDifficulty.Size = new Size(463, 28);
            customComboBoxDifficulty.TabIndex = 6;
            // 
            // controlInputNullableDoubleAverageScore
            // 
            controlInputNullableDoubleAverageScore.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            controlInputNullableDoubleAverageScore.Location = new Point(140, 3);
            controlInputNullableDoubleAverageScore.Margin = new Padding(5, 3, 5, 3);
            controlInputNullableDoubleAverageScore.Name = "controlInputNullableDoubleAverageScore";
            controlInputNullableDoubleAverageScore.Size = new Size(448, 28);
            controlInputNullableDoubleAverageScore.TabIndex = 7;
            controlInputNullableDoubleAverageScore.Value = null;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(panel4, 0, 3);
            tableLayoutPanel1.Controls.Add(panel3, 0, 2);
            tableLayoutPanel1.Controls.Add(panel2, 0, 1);
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(panel5, 0, 4);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.MinimumSize = new Size(400, 200);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Size = new Size(597, 205);
            tableLayoutPanel1.TabIndex = 8;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel4.Controls.Add(label4);
            panel4.Controls.Add(controlInputNullableDoubleAverageScore);
            panel4.Location = new Point(3, 126);
            panel4.Name = "panel4";
            panel4.Size = new Size(591, 35);
            panel4.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.Controls.Add(label3);
            panel3.Controls.Add(customComboBoxDifficulty);
            panel3.Location = new Point(3, 85);
            panel3.Name = "panel3";
            panel3.Size = new Size(591, 35);
            panel3.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(textBoxTask);
            panel2.Location = new Point(3, 44);
            panel2.Name = "panel2";
            panel2.Size = new Size(591, 35);
            panel2.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBoxTheme);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(591, 35);
            panel1.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel5.Controls.Add(buttonSave);
            panel5.Controls.Add(buttonCancel);
            panel5.Location = new Point(3, 167);
            panel5.Name = "panel5";
            panel5.Size = new Size(591, 35);
            panel5.TabIndex = 4;
            // 
            // buttonSave
            // 
            buttonSave.Anchor = AnchorStyles.Right;
            buttonSave.Location = new Point(400, 3);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(188, 29);
            buttonSave.TabIndex = 1;
            buttonSave.Text = "закрыть с сохранением";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Anchor = AnchorStyles.Left;
            buttonCancel.Location = new Point(3, 3);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(188, 29);
            buttonCancel.TabIndex = 0;
            buttonCancel.Text = "закрыть без сохранения";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // LabForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoScrollMinSize = new Size(400, 200);
            ClientSize = new Size(597, 205);
            Controls.Add(tableLayoutPanel1);
            Name = "LabForm";
            Text = "Lab";
            FormClosing += LabForm_FormClosing;
            tableLayoutPanel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBoxTheme;
        private TextBox textBoxTask;
        private Visual_components_Kouvshinoff.CustomComboBox customComboBoxDifficulty;
        private ControlsLibraryNet60.Input.ControlInputNullableDouble controlInputNullableDoubleAverageScore;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Panel panel4;
        private Panel panel3;
        private Panel panel2;
        private Panel panel5;
        private Button buttonSave;
        private Button buttonCancel;
    }
}