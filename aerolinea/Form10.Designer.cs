namespace aerolinea
{
    partial class Form10
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form10));
            this.aerolineaDataSet = new aerolinea.aerolineaDataSet();
            this.lis_pasajerosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lis_pasajerosTableAdapter = new aerolinea.aerolineaDataSetTableAdapters.lis_pasajerosTableAdapter();
            this.tableAdapterManager = new aerolinea.aerolineaDataSetTableAdapters.TableAdapterManager();
            this.lis_pasajerosBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.id_pasajeroTextBox = new System.Windows.Forms.TextBox();
            this.lis_pasajerosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            id_vueloLabel = new System.Windows.Forms.Label();
            id_pasajeroLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.aerolineaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lis_pasajerosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lis_pasajerosBindingNavigator)).BeginInit();
            this.lis_pasajerosBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lis_pasajerosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // id_vueloLabel
            // 
            id_vueloLabel.AutoSize = true;
            id_vueloLabel.BackColor = System.Drawing.Color.Transparent;
            id_vueloLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            id_vueloLabel.Location = new System.Drawing.Point(13, 52);
            id_vueloLabel.Name = "id_vueloLabel";
            id_vueloLabel.Size = new System.Drawing.Size(52, 13);
            id_vueloLabel.TabIndex = 1;
            id_vueloLabel.Text = "Id. Vuelo:";
            id_vueloLabel.Click += new System.EventHandler(this.id_vueloLabel_Click);
            // 
            // id_pasajeroLabel
            // 
            id_pasajeroLabel.AutoSize = true;
            id_pasajeroLabel.BackColor = System.Drawing.Color.Transparent;
            id_pasajeroLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            id_pasajeroLabel.Location = new System.Drawing.Point(13, 78);
            id_pasajeroLabel.Name = "id_pasajeroLabel";
            id_pasajeroLabel.Size = new System.Drawing.Size(66, 13);
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
            this.tableAdapterManager.PasajerosTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = aerolinea.aerolineaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VuelosTableAdapter = null;
            // 
            // lis_pasajerosBindingNavigator
            // 
            this.lis_pasajerosBindingNavigator.AddNewItem = null;
            this.lis_pasajerosBindingNavigator.BindingSource = this.lis_pasajerosBindingSource;
            this.lis_pasajerosBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.lis_pasajerosBindingNavigator.DeleteItem = null;
            this.lis_pasajerosBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.lis_pasajerosBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.lis_pasajerosBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.lis_pasajerosBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.lis_pasajerosBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.lis_pasajerosBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.lis_pasajerosBindingNavigator.Name = "lis_pasajerosBindingNavigator";
            this.lis_pasajerosBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.lis_pasajerosBindingNavigator.Size = new System.Drawing.Size(369, 25);
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
            this.id_vueloTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lis_pasajerosBindingSource, "Id_vuelo", true));
            this.id_vueloTextBox.Location = new System.Drawing.Point(80, 49);
            this.id_vueloTextBox.Name = "id_vueloTextBox";
            this.id_vueloTextBox.ReadOnly = true;
            this.id_vueloTextBox.Size = new System.Drawing.Size(184, 20);
            this.id_vueloTextBox.TabIndex = 2;
            // 
            // id_pasajeroTextBox
            // 
            this.id_pasajeroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lis_pasajerosBindingSource, "id_pasajero", true));
            this.id_pasajeroTextBox.Location = new System.Drawing.Point(80, 75);
            this.id_pasajeroTextBox.Name = "id_pasajeroTextBox";
            this.id_pasajeroTextBox.ReadOnly = true;
            this.id_pasajeroTextBox.Size = new System.Drawing.Size(184, 20);
            this.id_pasajeroTextBox.TabIndex = 4;
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
            this.lis_pasajerosDataGridView.Location = new System.Drawing.Point(16, 110);
            this.lis_pasajerosDataGridView.Name = "lis_pasajerosDataGridView";
            this.lis_pasajerosDataGridView.ReadOnly = true;
            this.lis_pasajerosDataGridView.Size = new System.Drawing.Size(341, 220);
            this.lis_pasajerosDataGridView.TabIndex = 5;
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
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(369, 352);
            this.Controls.Add(this.lis_pasajerosDataGridView);
            this.Controls.Add(id_vueloLabel);
            this.Controls.Add(this.id_vueloTextBox);
            this.Controls.Add(id_pasajeroLabel);
            this.Controls.Add(this.id_pasajeroTextBox);
            this.Controls.Add(this.lis_pasajerosBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form10";
            this.Text = "CONSULTA LISTA DE VUELOS";
            this.Load += new System.EventHandler(this.Form10_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aerolineaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lis_pasajerosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lis_pasajerosBindingNavigator)).EndInit();
            this.lis_pasajerosBindingNavigator.ResumeLayout(false);
            this.lis_pasajerosBindingNavigator.PerformLayout();
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
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.TextBox id_vueloTextBox;
        private System.Windows.Forms.TextBox id_pasajeroTextBox;
        private System.Windows.Forms.DataGridView lis_pasajerosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem mENUToolStripMenuItem;
    }
}