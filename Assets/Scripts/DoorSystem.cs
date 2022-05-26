using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
public class DoorSystem : MonoBehaviour
{
    public XRGrabInteractable doorGrab;
    // Start is called before the first frame update
    void Start()
    {
        doorGrab = GetComponent<XRGrabInteractable>();
        doorGrab.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Key")
        {
            doorGrab.enabled = true;
        }
        else
        {
            doorGrab.enabled = false;
        }
    }
 
}
