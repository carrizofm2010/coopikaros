using UnityEngine;
using System.Collections;

public class DibujarPantalla : MonoBehaviour {
	
	public GUIStyle styleLabel1;
	public GUIStyle styleLabel2;
	public GUIStyle styleLabel3;
	public GUIStyle styleLabel4;
	public GUIStyle styleLabel5;
	public GUIStyle styleLabelIkaros;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	 void OnGUI() {
		GUILayout.BeginArea(new Rect(10, 10, Screen.width-20, Screen.height-20));
        GUILayout.Label("IKAROS COOP IT",styleLabelIkaros, GUILayout.Height(Screen.height/10));
        if ( GUILayout.Button("Modelo-1",styleLabel1,GUILayout.Height(Screen.height/6))  ) {
	  
			Application.LoadLevel("Naruto");
	}
        
		GUILayout.Button("Modelo-2",styleLabel2,GUILayout.Height(Screen.height/6));
        GUILayout.Button("Modelo-3",styleLabel3,GUILayout.Height(Screen.height/6));
		GUILayout.Button("Modelo-4",styleLabel4,GUILayout.Height(Screen.height/6));
        GUILayout.Button("Modelo-5",styleLabel5,GUILayout.Height(Screen.height/6));
        GUILayout.EndArea();
    }
}
