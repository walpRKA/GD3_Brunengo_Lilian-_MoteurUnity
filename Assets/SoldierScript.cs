using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class SoldierScript : MonoBehaviour
{
    Animator animator;
    float speed = 0.0f;
    float attack = 0.0f;


    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            Debug.Log("OOOOH");
            speed += 1;

        }

        if (Input.GetKeyUp(KeyCode.I))
        {
            speed -= 1;
        }

        if (Input.GetKeyDown(KeyCode.E))
        {

            attack += 1;

        }

        if (Input.GetKeyUp(KeyCode.E))
        {
            attack -= 1;
        }
        animator.SetFloat("runParameter", speed);
        animator.SetFloat("Punch", attack);
    }
}
