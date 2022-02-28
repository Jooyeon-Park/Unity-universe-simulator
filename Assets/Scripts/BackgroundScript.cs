using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackgroundScript : MonoBehaviour
{
    public GameObject background;
    public Text scale;
    private Vector3 cameraPosition;
    private Vector3 prevCameraPosition;
    public new List<GameObject> objectList;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        cameraPosition = Camera.main.transform.position;
        if (cameraPosition != prevCameraPosition)
        {
            //Move backgroud
            background.transform.position = new Vector3(cameraPosition.x, cameraPosition.y, cameraPosition.z + 8.1f);

            //Object setActive
            for (int i = 0; i < objectList.Count; i++)
            {
                scale.text = cameraPosition.z.ToString();
                if(objectList[i].transform.position.z > Camera.main.transform.position.z + 9.1f)
                {
                    objectList[i].SetActive(false);
                }
                else
                {
                    objectList[i].SetActive(true);
                }
            }


            prevCameraPosition = cameraPosition;
        }
    }
}
