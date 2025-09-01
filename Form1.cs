using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;



namespace Psychic_train_terry_was_right
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(
            object sender, EventArgs e)
        {
            this.Close();
        }


        private void txtUsername_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtUsername.Text == "Username (q)")
            {
                txtUsername.Clear();
            }
        }

        private void txtPassword_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtPassword.Text == "Password (q)")
            {
                txtPassword.Clear();
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            txtPassword.Clear();
            txtPassword.UseSystemPasswordChar = true;
        }

        private void picHint_MouseDown(object sender, MouseEventArgs e)
        {
            txtPassword.UseSystemPasswordChar = false;
        }
        //Password hint icon
        private void picHint_MouseUp(object sender, MouseEventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }
        //Fancy not so fancy links via default browser
        private void picInstagram_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://www.instagram.com/davidimenov/",
                UseShellExecute = true
            });
        }

        private void picGithub_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://github.com/vanakraj?tab=overview&from=2025-08-01&to=2025-08-31",
                UseShellExecute = true
            });
        }

        private void picLibrary_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "httpsc://www.mlp.cz/cz/",
                UseShellExecute = true
            });
        }

        /*There is BindingList and Linq libraries, short on time thought sql is easier, fucked up pretty badly
        I know this is not safe, but this is just a demo app, so I don't care about SQL Injection here
        System.data.sqlclient is obsolete, should have used Microsoft.data.sqlclient but short on time and meth
        */
        private void btnLogin_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = (localdb)\\booktool; database=library; integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            
            cmd.CommandText = "select * from loginTable where username = '" + txtUsername.Text + "' and pass = '" + txtPassword.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            if (ds.Tables[0].Rows.Count != 0)
            {
                this.Hide();
                Dashboard dsa = new Dashboard();
                dsa.Show();
            }
            else
            {
                MessageBox.Show("Wrong Username or Password!","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You either work in library, or you don't!\nSignup is hardcoded by meth devs.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
