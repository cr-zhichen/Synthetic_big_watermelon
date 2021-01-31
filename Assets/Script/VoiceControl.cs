/// <summary>
/// 控制下落与胜利声音
/// </summary>
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class VoiceControl : MonoBehaviour
{

    public AudioSource fallingSound;//下落声音
    public AudioSource voiceOfVictory;//胜利声音

    public void PlayTheFallingSound()
    {
        fallingSound.Play();
    }

    public void PlayVictory()
    {
        voiceOfVictory.Play();
    }

}
