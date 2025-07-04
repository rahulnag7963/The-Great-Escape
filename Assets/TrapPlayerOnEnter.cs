using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapPlayerOnEnter : MonoBehaviour
{
    public GameObject myDoor;
    public GameObject myDoor2;
    public GameObject doorSignal1;
    public GameObject doorSignal2;
    public Material myMaterial; 

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            myDoor.SetActive(true);
            myDoor2.SetActive(true);
            doorSignal1.GetComponent<MeshRenderer>().material = myMaterial;
            doorSignal2.GetComponent<MeshRenderer>().material = myMaterial;

        }
    }
}