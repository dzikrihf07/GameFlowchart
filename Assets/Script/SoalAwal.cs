using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoalAwal : MonoBehaviour
{
    public GameObject soal1, soal2, soal3, soal4, soal5;
    // Start is called before the first frame update
    void Start()
    {
        soal1.gameObject.SetActive(true);
        soal2.gameObject.SetActive(false);
        soal3.gameObject.SetActive(false);
        soal4.gameObject.SetActive(false);
        soal5.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
