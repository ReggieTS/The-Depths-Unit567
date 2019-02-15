using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioController : MonoBehaviour {

    public AudioMixer MasterAudio;

    public void SetMaster (float Mastervol)
    {
        MasterAudio.SetFloat("Master", Mastervol);

       
    }



}