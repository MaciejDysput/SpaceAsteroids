using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestMonoBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            Debug.Log("DUPA");
        }
        if (Input.GetKey(KeyCode.R))
        {
            Debug.Log("Random bruce jest w platynie XD");
        }

    }
}
