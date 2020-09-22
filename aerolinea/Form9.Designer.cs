namespace aerolinea
{
    partial class Form9
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
            System.Windows.Forms.Label id_vueloLabel;
            System.Windows.Forms.Label id_avionLabel;
            System.Windows.Forms.Label origenLabel;
            System.Windows.Forms.Label destinoLabel;
            System.Windows.Forms.Label f_salidaLabel;
            System.Windows.Forms.Label f_llegadaLabel;
            System.Windows.Forms.Label h_salidaLabel;
            System.Windows.Forms.Label h_llegadaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form9));
            this.aerolineaDataSet = new aerolinea.aerolineaDataSet();
            this.vuelosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vuelosTableAdapter = new aerolinea.aerolineaDataSetTableAdapters.VuelosTableAdapter();
            this.tableAdapterManager = new aerolinea.aerolineaDataSetTableAdapters.TableAdapterManager();
            this.vuelosBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.mENUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.id_vueloTextBox = new System.Windows.Forms.TextBox();
            this.id_avionTextBox = new System.Windows.Forms.TextBox();
            this.origenTextBox = new System.Windows.Forms.TextBox();
            this.destinoTextBox = new System.Windows.Forms.TextBox();
            this.f_salidaTextBox = new System.Windows.Forms.TextBox();
            this.f_llegadaTextBox = new System.Windows.Forms.TextBox();
            this.h_salidaTextBox = new System.Windows.Forms.TextBox();
            this.h_llegadaTextBox = new System.Windows.Forms.TextBox();
            this.vuelosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            id_vueloLabel = new System.Windows.Forms.Label();
            id_avionLabel = new System.Windows.Forms.Label();
            origenLabel = new System.Windows.Forms.Label();
            destinoLabel = new System.Windows.Forms.Label();
            f_salidaLabel = new System.Windows.Forms.Label();
            f_llegadaLabel = new System.Windows.Forms.Label();
            h_salidaLabel = new System.Windows.Forms.Label();
            h_llegadaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.aerolineaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vuelosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vuelosBindingNavigator)).BeginInit();
            this.vuelosBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vuelosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // id_vueloLabel
            // 
            id_vueloLabel.AutoSize = true;
            id_vueloLabel.BackColor = System.Drawing.Color.Transparent;
            id_vueloLabel.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            id_vueloLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            id_vueloLabel.Location = new System.Drawing.Point(12, 42);
            id_vueloLabel.Name = "id_vueloLabel";
            id_vueloLabel.Size = new System.Drawing.Size(57, 13);
            id_vueloLabel.TabIndex = 1;
            id_vueloLabel.Text = "Id. Vuelo:";
            // 
            // id_avionLabel
            // 
            id_avionLabel.AutoSize = true;
            id_avionLabel.BackColor = System.Drawing.Color.Transparent;
            id_avionLabel.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            id_avionLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            id_avionLabel.Location = new System.Drawing.Point(12, 68);
            id_avionLabel.Name = "id_avionLabel";
            id_avionLabel.Size = new System.Drawing.Size(55, 13);
            id_avionLabel.TabIndex = 3;
            id_avionLabel.Text = "Id. Avion:";
            // 
            // origenLabel
            // 
            origenLabel.AutoSize = true;
            origenLabel.BackColor = System.Drawing.Color.Transparent;
            origenLabel.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            origenLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            origenLabel.Location = new System.Drawing.Point(12, 94);
            origenLabel.Name = "origenLabel";
            origenLabel.Size = new System.Drawing.Size(49, 13);
            origenLabel.TabIndex = 5;
            origenLabel.Text = "Origen:";
            // 
            // destinoLabel
            // 
            destinoLabel.AutoSize = true;
            destinoLabel.BackColor = System.Drawing.Color.Transparent;
            destinoLabel.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            destinoLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            destinoLabel.Location = new System.Drawing.Point(12, 120);
            destinoLabel.Name = "destinoLabel";
            destinoLabel.Size = new System.Drawing.Size(51, 13);
            destinoLabel.TabIndex = 7;
            destinoLabel.Text = "Destino:";
            // 
            // f_salidaLabel
            // 
            f_salidaLabel.AutoSize = true;
            f_salidaLabel.BackColor = System.Drawing.Color.Transparent;
            f_salidaLabel.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            f_salidaLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            f_salidaLabel.Location = new System.Drawing.Point(12, 146);
            f_salidaLabel.Name = "f_salidaLabel";
            f_salidaLabel.Size = new System.Drawing.Size(55, 13);
            f_salidaLabel.TabIndex = 9;
            f_salidaLabel.Text = "F. Salida:";
            // 
            // f_llegadaLabel
            // 
            f_llegadaLabel.AutoSize = true;
            f_llegadaLabel.BackColor = System.Drawing.Color.Transparent;
            f_llegadaLabel.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            f_llegadaLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            f_llegadaLabel.Location = new System.Drawing.Point(12, 172);
            f_llegadaLabel.Name = "f_llegadaLabel";
            f_llegadaLabel.Size = new System.Drawing.Size(63, 13);
            f_llegadaLabel.TabIndex = 11;
            f_llegadaLabel.Text = "F. Llegada:";
            // 
            // h_salidaLabel
            // 
            h_salidaLabel.AutoSize = true;
            h_salidaLabel.BackColor = System.Drawing.Color.Transparent;
            h_salidaLabel.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            h_salidaLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            h_salidaLabel.Location = new System.Drawing.Point(12, 198);
            h_salidaLabel.Name = "h_salidaLabel";
            h_salidaLabel.Size = new System.Drawing.Size(59, 13);
            h_salidaLabel.TabIndex = 13;
            h_salidaLabel.Text = "H. Salida:";
            // 
            // h_llegadaLabel
            // 
            h_llegadaLabel.AutoSize = true;
            h_llegadaLabel.BackColor = System.Drawing.Color.Transparent;
            h_llegadaLabel.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            h_llegadaLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            h_llegadaLabel.Location = new System.Drawing.Point(12, 224);
            h_llegadaLabel.Name = "h_llegadaLabel";
            h_llegadaLabel.Size = new System.Drawing.Size(67, 13);
            h_llegadaLabel.TabIndex = 15;
            h_llegadaLabel.Text = "H. Llegada:";
            // 
            // aerolineaDataSet
            // 
            this.aerolineaDataSet.DataSetName = "aerolineaDataSet";
            this.aerolineaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vuelosBindingSource
            // 
            this.vuelosBindingSource.DataMember = "Vuelos";
            this.vuelosBindingSource.DataSource = this.aerolineaDataSet;
            // 
            // vuelosTableAdapter
            // 
            this.vuelosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AvionesTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.lis_pasajerosTableAdapter = null;
            this.tableAdapterManager.PasajerosTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = aerolinea.aerolineaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VuelosTableAdapter = this.vuelosTableAdapter;
            // 
            // vuelosBindingNavigator
            // 
            this.vuelosBindingNavigator.AddNewItem = null;
            this.vuelosBindingNavigator.BindingSource = this.vuelosBindingSource;
            this.vuelosBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.vuelosBindingNavigator.DeleteItem = null;
            this.vuelosBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.vuelosBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.vuelosBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.vuelosBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.vuelosBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.vuelosBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.vuelosBindingNavigator.Name = "vuelosBindingNavigator";
            this.vuelosBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.vuelosBindingNavigator.Size = new System.Drawing.Size(607, 25);
            this.vuelosBindingNavigator.TabIndex = 0;
            this.vuelosBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mENUToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(29, 22);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // mENUToolStripMenuItem
            // 
            this.mENUToolStripMenuItem.Name = "mENUToolStripMenuItem";
            this.mENUToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.mENUToolStripMenuItem.Text = "MENU";
            this.mENUToolStripMenuItem.Click += new System.EventHandler(this.mENUToolStripMenuItem_Click);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // id_vueloTextBox
            // 
            this.id_vueloTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vuelosBindingSource, "Id_vuelo", true));
            this.id_vueloTextBox.Location = new System.Drawing.Point(80, 39);
            this.id_vueloTextBox.Name = "id_vueloTextBox";
            this.id_vueloTextBox.ReadOnly = true;
            this.id_vueloTextBox.Size = new System.Drawing.Size(185, 20);
            this.id_vueloTextBox.TabIndex = 2;
            // 
            // id_avionTextBox
            // 
            this.id_avionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vuelosBindingSource, "id_avion", true));
            this.id_avionTextBox.Location = new System.Drawing.Point(80, 65);
            this.id_avionTextBox.Name = "id_avionTextBox";
            this.id_avionTextBox.ReadOnly = true;
            this.id_avionTextBox.Size = new System.Drawing.Size(185, 20);
            this.id_avionTextBox.TabIndex = 4;
            // 
            // origenTextBox
            // 
            this.origenTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vuelosBindingSource, "origen", true));
            this.origenTextBox.Location = new System.Drawing.Point(80, 91);
            this.origenTextBox.Name = "origenTextBox";
            this.origenTextBox.ReadOnly = true;
            this.origenTextBox.Size = new System.Drawing.Size(185, 20);
            this.origenTextBox.TabIndex = 6;
            // 
            // destinoTextBox
            // 
            this.destinoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vuelosBindingSource, "destino", true));
            this.destinoTextBox.Location = new System.Drawing.Point(80, 117);
            this.destinoTextBox.Name = "destinoTextBox";
            this.destinoTextBox.ReadOnly = true;
            this.destinoTextBox.Size = new System.Drawing.Size(185, 20);
            this.destinoTextBox.TabIndex = 8;
            // 
            // f_salidaTextBox
            // 
            this.f_salidaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vuelosBindingSource, "f_salida", true));
            this.f_salidaTextBox.Location = new System.Drawing.Point(80, 143);
            this.f_salidaTextBox.Name = "f_salidaTextBox";
            this.f_salidaTextBox.ReadOnly = true;
            this.f_salidaTextBox.Size = new System.Drawing.Size(185, 20);
            this.f_salidaTextBox.TabIndex = 10;
            // 
            // f_llegadaTextBox
            // 
            this.f_llegadaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vuelosBindingSource, "f_llegada", true));
            this.f_llegadaTextBox.Location = new System.Drawing.Point(80, 169);
            this.f_llegadaTextBox.Name = "f_llegadaTextBox";
            this.f_llegadaTextBox.ReadOnly = true;
            this.f_llegadaTextBox.Size = new System.Drawing.Size(185, 20);
            this.f_llegadaTextBox.TabIndex = 12;
            // 
            // h_salidaTextBox
            // 
            this.h_salidaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vuelosBindingSource, "h_salida", true));
            this.h_salidaTextBox.Location = new System.Drawing.Point(80, 195);
            this.h_salidaTextBox.Name = "h_salidaTextBox";
            this.h_salidaTextBox.ReadOnly = true;
            this.h_salidaTextBox.Size = new System.Drawing.Size(185, 20);
            this.h_salidaTextBox.TabIndex = 14;
            // 
            // h_llegadaTextBox
            // 
            this.h_llegadaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vuelosBindingSource, "h_llegada", true));
            this.h_llegadaTextBox.Location = new System.Drawing.Point(80, 221);
            this.h_llegadaTextBox.Name = "h_llegadaTextBox";
            this.h_llegadaTextBox.ReadOnly = true;
            this.h_llegadaTextBox.Size = new System.Drawing.Size(185, 20);
            this.h_llegadaTextBox.TabIndex = 16;
            // 
            // vuelosDataGridView
            // 
            this.vuelosDataGridView.AllowUserToAddRows = false;
            this.vuelosDataGridView.AllowUserToDeleteRows = false;
            this.vuelosDataGridView.AllowUserToOrderColumns = true;
            this.vuelosDataGridView.AutoGenerateColumns = false;
            this.vuelosDataGridView.BackgroundColor = System.Drawing.Color.PowderBlue;
            this.vuelosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vuelosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.vuelosDataGridView.DataSource = this.vuelosBindingSource;
            this.vuelosDataGridView.Location = new System.Drawing.Point(12, 247);
            this.vuelosDataGridView.Name = "vuelosDataGridView";
            this.vuelosDataGridView.ReadOnly = true;
            this.vuelosDataGridView.Size = new System.Drawing.Size(584, 220);
            this.vuelosDataGridView.TabIndex = 17;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id_vuelo";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id_vuelo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "id_avion";
            this.dataGridViewTextBoxColumn2.HeaderText = "id_avion";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "origen";
            this.dataGridViewTextBoxColumn3.HeaderText = "origen";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "destino";
            this.dataGridViewTextBoxColumn4.HeaderText = "destino";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "f_salida";
            this.dataGridViewTextBoxColumn5.HeaderText = "f_salida";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "f_llegada";
            this.dataGridViewTextBoxColumn6.HeaderText = "f_llegada";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "h_salida";
            this.dataGridViewTextBoxColumn7.HeaderText = "h_salida";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn8.DataPropertyName = "h_llegada";
            this.dataGridViewTextBoxColumn8.HeaderText = "h_llegada";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(607, 492);
            this.Controls.Add(this.vuelosDataGridView);
            this.Controls.Add(id_vueloLabel);
            this.Controls.Add(this.id_vueloTextBox);
            this.Controls.Add(id_avionLabel);
            this.Controls.Add(this.id_avionTextBox);
            this.Controls.Add(origenLabel);
            this.Controls.Add(this.origenTextBox);
            this.Controls.Add(destinoLabel);
            this.Controls.Add(this.destinoTextBox);
            this.Controls.Add(f_salidaLabel);
            this.Controls.Add(this.f_salidaTextBox);
            this.Controls.Add(f_llegadaLabel);
            this.Controls.Add(this.f_llegadaTextBox);
            this.Controls.Add(h_salidaLabel);
            this.Controls.Add(this.h_salidaTextBox);
            this.Controls.Add(h_llegadaLabel);
            this.Controls.Add(this.h_llegadaTextBox);
            this.Controls.Add(this.vuelosBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form9";
            this.Text = "CONSULTA VUELOS";
            this.Load += new System.EventHandler(this.Form9_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aerolineaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vuelosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vuelosBindingNavigator)).EndInit();
            this.vuelosBindingNavigator.ResumeLayout(false);
            this.vuelosBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vuelosDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private aerolineaDataSet aerolineaDataSet;
        private System.Windows.Forms.BindingSource vuelosBindingSource;
        private aerolineaDataSetTableAdapters.VuelosTableAdapter vuelosTableAdapter;
        private aerolineaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator vuelosBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.TextBox id_vueloTextBox;
        private System.Windows.Forms.TextBox id_avionTextBox;
        private System.Windows.Forms.TextBox origenTextBox;
        private System.Windows.Forms.TextBox destinoTextBox;
        private System.Windows.Forms.TextBox f_salidaTextBox;
        private System.Windows.Forms.TextBox f_llegadaTextBox;
        private System.Windows.Forms.TextBox h_salidaTextBox;
        private System.Windows.Forms.TextBox h_llegadaTextBox;
        private System.Windows.Forms.DataGridView vuelosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem mENUToolStripMenuItem;
    }
}