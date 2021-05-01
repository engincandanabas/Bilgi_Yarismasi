using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundmanger : MonoBehaviour
{
    // Start is called before the first frame update
    public static AudioClip dogrucevap_efekt;
    static AudioSource audiosrc;

    void Start()
    {
        dogrucevap_efekt = Resources.Load<AudioClip>("dogru_efekt");
        audiosrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public static void PlaySound()
    {
        audiosrc.PlayOneShot(dogrucevap_efekt);
    }
}
