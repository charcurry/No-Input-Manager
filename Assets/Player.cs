using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //cube speed
    float maxSpeed = 5.0f; // 5 units/second
    float stepSpeed = 1.0f; // 1 unit/step

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        // old input manager
        //Input.GetAxis();
        //Input.GetAxisRaw();
        //float x = Input.GetAxis("Horizontal"); // -1.0..1.0
        //float y = Input.GetAxis("Vertical"); // -1.0..1.0
        float x = Input.GetAxisRaw("Horizontal"); // -1.0 1.0
        float y = Input.GetAxisRaw("Vertical"); // -1.0 1.0

        gameObject.transform.Translate(Vector3.right * x * maxSpeed * Time.deltaTime);
        gameObject.transform.Translate(Vector3.forward * y * maxSpeed * Time.deltaTime);

        //Vector3 newPosition = gameObject.transform.position;
        //newPosition.x += x * Time.deltaTime * maxSpeed;
        //newPosition.z += y * Time.deltaTime * maxSpeed;
        //gameObject.transform.position = newPosition;

        ////WASD
        //if (Input.GetKeyDown(KeyCode.W))
        //{
        //    gameObject.transform.Translate(Vector3.forward * maxSpeed * stepSpeed);
        //}
        //if (Input.GetKeyDown(KeyCode.S))
        //{
        //    gameObject.transform.Translate(Vector3.back * maxSpeed * stepSpeed);
        //}
        //if (Input.GetKeyDown(KeyCode.A))
        //{
        //    gameObject.transform.Translate(Vector3.left * maxSpeed * stepSpeed);
        //}
        //if (Input.GetKeyDown(KeyCode.D))
        //{
        //    gameObject.transform.Translate(Vector3.right * maxSpeed * stepSpeed);
        //}

        ////IJKL
        //if (Input.GetKey(KeyCode.I))
        //{
        //    gameObject.transform.Translate(Vector3.forward * maxSpeed * Time.deltaTime);
        //}
        //if (Input.GetKey(KeyCode.K))
        //{
        //    gameObject.transform.Translate(Vector3.back * maxSpeed * Time.deltaTime);
        //}
        //if (Input.GetKey(KeyCode.J))
        //{
        //    gameObject.transform.Translate(Vector3.left * maxSpeed * Time.deltaTime);
        //}
        //if (Input.GetKey(KeyCode.L))
        //{
        //    gameObject.transform.Translate(Vector3.right * maxSpeed * Time.deltaTime);
        //}

    }
}
