using Refit;

namespace XFTest.Services
{
    public static class ApiHandler
    {
        const string BASE_URL = "http://khorshidnegar.ir";
        private static IApi api;
        public static IApi Api
        {
            get
            {
                if (api == null) api = RestService.For<IApi>(BASE_URL);
                return api;
            }
        }
    }
}
