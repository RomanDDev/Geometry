using System;
using System.Windows.Forms;
using Geometry.ApplicationLayer.Enums;
using Geometry.ApplicationLayer.EventArgs;
using Geometry.PresentationLayer.Interfaces;
using Geometry.Properties;

namespace Geometry
{
    /// <summary>
    /// The main editor view
    /// </summary>
    public partial class DrawingForm : Form, IEditorView
    {
        public DrawingForm()
        {
            InitializeComponent();
        }

        #region IEditorView Implementation

        public event EventHandler<EditorModeChangedEventArgs> OnEditorModeChanged;
        public event EventHandler<BrushShapeChangedEventArgs> OnEditorBrushShapeChanged;

        ///<inheritdoc />
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

        #region Editor tool changed event handling

        private void SelectButton_CheckedChanged(object sender, EventArgs e)
        {
            if (!selectButton.Checked) return;
            OnEditorModeChanged?.Invoke(this, new EditorModeChangedEventArgs(EditorModes.Selection));
        }

        private void DrawButton_CheckedChanged(object sender, EventArgs e)
        {
            if (!drawButton.Checked)
            {
                shapesGroupBox.Visible = false;
                return;
            }
            shapesGroupBox.Visible = true;
            OnEditorModeChanged?.Invoke(this, new EditorModeChangedEventArgs(EditorModes.Drawing));
        }

        private void MoveButton_CheckedChanged(object sender, EventArgs e)
        {
            if (!moveButton.Checked) return;
            OnEditorModeChanged?.Invoke(this, new EditorModeChangedEventArgs(EditorModes.Movement));
        }

        #endregion

        #region Brush shape changed event handling

        private void QuadrangleRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            OnEditorBrushShapeChanged?.Invoke(this, new BrushShapeChangedEventArgs(BrushShapes.Quadrangle));
        }

        private void TriangleRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            OnEditorBrushShapeChanged?.Invoke(this, new BrushShapeChangedEventArgs(BrushShapes.Triangle));
        }

        private void EllipseRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            OnEditorBrushShapeChanged?.Invoke(this, new BrushShapeChangedEventArgs(BrushShapes.Ellipse));
        }

        private void RhombusRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            OnEditorBrushShapeChanged?.Invoke(this, new BrushShapeChangedEventArgs(BrushShapes.Rhombus));
        }

        #endregion

        #region Messenger implementation

        public void ShowInformationMessage(string message, string caption)
        {
            MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void ShowErrorMessage(Exception ex)
        {
            MessageBox.Show($@"{ex.Message}/n/n{ex.StackTrace}", Resources.ErrorMessageBoxCaption, MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        #endregion
    }
}
