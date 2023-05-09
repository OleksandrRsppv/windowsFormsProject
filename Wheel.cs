// Autor. mgr. inż Piotr Bilski
// Programowanie Obiektowe

using System.Drawing;
using System.Drawing.Drawing2D;

namespace PO_W_704
{
    class Wheel : Fig2D
    {
        // 46.
        // najpierw deklaracja pól charakterystycznych tylko dla tej figury
        int _radius;
        Point _point;

        // 47.
        // potem konstruktor z przypisanie wartości
        public Wheel(int radius, Point pointA, Color lineColor, DashStyle lineType,
                    int lineThickness, Graphics graphArea, string type)
                   : base(pointA, lineColor, lineType, lineThickness, graphArea, type)
        {
            this._radius = radius;
            graphicsWorld.graphicsBoard = graphArea;
            _point = pointA;
        }

        // 48. 
        // w kolejnym kroku metoda Draw()
        public override void Draw()
        {
            // 49.
            // tworzymy pióro z odwołaniem do pól klasy bazowej
            Pen pen = new Pen(this._lineColor, this._lineThickness);
            pen.DashStyle = this._lineType;

            // 50.
            // deklarujemy sztywną wartość promienia
            _radius = 20;

            // 51.
            // wykreślamy koło na płaszczyźnie formy
            graphicsWorld.graphicsBoard.DrawEllipse(pen, _point.X, _point.Y,
                                         _radius * 2, _radius * 2);
            // 52.
            // i zwalniamy zasoby pamięci pobranych przez pióro
            pen.Dispose();
        }

        // 53.
        // teraz metoda Erase(), podobnie jak w klasie Równoległobok
        public override void Erase()
        {
            // 54.
            // utworzenie pióra ze wskazaniem na pola klasy bazowej
            Pen pen = new Pen(graphicsWorld.formReference.BackColor,
                              this._lineThickness);
            pen.DashStyle = this._lineType;
            pen.StartCap = LineCap.Round;
            pen.EndCap = LineCap.Round;

            // 55.
            // wykreślenie koła na płaszczyźnie formy
            graphicsWorld.graphicsBoard.DrawEllipse(pen, _point.X, _point.Y,
                                          _radius * 2, _radius * 2);
            // 56.
            // i zwolnienie zasobów pamięci pobranych przez pióro
            pen.Dispose();
        }

        // 57.
        // i na koniec nadpisujemy metodę Move
        public override void Move(int shiftX, int shiftY)
        {
            // 58.
            // zamazujemy obecnie wyrysowaną
            Erase();

            // 59.
            // zmieniamy położenie punktu zaczepienia
            _point.X = _point.X + shiftX;
            _point.Y = _point.Y + shiftY;

            // 60.
            // i ponowne wykreślamy koło na nowych współrzednych
            Draw();
        }

        // 61.
        // Przyszedł wreszcie czas na napisanie metod obsługi 
        // zdarzenia click dla osadzonych na formie obiektów typu button
        // robimy to oczywiście w klasie głównej programu, 
        // czyli w klasie GraphicsWorld
    }
}
