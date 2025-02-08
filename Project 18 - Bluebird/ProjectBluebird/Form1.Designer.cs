
namespace ProjectBluebird
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.naamInput = new System.Windows.Forms.TextBox();
            this.naamLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ecoButton = new System.Windows.Forms.RadioButton();
            this.firstButton = new System.Windows.Forms.RadioButton();
            this.busButton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.stoelSelected = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(33, 11);
            this.listBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(211, 356);
            this.listBox1.TabIndex = 4;
            // 
            // naamInput
            // 
            this.naamInput.Location = new System.Drawing.Point(151, 430);
            this.naamInput.Margin = new System.Windows.Forms.Padding(4);
            this.naamInput.Name = "naamInput";
            this.naamInput.Size = new System.Drawing.Size(132, 22);
            this.naamInput.TabIndex = 12;
            // 
            // naamLabel
            // 
            this.naamLabel.AutoSize = true;
            this.naamLabel.Location = new System.Drawing.Point(9, 430);
            this.naamLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.naamLabel.Name = "naamLabel";
            this.naamLabel.Size = new System.Drawing.Size(53, 17);
            this.naamLabel.TabIndex = 13;
            this.naamLabel.Text = "Naam: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ecoButton);
            this.groupBox1.Controls.Add(this.firstButton);
            this.groupBox1.Controls.Add(this.busButton);
            this.groupBox1.Location = new System.Drawing.Point(302, 408);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(180, 101);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Class";
            // 
            // ecoButton
            // 
            this.ecoButton.AutoSize = true;
            this.ecoButton.Location = new System.Drawing.Point(8, 72);
            this.ecoButton.Margin = new System.Windows.Forms.Padding(4);
            this.ecoButton.Name = "ecoButton";
            this.ecoButton.Size = new System.Drawing.Size(125, 21);
            this.ecoButton.TabIndex = 17;
            this.ecoButton.TabStop = true;
            this.ecoButton.Text = "Economy Class";
            this.ecoButton.UseVisualStyleBackColor = true;
            this.ecoButton.CheckedChanged += new System.EventHandler(this.ecoButton_CheckedChanged);
            // 
            // firstButton
            // 
            this.firstButton.AutoSize = true;
            this.firstButton.Location = new System.Drawing.Point(8, 33);
            this.firstButton.Margin = new System.Windows.Forms.Padding(4);
            this.firstButton.Name = "firstButton";
            this.firstButton.Size = new System.Drawing.Size(94, 21);
            this.firstButton.TabIndex = 15;
            this.firstButton.TabStop = true;
            this.firstButton.Text = "First Class";
            this.firstButton.UseVisualStyleBackColor = true;
            this.firstButton.CheckedChanged += new System.EventHandler(this.firstButton_CheckedChanged);
            // 
            // busButton
            // 
            this.busButton.AutoSize = true;
            this.busButton.Location = new System.Drawing.Point(8, 52);
            this.busButton.Margin = new System.Windows.Forms.Padding(4);
            this.busButton.Name = "busButton";
            this.busButton.Size = new System.Drawing.Size(124, 21);
            this.busButton.TabIndex = 16;
            this.busButton.TabStop = true;
            this.busButton.Text = "Business Class";
            this.busButton.UseVisualStyleBackColor = true;
            this.busButton.CheckedChanged += new System.EventHandler(this.busButton_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 477);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "StoelNummer";
            // 
            // stoelSelected
            // 
            this.stoelSelected.FormattingEnabled = true;
            this.stoelSelected.Items.AddRange(new object[] {
            "1A",
            "1B",
            "1C",
            "1D",
            "2A",
            "2B",
            "2C",
            "2D",
            "3A",
            "3B",
            "3C",
            "3D",
            "4A",
            "4B",
            "4C",
            "4D",
            "5A",
            "5B",
            "5C",
            "5D"});
            this.stoelSelected.Location = new System.Drawing.Point(123, 477);
            this.stoelSelected.Margin = new System.Windows.Forms.Padding(4);
            this.stoelSelected.Name = "stoelSelected";
            this.stoelSelected.Size = new System.Drawing.Size(160, 24);
            this.stoelSelected.TabIndex = 16;
            this.stoelSelected.SelectedIndexChanged += new System.EventHandler(this.stoelSelected_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(310, 174);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 47);
            this.button1.TabIndex = 17;
            this.button1.Text = "Plaats Reseveren";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(310, 96);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 47);
            this.button2.TabIndex = 18;
            this.button2.Text = "Plaats Vrijgeven";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(310, 24);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(108, 47);
            this.button3.TabIndex = 19;
            this.button3.Text = "Programma afsluiten";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(506, 565);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.stoelSelected);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.naamLabel);
            this.Controls.Add(this.naamInput);
            this.Controls.Add(this.listBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Bluebird Airlines";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox naamInput;
        private System.Windows.Forms.Label naamLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton ecoButton;
        private System.Windows.Forms.RadioButton busButton;
        private System.Windows.Forms.RadioButton firstButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox stoelSelected;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

