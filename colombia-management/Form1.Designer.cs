
namespace colombia_management
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.table = new System.Windows.Forms.DataGridView();
            this.depCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(108, -1);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "buscar";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(189, -2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "salir";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(2, 1);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(100, 20);
            this.txtPath.TabIndex = 2;
            this.txtPath.Visible = false;
            // 
            // table
            // 
            this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.depCode,
            this.cityCode,
            this.depName,
            this.cityName,
            this.type});
            this.table.Location = new System.Drawing.Point(15, 58);
            this.table.Name = "table";
            this.table.Size = new System.Drawing.Size(543, 150);
            this.table.TabIndex = 3;
            // 
            // depCode
            // 
            this.depCode.HeaderText = "Codigo Departamento";
            this.depCode.Name = "depCode";
            this.depCode.ReadOnly = true;
            // 
            // cityCode
            // 
            this.cityCode.HeaderText = "Codigo Municipio";
            this.cityCode.Name = "cityCode";
            this.cityCode.ReadOnly = true;
            // 
            // depName
            // 
            this.depName.HeaderText = "Nombre Departamento";
            this.depName.Name = "depName";
            this.depName.ReadOnly = true;
            // 
            // cityName
            // 
            this.cityName.HeaderText = "Nombre Municipio";
            this.cityName.Name = "cityName";
            this.cityName.ReadOnly = true;
            // 
            // type
            // 
            this.type.HeaderText = "Tipo";
            this.type.Name = "type";
            this.type.ReadOnly = true;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(908, 261);
            this.Controls.Add(this.table);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSearch);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.DataGridView table;
        private System.Windows.Forms.DataGridViewTextBoxColumn depCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn depName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityName;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
    }
}

