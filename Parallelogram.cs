// Autor. mgr. inż Piotr Bilski
// Programowanie Obiektowe

using System.Drawing;
using System.Drawing.Drawing2D;

namespace PO_W_704
{
    class Parallelogram : Fig2D
    {
        // 30.
        // na początek deklarujemy tablicę punktów,
        // któa pozwoli na wyrysowanie tego obiektu na formie
        PointF[] _parallelogram;

        // 31.
        // następnie oczywiście modelujemy konstruktora
        // wskazującego na pola w klasie nadrzędnej
        public Parallelogram(Point pointA, Point pointB, Point pointC, Point pointD,
                             Color lineColor, DashStyle lineType, int lineThickness,
                             Graphics graphArea, string type)
                   : base(pointA, lineColor, lineType, lineThickness, graphArea, type)
        {
            // 32.
            // tu musimy rozpisać kształt tablicy
            PointF[] temp =
            {
                pointA,
                pointB,
                pointC,
                pointD
            };
            this._parallelogram = temp;

            // 33.
            // oraz wskazać na zmienną referencyjną, która pozwoli nam
            // odwoływać sie do powieżchni formy
            graphicsWorld.graphicsBoard = graphArea;
        }

        // 33.
        // i wreszcie nadpisujemy metody funkcyjne.
        // na pierwszy ogień metodę Draw()
        public override void Draw()
        {
            // 34.
            // najpierw tworzymy obiekt typu Pen,
            // który będzie użyty do rysowania linii obrysowych,
            // i modelujemy w jego ciele odwołanie do pól klasy bazowej
            Pen pen = new Pen(this._lineColor, this._lineThickness);
            pen.DashStyle = this._lineType;

            // 35.
            // teraz wykreślamy równoległobok na płaszczyźnie formy,
            // za pomocą punktów opisanych w polutypu PointF
            // i narzędzia typu Pen
            graphicsWorld.graphicsBoard.DrawPolygon(pen, _parallelogram);

            // 36.
            // i na koniec zwalniamy ręcznie zasoby niezarządzane
            // czyli po prostu niszczymy obiekt typu Pen
            pen.Dispose();
        }

        // 37.
        // podobnie postępujemy z metodą Erase
        public override void Erase()
        {
            // 38.
            // tworzymy pióro poprzez odwołanie do pól klasy bazowej
            // ale jako kolor ustawiamy kolor tła na jakim wyrysowany
            // został ten obiekt
            Pen pen = new Pen(graphicsWorld.formReference.BackColor, this._lineThickness);
            pen.DashStyle = this._lineType;
            pen.StartCap = LineCap.Round;
            pen.EndCap = LineCap.Round;

            // 39.
            // wykreślamy równoległobok na płaszczyźnie formy
            graphicsWorld.graphicsBoard.DrawPolygon(pen, _parallelogram);

            // 40.
            // i zwolniamy zasoby pamięci pobrane przez pióro
            pen.Dispose();
        }

        // 41.
        // pozostała już tylko do nadpisania metoda Move
        public override void Move(int shiftX, int shiftY)
        {
            // 42.
            // na początku wywołujemy metodę wymazującą obiekt z formy
            Erase();

            // 43. 
            // następnie zmieniamy współrzędne punktów zapisane w tablicy
            _parallelogram[0].X = _parallelogram[0].X + shiftX;
            _parallelogram[0].Y = _parallelogram[0].Y + shiftY;
            _parallelogram[1].X = _parallelogram[1].X + shiftX;
            _parallelogram[1].Y = _parallelogram[1].Y + shiftY;
            _parallelogram[2].X = _parallelogram[2].X + shiftX;
            _parallelogram[2].Y = _parallelogram[2].Y + shiftY;
            _parallelogram[3].X = _parallelogram[3].X + shiftX;
            _parallelogram[3].Y = _parallelogram[3].Y + shiftY;

            // 44.
            // i ponowne wykreślamy ją na formie
            Draw();

            // 45.
            // te same operacje wykonamy dla figury typu koło
        }
    }
}
