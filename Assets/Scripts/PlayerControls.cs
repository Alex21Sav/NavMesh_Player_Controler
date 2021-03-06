using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerControls : MonoBehaviour
{
    private Camera _mainCamera;
    private NavMeshAgent _agent;

    private void Start()
    {
        _mainCamera = Camera.main;
        _agent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;

            if(Physics.Raycast(_mainCamera.ScreenPointToRay(Input.mousePosition), out hit))
            {
                _agent.SetDestination(hit.point);
            }

        }
    }

}
