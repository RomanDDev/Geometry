using Geometry.ApplicationLayer.Enums;

namespace Geometry.ApplicationLayer.EventArgs
{
    /// <summary>
    /// Event args to store current selected editor tool type
    /// </summary>
    public class EditorModeChangedEventArgs:System.EventArgs
    {
        public EditorModes Mode { get; }

        public EditorModeChangedEventArgs(EditorModes mode)
        {
            Mode = mode;
        }
    }
}
