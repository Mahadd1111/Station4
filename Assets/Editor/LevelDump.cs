using System.Text;
using UnityEditor;
using UnityEngine;

public class LevelDump
{
    [MenuItem("Tools/Dump Selected Geometry")]
    private static void Dump()
    {
        StringBuilder sb = new();
        foreach (GameObject root in Selection.gameObjects)
        {
            Walk(root.transform, 0, sb);
        }
        EditorGUIUtility.systemCopyBuffer = sb.ToString();
        Debug.Log(sb.ToString());
    }

    private static void Walk(Transform t, int depth, StringBuilder sb)
    {
        string indent = new(' ', depth * 2);
        
        if (t.TryGetComponent<Renderer>(out var r))
        {
            Vector3 c = r.bounds.center;
            Vector3 s = r.bounds.size;
            sb.AppendLine($"{indent}{t.name}  @({c.x:F2}, {c.y:F2}, {c.z:F2})  size({s.x:F2} x {s.y:F2} x {s.z:F2})");
        }
        else
        {
            sb.AppendLine($"{indent}{t.name}/");
        }

        foreach (Transform child in t)
        {
            Walk(child, depth + 1, sb);
        }
    }
}