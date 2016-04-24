using RestCore;
namespace REST
{
    using Nancy;
    using Nancy.IO;
    using Nancy.ModelBinding;
    public class IndexModule : NancyModule
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public IndexModule()
        {
            Get["/fibo/{n}"] = parameters =>
            {
                log.Info("Calling /fibo/" + parameters.n);
                if (parameters.n != null)
                {
                    int n = int.Parse(parameters.n);
                    log.Info("Calcultaing Fibo("+n+") = " +Core.Fibonacci(n) );
                    return Response.AsJson("{fibo:" + Core.Fibonacci(n) + " }");
                }
                else {
                    log.Error("Parameter is Null");
                    return -1;
                }
            };
            
            Post["/xml2json"] = _ =>
            {
                log.Info("Calling /xml2json");
                Xml body = this.Bind<Xml>();
                log.Info("Request body for /xml2json is :" + body);
                var json =  Core.XmlToJson(body.Value);
                if (json != null)
                {
                    log.Info("Converting XML file to json");
                    log.Info("Response body for /xml2json is : " + json);
                    return json;
                }
                else {
                    log.Error("Error Converting XML file");
                    return HttpStatusCode.BadRequest;
                }
            };
        }
        
    }
}