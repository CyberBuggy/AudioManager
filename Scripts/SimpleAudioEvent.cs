using UnityEngine;
using Random = UnityEngine.Random;

namespace CyberBuggy
{
    [CreateAssetMenu(fileName = "SimpleAudioEvent", menuName = "PackageDevEnvironment/SimpleAudioEvent", order = 0)]
    public class SimpleAudioEvent : AudioEvent
    {
        public AudioClip[] _audioClips;
        public float _volume;
        public float _pitch;
        public override void Play(AudioSource audioSource)
        {
            if (_audioClips.Length == 0) return;

            audioSource.clip = _audioClips[Random.Range(0, _audioClips.Length)];
            audioSource.volume = _volume;
            audioSource.pitch = _pitch;
            audioSource.Play();
        }
    }
}
