using UnityEngine;

public class BGMScript : MonoBehaviour
 {
    private static BGMScript _instance;

    public static BGMScript instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = GameObject.FindObjectOfType<BGMScript>();
                //Tell unity not to destroy this object when loading a new scene!
                DontDestroyOnLoad(_instance.gameObject);
            }
            return _instance;
        }
    }

    private void Awake()
    {
        if (_instance == null)
        {
            Debug.Log("Null");
            //If I am the first instance, make me the Singleton
            _instance = this;
            DontDestroyOnLoad(this);
        }
        else
        {
            //If a Singleton already exists and you find
            //another reference in scene, destroy it!
            if (this != _instance)
            {
                Play();
                Debug.Log("IsnotNull");
                Destroy(this.gameObject);
            }
        }
    }
    public void Update()
    {
        if (this != _instance)
        {
            _instance = null;
        }
    }
    public void Play()
    {
        this.gameObject.GetComponent<AudioSource>().Play();
    }
 // any other methods you need
 }