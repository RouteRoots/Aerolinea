namespace aerolinea
{
    partial class Form2
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
            System.Windows.Forms.Label no_pasaporteLabel;
            System.Windows.Forms.Label f_nacLabel;
            System.Windows.Forms.Label nacionalidadLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.aerolineaDataSet = new aerolinea.aerolineaDataSet();
            this.pasajerosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pasajerosTableAdapter = new aerolinea.aerolineaDataSetTableAdapters.PasajerosTableAdapter();
            this.tableAdapterManager = new aerolinea.aerolineaDataSetTableAdapters.TableAdapterManager();
            this.pasajerosBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.mENUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.id_pasajeroTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.no_pasaporteTextBox = new System.Windows.Forms.TextBox();
            this.f_nacDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.tb_search = new System.Windows.Forms.TextBox();
            this.btn_sear = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_new = new System.Windows.Forms.Button();
            this.btn_ultimo = new System.Windows.Forms.Button();
            this.btn_siguente = new System.Windows.Forms.Button();
            this.btn_anterior = new System.Windows.Forms.Button();
            this.btn_primero = new System.Windows.Forms.Button();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.nacionalidadComboBox = new System.Windows.Forms.ComboBox();
            id_pasajeroLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            no_pasaporteLabel = new System.Windows.Forms.Label();
            f_nacLabel = new System.Windows.Forms.Label();
            nacionalidadLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.aerolineaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pasajerosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pasajerosBindingNavigator)).BeginInit();
            this.pasajerosBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // id_pasajeroLabel
            // 
            id_pasajeroLabel.AutoSize = true;
            id_pasajeroLabel.BackColor = System.Drawing.Color.Transparent;
            id_pasajeroLabel.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            id_pasajeroLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            id_pasajeroLabel.Location = new System.Drawing.Point(16, 52);
            id_pasajeroLabel.Name = "id_pasajeroLabel";
            id_pasajeroLabel.Size = new System.Drawing.Size(72, 13);
            id_pasajeroLabel.TabIndex = 1;
            id_pasajeroLabel.Text = "Id. Pasajero:";
            id_pasajeroLabel.Click += new System.EventHandler(this.id_pasajeroLabel_Click);
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.BackColor = System.Drawing.Color.Transparent;
            nombreLabel.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nombreLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            nombreLabel.Location = new System.Drawing.Point(16, 78);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(52, 13);
            nombreLabel.TabIndex = 3;
            nombreLabel.Text = "Nombre:";
            // 
            // no_pasaporteLabel
            // 
            no_pasaporteLabel.AutoSize = true;
            no_pasaporteLabel.BackColor = System.Drawing.Color.Transparent;
            no_pasaporteLabel.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            no_pasaporteLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            no_pasaporteLabel.Location = new System.Drawing.Point(16, 131);
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
            f_nacLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            f_nacLabel.Location = new System.Drawing.Point(16, 160);
            f_nacLabel.Name = "f_nacLabel";
            f_nacLabel.Size = new System.Drawing.Size(115, 13);
            f_nacLabel.TabIndex = 9;
            f_nacLabel.Text = "Fecha de Nacimiento";
            // 
            // nacionalidadLabel
            // 
            nacionalidadLabel.AutoSize = true;
            nacionalidadLabel.BackColor = System.Drawing.Color.Transparent;
            nacionalidadLabel.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nacionalidadLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            nacionalidadLabel.Location = new System.Drawing.Point(18, 102);
            nacionalidadLabel.Name = "nacionalidadLabel";
            nacionalidadLabel.Size = new System.Drawing.Size(79, 13);
            nacionalidadLabel.TabIndex = 28;
            nacionalidadLabel.Text = "Nacionalidad:";
            nacionalidadLabel.Click += new System.EventHandler(this.nacionalidadLabel_Click);
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
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1});
            this.pasajerosBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.pasajerosBindingNavigator.MoveFirstItem = null;
            this.pasajerosBindingNavigator.MoveLastItem = null;
            this.pasajerosBindingNavigator.MoveNextItem = null;
            this.pasajerosBindingNavigator.MovePreviousItem = null;
            this.pasajerosBindingNavigator.Name = "pasajerosBindingNavigator";
            this.pasajerosBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.pasajerosBindingNavigator.Size = new System.Drawing.Size(485, 25);
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
            this.bindingNavigatorPositionItem.Click += new System.EventHandler(this.bindingNavigatorPositionItem_Click);
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // id_pasajeroTextBox
            // 
            this.id_pasajeroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pasajerosBindingSource, "Id_pasajero", true));
            this.id_pasajeroTextBox.Location = new System.Drawing.Point(155, 49);
            this.id_pasajeroTextBox.Name = "id_pasajeroTextBox";
            this.id_pasajeroTextBox.Size = new System.Drawing.Size(200, 20);
            this.id_pasajeroTextBox.TabIndex = 2;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pasajerosBindingSource, "nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(155, 75);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(200, 20);
            this.nombreTextBox.TabIndex = 4;
            // 
            // no_pasaporteTextBox
            // 
            this.no_pasaporteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pasajerosBindingSource, "no_pasaporte", true));
            this.no_pasaporteTextBox.Location = new System.Drawing.Point(155, 128);
            this.no_pasaporteTextBox.Name = "no_pasaporteTextBox";
            this.no_pasaporteTextBox.Size = new System.Drawing.Size(200, 20);
            this.no_pasaporteTextBox.TabIndex = 8;
            // 
            // f_nacDateTimePicker
            // 
            this.f_nacDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.pasajerosBindingSource, "f_nac", true));
            this.f_nacDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.f_nacDateTimePicker.Location = new System.Drawing.Point(155, 154);
            this.f_nacDateTimePicker.MaxDate = new System.DateTime(2019, 12, 25, 23, 59, 59, 0);
            this.f_nacDateTimePicker.Name = "f_nacDateTimePicker";
            this.f_nacDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.f_nacDateTimePicker.TabIndex = 10;
            // 
            // tb_search
            // 
            this.tb_search.Location = new System.Drawing.Point(374, 156);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(100, 20);
            this.tb_search.TabIndex = 24;
            // 
            // btn_sear
            // 
            this.btn_sear.Location = new System.Drawing.Point(374, 126);
            this.btn_sear.Name = "btn_sear";
            this.btn_sear.Size = new System.Drawing.Size(75, 23);
            this.btn_sear.TabIndex = 23;
            this.btn_sear.Text = "buscar";
            this.btn_sear.UseVisualStyleBackColor = true;
            this.btn_sear.Click += new System.EventHandler(this.btn_sear_Click);
            // 
            // btn_del
            // 
            this.btn_del.Location = new System.Drawing.Point(374, 97);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(75, 23);
            this.btn_del.TabIndex = 22;
            this.btn_del.Text = "borrar";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(374, 68);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 21;
            this.btn_save.Text = "guardar";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_new
            // 
            this.btn_new.Location = new System.Drawing.Point(374, 42);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(75, 23);
            this.btn_new.TabIndex = 20;
            this.btn_new.Text = "nuevo";
            this.btn_new.UseVisualStyleBackColor = true;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // btn_ultimo
            // 
            this.btn_ultimo.BackColor = System.Drawing.Color.Transparent;
            this.btn_ultimo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_ultimo.BackgroundImage")));
            this.btn_ultimo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_ultimo.FlatAppearance.BorderSize = 0;
            this.btn_ultimo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ultimo.Location = new System.Drawing.Point(323, 231);
            this.btn_ultimo.Name = "btn_ultimo";
            this.btn_ultimo.Size = new System.Drawing.Size(88, 28);
            this.btn_ultimo.TabIndex = 28;
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
            this.btn_siguente.Location = new System.Drawing.Point(242, 231);
            this.btn_siguente.Name = "btn_siguente";
            this.btn_siguente.Size = new System.Drawing.Size(88, 28);
            this.btn_siguente.TabIndex = 27;
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
            this.btn_anterior.Location = new System.Drawing.Point(161, 231);
            this.btn_anterior.Name = "btn_anterior";
            this.btn_anterior.Size = new System.Drawing.Size(88, 28);
            this.btn_anterior.TabIndex = 26;
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
            this.btn_primero.Location = new System.Drawing.Point(73, 231);
            this.btn_primero.Name = "btn_primero";
            this.btn_primero.Size = new System.Drawing.Size(88, 28);
            this.btn_primero.TabIndex = 25;
            this.btn_primero.UseVisualStyleBackColor = false;
            this.btn_primero.Click += new System.EventHandler(this.btn_primero_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(41, 22);
            this.toolStripLabel1.Text = "MENU";
            this.toolStripLabel1.Click += new System.EventHandler(this.toolStripLabel1_Click);
            // 
            // nacionalidadComboBox
            // 
            this.nacionalidadComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pasajerosBindingSource, "nacionalidad", true));
            this.nacionalidadComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nacionalidadComboBox.FormattingEnabled = true;
            this.nacionalidadComboBox.Items.AddRange(new object[] {
            "Afganistán",
            "Akrotiri",
            "Albania",
            "Alemania",
            "Andorra",
            "Angola",
            "Anguila",
            "Antártida",
            "Antigua y Barbuda",
            "Antillas Neerlandesas",
            "Arabia Saudí",
            "Arctic Ocean",
            "Argelia",
            "Argentina",
            "Armenia",
            "Aruba",
            "Ashmore and Cartier Islands",
            "Atlantic Ocean",
            "Australia",
            "Austria",
            "Azerbaiyán",
            "Bahamas",
            "Bahráin",
            "Bangladesh",
            "Barbados",
            "Bélgica",
            "Belice",
            "Benín",
            "Bermudas",
            "Bielorrusia",
            "Birmania; Myanmar",
            "Bolivia",
            "Bosnia y Hercegovina",
            "Botsuana",
            "Brasil",
            "Brunéi",
            "Bulgaria",
            "Burkina Faso",
            "Burundi",
            "Bután",
            "Cabo Verde",
            "Camboya",
            "Camerún",
            "Canadá",
            "Chad",
            "Chile",
            "China",
            "Chipre",
            "Clipperton Island",
            "Colombia",
            "Comoras",
            "Congo",
            "Coral Sea Islands",
            "Corea del Norte",
            "Corea del Sur",
            "Costa de Marfil",
            "Costa Rica",
            "Croacia",
            "Cuba",
            "Dhekelia",
            "Dinamarca",
            "Dominica",
            "Ecuador",
            "Egipto",
            "El Salvador",
            "El Vaticano",
            "Emiratos Árabes Unidos",
            "Eritrea",
            "Eslovaquia",
            "Eslovenia",
            "España",
            "Estados Unidos",
            "Estonia",
            "Etiopía",
            "Filipinas",
            "Finlandia",
            "Fiyi",
            "Francia",
            "Gabón",
            "Gambia",
            "Gaza Strip",
            "Georgia",
            "Ghana",
            "Gibraltar",
            "Granada",
            "Grecia",
            "Groenlandia",
            "Guam",
            "Guatemala",
            "Guernsey",
            "Guinea",
            "Guinea Ecuatorial",
            "Guinea-Bissau",
            "Guyana",
            "Haití",
            "Honduras",
            "Hong Kong",
            "Hungría",
            "India",
            "Indian Ocean",
            "Indonesia",
            "Irán",
            "Iraq",
            "Irlanda",
            "Isla Bouvet",
            "Isla Christmas",
            "Isla Norfolk",
            "Islandia",
            "Islas Caimán",
            "Islas Cocos",
            "Islas Cook",
            "Islas Feroe",
            "Islas Georgia del Sur y Sandwich del Sur",
            "Islas Heard y McDonald",
            "Islas Malvinas",
            "Islas Marianas del Norte",
            "Islas Marshall",
            "Islas Pitcairn",
            "Islas Salomón",
            "Islas Turcas y Caicos",
            "Islas Vírgenes Americanas",
            "Islas Vírgenes Británicas",
            "Israel",
            "Italia",
            "Jamaica",
            "Jan Mayen",
            "Japón",
            "Jersey",
            "Jordania",
            "Kazajistán",
            "Kenia",
            "Kirguizistán",
            "Kiribati",
            "Kuwait",
            "Laos",
            "Lesoto",
            "Letonia",
            "Líbano",
            "Liberia",
            "Libia",
            "Liechtenstein",
            "Lituania",
            "Luxemburgo",
            "Macao",
            "Macedonia",
            "Madagascar",
            "Malasia",
            "Malaui",
            "Maldivas",
            "Malí",
            "Malta",
            "Man, Isle of",
            "Marruecos",
            "Mauricio",
            "Mauritania",
            "Mayotte",
            "México",
            "Micronesia",
            "Moldavia",
            "Mónaco",
            "Mongolia",
            "Montenegro",
            "Montserrat",
            "Mozambique",
            "Mundo",
            "Namibia",
            "Nauru",
            "Navassa Island",
            "Nepal",
            "Nicaragua",
            "Níger",
            "Nigeria",
            "Niue",
            "Noruega",
            "Nueva Caledonia",
            "Nueva Zelanda",
            "Omán",
            "Pacific Ocean",
            "Países Bajos",
            "Pakistán",
            "Palaos",
            "Panamá",
            "Papúa-Nueva Guinea",
            "Paracel Islands",
            "Paraguay",
            "Perú",
            "Polinesia Francesa",
            "Polonia",
            "Portugal",
            "Puerto Rico",
            "Qatar",
            "Reino Unido",
            "República Centroafricana",
            "República Checa",
            "República Democrática del Congo",
            "República Dominicana",
            "Ruanda",
            "Rumania",
            "Rusia",
            "Sáhara Occidental",
            "Samoa",
            "Samoa Americana",
            "San Cristóbal y Nieves",
            "San Marino",
            "San Pedro y Miquelón",
            "San Vicente y las Granadinas",
            "Santa Helena",
            "Santa Lucía",
            "Santo Tomé y Príncipe",
            "Senegal",
            "Serbia",
            "Seychelles",
            "Sierra Leona",
            "Singapur",
            "Siria",
            "Somalia",
            "Southern Ocean",
            "Spratly Islands",
            "Sri Lanka",
            "Suazilandia",
            "Sudáfrica",
            "Sudán",
            "Suecia",
            "Suiza",
            "Surinam",
            "Svalbard y Jan Mayen",
            "Tailandia",
            "Taiwán",
            "Tanzania",
            "Tayikistán",
            "Territorio Británico del Océano Indico",
            "Territorios Australes Franceses",
            "Timor Oriental",
            "Togo",
            "Tokelau",
            "Tonga",
            "Trinidad y Tobago",
            "Túnez",
            "Turkmenistán",
            "Turquía",
            "Tuvalu",
            "Ucrania",
            "Uganda",
            "Unión Europea",
            "Uruguay",
            "Uzbekistán",
            "Vanuatu",
            "Venezuela",
            "Vietnam",
            "Wake Island",
            "Wallis y Futuna",
            "West Bank",
            "Yemen",
            "Yibuti",
            "Zambia",
            "Zimbabue"});
            this.nacionalidadComboBox.Location = new System.Drawing.Point(155, 99);
            this.nacionalidadComboBox.Name = "nacionalidadComboBox";
            this.nacionalidadComboBox.Size = new System.Drawing.Size(200, 21);
            this.nacionalidadComboBox.TabIndex = 29;
            this.nacionalidadComboBox.SelectedIndexChanged += new System.EventHandler(this.nacionalidadComboBox_SelectedIndexChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(485, 299);
            this.Controls.Add(nacionalidadLabel);
            this.Controls.Add(this.nacionalidadComboBox);
            this.Controls.Add(this.btn_ultimo);
            this.Controls.Add(this.btn_siguente);
            this.Controls.Add(this.btn_anterior);
            this.Controls.Add(this.btn_primero);
            this.Controls.Add(this.tb_search);
            this.Controls.Add(this.btn_sear);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_new);
            this.Controls.Add(id_pasajeroLabel);
            this.Controls.Add(this.id_pasajeroTextBox);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(no_pasaporteLabel);
            this.Controls.Add(this.no_pasaporteTextBox);
            this.Controls.Add(f_nacLabel);
            this.Controls.Add(this.f_nacDateTimePicker);
            this.Controls.Add(this.pasajerosBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "PASAJEROS";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aerolineaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pasajerosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pasajerosBindingNavigator)).EndInit();
            this.pasajerosBindingNavigator.ResumeLayout(false);
            this.pasajerosBindingNavigator.PerformLayout();
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
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.TextBox id_pasajeroTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox no_pasaporteTextBox;
        private System.Windows.Forms.DateTimePicker f_nacDateTimePicker;
        private System.Windows.Forms.TextBox tb_search;
        private System.Windows.Forms.Button btn_sear;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.Button btn_ultimo;
        private System.Windows.Forms.Button btn_siguente;
        private System.Windows.Forms.Button btn_anterior;
        private System.Windows.Forms.Button btn_primero;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem mENUToolStripMenuItem;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ComboBox nacionalidadComboBox;
    }
}