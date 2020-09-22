namespace aerolinea
{
    partial class Form4
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
            System.Windows.Forms.Label id_pasajeroLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.aerolineaDataSet = new aerolinea.aerolineaDataSet();
            this.lis_pasajerosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lis_pasajerosTableAdapter = new aerolinea.aerolineaDataSetTableAdapters.lis_pasajerosTableAdapter();
            this.tableAdapterManager = new aerolinea.aerolineaDataSetTableAdapters.TableAdapterManager();
            this.pasajerosTableAdapter = new aerolinea.aerolineaDataSetTableAdapters.PasajerosTableAdapter();
            this.vuelosTableAdapter = new aerolinea.aerolineaDataSetTableAdapters.VuelosTableAdapter();
            this.lis_pasajerosBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.mENUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.id_vueloComboBox = new System.Windows.Forms.ComboBox();
            this.vuelosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.id_pasajeroComboBox = new System.Windows.Forms.ComboBox();
            this.pasajerosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lis_pasajerosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_ultimo = new System.Windows.Forms.Button();
            this.btn_siguente = new System.Windows.Forms.Button();
            this.btn_anterior = new System.Windows.Forms.Button();
            this.btn_primero = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_new = new System.Windows.Forms.Button();
            id_vueloLabel = new System.Windows.Forms.Label();
            id_pasajeroLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.aerolineaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lis_pasajerosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lis_pasajerosBindingNavigator)).BeginInit();
            this.lis_pasajerosBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vuelosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pasajerosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lis_pasajerosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // id_vueloLabel
            // 
            id_vueloLabel.AutoSize = true;
            id_vueloLabel.BackColor = System.Drawing.Color.Transparent;
            id_vueloLabel.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            id_vueloLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            id_vueloLabel.Location = new System.Drawing.Point(30, 41);
            id_vueloLabel.Name = "id_vueloLabel";
            id_vueloLabel.Size = new System.Drawing.Size(57, 13);
            id_vueloLabel.TabIndex = 1;
            id_vueloLabel.Text = "Id. Vuelo:";
            // 
            // id_pasajeroLabel
            // 
            id_pasajeroLabel.AutoSize = true;
            id_pasajeroLabel.BackColor = System.Drawing.Color.Transparent;
            id_pasajeroLabel.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            id_pasajeroLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            id_pasajeroLabel.Location = new System.Drawing.Point(30, 86);
            id_pasajeroLabel.Name = "id_pasajeroLabel";
            id_pasajeroLabel.Size = new System.Drawing.Size(72, 13);
            id_pasajeroLabel.TabIndex = 3;
            id_pasajeroLabel.Text = "Id. Pasajero:";
            // 
            // aerolineaDataSet
            // 
            this.aerolineaDataSet.DataSetName = "aerolineaDataSet";
            this.aerolineaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lis_pasajerosBindingSource
            // 
            this.lis_pasajerosBindingSource.DataMember = "lis_pasajeros";
            this.lis_pasajerosBindingSource.DataSource = this.aerolineaDataSet;
            // 
            // lis_pasajerosTableAdapter
            // 
            this.lis_pasajerosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AvionesTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.lis_pasajerosTableAdapter = this.lis_pasajerosTableAdapter;
            this.tableAdapterManager.PasajerosTableAdapter = this.pasajerosTableAdapter;
            this.tableAdapterManager.UpdateOrder = aerolinea.aerolineaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VuelosTableAdapter = this.vuelosTableAdapter;
            // 
            // pasajerosTableAdapter
            // 
            this.pasajerosTableAdapter.ClearBeforeFill = true;
            // 
            // vuelosTableAdapter
            // 
            this.vuelosTableAdapter.ClearBeforeFill = true;
            // 
            // lis_pasajerosBindingNavigator
            // 
            this.lis_pasajerosBindingNavigator.AddNewItem = null;
            this.lis_pasajerosBindingNavigator.BindingSource = this.lis_pasajerosBindingSource;
            this.lis_pasajerosBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.lis_pasajerosBindingNavigator.DeleteItem = null;
            this.lis_pasajerosBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1});
            this.lis_pasajerosBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.lis_pasajerosBindingNavigator.MoveFirstItem = null;
            this.lis_pasajerosBindingNavigator.MoveLastItem = null;
            this.lis_pasajerosBindingNavigator.MoveNextItem = null;
            this.lis_pasajerosBindingNavigator.MovePreviousItem = null;
            this.lis_pasajerosBindingNavigator.Name = "lis_pasajerosBindingNavigator";
            this.lis_pasajerosBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.lis_pasajerosBindingNavigator.Size = new System.Drawing.Size(488, 25);
            this.lis_pasajerosBindingNavigator.TabIndex = 0;
            this.lis_pasajerosBindingNavigator.Text = "bindingNavigator1";
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
            // id_vueloComboBox
            // 
            this.id_vueloComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lis_pasajerosBindingSource, "Id_vuelo", true));
            this.id_vueloComboBox.DataSource = this.vuelosBindingSource;
            this.id_vueloComboBox.DisplayMember = "Id_vuelo";
            this.id_vueloComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.id_vueloComboBox.FormattingEnabled = true;
            this.id_vueloComboBox.Location = new System.Drawing.Point(114, 41);
            this.id_vueloComboBox.Name = "id_vueloComboBox";
            this.id_vueloComboBox.Size = new System.Drawing.Size(121, 21);
            this.id_vueloComboBox.TabIndex = 2;
            this.id_vueloComboBox.ValueMember = "Id_vuelo";
            // 
            // vuelosBindingSource
            // 
            this.vuelosBindingSource.DataMember = "Vuelos";
            this.vuelosBindingSource.DataSource = this.aerolineaDataSet;
            // 
            // id_pasajeroComboBox
            // 
            this.id_pasajeroComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lis_pasajerosBindingSource, "id_pasajero", true));
            this.id_pasajeroComboBox.DataSource = this.pasajerosBindingSource;
            this.id_pasajeroComboBox.DisplayMember = "Id_pasajero";
            this.id_pasajeroComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.id_pasajeroComboBox.FormattingEnabled = true;
            this.id_pasajeroComboBox.Location = new System.Drawing.Point(114, 86);
            this.id_pasajeroComboBox.Name = "id_pasajeroComboBox";
            this.id_pasajeroComboBox.Size = new System.Drawing.Size(121, 21);
            this.id_pasajeroComboBox.TabIndex = 4;
            this.id_pasajeroComboBox.ValueMember = "Id_pasajero";
            // 
            // pasajerosBindingSource
            // 
            this.pasajerosBindingSource.DataMember = "Pasajeros";
            this.pasajerosBindingSource.DataSource = this.aerolineaDataSet;
            // 
            // lis_pasajerosDataGridView
            // 
            this.lis_pasajerosDataGridView.AllowUserToAddRows = false;
            this.lis_pasajerosDataGridView.AllowUserToDeleteRows = false;
            this.lis_pasajerosDataGridView.AllowUserToOrderColumns = true;
            this.lis_pasajerosDataGridView.AutoGenerateColumns = false;
            this.lis_pasajerosDataGridView.BackgroundColor = System.Drawing.Color.PowderBlue;
            this.lis_pasajerosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lis_pasajerosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.lis_pasajerosDataGridView.DataSource = this.lis_pasajerosBindingSource;
            this.lis_pasajerosDataGridView.Location = new System.Drawing.Point(12, 152);
            this.lis_pasajerosDataGridView.Name = "lis_pasajerosDataGridView";
            this.lis_pasajerosDataGridView.ReadOnly = true;
            this.lis_pasajerosDataGridView.Size = new System.Drawing.Size(464, 220);
            this.lis_pasajerosDataGridView.TabIndex = 5;
            this.lis_pasajerosDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.lis_pasajerosDataGridView_CellContentClick);
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
            this.dataGridViewTextBoxColumn2.DataPropertyName = "id_pasajero";
            this.dataGridViewTextBoxColumn2.HeaderText = "id_pasajero";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // btn_ultimo
            // 
            this.btn_ultimo.BackColor = System.Drawing.Color.Transparent;
            this.btn_ultimo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_ultimo.BackgroundImage")));
            this.btn_ultimo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_ultimo.FlatAppearance.BorderSize = 0;
            this.btn_ultimo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ultimo.Location = new System.Drawing.Point(341, 123);
            this.btn_ultimo.Name = "btn_ultimo";
            this.btn_ultimo.Size = new System.Drawing.Size(75, 23);
            this.btn_ultimo.TabIndex = 36;
            this.btn_ultimo.UseVisualStyleBackColor = false;
            this.btn_ultimo.Click += new System.EventHandler(this.btn_ultimo_Click);
            // 
            // btn_siguente
            // 
            this.btn_siguente.BackColor = System.Drawing.Color.Transparent;
            this.btn_siguente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_siguente.BackgroundImage")));
            this.btn_siguente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_siguente.FlatAppearance.BorderSize = 0;
            this.btn_siguente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_siguente.Location = new System.Drawing.Point(260, 123);
            this.btn_siguente.Name = "btn_siguente";
            this.btn_siguente.Size = new System.Drawing.Size(75, 23);
            this.btn_siguente.TabIndex = 35;
            this.btn_siguente.UseVisualStyleBackColor = false;
            this.btn_siguente.Click += new System.EventHandler(this.btn_siguente_Click);
            // 
            // btn_anterior
            // 
            this.btn_anterior.BackColor = System.Drawing.Color.Transparent;
            this.btn_anterior.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_anterior.BackgroundImage")));
            this.btn_anterior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_anterior.FlatAppearance.BorderSize = 0;
            this.btn_anterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_anterior.Location = new System.Drawing.Point(179, 123);
            this.btn_anterior.Name = "btn_anterior";
            this.btn_anterior.Size = new System.Drawing.Size(75, 23);
            this.btn_anterior.TabIndex = 34;
            this.btn_anterior.UseVisualStyleBackColor = false;
            this.btn_anterior.Click += new System.EventHandler(this.btn_anterior_Click);
            // 
            // btn_primero
            // 
            this.btn_primero.BackColor = System.Drawing.Color.Transparent;
            this.btn_primero.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_primero.BackgroundImage")));
            this.btn_primero.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_primero.FlatAppearance.BorderSize = 0;
            this.btn_primero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_primero.Location = new System.Drawing.Point(91, 123);
            this.btn_primero.Name = "btn_primero";
            this.btn_primero.Size = new System.Drawing.Size(75, 23);
            this.btn_primero.TabIndex = 33;
            this.btn_primero.UseVisualStyleBackColor = false;
            this.btn_primero.Click += new System.EventHandler(this.btn_primero_Click);
            // 
            // btn_del
            // 
            this.btn_del.Location = new System.Drawing.Point(267, 83);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(75, 23);
            this.btn_del.TabIndex = 40;
            this.btn_del.Text = "borrar";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(267, 54);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 39;
            this.btn_save.Text = "guardar";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_new
            // 
            this.btn_new.Location = new System.Drawing.Point(267, 28);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(75, 23);
            this.btn_new.TabIndex = 38;
            this.btn_new.Text = "nuevo";
            this.btn_new.UseVisualStyleBackColor = true;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(488, 384);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_new);
            this.Controls.Add(this.btn_ultimo);
            this.Controls.Add(this.btn_siguente);
            this.Controls.Add(this.btn_anterior);
            this.Controls.Add(this.btn_primero);
            this.Controls.Add(this.lis_pasajerosDataGridView);
            this.Controls.Add(id_vueloLabel);
            this.Controls.Add(this.id_vueloComboBox);
            this.Controls.Add(id_pasajeroLabel);
            this.Controls.Add(this.id_pasajeroComboBox);
            this.Controls.Add(this.lis_pasajerosBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form4";
            this.Text = "LISTA DE PASAJEROS";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aerolineaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lis_pasajerosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lis_pasajerosBindingNavigator)).EndInit();
            this.lis_pasajerosBindingNavigator.ResumeLayout(false);
            this.lis_pasajerosBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vuelosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pasajerosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lis_pasajerosDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private aerolineaDataSet aerolineaDataSet;
        private System.Windows.Forms.BindingSource lis_pasajerosBindingSource;
        private aerolineaDataSetTableAdapters.lis_pasajerosTableAdapter lis_pasajerosTableAdapter;
        private aerolineaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator lis_pasajerosBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ComboBox id_vueloComboBox;
        private System.Windows.Forms.ComboBox id_pasajeroComboBox;
        private aerolineaDataSetTableAdapters.VuelosTableAdapter vuelosTableAdapter;
        private System.Windows.Forms.BindingSource vuelosBindingSource;
        private aerolineaDataSetTableAdapters.PasajerosTableAdapter pasajerosTableAdapter;
        private System.Windows.Forms.BindingSource pasajerosBindingSource;
        private System.Windows.Forms.DataGridView lis_pasajerosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button btn_ultimo;
        private System.Windows.Forms.Button btn_siguente;
        private System.Windows.Forms.Button btn_anterior;
        private System.Windows.Forms.Button btn_primero;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem mENUToolStripMenuItem;
    }
}