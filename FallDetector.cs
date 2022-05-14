using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallDetector : MonoBehaviour
{
    
    private Vector3 StartPosition;

    // Start is called before the first frame update
    void Start(){
        StartPosition = transform.position;
    }

    void Update(){
        if(transform.position.y < -10){
            transform.position = StartPosition;
        }
    }
}