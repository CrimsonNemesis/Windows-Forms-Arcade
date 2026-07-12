using NAudio.Wave;
using System.Threading.Tasks;

internal static class SoundEffects
{
    public static void Play(string path)
    {
        if (GameSettings.SfxVolume <= 0) return;

        Task.Run(() =>
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
        });
    }

    public static void SetVolume(float volume)
    {
        GameSettings.SfxVolume = volume;
    }
}