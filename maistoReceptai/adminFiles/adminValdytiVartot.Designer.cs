
namespace maistoReceptai
{
    partial class adminValdytiVartot
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.vartotojaiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet3 = new maistoReceptai.Database1DataSet3();
            this.vartotojaiTableAdapter = new maistoReceptai.Database1DataSet3TableAdapters.VartotojaiTableAdapter();
            this.refreshAdminVartotBtn = new System.Windows.Forms.Button();
            this.removeAdminVartot = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.adminEditUser = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vartotojaiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(30, 183);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(920, 450);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // vartotojaiBindingSource
            // 
            this.vartotojaiBindingSource.DataMember = "Vartotojai";
            this.vartotojaiBindingSource.DataSource = this.database1DataSet3;
            // 
            // database1DataSet3
            // 
            this.database1DataSet3.DataSetName = "Database1DataSet3";
            this.database1DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vartotojaiTableAdapter
            // 
            this.vartotojaiTableAdapter.ClearBeforeFill = true;
            // 
            // refreshAdminVartotBtn
            // 
            this.refreshAdminVartotBtn.BackColor = System.Drawing.Color.MediumTurquoise;
            this.refreshAdminVartotBtn.Location = new System.Drawing.Point(242, 122);
            this.refreshAdminVartotBtn.Name = "refreshAdminVartotBtn";
            this.refreshAdminVartotBtn.Size = new System.Drawing.Size(134, 38);
            this.refreshAdminVartotBtn.TabIndex = 1;
            this.refreshAdminVartotBtn.Text = "Atnaujinti";
            this.refreshAdminVartotBtn.UseVisualStyleBackColor = false;
            this.refreshAdminVartotBtn.Click += new System.EventHandler(this.refreshAdminVartotBtn_Click);
            // 
            // removeAdminVartot
            // 
            this.removeAdminVartot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.removeAdminVartot.Location = new System.Drawing.Point(425, 122);
            this.removeAdminVartot.Name = "removeAdminVartot";
            this.removeAdminVartot.Size = new System.Drawing.Size(142, 38);
            this.removeAdminVartot.TabIndex = 2;
            this.removeAdminVartot.Text = "Panaikinti vartotoją";
            this.removeAdminVartot.UseVisualStyleBackColor = false;
            this.removeAdminVartot.Click += new System.EventHandler(this.removeAdminVartot_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(274, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = "Vartotojų valdymas";
            // 
            // adminEditUser
            // 
            this.adminEditUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.adminEditUser.Location = new System.Drawing.Point(615, 122);
            this.adminEditUser.Name = "adminEditUser";
            this.adminEditUser.Size = new System.Drawing.Size(156, 38);
            this.adminEditUser.TabIndex = 19;
            this.adminEditUser.Text = "Koreguoti vartotoją\r\n";
            this.adminEditUser.UseVisualStyleBackColor = false;
            this.adminEditUser.Click += new System.EventHandler(this.adminEditUser_Click);
            // 
            // adminValdytiVartot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.adminEditUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.removeAdminVartot);
            this.Controls.Add(this.refreshAdminVartotBtn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "adminValdytiVartot";
            this.Size = new System.Drawing.Size(1001, 662);
            this.Load += new System.EventHandler(this.adminValdytiVartot_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vartotojaiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource vartotojaiBindingSource;
        private Database1DataSet3 database1DataSet3;
        private Database1DataSet3TableAdapters.VartotojaiTableAdapter vartotojaiTableAdapter;
        private System.Windows.Forms.Button refreshAdminVartotBtn;
        private System.Windows.Forms.Button removeAdminVartot;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button adminEditUser;
    }
}
