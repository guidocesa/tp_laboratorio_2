
namespace Ventana_Produccion
{
    partial class RequestForm
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
            this.dataGrid_PartsTable = new System.Windows.Forms.DataGridView();
            this.column_ItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_TotalRequested = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.btn_MakeRequest = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_PartsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid_PartsTable
            // 
            this.dataGrid_PartsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_PartsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.column_ItemID,
            this.column_Stock,
            this.column_TotalRequested});
            this.dataGrid_PartsTable.Location = new System.Drawing.Point(12, 12);
            this.dataGrid_PartsTable.Name = "dataGrid_PartsTable";
            this.dataGrid_PartsTable.Size = new System.Drawing.Size(443, 357);
            this.dataGrid_PartsTable.TabIndex = 16;
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
            // column_TotalRequested
            // 
            this.column_TotalRequested.HeaderText = "Total Requested";
            this.column_TotalRequested.Name = "column_TotalRequested";
            this.column_TotalRequested.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.column_TotalRequested.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // btn_MakeRequest
            // 
            this.btn_MakeRequest.Location = new System.Drawing.Point(473, 12);
            this.btn_MakeRequest.Name = "btn_MakeRequest";
            this.btn_MakeRequest.Size = new System.Drawing.Size(170, 33);
            this.btn_MakeRequest.TabIndex = 17;
            this.btn_MakeRequest.Text = "Make Request";
            this.btn_MakeRequest.UseVisualStyleBackColor = true;
            this.btn_MakeRequest.Click += new System.EventHandler(this.btn_MakeRequest_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(473, 65);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(170, 33);
            this.btn_Close.TabIndex = 18;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // RequestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 383);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_MakeRequest);
            this.Controls.Add(this.dataGrid_PartsTable);
            this.Name = "RequestForm";
            this.Text = "RequestForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_PartsTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid_PartsTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_ItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_Stock;
        private System.Windows.Forms.DataGridViewComboBoxColumn column_TotalRequested;
        private System.Windows.Forms.Button btn_MakeRequest;
        private System.Windows.Forms.Button btn_Close;
    }
}