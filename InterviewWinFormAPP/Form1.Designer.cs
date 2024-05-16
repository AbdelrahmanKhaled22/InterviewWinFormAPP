namespace InterviewWinFormAPP
{
    partial class Form1
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
            dataGridView1 = new DataGridView();
            namebox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button1 = new Button();
            idbox = new NumericUpDown();
            agebox = new NumericUpDown();
            nationalityidbox = new NumericUpDown();
            datepicker = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)idbox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)agebox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nationalityidbox).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 227);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(800, 223);
            dataGridView1.TabIndex = 0;
            // 
            // namebox
            // 
            namebox.Location = new Point(487, 37);
            namebox.Name = "namebox";
            namebox.Size = new Size(125, 27);
            namebox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 34);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 2;
            label1.Text = "personID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(374, 99);
            label2.Name = "label2";
            label2.Size = new Size(94, 20);
            label2.TabIndex = 2;
            label2.Text = "nationalityID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(400, 40);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 2;
            label3.Text = "name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 92);
            label4.Name = "label4";
            label4.Size = new Size(34, 20);
            label4.TabIndex = 2;
            label4.Text = "age";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(116, 154);
            label5.Name = "label5";
            label5.Size = new Size(70, 20);
            label5.TabIndex = 2;
            label5.Text = "birthdate";
            // 
            // button1
            // 
            button1.Location = new Point(611, 153);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 3;
            button1.Text = "Insert";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // idbox
            // 
            idbox.Location = new Point(110, 37);
            idbox.Name = "idbox";
            idbox.Size = new Size(150, 27);
            idbox.TabIndex = 4;
            // 
            // agebox
            // 
            agebox.Location = new Point(110, 92);
            agebox.Name = "agebox";
            agebox.Size = new Size(150, 27);
            agebox.TabIndex = 4;
            // 
            // nationalityidbox
            // 
            nationalityidbox.Location = new Point(487, 90);
            nationalityidbox.Name = "nationalityidbox";
            nationalityidbox.Size = new Size(150, 27);
            nationalityidbox.TabIndex = 4;
            // 
            // datepicker
            // 
            datepicker.Location = new Point(196, 152);
            datepicker.Name = "datepicker";
            datepicker.Size = new Size(250, 27);
            datepicker.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(datepicker);
            Controls.Add(nationalityidbox);
            Controls.Add(agebox);
            Controls.Add(idbox);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(namebox);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)idbox).EndInit();
            ((System.ComponentModel.ISupportInitialize)agebox).EndInit();
            ((System.ComponentModel.ISupportInitialize)nationalityidbox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox namebox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button1;
        private NumericUpDown idbox;
        private NumericUpDown agebox;
        private NumericUpDown nationalityidbox;
        private DateTimePicker datepicker;
    }
}
