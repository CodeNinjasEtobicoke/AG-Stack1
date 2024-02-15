using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameController : MonoBehaviour
{
    [Header("Cube Object")]
    public GameObject currentCube;
    [Header("Last Cube Object")]
    public GameObject lastCube;
    [Header("Text Object")]
    public Text text;
    [Header("Current Level")]
    public int Level;
    [Header("Boolean")]
    public bool Done;

    void NewBlock()
    {
        if(lastCube != null)
        {
            //Uncomment these when you come back Adam.
            //Comment unfinished codes before you close Unity and/or push to GitHub

            //currentCube.transform.position = new Vector3(Mathf.Round(currrentCube.transform.position.x),
                //current
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
