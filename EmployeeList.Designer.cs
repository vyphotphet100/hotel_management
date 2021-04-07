
namespace Hotel_Manager
{
    partial class EmployeeList
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeList));
            this.panelEmployeeList = new System.Windows.Forms.Panel();
            this.gunaDataGridView1 = new Guna.UI.WinForms.GunaDataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.stdBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.myDBDataSet = new Hotel_Manager.myDBDataSet();
            this.GunaAdvenceButton4 = new Guna.UI.WinForms.GunaAdvenceButton();
            this.GunaAdvenceButton1 = new Guna.UI.WinForms.GunaAdvenceButton();
            this.GunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.GunaPictureBox2 = new Guna.UI.WinForms.GunaPictureBox();
            this.GunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.buttonMorningShift = new Guna.UI.WinForms.GunaAdvenceButton();
            this.GunaButton2 = new Guna.UI.WinForms.GunaButton();
            this.GunaCirclePictureBox1 = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.GunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.buttonViewAll = new Guna.UI.WinForms.GunaAdvenceButton();
            this.stdTableAdapter = new Hotel_Manager.myDBDataSetTableAdapters.stdTableAdapter();
            this.panelEmployeeList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stdBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GunaPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GunaPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GunaCirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEmployeeList
            // 
            this.panelEmployeeList.Controls.Add(this.gunaDataGridView1);
            this.panelEmployeeList.Controls.Add(this.GunaAdvenceButton4);
            this.panelEmployeeList.Controls.Add(this.GunaAdvenceButton1);
            this.panelEmployeeList.Controls.Add(this.GunaPictureBox1);
            this.panelEmployeeList.Controls.Add(this.GunaPictureBox2);
            this.panelEmployeeList.Controls.Add(this.GunaLabel2);
            this.panelEmployeeList.Controls.Add(this.buttonMorningShift);
            this.panelEmployeeList.Controls.Add(this.GunaButton2);
            this.panelEmployeeList.Controls.Add(this.GunaCirclePictureBox1);
            this.panelEmployeeList.Controls.Add(this.GunaLabel6);
            this.panelEmployeeList.Controls.Add(this.buttonViewAll);
            this.panelEmployeeList.Location = new System.Drawing.Point(0, 0);
            this.panelEmployeeList.Name = "panelEmployeeList";
            this.panelEmployeeList.Size = new System.Drawing.Size(820, 698);
            this.panelEmployeeList.TabIndex = 0;
            // 
            // gunaDataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.gunaDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gunaDataGridView1.AutoGenerateColumns = false;
            this.gunaDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gunaDataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.gunaDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaDataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gunaDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gunaDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gunaDataGridView1.ColumnHeadersHeight = 21;
            this.gunaDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.fnameDataGridViewTextBoxColumn,
            this.lnameDataGridViewTextBoxColumn,
            this.bdateDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.pictureDataGridViewImageColumn});
            this.gunaDataGridView1.DataSource = this.stdBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gunaDataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.gunaDataGridView1.EnableHeadersVisualStyles = false;
            this.gunaDataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunaDataGridView1.Location = new System.Drawing.Point(-3, 239);
            this.gunaDataGridView1.Name = "gunaDataGridView1";
            this.gunaDataGridView1.RowHeadersVisible = false;
            this.gunaDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gunaDataGridView1.Size = new System.Drawing.Size(820, 239);
            this.gunaDataGridView1.TabIndex = 14;
            this.gunaDataGridView1.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gunaDataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gunaDataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.Height = 21;
            this.gunaDataGridView1.ThemeStyle.ReadOnly = false;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gunaDataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gunaDataGridView1.ThemeStyle.RowsStyle.Height = 22;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunaDataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // fnameDataGridViewTextBoxColumn
            // 
            this.fnameDataGridViewTextBoxColumn.DataPropertyName = "fname";
            this.fnameDataGridViewTextBoxColumn.HeaderText = "fname";
            this.fnameDataGridViewTextBoxColumn.Name = "fnameDataGridViewTextBoxColumn";
            // 
            // lnameDataGridViewTextBoxColumn
            // 
            this.lnameDataGridViewTextBoxColumn.DataPropertyName = "lname";
            this.lnameDataGridViewTextBoxColumn.HeaderText = "lname";
            this.lnameDataGridViewTextBoxColumn.Name = "lnameDataGridViewTextBoxColumn";
            // 
            // bdateDataGridViewTextBoxColumn
            // 
            this.bdateDataGridViewTextBoxColumn.DataPropertyName = "bdate";
            this.bdateDataGridViewTextBoxColumn.HeaderText = "bdate";
            this.bdateDataGridViewTextBoxColumn.Name = "bdateDataGridViewTextBoxColumn";
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "phone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // pictureDataGridViewImageColumn
            // 
            this.pictureDataGridViewImageColumn.DataPropertyName = "picture";
            this.pictureDataGridViewImageColumn.HeaderText = "picture";
            this.pictureDataGridViewImageColumn.Name = "pictureDataGridViewImageColumn";
            // 
            // stdBindingSource
            // 
            this.stdBindingSource.DataMember = "std";
            this.stdBindingSource.DataSource = this.myDBDataSet;
            // 
            // myDBDataSet
            // 
            this.myDBDataSet.DataSetName = "myDBDataSet";
            this.myDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // GunaAdvenceButton4
            // 
            this.GunaAdvenceButton4.AnimationHoverSpeed = 0.07F;
            this.GunaAdvenceButton4.AnimationSpeed = 0.03F;
            this.GunaAdvenceButton4.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(92)))));
            this.GunaAdvenceButton4.BorderColor = System.Drawing.Color.Black;
            this.GunaAdvenceButton4.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.GunaAdvenceButton4.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(72)))), ((int)(((byte)(114)))));
            this.GunaAdvenceButton4.CheckedBorderColor = System.Drawing.Color.Black;
            this.GunaAdvenceButton4.CheckedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(209)))), ((int)(((byte)(218)))));
            this.GunaAdvenceButton4.CheckedImage = ((System.Drawing.Image)(resources.GetObject("GunaAdvenceButton4.CheckedImage")));
            this.GunaAdvenceButton4.CheckedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.GunaAdvenceButton4.DialogResult = System.Windows.Forms.DialogResult.None;
            this.GunaAdvenceButton4.FocusedColor = System.Drawing.Color.Empty;
            this.GunaAdvenceButton4.Font = new System.Drawing.Font("Segoe UI Semibold", 8F);
            this.GunaAdvenceButton4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(209)))), ((int)(((byte)(218)))));
            this.GunaAdvenceButton4.Image = ((System.Drawing.Image)(resources.GetObject("GunaAdvenceButton4.Image")));
            this.GunaAdvenceButton4.ImageOffsetX = 15;
            this.GunaAdvenceButton4.ImageSize = new System.Drawing.Size(16, 16);
            this.GunaAdvenceButton4.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(92)))));
            this.GunaAdvenceButton4.LineLeft = 5;
            this.GunaAdvenceButton4.Location = new System.Drawing.Point(498, 25);
            this.GunaAdvenceButton4.Name = "GunaAdvenceButton4";
            this.GunaAdvenceButton4.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(72)))), ((int)(((byte)(114)))));
            this.GunaAdvenceButton4.OnHoverBorderColor = System.Drawing.Color.Black;
            this.GunaAdvenceButton4.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(209)))), ((int)(((byte)(218)))));
            this.GunaAdvenceButton4.OnHoverImage = null;
            this.GunaAdvenceButton4.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(72)))), ((int)(((byte)(114)))));
            this.GunaAdvenceButton4.OnPressedColor = System.Drawing.Color.Black;
            this.GunaAdvenceButton4.OnPressedDepth = 0;
            this.GunaAdvenceButton4.Size = new System.Drawing.Size(180, 50);
            this.GunaAdvenceButton4.TabIndex = 13;
            this.GunaAdvenceButton4.Text = "PERMISSIONS";
            // 
            // GunaAdvenceButton1
            // 
            this.GunaAdvenceButton1.AnimationHoverSpeed = 0.07F;
            this.GunaAdvenceButton1.AnimationSpeed = 0.03F;
            this.GunaAdvenceButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(92)))));
            this.GunaAdvenceButton1.BorderColor = System.Drawing.Color.Black;
            this.GunaAdvenceButton1.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.GunaAdvenceButton1.Checked = true;
            this.GunaAdvenceButton1.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(72)))), ((int)(((byte)(114)))));
            this.GunaAdvenceButton1.CheckedBorderColor = System.Drawing.Color.Black;
            this.GunaAdvenceButton1.CheckedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(209)))), ((int)(((byte)(218)))));
            this.GunaAdvenceButton1.CheckedImage = ((System.Drawing.Image)(resources.GetObject("GunaAdvenceButton1.CheckedImage")));
            this.GunaAdvenceButton1.CheckedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.GunaAdvenceButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.GunaAdvenceButton1.FocusedColor = System.Drawing.Color.Empty;
            this.GunaAdvenceButton1.Font = new System.Drawing.Font("Segoe UI Semibold", 8F);
            this.GunaAdvenceButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(209)))), ((int)(((byte)(218)))));
            this.GunaAdvenceButton1.Image = ((System.Drawing.Image)(resources.GetObject("GunaAdvenceButton1.Image")));
            this.GunaAdvenceButton1.ImageOffsetX = 15;
            this.GunaAdvenceButton1.ImageSize = new System.Drawing.Size(16, 16);
            this.GunaAdvenceButton1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(92)))));
            this.GunaAdvenceButton1.LineLeft = 5;
            this.GunaAdvenceButton1.Location = new System.Drawing.Point(658, 25);
            this.GunaAdvenceButton1.Name = "GunaAdvenceButton1";
            this.GunaAdvenceButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(72)))), ((int)(((byte)(114)))));
            this.GunaAdvenceButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.GunaAdvenceButton1.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(209)))), ((int)(((byte)(218)))));
            this.GunaAdvenceButton1.OnHoverImage = null;
            this.GunaAdvenceButton1.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(72)))), ((int)(((byte)(114)))));
            this.GunaAdvenceButton1.OnPressedColor = System.Drawing.Color.Black;
            this.GunaAdvenceButton1.OnPressedDepth = 0;
            this.GunaAdvenceButton1.Size = new System.Drawing.Size(180, 50);
            this.GunaAdvenceButton1.TabIndex = 12;
            this.GunaAdvenceButton1.Text = "DATABASE";
            // 
            // GunaPictureBox1
            // 
            this.GunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.GunaPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("GunaPictureBox1.Image")));
            this.GunaPictureBox1.Location = new System.Drawing.Point(225, 114);
            this.GunaPictureBox1.Name = "GunaPictureBox1";
            this.GunaPictureBox1.Size = new System.Drawing.Size(18, 18);
            this.GunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.GunaPictureBox1.TabIndex = 11;
            this.GunaPictureBox1.TabStop = false;
            // 
            // GunaPictureBox2
            // 
            this.GunaPictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GunaPictureBox2.BaseColor = System.Drawing.Color.White;
            this.GunaPictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("GunaPictureBox2.Image")));
            this.GunaPictureBox2.Location = new System.Drawing.Point(207, 114);
            this.GunaPictureBox2.Name = "GunaPictureBox2";
            this.GunaPictureBox2.Size = new System.Drawing.Size(12, 12);
            this.GunaPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.GunaPictureBox2.TabIndex = 2;
            this.GunaPictureBox2.TabStop = false;
            // 
            // GunaLabel2
            // 
            this.GunaLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GunaLabel2.AutoSize = true;
            this.GunaLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 8F);
            this.GunaLabel2.ForeColor = System.Drawing.Color.Gray;
            this.GunaLabel2.Location = new System.Drawing.Point(145, 114);
            this.GunaLabel2.Name = "GunaLabel2";
            this.GunaLabel2.Size = new System.Drawing.Size(35, 13);
            this.GunaLabel2.TabIndex = 2;
            this.GunaLabel2.Text = "JHON";
            // 
            // buttonMorningShift
            // 
            this.buttonMorningShift.AnimationHoverSpeed = 0.07F;
            this.buttonMorningShift.AnimationSpeed = 0.03F;
            this.buttonMorningShift.BackColor = System.Drawing.Color.Transparent;
            this.buttonMorningShift.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.buttonMorningShift.BorderColor = System.Drawing.Color.Black;
            this.buttonMorningShift.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.buttonMorningShift.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.buttonMorningShift.CheckedBorderColor = System.Drawing.Color.Black;
            this.buttonMorningShift.CheckedForeColor = System.Drawing.Color.White;
            this.buttonMorningShift.CheckedImage = null;
            this.buttonMorningShift.CheckedLineColor = System.Drawing.Color.DimGray;
            this.buttonMorningShift.DialogResult = System.Windows.Forms.DialogResult.None;
            this.buttonMorningShift.FocusedColor = System.Drawing.Color.Empty;
            this.buttonMorningShift.Font = new System.Drawing.Font("Segoe UI Semibold", 8.2F);
            this.buttonMorningShift.ForeColor = System.Drawing.Color.DimGray;
            this.buttonMorningShift.Image = null;
            this.buttonMorningShift.ImageSize = new System.Drawing.Size(20, 20);
            this.buttonMorningShift.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.buttonMorningShift.Location = new System.Drawing.Point(42, 100);
            this.buttonMorningShift.Name = "buttonMorningShift";
            this.buttonMorningShift.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.buttonMorningShift.OnHoverBorderColor = System.Drawing.Color.Black;
            this.buttonMorningShift.OnHoverForeColor = System.Drawing.Color.White;
            this.buttonMorningShift.OnHoverImage = null;
            this.buttonMorningShift.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.buttonMorningShift.OnPressedColor = System.Drawing.Color.Black;
            this.buttonMorningShift.Radius = 13;
            this.buttonMorningShift.Size = new System.Drawing.Size(55, 27);
            this.buttonMorningShift.TabIndex = 10;
            this.buttonMorningShift.Text = "TYPE";
            this.buttonMorningShift.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // GunaButton2
            // 
            this.GunaButton2.AnimationHoverSpeed = 0.07F;
            this.GunaButton2.AnimationSpeed = 0.03F;
            this.GunaButton2.BackColor = System.Drawing.Color.Transparent;
            this.GunaButton2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.GunaButton2.BorderColor = System.Drawing.Color.Black;
            this.GunaButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.GunaButton2.FocusedColor = System.Drawing.Color.Empty;
            this.GunaButton2.Font = new System.Drawing.Font("Segoe UI Semibold", 8F);
            this.GunaButton2.ForeColor = System.Drawing.Color.White;
            this.GunaButton2.Image = ((System.Drawing.Image)(resources.GetObject("GunaButton2.Image")));
            this.GunaButton2.ImageSize = new System.Drawing.Size(12, 12);
            this.GunaButton2.Location = new System.Drawing.Point(253, 48);
            this.GunaButton2.Name = "GunaButton2";
            this.GunaButton2.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(166)))), ((int)(((byte)(213)))));
            this.GunaButton2.OnHoverBorderColor = System.Drawing.Color.Black;
            this.GunaButton2.OnHoverForeColor = System.Drawing.Color.White;
            this.GunaButton2.OnHoverImage = null;
            this.GunaButton2.OnPressedColor = System.Drawing.Color.Black;
            this.GunaButton2.Radius = 3;
            this.GunaButton2.Size = new System.Drawing.Size(121, 40);
            this.GunaButton2.TabIndex = 8;
            this.GunaButton2.Text = "CREATE ASSET";
            // 
            // GunaCirclePictureBox1
            // 
            this.GunaCirclePictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GunaCirclePictureBox1.BaseColor = System.Drawing.Color.White;
            this.GunaCirclePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("GunaCirclePictureBox1.Image")));
            this.GunaCirclePictureBox1.Location = new System.Drawing.Point(422, 43);
            this.GunaCirclePictureBox1.Name = "GunaCirclePictureBox1";
            this.GunaCirclePictureBox1.Size = new System.Drawing.Size(32, 32);
            this.GunaCirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GunaCirclePictureBox1.TabIndex = 0;
            this.GunaCirclePictureBox1.TabStop = false;
            this.GunaCirclePictureBox1.UseTransfarantBackground = false;
            // 
            // GunaLabel6
            // 
            this.GunaLabel6.AutoSize = true;
            this.GunaLabel6.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.GunaLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(92)))));
            this.GunaLabel6.Location = new System.Drawing.Point(50, 48);
            this.GunaLabel6.Name = "GunaLabel6";
            this.GunaLabel6.Size = new System.Drawing.Size(63, 13);
            this.GunaLabel6.TabIndex = 4;
            this.GunaLabel6.Text = "COMPANY";
            // 
            // buttonViewAll
            // 
            this.buttonViewAll.AnimationHoverSpeed = 0.07F;
            this.buttonViewAll.AnimationSpeed = 0.03F;
            this.buttonViewAll.BackColor = System.Drawing.Color.Transparent;
            this.buttonViewAll.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.buttonViewAll.BorderColor = System.Drawing.Color.Black;
            this.buttonViewAll.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.buttonViewAll.Checked = true;
            this.buttonViewAll.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.buttonViewAll.CheckedBorderColor = System.Drawing.Color.Black;
            this.buttonViewAll.CheckedForeColor = System.Drawing.Color.White;
            this.buttonViewAll.CheckedImage = null;
            this.buttonViewAll.CheckedLineColor = System.Drawing.Color.DimGray;
            this.buttonViewAll.DialogResult = System.Windows.Forms.DialogResult.None;
            this.buttonViewAll.FocusedColor = System.Drawing.Color.Empty;
            this.buttonViewAll.Font = new System.Drawing.Font("Segoe UI Semibold", 8.2F);
            this.buttonViewAll.ForeColor = System.Drawing.Color.DimGray;
            this.buttonViewAll.Image = null;
            this.buttonViewAll.ImageSize = new System.Drawing.Size(20, 20);
            this.buttonViewAll.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.buttonViewAll.Location = new System.Drawing.Point(133, 48);
            this.buttonViewAll.Name = "buttonViewAll";
            this.buttonViewAll.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.buttonViewAll.OnHoverBorderColor = System.Drawing.Color.Black;
            this.buttonViewAll.OnHoverForeColor = System.Drawing.Color.White;
            this.buttonViewAll.OnHoverImage = null;
            this.buttonViewAll.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.buttonViewAll.OnPressedColor = System.Drawing.Color.Black;
            this.buttonViewAll.Radius = 13;
            this.buttonViewAll.Size = new System.Drawing.Size(76, 27);
            this.buttonViewAll.TabIndex = 2;
            this.buttonViewAll.Text = "VIEW ALL";
            this.buttonViewAll.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // stdTableAdapter
            // 
            this.stdTableAdapter.ClearBeforeFill = true;
            // 
            // EmployeeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelEmployeeList);
            this.Name = "EmployeeList";
            this.Size = new System.Drawing.Size(823, 698);
            this.panelEmployeeList.ResumeLayout(false);
            this.panelEmployeeList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stdBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GunaPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GunaPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GunaCirclePictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelEmployeeList;
        internal Guna.UI.WinForms.GunaAdvenceButton buttonViewAll;
        internal Guna.UI.WinForms.GunaButton GunaButton2;
        internal Guna.UI.WinForms.GunaLabel GunaLabel6;
        internal Guna.UI.WinForms.GunaPictureBox GunaPictureBox1;
        internal Guna.UI.WinForms.GunaPictureBox GunaPictureBox2;
        internal Guna.UI.WinForms.GunaLabel GunaLabel2;
        internal Guna.UI.WinForms.GunaAdvenceButton buttonMorningShift;
        internal Guna.UI.WinForms.GunaCirclePictureBox GunaCirclePictureBox1;
        private Guna.UI.WinForms.GunaDataGridView gunaDataGridView1;
        private System.Windows.Forms.BindingSource stdBindingSource;
        private myDBDataSet myDBDataSet;
        internal Guna.UI.WinForms.GunaAdvenceButton GunaAdvenceButton4;
        internal Guna.UI.WinForms.GunaAdvenceButton GunaAdvenceButton1;
        private myDBDataSetTableAdapters.stdTableAdapter stdTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn pictureDataGridViewImageColumn;
    }
}
