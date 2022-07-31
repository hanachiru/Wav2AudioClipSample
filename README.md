# Wav2AudioClipSample
<b>Wav2AudioClipSample</b> is a sample project to convert <code>.wav</code> to <code>AudioClip</code>.

``` sample.cs
// Read .wav as a byte array.
byte[] wav = File.ReadAllBytes(Path.Combine(Application.streamingAssetsPath, "sample.wav"));

// Convert .wav to AudioClip
AudioClip audioClip = Wav.ToAudioClip(wav, "sample");
```

## Dependency
Unity 2021.3.0f1 or later  

## Authors
Hanachiru([@hanaaaaaachiru](https://twitter.com/hanaaaaaachiru))
