using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnarScript : MonoBehaviour
{
    public GameObject Enemy;
    //1:生成されたEnemyの変数宣言
    GameObject EnemyClone;

    float timer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > 1)
        {
            //2:Enemyを生成し、それを変数EnemyCloneに格納する
            EnemyClone = Instantiate(Enemy, this.transform.position + this.transform.right * Random.Range(-10.0f, 10.0f), this.transform.rotation) as GameObject;

            //3:生成されたEnemy(生成し、格納された変数)をDestroyする
            Destroy(EnemyClone, 5.0f);
            timer = 0;
        }
    }
}
