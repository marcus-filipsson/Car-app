namespace Car_app
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.txtRegNr = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtMake = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxForSale = new System.Windows.Forms.CheckBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.regnr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lsvCars = new System.Windows.Forms.ListView();
            this.make = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.forsale = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.year = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.model = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtRegNr
            // 
            this.txtRegNr.Location = new System.Drawing.Point(125, 73);
            this.txtRegNr.Name = "txtRegNr";
            this.txtRegNr.Size = new System.Drawing.Size(146, 26);
            this.txtRegNr.TabIndex = 0;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(374, 73);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(123, 26);
            this.txtModel.TabIndex = 1;
            // 
            // txtMake
            // 
            this.txtMake.Location = new System.Drawing.Point(125, 123);
            this.txtMake.Name = "txtMake";
            this.txtMake.Size = new System.Drawing.Size(146, 26);
            this.txtMake.TabIndex = 2;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(374, 123);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(123, 26);
            this.txtYear.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.cbxForSale);
            this.groupBox1.Controls.Add(this.txtMake);
            this.groupBox1.Controls.Add(this.txtYear);
            this.groupBox1.Controls.Add(this.txtRegNr);
            this.groupBox1.Controls.Add(this.txtModel);
            this.groupBox1.Location = new System.Drawing.Point(41, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(686, 174);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cbxForSale
            // 
            this.cbxForSale.AutoSize = true;
            this.cbxForSale.Location = new System.Drawing.Point(579, 73);
            this.cbxForSale.Name = "cbxForSale";
            this.cbxForSale.Size = new System.Drawing.Size(89, 24);
            this.cbxForSale.TabIndex = 4;
            this.cbxForSale.Text = "Till Salu";
            this.cbxForSale.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(579, 123);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 26);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Lägg till";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // regnr
            // 
            this.regnr.Text = "Reg Nr";
            this.regnr.Width = 74;
            // 
            // lsvCars
            // 
            this.lsvCars.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.regnr,
            this.make,
            this.forsale,
            this.year,
            this.model});
            this.lsvCars.Location = new System.Drawing.Point(41, 193);
            this.lsvCars.Name = "lsvCars";
            this.lsvCars.Size = new System.Drawing.Size(686, 207);
            this.lsvCars.TabIndex = 5;
            this.lsvCars.UseCompatibleStateImageBehavior = false;
            this.lsvCars.View = System.Windows.Forms.View.Details;
            this.lsvCars.SelectedIndexChanged += new System.EventHandler(this.lsvCars_SelectedIndexChanged);
            // 
            // make
            // 
            this.make.Text = "Märke";
            // 
            // forsale
            // 
            this.forsale.Text = "Till Salu";
            this.forsale.Width = 73;
            // 
            // year
            // 
            this.year.Text = "år";
            // 
            // model
            // 
            this.model.Text = "modell";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(620, 415);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 6;
            this.btnRemove.Text = "Ta bort markerad";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(111, 406);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(136, 32);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Rensa bort all data";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.lsvCars);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.TextBox txtRegNr;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtMake;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.CheckBox cbxForSale;
        private System.Windows.Forms.ColumnHeader regnr;
        private System.Windows.Forms.ListView lsvCars;
        private System.Windows.Forms.ColumnHeader make;
        private System.Windows.Forms.ColumnHeader forsale;
        private System.Windows.Forms.ColumnHeader year;
        private System.Windows.Forms.ColumnHeader model;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnClear;
    }
}

