using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Interactables : MonoBehaviour
{
    private XRGrabInteractable grabInteractable = null;

    [SerializeField] Material selected = null;
    [SerializeField] Material unSelected = null;

    private MeshRenderer meshRenderer = null;

    // Start is called before the first frame update
    void Awake()
    {
        grabInteractable = GetComponent<XRGrabInteractable>();

        grabInteractable.onActivate.AddListener(grabObject);
        grabInteractable.onDeactivate.AddListener(releaseObject);
    }
    private void OnDestroy()
    {
        grabInteractable.onActivate.RemoveListener(grabObject);
        grabInteractable.onDeactivate.RemoveListener(releaseObject);
    }

    // Update is called once per frame
    void grabObject(XRBaseInteractor interactor)
    { 
    
    }
    void releaseObject(XRBaseInteractor interactor)
    {

    }
}
