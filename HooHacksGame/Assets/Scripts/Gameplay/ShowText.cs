using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class ShowText : MonoBehaviour
{
	public string textValue; 
	public Text textElement; 

    // Start is called before the first frame update
    void Start(){
     	Text gm = GameObject.FindWithTag("TextDisplay").GetComponent<Text>();
     	this.textElement = gm;
     	//CleanText();
	}

	public void SetTextToDisplayAndCleanIt(string s){
     	this.textElement.text = s; 
     	Invoke("CleanText",5f);//call that function after 5 secs
	}

	void CleanText(){
    	this.textElement.text="";
	}

	public void setTextElement() {
	}
}
