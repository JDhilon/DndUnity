using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ItemButton : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{

    [SerializeField]
    private Canvas canvas;
    [SerializeField]
    private Camera uiCamera;

    [SerializeField]
    private GameObject item;

    [SerializeField]
    private GameObject tooltip;

    [SerializeField]
    private RectTransform backgroundRectTranform;

    [SerializeField]
    private Text tooltipText;

    /*
    private void Awake()
    {
        backgroundRectTranform = transform.Find("Background").GetComponent<RectTransform>();
        tooltipText = transform.Find("Text").GetComponent<Text>();
    }
    */
    public GameObject Item
    {
        get
        {
            return item;
        }
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        //Vector2 localPoint;
        //RectTransformUtility.ScreenPointToLocalPointInRectangle(transform.parent.GetComponent<RectTransform>(), Input.mousePosition, uiCamera, out localPoint);
        //backgroundRectTranform.anchoredPosition += eventData.delta / canvas.scaleFactor;
        //transform.localPosition = localPoint;
        setTooltip();
        showTooltip();
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        hideTooltip();
    }

    public void showTooltip()
    {
        tooltip.SetActive(true);
    }

    public void hideTooltip()
    {
        tooltip.SetActive(false);
    }

    public void setTooltip()
    {

        tooltipText.text = this.gameObject.name;
        //Text txt = tooltip.GetComponent<Text>();

        //txt.text = this.gameObject.name;
    }

    /*
    private void Update()
    {
        Vector2 localPoint;
        RectTransformUtility.ScreenPointToLocalPointInRectangle(transform.parent.GetComponent<RectTransform>(), Input.mousePosition, uiCamera, out localPoint);
        transform.localPosition = localPoint;
    }
    */

}
