namespace aerolinea
{
    partial class Form7
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
            System.Windows.Forms.Label id_avionLabel;
            System.Windows.Forms.Label aerolineaLabel;
            System.Windows.Forms.Label modeloLabel;
            System.Windows.Forms.Label tipoLabel;
            System.Windows.Forms.Label capacidadLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            this.aerolineaDataSet = new aerolinea.aerolineaDataSet();
            this.avionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.avionesTableAdapter = new aerolinea.aerolineaDataSetTableAdapters.AvionesTableAdapter();
            this.tableAdapterManager = new aerolinea.aerolineaDataSetTableAdapters.TableAdapterManager();
            this.avionesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.id_avionTextBox = new System.Windows.Forms.TextBox();
            this.aerolineaTextBox = new System.Windows.Forms.TextBox();
            this.modeloTextBox = new System.Windows.Forms.TextBox();
            this.tipoTextBox = new System.Windows.Forms.TextBox();
            this.capacidadTextBox = new System.Windows.Forms.TextBox();
            this.avionesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            id_avionLabel = new System.Windows.Forms.Label();
            aerolineaLabel = new System.Windows.Forms.Label();
            modeloLabel = new System.Windows.Forms.Label();
            tipoLabel = new System.Windows.Forms.Label();
            capacidadLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.aerolineaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avionesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avionesBindingNavigator)).BeginInit();
            this.avionesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avionesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // id_avionLabel
            // 
            id_avionLabel.AutoSize = true;
            id_avionLabel.BackColor = System.Drawing.Color.Transparent;
            id_avionLabel.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            id_avionLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            id_avionLabel.Location = new System.Drawing.Point(26, 47);
            id_avionLabel.Name = "id_avionLabel";
            id_avionLabel.Size = new System.Drawing.Size(55, 13);
            id_avionLabel.TabIndex = 1;
            id_avionLabel.Text = "Id. Avion:";
            // 
            // aerolineaLabel
            // 
            aerolineaLabel.AutoSize = true;
            aerolineaLabel.BackColor = System.Drawing.Color.Transparent;
            aerolineaLabel.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            aerolineaLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            aerolineaLabel.Location = new System.Drawing.Point(26, 73);
            aerolineaLabel.Name = "aerolineaLabel";
            aerolineaLabel.Size = new System.Drawing.Size(63, 13);
            aerolineaLabel.TabIndex = 3;
            aerolineaLabel.Text = "Aerolinea:";
            // 
            // modeloLabel
            // 
            modeloLabel.AutoSize = true;
            modeloLabel.BackColor = System.Drawing.Color.Transparent;
            modeloLabel.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            modeloLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            modeloLabel.Location = new System.Drawing.Point(26, 99);
            modeloLabel.Name = "modeloLabel";
            modeloLabel.Size = new System.Drawing.Size(49, 13);
            modeloLabel.TabIndex = 5;
            modeloLabel.Text = "Modelo:";
            // 
            // tipoLabel
            // 
            tipoLabel.AutoSize = true;
            tipoLabel.BackColor = System.Drawing.Color.Transparent;
            tipoLabel.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tipoLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            tipoLabel.Location = new System.Drawing.Point(26, 125);
            tipoLabel.Name = "tipoLabel";
            tipoLabel.Size = new System.Drawing.Size(33, 13);
            tipoLabel.TabIndex = 7;
            tipoLabel.Text = "Tipo:";
            // 
            // capacidadLabel
            // 
            capacidadLabel.AutoSize = true;
            capacidadLabel.BackColor = System.Drawing.Color.Transparent;
            capacidadLabel.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            capacidadLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            capacidadLabel.Location = new System.Drawing.Point(26, 151);
            capacidadLabel.Name = "capacidadLabel";
            capacidadLabel.Size = new System.Drawing.Size(65, 13);
            capacidadLabel.TabIndex = 9;
            capacidadLabel.Text = "Capacidad:";
            // 
            // aerolineaDataSet
            // 
            this.aerolineaDataSet.DataSetName = "aerolineaDataSet";
            this.aerolineaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // avionesBindingSource
            // 
            this.avionesBindingSource.DataMember = "Aviones";
            this.avionesBindingSource.DataSource = this.aerolineaDataSet;
            // 
            // avionesTableAdapter
            // 
            this.avionesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AvionesTableAdapter = this.avionesTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.lis_pasajerosTableAdapter = null;
            this.tableAdapterManager.PasajerosTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = aerolinea.aerolineaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VuelosTableAdapter = null;
            // 
            // avionesBindingNavigator
            // 
            this.avionesBindingNavigator.AddNewItem = null;
            this.avionesBindingNavigator.BindingSource = this.avionesBindingSource;
            this.avionesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.avionesBindingNavigator.DeleteItem = null;
            this.avionesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.toolStripSeparator1});
            this.avionesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.avionesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.avionesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.avionesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.avionesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.avionesBindingNavigator.Name = "avionesBindingNavigator";
            this.avionesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.avionesBindingNavigator.Size = new System.Drawing.Size(516, 25);
            this.avionesBindingNavigator.TabIndex = 0;
            this.avionesBindingNavigator.Text = "bindingNavigator1";
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
            this.toolStripDropDownButton1.Click += new System.EventHandler(this.toolStripDropDownButton1_Click);
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
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // id_avionTextBox
            // 
            this.id_avionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.avionesBindingSource, "Id_avion", true));
            this.id_avionTextBox.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.id_avionTextBox.Location = new System.Drawing.Point(92, 44);
            this.id_avionTextBox.Name = "id_avionTextBox";
            this.id_avionTextBox.ReadOnly = true;
            this.id_avionTextBox.Size = new System.Drawing.Size(212, 20);
            this.id_avionTextBox.TabIndex = 2;
            // 
            // aerolineaTextBox
            // 
            this.aerolineaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.avionesBindingSource, "aerolinea", true));
            this.aerolineaTextBox.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.aerolineaTextBox.Location = new System.Drawing.Point(92, 70);
            this.aerolineaTextBox.Name = "aerolineaTextBox";
            this.aerolineaTextBox.ReadOnly = true;
            this.aerolineaTextBox.Size = new System.Drawing.Size(212, 20);
            this.aerolineaTextBox.TabIndex = 4;
            // 
            // modeloTextBox
            // 
            this.modeloTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.avionesBindingSource, "modelo", true));
            this.modeloTextBox.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.modeloTextBox.Location = new System.Drawing.Point(92, 96);
            this.modeloTextBox.Name = "modeloTextBox";
            this.modeloTextBox.ReadOnly = true;
            this.modeloTextBox.Size = new System.Drawing.Size(212, 20);
            this.modeloTextBox.TabIndex = 6;
            // 
            // tipoTextBox
            // 
            this.tipoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.avionesBindingSource, "tipo", true));
            this.tipoTextBox.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tipoTextBox.Location = new System.Drawing.Point(92, 122);
            this.tipoTextBox.Name = "tipoTextBox";
            this.tipoTextBox.ReadOnly = true;
            this.tipoTextBox.Size = new System.Drawing.Size(212, 20);
            this.tipoTextBox.TabIndex = 8;
            // 
            // capacidadTextBox
            // 
            this.capacidadTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.avionesBindingSource, "capacidad", true));
            this.capacidadTextBox.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.capacidadTextBox.Location = new System.Drawing.Point(92, 148);
            this.capacidadTextBox.Name = "capacidadTextBox";
            this.capacidadTextBox.ReadOnly = true;
            this.capacidadTextBox.Size = new System.Drawing.Size(212, 20);
            this.capacidadTextBox.TabIndex = 10;
            // 
            // avionesDataGridView
            // 
            this.avionesDataGridView.AllowUserToAddRows = false;
            this.avionesDataGridView.AllowUserToDeleteRows = false;
            this.avionesDataGridView.AllowUserToOrderColumns = true;
            this.avionesDataGridView.AutoGenerateColumns = false;
            this.avionesDataGridView.BackgroundColor = System.Drawing.Color.PowderBlue;
            this.avionesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.avionesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.avionesDataGridView.DataSource = this.avionesBindingSource;
            this.avionesDataGridView.Location = new System.Drawing.Point(12, 174);
            this.avionesDataGridView.Name = "avionesDataGridView";
            this.avionesDataGridView.ReadOnly = true;
            this.avionesDataGridView.Size = new System.Drawing.Size(492, 254);
            this.avionesDataGridView.TabIndex = 11;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id_avion";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id_avion";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "aerolinea";
            this.dataGridViewTextBoxColumn2.HeaderText = "aerolinea";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "modelo";
            this.dataGridViewTextBoxColumn3.HeaderText = "modelo";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "tipo";
            this.dataGridViewTextBoxColumn4.HeaderText = "tipo";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "capacidad";
            this.dataGridViewTextBoxColumn5.HeaderText = "capacidad";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(516, 440);
            this.Controls.Add(this.avionesDataGridView);
            this.Controls.Add(id_avionLabel);
            this.Controls.Add(this.id_avionTextBox);
            this.Controls.Add(aerolineaLabel);
            this.Controls.Add(this.aerolineaTextBox);
            this.Controls.Add(modeloLabel);
            this.Controls.Add(this.modeloTextBox);
            this.Controls.Add(tipoLabel);
            this.Controls.Add(this.tipoTextBox);
            this.Controls.Add(capacidadLabel);
            this.Controls.Add(this.capacidadTextBox);
            this.Controls.Add(this.avionesBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form7";
            this.Text = "CONSULTA AVIONES";
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aerolineaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avionesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avionesBindingNavigator)).EndInit();
            this.avionesBindingNavigator.ResumeLayout(false);
            this.avionesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avionesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private aerolineaDataSet aerolineaDataSet;
        private System.Windows.Forms.BindingSource avionesBindingSource;
        private aerolineaDataSetTableAdapters.AvionesTableAdapter avionesTableAdapter;
        private aerolineaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator avionesBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.TextBox id_avionTextBox;
        private System.Windows.Forms.TextBox aerolineaTextBox;
        private System.Windows.Forms.TextBox modeloTextBox;
        private System.Windows.Forms.TextBox tipoTextBox;
        private System.Windows.Forms.TextBox capacidadTextBox;
        private System.Windows.Forms.DataGridView avionesDataGridView;
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