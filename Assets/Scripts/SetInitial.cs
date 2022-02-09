using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetInitial : MonoBehaviour
{
       public Transform t1;
    // Start is called before the first frame update
    void Start()
    {
        t1.position = new Vector3(0.76f,-0.58f,0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
