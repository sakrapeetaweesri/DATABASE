using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaffAnimation : MonoBehaviour
{
    private Animator _anim;
    private Staff _staff;

    private void Awake()
    {
        _anim = GetComponent<Animator>();
        _staff = GetComponent<Staff>();
    }

    private void Update()
    {
        if (_staff.State == UnitState.IsIdel)
        {
            DisableAll();
            _anim.SetBool("IsIdel",true);
        }
        if (_staff.State == UnitState.IsWalk)
        {
            DisableAll();
            _anim.SetBool("IsWalk",true);
        }
    }

    private void DisableAll()
    {
        _anim.SetBool("IsIdel",false);
        _anim.SetBool("IsWalk",false);
    }
}
