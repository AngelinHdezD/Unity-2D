using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    public float Speed = 5f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float HorizontalInput = Input.GetAxis("Horizontal");
        float VerticalInput = Input.GetAxis("Vertical");

       

        transform.position += new Vector3(HorizontalInput, VerticalInput, 0f) * Speed * Time.deltaTime;



    }
}
