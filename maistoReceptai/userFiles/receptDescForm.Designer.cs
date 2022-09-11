
namespace maistoReceptai
{
    partial class receptDescForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.viewReceptDesc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // viewReceptDesc
            // 
            this.viewReceptDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewReceptDesc.Location = new System.Drawing.Point(62, 97);
            this.viewReceptDesc.Multiline = true;
            this.viewReceptDesc.Name = "viewReceptDesc";
            this.viewReceptDesc.ReadOnly = true;
            this.viewReceptDesc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.viewReceptDesc.Size = new System.Drawing.Size(375, 442);
            this.viewReceptDesc.TabIndex = 0;
            this.viewReceptDesc.TextChanged += new System.EventHandler(this.viewReceptDesc_TextChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 70);
            this.label1.TabIndex = 1;
            this.label1.Text = "Recepto ingredientai ir paruošimo būdas";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // receptDescForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 589);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.viewReceptDesc);
            this.Name = "receptDescForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "receptDescForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox viewReceptDesc;
        private System.Windows.Forms.Label label1;
    }
}