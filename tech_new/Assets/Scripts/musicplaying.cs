using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musicplaying : MonoBehaviour

    
{
    public AudioSource WinterSound;
    public ParticleSystem Snow;
    public GameObject GroundSnow;
    public GameObject Flowers;

    bool isGroundSnowShowing = false;
    bool isFlowerShowing = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        WinterSound.Play();
        Snow.Play();
        GroundSnow.SetActive(true);
        isGroundSnowShowing = true;
        Flowers.SetActive(false);
        isFlowerShowing = false;
    }
    private void OnTriggerExit(Collider other)
    {
        WinterSound.Stop();
        Snow.Stop();
        GroundSnow.SetActive(false);
        isGroundSnowShowing = false;
        Flowers.SetActive(true);
        isFlowerShowing = true;

    }


}
