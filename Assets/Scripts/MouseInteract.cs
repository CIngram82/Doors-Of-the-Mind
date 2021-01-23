using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseInteract : MonoBehaviour
{
    public float reachDist = 1f;

    public Camera playerCam;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            RaycastHit hit;
            Physics.Raycast(playerCam.transform.position, playerCam.transform.forward, out hit, reachDist);
            Debug.Log(hit.point);
        }
    }
}
