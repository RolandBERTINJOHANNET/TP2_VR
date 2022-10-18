using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseBehaviorScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Input.GetAxis("Horizontal")*(float)0.1, 0, Input.GetAxis("Vertical")*(float)0.1) ;
    }
}
