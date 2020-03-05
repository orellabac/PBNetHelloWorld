namespace sample
{

   public partial class w_sample
   {

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Iw_sampleInner.Idw_1_type dw_1 { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Iw_sampleInner.Isle_1_type sle_1 { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Iw_sampleInner.Ist_1_type st_1 { get; set; }

      [Mobilize.WebMap.Common.Attributes.Intercepted]
      public Iw_sampleInner.Icb_1_type cb_1 { get; set; }


      public w_sample(Mobilize.Web.BaseControl parent = null)
      : base(parent)
      {
         this.Width = 1266;
         this.Height = 844;
         this.TitleBar = true;
         this.Title = "Untitled";
         this.ControlMenu = true;
         this.MinBox = true;
         this.MaxBox = true;
         this.Resizable = true;
         this.BackColor = 67108864;
         this.Icon = "AppIcon!";
         this.Center = true;
      }
   }

}