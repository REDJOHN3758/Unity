using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicHelper : MonoBehaviour
{
    AudioSource myAudio;
    // Start is called before the first frame update
    void Start()
    {
        myAudio = GetComponent<AudioSource>();
        //myAudio.Stop();
        myAudio.clip = Resources.Load<AudioClip>("click");
        myAudio.Play();
        //Debug.Log("myAudio " + music.name.ToString());
    }

    /*private AudioSource CreateAudioSource(string filename)
    {
        AudioSource audio = this.gameObject.AddComponent<AudioSource>();
        audio.clip = Resources.Load<AudioClip>(filename);
        return audio;
    }*/

    // Update is called once per frame
    void Update()
    {
        //if(ColliderScript.IsCollision && ColliderScript.score < 6)
        //{
            //myAudio.clip = Resources.Load<AudioClip>("Coin04");
            //myAudio.Play(0);
            //Debug.Log("myAudio " + myAudio.clip.ToString());
       // }
        //if(ColliderScript.IsCollision && ColliderScript.score > 5)
       // {
            //myAudio.clip = Resources.Load<AudioClip>("ElectricitySpell");
            //myAudio.Play(0);
            //Debug.Log("myAudio " + myAudio.clip.ToString());
       // }
    }
}
