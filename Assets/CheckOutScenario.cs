using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckOutScenario : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y <= -10) {
            transform.position = new Vector3(3f, 3f, -5f);
        }
    }
}
