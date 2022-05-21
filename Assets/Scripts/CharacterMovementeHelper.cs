using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
public class CharacterMovementeHelper : MonoBehaviour
{
    private XRRig rig;
    private CharacterController charactControl;
    private CharacterControllerDriver driver;
    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<XRRig>();
        charactControl = GetComponent<CharacterController>();
        driver = GetComponent<CharacterControllerDriver>();
    }

    // Update is called once per frame
    void Update()
    {
        UpdateCharacterController();
    }

    /// <summary>
    /// Updates the <see cref="CharacterController.height"/> and <see cref="CharacterController.center"/>
    /// based on the camera's position.
    /// </summary>
    protected virtual void UpdateCharacterController()
    {
        if (rig == null || charactControl == null)
            return;

        var height = Mathf.Clamp(rig.CameraInOriginSpaceHeight, driver.minHeight, driver.maxHeight);

        Vector3 center = rig.CameraInOriginSpacePos;
        center.y = height / 2f + charactControl.skinWidth;

        charactControl.height = height;
        charactControl.center = center;
    }
}
