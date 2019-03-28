using System.Net;

namespace CorePexel
{
   [System.Serializable]
   public class CorePexelException : System.Exception
   {
      public HttpStatusCode HttpStatusCode { get; private set; }

      public CorePexelException()
      {
      }

      public CorePexelException(HttpStatusCode httpStatusCode, string message) : base(message)
      {
         HttpStatusCode = httpStatusCode;
      }
   }
}