using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Shapes;
using Windows.UI.Xaml.Controls;

namespace Drawing
{
    class Square : IDraw, IColor
    {
        private int sideLength = 0;
        private int locX = 0;
        private int locY = 0;
        private Rectangle rect = null;

        void IDraw.Draw(Canvas canvas)
        {
            if (rect != null)
            {
                canvas.Children.Remove(rect);
            }
            else
            {
                rect = new Rectangle();
            }
            rect.Height = sideLength;
            rect.Width = sideLength;
            Canvas.SetTop(rect, locY);
            Canvas.SetLeft(rect, locX);
            canvas.Children.Add(rect);
        }


        void IDraw.SetLocation(int xCoord, int yCoord)
        {
            locX = xCoord;
            locY = yCoord;
        }

        void IColor.SetColor(Color color)
        {
            if (this.rect != null)
            {
                SolidColorBrush brush = new SolidColorBrush(color);
                this.rect.Fill = brush;
            }
        }





    }


    
}
