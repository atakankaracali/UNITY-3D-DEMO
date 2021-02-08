using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMeneger : MonoBehaviour
{
    public float run;
    public Rigidbody rb;
    void Start()
    {
        run = 2000; //hızımız..
    }


    void Update()//yön tuşları ile çalıştırdım. Dilersek asdw ile de çalıştırabilirdik. 
    {
        if (Input.GetKey(KeyCode.LeftArrow)) //sol yön tuşuna basıldıysa
        {
            rb.velocity = Vector3.left * run * Time.deltaTime;

        }
        if (Input.GetKey(KeyCode.RightArrow))//sağ yön tuşuna basıldıysa
        {
            rb.velocity = Vector3.right * run * Time.deltaTime;

        }
        if (Input.GetKey(KeyCode.UpArrow))//yukarı yön tuşuna basıldıysa
        {
            rb.velocity = Vector3.forward * run * Time.deltaTime;

        }
        if (Input.GetKey(KeyCode.DownArrow))//aşağı yön tuşuna basıldıysa
        {
            rb.velocity = Vector3.back * run * Time.deltaTime;

        }
    }
}
