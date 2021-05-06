using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlendTrigger : MonoBehaviour
{

    public Material skyboxMaterial;

    [Range(0.00f, 1.00f)]
    public float yourblend=0f;


    void OnTriggerStay(Collider collider)
    {
        if(collider.gameObject.tag == "Player")
        {
            if(yourblend <= 1f)
            {
                yourblend += 0.2f * Time.deltaTime;
                    skyboxMaterial.SetFloat("_Blend", yourblend);
            }   
        }
    }
    void OnTriggerExit(Collider collider)
    {
        if(collider.gameObject.tag == "Player")
        {
            if(yourblend >= 1f)
            {
                yourblend -= 0.2f * Time.deltaTime;
                    skyboxMaterial.SetFloat("_Blend", yourblend);
            }
        }
    }
}
