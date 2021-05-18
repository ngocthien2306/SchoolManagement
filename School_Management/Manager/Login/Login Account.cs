using DevExpress.XtraEditors;
using School_Management.Manager.Student;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using School_Management.Manager.Contact;
using System.Data.SqlClient;
using System.IO;

namespace School_Management.Manager.Login
{
    public partial class Login_Account : DevExpress.XtraEditors.XtraForm
    {
        public Login_Account()
        {
            InitializeComponent();
        }
        
        public void GetImageIDUser()
        {
            Contacts contact = new Contacts();
            My_Database data = new My_Database();
            SqlDataAdapter SDA = new SqlDataAdapter();
            DataTable table = new DataTable();
            SqlCommand commnand = new SqlCommand("SELECT * FROM New_User WHERE Id = @id", data.GetConnection);
            commnand.Parameters.Add("@id", SqlDbType.Int).Value = Globals.GlobalsUserID;
            SDA.SelectCommand = commnand;
            SDA.Fill(table);
            if(table.Rows.Count > 0)
            {
                byte[] pic = (byte[])table.Rows[0]["picture"];
                MemoryStream picture = new MemoryStream(pic);
                contact.Picture_User.Image = Image.FromStream(picture);
                contact.Wellcome_LabelControl.Text = "Wellcome back " + table.Rows[0]["firstname"].ToString() +
                    " with username: " + table.Rows[0]["username"].ToString();
            }
        }

        public string Role()
        {
            string role = "";
            Users user = new Users();
            My_Database data = new My_Database();
            SqlCommand command = new SqlCommand("SELECT Id, firstname, lastname, username, password, picture, role FROM New_User WHERE username = @name AND password = @pass", data.GetConnection);
            command.Parameters.Add("@name", SqlDbType.NVarChar).Value = User_tb.Text;
            command.Parameters.Add("@pass", SqlDbType.NVarChar).Value = Pass_tb.Text;
            data.Openconnection();
            DataTable table = user.GetUser(command);
            if(table.Rows.Count > 0)
            {
                
                SqlDataAdapter SDA = new SqlDataAdapter();
                SDA.SelectCommand = command;
                DataSet set = new DataSet();
                SDA.Fill(set, "New_User");
                data.Closeconnection();       
                role = table.Rows[0]["role"].ToString().Trim();              
                return role;
            }
            else
            {
                return role = "";
            }
        }

        private void Login_bt_Click_1(object sender, EventArgs e)
        {
            try
            
            {
                string user = User_tb.Text;
                string pass = Pass_tb.Text;
                Users users = new Users();
                if (users.Login(user, pass))
                {
                    
                    if (RadioButton_Teacher.Checked == true && this.Role() == "Teacher")
                    {
                        this.LoadImageTeacher();
                        this.Hide();

                    }
                    else if (Radio_human.Checked == true && this.Role().ToString() == "Manager")
                    {

                        this.LoadImageManager();
                        this.Hide();
                    }
                    else if (Radio_Student.Checked == true && this.Role().ToString() == "Student")
                    {

                    }
                    else
                    {
                        XtraMessageBox.Show("Plase choose again role login!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    XtraMessageBox.Show("Login failed, your name or pass incorrect!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    User_tb.Text = "";
                    Pass_tb.Text = "";
                }
            }
            catch (Exception)
            {
                XtraMessageBox.Show("Error", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void User_tb_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void Pass_tb_EditValueChanged(object sender, EventArgs e)
        {

        }


        private void Link_account_Click(object sender, EventArgs e)
        {
            Create_Account create = new Create_Account();
            create.ShowDialog();
        }

        private void Exit_bt_Click(object sender, EventArgs e)
        {
            DialogResult exit = XtraMessageBox.Show("Do you want to close program?", "Close Program", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (exit == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {

            }
        }

        private void Radio_Student_CheckedChanged(object sender, EventArgs e)
        {
            Radio_human.Checked = false;
            RadioButton_Teacher.Checked = false;
        }

        private void Radio_human_CheckedChanged(object sender, EventArgs e)
        {
            Radio_Student.Checked = false;
            RadioButton_Teacher.Checked = false;
        }

        private void Login_Account_Load(object sender, EventArgs e)
        { 
            Radio_Student.Checked = true;
           
        }

        private void RadioButton_Teacher_CheckedChanged(object sender, EventArgs e)
        {
            Radio_Student.Checked = false;
            Radio_human.Checked = false;
        }
        public void LoadImageTeacher()
        {
            Manager_Student manager = new Manager_Student();
            Users user = new Users();
            My_Database data = new My_Database();
            SqlCommand command = new SqlCommand("SELECT Id, firstname, lastname, username, password, picture, role FROM New_User WHERE username = @name AND password = @pass", data.GetConnection);
            command.Parameters.Add("@name", SqlDbType.NVarChar).Value = User_tb.Text;
            command.Parameters.Add("@pass", SqlDbType.NVarChar).Value = Pass_tb.Text;
            data.Openconnection();
            DataTable table = user.GetUser(command);
            if (table.Rows.Count > 0)
            {
                SqlDataAdapter SDA = new SqlDataAdapter();
                SDA.SelectCommand = command;
                DataSet set = new DataSet();
                SDA.Fill(set, "New_User");
                data.Closeconnection();
                byte[] pic1 = (byte[])table.Rows[0]["picture"];
                MemoryStream picture1 = new MemoryStream(pic1);
                manager.Picture_user.Image = Image.FromStream(picture1);
                manager.Label_Status.Text = "Wellcome back " + table.Rows[0]["firstname"].ToString().Trim();
                manager.Show();
            }
        }
        public void LoadImageManager()
        {
            Contacts contact = new Contacts();
            Users user = new Users();
            My_Database data = new My_Database();
            SqlCommand command = new SqlCommand("SELECT Id, firstname, lastname, username, password, picture, role FROM New_User WHERE username = @name AND password = @pass", data.GetConnection);
            command.Parameters.Add("@name", SqlDbType.NVarChar).Value = User_tb.Text;
            command.Parameters.Add("@pass", SqlDbType.NVarChar).Value = Pass_tb.Text;
            data.Openconnection();
            DataTable table = user.GetUser(command);
            if (table.Rows.Count > 0)
            {
                SqlDataAdapter SDA = new SqlDataAdapter();
                SDA.SelectCommand = command;
                DataSet set = new DataSet();
                SDA.Fill(set, "New_User");
                data.Closeconnection();
                byte[] pic1 = (byte[])table.Rows[0]["picture"];
                MemoryStream picture1 = new MemoryStream(pic1);
                contact.Picture_User.Image = Image.FromStream(picture1);
                contact.Wellcome_LabelControl.Text = "Wellcome back " + table.Rows[0]["firstname"].ToString().Trim() +
                    " with username: " + table.Rows[0]["username"].ToString();
                contact.LabelControl_ID.Text = table.Rows[0]["Id"].ToString();
                contact.Show();
            }
        }
    }
}
