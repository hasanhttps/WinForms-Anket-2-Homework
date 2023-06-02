namespace WinForms_Anket_2_Homework
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            groupBox1 = new GroupBox();
            GenderRadioButton = new Label();
            MaleRadioButton = new RadioButton();
            FemaleRadioButton = new RadioButton();
            addButton = new Button();
            changeButton = new Button();
            Birthday = new DateTimePicker();
            label5 = new Label();
            phoneBox = new TextBox();
            label4 = new Label();
            emailBox = new TextBox();
            label3 = new Label();
            surnameBox = new TextBox();
            label2 = new Label();
            nameBox = new TextBox();
            label1 = new Label();
            Ankets = new ListBox();
            fileNameBox = new TextBox();
            loadButton = new Button();
            saveButton = new Button();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            folderBrowserDialog1 = new FolderBrowserDialog();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(GenderRadioButton);
            groupBox1.Controls.Add(MaleRadioButton);
            groupBox1.Controls.Add(FemaleRadioButton);
            groupBox1.Controls.Add(addButton);
            groupBox1.Controls.Add(changeButton);
            groupBox1.Controls.Add(Birthday);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(phoneBox);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(emailBox);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(surnameBox);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(nameBox);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(437, 400);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Anket";
            // 
            // GenderRadioButton
            // 
            GenderRadioButton.AutoSize = true;
            GenderRadioButton.Location = new Point(41, 218);
            GenderRadioButton.Name = "GenderRadioButton";
            GenderRadioButton.Size = new Size(45, 15);
            GenderRadioButton.TabIndex = 14;
            GenderRadioButton.Text = "Gender";
            // 
            // MaleRadioButton
            // 
            MaleRadioButton.AutoSize = true;
            MaleRadioButton.Location = new Point(123, 216);
            MaleRadioButton.Name = "MaleRadioButton";
            MaleRadioButton.Size = new Size(51, 19);
            MaleRadioButton.TabIndex = 13;
            MaleRadioButton.TabStop = true;
            MaleRadioButton.Text = "Male";
            MaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // FemaleRadioButton
            // 
            FemaleRadioButton.AutoSize = true;
            FemaleRadioButton.Location = new Point(199, 216);
            FemaleRadioButton.Name = "FemaleRadioButton";
            FemaleRadioButton.Size = new Size(63, 19);
            FemaleRadioButton.TabIndex = 12;
            FemaleRadioButton.TabStop = true;
            FemaleRadioButton.Text = "Female";
            FemaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // addButton
            // 
            addButton.Location = new Point(295, 355);
            addButton.Name = "addButton";
            addButton.Size = new Size(92, 23);
            addButton.TabIndex = 11;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // changeButton
            // 
            changeButton.Location = new Point(295, 326);
            changeButton.Name = "changeButton";
            changeButton.Size = new Size(92, 23);
            changeButton.TabIndex = 10;
            changeButton.Text = "Change";
            changeButton.UseVisualStyleBackColor = true;
            changeButton.Click += changeButton_Click;
            // 
            // Birthday
            // 
            Birthday.Location = new Point(123, 177);
            Birthday.Name = "Birthday";
            Birthday.Size = new Size(205, 23);
            Birthday.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(41, 183);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 8;
            label5.Text = "Birthday";
            // 
            // phoneBox
            // 
            phoneBox.Location = new Point(123, 148);
            phoneBox.Name = "phoneBox";
            phoneBox.Size = new Size(205, 23);
            phoneBox.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(40, 151);
            label4.Name = "label4";
            label4.Size = new Size(41, 15);
            label4.TabIndex = 6;
            label4.Text = "Phone";
            // 
            // emailBox
            // 
            emailBox.Location = new Point(123, 119);
            emailBox.Name = "emailBox";
            emailBox.Size = new Size(205, 23);
            emailBox.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 122);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 4;
            label3.Text = "Email";
            // 
            // surnameBox
            // 
            surnameBox.Location = new Point(123, 90);
            surnameBox.Name = "surnameBox";
            surnameBox.Size = new Size(205, 23);
            surnameBox.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 93);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 2;
            label2.Text = "Surname";
            // 
            // nameBox
            // 
            nameBox.Location = new Point(123, 61);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(205, 23);
            nameBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 64);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 0;
            label1.Text = "Name ";
            // 
            // Ankets
            // 
            Ankets.FormattingEnabled = true;
            Ankets.ItemHeight = 15;
            Ankets.Location = new Point(544, 21);
            Ankets.Name = "Ankets";
            Ankets.Size = new Size(244, 364);
            Ankets.TabIndex = 1;
            // 
            // fileNameBox
            // 
            fileNameBox.Location = new Point(544, 389);
            fileNameBox.Name = "fileNameBox";
            fileNameBox.PlaceholderText = "File name";
            fileNameBox.Size = new Size(244, 23);
            fileNameBox.TabIndex = 2;
            // 
            // loadButton
            // 
            loadButton.Location = new Point(544, 415);
            loadButton.Name = "loadButton";
            loadButton.Size = new Size(126, 23);
            loadButton.TabIndex = 3;
            loadButton.Text = "Load";
            loadButton.UseVisualStyleBackColor = true;
            loadButton.Click += loadButton_Click;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(676, 415);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(112, 23);
            saveButton.TabIndex = 4;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(saveButton);
            Controls.Add(loadButton);
            Controls.Add(fileNameBox);
            Controls.Add(Ankets);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Anket";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private ListBox Ankets;
        private TextBox fileNameBox;
        private Button loadButton;
        private Button saveButton;
        private DateTimePicker Birthday;
        private Label label5;
        private TextBox phoneBox;
        private Label label4;
        private TextBox emailBox;
        private Label label3;
        private TextBox surnameBox;
        private Label label2;
        private TextBox nameBox;
        private Label label1;
        private Button addButton;
        private Button changeButton;
        private RadioButton FemaleRadioButton;
        private Label GenderRadioButton;
        private RadioButton MaleRadioButton;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private FolderBrowserDialog folderBrowserDialog1;
    }
}