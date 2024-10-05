using System.Collections.Generic;
using TCS._Project.Scripts;
using UnityEngine;
using UnityEngine.UIElements;

namespace TCS
{
    public class VisualElementClickthroughable : MonoBehaviour
    {
        UIDocument m_document;
        VisualElement root;

        public List<string> m_elementTags = new();
        List<VisualElement> m_childrenNotClickthroughable = new();
        
        void Awake()
        {   
            m_document = GetComponent<UIDocument>();
            root = m_document.rootVisualElement;
        }
        
        void OnEnable()
        {
            root.RegisterCallback<MouseEnterEvent>(_ => OnMouseEnter());
            root.RegisterCallback<MouseLeaveEvent>(OnMouseLeave);

            foreach (var s in m_elementTags)
            {
                var element = root.Q<VisualElement>(s);
                if (element != null)
                {
                    element.RegisterCallback<MouseEnterEvent>(evt => OnMouseEnter());
                    element.RegisterCallback<MouseLeaveEvent>(OnMouseLeave);
                    m_childrenNotClickthroughable.Add(element);
                }
            }
        }
        
        void OnDisable()
        {
            root.UnregisterCallback<MouseEnterEvent>(_ => OnMouseEnter());
            root.UnregisterCallback<MouseLeaveEvent>(OnMouseLeave);

            foreach (var element in m_childrenNotClickthroughable)
            {
                element.UnregisterCallback<MouseEnterEvent>(_ => OnMouseEnter());
                element.UnregisterCallback<MouseLeaveEvent>(OnMouseLeave);
            }
            m_childrenNotClickthroughable.Clear();
        }
        
        void OnMouseEnter()
        {
            TransparentWindowEvents.OnForceNotClickthrough?.Invoke();
            Debug.Log("OnForceNotClickthrough event invoked");
        }
        
        void OnMouseLeave(MouseLeaveEvent evt)
        {
            TransparentWindowEvents.OnForceClickthrough?.Invoke();
            Debug.Log("OnForceClickthrough event invoked");
        }
    }
}