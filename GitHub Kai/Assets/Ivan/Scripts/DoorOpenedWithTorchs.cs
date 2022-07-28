using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpenedWithTorchs : MonoBehaviour
{
    TorchToLightup torch1;
    TorchToLightup2 torch2;
    TorchToLightup3 torch3;
    TorchToLightup4 torch4;
    BoxCollider boxCollider;

    // Start is called before the first frame update
    void Start()
    {
        torch1 = FindObjectOfType<TorchToLightup>();
        torch2 = FindObjectOfType<TorchToLightup2>();
        torch3 = FindObjectOfType<TorchToLightup3>();
        torch4 = FindObjectOfType<TorchToLightup4>();
        boxCollider = GetComponent<BoxCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        if (torch1.torchOn && torch2.torchOn && torch3.torchOn && torch4.torchOn)
        {
            boxCollider.enabled = false;
        }
    }
}
