using UnityEngine;
using System.Collections;

public class RotarModelo : MonoBehaviour {
	//imagenes para los botones
	public GUITexture imagenBotonIzquierda;
	public GUITexture imagenBotonDerecha;
	private bool botonIzquierdaPulsado=false;
	private bool botonDerechaPulsado=false;
	
	public float rotateSpeed=2.0f;
	void Awake(){
		this.SituarControles();
	}
	// Use this for initialization
	void Start () { 
	    this.SituarControles();
	}
	
	// Update is called once per frame
	void Update () {
		this.SituarControles();
		Screen.orientation=ScreenOrientation.AutoRotation;
	//-------------------------Editor----------------------------------------

	if(Input.GetKey(KeyCode.A)){
		transform.Rotate(0, 20 * rotateSpeed * Time.deltaTime, 0);
		}
	if(Input.GetKey(KeyCode.D)){
		transform.Rotate(0, -20 * rotateSpeed * Time.deltaTime, 0);	
		}
	//-----------------------------------------------------------------	
		
	 if(Input.touchCount > 0){
        for (var i = 0; i < Input.touchCount; ++i) {   
        if(imagenBotonIzquierda.HitTest(Input.GetTouch(i).position)){
						botonIzquierdaPulsado = true;                     
            }else if(imagenBotonDerecha.HitTest(Input.GetTouch(i).position)){
						botonDerechaPulsado = true;
            }             
        } 
    } 
   
    if(botonDerechaPulsado){
			transform.Rotate(0, -20 * rotateSpeed * Time.deltaTime, 0);
          
    }else if(botonIzquierdaPulsado){
         transform.Rotate(0, 20 * rotateSpeed * Time.deltaTime, 0); 		
    }     
     		    	
    
    botonDerechaPulsado = false;
    botonIzquierdaPulsado = false;

	}

	public void SituarControles(){
	//DERECHA
    imagenBotonDerecha.transform.position = Vector3.zero;
    imagenBotonDerecha.transform.localScale = Vector3.zero; 
	imagenBotonDerecha.guiTexture.pixelInset=new Rect(Screen.width*0.8f,Screen.height*0.1f,Screen.width*0.1f,Screen.height*0.06f);
	//IZQUIERDA
	imagenBotonIzquierda.transform.position = Vector3.zero;
    imagenBotonIzquierda.transform.localScale = Vector3.zero;	
	imagenBotonIzquierda.guiTexture.pixelInset=new Rect(Screen.width*0.1f,Screen.height*0.1f,Screen.width*0.1f,Screen.height*0.06f);
    
  }

}
