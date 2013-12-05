using System;
using System.Drawing;
using System.Windows.Forms;

public class ScrollTextBox : TextBox
{
    private bool mScrollbars;
    public ScrollTextBox()
    {
        this.Multiline = true;
        this.ReadOnly = true;
    }
    private void checkForScrollbars()
    {
        bool scroll = false;
        int cnt = this.Lines.Length;
        if (cnt > 1)
        {
            int pos0 = this.GetPositionFromCharIndex(this.GetFirstCharIndexFromLine(0)).Y;
            if (pos0 >= 32768) pos0 -= 65536;
            int pos1 = this.GetPositionFromCharIndex(this.GetFirstCharIndexFromLine(1)).Y;
            if (pos1 >= 32768) pos1 -= 65536;
            int h = pos1 - pos0;
            scroll = cnt * h > (this.ClientSize.Height - 6);  // 6 = padding
        }
        if (scroll != mScrollbars)
        {
            mScrollbars = scroll;
            this.ScrollBars = scroll ? ScrollBars.Vertical : ScrollBars.None;
        }
    }

    protected override void OnTextChanged(EventArgs e)
    {
        checkForScrollbars();
        base.OnTextChanged(e);
    }

    protected override void OnClientSizeChanged(EventArgs e)
    {
        checkForScrollbars();
        base.OnClientSizeChanged(e);
    }
}