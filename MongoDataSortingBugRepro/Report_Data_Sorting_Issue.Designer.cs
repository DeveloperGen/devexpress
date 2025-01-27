namespace MongoDataSortingBugRepro
{
    partial class Report_Data_Sorting_Issue
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

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.DataAccess.MongoDB.MongoDBQuery mongoDBQuery1 = new DevExpress.DataAccess.MongoDB.MongoDBQuery();
            DevExpress.DataAccess.MongoDB.MongoDBSchemaNode mongoDBSchemaNode1 = new DevExpress.DataAccess.MongoDB.MongoDBSchemaNode("Client", true);
            DevExpress.DataAccess.MongoDB.MongoDBSchemaNode mongoDBSchemaNode2 = new DevExpress.DataAccess.MongoDB.MongoDBSchemaNode("_id", true, DevExpress.DataAccess.MongoDB.MongoDBNodeType.Property, typeof(string));
            DevExpress.DataAccess.MongoDB.MongoDBSchemaNode mongoDBSchemaNode3 = new DevExpress.DataAccess.MongoDB.MongoDBSchemaNode("Name", true, DevExpress.DataAccess.MongoDB.MongoDBNodeType.Property, typeof(string));
            DevExpress.DataAccess.MongoDB.MongoDBSchemaNode mongoDBSchemaNode4 = new DevExpress.DataAccess.MongoDB.MongoDBSchemaNode("Country", true, DevExpress.DataAccess.MongoDB.MongoDBNodeType.Property, typeof(string));
            DevExpress.DataAccess.MongoDB.MongoDBSchemaNode mongoDBSchemaNode5 = new DevExpress.DataAccess.MongoDB.MongoDBSchemaNode("CreatedBy", true);
            DevExpress.DataAccess.MongoDB.MongoDBSchemaNode mongoDBSchemaNode6 = new DevExpress.DataAccess.MongoDB.MongoDBSchemaNode("ProfileId", true, DevExpress.DataAccess.MongoDB.MongoDBNodeType.Property, typeof(string));
            DevExpress.DataAccess.MongoDB.MongoDBSchemaNode mongoDBSchemaNode7 = new DevExpress.DataAccess.MongoDB.MongoDBSchemaNode("UserName", true, DevExpress.DataAccess.MongoDB.MongoDBNodeType.Property, typeof(string));
            DevExpress.DataAccess.MongoDB.MongoDBSchemaNode mongoDBSchemaNode8 = new DevExpress.DataAccess.MongoDB.MongoDBSchemaNode("CreatedDate", true, DevExpress.DataAccess.MongoDB.MongoDBNodeType.Property, typeof(string));
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Report_Data_Sorting_Issue));
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.mongoDBDataSource1 = new DevExpress.DataAccess.MongoDB.MongoDBDataSource(this.components);
            this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.xrTable2 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell7 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell8 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell9 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTable1 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
            this.label1 = new DevExpress.XtraReports.UI.XRLabel();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable1});
            this.Detail.HeightF = 25F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.SortFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("CreatedBy.ProfileId", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // TopMargin
            // 
            this.TopMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.label1});
            this.TopMargin.HeightF = 38.95833F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 0F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // mongoDBDataSource1
            // 
            this.mongoDBDataSource1.ConnectionName = "dev_Connection";
            this.mongoDBDataSource1.Name = "mongoDBDataSource1";
            mongoDBQuery1.ActualName = "Client";
            mongoDBQuery1.Alias = null;
            mongoDBQuery1.CollectionName = "Client";
            mongoDBQuery1.DatabaseName = "test";
            mongoDBSchemaNode5.Nodes.Add(mongoDBSchemaNode6);
            mongoDBSchemaNode5.Nodes.Add(mongoDBSchemaNode7);
            mongoDBSchemaNode5.Nodes.Add(mongoDBSchemaNode8);
            mongoDBSchemaNode1.Nodes.Add(mongoDBSchemaNode2);
            mongoDBSchemaNode1.Nodes.Add(mongoDBSchemaNode3);
            mongoDBSchemaNode1.Nodes.Add(mongoDBSchemaNode4);
            mongoDBSchemaNode1.Nodes.Add(mongoDBSchemaNode5);
            mongoDBQuery1.Schema = mongoDBSchemaNode1;
            this.mongoDBDataSource1.Queries.AddRange(new DevExpress.DataAccess.MongoDB.MongoDBQuery[] {
            mongoDBQuery1});
            this.mongoDBDataSource1.ResultSchemaSerializable = resources.GetString("mongoDBDataSource1.ResultSchemaSerializable");
            // 
            // GroupHeader1
            // 
            this.GroupHeader1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable2});
            this.GroupHeader1.HeightF = 25F;
            this.GroupHeader1.Name = "GroupHeader1";
            // 
            // xrTable2
            // 
            this.xrTable2.BackColor = System.Drawing.Color.Silver;
            this.xrTable2.Font = new DevExpress.Drawing.DXFont("Calibri Light", 10F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrTable2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrTable2.Name = "xrTable2";
            this.xrTable2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrTable2.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow2});
            this.xrTable2.SizeF = new System.Drawing.SizeF(650.0001F, 25F);
            this.xrTable2.StylePriority.UseBackColor = false;
            this.xrTable2.StylePriority.UseFont = false;
            // 
            // xrTableRow2
            // 
            this.xrTableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell7,
            this.xrTableCell8,
            this.xrTableCell9});
            this.xrTableRow2.Name = "xrTableRow2";
            this.xrTableRow2.Weight = 1D;
            // 
            // xrTableCell7
            // 
            this.xrTableCell7.Multiline = true;
            this.xrTableCell7.Name = "xrTableCell7";
            this.xrTableCell7.Text = "Name";
            this.xrTableCell7.Weight = 2.17582345061882D;
            // 
            // xrTableCell8
            // 
            this.xrTableCell8.Multiline = true;
            this.xrTableCell8.Name = "xrTableCell8";
            this.xrTableCell8.Text = "Country";
            this.xrTableCell8.Weight = 1.8818635170824196D;
            // 
            // xrTableCell9
            // 
            this.xrTableCell9.Multiline = true;
            this.xrTableCell9.Name = "xrTableCell9";
            this.xrTableCell9.StylePriority.UseTextAlignment = false;
            this.xrTableCell9.Text = "Profile Id";
            this.xrTableCell9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell9.Weight = 2.7994436988852764D;
            // 
            // xrTable1
            // 
            this.xrTable1.BackColor = System.Drawing.Color.Transparent;
            this.xrTable1.Font = new DevExpress.Drawing.DXFont("Calibri Light", 10F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrTable1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrTable1.Name = "xrTable1";
            this.xrTable1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1});
            this.xrTable1.SizeF = new System.Drawing.SizeF(650.0001F, 25F);
            this.xrTable1.StylePriority.UseBackColor = false;
            this.xrTable1.StylePriority.UseFont = false;
            // 
            // xrTableRow1
            // 
            this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell1,
            this.xrTableCell2,
            this.xrTableCell3});
            this.xrTableRow1.Name = "xrTableRow1";
            this.xrTableRow1.Weight = 1D;
            // 
            // xrTableCell1
            // 
            this.xrTableCell1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Name]")});
            this.xrTableCell1.Multiline = true;
            this.xrTableCell1.Name = "xrTableCell1";
            this.xrTableCell1.Text = "Name";
            this.xrTableCell1.Weight = 2.17582345061882D;
            // 
            // xrTableCell2
            // 
            this.xrTableCell2.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Country]")});
            this.xrTableCell2.Multiline = true;
            this.xrTableCell2.Name = "xrTableCell2";
            this.xrTableCell2.Text = "Country";
            this.xrTableCell2.Weight = 1.8818635170824196D;
            // 
            // xrTableCell3
            // 
            this.xrTableCell3.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CreatedBy].[ProfileId]")});
            this.xrTableCell3.Multiline = true;
            this.xrTableCell3.Name = "xrTableCell3";
            this.xrTableCell3.StylePriority.UseTextAlignment = false;
            this.xrTableCell3.Text = "Profile Id";
            this.xrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell3.Weight = 2.7994436988852764D;
            // 
            // label1
            // 
            this.label1.Font = new DevExpress.Drawing.DXFont("Calibri", 16F, DevExpress.Drawing.DXFontStyle.Bold);
            this.label1.LocationFloat = new DevExpress.Utils.PointFloat(189.8872F, 4.347332F);
            this.label1.Name = "label1";
            this.label1.SizeF = new System.Drawing.SizeF(264.2794F, 34.611F);
            this.label1.StylePriority.UseFont = false;
            this.label1.StylePriority.UseTextAlignment = false;
            this.label1.Text = "Report Client";
            this.label1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // Report_Data_Sorting_Issue
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.GroupHeader1});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.mongoDBDataSource1});
            this.DataMember = "Client";
            this.DataSource = this.mongoDBDataSource1;
            this.FilterString = "[Country] = \'USA\'";
            this.Margins = new DevExpress.Drawing.DXMargins(100F, 100F, 38.95833F, 0F);
            this.Version = "24.1";
            ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.DataAccess.MongoDB.MongoDBDataSource mongoDBDataSource1;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader1;
        private DevExpress.XtraReports.UI.XRTable xrTable2;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow2;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell7;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell8;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell9;
        private DevExpress.XtraReports.UI.XRTable xrTable1;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow1;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell1;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell2;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell3;
        private DevExpress.XtraReports.UI.XRLabel label1;
    }
}
