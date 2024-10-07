using TCS._Project.Scripts;
using UnityEngine;
using UnityEngine.EventSystems;

public class Clickthroughable : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    void OnMouseEnter()
    {
        Debug.Log("OnMouseEnter called");
        TransparentWindowEvents.OnForceNotClickthrough?.Invoke();
        Debug.Log("OnForceNotClickthrough event invoked");
    }
    
    void OnMouseExit()
    {
        Debug.Log("OnMouseExit called");
        TransparentWindowEvents.OnForceClickthrough?.Invoke();
        Debug.Log("OnForceClickthrough event invoked");
    }
    
    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log("OnPointerEnter called");
        TransparentWindowEvents.OnForceNotClickthrough?.Invoke();
        Debug.Log("OnForceNotClickthrough event invoked");
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        Debug.Log("OnPointerExit called");
        TransparentWindowEvents.OnForceClickthrough?.Invoke();
        Debug.Log("OnForceClickthrough event invoked");
    }
}