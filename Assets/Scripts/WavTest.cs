using System.IO;
using UnityEngine;

public class WavTest : MonoBehaviour
{
    private void Start()
    {
        // Reads .wav as a byte array.
        byte[] wav = File.ReadAllBytes(Path.Combine(Application.streamingAssetsPath, "sample.wav"));

        // Convert .wav to AudioClip
        AudioClip audioClip = Wav.ToAudioClip(wav, "sample");

        // Play AudioClip
        AudioSource audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.clip = audioClip;
        audioSource.Play();
    }
}