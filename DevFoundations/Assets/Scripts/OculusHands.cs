using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class OculusHands : MonoBehaviour
{
    public InputActionReference gripAction;
    public InputActionReference triggerAction;
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        gripAction.action.started += GripWasPressed;
        gripAction.action.canceled += GripWasReleased;
        triggerAction.action.started += TriggerWasPressed;
        triggerAction.action.canceled += TriggerWasReleased;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void TriggerWasPressed(InputAction.CallbackContext context)
    {
        anim.SetBool("TriggerPressed",true);
    }
    
    void TriggerWasReleased(InputAction.CallbackContext context)
    {
        anim.SetBool("TriggerPressed",false);
    }
    void GripWasPressed(InputAction.CallbackContext context)
    {
        anim.SetBool("GripPressed",true);
    }

    void GripWasReleased(InputAction.CallbackContext context)
    {
        anim.SetBool("GripPressed",false);
    }

    private void OnDestroy()
    {
        gripAction.action.started -= GripWasPressed;
        gripAction.action.canceled -= GripWasReleased;
        triggerAction.action.started -= TriggerWasPressed;
        triggerAction.action.canceled -= TriggerWasReleased;
    }
}
