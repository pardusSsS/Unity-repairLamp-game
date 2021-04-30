using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turn : MonoBehaviour
{
    public Animator a_right;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void right()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            a_right.enabled = true;
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            a_right.enabled = false;


        }
    }
   public void left()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            a_right.enabled = true;
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            a_right.enabled = false;


        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
