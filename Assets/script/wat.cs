using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class wat : MonoBehaviour
{
    [SerializeField] Camera cam;
    RaycastHit hitInfo;

    bool isContact = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!isContact)
        {
            CheckObject();
        }
    }

    void CheckObject()
    {
        Vector3 mousePos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0)

            if (Physics.Raycast(cam.ScreenPointToRay(mousePos), out hitInfo, 2))
        {
            ObjectContact();
        }
    }

    void ObjectContact()
    {

    }
}
