using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class rightbtn : MonoBehaviour,IPointerDownHandler,IPointerUpHandler
{
    public void OnPointerDown(PointerEventData eventData)
    {

        PlayerControl.right = true;
        PlayerControl.left = false;
    }


    public void OnPointerUp(PointerEventData eventData)
    {
        PlayerControl.right = false;
    }


}
