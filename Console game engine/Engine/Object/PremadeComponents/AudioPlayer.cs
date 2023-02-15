using System.Resources;
using System.Media;
using NAudio.Utils;
using NAudio.Wave;

namespace Engine.Object.PremadeComponents
{
    public class AudioPlayer : Component
    {
        public bool IsPlaying { get; private set; }
        public bool Loop { get; set; } = true;
        public bool StartPlayingAtAwake { get; set; } = true;

        private AudioFileReader audiofile;
        private WaveOutEvent waveEvent;
        private WaveStream WaveStream;

        //TODO: Properly implement looping audio
        public AudioPlayer(string file)
        {
            audiofile = new AudioFileReader(file);
            waveEvent = new WaveOutEvent();
            waveEvent.Init(audiofile);
            waveEvent.PlaybackStopped += loop_func;
            WaveStream = audiofile;
        }


        public void Play()
        {
            waveEvent.Play();
            IsPlaying = true;
        }

        public void Stop()
        {
            waveEvent.Stop();
            IsPlaying = false;
        }

        public void Pause()
        {
            waveEvent.Pause();
            IsPlaying = false;
        }


        public override void Load()
        {
            
        }

        public override void Awake()
        {
            if (StartPlayingAtAwake)
            {
                Play();
            }
        }

        public override void Update()
        {
            if (Loop && IsPlaying)
            {
                if (waveEvent.GetPositionTimeSpan() >= TimeSpan.MinValue)
                {
                    Play();
                }
            }
        }

        public override void Render()
        {
        }

        private void loop_func(object sender, StoppedEventArgs args)
        {
            IWavePlayer player = sender as IWavePlayer;
            if (WaveStream.Position == 0 && Loop)
            {
                Play();
            }
        }
    }
}
