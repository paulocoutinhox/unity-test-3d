using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FogoRotator : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.left * (Time.deltaTime * 5.0f)/*, Space.World*/);
        //Quaternion target = transform.ro
        //transform.rotation = Quaternion.Slerp(transform.rotation, transform.rotation, )
    }
}
