using UnityEngine;
using System.Collections;

public class DibujarPantalla : MonoBehaviour {
	
	public GUIStyle btn_centinel;
	public GUIStyle btn_bowser;
	public GUIStyle btn_morrigan;
	public GUIStyle btn_goku;
	public GUIStyle btn_mai_shiranui;
	public GUIStyle btn_banner_ikaro;
	public GUIStyle styleBox;
	
	private bool alwaysShowHorizontal; 
	private bool alwaysShowVertical;
	
	private bool desaparecerPantalla;
	private Vector2 scrollPosition; 
	private Rect Caja;

	// Use this for initialization
	void Start () {
		desaparecerPantalla=true;
		//variables temporales, borrar si no se utilizan en otra parte
		alwaysShowHorizontal = false;
		alwaysShowVertical = true;
	}
	
	// Update is called once per frame
	void Update () {
		
		Caja=new Rect(0,0,Screen.width,Screen.height);
		
		if(Input.GetKeyDown(KeyCode.Escape)){
				Application.Quit();
		}
		if(Input.GetKeyDown(KeyCode.Menu)||Input.GetKey(KeyCode.M)){
			    Application.LoadLevel("About");
		}
	}
	void OnGUI() {
		if(desaparecerPantalla){
			
			GUI.Box(Caja,"", styleBox);
			
	        GUILayout.BeginArea(new Rect(10, 10, Screen.width-20, Screen.height-20));
			
			//setting scroll
			scrollPosition = GUILayout.BeginScrollView(scrollPosition, alwaysShowVertical, alwaysShowHorizontal,GUILayout.Height(Screen.height));
		
			
	        GUILayout.Label("",btn_banner_ikaro, GUILayout.Height(Screen.height*0.1f));
			
	        if(GUILayout.Button("",btn_centinel,GUILayout.Height(Screen.height*0.185f))){
		        desaparecerPantalla=false;
				Application.LoadLevel(1);
			}
			
			GUILayout.Label("",GUILayout.Height(Screen.height*0.0004f));	
			
			if(GUILayout.Button("",btn_bowser,GUILayout.Height(Screen.height*0.185f))){
					desaparecerPantalla=false;
					Application.LoadLevel(2);
			}
		
			GUILayout.Label("",GUILayout.Height(Screen.height*0.0004f));		
	        if(GUILayout.Button("",btn_morrigan,GUILayout.Height(Screen.height*0.185f))){
					desaparecerPantalla=false;
					Application.LoadLevel(3);
			}
			
		    GUILayout.Label("",GUILayout.Height(Screen.height*0.0004f));	
			if(GUILayout.Button("",btn_goku,GUILayout.Height(Screen.height*0.185f))){
					desaparecerPantalla=false;
					Application.LoadLevel(4);
			}
				
			GUILayout.Label("",GUILayout.Height(Screen.height*0.0004f));	
			
	        if(GUILayout.Button(" ",btn_mai_shiranui,GUILayout.Height(Screen.height*0.185f))){
					desaparecerPantalla=false;
					Application.LoadLevel(5);
			}
			GUILayout.EndScrollView();
	        GUILayout.EndArea();
		}
	}
}
