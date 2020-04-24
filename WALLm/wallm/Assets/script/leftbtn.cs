using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class leftbtn : MonoBehaviour,IPointerDownHandler,IPointerUpHandler
{
    public void OnPointerDown(PointerEventData eventData)
    {
        PlayerControl.left = true;
        PlayerControl.right = false;
    }


    public void OnPointerUp(PointerEventData eventData)
    {
        PlayerControl.left = false;
    }


}
