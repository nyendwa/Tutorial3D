using System;
using GLFW;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static Tutorial3D.OpenGL.GL;
using OpenTK.Mathematics;
using OpenTK.Windowing;
using OpenTK.Graphics;
using System.Threading.Tasks;
using System.Drawing;

namespace Tutorial3D.Rendering.DisplayManager
{
    static class DisplayManager
    {
        public static Window window { get; set; }
        public static Vector2 WindowSize { get; set; }
        public static void CreateWindow(int width,int height, string title)
        {
            WindowSize=new Vector2(width,height);
            Glfw.Init();

            Glfw.WindowHint(Hint.ContextVersionMajor, 3);
            Glfw.WindowHint(Hint.ContextVersionMinor, 3);
            Glfw.WindowHint(Hint.OpenglProfile, Profile.Core);

            Glfw.WindowHint(Hint.Focused,true);
            Glfw.WindowHint(Hint.Resizable, false);
            window = Glfw.CreateWindow(width,
                                       height,
                                       title,
                                       Glfw.Monitor,
                                       Window.None);

            if (window == Window.None)
            {
                return;
            }

            Rectangle screen = Glfw.PrimaryMonitor.WorkArea;
            int x = (screen.Width - width) / 2;
            int y = (screen.Height - height) / 2;

            Glfw.SetWindowPosition(window,x,y);

            Glfw.MakeContextCurrent(window);
            Import(Glfw.GetProcAddress);

            glViewport(0,0,width,height);
            Glfw.SwapInterval(0);

        }
        public static void CloseWindow()
        {
            Glfw.Terminate();
        }
    }
}
