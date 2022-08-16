
namespace Şantiye_otomasyon_proje
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonbekar = new System.Windows.Forms.RadioButton();
            this.radioButtonevli = new System.Windows.Forms.RadioButton();
            this.buttonsil = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonkydt = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxsehir = new System.Windows.Forms.ComboBox();
            this.maskedTextBoxmaas = new System.Windows.Forms.MaskedTextBox();
            this.textBoxmslk = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxsoyad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textboxid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttontmzle = new System.Windows.Forms.Button();
            this.buttonlist = new System.Windows.Forms.Button();
            this.buttongnclle = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.personelidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personeladDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelsoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelsehirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelmeslekDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelmaasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personeldurumDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tablepersonelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.şantiye_personelDataSet = new Şantiye_otomasyon_proje.Şantiye_personelDataSet();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.table_personelTableAdapter = new Şantiye_otomasyon_proje.Şantiye_personelDataSetTableAdapters.Table_personelTableAdapter();
            this.label8 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.renklerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.varsayılanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeşilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maviToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.araçlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.istatistiklerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grafiklerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hakkındaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hakkındaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.yenileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablepersonelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.şantiye_personelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(this.radioButtonbekar);
            this.groupBox1.Controls.Add(this.radioButtonevli);
            this.groupBox1.Controls.Add(this.buttonsil);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.buttonkydt);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.comboBoxsehir);
            this.groupBox1.Controls.Add(this.maskedTextBoxmaas);
            this.groupBox1.Controls.Add(this.textBoxmslk);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxsoyad);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxad);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textboxid);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(15, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(433, 429);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = ">Personel Kayıt<";
            // 
            // radioButtonbekar
            // 
            this.radioButtonbekar.AutoSize = true;
            this.radioButtonbekar.Location = new System.Drawing.Point(286, 276);
            this.radioButtonbekar.Name = "radioButtonbekar";
            this.radioButtonbekar.Size = new System.Drawing.Size(80, 28);
            this.radioButtonbekar.TabIndex = 14;
            this.radioButtonbekar.TabStop = true;
            this.radioButtonbekar.Text = "Bekar";
            this.radioButtonbekar.UseVisualStyleBackColor = true;
            this.radioButtonbekar.CheckedChanged += new System.EventHandler(this.radioButtonbekar_CheckedChanged);
            // 
            // radioButtonevli
            // 
            this.radioButtonevli.AutoSize = true;
            this.radioButtonevli.Location = new System.Drawing.Point(219, 276);
            this.radioButtonevli.Name = "radioButtonevli";
            this.radioButtonevli.Size = new System.Drawing.Size(61, 28);
            this.radioButtonevli.TabIndex = 13;
            this.radioButtonevli.TabStop = true;
            this.radioButtonevli.Text = "Evli";
            this.radioButtonevli.UseVisualStyleBackColor = true;
            this.radioButtonevli.CheckedChanged += new System.EventHandler(this.radioButtonevli_CheckedChanged);
            // 
            // buttonsil
            // 
            this.buttonsil.BackColor = System.Drawing.Color.Red;
            this.buttonsil.ForeColor = System.Drawing.Color.White;
            this.buttonsil.Location = new System.Drawing.Point(67, 366);
            this.buttonsil.Name = "buttonsil";
            this.buttonsil.Size = new System.Drawing.Size(125, 39);
            this.buttonsil.TabIndex = 2;
            this.buttonsil.Text = "Sil";
            this.buttonsil.UseVisualStyleBackColor = false;
            this.buttonsil.Click += new System.EventHandler(this.buttonsil_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(83, 318);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 24);
            this.label7.TabIndex = 12;
            this.label7.Text = "Maaş:";
            // 
            // buttonkydt
            // 
            this.buttonkydt.BackColor = System.Drawing.Color.Lime;
            this.buttonkydt.ForeColor = System.Drawing.Color.Black;
            this.buttonkydt.Location = new System.Drawing.Point(209, 366);
            this.buttonkydt.Name = "buttonkydt";
            this.buttonkydt.Size = new System.Drawing.Size(125, 39);
            this.buttonkydt.TabIndex = 1;
            this.buttonkydt.Text = "Kaydet";
            this.buttonkydt.UseVisualStyleBackColor = false;
            this.buttonkydt.Click += new System.EventHandler(this.buttonkydt_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(83, 278);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 24);
            this.label6.TabIndex = 11;
            this.label6.Text = "Durum:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(83, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "Şehir:";
            // 
            // comboBoxsehir
            // 
            this.comboBoxsehir.FormattingEnabled = true;
            this.comboBoxsehir.Location = new System.Drawing.Point(219, 227);
            this.comboBoxsehir.Name = "comboBoxsehir";
            this.comboBoxsehir.Size = new System.Drawing.Size(100, 32);
            this.comboBoxsehir.TabIndex = 9;
            // 
            // maskedTextBoxmaas
            // 
            this.maskedTextBoxmaas.Location = new System.Drawing.Point(219, 310);
            this.maskedTextBoxmaas.Mask = "00000";
            this.maskedTextBoxmaas.Name = "maskedTextBoxmaas";
            this.maskedTextBoxmaas.Size = new System.Drawing.Size(100, 32);
            this.maskedTextBoxmaas.TabIndex = 8;
            this.maskedTextBoxmaas.ValidatingType = typeof(int);
            // 
            // textBoxmslk
            // 
            this.textBoxmslk.Location = new System.Drawing.Point(219, 177);
            this.textBoxmslk.Name = "textBoxmslk";
            this.textBoxmslk.Size = new System.Drawing.Size(100, 32);
            this.textBoxmslk.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(83, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Meslek:";
            // 
            // textBoxsoyad
            // 
            this.textBoxsoyad.Location = new System.Drawing.Point(219, 129);
            this.textBoxsoyad.Name = "textBoxsoyad";
            this.textBoxsoyad.Size = new System.Drawing.Size(100, 32);
            this.textBoxsoyad.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Soyad:";
            // 
            // textBoxad
            // 
            this.textBoxad.Location = new System.Drawing.Point(219, 81);
            this.textBoxad.Name = "textBoxad";
            this.textBoxad.Size = new System.Drawing.Size(100, 32);
            this.textBoxad.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ad:";
            // 
            // textboxid
            // 
            this.textboxid.Location = new System.Drawing.Point(219, 40);
            this.textboxid.Name = "textboxid";
            this.textboxid.Size = new System.Drawing.Size(100, 32);
            this.textboxid.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Personel İD:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox2.Controls.Add(this.buttontmzle);
            this.groupBox2.Controls.Add(this.buttonlist);
            this.groupBox2.Controls.Add(this.buttongnclle);
            this.groupBox2.Location = new System.Drawing.Point(592, 241);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(322, 229);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = ">İşlemler<";
            // 
            // buttontmzle
            // 
            this.buttontmzle.Location = new System.Drawing.Point(94, 166);
            this.buttontmzle.Name = "buttontmzle";
            this.buttontmzle.Size = new System.Drawing.Size(125, 39);
            this.buttontmzle.TabIndex = 4;
            this.buttontmzle.Text = "Temizle";
            this.buttontmzle.UseVisualStyleBackColor = true;
            this.buttontmzle.Click += new System.EventHandler(this.buttontmzle_Click);
            // 
            // buttonlist
            // 
            this.buttonlist.Location = new System.Drawing.Point(94, 51);
            this.buttonlist.Name = "buttonlist";
            this.buttonlist.Size = new System.Drawing.Size(125, 39);
            this.buttonlist.TabIndex = 0;
            this.buttonlist.Text = "Yenile";
            this.buttonlist.UseVisualStyleBackColor = true;
            this.buttonlist.Click += new System.EventHandler(this.buttonlist_Click);
            // 
            // buttongnclle
            // 
            this.buttongnclle.Location = new System.Drawing.Point(94, 111);
            this.buttongnclle.Name = "buttongnclle";
            this.buttongnclle.Size = new System.Drawing.Size(125, 39);
            this.buttongnclle.TabIndex = 3;
            this.buttongnclle.Text = "Güncelle";
            this.buttongnclle.UseVisualStyleBackColor = true;
            this.buttongnclle.Click += new System.EventHandler(this.buttongnclle_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(12, 476);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1294, 259);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = ">Personeller<";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.personelidDataGridViewTextBoxColumn,
            this.personeladDataGridViewTextBoxColumn,
            this.personelsoyadDataGridViewTextBoxColumn,
            this.personelsehirDataGridViewTextBoxColumn,
            this.personelmeslekDataGridViewTextBoxColumn,
            this.personelmaasDataGridViewTextBoxColumn,
            this.personeldurumDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.tablepersonelBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1288, 228);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // personelidDataGridViewTextBoxColumn
            // 
            this.personelidDataGridViewTextBoxColumn.DataPropertyName = "Personelid";
            this.personelidDataGridViewTextBoxColumn.HeaderText = "Personelid";
            this.personelidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.personelidDataGridViewTextBoxColumn.Name = "personelidDataGridViewTextBoxColumn";
            this.personelidDataGridViewTextBoxColumn.ReadOnly = true;
            this.personelidDataGridViewTextBoxColumn.Width = 125;
            // 
            // personeladDataGridViewTextBoxColumn
            // 
            this.personeladDataGridViewTextBoxColumn.DataPropertyName = "Personelad";
            this.personeladDataGridViewTextBoxColumn.HeaderText = "Personelad";
            this.personeladDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.personeladDataGridViewTextBoxColumn.Name = "personeladDataGridViewTextBoxColumn";
            this.personeladDataGridViewTextBoxColumn.Width = 125;
            // 
            // personelsoyadDataGridViewTextBoxColumn
            // 
            this.personelsoyadDataGridViewTextBoxColumn.DataPropertyName = "personelsoyad";
            this.personelsoyadDataGridViewTextBoxColumn.HeaderText = "personelsoyad";
            this.personelsoyadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.personelsoyadDataGridViewTextBoxColumn.Name = "personelsoyadDataGridViewTextBoxColumn";
            this.personelsoyadDataGridViewTextBoxColumn.Width = 125;
            // 
            // personelsehirDataGridViewTextBoxColumn
            // 
            this.personelsehirDataGridViewTextBoxColumn.DataPropertyName = "personelsehir";
            this.personelsehirDataGridViewTextBoxColumn.HeaderText = "personelsehir";
            this.personelsehirDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.personelsehirDataGridViewTextBoxColumn.Name = "personelsehirDataGridViewTextBoxColumn";
            this.personelsehirDataGridViewTextBoxColumn.Width = 125;
            // 
            // personelmeslekDataGridViewTextBoxColumn
            // 
            this.personelmeslekDataGridViewTextBoxColumn.DataPropertyName = "personelmeslek";
            this.personelmeslekDataGridViewTextBoxColumn.HeaderText = "personelmeslek";
            this.personelmeslekDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.personelmeslekDataGridViewTextBoxColumn.Name = "personelmeslekDataGridViewTextBoxColumn";
            this.personelmeslekDataGridViewTextBoxColumn.Width = 125;
            // 
            // personelmaasDataGridViewTextBoxColumn
            // 
            this.personelmaasDataGridViewTextBoxColumn.DataPropertyName = "personelmaas";
            this.personelmaasDataGridViewTextBoxColumn.HeaderText = "personelmaas";
            this.personelmaasDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.personelmaasDataGridViewTextBoxColumn.Name = "personelmaasDataGridViewTextBoxColumn";
            this.personelmaasDataGridViewTextBoxColumn.Width = 125;
            // 
            // personeldurumDataGridViewCheckBoxColumn
            // 
            this.personeldurumDataGridViewCheckBoxColumn.DataPropertyName = "personeldurum";
            this.personeldurumDataGridViewCheckBoxColumn.HeaderText = "personeldurum";
            this.personeldurumDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.personeldurumDataGridViewCheckBoxColumn.Name = "personeldurumDataGridViewCheckBoxColumn";
            this.personeldurumDataGridViewCheckBoxColumn.Width = 125;
            // 
            // tablepersonelBindingSource
            // 
            this.tablepersonelBindingSource.DataMember = "Table_personel";
            this.tablepersonelBindingSource.DataSource = this.şantiye_personelDataSet;
            // 
            // şantiye_personelDataSet
            // 
            this.şantiye_personelDataSet.DataSetName = "Şantiye_personelDataSet";
            this.şantiye_personelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(961, 122);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(327, 197);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // table_personelTableAdapter
            // 
            this.table_personelTableAdapter.ClearBeforeFill = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1043, 407);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 24);
            this.label8.TabIndex = 4;
            this.label8.Text = "label8";
            this.label8.Visible = false;
            this.label8.TextChanged += new System.EventHandler(this.label8_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.renklerToolStripMenuItem,
            this.araçlarToolStripMenuItem,
            this.hakkındaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1318, 28);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // renklerToolStripMenuItem
            // 
            this.renklerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.varsayılanToolStripMenuItem,
            this.yeşilToolStripMenuItem,
            this.maviToolStripMenuItem});
            this.renklerToolStripMenuItem.Name = "renklerToolStripMenuItem";
            this.renklerToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.renklerToolStripMenuItem.Text = "Renkler";
            // 
            // varsayılanToolStripMenuItem
            // 
            this.varsayılanToolStripMenuItem.Name = "varsayılanToolStripMenuItem";
            this.varsayılanToolStripMenuItem.Size = new System.Drawing.Size(158, 26);
            this.varsayılanToolStripMenuItem.Text = "Varsayılan";
            this.varsayılanToolStripMenuItem.Click += new System.EventHandler(this.varsayılanToolStripMenuItem_Click);
            // 
            // yeşilToolStripMenuItem
            // 
            this.yeşilToolStripMenuItem.Name = "yeşilToolStripMenuItem";
            this.yeşilToolStripMenuItem.Size = new System.Drawing.Size(158, 26);
            this.yeşilToolStripMenuItem.Text = "yeşil";
            this.yeşilToolStripMenuItem.Click += new System.EventHandler(this.yeşilToolStripMenuItem_Click);
            // 
            // maviToolStripMenuItem
            // 
            this.maviToolStripMenuItem.Name = "maviToolStripMenuItem";
            this.maviToolStripMenuItem.Size = new System.Drawing.Size(158, 26);
            this.maviToolStripMenuItem.Text = "mavi";
            this.maviToolStripMenuItem.Click += new System.EventHandler(this.maviToolStripMenuItem_Click);
            // 
            // araçlarToolStripMenuItem
            // 
            this.araçlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.istatistiklerToolStripMenuItem,
            this.grafiklerToolStripMenuItem});
            this.araçlarToolStripMenuItem.Name = "araçlarToolStripMenuItem";
            this.araçlarToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.araçlarToolStripMenuItem.Text = "Araçlar";
            // 
            // istatistiklerToolStripMenuItem
            // 
            this.istatistiklerToolStripMenuItem.Name = "istatistiklerToolStripMenuItem";
            this.istatistiklerToolStripMenuItem.Size = new System.Drawing.Size(163, 26);
            this.istatistiklerToolStripMenuItem.Text = "İstatistikler";
            this.istatistiklerToolStripMenuItem.Click += new System.EventHandler(this.istatistiklerToolStripMenuItem_Click);
            // 
            // grafiklerToolStripMenuItem
            // 
            this.grafiklerToolStripMenuItem.Name = "grafiklerToolStripMenuItem";
            this.grafiklerToolStripMenuItem.Size = new System.Drawing.Size(163, 26);
            this.grafiklerToolStripMenuItem.Text = "Grafikler";
            this.grafiklerToolStripMenuItem.Click += new System.EventHandler(this.grafiklerToolStripMenuItem_Click);
            // 
            // hakkındaToolStripMenuItem
            // 
            this.hakkındaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hakkındaToolStripMenuItem1,
            this.çıkışToolStripMenuItem});
            this.hakkındaToolStripMenuItem.Name = "hakkındaToolStripMenuItem";
            this.hakkındaToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.hakkındaToolStripMenuItem.Text = "Hakkında";
            // 
            // hakkındaToolStripMenuItem1
            // 
            this.hakkındaToolStripMenuItem1.Name = "hakkındaToolStripMenuItem1";
            this.hakkındaToolStripMenuItem1.Size = new System.Drawing.Size(154, 26);
            this.hakkındaToolStripMenuItem1.Text = "Hakkında";
            this.hakkındaToolStripMenuItem1.Click += new System.EventHandler(this.hakkındaToolStripMenuItem1_Click);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(154, 26);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yenileToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(118, 28);
            // 
            // yenileToolStripMenuItem
            // 
            this.yenileToolStripMenuItem.Name = "yenileToolStripMenuItem";
            this.yenileToolStripMenuItem.Size = new System.Drawing.Size(117, 24);
            this.yenileToolStripMenuItem.Text = "Yenile";
            this.yenileToolStripMenuItem.Click += new System.EventHandler(this.yenileToolStripMenuItem_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Ebrima", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(532, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(627, 41);
            this.label9.TabIndex = 7;
            this.label9.Text = " ŞANTİYE PERSONEL TAKİP OTOMASYONU";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(686, 131);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 37);
            this.button1.TabIndex = 8;
            this.button1.Text = "raporlama";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(539, 81);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(119, 32);
            this.textBox1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1318, 754);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablepersonelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.şantiye_personelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonbekar;
        private System.Windows.Forms.RadioButton radioButtonevli;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxsehir;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxmaas;
        private System.Windows.Forms.TextBox textBoxmslk;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxsoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textboxid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttontmzle;
        private System.Windows.Forms.Button buttongnclle;
        private System.Windows.Forms.Button buttonsil;
        private System.Windows.Forms.Button buttonkydt;
        private System.Windows.Forms.Button buttonlist;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Şantiye_personelDataSet şantiye_personelDataSet;
        private System.Windows.Forms.BindingSource tablepersonelBindingSource;
        private Şantiye_personelDataSetTableAdapters.Table_personelTableAdapter table_personelTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personeladDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelsoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelsehirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelmeslekDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelmaasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn personeldurumDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem renklerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem varsayılanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeşilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maviToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem araçlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem istatistiklerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grafiklerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hakkındaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hakkındaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem yenileToolStripMenuItem;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

