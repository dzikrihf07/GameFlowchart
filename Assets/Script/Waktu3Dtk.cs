using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waktu3Dtk : MonoBehaviour
{
    public GameObject no1, no2, no3, waktu, soal;
    public static int nyawa;
    // Start is called before the first frame update
    void Start()
    {
        nyawa = 3;
        no1.gameObject.SetActive(true);
        no2.gameObject.SetActive(false);
        no3.gameObject.SetActive(false);
        waktu.gameObject.SetActive(true);
        soal.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (nyawa > 3)
            nyawa = 3;
        
        switch (nyawa){
            case 3:
                no1.gameObject.SetActive(true);
                no2.gameObject.SetActive(false);
                no3.gameObject.SetActive(false);
                waktu.gameObject.SetActive(true);
                soal.gameObject.SetActive(false);
            break;
            case 2:
                no1.gameObject.SetActive(false);
                no2.gameObject.SetActive(true);
                no3.gameObject.SetActive(false);
                waktu.gameObject.SetActive(true);
                soal.gameObject.SetActive(false);
            break;
            case 1:
                no1.gameObject.SetActive(false);
                no2.gameObject.SetActive(false);
                no3.gameObject.SetActive(true);
                waktu.gameObject.SetActive(true);
                soal.gameObject.SetActive(false);
            break;
            case 0:
                no1.gameObject.SetActive(false);
                no2.gameObject.SetActive(false);
                no3.gameObject.SetActive(false);
                waktu.gameObject.SetActive(false);
                soal.gameObject.SetActive(true);
            break;
        }
    }
}
