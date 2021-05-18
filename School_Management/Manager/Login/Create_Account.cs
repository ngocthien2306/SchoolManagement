using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using DevExpress.XtraBars.Docking2010;

namespace School_Management.Manager.Login
{
    public partial class Create_Account : DevExpress.XtraEditors.XtraForm
    {
        public Create_Account()
        {
            InitializeComponent();
        }

        private void Create_Account_Load(object sender, EventArgs e)
        {

        }
        public bool ChechBox()
        {
            if (ID_tb.Text.Trim() == "" || First_tb.Text.Trim() == "" 
                || Last_tb.Text.Trim() == "" || User_tb.Text.Trim() == "" 
                || Pass_tb.Text.Trim() == "" || RePass_tb.Text.Trim() == "" )
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Insert_User()
        {
            Users user = new Users();
            if(this.ChechBox())
            {

                MessageBox.Show("The textboxs are blank, please enter again!", "Add User", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int id = Convert.ToInt32(ID_tb.Text);
                string fname = First_tb.Text;
                string lname = Last_tb.Text;
                string uname = User_tb.Text;
                string pass = Pass_tb.Text;
                MemoryStream pic = new MemoryStream();
                PictureUser.Image.Save(pic, PictureUser.Image.RawFormat);
                string role = CheckedComboBox_Role.SelectedText.ToString();
                if (user.Insert_User(id, fname, lname, uname, pass, pic, role))
                {
                    MessageBox.Show("Add new user successful!", "Add User", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Add failed!", "Add User", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            
        }

        private void PictureUser_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.pnq;*.gif";
            if (open.ShowDialog() == DialogResult.OK)
            {
                PictureUser.Image = Image.FromFile(open.FileName);
            }
        }

        private void WindowsUIButtonPanel_ButtonChecked(object sender, ButtonEventArgs e)
        {
            string tag = ((WindowsUIButton)e.Button).Tag.ToString();
            switch (tag)
            {
                case "A1":
                    this.Insert_User();
                    break;
                case "A2":
                    this.Hide();
                    Create_Account add = new Create_Account();
                    add.Show();
                    
                    break;
                case "A3":
                    DialogResult exit = XtraMessageBox.Show("Do you want to close program?", "Close Program", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (exit == DialogResult.Yes)
                    {
                        this.Hide();
                    }
                    else
                    {

                    }
                    break;
            }
        }

        private void WindowsUIButtonPanel_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void CheckedComboBox_Role_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void hyperlinkLabelControl1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login_Account login = new Login_Account();
            login.ShowDialog();
        }
    }
}