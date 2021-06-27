using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NyawaNgurang : MonoBehaviour
{
    public GameObject nyawa1, nyawa2, nyawa3, gameOver;
    public static int nyawa;
    // Start is called before the first frame update
    void Start()
    {
        nyawa = 3;
        nyawa1.gameObject.SetActive(false);
        nyawa2.gameObject.SetActive(false);
        nyawa3.gameObject.SetActive(true);
        gameOver.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (nyawa > 3)
            nyawa = 3;
        
        switch (nyawa){
            case 3:
                nyawa1.gameObject.SetActive(false);
                nyawa2.gameObject.SetActive(false);
                nyawa3.gameObject.SetActive(true);
                gameOver.gameObject.SetActive(false);
            break;
            case 2:
                nyawa1.gameObject.SetActive(false);
                nyawa2.gameObject.SetActive(true);
                nyawa3.gameObject.SetActive(false);
                gameOver.gameObject.SetActive(false);
            break;
            case 1:
                nyawa1.gameObject.SetActive(true);
                nyawa2.gameObject.SetActive(false);
                nyawa3.gameObject.SetActive(false);
                gameOver.gameObject.SetActive(false);
            break;
            case 0:
                nyawa1.gameObject.SetActive(false);
                nyawa2.gameObject.SetActive(false);
                nyawa3.gameObject.SetActive(false);
                gameOver.gameObject.SetActive(true);
            break;
        }
    }
}
