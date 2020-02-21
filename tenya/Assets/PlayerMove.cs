using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public Transform explosionPrefab;
    Rigidbody pRigidBody;
    Collider collider;
    // Start is called before the first frame update
    void Start()
    {
        pRigidBody = GetComponent<Rigidbody>();
        collider = GetComponent<BoxCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.A))
        pRigidBody.AddForce(new Vector3(-10f, 0, 0));
        if (Input.GetKey(KeyCode.D))
            pRigidBody.AddForce(new Vector3(10f, 0, 0));

       // collider.transform.posi = new Vector3(0,0,1);
    }
   
    void OnCollisionEnter(Collision collision)
    {
       
        pRigidBody.AddForce(new Vector3(0, 500, 0));
    }
}

    

