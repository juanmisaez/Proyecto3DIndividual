using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySoundSystem : MonoBehaviour
{    
    public void PlaySound(string tag, string nameSound)
    {
        if(gameObject.tag == tag)
        {
            FindObjectOfType<AudioManager>().Play(nameSound);
        }
    }
}