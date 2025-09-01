using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Psychic_train_terry_was_right
{
    public partial class AddBooks : Form
    {
        public AddBooks()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //check if price and quantity are numbers
            if(!System.Text.RegularExpressions.Regex.IsMatch(txtPrice.Text, "^[0-9]*$"))
            {
                MessageBox.Show("Please enter only numbers for price", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrice.Clear();
                txtPrice.Focus();
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(txtQuantity.Text, "^[0-9]*$"))
            {
                MessageBox.Show("Please enter only numbers for quantity", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtQuantity.Clear();
                txtQuantity.Focus();
            }
            //check if any field is empty
            if (txtBookName.Text != "" && txtAuthor.Text != "" && txtPublication.Text != "" && txtPrice.Text != "" && txtQuantity.Text != "")
            {


                String bname = txtBookName.Text;
                String bauthor = txtPublication.Text;
                String publication = txtAuthor.Text;
                String pdate = dateTimePicker1.Text;
                Int64 price = Int64.Parse(txtPrice.Text);
                Int64 quan = Int64.Parse(txtQuantity.Text);

                //Should have used LinkedLists, but too late now
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = (localdb)\\booktool; database = library; integrated security = True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                //Inserts the values into the database
                con.Open();
                cmd.CommandText = "insert into NewBook (bName,bAuthor,bPubl,bPDate,bPrice,bQuan) values ('" + bname + "','" + bauthor + "','" + publication + "','" + pdate + "'," + price + "," + quan + ")";
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Data Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBookName.Clear();
                txtAuthor.Clear();
                txtPublication.Clear();
                txtPrice.Clear();
                txtQuantity.Clear();
            }
            else
            {
                MessageBox.Show("Please fill all the fields!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("This will DELETE your unsaved data.", "Are you Sure?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
            
        }
    }
}
