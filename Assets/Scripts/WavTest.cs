using System.IO;
using UnityEngine;

public class WavTest : MonoBehaviour
{
    private void Start()
    {
        var wav = File.ReadAllBytes(Path.Combine(Application.streamingAssetsPath, "sample.wav"));

        var audioClip = Wav.ToAudioClip(wav, "sample");

        var audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.clip = audioClip;
        audioSource.Play();
    }
}
