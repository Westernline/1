using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeRaycastController : MonoBehaviour
{
    [SerializeField] private HeroStackController heroStackController;
    private Vector3 direction = Vector3.back;
    private bool isStack = false;
    private RaycastHit hit;
    [SerializeField] private float secondsToDestroy = 2.0f;


    private void Start()
    {
        heroStackController = GameObject.FindObjectOfType<HeroStackController>();
    }


    void FixedUpdate()
    {
        if (Physics.Raycast(transform.position, direction, out hit, 1.0f))
        {
            if (!isStack)
            {
                isStack = !isStack;
                heroStackController.IncreaseNewBlock(gameObject);
                SetDirection();
            }

            if (hit.transform.name == "ObstacleCube")
            {
                heroStackController.DecreaseBlock(gameObject);
                Destroy(gameObject, secondsToDestroy);
                
            }
        }
    }

    private void SetDirection()
    {
        direction = Vector3.forward;
    }
    
}