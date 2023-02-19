using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class TwoHandGrabInteractable : XRGrabInteractable
{
    public List<XRSimpleInteractable> secondHandGrabPoints = new List<XRSimpleInteractable>();
    public List<GameObject> cellObjects = new List<GameObject>();
    private XRBaseInteractor secondInteractor;
    private Quaternion attachInititalRotation;
    public GameObject cellObject;
    public Rigidbody rb;
    
    // Start is called before the first frame update
    void Start()
    {
        foreach (var item in secondHandGrabPoints)
        {
            item.onSelectEntered.AddListener(OnSecondHandGrab);
            item.onSelectExited.AddListener(OnSecondHandRelease);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // public override void ProcessInteractable(XRInteractionUpdateOrder.UpdatePhase updatePhase)
    // {
    //     if (secondInteractor && selectingInteractor)
    //     {
    //         //Compute the rotation
    //
    //     }
    //     base.ProcessInteractable(updatePhase);
    // }

    public void OnSecondHandGrab(XRBaseInteractor interactor)
    {
        Debug.Log("SECOND HAND GRAB");
        secondInteractor = interactor;
        //GameObject cell = Instantiate(cellObject, secondInteractor.transform);
        GameObject instance = GameObject.Instantiate(cellObject) as GameObject;
        instance.transform.position = secondInteractor.transform.position;
        rb = instance.GetComponent<Rigidbody>();
        rb.isKinematic = false;
        rb.useGravity = false;
        cellObjects.Add(instance);
    }
    
    public void OnSecondHandRelease(XRBaseInteractor interactor)
    {
        Debug.Log("SECOND HAND RELEASE");
        secondInteractor = null;
    }

    protected override void OnSelectEntered(XRBaseInteractor interactor)
    {
        Debug.Log("First Grab Enter");
        base.OnSelectEntered(interactor);
        attachInititalRotation = interactor.attachTransform.localRotation;
    }

    protected override void OnSelectExited(XRBaseInteractor interactor)
    {
        Debug.Log("First Grab Exit");
        base.OnSelectExited(interactor);
        secondInteractor = null;
        interactor.attachTransform.localRotation = attachInititalRotation;
    }

    public override bool IsSelectableBy(IXRSelectInteractor interactor)
    {
        bool isalreadygrabbed = selectingInteractor && !interactor.Equals(selectingInteractor);
        return base.IsSelectableBy(interactor) && !isalreadygrabbed;
    }
}
