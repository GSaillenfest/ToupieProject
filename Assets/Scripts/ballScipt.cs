using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballScipt : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(
        Mathf.Clamp(transform.position.x, -9.2f, 9.2f),
        Mathf.Clamp(transform.position.y, -0f, 20f),
        Mathf.Clamp(transform.position.z, -9.2f, 9.2f));
    }
}
