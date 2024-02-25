using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float movementSpeed = 2;
    public float sineSpeed;

    public float sineRange;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    
        transform.position += -transform.right * movementSpeed * Time.deltaTime;
        float yPosition= Mathf.Sin(transform.position.x * sineSpeed)* sineRange;
        Vector3 newPosition = new Vector3(transform.position.x, yPosition, 0);
        transform.position = newPosition;


    }
}
