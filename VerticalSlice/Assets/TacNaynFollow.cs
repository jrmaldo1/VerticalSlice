using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Animations;
public class TacNaynFollow : MonoBehaviour
{
    public NavMeshAgent tacnayn;
    public Transform nyancat;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        tacnayn.SetDestination(nyancat.position);
        
    }
}
