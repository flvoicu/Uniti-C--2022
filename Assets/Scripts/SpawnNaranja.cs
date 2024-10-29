using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnNaranja : MonoBehaviour
{

    float timer;
    public GameObject NaranjaPrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if(timer >= 2f)
        {
            timer = 0;
            float x = Random.Range(-170, 170);
            float y = Random.Range(-15, 10);
            Vector3 position = new Vector3(x,y,0);
            Quaternion rotation = new Quaternion();
            Instantiate(NaranjaPrefab, position, rotation);
        }
    }
}
