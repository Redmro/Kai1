using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorchToLightup5 : MonoBehaviour
{
    public bool torchOn = false;
    GameObject fire;
    GameObject flare;

    // Start is called before the first frame update
    void Start()
    {
        fire = GameObject.Find("FIRE");
        flare = GameObject.Find("Flare");
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Torch")
        {
            fire.gameObject.SetActive(true);
            flare.gameObject.SetActive(true);
            torchOn = true;
        }
    }
}