using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bobBehavior : MonoBehaviour
{
    public GameObject fx;
    private AudioSource aud;
    public GameObject world;
    // Start is called before the first frame update
    void Start()
    {
        aud = GameObject.Find("sound").GetComponent<AudioSource>();
        world = GameObject.Find("world");
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void OnTriggerEnter(Collider other){
        if(other.tag=="player"){
            print("explosion !");
            aud.Play();
            Instantiate(fx,transform.position,Quaternion.identity);
            Destroy(gameObject);
            world.SendMessage("addExp");
        }
    }
}
