using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class MyRenderer : ToolStripProfessionalRenderer
{
    protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
    {
        if (e.Item.Selected)
        {
            // لون خلفية مع شفافية
            Color hoverColor = Color.FromArgb(120, 0, 206, 209); 
            using (SolidBrush brush = new SolidBrush(hoverColor))
            {
                e.Graphics.FillRectangle(brush, e.Item.ContentRectangle);
            }
        }
        else
        {
            base.OnRenderMenuItemBackground(e);
        }
    }

    protected override void OnRenderItemText(ToolStripItemTextRenderEventArgs e)
    {
        if (e.Item.Selected)
        {
            e.TextColor = Color.White;
        }
        base.OnRenderItemText(e);
    }
}
