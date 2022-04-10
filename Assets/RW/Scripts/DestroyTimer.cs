using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyTimer : MonoBehaviour
{
    public float timetoDestroy;
    void Start()
    {
        Destroy(gameObject, timetoDestroy);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
