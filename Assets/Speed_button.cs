using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Speed_button : Button
{
    public override void OnPointerDown(PointerEventData eventData)
    {
        base.OnPointerDown(eventData);
        Debug.Log("Down");
        //show text
    }

    public override void OnPointerUp(PointerEventData eventData)
    {
        base.OnPointerUp(eventData);
        Debug.Log("Up");
        //hide text
    }
}
