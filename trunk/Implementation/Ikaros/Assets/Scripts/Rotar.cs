using UnityEngine;
using System.Collections;

public class Rotar : MonoBehaviour {
  private Rect derecha;
  private Rect izquierda;
  public GUIStyle styleBotton;
  public float rotateSpeed=6.0f;	
 	
	// Use this for initialization
	void Start () {	
		this.redimensionarBotones(Screen.width,Screen.height);
	}
	
	// Update is called once per frame
	void Update () {
	   this.redimensionarBotones(Screen.width,Screen.height);
	}
	
	void OnGUI() {
	if(GUI.Button(derecha, "Derecha",styleBotton)) {
         this.RotarModeloDerecha();
        }
	if(GUI.Button(izquierda, "Izquierda",styleBotton)) {
          
        }
    
	
	}
	private void redimensionarBotones(double alto, double ancho){
		izquierda=new Rect(Screen.width*0.1f,Screen.height*0.8f,Screen.width*0.1f,Screen.height*0.06f);
	    derecha=new Rect(Screen.width*0.8f,Screen.height*0.8f,Screen.width*0.1f,Screen.height*0.06f);
	}
	public void RotarModeloDerecha(){		
		transform.Rotate(0, 20 * rotateSpeed * Time.deltaTime, 0);
	}
		
}
