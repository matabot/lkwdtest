//Conditional Compile Flags.
//You wouldn't want this included in a packaged build. Nor would it compile.
#if UNITY_EDITOR
using System;
using System.Globalization;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class BuildAndroid 
{
    [MenuItem("Build/Build Android")]
    static void Build()
    {
        //Can be extended for further scenes.
        string[] defaultScene = { 
            "Assets/Scenes/SampleScene.unity"
            };

        BuildPlayerOptions buildPlayerOptions = new BuildPlayerOptions();
        buildPlayerOptions.scenes = new[] { "Assets/Scenes/SampleScene.unity"};
        buildPlayerOptions.locationPathName = "/Build/LKWDAndroidBuild";
        buildPlayerOptions.target = BuildTarget.Android;
        buildPlayerOptions.options = BuildOptions.None;


        BuildPipeline.BuildPlayer(buildPlayerOptions);
    }
}
#endif