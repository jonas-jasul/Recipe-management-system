
namespace maistoReceptai
{
    partial class adminPridetiRec
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminPridetiRec));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.receptoPav = new System.Windows.Forms.TextBox();
            this.PridetiRec = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ingred_admin_Box1 = new System.Windows.Forms.ListBox();
            this.ingredientaiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet2 = new maistoReceptai.Database1DataSet2();
            this.label4 = new System.Windows.Forms.Label();
            this.ikeltFoto = new System.Windows.Forms.Button();
            this.recNuotrauka = new System.Windows.Forms.PictureBox();
            this.recept_ingred_nuotr = new maistoReceptai.recept_ingred_nuotr();
            this.receptingrednuotrBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ingredientaiTableAdapter = new maistoReceptai.Database1DataSet2TableAdapters.IngredientaiTableAdapter();
            this.refreshIngred = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.receptDescTxtBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.radioVeg = new System.Windows.Forms.RadioButton();
            this.radioNonVeg = new System.Windows.Forms.RadioButton();
            this.adminPridRecRemPhoto = new System.Windows.Forms.Button();
            this.ikeltIngredToTxtBox = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.adminPridRecTime = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.ingredientaiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recNuotrauka)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recept_ingred_nuotr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receptingrednuotrBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminPridRecTime)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(333, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pridėti receptus";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(146, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Patiekalo pavadinimas";
            // 
            // receptoPav
            // 
            this.receptoPav.Location = new System.Drawing.Point(340, 91);
            this.receptoPav.Name = "receptoPav";
            this.receptoPav.Size = new System.Drawing.Size(213, 22);
            this.receptoPav.TabIndex = 4;
            this.receptoPav.TextChanged += new System.EventHandler(this.receptoPav_TextChanged);
            this.receptoPav.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.receptoPav_KeyPress);
            // 
            // PridetiRec
            // 
            this.PridetiRec.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.PridetiRec.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PridetiRec.Location = new System.Drawing.Point(385, 658);
            this.PridetiRec.Name = "PridetiRec";
            this.PridetiRec.Size = new System.Drawing.Size(119, 65);
            this.PridetiRec.TabIndex = 5;
            this.PridetiRec.Text = "Pridėti";
            this.PridetiRec.UseVisualStyleBackColor = false;
            this.PridetiRec.Click += new System.EventHandler(this.PridetiRec_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(213, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ingredientai";
            // 
            // ingred_admin_Box1
            // 
            this.ingred_admin_Box1.FormattingEnabled = true;
            this.ingred_admin_Box1.ItemHeight = 16;
            this.ingred_admin_Box1.Location = new System.Drawing.Point(340, 133);
            this.ingred_admin_Box1.Name = "ingred_admin_Box1";
            this.ingred_admin_Box1.ScrollAlwaysVisible = true;
            this.ingred_admin_Box1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.ingred_admin_Box1.Size = new System.Drawing.Size(213, 100);
            this.ingred_admin_Box1.TabIndex = 7;
            this.ingred_admin_Box1.SelectedIndexChanged += new System.EventHandler(this.ingred_admin_Box1_SelectedIndexChanged);
            // 
            // ingredientaiBindingSource
            // 
            this.ingredientaiBindingSource.DataMember = "Ingredientai";
            this.ingredientaiBindingSource.DataSource = this.database1DataSet2;
            // 
            // database1DataSet2
            // 
            this.database1DataSet2.DataSetName = "Database1DataSet2";
            this.database1DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(221, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nuotrauka";
            // 
            // ikeltFoto
            // 
            this.ikeltFoto.Location = new System.Drawing.Point(574, 271);
            this.ikeltFoto.Name = "ikeltFoto";
            this.ikeltFoto.Size = new System.Drawing.Size(142, 46);
            this.ikeltFoto.TabIndex = 9;
            this.ikeltFoto.Text = "Įkelti nuotrauką";
            this.ikeltFoto.UseVisualStyleBackColor = true;
            this.ikeltFoto.Click += new System.EventHandler(this.ikeltFoto_Click);
            // 
            // recNuotrauka
            // 
            this.recNuotrauka.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.recNuotrauka.Image = ((System.Drawing.Image)(resources.GetObject("recNuotrauka.Image")));
            this.recNuotrauka.Location = new System.Drawing.Point(340, 262);
            this.recNuotrauka.Name = "recNuotrauka";
            this.recNuotrauka.Size = new System.Drawing.Size(213, 130);
            this.recNuotrauka.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.recNuotrauka.TabIndex = 10;
            this.recNuotrauka.TabStop = false;
            // 
            // recept_ingred_nuotr
            // 
            this.recept_ingred_nuotr.DataSetName = "recept_ingred_nuotr";
            this.recept_ingred_nuotr.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // receptingrednuotrBindingSource
            // 
            this.receptingrednuotrBindingSource.DataSource = this.recept_ingred_nuotr;
            this.receptingrednuotrBindingSource.Position = 0;
            // 
            // ingredientaiTableAdapter
            // 
            this.ingredientaiTableAdapter.ClearBeforeFill = true;
            // 
            // refreshIngred
            // 
            this.refreshIngred.BackColor = System.Drawing.Color.DarkTurquoise;
            this.refreshIngred.Location = new System.Drawing.Point(574, 146);
            this.refreshIngred.Name = "refreshIngred";
            this.refreshIngred.Size = new System.Drawing.Size(100, 61);
            this.refreshIngred.TabIndex = 11;
            this.refreshIngred.Text = "Atnaujinti";
            this.refreshIngred.UseVisualStyleBackColor = false;
            this.refreshIngred.Click += new System.EventHandler(this.refreshIngred_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(221, 449);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 18);
            this.label5.TabIndex = 12;
            this.label5.Text = "Aprašymas";
            // 
            // receptDescTxtBox
            // 
            this.receptDescTxtBox.Location = new System.Drawing.Point(340, 415);
            this.receptDescTxtBox.Multiline = true;
            this.receptDescTxtBox.Name = "receptDescTxtBox";
            this.receptDescTxtBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.receptDescTxtBox.Size = new System.Drawing.Size(213, 137);
            this.receptDescTxtBox.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(273, 610);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 18);
            this.label6.TabIndex = 15;
            this.label6.Text = "Tipas";
            // 
            // radioVeg
            // 
            this.radioVeg.AutoSize = true;
            this.radioVeg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioVeg.Location = new System.Drawing.Point(355, 608);
            this.radioVeg.Name = "radioVeg";
            this.radioVeg.Size = new System.Drawing.Size(114, 22);
            this.radioVeg.TabIndex = 16;
            this.radioVeg.TabStop = true;
            this.radioVeg.Text = "Vegetariškas";
            this.radioVeg.UseVisualStyleBackColor = true;
            // 
            // radioNonVeg
            // 
            this.radioNonVeg.AutoSize = true;
            this.radioNonVeg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioNonVeg.Location = new System.Drawing.Point(484, 608);
            this.radioNonVeg.Name = "radioNonVeg";
            this.radioNonVeg.Size = new System.Drawing.Size(131, 22);
            this.radioNonVeg.TabIndex = 17;
            this.radioNonVeg.TabStop = true;
            this.radioNonVeg.Text = "Nevegetariškas";
            this.radioNonVeg.UseVisualStyleBackColor = true;
            // 
            // adminPridRecRemPhoto
            // 
            this.adminPridRecRemPhoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.adminPridRecRemPhoto.Location = new System.Drawing.Point(574, 323);
            this.adminPridRecRemPhoto.Name = "adminPridRecRemPhoto";
            this.adminPridRecRemPhoto.Size = new System.Drawing.Size(142, 69);
            this.adminPridRecRemPhoto.TabIndex = 18;
            this.adminPridRecRemPhoto.Text = "Panaikinti nuotrauką";
            this.adminPridRecRemPhoto.UseVisualStyleBackColor = false;
            this.adminPridRecRemPhoto.Click += new System.EventHandler(this.adminPridRecRemPhoto_Click);
            // 
            // ikeltIngredToTxtBox
            // 
            this.ikeltIngredToTxtBox.Location = new System.Drawing.Point(574, 449);
            this.ikeltIngredToTxtBox.Name = "ikeltIngredToTxtBox";
            this.ikeltIngredToTxtBox.Size = new System.Drawing.Size(142, 69);
            this.ikeltIngredToTxtBox.TabIndex = 19;
            this.ikeltIngredToTxtBox.Text = "Įkelti ingredientus į aprašą";
            this.ikeltIngredToTxtBox.UseVisualStyleBackColor = true;
            this.ikeltIngredToTxtBox.Click += new System.EventHandler(this.ikeltIngredToTxtBox_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(130, 567);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(189, 18);
            this.label7.TabIndex = 20;
            this.label7.Text = "Paruošimo laikas (minutės)";
            // 
            // adminPridRecTime
            // 
            this.adminPridRecTime.Location = new System.Drawing.Point(376, 567);
            this.adminPridRecTime.Name = "adminPridRecTime";
            this.adminPridRecTime.Size = new System.Drawing.Size(146, 22);
            this.adminPridRecTime.TabIndex = 21;
            this.adminPridRecTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.adminPridRecTime.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.adminPridRecTime.ValueChanged += new System.EventHandler(this.adminPridRecTime_ValueChanged);
            // 
            // adminPridetiRec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.adminPridRecTime);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ikeltIngredToTxtBox);
            this.Controls.Add(this.adminPridRecRemPhoto);
            this.Controls.Add(this.radioNonVeg);
            this.Controls.Add(this.radioVeg);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.receptDescTxtBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.refreshIngred);
            this.Controls.Add(this.recNuotrauka);
            this.Controls.Add(this.ikeltFoto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ingred_admin_Box1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PridetiRec);
            this.Controls.Add(this.receptoPav);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "adminPridetiRec";
            this.Size = new System.Drawing.Size(853, 748);
            this.Load += new System.EventHandler(this.adminPridetiRec_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ingredientaiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recNuotrauka)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recept_ingred_nuotr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receptingrednuotrBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminPridRecTime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox receptoPav;
        private System.Windows.Forms.Button PridetiRec;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox ingred_admin_Box1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ikeltFoto;
        private System.Windows.Forms.PictureBox recNuotrauka;
        private recept_ingred_nuotr recept_ingred_nuotr;
        private System.Windows.Forms.BindingSource receptingrednuotrBindingSource;
        private System.Windows.Forms.BindingSource ingredientaiBindingSource;
        private Database1DataSet2 database1DataSet2;
        private Database1DataSet2TableAdapters.IngredientaiTableAdapter ingredientaiTableAdapter;
        private System.Windows.Forms.Button refreshIngred;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox receptDescTxtBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton radioVeg;
        private System.Windows.Forms.RadioButton radioNonVeg;
        private System.Windows.Forms.Button adminPridRecRemPhoto;
        private System.Windows.Forms.Button ikeltIngredToTxtBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown adminPridRecTime;
    }
}
