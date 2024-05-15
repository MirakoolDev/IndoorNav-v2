using UnityEditor;
using UnityEditor.Build.Reporting;

public class BuildScript
{
    [MenuItem("Build/Build iOS")]
    public static void BuildIOS()
    {
        string buildPath = "Build/iOS";
        BuildReport report = BuildPipeline.BuildPlayer(EditorBuildSettings.scenes, buildPath, BuildTarget.iOS, BuildOptions.None);
        if (report.summary.result == BuildResult.Succeeded)
        {
            Debug.Log("iOS build succeeded.");
        }
        else
        {
            Debug.LogError("iOS build failed.");
        }
    }
}
