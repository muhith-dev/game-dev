using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pemain : MonoBehaviour
{
    public float kecepatan, scaleX, lompat;
    void Start()
    {
        scaleX = transform.localScale.x;
    }

    public void jalan_kiri(){
        transform.localScale = new Vector3 (-scaleX, transform.localScale.y, transform.localScale.z);
        transform.Translate(Vector3.left * kecepatan * Time.fixedDeltaTime, Space.Self);
    }

    public void jalan_kanan(){
        transform.localScale = new Vector3 (scaleX, transform.localScale.y, transform.localScale.z);
        transform.Translate(Vector3.right * kecepatan * Time.fixedDeltaTime, Space.Self);
    }


    public void melompat(){
        GetComponent<Rigidbody2D>().velocity = new Vector2 (0,lompat);
    }

    void Update()
    {
        if (Input.GetKey (KeyCode.LeftArrow)){
            jalan_kiri();
        }
        if (Input.GetKey (KeyCode.RightArrow)){
            jalan_kanan();
        }
        if (Input.GetKeyDown (KeyCode.UpArrow)){
            melompat();
        }
    }
}