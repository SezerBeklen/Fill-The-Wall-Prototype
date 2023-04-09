using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class UIDrag : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler , IDragHandler , IPointerUpHandler
{
    private RectTransform rectTransform;

    public GameObject canvasParent;
    public GameObject panelParent;
    public GameObject returnPos;
    public GameObject dragableUIObject_1;
    public GameObject rack;
    public GameObject quad;
    public float DragSpeed;
    GameObject newparentObject;
    private void Awake()
    {
         
        rectTransform = GetComponent<RectTransform>();
        newparentObject = GameObject.Find("scoreControl");
    }

    public void OnBeginDrag(PointerEventData eventData)
    {

        dragableUIObject_1.gameObject.SetActive(false);
    }

    public void OnDrag(PointerEventData eventData)
    {
        gameObject.transform.parent = canvasParent.transform;
        rectTransform.anchoredPosition += eventData.delta * Time.deltaTime * DragSpeed;

        

    }

    public void OnEndDrag(PointerEventData eventData)
    {
        gameObject.transform.parent = panelParent.transform;
        gameObject.transform.localScale = new Vector3(0.1f, 1, 0.2f);
        dragableUIObject_1.gameObject.SetActive(true);

        if (trigger.instance._trigger1.isTrigger == true)
        {

            trigger.instance.dragabbleObject[0].transform.position = rack.transform.position;
            trigger.instance._trigger1.isTrigger = false;
            trigger.instance.dragabbleObject[0].transform.parent = null;
            quad.gameObject.SetActive(false);
            dragableUIObject_1.gameObject.SetActive(false);


        }
        else
        {

            gameObject.transform.position = returnPos.transform.position;

        }


        if (trigger.instance._trigger2.isTrigger == true)
        {


            trigger.instance.dragabbleObject[1].transform.position = rack.transform.position;
            trigger.instance._trigger2.isTrigger = false;
            trigger.instance.dragabbleObject[1].transform.parent = null;
            quad.gameObject.SetActive(false);
            dragableUIObject_1.gameObject.SetActive(false);

        }
        else
        {

            gameObject.transform.position = returnPos.transform.position;

        }


        if (trigger.instance._trigger3.isTrigger == true)
        {


            trigger.instance.dragabbleObject[2].transform.position = rack.transform.position;
            trigger.instance._trigger3.isTrigger = false;
            trigger.instance.dragabbleObject[2].transform.parent = null;
            quad.gameObject.SetActive(false);
            dragableUIObject_1.gameObject.SetActive(false);

        }
        else
        {

            gameObject.transform.position = returnPos.transform.position;

        }

        
        if (trigger.instance._trigger4.isTrigger == true)
        {


            trigger.instance.dragabbleObject[3].transform.position = rack.transform.position;
            trigger.instance._trigger4.isTrigger = false;
            trigger.instance.dragabbleObject[3].transform.parent = null;
            quad.gameObject.SetActive(false);
            dragableUIObject_1.gameObject.SetActive(false);

        }
        else
        {

            gameObject.transform.position = returnPos.transform.position;

        }



    }

    public void OnPointerDown(PointerEventData eventData)
    {
        dragableUIObject_1.gameObject.transform.localScale = new Vector3(1.5f, 1.5f, 0);
        
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        dragableUIObject_1.gameObject.transform.localScale = new Vector3(1, 1, 0);
    }

    

}
