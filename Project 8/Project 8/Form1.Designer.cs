namespace Project_8
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.beverage = new System.Windows.Forms.ComboBox();
            this.appetizerbox = new System.Windows.Forms.ComboBox();
            this.maincoursebox = new System.Windows.Forms.ComboBox();
            this.dessertbox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Recipt = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.taxtable = new System.Windows.Forms.TextBox();
            this.totaltable = new System.Windows.Forms.TextBox();
            this.subtotaltable = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Waiter Information";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(113, 56);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 9;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(187, 26);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(26, 20);
            this.textBox2.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Waiter\'s name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Table number:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.beverage);
            this.groupBox2.Controls.Add(this.appetizerbox);
            this.groupBox2.Controls.Add(this.maincoursebox);
            this.groupBox2.Controls.Add(this.dessertbox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(12, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(250, 164);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Menu Items";
            // 
            // beverage
            // 
            this.beverage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.beverage.FormattingEnabled = true;
            this.beverage.Items.AddRange(new object[] {
            "Soda",
            "Tea",
            "Coffee",
            "Mineral Water",
            "Juice",
            "Milk"});
            this.beverage.Location = new System.Drawing.Point(92, 26);
            this.beverage.Name = "beverage";
            this.beverage.Size = new System.Drawing.Size(121, 21);
            this.beverage.TabIndex = 11;
            this.beverage.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // appetizerbox
            // 
            this.appetizerbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.appetizerbox.FormattingEnabled = true;
            this.appetizerbox.Items.AddRange(new object[] {
            "Buffalo Wings",
            "Buffalo Fingers",
            "Potato Skins",
            "Nachos",
            "Mushroom Caps",
            "Shrimp Cocktail",
            "Chips and Salsa"});
            this.appetizerbox.Location = new System.Drawing.Point(92, 54);
            this.appetizerbox.Name = "appetizerbox";
            this.appetizerbox.Size = new System.Drawing.Size(121, 21);
            this.appetizerbox.TabIndex = 12;
            this.appetizerbox.SelectedIndexChanged += new System.EventHandler(this.appetizerbox_SelectedIndexChanged);
            // 
            // maincoursebox
            // 
            this.maincoursebox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.maincoursebox.FormattingEnabled = true;
            this.maincoursebox.Items.AddRange(new object[] {
            "Seafood Alfredo",
            "Chicken Alfredo",
            "Chicken Picatta",
            "Turkey Club",
            "Lobster Pie",
            "Prime Rib",
            "Shrimp Scampi",
            "Turkey Dinner",
            "Stuffed Chicken"});
            this.maincoursebox.Location = new System.Drawing.Point(92, 82);
            this.maincoursebox.Name = "maincoursebox";
            this.maincoursebox.Size = new System.Drawing.Size(121, 21);
            this.maincoursebox.TabIndex = 13;
            this.maincoursebox.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // dessertbox
            // 
            this.dessertbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dessertbox.FormattingEnabled = true;
            this.dessertbox.Items.AddRange(new object[] {
            "Apple Pie",
            "Sundae",
            "Carrot Cake",
            "Mud Pie",
            "Apple Crisp"});
            this.dessertbox.Location = new System.Drawing.Point(92, 110);
            this.dessertbox.Name = "dessertbox";
            this.dessertbox.Size = new System.Drawing.Size(121, 21);
            this.dessertbox.TabIndex = 14;
            this.dessertbox.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Beverage:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Appetizer:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Main course:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Dessert:";
            // 
            // Recipt
            // 
            this.Recipt.Enabled = false;
            this.Recipt.FormattingEnabled = true;
            this.Recipt.Location = new System.Drawing.Point(268, 17);
            this.Recipt.Name = "Recipt";
            this.Recipt.Size = new System.Drawing.Size(219, 368);
            this.Recipt.TabIndex = 2;
            this.Recipt.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(104, 288);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Clear Bill";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 323);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Subtotal:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 371);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Total:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(32, 347);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Tax:";
            // 
            // taxtable
            // 
            this.taxtable.BackColor = System.Drawing.SystemColors.Window;
            this.taxtable.Enabled = false;
            this.taxtable.Location = new System.Drawing.Point(125, 347);
            this.taxtable.Name = "taxtable";
            this.taxtable.Size = new System.Drawing.Size(100, 20);
            this.taxtable.TabIndex = 15;
            // 
            // totaltable
            // 
            this.totaltable.Enabled = false;
            this.totaltable.Location = new System.Drawing.Point(125, 371);
            this.totaltable.Name = "totaltable";
            this.totaltable.Size = new System.Drawing.Size(100, 20);
            this.totaltable.TabIndex = 16;
            // 
            // subtotaltable
            // 
            this.subtotaltable.Location = new System.Drawing.Point(125, 323);
            this.subtotaltable.Name = "subtotaltable";
            this.subtotaltable.Size = new System.Drawing.Size(99, 20);
            this.subtotaltable.TabIndex = 19;
            this.subtotaltable.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 393);
            this.Controls.Add(this.subtotaltable);
            this.Controls.Add(this.taxtable);
            this.Controls.Add(this.totaltable);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Recipt);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Restaurant Bill Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox Recipt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox beverage;
        private System.Windows.Forms.ComboBox appetizerbox;
        private System.Windows.Forms.ComboBox maincoursebox;
        private System.Windows.Forms.ComboBox dessertbox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox taxtable;
        private System.Windows.Forms.TextBox totaltable;
        private System.Windows.Forms.TextBox subtotaltable;
    }
}

