// Autor. mgr. inż Piotr Bilski
// Programowanie Obiektowe

using System.Drawing;
using System.Drawing.Drawing2D;

namespace PO_W_704
{
    class Cube : Static3D
    {
        public Cube(Point pointA, Color lineColor, DashStyle lineType,
                        int lineThickness, Graphics graphArea, string type)
          : base(pointA, lineColor, lineType, lineThickness, graphArea, type)
        {

        }
        public override void Draw()
        {
            throw new System.NotImplementedException();
        }
        public override void Erase()
        {
            throw new System.NotImplementedException();
        }
        public override void Move(int shiftX, int shiftY)
        {
            throw new System.NotImplementedException();
        }
    }
}
