
namespace Ventana_Produccion
{
    partial class AddInventoryForm
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
            this.btn_Add = new System.Windows.Forms.Button();
            this.gBox_Axles = new System.Windows.Forms.GroupBox();
            this.txt_Length_Axle = new System.Windows.Forms.TextBox();
            this.txt_Diameter_Axle = new System.Windows.Forms.TextBox();
            this.num_Qua_Axle = new System.Windows.Forms.NumericUpDown();
            this.lbl_Quantity_A = new System.Windows.Forms.Label();
            this.lbl_Length_A = new System.Windows.Forms.Label();
            this.lbl_Diameter_A = new System.Windows.Forms.Label();
            this.bBox_Bolts = new System.Windows.Forms.GroupBox();
            this.cmb_Type_Bolt = new System.Windows.Forms.ComboBox();
            this.txt_Length_Bolt = new System.Windows.Forms.TextBox();
            this.txt_Diameter_Bolt = new System.Windows.Forms.TextBox();
            this.num_Qua_Bolt = new System.Windows.Forms.NumericUpDown();
            this.lbl_Quantity_B = new System.Windows.Forms.Label();
            this.lbl_Length_B = new System.Windows.Forms.Label();
            this.lbl_Type = new System.Windows.Forms.Label();
            this.lbl_Diameter_B = new System.Windows.Forms.Label();
            this.gBox_Cogs = new System.Windows.Forms.GroupBox();
            this.num_Teeth_Cogs = new System.Windows.Forms.NumericUpDown();
            this.num_Qua_Cogs = new System.Windows.Forms.NumericUpDown();
            this.lbl_Quantity_C = new System.Windows.Forms.Label();
            this.lbl_Teeth = new System.Windows.Forms.Label();
            this.gBox_BBearings = new System.Windows.Forms.GroupBox();
            this.txt_Diameter_BB = new System.Windows.Forms.TextBox();
            this.num_Qua_BB = new System.Windows.Forms.NumericUpDown();
            this.lbl_Quantity_BB = new System.Windows.Forms.Label();
            this.lbl_Diameter_BB = new System.Windows.Forms.Label();
            this.gBox_Nuts = new System.Windows.Forms.GroupBox();
            this.txt_Diameter_Nut = new System.Windows.Forms.TextBox();
            this.num_Qua_Nut = new System.Windows.Forms.NumericUpDown();
            this.lbl_Quantity_N = new System.Windows.Forms.Label();
            this.lbl_Diameter_N = new System.Windows.Forms.Label();
            this.lbl_Bolts = new System.Windows.Forms.Label();
            this.btn_Close = new System.Windows.Forms.Button();
            this.gBox_Axles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Qua_Axle)).BeginInit();
            this.bBox_Bolts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Qua_Bolt)).BeginInit();
            this.gBox_Cogs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Teeth_Cogs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Qua_Cogs)).BeginInit();
            this.gBox_BBearings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Qua_BB)).BeginInit();
            this.gBox_Nuts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Qua_Nut)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(256, 360);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(200, 37);
            this.btn_Add.TabIndex = 22;
            this.btn_Add.Text = "Add to Warehouse";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // gBox_Axles
            // 
            this.gBox_Axles.Controls.Add(this.txt_Length_Axle);
            this.gBox_Axles.Controls.Add(this.txt_Diameter_Axle);
            this.gBox_Axles.Controls.Add(this.num_Qua_Axle);
            this.gBox_Axles.Controls.Add(this.lbl_Quantity_A);
            this.gBox_Axles.Controls.Add(this.lbl_Length_A);
            this.gBox_Axles.Controls.Add(this.lbl_Diameter_A);
            this.gBox_Axles.Location = new System.Drawing.Point(12, 159);
            this.gBox_Axles.Name = "gBox_Axles";
            this.gBox_Axles.Size = new System.Drawing.Size(200, 100);
            this.gBox_Axles.TabIndex = 18;
            this.gBox_Axles.TabStop = false;
            this.gBox_Axles.Text = "Axles";
            // 
            // txt_Length_Axle
            // 
            this.txt_Length_Axle.Location = new System.Drawing.Point(123, 43);
            this.txt_Length_Axle.Name = "txt_Length_Axle";
            this.txt_Length_Axle.Size = new System.Drawing.Size(71, 20);
            this.txt_Length_Axle.TabIndex = 18;
            // 
            // txt_Diameter_Axle
            // 
            this.txt_Diameter_Axle.Location = new System.Drawing.Point(123, 18);
            this.txt_Diameter_Axle.Name = "txt_Diameter_Axle";
            this.txt_Diameter_Axle.Size = new System.Drawing.Size(71, 20);
            this.txt_Diameter_Axle.TabIndex = 17;
            // 
            // num_Qua_Axle
            // 
            this.num_Qua_Axle.Location = new System.Drawing.Point(123, 69);
            this.num_Qua_Axle.Name = "num_Qua_Axle";
            this.num_Qua_Axle.Size = new System.Drawing.Size(71, 20);
            this.num_Qua_Axle.TabIndex = 16;
            // 
            // lbl_Quantity_A
            // 
            this.lbl_Quantity_A.AutoSize = true;
            this.lbl_Quantity_A.Location = new System.Drawing.Point(6, 71);
            this.lbl_Quantity_A.Name = "lbl_Quantity_A";
            this.lbl_Quantity_A.Size = new System.Drawing.Size(46, 13);
            this.lbl_Quantity_A.TabIndex = 16;
            this.lbl_Quantity_A.Text = "Quantity";
            // 
            // lbl_Length_A
            // 
            this.lbl_Length_A.AutoSize = true;
            this.lbl_Length_A.Location = new System.Drawing.Point(6, 46);
            this.lbl_Length_A.Name = "lbl_Length_A";
            this.lbl_Length_A.Size = new System.Drawing.Size(40, 13);
            this.lbl_Length_A.TabIndex = 14;
            this.lbl_Length_A.Text = "Length";
            // 
            // lbl_Diameter_A
            // 
            this.lbl_Diameter_A.AutoSize = true;
            this.lbl_Diameter_A.Location = new System.Drawing.Point(6, 21);
            this.lbl_Diameter_A.Name = "lbl_Diameter_A";
            this.lbl_Diameter_A.Size = new System.Drawing.Size(49, 13);
            this.lbl_Diameter_A.TabIndex = 15;
            this.lbl_Diameter_A.Text = "Diameter";
            // 
            // bBox_Bolts
            // 
            this.bBox_Bolts.Controls.Add(this.cmb_Type_Bolt);
            this.bBox_Bolts.Controls.Add(this.txt_Length_Bolt);
            this.bBox_Bolts.Controls.Add(this.txt_Diameter_Bolt);
            this.bBox_Bolts.Controls.Add(this.num_Qua_Bolt);
            this.bBox_Bolts.Controls.Add(this.lbl_Quantity_B);
            this.bBox_Bolts.Controls.Add(this.lbl_Length_B);
            this.bBox_Bolts.Controls.Add(this.lbl_Type);
            this.bBox_Bolts.Controls.Add(this.lbl_Diameter_B);
            this.bBox_Bolts.Location = new System.Drawing.Point(256, 159);
            this.bBox_Bolts.Name = "bBox_Bolts";
            this.bBox_Bolts.Size = new System.Drawing.Size(200, 124);
            this.bBox_Bolts.TabIndex = 19;
            this.bBox_Bolts.TabStop = false;
            this.bBox_Bolts.Text = "Bolts";
            // 
            // cmb_Type_Bolt
            // 
            this.cmb_Type_Bolt.FormattingEnabled = true;
            this.cmb_Type_Bolt.Location = new System.Drawing.Point(123, 68);
            this.cmb_Type_Bolt.Name = "cmb_Type_Bolt";
            this.cmb_Type_Bolt.Size = new System.Drawing.Size(71, 21);
            this.cmb_Type_Bolt.TabIndex = 14;
            // 
            // txt_Length_Bolt
            // 
            this.txt_Length_Bolt.Location = new System.Drawing.Point(123, 43);
            this.txt_Length_Bolt.Name = "txt_Length_Bolt";
            this.txt_Length_Bolt.Size = new System.Drawing.Size(71, 20);
            this.txt_Length_Bolt.TabIndex = 20;
            // 
            // txt_Diameter_Bolt
            // 
            this.txt_Diameter_Bolt.Location = new System.Drawing.Point(123, 18);
            this.txt_Diameter_Bolt.Name = "txt_Diameter_Bolt";
            this.txt_Diameter_Bolt.Size = new System.Drawing.Size(71, 20);
            this.txt_Diameter_Bolt.TabIndex = 19;
            // 
            // num_Qua_Bolt
            // 
            this.num_Qua_Bolt.Location = new System.Drawing.Point(123, 95);
            this.num_Qua_Bolt.Name = "num_Qua_Bolt";
            this.num_Qua_Bolt.Size = new System.Drawing.Size(71, 20);
            this.num_Qua_Bolt.TabIndex = 18;
            // 
            // lbl_Quantity_B
            // 
            this.lbl_Quantity_B.AutoSize = true;
            this.lbl_Quantity_B.Location = new System.Drawing.Point(6, 97);
            this.lbl_Quantity_B.Name = "lbl_Quantity_B";
            this.lbl_Quantity_B.Size = new System.Drawing.Size(46, 13);
            this.lbl_Quantity_B.TabIndex = 14;
            this.lbl_Quantity_B.Text = "Quantity";
            // 
            // lbl_Length_B
            // 
            this.lbl_Length_B.AutoSize = true;
            this.lbl_Length_B.Location = new System.Drawing.Point(6, 46);
            this.lbl_Length_B.Name = "lbl_Length_B";
            this.lbl_Length_B.Size = new System.Drawing.Size(40, 13);
            this.lbl_Length_B.TabIndex = 15;
            this.lbl_Length_B.Text = "Length";
            // 
            // lbl_Type
            // 
            this.lbl_Type.AutoSize = true;
            this.lbl_Type.Location = new System.Drawing.Point(6, 71);
            this.lbl_Type.Name = "lbl_Type";
            this.lbl_Type.Size = new System.Drawing.Size(31, 13);
            this.lbl_Type.TabIndex = 17;
            this.lbl_Type.Text = "Type";
            // 
            // lbl_Diameter_B
            // 
            this.lbl_Diameter_B.AutoSize = true;
            this.lbl_Diameter_B.Location = new System.Drawing.Point(6, 21);
            this.lbl_Diameter_B.Name = "lbl_Diameter_B";
            this.lbl_Diameter_B.Size = new System.Drawing.Size(49, 13);
            this.lbl_Diameter_B.TabIndex = 16;
            this.lbl_Diameter_B.Text = "Diameter";
            // 
            // gBox_Cogs
            // 
            this.gBox_Cogs.Controls.Add(this.num_Teeth_Cogs);
            this.gBox_Cogs.Controls.Add(this.num_Qua_Cogs);
            this.gBox_Cogs.Controls.Add(this.lbl_Quantity_C);
            this.gBox_Cogs.Controls.Add(this.lbl_Teeth);
            this.gBox_Cogs.Location = new System.Drawing.Point(12, 297);
            this.gBox_Cogs.Name = "gBox_Cogs";
            this.gBox_Cogs.Size = new System.Drawing.Size(200, 100);
            this.gBox_Cogs.TabIndex = 20;
            this.gBox_Cogs.TabStop = false;
            this.gBox_Cogs.Text = "Cogs";
            // 
            // num_Teeth_Cogs
            // 
            this.num_Teeth_Cogs.Location = new System.Drawing.Point(123, 26);
            this.num_Teeth_Cogs.Name = "num_Teeth_Cogs";
            this.num_Teeth_Cogs.Size = new System.Drawing.Size(71, 20);
            this.num_Teeth_Cogs.TabIndex = 18;
            // 
            // num_Qua_Cogs
            // 
            this.num_Qua_Cogs.Location = new System.Drawing.Point(123, 50);
            this.num_Qua_Cogs.Name = "num_Qua_Cogs";
            this.num_Qua_Cogs.Size = new System.Drawing.Size(71, 20);
            this.num_Qua_Cogs.TabIndex = 17;
            // 
            // lbl_Quantity_C
            // 
            this.lbl_Quantity_C.AutoSize = true;
            this.lbl_Quantity_C.Location = new System.Drawing.Point(6, 52);
            this.lbl_Quantity_C.Name = "lbl_Quantity_C";
            this.lbl_Quantity_C.Size = new System.Drawing.Size(46, 13);
            this.lbl_Quantity_C.TabIndex = 16;
            this.lbl_Quantity_C.Text = "Quantity";
            // 
            // lbl_Teeth
            // 
            this.lbl_Teeth.AutoSize = true;
            this.lbl_Teeth.Location = new System.Drawing.Point(6, 28);
            this.lbl_Teeth.Name = "lbl_Teeth";
            this.lbl_Teeth.Size = new System.Drawing.Size(35, 13);
            this.lbl_Teeth.TabIndex = 0;
            this.lbl_Teeth.Text = "Teeth";
            // 
            // gBox_BBearings
            // 
            this.gBox_BBearings.Controls.Add(this.txt_Diameter_BB);
            this.gBox_BBearings.Controls.Add(this.num_Qua_BB);
            this.gBox_BBearings.Controls.Add(this.lbl_Quantity_BB);
            this.gBox_BBearings.Controls.Add(this.lbl_Diameter_BB);
            this.gBox_BBearings.Location = new System.Drawing.Point(256, 12);
            this.gBox_BBearings.Name = "gBox_BBearings";
            this.gBox_BBearings.Size = new System.Drawing.Size(200, 100);
            this.gBox_BBearings.TabIndex = 21;
            this.gBox_BBearings.TabStop = false;
            this.gBox_BBearings.Text = "Ball Bearings";
            // 
            // txt_Diameter_BB
            // 
            this.txt_Diameter_BB.Location = new System.Drawing.Point(120, 18);
            this.txt_Diameter_BB.Name = "txt_Diameter_BB";
            this.txt_Diameter_BB.Size = new System.Drawing.Size(71, 20);
            this.txt_Diameter_BB.TabIndex = 14;
            // 
            // num_Qua_BB
            // 
            this.num_Qua_BB.Location = new System.Drawing.Point(120, 42);
            this.num_Qua_BB.Name = "num_Qua_BB";
            this.num_Qua_BB.Size = new System.Drawing.Size(71, 20);
            this.num_Qua_BB.TabIndex = 15;
            // 
            // lbl_Quantity_BB
            // 
            this.lbl_Quantity_BB.AutoSize = true;
            this.lbl_Quantity_BB.Location = new System.Drawing.Point(6, 44);
            this.lbl_Quantity_BB.Name = "lbl_Quantity_BB";
            this.lbl_Quantity_BB.Size = new System.Drawing.Size(46, 13);
            this.lbl_Quantity_BB.TabIndex = 15;
            this.lbl_Quantity_BB.Text = "Quantity";
            // 
            // lbl_Diameter_BB
            // 
            this.lbl_Diameter_BB.AutoSize = true;
            this.lbl_Diameter_BB.Location = new System.Drawing.Point(6, 21);
            this.lbl_Diameter_BB.Name = "lbl_Diameter_BB";
            this.lbl_Diameter_BB.Size = new System.Drawing.Size(49, 13);
            this.lbl_Diameter_BB.TabIndex = 14;
            this.lbl_Diameter_BB.Text = "Diameter";
            // 
            // gBox_Nuts
            // 
            this.gBox_Nuts.Controls.Add(this.txt_Diameter_Nut);
            this.gBox_Nuts.Controls.Add(this.num_Qua_Nut);
            this.gBox_Nuts.Controls.Add(this.lbl_Quantity_N);
            this.gBox_Nuts.Controls.Add(this.lbl_Diameter_N);
            this.gBox_Nuts.Location = new System.Drawing.Point(12, 12);
            this.gBox_Nuts.Name = "gBox_Nuts";
            this.gBox_Nuts.Size = new System.Drawing.Size(200, 100);
            this.gBox_Nuts.TabIndex = 17;
            this.gBox_Nuts.TabStop = false;
            this.gBox_Nuts.Text = "Nuts";
            // 
            // txt_Diameter_Nut
            // 
            this.txt_Diameter_Nut.Location = new System.Drawing.Point(123, 18);
            this.txt_Diameter_Nut.Name = "txt_Diameter_Nut";
            this.txt_Diameter_Nut.Size = new System.Drawing.Size(71, 20);
            this.txt_Diameter_Nut.TabIndex = 16;
            // 
            // num_Qua_Nut
            // 
            this.num_Qua_Nut.Location = new System.Drawing.Point(123, 42);
            this.num_Qua_Nut.Name = "num_Qua_Nut";
            this.num_Qua_Nut.Size = new System.Drawing.Size(71, 20);
            this.num_Qua_Nut.TabIndex = 14;
            // 
            // lbl_Quantity_N
            // 
            this.lbl_Quantity_N.AutoSize = true;
            this.lbl_Quantity_N.Location = new System.Drawing.Point(9, 44);
            this.lbl_Quantity_N.Name = "lbl_Quantity_N";
            this.lbl_Quantity_N.Size = new System.Drawing.Size(46, 13);
            this.lbl_Quantity_N.TabIndex = 15;
            this.lbl_Quantity_N.Text = "Quantity";
            // 
            // lbl_Diameter_N
            // 
            this.lbl_Diameter_N.AutoSize = true;
            this.lbl_Diameter_N.Location = new System.Drawing.Point(9, 21);
            this.lbl_Diameter_N.Name = "lbl_Diameter_N";
            this.lbl_Diameter_N.Size = new System.Drawing.Size(49, 13);
            this.lbl_Diameter_N.TabIndex = 1;
            this.lbl_Diameter_N.Text = "Diameter";
            // 
            // lbl_Bolts
            // 
            this.lbl_Bolts.AutoSize = true;
            this.lbl_Bolts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Bolts.Location = new System.Drawing.Point(285, 46);
            this.lbl_Bolts.Name = "lbl_Bolts";
            this.lbl_Bolts.Size = new System.Drawing.Size(43, 16);
            this.lbl_Bolts.TabIndex = 16;
            this.lbl_Bolts.Text = "Bolts";
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(256, 297);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(200, 37);
            this.btn_Close.TabIndex = 15;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // AddInventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 405);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.gBox_Axles);
            this.Controls.Add(this.bBox_Bolts);
            this.Controls.Add(this.gBox_Cogs);
            this.Controls.Add(this.gBox_BBearings);
            this.Controls.Add(this.gBox_Nuts);
            this.Controls.Add(this.lbl_Bolts);
            this.Controls.Add(this.btn_Close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddInventoryForm";
            this.ShowIcon = false;
            this.Text = "New Parts";
            this.TopMost = true;
            this.gBox_Axles.ResumeLayout(false);
            this.gBox_Axles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Qua_Axle)).EndInit();
            this.bBox_Bolts.ResumeLayout(false);
            this.bBox_Bolts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Qua_Bolt)).EndInit();
            this.gBox_Cogs.ResumeLayout(false);
            this.gBox_Cogs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Teeth_Cogs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Qua_Cogs)).EndInit();
            this.gBox_BBearings.ResumeLayout(false);
            this.gBox_BBearings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Qua_BB)).EndInit();
            this.gBox_Nuts.ResumeLayout(false);
            this.gBox_Nuts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Qua_Nut)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.GroupBox gBox_Axles;
        private System.Windows.Forms.TextBox txt_Length_Axle;
        private System.Windows.Forms.TextBox txt_Diameter_Axle;
        private System.Windows.Forms.NumericUpDown num_Qua_Axle;
        private System.Windows.Forms.Label lbl_Quantity_A;
        private System.Windows.Forms.Label lbl_Length_A;
        private System.Windows.Forms.Label lbl_Diameter_A;
        private System.Windows.Forms.GroupBox bBox_Bolts;
        private System.Windows.Forms.ComboBox cmb_Type_Bolt;
        private System.Windows.Forms.TextBox txt_Length_Bolt;
        private System.Windows.Forms.TextBox txt_Diameter_Bolt;
        private System.Windows.Forms.NumericUpDown num_Qua_Bolt;
        private System.Windows.Forms.Label lbl_Quantity_B;
        private System.Windows.Forms.Label lbl_Length_B;
        private System.Windows.Forms.Label lbl_Type;
        private System.Windows.Forms.Label lbl_Diameter_B;
        private System.Windows.Forms.GroupBox gBox_Cogs;
        private System.Windows.Forms.NumericUpDown num_Teeth_Cogs;
        private System.Windows.Forms.NumericUpDown num_Qua_Cogs;
        private System.Windows.Forms.Label lbl_Quantity_C;
        private System.Windows.Forms.Label lbl_Teeth;
        private System.Windows.Forms.GroupBox gBox_BBearings;
        private System.Windows.Forms.TextBox txt_Diameter_BB;
        private System.Windows.Forms.NumericUpDown num_Qua_BB;
        private System.Windows.Forms.Label lbl_Quantity_BB;
        private System.Windows.Forms.Label lbl_Diameter_BB;
        private System.Windows.Forms.GroupBox gBox_Nuts;
        private System.Windows.Forms.TextBox txt_Diameter_Nut;
        private System.Windows.Forms.NumericUpDown num_Qua_Nut;
        private System.Windows.Forms.Label lbl_Quantity_N;
        private System.Windows.Forms.Label lbl_Diameter_N;
        private System.Windows.Forms.Label lbl_Bolts;
        private System.Windows.Forms.Button btn_Close;
    }
}