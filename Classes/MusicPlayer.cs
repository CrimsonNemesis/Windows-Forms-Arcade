using NAudio.Wave;

internal static class MusicPlayer
{
    private static WaveOutEvent output;
    private static AudioFileReader audio;
    private static string? currentMusic;

    public static void Play(string path)
    {
        if (currentMusic == path &&
            output != null &&
            output.PlaybackState == PlaybackState.Playing)
        {
            return;
        }

        Stop();

        currentMusic = path;

        audio = new AudioFileReader(path);
        audio.Volume = GameSettings.MusicVolume;

        output = new WaveOutEvent();
        output.Init(audio);

        output.PlaybackStopped += (s, e) =>
        {
            if (audio != null && output != null)
            {
                audio.Position = 0;
                output.Play();
            }
        };

        output.Play();
    }

    public static void Stop()
    {
        output?.Stop();
        output?.Dispose();
        audio?.Dispose();

        output = null;
        audio = null;
        currentMusic = null;
    }

    public static void SetVolume(float volume)
    {
        GameSettings.MusicVolume = volume;

        if (audio != null)
            audio.Volume = volume;
    }
}