using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class RandomWalkBob : MonoBehaviour
{
    public float mRange = 25.0f;
    Vector2 lastPos;
    Vector2 randomPos;
    NavMeshAgent mAgent;
    // Start is called before the first frame update
    void Start()
    {
        mAgent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if (mAgent.pathPending || mAgent.remainingDistance > 0.1f)
            return;
        randomPos = Random.insideUnitCircle * mRange;
        if (randomPos == lastPos)
            randomPos = Random.insideUnitCircle * mRange;
        mAgent.destination = new Vector3(randomPos.x,0,randomPos.y);
    }
}
