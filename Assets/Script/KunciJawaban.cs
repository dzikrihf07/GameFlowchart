using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KunciJawaban : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt ("skor", 0);
    }

    public void jawaban(bool jawab) {
        if (jawab) {
            int skor = PlayerPrefs.GetInt ("skor") + 20;
            PlayerPrefs.SetInt ("skor", skor);
        } else {
            NyawaNgurang.nyawa -= 1;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
