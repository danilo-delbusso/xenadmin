/* Copyright (c) Citrix Systems, Inc. 
 * All rights reserved. 
 * 
 * Redistribution and use in source and binary forms, 
 * with or without modification, are permitted provided 
 * that the following conditions are met: 
 * 
 * *   Redistributions of source code must retain the above 
 *     copyright notice, this list of conditions and the 
 *     following disclaimer. 
 * *   Redistributions in binary form must reproduce the above 
 *     copyright notice, this list of conditions and the 
 *     following disclaimer in the documentation and/or other 
 *     materials provided with the distribution. 
 * 
 * THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND 
 * CONTRIBUTORS "AS IS" AND ANY EXPRESS OR IMPLIED WARRANTIES, 
 * INCLUDING, BUT NOT LIMITED TO, THE IMPLIED WARRANTIES OF 
 * MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE 
 * DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT HOLDER OR 
 * CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, 
 * SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, 
 * BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR 
 * SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS 
 * INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, 
 * WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING 
 * NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE 
 * OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF 
 * SUCH DAMAGE.
 */

using System.Collections.Generic;
using System.Drawing;

namespace XenAdmin.Controls.CustomDataGraph
{
    public abstract class DataGrid
    {
        protected GridLabels Labels;
        protected ArchiveMaintainer ArchiveMaintainer;

        protected DataGrid(ArchiveMaintainer archivemaintainer)
        {
            ArchiveMaintainer = archivemaintainer;
        }

        public abstract void DrawToBuffer(DrawAxisArgs args);
    }

    public class DataGridHorizontal : DataGrid
    {
        public DataGridHorizontal(ArchiveMaintainer archivemaintainer)
            : base(archivemaintainer)
        {
            Labels = GridLabels.All;
        }

        public override void DrawToBuffer(DrawAxisArgs args)
        {
            if (!(args is DrawAxisXArgs drawAxisXArgs))
                return;

            var labels = new Dictionary<long, string>();
            var last_i = long.MinValue;

            for (long i = drawAxisXArgs.Range.Min - (drawAxisXArgs.Range.Min % -drawAxisXArgs.Range.Resolution); i >= drawAxisXArgs.Range.Max; i += drawAxisXArgs.Range.Resolution)
            {
                string label = drawAxisXArgs.Range.GetRelativeString(i + ArchiveMaintainer.ClientServerOffset.Ticks, ArchiveMaintainer.GraphNow);
                if (last_i != long.MinValue && label == labels[last_i])
                    labels.Remove(last_i);
                labels[i] = label;
                last_i = i;
            }

            for (long i = drawAxisXArgs.Range.Min - (drawAxisXArgs.Range.Min % -drawAxisXArgs.Range.Resolution); i >= drawAxisXArgs.Range.Max; i += drawAxisXArgs.Range.Resolution)
            {
                LongPoint pt = LongPoint.TranslateToScreen(new LongPoint(i, 0), drawAxisXArgs.Range, DataRange.UnitRange, new LongRectangle(drawAxisXArgs.Rectangle));
                if (i != 0)
                    drawAxisXArgs.Graphics.DrawLine(Palette.GridPen, new Point((int)pt.X, drawAxisXArgs.Rectangle.Bottom), new Point((int)pt.X, drawAxisXArgs.Rectangle.Top));

                if (!drawAxisXArgs.ShowLabels)
                    continue;

                if (!labels.ContainsKey(i))
                    continue;
                string label = labels[i];

                if (Labels == GridLabels.MinMax && (i == drawAxisXArgs.Range.Min - (drawAxisXArgs.Range.Min % -drawAxisXArgs.Range.Resolution) || i + drawAxisXArgs.Range.Resolution < drawAxisXArgs.Range.Max))
                {
                    SizeF labelsize = drawAxisXArgs.Graphics.MeasureString(label, Palette.LabelFont);
                    drawAxisXArgs.Graphics.DrawString(label, Palette.LabelFont, Palette.LabelBrush, new PointF(i == drawAxisXArgs.Range.Min - (drawAxisXArgs.Range.Min % -drawAxisXArgs.Range.Resolution) ? (int)pt.X - labelsize.Width : (int)pt.X, drawAxisXArgs.Rectangle.Bottom));
                }
                else if (Labels == GridLabels.All)
                {
                    SizeF labelsize = drawAxisXArgs.Graphics.MeasureString(label, Palette.LabelFont);
                    drawAxisXArgs.Graphics.DrawString(label, Palette.LabelFont, Palette.LabelBrush, new PointF(i == drawAxisXArgs.Range.Min ? (int)pt.X - labelsize.Width : i == drawAxisXArgs.Range.Max ? (int)pt.X : (int)pt.X - (labelsize.Width / 2), drawAxisXArgs.Rectangle.Bottom));
                }
            }
        }
    }

    public class DataGridVertical : DataGrid
    {
        public DataGridVertical(ArchiveMaintainer archivemaintainer)
            : base(archivemaintainer)
        {
            Labels = GridLabels.MinMax;
        }

        public override void DrawToBuffer(DrawAxisArgs args)
        {
            if (!(args is DrawAxisYArgs drawAxisYArgs))
                return;

            for (double i = drawAxisYArgs.Range.Min; i <= drawAxisYArgs.Range.Max; i += drawAxisYArgs.Range.Resolution)
            {
                // make sure that the last point is args.Range.Max
                if (i + drawAxisYArgs.Range.Resolution > drawAxisYArgs.Range.Max)
                    i = drawAxisYArgs.Range.Max; 

                string label = drawAxisYArgs.Range.GetRelativeString(i);
                LongPoint pt = LongPoint.TranslateToScreen(new LongPoint(0, (long)i), DataTimeRange.UnitRange, drawAxisYArgs.Range, new LongRectangle(drawAxisYArgs.Rectangle));

                if (i != 0)
                    drawAxisYArgs.Graphics.DrawLine(Palette.GridPen, new Point(drawAxisYArgs.Rectangle.Right, (int)pt.Y), new Point(drawAxisYArgs.Rectangle.Left, (int)pt.Y));

                if (!drawAxisYArgs.ShowLabels)
                    continue;

                if (Labels == GridLabels.All)
                {
                    SizeF labelsize = drawAxisYArgs.Graphics.MeasureString(label, Palette.LabelFont);
                    drawAxisYArgs.Graphics.DrawString(label, Palette.LabelFont, Palette.LabelBrush, new PointF(drawAxisYArgs.Rectangle.Right, i == drawAxisYArgs.Range.Min ? (int)pt.Y - labelsize.Height : i == drawAxisYArgs.Range.Max ? (int)pt.Y : (int)pt.Y - (labelsize.Height / 2)));
                }
                else if (Labels == GridLabels.MinMax)
                {
                    if (i == drawAxisYArgs.Range.Min || i + drawAxisYArgs.Range.Resolution > drawAxisYArgs.Range.Max)
                    {
                        SizeF labelsize = drawAxisYArgs.Graphics.MeasureString(label, Palette.LabelFont);
                        drawAxisYArgs.Graphics.DrawString(label, Palette.LabelFont, Palette.LabelBrush, new PointF(drawAxisYArgs.Rectangle.Right, i == drawAxisYArgs.Range.Min ? (int)pt.Y - labelsize.Height : i == drawAxisYArgs.Range.Max ? (int)pt.Y : (int)pt.Y - (labelsize.Height / 2)));
                    }

                    // draw units
                    string unitString = drawAxisYArgs.Range.UnitString;
                    if (!string.IsNullOrEmpty(unitString))
                    {
                        SizeF unitssize = drawAxisYArgs.Graphics.MeasureString(unitString, Palette.LabelFont);
                        drawAxisYArgs.Graphics.DrawString(unitString,
                            Palette.LabelFont,
                            Palette.LabelBrush,
                            new PointF(drawAxisYArgs.Rectangle.Right, drawAxisYArgs.Rectangle.Top + (drawAxisYArgs.Rectangle.Height / 2) - (unitssize.Height / 2)));
                    }
                }
            }
        }
    }


    public class DataGridNav : DataGrid
    {
        public DataGridNav(ArchiveMaintainer archivemaintainer)
            : base(archivemaintainer)
        {
            Labels = GridLabels.All;
        }

        public override void DrawToBuffer(DrawAxisArgs args)
        {
            if (!(args is DrawAxisNavArgs drawAxisNavArgs))
                return;

            for (long i = drawAxisNavArgs.Range.Min - (drawAxisNavArgs.Range.Min % -drawAxisNavArgs.Range.Resolution); i >= drawAxisNavArgs.Range.Max; i += drawAxisNavArgs.Range.Resolution)
            {
                string label = drawAxisNavArgs.Range.GetRelativeString(i + ArchiveMaintainer.ClientServerOffset.Ticks, ArchiveMaintainer.GraphNow);
                LongPoint pt = LongPoint.TranslateToScreen(new LongPoint(i, 0), drawAxisNavArgs.Range, DataRange.UnitRange, new LongRectangle(drawAxisNavArgs.Rectangle));
                if (i != 0)
                    drawAxisNavArgs.Graphics.DrawLine(Palette.GridPen, new Point((int)pt.X, drawAxisNavArgs.Rectangle.Bottom), new Point((int)pt.X, drawAxisNavArgs.Rectangle.Top));
                if (drawAxisNavArgs.ShowLabels && Labels == GridLabels.All)
                {
                    drawAxisNavArgs.Graphics.DrawString(label, Palette.LabelFont, Palette.LabelBrush, new PointF((int)pt.X, drawAxisNavArgs.Rectangle.Top));
                }

            }
        }
    }

    public enum GridLabels { None, MinMax, All }
}
