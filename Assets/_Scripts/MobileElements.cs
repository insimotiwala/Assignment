using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MobileElements : MonoBehaviour
{
    public GameObject Target;
    private NavMeshAgent body;

    // Start is called before the first frame update
    private void Start()
    {
        body = this.GetComponent<NavMeshAgent>();
        body.SetDestination(Target.transform.position);
    }

    // Update is called once per frame
    private void Update()
    {
    }
}