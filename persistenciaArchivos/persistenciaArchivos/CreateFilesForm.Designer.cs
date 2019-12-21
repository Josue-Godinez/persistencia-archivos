namespace persistenciaArchivos
{
    partial class CreateFilesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateFilesForm));
            this.ChequesDataGridView = new System.Windows.Forms.DataGridView();
            this.NombreColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReceptorColum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaColum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InstitucionColum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroChequeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescripcionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CerrarButton = new System.Windows.Forms.Button();
            this.CrearArchivoButton = new System.Windows.Forms.Button();
            this.ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.UpsertPanel = new System.Windows.Forms.Panel();
            this.FechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.FechaLabel = new System.Windows.Forms.Label();
            this.MonedaLabel = new System.Windows.Forms.Label();
            this.MonedaComboBox = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.InstitucionITextBox = new System.Windows.Forms.Label();
            this.ReceptorTextBox = new System.Windows.Forms.TextBox();
            this.ReceptorLabel = new System.Windows.Forms.Label();
            this.MontoLabel = new System.Windows.Forms.Label();
            this.MontoTextBox = new System.Windows.Forms.TextBox();
            this.DescripcionLlabel = new System.Windows.Forms.Label();
            this.DescripcionTextBox = new System.Windows.Forms.TextBox();
            this.NumeroChequeLabel = new System.Windows.Forms.Label();
            this.EmisorLabel = new System.Windows.Forms.Label();
            this.NumeroChequeTextBox = new System.Windows.Forms.TextBox();
            this.NombreTextBox = new System.Windows.Forms.TextBox();
            this.AgregarButton = new System.Windows.Forms.Button();
            this.LimpiarButton = new System.Windows.Forms.Button();
            this.ListaChequesLabel = new System.Windows.Forms.Label();
            this.InformacionRutaLabel = new System.Windows.Forms.Label();
            this.BorrarRenglonButton = new System.Windows.Forms.Button();
            this.InformationProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ChequesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.UpsertPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InformationProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // ChequesDataGridView
            // 
            this.ChequesDataGridView.AllowUserToAddRows = false;
            this.ChequesDataGridView.AllowUserToDeleteRows = false;
            this.ChequesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ChequesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreColumn,
            this.ReceptorColum,
            this.FechaColum,
            this.InstitucionColum,
            this.NumeroChequeColumn,
            this.MontoColumn,
            this.DescripcionColumn});
            this.ChequesDataGridView.Location = new System.Drawing.Point(279, 81);
            this.ChequesDataGridView.Name = "ChequesDataGridView";
            this.ChequesDataGridView.ReadOnly = true;
            this.ChequesDataGridView.Size = new System.Drawing.Size(647, 318);
            this.ChequesDataGridView.TabIndex = 2;
            // 
            // NombreColumn
            // 
            this.NombreColumn.HeaderText = "Emisor";
            this.NombreColumn.Name = "NombreColumn";
            this.NombreColumn.ReadOnly = true;
            // 
            // ReceptorColum
            // 
            this.ReceptorColum.HeaderText = "Receptor";
            this.ReceptorColum.Name = "ReceptorColum";
            this.ReceptorColum.ReadOnly = true;
            // 
            // FechaColum
            // 
            this.FechaColum.HeaderText = "Fecha";
            this.FechaColum.Name = "FechaColum";
            this.FechaColum.ReadOnly = true;
            // 
            // InstitucionColum
            // 
            this.InstitucionColum.HeaderText = "Intitucion Financiera";
            this.InstitucionColum.Name = "InstitucionColum";
            this.InstitucionColum.ReadOnly = true;
            // 
            // NumeroChequeColumn
            // 
            this.NumeroChequeColumn.HeaderText = "Número Cheque";
            this.NumeroChequeColumn.Name = "NumeroChequeColumn";
            this.NumeroChequeColumn.ReadOnly = true;
            // 
            // MontoColumn
            // 
            this.MontoColumn.HeaderText = "Monto en Colones";
            this.MontoColumn.Name = "MontoColumn";
            this.MontoColumn.ReadOnly = true;
            // 
            // DescripcionColumn
            // 
            this.DescripcionColumn.HeaderText = "Descripción";
            this.DescripcionColumn.Name = "DescripcionColumn";
            this.DescripcionColumn.ReadOnly = true;
            // 
            // CerrarButton
            // 
            this.CerrarButton.Location = new System.Drawing.Point(279, 449);
            this.CerrarButton.Name = "CerrarButton";
            this.CerrarButton.Size = new System.Drawing.Size(75, 23);
            this.CerrarButton.TabIndex = 11;
            this.CerrarButton.Text = "Cerrar";
            this.CerrarButton.UseVisualStyleBackColor = true;
            this.CerrarButton.Click += new System.EventHandler(this.CerrarButton_Click);
            // 
            // CrearArchivoButton
            // 
            this.CrearArchivoButton.Location = new System.Drawing.Point(833, 449);
            this.CrearArchivoButton.Name = "CrearArchivoButton";
            this.CrearArchivoButton.Size = new System.Drawing.Size(93, 23);
            this.CrearArchivoButton.TabIndex = 11;
            this.CrearArchivoButton.Text = "Crear Archivo";
            this.CrearArchivoButton.UseVisualStyleBackColor = true;
            this.CrearArchivoButton.Click += new System.EventHandler(this.CrearArchivoButton_Click);
            // 
            // ErrorProvider
            // 
            this.ErrorProvider.ContainerControl = this;
            this.ErrorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("ErrorProvider.Icon")));
            // 
            // UpsertPanel
            // 
            this.UpsertPanel.BackColor = System.Drawing.Color.DarkBlue;
            this.UpsertPanel.Controls.Add(this.FechaDateTimePicker);
            this.UpsertPanel.Controls.Add(this.FechaLabel);
            this.UpsertPanel.Controls.Add(this.MonedaLabel);
            this.UpsertPanel.Controls.Add(this.MonedaComboBox);
            this.UpsertPanel.Controls.Add(this.textBox1);
            this.UpsertPanel.Controls.Add(this.InstitucionITextBox);
            this.UpsertPanel.Controls.Add(this.ReceptorTextBox);
            this.UpsertPanel.Controls.Add(this.ReceptorLabel);
            this.UpsertPanel.Controls.Add(this.MontoLabel);
            this.UpsertPanel.Controls.Add(this.MontoTextBox);
            this.UpsertPanel.Controls.Add(this.DescripcionLlabel);
            this.UpsertPanel.Controls.Add(this.DescripcionTextBox);
            this.UpsertPanel.Controls.Add(this.NumeroChequeLabel);
            this.UpsertPanel.Controls.Add(this.EmisorLabel);
            this.UpsertPanel.Controls.Add(this.NumeroChequeTextBox);
            this.UpsertPanel.Controls.Add(this.NombreTextBox);
            this.UpsertPanel.Controls.Add(this.AgregarButton);
            this.UpsertPanel.Controls.Add(this.LimpiarButton);
            this.UpsertPanel.Location = new System.Drawing.Point(0, 0);
            this.UpsertPanel.Name = "UpsertPanel";
            this.UpsertPanel.Size = new System.Drawing.Size(251, 486);
            this.UpsertPanel.TabIndex = 12;
            // 
            // FechaDateTimePicker
            // 
            this.FechaDateTimePicker.Location = new System.Drawing.Point(21, 107);
            this.FechaDateTimePicker.Name = "FechaDateTimePicker";
            this.FechaDateTimePicker.Size = new System.Drawing.Size(205, 20);
            this.FechaDateTimePicker.TabIndex = 2;
            // 
            // FechaLabel
            // 
            this.FechaLabel.AutoSize = true;
            this.FechaLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FechaLabel.Location = new System.Drawing.Point(21, 90);
            this.FechaLabel.Name = "FechaLabel";
            this.FechaLabel.Size = new System.Drawing.Size(37, 13);
            this.FechaLabel.TabIndex = 26;
            this.FechaLabel.Text = "Fecha";
            // 
            // MonedaLabel
            // 
            this.MonedaLabel.AutoSize = true;
            this.MonedaLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MonedaLabel.Location = new System.Drawing.Point(21, 247);
            this.MonedaLabel.Name = "MonedaLabel";
            this.MonedaLabel.Size = new System.Drawing.Size(51, 13);
            this.MonedaLabel.TabIndex = 25;
            this.MonedaLabel.Text = "Monedas";
            // 
            // MonedaComboBox
            // 
            this.MonedaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MonedaComboBox.FormattingEnabled = true;
            this.MonedaComboBox.Items.AddRange(new object[] {
            "Colon",
            "Euro",
            "Dolar",
            "Yen",
            "Peso"});
            this.MonedaComboBox.Location = new System.Drawing.Point(21, 263);
            this.MonedaComboBox.Name = "MonedaComboBox";
            this.MonedaComboBox.Size = new System.Drawing.Size(205, 21);
            this.MonedaComboBox.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(21, 224);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(205, 20);
            this.textBox1.TabIndex = 5;
            // 
            // InstitucionITextBox
            // 
            this.InstitucionITextBox.AutoSize = true;
            this.InstitucionITextBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.InstitucionITextBox.Location = new System.Drawing.Point(21, 208);
            this.InstitucionITextBox.Name = "InstitucionITextBox";
            this.InstitucionITextBox.Size = new System.Drawing.Size(194, 13);
            this.InstitucionITextBox.TabIndex = 22;
            this.InstitucionITextBox.Text = "Institucion Financiera (min 3 caractéres)";
            // 
            // ReceptorTextBox
            // 
            this.ReceptorTextBox.Location = new System.Drawing.Point(21, 67);
            this.ReceptorTextBox.Name = "ReceptorTextBox";
            this.ReceptorTextBox.Size = new System.Drawing.Size(205, 20);
            this.ReceptorTextBox.TabIndex = 1;
            // 
            // ReceptorLabel
            // 
            this.ReceptorLabel.AutoSize = true;
            this.ReceptorLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ReceptorLabel.Location = new System.Drawing.Point(18, 51);
            this.ReceptorLabel.Name = "ReceptorLabel";
            this.ReceptorLabel.Size = new System.Drawing.Size(138, 13);
            this.ReceptorLabel.TabIndex = 17;
            this.ReceptorLabel.Text = "Receptor (min 3 caractéres)";
            // 
            // MontoLabel
            // 
            this.MontoLabel.AutoSize = true;
            this.MontoLabel.ForeColor = System.Drawing.Color.White;
            this.MontoLabel.Location = new System.Drawing.Point(18, 169);
            this.MontoLabel.Name = "MontoLabel";
            this.MontoLabel.Size = new System.Drawing.Size(110, 13);
            this.MontoLabel.TabIndex = 20;
            this.MontoLabel.Text = "Monto (Solo números)";
            // 
            // MontoTextBox
            // 
            this.MontoTextBox.Location = new System.Drawing.Point(21, 185);
            this.MontoTextBox.Name = "MontoTextBox";
            this.MontoTextBox.Size = new System.Drawing.Size(205, 20);
            this.MontoTextBox.TabIndex = 4;
            // 
            // DescripcionLlabel
            // 
            this.DescripcionLlabel.AutoSize = true;
            this.DescripcionLlabel.ForeColor = System.Drawing.Color.White;
            this.DescripcionLlabel.Location = new System.Drawing.Point(18, 330);
            this.DescripcionLlabel.Name = "DescripcionLlabel";
            this.DescripcionLlabel.Size = new System.Drawing.Size(212, 13);
            this.DescripcionLlabel.TabIndex = 18;
            this.DescripcionLlabel.Text = "Descripción( min 10 caractéres, encriptada)";
            // 
            // DescripcionTextBox
            // 
            this.DescripcionTextBox.Location = new System.Drawing.Point(21, 346);
            this.DescripcionTextBox.Multiline = true;
            this.DescripcionTextBox.Name = "DescripcionTextBox";
            this.DescripcionTextBox.Size = new System.Drawing.Size(205, 97);
            this.DescripcionTextBox.TabIndex = 7;
            // 
            // NumeroChequeLabel
            // 
            this.NumeroChequeLabel.AutoSize = true;
            this.NumeroChequeLabel.ForeColor = System.Drawing.Color.White;
            this.NumeroChequeLabel.Location = new System.Drawing.Point(18, 130);
            this.NumeroChequeLabel.Name = "NumeroChequeLabel";
            this.NumeroChequeLabel.Size = new System.Drawing.Size(185, 13);
            this.NumeroChequeLabel.TabIndex = 16;
            this.NumeroChequeLabel.Text = "Número de cheque (min 5 caractéres)";
            // 
            // EmisorLabel
            // 
            this.EmisorLabel.AutoSize = true;
            this.EmisorLabel.ForeColor = System.Drawing.Color.White;
            this.EmisorLabel.Location = new System.Drawing.Point(18, 12);
            this.EmisorLabel.Name = "EmisorLabel";
            this.EmisorLabel.Size = new System.Drawing.Size(125, 13);
            this.EmisorLabel.TabIndex = 15;
            this.EmisorLabel.Text = "Emisor (min 3 caractéres)";
            // 
            // NumeroChequeTextBox
            // 
            this.NumeroChequeTextBox.Location = new System.Drawing.Point(21, 146);
            this.NumeroChequeTextBox.Name = "NumeroChequeTextBox";
            this.NumeroChequeTextBox.Size = new System.Drawing.Size(205, 20);
            this.NumeroChequeTextBox.TabIndex = 3;
            // 
            // NombreTextBox
            // 
            this.NombreTextBox.Location = new System.Drawing.Point(21, 28);
            this.NombreTextBox.Name = "NombreTextBox";
            this.NombreTextBox.Size = new System.Drawing.Size(205, 20);
            this.NombreTextBox.TabIndex = 0;
            // 
            // AgregarButton
            // 
            this.AgregarButton.Location = new System.Drawing.Point(151, 449);
            this.AgregarButton.Name = "AgregarButton";
            this.AgregarButton.Size = new System.Drawing.Size(75, 23);
            this.AgregarButton.TabIndex = 8;
            this.AgregarButton.Text = "Agregar";
            this.AgregarButton.UseVisualStyleBackColor = true;
            this.AgregarButton.Click += new System.EventHandler(this.AgregarButton_Click);
            // 
            // LimpiarButton
            // 
            this.LimpiarButton.Location = new System.Drawing.Point(21, 449);
            this.LimpiarButton.Name = "LimpiarButton";
            this.LimpiarButton.Size = new System.Drawing.Size(75, 23);
            this.LimpiarButton.TabIndex = 11;
            this.LimpiarButton.Text = "Limpiar";
            this.LimpiarButton.UseVisualStyleBackColor = true;
            this.LimpiarButton.Click += new System.EventHandler(this.LimpiarButton_Click);
            // 
            // ListaChequesLabel
            // 
            this.ListaChequesLabel.AutoSize = true;
            this.ListaChequesLabel.BackColor = System.Drawing.Color.Transparent;
            this.ListaChequesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListaChequesLabel.ForeColor = System.Drawing.Color.Black;
            this.ListaChequesLabel.Location = new System.Drawing.Point(448, 12);
            this.ListaChequesLabel.Name = "ListaChequesLabel";
            this.ListaChequesLabel.Size = new System.Drawing.Size(169, 24);
            this.ListaChequesLabel.TabIndex = 15;
            this.ListaChequesLabel.Text = "Lista de cheques";
            // 
            // InformacionRutaLabel
            // 
            this.InformacionRutaLabel.Location = new System.Drawing.Point(279, 37);
            this.InformacionRutaLabel.Name = "InformacionRutaLabel";
            this.InformacionRutaLabel.Size = new System.Drawing.Size(471, 41);
            this.InformacionRutaLabel.TabIndex = 16;
            this.InformacionRutaLabel.Text = "@InformacionRutaArchivos";
            // 
            // BorrarRenglonButton
            // 
            this.BorrarRenglonButton.Location = new System.Drawing.Point(360, 449);
            this.BorrarRenglonButton.Name = "BorrarRenglonButton";
            this.BorrarRenglonButton.Size = new System.Drawing.Size(95, 23);
            this.BorrarRenglonButton.TabIndex = 11;
            this.BorrarRenglonButton.Text = "Borrar renglón";
            this.BorrarRenglonButton.UseVisualStyleBackColor = true;
            this.BorrarRenglonButton.Click += new System.EventHandler(this.BorrarRenglonButton_Click);
            // 
            // InformationProvider
            // 
            this.InformationProvider.ContainerControl = this;
            this.InformationProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("InformationProvider.Icon")));
            // 
            // CreateFilesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(948, 484);
            this.Controls.Add(this.InformacionRutaLabel);
            this.Controls.Add(this.BorrarRenglonButton);
            this.Controls.Add(this.CerrarButton);
            this.Controls.Add(this.UpsertPanel);
            this.Controls.Add(this.CrearArchivoButton);
            this.Controls.Add(this.ChequesDataGridView);
            this.Controls.Add(this.ListaChequesLabel);
            this.Name = "CreateFilesForm";
            this.Text = "Información de archivos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CreateFilesForm_FormClosing);
            this.Load += new System.EventHandler(this.CreateFilesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ChequesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.UpsertPanel.ResumeLayout(false);
            this.UpsertPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InformationProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ChequesDataGridView;
        private System.Windows.Forms.Button CerrarButton;
        private System.Windows.Forms.Button CrearArchivoButton;
        private System.Windows.Forms.ErrorProvider ErrorProvider;
        private System.Windows.Forms.Panel UpsertPanel;
        private System.Windows.Forms.Label MontoLabel;
        private System.Windows.Forms.TextBox MontoTextBox;
        private System.Windows.Forms.Label DescripcionLlabel;
        private System.Windows.Forms.TextBox DescripcionTextBox;
        private System.Windows.Forms.Label NumeroChequeLabel;
        private System.Windows.Forms.Label EmisorLabel;
        private System.Windows.Forms.TextBox NumeroChequeTextBox;
        private System.Windows.Forms.TextBox NombreTextBox;
        private System.Windows.Forms.Button AgregarButton;
        private System.Windows.Forms.Button LimpiarButton;
        private System.Windows.Forms.Label InformacionRutaLabel;
        private System.Windows.Forms.Label ListaChequesLabel;
        private System.Windows.Forms.Button BorrarRenglonButton;
        private System.Windows.Forms.ErrorProvider InformationProvider;
        private System.Windows.Forms.Label MonedaLabel;
        private System.Windows.Forms.ComboBox MonedaComboBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label InstitucionITextBox;
        private System.Windows.Forms.TextBox ReceptorTextBox;
        private System.Windows.Forms.Label ReceptorLabel;
        private System.Windows.Forms.Label FechaLabel;
        private System.Windows.Forms.DateTimePicker FechaDateTimePicker;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReceptorColum;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaColum;
        private System.Windows.Forms.DataGridViewTextBoxColumn InstitucionColum;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroChequeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontoColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripcionColumn;
    }
}

