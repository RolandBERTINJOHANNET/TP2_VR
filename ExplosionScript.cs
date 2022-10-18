using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

//world behavior to allow incrementing the explosion counter
public class NewBehaviourScript : MonoBehaviour
{
    TMP_Text txtExp;
    TMP_Text txtCtr;
    int nbExp=0;
    int ctr=10;
    // Start is called before the first frame update
    void Start()
    {
        txtExp = GameObject.Find("explosionsText").GetComponent<TMPro.TMP_Text>();
        txtCtr = GameObject.Find("counterText").GetComponent<TMPro.TMP_Text>();
        StartCoroutine(TimerProcess());
    }

    // Update is called once per frame
    void Update()
    {
    }

    public IEnumerator TimerProcess(){
        while (ctr>0){
            yield return new WaitForSeconds(1);
            ctr--;
            txtCtr.text = "Seconds left : "+ctr;
        }
        SceneManager.LoadScene("mainscene");
    }

    public void addExp(){
        nbExp++;
        txtExp.text = "explosions : " + nbExp;
    }
}
