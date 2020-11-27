namespace PIMdesktop
{
    partial class Cadastro
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
            System.Windows.Forms.Label nOMELabel;
            System.Windows.Forms.Label tELEFONELabel;
            System.Windows.Forms.Label eMAILLabel;
            System.Windows.Forms.Label cARTEIRALabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastro));
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dBpimDataSet = new PIMdesktop.DBpimDataSet();
            this.tBclientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tBclientesTableAdapter = new PIMdesktop.DBpimDataSetTableAdapters.TBclientesTableAdapter();
            this.tableAdapterManager = new PIMdesktop.DBpimDataSetTableAdapters.TableAdapterManager();
            this.tBclientesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.tBclientesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.nOMETextBox = new System.Windows.Forms.TextBox();
            this.tELEFONETextBox = new System.Windows.Forms.TextBox();
            this.eMAILTextBox = new System.Windows.Forms.TextBox();
            this.cARTEIRATextBox = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            nOMELabel = new System.Windows.Forms.Label();
            tELEFONELabel = new System.Windows.Forms.Label();
            eMAILLabel = new System.Windows.Forms.Label();
            cARTEIRALabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dBpimDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBclientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBclientesBindingNavigator)).BeginInit();
            this.tBclientesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // nOMELabel
            // 
            nOMELabel.AutoSize = true;
            nOMELabel.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nOMELabel.Location = new System.Drawing.Point(468, 209);
            nOMELabel.Name = "nOMELabel";
            nOMELabel.Size = new System.Drawing.Size(73, 22);
            nOMELabel.TabIndex = 11;
            nOMELabel.Text = "NOME:";
            // 
            // tELEFONELabel
            // 
            tELEFONELabel.AutoSize = true;
            tELEFONELabel.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tELEFONELabel.Location = new System.Drawing.Point(468, 269);
            tELEFONELabel.Name = "tELEFONELabel";
            tELEFONELabel.Size = new System.Drawing.Size(102, 22);
            tELEFONELabel.TabIndex = 13;
            tELEFONELabel.Text = "TELEFONE:";
            tELEFONELabel.Click += new System.EventHandler(this.tELEFONELabel_Click);
            // 
            // eMAILLabel
            // 
            eMAILLabel.AutoSize = true;
            eMAILLabel.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            eMAILLabel.Location = new System.Drawing.Point(468, 335);
            eMAILLabel.Name = "eMAILLabel";
            eMAILLabel.Size = new System.Drawing.Size(71, 22);
            eMAILLabel.TabIndex = 15;
            eMAILLabel.Text = "EMAIL:";
            // 
            // cARTEIRALabel
            // 
            cARTEIRALabel.AutoSize = true;
            cARTEIRALabel.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cARTEIRALabel.Location = new System.Drawing.Point(468, 396);
            cARTEIRALabel.Name = "cARTEIRALabel";
            cARTEIRALabel.Size = new System.Drawing.Size(107, 22);
            cARTEIRALabel.TabIndex = 17;
            cARTEIRALabel.Text = "CARTEIRA:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.LavenderBlush;
            this.button1.Location = new System.Drawing.Point(147, 450);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(199, 47);
            this.button1.TabIndex = 7;
            this.button1.Text = "Voltar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkOrange;
            this.label4.Location = new System.Drawing.Point(467, 59);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 34);
            this.label4.TabIndex = 8;
            this.label4.Text = "Cadastro";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dBpimDataSet
            // 
            this.dBpimDataSet.DataSetName = "DBpimDataSet";
            this.dBpimDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBclientesBindingSource
            // 
            this.tBclientesBindingSource.DataMember = "TBclientes";
            this.tBclientesBindingSource.DataSource = this.dBpimDataSet;
            // 
            // tBclientesTableAdapter
            // 
            this.tBclientesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TBclientesTableAdapter = this.tBclientesTableAdapter;
            this.tableAdapterManager.UpdateOrder = PIMdesktop.DBpimDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tBclientesBindingNavigator
            // 
            this.tBclientesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tBclientesBindingNavigator.BindingSource = this.tBclientesBindingSource;
            this.tBclientesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tBclientesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tBclientesBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tBclientesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tBclientesBindingNavigatorSaveItem});
            this.tBclientesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tBclientesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tBclientesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tBclientesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tBclientesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tBclientesBindingNavigator.Name = "tBclientesBindingNavigator";
            this.tBclientesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tBclientesBindingNavigator.Size = new System.Drawing.Size(1072, 27);
            this.tBclientesBindingNavigator.TabIndex = 9;
            this.tBclientesBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(48, 24);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
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
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // tBclientesBindingNavigatorSaveItem
            // 
            this.tBclientesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tBclientesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tBclientesBindingNavigatorSaveItem.Image")));
            this.tBclientesBindingNavigatorSaveItem.Name = "tBclientesBindingNavigatorSaveItem";
            this.tBclientesBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.tBclientesBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.tBclientesBindingNavigatorSaveItem.Click += new System.EventHandler(this.tBclientesBindingNavigatorSaveItem_Click);
            // 
            // nOMETextBox
            // 
            this.nOMETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tBclientesBindingSource, "NOME", true));
            this.nOMETextBox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nOMETextBox.Location = new System.Drawing.Point(645, 203);
            this.nOMETextBox.Name = "nOMETextBox";
            this.nOMETextBox.Size = new System.Drawing.Size(354, 26);
            this.nOMETextBox.TabIndex = 12;
            this.nOMETextBox.TextChanged += new System.EventHandler(this.nOMETextBox_TextChanged);
            // 
            // tELEFONETextBox
            // 
            this.tELEFONETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tBclientesBindingSource, "TELEFONE", true));
            this.tELEFONETextBox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tELEFONETextBox.Location = new System.Drawing.Point(645, 263);
            this.tELEFONETextBox.Name = "tELEFONETextBox";
            this.tELEFONETextBox.Size = new System.Drawing.Size(354, 26);
            this.tELEFONETextBox.TabIndex = 14;
            // 
            // eMAILTextBox
            // 
            this.eMAILTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tBclientesBindingSource, "EMAIL", true));
            this.eMAILTextBox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eMAILTextBox.Location = new System.Drawing.Point(645, 329);
            this.eMAILTextBox.Name = "eMAILTextBox";
            this.eMAILTextBox.Size = new System.Drawing.Size(354, 26);
            this.eMAILTextBox.TabIndex = 16;
            // 
            // cARTEIRATextBox
            // 
            this.cARTEIRATextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tBclientesBindingSource, "CARTEIRA", true));
            this.cARTEIRATextBox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cARTEIRATextBox.Location = new System.Drawing.Point(936, 394);
            this.cARTEIRATextBox.Name = "cARTEIRATextBox";
            this.cARTEIRATextBox.Size = new System.Drawing.Size(63, 26);
            this.cARTEIRATextBox.TabIndex = 18;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::PIMdesktop.Properties.Resources.driver_license1;
            this.pictureBox4.Location = new System.Drawing.Point(76, 159);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(341, 283);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 589);
            this.Controls.Add(nOMELabel);
            this.Controls.Add(this.nOMETextBox);
            this.Controls.Add(tELEFONELabel);
            this.Controls.Add(this.tELEFONETextBox);
            this.Controls.Add(eMAILLabel);
            this.Controls.Add(this.eMAILTextBox);
            this.Controls.Add(cARTEIRALabel);
            this.Controls.Add(this.cARTEIRATextBox);
            this.Controls.Add(this.tBclientesBindingNavigator);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Cadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro";
            this.Load += new System.EventHandler(this.Cadastro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dBpimDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBclientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBclientesBindingNavigator)).EndInit();
            this.tBclientesBindingNavigator.ResumeLayout(false);
            this.tBclientesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private DBpimDataSet dBpimDataSet;
        private System.Windows.Forms.BindingSource tBclientesBindingSource;
        private DBpimDataSetTableAdapters.TBclientesTableAdapter tBclientesTableAdapter;
        private DBpimDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tBclientesBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tBclientesBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox nOMETextBox;
        private System.Windows.Forms.TextBox tELEFONETextBox;
        private System.Windows.Forms.TextBox eMAILTextBox;
        private System.Windows.Forms.TextBox cARTEIRATextBox;
    }
}