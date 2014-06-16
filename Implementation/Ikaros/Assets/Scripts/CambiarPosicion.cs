using UnityEngine;
using System.Collections;

public class CambiarPosicion : MonoBehaviour {
	
	public GUITexture imagenBotonCambiarPosicion;
	private bool botonCambiarPosicion=false;
	private bool botonPosicionPulsado=false;
	
	// Use this for initialization
	public float rotateSpeed=2.0f;
	private bool cambiarPosicion;

	void Start () {
	this.SituarControles();
	cambiarPosicion=true;
	}
	
	// Update is called once per frame
	void Update () {

	this.SituarControles();
	//Para el editor
		if(Input.GetKeyDown(KeyCode.R)){
			if(cambiarPosicion){
				this.cambiarOrientacionAParado();
				cambiarPosicion=false;
			}else{
				this.cambiarOrientacionAAcostado();
				cambiarPosicion=true;
			}
		
		}
	//para android
	if(Input.touchCount > 0){
        for (var i = 0; i < Input.touchCount; ++i) {   
        if(imagenBotonCambiarPosicion.HitTest(Input.GetTouch(i).position)){
					if(Input.GetTouch(i).phase==TouchPhase.Began){
						botonPosicionPulsado = true;  
					}
						                   
            }           
        } 
    } 
   
    if(botonPosicionPulsado){
			if(cambiarPosicion){
				this.cambiarOrientacionAParado();
				cambiarPosicion=false;
			}else{
				this.cambiarOrientacionAAcostado();
				cambiarPosicion=true;
			}
          
    }	    	
    
    botonPosicionPulsado = false;
	
	}
	private void cambiarOrientacionAParado(){

		transform.localPosition=new Vector3(0,0.15f,0);
        transform.localRotation=Quaternion.Euler(0,0,0);
	}
	private void cambiarOrientacionAAcostado(){
		transform.localPosition=new Vector3(-0.1056577f,0.4757624f,-0.7931951f);
        transform.localRotation=Quaternion.Euler(300.8452f,89.99997f,89.99997f);
	}
	public void SituarControles(){
		//DERECHA		
    	imagenBotonCambiarPosicion.transform.position = Vector3.zero;
    	imagenBotonCambiarPosicion.transform.localScale = Vector3.zero; 
		imagenBotonCambiarPosicion.guiTexture.pixelInset=new Rect(Screen.width*0.45f,Screen.height*0.1f,Screen.width*0.1f,Screen.height*0.06f);
	
		
  }
}
