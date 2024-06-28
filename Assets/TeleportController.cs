
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Events;
using UnityEngine.XR.Interaction.Toolkit;

public class TeleportController : MonoBehaviour
{

    // identifying variables
    [SerializeField]
    public GameObject baseControllerGameObject;
    public GameObject teleportationGameObject;


    public InputActionReference teleportActivationReference;

    [Space]
    public UnityEvent onTeleportActivate;
    public UnityEvent onTeleportCancel;

    private void Start()
    {
        teleportActivationReference.action.performed += TeleportModeActivate; // activating teleporter
        teleportActivationReference.action.canceled += TeleportModeCancel; //  cancelling teleporter
    }

    private void TeleportModeCancel(InputAction.CallbackContext obj) { Invoke("DeactivateTeleporter", .1f);
       // teleportationGameObject.GetComponent<XRInteractorLineVisual>().reticle.SetActive(false);
    }// invoking deactivate teleporter


    void DeactivateTeleporter() => onTeleportCancel.Invoke();


    private void TeleportModeActivate(InputAction.CallbackContext obj) {

        //teleportationGameObject.GetComponent<XRInteractorLineVisual>().reticle.SetActive(true);
        onTeleportActivate.Invoke(); }// invoking activating teleporter
   



}
