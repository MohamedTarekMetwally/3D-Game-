using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PointsScript : MonoBehaviour
{
    public int health=100;
    public Text scoreText;
    public Text healthText;
    public int scoreCounter;
    void OnTriggerEnter(Collider x){
        if(x.gameObject.tag== "point"){
            x.gameObject.SetActive(false);
            scoreCounter++;
            scoreText.text="Score: "+scoreCounter;
        }
        if(x.gameObject.tag== "Frog"){
            x.gameObject.SetActive(false);
            health-=20;
            healthText.text="HP: "+health+"%";
        }

    }
    /*void update(){
    if(health<=0 )health=0;
    if(health<=0 || this.transform.position.y < -5 )
        pointscript.scoreText.text="GAME OVER ";
    }*/

}
