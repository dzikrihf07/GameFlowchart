using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeadlineSoal : MonoBehaviour
{
    public GameObject scrollbar, SoalMati, SoalMuncul;
    float scroll_pos = 0;
    float [] pos;
    int posisi = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(WaktuDeadline(30));

        pos = new float[transform.childCount];
        float distance = 1f / (pos.Length - 1f);
        for (int i = 0; i < pos.Length; i++) {
            pos [i] = distance * i;
        }

        if (Input.GetMouseButton (0)) {
            scroll_pos = scrollbar.GetComponent<Scrollbar> ().value;
        } else {
            for (int i = 0; i < pos.Length; i++) {
                if (scroll_pos < pos [i] + (distance / 2) && scroll_pos > pos [i] - (distance /2)) {
                    scrollbar.GetComponent<Scrollbar> ().value = Mathf.Lerp (scrollbar.GetComponent<Scrollbar>().value, pos[i], 0.15f);
                    posisi = i;
                }
            }
        }
    }
    private IEnumerator WaktuDeadline(float duration) {
        yield return new WaitForSeconds(duration);

        SoalMati.SetActive(false);
        SoalMuncul.SetActive(true);

        if (posisi < pos.Length - 1) {
            posisi += 1;
            scroll_pos = pos [posisi];
        }
    }
}
