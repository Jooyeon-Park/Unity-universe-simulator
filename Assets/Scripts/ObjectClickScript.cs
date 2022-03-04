using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectClickScript : MonoBehaviour
{
    private Renderer renderer;
    public GameObject popUp;
    private GameObject objName;
    private GameObject objDescription;

    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<Renderer>();
    }

    private void OnMouseEnter()
    {
        renderer.material.color = Color.green;
    }

    private void OnMouseOver()
    {
        if (Input.GetMouseButton(0))
        {
            popUp.SetActive(true);

            GameObject.Find("BasicUI").SetActive(false);
            GameObject.Find("ObjectName").GetComponent<Text>().text = "Hamburger";
            GameObject.Find("ObjectDescription").GetComponent<Text>().text = "Size: 0.1m\n Tastes good.";
        }
    }

    private void OnMouseExit()
    {
        renderer.material.color = Color.white;
    }
}
