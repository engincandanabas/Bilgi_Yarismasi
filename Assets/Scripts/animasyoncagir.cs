using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class animasyoncagir : MonoBehaviour
{
    // Start is called before the first frame update
    Yarisma yr;
    Animator anim;


    void Start()
    {
        anim = GetComponent<Animator>();
        yr = GetComponent<Yarisma>();    
    }
   
    // Update is called once per frame
    void Update()
    {
        
        if (Yarisma.dogruanimcagir == 1)
        {
     
            anim.SetBool("isTrue", true);
            Yarisma.dogruanimcagir = 0;
            Bekle();
       
        }
        else
        {
            
            anim.SetBool("isTrue", false);
        }
        
       
    }
    IEnumerator Bekle()
    {
        yield return new WaitForSeconds(3);
    }

}
