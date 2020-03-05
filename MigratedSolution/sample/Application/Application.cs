namespace sample
{

   public class Application
      : Mobilize.Web.Application, sample.IApplication
   {

      public Application(Microsoft.AspNetCore.Http.IHttpContextAccessor contextAccesor)
      : base(contextAccesor)
      {
         this.AppName = "sample";
      }

      public void DoWmInit()
      {
      }

      public virtual int? OpenWindow(string commandline)
      {
         Mobilize.Web.BuiltInExtensions.Open(Mobilize.Web.ReferenceExtensions.Ref<Mobilize.Web.IWindow>((Mobilize.Web.IWindow)Mobilize.Web.Application.CurrentApplication.Variables.w_sample<sample.Iw_sample>(), (v) => Mobilize.Web.Application.CurrentApplication.Variables.w_sample = (sample.Iw_sample)v, () => Mobilize.Web.Application.CurrentApplication.Variables.w_sample<sample.Iw_sample>()));
         return null;
      }

      public override void Create()
      {
         this.AppName = "sample";
         Mobilize.Web.Application.CurrentApplication.Variables.Message = Mobilize.Web.Application.Create<Mobilize.Web.IMessage>();
         Mobilize.Web.Application.CurrentApplication.Variables.SqlCa = Mobilize.Web.Application.Create<Mobilize.Web.ITransaction>();
         Mobilize.Web.Application.CurrentApplication.Variables.SqlDa = Mobilize.Web.Application.Create<Mobilize.Web.IDynamicDescriptionArea>();
         Mobilize.Web.Application.CurrentApplication.Variables.SqlSa = Mobilize.Web.Application.Create<Mobilize.Web.IDynamicStagingArea>();
         Mobilize.Web.Application.CurrentApplication.Variables.Error = Mobilize.Web.Application.Create<Mobilize.Web.IError>();
      }

      public override void Destroy()
      {
         Mobilize.Web.Application.CurrentApplication.Variables.SqlCa = null;
         Mobilize.Web.Application.CurrentApplication.Variables.SqlDa = null;
         Mobilize.Web.Application.CurrentApplication.Variables.SqlSa = null;
         Mobilize.Web.Application.CurrentApplication.Variables.Error = null;
         Mobilize.Web.Application.CurrentApplication.Variables.Message = null;
      }

   }

}