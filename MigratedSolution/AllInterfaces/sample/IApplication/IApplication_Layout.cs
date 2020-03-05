namespace sample
{

   public interface IApplication
      : Mobilize.Web.IApplication
   {

      void DoWmInit();

      int? OpenWindow(string commandline);

      void Create();

      void Destroy();

   }

}