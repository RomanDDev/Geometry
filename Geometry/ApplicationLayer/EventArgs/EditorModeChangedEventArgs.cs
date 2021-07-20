using Geometry.ApplicationLayer.Enums;

namespace Geometry.ApplicationLayer.EventArgs
{
    public class EditorModeChangedEventArgs:System.EventArgs
    {
        public EditorModes Mode { get; }

        public EditorModeChangedEventArgs(EditorModes mode)
        {
            Mode = mode;
        }
    }
}
