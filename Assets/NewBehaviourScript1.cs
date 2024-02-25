using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript1 : MonoBehaviour
{
    public float angle;
         public float radius;
         float x,y;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        angle += Time.deltaTime * 10;

        x = Mathf.Cos(angle * Mathf.Deg2Rad);
        y = Mathf.Sin(angle * Mathf.Deg2Rad);
    
        transform.position = new Vector3(x, y, 0) * radius;
    }
}
