namespace PresentationLayer
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
            this.SourceFilePathTextBox = new System.Windows.Forms.TextBox();
            this.SourceFileLabel = new System.Windows.Forms.Label();
            this.SourceFileBrowseButton = new System.Windows.Forms.Button();
            this.StartButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DestinationFileLabel = new System.Windows.Forms.Label();
            this.DestinationFilePathTextBox = new System.Windows.Forms.TextBox();
            this.DestinationFileBrowseButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SourceFilePathTextBox
            // 
            this.SourceFilePathTextBox.Location = new System.Drawing.Point(171, 42);
            this.SourceFilePathTextBox.Name = "SourceFilePathTextBox";
            this.SourceFilePathTextBox.Size = new System.Drawing.Size(362, 20);
            this.SourceFilePathTextBox.TabIndex = 0;
            // 
            // SourceFileLabel
            // 
            this.SourceFileLabel.AutoSize = true;
            this.SourceFileLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SourceFileLabel.Location = new System.Drawing.Point(6, 43);
            this.SourceFileLabel.Name = "SourceFileLabel";
            this.SourceFileLabel.Size = new System.Drawing.Size(112, 17);
            this.SourceFileLabel.TabIndex = 1;
            this.SourceFileLabel.Text = "Исходный файл";
            // 
            // SourceFileBrowseButton
            // 
            this.SourceFileBrowseButton.Location = new System.Drawing.Point(557, 42);
            this.SourceFileBrowseButton.Name = "SourceFileBrowseButton";
            this.SourceFileBrowseButton.Size = new System.Drawing.Size(75, 23);
            this.SourceFileBrowseButton.TabIndex = 2;
            this.SourceFileBrowseButton.Text = "Выбрать";
            this.SourceFileBrowseButton.UseVisualStyleBackColor = true;
            this.SourceFileBrowseButton.Click += new System.EventHandler(this.Browse_Click);
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(335, 252);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(146, 65);
            this.StartButton.TabIndex = 3;
            this.StartButton.Text = "Пуск";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DestinationFileBrowseButton);
            this.groupBox1.Controls.Add(this.DestinationFilePathTextBox);
            this.groupBox1.Controls.Add(this.DestinationFileLabel);
            this.groupBox1.Controls.Add(this.SourceFileLabel);
            this.groupBox1.Controls.Add(this.SourceFilePathTextBox);
            this.groupBox1.Controls.Add(this.SourceFileBrowseButton);
            this.groupBox1.Location = new System.Drawing.Point(80, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(638, 176);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // DestinationFileLabel
            // 
            this.DestinationFileLabel.AutoSize = true;
            this.DestinationFileLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DestinationFileLabel.Location = new System.Drawing.Point(6, 97);
            this.DestinationFileLabel.Name = "DestinationFileLabel";
            this.DestinationFileLabel.Size = new System.Drawing.Size(145, 17);
            this.DestinationFileLabel.TabIndex = 3;
            this.DestinationFileLabel.Text = "Полученные данные";
            // 
            // DestinationFilePathTextBox
            // 
            this.DestinationFilePathTextBox.Location = new System.Drawing.Point(171, 97);
            this.DestinationFilePathTextBox.Name = "DestinationFilePathTextBox";
            this.DestinationFilePathTextBox.Size = new System.Drawing.Size(362, 20);
            this.DestinationFilePathTextBox.TabIndex = 4;
            // 
            // DestinationFileBrowseButton
            // 
            this.DestinationFileBrowseButton.Location = new System.Drawing.Point(557, 93);
            this.DestinationFileBrowseButton.Name = "DestinationFileBrowseButton";
            this.DestinationFileBrowseButton.Size = new System.Drawing.Size(75, 23);
            this.DestinationFileBrowseButton.TabIndex = 5;
            this.DestinationFileBrowseButton.Text = "Выбрать";
            this.DestinationFileBrowseButton.UseVisualStyleBackColor = true;
            this.DestinationFileBrowseButton.Click += new System.EventHandler(this.DestinationFileBrowseButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.StartButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox SourceFilePathTextBox;
        private System.Windows.Forms.Label SourceFileLabel;
        private System.Windows.Forms.Button SourceFileBrowseButton;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button DestinationFileBrowseButton;
        private System.Windows.Forms.TextBox DestinationFilePathTextBox;
        private System.Windows.Forms.Label DestinationFileLabel;
    }
}

