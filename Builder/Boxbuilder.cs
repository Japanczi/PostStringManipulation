using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace PostStringManipulation
{
    public static class Boxbuilder
    {
        static Boxbuilder()
        {
            Position = new Point(defaultMarginX, 0);
        }

        public enum Positioning
        {
            Vertical = 0,
            Horizontal = 1
        }

        public static void Reset()
        {
            Position = new Point(defaultMarginX, 0);
        }

        public static TextBox BuildTextBox(int width = 100, int height = 20)
        {
            TextBox textBox = new TextBox
            {
                Size = new Size(width, height)
            };

            return textBox;
        }

        private static bool TrySetPosition(GroupBox container, int offset_X, int offset_Y, TextBox box1, TextBox box2, Positioning positioning)
        {
            Point position = Position;
            if (positioning == Positioning.Vertical)
            {
                int maxWidth = box1.Width;
                if (box2.Width > box1.Width)
                    maxWidth = box2.Width;

                int joinedHeight = box2.Height + box1.Height;
                box1.Location = new Point(position.X, position.Y + defaultMarginY);
                box2.Location = new Point(box1.Location.X, position.Y + box2.Height);
                int joinedPositionY = box1.Location.Y + box1.Height + box2.Height;

                // if there is still space in Y axis, create objects
                if (joinedPositionY < container.Height - joinedHeight - defaultMarginY)
                {
                    box1.Location = new Point(position.X, box1.Location.Y);
                    box2.Location = new Point(position.X, box1.Location.Y + box2.Height);
                    position = new Point(box1.Location.X, box2.Location.Y + offset_Y);
                }
                // if there is not enough space in Y axis but still enough in X, move to next column and create objects
                else if (box1.Location.X < container.Width - maxWidth - defaultMarginX)
                {
                    box1.Location = new Point(box1.Location.X + maxWidth + offset_X, defaultMarginY);
                    box2.Location = new Point(box1.Location.X, box1.Location.Y + box1.Height);
                    position = new Point(box1.Location.X, 0);
                }
                else
                    return false;

                Position = position;
                return true;
            }


            if (positioning == Positioning.Horizontal)
            {
                int maxHeight = box1.Height;
                if (box2.Height > box1.Height)
                    maxHeight = box2.Height;

                int joinedWidth = box2.Width + box1.Width;
                box1.Location = new Point(position.X, position.Y + defaultMarginY);
                box2.Location = new Point(box1.Location.X, position.Y + box2.Height);
                int joinedPositionX = box1.Location.X + box1.Width + box2.Width;

                // if there is still space in Y axis, create objects
                if (box1.Location.Y < container.Height - maxHeight - defaultMarginY)
                {
                    box1.Location = new Point(position.X, box1.Location.Y);
                    box2.Location = new Point(position.X + box2.Width, box1.Location.Y);
                    position = new Point(box1.Location.X, box2.Location.Y + offset_Y);
                }
                // if there is not enough space in Y axis but still enough in X, move to next column and create objects
                else if (joinedPositionX < container.Width - joinedWidth - defaultMarginX)
                {
                    box1.Location = new Point(box1.Location.X + joinedWidth + offset_X, defaultMarginY);
                    box2.Location = new Point(box1.Location.X + box2.Width, box1.Location.Y);
                    position = new Point(box1.Location.X, 0);
                }
                else
                    return false;

                Position = position;
                return true;

            }

            return true;
        }

        public static List<TextBox> BuildCoupledTextBoxes(GroupBox container, int offset_X, int offset_Y, Positioning positioning, string content1 = null, string content2 = null)
        {
            TextBox textBox1 = BuildTextBox();
            TextBox textBox2 = BuildTextBox();

            if (!TrySetPosition(container, offset_X, offset_Y, textBox1, textBox2, positioning))
                return null;

            textBox1.Text = content1;
            textBox2.Text = content2;

            List<TextBox> textBoxes = new List<TextBox>() { textBox1, textBox2 };

            return textBoxes;
        }

        private static readonly int defaultMarginX = 20;
        private static readonly int defaultMarginY = 20;
        public static Point Position { get; set; }
    }
}
