using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
public class CodeButtonInteractable : XRSimpleInteractable
{
    public Material hoverMaterial;
    public Material selectedMaterial;
    public CodeCheck codechecker;
    public int number;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    protected override void OnHoverExited(HoverExitEventArgs args)
	{
        base.OnHoverExited(args);

        GetComponent<MeshRenderer>().material = hoverMaterial;
    }

    protected override void OnSelectEntered(SelectEnterEventArgs args)
	{
        base.OnSelectEntered(args);

        GetComponent<MeshRenderer>().material = selectedMaterial;
        codechecker.PutNumber(number);

    }
}
