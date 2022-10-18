using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomBobScript1 : MonoBehaviour
{
    public GameObject prefab;
    public int nobj = 5;
    public int maxx=0;
    public int maxz=10;
    public int minx=-20;
    public int minz=-10;
    public int y=0;
    // Start is called before the first frame update
    void Start()
    {
        for(int i=0;i<nobj;i++){
            Vector3 randomPos = new Vector3(Random.Range(minx,maxx),y,Random.Range(minz,maxz));
            Instantiate(prefab,randomPos,Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
