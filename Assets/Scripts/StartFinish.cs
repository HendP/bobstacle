using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartFinish : MonoBehaviour
{
    [SerializeField] bool isStart = false;
    [SerializeField] bool isFinish = false;

    [SerializeField] Material materialStart;

    [SerializeField] Material materialFinish;

    // Start is called before the first frame update
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player" && isStart)
        {
            GetComponent<MeshRenderer>().material = materialFinish;
            gameObject.tag = "Hit";
            Debug.Log("Player Moving");
        }

        if (other.gameObject.tag == "Player" && isFinish)
        {
            GetComponent<MeshRenderer>().material = materialFinish;
            gameObject.tag = "Hit";
            Debug.Log("Player Arrived");
        }
    }
}
