using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plot : MonoBehaviour
{
    Animator animator;

    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) 
        {
             RaycastHit hit;
             Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
             
             if (Physics.Raycast(ray, out hit)) 
             {
                 if (hit.transform.name == "Plot")
                 {
                    animator.SetTrigger("Flip");
                 }
             }
        }
    }
}
