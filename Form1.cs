using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-HU8DLR9F;Initial Catalog=Project;Integrated Security=True");
        

        //Insert Method
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string status = "";
                if (radioButton1.Checked == true)
                {
                    status = radioButton1.Text;
                }
                else
                {
                    status = radioButton2.Text;
                }
                DateTime expDate;
                if (DateTime.TryParse(ExpDate.Text, out expDate))
                {
                    SqlCommand com = new SqlCommand("exec dbo.SP_Task_Insert '" + int.Parse(textBox1.Text) + "','" + textBox2.Text + "','" + comboBox1.Text + "','" + status + "','" + expDate.ToString("yyyy-MM-dd") + "'", con);
                    com.ExecuteNonQuery();
                    MessageBox.Show("Successfully Saved");
                    LoadAllRecords();
                    clear();
                }
                else
                {
                    MessageBox.Show("Invalid date format");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }

        }
        void LoadAllRecords()
        {

            SqlCommand com = new SqlCommand("exec dbo.SP_Task_View", con);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        // The purpose of this code seems to be to initialize the form by loading some data and populating controls.
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadAllRecords();
        }
        // update method
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string status = "";
                if (radioButton1.Checked == true)
                {
                    status = radioButton1.Text;
                }
                else
                {
                    status = radioButton2.Text;
                }
                DateTime expDate;
                if (DateTime.TryParse(ExpDate.Text, out expDate))
                {
                    SqlCommand com = new SqlCommand("exec dbo.SP_Task_Update '" + int.Parse(textBox1.Text) + "','" + textBox2.Text + "','" + comboBox1.Text + "','" + status + "','" + expDate.ToString("yyyy-MM-dd") + "'", con);
                    com.ExecuteNonQuery();
                    MessageBox.Show("Successfully Updated");
                    LoadAllRecords();
                    clear();
                }
                else
                {
                    MessageBox.Show("Invalid date format");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }


           
        }
        

        // Delete Method
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand("exec dbo.SP_Task_Delete '" + int.Parse(textBox1.Text) + "'", con);
                com.ExecuteNonQuery();
                MessageBox.Show("Successfully Deleted");
                LoadAllRecords();
                clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }




        }


        // Search button
        private void button4_Click(object sender, EventArgs e)
        {
            
            try
            {
                SqlCommand com = new SqlCommand("exec dbo.SP_Task_Search '" + int.Parse(textBox1.Text) + "'", con);
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }



        }
        void clear()
           {
               textBox1.Text = textBox2.Text = comboBox1.Text = ExpDate.Text = "";
               button1.Text = "save";
               button3.Enabled = false;
               //icon.taskid = 0;
          }
        }
    

}