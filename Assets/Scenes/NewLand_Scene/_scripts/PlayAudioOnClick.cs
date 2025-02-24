using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class PlayAudioOnClick : MonoBehaviour
{
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void PlayAudio()
    {
        if (audioSource != null)
        {
            if (audioSource.isPlaying)
            {
                audioSource.Stop(); // Stop if already playing
            }
            audioSource.Play();
        }
    }
}
