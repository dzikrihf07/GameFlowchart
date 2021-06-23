using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideJenisFlowchart : MonoBehaviour
{
    public GameObject UIMateri, Materi, Bt, Bg;
 
    public void Sembunyikan() {
        StartCoroutine(TemporarilyDeactivate(1));
    }
 
    private IEnumerator TemporarilyDeactivate(float duration) {
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
