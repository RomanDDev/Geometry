using System;
using System.Windows.Forms;
using Geometry.ApplicationLayer.Enums;
using Geometry.PresentationLayer.Interfaces;
using Geometry.Properties;

namespace Geometry
{
    public partial class DrawingForm : Form, IEditorView
    {
        public DrawingForm()
        {
            InitializeComponent();
        }

        #region IEditorView Implementation
        public event EventHandler<EventArgs> OnSelectMode;
        public event EventHandler<EventArgs> OnMoveMode;
        public event EventHandler<EventArgs> OnDrawMode;

        public void SetMode(EditorModes mode)
        {
            switch (mode)
            {
                case EditorModes.Drawing:
                    drawButton.Checked = true;
                    break;
                case EditorModes.Selection:
                    selectButton.Checked = true;
                    break;
                case EditorModes.Movement:
                    moveButton.Checked = true;
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(mode), mode, Resources.UnexpectedEditorModeErrorMessage);
            }
        }
        #endregion

        private void selectButton_CheckedChanged(object sender, EventArgs e)
        {
            if (!selectButton.Checked) return;
            OnSelectMode?.Invoke(this, EventArgs.Empty);
        }

        private void drawButton_CheckedChanged(object sender, EventArgs e)
        {
            if (!drawButton.Checked) return;
            OnDrawMode?.Invoke(this, EventArgs.Empty);
        }

        private void moveButton_CheckedChanged(object sender, EventArgs e)
        {
            if (!moveButton.Checked) return;
            OnMoveMode?.Invoke(this, EventArgs.Empty);
        }
    }
}
