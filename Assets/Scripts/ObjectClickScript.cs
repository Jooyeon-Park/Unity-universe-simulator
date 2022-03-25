using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectClickScript : MonoBehaviour
{
    private Renderer renderer;
    private Outline outline;
    private GameObject popUp;
    private GameObject objName;
    private GameObject objDescription;
    private AudioSource clickSound;

    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<Renderer>();
        outline = GetComponent<Outline>();
        popUp = GameObject.Find("PopUpCanvas").transform.Find("PopUp").gameObject;
        clickSound = GameObject.Find("Click").GetComponent<AudioSource>();
    }

    private void OnMouseEnter()
    {
        outline.OutlineColor = Color.green;
        outline.OutlineWidth = 4;
    }

    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            clickSound.Play();
            if (popUp.activeSelf)
            {
                popUp.SetActive(false);
            }
            else
            {
                popUp.SetActive(true);
            }

            GameObject.Find("ObjectName").GetComponent<Text>().text = "Hamburger";
            GameObject.Find("ObjectDescription").GetComponent<Text>().text = "Size: 0.1m\n Tastes good.";
        }
    }

    private void OnMouseExit()
    {
        outline.OutlineWidth = 0;
    }
}
