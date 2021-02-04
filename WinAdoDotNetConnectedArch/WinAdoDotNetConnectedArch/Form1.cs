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
using System.Configuration;

namespace WinAdoDotNetConnectedArch
{
    public partial class Form1 : Form
    {
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings[1].ToString());
        SqlCommand cmd = null;
        SqlDataReader dr = null;
        DataTable dt = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            lblMName.Visible = true;
            lblTicketsSold.Visible =true;
            lblActor.Visible = true;
            lblvalueActor.Visible = true;
            lblvalueMName.Visible = true;
            lblvalueTicketsSold.Visible = true;
            try
            {
                using (cmd = new SqlCommand("sp_ShowMovie", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@movieId", SqlDbType.Int).Value = txtEnterMId.Text;
                    cn.Open();
                    dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                    if (dr.HasRows && dr.Read())
                    {
                        lblvalueMName.Text = dr["MovieName"].ToString();
                        lblvalueActor.Text = dr["Actor"].ToString();
                        lblvalueTicketsSold.Text = dr["Tickets"].ToString();
                    }
                        
                    dr.Close();
                    cn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ShowMovieDetails()
        {
            
            using (cmd = new SqlCommand("Select * from MovieTable", cn))
            {
                cn.Open();
                dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                dt = new DataTable();
                dt.Load(dr);
                dataGridView1.DataSource = dt;
                dr.Close();
                cn.Close();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            lblMName.Visible = false;
            lblTicketsSold.Visible = false;
            lblActor.Visible = false;
           
            ShowMovieDetails();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                using (cmd = new SqlCommand("sp_UpdateMovieDetails", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@movieId", SqlDbType.Int).Value = txtMId.Text;
                    cmd.Parameters.Add("@mName", SqlDbType.VarChar, 20).Value = txtMName.Text;
                    cmd.Parameters.Add("@actor", SqlDbType.VarChar,20).Value = txtActor.Text;
                    cmd.Parameters.Add("@tickets", SqlDbType.Int).Value = txtTicketsSold.Text;
                    cn.Open();
                    int i = cmd.ExecuteNonQuery();
                    MessageBox.Show("MovieDetails Updated");
                    cn.Close();
                    ShowMovieDetails();

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnShowOnlyMName_Click(object sender, EventArgs e)
        {
            lblMName.Visible = true;
            lblActor.Visible = false;
            lblTicketsSold.Visible = false;
            lblvalueActor.Visible = false;
            lblvalueTicketsSold.Visible = false;
            try
            {
                using (cmd = new SqlCommand("sp_ShowOnlyMName", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@movieId", SqlDbType.Int).Value = txtEnterMId.Text;
                    cn.Open();
                    object result= cmd.ExecuteScalar();
                    lblvalueMName.Text = result.ToString();
                    cn.Close();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
