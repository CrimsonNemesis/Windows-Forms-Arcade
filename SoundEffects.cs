using NAudio.Wave;
using System.Drawing.Printing;

internal static class SoundEffects
{
    public static void Play(string path)
    {
        var reader = new AudioFileReader(path);

        reader.Volume = GameSettings.SfxVolume;

        var output = new WaveOutEvent();

        output.Init(reader);

        output.Play();

        output.PlaybackStopped += (s, e) =>
        {
            output.Dispose();
            reader.Dispose();
        };
    }

    public static void SetVolume(float volume)
    {
        GameSettings.SfxVolume = volume;
    }
}