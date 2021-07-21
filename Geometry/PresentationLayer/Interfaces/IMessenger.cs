using System;

namespace Geometry.PresentationLayer.Interfaces
{
    /// <summary>
    /// Interface for showing messages to client
    /// </summary>
    public interface IMessenger
    {
        /// <summary>
        /// Shows information message to user
        /// </summary>
        /// <param name="message"></param>
        /// <param name="caption"></param>
        void ShowInformationMessage(string message, string caption);

        /// <summary>
        /// Shows error message to viewer with stacktrace
        /// Not the best practice to show user exception information
        /// </summary>
        /// <param name="ex">Exception information</param>
        void ShowErrorMessage(Exception ex);
    }
}
