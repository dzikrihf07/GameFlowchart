using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeadlineSoal : MonoBehaviour
{
    public GameObject SoalMati, SoalMuncul;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(WaktuDeadline(30));
    }
    
    private IEnumerator WaktuDeadline(float duration) {
        yield return new WaitForSeconds(duration);

        SoalMati.SetActive(false);
        SoalMuncul.SetActive(true);
        
        NyawaNgurang.nyawa -= 1;
    }
}
