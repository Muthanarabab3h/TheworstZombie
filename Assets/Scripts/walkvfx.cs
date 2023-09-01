using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walkvfx : MonoBehaviour
{
    [SerializeField]
    GameObject vfxEffect;

    [SerializeField]
    AudioSource vfxSource;

    [SerializeField]
    GameObject SoundSource;




    // Start is called before the first frame update
    void Start()
    {
        vfxEffect.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Ground") 
        {
        
        vfxEffect.SetActive(true);
        vfxSource.Play();


        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Ground")
        {
            vfxEffect.SetActive(false);
            //vfxSource.Stop();
            SoundSource.SetActive(true);
        }
    }
}
