namespace Drawing_Robot
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
            button1 = new Button();
            comboBox1 = new ComboBox();
            button2 = new Button();
            colorDialog1 = new ColorDialog();
            pnl_input = new Panel();
            listBox1 = new ListBox();
            label1 = new Label();
            button3 = new Button();
            pnl_debug = new Panel();
            label2 = new Label();
            pnl_input.SuspendLayout();
            pnl_debug.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(895, 8);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(82, 22);
            button1.TabIndex = 0;
            button1.Text = "Draw";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            comboBox1.Location = new Point(47, 8);
            comboBox1.Margin = new Padding(3, 2, 3, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(106, 23);
            comboBox1.TabIndex = 1;
            comboBox1.Text = "1";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button2
            // 
            button2.Location = new Point(47, 34);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(105, 22);
            button2.TabIndex = 2;
            button2.Text = "Color";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // colorDialog1
            // 
            colorDialog1.FullOpen = true;
            // 
            // pnl_input
            // 
            pnl_input.BackColor = SystemColors.Info;
            pnl_input.Controls.Add(listBox1);
            pnl_input.Controls.Add(label1);
            pnl_input.Controls.Add(button3);
            pnl_input.Controls.Add(button2);
            pnl_input.Controls.Add(button1);
            pnl_input.Controls.Add(comboBox1);
            pnl_input.Dock = DockStyle.Top;
            pnl_input.Location = new Point(0, 0);
            pnl_input.Margin = new Padding(3, 2, 3, 2);
            pnl_input.Name = "pnl_input";
            pnl_input.Size = new Size(1232, 64);
            pnl_input.TabIndex = 3;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(168, 8);
            listBox1.Margin = new Padding(3, 2, 3, 2);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(710, 49);
            listBox1.TabIndex = 5;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.OrangeRed;
            label1.Location = new Point(4, 10);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 4;
            label1.Text = "Size :";
            // 
            // button3
            // 
            button3.Location = new Point(895, 34);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(82, 22);
            button3.TabIndex = 3;
            button3.Text = "Reset";
            button3.UseVisualStyleBackColor = true;
            button3.Visible = false;
            button3.Click += button3_Click;
            // 
            // pnl_debug
            // 
            pnl_debug.BackColor = SystemColors.Desktop;
            pnl_debug.Controls.Add(label2);
            pnl_debug.Dock = DockStyle.Bottom;
            pnl_debug.ForeColor = SystemColors.ControlLightLight;
            pnl_debug.Location = new Point(0, 396);
            pnl_debug.Margin = new Padding(3, 2, 3, 2);
            pnl_debug.Name = "pnl_debug";
            pnl_debug.Size = new Size(1232, 82);
            pnl_debug.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Microsoft Himalaya", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.PaleGreen;
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(0, 24);
            label2.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1232, 478);
            Controls.Add(pnl_debug);
            Controls.Add(pnl_input);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Drawing Robot";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            pnl_input.ResumeLayout(false);
            pnl_input.PerformLayout();
            pnl_debug.ResumeLayout(false);
            pnl_debug.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private ComboBox comboBox1;
        private Button button2;
        private ColorDialog colorDialog1;
        private Panel pnl_input;
        private Panel pnl_debug;
        private Button button3;
        private ListBox listBox1;
        private Label label1;
        private Label label2;
    }
}