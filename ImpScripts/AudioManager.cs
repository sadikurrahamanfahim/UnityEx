using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public Sounds[] sound;

    // Start is called before the first frame update
    void Start()
    {
        foreach(Sounds s in sound)
        {
            s.source= gameObject.AddComponent<AudioSource>();
            s.source.loop= s.loop;
            s.source.clip= s.clip;
            s.source.volume= s.volume;
        }

        PlaySound("Theme");
    }

    public void PlaySound(string name)
    {
        foreach (Sounds s in sound)
        {
            if(s.name == name)
            {
                s.source.Play();
            }
        }
    }
}
