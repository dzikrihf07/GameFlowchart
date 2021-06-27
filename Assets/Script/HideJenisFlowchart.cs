using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideJenisFlowchart : MonoBehaviour
{
    public GameObject UIMateri, Materi, Bt, Bg;
 
    public void Sembunyikan() {
        StartCoroutine(WaktuSembuyikan(1));
    }
 
    private IEnumerator WaktuSembuyikan(float duration) {
        UIMateri.SetActive(true);
        Materi.SetActive(true);
        Bt.SetActive(true);
        Bg.SetActive(true);

        yield return new WaitForSeconds(duration);

        UIMateri.SetActive(false);
        Materi.SetActive(false);
        Bt.SetActive(false);
        Bg.SetActive(false);
    }
}
