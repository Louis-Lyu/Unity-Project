using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class box : MonoBehaviour
{
    void OnTriggerEnter(Collider other){
        other.GetComponent<CharacterController>().Move(Vector3.up * 10);
    }
}
