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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        DBconnect dbCon = new DBconnect();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbRole.SelectedIndex > 0)
                {
                    //if (txtUsername.Text == String.Empty)
                    //{
                    //    MessageBox.Show("Please Enter valid UserName", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //    txtUsername.Focus();
                    //    return;
                    //}
                    //if (txtPassword.Text == String.Empty)
                    //{
                    //    MessageBox.Show("Please Enter valid Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //    txtPassword.Focus();
                    //    return;
                    //}

                    if (cmbRole.SelectedIndex > 0 && txtUsername.Text != String.Empty && txtPassword.Text != String.Empty)
                    {
                        //login code
                        if (cmbRole.Text == "Admin")
                        {
                            SqlCommand cmd = new SqlCommand("select top 1 AdminID,AdminPassword,FullName from tblAdmin where AdminID=@AdminID and AdminPassword=@AdminPassword", dbCon.GetCon());
                            cmd.Parameters.AddWithValue("@AdminID", txtUsername.Text);
                            cmd.Parameters.AddWithValue("@AdminPassword", txtPassword.Text);
                            dbCon.OpenCon();
                            SqlDataAdapter da = new SqlDataAdapter(cmd);
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            if (dt.Rows.Count > 0)
                            {
                                MessageBox.Show("Login Success Welcome to Home Page", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Hide();
                                Form2 fm = new Form2();
                                fm.Show();
                            }
                            else
                            {
                                MessageBox.Show("Invalid Login Please check userName and Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }


                        }
                        else if (cmbRole.Text == "User")
                        {
                            SqlCommand cmd = new SqlCommand("select top 1 UserID,UserPassword from tblUser where UserID=@UserID and UserPassword=@UserPassword", dbCon.GetCon());
                            cmd.Parameters.AddWithValue("@UserID", txtUsername.Text);
                            cmd.Parameters.AddWithValue("@UserPassword", txtPassword.Text);
                            dbCon.OpenCon();
                            SqlDataAdapter da = new SqlDataAdapter(cmd);
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            if (dt.Rows.Count > 0)
                            {
                                MessageBox.Show("Login Success Welcome to Home Page", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Hide();
                                Form2 fm = new Form2();
                                fm.Show();
                            }
                            else
                            {
                                MessageBox.Show("Invalid Login Please check userName and Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    else
                    {
                        //MessageBox.Show("Please Enter UserName or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        
                    }

                }
                else
                {
                    MessageBox.Show("Please select any role", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /*  private void btnLogin_Click(object sender, EventArgs e)
          {
              try
              {
                  if(cmbRole.SelectedIndex>0)
                  {
                      if (txtUsername.Text == String.Empty) { 
                          txtUsername.Focus();
                          return;
                      }
                      if (txtPassword.Text == string.Empty)
                      {
                       //log
                           txtPassword.Focus();
                           return;
                       }
                      else
                      {
                          MessageBox.Show("Please Enter Username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                      }
                   }
                  else
                  {
                      MessageBox.Show("Please Select any role","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                  }
              }
              catch(Exception ex)
              {
                  MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
              }
          }*/

        private void cmbRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
        }
    }
}
