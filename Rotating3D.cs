// Autor. mgr. inż Piotr Bilski
// Programowanie Obiektowe

using System.Drawing;
using System.Drawing.Drawing2D;

namespace PO_W_704
{
    // 27.
    // dodajemy słowo kluczowe abstract
    abstract class Rotating3D : Fig3D
    {
        // 28.
        // i pon ownie tylko konstruktor, ponieważ to klasa abstrakcyjna
        public Rotating3D(Point pointA, Color lineColor, DashStyle lineType,
                        int lineThickness, Graphics graphArea, string type)
          : base(pointA, lineColor, lineType, lineThickness, graphArea, type)
        { }

        // 29.
        // wreszcie zaczynamy modelować klasy obiektów,
        // które będą rysowane, i zaczynamy od klasy Rownoległobok
    }
}
