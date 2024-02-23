namespace ErpProject.Formlar
{
    partial class Departmanlar
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Departmanlar));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.GüncelleBtn = new DevExpress.XtraEditors.SimpleButton();
            this.SilBtn = new DevExpress.XtraEditors.SimpleButton();
            this.EkleBtn = new DevExpress.XtraEditors.SimpleButton();
            this.SorumluTxt = new DevExpress.XtraEditors.TextEdit();
            this.PersonelSayisiTxt = new DevExpress.XtraEditors.TextEdit();
            this.DepartmanAdiTxt = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.ListeleBtn = new DevExpress.XtraEditors.SimpleButton();
            this.DepartmanIdTxt = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SorumluTxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PersonelSayisiTxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DepartmanAdiTxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DepartmanIdTxt.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            gridLevelNode1.RelationName = "Level1";
            this.gridControl1.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControl1.Location = new System.Drawing.Point(-2, -3);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1035, 663);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.FocusedViewChanged += new DevExpress.XtraGrid.ViewFocusEventHandler(this.gridControl1_FocusedViewChanged);
            this.gridControl1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gridControl1_MouseClick);
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.GüncelleBtn);
            this.groupControl1.Controls.Add(this.SilBtn);
            this.groupControl1.Controls.Add(this.EkleBtn);
            this.groupControl1.Controls.Add(this.SorumluTxt);
            this.groupControl1.Controls.Add(this.PersonelSayisiTxt);
            this.groupControl1.Controls.Add(this.DepartmanAdiTxt);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.ListeleBtn);
            this.groupControl1.Controls.Add(this.DepartmanIdTxt);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(1033, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(385, 635);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl1_Paint);
            // 
            // GüncelleBtn
            // 
            this.GüncelleBtn.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("GüncelleBtn.ImageOptions.SvgImage")));
            this.GüncelleBtn.Location = new System.Drawing.Point(203, 283);
            this.GüncelleBtn.Name = "GüncelleBtn";
            this.GüncelleBtn.Size = new System.Drawing.Size(141, 32);
            this.GüncelleBtn.TabIndex = 11;
            this.GüncelleBtn.Text = "Güncelle";
            this.GüncelleBtn.Click += new System.EventHandler(this.GüncelleBtn_Click);
            // 
            // SilBtn
            // 
            this.SilBtn.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("SilBtn.ImageOptions.SvgImage")));
            this.SilBtn.Location = new System.Drawing.Point(203, 245);
            this.SilBtn.Name = "SilBtn";
            this.SilBtn.Size = new System.Drawing.Size(141, 32);
            this.SilBtn.TabIndex = 10;
            this.SilBtn.Text = "Sil";
            this.SilBtn.Click += new System.EventHandler(this.SilBtn_Click);
            // 
            // EkleBtn
            // 
            this.EkleBtn.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("EkleBtn.ImageOptions.SvgImage")));
            this.EkleBtn.Location = new System.Drawing.Point(203, 207);
            this.EkleBtn.Name = "EkleBtn";
            this.EkleBtn.Size = new System.Drawing.Size(141, 32);
            this.EkleBtn.TabIndex = 9;
            this.EkleBtn.Text = "Ekle";
            this.EkleBtn.Click += new System.EventHandler(this.EkleBtn_Click);
            // 
            // SorumluTxt
            // 
            this.SorumluTxt.Location = new System.Drawing.Point(143, 131);
            this.SorumluTxt.Name = "SorumluTxt";
            this.SorumluTxt.Size = new System.Drawing.Size(201, 20);
            this.SorumluTxt.TabIndex = 8;
            // 
            // PersonelSayisiTxt
            // 
            this.PersonelSayisiTxt.Location = new System.Drawing.Point(143, 105);
            this.PersonelSayisiTxt.Name = "PersonelSayisiTxt";
            this.PersonelSayisiTxt.Size = new System.Drawing.Size(201, 20);
            this.PersonelSayisiTxt.TabIndex = 7;
            // 
            // DepartmanAdiTxt
            // 
            this.DepartmanAdiTxt.Location = new System.Drawing.Point(143, 79);
            this.DepartmanAdiTxt.Name = "DepartmanAdiTxt";
            this.DepartmanAdiTxt.Size = new System.Drawing.Size(201, 20);
            this.DepartmanAdiTxt.TabIndex = 6;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(66, 108);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(71, 13);
            this.labelControl4.TabIndex = 5;
            this.labelControl4.Text = "Personel Sayısı";
            // 
            // ListeleBtn
            // 
            this.ListeleBtn.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ListeleBtn.ImageOptions.SvgImage")));
            this.ListeleBtn.Location = new System.Drawing.Point(203, 169);
            this.ListeleBtn.Name = "ListeleBtn";
            this.ListeleBtn.Size = new System.Drawing.Size(141, 32);
            this.ListeleBtn.TabIndex = 4;
            this.ListeleBtn.Text = "Listele";
            this.ListeleBtn.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // DepartmanIdTxt
            // 
            this.DepartmanIdTxt.Location = new System.Drawing.Point(143, 53);
            this.DepartmanIdTxt.Name = "DepartmanIdTxt";
            this.DepartmanIdTxt.Size = new System.Drawing.Size(200, 20);
            this.DepartmanIdTxt.TabIndex = 3;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(99, 134);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(38, 13);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Sorumlu";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(66, 82);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(71, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Departman Adı";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(71, 56);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(66, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Departman Id";
            this.labelControl1.Click += new System.EventHandler(this.labelControl1_Click);
            // 
            // Departmanlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1418, 635);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "Departmanlar";
            this.Text = "Departmanlar";
            this.Load += new System.EventHandler(this.Departmanlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SorumluTxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PersonelSayisiTxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DepartmanAdiTxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DepartmanIdTxt.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit DepartmanIdTxt;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton GüncelleBtn;
        private DevExpress.XtraEditors.SimpleButton SilBtn;
        private DevExpress.XtraEditors.SimpleButton EkleBtn;
        private DevExpress.XtraEditors.TextEdit SorumluTxt;
        private DevExpress.XtraEditors.TextEdit PersonelSayisiTxt;
        private DevExpress.XtraEditors.TextEdit DepartmanAdiTxt;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SimpleButton ListeleBtn;
    }
}