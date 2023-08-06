namespace PROG_PROJECT
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.btEng = new System.Windows.Forms.Button();
            this.btPl = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.btCheck = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.dvgGradeList = new System.Windows.Forms.DataGridView();
            this.lblGrade = new System.Windows.Forms.Label();
            this.txtGrade = new System.Windows.Forms.TextBox();
            this.btDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvgGradeList)).BeginInit();
            this.SuspendLayout();
            // 
            // btEng
            // 
            this.btEng.Location = new System.Drawing.Point(12, 12);
            this.btEng.Name = "btEng";
            this.btEng.Size = new System.Drawing.Size(51, 45);
            this.btEng.TabIndex = 0;
            this.btEng.Text = "ENG";
            this.btEng.UseVisualStyleBackColor = true;
            this.btEng.Click += new System.EventHandler(this.btEng_Click);
            // 
            // btPl
            // 
            this.btPl.Location = new System.Drawing.Point(69, 12);
            this.btPl.Name = "btPl";
            this.btPl.Size = new System.Drawing.Size(51, 45);
            this.btPl.TabIndex = 1;
            this.btPl.Text = "PL";
            this.btPl.UseVisualStyleBackColor = true;
            this.btPl.Click += new System.EventHandler(this.btPl_Click);
            // 
            // btAdd
            // 
            this.btAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btAdd.Location = new System.Drawing.Point(29, 358);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(114, 44);
            this.btAdd.TabIndex = 2;
            this.btAdd.Text = "Add";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btCheck
            // 
            this.btCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btCheck.Location = new System.Drawing.Point(230, 358);
            this.btCheck.Name = "btCheck";
            this.btCheck.Size = new System.Drawing.Size(114, 44);
            this.btCheck.TabIndex = 3;
            this.btCheck.Text = "Update";
            this.btCheck.UseVisualStyleBackColor = true;
            this.btCheck.Click += new System.EventHandler(this.btCheck_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(443, 358);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 44);
            this.button1.TabIndex = 4;
            this.button1.Text = "+1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(24, 186);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(44, 16);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Name";
            this.lblName.Click += new System.EventHandler(this.lblName_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(119, 180);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 22);
            this.txtName.TabIndex = 6;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(24, 113);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(39, 16);
            this.lblID.TabIndex = 7;
            this.lblID.Text = "Index";
            this.lblID.Click += new System.EventHandler(this.lblID_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(119, 107);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(100, 22);
            this.txtID.TabIndex = 8;
            // 
            // dvgGradeList
            // 
            this.dvgGradeList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dvgGradeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgGradeList.Location = new System.Drawing.Point(246, 55);
            this.dvgGradeList.Name = "dvgGradeList";
            this.dvgGradeList.RowHeadersWidth = 51;
            this.dvgGradeList.RowTemplate.Height = 24;
            this.dvgGradeList.Size = new System.Drawing.Size(542, 275);
            this.dvgGradeList.TabIndex = 9;
            this.dvgGradeList.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dvgGrade_RowHeaderMouseClick);
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.Location = new System.Drawing.Point(26, 263);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(45, 16);
            this.lblGrade.TabIndex = 12;
            this.lblGrade.Text = "Grade";
            this.lblGrade.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtGrade
            // 
            this.txtGrade.Location = new System.Drawing.Point(119, 257);
            this.txtGrade.Name = "txtGrade";
            this.txtGrade.Size = new System.Drawing.Size(100, 22);
            this.txtGrade.TabIndex = 13;
            // 
            // btDelete
            // 
            this.btDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btDelete.Location = new System.Drawing.Point(645, 358);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(114, 44);
            this.btDelete.TabIndex = 14;
            this.btDelete.Text = "Delete";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.txtGrade);
            this.Controls.Add(this.lblGrade);
            this.Controls.Add(this.dvgGradeList);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btCheck);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.btPl);
            this.Controls.Add(this.btEng);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgGradeList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btEng;
        private System.Windows.Forms.Button btPl;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btCheck;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.DataGridView dvgGradeList;
        private System.Windows.Forms.Label lblGrade;
        public System.Windows.Forms.TextBox txtName;
        public System.Windows.Forms.TextBox txtGrade;
        private System.Windows.Forms.Button btDelete;
    }
}

