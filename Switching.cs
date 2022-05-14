using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switching : MonoBehaviour
{
    public GameObject Weapon1;
    public GameObject Weapon2;
    public bool IsWeapon1;

    void Start(){
        IsWeapon1 = true;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        var Scroll = Input.GetAxis("Mouse ScrollWheel");
        if(Scroll != 0){
            Weapon1.SetActive(false);
            Weapon2.SetActive(true);
            IsWeapon1 = false;
        }
        else if(Scroll != 0){
            Weapon1.SetActive(true);
            Weapon2.SetActive(false);
            IsWeapon1 = true;
        }
    }
}