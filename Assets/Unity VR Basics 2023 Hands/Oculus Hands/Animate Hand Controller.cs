using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Animator))]

public class AnimateHandController : MonoBehaviour
{
    public InputActionReference gripInputActionRefrence;
    public InputActionReference triggerInputActionRefrence;

    private Animator _handanimator;
    private float _gripValue;
    private float _triggerValue;
    private void Start()
    {
        _handanimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    private void Update()
    {
        AnimateGrip();
        AnimateTrigger();
    }

    private void AnimateGrip()
    {
        _gripValue = gripInputActionRefrence.action.ReadValue<float>();
        _handanimator.SetFloat("Grip", _gripValue); 
    }

    private void AnimateTrigger()
    {
        _triggerValue = triggerInputActionRefrence.action.ReadValue<float>();
        _handanimator.SetFloat("Trigger",_triggerValue);
    }



}

