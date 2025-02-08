namespace Opdracht8
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbxOverzicht = new System.Windows.Forms.ListBox();
            this.btnVerwijder = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbxOverzicht);
            this.groupBox1.Location = new System.Drawing.Point(29, 42);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(469, 228);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Overzicht Recepten";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lbxOverzicht
            // 
            this.lbxOverzicht.FormattingEnabled = true;
            this.lbxOverzicht.ItemHeight = 16;
            this.lbxOverzicht.Location = new System.Drawing.Point(21, 32);
            this.lbxOverzicht.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbxOverzicht.Name = "lbxOverzicht";
            this.lbxOverzicht.Size = new System.Drawing.Size(420, 180);
            this.lbxOverzicht.TabIndex = 0;
            this.lbxOverzicht.SelectedIndexChanged += new System.EventHandler(this.lbxOverzicht_SelectedIndexChanged);
            // 
            // btnVerwijder
            // 
            this.btnVerwijder.Location = new System.Drawing.Point(389, 309);
            this.btnVerwijder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVerwijder.Name = "btnVerwijder";
            this.btnVerwijder.Size = new System.Drawing.Size(109, 31);
            this.btnVerwijder.TabIndex = 5;
            this.btnVerwijder.Text = "Verwijderen";
            this.btnVerwijder.UseVisualStyleBackColor = true;
            this.btnVerwijder.Click += new System.EventHandler(this.btnVerwijder_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 416);
            this.Controls.Add(this.btnVerwijder);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Firma Bruinsma";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lbxOverzicht;
        private System.Windows.Forms.Button btnVerwijder;
    }
}

