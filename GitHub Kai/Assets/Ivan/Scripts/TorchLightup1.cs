using System.Collections;
using Unity.FPS.Game;
using UnityEditorInternal;
using UnityEngine;
using UnityEngine.Events;

public class TorchLightup : MonoBehaviour
{
    CapsuleCollider capsuleCollider;
    AudioSource audioSource;
    GameObject fire;
    GameObject flare;


    // Start is called before the first frame update
    void Start()
    {
        capsuleCollider = GetComponent<CapsuleCollider>();
        audioSource = GetComponent<AudioSource>();
        fire = GameObject.Find("FIRE 1");
        flare = GameObject.Find("Flare");
    }

    // Update is called once per frame
    void Update()
    {
        if (MouseButtonDown())
        {
           capsuleCollider.gameObject.SetActive(true);
           fire.gameObject.SetActive(true);
           flare.gameObject.SetActive(true);
        }

        else {
              capsuleCollider.gameObject.SetActive(false);
              fire.gameObject.SetActive(true);
              flare.gameObject.SetActive(true);
             }    
    }

    private bool MouseButtonDown()
        {
            return Input.GetMouseButtonDown (0);
        }
}
