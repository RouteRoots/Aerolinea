namespace aerolinea
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label id_avionLabel;
            System.Windows.Forms.Label aerolineaLabel;
            System.Windows.Forms.Label modeloLabel;
            System.Windows.Forms.Label tipoLabel;
            System.Windows.Forms.Label capacidadLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.aerolineaDataSet = new aerolinea.aerolineaDataSet();
            this.avionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.avionesTableAdapter = new aerolinea.aerolineaDataSetTableAdapters.AvionesTableAdapter();
            this.tableAdapterManager = new aerolinea.aerolineaDataSetTableAdapters.TableAdapterManager();
            this.avionesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.mENUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_primero = new System.Windows.Forms.Button();
            this.btn_anterior = new System.Windows.Forms.Button();
            this.btn_siguente = new System.Windows.Forms.Button();
            this.btn_ultimo = new System.Windows.Forms.Button();
            this.btn_new = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.btn_sear = new System.Windows.Forms.Button();
            this.tb_search = new System.Windows.Forms.TextBox();
            this.id_avionTextBox = new System.Windows.Forms.TextBox();
            this.aerolineaComboBox = new System.Windows.Forms.ComboBox();
            this.modeloTextBox = new System.Windows.Forms.TextBox();
            this.tipoComboBox = new System.Windows.Forms.ComboBox();
            this.capacidadTextBox = new System.Windows.Forms.TextBox();
            id_avionLabel = new System.Windows.Forms.Label();
            aerolineaLabel = new System.Windows.Forms.Label();
            modeloLabel = new System.Windows.Forms.Label();
            tipoLabel = new System.Windows.Forms.Label();
            capacidadLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.aerolineaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avionesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avionesBindingNavigator)).BeginInit();
            this.avionesBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // id_avionLabel
            // 
            id_avionLabel.AutoSize = true;
            id_avionLabel.BackColor = System.Drawing.Color.Transparent;
            id_avionLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            id_avionLabel.Location = new System.Drawing.Point(21, 51);
            id_avionLabel.Name = "id_avionLabel";
            id_avionLabel.Size = new System.Drawing.Size(52, 13);
            id_avionLabel.TabIndex = 19;
            id_avionLabel.Text = "Id. Avion:";
            // 
            // aerolineaLabel
            // 
            aerolineaLabel.AutoSize = true;
            aerolineaLabel.BackColor = System.Drawing.Color.Transparent;
            aerolineaLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            aerolineaLabel.Location = new System.Drawing.Point(21, 77);
            aerolineaLabel.Name = "aerolineaLabel";
            aerolineaLabel.Size = new System.Drawing.Size(54, 13);
            aerolineaLabel.TabIndex = 21;
            aerolineaLabel.Text = "Aerolinea:";
            // 
            // modeloLabel
            // 
            modeloLabel.AutoSize = true;
            modeloLabel.BackColor = System.Drawing.Color.Transparent;
            modeloLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            modeloLabel.Location = new System.Drawing.Point(21, 104);
            modeloLabel.Name = "modeloLabel";
            modeloLabel.Size = new System.Drawing.Size(45, 13);
            modeloLabel.TabIndex = 23;
            modeloLabel.Text = "Modelo:";
            // 
            // tipoLabel
            // 
            tipoLabel.AutoSize = true;
            tipoLabel.BackColor = System.Drawing.Color.Transparent;
            tipoLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            tipoLabel.Location = new System.Drawing.Point(21, 130);
            tipoLabel.Name = "tipoLabel";
            tipoLabel.Size = new System.Drawing.Size(31, 13);
            tipoLabel.TabIndex = 25;
            tipoLabel.Text = "Tipo:";
            // 
            // capacidadLabel
            // 
            capacidadLabel.AutoSize = true;
            capacidadLabel.BackColor = System.Drawing.Color.Transparent;
            capacidadLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            capacidadLabel.Location = new System.Drawing.Point(21, 157);
            capacidadLabel.Name = "capacidadLabel";
            capacidadLabel.Size = new System.Drawing.Size(61, 13);
            capacidadLabel.TabIndex = 27;
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
            this.toolStripLabel1,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1});
            this.avionesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.avionesBindingNavigator.MoveFirstItem = null;
            this.avionesBindingNavigator.MoveLastItem = null;
            this.avionesBindingNavigator.MoveNextItem = null;
            this.avionesBindingNavigator.MovePreviousItem = null;
            this.avionesBindingNavigator.Name = "avionesBindingNavigator";
            this.avionesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.avionesBindingNavigator.Size = new System.Drawing.Size(483, 25);
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
            // toolStripLabel1
            // 
            this.toolStripLabel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripLabel1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mENUToolStripMenuItem});
            this.toolStripLabel1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripLabel1.Image")));
            this.toolStripLabel1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(29, 22);
            this.toolStripLabel1.Text = "MENU";
            this.toolStripLabel1.Click += new System.EventHandler(this.toolStripLabel1_Click);
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
            // btn_primero
            // 
            this.btn_primero.BackColor = System.Drawing.Color.Transparent;
            this.btn_primero.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_primero.BackgroundImage")));
            this.btn_primero.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_primero.FlatAppearance.BorderSize = 0;
            this.btn_primero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_primero.Location = new System.Drawing.Point(63, 202);
            this.btn_primero.Name = "btn_primero";
            this.btn_primero.Size = new System.Drawing.Size(78, 40);
            this.btn_primero.TabIndex = 11;
            this.btn_primero.UseVisualStyleBackColor = false;
            this.btn_primero.Click += new System.EventHandler(this.btn_primero_Click);
            // 
            // btn_anterior
            // 
            this.btn_anterior.BackColor = System.Drawing.Color.Transparent;
            this.btn_anterior.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_anterior.BackgroundImage")));
            this.btn_anterior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_anterior.FlatAppearance.BorderSize = 0;
            this.btn_anterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_anterior.Location = new System.Drawing.Point(151, 202);
            this.btn_anterior.Name = "btn_anterior";
            this.btn_anterior.Size = new System.Drawing.Size(78, 40);
            this.btn_anterior.TabIndex = 12;
            this.btn_anterior.UseVisualStyleBackColor = false;
            this.btn_anterior.Click += new System.EventHandler(this.btn_anterior_Click);
            // 
            // btn_siguente
            // 
            this.btn_siguente.BackColor = System.Drawing.Color.Transparent;
            this.btn_siguente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_siguente.BackgroundImage")));
            this.btn_siguente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_siguente.FlatAppearance.BorderSize = 0;
            this.btn_siguente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_siguente.Location = new System.Drawing.Point(232, 202);
            this.btn_siguente.Name = "btn_siguente";
            this.btn_siguente.Size = new System.Drawing.Size(78, 40);
            this.btn_siguente.TabIndex = 13;
            this.btn_siguente.UseVisualStyleBackColor = false;
            this.btn_siguente.Click += new System.EventHandler(this.btn_siguente_Click);
            // 
            // btn_ultimo
            // 
            this.btn_ultimo.BackColor = System.Drawing.Color.Transparent;
            this.btn_ultimo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_ultimo.BackgroundImage")));
            this.btn_ultimo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_ultimo.FlatAppearance.BorderSize = 0;
            this.btn_ultimo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ultimo.Location = new System.Drawing.Point(313, 202);
            this.btn_ultimo.Name = "btn_ultimo";
            this.btn_ultimo.Size = new System.Drawing.Size(78, 40);
            this.btn_ultimo.TabIndex = 14;
            this.btn_ultimo.UseVisualStyleBackColor = false;
            this.btn_ultimo.Click += new System.EventHandler(this.btn_ultimo_Click);
            // 
            // btn_new
            // 
            this.btn_new.Location = new System.Drawing.Point(277, 45);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(75, 23);
            this.btn_new.TabIndex = 15;
            this.btn_new.Text = "nuevo";
            this.btn_new.UseVisualStyleBackColor = true;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(277, 71);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 16;
            this.btn_save.Text = "guardar";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_del
            // 
            this.btn_del.Location = new System.Drawing.Point(277, 100);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(75, 23);
            this.btn_del.TabIndex = 17;
            this.btn_del.Text = "borrar";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // btn_sear
            // 
            this.btn_sear.Location = new System.Drawing.Point(277, 129);
            this.btn_sear.Name = "btn_sear";
            this.btn_sear.Size = new System.Drawing.Size(75, 23);
            this.btn_sear.TabIndex = 18;
            this.btn_sear.Text = "buscar";
            this.btn_sear.UseVisualStyleBackColor = true;
            this.btn_sear.Click += new System.EventHandler(this.btn_sear_Click);
            // 
            // tb_search
            // 
            this.tb_search.Location = new System.Drawing.Point(277, 159);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(100, 20);
            this.tb_search.TabIndex = 19;
            // 
            // id_avionTextBox
            // 
            this.id_avionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.avionesBindingSource, "Id_avion", true));
            this.id_avionTextBox.Location = new System.Drawing.Point(87, 48);
            this.id_avionTextBox.Name = "id_avionTextBox";
            this.id_avionTextBox.Size = new System.Drawing.Size(121, 20);
            this.id_avionTextBox.TabIndex = 20;
            // 
            // aerolineaComboBox
            // 
            this.aerolineaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.avionesBindingSource, "aerolinea", true));
            this.aerolineaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.aerolineaComboBox.FormattingEnabled = true;
            this.aerolineaComboBox.Items.AddRange(new object[] {
            "Aeromar",
            "Aeroméxico",
            "Aeroméxico Connect",
            "Interjet",
            "Magnicharters",
            "TAR",
            "VivaAerobus",
            "Volaris",
            "Aéreo Calafia",
            "Aéreo Servicio Guerrero",
            "Aerodan",
            "Aero Davinci",
            "Aerodinámica de Monterrey",
            "Aerolíneas Ejecutivas",
            "Aeromaan",
            "Aeromexpress",
            "Aeropostal Cargo de México",
            "AeroUnion",
            "ARD Charters",
            "Aviesa",
            "Avioquintana",
            "BAX Global",
            "Estafeta Carga Aérea",
            "Fiesta Airlines",
            "FlyMex",
            "Global Air",
            "Grupo Posadas",
            "Jetclub",
            "MasAir Cargo",
            "Omniflys",
            "Regional Cargo",
            "Republicair",
            "StatusAir",
            "TAR (Transportes Aéreos Regionales)",
            "Vacation Express",
            "VigoJet"});
            this.aerolineaComboBox.Location = new System.Drawing.Point(87, 74);
            this.aerolineaComboBox.Name = "aerolineaComboBox";
            this.aerolineaComboBox.Size = new System.Drawing.Size(121, 21);
            this.aerolineaComboBox.TabIndex = 22;
            // 
            // modeloTextBox
            // 
            this.modeloTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.avionesBindingSource, "modelo", true));
            this.modeloTextBox.Location = new System.Drawing.Point(87, 101);
            this.modeloTextBox.Name = "modeloTextBox";
            this.modeloTextBox.Size = new System.Drawing.Size(121, 20);
            this.modeloTextBox.TabIndex = 24;
            // 
            // tipoComboBox
            // 
            this.tipoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.avionesBindingSource, "tipo", true));
            this.tipoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipoComboBox.FormattingEnabled = true;
            this.tipoComboBox.Items.AddRange(new object[] {
            "comercial",
            "privado",
            "carga"});
            this.tipoComboBox.Location = new System.Drawing.Point(87, 127);
            this.tipoComboBox.Name = "tipoComboBox";
            this.tipoComboBox.Size = new System.Drawing.Size(121, 21);
            this.tipoComboBox.TabIndex = 26;
            // 
            // capacidadTextBox
            // 
            this.capacidadTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.avionesBindingSource, "capacidad", true));
            this.capacidadTextBox.Location = new System.Drawing.Point(87, 154);
            this.capacidadTextBox.Name = "capacidadTextBox";
            this.capacidadTextBox.Size = new System.Drawing.Size(121, 20);
            this.capacidadTextBox.TabIndex = 28;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(483, 348);
            this.Controls.Add(id_avionLabel);
            this.Controls.Add(this.id_avionTextBox);
            this.Controls.Add(aerolineaLabel);
            this.Controls.Add(this.aerolineaComboBox);
            this.Controls.Add(modeloLabel);
            this.Controls.Add(this.modeloTextBox);
            this.Controls.Add(tipoLabel);
            this.Controls.Add(this.tipoComboBox);
            this.Controls.Add(capacidadLabel);
            this.Controls.Add(this.capacidadTextBox);
            this.Controls.Add(this.tb_search);
            this.Controls.Add(this.btn_sear);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_new);
            this.Controls.Add(this.btn_ultimo);
            this.Controls.Add(this.btn_siguente);
            this.Controls.Add(this.btn_anterior);
            this.Controls.Add(this.btn_primero);
            this.Controls.Add(this.avionesBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "AVIONES";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aerolineaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avionesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avionesBindingNavigator)).EndInit();
            this.avionesBindingNavigator.ResumeLayout(false);
            this.avionesBindingNavigator.PerformLayout();
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
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.Button btn_primero;
        private System.Windows.Forms.Button btn_anterior;
        private System.Windows.Forms.Button btn_siguente;
        private System.Windows.Forms.Button btn_ultimo;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Button btn_sear;
        private System.Windows.Forms.TextBox tb_search;
        private System.Windows.Forms.TextBox id_avionTextBox;
        private System.Windows.Forms.ComboBox aerolineaComboBox;
        private System.Windows.Forms.TextBox modeloTextBox;
        private System.Windows.Forms.ComboBox tipoComboBox;
        private System.Windows.Forms.TextBox capacidadTextBox;
        private System.Windows.Forms.ToolStripDropDownButton toolStripLabel1;
        private System.Windows.Forms.ToolStripMenuItem mENUToolStripMenuItem;
    }
}

