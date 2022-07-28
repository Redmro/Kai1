using System.Collections;
using Unity.FPS.Game;
using UnityEditorInternal;
using UnityEngine;
using UnityEngine.Events;

public class TorchLightup : MonoBehaviour
{
    CapsuleCollider capsuleCollider;
    AudioSource audioSource;
    public GameObject fire;
    public GameObject flare;

    private bool isFireActive;


    // Start is called before the first frame update
    void Awake()
    {
        capsuleCollider = GetComponent<CapsuleCollider>();
        audioSource = GetComponent<AudioSource>();
    }

     void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MouseButtonDown();
        if (isFireActive)
        {           
           fire.gameObject.SetActive(true);
           flare.gameObject.SetActive(true);
        }

        else {
              
              fire.gameObject.SetActive(false);
              flare.gameObject.SetActive(false);
             }    
    }

    private void MouseButtonDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            isFireActive = !isFireActive;
        }
     }
}
