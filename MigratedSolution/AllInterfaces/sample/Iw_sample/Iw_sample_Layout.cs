namespace sample
{

   public interface Iw_sample
      : Mobilize.Web.IWindow
   {

      void Create();

      void Destroy();

      Iw_sampleInner.Idw_1_type dw_1 { get; set; }

      Iw_sampleInner.Isle_1_type sle_1 { get; set; }

      Iw_sampleInner.Ist_1_type st_1 { get; set; }

      Iw_sampleInner.Icb_1_type cb_1 { get; set; }

   }

   namespace Iw_sampleInner
   {

      public interface Idw_1_type
         : Mobilize.Web.IDataManagerControl
      {

         void DoWmInit();

      }

      public interface Isle_1_type
         : Mobilize.Web.ISingleLineEdit
      {

         void DoWmInit();

      }

      public interface Ist_1_type
         : Mobilize.Web.IStaticText
      {

         void DoWmInit();

      }

      public interface Icb_1_type
         : Mobilize.Web.ICommandButton
      {

         int? Clicked();

         void DoWmInit();

      }

   }
}