using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Yarisma : MonoBehaviour
{
    

    // Start is called before the first frame update
    public Text soruismi, cevapa, cevapb, cevapc, cevapd;
    public int cevap;
    Sorular sr;
    public List<bool> sorulanlar;
    public static int dogruanimcagir = 0, yanlisanimcagir = 0;


    void Start()
    {
        sr = GetComponent<Sorular>();
        for(int i = 0; i < sr.sorularr.Count; i++)
        {
            sorulanlar.Add(false);
        }
        SoruEkle();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SoruEkle()
    {
        for (int i = 0; i < sorulanlar.Count; i++)
        {
            if (sorulanlar[i] == false)
            {
                int sorusayi = Random.Range(0, sorulanlar.Count);
                if (sorulanlar[sorusayi] == false)
                {
                    
                    sorulanlar[sorusayi] = true;
                    soruismi.text = sr.sorularr[sorusayi].soruismi;
                    cevapa.text = sr.sorularr[sorusayi].cevapa;
                    cevapb.text = sr.sorularr[sorusayi].cevapb;
                    cevapc.text = sr.sorularr[sorusayi].cevapc;
                    cevapd.text = sr.sorularr[sorusayi].cevapd;
                    cevap = sr.sorularr[sorusayi].cevap;
                }
                else
                {
                    SoruEkle();
                }
                break;
            }
            if (i == sorulanlar.Count - 1)
            {
                Debug.Log("HOPP");
            }
        }
        
    }
    
    public void CevapVer(int deger)
    {
        if (deger == cevap)
        {
            soundmanger.PlaySound();
            yanlisanimcagir = 0;
            dogruanimcagir = 1;
            SoruEkle();
            
        }
        else
        {
            yanlisanimcagir = 1;
            
        }

    }
}
