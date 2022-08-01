using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomColorBall : MonoBehaviour
{

    [SerializeField] Material[] mat;
    [SerializeField] string[] tagName;
    [SerializeField] float colorChangeRate;
    int index = 0;

    float nextColorChange;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<MeshRenderer>().material = mat[index];
        nextColorChange = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= nextColorChange)
        {
            if (index == mat.Length - 1) index = 0;
            else index++;
            nextColorChange = Time.time + colorChangeRate;
        }

        gameObject.GetComponent<MeshRenderer>().material = mat[index];
        gameObject.tag = tagName[index];
    }
}
