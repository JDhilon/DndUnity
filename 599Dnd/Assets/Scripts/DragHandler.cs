using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class DragHandler : MonoBehaviour, IDragHandler, IPointerDownHandler
{

    [SerializeField]
    private RectTransform dragRectTransform;

    [SerializeField]
    private Canvas canvas;


    /*
    public void OnDrag(PointerEventData eventData)
    {
        transform.position = Input.mousePosition;
        //transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        //Vector3 mousePos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0f);
        //transform.localPosition = Camera.main.ScreenToWorldPoint(Camera.main.ScreenToWorldPoint(Input.mousePosition));
        transform.localPosition = Input.mousePosition;
        //transform.localPosition = mousePos;

    }
    */

    public void OnDrag(PointerEventData eventData)
    {
        dragRectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor;
    }

   
    public void OnPointerDown(PointerEventData eventData)
    {
        dragRectTransform.SetAsLastSibling();
    }
}
