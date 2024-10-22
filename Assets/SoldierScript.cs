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
        if (Input.GetKey(KeyCode.I))
        {
            Debug.Log("OOOOH");
            speed += Time.deltaTime;

        }

        if (Input.GetKeyUp(KeyCode.I))
        {
            speed = 0.0f;
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
