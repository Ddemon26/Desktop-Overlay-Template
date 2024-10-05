using UnityEngine;
using UnityEngine.UIElements;

public class MainView : MonoBehaviour
{
    UIDocument m_Document;
    VisualElement m_Root;
    
    void Start()
    {
        m_Document = GetComponent<UIDocument>();
        m_Root = m_Document.rootVisualElement;
        
        var label = new Label("Hello World!");
        m_Root.Add(label);
    }
}
