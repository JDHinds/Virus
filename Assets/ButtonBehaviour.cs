using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ButtonBehaviour : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    void Start()
    {
        this.gameObject.GetComponent<Button>().image.enabled = false;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        this.gameObject.GetComponent<Button>().image.enabled = true;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        this.gameObject.GetComponent<Button>().image.enabled = false;
    }

public void onClick()
    {
        this.gameObject.GetComponent<Button>().image.enabled = false;
    }
}