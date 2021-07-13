
namespace Ventana_Produccion
{
    partial class WarehouseForm
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
            this.btn_MakeRequest = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.dataGrid_PartsTable = new System.Windows.Forms.DataGridView();
            this.column_ItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.warehouseBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btn_LoadWare = new System.Windows.Forms.Button();
            this.btn_SaveWarehouse = new System.Windows.Forms.Button();
            this.lblCurrentWarehouse = new System.Windows.Forms.Label();
            this.btn_LoadSQL = new System.Windows.Forms.Button();
            this.btn_SaveSQL = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_PartsTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_MakeRequest
            // 
            this.btn_MakeRequest.Location = new System.Drawing.Point(264, 163);
            this.btn_MakeRequest.Name = "btn_MakeRequest";
            this.btn_MakeRequest.Size = new System.Drawing.Size(194, 40);
            this.btn_MakeRequest.TabIndex = 0;
            this.btn_MakeRequest.Text = "Make Request";
            this.btn_MakeRequest.UseVisualStyleBackColor = true;
            this.btn_MakeRequest.Click += new System.EventHandler(this.btn_MakeRequest_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(264, 226);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(194, 40);
            this.btn_Add.TabIndex = 14;
            this.btn_Add.Text = "Add new Parts";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // dataGrid_PartsTable
            // 
            this.dataGrid_PartsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_PartsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.column_ItemID,
            this.column_Stock});
            this.dataGrid_PartsTable.Location = new System.Drawing.Point(12, 40);
            this.dataGrid_PartsTable.Name = "dataGrid_PartsTable";
            this.dataGrid_PartsTable.Size = new System.Drawing.Size(246, 357);
            this.dataGrid_PartsTable.TabIndex = 15;
            // 
            // column_ItemID
            // 
            this.column_ItemID.HeaderText = "Item ID";
            this.column_ItemID.Name = "column_ItemID";
            this.column_ItemID.ReadOnly = true;
            // 
            // column_Stock
            // 
            this.column_Stock.HeaderText = "Stock";
            this.column_Stock.Name = "column_Stock";
            this.column_Stock.ReadOnly = true;
            // 
            // warehouseBindingSource1
            // 
            this.warehouseBindingSource1.DataSource = typeof(Clases.Warehouse);
            // 
            // btn_LoadWare
            // 
            this.btn_LoadWare.Location = new System.Drawing.Point(264, 40);
            this.btn_LoadWare.Name = "btn_LoadWare";
            this.btn_LoadWare.Size = new System.Drawing.Size(194, 40);
            this.btn_LoadWare.TabIndex = 16;
            this.btn_LoadWare.Text = "Load Warehouse";
            this.btn_LoadWare.UseVisualStyleBackColor = true;
            this.btn_LoadWare.Click += new System.EventHandler(this.btn_LoadWare_Click);
            // 
            // btn_SaveWarehouse
            // 
            this.btn_SaveWarehouse.Location = new System.Drawing.Point(264, 102);
            this.btn_SaveWarehouse.Name = "btn_SaveWarehouse";
            this.btn_SaveWarehouse.Size = new System.Drawing.Size(194, 40);
            this.btn_SaveWarehouse.TabIndex = 17;
            this.btn_SaveWarehouse.Text = "Save Warehouse";
            this.btn_SaveWarehouse.UseVisualStyleBackColor = true;
            this.btn_SaveWarehouse.Click += new System.EventHandler(this.btn_SaveWarehouse_Click);
            // 
            // lblCurrentWarehouse
            // 
            this.lblCurrentWarehouse.AutoSize = true;
            this.lblCurrentWarehouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentWarehouse.Location = new System.Drawing.Point(55, 17);
            this.lblCurrentWarehouse.Name = "lblCurrentWarehouse";
            this.lblCurrentWarehouse.Size = new System.Drawing.Size(165, 20);
            this.lblCurrentWarehouse.TabIndex = 18;
            this.lblCurrentWarehouse.Text = "Current Warehouse";
            // 
            // btn_LoadSQL
            // 
            this.btn_LoadSQL.Location = new System.Drawing.Point(264, 290);
            this.btn_LoadSQL.Name = "btn_LoadSQL";
            this.btn_LoadSQL.Size = new System.Drawing.Size(194, 40);
            this.btn_LoadSQL.TabIndex = 19;
            this.btn_LoadSQL.Text = "Load from SQL";
            this.btn_LoadSQL.UseVisualStyleBackColor = true;
            this.btn_LoadSQL.Click += new System.EventHandler(this.btn_LoadSQL_Click);
            // 
            // btn_SaveSQL
            // 
            this.btn_SaveSQL.Location = new System.Drawing.Point(264, 357);
            this.btn_SaveSQL.Name = "btn_SaveSQL";
            this.btn_SaveSQL.Size = new System.Drawing.Size(194, 40);
            this.btn_SaveSQL.TabIndex = 20;
            this.btn_SaveSQL.Text = "Save to Database";
            this.btn_SaveSQL.UseVisualStyleBackColor = true;
            this.btn_SaveSQL.Click += new System.EventHandler(this.btn_SaveSQL_Click);
            // 
            // WarehouseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 410);
            this.Controls.Add(this.btn_SaveSQL);
            this.Controls.Add(this.btn_LoadSQL);
            this.Controls.Add(this.lblCurrentWarehouse);
            this.Controls.Add(this.btn_SaveWarehouse);
            this.Controls.Add(this.btn_LoadWare);
            this.Controls.Add(this.dataGrid_PartsTable);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btn_MakeRequest);
            this.Name = "WarehouseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Warehouse Manager";
            this.Load += new System.EventHandler(this.WarehouseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_PartsTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_MakeRequest;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.BindingSource warehouseBindingSource1;
        private System.Windows.Forms.DataGridView dataGrid_PartsTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_ItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_Stock;
        private System.Windows.Forms.Button btn_LoadWare;
        private System.Windows.Forms.Button btn_SaveWarehouse;
        private System.Windows.Forms.Label lblCurrentWarehouse;
        private System.Windows.Forms.Button btn_LoadSQL;
        private System.Windows.Forms.Button btn_SaveSQL;
    }
}

