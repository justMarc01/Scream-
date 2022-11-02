using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ListenForAudioCommand : MonoBehaviour
{
    public float volume;
    public float bigVol;

    public Text score;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bigVol = 1000 * MicInput.MicLoudness;
        volume = Mathf.RoundToInt(bigVol);
        score.text = volume.ToString();
    }
}
