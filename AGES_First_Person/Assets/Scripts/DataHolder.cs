using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class DataHolder
{
    public float convnumber = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        convnumber += (Time.deltaTime * 1.5f);

        if (Input.GetKeyDown(KeyCode.T))
        {
            Debug.Log(convnumber);
        }
    }
}
