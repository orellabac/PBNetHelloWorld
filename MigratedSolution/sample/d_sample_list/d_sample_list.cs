namespace sample
{

   [Mobilize.WebMap.Common.Attributes.Observable]
   public partial class d_sample_list
      : Mobilize.Web.DataManager, Mobilize.Web.IDataManager
   {

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmText list_t { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Mobilize.Web.DmColumn list { get; set; }


      public d_sample_list()
      : base()
      {
         this.Units = Mobilize.Web.CaseExtensions.String("0");
         this.Color = Mobilize.Web.CaseExtensions.String("1073741824");
         this.Processing = Mobilize.Web.CaseExtensions.String("1");
         this.PrintSpecification.PrinterName = "";
         this.PrintSpecification.DocumentName = "";
         this.PrintSpecification.Orientation = Mobilize.Web.CaseExtensions.String("0");
         this.PrintSpecification.Margin.Left = 110;
         this.PrintSpecification.Margin.Right = 110;
         this.PrintSpecification.Margin.Top = 96;
         this.PrintSpecification.Margin.Bottom = 96;
         this.PrintSpecification.Paper.Source = 0;
         this.PrintSpecification.Paper.Size = 0;
         this.PrintSpecification.CanUseDefaultPrinter = true;
         this.PrintSpecification.Prompt = false;
         this.PrintSpecification.Buttons = false;
         this.PrintSpecification.ClipText = false;
         this.PrintSpecification.OverridePrintJob = false;
         this.PrintSpecification.Collate = true;
         this.Header.Height = 80;
         this.Header.Color = "536870912";
         this.Summary.Height = 0;
         this.Summary.Color = "536870912";
         this.Footer.Height = 0;
         this.Footer.Color = "536870912";
         this.Detail.Height = 92;
         this.Detail.Color = "536870912";
         var list_db1 = new Mobilize.Web.DB.Column();
         list_db1.Type = Mobilize.Web.CaseExtensions.String("char(10)");
         list_db1.UpdateWhereClause = true;
         list_db1.Name = Mobilize.Web.CaseExtensions.String("list");
         list_db1.DbName = "list";
         this.list_t = new Mobilize.Web.DmText();
         this.list_t.Band = Mobilize.Web.CaseExtensions.String("header");
         this.list_t.Alignment = 2;
         this.list_t.Text = "List";
         this.list_t.Border = 0;
         this.list_t.Color = "33554432";
         this.list_t.X = 14;
         this.list_t.Y = 8;
         this.list_t.Height = 64;
         this.list_t.Width = 443;
         this.list_t.Name = Mobilize.Web.CaseExtensions.String("list_t");
         this.list_t.Visible = true;
         this.list_t.Font.FontFace = "Tahoma";
         this.list_t.Font.Height = -10;
         this.list_t.Font.Weight = 700;
         this.list_t.Font.FontFamily = "2";
         this.list_t.Font.Pitch = "2";
         this.list_t.Font.Charset = "0";
         this.list_t.Background.Color = "536870912";
         this.list = new Mobilize.Web.DmColumn();
         this.list.Band = Mobilize.Web.CaseExtensions.String("detail");
         this.list.Id = 1;
         this.list.Alignment = 0;
         this.list.TabSequence = 10;
         this.list.Border = 0;
         this.list.Color = "33554432";
         this.list.X = 14;
         this.list.Y = 8;
         this.list.Height = 76;
         this.list.Width = 443;
         this.list.Format = "[general]";
         this.list.Name = Mobilize.Web.CaseExtensions.String("list");
         this.list.Visible = true;
         this.list.Edit.Limit = 0;
         this.list.Edit.Case = "any";
         this.list.Edit.FocusRectangle = false;
         this.list.Edit.AutoSelect = true;
         this.list.Edit.AutoHScroll = true;
         this.list.Font.FontFace = "Tahoma";
         this.list.Font.Height = -10;
         this.list.Font.Weight = 400;
         this.list.Font.FontFamily = "2";
         this.list.Font.Pitch = "2";
         this.list.Font.Charset = "0";
         this.list.Background.Color = "536870912";
         this.list.EditMask.MaskDataType = Mobilize.Web.MaskDataType.StringMask;
         this.AddColumns(new Mobilize.Web.DB.Column[] { list_db1 });
         this.AddControls(new Mobilize.Web.DmControl[] { this.list_t, this.list });
         this.PopulateRadioButtons();
      }
   }

}