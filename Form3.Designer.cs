namespace WindowsFormsApp1
{
    partial class Form3
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btndelcat = new System.Windows.Forms.Button();
            this.btnupcat = new System.Windows.Forms.Button();
            this.btnAddCat = new System.Windows.Forms.Button();
            this.txtDesccat = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtcatname = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Coral;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 85);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(278, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rawal Inventory";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.txtcatname);
            this.groupBox1.Controls.Add(this.btndelcat);
            this.groupBox1.Controls.Add(this.btnupcat);
            this.groupBox1.Controls.Add(this.btnAddCat);
            this.groupBox1.Controls.Add(this.txtDesccat);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(0, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(423, 366);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Category";
            // 
            // btndelcat
            // 
            this.btndelcat.Location = new System.Drawing.Point(323, 294);
            this.btndelcat.Name = "btndelcat";
            this.btndelcat.Size = new System.Drawing.Size(75, 34);
            this.btndelcat.TabIndex = 12;
            this.btndelcat.Text = "Delete";
            this.btndelcat.UseVisualStyleBackColor = true;
            this.btndelcat.Click += new System.EventHandler(this.btndelcat_Click);
            // 
            // btnupcat
            // 
            this.btnupcat.Location = new System.Drawing.Point(223, 294);
            this.btnupcat.Name = "btnupcat";
            this.btnupcat.Size = new System.Drawing.Size(75, 34);
            this.btnupcat.TabIndex = 11;
            this.btnupcat.Text = "Update";
            this.btnupcat.UseVisualStyleBackColor = true;
            this.btnupcat.Click += new System.EventHandler(this.btnupcat_Click);
            // 
            // btnAddCat
            // 
            this.btnAddCat.Location = new System.Drawing.Point(131, 294);
            this.btnAddCat.Name = "btnAddCat";
            this.btnAddCat.Size = new System.Drawing.Size(75, 34);
            this.btnAddCat.TabIndex = 10;
            this.btnAddCat.Text = "Add";
            this.btnAddCat.UseVisualStyleBackColor = true;
            this.btnAddCat.Click += new System.EventHandler(this.btnAddCat_Click);
            // 
            // txtDesccat
            // 
            this.txtDesccat.Location = new System.Drawing.Point(206, 143);
            this.txtDesccat.Name = "txtDesccat";
            this.txtDesccat.Size = new System.Drawing.Size(192, 106);
            this.txtDesccat.TabIndex = 9;
            this.txtDesccat.Text = "";
            this.txtDesccat.TextChanged += new System.EventHandler(this.txtDesccat_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Category Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Category Name";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(421, 85);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(379, 366);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtcatname
            // 
            this.txtcatname.Location = new System.Drawing.Point(206, 69);
            this.txtcatname.Name = "txtcatname";
            this.txtcatname.Size = new System.Drawing.Size(192, 22);
            this.txtcatname.TabIndex = 13;
            this.txtcatname.TextChanged += new System.EventHandler(this.txtcatname_TextChanged);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Form3";
            this.Text = "Cateogry";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.RichTextBox txtDesccat;
        private System.Windows.Forms.Button btndelcat;
        private System.Windows.Forms.Button btnupcat;
        private System.Windows.Forms.Button btnAddCat;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtcatname;
    }
}