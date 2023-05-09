// Autor. mgr. inż Piotr Bilski
// Programowanie Obiektowe

using System.Drawing;
using System.Drawing.Drawing2D;

namespace PO_W_704
{
    // 18.
    // na początku dodajemy modyfikator abstract w deklaracji klasy
    abstract class Fig3D : Figure
    {
        // 19.
        // następnie przepisujemy konstruktor,
        // ze wskazaniem na pola klasy nadrzędnej
        public Fig3D(Point pointA, Color lineColor, DashStyle lineType,
                     int lineThickness, Graphics graphArea, string type)
               : base(pointA, lineColor, lineType, lineThickness, graphArea, type)
        { }
        // 20.
        // podobnie implementujemy klasę Fig2D
    }
}