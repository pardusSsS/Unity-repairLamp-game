using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_move : MonoBehaviour
{
    public GameObject kid;
    public float kx;
    public float ky;
    public float kz;
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        kx = kid.transform.eulerAngles.x;
        ky = kid.transform.eulerAngles.y;
        kz = kid.transform.eulerAngles.z;

        transform.eulerAngles = new Vector3(kx - kx, ky, kz - kz);


    }
}
