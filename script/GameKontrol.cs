using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameKontrol : MonoBehaviour
{
    private float saglik;
    public Image HealthBar;
    public Text kalanSayiText;
    private int kalansayiDeger;
    
    public GameObject[] Noktalar;
    public GameObject olusacakObje;
    public GameObject olusacakEngel;
    public Button[] butonlar;
    
    void Start()
    {
        saglik = 100;
        kalansayiDeger = 30;
        kalanSayiText.text = kalansayiDeger.ToString();
        //HealthBar.fillAmount -= .1f;
    }

    void butonlarýnKontrolu()
    {
        if (kalansayiDeger == 0)
        {
            foreach (var gelenbutonlar in butonlar)
            {
                gelenbutonlar.interactable = false;
            }
        }
    }
    public void canDusur(float darbe)
    {
        saglik -= darbe;
        HealthBar.fillAmount -= .1f;
        CanKontrolEt();
    }
    
    void CanKontrolEt()
    {

    }

    public void noktaButonlari(int indisDeger)
    {
        
        kalansayiDeger--;
        kalanSayiText.text = kalansayiDeger.ToString();
        Instantiate(olusacakObje, Noktalar[indisDeger].transform.position,Quaternion.identity);
        butonlarýnKontrolu();

        
    }

}
