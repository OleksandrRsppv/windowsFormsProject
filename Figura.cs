using System.Drawing;
using System.Drawing.Drawing2D;

namespace PO_W_704
{
    // 11.
    // zmieniamy typ klasy na abstrakcyjną
    abstract class Figura
    {
        // 12.
        // następnie deklarujemy pola wspólne dla wszystkich klas pochodnych
        // ===============================================
        // !!!!! zadeklarować bez słowa protected!!!!!!!!!
        // ===============================================
        protected Color lineColor;
        protected DashStyle lineType;
        protected int lineThickness;
        protected Color fillColor;
        string figType;
        public GraphicsWorld graphicsWorld = new GraphicsWorld();

        // 13.
        // nawet klasy abstrakcyjne potrzebują konstruktorów
        // dlategto zadeklarujemy konstruktor domyślny
        // dla wszystkich klas pochodnych
        public Figura(Color kolorLinii, DashStyle typLinii, int gruboscLinii,
                      Graphics plansza, string type)
        {
            this.lineColor = kolorLinii;
            this.lineType = typLinii;
            this.lineThickness = gruboscLinii;
            this.figType = type;
            graphicsWorld.planszaGraficzna = plansza;
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
        public virtual void ChangeGraphicsParameters(Color kolorLinii, 
                                                     DashStyle typLinii,                                                     
                                                     int gruboscLinii)
        {
            this.lineColor = kolorLinii;
            this.lineType = typLinii;
            this.lineThickness = gruboscLinii;
        }
        public void ChangeGraphicsParameters(Color kolorWypelnienia)
        {
            this.fillColor = kolorWypelnienia;
        }

        // 16.
        // zadeklarujemy również właściwość ustawiającą pole opisowe typu figury
        // z charakterystycznym zapisem, pozwalającym na wykonanie tej operacji
        // jedynie w konstruktorze
        public string FigType
        {
            get { return figType; }
            private set { figType = value; }
        }

        // 17.
        // kolejny krok to szybkie wymodelowanie klas abstrakcyjncych
        // ===================================================================
        // stworzyć klasę Fig3D, Fig2D, Statyczne i obrotowe jako abstrakcyjne
        // ===================================================================
        // przejść do klasy Fig3D
    }
}
