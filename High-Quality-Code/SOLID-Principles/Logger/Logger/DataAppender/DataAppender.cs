using Logger.Logger.Interfaces;

namespace Logger.Logger.DataAppender
{
    public abstract class DataAppender : IDataAppender
    {
        protected DataAppender(ILayout layout)
        {
            this.Layout = layout;
        }

        public ILayout Layout { get; private set; }

        public abstract void Append(string type, string message);
    }
}