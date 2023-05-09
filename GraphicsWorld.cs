// Autor. mgr. inż Piotr Bilski
// Programowanie Obiektowe

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace PO_W_704
{
    public partial class GraphicsWorld : Form
    {
        // 1. na początku zmieniamy nazwę klasy głównej,
        // i tworzymy drzewo klas zgodnie z zaplanowanym wzorcem

        // 2.
        // utworzenie referencji do kontenera Form
        public GraphicsWorld formReference;

        // 3.
        // oraz zmiennej typu Graphics, dzięki której
        // będzie możliwe rysowanie po powierzchni formy
        public Graphics graphicsBoard;

        // 4.
        // dodatkowo zapobiegawczo deklaracja listy
        // która będzie przechowywała obiekty typu Figura
        static List<Figure> graphList = new List<Figure>();

        // 5.
        // deklarujemy również tablicę, która będzie przechowywała
        // nazwy szystkich prymitywów graficznych jakie zdefiniujemy
        string[] primitiveName;

        public GraphicsWorld()
        {
            // 6.
            // w konstruktorze, wskazujemy cel zmiennej referencyjnej
            formReference = this;
            InitializeComponent();

            // 7. 
            // oraz wskazujemy na czym chcemy rysować
            graphicsBoard = formReference.CreateGraphics();

            // 8.
            // i wreszcie inicjalizujemy zadeklarowaną wcześniej tablicę
            primitiveName = new string[3];
            primitiveName[0] = "Koło";
            primitiveName[1] = "Równoległobok";
            primitiveName[2] = "Sześcian";
        }

        // 9.  
        // w celu poprawienia dostępu do tablicy
        // deklarujemy odpowiedni indekser 
        public string this[int index]
        {
            get { return primitiveName[index]; }
        }
        // 10.
        // w kolejnym kroku czas wymodelować klasę Figura
        // co zgodnie z zasadami uczynimy w nowym pliku

        // 62.
        // musimy tu wymodelować trzy grupy metod obsługujących zdarzenia
        // metody move, erase i draw dla planowanych do wyrysowania obiektów.
        private void DrawParallelogram_Click(object sender, EventArgs e)
        {
            Point pointA = new Point(80, 250);
            Point pointB = new Point(230, 250);
            Point pointC = new Point(180, 300);
            Point pointD = new Point(30, 300);
            Color lineColor = Color.Green;
            DashStyle lineType = DashStyle.Solid;
            int lineThickness = 3;
            string type = primitiveName[1];

            Figure parallelogram = new Parallelogram(pointA, pointB, pointC, pointD, lineColor, lineType, lineThickness, graphicsBoard, type); ;
            graphList.Add(parallelogram);
            parallelogram.Draw();
        }

        private void MoveParallelogram_Click(object sender, EventArgs e)
        {
            int shiftX = 50;
            int shiftY = 20;
            int figToMove = FindIndex(graphList, 1);
            graphList[figToMove].Move(shiftX, shiftY);
        }

        private void DeleteParallelogram_Click(object sender, EventArgs e)
        {
            int figToDelete = FindIndex(graphList, 1);
            graphList[figToDelete].Erase();
            graphList.RemoveAt(figToDelete);
        }

        private void DrawCircle_Click(object sender, EventArgs e)
        {
            Point point = new Point(300, 50);
            int r = 20;
            Color lineColor = Color.Red;
            DashStyle lineType = DashStyle.Solid;
            int lineThickness = 3;
            string type = primitiveName[0];

            Figure wheel = new Wheel(r, point, lineColor, lineType, lineThickness, graphicsBoard, type);
            graphList.Add(wheel);
            wheel.Draw();
        }

        private void MoveCircle_Click(object sender, EventArgs e)
        {
            int shiftX = 100;
            int shiftY = 20;
            int figToMove = FindIndex(graphList, 0);
            graphList[figToMove].Move(shiftX, shiftY);
        }

        private void DeleteCircle_Click(object sender, EventArgs e)
        {
            int figToDelete = FindIndex(graphList, 0);
            graphList[figToDelete].Erase();
            graphList.RemoveAt(figToDelete);
        }

        private int FindIndex(List<Figure> objectList, int index)
        {
            int lookingObjectIndex;
            return lookingObjectIndex = objectList.FindIndex(x => x.FigType == primitiveName[index]);
        }

        // cała koncepcja tego programu, na skutek zbyt dużych uproszczeń
        // jest obłożona dużym błędem logicznym, powodującym stały wyciek pamięci
        // związane jest to z faktem, że de facto nie kasujemy obiektów z listy
        // a jedynie je wymazuyjemy z planszy. Wydaje się, że koniecze było by 
        // wymodelowanie kolejnej metody która będzie kasowała obiekty z listy
        // ale to, tak jak i napisanie metody rysującej sześcian zostawiam już
        // państwu do samodzielnych ćwiczeń.
    }
}
