namespace WindowsFormsApp1
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtcont = new System.Windows.Forms.TextBox();
            this.txtprod = new System.Windows.Forms.TextBox();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.txtpricew = new System.Windows.Forms.RichTextBox();
            this.btnprint = new System.Windows.Forms.Button();
            this.btnreset = new System.Windows.Forms.Button();
            this.btnGen = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Coral;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 85);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(269, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rawal Inventory";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(293, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "FEE RECEIPT";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "NAME";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 326);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "PRICE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "PRODUCT";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "CONTACT";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(121, 159);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(130, 22);
            this.txtname.TabIndex = 9;
            // 
            // txtcont
            // 
            this.txtcont.Location = new System.Drawing.Point(121, 220);
            this.txtcont.Name = "txtcont";
            this.txtcont.Size = new System.Drawing.Size(130, 22);
            this.txtcont.TabIndex = 10;
            // 
            // txtprod
            // 
            this.txtprod.Location = new System.Drawing.Point(121, 276);
            this.txtprod.Name = "txtprod";
            this.txtprod.Size = new System.Drawing.Size(130, 22);
            this.txtprod.TabIndex = 11;
            // 
            // txtprice
            // 
            this.txtprice.Location = new System.Drawing.Point(121, 326);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(130, 22);
            this.txtprice.TabIndex = 12;
            // 
            // txtpricew
            // 
            this.txtpricew.Location = new System.Drawing.Point(299, 159);
            this.txtpricew.Name = "txtpricew";
            this.txtpricew.Size = new System.Drawing.Size(502, 296);
            this.txtpricew.TabIndex = 13;
            this.txtpricew.Text = "";
            // 
            // btnprint
            // 
            this.btnprint.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprint.Location = new System.Drawing.Point(121, 394);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(85, 29);
            this.btnprint.TabIndex = 14;
            this.btnprint.Text = "PRINT";
            this.btnprint.UseVisualStyleBackColor = true;
            this.btnprint.Click += new System.EventHandler(this.btnprint_Click);
            // 
            // btnreset
            // 
            this.btnreset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreset.Location = new System.Drawing.Point(212, 394);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(81, 29);
            this.btnreset.TabIndex = 15;
            this.btnreset.Text = "RESET";
            this.btnreset.UseVisualStyleBackColor = true;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // btnGen
            // 
            this.btnGen.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGen.Location = new System.Drawing.Point(12, 394);
            this.btnGen.Name = "btnGen";
            this.btnGen.Size = new System.Drawing.Size(99, 29);
            this.btnGen.TabIndex = 16;
            this.btnGen.Text = "Generate";
            this.btnGen.UseVisualStyleBackColor = false;
            this.btnGen.Click += new System.EventHandler(this.btnGen_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGen);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.btnprint);
            this.Controls.Add(this.txtpricew);
            this.Controls.Add(this.txtprice);
            this.Controls.Add(this.txtprod);
            this.Controls.Add(this.txtcont);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtcont;
        private System.Windows.Forms.TextBox txtprod;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.RichTextBox txtpricew;
        private System.Windows.Forms.Button btnprint;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.Button btnGen;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}