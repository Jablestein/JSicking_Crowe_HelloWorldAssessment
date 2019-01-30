using ServiceLibrary.Interfaces;

namespace ServiceLibrary.Classes
{
    public abstract class ServiceWriter
    {
        protected IMessage _message;
        public ServiceWriter(IMessage message)
        {
            _message = message;
        }

        public void WriteMessage()
        {
            WriteMessageToMedium(_message);
        }

        protected abstract void WriteMessageToMedium(IMessage message);
    }
}
