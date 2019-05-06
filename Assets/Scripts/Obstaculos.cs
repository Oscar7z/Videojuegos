using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaculos : MonoBehaviour
{

    public float v = 5f;
    public float mH = 24.33f;
    public float mV; 
    // Start is called before the first frame update
    void Start()
    {
        mV = Random.Range(3.80f, 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        var p = gameObject.transform.position;
        mH -= v;
        p.x = mH;
        p.y = mV;

        gameObject.transform.position = p;

        if(mH < -24f) 
        {
            Destroy(gameObject);
        }

    }
}
