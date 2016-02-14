using System;
using Logger.Logger.Interfaces;

namespace Logger.Logger.DataAppender
{
    /// <summary>
    /// Appends a log to the console using the provided layout.
    /// </summary>
    public class ConsoleAppender : DataAppender
    {
        public ConsoleAppender(ILayout layout)
            : base(layout)
        {
        }

        public override void Append(string type, string message)
        {
            Console.WriteLine(this.Layout.LayoutFormat(type, message));
        }
    }
}
