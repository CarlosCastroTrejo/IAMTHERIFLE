using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour {

    [System.Serializable]
    public class SingleSound {
        public string name;
        public AudioClip clip;
    }

    public SingleSound[] soundList;
    Dictionary<string, AudioClip> dict;
    public GameObject genericAudioSource;
    static public SoundManager instance;

    private void Awake()
    {
        instance = this;
    }

    // Use this for initialization
    void Start () {
        dict = new Dictionary<string, AudioClip>();
        foreach (SingleSound s in soundList) dict.Add(s.name, s.clip);
	}

    public void PlaySound(string name) {
        AudioClip c;
        if (dict.TryGetValue(name, out c))
        {
            GameObject g = Instantiate(genericAudioSource) as GameObject;
            AudioSource a = g.GetComponent<AudioSource>();
            a.clip = c;
            a.Play();
            Destroy(g, c.length);
        }
        else {
            Debug.Log("Sonido " + name + " ignorado");
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
