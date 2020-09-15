namespace PooAndSolid.Exception
{
    public class InternalServerError : System.Exception
    {
        public InternalServerError() : base() { }
        public InternalServerError(string message) : base(message) { }
        public InternalServerError(string message, System.Exception inner) : base(message, inner) { }
        protected InternalServerError(System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context)
        { }
    }
}
