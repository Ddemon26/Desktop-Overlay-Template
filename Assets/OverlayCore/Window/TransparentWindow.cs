using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.EventSystems;

namespace TCS._Project.Scripts {
    public static class TransparentWindowEvents {
        public static Action OnForceClickthrough;   
        public static Action OnForceNotClickthrough;
    }
    public class TransparentWindow : MonoBehaviour
    {
        [DllImport("user32.dll")]
        public static extern int MessageBox(IntPtr hWnd, string text, string caption, uint type);

        [DllImport("user32.dll")]
        static extern IntPtr GetActiveWindow();

        [DllImport("user32.dll")]
        static extern int SetWindowLong(IntPtr hWnd, int nIndex, uint dwNewLong);

        [DllImport("user32.dll", SetLastError = true)]
        static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);

        [DllImport("user32.dll")]
        static extern int SetLayeredWindowAttributes(IntPtr hWnd, uint crKey, byte bAlpha, uint dwFlags);


        struct MARGINS {
            public int cxLeftWidth;
            public int cxRightWidth;
            public int cyTopHeight;
            public int cyBottomHeight;
        }

        [DllImport("Dwmapi.dll")]
        static extern uint DwmExtendFrameIntoClientArea(IntPtr hWnd, ref MARGINS margins);

        const int GWL_EXSTYLE = -20;
        const uint WS_EX_LAYERED = 0x00080000;
        const uint WS_EX_TRANSPARENT = 0x00000020;

        static readonly IntPtr HWND_TOPMOST = new(-1);
        const uint LWA_COLORKEY = 0x00000001;
        
        bool m_clickthrough;
        
        void ForceNotClickthrough() => m_clickthrough = false;
        void ForceClickthrough() => m_clickthrough = true;

        IntPtr hWnd;
        Camera m_camera;

        void Awake() {
            m_camera = Camera.main;
                        
            TransparentWindowEvents.OnForceClickthrough += ForceClickthrough;
            TransparentWindowEvents.OnForceNotClickthrough += ForceNotClickthrough;
        }

        void Start() {
            //MessageBox(new IntPtr(0), "Hello World!", "Hello Dialog", 0);

        #if !UNITY_EDITOR
        hWnd = GetActiveWindow();

        MARGINS margins = new MARGINS { cxLeftWidth = -1 };
        DwmExtendFrameIntoClientArea(hWnd, ref margins);

        //SetWindowLong(hWnd, GWL_EXSTYLE, WS_EX_LAYERED);

        SetWindowLong(hWnd, GWL_EXSTYLE, WS_EX_LAYERED | WS_EX_TRANSPARENT);
        //SetLayeredWindowAttributes(hWnd, 0, 0, LWA_COLORKEY);


        SetWindowPos(hWnd, HWND_TOPMOST, 0, 0, 0, 0, 0);
        #endif

            Application.runInBackground = true;
        }

        void Update() {
            SetClickthrough(!IsPointerOverUIOr3DObject());
        }
        
        void OnDestroy() {
            TransparentWindowEvents.OnForceClickthrough -= ForceClickthrough;
            TransparentWindowEvents.OnForceNotClickthrough -= ForceNotClickthrough;
        }
    
        public bool IsPointerOverUIOr3DObject() {
            if (!m_clickthrough) {
                return false;
            }
            
            // Check if the pointer is over a UI element
            if (EventSystem.current.IsPointerOverGameObject()) {
                return true;
            }

            var pe = new PointerEventData(EventSystem.current) {
                position = Input.mousePosition
            };
            List<RaycastResult> hits = new();
            EventSystem.current.RaycastAll(pe, hits);
            if (hits.Count > 0) {
                return true;
            }

            // Check if the pointer is over a 3D object
            var ray = m_camera.ScreenPointToRay(Input.mousePosition);
            return Physics.Raycast(ray, out _);
        }

        void SetClickthrough(bool clickthrough) {
            if (clickthrough) {
                SetWindowLong(hWnd, GWL_EXSTYLE, WS_EX_LAYERED | WS_EX_TRANSPARENT);
            } else {
                SetWindowLong(hWnd, GWL_EXSTYLE, WS_EX_LAYERED);
            }
        }
    }
}