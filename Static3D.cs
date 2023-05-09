// Autor. mgr. inż Piotr Bilski
// Programowanie Obiektowe

using System.Drawing;
using System.Drawing.Drawing2D;

namespace PO_W_704
{
    // 24.
    // dopisujemy słowo abstract
    abstract class Static3D : Fig3D
    {
        // 25.
        // modelijemy konstrujktora
        public Static3D(Point pointA, Color lineColor, DashStyle lineType,
                         int lineThickness, Graphics graphArea, string type)
           : base(pointA, lineColor, lineType, lineThickness, graphArea, type)
        { }

        // 26.
        // przechodzimy do klasy Obrotowe
    }
}
