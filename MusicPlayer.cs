using NAudio.Wave;

internal static class MusicPlayer
{
    private static WaveOutEvent output;
    private static AudioFileReader audio;

    public static void Play(string path)
    {
        Stop();

        audio = new AudioFileReader(path);
        output = new WaveOutEvent();
        output.Init(audio);

        output.PlaybackStopped += (s, e) =>
        {
            audio.Position = 0;
            output.Play();
        };

        output.Play();
    }

    public static void Stop()
    {
        output?.Stop();
        output?.Dispose();
        audio?.Dispose();
    }
}