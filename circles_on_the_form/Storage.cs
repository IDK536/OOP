using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace circles_on_the_form
{
    internal class Storage
    {
        private List<CShape> shapes = new List<CShape>();
        private List<Command> commands = new List<Command>();

        private DrawCommand drawCommand;//
        private SetColorCommand setColorCommand;//
        private ScaleCommand scaleCommand;//
        private DeleteCommand deleteCommand;//
        private MoveCommand moveCommand;//
        private SelectCommand selectCommand;//

        public void Add(int ShapeType, int x, int y)
        {
            CShape? shape;
            switch (ShapeType)
            {
                case 0:
                    shape = new CCircle(x, y);
                    break;
                case 1:
                    shape = new CSquare(x, y);
                    break;
                case 2:
                    shape = new CTriangle(x, y);
                    break;
                default:
                    throw new ArgumentException("Invalid shape type");
            }

            List<CShape> shapes = new List<CShape> { shape };

            Command command = new DrawCommand(shapes);
            command.Execute(shapes);

            commands.Add(command);
        }

        public void Remove()
        {
            List<CShape> selectedShapes = GetSelectedShapes();

            Command command = new DeleteCommand(selectedShapes);
            command.Execute(shapes);

            commands.Add(command);
        }

        public void Select(int x, int y, bool isCtrlPressed)
        {
            List<CShape> shapes = FindShapes(x, y);

            Command command = new SelectCommand();
            command.Execute(shapes);

            commands.Add(command);
        }

        public void Move(int moveX, int moveY)
        {
            List<CShape> selectedShapes = GetSelectedShapes();

            Command command = new MoveCommand(moveX, moveY);
            command.Execute(selectedShapes);

            commands.Add(command);
        }

        public void Scale(int scale)
        {
            List<CShape> selectedShapes = GetSelectedShapes();

            Command command = new ScaleCommand(scale);
            command.Execute(selectedShapes);

            commands.Add(command);
        }

        public void SetColor(Color color)
        {
            List<CShape> selectedShapes = GetSelectedShapes();

            Command command = new SetColorCommand(color);
            command.Execute(selectedShapes);

            commands.Add(command);
        }



        private List<CShape> GetSelectedShapes()
        {
            List<CShape> selectedShapes = new List<CShape>();
            for (int i = 0; i < shapes.Count; i++)
            {
                if (shapes[i].IsSelected)
                {
                    selectedShapes.Add(shapes[i]);
                }
            }
            return selectedShapes;
        }

        private List<CShape> FindShapes(int x, int y)
        {
            List<CShape> foundShapes = new List<CShape>();
            for (int i = 0; i < shapes.Count; i++)
            {
                if (shapes[i].In(x, y))
                {
                    foundShapes.Add(shapes[i]);
                    //break;
                }
            }
            return foundShapes;
        }
    }
}