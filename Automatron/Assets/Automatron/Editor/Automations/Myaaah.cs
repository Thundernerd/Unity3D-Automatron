#if UNITY_EDITOR
using System;
using System.Collections;
using TNRD.Automatron;
using UnityEngine;
using UnityEditor;

[Automation( "Myaaah" )]
public class MyaaahAutomation : Automation {

    public int abcd;

    public override IEnumerator Execute() {
        
        yield break;
    }
}
#endif