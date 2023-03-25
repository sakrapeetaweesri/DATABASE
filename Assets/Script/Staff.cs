using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using Random = UnityEngine.Random;


public enum UnitState
{
    IsIdel,
    IsWalk
}

public class Staff : MonoBehaviour
{
    private int _id;
    public int ID
    {
        get { return _id;}
        set { _id = value; }
    }

    private int charSkinId;
    public int CharSkinID
    {
        get { return charSkinId;}
        set { charSkinId = value; }
    }
    public GameObject[] charSkin;

    public string stafName;
    public int dailyWage;
    
    //Animation
    [SerializeField] private UnitState state;
    public UnitState State
    {
        get { return state;}
        set { state = value; }
    }
    
    //nav Agent
    [SerializeField] private NavMeshAgent navAgent;
    public NavMeshAgent NavAgent
    {
        get { return navAgent; }
    }

    private void Awake()
    {
        navAgent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        CheckStop();
    }

    public void InitCharID(int id)
    {
        _id = id;
        charSkinId = Random.Range(0, charSkin.Length - 1);
        stafName = "XXXX";
        dailyWage = Random.Range(80, 125);
    }

    public void ChageChaSkin()
    {
        for (int i = 0; i < charSkin.Length; i++)
        {
            if (i == charSkinId)
            {
                charSkin[i].SetActive(true);
            }
            else
            {
                charSkin[i].SetActive(false);
            }
        }
    }

    public void CheckStop()
    {
        float dist = Vector3.Distance(transform.position, navAgent.destination);

        if (dist <= 3f)
        {
            state = UnitState.IsIdel;
            navAgent.isStopped = true;
        }
    }

    public void SetToWalk(Vector3 dest)
    {
        state = UnitState.IsWalk;

        navAgent.SetDestination(dest);
        navAgent.isStopped = false;
    }
}
