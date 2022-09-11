
namespace maistoReceptai
{
    partial class ziuretiReceptus
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
            this.label1 = new System.Windows.Forms.Label();
            this.appDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet1 = new maistoReceptai.Database1DataSet1();
            this.nuotraukosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nuotraukosTableAdapter = new maistoReceptai.Database1DataSet1TableAdapters.NuotraukosTableAdapter();
            this.vartotojaiTableAdapter = new maistoReceptai.AppDataSetTableAdapters.VartotojaiTableAdapter();
            this.database1DataSet = new maistoReceptai.Database1DataSet();
            this.receptaiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ingredientaiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ingredientaiTableAdapter = new maistoReceptai.Database1DataSetTableAdapters.IngredientaiTableAdapter();
            this.database1DataSet11 = new maistoReceptai.Database1DataSet1();
            this.recept_ingred_nuotr = new maistoReceptai.recept_ingred_nuotr();
            this.receptingrednuotraukaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.recept_ingred_nuotraukaTableAdapter = new maistoReceptai.recept_ingred_nuotrTableAdapters.Recept_ingred_nuotraukaTableAdapter();
            this.ziurRecAtn = new System.Windows.Forms.Button();
            this.database1DataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nuotraukosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.receptingrednuotraukaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.filterByName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.filterByIngred = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.filterByTypeUsr = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.appDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuotraukosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receptaiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingredientaiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recept_ingred_nuotr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receptingrednuotraukaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuotraukosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receptingrednuotraukaBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(275, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Žiūrėti receptus";
            // 
            // database1DataSet1
            // 
            this.database1DataSet1.DataSetName = "Database1DataSet1";
            this.database1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nuotraukosBindingSource
            // 
            this.nuotraukosBindingSource.DataMember = "Nuotraukos";
            this.nuotraukosBindingSource.DataSource = this.database1DataSet1;
            // 
            // nuotraukosTableAdapter
            // 
            this.nuotraukosTableAdapter.ClearBeforeFill = true;
            // 
            // vartotojaiTableAdapter
            // 
            this.vartotojaiTableAdapter.ClearBeforeFill = true;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // receptaiBindingSource
            // 
            this.receptaiBindingSource.DataMember = "Receptai";
            this.receptaiBindingSource.DataSource = this.database1DataSet;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 150);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(922, 425);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ingredientaiBindingSource
            // 
            this.ingredientaiBindingSource.DataMember = "Ingredientai";
            this.ingredientaiBindingSource.DataSource = this.database1DataSet;
            // 
            // ingredientaiTableAdapter
            // 
            this.ingredientaiTableAdapter.ClearBeforeFill = true;
            // 
            // database1DataSet11
            // 
            this.database1DataSet11.DataSetName = "Database1DataSet1";
            this.database1DataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // recept_ingred_nuotr
            // 
            this.recept_ingred_nuotr.DataSetName = "recept_ingred_nuotr";
            this.recept_ingred_nuotr.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // receptingrednuotraukaBindingSource
            // 
            this.receptingrednuotraukaBindingSource.DataMember = "Recept_ingred_nuotrauka";
            this.receptingrednuotraukaBindingSource.DataSource = this.recept_ingred_nuotr;
            // 
            // recept_ingred_nuotraukaTableAdapter
            // 
            this.recept_ingred_nuotraukaTableAdapter.ClearBeforeFill = true;
            // 
            // ziurRecAtn
            // 
            this.ziurRecAtn.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ziurRecAtn.Location = new System.Drawing.Point(440, 87);
            this.ziurRecAtn.Name = "ziurRecAtn";
            this.ziurRecAtn.Size = new System.Drawing.Size(111, 53);
            this.ziurRecAtn.TabIndex = 3;
            this.ziurRecAtn.Text = "Atnaujinti sąrašą";
            this.ziurRecAtn.UseVisualStyleBackColor = false;
            this.ziurRecAtn.Click += new System.EventHandler(this.ziurRecAtn_Click);
            // 
            // database1DataSet1BindingSource
            // 
            this.database1DataSet1BindingSource.DataSource = this.database1DataSet1;
            this.database1DataSet1BindingSource.Position = 0;
            // 
            // nuotraukosBindingSource1
            // 
            this.nuotraukosBindingSource1.DataMember = "Nuotraukos";
            this.nuotraukosBindingSource1.DataSource = this.database1DataSet1BindingSource;
            // 
            // receptingrednuotraukaBindingSource1
            // 
            this.receptingrednuotraukaBindingSource1.DataMember = "Recept_ingred_nuotrauka";
            this.receptingrednuotraukaBindingSource1.DataSource = this.database1DataSet1BindingSource;
            // 
            // filterByName
            // 
            this.filterByName.Location = new System.Drawing.Point(92, 118);
            this.filterByName.Name = "filterByName";
            this.filterByName.Size = new System.Drawing.Size(100, 22);
            this.filterByName.TabIndex = 4;
            this.filterByName.TextChanged += new System.EventHandler(this.filterByName_TextChanged);
            this.filterByName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.filterByName_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Filtruoti pagal pavadinimą";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(245, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "FIltruoti pagal ingredientą";
            // 
            // filterByIngred
            // 
            this.filterByIngred.Location = new System.Drawing.Point(282, 118);
            this.filterByIngred.Name = "filterByIngred";
            this.filterByIngred.Size = new System.Drawing.Size(100, 22);
            this.filterByIngred.TabIndex = 7;
            this.filterByIngred.TextChanged += new System.EventHandler(this.filterByIngred_TextChanged);
            this.filterByIngred.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.filterByIngred_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(225, 578);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(514, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Du kartus paspauskite ant recepto, kad parodyti jo aprašą!";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(588, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "FIltruoti pagal tipą";
            // 
            // filterByTypeUsr
            // 
            this.filterByTypeUsr.FormattingEnabled = true;
            this.filterByTypeUsr.ItemHeight = 16;
            this.filterByTypeUsr.Items.AddRange(new object[] {
            "Vegetariškas",
            "Nevegetariškas"});
            this.filterByTypeUsr.Location = new System.Drawing.Point(591, 104);
            this.filterByTypeUsr.Name = "filterByTypeUsr";
            this.filterByTypeUsr.Size = new System.Drawing.Size(125, 36);
            this.filterByTypeUsr.TabIndex = 11;
            this.filterByTypeUsr.SelectedIndexChanged += new System.EventHandler(this.filterByTypeUsr_SelectedIndexChanged);
            // 
            // ziuretiReceptus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.filterByTypeUsr);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.filterByIngred);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.filterByName);
            this.Controls.Add(this.ziurRecAtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "ziuretiReceptus";
            this.Size = new System.Drawing.Size(948, 683);
            this.Load += new System.EventHandler(this.ziuretiReceptus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.appDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuotraukosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receptaiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingredientaiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recept_ingred_nuotr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receptingrednuotraukaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuotraukosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receptingrednuotraukaBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource appDataSetBindingSource;
        private Database1DataSet1 database1DataSet1;
        private System.Windows.Forms.BindingSource nuotraukosBindingSource;
        private Database1DataSet1TableAdapters.NuotraukosTableAdapter nuotraukosTableAdapter;
        private AppDataSetTableAdapters.VartotojaiTableAdapter vartotojaiTableAdapter;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource receptaiBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource ingredientaiBindingSource;
        private Database1DataSetTableAdapters.IngredientaiTableAdapter ingredientaiTableAdapter;
        private Database1DataSet1 database1DataSet11;
        private System.Windows.Forms.BindingSource receptingrednuotraukaBindingSource;
        private recept_ingred_nuotr recept_ingred_nuotr;
        private recept_ingred_nuotrTableAdapters.Recept_ingred_nuotraukaTableAdapter recept_ingred_nuotraukaTableAdapter;
        private System.Windows.Forms.Button ziurRecAtn;
        private System.Windows.Forms.BindingSource database1DataSet1BindingSource;
        private System.Windows.Forms.BindingSource nuotraukosBindingSource1;
        private System.Windows.Forms.BindingSource receptingrednuotraukaBindingSource1;
        private System.Windows.Forms.TextBox filterByName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox filterByIngred;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox filterByTypeUsr;
    }
}
