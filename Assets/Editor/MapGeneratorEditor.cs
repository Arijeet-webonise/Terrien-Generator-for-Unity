using UnityEngine;
using System.Collections;
using UnityEditor;

[CustomEditor (typeof(MapGenerator))]
public class MapGeneratorEditor : Editor {

	public override void OnInspectorGUI(){
		MapGenerator map = (MapGenerator)target;

		if (DrawDefaultInspector ()) {
			if (map.autoUpdate) {
				map.DrawMapInEditor ();
			}
		}

		if (GUILayout.Button ("Generate")) {
			map.DrawMapInEditor ();
		}
	}
}
