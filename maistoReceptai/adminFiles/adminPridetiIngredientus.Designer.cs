
namespace maistoReceptai
{
    partial class adminPridetiIngredientus
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
            this.adminPridetiIngredienta_btn = new System.Windows.Forms.Button();
            this.adminPridetiIngredienta_pav = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ingred_admin_Box2 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.deleteSlcIngr = new System.Windows.Forms.Button();
            this.refreshIngred = new System.Windows.Forms.Button();
            this.database1DataSet2 = new maistoReceptai.Database1DataSet2();
            this.ingredientaiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ingredientaiTableAdapter = new maistoReceptai.Database1DataSet2TableAdapters.IngredientaiTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingredientaiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(211, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(472, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pridėti ir pašalinti ingredientus";
            // 
            // adminPridetiIngredienta_btn
            // 
            this.adminPridetiIngredienta_btn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.adminPridetiIngredienta_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminPridetiIngredienta_btn.Location = new System.Drawing.Point(405, 390);
            this.adminPridetiIngredienta_btn.Name = "adminPridetiIngredienta_btn";
            this.adminPridetiIngredienta_btn.Size = new System.Drawing.Size(119, 65);
            this.adminPridetiIngredienta_btn.TabIndex = 6;
            this.adminPridetiIngredienta_btn.Text = "Pridėti";
            this.adminPridetiIngredienta_btn.UseVisualStyleBackColor = false;
            this.adminPridetiIngredienta_btn.Click += new System.EventHandler(this.adminPridetiIngredienta_btn_Click);
            // 
            // adminPridetiIngredienta_pav
            // 
            this.adminPridetiIngredienta_pav.Location = new System.Drawing.Point(354, 99);
            this.adminPridetiIngredienta_pav.Name = "adminPridetiIngredienta_pav";
            this.adminPridetiIngredienta_pav.Size = new System.Drawing.Size(207, 22);
            this.adminPridetiIngredienta_pav.TabIndex = 7;
            this.adminPridetiIngredienta_pav.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.adminPridetiIngredienta_pav_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(131, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Ingrediento pavadinimas";
            // 
            // ingred_admin_Box2
            // 
            this.ingred_admin_Box2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ingred_admin_Box2.FormattingEnabled = true;
            this.ingred_admin_Box2.ItemHeight = 18;
            this.ingred_admin_Box2.Location = new System.Drawing.Point(354, 163);
            this.ingred_admin_Box2.Name = "ingred_admin_Box2";
            this.ingred_admin_Box2.ScrollAlwaysVisible = true;
            this.ingred_admin_Box2.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.ingred_admin_Box2.Size = new System.Drawing.Size(207, 202);
            this.ingred_admin_Box2.TabIndex = 9;
            this.ingred_admin_Box2.SelectedIndexChanged += new System.EventHandler(this.ingred_admin_Box2_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(160, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "Ingredientų sąrašas";
            // 
            // deleteSlcIngr
            // 
            this.deleteSlcIngr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.deleteSlcIngr.Location = new System.Drawing.Point(604, 252);
            this.deleteSlcIngr.Name = "deleteSlcIngr";
            this.deleteSlcIngr.Size = new System.Drawing.Size(100, 61);
            this.deleteSlcIngr.TabIndex = 12;
            this.deleteSlcIngr.Text = "Pašalinti";
            this.deleteSlcIngr.UseVisualStyleBackColor = false;
            this.deleteSlcIngr.Click += new System.EventHandler(this.deleteSlcIngr_Click);
            // 
            // refreshIngred
            // 
            this.refreshIngred.BackColor = System.Drawing.Color.DarkTurquoise;
            this.refreshIngred.Location = new System.Drawing.Point(604, 163);
            this.refreshIngred.Name = "refreshIngred";
            this.refreshIngred.Size = new System.Drawing.Size(100, 61);
            this.refreshIngred.TabIndex = 13;
            this.refreshIngred.Text = "Atnaujinti";
            this.refreshIngred.UseVisualStyleBackColor = false;
            this.refreshIngred.Click += new System.EventHandler(this.refreshIngred_Click);
            // 
            // database1DataSet2
            // 
            this.database1DataSet2.DataSetName = "Database1DataSet2";
            this.database1DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ingredientaiBindingSource
            // 
            this.ingredientaiBindingSource.DataMember = "Ingredientai";
            this.ingredientaiBindingSource.DataSource = this.database1DataSet2;
            // 
            // ingredientaiTableAdapter
            // 
            this.ingredientaiTableAdapter.ClearBeforeFill = true;
            // 
            // adminPridetiIngredientus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.refreshIngred);
            this.Controls.Add(this.deleteSlcIngr);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ingred_admin_Box2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.adminPridetiIngredienta_pav);
            this.Controls.Add(this.adminPridetiIngredienta_btn);
            this.Controls.Add(this.label1);
            this.Name = "adminPridetiIngredientus";
            this.Size = new System.Drawing.Size(945, 601);
            this.Load += new System.EventHandler(this.adminPridetiIngredientus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingredientaiBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button adminPridetiIngredienta_btn;
        private System.Windows.Forms.TextBox adminPridetiIngredienta_pav;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox ingred_admin_Box2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button deleteSlcIngr;
        private System.Windows.Forms.Button refreshIngred;
        private System.Windows.Forms.BindingSource ingredientaiBindingSource;
        private Database1DataSet2 database1DataSet2;
        private Database1DataSet2TableAdapters.IngredientaiTableAdapter ingredientaiTableAdapter;
    }
}
