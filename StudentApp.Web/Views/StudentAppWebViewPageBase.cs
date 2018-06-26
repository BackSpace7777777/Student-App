using Abp.Web.Mvc.Views;

namespace StudentApp.Web.Views
{
    public abstract class StudentAppWebViewPageBase : StudentAppWebViewPageBase<dynamic>
    {

    }

    public abstract class StudentAppWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected StudentAppWebViewPageBase()
        {
            LocalizationSourceName = StudentAppConsts.LocalizationSourceName;
        }
    }
}