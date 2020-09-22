namespace aerolinea
{
    partial class Form8
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
            System.Windows.Forms.Label id_pasajeroLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label nacionalidadLabel;
            System.Windows.Forms.Label no_pasaporteLabel;
            System.Windows.Forms.Label f_nacLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form8));
            this.aerolineaDataSet = new aerolinea.aerolineaDataSet();
            this.pasajerosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pasajerosTableAdapter = new aerolinea.aerolineaDataSetTableAdapters.PasajerosTableAdapter();
            this.tableAdapterManager = new aerolinea.aerolineaDataSetTableAdapters.TableAdapterManager();
            this.pasajerosBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.id_pasajeroTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.nacionalidadTextBox = new System.Windows.Forms.TextBox();
            this.no_pasaporteTextBox = new System.Windows.Forms.TextBox();
            this.f_nacTextBox = new System.Windows.Forms.TextBox();
            this.pasajerosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            id_pasajeroLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            nacionalidadLabel = new System.Windows.Forms.Label();
            no_pasaporteLabel = new System.Windows.Forms.Label();
            f_nacLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.aerolineaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pasajerosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pasajerosBindingNavigator)).BeginInit();
            this.pasajerosBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pasajerosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // id_pasajeroLabel
            // 
            id_pasajeroLabel.AutoSize = true;
            id_pasajeroLabel.BackColor = System.Drawing.Color.Transparent;
            id_pasajeroLabel.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            id_pasajeroLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            id_pasajeroLabel.Location = new System.Drawing.Point(20, 40);
            id_pasajeroLabel.Name = "id_pasajeroLabel";
            id_pasajeroLabel.Size = new System.Drawing.Size(72, 13);
            id_pasajeroLabel.TabIndex = 1;
            id_pasajeroLabel.Text = "Id. Pasajero:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.BackColor = System.Drawing.Color.Transparent;
            nombreLabel.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nombreLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            nombreLabel.Location = new System.Drawing.Point(20, 66);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(52, 13);
            nombreLabel.TabIndex = 3;
            nombreLabel.Text = "Nombre:";
            // 
            // nacionalidadLabel
            // 
            nacionalidadLabel.AutoSize = true;
            nacionalidadLabel.BackColor = System.Drawing.Color.Transparent;
            nacionalidadLabel.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nacionalidadLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            nacionalidadLabel.Location = new System.Drawing.Point(20, 92);
            nacionalidadLabel.Name = "nacionalidadLabel";
            nacionalidadLabel.Size = new System.Drawing.Size(79, 13);
            nacionalidadLabel.TabIndex = 5;
            nacionalidadLabel.Text = "Nacionalidad:";
            // 
            // no_pasaporteLabel
            // 
            no_pasaporteLabel.AutoSize = true;
            no_pasaporteLabel.BackColor = System.Drawing.Color.Transparent;
            no_pasaporteLabel.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            no_pasaporteLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            no_pasaporteLabel.Location = new System.Drawing.Point(20, 118);
            no_pasaporteLabel.Name = "no_pasaporteLabel";
            no_pasaporteLabel.Size = new System.Drawing.Size(82, 13);
            no_pasaporteLabel.TabIndex = 7;
            no_pasaporteLabel.Text = "No. Pasaporte:";
            // 
            // f_nacLabel
            // 
            f_nacLabel.AutoSize = true;
            f_nacLabel.BackColor = System.Drawing.Color.Transparent;
            f_nacLabel.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            f_nacLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            f_nacLabel.Location = new System.Drawing.Point(20, 141);
            f_nacLabel.Name = "f_nacLabel";
            f_nacLabel.Size = new System.Drawing.Size(115, 13);
            f_nacLabel.TabIndex = 9;
            f_nacLabel.Text = "Fecha de Nacimiento";
            // 
            // aerolineaDataSet
            // 
            this.aerolineaDataSet.DataSetName = "aerolineaDataSet";
            this.aerolineaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pasajerosBindingSource
            // 
            this.pasajerosBindingSource.DataMember = "Pasajeros";
            this.pasajerosBindingSource.DataSource = this.aerolineaDataSet;
            // 
            // pasajerosTableAdapter
            // 
            this.pasajerosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AvionesTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.lis_pasajerosTableAdapter = null;
            this.tableAdapterManager.PasajerosTableAdapter = this.pasajerosTableAdapter;
            this.tableAdapterManager.UpdateOrder = aerolinea.aerolineaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VuelosTableAdapter = null;
            // 
            // pasajerosBindingNavigator
            // 
            this.pasajerosBindingNavigator.AddNewItem = null;
            this.pasajerosBindingNavigator.BindingSource = this.pasajerosBindingSource;
            this.pasajerosBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.pasajerosBindingNavigator.DeleteItem = null;
            this.pasajerosBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.toolStripSeparator1});
            this.pasajerosBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.pasajerosBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.pasajerosBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.pasajerosBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.pasajerosBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.pasajerosBindingNavigator.Name = "pasajerosBindingNavigator";
            this.pasajerosBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.pasajerosBindingNavigator.Size = new System.Drawing.Size(513, 25);
            this.pasajerosBindingNavigator.TabIndex = 0;
            this.pasajerosBindingNavigator.Text = "bindingNavigator1";
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
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // id_pasajeroTextBox
            // 
            this.id_pasajeroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pasajerosBindingSource, "Id_pasajero", true));
            this.id_pasajeroTextBox.Location = new System.Drawing.Point(163, 37);
            this.id_pasajeroTextBox.Name = "id_pasajeroTextBox";
            this.id_pasajeroTextBox.ReadOnly = true;
            this.id_pasajeroTextBox.Size = new System.Drawing.Size(304, 20);
            this.id_pasajeroTextBox.TabIndex = 2;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pasajerosBindingSource, "nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(163, 63);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.ReadOnly = true;
            this.nombreTextBox.Size = new System.Drawing.Size(304, 20);
            this.nombreTextBox.TabIndex = 4;
            // 
            // nacionalidadTextBox
            // 
            this.nacionalidadTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pasajerosBindingSource, "nacionalidad", true));
            this.nacionalidadTextBox.Location = new System.Drawing.Point(163, 89);
            this.nacionalidadTextBox.Name = "nacionalidadTextBox";
            this.nacionalidadTextBox.ReadOnly = true;
            this.nacionalidadTextBox.Size = new System.Drawing.Size(304, 20);
            this.nacionalidadTextBox.TabIndex = 6;
            // 
            // no_pasaporteTextBox
            // 
            this.no_pasaporteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pasajerosBindingSource, "no_pasaporte", true));
            this.no_pasaporteTextBox.Location = new System.Drawing.Point(163, 115);
            this.no_pasaporteTextBox.Name = "no_pasaporteTextBox";
            this.no_pasaporteTextBox.ReadOnly = true;
            this.no_pasaporteTextBox.Size = new System.Drawing.Size(304, 20);
            this.no_pasaporteTextBox.TabIndex = 8;
            // 
            // f_nacTextBox
            // 
            this.f_nacTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pasajerosBindingSource, "f_nac", true));
            this.f_nacTextBox.Location = new System.Drawing.Point(163, 141);
            this.f_nacTextBox.Name = "f_nacTextBox";
            this.f_nacTextBox.ReadOnly = true;
            this.f_nacTextBox.Size = new System.Drawing.Size(304, 20);
            this.f_nacTextBox.TabIndex = 10;
            // 
            // pasajerosDataGridView
            // 
            this.pasajerosDataGridView.AllowUserToAddRows = false;
            this.pasajerosDataGridView.AllowUserToDeleteRows = false;
            this.pasajerosDataGridView.AllowUserToOrderColumns = true;
            this.pasajerosDataGridView.AutoGenerateColumns = false;
            this.pasajerosDataGridView.BackgroundColor = System.Drawing.Color.PowderBlue;
            this.pasajerosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pasajerosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.pasajerosDataGridView.DataSource = this.pasajerosBindingSource;
            this.pasajerosDataGridView.Location = new System.Drawing.Point(12, 167);
            this.pasajerosDataGridView.Name = "pasajerosDataGridView";
            this.pasajerosDataGridView.ReadOnly = true;
            this.pasajerosDataGridView.Size = new System.Drawing.Size(489, 220);
            this.pasajerosDataGridView.TabIndex = 11;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id_pasajero";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id_pasajero";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nombre";
            this.dataGridViewTextBoxColumn2.HeaderText = "nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "nacionalidad";
            this.dataGridViewTextBoxColumn3.HeaderText = "nacionalidad";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "no_pasaporte";
            this.dataGridViewTextBoxColumn4.HeaderText = "no_pasaporte";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "f_nac";
            this.dataGridViewTextBoxColumn5.HeaderText = "f_nac";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(513, 421);
            this.Controls.Add(this.pasajerosDataGridView);
            this.Controls.Add(f_nacLabel);
            this.Controls.Add(this.f_nacTextBox);
            this.Controls.Add(id_pasajeroLabel);
            this.Controls.Add(this.id_pasajeroTextBox);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(nacionalidadLabel);
            this.Controls.Add(this.nacionalidadTextBox);
            this.Controls.Add(no_pasaporteLabel);
            this.Controls.Add(this.no_pasaporteTextBox);
            this.Controls.Add(this.pasajerosBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form8";
            this.Text = "CONSULTA PASAJEROS";
            this.Load += new System.EventHandler(this.Form8_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aerolineaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pasajerosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pasajerosBindingNavigator)).EndInit();
            this.pasajerosBindingNavigator.ResumeLayout(false);
            this.pasajerosBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pasajerosDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private aerolineaDataSet aerolineaDataSet;
        private System.Windows.Forms.BindingSource pasajerosBindingSource;
        private aerolineaDataSetTableAdapters.PasajerosTableAdapter pasajerosTableAdapter;
        private aerolineaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator pasajerosBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.TextBox id_pasajeroTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox nacionalidadTextBox;
        private System.Windows.Forms.TextBox no_pasaporteTextBox;
        private System.Windows.Forms.TextBox f_nacTextBox;
        private System.Windows.Forms.DataGridView pasajerosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem mENUToolStripMenuItem;
    }
}