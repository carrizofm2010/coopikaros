using UnityEngine;
using System.Collections;

public class DibujarPantalla : MonoBehaviour {
	
	public GUIStyle styleLabel;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	 void OnGUI() {
        GUILayout.BeginArea(new Rect(10, 10, Screen.width-20, Screen.height-20));
        GUILayout.Label("IKAROS COOP IT",GUILayout.Height(Screen.height/20));
        if(GUILayout.Button("Modelo-1",styleLabel,GUILayout.Height(Screen.height/5))) {
	  
			Application.LoadLevel("Naruto");
	}
		GUILayout.Button("Modelo-2",GUILayout.Height(Screen.height/7));
        GUILayout.Button("Modelo-3",GUILayout.Height(Screen.height/7));
		GUILayout.Button("Modelo-4",GUILayout.Height(Screen.height/7));
        GUILayout.Button("Modelo-5",GUILayout.Height(Screen.height/7));
        GUILayout.EndArea();
    }
}
