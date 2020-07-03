namespace V3
{
    partial class Form1
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
            System.Windows.Forms.Label imeLabel;
            System.Windows.Forms.Label prezimeLabel;
            System.Windows.Forms.Label jMBGLabel;
            System.Windows.Forms.Label mesto_rodjenjaLabel;
            System.Windows.Forms.Label godina_upisaLabel;
            System.Windows.Forms.Label smerLabel;
            System.Windows.Forms.Label status_budzetaLabel;
            System.Windows.Forms.Label broj_indeksaLabel;
            System.Windows.Forms.Label upisana_godinaLabel;
            System.Windows.Forms.Label datum_rodjenjaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.finalnabazaV1DataSet = new V3.finalnabazaV1DataSet();
            this.izbor_GodinaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.izbor_GodinaTableAdapter = new V3.finalnabazaV1DataSetTableAdapters.Izbor_GodinaTableAdapter();
            this.tableAdapterManager = new V3.finalnabazaV1DataSetTableAdapters.TableAdapterManager();
            this.izbor_GodinaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.izbor_GodinaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.izbor_GodinaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeTextBox = new System.Windows.Forms.TextBox();
            this.prezimeTextBox = new System.Windows.Forms.TextBox();
            this.jMBGTextBox = new System.Windows.Forms.TextBox();
            this.mesto_rodjenjaTextBox = new System.Windows.Forms.TextBox();
            this.godina_upisaTextBox = new System.Windows.Forms.TextBox();
            this.smerComboBox = new System.Windows.Forms.ComboBox();
            this.status_budzetaCheckBox = new System.Windows.Forms.CheckBox();
            this.broj_indeksaTextBox = new System.Windows.Forms.TextBox();
            this.upisana_godinaComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.datum_rodjenjaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            imeLabel = new System.Windows.Forms.Label();
            prezimeLabel = new System.Windows.Forms.Label();
            jMBGLabel = new System.Windows.Forms.Label();
            mesto_rodjenjaLabel = new System.Windows.Forms.Label();
            godina_upisaLabel = new System.Windows.Forms.Label();
            smerLabel = new System.Windows.Forms.Label();
            status_budzetaLabel = new System.Windows.Forms.Label();
            broj_indeksaLabel = new System.Windows.Forms.Label();
            upisana_godinaLabel = new System.Windows.Forms.Label();
            datum_rodjenjaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.finalnabazaV1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.izbor_GodinaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.izbor_GodinaBindingNavigator)).BeginInit();
            this.izbor_GodinaBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.izbor_GodinaDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // imeLabel
            // 
            imeLabel.AutoSize = true;
            imeLabel.Location = new System.Drawing.Point(6, 21);
            imeLabel.Name = "imeLabel";
            imeLabel.Size = new System.Drawing.Size(27, 13);
            imeLabel.TabIndex = 2;
            imeLabel.Text = "Ime:";
            // 
            // prezimeLabel
            // 
            prezimeLabel.AutoSize = true;
            prezimeLabel.Location = new System.Drawing.Point(203, 21);
            prezimeLabel.Name = "prezimeLabel";
            prezimeLabel.Size = new System.Drawing.Size(47, 13);
            prezimeLabel.TabIndex = 4;
            prezimeLabel.Text = "Prezime:";
            // 
            // jMBGLabel
            // 
            jMBGLabel.AutoSize = true;
            jMBGLabel.Location = new System.Drawing.Point(85, 132);
            jMBGLabel.Name = "jMBGLabel";
            jMBGLabel.Size = new System.Drawing.Size(39, 13);
            jMBGLabel.TabIndex = 6;
            jMBGLabel.Text = "JMBG:";
            // 
            // mesto_rodjenjaLabel
            // 
            mesto_rodjenjaLabel.AutoSize = true;
            mesto_rodjenjaLabel.Location = new System.Drawing.Point(206, 77);
            mesto_rodjenjaLabel.Name = "mesto_rodjenjaLabel";
            mesto_rodjenjaLabel.Size = new System.Drawing.Size(79, 13);
            mesto_rodjenjaLabel.TabIndex = 10;
            mesto_rodjenjaLabel.Text = "Mesto rodjenja:";
            // 
            // godina_upisaLabel
            // 
            godina_upisaLabel.AutoSize = true;
            godina_upisaLabel.Location = new System.Drawing.Point(40, 77);
            godina_upisaLabel.Name = "godina_upisaLabel";
            godina_upisaLabel.Size = new System.Drawing.Size(72, 13);
            godina_upisaLabel.TabIndex = 12;
            godina_upisaLabel.Text = "Godina upisa:";
            // 
            // smerLabel
            // 
            smerLabel.AutoSize = true;
            smerLabel.Location = new System.Drawing.Point(35, 29);
            smerLabel.Name = "smerLabel";
            smerLabel.Size = new System.Drawing.Size(34, 13);
            smerLabel.TabIndex = 14;
            smerLabel.Text = "Smer:";
            // 
            // status_budzetaLabel
            // 
            status_budzetaLabel.AutoSize = true;
            status_budzetaLabel.Location = new System.Drawing.Point(336, 99);
            status_budzetaLabel.Name = "status_budzetaLabel";
            status_budzetaLabel.Size = new System.Drawing.Size(81, 13);
            status_budzetaLabel.TabIndex = 16;
            status_budzetaLabel.Text = "Status budzeta:";
            // 
            // broj_indeksaLabel
            // 
            broj_indeksaLabel.AutoSize = true;
            broj_indeksaLabel.Location = new System.Drawing.Point(305, 32);
            broj_indeksaLabel.Name = "broj_indeksaLabel";
            broj_indeksaLabel.Size = new System.Drawing.Size(68, 13);
            broj_indeksaLabel.TabIndex = 18;
            broj_indeksaLabel.Text = "Broj indeksa:";
            // 
            // upisana_godinaLabel
            // 
            upisana_godinaLabel.AutoSize = true;
            upisana_godinaLabel.Location = new System.Drawing.Point(7, 130);
            upisana_godinaLabel.Name = "upisana_godinaLabel";
            upisana_godinaLabel.Size = new System.Drawing.Size(84, 13);
            upisana_godinaLabel.TabIndex = 20;
            upisana_godinaLabel.Text = "Upisana godina:";
            // 
            // datum_rodjenjaLabel
            // 
            datum_rodjenjaLabel.AutoSize = true;
            datum_rodjenjaLabel.Location = new System.Drawing.Point(0, 81);
            datum_rodjenjaLabel.Name = "datum_rodjenjaLabel";
            datum_rodjenjaLabel.Size = new System.Drawing.Size(81, 13);
            datum_rodjenjaLabel.TabIndex = 10;
            datum_rodjenjaLabel.Text = "Datum rodjenja:";
            // 
            // finalnabazaV1DataSet
            // 
            this.finalnabazaV1DataSet.DataSetName = "finalnabazaV1DataSet";
            this.finalnabazaV1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // izbor_GodinaBindingSource
            // 
            this.izbor_GodinaBindingSource.DataMember = "Izbor_Godina";
            this.izbor_GodinaBindingSource.DataSource = this.finalnabazaV1DataSet;
            // 
            // izbor_GodinaTableAdapter
            // 
            this.izbor_GodinaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Izbor_GodinaTableAdapter = this.izbor_GodinaTableAdapter;
            this.tableAdapterManager.UpdateOrder = V3.finalnabazaV1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // izbor_GodinaBindingNavigator
            // 
            this.izbor_GodinaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.izbor_GodinaBindingNavigator.BindingSource = this.izbor_GodinaBindingSource;
            this.izbor_GodinaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.izbor_GodinaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.izbor_GodinaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bindingNavigatorDeleteItem,
            this.izbor_GodinaBindingNavigatorSaveItem});
            this.izbor_GodinaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.izbor_GodinaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.izbor_GodinaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.izbor_GodinaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.izbor_GodinaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.izbor_GodinaBindingNavigator.Name = "izbor_GodinaBindingNavigator";
            this.izbor_GodinaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.izbor_GodinaBindingNavigator.Size = new System.Drawing.Size(1045, 25);
            this.izbor_GodinaBindingNavigator.TabIndex = 0;
            this.izbor_GodinaBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
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
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // izbor_GodinaBindingNavigatorSaveItem
            // 
            this.izbor_GodinaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.izbor_GodinaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("izbor_GodinaBindingNavigatorSaveItem.Image")));
            this.izbor_GodinaBindingNavigatorSaveItem.Name = "izbor_GodinaBindingNavigatorSaveItem";
            this.izbor_GodinaBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.izbor_GodinaBindingNavigatorSaveItem.Text = "Save Data";
            this.izbor_GodinaBindingNavigatorSaveItem.Click += new System.EventHandler(this.izbor_GodinaBindingNavigatorSaveItem_Click);
            // 
            // izbor_GodinaDataGridView
            // 
            this.izbor_GodinaDataGridView.AllowUserToAddRows = false;
            this.izbor_GodinaDataGridView.AllowUserToDeleteRows = false;
            this.izbor_GodinaDataGridView.AutoGenerateColumns = false;
            this.izbor_GodinaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.izbor_GodinaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.izbor_GodinaDataGridView.DataSource = this.izbor_GodinaBindingSource;
            this.izbor_GodinaDataGridView.Location = new System.Drawing.Point(0, 217);
            this.izbor_GodinaDataGridView.Name = "izbor_GodinaDataGridView";
            this.izbor_GodinaDataGridView.ReadOnly = true;
            this.izbor_GodinaDataGridView.Size = new System.Drawing.Size(1045, 220);
            this.izbor_GodinaDataGridView.TabIndex = 1;
            this.izbor_GodinaDataGridView.TabStop = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Redni_broj";
            this.dataGridViewTextBoxColumn1.HeaderText = "Redni_broj";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Ime";
            this.dataGridViewTextBoxColumn2.HeaderText = "Ime";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Prezime";
            this.dataGridViewTextBoxColumn3.HeaderText = "Prezime";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "JMBG";
            this.dataGridViewTextBoxColumn4.HeaderText = "JMBG";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Datum_rodjenja";
            this.dataGridViewTextBoxColumn5.HeaderText = "Datum_rodjenja";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Mesto_rodjenja";
            this.dataGridViewTextBoxColumn6.HeaderText = "Mesto_rodjenja";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Godina_upisa";
            this.dataGridViewTextBoxColumn7.HeaderText = "Godina_upisa";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Smer";
            this.dataGridViewTextBoxColumn8.HeaderText = "Smer";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Status_budzeta";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Status_budzeta";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Broj_indeksa";
            this.dataGridViewTextBoxColumn9.HeaderText = "Broj_indeksa";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Upisana_godina";
            this.dataGridViewTextBoxColumn10.HeaderText = "Upisana_godina";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // imeTextBox
            // 
            this.imeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.izbor_GodinaBindingSource, "Ime", true));
            this.imeTextBox.Location = new System.Drawing.Point(53, 21);
            this.imeTextBox.Name = "imeTextBox";
            this.imeTextBox.Size = new System.Drawing.Size(135, 20);
            this.imeTextBox.TabIndex = 1;
            // 
            // prezimeTextBox
            // 
            this.prezimeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.izbor_GodinaBindingSource, "Prezime", true));
            this.prezimeTextBox.Location = new System.Drawing.Point(256, 18);
            this.prezimeTextBox.Name = "prezimeTextBox";
            this.prezimeTextBox.Size = new System.Drawing.Size(135, 20);
            this.prezimeTextBox.TabIndex = 2;
            // 
            // jMBGTextBox
            // 
            this.jMBGTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.izbor_GodinaBindingSource, "JMBG", true));
            this.jMBGTextBox.Location = new System.Drawing.Point(130, 129);
            this.jMBGTextBox.Name = "jMBGTextBox";
            this.jMBGTextBox.Size = new System.Drawing.Size(167, 20);
            this.jMBGTextBox.TabIndex = 5;
            // 
            // mesto_rodjenjaTextBox
            // 
            this.mesto_rodjenjaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.izbor_GodinaBindingSource, "Mesto_rodjenja", true));
            this.mesto_rodjenjaTextBox.Location = new System.Drawing.Point(291, 74);
            this.mesto_rodjenjaTextBox.Name = "mesto_rodjenjaTextBox";
            this.mesto_rodjenjaTextBox.Size = new System.Drawing.Size(100, 20);
            this.mesto_rodjenjaTextBox.TabIndex = 4;
            // 
            // godina_upisaTextBox
            // 
            this.godina_upisaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.izbor_GodinaBindingSource, "Godina_upisa", true));
            this.godina_upisaTextBox.Location = new System.Drawing.Point(118, 74);
            this.godina_upisaTextBox.Name = "godina_upisaTextBox";
            this.godina_upisaTextBox.Size = new System.Drawing.Size(100, 20);
            this.godina_upisaTextBox.TabIndex = 13;
            this.godina_upisaTextBox.TabStop = false;
            // 
            // smerComboBox
            // 
            this.smerComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.izbor_GodinaBindingSource, "Smer", true));
            this.smerComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.smerComboBox.FormattingEnabled = true;
            this.smerComboBox.Items.AddRange(new object[] {
            "Informatika",
            "Arhitektura",
            "Masinstvo",
            "Turizam",
            "Menadzment"});
            this.smerComboBox.Location = new System.Drawing.Point(97, 25);
            this.smerComboBox.Name = "smerComboBox";
            this.smerComboBox.Size = new System.Drawing.Size(121, 21);
            this.smerComboBox.TabIndex = 15;
            this.smerComboBox.TabStop = false;
            // 
            // status_budzetaCheckBox
            // 
            this.status_budzetaCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.izbor_GodinaBindingSource, "Status_budzeta", true));
            this.status_budzetaCheckBox.Location = new System.Drawing.Point(369, 132);
            this.status_budzetaCheckBox.Name = "status_budzetaCheckBox";
            this.status_budzetaCheckBox.Size = new System.Drawing.Size(18, 24);
            this.status_budzetaCheckBox.TabIndex = 8;
            this.status_budzetaCheckBox.UseVisualStyleBackColor = true;
            // 
            // broj_indeksaTextBox
            // 
            this.broj_indeksaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.izbor_GodinaBindingSource, "Broj_indeksa", true));
            this.broj_indeksaTextBox.Location = new System.Drawing.Point(379, 29);
            this.broj_indeksaTextBox.Name = "broj_indeksaTextBox";
            this.broj_indeksaTextBox.Size = new System.Drawing.Size(100, 20);
            this.broj_indeksaTextBox.TabIndex = 7;
            // 
            // upisana_godinaComboBox
            // 
            this.upisana_godinaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.izbor_GodinaBindingSource, "Upisana_godina", true));
            this.upisana_godinaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.upisana_godinaComboBox.FormattingEnabled = true;
            this.upisana_godinaComboBox.Items.AddRange(new object[] {
            "Prva godina",
            "Druga godina",
            "Treca godina"});
            this.upisana_godinaComboBox.Location = new System.Drawing.Point(97, 122);
            this.upisana_godinaComboBox.Name = "upisana_godinaComboBox";
            this.upisana_godinaComboBox.Size = new System.Drawing.Size(121, 21);
            this.upisana_godinaComboBox.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(datum_rodjenjaLabel);
            this.groupBox1.Controls.Add(this.datum_rodjenjaDateTimePicker);
            this.groupBox1.Controls.Add(this.prezimeTextBox);
            this.groupBox1.Controls.Add(this.imeTextBox);
            this.groupBox1.Controls.Add(imeLabel);
            this.groupBox1.Controls.Add(prezimeLabel);
            this.groupBox1.Controls.Add(this.jMBGTextBox);
            this.groupBox1.Controls.Add(jMBGLabel);
            this.groupBox1.Controls.Add(this.mesto_rodjenjaTextBox);
            this.groupBox1.Controls.Add(mesto_rodjenjaLabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(407, 183);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Licni podaci studenta";
            // 
            // datum_rodjenjaDateTimePicker
            // 
            this.datum_rodjenjaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.izbor_GodinaBindingSource, "Datum_rodjenja", true));
            this.datum_rodjenjaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datum_rodjenjaDateTimePicker.Location = new System.Drawing.Point(87, 77);
            this.datum_rodjenjaDateTimePicker.Name = "datum_rodjenjaDateTimePicker";
            this.datum_rodjenjaDateTimePicker.Size = new System.Drawing.Size(92, 20);
            this.datum_rodjenjaDateTimePicker.TabIndex = 11;
            this.datum_rodjenjaDateTimePicker.Value = new System.DateTime(2020, 6, 9, 0, 0, 0, 0);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.smerComboBox);
            this.groupBox2.Controls.Add(smerLabel);
            this.groupBox2.Controls.Add(status_budzetaLabel);
            this.groupBox2.Controls.Add(broj_indeksaLabel);
            this.groupBox2.Controls.Add(this.status_budzetaCheckBox);
            this.groupBox2.Controls.Add(upisana_godinaLabel);
            this.groupBox2.Controls.Add(this.broj_indeksaTextBox);
            this.groupBox2.Controls.Add(this.upisana_godinaComboBox);
            this.groupBox2.Controls.Add(this.godina_upisaTextBox);
            this.groupBox2.Controls.Add(godina_upisaLabel);
            this.groupBox2.Location = new System.Drawing.Point(487, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(546, 183);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fakultetski podaci studenta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(305, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "(Cekirati ako je student ostvario budzet)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 441);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.izbor_GodinaDataGridView);
            this.Controls.Add(this.izbor_GodinaBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "VŠSS - Program za unos studenata";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.finalnabazaV1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.izbor_GodinaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.izbor_GodinaBindingNavigator)).EndInit();
            this.izbor_GodinaBindingNavigator.ResumeLayout(false);
            this.izbor_GodinaBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.izbor_GodinaDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private finalnabazaV1DataSet finalnabazaV1DataSet;
        private System.Windows.Forms.BindingSource izbor_GodinaBindingSource;
        private finalnabazaV1DataSetTableAdapters.Izbor_GodinaTableAdapter izbor_GodinaTableAdapter;
        private finalnabazaV1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator izbor_GodinaBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton izbor_GodinaBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView izbor_GodinaDataGridView;
        private System.Windows.Forms.TextBox imeTextBox;
        private System.Windows.Forms.TextBox prezimeTextBox;
        private System.Windows.Forms.TextBox jMBGTextBox;
        private System.Windows.Forms.TextBox mesto_rodjenjaTextBox;
        private System.Windows.Forms.TextBox godina_upisaTextBox;
        private System.Windows.Forms.ComboBox smerComboBox;
        private System.Windows.Forms.CheckBox status_budzetaCheckBox;
        private System.Windows.Forms.TextBox broj_indeksaTextBox;
        private System.Windows.Forms.ComboBox upisana_godinaComboBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DateTimePicker datum_rodjenjaDateTimePicker;
    }
}

