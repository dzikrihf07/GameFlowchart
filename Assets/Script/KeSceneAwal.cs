using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class KeSceneAwal : MonoBehaviour
{
    public GameObject play, menu;
    public void btPindah () {
        Application.LoadLevel("SceneAwalMenu");
    }
}
