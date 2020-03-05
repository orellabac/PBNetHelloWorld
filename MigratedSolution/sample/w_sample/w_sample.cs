namespace sample
{

   [Mobilize.WebMap.Common.Attributes.Observable]
   public partial class w_sample
      : Mobilize.Web.Window, sample.Iw_sample
   {

      public override void Create()
      {
         this.dw_1 = CreateInnerControl_dw_1_type();
         this.sle_1 = CreateInnerControl_sle_1_type();
         this.st_1 = CreateInnerControl_st_1_type();
         this.cb_1 = CreateInnerControl_cb_1_type();
         this.Control = Mobilize.Web.ArrayExtensions.Clone<Mobilize.Web.IControl>(new Mobilize.Web.IControl[] { this.dw_1, this.sle_1, this.st_1, this.cb_1 });
      }

      public override void Destroy()
      {
         this.dw_1 = null;
         this.sle_1 = null;
         this.st_1 = null;
         this.cb_1 = null;
      }

      protected virtual Iw_sampleInner.Idw_1_type CreateInnerControl_dw_1_type()
      {
         return Mobilize.Web.Application.Create<Iw_sampleInner.Idw_1_type>(this);
      }

      protected virtual Iw_sampleInner.Isle_1_type CreateInnerControl_sle_1_type()
      {
         return Mobilize.Web.Application.Create<Iw_sampleInner.Isle_1_type>(this);
      }

      protected virtual Iw_sampleInner.Ist_1_type CreateInnerControl_st_1_type()
      {
         return Mobilize.Web.Application.Create<Iw_sampleInner.Ist_1_type>(this);
      }

      protected virtual Iw_sampleInner.Icb_1_type CreateInnerControl_cb_1_type()
      {
         return Mobilize.Web.Application.Create<Iw_sampleInner.Icb_1_type>(this);
      }

      public class dw_1_type
         : Mobilize.Web.DataManagerControl, Iw_sampleInner.Idw_1_type
      {

         public dw_1_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_sample Parent => (w_sample)base.Parent;

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 73;
            this.Y = 256;
            this.Width = 1070;
            this.Height = 420;
            this.TabOrder = 20;
            this.Title = "none";
            this.DataObject = "d_sample_list";
            this.LiveScroll = true;
            this.BorderStyle = Mobilize.Web.BorderStyle.StyleLowered;
         }

      }

      public class sle_1_type
         : Mobilize.Web.SingleLineEdit, Iw_sampleInner.Isle_1_type
      {

         public sle_1_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_sample Parent => (w_sample)base.Parent;

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 471;
            this.Y = 80;
            this.Width = 320;
            this.Height = 112;
            this.TabOrder = 10;
            this.TextSize = -10;
            this.Weight = 400;
            this.FontCharset = Mobilize.Web.FontCharset.Ansi;
            this.FontPitch = Mobilize.Web.FontPitch.Variable;
            this.FontFamily = Mobilize.Web.FontFamily.Swiss;
            this.FaceName = "Tahoma";
            this.TextColor = 33554432;
            this.BorderStyle = Mobilize.Web.BorderStyle.StyleLowered;
         }

      }

      public class st_1_type
         : Mobilize.Web.StaticText, Iw_sampleInner.Ist_1_type
      {

         public st_1_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_sample Parent => (w_sample)base.Parent;

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 96;
            this.Y = 80;
            this.Width = 320;
            this.Height = 112;
            this.TextSize = -10;
            this.Weight = 400;
            this.FontCharset = Mobilize.Web.FontCharset.Ansi;
            this.FontPitch = Mobilize.Web.FontPitch.Variable;
            this.FontFamily = Mobilize.Web.FontFamily.Swiss;
            this.FaceName = "Tahoma";
            this.TextColor = 33554432;
            this.BackColor = 67108864;
            this.Text = "Test Dw";
            this.FocusRectangle = false;
         }

      }

      public class cb_1_type
         : Mobilize.Web.CommandButton, Iw_sampleInner.Icb_1_type
      {

         public cb_1_type(Mobilize.Web.BaseControl parent)
         : base(parent)
         {
         }

         private new w_sample Parent => (w_sample)base.Parent;

         public virtual int? Clicked()
         {
            short? li_row = 0;
            if ( Mobilize.Web.Comparison.NotEquals(this.Parent.sle_1.Text, "") == true )
            {
               li_row = (short?)this.Parent.dw_1.InsertRow(0);
               this.Parent.dw_1.SetItem(li_row, 1, this.Parent.sle_1.Text);
            }
            return null;
         }

         public override void DoWmInit()
         {
            base.DoWmInit();
            this.X = 827;
            this.Y = 80;
            this.Width = 320;
            this.Height = 112;
            this.TabOrder = 10;
            this.TextSize = -10;
            this.Weight = 400;
            this.FontCharset = Mobilize.Web.FontCharset.Ansi;
            this.FontPitch = Mobilize.Web.FontPitch.Variable;
            this.FontFamily = Mobilize.Web.FontFamily.Swiss;
            this.FaceName = "Tahoma";
            this.Text = "Add";
            this.bnclicked = new Mobilize.Web.ClickedEventHandler(Clicked);
         }

      }

   }

}