using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScene : MonoBehaviour
{
    public Staff staff;

    public void ButtonWalk()
    {
        staff.State = UnitState.IsWalk;
    }

    public void ButtonIdel()
    {
        staff.State = UnitState.IsIdel;
    }
}
