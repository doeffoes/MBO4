
namespace Opdracht2
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
            this.artikelenText = new System.Windows.Forms.TextBox();
            this.artikelenL = new System.Windows.Forms.Label();
            this.klantenL = new System.Windows.Forms.Label();
            this.klantenText = new System.Windows.Forms.TextBox();
            this.bestellingenL = new System.Windows.Forms.Label();
            this.bestellingenText = new System.Windows.Forms.TextBox();
            this.bestellingenreken = new System.Windows.Forms.TextBox();
            this.bestellingenRekenL = new System.Windows.Forms.Label();
            this.upperRow = new System.Windows.Forms.TextBox();
            this.middleRow = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // artikelenText
            // 
            this.artikelenText.Location = new System.Drawing.Point(29, 45);
            this.artikelenText.Name = "artikelenText";
            this.artikelenText.Size = new System.Drawing.Size(52, 20);
            this.artikelenText.TabIndex = 0;
            // 
            // artikelenL
            // 
            this.artikelenL.AutoSize = true;
            this.artikelenL.Location = new System.Drawing.Point(26, 29);
            this.artikelenL.Name = "artikelenL";
            this.artikelenL.Size = new System.Drawing.Size(48, 13);
            this.artikelenL.TabIndex = 1;
            this.artikelenL.Text = "Artikelen";
            // 
            // klantenL
            // 
            this.klantenL.AutoSize = true;
            this.klantenL.Location = new System.Drawing.Point(147, 29);
            this.klantenL.Name = "klantenL";
            this.klantenL.Size = new System.Drawing.Size(43, 13);
            this.klantenL.TabIndex = 3;
            this.klantenL.Text = "Klanten";
            // 
            // klantenText
            // 
            this.klantenText.Location = new System.Drawing.Point(150, 45);
            this.klantenText.Name = "klantenText";
            this.klantenText.Size = new System.Drawing.Size(52, 20);
            this.klantenText.TabIndex = 2;
            // 
            // bestellingenL
            // 
            this.bestellingenL.AutoSize = true;
            this.bestellingenL.Location = new System.Drawing.Point(26, 118);
            this.bestellingenL.Name = "bestellingenL";
            this.bestellingenL.Size = new System.Drawing.Size(64, 13);
            this.bestellingenL.TabIndex = 5;
            this.bestellingenL.Text = "Bestellingen";
            // 
            // bestellingenText
            // 
            this.bestellingenText.Location = new System.Drawing.Point(29, 134);
            this.bestellingenText.Name = "bestellingenText";
            this.bestellingenText.Size = new System.Drawing.Size(52, 20);
            this.bestellingenText.TabIndex = 4;
            // 
            // bestellingenreken
            // 
            this.bestellingenreken.Location = new System.Drawing.Point(150, 134);
            this.bestellingenreken.Name = "bestellingenreken";
            this.bestellingenreken.Size = new System.Drawing.Size(52, 20);
            this.bestellingenreken.TabIndex = 6;
            // 
            // bestellingenRekenL
            // 
            this.bestellingenRekenL.AutoSize = true;
            this.bestellingenRekenL.Location = new System.Drawing.Point(147, 118);
            this.bestellingenRekenL.Name = "bestellingenRekenL";
            this.bestellingenRekenL.Size = new System.Drawing.Size(64, 13);
            this.bestellingenRekenL.TabIndex = 7;
            this.bestellingenRekenL.Text = "Bestellingen";
            // 
            // upperRow
            // 
            this.upperRow.Location = new System.Drawing.Point(234, 134);
            this.upperRow.Name = "upperRow";
            this.upperRow.Size = new System.Drawing.Size(52, 20);
            this.upperRow.TabIndex = 8;
            // 
            // middleRow
            // 
            this.middleRow.Location = new System.Drawing.Point(234, 151);
            this.middleRow.Name = "middleRow";
            this.middleRow.Size = new System.Drawing.Size(52, 20);
            this.middleRow.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 240);
            this.Controls.Add(this.middleRow);
            this.Controls.Add(this.upperRow);
            this.Controls.Add(this.bestellingenRekenL);
            this.Controls.Add(this.bestellingenreken);
            this.Controls.Add(this.bestellingenL);
            this.Controls.Add(this.bestellingenText);
            this.Controls.Add(this.klantenL);
            this.Controls.Add(this.klantenText);
            this.Controls.Add(this.artikelenL);
            this.Controls.Add(this.artikelenText);
            this.Name = "Form1";
            this.Text = "Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox artikelenText;
        private System.Windows.Forms.Label artikelenL;
        private System.Windows.Forms.Label klantenL;
        private System.Windows.Forms.TextBox klantenText;
        private System.Windows.Forms.Label bestellingenL;
        private System.Windows.Forms.TextBox bestellingenText;
        private System.Windows.Forms.TextBox bestellingenreken;
        private System.Windows.Forms.Label bestellingenRekenL;
        private System.Windows.Forms.TextBox upperRow;
        private System.Windows.Forms.TextBox middleRow;
    }
}

