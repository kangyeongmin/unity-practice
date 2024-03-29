using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    public float speed = 0.1f;

    private void Start()
    {
        speed = speed * 0.1f;
    }


    void Update()
    {
        //if (Input.GetKey(KeyCode.W))
        //{
        //    this.transform.Translate(0, 0, -speed);
        //}

        //if (Input.GetKey(KeyCode.S))
        //{
        //    this.transform.Translate(0, 0, speed);
        //}

        if (Input.GetKey(KeyCode.A))
        {
            this.transform.Translate(speed, 0, 0);
        }

        if (Input.GetKey(KeyCode.D))
        {
            this.transform.Translate(-speed, 0, 0);
        }

    }

}
