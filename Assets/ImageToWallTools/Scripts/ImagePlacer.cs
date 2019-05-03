using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImagePlacer : MonoBehaviour
{
    [SerializeField]
    private float Speed;

    private RaycastHit hitInfo;
    private float iterator = 0;
    private Vector3 startPos;
    private Quaternion startRot;

    void Start()
    {
        
        if(!Physics.Raycast(transform.position + transform.forward * 0.01f, transform.forward, out hitInfo, Mathf.Infinity))
        {
            Destroy(transform.parent.gameObject);
            return;
        }
        startPos = transform.position;
        startRot = transform.rotation;

    }

    // Update is called once per frame
    void Update()
    {
        if (iterator > 1) return;

        transform.position = Vector3.Lerp(startPos, hitInfo.point, iterator);
        transform.rotation = Quaternion.Lerp(startRot, Quaternion.LookRotation(-hitInfo.normal, Vector3.up), iterator);
        //transform.rotation = Quaternion.LookRotation(-hitInfo.normal, Vector3.up);

        iterator += Speed * Time.deltaTime;
    }
}
