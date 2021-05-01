using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yanlisanimasyon : MonoBehaviour
{
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

        if (Yarisma.yanlisanimcagir == 1)
        {

            anim.SetBool("isTrue", true);
            Yarisma.yanlisanimcagir= 0;
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
