using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;

namespace Bookshop.Components
{
    public partial class MouseMoveController : Component
    {
        public Form Form { get; set; }
        
        private List<Control> Controls { get; set; } = new List<Control>();
        private Dictionary<Control, Point> dictMouseDownPoint { get; set; } = new Dictionary<Control, Point>();
        private bool isMoving = false;

        public MouseMoveController()
        {
            InitializeComponent();
        }

        public MouseMoveController(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        // 添加一个控件
        public void Add(Control control)
        {
            InitControlEvents(control);
        }

        // 添加多个控件 
        public void Add(ICollection<Control> controls)
        {
            foreach (var control in controls)
            {
                Add(control);
            }
        }


        private void InitControlEvents(Control control)
        {
            control.MouseDown += (obj,args) =>{
                if (args.Button == MouseButtons.Left)
                {
                    Point mouseSet = Control.MousePosition;
                    if (dictMouseDownPoint.ContainsKey(obj as Control))
                    {
                        dictMouseDownPoint[obj as Control] = new Point(Form.Location.X - mouseSet.X, Form.Location.Y - mouseSet.Y);
                    }
                    else
                    {
                        dictMouseDownPoint.Add(obj as Control, new Point(Form.Location.X - mouseSet.X, Form.Location.Y - mouseSet.Y));
                    }
                    isMoving = true;
                }
            };
            control.MouseMove += (obj, args) =>
            {
                if (isMoving)
                {
                    Point mouseSet = Control.MousePosition;
                    mouseSet.Offset(dictMouseDownPoint[obj as Control]);
                    Form.Location = mouseSet;
                }
            };
            control.MouseUp += (obj, args) =>
            {
                if (isMoving)
                {
                    isMoving = false;
                }
            };
        }
    }
}
