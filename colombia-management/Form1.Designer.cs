
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.table = new System.Windows.Forms.DataGridView();
            this.depCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.BtnFiltrar = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(259, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "buscar";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(367, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "salir";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(15, 13);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(217, 22);
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
            this.table.RowHeadersWidth = 51;
            this.table.Size = new System.Drawing.Size(543, 350);
            this.table.TabIndex = 3;
            // 
            // depCode
            // 
            this.depCode.HeaderText = "Codigo Departamento";
            this.depCode.MinimumWidth = 6;
            this.depCode.Name = "depCode";
            this.depCode.ReadOnly = true;
            this.depCode.Width = 125;
            // 
            // cityCode
            // 
            this.cityCode.HeaderText = "Codigo Municipio";
            this.cityCode.MinimumWidth = 6;
            this.cityCode.Name = "cityCode";
            this.cityCode.ReadOnly = true;
            this.cityCode.Width = 125;
            // 
            // depName
            // 
            this.depName.HeaderText = "Nombre Departamento";
            this.depName.MinimumWidth = 6;
            this.depName.Name = "depName";
            this.depName.ReadOnly = true;
            this.depName.Width = 125;
            // 
            // cityName
            // 
            this.cityName.HeaderText = "Nombre Municipio";
            this.cityName.MinimumWidth = 6;
            this.cityName.Name = "cityName";
            this.cityName.ReadOnly = true;
            this.cityName.Width = 125;
            // 
            // type
            // 
            this.type.HeaderText = "Tipo";
            this.type.MinimumWidth = 6;
            this.type.Name = "type";
            this.type.ReadOnly = true;
            this.type.Width = 125;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "ANTIOQUIA",
            "ATLÃNTICO",
            "BOGOTÃ. D.C.",
            "BOLÃVAR",
            "BOYACÃ",
            "CALDAS",
            "CAQUETÃ",
            "CAUCA",
            "CESAR",
            "CÃ“RDOBA",
            "CUNDINAMARCA",
            "CHOCÃ“",
            "HUILA",
            "LA GUAJIRA",
            "MAGDALENA",
            "META",
            "NARIÃ‘O",
            "NORTE DE SANTANDER",
            "QUINDÃO",
            "RISARALDA",
            "SANTANDER",
            "SUCRE",
            "TOLIMA",
            "VALLE DEL CAUCA",
            "ARAUCA",
            "CASANARE",
            "PUTUMAYO",
            "ARCHIPIÃ‰LAGO DE SAN ANDRÃ‰S. PROVIDENCIA Y SANTA CATALINA",
            "AMAZONAS",
            "GUAINÃA",
            "GUAVIARE",
            "VAUPÃ‰S",
            "VICHADA"});
            this.comboBox1.Location = new System.Drawing.Point(591, 58);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(365, 24);
            this.comboBox1.TabIndex = 4;
            // 
            // BtnFiltrar
            // 
            this.BtnFiltrar.Location = new System.Drawing.Point(992, 58);
            this.BtnFiltrar.Name = "BtnFiltrar";
            this.BtnFiltrar.Size = new System.Drawing.Size(109, 23);
            this.BtnFiltrar.TabIndex = 5;
            this.BtnFiltrar.Text = "filtrar";
            this.BtnFiltrar.UseVisualStyleBackColor = true;
            this.BtnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(591, 104);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(510, 304);
            this.chart1.TabIndex = 6;
            this.chart1.Text = "chart1";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1124, 420);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.BtnFiltrar);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.table);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSearch);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
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
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button BtnFiltrar;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

