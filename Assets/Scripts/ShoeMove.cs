using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShoeMove : MonoBehaviour
{
    public GameObject mouseSphere;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mouseSphere.transform.position = new Vector3 mousePos = Input.mousePosition;
    }
}
