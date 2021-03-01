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
   
    class Circle : IDraw, IColor
    {
        private int diameter;
        private int locX = 0;
        private int locY = 0;
        private Ellipse circle = null;
    }

    public Circle(int d)
    {
        diameter = d;
    }
    void IDraw.Draw(Canvas canvas)
    {
        if (circle != null)
        {
            canvas.Children.Remove(circle);
        }
        else
        {
            circle = new Ellipse();
        }
        circle.Height = diameter;
        circle.Width = diameter;
        Canvas.SetTop(circle, locY);
        Canvas.SetLeft(circle, locX);
        canvas.Children.Add(circle);
    }

    void IDraw.SetLocation(int xCoord, int yCoord)
    {
        locX = xCoord;
        locY = yCoord;
    }

    void IColor.SetColor(Color color)
    {
        if (circle != null)
        {
            SolidColorBrush brush = new SolidColorBrush(color);
            circle.Fill = brush;
        }
    }
}
