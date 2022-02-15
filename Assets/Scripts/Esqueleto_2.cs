using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esqueleto_2 : MonoBehaviour
{
    private float movHorizontal = 2f;
    private float speed = 8f;
    private float verticalInput;
    private float LimY = 2f;
    private float PosY = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
            verticalInput = Input.GetAxis("Vertical");

            transform.Translate(Vector3.up * Time.deltaTime * speed * verticalInput);

            if (transform.position.y > 7)
            {
                transform.position = new Vector3(transform.position.x, 7, transform.position.z);
            }
            if (transform.position.y < 3.5f)
            {
                transform.position = new Vector3(transform.position.x, 3.5f, transform.position.z);
            }

        if (transform.position.y == 7f)
        {
            transform.position = new Vector3(transform.position.x, 7, transform.position.z);


            if (Input.GetKeyDown(KeyCode.C))
            {
                //transform.Translate(new Vector3(transform.position.x, -3.5f, transform.position.z) * Time.deltaTime * speed);
                transform.position = new Vector3(transform.position.x, 3.5f, transform.position.z);

            }
        }

    }
}
