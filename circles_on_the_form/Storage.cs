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
        private Stack<Stack<Command>> commands = new Stack<Stack<Command>>();

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
            Stack<Command> commandStack = new Stack<Command>();
            Unselect(commandStack);

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

            Command command = new DrawCommand(this.shapes);
            command.Execute(shape);


            commandStack.Push(command);
            commands.Push(commandStack);
        }

        public void Remove()
        {
            List<CShape> selectedShapes = GetSelectedShapes();
            if (selectedShapes.Count == 0) return;

            Stack<Command> commandStack = new Stack<Command>();

            for (int i = 0; i < selectedShapes.Count; i++)
            {
                Command command = new DeleteCommand(shapes);
                command.Execute(selectedShapes[i]);

                commandStack.Push(command);
            }

            commands.Push(commandStack);
        }

        public bool Select(int x, int y, bool isCtrlPressed)
        {
            List<CShape> shapes = FindShapes(x, y);
            if (shapes.Count == 0)
            {
                return false;
            }

            Stack<Command> commandStack = new Stack<Command>();

            if (!isCtrlPressed)
            {
                Unselect(commandStack);
            }

            for (int i = 0; i < shapes.Count; i++)
            {
                Command command1 = new SelectCommand(true);
                command1.Execute(shapes[i]);

                commandStack.Push(command1);
            }

            commands.Push(commandStack);

            return true;
        }

        public void Move(int moveX, int moveY)
        {
            List<CShape> selectedShapes = GetSelectedShapes();
            if (selectedShapes.Count == 0) return;

            Stack<Command> commandStack = new Stack<Command>();

            for (int i = 0; i < selectedShapes.Count; i++)
            {
                Command command = new MoveCommand(moveX, moveY);
                command.Execute(selectedShapes[i]);

                commandStack.Push(command);
            }

            commands.Push(commandStack);
        }

        public void Scale(int scale)
        {
            List<CShape> selectedShapes = GetSelectedShapes();
            if (selectedShapes.Count == 0) return;

            Stack<Command> commandStack = new Stack<Command>();

            for (int i = 0; i < shapes.Count; i++)
            {
                Command command = new ScaleCommand(scale);
                command.Execute(selectedShapes[i]);

                commandStack.Push(command);
            }

            commands.Push(commandStack);
        }

        public void SetColor(Color color)
        {
            List<CShape> selectedShapes = GetSelectedShapes();
            if (selectedShapes.Count == 0) return;

            Stack<Command> commandStack = new Stack<Command>();

            for (int i = 0; i < shapes.Count; i++)
            {
                Command command = new SetColorCommand(color);
                command.Execute(selectedShapes[i]);

                commandStack.Push(command);
            }

            commands.Push(commandStack);
        }

        public void Undo()
        {
            if (commands.Count > 0)
            {
                Stack<Command> commandStack = commands.Pop();

                while (commandStack.Count > 0)
                {
                    Command command = commandStack.Pop();

                    command.UnExecute();
                }
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

        private void Unselect(Stack<Command> commandStack)
        {
            List<CShape> selectedShapes = GetSelectedShapes();
            if (selectedShapes.Count == 0) return;

            for (int i = 0; i < selectedShapes.Count; i++)
            {
                Command command = new SelectCommand(false);
                command.Execute(selectedShapes[i]);
                commandStack.Push(command);
            }
        }
    }
}