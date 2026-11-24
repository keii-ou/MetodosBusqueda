#nullable disable
namespace MetodosBusqueda
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle estiloEntero = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle estiloDecimal2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle estiloDecimal3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle estiloEncabezado = new System.Windows.Forms.DataGridViewCellStyle();
            gbParametros = new System.Windows.Forms.GroupBox();
            lblCantidadDatos = new System.Windows.Forms.Label();
            nudCantidadDatos = new System.Windows.Forms.NumericUpDown();
            lblConsultas = new System.Windows.Forms.Label();
            nudConsultas = new System.Windows.Forms.NumericUpDown();
            lblPorcentajeExito = new System.Windows.Forms.Label();
            nudPorcentajeExito = new System.Windows.Forms.NumericUpDown();
            lblFactorRango = new System.Windows.Forms.Label();
            nudFactorRango = new System.Windows.Forms.NumericUpDown();
            lblFactorCarga = new System.Windows.Forms.Label();
            nudFactorCarga = new System.Windows.Forms.NumericUpDown();
            lblSemilla = new System.Windows.Forms.Label();
            nudSemilla = new System.Windows.Forms.NumericUpDown();
            chkSemillaAleatoria = new System.Windows.Forms.CheckBox();
            btnEjecutar = new System.Windows.Forms.Button();
            btnLimpiar = new System.Windows.Forms.Button();
            btnExportar = new System.Windows.Forms.Button();
            tabPrincipal = new System.Windows.Forms.TabControl();
            tabResultados = new System.Windows.Forms.TabPage();
            dgvResultados = new System.Windows.Forms.DataGridView();
            colN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colTecnica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colConsultas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colEncontradas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colCompExito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colCompFallo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colCompGlobal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colCompMax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colIterProm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colIterMax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colPreparacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colBusqueda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            tabDetalle = new System.Windows.Forms.TabPage();
            gbDetalle = new System.Windows.Forms.GroupBox();
            txtDetalle = new System.Windows.Forms.TextBox();
            gbConclusiones = new System.Windows.Forms.GroupBox();
            txtConclusiones = new System.Windows.Forms.TextBox();
            tabIndividual = new System.Windows.Forms.TabPage();
            lblClave = new System.Windows.Forms.Label();
            nudClave = new System.Windows.Forms.NumericUpDown();
            btnBuscarClave = new System.Windows.Forms.Button();
            btnClaveExistente = new System.Windows.Forms.Button();
            lblRangoClave = new System.Windows.Forms.Label();
            txtResultadoClave = new System.Windows.Forms.TextBox();
            statusPrincipal = new System.Windows.Forms.StatusStrip();
            lblEstado = new System.Windows.Forms.ToolStripStatusLabel();
            barraProgreso = new System.Windows.Forms.ToolStripProgressBar();
            sfdCsv = new System.Windows.Forms.SaveFileDialog();
            gbParametros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudCantidadDatos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudConsultas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudPorcentajeExito).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudFactorRango).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudFactorCarga).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudSemilla).BeginInit();
            tabPrincipal.SuspendLayout();
            tabResultados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvResultados).BeginInit();
            tabDetalle.SuspendLayout();
            gbDetalle.SuspendLayout();
            gbConclusiones.SuspendLayout();
            tabIndividual.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudClave).BeginInit();
            statusPrincipal.SuspendLayout();
            SuspendLayout();
            //
            // gbParametros
            //
            gbParametros.Controls.Add(lblCantidadDatos);
            gbParametros.Controls.Add(nudCantidadDatos);
            gbParametros.Controls.Add(lblConsultas);
            gbParametros.Controls.Add(nudConsultas);
            gbParametros.Controls.Add(lblPorcentajeExito);
            gbParametros.Controls.Add(nudPorcentajeExito);
            gbParametros.Controls.Add(lblFactorRango);
            gbParametros.Controls.Add(nudFactorRango);
            gbParametros.Controls.Add(lblFactorCarga);
            gbParametros.Controls.Add(nudFactorCarga);
            gbParametros.Controls.Add(lblSemilla);
            gbParametros.Controls.Add(nudSemilla);
            gbParametros.Controls.Add(chkSemillaAleatoria);
            gbParametros.Controls.Add(btnEjecutar);
            gbParametros.Controls.Add(btnLimpiar);
            gbParametros.Controls.Add(btnExportar);
            gbParametros.Dock = System.Windows.Forms.DockStyle.Top;
            gbParametros.Location = new System.Drawing.Point(0, 0);
            gbParametros.Name = "gbParametros";
            gbParametros.Padding = new System.Windows.Forms.Padding(8);
            gbParametros.Size = new System.Drawing.Size(1200, 170);
            gbParametros.TabIndex = 0;
            gbParametros.TabStop = false;
            gbParametros.Text = "Parámetros del experimento";
            //
            // lblCantidadDatos
            //
            lblCantidadDatos.AutoSize = true;
            lblCantidadDatos.Location = new System.Drawing.Point(20, 36);
            lblCantidadDatos.Name = "lblCantidadDatos";
            lblCantidadDatos.Size = new System.Drawing.Size(130, 20);
            lblCantidadDatos.TabIndex = 0;
            lblCantidadDatos.Text = "Cantidad de datos (N):";
            //
            // nudCantidadDatos
            //
            nudCantidadDatos.Increment = new decimal(new int[] { 1000, 0, 0, 0 });
            nudCantidadDatos.Location = new System.Drawing.Point(220, 32);
            nudCantidadDatos.Maximum = new decimal(new int[] { 2000000, 0, 0, 0 });
            nudCantidadDatos.Minimum = new decimal(new int[] { 100, 0, 0, 0 });
            nudCantidadDatos.Name = "nudCantidadDatos";
            nudCantidadDatos.Size = new System.Drawing.Size(120, 27);
            nudCantidadDatos.TabIndex = 1;
            nudCantidadDatos.ThousandsSeparator = true;
            nudCantidadDatos.Value = new decimal(new int[] { 10000, 0, 0, 0 });
            //
            // lblConsultas
            //
            lblConsultas.AutoSize = true;
            lblConsultas.Location = new System.Drawing.Point(380, 36);
            lblConsultas.Name = "lblConsultas";
            lblConsultas.Size = new System.Drawing.Size(130, 20);
            lblConsultas.TabIndex = 2;
            lblConsultas.Text = "Consultas por técnica:";
            //
            // nudConsultas
            //
            nudConsultas.Increment = new decimal(new int[] { 100, 0, 0, 0 });
            nudConsultas.Location = new System.Drawing.Point(560, 32);
            nudConsultas.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nudConsultas.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudConsultas.Name = "nudConsultas";
            nudConsultas.Size = new System.Drawing.Size(100, 27);
            nudConsultas.TabIndex = 3;
            nudConsultas.ThousandsSeparator = true;
            nudConsultas.Value = new decimal(new int[] { 1000, 0, 0, 0 });
            //
            // lblPorcentajeExito
            //
            lblPorcentajeExito.AutoSize = true;
            lblPorcentajeExito.Location = new System.Drawing.Point(700, 36);
            lblPorcentajeExito.Name = "lblPorcentajeExito";
            lblPorcentajeExito.Size = new System.Drawing.Size(150, 20);
            lblPorcentajeExito.TabIndex = 4;
            lblPorcentajeExito.Text = "Búsquedas exitosas (%):";
            //
            // nudPorcentajeExito
            //
            nudPorcentajeExito.Location = new System.Drawing.Point(880, 32);
            nudPorcentajeExito.Name = "nudPorcentajeExito";
            nudPorcentajeExito.Size = new System.Drawing.Size(80, 27);
            nudPorcentajeExito.TabIndex = 5;
            nudPorcentajeExito.Value = new decimal(new int[] { 50, 0, 0, 0 });
            //
            // lblFactorRango
            //
            lblFactorRango.AutoSize = true;
            lblFactorRango.Location = new System.Drawing.Point(20, 76);
            lblFactorRango.Name = "lblFactorRango";
            lblFactorRango.Size = new System.Drawing.Size(170, 20);
            lblFactorRango.TabIndex = 6;
            lblFactorRango.Text = "Factor del rango de valores:";
            //
            // nudFactorRango
            //
            nudFactorRango.Location = new System.Drawing.Point(220, 72);
            nudFactorRango.Maximum = new decimal(new int[] { 100, 0, 0, 0 });
            nudFactorRango.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            nudFactorRango.Name = "nudFactorRango";
            nudFactorRango.Size = new System.Drawing.Size(120, 27);
            nudFactorRango.TabIndex = 7;
            nudFactorRango.Value = new decimal(new int[] { 10, 0, 0, 0 });
            //
            // lblFactorCarga
            //
            lblFactorCarga.AutoSize = true;
            lblFactorCarga.Location = new System.Drawing.Point(380, 76);
            lblFactorCarga.Name = "lblFactorCarga";
            lblFactorCarga.Size = new System.Drawing.Size(130, 20);
            lblFactorCarga.TabIndex = 8;
            lblFactorCarga.Text = "Factor de carga hash:";
            //
            // nudFactorCarga
            //
            nudFactorCarga.DecimalPlaces = 2;
            nudFactorCarga.Increment = new decimal(new int[] { 5, 0, 0, 131072 });
            nudFactorCarga.Location = new System.Drawing.Point(560, 72);
            nudFactorCarga.Maximum = new decimal(new int[] { 500, 0, 0, 131072 });
            nudFactorCarga.Minimum = new decimal(new int[] { 10, 0, 0, 131072 });
            nudFactorCarga.Name = "nudFactorCarga";
            nudFactorCarga.Size = new System.Drawing.Size(100, 27);
            nudFactorCarga.TabIndex = 9;
            nudFactorCarga.Value = new decimal(new int[] { 75, 0, 0, 131072 });
            //
            // lblSemilla
            //
            lblSemilla.AutoSize = true;
            lblSemilla.Location = new System.Drawing.Point(700, 76);
            lblSemilla.Name = "lblSemilla";
            lblSemilla.Size = new System.Drawing.Size(60, 20);
            lblSemilla.TabIndex = 10;
            lblSemilla.Text = "Semilla:";
            //
            // nudSemilla
            //
            nudSemilla.Location = new System.Drawing.Point(880, 72);
            nudSemilla.Maximum = new decimal(new int[] { int.MaxValue, 0, 0, 0 });
            nudSemilla.Name = "nudSemilla";
            nudSemilla.Size = new System.Drawing.Size(100, 27);
            nudSemilla.TabIndex = 11;
            nudSemilla.Value = new decimal(new int[] { 2026, 0, 0, 0 });
            //
            // chkSemillaAleatoria
            //
            chkSemillaAleatoria.AutoSize = true;
            chkSemillaAleatoria.Location = new System.Drawing.Point(1000, 74);
            chkSemillaAleatoria.Name = "chkSemillaAleatoria";
            chkSemillaAleatoria.Size = new System.Drawing.Size(145, 24);
            chkSemillaAleatoria.TabIndex = 12;
            chkSemillaAleatoria.Text = "Semilla aleatoria";
            chkSemillaAleatoria.UseVisualStyleBackColor = true;
            chkSemillaAleatoria.CheckedChanged += chkSemillaAleatoria_CheckedChanged;
            //
            // btnEjecutar
            //
            btnEjecutar.Location = new System.Drawing.Point(20, 118);
            btnEjecutar.Name = "btnEjecutar";
            btnEjecutar.Size = new System.Drawing.Size(180, 38);
            btnEjecutar.TabIndex = 13;
            btnEjecutar.Text = "Ejecutar experimento";
            btnEjecutar.UseVisualStyleBackColor = true;
            btnEjecutar.Click += btnEjecutar_Click;
            //
            // btnLimpiar
            //
            btnLimpiar.Location = new System.Drawing.Point(216, 118);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new System.Drawing.Size(140, 38);
            btnLimpiar.TabIndex = 14;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            //
            // btnExportar
            //
            btnExportar.Location = new System.Drawing.Point(372, 118);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new System.Drawing.Size(180, 38);
            btnExportar.TabIndex = 15;
            btnExportar.Text = "Exportar a CSV";
            btnExportar.UseVisualStyleBackColor = true;
            btnExportar.Click += btnExportar_Click;
            //
            // tabPrincipal
            //
            tabPrincipal.Controls.Add(tabResultados);
            tabPrincipal.Controls.Add(tabDetalle);
            tabPrincipal.Controls.Add(tabIndividual);
            tabPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            tabPrincipal.Location = new System.Drawing.Point(0, 170);
            tabPrincipal.Name = "tabPrincipal";
            tabPrincipal.SelectedIndex = 0;
            tabPrincipal.Size = new System.Drawing.Size(1200, 498);
            tabPrincipal.TabIndex = 1;
            //
            // tabResultados
            //
            tabResultados.Controls.Add(dgvResultados);
            tabResultados.Location = new System.Drawing.Point(4, 29);
            tabResultados.Name = "tabResultados";
            tabResultados.Padding = new System.Windows.Forms.Padding(3);
            tabResultados.Size = new System.Drawing.Size(1192, 465);
            tabResultados.TabIndex = 0;
            tabResultados.Text = "Resultados";
            tabResultados.UseVisualStyleBackColor = true;
            //
            // dgvResultados
            //
            dgvResultados.AllowUserToAddRows = false;
            dgvResultados.AllowUserToDeleteRows = false;
            dgvResultados.AllowUserToResizeRows = false;
            dgvResultados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvResultados.BackgroundColor = System.Drawing.SystemColors.Window;
            estiloEncabezado.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            estiloEncabezado.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvResultados.ColumnHeadersDefaultCellStyle = estiloEncabezado;
            dgvResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResultados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                colN, colTecnica, colConsultas, colEncontradas, colCompExito, colCompFallo,
                colCompGlobal, colCompMax, colIterProm, colIterMax, colPreparacion, colBusqueda });
            dgvResultados.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvResultados.Location = new System.Drawing.Point(3, 3);
            dgvResultados.Name = "dgvResultados";
            dgvResultados.ReadOnly = true;
            dgvResultados.RowHeadersVisible = false;
            dgvResultados.RowHeadersWidth = 51;
            dgvResultados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvResultados.Size = new System.Drawing.Size(1186, 459);
            dgvResultados.TabIndex = 0;
            //
            // estilos de celda compartidos por las columnas numéricas
            //
            estiloEntero.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            estiloEntero.Format = "N0";
            estiloDecimal2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            estiloDecimal2.Format = "N2";
            estiloDecimal3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            estiloDecimal3.Format = "N3";
            //
            // colN
            //
            colN.DefaultCellStyle = estiloEntero;
            colN.FillWeight = 70F;
            colN.HeaderText = "N";
            colN.MinimumWidth = 6;
            colN.Name = "colN";
            colN.ReadOnly = true;
            //
            // colTecnica
            //
            colTecnica.FillWeight = 130F;
            colTecnica.HeaderText = "Técnica";
            colTecnica.MinimumWidth = 6;
            colTecnica.Name = "colTecnica";
            colTecnica.ReadOnly = true;
            //
            // colConsultas
            //
            colConsultas.DefaultCellStyle = estiloEntero;
            colConsultas.FillWeight = 70F;
            colConsultas.HeaderText = "Consultas";
            colConsultas.MinimumWidth = 6;
            colConsultas.Name = "colConsultas";
            colConsultas.ReadOnly = true;
            //
            // colEncontradas
            //
            colEncontradas.DefaultCellStyle = estiloEntero;
            colEncontradas.FillWeight = 80F;
            colEncontradas.HeaderText = "Encontradas";
            colEncontradas.MinimumWidth = 6;
            colEncontradas.Name = "colEncontradas";
            colEncontradas.ReadOnly = true;
            //
            // colCompExito
            //
            colCompExito.DefaultCellStyle = estiloDecimal2;
            colCompExito.HeaderText = "Comp. prom. (éxito)";
            colCompExito.MinimumWidth = 6;
            colCompExito.Name = "colCompExito";
            colCompExito.ReadOnly = true;
            //
            // colCompFallo
            //
            colCompFallo.DefaultCellStyle = estiloDecimal2;
            colCompFallo.HeaderText = "Comp. prom. (fallo)";
            colCompFallo.MinimumWidth = 6;
            colCompFallo.Name = "colCompFallo";
            colCompFallo.ReadOnly = true;
            //
            // colCompGlobal
            //
            colCompGlobal.DefaultCellStyle = estiloDecimal2;
            colCompGlobal.HeaderText = "Comp. prom. (global)";
            colCompGlobal.MinimumWidth = 6;
            colCompGlobal.Name = "colCompGlobal";
            colCompGlobal.ReadOnly = true;
            //
            // colCompMax
            //
            colCompMax.DefaultCellStyle = estiloEntero;
            colCompMax.FillWeight = 80F;
            colCompMax.HeaderText = "Comp. máx.";
            colCompMax.MinimumWidth = 6;
            colCompMax.Name = "colCompMax";
            colCompMax.ReadOnly = true;
            //
            // colIterProm
            //
            colIterProm.DefaultCellStyle = estiloDecimal2;
            colIterProm.FillWeight = 80F;
            colIterProm.HeaderText = "Iter. prom.";
            colIterProm.MinimumWidth = 6;
            colIterProm.Name = "colIterProm";
            colIterProm.ReadOnly = true;
            //
            // colIterMax
            //
            colIterMax.DefaultCellStyle = estiloEntero;
            colIterMax.FillWeight = 80F;
            colIterMax.HeaderText = "Iter. máx.";
            colIterMax.MinimumWidth = 6;
            colIterMax.Name = "colIterMax";
            colIterMax.ReadOnly = true;
            //
            // colPreparacion
            //
            colPreparacion.DefaultCellStyle = estiloDecimal3;
            colPreparacion.HeaderText = "Preparación (ms)";
            colPreparacion.MinimumWidth = 6;
            colPreparacion.Name = "colPreparacion";
            colPreparacion.ReadOnly = true;
            //
            // colBusqueda
            //
            colBusqueda.DefaultCellStyle = estiloDecimal3;
            colBusqueda.HeaderText = "Búsqueda total (ms)";
            colBusqueda.MinimumWidth = 6;
            colBusqueda.Name = "colBusqueda";
            colBusqueda.ReadOnly = true;
            //
            // tabDetalle
            //
            tabDetalle.Controls.Add(gbDetalle);
            tabDetalle.Controls.Add(gbConclusiones);
            tabDetalle.Location = new System.Drawing.Point(4, 29);
            tabDetalle.Name = "tabDetalle";
            tabDetalle.Padding = new System.Windows.Forms.Padding(3);
            tabDetalle.Size = new System.Drawing.Size(1192, 465);
            tabDetalle.TabIndex = 1;
            tabDetalle.Text = "Detalle y conclusiones";
            tabDetalle.UseVisualStyleBackColor = true;
            //
            // gbDetalle
            //
            gbDetalle.Controls.Add(txtDetalle);
            gbDetalle.Dock = System.Windows.Forms.DockStyle.Fill;
            gbDetalle.Location = new System.Drawing.Point(3, 3);
            gbDetalle.Name = "gbDetalle";
            gbDetalle.Padding = new System.Windows.Forms.Padding(8);
            gbDetalle.Size = new System.Drawing.Size(1186, 249);
            gbDetalle.TabIndex = 0;
            gbDetalle.TabStop = false;
            gbDetalle.Text = "Detalle de la última corrida";
            //
            // txtDetalle
            //
            txtDetalle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtDetalle.Dock = System.Windows.Forms.DockStyle.Fill;
            txtDetalle.Font = new System.Drawing.Font("Consolas", 10F);
            txtDetalle.Location = new System.Drawing.Point(8, 28);
            txtDetalle.Multiline = true;
            txtDetalle.Name = "txtDetalle";
            txtDetalle.ReadOnly = true;
            txtDetalle.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            txtDetalle.Size = new System.Drawing.Size(1170, 213);
            txtDetalle.TabIndex = 0;
            //
            // gbConclusiones
            //
            gbConclusiones.Controls.Add(txtConclusiones);
            gbConclusiones.Dock = System.Windows.Forms.DockStyle.Bottom;
            gbConclusiones.Location = new System.Drawing.Point(3, 252);
            gbConclusiones.Name = "gbConclusiones";
            gbConclusiones.Padding = new System.Windows.Forms.Padding(8);
            gbConclusiones.Size = new System.Drawing.Size(1186, 210);
            gbConclusiones.TabIndex = 1;
            gbConclusiones.TabStop = false;
            gbConclusiones.Text = "Conclusiones generadas con los datos de la corrida";
            //
            // txtConclusiones
            //
            txtConclusiones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtConclusiones.Dock = System.Windows.Forms.DockStyle.Fill;
            txtConclusiones.Location = new System.Drawing.Point(8, 28);
            txtConclusiones.Multiline = true;
            txtConclusiones.Name = "txtConclusiones";
            txtConclusiones.ReadOnly = true;
            txtConclusiones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            txtConclusiones.Size = new System.Drawing.Size(1170, 174);
            txtConclusiones.TabIndex = 0;
            //
            // tabIndividual
            //
            tabIndividual.Controls.Add(lblClave);
            tabIndividual.Controls.Add(nudClave);
            tabIndividual.Controls.Add(btnBuscarClave);
            tabIndividual.Controls.Add(btnClaveExistente);
            tabIndividual.Controls.Add(lblRangoClave);
            tabIndividual.Controls.Add(txtResultadoClave);
            tabIndividual.Location = new System.Drawing.Point(4, 29);
            tabIndividual.Name = "tabIndividual";
            tabIndividual.Padding = new System.Windows.Forms.Padding(3);
            tabIndividual.Size = new System.Drawing.Size(1192, 465);
            tabIndividual.TabIndex = 2;
            tabIndividual.Text = "Búsqueda individual";
            tabIndividual.UseVisualStyleBackColor = true;
            //
            // lblClave
            //
            lblClave.AutoSize = true;
            lblClave.Location = new System.Drawing.Point(20, 26);
            lblClave.Name = "lblClave";
            lblClave.Size = new System.Drawing.Size(105, 20);
            lblClave.TabIndex = 0;
            lblClave.Text = "Clave a buscar:";
            //
            // nudClave
            //
            nudClave.Location = new System.Drawing.Point(150, 22);
            nudClave.Maximum = new decimal(new int[] { int.MaxValue, 0, 0, 0 });
            nudClave.Name = "nudClave";
            nudClave.Size = new System.Drawing.Size(130, 27);
            nudClave.TabIndex = 1;
            //
            // btnBuscarClave
            //
            btnBuscarClave.Location = new System.Drawing.Point(300, 18);
            btnBuscarClave.Name = "btnBuscarClave";
            btnBuscarClave.Size = new System.Drawing.Size(230, 36);
            btnBuscarClave.TabIndex = 2;
            btnBuscarClave.Text = "Buscar con las tres técnicas";
            btnBuscarClave.UseVisualStyleBackColor = true;
            btnBuscarClave.Click += btnBuscarClave_Click;
            //
            // btnClaveExistente
            //
            btnClaveExistente.Location = new System.Drawing.Point(546, 18);
            btnClaveExistente.Name = "btnClaveExistente";
            btnClaveExistente.Size = new System.Drawing.Size(230, 36);
            btnClaveExistente.TabIndex = 3;
            btnClaveExistente.Text = "Tomar una clave existente";
            btnClaveExistente.UseVisualStyleBackColor = true;
            btnClaveExistente.Click += btnClaveExistente_Click;
            //
            // lblRangoClave
            //
            lblRangoClave.AutoSize = true;
            lblRangoClave.Location = new System.Drawing.Point(20, 68);
            lblRangoClave.Name = "lblRangoClave";
            lblRangoClave.Size = new System.Drawing.Size(60, 20);
            lblRangoClave.TabIndex = 4;
            lblRangoClave.Text = "Rango";
            //
            // txtResultadoClave
            //
            txtResultadoClave.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtResultadoClave.Font = new System.Drawing.Font("Consolas", 10F);
            txtResultadoClave.Location = new System.Drawing.Point(20, 100);
            txtResultadoClave.Multiline = true;
            txtResultadoClave.Name = "txtResultadoClave";
            txtResultadoClave.ReadOnly = true;
            txtResultadoClave.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            txtResultadoClave.Size = new System.Drawing.Size(1150, 350);
            txtResultadoClave.TabIndex = 5;
            //
            // statusPrincipal
            //
            statusPrincipal.ImageScalingSize = new System.Drawing.Size(20, 20);
            statusPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { lblEstado, barraProgreso });
            statusPrincipal.Location = new System.Drawing.Point(0, 668);
            statusPrincipal.Name = "statusPrincipal";
            statusPrincipal.Size = new System.Drawing.Size(1200, 32);
            statusPrincipal.TabIndex = 2;
            //
            // lblEstado
            //
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new System.Drawing.Size(1000, 26);
            lblEstado.Spring = true;
            lblEstado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // barraProgreso
            //
            barraProgreso.MarqueeAnimationSpeed = 30;
            barraProgreso.Name = "barraProgreso";
            barraProgreso.Size = new System.Drawing.Size(150, 24);
            barraProgreso.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            barraProgreso.Visible = false;
            //
            // sfdCsv
            //
            sfdCsv.DefaultExt = "csv";
            //
            // Form1
            //
            AcceptButton = btnEjecutar;
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1200, 700);
            Controls.Add(tabPrincipal);
            Controls.Add(gbParametros);
            Controls.Add(statusPrincipal);
            MinimumSize = new System.Drawing.Size(1000, 640);
            Name = "Form1";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Form1";
            gbParametros.ResumeLayout(false);
            gbParametros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudCantidadDatos).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudConsultas).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudPorcentajeExito).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudFactorRango).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudFactorCarga).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudSemilla).EndInit();
            tabPrincipal.ResumeLayout(false);
            tabResultados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvResultados).EndInit();
            tabDetalle.ResumeLayout(false);
            gbDetalle.ResumeLayout(false);
            gbDetalle.PerformLayout();
            gbConclusiones.ResumeLayout(false);
            gbConclusiones.PerformLayout();
            tabIndividual.ResumeLayout(false);
            tabIndividual.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudClave).EndInit();
            statusPrincipal.ResumeLayout(false);
            statusPrincipal.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.GroupBox gbParametros;
        private System.Windows.Forms.Label lblCantidadDatos;
        private System.Windows.Forms.NumericUpDown nudCantidadDatos;
        private System.Windows.Forms.Label lblConsultas;
        private System.Windows.Forms.NumericUpDown nudConsultas;
        private System.Windows.Forms.Label lblPorcentajeExito;
        private System.Windows.Forms.NumericUpDown nudPorcentajeExito;
        private System.Windows.Forms.Label lblFactorRango;
        private System.Windows.Forms.NumericUpDown nudFactorRango;
        private System.Windows.Forms.Label lblFactorCarga;
        private System.Windows.Forms.NumericUpDown nudFactorCarga;
        private System.Windows.Forms.Label lblSemilla;
        private System.Windows.Forms.NumericUpDown nudSemilla;
        private System.Windows.Forms.CheckBox chkSemillaAleatoria;
        private System.Windows.Forms.Button btnEjecutar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.TabControl tabPrincipal;
        private System.Windows.Forms.TabPage tabResultados;
        private System.Windows.Forms.DataGridView dgvResultados;
        private System.Windows.Forms.DataGridViewTextBoxColumn colN;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTecnica;
        private System.Windows.Forms.DataGridViewTextBoxColumn colConsultas;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEncontradas;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCompExito;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCompFallo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCompGlobal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCompMax;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIterProm;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIterMax;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPreparacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBusqueda;
        private System.Windows.Forms.TabPage tabDetalle;
        private System.Windows.Forms.GroupBox gbDetalle;
        private System.Windows.Forms.TextBox txtDetalle;
        private System.Windows.Forms.GroupBox gbConclusiones;
        private System.Windows.Forms.TextBox txtConclusiones;
        private System.Windows.Forms.TabPage tabIndividual;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.NumericUpDown nudClave;
        private System.Windows.Forms.Button btnBuscarClave;
        private System.Windows.Forms.Button btnClaveExistente;
        private System.Windows.Forms.Label lblRangoClave;
        private System.Windows.Forms.TextBox txtResultadoClave;
        private System.Windows.Forms.StatusStrip statusPrincipal;
        private System.Windows.Forms.ToolStripStatusLabel lblEstado;
        private System.Windows.Forms.ToolStripProgressBar barraProgreso;
        private System.Windows.Forms.SaveFileDialog sfdCsv;
    }
}
