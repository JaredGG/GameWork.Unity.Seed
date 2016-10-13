using System.IO;
using GameWork.Unity.Editor.Build;
using UnityEditor;
using UnityEngine;
using EventType = GameWork.Unity.Editor.Build.EventType;

namespace Editor.Build
{
    public static class SetupAndrodKeystore
    {
        [MenuItem("Tools/Build/Android/Setup Keystore")]
        [BuildEvent(EventType.Pre)]
        public static void Setup()
        {
            PlayerSettings.Android.keystoreName = Directory.GetParent(Application.dataPath).FullName +
                                                  "/BuildAssets/Android/seed.keystore";
            PlayerSettings.Android.keystorePass = "p4$Sw0rd";

            PlayerSettings.Android.keyaliasName = "seed";
            PlayerSettings.Android.keyaliasPass = "p4$Sw0rd";
        }
    }
}