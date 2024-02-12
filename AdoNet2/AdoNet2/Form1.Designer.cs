namespace AdoNet2
{
    partial class FormRecords
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRecords));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelBookName = new System.Windows.Forms.Label();
            this.labelBookAuthor = new System.Windows.Forms.Label();
            this.labelBookPage = new System.Windows.Forms.Label();
            this.labelBookPrice = new System.Windows.Forms.Label();
            this.labelPublisher = new System.Windows.Forms.Label();
            this.labelBookDate = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxPage = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxPublisher = new System.Windows.Forms.TextBox();
            this.textBoxAuthor = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.labelDelete = new System.Windows.Forms.Label();
            this.panelDelete = new System.Windows.Forms.Panel();
            this.labelDelete2 = new System.Windows.Forms.Label();
            this.panelAdd = new System.Windows.Forms.Panel();
            this.labelBookGenre = new System.Windows.Forms.Label();
            this.comboBoxBookGenre = new System.Windows.Forms.ComboBox();
            this.radioButtonNon = new System.Windows.Forms.RadioButton();
            this.labelStock = new System.Windows.Forms.Label();
            this.radioButtonExist = new System.Windows.Forms.RadioButton();
            this.panelChange = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxBookGenre2 = new System.Windows.Forms.ComboBox();
            this.labelBookGenre2 = new System.Windows.Forms.Label();
            this.radioButtonNon2 = new System.Windows.Forms.RadioButton();
            this.radioButtonExist2 = new System.Windows.Forms.RadioButton();
            this.labelStock2 = new System.Windows.Forms.Label();
            this.label_id = new System.Windows.Forms.Label();
            this.labelNo2 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.textBoxBookPublisher2 = new System.Windows.Forms.TextBox();
            this.textBoxBookPrice2 = new System.Windows.Forms.TextBox();
            this.textBoxBookPage2 = new System.Windows.Forms.TextBox();
            this.labelBookDate2 = new System.Windows.Forms.Label();
            this.textBoxBookAuthor2 = new System.Windows.Forms.TextBox();
            this.textBoxBookName2 = new System.Windows.Forms.TextBox();
            this.buttonChange = new System.Windows.Forms.Button();
            this.labelBookPublisher2 = new System.Windows.Forms.Label();
            this.labelBookPrice2 = new System.Windows.Forms.Label();
            this.labelBookPage2 = new System.Windows.Forms.Label();
            this.labelBookAuthor2 = new System.Windows.Forms.Label();
            this.labelBookName2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelDelete.SuspendLayout();
            this.panelAdd.SuspendLayout();
            this.panelChange.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter_1);
            // 
            // labelBookName
            // 
            resources.ApplyResources(this.labelBookName, "labelBookName");
            this.labelBookName.Name = "labelBookName";
            // 
            // labelBookAuthor
            // 
            resources.ApplyResources(this.labelBookAuthor, "labelBookAuthor");
            this.labelBookAuthor.Name = "labelBookAuthor";
            // 
            // labelBookPage
            // 
            resources.ApplyResources(this.labelBookPage, "labelBookPage");
            this.labelBookPage.Name = "labelBookPage";
            // 
            // labelBookPrice
            // 
            resources.ApplyResources(this.labelBookPrice, "labelBookPrice");
            this.labelBookPrice.Name = "labelBookPrice";
            // 
            // labelPublisher
            // 
            resources.ApplyResources(this.labelPublisher, "labelPublisher");
            this.labelPublisher.Name = "labelPublisher";
            // 
            // labelBookDate
            // 
            resources.ApplyResources(this.labelBookDate, "labelBookDate");
            this.labelBookDate.Name = "labelBookDate";
            // 
            // textBoxName
            // 
            resources.ApplyResources(this.textBoxName, "textBoxName");
            this.textBoxName.Name = "textBoxName";
            // 
            // textBoxPage
            // 
            resources.ApplyResources(this.textBoxPage, "textBoxPage");
            this.textBoxPage.Name = "textBoxPage";
            // 
            // textBoxPrice
            // 
            resources.ApplyResources(this.textBoxPrice, "textBoxPrice");
            this.textBoxPrice.Name = "textBoxPrice";
            // 
            // textBoxPublisher
            // 
            resources.ApplyResources(this.textBoxPublisher, "textBoxPublisher");
            this.textBoxPublisher.Name = "textBoxPublisher";
            // 
            // textBoxAuthor
            // 
            resources.ApplyResources(this.textBoxAuthor, "textBoxAuthor");
            this.textBoxAuthor.Name = "textBoxAuthor";
            // 
            // buttonAdd
            // 
            resources.ApplyResources(this.buttonAdd, "buttonAdd");
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // dateTimePicker
            // 
            resources.ApplyResources(this.dateTimePicker, "dateTimePicker");
            this.dateTimePicker.Name = "dateTimePicker";
            // 
            // buttonDelete
            // 
            resources.ApplyResources(this.buttonDelete, "buttonDelete");
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // labelDelete
            // 
            resources.ApplyResources(this.labelDelete, "labelDelete");
            this.labelDelete.Name = "labelDelete";
            // 
            // panelDelete
            // 
            this.panelDelete.BackColor = System.Drawing.Color.AntiqueWhite;
            this.panelDelete.Controls.Add(this.labelDelete2);
            this.panelDelete.Controls.Add(this.buttonDelete);
            this.panelDelete.Controls.Add(this.labelDelete);
            resources.ApplyResources(this.panelDelete, "panelDelete");
            this.panelDelete.Name = "panelDelete";
            // 
            // labelDelete2
            // 
            resources.ApplyResources(this.labelDelete2, "labelDelete2");
            this.labelDelete2.Name = "labelDelete2";
            // 
            // panelAdd
            // 
            this.panelAdd.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panelAdd.Controls.Add(this.labelBookGenre);
            this.panelAdd.Controls.Add(this.comboBoxBookGenre);
            this.panelAdd.Controls.Add(this.buttonAdd);
            this.panelAdd.Controls.Add(this.radioButtonNon);
            this.panelAdd.Controls.Add(this.labelStock);
            this.panelAdd.Controls.Add(this.radioButtonExist);
            this.panelAdd.Controls.Add(this.dateTimePicker);
            this.panelAdd.Controls.Add(this.textBoxPublisher);
            this.panelAdd.Controls.Add(this.labelBookName);
            this.panelAdd.Controls.Add(this.labelPublisher);
            this.panelAdd.Controls.Add(this.textBoxName);
            this.panelAdd.Controls.Add(this.textBoxAuthor);
            this.panelAdd.Controls.Add(this.textBoxPrice);
            this.panelAdd.Controls.Add(this.labelBookAuthor);
            this.panelAdd.Controls.Add(this.textBoxPage);
            this.panelAdd.Controls.Add(this.labelBookPage);
            this.panelAdd.Controls.Add(this.labelBookDate);
            this.panelAdd.Controls.Add(this.labelBookPrice);
            resources.ApplyResources(this.panelAdd, "panelAdd");
            this.panelAdd.Name = "panelAdd";
            // 
            // labelBookGenre
            // 
            resources.ApplyResources(this.labelBookGenre, "labelBookGenre");
            this.labelBookGenre.Name = "labelBookGenre";
            // 
            // comboBoxBookGenre
            // 
            this.comboBoxBookGenre.FormattingEnabled = true;
            this.comboBoxBookGenre.Items.AddRange(new object[] {
            resources.GetString("comboBoxBookGenre.Items"),
            resources.GetString("comboBoxBookGenre.Items1"),
            resources.GetString("comboBoxBookGenre.Items2"),
            resources.GetString("comboBoxBookGenre.Items3"),
            resources.GetString("comboBoxBookGenre.Items4"),
            resources.GetString("comboBoxBookGenre.Items5"),
            resources.GetString("comboBoxBookGenre.Items6"),
            resources.GetString("comboBoxBookGenre.Items7")});
            resources.ApplyResources(this.comboBoxBookGenre, "comboBoxBookGenre");
            this.comboBoxBookGenre.Name = "comboBoxBookGenre";
            // 
            // radioButtonNon
            // 
            resources.ApplyResources(this.radioButtonNon, "radioButtonNon");
            this.radioButtonNon.Name = "radioButtonNon";
            this.radioButtonNon.TabStop = true;
            this.radioButtonNon.UseVisualStyleBackColor = true;
            // 
            // labelStock
            // 
            resources.ApplyResources(this.labelStock, "labelStock");
            this.labelStock.Name = "labelStock";
            // 
            // radioButtonExist
            // 
            resources.ApplyResources(this.radioButtonExist, "radioButtonExist");
            this.radioButtonExist.Name = "radioButtonExist";
            this.radioButtonExist.TabStop = true;
            this.radioButtonExist.UseVisualStyleBackColor = true;
            // 
            // panelChange
            // 
            this.panelChange.BackColor = System.Drawing.Color.Tan;
            this.panelChange.Controls.Add(this.panel2);
            this.panelChange.Controls.Add(this.panel1);
            this.panelChange.Controls.Add(this.comboBoxBookGenre2);
            this.panelChange.Controls.Add(this.labelBookGenre2);
            this.panelChange.Controls.Add(this.radioButtonNon2);
            this.panelChange.Controls.Add(this.radioButtonExist2);
            this.panelChange.Controls.Add(this.labelStock2);
            this.panelChange.Controls.Add(this.label_id);
            this.panelChange.Controls.Add(this.labelNo2);
            this.panelChange.Controls.Add(this.dateTimePicker2);
            this.panelChange.Controls.Add(this.textBoxBookPublisher2);
            this.panelChange.Controls.Add(this.textBoxBookPrice2);
            this.panelChange.Controls.Add(this.textBoxBookPage2);
            this.panelChange.Controls.Add(this.labelBookDate2);
            this.panelChange.Controls.Add(this.textBoxBookAuthor2);
            this.panelChange.Controls.Add(this.textBoxBookName2);
            this.panelChange.Controls.Add(this.buttonChange);
            this.panelChange.Controls.Add(this.labelBookPublisher2);
            this.panelChange.Controls.Add(this.labelBookPrice2);
            this.panelChange.Controls.Add(this.labelBookPage2);
            this.panelChange.Controls.Add(this.labelBookAuthor2);
            this.panelChange.Controls.Add(this.labelBookName2);
            resources.ApplyResources(this.panelChange, "panelChange");
            this.panelChange.Name = "panelChange";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GrayText;
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // comboBoxBookGenre2
            // 
            this.comboBoxBookGenre2.FormattingEnabled = true;
            this.comboBoxBookGenre2.Items.AddRange(new object[] {
            resources.GetString("comboBoxBookGenre2.Items"),
            resources.GetString("comboBoxBookGenre2.Items1"),
            resources.GetString("comboBoxBookGenre2.Items2"),
            resources.GetString("comboBoxBookGenre2.Items3"),
            resources.GetString("comboBoxBookGenre2.Items4"),
            resources.GetString("comboBoxBookGenre2.Items5"),
            resources.GetString("comboBoxBookGenre2.Items6"),
            resources.GetString("comboBoxBookGenre2.Items7")});
            resources.ApplyResources(this.comboBoxBookGenre2, "comboBoxBookGenre2");
            this.comboBoxBookGenre2.Name = "comboBoxBookGenre2";
            // 
            // labelBookGenre2
            // 
            resources.ApplyResources(this.labelBookGenre2, "labelBookGenre2");
            this.labelBookGenre2.Name = "labelBookGenre2";
            // 
            // radioButtonNon2
            // 
            resources.ApplyResources(this.radioButtonNon2, "radioButtonNon2");
            this.radioButtonNon2.Name = "radioButtonNon2";
            this.radioButtonNon2.TabStop = true;
            this.radioButtonNon2.UseVisualStyleBackColor = true;
            // 
            // radioButtonExist2
            // 
            resources.ApplyResources(this.radioButtonExist2, "radioButtonExist2");
            this.radioButtonExist2.Name = "radioButtonExist2";
            this.radioButtonExist2.TabStop = true;
            this.radioButtonExist2.UseVisualStyleBackColor = true;
            // 
            // labelStock2
            // 
            resources.ApplyResources(this.labelStock2, "labelStock2");
            this.labelStock2.Name = "labelStock2";
            // 
            // label_id
            // 
            resources.ApplyResources(this.label_id, "label_id");
            this.label_id.Name = "label_id";
            // 
            // labelNo2
            // 
            resources.ApplyResources(this.labelNo2, "labelNo2");
            this.labelNo2.Name = "labelNo2";
            // 
            // dateTimePicker2
            // 
            resources.ApplyResources(this.dateTimePicker2, "dateTimePicker2");
            this.dateTimePicker2.Name = "dateTimePicker2";
            // 
            // textBoxBookPublisher2
            // 
            resources.ApplyResources(this.textBoxBookPublisher2, "textBoxBookPublisher2");
            this.textBoxBookPublisher2.Name = "textBoxBookPublisher2";
            // 
            // textBoxBookPrice2
            // 
            resources.ApplyResources(this.textBoxBookPrice2, "textBoxBookPrice2");
            this.textBoxBookPrice2.Name = "textBoxBookPrice2";
            // 
            // textBoxBookPage2
            // 
            resources.ApplyResources(this.textBoxBookPage2, "textBoxBookPage2");
            this.textBoxBookPage2.Name = "textBoxBookPage2";
            // 
            // labelBookDate2
            // 
            resources.ApplyResources(this.labelBookDate2, "labelBookDate2");
            this.labelBookDate2.Name = "labelBookDate2";
            // 
            // textBoxBookAuthor2
            // 
            resources.ApplyResources(this.textBoxBookAuthor2, "textBoxBookAuthor2");
            this.textBoxBookAuthor2.Name = "textBoxBookAuthor2";
            // 
            // textBoxBookName2
            // 
            resources.ApplyResources(this.textBoxBookName2, "textBoxBookName2");
            this.textBoxBookName2.Name = "textBoxBookName2";
            // 
            // buttonChange
            // 
            resources.ApplyResources(this.buttonChange, "buttonChange");
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.UseVisualStyleBackColor = true;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // labelBookPublisher2
            // 
            resources.ApplyResources(this.labelBookPublisher2, "labelBookPublisher2");
            this.labelBookPublisher2.Name = "labelBookPublisher2";
            // 
            // labelBookPrice2
            // 
            resources.ApplyResources(this.labelBookPrice2, "labelBookPrice2");
            this.labelBookPrice2.Name = "labelBookPrice2";
            // 
            // labelBookPage2
            // 
            resources.ApplyResources(this.labelBookPage2, "labelBookPage2");
            this.labelBookPage2.Name = "labelBookPage2";
            // 
            // labelBookAuthor2
            // 
            resources.ApplyResources(this.labelBookAuthor2, "labelBookAuthor2");
            this.labelBookAuthor2.Name = "labelBookAuthor2";
            // 
            // labelBookName2
            // 
            resources.ApplyResources(this.labelBookName2, "labelBookName2");
            this.labelBookName2.Name = "labelBookName2";
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Pink;
            this.panel3.Controls.Add(this.button1);
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // FormRecords
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panelChange);
            this.Controls.Add(this.panelAdd);
            this.Controls.Add(this.panelDelete);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormRecords";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelDelete.ResumeLayout(false);
            this.panelDelete.PerformLayout();
            this.panelAdd.ResumeLayout(false);
            this.panelAdd.PerformLayout();
            this.panelChange.ResumeLayout(false);
            this.panelChange.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelBookName;
        private System.Windows.Forms.Label labelBookAuthor;
        private System.Windows.Forms.Label labelBookPage;
        private System.Windows.Forms.Label labelBookPrice;
        private System.Windows.Forms.Label labelPublisher;
        private System.Windows.Forms.Label labelBookDate;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxPage;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.TextBox textBoxPublisher;
        private System.Windows.Forms.TextBox textBoxAuthor;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button buttonDelete;
        internal System.Windows.Forms.Label labelDelete;
        private System.Windows.Forms.Panel panelDelete;
        private System.Windows.Forms.Panel panelAdd;
        private System.Windows.Forms.Panel panelChange;
        private System.Windows.Forms.Label labelBookPublisher2;
        private System.Windows.Forms.Label labelBookDate2;
        private System.Windows.Forms.Label labelBookPrice2;
        private System.Windows.Forms.Label labelBookPage2;
        private System.Windows.Forms.Label labelBookAuthor2;
        private System.Windows.Forms.Label labelBookName2;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.TextBox textBoxBookPublisher2;
        private System.Windows.Forms.TextBox textBoxBookPrice2;
        private System.Windows.Forms.TextBox textBoxBookPage2;
        private System.Windows.Forms.TextBox textBoxBookAuthor2;
        private System.Windows.Forms.TextBox textBoxBookName2;
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.Label labelNo2;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Label labelDelete2;
        private System.Windows.Forms.Label labelStock;
        private System.Windows.Forms.RadioButton radioButtonNon;
        private System.Windows.Forms.RadioButton radioButtonExist;
        private System.Windows.Forms.RadioButton radioButtonNon2;
        private System.Windows.Forms.RadioButton radioButtonExist2;
        private System.Windows.Forms.Label labelStock2;
        private System.Windows.Forms.Label labelBookGenre;
        private System.Windows.Forms.ComboBox comboBoxBookGenre;
        private System.Windows.Forms.ComboBox comboBoxBookGenre2;
        private System.Windows.Forms.Label labelBookGenre2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel3;
    }
}

