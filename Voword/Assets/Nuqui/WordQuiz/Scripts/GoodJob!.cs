using UnityEngine;

public class AudioPlayer : MonoBehaviour
{
    public AudioClip audioClip;

    private AudioSource audioSource;

    void Start()
    {
        // Get the AudioSource component attached to this GameObject
        audioSource = GetComponent<AudioSource>();

        // Set the AudioClip to play
        audioSource.clip = audioClip;

        // Play the audio clip
        audioSource.Play();
    }
}