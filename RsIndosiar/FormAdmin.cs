using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace RsIndosiar
{
    public partial class FormAdmin : Form
    {
        
        public FormAdmin()
        {
            InitializeComponent();
        }
        int id_obat;
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
        string connStr = "Data Source=DIAN\\NAZARIN;Initial Catalog=RsIndosiar;Integrated Security=True";

        private void InitializeComponent() 
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdmin));
            this.txtObat = new System.Windows.Forms.TextBox();
            this.btnTambahObat = new System.Windows.Forms.Button();
            this.btnUpdateObat = new System.Windows.Forms.Button();
            this.btnDeleteObat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataObat = new System.Windows.Forms.DataGridView();
            this.txtDeskripsi = new System.Windows.Forms.TextBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.dataDiagnosa = new System.Windows.Forms.DataGridView();
            this.btnKonfirmasi = new System.Windows.Forms.Button();
            this.txtHasil = new System.Windows.Forms.TextBox();
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
            this.rsIndosiarDataSet = new RsIndosiar.RsIndosiarDataSet();
            this.obatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.obatTableAdapter = new RsIndosiar.RsIndosiarDataSetTableAdapters.ObatTableAdapter();
            this.diagnosaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.diagnosaTableAdapter = new RsIndosiar.RsIndosiarDataSetTableAdapters.DiagnosaTableAdapter();
            this.btnTes = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataObat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDiagnosa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rsIndosiarDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obatBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagnosaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtObat
            // 
            this.txtObat.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.obatBindingSource, "nama_obat", true));
            this.txtObat.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.obatBindingSource, "nama_obat", true));
            this.txtObat.Location = new System.Drawing.Point(560, 74);
            this.txtObat.Name = "txtObat";
            this.txtObat.Size = new System.Drawing.Size(356, 22);
            this.txtObat.TabIndex = 5;
            // 
            // btnTambahObat
            // 
            this.btnTambahObat.Location = new System.Drawing.Point(694, 164);
            this.btnTambahObat.Name = "btnTambahObat";
            this.btnTambahObat.Size = new System.Drawing.Size(75, 23);
            this.btnTambahObat.TabIndex = 6;
            this.btnTambahObat.Text = "Tambah";
            this.btnTambahObat.UseVisualStyleBackColor = true;
            this.btnTambahObat.Click += new System.EventHandler(this.btnTambahObat_Click);
            // 
            // btnUpdateObat
            // 
            this.btnUpdateObat.Location = new System.Drawing.Point(694, 196);
            this.btnUpdateObat.Name = "btnUpdateObat";
            this.btnUpdateObat.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateObat.TabIndex = 7;
            this.btnUpdateObat.Text = "Update";
            this.btnUpdateObat.UseVisualStyleBackColor = true;
            this.btnUpdateObat.Click += new System.EventHandler(this.btnUpdateObat_Click);
            // 
            // btnDeleteObat
            // 
            this.btnDeleteObat.Location = new System.Drawing.Point(694, 225);
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
            this.label1.Location = new System.Drawing.Point(193, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Gejala";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(714, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Obat";
            // 
            // dataObat
            // 
            this.dataObat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataObat.Location = new System.Drawing.Point(560, 269);
            this.dataObat.Name = "dataObat";
            this.dataObat.RowHeadersWidth = 51;
            this.dataObat.RowTemplate.Height = 24;
            this.dataObat.Size = new System.Drawing.Size(369, 183);
            this.dataObat.TabIndex = 11;
            this.dataObat.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataObat_CellClick);
            this.dataObat.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataObat_CellContentClick);
            // 
            // txtDeskripsi
            // 
            this.txtDeskripsi.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.obatBindingSource, "deskripsi", true));
            this.txtDeskripsi.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.obatBindingSource, "deskripsi", true));
            this.txtDeskripsi.Location = new System.Drawing.Point(560, 121);
            this.txtDeskripsi.Name = "txtDeskripsi";
            this.txtDeskripsi.Size = new System.Drawing.Size(356, 22);
            this.txtDeskripsi.TabIndex = 12;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(854, 3);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 13;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // dataDiagnosa
            // 
            this.dataDiagnosa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataDiagnosa.Location = new System.Drawing.Point(22, 269);
            this.dataDiagnosa.Name = "dataDiagnosa";
            this.dataDiagnosa.RowHeadersWidth = 51;
            this.dataDiagnosa.RowTemplate.Height = 24;
            this.dataDiagnosa.Size = new System.Drawing.Size(400, 183);
            this.dataDiagnosa.TabIndex = 14;
            this.dataDiagnosa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataDiagnosa_CellClick);
            this.dataDiagnosa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnKonfirmasi
            // 
            this.btnKonfirmasi.Location = new System.Drawing.Point(186, 225);
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
            this.txtHasil.Location = new System.Drawing.Point(59, 74);
            this.txtHasil.Name = "txtHasil";
            this.txtHasil.Size = new System.Drawing.Size(338, 22);
            this.txtHasil.TabIndex = 16;
            this.txtHasil.TextChanged += new System.EventHandler(this.txtHasil_TextChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(186, 183);
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
            this.txtObatt.Location = new System.Drawing.Point(59, 121);
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
            // rsIndosiarDataSet
            // 
            this.rsIndosiarDataSet.DataSetName = "RsIndosiarDataSet";
            this.rsIndosiarDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // obatBindingSource
            // 
            this.obatBindingSource.DataMember = "Obat";
            this.obatBindingSource.DataSource = this.rsIndosiarDataSet;
            // 
            // obatTableAdapter
            // 
            this.obatTableAdapter.ClearBeforeFill = true;
            // 
            // diagnosaBindingSource
            // 
            this.diagnosaBindingSource.DataMember = "Diagnosa";
            this.diagnosaBindingSource.DataSource = this.rsIndosiarDataSet;
            // 
            // diagnosaTableAdapter
            // 
            this.diagnosaTableAdapter.ClearBeforeFill = true;
            // 
            // btnTes
            // 
            this.btnTes.BackColor = System.Drawing.Color.Red;
            this.btnTes.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTes.Location = new System.Drawing.Point(347, 225);
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
            this.btnReset.Location = new System.Drawing.Point(48, 225);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 22;
            this.btnReset.Text = "RESET";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // FormAdmin
            // 
            this.ClientSize = new System.Drawing.Size(941, 528);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataObat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDiagnosa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rsIndosiarDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obatBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagnosaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private DataGridView dataObat;
        private TextBox txtObat;
      


       


        private void LoadDiagnosa()
        {
            SqlConnection conn = new SqlConnection(connStr);

            SqlDataAdapter da =
            new SqlDataAdapter("SELECT * FROM vwDiagnosa", conn);

            DataTable dt = new DataTable();

            da.Fill(dt);

            dataDiagnosa.DataSource = dt;
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rsIndosiarDataSet.Diagnosa' table. You can move, or remove it, as needed.
            this.diagnosaTableAdapter.Fill(this.rsIndosiarDataSet.Diagnosa);
            // TODO: This line of code loads data into the 'rsIndosiarDataSet.Obat' table. You can move, or remove it, as needed.
            this.obatTableAdapter.Fill(this.rsIndosiarDataSet.Obat);
            LoadDiagnosa();
            
            LoadObat();
            MessageBox.Show("Masuk Admin");
        } 


        int id_gejala;

   






        private Button btnTambahObat;
        private Button btnUpdateObat;
        private Button btnDeleteObat;
        private Label label1;
        private Label label2;
        private void LoadObat()
        {
            SqlConnection conn = new SqlConnection(connStr);

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Obat", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataObat.DataSource = dt;
        }

        private void btnTambahObat_Click(object sender, EventArgs e)
        {
            SqlConnection conn =
    new SqlConnection(connStr);

            conn.Open();

            string query =
            "INSERT INTO Obat(nama_obat,deskripsi) VALUES(@n,@d)";

            SqlCommand cmd =
            new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@n",
            txtObat.Text);

            cmd.Parameters.AddWithValue("@d",
            txtDeskripsi.Text);

            cmd.ExecuteNonQuery();

            MessageBox.Show("Obat berhasil ditambahkan!");

            conn.Close();

            LoadObat();
        }

        private void dataObat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataObat.Rows[e.RowIndex];
                 
                id_obat = Convert.ToInt32(row.Cells["id_obat"].Value);
                txtObat.Text = row.Cells["nama_obat"].Value.ToString();
                txtDeskripsi.Text = row.Cells["deskripsi"].Value.ToString();
            }
        }

        private void btnUpdateObat_Click(object sender, EventArgs e)
        {
            SqlConnection conn =
             new SqlConnection(connStr); 

            conn.Open();

            string query =
            @"UPDATE Obat
            SET
            nama_obat=@n,
            deskripsi=@d
            WHERE id_obat=@id";

            SqlCommand cmd =
            new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@n",
            txtObat.Text);

            cmd.Parameters.AddWithValue("@d",
            txtDeskripsi.Text);

            cmd.Parameters.AddWithValue("@id",
            id_obat);

            int cek =
            cmd.ExecuteNonQuery();

            MessageBox.Show(
            "Baris terupdate : " + cek);

            conn.Close();

            LoadObat();
        }

        private void btnDeleteObat_Click(object sender, EventArgs e)
        {
            SqlConnection conn =
    new SqlConnection(connStr); 

            conn.Open();

            string query =
            "DELETE FROM Obat WHERE id_obat=@id";

            SqlCommand cmd =
            new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@id",
            id_obat);

            cmd.ExecuteNonQuery();

            MessageBox.Show("Obat berhasil dihapus!");

            conn.Close();

            LoadObat();
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
            SqlConnection conn =
     new SqlConnection(connStr);

            conn.Open();

            string query =
            @"UPDATE Diagnosa
                SET
                hasil_diagnosa=@h,
                obat=@o,
                status='Selesai'
                WHERE id_diagnosa=@id";

            SqlCommand cmd =
            new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@h",
            txtHasil.Text);

            cmd.Parameters.AddWithValue("@o",
            txtObatt.Text);

            cmd.Parameters.AddWithValue("@id",
            idDiagnosa);

            cmd.ExecuteNonQuery();

            MessageBox.Show("Diagnosa berhasil dikonfirmasi!");

            conn.Close();

            LoadDiagnosa();
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
            SqlConnection conn =
     new SqlConnection(connStr);

            conn.Open();

            string query =
            "DELETE FROM Diagnosa WHERE id_diagnosa=@id";

            SqlCommand cmd =
            new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@id",
            idDiagnosa);

            int cek = cmd.ExecuteNonQuery();

            MessageBox.Show(
            "Data terhapus : " + cek);

            conn.Close();

            LoadDiagnosa();
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
                row.Cells[0].Value);

                txtObat.Text =
                row.Cells[1].Value.ToString();

                txtDeskripsi.Text =
                row.Cells[2].Value.ToString();
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
            Color.DarkGray;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            LoadDiagnosa();

            this.BackColor =
            Color.White;

            MessageBox.Show(
            "Sistem berhasil dipulihkan!");
        }
    }
    
}
