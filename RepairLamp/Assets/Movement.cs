using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float movementSpeed = 0.1f;
    public float rotationSpeed = 100.0f;
    private bool moving;
    public Animator anim;
    public Rigidbody rigi;
    private int x = 0;
    public TMPro.TextMeshProUGUI artan;

    private void Start()
    {
        artan.text = x.ToString();
        rigi = GetComponent<Rigidbody>();
    }
    void Update()
    {

        transform.Rotate(0, Input.GetAxis("Horizontal") * Time.deltaTime * rotationSpeed, 0);
        transform.Translate(0, 0, Input.GetAxis("Vertical") * Time.deltaTime * movementSpeed);
        Anima();
    }
    private void FixedUpdate()
    {
        if (Input.GetAxis("Vertical") * Time.deltaTime * movementSpeed > 0)
            moving = true;
       
    }

    private void Anima()
    {
        if (moving == true)
        {
            anim.enabled = true;
        }
        else
            anim.enabled = false;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject.tag == "model")
        {

            Destroy(collision.collider.gameObject);
            x = x + 1;
            
            
        }
        artan.text = x.ToString();
    }
}
