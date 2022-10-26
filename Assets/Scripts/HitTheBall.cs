using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitTheBall : MonoBehaviour
{
    Rigidbody rb;
    public float thrust;
    public GameObject Arrow;
    public float turnSpeed;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        thrust = 20f;
        turnSpeed = 0.1f;
    }

    // Update is called once per frame
    void Update()
    {
        //Hit Force on Ball
        if (Input.GetKeyDown(KeyCode.W))
        {
            Debug.Log("Hit");
            rb.AddForce(transform.forward * thrust, ForceMode.Impulse);
        }

        //Arrow Transforms
        Arrow.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);

        //Turn Ball/Arrow
        if (Input.GetKey(KeyCode.A))
        {
            transform.localEulerAngles -= new Vector3(transform.rotation.x, transform.rotation.y - turnSpeed, transform.rotation.z);
            Arrow.transform.localEulerAngles -= new Vector3(0, Arrow.transform.rotation.y - turnSpeed, 0);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.localEulerAngles += new Vector3(transform.rotation.x, transform.rotation.y + turnSpeed, transform.rotation.z);
            Arrow.transform.localEulerAngles += new Vector3(0, Arrow.transform.rotation.y + turnSpeed, 0);
        }
        else
        {
            transform.localEulerAngles += new Vector3(0,0,0);
        }
    }
}
