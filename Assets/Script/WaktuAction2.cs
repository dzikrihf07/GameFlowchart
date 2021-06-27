using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaktuAction2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(No1(1));
    }

    private IEnumerator No1(float duration) {
        yield return new WaitForSeconds(duration);
        Waktu3Dtk.nyawa -= 1;
    }
}