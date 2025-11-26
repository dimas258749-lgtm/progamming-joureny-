namespace ProjectAkhir_dimasXPPLG2
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            dataGridView2 = new DataGridView();
            n = new DataGridViewTextBoxColumn();
            Ju = new DataGridViewTextBoxColumn();
            jumpes = new DataGridViewTextBoxColumn();
            H = new DataGridViewTextBoxColumn();
            tangpes = new DataGridViewTextBoxColumn();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            jenpes = new DataGridViewTextBoxColumn();
            harbar = new DataGridViewTextBoxColumn();
            button1 = new Button();
            button2 = new Button();
            dateTimePicker1 = new DateTimePicker();
            label6 = new Label();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(529, -3);
            label1.Name = "label1";
            label1.Size = new Size(594, 65);
            label1.TabIndex = 0;
            label1.Text = "DAFTAR PESAN BARANG";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(1, 76);
            label2.Name = "label2";
            label2.Size = new Size(85, 28);
            label2.TabIndex = 1;
            label2.Text = "Nama ";
            label2.Click += label2_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(1, 177);
            label3.Name = "label3";
            label3.Size = new Size(171, 28);
            label3.TabIndex = 7;
            label3.Text = "Jenis Barang ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(1, 273);
            label4.Name = "label4";
            label4.Size = new Size(201, 28);
            label4.TabIndex = 8;
            label4.Text = "Jumlah Pesanan";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.ForeColor = Color.White;
            label5.Location = new Point(16, 228);
            label5.Name = "label5";
            label5.Size = new Size(0, 25);
            label5.TabIndex = 10;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.BackgroundColor = SystemColors.WindowFrame;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { n, Ju, jumpes, H, tangpes });
            dataGridView2.Location = new Point(987, 437);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.Size = new Size(765, 443);
            dataGridView2.TabIndex = 12;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick_1;
            // 
            // n
            // 
            n.HeaderText = "Nama";
            n.MinimumWidth = 8;
            n.Name = "n";
            n.ReadOnly = true;
            n.Width = 150;
            // 
            // Ju
            // 
            Ju.HeaderText = "Jenis Barang";
            Ju.MinimumWidth = 8;
            Ju.Name = "Ju";
            Ju.ReadOnly = true;
            Ju.Width = 150;
            // 
            // jumpes
            // 
            jumpes.HeaderText = "Jumlah Pesanan";
            jumpes.MinimumWidth = 8;
            jumpes.Name = "jumpes";
            jumpes.ReadOnly = true;
            jumpes.Width = 150;
            // 
            // H
            // 
            H.HeaderText = "Harga Barang";
            H.MinimumWidth = 8;
            H.Name = "H";
            H.ReadOnly = true;
            H.Width = 150;
            // 
            // tangpes
            // 
            tangpes.HeaderText = "Tanggal Pesanan ";
            tangpes.MinimumWidth = 8;
            tangpes.Name = "tangpes";
            tangpes.ReadOnly = true;
            tangpes.Width = 150;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = SystemColors.WindowFrame;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Tas", "Sepatu", "Baju", "Hoodie" });
            comboBox1.Location = new Point(228, 172);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 33);
            comboBox1.TabIndex = 13;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // comboBox2
            // 
            comboBox2.BackColor = SystemColors.WindowFrame;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
            comboBox2.Location = new Point(228, 273);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(182, 33);
            comboBox2.TabIndex = 14;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.WindowFrame;
            textBox1.Location = new Point(228, 76);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(182, 31);
            textBox1.TabIndex = 15;
            textBox1.TextChanged += textBox1_TextChanged_1;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = SystemColors.WindowFrame;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { jenpes, harbar });
            dataGridView1.Location = new Point(1253, 51);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(369, 212);
            dataGridView1.TabIndex = 16;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // jenpes
            // 
            jenpes.HeaderText = "Jenis Pesanan";
            jenpes.MinimumWidth = 8;
            jenpes.Name = "jenpes";
            jenpes.ReadOnly = true;
            jenpes.Width = 150;
            // 
            // harbar
            // 
            harbar.HeaderText = "Harga Barang";
            harbar.MinimumWidth = 8;
            harbar.Name = "harbar";
            harbar.ReadOnly = true;
            harbar.Width = 150;
            // 
            // button1
            // 
            button1.BackColor = Color.Green;
            button1.Location = new Point(28, 489);
            button1.Name = "button1";
            button1.Size = new Size(156, 74);
            button1.TabIndex = 17;
            button1.Text = "Pesan";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.Location = new Point(228, 489);
            button2.Name = "button2";
            button2.Size = new Size(151, 66);
            button2.TabIndex = 18;
            button2.Text = "Batal";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(228, 361);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(147, 31);
            dateTimePicker1.TabIndex = 19;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(1, 361);
            label6.Name = "label6";
            label6.Size = new Size(183, 28);
            label6.TabIndex = 20;
            label6.Text = "Tanggal Pesan";
            label6.Click += label6_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Navy;
            button3.ForeColor = Color.White;
            button3.Location = new Point(28, 747);
            button3.Name = "button3";
            button3.Size = new Size(156, 68);
            button3.TabIndex = 21;
            button3.Text = "Reset";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1716, 879);
            Controls.Add(button3);
            Controls.Add(label6);
            Controls.Add(dateTimePicker1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(textBox1);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(dataGridView2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Daftar Pesanan ";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ContextMenuStrip contextMenuStrip1;
        private Label label3;
        private Label label4;
        private Label label5;
        private DataGridView dataGridView2;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private TextBox textBox1;
        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private DataGridViewTextBoxColumn jenpes;
        private DataGridViewTextBoxColumn harbar;
        private DataGridViewTextBoxColumn n;
        private DataGridViewTextBoxColumn Ju;
        private DataGridViewTextBoxColumn jumpes;
        private DataGridViewTextBoxColumn H;
        private DateTimePicker dateTimePicker1;
        private DataGridViewTextBoxColumn tangpes;
        private Label label6;
        private Button button3;
    }
}
