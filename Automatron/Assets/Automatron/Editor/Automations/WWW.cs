using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System;

namespace TNRD.Automatron.Automations {

    [Automation( "WWW/Audio Clip" )]
    public class WWWAudioClip : Automation {

        public string URL;
        [ReadOnly]
        public AudioClip Result;

        public override IEnumerator Execute() {
            var www = new WWW( URL );
            while ( !www.isDone ) {
                yield return www;
                Progress = www.progress;
            }
            Result = www.audioClip;
            yield break;
        }
    }

    [Automation( "WWW/Movie Texture" )]
    public class WWWMovie : Automation {

        public string URL;
        [ReadOnly]
        public MovieTexture Result;

        public override IEnumerator Execute() {
            var www = new WWW( URL );
            while ( !www.isDone ) {
                yield return www;
                Progress = www.progress;
            }
            Result = www.movie;
            yield break;
        }
    }

    [Automation( "WWW/Text" )]
    public class WWWText : Automation {

        public string URL;
        [ReadOnly]
        public string Result;

        public override IEnumerator Execute() {
            var www = new WWW( URL );
            while ( !www.isDone ) {
                yield return www;
                Progress = www.progress;
            }
            Result = www.text;
            yield break;
        }
    }

    [Automation( "WWW/Texture" )]
    public class WWWTexture : Automation {

        public string URL;
        [ReadOnly]
        public Texture Result;

        public override IEnumerator Execute() {
            var www = new WWW( URL );
            while ( !www.isDone ) {
                yield return www;
                Progress = www.progress;
            }
            Result = www.texture;
            yield break;
        }
    }

    [Automation( "WWW/Escape URL" )]
    public class WWWEscape : Automation {

        public string URL;
        [ReadOnly]
        public string Result;

        public override IEnumerator Execute() {
            Result = WWW.EscapeURL( URL );
            yield break;
        }
    }

    [Automation( "WWW/Unescape URL" )]
    public class WWWUnEscapeURL : Automation {

        public string URL;
        [ReadOnly]
        public string Result;

        public override IEnumerator Execute() {
            Result = WWW.UnEscapeURL( URL );
            yield break;
        }
    }
}