using System.Data;

using System.Data.SqlClient;


namespace ex1
{
    public partial class Form2 : Form
    {
        SqlConnection cn;

        SqlDataAdapter data;

        SqlCommand cm;

        DataTable tb;

        int dk = 0;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string sql = "initial catalog = creditTask; data source = ACERLT; integrated security = true";

            cn = new SqlConnection(sql);
            cn.Open();

            formload();
        }

        void formload()
        {
            enable(txtidoder, false);
            enable(txtagent, false);
            enable(txtidagent, false);
            enable(txtnameagent, false);
            enable(txtaddress, false);
            enable(txtiddetail, false);
            enable(txtorderdetail, false);
            enable(txtitemid, false);
            enable(txtsldetil, false);
            enable(txtamountdetail, false);

            enable(dtp, false);

            button1.Enabled = true;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button9.Enabled = true;
            button14.Enabled = false;
            button15.Enabled = false;
            button16.Enabled = false;
            button10.Enabled = true;
            button11.Enabled = false;
            button12.Enabled = false;
            button13.Enabled = false;
            button17.Enabled = true;
            button18.Enabled = false;
            button19.Enabled = false;
            button20.Enabled = false;

            htGRD1();
            htGRD2();
            htGRD3();
            htGRD4();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to delete?", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string sql = "delete from item where Ma ='" + txttensp.Text + "'";
                cm = new SqlCommand(sql, cn);
                cm.ExecuteNonQuery();
                formload();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            enable(groupBox5, true);
            txtidsp.Enabled = false;
            txttensp.Focus();
            button4.Enabled = true;
            dk = 2;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dk == 1)
            {
                string s = "select * from item where Ma = '" + txtidsp.Text + "' ";
                data = new SqlDataAdapter(s, cn);
                tb = new DataTable();
                data.Fill(tb);
                if (tb.Rows.Count > 0)
                {
                    MessageBox.Show("Item exists");
                    return;
                }
                s = "insert into item values ('" + txtidsp.Text + "','" + txttensp.Text + "','" + txtslsp.Text + "','" + txtgiasp.Text + "')";
                cm = new SqlCommand(s, cn);
                cm.ExecuteNonQuery();
            }
            else //dk =2
            {
                //Update
                string s = "update item set Ten = '" + txttensp.Text + "', soluong = '" + txtslsp.Text + "', gia = '" + txtgiasp.Text + "' where Ma = '" + txtidsp.Text + "'";
                cm = new SqlCommand(s, cn);
                cm.ExecuteNonQuery();
            }
            formload();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            enable(groupBox5, true);

            txtidsp.Clear();

            txttensp.Clear();

            txtslsp.Clear();

            txtgiasp.Clear();




            txtidsp.Focus();

            dk = 1;



            button4.Enabled = true;
        }

        void enable(GroupBox g, bool b)

        {

            g.Enabled = b;

        }

        void enable(TextBox g, bool b)

        {

            g.Enabled = b;

        }

        void enable(DateTimePicker g, bool b)

        {

            g.Enabled = b;

        }


        void htGRD1()
        {
            string s = "select * from item";

            data = new SqlDataAdapter(s, cn);

            tb = new DataTable();

            data.Fill(tb);

            grd1.DataSource = tb;

        }

        void htGRD2()

        {

            string s = "select * from Agent";

            data = new SqlDataAdapter(s, cn);

            tb = new DataTable();

            data.Fill(tb);

            grd2.DataSource = tb;

        }

        void htGRD3()

        {

            string s = "select * from Orders";

            data = new SqlDataAdapter(s, cn);

            tb = new DataTable();

            data.Fill(tb);

            grd3.DataSource = tb;

        }

        void htGRD4()

        {

            string s = "select * from order_Detail";

            data = new SqlDataAdapter(s, cn);

            tb = new DataTable();

            data.Fill(tb);

            grd4.DataSource = tb;

        }

        private void grd1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtidsp.Text = grd1.CurrentRow.Cells[1].Value.ToString();
            txttensp.Text = grd1.CurrentRow.Cells[2].Value.ToString();
            txtslsp.Text = grd1.CurrentRow.Cells[3].Value.ToString();
            txtgiasp.Text = grd1.CurrentRow.Cells[4].Value.ToString();

            button2.Enabled = true;
            button3.Enabled = true;
        }

        //Order ------------------------------------------------------------------------------------
        private void button9_Click(object sender, EventArgs e)
        {
            enable(txtidoder, true);
            enable(txtagent, true);
            enable(dtp, true);

            txtidoder.Clear();

            txtagent.Clear();


            txtidoder.Focus();

            dk = 1;



            button16.Enabled = true;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to delete?", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string sql = "delete from Order where orderId ='" + txtidoder.Text + "'";
                cm = new SqlCommand(sql, cn);
                cm.ExecuteNonQuery();
                formload();
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            enable(txtagent, true);
            txtidoder.Enabled = false;
            dtp.Enabled = true;

            txtagent.Focus();
            button16.Enabled = true;
            dk = 2;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (dk == 1)
            {
                string s = "select * from Orders where orderId = '" + txtidoder.Text + "' ";
                data = new SqlDataAdapter(s, cn);
                tb = new DataTable();
                data.Fill(tb);
                if (tb.Rows.Count > 0)
                {
                    MessageBox.Show("Order exists");
                    return;
                }
                s = "insert into item values ('" + txtidoder.Text + "','" + txtagent.Text + "','" + dtp.Value.ToShortDateString() + "')";
                cm = new SqlCommand(s, cn);
                cm.ExecuteNonQuery();
            }
            else //dk =2
            {
                //Update
                string s = "update Orders set agentID = '" + txtagent.Text + "', orderDate = '" + dtp.Value.ToShortDateString() + "' where orderId = '" + txtidoder.Text + "'";
                cm = new SqlCommand(s, cn);
                cm.ExecuteNonQuery();
            }
            formload();
        }

        //Detail 
        private void button17_Click(object sender, EventArgs e)
        {
            enable(txtiddetail, true);
            enable(txtorderdetail, true);
            enable(txtitemid, true);
            enable(txtsldetil, true);
            enable(txtamountdetail, true);

            txtiddetail.Clear();

            txtorderdetail.Clear();

            txtitemid.Clear();

            txtsldetil.Clear();

            txtamountdetail.Clear();


            txtiddetail.Focus();

            dk = 1;

            button20.Enabled = true;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to delete?", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string sql = "delete from order_Detail where id ='" + txtiddetail.Text + "'";
                cm = new SqlCommand(sql, cn);
                cm.ExecuteNonQuery();
                formload();
            }
        }


        private void button19_Click(object sender, EventArgs e)
        {
            enable(txtorderdetail, true);
            enable(txtitemid, true);
            enable(txtsldetil, true);
            enable(txtamountdetail, true);

            txtiddetail.Enabled = false;

            txtorderdetail.Focus();

            button20.Enabled = true;
            dk = 2;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (dk == 1)
            {
                string s = "select * from order_Detail where id = '" + txtiddetail.Text + "' ";
                data = new SqlDataAdapter(s, cn);
                tb = new DataTable();
                data.Fill(tb);
                if (tb.Rows.Count > 0)
                {
                    MessageBox.Show("Orser detail exists");
                    return;
                }
                s = "insert into item values ('" + txtiddetail.Text + "','" + txtorderdetail.Text + "','" + txtitemid.Text + "','" + txtsldetil.Text + "','" + txtamountdetail.Text + "')";
                cm = new SqlCommand(s, cn);
                cm.ExecuteNonQuery();
            }
            else //dk =2
            {
                //Update
                string s = "update order_Detail set orderId = '" + txtorderdetail.Text + "', itemId = '" + txtitemid.Text + "', quantity = '" + txtsldetil.Text + "', unitAmount = '" + txtamountdetail.Text + "' where id = '" + txtiddetail.Text + "'";
                cm = new SqlCommand(s, cn);
                cm.ExecuteNonQuery();
            }
            formload();
        }
        //Agent add button
        private void button10_Click(object sender, EventArgs e)
        {
            enable(txtidagent, true);
            enable(txtnameagent, true);
            enable(txtaddress, true);

            txtidagent.Clear();

            txtnameagent.Clear();

            txtaddress.Clear();


            txtidagent.Focus();

            dk = 1;

            button13.Enabled = true;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to delete?", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string sql = "delete from Agent where agentId ='" + txtidagent.Text + "'";
                cm = new SqlCommand(sql, cn);
                cm.ExecuteNonQuery();
                formload();
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            enable(txtnameagent, true);
            enable(txtaddress, true);

            txtidagent.Enabled = false;

            txtnameagent.Focus();

            button13.Enabled = true;
            dk = 2;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (dk == 1)
            {
                string s = "select * from Agent where agentId = '" + txtidagent.Text + "' ";
                data = new SqlDataAdapter(s, cn);
                tb = new DataTable();
                data.Fill(tb);
                if (tb.Rows.Count > 0)
                {
                    MessageBox.Show("Agent exists");
                    return;
                }
                s = "insert into item values ('" + txtidagent.Text + "','" + txtnameagent.Text + "',''" + txtaddress.Text + "')";
                cm = new SqlCommand(s, cn);
                cm.ExecuteNonQuery();
            }
            else //dk =2
            {
                //Update
                string s = "update Agent set agentName = '" + txtnameagent.Text + "', address = '" + txtaddress.Text + "' where agentId = '" + txtidagent.Text + "'";
                cm = new SqlCommand(s, cn);
                cm.ExecuteNonQuery();
            }
            formload();
        }
        private void grd3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtidoder.Text = grd3.CurrentRow.Cells[1].Value.ToString();

            txtagent.Text = grd3.CurrentRow.Cells[2].Value.ToString();


            button14.Enabled = true;

            button15.Enabled = true;
        }

        private void grd2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtidagent.Text = grd2.CurrentRow.Cells[1].Value.ToString();

            txtnameagent.Text = grd2.CurrentRow.Cells[2].Value.ToString();

            txtaddress.Text = grd2.CurrentRow.Cells[3].Value.ToString();


            button11.Enabled = true;

            button12.Enabled = true;
        }

        private void grd4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtiddetail.Text = grd4.CurrentRow.Cells[1].Value.ToString();

            txtorderdetail.Text = grd4.CurrentRow.Cells[2].Value.ToString();

            txtitemid.Text = grd4.CurrentRow.Cells[3].Value.ToString();

            txtsldetil.Text = grd4.CurrentRow.Cells[4].Value.ToString();

            txtamountdetail.Text = grd4.CurrentRow.Cells[5].Value.ToString();



            button18.Enabled = true;
            button19.Enabled = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            bill.Clear();
            bill.Text += "***********************************************\n\n";
            bill.Text += "************         TICKET        ************\n\n";
            bill.Text += "***********************************************\n\n";
            bill.Text += "Date: " + DateTime.Now + "\n\n";

            bill.Text += "Order ID: " + txtorderdetail + "\n\n";
            bill.Text += "Item ID: " + txtitemid + "\n\n";
            bill.Text += "Quantity: " + txtsldetil + "\n\n";
            bill.Text += "UnitAmount: " + txtamountdetail + "\n\n";





            bill.Text += "**************************************************\n\n";
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(bill.Text, new Font("Microsoft Sans Serif", 18, FontStyle.Bold), Brushes.Black, new Point(10, 10));
        }

        private void grd1_Click(object sender, EventArgs e)
        {
            txtidsp.Text = grd1.CurrentRow.Cells[1].Value.ToString();
            txttensp.Text = grd1.CurrentRow.Cells[2].Value.ToString();
            txtslsp.Text = grd1.CurrentRow.Cells[3].Value.ToString();
            txtgiasp.Text = grd1.CurrentRow.Cells[4].Value.ToString();

            button2.Enabled = true;
            button3.Enabled = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
