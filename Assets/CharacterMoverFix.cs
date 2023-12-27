using Unity.XR.CoreUtils;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class CharacterMoverFix : MonoBehaviour
{
    private XROrigin rig;
    private CharacterController characterController;
    private CharacterControllerDriver driver;

    private void Start()
    {
        rig = GetComponent<XROrigin>();
        characterController = GetComponent<CharacterController>();
        driver = GetComponent<CharacterControllerDriver>();
    }

    private void Update()
    {
        if (rig == null || characterController == null)
            return;

        var height = Mathf.Clamp(rig.CameraInOriginSpaceHeight, driver.minHeight, driver.maxHeight);

        Vector3 center = rig.CameraInOriginSpacePos;
        center.y = height / 2.0f + characterController.skinWidth;

        characterController.height = height;
        characterController.center = center;
    }
}
