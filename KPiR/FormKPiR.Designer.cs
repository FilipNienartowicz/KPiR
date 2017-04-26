namespace KPiR
{
    partial class FormKPiR
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKPiR));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPagePiR = new System.Windows.Forms.TabPage();
            this.label15 = new System.Windows.Forms.Label();
            this.textBoxPiRKontrahent = new System.Windows.Forms.TextBox();
            this.textBoxPiROperacja = new System.Windows.Forms.TextBox();
            this.buttonPiR_do = new System.Windows.Forms.Button();
            this.buttonPiR_od = new System.Windows.Forms.Button();
            this.dataGridViewPiRKonta = new System.Windows.Forms.DataGridView();
            this.NAZWA_KONTA_PiR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aKTYWNYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STAN_OTW = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STAN_ZAMK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kONTABindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new KPiR.DataSet1();
            this.buttonPiRusun = new System.Windows.Forms.Button();
            this.buttonAnuluj = new System.Windows.Forms.Button();
            this.buttonZapisz = new System.Windows.Forms.Button();
            this.buttonFiltry = new System.Windows.Forms.Button();
            this.buttonWyczysc = new System.Windows.Forms.Button();
            this.buttonPokaz = new System.Windows.Forms.Button();
            this.dataError = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPiRDo = new System.Windows.Forms.TextBox();
            this.textBoxPiROd = new System.Windows.Forms.TextBox();
            this.radioButtonCustom = new System.Windows.Forms.RadioButton();
            this.radioButtonCurMonth = new System.Windows.Forms.RadioButton();
            this.radioButtonAll = new System.Windows.Forms.RadioButton();
            this.dataGridViewPiR = new System.Windows.Forms.DataGridView();
            this.pRZYCHODYIROZCHODYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPageAkcje = new System.Windows.Forms.TabPage();
            this.buttonAkcjaNazwa = new System.Windows.Forms.Button();
            this.buttonAkcjaDodaj = new System.Windows.Forms.Button();
            this.textBoxAkcjaNowa = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBoxAkcjeKoordynator = new System.Windows.Forms.ComboBox();
            this.kOORDYNATORZYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonAkcje = new System.Windows.Forms.Button();
            this.buttonAkcje_Usun_Edycje = new System.Windows.Forms.Button();
            this.radioButtonAkcja_nowa = new System.Windows.Forms.RadioButton();
            this.radioButtonAkcja_obecna = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxAkcjeOd = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxNazwaAkcji = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.buttonAkcje_Anuluj = new System.Windows.Forms.Button();
            this.buttonAkcje_Zapisz = new System.Windows.Forms.Button();
            this.dataGridViewAkcje = new System.Windows.Forms.DataGridView();
            this.AKCJANAZWA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aKCJEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.buttonAkcje_Usun_Akcje = new System.Windows.Forms.Button();
            this.dataGridViewAkcjeHistoria = new System.Windows.Forms.DataGridView();
            this.AKCJA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AKCJA_KOORDYNATOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AKCJA_OD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AKCJA_DO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDAKCJA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aKCJEFKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPageKoordynatorzy = new System.Windows.Forms.TabPage();
            this.buttonkoord_od = new System.Windows.Forms.Button();
            this.buttonUsun_koord = new System.Windows.Forms.Button();
            this.radioButtonkoord_nowy = new System.Windows.Forms.RadioButton();
            this.radioButtonkoord_obecny = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxkoordod = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxNazwisko = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxImie = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxFunkcja = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonkoordanuluj = new System.Windows.Forms.Button();
            this.buttonkoordzapisz = new System.Windows.Forms.Button();
            this.dataGridViewKoordHist = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KOORD_OD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KOORD_DO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kOORDHISTOKOORDFKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewKoord = new System.Windows.Forms.DataGridView();
            this.FUNKCJA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IMIE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NAZWISKO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPageKonta = new System.Windows.Forms.TabPage();
            this.dataGridViewKonta = new System.Windows.Forms.DataGridView();
            this.NAZWA_KONTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AKTYWNE = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.STAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonKontaUsun = new System.Windows.Forms.Button();
            this.buttonKontaAnuluj = new System.Windows.Forms.Button();
            this.buttonKontaZapisz = new System.Windows.Forms.Button();
            this.kONTABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet11 = new KPiR.DataSet1();
            this.kONTATableAdapter = new KPiR.DataSet1TableAdapters.KONTATableAdapter();
            this.kOORDYNATORZYTableAdapter = new KPiR.DataSet1TableAdapters.KOORDYNATORZYTableAdapter();
            this.kOORDYNATORZY_HISTORIATableAdapter = new KPiR.DataSet1TableAdapters.KOORDYNATORZY_HISTORIATableAdapter();
            this.aKCJETableAdapter = new KPiR.DataSet1TableAdapters.AKCJETableAdapter();
            this.aKCJE_HISTORIATableAdapter = new KPiR.DataSet1TableAdapters.AKCJE_HISTORIATableAdapter();
            this.pRZYCHODY_I_ROZCHODYTableAdapter = new KPiR.DataSet1TableAdapters.PRZYCHODY_I_ROZCHODYTableAdapter();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KONTRAHENT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TYTUŁ_OPERACJI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NR_DOKUMENTU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATA_DOKONANIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRZYCHOD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ROZCHOD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KWOTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RODZAJ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KONTO = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.AKCJA_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PiR_AKCJA = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.KOORD_IMIE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KOORD_NAZWISKO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPagePiR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPiRKonta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kONTABindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPiR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRZYCHODYIROZCHODYBindingSource)).BeginInit();
            this.tabPageAkcje.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kOORDYNATORZYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAkcje)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aKCJEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAkcjeHistoria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aKCJEFKBindingSource)).BeginInit();
            this.tabPageKoordynatorzy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKoordHist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kOORDHISTOKOORDFKBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKoord)).BeginInit();
            this.tabPageKonta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKonta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kONTABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPagePiR);
            this.tabControl1.Controls.Add(this.tabPageAkcje);
            this.tabControl1.Controls.Add(this.tabPageKoordynatorzy);
            this.tabControl1.Controls.Add(this.tabPageKonta);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1463, 784);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Deselecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControl1_Deselecting);
            // 
            // tabPagePiR
            // 
            this.tabPagePiR.Controls.Add(this.label15);
            this.tabPagePiR.Controls.Add(this.textBoxPiRKontrahent);
            this.tabPagePiR.Controls.Add(this.textBoxPiROperacja);
            this.tabPagePiR.Controls.Add(this.buttonPiR_do);
            this.tabPagePiR.Controls.Add(this.buttonPiR_od);
            this.tabPagePiR.Controls.Add(this.dataGridViewPiRKonta);
            this.tabPagePiR.Controls.Add(this.buttonPiRusun);
            this.tabPagePiR.Controls.Add(this.buttonAnuluj);
            this.tabPagePiR.Controls.Add(this.buttonZapisz);
            this.tabPagePiR.Controls.Add(this.buttonFiltry);
            this.tabPagePiR.Controls.Add(this.buttonWyczysc);
            this.tabPagePiR.Controls.Add(this.buttonPokaz);
            this.tabPagePiR.Controls.Add(this.dataError);
            this.tabPagePiR.Controls.Add(this.label2);
            this.tabPagePiR.Controls.Add(this.label1);
            this.tabPagePiR.Controls.Add(this.textBoxPiRDo);
            this.tabPagePiR.Controls.Add(this.textBoxPiROd);
            this.tabPagePiR.Controls.Add(this.radioButtonCustom);
            this.tabPagePiR.Controls.Add(this.radioButtonCurMonth);
            this.tabPagePiR.Controls.Add(this.radioButtonAll);
            this.tabPagePiR.Controls.Add(this.dataGridViewPiR);
            this.tabPagePiR.Location = new System.Drawing.Point(4, 25);
            this.tabPagePiR.Name = "tabPagePiR";
            this.tabPagePiR.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePiR.Size = new System.Drawing.Size(1455, 755);
            this.tabPagePiR.TabIndex = 0;
            this.tabPagePiR.Text = "Przychody i Rozchody";
            this.tabPagePiR.UseVisualStyleBackColor = true;
            this.tabPagePiR.Enter += new System.EventHandler(this.tabPagePiR_Enter);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(233, 188);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(92, 17);
            this.label15.TabIndex = 38;
            this.label15.Text = "Szukaj tekstu";
            // 
            // textBoxPiRKontrahent
            // 
            this.textBoxPiRKontrahent.Location = new System.Drawing.Point(121, 217);
            this.textBoxPiRKontrahent.Name = "textBoxPiRKontrahent";
            this.textBoxPiRKontrahent.Size = new System.Drawing.Size(148, 22);
            this.textBoxPiRKontrahent.TabIndex = 37;
            // 
            // textBoxPiROperacja
            // 
            this.textBoxPiROperacja.Location = new System.Drawing.Point(282, 217);
            this.textBoxPiROperacja.Name = "textBoxPiROperacja";
            this.textBoxPiROperacja.Size = new System.Drawing.Size(190, 22);
            this.textBoxPiROperacja.TabIndex = 36;
            // 
            // buttonPiR_do
            // 
            this.buttonPiR_do.Image = ((System.Drawing.Image)(resources.GetObject("buttonPiR_do.Image")));
            this.buttonPiR_do.Location = new System.Drawing.Point(437, 93);
            this.buttonPiR_do.Name = "buttonPiR_do";
            this.buttonPiR_do.Size = new System.Drawing.Size(35, 35);
            this.buttonPiR_do.TabIndex = 35;
            this.buttonPiR_do.UseVisualStyleBackColor = true;
            this.buttonPiR_do.Click += new System.EventHandler(this.buttonDate_Click);
            // 
            // buttonPiR_od
            // 
            this.buttonPiR_od.Image = ((System.Drawing.Image)(resources.GetObject("buttonPiR_od.Image")));
            this.buttonPiR_od.Location = new System.Drawing.Point(249, 96);
            this.buttonPiR_od.Name = "buttonPiR_od";
            this.buttonPiR_od.Size = new System.Drawing.Size(35, 35);
            this.buttonPiR_od.TabIndex = 34;
            this.buttonPiR_od.UseVisualStyleBackColor = true;
            this.buttonPiR_od.Click += new System.EventHandler(this.buttonDate_Click);
            // 
            // dataGridViewPiRKonta
            // 
            this.dataGridViewPiRKonta.AllowUserToAddRows = false;
            this.dataGridViewPiRKonta.AllowUserToDeleteRows = false;
            this.dataGridViewPiRKonta.AutoGenerateColumns = false;
            this.dataGridViewPiRKonta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewPiRKonta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPiRKonta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NAZWA_KONTA_PiR,
            this.aKTYWNYDataGridViewTextBoxColumn,
            this.STAN_OTW,
            this.STAN_ZAMK});
            this.dataGridViewPiRKonta.DataSource = this.kONTABindingSource1;
            this.dataGridViewPiRKonta.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewPiRKonta.Location = new System.Drawing.Point(921, 6);
            this.dataGridViewPiRKonta.MultiSelect = false;
            this.dataGridViewPiRKonta.Name = "dataGridViewPiRKonta";
            this.dataGridViewPiRKonta.ReadOnly = true;
            this.dataGridViewPiRKonta.RowHeadersVisible = false;
            this.dataGridViewPiRKonta.RowTemplate.Height = 24;
            this.dataGridViewPiRKonta.Size = new System.Drawing.Size(452, 222);
            this.dataGridViewPiRKonta.TabIndex = 15;
            // 
            // NAZWA_KONTA_PiR
            // 
            this.NAZWA_KONTA_PiR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NAZWA_KONTA_PiR.DataPropertyName = "NAZWA";
            this.NAZWA_KONTA_PiR.HeaderText = "NAZWA";
            this.NAZWA_KONTA_PiR.Name = "NAZWA_KONTA_PiR";
            this.NAZWA_KONTA_PiR.ReadOnly = true;
            // 
            // aKTYWNYDataGridViewTextBoxColumn
            // 
            this.aKTYWNYDataGridViewTextBoxColumn.DataPropertyName = "AKTYWNY";
            this.aKTYWNYDataGridViewTextBoxColumn.HeaderText = "AKTYWNY";
            this.aKTYWNYDataGridViewTextBoxColumn.Name = "aKTYWNYDataGridViewTextBoxColumn";
            this.aKTYWNYDataGridViewTextBoxColumn.ReadOnly = true;
            this.aKTYWNYDataGridViewTextBoxColumn.Visible = false;
            this.aKTYWNYDataGridViewTextBoxColumn.Width = 101;
            // 
            // STAN_OTW
            // 
            this.STAN_OTW.HeaderText = "STAN OTWARCIA";
            this.STAN_OTW.Name = "STAN_OTW";
            this.STAN_OTW.ReadOnly = true;
            this.STAN_OTW.Width = 134;
            // 
            // STAN_ZAMK
            // 
            this.STAN_ZAMK.HeaderText = "STAN ZAMKNIĘCIA";
            this.STAN_ZAMK.Name = "STAN_ZAMK";
            this.STAN_ZAMK.ReadOnly = true;
            this.STAN_ZAMK.Width = 141;
            // 
            // kONTABindingSource1
            // 
            this.kONTABindingSource1.DataMember = "KONTA";
            this.kONTABindingSource1.DataSource = this.dataSet1;
            this.kONTABindingSource1.Sort = "NAZWA";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buttonPiRusun
            // 
            this.buttonPiRusun.Location = new System.Drawing.Point(304, 694);
            this.buttonPiRusun.Name = "buttonPiRusun";
            this.buttonPiRusun.Size = new System.Drawing.Size(96, 45);
            this.buttonPiRusun.TabIndex = 14;
            this.buttonPiRusun.Text = "Usuń pozycję";
            this.buttonPiRusun.UseVisualStyleBackColor = true;
            this.buttonPiRusun.Click += new System.EventHandler(this.buttonPiRusun_Click);
            // 
            // buttonAnuluj
            // 
            this.buttonAnuluj.Location = new System.Drawing.Point(150, 694);
            this.buttonAnuluj.Name = "buttonAnuluj";
            this.buttonAnuluj.Size = new System.Drawing.Size(96, 45);
            this.buttonAnuluj.TabIndex = 13;
            this.buttonAnuluj.Text = "Anuluj";
            this.buttonAnuluj.UseVisualStyleBackColor = true;
            this.buttonAnuluj.Click += new System.EventHandler(this.buttonAnuluj_Click);
            // 
            // buttonZapisz
            // 
            this.buttonZapisz.Location = new System.Drawing.Point(18, 694);
            this.buttonZapisz.Name = "buttonZapisz";
            this.buttonZapisz.Size = new System.Drawing.Size(96, 45);
            this.buttonZapisz.TabIndex = 12;
            this.buttonZapisz.Text = "Zapisz zmiany";
            this.buttonZapisz.UseVisualStyleBackColor = true;
            this.buttonZapisz.Click += new System.EventHandler(this.buttonZapisz_Click);
            // 
            // buttonFiltry
            // 
            this.buttonFiltry.Location = new System.Drawing.Point(103, 139);
            this.buttonFiltry.Name = "buttonFiltry";
            this.buttonFiltry.Size = new System.Drawing.Size(85, 31);
            this.buttonFiltry.TabIndex = 11;
            this.buttonFiltry.Text = "Filtry";
            this.buttonFiltry.UseVisualStyleBackColor = true;
            this.buttonFiltry.Click += new System.EventHandler(this.buttonFiltry_Click);
            // 
            // buttonWyczysc
            // 
            this.buttonWyczysc.Location = new System.Drawing.Point(194, 139);
            this.buttonWyczysc.Name = "buttonWyczysc";
            this.buttonWyczysc.Size = new System.Drawing.Size(115, 31);
            this.buttonWyczysc.TabIndex = 10;
            this.buttonWyczysc.Text = "Wyczyść filtry";
            this.buttonWyczysc.UseVisualStyleBackColor = true;
            this.buttonWyczysc.Click += new System.EventHandler(this.buttonWyczysc_Click);
            // 
            // buttonPokaz
            // 
            this.buttonPokaz.Location = new System.Drawing.Point(18, 139);
            this.buttonPokaz.Name = "buttonPokaz";
            this.buttonPokaz.Size = new System.Drawing.Size(75, 31);
            this.buttonPokaz.TabIndex = 9;
            this.buttonPokaz.Text = "Pokaż";
            this.buttonPokaz.UseVisualStyleBackColor = true;
            this.buttonPokaz.Click += new System.EventHandler(this.buttonPokaz_Click);
            // 
            // dataError
            // 
            this.dataError.AutoSize = true;
            this.dataError.ForeColor = System.Drawing.Color.DarkRed;
            this.dataError.Location = new System.Drawing.Point(181, 65);
            this.dataError.Name = "dataError";
            this.dataError.Size = new System.Drawing.Size(250, 17);
            this.dataError.TabIndex = 8;
            this.dataError.Text = "Data od musi być mniejsza od daty do!";
            this.dataError.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "od";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(301, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "do";
            // 
            // textBoxPiRDo
            // 
            this.textBoxPiRDo.Location = new System.Drawing.Point(331, 106);
            this.textBoxPiRDo.MaxLength = 10;
            this.textBoxPiRDo.Name = "textBoxPiRDo";
            this.textBoxPiRDo.Size = new System.Drawing.Size(100, 22);
            this.textBoxPiRDo.TabIndex = 5;
            this.textBoxPiRDo.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.textBoxPiRDo.Leave += new System.EventHandler(this.textBoxDate_Leave);
            // 
            // textBoxPiROd
            // 
            this.textBoxPiROd.Location = new System.Drawing.Point(143, 106);
            this.textBoxPiROd.MaxLength = 10;
            this.textBoxPiROd.Name = "textBoxPiROd";
            this.textBoxPiROd.Size = new System.Drawing.Size(100, 22);
            this.textBoxPiROd.TabIndex = 4;
            this.textBoxPiROd.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.textBoxPiROd.Leave += new System.EventHandler(this.textBoxDate_Leave);
            // 
            // radioButtonCustom
            // 
            this.radioButtonCustom.AutoSize = true;
            this.radioButtonCustom.Location = new System.Drawing.Point(18, 103);
            this.radioButtonCustom.Name = "radioButtonCustom";
            this.radioButtonCustom.Size = new System.Drawing.Size(89, 21);
            this.radioButtonCustom.TabIndex = 3;
            this.radioButtonCustom.Text = "Z okresu:";
            this.radioButtonCustom.UseVisualStyleBackColor = true;
            // 
            // radioButtonCurMonth
            // 
            this.radioButtonCurMonth.AutoSize = true;
            this.radioButtonCurMonth.Location = new System.Drawing.Point(18, 61);
            this.radioButtonCurMonth.Name = "radioButtonCurMonth";
            this.radioButtonCurMonth.Size = new System.Drawing.Size(129, 21);
            this.radioButtonCurMonth.TabIndex = 2;
            this.radioButtonCurMonth.Text = "Bieżący miesiąc";
            this.radioButtonCurMonth.UseVisualStyleBackColor = true;
            // 
            // radioButtonAll
            // 
            this.radioButtonAll.AutoSize = true;
            this.radioButtonAll.Checked = true;
            this.radioButtonAll.Location = new System.Drawing.Point(18, 21);
            this.radioButtonAll.Name = "radioButtonAll";
            this.radioButtonAll.Size = new System.Drawing.Size(170, 21);
            this.radioButtonAll.TabIndex = 1;
            this.radioButtonAll.TabStop = true;
            this.radioButtonAll.Text = "Cała dostępna historia";
            this.radioButtonAll.UseVisualStyleBackColor = true;
            // 
            // dataGridViewPiR
            // 
            this.dataGridViewPiR.AllowUserToResizeColumns = false;
            this.dataGridViewPiR.AutoGenerateColumns = false;
            this.dataGridViewPiR.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewPiR.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewPiR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPiR.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.KONTRAHENT,
            this.TYTUŁ_OPERACJI,
            this.NR_DOKUMENTU,
            this.DATA_DOKONANIA,
            this.PRZYCHOD,
            this.ROZCHOD,
            this.KWOTA,
            this.RODZAJ,
            this.KONTO,
            this.AKCJA_ID,
            this.PiR_AKCJA,
            this.KOORD_IMIE,
            this.KOORD_NAZWISKO});
            this.dataGridViewPiR.DataSource = this.pRZYCHODYIROZCHODYBindingSource;
            this.dataGridViewPiR.Location = new System.Drawing.Point(18, 245);
            this.dataGridViewPiR.MultiSelect = false;
            this.dataGridViewPiR.Name = "dataGridViewPiR";
            this.dataGridViewPiR.RowHeadersVisible = false;
            this.dataGridViewPiR.RowTemplate.Height = 24;
            this.dataGridViewPiR.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPiR.ShowCellErrors = false;
            this.dataGridViewPiR.ShowRowErrors = false;
            this.dataGridViewPiR.Size = new System.Drawing.Size(1422, 443);
            this.dataGridViewPiR.TabIndex = 0;
            this.dataGridViewPiR.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridViewPiR_CellBeginEdit);
            this.dataGridViewPiR.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPiR_CellValueChanged);
            this.dataGridViewPiR.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridViewPiR_DataError);
            this.dataGridViewPiR.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridViewPiR_UserAddedRow);
            // 
            // pRZYCHODYIROZCHODYBindingSource
            // 
            this.pRZYCHODYIROZCHODYBindingSource.DataMember = "PRZYCHODY_I_ROZCHODY";
            this.pRZYCHODYIROZCHODYBindingSource.DataSource = this.dataSet1;
            this.pRZYCHODYIROZCHODYBindingSource.Sort = "DATA_DOKONANIA";
            // 
            // tabPageAkcje
            // 
            this.tabPageAkcje.Controls.Add(this.buttonAkcjaNazwa);
            this.tabPageAkcje.Controls.Add(this.buttonAkcjaDodaj);
            this.tabPageAkcje.Controls.Add(this.textBoxAkcjaNowa);
            this.tabPageAkcje.Controls.Add(this.label12);
            this.tabPageAkcje.Controls.Add(this.comboBoxAkcjeKoordynator);
            this.tabPageAkcje.Controls.Add(this.buttonAkcje);
            this.tabPageAkcje.Controls.Add(this.buttonAkcje_Usun_Edycje);
            this.tabPageAkcje.Controls.Add(this.radioButtonAkcja_nowa);
            this.tabPageAkcje.Controls.Add(this.radioButtonAkcja_obecna);
            this.tabPageAkcje.Controls.Add(this.label8);
            this.tabPageAkcje.Controls.Add(this.textBoxAkcjeOd);
            this.tabPageAkcje.Controls.Add(this.label11);
            this.tabPageAkcje.Controls.Add(this.label13);
            this.tabPageAkcje.Controls.Add(this.textBoxNazwaAkcji);
            this.tabPageAkcje.Controls.Add(this.label14);
            this.tabPageAkcje.Controls.Add(this.buttonAkcje_Anuluj);
            this.tabPageAkcje.Controls.Add(this.buttonAkcje_Zapisz);
            this.tabPageAkcje.Controls.Add(this.dataGridViewAkcje);
            this.tabPageAkcje.Controls.Add(this.label3);
            this.tabPageAkcje.Controls.Add(this.buttonAkcje_Usun_Akcje);
            this.tabPageAkcje.Controls.Add(this.dataGridViewAkcjeHistoria);
            this.tabPageAkcje.Location = new System.Drawing.Point(4, 25);
            this.tabPageAkcje.Name = "tabPageAkcje";
            this.tabPageAkcje.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAkcje.Size = new System.Drawing.Size(1455, 755);
            this.tabPageAkcje.TabIndex = 1;
            this.tabPageAkcje.Text = "Akcje";
            this.tabPageAkcje.UseVisualStyleBackColor = true;
            this.tabPageAkcje.Enter += new System.EventHandler(this.tabPageAkcje_Enter);
            // 
            // buttonAkcjaNazwa
            // 
            this.buttonAkcjaNazwa.Location = new System.Drawing.Point(142, 612);
            this.buttonAkcjaNazwa.Name = "buttonAkcjaNazwa";
            this.buttonAkcjaNazwa.Size = new System.Drawing.Size(96, 53);
            this.buttonAkcjaNazwa.TabIndex = 53;
            this.buttonAkcjaNazwa.Text = "Edytuj nazwę akcji";
            this.buttonAkcjaNazwa.UseVisualStyleBackColor = true;
            this.buttonAkcjaNazwa.Click += new System.EventHandler(this.buttonAkcjaNazwa_Click);
            // 
            // buttonAkcjaDodaj
            // 
            this.buttonAkcjaDodaj.Location = new System.Drawing.Point(25, 612);
            this.buttonAkcjaDodaj.Name = "buttonAkcjaDodaj";
            this.buttonAkcjaDodaj.Size = new System.Drawing.Size(96, 53);
            this.buttonAkcjaDodaj.TabIndex = 52;
            this.buttonAkcjaDodaj.Text = "Nowa Akcja";
            this.buttonAkcjaDodaj.UseVisualStyleBackColor = true;
            this.buttonAkcjaDodaj.Click += new System.EventHandler(this.buttonAkcjaDodaj_Click);
            // 
            // textBoxAkcjaNowa
            // 
            this.textBoxAkcjaNowa.Location = new System.Drawing.Point(90, 574);
            this.textBoxAkcjaNowa.MaxLength = 30;
            this.textBoxAkcjaNowa.Name = "textBoxAkcjaNowa";
            this.textBoxAkcjaNowa.Size = new System.Drawing.Size(148, 22);
            this.textBoxAkcjaNowa.TabIndex = 51;
            this.textBoxAkcjaNowa.Leave += new System.EventHandler(this.textBoxNull_Leave);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(22, 574);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 17);
            this.label12.TabIndex = 50;
            this.label12.Text = "Nazwa:";
            // 
            // comboBoxAkcjeKoordynator
            // 
            this.comboBoxAkcjeKoordynator.DataSource = this.kOORDYNATORZYBindingSource;
            this.comboBoxAkcjeKoordynator.DisplayMember = "FUNKCJA";
            this.comboBoxAkcjeKoordynator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAkcjeKoordynator.FormattingEnabled = true;
            this.comboBoxAkcjeKoordynator.Location = new System.Drawing.Point(504, 473);
            this.comboBoxAkcjeKoordynator.Name = "comboBoxAkcjeKoordynator";
            this.comboBoxAkcjeKoordynator.Size = new System.Drawing.Size(121, 24);
            this.comboBoxAkcjeKoordynator.TabIndex = 49;
            this.comboBoxAkcjeKoordynator.ValueMember = "FUNKCJA";
            // 
            // kOORDYNATORZYBindingSource
            // 
            this.kOORDYNATORZYBindingSource.DataMember = "KOORDYNATORZY";
            this.kOORDYNATORZYBindingSource.DataSource = this.dataSet1;
            // 
            // buttonAkcje
            // 
            this.buttonAkcje.Image = ((System.Drawing.Image)(resources.GetObject("buttonAkcje.Image")));
            this.buttonAkcje.Location = new System.Drawing.Point(582, 517);
            this.buttonAkcje.Name = "buttonAkcje";
            this.buttonAkcje.Size = new System.Drawing.Size(35, 35);
            this.buttonAkcje.TabIndex = 48;
            this.buttonAkcje.UseVisualStyleBackColor = true;
            this.buttonAkcje.Click += new System.EventHandler(this.buttonDate_Click);
            // 
            // buttonAkcje_Usun_Edycje
            // 
            this.buttonAkcje_Usun_Edycje.Location = new System.Drawing.Point(628, 612);
            this.buttonAkcje_Usun_Edycje.Name = "buttonAkcje_Usun_Edycje";
            this.buttonAkcje_Usun_Edycje.Size = new System.Drawing.Size(114, 53);
            this.buttonAkcje_Usun_Edycje.TabIndex = 47;
            this.buttonAkcje_Usun_Edycje.Text = "Usuń obecną edycję";
            this.buttonAkcje_Usun_Edycje.UseVisualStyleBackColor = true;
            this.buttonAkcje_Usun_Edycje.Click += new System.EventHandler(this.buttonAkcje_Usun_Edycje_Click);
            // 
            // radioButtonAkcja_nowa
            // 
            this.radioButtonAkcja_nowa.AutoSize = true;
            this.radioButtonAkcja_nowa.Location = new System.Drawing.Point(414, 564);
            this.radioButtonAkcja_nowa.Name = "radioButtonAkcja_nowa";
            this.radioButtonAkcja_nowa.Size = new System.Drawing.Size(109, 21);
            this.radioButtonAkcja_nowa.TabIndex = 46;
            this.radioButtonAkcja_nowa.Text = "Nowa edycja";
            this.radioButtonAkcja_nowa.UseVisualStyleBackColor = true;
            // 
            // radioButtonAkcja_obecna
            // 
            this.radioButtonAkcja_obecna.AutoSize = true;
            this.radioButtonAkcja_obecna.Checked = true;
            this.radioButtonAkcja_obecna.Location = new System.Drawing.Point(563, 564);
            this.radioButtonAkcja_obecna.Name = "radioButtonAkcja_obecna";
            this.radioButtonAkcja_obecna.Size = new System.Drawing.Size(119, 21);
            this.radioButtonAkcja_obecna.TabIndex = 45;
            this.radioButtonAkcja_obecna.TabStop = true;
            this.radioButtonAkcja_obecna.Text = "Edytuj obecną";
            this.radioButtonAkcja_obecna.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(408, 387);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 17);
            this.label8.TabIndex = 44;
            this.label8.Text = "Edycja akcji";
            // 
            // textBoxAkcjeOd
            // 
            this.textBoxAkcjeOd.Location = new System.Drawing.Point(476, 526);
            this.textBoxAkcjeOd.Name = "textBoxAkcjeOd";
            this.textBoxAkcjeOd.Size = new System.Drawing.Size(100, 22);
            this.textBoxAkcjeOd.TabIndex = 43;
            this.textBoxAkcjeOd.Leave += new System.EventHandler(this.textBoxDate_Leave);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(408, 526);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 17);
            this.label11.TabIndex = 42;
            this.label11.Text = "Od:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(408, 480);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(90, 17);
            this.label13.TabIndex = 38;
            this.label13.Text = "Koordynator:";
            // 
            // textBoxNazwaAkcji
            // 
            this.textBoxNazwaAkcji.Location = new System.Drawing.Point(476, 434);
            this.textBoxNazwaAkcji.MaxLength = 30;
            this.textBoxNazwaAkcji.Name = "textBoxNazwaAkcji";
            this.textBoxNazwaAkcji.ReadOnly = true;
            this.textBoxNazwaAkcji.Size = new System.Drawing.Size(100, 22);
            this.textBoxNazwaAkcji.TabIndex = 37;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(408, 434);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(54, 17);
            this.label14.TabIndex = 36;
            this.label14.Text = "Nazwa:";
            // 
            // buttonAkcje_Anuluj
            // 
            this.buttonAkcje_Anuluj.Location = new System.Drawing.Point(498, 612);
            this.buttonAkcje_Anuluj.Name = "buttonAkcje_Anuluj";
            this.buttonAkcje_Anuluj.Size = new System.Drawing.Size(104, 53);
            this.buttonAkcje_Anuluj.TabIndex = 35;
            this.buttonAkcje_Anuluj.Text = "Anuluj";
            this.buttonAkcje_Anuluj.UseVisualStyleBackColor = true;
            this.buttonAkcje_Anuluj.Click += new System.EventHandler(this.buttonAkcje_Anuluj_Click);
            // 
            // buttonAkcje_Zapisz
            // 
            this.buttonAkcje_Zapisz.Location = new System.Drawing.Point(369, 612);
            this.buttonAkcje_Zapisz.Name = "buttonAkcje_Zapisz";
            this.buttonAkcje_Zapisz.Size = new System.Drawing.Size(96, 53);
            this.buttonAkcje_Zapisz.TabIndex = 34;
            this.buttonAkcje_Zapisz.Text = "Zapisz zmiany";
            this.buttonAkcje_Zapisz.UseVisualStyleBackColor = true;
            this.buttonAkcje_Zapisz.Click += new System.EventHandler(this.buttonAkcje_Zapisz_Click);
            // 
            // dataGridViewAkcje
            // 
            this.dataGridViewAkcje.AllowUserToAddRows = false;
            this.dataGridViewAkcje.AllowUserToDeleteRows = false;
            this.dataGridViewAkcje.AutoGenerateColumns = false;
            this.dataGridViewAkcje.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAkcje.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AKCJANAZWA});
            this.dataGridViewAkcje.DataSource = this.aKCJEBindingSource;
            this.dataGridViewAkcje.Location = new System.Drawing.Point(23, 45);
            this.dataGridViewAkcje.MultiSelect = false;
            this.dataGridViewAkcje.Name = "dataGridViewAkcje";
            this.dataGridViewAkcje.ReadOnly = true;
            this.dataGridViewAkcje.RowHeadersVisible = false;
            this.dataGridViewAkcje.RowTemplate.Height = 24;
            this.dataGridViewAkcje.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAkcje.Size = new System.Drawing.Size(215, 510);
            this.dataGridViewAkcje.TabIndex = 23;
            this.dataGridViewAkcje.SelectionChanged += new System.EventHandler(this.dataGridViewAkcje_SelectionChanged);
            // 
            // AKCJANAZWA
            // 
            this.AKCJANAZWA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AKCJANAZWA.DataPropertyName = "NAZWA";
            this.AKCJANAZWA.HeaderText = "NAZWA";
            this.AKCJANAZWA.Name = "AKCJANAZWA";
            this.AKCJANAZWA.ReadOnly = true;
            // 
            // aKCJEBindingSource
            // 
            this.aKCJEBindingSource.DataMember = "AKCJE";
            this.aKCJEBindingSource.DataSource = this.dataSet1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(260, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 22;
            this.label3.Text = "Edycje";
            // 
            // buttonAkcje_Usun_Akcje
            // 
            this.buttonAkcje_Usun_Akcje.Location = new System.Drawing.Point(90, 685);
            this.buttonAkcje_Usun_Akcje.Name = "buttonAkcje_Usun_Akcje";
            this.buttonAkcje_Usun_Akcje.Size = new System.Drawing.Size(99, 53);
            this.buttonAkcje_Usun_Akcje.TabIndex = 20;
            this.buttonAkcje_Usun_Akcje.Text = "Usuń akcję";
            this.buttonAkcje_Usun_Akcje.UseVisualStyleBackColor = true;
            this.buttonAkcje_Usun_Akcje.Click += new System.EventHandler(this.buttonAkcje_Usun_Akcje_Click);
            // 
            // dataGridViewAkcjeHistoria
            // 
            this.dataGridViewAkcjeHistoria.AllowUserToAddRows = false;
            this.dataGridViewAkcjeHistoria.AllowUserToDeleteRows = false;
            this.dataGridViewAkcjeHistoria.AutoGenerateColumns = false;
            this.dataGridViewAkcjeHistoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAkcjeHistoria.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AKCJA,
            this.AKCJA_KOORDYNATOR,
            this.AKCJA_OD,
            this.AKCJA_DO,
            this.IDAKCJA});
            this.dataGridViewAkcjeHistoria.DataSource = this.aKCJEFKBindingSource;
            this.dataGridViewAkcjeHistoria.Location = new System.Drawing.Point(263, 45);
            this.dataGridViewAkcjeHistoria.MultiSelect = false;
            this.dataGridViewAkcjeHistoria.Name = "dataGridViewAkcjeHistoria";
            this.dataGridViewAkcjeHistoria.ReadOnly = true;
            this.dataGridViewAkcjeHistoria.RowHeadersVisible = false;
            this.dataGridViewAkcjeHistoria.RowTemplate.Height = 24;
            this.dataGridViewAkcjeHistoria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAkcjeHistoria.Size = new System.Drawing.Size(546, 300);
            this.dataGridViewAkcjeHistoria.TabIndex = 19;
            // 
            // AKCJA
            // 
            this.AKCJA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AKCJA.DataPropertyName = "AKCJA";
            this.AKCJA.HeaderText = "AKCJA";
            this.AKCJA.Name = "AKCJA";
            this.AKCJA.ReadOnly = true;
            // 
            // AKCJA_KOORDYNATOR
            // 
            this.AKCJA_KOORDYNATOR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AKCJA_KOORDYNATOR.DataPropertyName = "KOORDYNATOR";
            this.AKCJA_KOORDYNATOR.HeaderText = "KOORDYNATOR";
            this.AKCJA_KOORDYNATOR.Name = "AKCJA_KOORDYNATOR";
            this.AKCJA_KOORDYNATOR.ReadOnly = true;
            // 
            // AKCJA_OD
            // 
            this.AKCJA_OD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AKCJA_OD.DataPropertyName = "OD";
            this.AKCJA_OD.HeaderText = "OD";
            this.AKCJA_OD.Name = "AKCJA_OD";
            this.AKCJA_OD.ReadOnly = true;
            // 
            // AKCJA_DO
            // 
            this.AKCJA_DO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AKCJA_DO.DataPropertyName = "DO";
            this.AKCJA_DO.HeaderText = "DO";
            this.AKCJA_DO.Name = "AKCJA_DO";
            this.AKCJA_DO.ReadOnly = true;
            // 
            // IDAKCJA
            // 
            this.IDAKCJA.DataPropertyName = "ID";
            this.IDAKCJA.HeaderText = "ID";
            this.IDAKCJA.Name = "IDAKCJA";
            this.IDAKCJA.ReadOnly = true;
            this.IDAKCJA.Visible = false;
            // 
            // aKCJEFKBindingSource
            // 
            this.aKCJEFKBindingSource.DataMember = "AKCJE_FK";
            this.aKCJEFKBindingSource.DataSource = this.aKCJEBindingSource;
            this.aKCJEFKBindingSource.Sort = "OD";
            // 
            // tabPageKoordynatorzy
            // 
            this.tabPageKoordynatorzy.Controls.Add(this.buttonkoord_od);
            this.tabPageKoordynatorzy.Controls.Add(this.buttonUsun_koord);
            this.tabPageKoordynatorzy.Controls.Add(this.radioButtonkoord_nowy);
            this.tabPageKoordynatorzy.Controls.Add(this.radioButtonkoord_obecny);
            this.tabPageKoordynatorzy.Controls.Add(this.label10);
            this.tabPageKoordynatorzy.Controls.Add(this.textBoxkoordod);
            this.tabPageKoordynatorzy.Controls.Add(this.label9);
            this.tabPageKoordynatorzy.Controls.Add(this.textBoxNazwisko);
            this.tabPageKoordynatorzy.Controls.Add(this.label7);
            this.tabPageKoordynatorzy.Controls.Add(this.textBoxImie);
            this.tabPageKoordynatorzy.Controls.Add(this.label6);
            this.tabPageKoordynatorzy.Controls.Add(this.textBoxFunkcja);
            this.tabPageKoordynatorzy.Controls.Add(this.label5);
            this.tabPageKoordynatorzy.Controls.Add(this.label4);
            this.tabPageKoordynatorzy.Controls.Add(this.buttonkoordanuluj);
            this.tabPageKoordynatorzy.Controls.Add(this.buttonkoordzapisz);
            this.tabPageKoordynatorzy.Controls.Add(this.dataGridViewKoordHist);
            this.tabPageKoordynatorzy.Controls.Add(this.dataGridViewKoord);
            this.tabPageKoordynatorzy.Location = new System.Drawing.Point(4, 25);
            this.tabPageKoordynatorzy.Name = "tabPageKoordynatorzy";
            this.tabPageKoordynatorzy.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageKoordynatorzy.Size = new System.Drawing.Size(1455, 755);
            this.tabPageKoordynatorzy.TabIndex = 2;
            this.tabPageKoordynatorzy.Text = "Koordynatorzy";
            this.tabPageKoordynatorzy.UseVisualStyleBackColor = true;
            this.tabPageKoordynatorzy.Enter += new System.EventHandler(this.tabPageKoordynatorzy_Enter);
            // 
            // buttonkoord_od
            // 
            this.buttonkoord_od.Image = ((System.Drawing.Image)(resources.GetObject("buttonkoord_od.Image")));
            this.buttonkoord_od.Location = new System.Drawing.Point(938, 404);
            this.buttonkoord_od.Name = "buttonkoord_od";
            this.buttonkoord_od.Size = new System.Drawing.Size(35, 35);
            this.buttonkoord_od.TabIndex = 33;
            this.buttonkoord_od.UseVisualStyleBackColor = true;
            this.buttonkoord_od.Click += new System.EventHandler(this.buttonDate_Click);
            // 
            // buttonUsun_koord
            // 
            this.buttonUsun_koord.Location = new System.Drawing.Point(1023, 487);
            this.buttonUsun_koord.Name = "buttonUsun_koord";
            this.buttonUsun_koord.Size = new System.Drawing.Size(127, 53);
            this.buttonUsun_koord.TabIndex = 32;
            this.buttonUsun_koord.Text = "Usuń obecnego koordynatora";
            this.buttonUsun_koord.UseVisualStyleBackColor = true;
            this.buttonUsun_koord.Click += new System.EventHandler(this.buttonUsun_koord_Click);
            // 
            // radioButtonkoord_nowy
            // 
            this.radioButtonkoord_nowy.AutoSize = true;
            this.radioButtonkoord_nowy.Location = new System.Drawing.Point(770, 451);
            this.radioButtonkoord_nowy.Name = "radioButtonkoord_nowy";
            this.radioButtonkoord_nowy.Size = new System.Drawing.Size(143, 21);
            this.radioButtonkoord_nowy.TabIndex = 31;
            this.radioButtonkoord_nowy.Text = "Nowy koordynator";
            this.radioButtonkoord_nowy.UseVisualStyleBackColor = true;
            // 
            // radioButtonkoord_obecny
            // 
            this.radioButtonkoord_obecny.AutoSize = true;
            this.radioButtonkoord_obecny.Checked = true;
            this.radioButtonkoord_obecny.Location = new System.Drawing.Point(919, 451);
            this.radioButtonkoord_obecny.Name = "radioButtonkoord_obecny";
            this.radioButtonkoord_obecny.Size = new System.Drawing.Size(135, 21);
            this.radioButtonkoord_obecny.TabIndex = 30;
            this.radioButtonkoord_obecny.TabStop = true;
            this.radioButtonkoord_obecny.Text = "Edytuj obecnego";
            this.radioButtonkoord_obecny.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(764, 274);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(138, 17);
            this.label10.TabIndex = 29;
            this.label10.Text = "Edycja koordynatora";
            // 
            // textBoxkoordod
            // 
            this.textBoxkoordod.Location = new System.Drawing.Point(832, 413);
            this.textBoxkoordod.Name = "textBoxkoordod";
            this.textBoxkoordod.Size = new System.Drawing.Size(100, 22);
            this.textBoxkoordod.TabIndex = 26;
            this.textBoxkoordod.Leave += new System.EventHandler(this.textBoxDate_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(764, 413);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 17);
            this.label9.TabIndex = 25;
            this.label9.Text = "Od:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBoxNazwisko
            // 
            this.textBoxNazwisko.Location = new System.Drawing.Point(1049, 364);
            this.textBoxNazwisko.MaxLength = 50;
            this.textBoxNazwisko.Name = "textBoxNazwisko";
            this.textBoxNazwisko.Size = new System.Drawing.Size(194, 22);
            this.textBoxNazwisko.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(972, 367);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 17);
            this.label7.TabIndex = 23;
            this.label7.Text = "Nazwisko:";
            // 
            // textBoxImie
            // 
            this.textBoxImie.Location = new System.Drawing.Point(832, 367);
            this.textBoxImie.MaxLength = 20;
            this.textBoxImie.Name = "textBoxImie";
            this.textBoxImie.Size = new System.Drawing.Size(134, 22);
            this.textBoxImie.TabIndex = 22;
            this.textBoxImie.Leave += new System.EventHandler(this.textBoxNull_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(764, 367);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 17);
            this.label6.TabIndex = 21;
            this.label6.Text = "Imię:";
            // 
            // textBoxFunkcja
            // 
            this.textBoxFunkcja.Location = new System.Drawing.Point(832, 321);
            this.textBoxFunkcja.Name = "textBoxFunkcja";
            this.textBoxFunkcja.ReadOnly = true;
            this.textBoxFunkcja.Size = new System.Drawing.Size(100, 22);
            this.textBoxFunkcja.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(764, 321);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "Funkcja:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Historia funkcji";
            // 
            // buttonkoordanuluj
            // 
            this.buttonkoordanuluj.Location = new System.Drawing.Point(887, 487);
            this.buttonkoordanuluj.Name = "buttonkoordanuluj";
            this.buttonkoordanuluj.Size = new System.Drawing.Size(96, 53);
            this.buttonkoordanuluj.TabIndex = 17;
            this.buttonkoordanuluj.Text = "Anuluj";
            this.buttonkoordanuluj.UseVisualStyleBackColor = true;
            this.buttonkoordanuluj.Click += new System.EventHandler(this.buttonkoordanuluj_Click);
            // 
            // buttonkoordzapisz
            // 
            this.buttonkoordzapisz.Location = new System.Drawing.Point(768, 487);
            this.buttonkoordzapisz.Name = "buttonkoordzapisz";
            this.buttonkoordzapisz.Size = new System.Drawing.Size(96, 53);
            this.buttonkoordzapisz.TabIndex = 16;
            this.buttonkoordzapisz.Text = "Zapisz zmiany";
            this.buttonkoordzapisz.UseVisualStyleBackColor = true;
            this.buttonkoordzapisz.Click += new System.EventHandler(this.buttonkoordzapisz_Click);
            // 
            // dataGridViewKoordHist
            // 
            this.dataGridViewKoordHist.AllowUserToAddRows = false;
            this.dataGridViewKoordHist.AllowUserToDeleteRows = false;
            this.dataGridViewKoordHist.AutoGenerateColumns = false;
            this.dataGridViewKoordHist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKoordHist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.KOORD_OD,
            this.KOORD_DO});
            this.dataGridViewKoordHist.DataSource = this.kOORDHISTOKOORDFKBindingSource;
            this.dataGridViewKoordHist.Location = new System.Drawing.Point(23, 232);
            this.dataGridViewKoordHist.MultiSelect = false;
            this.dataGridViewKoordHist.Name = "dataGridViewKoordHist";
            this.dataGridViewKoordHist.ReadOnly = true;
            this.dataGridViewKoordHist.RowHeadersVisible = false;
            this.dataGridViewKoordHist.RowTemplate.Height = 24;
            this.dataGridViewKoordHist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewKoordHist.Size = new System.Drawing.Size(671, 300);
            this.dataGridViewKoordHist.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "FUNKCJA";
            this.dataGridViewTextBoxColumn10.HeaderText = "FUNKCJA";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "IMIĘ";
            this.dataGridViewTextBoxColumn6.HeaderText = "IMIĘ";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "NAZWISKO";
            this.dataGridViewTextBoxColumn7.HeaderText = "NAZWISKO";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // KOORD_OD
            // 
            this.KOORD_OD.DataPropertyName = "OD";
            this.KOORD_OD.HeaderText = "OD";
            this.KOORD_OD.Name = "KOORD_OD";
            this.KOORD_OD.ReadOnly = true;
            // 
            // KOORD_DO
            // 
            this.KOORD_DO.DataPropertyName = "DO";
            this.KOORD_DO.HeaderText = "DO";
            this.KOORD_DO.Name = "KOORD_DO";
            this.KOORD_DO.ReadOnly = true;
            // 
            // kOORDHISTOKOORDFKBindingSource
            // 
            this.kOORDHISTOKOORDFKBindingSource.DataMember = "KOORD_HISTO_KOORD_FK";
            this.kOORDHISTOKOORDFKBindingSource.DataSource = this.kOORDYNATORZYBindingSource;
            this.kOORDHISTOKOORDFKBindingSource.Sort = "OD";
            // 
            // dataGridViewKoord
            // 
            this.dataGridViewKoord.AllowUserToAddRows = false;
            this.dataGridViewKoord.AllowUserToDeleteRows = false;
            this.dataGridViewKoord.AutoGenerateColumns = false;
            this.dataGridViewKoord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKoord.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FUNKCJA,
            this.IMIE,
            this.NAZWISKO});
            this.dataGridViewKoord.DataSource = this.kOORDYNATORZYBindingSource;
            this.dataGridViewKoord.Location = new System.Drawing.Point(23, 44);
            this.dataGridViewKoord.MultiSelect = false;
            this.dataGridViewKoord.Name = "dataGridViewKoord";
            this.dataGridViewKoord.ReadOnly = true;
            this.dataGridViewKoord.RowHeadersVisible = false;
            this.dataGridViewKoord.RowTemplate.Height = 24;
            this.dataGridViewKoord.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewKoord.Size = new System.Drawing.Size(404, 147);
            this.dataGridViewKoord.TabIndex = 0;
            this.dataGridViewKoord.SelectionChanged += new System.EventHandler(this.dataGridViewKoord_SelectionChanged);
            // 
            // FUNKCJA
            // 
            this.FUNKCJA.DataPropertyName = "FUNKCJA";
            this.FUNKCJA.HeaderText = "FUNKCJA";
            this.FUNKCJA.Name = "FUNKCJA";
            this.FUNKCJA.ReadOnly = true;
            // 
            // IMIE
            // 
            this.IMIE.DataPropertyName = "IMIĘ";
            this.IMIE.HeaderText = "IMIĘ";
            this.IMIE.Name = "IMIE";
            this.IMIE.ReadOnly = true;
            // 
            // NAZWISKO
            // 
            this.NAZWISKO.DataPropertyName = "NAZWISKO";
            this.NAZWISKO.HeaderText = "NAZWISKO";
            this.NAZWISKO.Name = "NAZWISKO";
            this.NAZWISKO.ReadOnly = true;
            // 
            // tabPageKonta
            // 
            this.tabPageKonta.Controls.Add(this.dataGridViewKonta);
            this.tabPageKonta.Controls.Add(this.buttonKontaUsun);
            this.tabPageKonta.Controls.Add(this.buttonKontaAnuluj);
            this.tabPageKonta.Controls.Add(this.buttonKontaZapisz);
            this.tabPageKonta.Location = new System.Drawing.Point(4, 25);
            this.tabPageKonta.Name = "tabPageKonta";
            this.tabPageKonta.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageKonta.Size = new System.Drawing.Size(1455, 755);
            this.tabPageKonta.TabIndex = 3;
            this.tabPageKonta.Text = "Konta";
            this.tabPageKonta.UseVisualStyleBackColor = true;
            this.tabPageKonta.Enter += new System.EventHandler(this.tabPageKonta_Enter);
            // 
            // dataGridViewKonta
            // 
            this.dataGridViewKonta.AllowUserToResizeColumns = false;
            this.dataGridViewKonta.AutoGenerateColumns = false;
            this.dataGridViewKonta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewKonta.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewKonta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKonta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NAZWA_KONTA,
            this.AKTYWNE,
            this.STAN});
            this.dataGridViewKonta.DataSource = this.kONTABindingSource1;
            this.dataGridViewKonta.Location = new System.Drawing.Point(37, 43);
            this.dataGridViewKonta.MultiSelect = false;
            this.dataGridViewKonta.Name = "dataGridViewKonta";
            this.dataGridViewKonta.RowHeadersVisible = false;
            this.dataGridViewKonta.RowTemplate.Height = 24;
            this.dataGridViewKonta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewKonta.Size = new System.Drawing.Size(404, 478);
            this.dataGridViewKonta.TabIndex = 18;
            this.dataGridViewKonta.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridViewKonta_CellBeginEdit);
            this.dataGridViewKonta.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridViewKonta_DataError);
            this.dataGridViewKonta.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridViewKonta_UserAddedRow);
            // 
            // NAZWA_KONTA
            // 
            this.NAZWA_KONTA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NAZWA_KONTA.DataPropertyName = "NAZWA";
            this.NAZWA_KONTA.HeaderText = "NAZWA";
            this.NAZWA_KONTA.MaxInputLength = 30;
            this.NAZWA_KONTA.Name = "NAZWA_KONTA";
            this.NAZWA_KONTA.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // AKTYWNE
            // 
            this.AKTYWNE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.AKTYWNE.DataPropertyName = "AKTYWNY";
            this.AKTYWNE.FalseValue = "N";
            this.AKTYWNE.HeaderText = "AKTYWNE";
            this.AKTYWNE.Name = "AKTYWNE";
            this.AKTYWNE.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.AKTYWNE.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.AKTYWNE.TrueValue = "Y";
            this.AKTYWNE.Width = 101;
            // 
            // STAN
            // 
            this.STAN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = "0,00";
            this.STAN.DefaultCellStyle = dataGridViewCellStyle5;
            this.STAN.HeaderText = "STAN KONTA";
            this.STAN.Name = "STAN";
            this.STAN.ReadOnly = true;
            this.STAN.Width = 112;
            // 
            // buttonKontaUsun
            // 
            this.buttonKontaUsun.Location = new System.Drawing.Point(348, 546);
            this.buttonKontaUsun.Name = "buttonKontaUsun";
            this.buttonKontaUsun.Size = new System.Drawing.Size(93, 45);
            this.buttonKontaUsun.TabIndex = 16;
            this.buttonKontaUsun.Text = "Usuń konto";
            this.buttonKontaUsun.UseVisualStyleBackColor = true;
            this.buttonKontaUsun.Click += new System.EventHandler(this.buttonKontaUsun_Click);
            // 
            // buttonKontaAnuluj
            // 
            this.buttonKontaAnuluj.Location = new System.Drawing.Point(160, 546);
            this.buttonKontaAnuluj.Name = "buttonKontaAnuluj";
            this.buttonKontaAnuluj.Size = new System.Drawing.Size(96, 45);
            this.buttonKontaAnuluj.TabIndex = 15;
            this.buttonKontaAnuluj.Text = "Anuluj";
            this.buttonKontaAnuluj.UseVisualStyleBackColor = true;
            this.buttonKontaAnuluj.Click += new System.EventHandler(this.buttonKontaAnuluj_Click);
            // 
            // buttonKontaZapisz
            // 
            this.buttonKontaZapisz.Location = new System.Drawing.Point(37, 546);
            this.buttonKontaZapisz.Name = "buttonKontaZapisz";
            this.buttonKontaZapisz.Size = new System.Drawing.Size(96, 45);
            this.buttonKontaZapisz.TabIndex = 14;
            this.buttonKontaZapisz.Text = "Zapisz zmiany";
            this.buttonKontaZapisz.UseVisualStyleBackColor = true;
            this.buttonKontaZapisz.Click += new System.EventHandler(this.buttonKontaZapisz_Click);
            // 
            // kONTABindingSource
            // 
            this.kONTABindingSource.DataMember = "KONTA";
            this.kONTABindingSource.DataSource = this.dataSet1;
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kONTATableAdapter
            // 
            this.kONTATableAdapter.ClearBeforeFill = true;
            // 
            // kOORDYNATORZYTableAdapter
            // 
            this.kOORDYNATORZYTableAdapter.ClearBeforeFill = true;
            // 
            // kOORDYNATORZY_HISTORIATableAdapter
            // 
            this.kOORDYNATORZY_HISTORIATableAdapter.ClearBeforeFill = true;
            // 
            // aKCJETableAdapter
            // 
            this.aKCJETableAdapter.ClearBeforeFill = true;
            // 
            // aKCJE_HISTORIATableAdapter
            // 
            this.aKCJE_HISTORIATableAdapter.ClearBeforeFill = true;
            // 
            // pRZYCHODY_I_ROZCHODYTableAdapter
            // 
            this.pRZYCHODY_I_ROZCHODYTableAdapter.ClearBeforeFill = true;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            this.ID.Width = 27;
            // 
            // KONTRAHENT
            // 
            this.KONTRAHENT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.KONTRAHENT.DataPropertyName = "KONTRAHENT";
            this.KONTRAHENT.HeaderText = "KONTRAHENT";
            this.KONTRAHENT.MaxInputLength = 50;
            this.KONTRAHENT.Name = "KONTRAHENT";
            this.KONTRAHENT.Width = 129;
            // 
            // TYTUŁ_OPERACJI
            // 
            this.TYTUŁ_OPERACJI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TYTUŁ_OPERACJI.DataPropertyName = "TYTUŁ_OPERACJI";
            this.TYTUŁ_OPERACJI.HeaderText = "TYTUŁ OPERACJI";
            this.TYTUŁ_OPERACJI.MaxInputLength = 100;
            this.TYTUŁ_OPERACJI.Name = "TYTUŁ_OPERACJI";
            // 
            // NR_DOKUMENTU
            // 
            this.NR_DOKUMENTU.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.NR_DOKUMENTU.DataPropertyName = "NR_DOKUMENTU";
            this.NR_DOKUMENTU.HeaderText = "NR DOKUMENTU";
            this.NR_DOKUMENTU.MaxInputLength = 30;
            this.NR_DOKUMENTU.Name = "NR_DOKUMENTU";
            this.NR_DOKUMENTU.Width = 133;
            // 
            // DATA_DOKONANIA
            // 
            this.DATA_DOKONANIA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.DATA_DOKONANIA.DataPropertyName = "DATA_DOKONANIA";
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.DATA_DOKONANIA.DefaultCellStyle = dataGridViewCellStyle1;
            this.DATA_DOKONANIA.HeaderText = "DATA DOKONANIA";
            this.DATA_DOKONANIA.Name = "DATA_DOKONANIA";
            this.DATA_DOKONANIA.Width = 142;
            // 
            // PRZYCHOD
            // 
            this.PRZYCHOD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.PRZYCHOD.DefaultCellStyle = dataGridViewCellStyle2;
            this.PRZYCHOD.HeaderText = "PRZYCHÓD";
            this.PRZYCHOD.MaxInputLength = 8;
            this.PRZYCHOD.Name = "PRZYCHOD";
            this.PRZYCHOD.Width = 110;
            // 
            // ROZCHOD
            // 
            this.ROZCHOD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.ROZCHOD.DefaultCellStyle = dataGridViewCellStyle3;
            this.ROZCHOD.HeaderText = "ROZCHÓD";
            this.ROZCHOD.MaxInputLength = 8;
            this.ROZCHOD.Name = "ROZCHOD";
            this.ROZCHOD.Width = 103;
            // 
            // KWOTA
            // 
            this.KWOTA.DataPropertyName = "KWOTA";
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            this.KWOTA.DefaultCellStyle = dataGridViewCellStyle4;
            this.KWOTA.HeaderText = "KWOTA";
            this.KWOTA.MaxInputLength = 8;
            this.KWOTA.Name = "KWOTA";
            this.KWOTA.Visible = false;
            this.KWOTA.Width = 84;
            // 
            // RODZAJ
            // 
            this.RODZAJ.DataPropertyName = "RODZAJ";
            this.RODZAJ.HeaderText = "RODZAJ";
            this.RODZAJ.Name = "RODZAJ";
            this.RODZAJ.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.RODZAJ.Visible = false;
            this.RODZAJ.Width = 89;
            // 
            // KONTO
            // 
            this.KONTO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.KONTO.DataPropertyName = "KONTO";
            this.KONTO.DataSource = this.kONTABindingSource1;
            this.KONTO.DisplayMember = "NAZWA";
            this.KONTO.HeaderText = "KONTO";
            this.KONTO.Name = "KONTO";
            this.KONTO.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.KONTO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.KONTO.ValueMember = "NAZWA";
            this.KONTO.Width = 83;
            // 
            // AKCJA_ID
            // 
            this.AKCJA_ID.DataPropertyName = "AKCJA_ID";
            this.AKCJA_ID.HeaderText = "AKCJA_ID";
            this.AKCJA_ID.Name = "AKCJA_ID";
            this.AKCJA_ID.Visible = false;
            this.AKCJA_ID.Width = 97;
            // 
            // PiR_AKCJA
            // 
            this.PiR_AKCJA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PiR_AKCJA.DataSource = this.aKCJEBindingSource;
            this.PiR_AKCJA.DisplayMember = "NAZWA";
            this.PiR_AKCJA.HeaderText = "AKCJA";
            this.PiR_AKCJA.Name = "PiR_AKCJA";
            this.PiR_AKCJA.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.PiR_AKCJA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.PiR_AKCJA.ValueMember = "NAZWA";
            this.PiR_AKCJA.Width = 76;
            // 
            // KOORD_IMIE
            // 
            this.KOORD_IMIE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.KOORD_IMIE.HeaderText = "IMIĘ";
            this.KOORD_IMIE.Name = "KOORD_IMIE";
            this.KOORD_IMIE.ReadOnly = true;
            this.KOORD_IMIE.Width = 59;
            // 
            // KOORD_NAZWISKO
            // 
            this.KOORD_NAZWISKO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.KOORD_NAZWISKO.HeaderText = "NAZWISKO";
            this.KOORD_NAZWISKO.Name = "KOORD_NAZWISKO";
            this.KOORD_NAZWISKO.ReadOnly = true;
            this.KOORD_NAZWISKO.Width = 106;
            // 
            // FormKPiR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1463, 784);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormKPiR";
            this.ShowIcon = false;
            this.Text = "KPiR";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormKPiR_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPagePiR.ResumeLayout(false);
            this.tabPagePiR.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPiRKonta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kONTABindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPiR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRZYCHODYIROZCHODYBindingSource)).EndInit();
            this.tabPageAkcje.ResumeLayout(false);
            this.tabPageAkcje.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kOORDYNATORZYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAkcje)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aKCJEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAkcjeHistoria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aKCJEFKBindingSource)).EndInit();
            this.tabPageKoordynatorzy.ResumeLayout(false);
            this.tabPageKoordynatorzy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKoordHist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kOORDHISTOKOORDFKBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKoord)).EndInit();
            this.tabPageKonta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKonta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kONTABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPagePiR;
        private System.Windows.Forms.TabPage tabPageAkcje;
        private System.Windows.Forms.TabPage tabPageKoordynatorzy;
        private System.Windows.Forms.DataGridView dataGridViewPiR;
        private System.Windows.Forms.RadioButton radioButtonCustom;
        private System.Windows.Forms.RadioButton radioButtonCurMonth;
        private System.Windows.Forms.RadioButton radioButtonAll;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPiRDo;
        private System.Windows.Forms.TextBox textBoxPiROd;
        private System.Windows.Forms.Label dataError;
        private System.Windows.Forms.Button buttonPokaz;
        private System.Windows.Forms.Button buttonFiltry;
        private System.Windows.Forms.Button buttonWyczysc;
        private System.Windows.Forms.Button buttonAnuluj;
        private System.Windows.Forms.Button buttonZapisz;
        private System.Windows.Forms.Button buttonPiRusun;
        private System.Windows.Forms.TabPage tabPageKonta;
        private System.Windows.Forms.Button buttonKontaAnuluj;
        private System.Windows.Forms.Button buttonKontaZapisz;
        private System.Windows.Forms.Button buttonKontaUsun;
        private System.Windows.Forms.DataGridView dataGridViewPiRKonta;
        private System.Windows.Forms.DataGridView dataGridViewKonta;
        private DataSet1 dataSet1;
        private System.Windows.Forms.DataGridView dataGridViewKoord;
        private System.Windows.Forms.DataGridViewTextBoxColumn fUNKCJADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iMIĘDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAZWISKODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridViewKoordHist;
        private System.Windows.Forms.DataGridViewTextBoxColumn iMIĘDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAZWISKODataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn oDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fUNKCJADataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button buttonkoordanuluj;
        private System.Windows.Forms.Button buttonkoordzapisz;
        private System.Windows.Forms.Button buttonAkcje_Usun_Akcje;
        private System.Windows.Forms.DataGridView dataGridViewAkcjeHistoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridViewAkcje;
        private System.Windows.Forms.DataGridViewTextBoxColumn AKCJA_NAZWA;
        private System.Windows.Forms.DataGridViewComboBoxColumn kOORDYNATORZYFUNKCJADataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAZWA;
        private System.Windows.Forms.DataGridViewCheckBoxColumn AKTYWNY;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAZWA_PiR;
        private DataSet1 dataSet11;
        private System.Windows.Forms.BindingSource kONTABindingSource;
        private DataSet1TableAdapters.KONTATableAdapter kONTATableAdapter;
        private System.Windows.Forms.BindingSource kONTABindingSource1;
        private System.Windows.Forms.BindingSource kOORDYNATORZYBindingSource;
        private DataSet1TableAdapters.KOORDYNATORZYTableAdapter kOORDYNATORZYTableAdapter;
        private System.Windows.Forms.BindingSource kOORDHISTOKOORDFKBindingSource;
        private DataSet1TableAdapters.KOORDYNATORZY_HISTORIATableAdapter kOORDYNATORZY_HISTORIATableAdapter;
        private System.Windows.Forms.BindingSource aKCJEBindingSource;
        private DataSet1TableAdapters.AKCJETableAdapter aKCJETableAdapter;
        private System.Windows.Forms.BindingSource aKCJEFKBindingSource;
        private DataSet1TableAdapters.AKCJE_HISTORIATableAdapter aKCJE_HISTORIATableAdapter;
        private System.Windows.Forms.BindingSource pRZYCHODYIROZCHODYBindingSource;
        private DataSet1TableAdapters.PRZYCHODY_I_ROZCHODYTableAdapter pRZYCHODY_I_ROZCHODYTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAZWA_KONTA_PiR;
        private System.Windows.Forms.DataGridViewTextBoxColumn aKTYWNYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn STAN_OTW;
        private System.Windows.Forms.DataGridViewTextBoxColumn STAN_ZAMK;
        private System.Windows.Forms.TextBox textBoxFunkcja;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxkoordod;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxNazwisko;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxImie;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton radioButtonkoord_nowy;
        private System.Windows.Forms.RadioButton radioButtonkoord_obecny;
        private System.Windows.Forms.Button buttonUsun_koord;
        private System.Windows.Forms.DataGridViewTextBoxColumn FUNKCJA;
        private System.Windows.Forms.DataGridViewTextBoxColumn IMIE;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAZWISKO;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn KOORD_OD;
        private System.Windows.Forms.DataGridViewTextBoxColumn KOORD_DO;
        private System.Windows.Forms.Button buttonkoord_od;
        private System.Windows.Forms.Button buttonPiR_do;
        private System.Windows.Forms.Button buttonPiR_od;
        private System.Windows.Forms.Button buttonAkcje;
        private System.Windows.Forms.Button buttonAkcje_Usun_Edycje;
        private System.Windows.Forms.RadioButton radioButtonAkcja_nowa;
        private System.Windows.Forms.RadioButton radioButtonAkcja_obecna;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxAkcjeOd;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxNazwaAkcji;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button buttonAkcje_Anuluj;
        private System.Windows.Forms.Button buttonAkcje_Zapisz;
        private System.Windows.Forms.ComboBox comboBoxAkcjeKoordynator;
        private System.Windows.Forms.DataGridViewTextBoxColumn AKCJANAZWA;
        private System.Windows.Forms.Button buttonAkcjaDodaj;
        private System.Windows.Forms.TextBox textBoxAkcjaNowa;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button buttonAkcjaNazwa;
        private System.Windows.Forms.DataGridViewTextBoxColumn AKCJA;
        private System.Windows.Forms.DataGridViewTextBoxColumn AKCJA_KOORDYNATOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn AKCJA_OD;
        private System.Windows.Forms.DataGridViewTextBoxColumn AKCJA_DO;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDAKCJA;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAZWA_KONTA;
        private System.Windows.Forms.DataGridViewCheckBoxColumn AKTYWNE;
        private System.Windows.Forms.DataGridViewTextBoxColumn STAN;
        private System.Windows.Forms.TextBox textBoxPiRKontrahent;
        private System.Windows.Forms.TextBox textBoxPiROperacja;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn KONTRAHENT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TYTUŁ_OPERACJI;
        private System.Windows.Forms.DataGridViewTextBoxColumn NR_DOKUMENTU;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATA_DOKONANIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRZYCHOD;
        private System.Windows.Forms.DataGridViewTextBoxColumn ROZCHOD;
        private System.Windows.Forms.DataGridViewTextBoxColumn KWOTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn RODZAJ;
        private System.Windows.Forms.DataGridViewComboBoxColumn KONTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn AKCJA_ID;
        private System.Windows.Forms.DataGridViewComboBoxColumn PiR_AKCJA;
        private System.Windows.Forms.DataGridViewTextBoxColumn KOORD_IMIE;
        private System.Windows.Forms.DataGridViewTextBoxColumn KOORD_NAZWISKO;
    }
}

