using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using OfficeOpenXml;
namespace RsIndosiar
{
    public partial class FormAdmin : Form
    {

        public FormAdmin()
        {
            InitializeComponent();
            picObat.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        int id_obat;
        ObatDAL obatDAL =new ObatDAL();
        DiagnosaDAL diagnosaDAL = new DiagnosaDAL();
        int idDiagnosa = 0;
        private TextBox txtDeskripsi;
        private Button btnLogout;
        private DataGridView dataDiagnosa;
        private Button btnKonfirmasi;
        private TextBox txtHasil;
        private Button btnDelete;
        private TextBox txtObatt;
        private System.ComponentModel.IContainer components;
        private BindingNavigator bindingNavigator1;
        private ToolStripButton bindingNavigatorAddNewItem;
        private ToolStripLabel bindingNavigatorCountItem;
        private ToolStripButton bindingNavigatorDeleteItem;
        private ToolStripButton bindingNavigatorMoveFirstItem;
        private ToolStripButton bindingNavigatorMovePreviousItem;
        private ToolStripSeparator bindingNavigatorSeparator;
        private ToolStripTextBox bindingNavigatorPositionItem;
        private ToolStripSeparator bindingNavigatorSeparator1;
        private ToolStripButton bindingNavigatorMoveNextItem;
        private ToolStripButton bindingNavigatorMoveLastItem;
        private ToolStripSeparator bindingNavigatorSeparator2;
        private RsIndosiarDataSet rsIndosiarDataSet;
        private BindingSource obatBindingSource;
        private RsIndosiarDataSetTableAdapters.ObatTableAdapter obatTableAdapter;
        private BindingSource diagnosaBindingSource;
        private RsIndosiarDataSetTableAdapters.DiagnosaTableAdapter diagnosaTableAdapter;
        private Button btnTes;
        private Button btnReset;
        private BindingNavigator bindingNavigator2;
        private ToolStripButton bindingNavigatorAddNewItem1;
        private ToolStripLabel bindingNavigatorCountItem1;
        private ToolStripButton bindingNavigatorDeleteItem1;
        private ToolStripButton bindingNavigatorMoveFirstItem1;
        private ToolStripButton bindingNavigatorMovePreviousItem1;
        private ToolStripSeparator bindingNavigatorSeparator3;
        private ToolStripTextBox bindingNavigatorPositionItem1;
        private ToolStripSeparator bindingNavigatorSeparator4;
        private ToolStripButton bindingNavigatorMoveNextItem1;
        private ToolStripButton bindingNavigatorMoveLastItem1;
        private ToolStripSeparator bindingNavigatorSeparator5;
        private RsIndosiarDataSet1 rsIndosiarDataSet1;
        private BindingSource obatBindingSource1;
        private RsIndosiarDataSet1TableAdapters.ObatTableAdapter obatTableAdapter1;
        private BindingSource obatBindingSource2;
        private BindingSource obatBindingSource3;
        private Button btnTestObat;
        private Button btnResetObat;
        private Button btnCetakDiagnosa;
        private PictureBox picObat;
        private Button btnUploadGambar;
        private Button btnUploadExcel;
        static string connStr =
        @"Data Source=10.39.198.11,1433;
Initial Catalog=RsIndosiar;
User ID=rsuser;
Password=123;";
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdmin));
            this.txtObat = new System.Windows.Forms.TextBox();
            this.obatBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.rsIndosiarDataSet1 = new RsIndosiar.RsIndosiarDataSet1();
            this.obatBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.btnTambahObat = new System.Windows.Forms.Button();
            this.btnUpdateObat = new System.Windows.Forms.Button();
            this.btnDeleteObat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataObat = new System.Windows.Forms.DataGridView();
            this.txtDeskripsi = new System.Windows.Forms.TextBox();
            this.obatBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.obatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rsIndosiarDataSet = new RsIndosiar.RsIndosiarDataSet();
            this.btnLogout = new System.Windows.Forms.Button();
            this.dataDiagnosa = new System.Windows.Forms.DataGridView();
            this.btnKonfirmasi = new System.Windows.Forms.Button();
            this.txtHasil = new System.Windows.Forms.TextBox();
            this.diagnosaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtObatt = new System.Windows.Forms.TextBox();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnTes = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.bindingNavigator2 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem1 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem1 = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.btnTestObat = new System.Windows.Forms.Button();
            this.btnResetObat = new System.Windows.Forms.Button();
            this.btnCetakDiagnosa = new System.Windows.Forms.Button();
            this.obatTableAdapter = new RsIndosiar.RsIndosiarDataSetTableAdapters.ObatTableAdapter();
            this.diagnosaTableAdapter = new RsIndosiar.RsIndosiarDataSetTableAdapters.DiagnosaTableAdapter();
            this.obatTableAdapter1 = new RsIndosiar.RsIndosiarDataSet1TableAdapters.ObatTableAdapter();
            this.picObat = new System.Windows.Forms.PictureBox();
            this.btnUploadGambar = new System.Windows.Forms.Button();
            this.btnUploadExcel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.obatBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rsIndosiarDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obatBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataObat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obatBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obatBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rsIndosiarDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDiagnosa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagnosaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).BeginInit();
            this.bindingNavigator2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picObat)).BeginInit();
            this.SuspendLayout();
            // 
            // txtObat
            // 
            this.txtObat.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.obatBindingSource1, "nama_obat", true));
            this.txtObat.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.obatBindingSource2, "nama_obat", true));
            this.txtObat.Location = new System.Drawing.Point(401, 306);
            this.txtObat.Name = "txtObat";
            this.txtObat.Size = new System.Drawing.Size(338, 22);
            this.txtObat.TabIndex = 5;
            // 
            // obatBindingSource1
            // 
            this.obatBindingSource1.DataMember = "Obat";
            this.obatBindingSource1.DataSource = this.rsIndosiarDataSet1;
            // 
            // rsIndosiarDataSet1
            // 
            this.rsIndosiarDataSet1.DataSetName = "RsIndosiarDataSet1";
            this.rsIndosiarDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // obatBindingSource2
            // 
            this.obatBindingSource2.DataMember = "Obat";
            this.obatBindingSource2.DataSource = this.rsIndosiarDataSet1;
            // 
            // btnTambahObat
            // 
            this.btnTambahObat.Location = new System.Drawing.Point(401, 362);
            this.btnTambahObat.Name = "btnTambahObat";
            this.btnTambahObat.Size = new System.Drawing.Size(75, 23);
            this.btnTambahObat.TabIndex = 6;
            this.btnTambahObat.Text = "Tambah";
            this.btnTambahObat.UseVisualStyleBackColor = true;
            this.btnTambahObat.Click += new System.EventHandler(this.btnTambahObat_Click);
            // 
            // btnUpdateObat
            // 
            this.btnUpdateObat.Location = new System.Drawing.Point(541, 362);
            this.btnUpdateObat.Name = "btnUpdateObat";
            this.btnUpdateObat.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateObat.TabIndex = 7;
            this.btnUpdateObat.Text = "Update";
            this.btnUpdateObat.UseVisualStyleBackColor = true;
            this.btnUpdateObat.Click += new System.EventHandler(this.btnUpdateObat_Click);
            // 
            // btnDeleteObat
            // 
            this.btnDeleteObat.Location = new System.Drawing.Point(664, 362);
            this.btnDeleteObat.Name = "btnDeleteObat";
            this.btnDeleteObat.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteObat.TabIndex = 8;
            this.btnDeleteObat.Text = "Delete";
            this.btnDeleteObat.UseVisualStyleBackColor = true;
            this.btnDeleteObat.Click += new System.EventHandler(this.btnDeleteObat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(536, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Gejala";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(537, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Obat";
            // 
            // dataObat
            // 
            this.dataObat.BackgroundColor = System.Drawing.Color.White;
            this.dataObat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataObat.Location = new System.Drawing.Point(188, 391);
            this.dataObat.Name = "dataObat";
            this.dataObat.RowHeadersWidth = 51;
            this.dataObat.RowTemplate.Height = 24;
            this.dataObat.Size = new System.Drawing.Size(825, 134);
            this.dataObat.TabIndex = 11;
            this.dataObat.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataObat_CellClick);
            this.dataObat.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataObat_CellContentClick);
            // 
            // txtDeskripsi
            // 
            this.txtDeskripsi.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.obatBindingSource3, "deskripsi", true));
            this.txtDeskripsi.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.obatBindingSource, "deskripsi", true));
            this.txtDeskripsi.Location = new System.Drawing.Point(401, 334);
            this.txtDeskripsi.Name = "txtDeskripsi";
            this.txtDeskripsi.Size = new System.Drawing.Size(338, 22);
            this.txtDeskripsi.TabIndex = 12;
            // 
            // obatBindingSource3
            // 
            this.obatBindingSource3.DataMember = "Obat";
            this.obatBindingSource3.DataSource = this.rsIndosiarDataSet1;
            // 
            // obatBindingSource
            // 
            this.obatBindingSource.DataMember = "Obat";
            this.obatBindingSource.DataSource = this.rsIndosiarDataSet;
            // 
            // rsIndosiarDataSet
            // 
            this.rsIndosiarDataSet.DataSetName = "RsIndosiarDataSet";
            this.rsIndosiarDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(938, 43);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 13;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // dataDiagnosa
            // 
            this.dataDiagnosa.BackgroundColor = System.Drawing.Color.White;
            this.dataDiagnosa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataDiagnosa.Location = new System.Drawing.Point(80, 163);
            this.dataDiagnosa.Name = "dataDiagnosa";
            this.dataDiagnosa.RowHeadersWidth = 51;
            this.dataDiagnosa.RowTemplate.Height = 24;
            this.dataDiagnosa.Size = new System.Drawing.Size(933, 105);
            this.dataDiagnosa.TabIndex = 14;
            this.dataDiagnosa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataDiagnosa_CellClick);
            this.dataDiagnosa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnKonfirmasi
            // 
            this.btnKonfirmasi.Location = new System.Drawing.Point(401, 134);
            this.btnKonfirmasi.Name = "btnKonfirmasi";
            this.btnKonfirmasi.Size = new System.Drawing.Size(75, 23);
            this.btnKonfirmasi.TabIndex = 15;
            this.btnKonfirmasi.Text = "Konfirmasi";
            this.btnKonfirmasi.UseVisualStyleBackColor = true;
            this.btnKonfirmasi.Click += new System.EventHandler(this.btnKonfirmasi_Click);
            // 
            // txtHasil
            // 
            this.txtHasil.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.diagnosaBindingSource, "hasil_diagnosa", true));
            this.txtHasil.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.diagnosaBindingSource, "hasil_diagnosa", true));
            this.txtHasil.Location = new System.Drawing.Point(401, 69);
            this.txtHasil.Name = "txtHasil";
            this.txtHasil.Size = new System.Drawing.Size(338, 22);
            this.txtHasil.TabIndex = 16;
            this.txtHasil.TextChanged += new System.EventHandler(this.txtHasil_TextChanged);
            // 
            // diagnosaBindingSource
            // 
            this.diagnosaBindingSource.DataMember = "Diagnosa";
            this.diagnosaBindingSource.DataSource = this.rsIndosiarDataSet;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(664, 134);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtObatt
            // 
            this.txtObatt.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.diagnosaBindingSource, "obat", true));
            this.txtObatt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.diagnosaBindingSource, "obat", true));
            this.txtObatt.Location = new System.Drawing.Point(401, 106);
            this.txtObatt.Name = "txtObatt";
            this.txtObatt.Size = new System.Drawing.Size(338, 22);
            this.txtObatt.TabIndex = 19;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BindingSource = this.diagnosaBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.None;
            this.bindingNavigator1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(302, 27);
            this.bindingNavigator1.TabIndex = 20;
            this.bindingNavigator1.Text = "bindingNavigator1";
            this.bindingNavigator1.RefreshItems += new System.EventHandler(this.bindingNavigator1_RefreshItems);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // btnTes
            // 
            this.btnTes.BackColor = System.Drawing.Color.Red;
            this.btnTes.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTes.Location = new System.Drawing.Point(583, 134);
            this.btnTes.Name = "btnTes";
            this.btnTes.Size = new System.Drawing.Size(75, 23);
            this.btnTes.TabIndex = 21;
            this.btnTes.Text = "TEST";
            this.btnTes.UseVisualStyleBackColor = false;
            this.btnTes.Click += new System.EventHandler(this.btnTes_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Lime;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(482, 134);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 22;
            this.btnReset.Text = "RESET";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // bindingNavigator2
            // 
            this.bindingNavigator2.AddNewItem = this.bindingNavigatorAddNewItem1;
            this.bindingNavigator2.BindingSource = this.obatBindingSource;
            this.bindingNavigator2.CountItem = this.bindingNavigatorCountItem1;
            this.bindingNavigator2.DeleteItem = this.bindingNavigatorDeleteItem1;
            this.bindingNavigator2.Dock = System.Windows.Forms.DockStyle.None;
            this.bindingNavigator2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindingNavigator2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem1,
            this.bindingNavigatorCountItem1,
            this.bindingNavigatorMovePreviousItem1,
            this.bindingNavigatorSeparator3,
            this.bindingNavigatorPositionItem1,
            this.bindingNavigatorSeparator4,
            this.bindingNavigatorMoveNextItem1,
            this.bindingNavigatorMoveLastItem1,
            this.bindingNavigatorSeparator5,
            this.bindingNavigatorAddNewItem1,
            this.bindingNavigatorDeleteItem1});
            this.bindingNavigator2.Location = new System.Drawing.Point(767, 0);
            this.bindingNavigator2.MoveFirstItem = this.bindingNavigatorMoveFirstItem1;
            this.bindingNavigator2.MoveLastItem = this.bindingNavigatorMoveLastItem1;
            this.bindingNavigator2.MoveNextItem = this.bindingNavigatorMoveNextItem1;
            this.bindingNavigator2.MovePreviousItem = this.bindingNavigatorMovePreviousItem1;
            this.bindingNavigator2.Name = "bindingNavigator2";
            this.bindingNavigator2.PositionItem = this.bindingNavigatorPositionItem1;
            this.bindingNavigator2.Size = new System.Drawing.Size(302, 31);
            this.bindingNavigator2.TabIndex = 23;
            this.bindingNavigator2.Text = "bindingNavigator2";
            // 
            // bindingNavigatorAddNewItem1
            // 
            this.bindingNavigatorAddNewItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem1.Image")));
            this.bindingNavigatorAddNewItem1.Name = "bindingNavigatorAddNewItem1";
            this.bindingNavigatorAddNewItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem1.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem1.Text = "Add new";
            // 
            // bindingNavigatorCountItem1
            // 
            this.bindingNavigatorCountItem1.Name = "bindingNavigatorCountItem1";
            this.bindingNavigatorCountItem1.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem1.Text = "of {0}";
            this.bindingNavigatorCountItem1.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem1
            // 
            this.bindingNavigatorDeleteItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem1.Image")));
            this.bindingNavigatorDeleteItem1.Name = "bindingNavigatorDeleteItem1";
            this.bindingNavigatorDeleteItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem1.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem1.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem1
            // 
            this.bindingNavigatorMoveFirstItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem1.Image")));
            this.bindingNavigatorMoveFirstItem1.Name = "bindingNavigatorMoveFirstItem1";
            this.bindingNavigatorMoveFirstItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem1.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem1.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem1
            // 
            this.bindingNavigatorMovePreviousItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem1.Image")));
            this.bindingNavigatorMovePreviousItem1.Name = "bindingNavigatorMovePreviousItem1";
            this.bindingNavigatorMovePreviousItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem1.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem1.Text = "Move previous";
            // 
            // bindingNavigatorSeparator3
            // 
            this.bindingNavigatorSeparator3.Name = "bindingNavigatorSeparator3";
            this.bindingNavigatorSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem1
            // 
            this.bindingNavigatorPositionItem1.AccessibleName = "Position";
            this.bindingNavigatorPositionItem1.AutoSize = false;
            this.bindingNavigatorPositionItem1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem1.Name = "bindingNavigatorPositionItem1";
            this.bindingNavigatorPositionItem1.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem1.Text = "0";
            this.bindingNavigatorPositionItem1.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator4
            // 
            this.bindingNavigatorSeparator4.Name = "bindingNavigatorSeparator4";
            this.bindingNavigatorSeparator4.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem1
            // 
            this.bindingNavigatorMoveNextItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem1.Image")));
            this.bindingNavigatorMoveNextItem1.Name = "bindingNavigatorMoveNextItem1";
            this.bindingNavigatorMoveNextItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem1.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem1.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem1
            // 
            this.bindingNavigatorMoveLastItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem1.Image")));
            this.bindingNavigatorMoveLastItem1.Name = "bindingNavigatorMoveLastItem1";
            this.bindingNavigatorMoveLastItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem1.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem1.Text = "Move last";
            // 
            // bindingNavigatorSeparator5
            // 
            this.bindingNavigatorSeparator5.Name = "bindingNavigatorSeparator5";
            this.bindingNavigatorSeparator5.Size = new System.Drawing.Size(6, 27);
            // 
            // btnTestObat
            // 
            this.btnTestObat.BackColor = System.Drawing.Color.Red;
            this.btnTestObat.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTestObat.Location = new System.Drawing.Point(745, 306);
            this.btnTestObat.Name = "btnTestObat";
            this.btnTestObat.Size = new System.Drawing.Size(75, 23);
            this.btnTestObat.TabIndex = 24;
            this.btnTestObat.Text = "TEST";
            this.btnTestObat.UseVisualStyleBackColor = false;
            this.btnTestObat.Click += new System.EventHandler(this.btnTestObat_Click);
            // 
            // btnResetObat
            // 
            this.btnResetObat.BackColor = System.Drawing.Color.Lime;
            this.btnResetObat.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetObat.Location = new System.Drawing.Point(320, 306);
            this.btnResetObat.Name = "btnResetObat";
            this.btnResetObat.Size = new System.Drawing.Size(75, 23);
            this.btnResetObat.TabIndex = 25;
            this.btnResetObat.Text = "RESET";
            this.btnResetObat.UseVisualStyleBackColor = false;
            this.btnResetObat.Click += new System.EventHandler(this.btnResetObat_Click);
            // 
            // btnCetakDiagnosa
            // 
            this.btnCetakDiagnosa.Location = new System.Drawing.Point(877, 531);
            this.btnCetakDiagnosa.Name = "btnCetakDiagnosa";
            this.btnCetakDiagnosa.Size = new System.Drawing.Size(136, 23);
            this.btnCetakDiagnosa.TabIndex = 26;
            this.btnCetakDiagnosa.Text = "Cetak Diaknosa";
            this.btnCetakDiagnosa.UseVisualStyleBackColor = true;
            this.btnCetakDiagnosa.Click += new System.EventHandler(this.btnCetakDiagnosa_Click);
            // 
            // obatTableAdapter
            // 
            this.obatTableAdapter.ClearBeforeFill = true;
            // 
            // diagnosaTableAdapter
            // 
            this.diagnosaTableAdapter.ClearBeforeFill = true;
            // 
            // obatTableAdapter1
            // 
            this.obatTableAdapter1.ClearBeforeFill = true;
            // 
            // picObat
            // 
            this.picObat.Location = new System.Drawing.Point(80, 394);
            this.picObat.Name = "picObat";
            this.picObat.Size = new System.Drawing.Size(100, 131);
            this.picObat.TabIndex = 27;
            this.picObat.TabStop = false;
            // 
            // btnUploadGambar
            // 
            this.btnUploadGambar.Location = new System.Drawing.Point(80, 531);
            this.btnUploadGambar.Name = "btnUploadGambar";
            this.btnUploadGambar.Size = new System.Drawing.Size(100, 23);
            this.btnUploadGambar.TabIndex = 28;
            this.btnUploadGambar.Text = "Pilih Gambar";
            this.btnUploadGambar.UseVisualStyleBackColor = true;
            this.btnUploadGambar.Click += new System.EventHandler(this.btnUploadGambar_Click);
            // 
            // btnUploadExcel
            // 
            this.btnUploadExcel.Location = new System.Drawing.Point(894, 330);
            this.btnUploadExcel.Name = "btnUploadExcel";
            this.btnUploadExcel.Size = new System.Drawing.Size(119, 55);
            this.btnUploadExcel.TabIndex = 29;
            this.btnUploadExcel.Text = "Import dari\r\nExcel";
            this.btnUploadExcel.UseVisualStyleBackColor = true;
            this.btnUploadExcel.Click += new System.EventHandler(this.btnUploadExcel_Click);
            // 
            // FormAdmin
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1108, 592);
            this.Controls.Add(this.btnUploadExcel);
            this.Controls.Add(this.btnUploadGambar);
            this.Controls.Add(this.picObat);
            this.Controls.Add(this.btnCetakDiagnosa);
            this.Controls.Add(this.btnResetObat);
            this.Controls.Add(this.btnTestObat);
            this.Controls.Add(this.bindingNavigator2);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnTes);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.txtObatt);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtHasil);
            this.Controls.Add(this.btnKonfirmasi);
            this.Controls.Add(this.dataDiagnosa);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.txtDeskripsi);
            this.Controls.Add(this.dataObat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDeleteObat);
            this.Controls.Add(this.btnUpdateObat);
            this.Controls.Add(this.btnTambahObat);
            this.Controls.Add(this.txtObat);
            this.Name = "FormAdmin";
            this.Load += new System.EventHandler(this.FormAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.obatBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rsIndosiarDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obatBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataObat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obatBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obatBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rsIndosiarDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDiagnosa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagnosaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).EndInit();
            this.bindingNavigator2.ResumeLayout(false);
            this.bindingNavigator2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picObat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private DataGridView dataObat;
        private TextBox txtObat;






        private void LoadDiagnosa()
        {
           

           
                dataDiagnosa.DataSource =
    diagnosaDAL.GetAll();


        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            LoadDiagnosa();
            LoadObat();

            MessageBox.Show("Masuk Admin");
        }


        int id_gejala;
        string gambarObat = "";
        string gambarLama = "";








        private Button btnTambahObat;
        private Button btnUpdateObat;
        private Button btnDeleteObat;
        private Label label1;
        private Label label2;
        private void LoadObat()
        {
            DataTable dt =
    obatDAL.GetAll();


            dataObat.DataSource = dt;


            if (dataObat.Columns.Contains("gambar_obat"))
            {
                dataObat.Columns["gambar_obat"].Visible = false;
            }


            if (dataObat.Columns.Contains("Foto"))
            {
                dataObat.Columns.Remove("Foto");
            }


            DataGridViewImageColumn img =
            new DataGridViewImageColumn();


            img.Name = "Foto";
            img.HeaderText = "Gambar";


            dataObat.Columns.Add(img);



            foreach (DataGridViewRow row in dataObat.Rows)
            {

                if (row.Cells["gambar_obat"].Value != null)
                {

                    string path =
                    row.Cells["gambar_obat"].Value.ToString();



                    if (File.Exists(path))
                    {

                        using (FileStream fs =
                        new FileStream(
                        path,
                        FileMode.Open,
                        FileAccess.Read))
                        {

                            row.Cells["Foto"].Value =
                            new Bitmap(Image.FromStream(fs));

                        }

                    }

                }

            }
        }


        private void btnTambahObat_Click(object sender, EventArgs e)
        {
            if (txtObat.Text == "" || txtDeskripsi.Text == "")
            {
                MessageBox.Show("Data obat belum lengkap!");
                return;
            }


            ClassObat obat =
    new ClassObat();


            obat.nama_obat =
            txtObat.Text;


            obat.deskripsi =
            txtDeskripsi.Text;


            obat.gambar_obat =
            gambarObat;



            bool hasil =
            obatDAL.Insert(obat);



            if (hasil)
            {
                MessageBox.Show(
                "Obat berhasil ditambahkan");


                LoadObat();
            }

            if (gambarObat == "")
            {
                MessageBox.Show("Silahkan pilih gambar obat dulu!");
                return;
            }


            // tampilkan gambar langsung
            // tampilkan gambar langsung
            if (!string.IsNullOrEmpty(gambarObat) && File.Exists(gambarObat))
            {
                using (FileStream fs = new FileStream(gambarObat, FileMode.Open, FileAccess.Read))
                {
                    picObat.Image = new Bitmap(Image.FromStream(fs));
                }
            }
        }

        private void dataObat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnUpdateObat_Click(object sender, EventArgs e)
        {
            if (id_obat == 0)
            {
                MessageBox.Show(
                "Pilih data obat terlebih dahulu!");

                return;
            }


            if (txtObat.Text.Trim() == "")
            {
                MessageBox.Show(
                "Nama obat belum diisi!");

                txtObat.Focus();

                return;
            }


            if (txtDeskripsi.Text.Trim() == "")
            {
                MessageBox.Show(
                "Deskripsi belum diisi!");

                txtDeskripsi.Focus();

                return;
            }



            ClassObat obat =
            new ClassObat();


            obat.id_obat = id_obat;
            obat.nama_obat = txtObat.Text;
            obat.deskripsi = txtDeskripsi.Text;
            obat.gambar_obat = gambarObat;
            // kalau gambar diganti pakai gambar baru
            // kalau tidak pakai gambar lama

            if (gambarObat == "")
            {
                obat.gambar_obat =
                gambarLama;
            }
            else
            {
                obat.gambar_obat =
                gambarObat;
            }



            bool hasil =
            obatDAL.Update(obat);



            if (hasil)
            {
                MessageBox.Show(
                "Data obat berhasil diupdate!");


                LoadObat();
            }

        }

        private void btnDeleteObat_Click(object sender, EventArgs e)
        {
            if (id_obat == 0)
            {
                MessageBox.Show("Pilih obat terlebih dahulu");
                return;
            }


            DialogResult hasil =
            MessageBox.Show(
            "Yakin hapus obat?",
            "Konfirmasi",
            MessageBoxButtons.YesNo);


            if (hasil == DialogResult.Yes)
            {

                bool sukses =
                obatDAL.Delete(id_obat);


                if (sukses)
                {
                    MessageBox.Show("Obat berhasil dihapus");

                    LoadObat();

                    id_obat = 0;
                }
                else
                {
                    MessageBox.Show("Gagal menghapus obat");
                }

            }

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Show();

            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataDiagnosa.Rows[e.RowIndex];

                idDiagnosa =
                Convert.ToInt32(row.Cells["id_diagnosa"].Value);

                txtHasil.Text =
                row.Cells["hasil_diagnosa"].Value.ToString();

                txtObatt.Text =
                row.Cells["obat"].Value.ToString();

                MessageBox.Show(idDiagnosa.ToString());
            }
        }

        private void btnKonfirmasi_Click(object sender, EventArgs e)
        {
            ClassDiagnosa d =
    new ClassDiagnosa();


            d.id_diagnosa = idDiagnosa;


            d.hasil_diagnosa =
            txtHasil.Text;


            d.obat =
            txtObatt.Text;



            bool hasil =
            diagnosaDAL.Update(d);



            if (hasil)
            {
                MessageBox.Show(
                "Diagnosa berhasil dikonfirmasi");


                LoadDiagnosa();
            }
        }

        private void dataDiagnosa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row =
                dataDiagnosa.Rows[e.RowIndex];

                idDiagnosa =
                Convert.ToInt32(
                row.Cells[0].Value);

                txtHasil.Text =
                row.Cells[2].Value.ToString();

                txtObatt.Text =
                row.Cells[3].Value.ToString();
            }
        }




        private void btnDelete_Click(object sender, EventArgs e)
        {
            bool hasil = diagnosaDAL.Delete(idDiagnosa);


            if (hasil)
            {
                MessageBox.Show(
                "Data diagnosa berhasil dihapus");


                LoadDiagnosa();
            }

        }

        private void txtHasil_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataObat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row =
                dataObat.Rows[e.RowIndex];


                id_obat =
                Convert.ToInt32(
                row.Cells["id_obat"].Value);



                txtObat.Text =
                row.Cells["nama_obat"].Value.ToString();


                txtDeskripsi.Text =
                row.Cells["deskripsi"].Value.ToString();



                gambarLama =
                obatDAL.GetGambar(id_obat);



                if (File.Exists(gambarLama))
                {
                    using (FileStream fs =
                    new FileStream(
                    gambarLama,
                    FileMode.Open,
                    FileAccess.Read))
                    {
                        picObat.Image =
                        new Bitmap(Image.FromStream(fs));
                    }
                }

            }
        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        private void btnTes_Click(object sender, EventArgs e)
        {
            DataTable dt =
            new DataTable();

            dt.Columns.Add("STATUS");

            dt.Rows.Add("⚠ SYSTEM ERROR ⚠");
            dt.Rows.Add("DATABASE HACKED");
            dt.Rows.Add("SQL INJECTION DETECTED");
            dt.Rows.Add("DATA BERHASIL DIBOCAHKAN");

            dataDiagnosa.DataSource = dt;

            MessageBox.Show(
            "SQL Injection Berhasil!");

            this.BackColor =
            Color.DarkMagenta;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            LoadDiagnosa();

            this.BackColor =
            Color.White;

            MessageBox.Show(
            "Sistem berhasil dipulihkan!");
        }

        private void btnTestObat_Click(object sender, EventArgs e)
        {
            DataTable dt =
            new DataTable();

            dt.Columns.Add("STATUS");

            dt.Rows.Add("⚠ DATABASE OBAT ERROR ⚠");
            dt.Rows.Add("DATA OBAT DIRETAS");
            dt.Rows.Add("SQL INJECTION DETECTED");
            dt.Rows.Add("SEMUA DATA OBAT BOCOR");

            dataObat.DataSource = dt;

            this.BackColor =
            Color.DarkMagenta;

            MessageBox.Show(
            "SQL Injection pada data obat berhasil!");
        }

        private void btnResetObat_Click(object sender, EventArgs e)
        {
            LoadObat();

            this.BackColor =
            Color.White;

            MessageBox.Show(
            "Data obat berhasil dipulihkan!");
        }

        private void btnCetakDiagnosa_Click(object sender, EventArgs e)
        {


            FormRekapDiagnosa f =
            new FormRekapDiagnosa();

            f.Show();
        }

        private void btnUploadGambar_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();

            open.Filter = "Image Files|*.jpg;*.png;*.jpeg";


            if (open.ShowDialog() == DialogResult.OK)
            {
                gambarObat = open.FileName;

                using (FileStream fs = new FileStream(gambarObat, FileMode.Open, FileAccess.Read))
                {
                    picObat.Image = new Bitmap(Image.FromStream(fs));
                }
            }
        }

        private void btnUploadExcel_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();

            open.Filter = "Excel Files|*.xlsx";


            if (open.ShowDialog() != DialogResult.OK)
            {
                return;
            }


            // ==========================
            // VALIDASI FILE EXCEL
            // ==========================

            string extension =
            Path.GetExtension(open.FileName);


            if (extension.ToLower() != ".xlsx")
            {
                MessageBox.Show(
                "File harus berformat Excel (.xlsx)");

                return;
            }



            string filePath =
            open.FileName;



            ExcelPackage.LicenseContext =
            LicenseContext.NonCommercial;



            using (var package =
            new ExcelPackage(new FileInfo(filePath)))
            {


                ExcelWorksheet sheet =
                package.Workbook.Worksheets[0];



                // ==========================
                // VALIDASI SHEET KOSONG
                // ==========================

                if (sheet.Dimension == null)
                {
                    MessageBox.Show(
                    "File Excel kosong!");

                    return;
                }



                // ==========================
                // VALIDASI HEADER
                // ==========================

                if (sheet.Cells[1, 1].Value.ToString()
                    != "nama_obat" ||

                   sheet.Cells[1, 2].Value.ToString()
                    != "deskripsi" ||

                   sheet.Cells[1, 3].Value.ToString()
                    != "gambar_obat")
                {

                    MessageBox.Show(
                    "Format Excel tidak sesuai!\n\n" +
                    "Gunakan format:\n" +
                    "nama_obat | deskripsi | gambar_obat");


                    return;
                }




                int jumlahBaris =
                sheet.Dimension.Rows;



                SqlConnection conn =
                new SqlConnection(connStr);


                conn.Open();



                int berhasil = 0;



                for (int i = 2; i <= jumlahBaris; i++)
                {


                    // ==========================
                    // AMBIL DATA EXCEL
                    // ==========================

                    string nama =
                    sheet.Cells[i, 1].Value?.ToString();



                    string deskripsi =
                    sheet.Cells[i, 2].Value?.ToString();



                    string gambar =
                    sheet.Cells[i, 3].Value?.ToString();





                    // ==========================
                    // VALIDASI DATA KOSONG
                    // ==========================

                    if (string.IsNullOrEmpty(nama) ||
                       string.IsNullOrEmpty(deskripsi))
                    {

                        MessageBox.Show(
                        "Data baris " + i +
                        " belum lengkap");


                        continue;
                    }





                    // ==========================
                    // VALIDASI GAMBAR
                    // ==========================

                    if (!File.Exists(gambar))
                    {

                        MessageBox.Show(
                        "Gambar tidak ditemukan pada baris "
                        + i);


                        continue;
                    }






                    // ==========================
                    // CEK DUPLIKAT OBAT
                    // ==========================

                    string cek =
                    "SELECT COUNT(*) FROM Obat WHERE nama_obat=@n";


                    SqlCommand cekCmd =
                    new SqlCommand(cek, conn);



                    cekCmd.Parameters.AddWithValue(
                    "@n", nama);



                    int jumlah =
                    (int)cekCmd.ExecuteScalar();



                    if (jumlah > 0)
                    {

                        MessageBox.Show(
                        nama +
                        " sudah ada di database");


                        continue;

                    }





                    // ==========================
                    // INSERT DATA
                    // ==========================

                    string query =
                    @"INSERT INTO Obat
            (
                nama_obat,
                deskripsi,
                gambar_obat
            )

            VALUES
            (
                @n,
                @d,
                @g
            )";



                    SqlCommand cmd =
                    new SqlCommand(query, conn);



                    cmd.Parameters.AddWithValue(
                    "@n", nama);



                    cmd.Parameters.AddWithValue(
                    "@d", deskripsi);



                    cmd.Parameters.AddWithValue(
                    "@g", gambar);



                    cmd.ExecuteNonQuery();


                    berhasil++;


                }



                conn.Close();



                MessageBox.Show(
                "Upload selesai!\n" +
                "Data berhasil masuk : "
                + berhasil);



                LoadObat();

            }
        }
        }
    }
