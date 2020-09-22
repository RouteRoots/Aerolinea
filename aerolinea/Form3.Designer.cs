namespace aerolinea
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.aerolineaDataSet = new aerolinea.aerolineaDataSet();
            this.vuelosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vuelosTableAdapter = new aerolinea.aerolineaDataSetTableAdapters.VuelosTableAdapter();
            this.tableAdapterManager = new aerolinea.aerolineaDataSetTableAdapters.TableAdapterManager();
            this.avionesTableAdapter = new aerolinea.aerolineaDataSetTableAdapters.AvionesTableAdapter();
            this.vuelosBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.mENUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.id_vueloTextBox = new System.Windows.Forms.TextBox();
            this.id_avionComboBox = new System.Windows.Forms.ComboBox();
            this.avionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.origenComboBox = new System.Windows.Forms.ComboBox();
            this.destinoComboBox = new System.Windows.Forms.ComboBox();
            this.f_salidaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.f_llegadaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.h_salidaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.h_llegadaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.btn_ultimo = new System.Windows.Forms.Button();
            this.btn_siguente = new System.Windows.Forms.Button();
            this.btn_anterior = new System.Windows.Forms.Button();
            this.btn_primero = new System.Windows.Forms.Button();
            this.tb_search = new System.Windows.Forms.TextBox();
            this.btn_sear = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_new = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.avionesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // id_vueloLabel
            // 
            id_vueloLabel.AutoSize = true;
            id_vueloLabel.BackColor = System.Drawing.Color.Transparent;
            id_vueloLabel.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            id_vueloLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            id_vueloLabel.Location = new System.Drawing.Point(35, 48);
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
            id_avionLabel.Location = new System.Drawing.Point(35, 74);
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
            origenLabel.Location = new System.Drawing.Point(35, 101);
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
            destinoLabel.Location = new System.Drawing.Point(35, 128);
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
            f_salidaLabel.Location = new System.Drawing.Point(35, 156);
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
            f_llegadaLabel.Location = new System.Drawing.Point(35, 182);
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
            h_salidaLabel.Location = new System.Drawing.Point(35, 208);
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
            h_llegadaLabel.Location = new System.Drawing.Point(35, 234);
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
            this.tableAdapterManager.AvionesTableAdapter = this.avionesTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.lis_pasajerosTableAdapter = null;
            this.tableAdapterManager.PasajerosTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = aerolinea.aerolineaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VuelosTableAdapter = this.vuelosTableAdapter;
            // 
            // avionesTableAdapter
            // 
            this.avionesTableAdapter.ClearBeforeFill = true;
            // 
            // vuelosBindingNavigator
            // 
            this.vuelosBindingNavigator.AddNewItem = null;
            this.vuelosBindingNavigator.BindingSource = this.vuelosBindingSource;
            this.vuelosBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.vuelosBindingNavigator.DeleteItem = null;
            this.vuelosBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorSeparator2});
            this.vuelosBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.vuelosBindingNavigator.MoveFirstItem = null;
            this.vuelosBindingNavigator.MoveLastItem = null;
            this.vuelosBindingNavigator.MoveNextItem = null;
            this.vuelosBindingNavigator.MovePreviousItem = null;
            this.vuelosBindingNavigator.Name = "vuelosBindingNavigator";
            this.vuelosBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.vuelosBindingNavigator.Size = new System.Drawing.Size(506, 25);
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
            this.toolStripDropDownButton1.Click += new System.EventHandler(this.toolStripDropDownButton1_Click);
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
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // id_vueloTextBox
            // 
            this.id_vueloTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vuelosBindingSource, "Id_vuelo", true));
            this.id_vueloTextBox.Location = new System.Drawing.Point(104, 45);
            this.id_vueloTextBox.Name = "id_vueloTextBox";
            this.id_vueloTextBox.Size = new System.Drawing.Size(200, 20);
            this.id_vueloTextBox.TabIndex = 2;
            // 
            // id_avionComboBox
            // 
            this.id_avionComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vuelosBindingSource, "id_avion", true));
            this.id_avionComboBox.DataSource = this.avionesBindingSource;
            this.id_avionComboBox.DisplayMember = "Id_avion";
            this.id_avionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.id_avionComboBox.FormattingEnabled = true;
            this.id_avionComboBox.Location = new System.Drawing.Point(104, 71);
            this.id_avionComboBox.Name = "id_avionComboBox";
            this.id_avionComboBox.Size = new System.Drawing.Size(200, 21);
            this.id_avionComboBox.TabIndex = 4;
            this.id_avionComboBox.ValueMember = "Id_avion";
            // 
            // avionesBindingSource
            // 
            this.avionesBindingSource.DataMember = "Aviones";
            this.avionesBindingSource.DataSource = this.aerolineaDataSet;
            // 
            // origenComboBox
            // 
            this.origenComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vuelosBindingSource, "origen", true));
            this.origenComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.origenComboBox.FormattingEnabled = true;
            this.origenComboBox.Items.AddRange(new object[] {
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
            this.origenComboBox.Location = new System.Drawing.Point(104, 98);
            this.origenComboBox.Name = "origenComboBox";
            this.origenComboBox.Size = new System.Drawing.Size(200, 21);
            this.origenComboBox.TabIndex = 6;
            // 
            // destinoComboBox
            // 
            this.destinoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vuelosBindingSource, "destino", true));
            this.destinoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.destinoComboBox.FormattingEnabled = true;
            this.destinoComboBox.Items.AddRange(new object[] {
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
            this.destinoComboBox.Location = new System.Drawing.Point(104, 125);
            this.destinoComboBox.Name = "destinoComboBox";
            this.destinoComboBox.Size = new System.Drawing.Size(200, 21);
            this.destinoComboBox.TabIndex = 8;
            // 
            // f_salidaDateTimePicker
            // 
            this.f_salidaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.vuelosBindingSource, "f_salida", true));
            this.f_salidaDateTimePicker.Location = new System.Drawing.Point(104, 152);
            this.f_salidaDateTimePicker.Name = "f_salidaDateTimePicker";
            this.f_salidaDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.f_salidaDateTimePicker.TabIndex = 10;
            // 
            // f_llegadaDateTimePicker
            // 
            this.f_llegadaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.vuelosBindingSource, "f_llegada", true));
            this.f_llegadaDateTimePicker.Location = new System.Drawing.Point(104, 178);
            this.f_llegadaDateTimePicker.Name = "f_llegadaDateTimePicker";
            this.f_llegadaDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.f_llegadaDateTimePicker.TabIndex = 12;
            // 
            // h_salidaDateTimePicker
            // 
            this.h_salidaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.vuelosBindingSource, "h_salida", true));
            this.h_salidaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.h_salidaDateTimePicker.Location = new System.Drawing.Point(104, 204);
            this.h_salidaDateTimePicker.Name = "h_salidaDateTimePicker";
            this.h_salidaDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.h_salidaDateTimePicker.TabIndex = 14;
            this.h_salidaDateTimePicker.ValueChanged += new System.EventHandler(this.h_salidaDateTimePicker_ValueChanged);
            // 
            // h_llegadaDateTimePicker
            // 
            this.h_llegadaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.vuelosBindingSource, "h_llegada", true));
            this.h_llegadaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.h_llegadaDateTimePicker.Location = new System.Drawing.Point(104, 230);
            this.h_llegadaDateTimePicker.Name = "h_llegadaDateTimePicker";
            this.h_llegadaDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.h_llegadaDateTimePicker.TabIndex = 16;
            // 
            // btn_ultimo
            // 
            this.btn_ultimo.BackColor = System.Drawing.Color.Transparent;
            this.btn_ultimo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_ultimo.BackgroundImage")));
            this.btn_ultimo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_ultimo.FlatAppearance.BorderSize = 0;
            this.btn_ultimo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ultimo.Location = new System.Drawing.Point(346, 287);
            this.btn_ultimo.Name = "btn_ultimo";
            this.btn_ultimo.Size = new System.Drawing.Size(76, 30);
            this.btn_ultimo.TabIndex = 32;
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
            this.btn_siguente.Location = new System.Drawing.Point(265, 287);
            this.btn_siguente.Name = "btn_siguente";
            this.btn_siguente.Size = new System.Drawing.Size(76, 30);
            this.btn_siguente.TabIndex = 31;
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
            this.btn_anterior.Location = new System.Drawing.Point(184, 287);
            this.btn_anterior.Name = "btn_anterior";
            this.btn_anterior.Size = new System.Drawing.Size(76, 30);
            this.btn_anterior.TabIndex = 30;
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
            this.btn_primero.Location = new System.Drawing.Point(96, 287);
            this.btn_primero.Name = "btn_primero";
            this.btn_primero.Size = new System.Drawing.Size(76, 30);
            this.btn_primero.TabIndex = 29;
            this.btn_primero.UseVisualStyleBackColor = false;
            this.btn_primero.Click += new System.EventHandler(this.btn_primero_Click);
            // 
            // tb_search
            // 
            this.tb_search.Location = new System.Drawing.Point(376, 172);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(100, 20);
            this.tb_search.TabIndex = 37;
            // 
            // btn_sear
            // 
            this.btn_sear.Location = new System.Drawing.Point(376, 142);
            this.btn_sear.Name = "btn_sear";
            this.btn_sear.Size = new System.Drawing.Size(75, 23);
            this.btn_sear.TabIndex = 36;
            this.btn_sear.Text = "buscar";
            this.btn_sear.UseVisualStyleBackColor = true;
            this.btn_sear.Click += new System.EventHandler(this.btn_sear_Click);
            // 
            // btn_del
            // 
            this.btn_del.Location = new System.Drawing.Point(376, 113);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(75, 23);
            this.btn_del.TabIndex = 35;
            this.btn_del.Text = "borrar";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(376, 84);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 34;
            this.btn_save.Text = "guardar";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_new
            // 
            this.btn_new.Location = new System.Drawing.Point(376, 58);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(75, 23);
            this.btn_new.TabIndex = 33;
            this.btn_new.Text = "nuevo";
            this.btn_new.UseVisualStyleBackColor = true;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(506, 353);
            this.Controls.Add(this.tb_search);
            this.Controls.Add(this.btn_sear);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_new);
            this.Controls.Add(this.btn_ultimo);
            this.Controls.Add(this.btn_siguente);
            this.Controls.Add(this.btn_anterior);
            this.Controls.Add(this.btn_primero);
            this.Controls.Add(id_vueloLabel);
            this.Controls.Add(this.id_vueloTextBox);
            this.Controls.Add(id_avionLabel);
            this.Controls.Add(this.id_avionComboBox);
            this.Controls.Add(origenLabel);
            this.Controls.Add(this.origenComboBox);
            this.Controls.Add(destinoLabel);
            this.Controls.Add(this.destinoComboBox);
            this.Controls.Add(f_salidaLabel);
            this.Controls.Add(this.f_salidaDateTimePicker);
            this.Controls.Add(f_llegadaLabel);
            this.Controls.Add(this.f_llegadaDateTimePicker);
            this.Controls.Add(h_salidaLabel);
            this.Controls.Add(this.h_salidaDateTimePicker);
            this.Controls.Add(h_llegadaLabel);
            this.Controls.Add(this.h_llegadaDateTimePicker);
            this.Controls.Add(this.vuelosBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.Text = "VUELOS";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aerolineaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vuelosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vuelosBindingNavigator)).EndInit();
            this.vuelosBindingNavigator.ResumeLayout(false);
            this.vuelosBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avionesBindingSource)).EndInit();
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
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private aerolineaDataSetTableAdapters.AvionesTableAdapter avionesTableAdapter;
        private System.Windows.Forms.TextBox id_vueloTextBox;
        private System.Windows.Forms.ComboBox id_avionComboBox;
        private System.Windows.Forms.ComboBox origenComboBox;
        private System.Windows.Forms.ComboBox destinoComboBox;
        private System.Windows.Forms.DateTimePicker f_salidaDateTimePicker;
        private System.Windows.Forms.DateTimePicker f_llegadaDateTimePicker;
        private System.Windows.Forms.DateTimePicker h_salidaDateTimePicker;
        private System.Windows.Forms.DateTimePicker h_llegadaDateTimePicker;
        private System.Windows.Forms.BindingSource avionesBindingSource;
        private System.Windows.Forms.Button btn_ultimo;
        private System.Windows.Forms.Button btn_siguente;
        private System.Windows.Forms.Button btn_anterior;
        private System.Windows.Forms.Button btn_primero;
        private System.Windows.Forms.TextBox tb_search;
        private System.Windows.Forms.Button btn_sear;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem mENUToolStripMenuItem;
    }
}