using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CodeCheck : MonoBehaviour
{
    public string TargetCode;
    private string CurrentCode;
    [SerializeField] private Animator myDoor = null;
    public AudioSource source;
    public AudioClip cliperror;
    public AudioClip clipright;
    // Start is called before the first frame update
    void Start()
    {
        CurrentCode = "";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PutNumber(int number)
	{
        CurrentCode += number;

		if (CurrentCode == TargetCode)
		{
            DoWhenCodeCorrect();
        }
		else if (CurrentCode.Length>=TargetCode.Length)
		{
            CurrentCode = "";
            incorrectCode();
		}
	}
    private void incorrectCode()
	{
        Debug.Log("incorrect code");
        source.PlayOneShot(cliperror);
	}


    private void DoWhenCodeCorrect()
    {
        myDoor.Play("DoorOpen", 0, 0.0f);
        source.PlayOneShot(clipright);
    }
}
