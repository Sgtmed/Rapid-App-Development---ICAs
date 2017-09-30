namespace Lesson02_MessageFormatter
{
    partial class MessageForm
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
            this.ExitButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.DisplayButton = new System.Windows.Forms.Button();
            this.MessageLabel = new System.Windows.Forms.Label();
            this.ClickLabel = new System.Windows.Forms.Label();
            this.BigPictureBox = new System.Windows.Forms.PictureBox();
            this.SmallPictureBox = new System.Windows.Forms.PictureBox();
            this.MessageVisibleCheckBox = new System.Windows.Forms.CheckBox();
            this.ColorGroupBox = new System.Windows.Forms.GroupBox();
            this.BlackRadioButton = new System.Windows.Forms.RadioButton();
            this.BlueRadioButton = new System.Windows.Forms.RadioButton();
            this.GreenRadioButton = new System.Windows.Forms.RadioButton();
            this.RedRadioButton = new System.Windows.Forms.RadioButton();
            this.InputGroupBox = new System.Windows.Forms.GroupBox();
            this.MessageTextBox = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BigPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SmallPictureBox)).BeginInit();
            this.ColorGroupBox.SuspendLayout();
            this.InputGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(307, 367);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(73, 29);
            this.ExitButton.TabIndex = 6;
            this.ExitButton.Text = "E&xit";
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ClearButton.Location = new System.Drawing.Point(307, 332);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(73, 29);
            this.ClearButton.TabIndex = 5;
            this.ClearButton.Text = "&Clear";
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // DisplayButton
            // 
            this.DisplayButton.Location = new System.Drawing.Point(307, 296);
            this.DisplayButton.Name = "DisplayButton";
            this.DisplayButton.Size = new System.Drawing.Size(73, 29);
            this.DisplayButton.TabIndex = 4;
            this.DisplayButton.Text = "&Display";
            this.DisplayButton.Click += new System.EventHandler(this.DisplayButton_Click);
            // 
            // MessageLabel
            // 
            this.MessageLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MessageLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.MessageLabel.Location = new System.Drawing.Point(193, 202);
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.Size = new System.Drawing.Size(188, 70);
            this.MessageLabel.TabIndex = 9;
            this.MessageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ClickLabel
            // 
            this.ClickLabel.AutoSize = true;
            this.ClickLabel.Location = new System.Drawing.Point(61, 401);
            this.ClickLabel.Name = "ClickLabel";
            this.ClickLabel.Size = new System.Drawing.Size(66, 13);
            this.ClickLabel.TabIndex = 3;
            this.ClickLabel.Text = "Click Picture";
            this.ClickLabel.Click += new System.EventHandler(this.ClickLabel_Click);
            // 
            // BigPictureBox
            // 
            this.BigPictureBox.Image = global::Lesson02_MessageFormatter.Properties.Resources.music;
            this.BigPictureBox.ImageLocation = "";
            this.BigPictureBox.Location = new System.Drawing.Point(40, 296);
            this.BigPictureBox.Name = "BigPictureBox";
            this.BigPictureBox.Padding = new System.Windows.Forms.Padding(3);
            this.BigPictureBox.Size = new System.Drawing.Size(104, 91);
            this.BigPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BigPictureBox.TabIndex = 26;
            this.BigPictureBox.TabStop = false;
            this.BigPictureBox.Click += new System.EventHandler(this.BigPictureBox_Click);
            // 
            // SmallPictureBox
            // 
            this.SmallPictureBox.Image = global::Lesson02_MessageFormatter.Properties.Resources.music;
            this.SmallPictureBox.Location = new System.Drawing.Point(63, 314);
            this.SmallPictureBox.Name = "SmallPictureBox";
            this.SmallPictureBox.Size = new System.Drawing.Size(65, 55);
            this.SmallPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SmallPictureBox.TabIndex = 25;
            this.SmallPictureBox.TabStop = false;
            this.SmallPictureBox.Click += new System.EventHandler(this.SmallPictureBox_Click);
            // 
            // MessageVisibleCheckBox
            // 
            this.MessageVisibleCheckBox.AutoSize = true;
            this.MessageVisibleCheckBox.Location = new System.Drawing.Point(193, 164);
            this.MessageVisibleCheckBox.Name = "MessageVisibleCheckBox";
            this.MessageVisibleCheckBox.Size = new System.Drawing.Size(102, 17);
            this.MessageVisibleCheckBox.TabIndex = 2;
            this.MessageVisibleCheckBox.Text = "Message &Visible";
            this.MessageVisibleCheckBox.CheckedChanged += new System.EventHandler(this.MessageVisibleCheckBox_CheckedChanged);
            // 
            // ColorGroupBox
            // 
            this.ColorGroupBox.Controls.Add(this.BlackRadioButton);
            this.ColorGroupBox.Controls.Add(this.BlueRadioButton);
            this.ColorGroupBox.Controls.Add(this.GreenRadioButton);
            this.ColorGroupBox.Controls.Add(this.RedRadioButton);
            this.ColorGroupBox.Location = new System.Drawing.Point(27, 146);
            this.ColorGroupBox.Name = "ColorGroupBox";
            this.ColorGroupBox.Size = new System.Drawing.Size(141, 125);
            this.ColorGroupBox.TabIndex = 1;
            this.ColorGroupBox.TabStop = false;
            this.ColorGroupBox.Text = "Color";
            // 
            // BlackRadioButton
            // 
            this.BlackRadioButton.AutoSize = true;
            this.BlackRadioButton.Location = new System.Drawing.Point(19, 94);
            this.BlackRadioButton.Name = "BlackRadioButton";
            this.BlackRadioButton.Size = new System.Drawing.Size(52, 17);
            this.BlackRadioButton.TabIndex = 3;
            this.BlackRadioButton.Text = "B&lack";
            this.BlackRadioButton.CheckedChanged += new System.EventHandler(this.BlackRadioButton_CheckedChanged);
            // 
            // BlueRadioButton
            // 
            this.BlueRadioButton.AutoSize = true;
            this.BlueRadioButton.ForeColor = System.Drawing.Color.Black;
            this.BlueRadioButton.Location = new System.Drawing.Point(19, 69);
            this.BlueRadioButton.Name = "BlueRadioButton";
            this.BlueRadioButton.Size = new System.Drawing.Size(46, 17);
            this.BlueRadioButton.TabIndex = 2;
            this.BlueRadioButton.Text = "&Blue";
            this.BlueRadioButton.CheckedChanged += new System.EventHandler(this.BlueRadioButton_CheckedChanged);
            // 
            // GreenRadioButton
            // 
            this.GreenRadioButton.AutoSize = true;
            this.GreenRadioButton.Location = new System.Drawing.Point(19, 44);
            this.GreenRadioButton.Name = "GreenRadioButton";
            this.GreenRadioButton.Size = new System.Drawing.Size(54, 17);
            this.GreenRadioButton.TabIndex = 1;
            this.GreenRadioButton.Text = "&Green";
            this.GreenRadioButton.CheckedChanged += new System.EventHandler(this.GreenRadioButton_CheckedChanged);
            // 
            // RedRadioButton
            // 
            this.RedRadioButton.AutoSize = true;
            this.RedRadioButton.Location = new System.Drawing.Point(19, 19);
            this.RedRadioButton.Name = "RedRadioButton";
            this.RedRadioButton.Size = new System.Drawing.Size(45, 17);
            this.RedRadioButton.TabIndex = 0;
            this.RedRadioButton.Text = "&Red";
            this.RedRadioButton.CheckedChanged += new System.EventHandler(this.RedRadioButton_CheckedChanged);
            // 
            // InputGroupBox
            // 
            this.InputGroupBox.Controls.Add(this.MessageTextBox);
            this.InputGroupBox.Controls.Add(this.Label2);
            this.InputGroupBox.Controls.Add(this.NameTextBox);
            this.InputGroupBox.Controls.Add(this.Label1);
            this.InputGroupBox.Location = new System.Drawing.Point(27, 46);
            this.InputGroupBox.Name = "InputGroupBox";
            this.InputGroupBox.Size = new System.Drawing.Size(353, 87);
            this.InputGroupBox.TabIndex = 0;
            this.InputGroupBox.TabStop = false;
            // 
            // MessageTextBox
            // 
            this.MessageTextBox.Location = new System.Drawing.Point(83, 52);
            this.MessageTextBox.Name = "MessageTextBox";
            this.MessageTextBox.Size = new System.Drawing.Size(209, 20);
            this.MessageTextBox.TabIndex = 3;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(11, 55);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(50, 13);
            this.Label2.TabIndex = 2;
            this.Label2.Text = "&Message";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(83, 19);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(209, 20);
            this.NameTextBox.TabIndex = 1;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(26, 19);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(35, 13);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "&Name";
            this.Label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(154, 20);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Message Formatter";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(333, 417);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Dan Brost";
            // 
            // MessageForm
            // 
            this.AcceptButton = this.DisplayButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ClearButton;
            this.ClientSize = new System.Drawing.Size(406, 438);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.DisplayButton);
            this.Controls.Add(this.MessageLabel);
            this.Controls.Add(this.ClickLabel);
            this.Controls.Add(this.BigPictureBox);
            this.Controls.Add(this.SmallPictureBox);
            this.Controls.Add(this.MessageVisibleCheckBox);
            this.Controls.Add(this.ColorGroupBox);
            this.Controls.Add(this.InputGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MessageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MessageForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BigPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SmallPictureBox)).EndInit();
            this.ColorGroupBox.ResumeLayout(false);
            this.ColorGroupBox.PerformLayout();
            this.InputGroupBox.ResumeLayout(false);
            this.InputGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button ExitButton;
        internal System.Windows.Forms.Button ClearButton;
        internal System.Windows.Forms.Button DisplayButton;
        internal System.Windows.Forms.Label MessageLabel;
        internal System.Windows.Forms.Label ClickLabel;
        internal System.Windows.Forms.PictureBox BigPictureBox;
        internal System.Windows.Forms.PictureBox SmallPictureBox;
        internal System.Windows.Forms.CheckBox MessageVisibleCheckBox;
        internal System.Windows.Forms.GroupBox ColorGroupBox;
        internal System.Windows.Forms.RadioButton BlackRadioButton;
        internal System.Windows.Forms.RadioButton BlueRadioButton;
        internal System.Windows.Forms.RadioButton GreenRadioButton;
        internal System.Windows.Forms.RadioButton RedRadioButton;
        internal System.Windows.Forms.GroupBox InputGroupBox;
        internal System.Windows.Forms.TextBox MessageTextBox;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox NameTextBox;
        internal System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

