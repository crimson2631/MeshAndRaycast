using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceObject : MonoBehaviour
{
    public LayerMask notMeshed;
    public GameObject placeableItem;
    public Transform parentCube;

    // Update is called once per frame
    void Update()
    {
        RaycastHit hitInfo;
        if (Physics.Raycast(transform.position, transform.forward, out hitInfo, notMeshed.value))
        {
            Debug.Log(hitInfo.point + " " + hitInfo.normal);
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Instantiate(placeableItem, hitInfo.point, Quaternion.Euler(hitInfo.normal), parentCube);//game object we are copying, the second is the position we are placing that copy, and the third is the rotation of that copy. fourth is that parent in the hierarchy
            }
        }
        else
        {
            Debug.Log("Not Hitting Object");
        }
    }

}
