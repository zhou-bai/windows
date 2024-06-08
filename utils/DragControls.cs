using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bookshop.utils
{
    internal class DragControls
    {
        bool isAllMouseButton = false;
        bool isMoving = false;
        object dragControl;
        Point controlStartLocation;
        Point mouseStartLocation;
        MouseButtons mouseButtons; 
        List<Control> addedControl = new List<Control>();
        //
        public DragControls() { 
            this.isAllMouseButton = true;
        }

        public DragControls(MouseButtons mouseButtons)
        {
            this.mouseButtons = mouseButtons;
        }

        void MouseDownEvent(object sender, MouseEventArgs e)
        {
            if (isAllMouseButton || e.Button == mouseButtons)
            {
                isMoving = true;
                dragControl = sender;
                controlStartLocation = (sender as Control).Location;
                if(sender is Form){
                    mouseStartLocation = Control.MousePosition;
                }
                else
                {
                    mouseStartLocation = (sender as Control).Parent.PointToClient(Control.MousePosition);
                }
                MessageBox.Show(mouseStartLocation.ToString());
            }
        }

        void MouseMoveEvent(object sender, MouseEventArgs e)
        {
            if (sender == dragControl)
            {
                if(isMoving){
                    if (sender is Form)
                    {
                        (sender as Form).Location = new Point(Control.MousePosition.X - mouseStartLocation.X, Control.MousePosition.Y - mouseStartLocation.Y);
                    }
                    else
                    {
                        (sender as Control).Location = new Point(controlStartLocation.X + Control.MousePosition.X - mouseStartLocation.X, controlStartLocation.Y + Control.MousePosition.Y - mouseStartLocation.Y);
                    }
                }
                else{
                    isMoving = false;
                    (dragControl as Control).Location = controlStartLocation;
                }
            }
        }

        void MouseUpEvent(object sender, MouseEventArgs e)
        {
            if (sender == dragControl)
            {
                isMoving = false;
            }
        }

        public bool AddControl(Control control)
        {
            if(addedControl.Contains(control))
                return false;
            else
            {
                control.MouseDown += MouseDownEvent;
                control.MouseMove += MouseMoveEvent;
                control.MouseUp += MouseUpEvent;
                addedControl.Add(control);
                return true;
            }
        }

        public bool RemoveControl(Control control)
        {
            if(addedControl.Contains(control))
            {
                control.MouseDown -= MouseDownEvent;
                control.MouseMove -= MouseMoveEvent;
                control.MouseUp -= MouseUpEvent;
                addedControl.Remove(control);
                return true;
            }
            else
                return false;
        }
    }
}
