using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour
{
    //変数宣言
    float speed = 5.0f;
    // Start is called before the first frame update
    void Start(){
        //this.transform.position += new Vector3(0,0,speed);
    }

    // Update is called once per frame
    void Update()
    {
        //upは、PCキーボードの右下にある上矢印を指す
        if(Input.GetKey("up") == true){ 
            this.transform.position += new Vector3(0,0,speed * Time.deltaTime);
        }
        //downは、PCキーボードの右下にある下矢印を指す
        if(Input.GetKey("down") == true){
            this.transform.position -= new Vector3(0,0,speed * Time.deltaTime);
        }
        //rightは、PCキーボードの右下にある右矢印を指す
        if(Input.GetKey("right") == true){
            this.transform.position += new Vector3(speed * Time.deltaTime,0,0);
        }
        //leftは、PCキーボードの右下にある左矢印を指す
        if(Input.GetKey("left") == true){
            this.transform.position -= new Vector3(speed * Time.deltaTime,0,0);
        }

    }
    //あたり判定を検知した時に処理
    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag == "Enemy")
        {
            Debug.Log("当たったよ！！");
            SceneManager.LoadScene("GameOverScene");
        }
        
        
    }
    
}