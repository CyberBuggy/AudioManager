using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CyberBuggy
{
    public abstract class AudioEvent : ScriptableObject
    {
        public abstract void Play(AudioSource audioSource);
    }
}
