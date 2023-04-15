namespace ex1
{
    partial class Form2
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
            groupBox1 = new GroupBox();
            button4 = new Button();
            grd1 = new DataGridView();
            button3 = new Button();
            button2 = new Button();
            groupBox5 = new GroupBox();
            label15 = new Label();
            txtgiasp = new TextBox();
            label14 = new Label();
            txtslsp = new TextBox();
            label2 = new Label();
            label1 = new Label();
            txttensp = new TextBox();
            txtidsp = new TextBox();
            button1 = new Button();
            groupBox2 = new GroupBox();
            button16 = new Button();
            button15 = new Button();
            button14 = new Button();
            grd3 = new DataGridView();
            button9 = new Button();
            label5 = new Label();
            dtp = new DateTimePicker();
            label4 = new Label();
            label3 = new Label();
            txtagent = new TextBox();
            txtidoder = new TextBox();
            bill = new RichTextBox();
            button6 = new Button();
            button5 = new Button();
            groupBox3 = new GroupBox();
            label11 = new Label();
            button10 = new Button();
            label9 = new Label();
            txtidagent = new TextBox();
            label10 = new Label();
            grd2 = new DataGridView();
            button12 = new Button();
            button13 = new Button();
            txtnameagent = new TextBox();
            button11 = new Button();
            txtaddress = new TextBox();
            button7 = new Button();
            button8 = new Button();
            groupBox4 = new GroupBox();
            button20 = new Button();
            button19 = new Button();
            button18 = new Button();
            button17 = new Button();
            txtamountdetail = new TextBox();
            label13 = new Label();
            txtsldetil = new TextBox();
            txtitemid = new TextBox();
            label12 = new Label();
            grd4 = new DataGridView();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtorderdetail = new TextBox();
            txtiddetail = new TextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grd1).BeginInit();
            groupBox5.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grd3).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grd2).BeginInit();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grd4).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Window;
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(grd1);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(groupBox5);
            groupBox1.Controls.Add(button1);
            groupBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(14, 40);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(571, 289);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Item";
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(17, 246);
            button4.Margin = new Padding(2);
            button4.Name = "button4";
            button4.Size = new Size(109, 35);
            button4.TabIndex = 3;
            button4.Text = "Save";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // grd1
            // 
            grd1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grd1.Location = new Point(130, 131);
            grd1.Margin = new Padding(2);
            grd1.Name = "grd1";
            grd1.RowHeadersWidth = 62;
            grd1.RowTemplate.Height = 33;
            grd1.Size = new Size(428, 150);
            grd1.TabIndex = 2;
            grd1.CellContentClick += grd1_CellContentClick;
            grd1.Click += grd1_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(17, 208);
            button3.Margin = new Padding(2);
            button3.Name = "button3";
            button3.Size = new Size(109, 34);
            button3.TabIndex = 2;
            button3.Text = "Edit";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(17, 170);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(109, 34);
            button2.TabIndex = 1;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // groupBox5
            // 
            groupBox5.BackColor = SystemColors.Window;
            groupBox5.Controls.Add(label15);
            groupBox5.Controls.Add(txtgiasp);
            groupBox5.Controls.Add(label14);
            groupBox5.Controls.Add(txtslsp);
            groupBox5.Controls.Add(label2);
            groupBox5.Controls.Add(label1);
            groupBox5.Controls.Add(txttensp);
            groupBox5.Controls.Add(txtidsp);
            groupBox5.ForeColor = SystemColors.ActiveCaptionText;
            groupBox5.Location = new Point(18, 24);
            groupBox5.Margin = new Padding(2);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new Padding(2);
            groupBox5.Size = new Size(540, 100);
            groupBox5.TabIndex = 0;
            groupBox5.TabStop = false;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(259, 61);
            label15.Margin = new Padding(2, 0, 2, 0);
            label15.Name = "label15";
            label15.Size = new Size(72, 23);
            label15.TabIndex = 7;
            label15.Text = "Amount";
            // 
            // txtgiasp
            // 
            txtgiasp.BackColor = SystemColors.ControlLightLight;
            txtgiasp.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtgiasp.Location = new Point(335, 58);
            txtgiasp.Margin = new Padding(2);
            txtgiasp.Name = "txtgiasp";
            txtgiasp.Size = new Size(191, 30);
            txtgiasp.TabIndex = 6;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(19, 61);
            label14.Margin = new Padding(2, 0, 2, 0);
            label14.Name = "label14";
            label14.Size = new Size(76, 23);
            label14.TabIndex = 5;
            label14.Text = "Quantity";
            // 
            // txtslsp
            // 
            txtslsp.BackColor = SystemColors.Window;
            txtslsp.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtslsp.Location = new Point(110, 58);
            txtslsp.Margin = new Padding(2);
            txtslsp.Name = "txtslsp";
            txtslsp.Size = new Size(145, 30);
            txtslsp.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(259, 26);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(56, 23);
            label2.TabIndex = 3;
            label2.Text = "Name";
            label2.Click += label2_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(19, 31);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(27, 23);
            label1.TabIndex = 2;
            label1.Text = "ID";
            // 
            // txttensp
            // 
            txttensp.BackColor = SystemColors.Window;
            txttensp.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            txttensp.Location = new Point(335, 24);
            txttensp.Margin = new Padding(2);
            txttensp.Name = "txttensp";
            txttensp.Size = new Size(191, 30);
            txttensp.TabIndex = 1;
            // 
            // txtidsp
            // 
            txtidsp.BackColor = SystemColors.Window;
            txtidsp.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtidsp.Location = new Point(110, 24);
            txtidsp.Margin = new Padding(2);
            txtidsp.Name = "txtidsp";
            txtidsp.Size = new Size(145, 30);
            txtidsp.TabIndex = 0;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(17, 131);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(109, 35);
            button1.TabIndex = 0;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.Window;
            groupBox2.Controls.Add(button16);
            groupBox2.Controls.Add(button15);
            groupBox2.Controls.Add(button14);
            groupBox2.Controls.Add(grd3);
            groupBox2.Controls.Add(button9);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(dtp);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(txtagent);
            groupBox2.Controls.Add(txtidoder);
            groupBox2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(589, 40);
            groupBox2.Margin = new Padding(2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(2);
            groupBox2.Size = new Size(488, 289);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Order";
            // 
            // button16
            // 
            button16.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button16.Location = new Point(6, 246);
            button16.Margin = new Padding(2);
            button16.Name = "button16";
            button16.Size = new Size(70, 35);
            button16.TabIndex = 4;
            button16.Text = "Save";
            button16.UseVisualStyleBackColor = true;
            button16.Click += button16_Click;
            // 
            // button15
            // 
            button15.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button15.Location = new Point(6, 208);
            button15.Margin = new Padding(2);
            button15.Name = "button15";
            button15.Size = new Size(70, 35);
            button15.TabIndex = 4;
            button15.Text = "Edit";
            button15.UseVisualStyleBackColor = true;
            button15.Click += button15_Click;
            // 
            // button14
            // 
            button14.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button14.Location = new Point(6, 169);
            button14.Margin = new Padding(2);
            button14.Name = "button14";
            button14.Size = new Size(70, 35);
            button14.TabIndex = 4;
            button14.Text = "Delete";
            button14.UseVisualStyleBackColor = true;
            button14.Click += button14_Click;
            // 
            // grd3
            // 
            grd3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grd3.Location = new Point(81, 131);
            grd3.Name = "grd3";
            grd3.RowTemplate.Height = 25;
            grd3.Size = new Size(393, 150);
            grd3.TabIndex = 6;
            grd3.CellContentClick += grd3_CellContentClick;
            // 
            // button9
            // 
            button9.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button9.Location = new Point(5, 131);
            button9.Margin = new Padding(2);
            button9.Name = "button9";
            button9.Size = new Size(71, 35);
            button9.TabIndex = 4;
            button9.Text = "Add";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(5, 85);
            label5.Name = "label5";
            label5.Size = new Size(90, 23);
            label5.TabIndex = 5;
            label5.Text = "OrderDate";
            // 
            // dtp
            // 
            dtp.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            dtp.Location = new Point(101, 80);
            dtp.Name = "dtp";
            dtp.Size = new Size(373, 30);
            dtp.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(253, 40);
            label4.Name = "label4";
            label4.Size = new Size(73, 23);
            label4.TabIndex = 3;
            label4.Text = "AgentID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(5, 39);
            label3.Name = "label3";
            label3.Size = new Size(71, 23);
            label3.TabIndex = 2;
            label3.Text = "OrderID";
            // 
            // txtagent
            // 
            txtagent.BackColor = SystemColors.ControlLightLight;
            txtagent.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtagent.Location = new Point(338, 34);
            txtagent.Name = "txtagent";
            txtagent.Size = new Size(136, 33);
            txtagent.TabIndex = 1;
            // 
            // txtidoder
            // 
            txtidoder.BackColor = SystemColors.ControlLightLight;
            txtidoder.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtidoder.Location = new Point(101, 35);
            txtidoder.Name = "txtidoder";
            txtidoder.Size = new Size(134, 33);
            txtidoder.TabIndex = 0;
            // 
            // bill
            // 
            bill.Location = new Point(1082, 48);
            bill.Name = "bill";
            bill.Size = new Size(276, 281);
            bill.TabIndex = 8;
            bill.Text = "";
            // 
            // button6
            // 
            button6.BackColor = SystemColors.GradientInactiveCaption;
            button6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button6.Location = new Point(348, -2);
            button6.Margin = new Padding(2);
            button6.Name = "button6";
            button6.Size = new Size(113, 38);
            button6.TabIndex = 3;
            button6.Text = "Print order";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.GradientInactiveCaption;
            button5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button5.Location = new Point(219, -2);
            button5.Margin = new Padding(2);
            button5.Name = "button5";
            button5.Size = new Size(114, 38);
            button5.TabIndex = 2;
            button5.Text = "Create order";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = SystemColors.Window;
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(button10);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(txtidagent);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(grd2);
            groupBox3.Controls.Add(button12);
            groupBox3.Controls.Add(button13);
            groupBox3.Controls.Add(txtnameagent);
            groupBox3.Controls.Add(button11);
            groupBox3.Controls.Add(txtaddress);
            groupBox3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox3.Location = new Point(13, 333);
            groupBox3.Margin = new Padding(2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(2);
            groupBox3.Size = new Size(643, 276);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Agent";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(12, 65);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(70, 23);
            label11.TabIndex = 14;
            label11.Text = "Address";
            // 
            // button10
            // 
            button10.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            button10.Location = new Point(18, 125);
            button10.Margin = new Padding(2);
            button10.Name = "button10";
            button10.Size = new Size(107, 32);
            button10.TabIndex = 4;
            button10.Text = "Add";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(12, 32);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(73, 23);
            label9.TabIndex = 11;
            label9.Text = "AgentID";
            // 
            // txtidagent
            // 
            txtidagent.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtidagent.Location = new Point(95, 22);
            txtidagent.Margin = new Padding(2);
            txtidagent.Name = "txtidagent";
            txtidagent.Size = new Size(225, 33);
            txtidagent.TabIndex = 15;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(335, 32);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(56, 23);
            label10.TabIndex = 12;
            label10.Text = "Name";
            // 
            // grd2
            // 
            grd2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grd2.Location = new Point(129, 125);
            grd2.Margin = new Padding(2);
            grd2.Name = "grd2";
            grd2.RowHeadersWidth = 62;
            grd2.RowTemplate.Height = 33;
            grd2.Size = new Size(510, 140);
            grd2.TabIndex = 1;
            grd2.CellContentClick += grd2_CellContentClick;
            // 
            // button12
            // 
            button12.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            button12.Location = new Point(19, 197);
            button12.Margin = new Padding(2);
            button12.Name = "button12";
            button12.Size = new Size(106, 32);
            button12.TabIndex = 4;
            button12.Text = "Edit";
            button12.UseVisualStyleBackColor = true;
            button12.Click += button12_Click;
            // 
            // button13
            // 
            button13.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            button13.Location = new Point(18, 233);
            button13.Margin = new Padding(2);
            button13.Name = "button13";
            button13.Size = new Size(107, 32);
            button13.TabIndex = 4;
            button13.Text = "Save";
            button13.UseVisualStyleBackColor = true;
            button13.Click += button13_Click;
            // 
            // txtnameagent
            // 
            txtnameagent.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtnameagent.Location = new Point(395, 22);
            txtnameagent.Margin = new Padding(2);
            txtnameagent.Name = "txtnameagent";
            txtnameagent.Size = new Size(225, 33);
            txtnameagent.TabIndex = 6;
            // 
            // button11
            // 
            button11.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            button11.Location = new Point(18, 161);
            button11.Margin = new Padding(2);
            button11.Name = "button11";
            button11.Size = new Size(107, 32);
            button11.TabIndex = 4;
            button11.Text = "Delete";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;
            // 
            // txtaddress
            // 
            txtaddress.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtaddress.Location = new Point(95, 55);
            txtaddress.Margin = new Padding(2);
            txtaddress.Name = "txtaddress";
            txtaddress.Size = new Size(225, 33);
            txtaddress.TabIndex = 5;
            // 
            // button7
            // 
            button7.BackColor = SystemColors.GradientInactiveCaption;
            button7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button7.Location = new Point(14, -2);
            button7.Margin = new Padding(2);
            button7.Name = "button7";
            button7.Size = new Size(87, 38);
            button7.TabIndex = 4;
            button7.Text = "Filter";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.BackColor = SystemColors.GradientInactiveCaption;
            button8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button8.Location = new Point(118, -2);
            button8.Margin = new Padding(2);
            button8.Name = "button8";
            button8.Size = new Size(87, 38);
            button8.TabIndex = 5;
            button8.Text = "Cancel";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // groupBox4
            // 
            groupBox4.BackColor = SystemColors.Window;
            groupBox4.Controls.Add(button20);
            groupBox4.Controls.Add(button19);
            groupBox4.Controls.Add(button18);
            groupBox4.Controls.Add(button17);
            groupBox4.Controls.Add(txtamountdetail);
            groupBox4.Controls.Add(label13);
            groupBox4.Controls.Add(txtsldetil);
            groupBox4.Controls.Add(txtitemid);
            groupBox4.Controls.Add(label12);
            groupBox4.Controls.Add(grd4);
            groupBox4.Controls.Add(label6);
            groupBox4.Controls.Add(label7);
            groupBox4.Controls.Add(label8);
            groupBox4.Controls.Add(txtorderdetail);
            groupBox4.Controls.Add(txtiddetail);
            groupBox4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox4.Location = new Point(670, 333);
            groupBox4.Margin = new Padding(2);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(2);
            groupBox4.Size = new Size(689, 276);
            groupBox4.TabIndex = 7;
            groupBox4.TabStop = false;
            groupBox4.Text = "OrderDetail";
            // 
            // button20
            // 
            button20.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button20.Location = new Point(12, 230);
            button20.Margin = new Padding(2);
            button20.Name = "button20";
            button20.Size = new Size(79, 35);
            button20.TabIndex = 7;
            button20.Text = "Save";
            button20.UseVisualStyleBackColor = true;
            button20.Click += button20_Click;
            // 
            // button19
            // 
            button19.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button19.Location = new Point(12, 194);
            button19.Margin = new Padding(2);
            button19.Name = "button19";
            button19.Size = new Size(79, 35);
            button19.TabIndex = 7;
            button19.Text = "Edit";
            button19.UseVisualStyleBackColor = true;
            button19.Click += button19_Click;
            // 
            // button18
            // 
            button18.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button18.Location = new Point(12, 158);
            button18.Margin = new Padding(2);
            button18.Name = "button18";
            button18.Size = new Size(79, 35);
            button18.TabIndex = 7;
            button18.Text = "Delete";
            button18.UseVisualStyleBackColor = true;
            button18.Click += button18_Click;
            // 
            // button17
            // 
            button17.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button17.Location = new Point(12, 123);
            button17.Margin = new Padding(2);
            button17.Name = "button17";
            button17.Size = new Size(79, 35);
            button17.TabIndex = 7;
            button17.Text = "Add";
            button17.UseVisualStyleBackColor = true;
            button17.Click += button17_Click;
            // 
            // txtamountdetail
            // 
            txtamountdetail.BackColor = SystemColors.Window;
            txtamountdetail.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtamountdetail.Location = new Point(411, 74);
            txtamountdetail.Name = "txtamountdetail";
            txtamountdetail.Size = new Size(243, 33);
            txtamountdetail.TabIndex = 11;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(291, 80);
            label13.Name = "label13";
            label13.Size = new Size(101, 21);
            label13.TabIndex = 10;
            label13.Text = "UnitAmount";
            // 
            // txtsldetil
            // 
            txtsldetil.BackColor = SystemColors.Window;
            txtsldetil.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtsldetil.Location = new Point(101, 74);
            txtsldetil.Name = "txtsldetil";
            txtsldetil.Size = new Size(184, 33);
            txtsldetil.TabIndex = 9;
            // 
            // txtitemid
            // 
            txtitemid.BackColor = SystemColors.Window;
            txtitemid.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtitemid.Location = new Point(492, 32);
            txtitemid.Name = "txtitemid";
            txtitemid.Size = new Size(162, 33);
            txtitemid.TabIndex = 8;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(419, 37);
            label12.Name = "label12";
            label12.Size = new Size(62, 21);
            label12.TabIndex = 7;
            label12.Text = "ItemID";
            // 
            // grd4
            // 
            grd4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grd4.Location = new Point(112, 125);
            grd4.Name = "grd4";
            grd4.RowTemplate.Height = 25;
            grd4.Size = new Size(542, 140);
            grd4.TabIndex = 6;
            grd4.CellContentClick += grd4_CellContentClick;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(11, 79);
            label6.Name = "label6";
            label6.Size = new Size(73, 21);
            label6.TabIndex = 5;
            label6.Text = "Quantity";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(193, 37);
            label7.Name = "label7";
            label7.Size = new Size(73, 21);
            label7.TabIndex = 3;
            label7.Text = "OrderID";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(11, 37);
            label8.Name = "label8";
            label8.Size = new Size(29, 21);
            label8.TabIndex = 2;
            label8.Text = "ID";
            // 
            // txtorderdetail
            // 
            txtorderdetail.BackColor = SystemColors.Window;
            txtorderdetail.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtorderdetail.Location = new Point(278, 29);
            txtorderdetail.Name = "txtorderdetail";
            txtorderdetail.Size = new Size(135, 33);
            txtorderdetail.TabIndex = 1;
            // 
            // txtiddetail
            // 
            txtiddetail.BackColor = SystemColors.Window;
            txtiddetail.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtiddetail.Location = new Point(47, 29);
            txtiddetail.Name = "txtiddetail";
            txtiddetail.Size = new Size(135, 33);
            txtiddetail.TabIndex = 0;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(1370, 625);
            ControlBox = false;
            Controls.Add(bill);
            Controls.Add(groupBox4);
            Controls.Add(button6);
            Controls.Add(button8);
            Controls.Add(button5);
            Controls.Add(button7);
            Controls.Add(groupBox2);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Margin = new Padding(2);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)grd1).EndInit();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grd3).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grd2).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grd4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView grd1;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private GroupBox groupBox5;
        private Label label2;
        private Label label1;
        private TextBox txttensp;
        private TextBox txtidsp;
        private GroupBox groupBox2;
        private Button button6;
        private Button button5;
        private GroupBox groupBox3;
        private Label label15;
        private TextBox txtgiasp;
        private Label label14;
        private TextBox txtslsp;
        private DataGridView grd2;
        private Button button7;
        private Button button8;
        private DataGridView grd3;
        private Label label5;
        private DateTimePicker dtp;
        private Label label4;
        private Label label3;
        private TextBox txtagent;
        private TextBox txtidoder;
        private Label label11;
        private Button button10;
        private Label label9;
        private TextBox txtidagent;
        private Label label10;
        private Button button12;
        private Button button13;
        private TextBox txtnameagent;
        private Button button11;
        private TextBox txtaddress;
        private GroupBox groupBox4;
        private TextBox txtamountdetail;
        private Label label13;
        private TextBox txtsldetil;
        private TextBox txtitemid;
        private Label label12;
        private DataGridView grd4;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtorderdetail;
        private TextBox txtiddetail;
        private RichTextBox bill;
        private Button button16;
        private Button button15;
        private Button button14;
        private Button button9;
        private Button button20;
        private Button button19;
        private Button button18;
        private Button button17;
    }
}