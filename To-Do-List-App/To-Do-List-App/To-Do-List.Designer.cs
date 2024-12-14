namespace To_Do_List_App
{
    partial class ToDoList
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            TitleTextBox = new TextBox();
            DescTextBox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            NewBtn = new Button();
            EdtBtn = new Button();
            SaveBtn = new Button();
            Dltbtn = new Button();
            ToDoListView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)ToDoListView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Solid Edge Stencil", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 1);
            label1.Name = "label1";
            label1.Size = new Size(1319, 110);
            label1.TabIndex = 0;
            label1.Text = "To Do List";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // TitleTextBox
            // 
            TitleTextBox.Location = new Point(12, 103);
            TitleTextBox.Name = "TitleTextBox";
            TitleTextBox.Size = new Size(1319, 27);
            TitleTextBox.TabIndex = 1;
            // 
            // DescTextBox
            // 
            DescTextBox.Location = new Point(12, 156);
            DescTextBox.Name = "DescTextBox";
            DescTextBox.Size = new Size(1319, 27);
            DescTextBox.TabIndex = 2;
            DescTextBox.TextChanged += textBox2_TextChanged;
            // 
            // label2
            // 
            label2.Location = new Point(12, 80);
            label2.Name = "label2";
            label2.Size = new Size(1319, 20);
            label2.TabIndex = 3;
            label2.Text = "Title:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.Location = new Point(12, 128);
            label3.Name = "label3";
            label3.Size = new Size(1319, 25);
            label3.TabIndex = 4;
            label3.Text = "Description:";
            // 
            // NewBtn
            // 
            NewBtn.Location = new Point(12, 189);
            NewBtn.Name = "NewBtn";
            NewBtn.Size = new Size(313, 41);
            NewBtn.TabIndex = 5;
            NewBtn.Text = "New";
            NewBtn.UseVisualStyleBackColor = true;
            NewBtn.Click += NewBtn_Click;
            // 
            // EdtBtn
            // 
            EdtBtn.Location = new Point(351, 189);
            EdtBtn.Name = "EdtBtn";
            EdtBtn.Size = new Size(313, 41);
            EdtBtn.TabIndex = 6;
            EdtBtn.Text = "Edit";
            EdtBtn.UseVisualStyleBackColor = true;
            EdtBtn.Click += EdtBtn_Click;
            // 
            // SaveBtn
            // 
            SaveBtn.Location = new Point(1018, 189);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(313, 41);
            SaveBtn.TabIndex = 7;
            SaveBtn.Text = "Save";
            SaveBtn.UseVisualStyleBackColor = true;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // Dltbtn
            // 
            Dltbtn.Location = new Point(685, 189);
            Dltbtn.Name = "Dltbtn";
            Dltbtn.Size = new Size(313, 41);
            Dltbtn.TabIndex = 8;
            Dltbtn.Text = "Delete";
            Dltbtn.UseVisualStyleBackColor = true;
            Dltbtn.Click += Dltbtn_Click;
            // 
            // ToDoListView
            // 
            ToDoListView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ToDoListView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ToDoListView.Location = new Point(12, 236);
            ToDoListView.Name = "ToDoListView";
            ToDoListView.RowHeadersWidth = 51;
            ToDoListView.Size = new Size(1319, 226);
            ToDoListView.TabIndex = 9;
            // 
            // ToDoList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(1343, 464);
            Controls.Add(ToDoListView);
            Controls.Add(Dltbtn);
            Controls.Add(SaveBtn);
            Controls.Add(EdtBtn);
            Controls.Add(NewBtn);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(DescTextBox);
            Controls.Add(TitleTextBox);
            Controls.Add(label1);
            Name = "ToDoList";
            Text = "To-Do-List";
            Load += ToDoList_Load;
            ((System.ComponentModel.ISupportInitialize)ToDoListView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox TitleTextBox;
        private TextBox DescTextBox;
        private Label label2;
        private Label label3;
        private Button NewBtn;
        private Button EdtBtn;
        private Button SaveBtn;
        private Button Dltbtn;
        private DataGridView ToDoListView;
    }
}
