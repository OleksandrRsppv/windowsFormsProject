// Autor. mgr. inż Piotr Bilski
// Programowanie Obiektowe

using System.Drawing;
using System.Drawing.Drawing2D;

namespace PO_W_704
{
    // 11.
    // zmieniamy typ klasy na abstrakcyjną
    abstract class Figure
    {
        // 12.
        // następnie deklarujemy pola wspólne dla wszystkich klas pochodnych
        // ===============================================
        // !!!!! zadeklarować bez słowa protected!!!!!!!!!
        // ===============================================
        protected Color _lineColor;
        protected DashStyle _lineType;
        protected int _lineThickness;
        protected Color _fillColor;
        protected Point _pointA;
        string _figType;
        public GraphicsWorld graphicsWorld = new GraphicsWorld();

        // 13.
        // nawet klasy abstrakcyjne potrzebują konstruktorów
        // dlategto zadeklarujemy konstruktor domyślny
        // dla wszystkich klas pochodnych
        public Figure(Point pointA, Color lineColor, DashStyle lineType, int lineThickness,
                      Graphics graphArea, string type)
        {
            this._lineColor = lineColor;
            this._lineType = lineType;
            this._lineThickness = lineThickness;
            this._pointA = pointA;
            this._figType = type;
            graphicsWorld.graphicsBoard = graphArea;
        }

        // 14.
        // teraz zgodnie z zasadami deklarujemy abstrakcyjne metody funkcyjne
        // czyli metody bez implementacji, które będzie można nadpisywać
        // w klasach pochodnych
        public abstract void Draw();
        public abstract void Erase();
        public abstract void Move(int shiftX, int shiftY);
        //public abstract void Remove();

        // 15.
        // zadeklarujemy też metody pozwalającą
        // na modyfikowanie niektórych parametrów
        // ponieważ może się taka przydać 
        public virtual void ChangeGraphicsParameters(Color lineColor,
                                                     DashStyle lineType,
                                                     int lineThickness)
        {
            this._lineColor = lineColor;
            this._lineType = lineType;
            this._lineThickness = lineThickness;
        }
        public void ChangeGraphicsParameters(Color fillColor)
        {
            this._fillColor = fillColor;
        }

        // 16.
        // zadeklarujemy również właściwość ustawiającą pole opisowe typu figury
        // z charakterystycznym zapisem, pozwalającym na wykonanie tej operacji
        // jedynie w konstruktorze
        public string FigType
        {
            get { return _figType; }
            private set { _figType = value; }
        }

        // 17.
        // kolejny krok to szybkie wymodelowanie klas abstrakcyjncych
        // ===================================================================
        // stworzyć klasę Fig3D, Fig2D, Statyczne i obrotowe jako abstrakcyjne
        // ===================================================================
        // przejść do klasy Fig3D
    }
}
