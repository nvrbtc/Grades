using PROG_PROJECT.ProjectClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROG_PROJECT
{
    public partial class Form1 : Form
    {
        enum Lang{
            ENG, 
            PL
        }
        public string[] nameTxt = new string[2] { "Name", "Imie" };
        public string[] gradeTxt = new string[2] { "Grade", "Ocena" };
        public string[] addBt = new string[2] { "Add", "Dodac" };
        public string[] updateBt = new string[2] { "Update", "Odswiezyc" };
        public string[] deleteBt = new string[2] { "Delete", "Ususnac" };
        public Form1()
        {
            InitializeComponent();
            this.BackColor = SystemColors.Window;
            btAdd.MouseEnter += OnMouseEnterBt; 
            btAdd.MouseLeave += OnMouseLeaveBt;
            btCheck.MouseEnter += OnMouseEnterBt;
            btCheck.MouseLeave += OnMouseLeaveBt;
            button1.MouseEnter += OnMouseEnterBt;
            button1.MouseLeave += OnMouseLeaveBt;
            btDelete.MouseEnter += OnMouseEnterBt1;
            btDelete.MouseLeave += OnMouseLeaveBt1;
            btPl.MouseEnter += btLang_Hower;
            btEng.MouseEnter += btLang_Hower;
            btPl.MouseLeave += btLang_HowerLeave;
            btEng.MouseLeave += btLang_HowerLeave;
        }

       

        private void OnMouseEnterBt(object sender, EventArgs e)
        {
            Button tb = sender as Button;
            tb.BackColor = Color.Green; // or Color.Red or whatever you want
            tb.ForeColor = Color.Blue; 
        }
        private void OnMouseLeaveBt(object sender, EventArgs e)
        {
            Button tb = sender as Button;
            tb.BackColor = SystemColors.Control; // or Color.Red or whatever you want
            tb.ForeColor = Color.Black;
        }
        private void OnMouseEnterBt1(object sender, EventArgs e)
        {
            Button tb = sender as Button;
            tb.BackColor = Color.Red; // or Color.Red or whatever you want
            tb.ForeColor = Color.White;
        }
        private void OnMouseLeaveBt1(object sender, EventArgs e)
        {
            Button tb = sender as Button;
            tb.BackColor = SystemColors.Control; // or Color.Red or whatever you want
            tb.ForeColor = Color.Black;
        }

        private void OnMouseLeaveButton1(object sender, EventArgs e)
        {
            button1.BackColor = SystemColors.ButtonFace;
        }
        grade c = new grade(); 

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            c.Name = txtName.Text; 
            c.Grade = Convert.ToInt32(txtGrade.Text);
            bool succes = c.Insert(c);
            if (succes == true )
            {
                MessageBox.Show("Insert Succeded.");
                Clear();
            }
            else
            {
                MessageBox.Show("Try again.");
            }
            DataTable dt = c.Select();
            //dgvContactList.DataSource = dt;
            dvgGradeList.DataSource = dt;
        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void btCheck_Click(object sender, EventArgs e)
        {
            if (int.Parse(txtID.Text).Equals(0) || txtName.Text.Equals(null) || Convert.ToInt32(txtGrade.Text).Equals(0))
            {
                MessageBox.Show("Data not set.");
                return;
            }
            c.Id = int.Parse(txtID.Text);
            c.Name = txtName.Text;
            c.Grade = Convert.ToInt32(txtGrade.Text);
            if (c.Grade > 100)
            {
                MessageBox.Show("Grade is over 100 pts ( maximum ).");
                return;
            }
            bool succes = c.Update(c);
            if ( succes == true )
            {
                MessageBox.Show("Update Succeded.");
                Clear(); 
            }
            else
            {
                MessageBox.Show("Update Failed."); 

            }
            DataTable dt = c.Select(); 
            dvgGradeList.DataSource = dt;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable dt = c.Select();
            dvgGradeList.DataSource = dt; 

        }
        public void Clear()
        {
            txtGrade.Text = "";
            txtName.Text = "";
            txtID.Text = "";

        }
        private void dvgGrade_RowHeaderMouseClick ( object sender , DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex; 
            txtGrade.Text = dvgGradeList.Rows[rowIndex].Cells[2].Value.ToString();
            txtName.Text = dvgGradeList.Rows[rowIndex].Cells[1].Value.ToString();
            txtID.Text = dvgGradeList.Rows[rowIndex].Cells[0].Value.ToString();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if ( txtName.Text.Equals(null) || Convert.ToInt32(txtGrade.Text).Equals(0))
            {
                MessageBox.Show("Data not set.");
                return;
            }
            c.Id = int.Parse(txtID.Text);
            c.Name = txtName.Text;
            c.Grade = Convert.ToInt32(txtGrade.Text) + 1;

            if ( c.Grade > 100)
            {
                MessageBox.Show("Grade is over 100 pts ( maximum ).");
                return; 
            }
            bool succes = c.Update(c);
            if (succes == true)
            {
                MessageBox.Show("+ 1 punkt to " + c.Name + ".");
                
            }
            else
            {
                MessageBox.Show("Update Failed.");

            }
            DataTable dt = c.Select();
            dvgGradeList.DataSource = dt;
           
    }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (int.Parse(txtID.Text).Equals(0) || txtName.Text.Equals(null) || Convert.ToInt32(txtGrade.Text).Equals(0))
            {
                MessageBox.Show("Data not set.");
                return;
            }
            c.Id = int.Parse(txtID.Text);
            bool succes = c.Delete(c);
            if ( succes == true)
            {
                MessageBox.Show("Deleted succesfully.");
                Clear();
                
            }
            else
            {
                MessageBox.Show("Went wrong."); 
            }
            DataTable dt = c.Select();

            
            dvgGradeList.DataSource = dt;

        }

        private void lblID_Click(object sender, EventArgs e)
        {

        }

        private void btEng_Click(object sender, EventArgs e)
        {
            lblGrade.Text = gradeTxt[Convert.ToInt32(Lang.ENG)];
            lblName.Text = nameTxt[Convert.ToInt32(Lang.ENG)];
            btAdd.Text = addBt[Convert.ToInt32(Lang.ENG)];
            btCheck.Text = updateBt[Convert.ToInt32(Lang.ENG)];
            btDelete.Text = deleteBt[Convert.ToInt32(Lang.ENG)];
        }

        private void btPl_Click(object sender, EventArgs e)
        {
            lblGrade.Text = gradeTxt[Convert.ToInt32(Lang.PL)];
            lblName.Text = nameTxt[Convert.ToInt32(Lang.PL)];
            btAdd.Text = addBt[Convert.ToInt32(Lang.PL)];
            btCheck.Text = updateBt[Convert.ToInt32(Lang.PL)];
            btDelete.Text = deleteBt[Convert.ToInt32(Lang.PL)];
        }
        private void btLang_Hower ( object sender, EventArgs e)
        {
            Button temp = sender as Button;
            temp.BackColor = Color.Black;
            temp.ForeColor = Color.White;
        }

        private void btLang_HowerLeave(object sender, EventArgs e)
        {
            Button temp = sender as Button;
            temp.BackColor = SystemColors.Control;
            temp.ForeColor = Color.Black;
        }



    }
}
