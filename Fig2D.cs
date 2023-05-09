// Autor. mgr. inż Piotr Bilski
// Programowanie Obiektowe

using System.Drawing;
using System.Drawing.Drawing2D;

namespace PO_W_704
{
    // 21.
    // dopisujemy słowo kluczowe abstract
    abstract class Fig2D : Figure
    {
        // 22.
        // i modelujemy konstruktora, ze wskazaniem na pola klasy matki
        public Fig2D(Point pointA, Color lineColor, DashStyle lineType,
                     int lineThickness, Graphics graphArea, string type)
              : base(pointA, lineColor, lineType, lineThickness, graphArea, type)
        { }

        // 23. 
        // potem klasa Statyczne
    }
}