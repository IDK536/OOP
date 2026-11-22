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
        private Stack<Command> commands = new Stack<Command>();

        private int shapeType;

        //private DrawCommand drawCommand;
        //private SetColorCommand setColorCommand;
        //private ScaleCommand scaleCommand;
        //private DeleteCommand deleteCommand;
        //private MoveCommand moveCommand;
        //private SelectCommand selectCommand;

        public Storage(int shapeType)
        {
            this.shapeType = shapeType;
        }

        public void SwitchTyep(int shapeType)
        {
            this.shapeType = shapeType;
        }

        public void Show(Graphics g)
        {
            for (int i = 0; i < shapes.Count; i++)
            {
                shapes[i].Draw(g);
            }
        }
        public void Draw(int x, int y)
        {
            Unselect();

            CShape? shape;
            switch (shapeType)
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

            Command command = new DrawCommand(this.shapes);
            command.Execute(shapes);

            commands.Push(command);
        }

        public void Remove()
        {
            List<CShape> selectedShapes = GetSelectedShapes();
            if (selectedShapes.Count == 0) return;

            Command command = new DeleteCommand(shapes);
            command.Execute(selectedShapes);

            commands.Push(command);
        }

        public bool Select(int x, int y, bool isCtrlPressed)
        {
            List<CShape> shapes = FindShapes(x, y);
            if (shapes.Count == 0)
            {
                return false;
            }

            if (!isCtrlPressed)
            {
                Unselect();
            }

            Command command = new SelectCommand(true);
            command.Execute(shapes);

            commands.Push(command);

            return true;
        }

        public void Move(int moveX, int moveY)
        {
            List<CShape> selectedShapes = GetSelectedShapes();
            if (selectedShapes.Count == 0) return;

            Command command = new MoveCommand(moveX, moveY);
            command.Execute(selectedShapes);

            commands.Push(command);
        }

        public void Scale(int scale)
        {
            List<CShape> selectedShapes = GetSelectedShapes();
            if (selectedShapes.Count == 0) return;

            Command command = new ScaleCommand(scale);
            command.Execute(selectedShapes);

            commands.Push(command);
        }

        public void SetColor(Color color)
        {
            List<CShape> selectedShapes = GetSelectedShapes();
            if (selectedShapes.Count == 0) return;

            Command command = new SetColorCommand(color);
            command.Execute(selectedShapes);

            commands.Push(command);
        }

        public void Undo()
        {
            if (commands.Count > 0)
            {
                Command command = commands.Pop();

                command.UnExecute();
            }
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

        private void Unselect()
        {
            List<CShape> selectedShapes = GetSelectedShapes();
            if (selectedShapes.Count == 0) return;

            Command command = new SelectCommand(false);
            command.Execute(selectedShapes);

            commands.Push(command);
        }
        private bool IsNoneSelected()
        {
            return GetSelectedShapes().Count == 0;
        }
    }
}