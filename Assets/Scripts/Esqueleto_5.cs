using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esqueleto_5 : MonoBehaviour
{
    private float movHorizontal = 2f;
    private float speed = 10f;
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

        if (transform.position.y > 7.5f)
        {
            transform.position = new Vector3(transform.position.x, 7.5f, transform.position.z);
        }
        if (transform.position.y < 4)
        {
            transform.position = new Vector3(transform.position.x, 4, transform.position.z);
        }

        if (Input.GetKeyDown(KeyCode.B))
        {

            transform.position = new Vector3(transform.position.x, 4f, transform.position.z);

        }
    }
}
