using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class sound : MonoBehaviour {
    public static sound game;
    public AudioSource vol;
    public Slider volslid;
    // Use this for initialization
    void Start ()
    {
        volslid.onValueChanged.AddListener(delegate { ValueChangeCheck(); });
    }
    void Awake()
    {

        if (game == null)
        {
            DontDestroyOnLoad(gameObject);
            game = this;
        }
        else if (game != this)
        {
            Destroy(gameObject);
        }
    }
    // Update is called once per frame
    void Update ()
    {

    }
    public void ValueChangeCheck()
    {
        PlayerPrefs.SetFloat("VolumeLevel", volslid.value);

        vol.volume = PlayerPrefs.GetFloat("VolumeLevel");
    }
}
