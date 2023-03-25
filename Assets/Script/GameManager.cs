using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject staffPrefab;
    public GameObject staffParent;

    public GameObject spawnPos;
    public GameObject rallyPos;

    public static GameManager instance;
    
    void Start()
    {
        instance = this;
        GenerateCandidate();
    }

    void Update()
    {
        
    }

    private void GenerateCandidate()
    {
        for (int i = 0; i < 20; i++)
        {
            GameObject staffobj = Instantiate(staffPrefab, staffParent.transform);
            Staff s = staffobj.GetComponent<Staff>();
            
            s.InitCharID(i);
            s.ChageChaSkin();
            
            s.SetToWalk(rallyPos.transform.position);
        }
    }
}
