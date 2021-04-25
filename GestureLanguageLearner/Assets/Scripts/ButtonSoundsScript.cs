using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonSoundsScript : MonoBehaviour
{
    //variables
    public AudioSource myFX;
    public AudioClip hoverFx;
    public AudioClip clickFx;
    public AudioClip wrongFx;
    public AudioClip correctFx;
    //play when hover over button
    public void HoverSound()
    {
        myFX.PlayOneShot(hoverFx);
    }
    //play when clicked
    public void ClickSound()
    {
        myFX.PlayOneShot(clickFx);
    }
    
    //play when requested
    public void correctSound()
    {
        myFX.PlayOneShot(correctFx);
    }
    
    //play when requested
    public void wrongSound()
    {
        myFX.PlayOneShot(wrongFx);
    }
}
