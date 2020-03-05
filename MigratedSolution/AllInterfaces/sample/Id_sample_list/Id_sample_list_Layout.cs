namespace sample
{

   public interface Id_sample_list
      : Mobilize.Web.IDataManager
   {

      Mobilize.Web.DmText list_t { get; set; }

      Mobilize.Web.DmColumn list { get; set; }

   }

}