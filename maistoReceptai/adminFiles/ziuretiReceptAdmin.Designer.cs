
namespace maistoReceptai
{
    partial class ziuretiReceptAdmin
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ziurRecAtn = new System.Windows.Forms.Button();
            this.ziurRecAdmDel = new System.Windows.Forms.Button();
            this.filterByTypeUsr = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.filterByIngred = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.filterByName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(251, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(379, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Žiūrėti receptus (Admin)";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 205);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(983, 502);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // ziurRecAtn
            // 
            this.ziurRecAtn.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ziurRecAtn.Location = new System.Drawing.Point(324, 69);
            this.ziurRecAtn.Name = "ziurRecAtn";
            this.ziurRecAtn.Size = new System.Drawing.Size(111, 53);
            this.ziurRecAtn.TabIndex = 4;
            this.ziurRecAtn.Text = "Atnaujinti sąrašą";
            this.ziurRecAtn.UseVisualStyleBackColor = false;
            this.ziurRecAtn.Click += new System.EventHandler(this.ziurRecAtn_Click);
            // 
            // ziurRecAdmDel
            // 
            this.ziurRecAdmDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ziurRecAdmDel.Location = new System.Drawing.Point(463, 69);
            this.ziurRecAdmDel.Name = "ziurRecAdmDel";
            this.ziurRecAdmDel.Size = new System.Drawing.Size(111, 53);
            this.ziurRecAdmDel.TabIndex = 5;
            this.ziurRecAdmDel.Text = "Panaikinti elementą";
            this.ziurRecAdmDel.UseVisualStyleBackColor = false;
            this.ziurRecAdmDel.Click += new System.EventHandler(this.ziurRecAdmDel_Click);
            // 
            // filterByTypeUsr
            // 
            this.filterByTypeUsr.FormattingEnabled = true;
            this.filterByTypeUsr.ItemHeight = 16;
            this.filterByTypeUsr.Items.AddRange(new object[] {
            "Vegetariškas",
            "Nevegetariškas"});
            this.filterByTypeUsr.Location = new System.Drawing.Point(592, 154);
            this.filterByTypeUsr.Name = "filterByTypeUsr";
            this.filterByTypeUsr.Size = new System.Drawing.Size(125, 36);
            this.filterByTypeUsr.TabIndex = 17;
            this.filterByTypeUsr.SelectedIndexChanged += new System.EventHandler(this.filterByTypeUsr_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(589, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "FIltruoti pagal tipą";
            // 
            // filterByIngred
            // 
            this.filterByIngred.Location = new System.Drawing.Point(411, 168);
            this.filterByIngred.Name = "filterByIngred";
            this.filterByIngred.Size = new System.Drawing.Size(100, 22);
            this.filterByIngred.TabIndex = 15;
            this.filterByIngred.TextChanged += new System.EventHandler(this.filterByIngred_TextChanged_1);
            this.filterByIngred.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.filterByIngred_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(374, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "FIltruoti pagal ingredientą";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(198, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Filtruoti pagal pavadinimą";
            // 
            // filterByName
            // 
            this.filterByName.Location = new System.Drawing.Point(234, 168);
            this.filterByName.Name = "filterByName";
            this.filterByName.Size = new System.Drawing.Size(100, 22);
            this.filterByName.TabIndex = 12;
            this.filterByName.TextChanged += new System.EventHandler(this.filterByName_TextChanged_1);
            this.filterByName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.filterByName_KeyPress);
            // 
            // ziuretiReceptAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.filterByTypeUsr);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.filterByIngred);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.filterByName);
            this.Controls.Add(this.ziurRecAdmDel);
            this.Controls.Add(this.ziurRecAtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "ziuretiReceptAdmin";
            this.Size = new System.Drawing.Size(1134, 740);
            this.Load += new System.EventHandler(this.ziuretiReceptAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ziurRecAtn;
        private System.Windows.Forms.Button ziurRecAdmDel;
        private System.Windows.Forms.ListBox filterByTypeUsr;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox filterByIngred;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox filterByName;
    }
}
