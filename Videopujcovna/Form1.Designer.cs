namespace Videopujcovna
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
            this.zakaznici = new System.Windows.Forms.DataGridView();
            this.sklad = new System.Windows.Forms.DataGridView();
            this.polozky = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.zakaznici)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sklad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.polozky)).BeginInit();
            this.SuspendLayout();
            // 
            // zakaznici
            // 
            this.zakaznici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.zakaznici.Location = new System.Drawing.Point(12, 12);
            this.zakaznici.MultiSelect = false;
            this.zakaznici.Name = "zakaznici";
            this.zakaznici.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.zakaznici.Size = new System.Drawing.Size(379, 281);
            this.zakaznici.TabIndex = 0;
            this.zakaznici.SelectionChanged += new System.EventHandler(this.zakaznici_SelectionChanged);
            // 
            // sklad
            // 
            this.sklad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sklad.Location = new System.Drawing.Point(397, 12);
            this.sklad.MultiSelect = false;
            this.sklad.Name = "sklad";
            this.sklad.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.sklad.Size = new System.Drawing.Size(379, 281);
            this.sklad.TabIndex = 1;
            // 
            // polozky
            // 
            this.polozky.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.polozky.Location = new System.Drawing.Point(12, 299);
            this.polozky.MultiSelect = false;
            this.polozky.Name = "polozky";
            this.polozky.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.polozky.Size = new System.Drawing.Size(565, 158);
            this.polozky.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(583, 299);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(193, 57);
            this.button1.TabIndex = 3;
            this.button1.Text = "Vypůjčit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(583, 362);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(193, 57);
            this.button2.TabIndex = 4;
            this.button2.Text = "Vrátit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(630, 434);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(111, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Nový zákazník";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 469);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.polozky);
            this.Controls.Add(this.sklad);
            this.Controls.Add(this.zakaznici);
            this.Name = "Form1";
            this.Text = "Videopůjčovna";
            ((System.ComponentModel.ISupportInitialize)(this.zakaznici)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sklad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.polozky)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView zakaznici;
        private System.Windows.Forms.DataGridView sklad;
        private System.Windows.Forms.DataGridView polozky;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

