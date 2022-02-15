using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;


public class Esqueleto_3 : MonoBehaviour
{
    private float speed = 9f;
    private float verticalInput;
    private float LimY = 2f;
    private float PosY = 0f;
    private float randomY;
    private float waiter;
    private bool alive = true;

    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("alive");
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

        if (transform.position.y < 3f)
        {
            transform.position = new Vector3(transform.position.x, 3f, transform.position.z);

        }

        if (transform.position.y == 7f)
        {
            transform.position = new Vector3(transform.position.x, 7, transform.position.z);



            if (Input.GetKeyDown(KeyCode.Z))
            {
                //transform.Translate(new Vector3(transform.position.x, -3.5f, transform.position.z) * Time.deltaTime * speed);
                transform.position = new Vector3(transform.position.x, 3f, transform.position.z);

            }
        }

        //IEnumerator alive()

        //while (alive)
        {
            //yield return new WaitForSeconds(5f);
            //yield return new WaitForSeconds(5f);

        }



    }

}

