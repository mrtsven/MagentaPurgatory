using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleScript : MonoBehaviour
{

    public GameObject puzzleFace1;
    public GameObject puzzleFace2;
    public GameObject puzzleFace3;

    public GameObject companion;

    private ArrayList puzzleOrder;
    private ArrayList playerOrder;

    private bool check1 = false;
    private bool check2 = false;
    private bool check3 = false;
    private bool check4 = false;
    private bool check5 = false;

    private bool completed = false;

    public void CollisionDetected(string childTag)
     {
        playerOrder.Add(childTag);
        Debug.Log(childTag);
     }

    // Start is called before the first frame update
    void Start()
    {
        puzzleOrder = new ArrayList();
        playerOrder = new ArrayList();
        puzzleOrder.Add("2");
        puzzleOrder.Add("3");
        puzzleOrder.Add("2");
        puzzleOrder.Add("1");
        puzzleOrder.Add("3");        
    }

    // Update is called once per frame
    void Update()
    {
        if(playerOrder.Count == 5){
            if(puzzleOrder[0].Equals(playerOrder[0])){
                check1 = true;
            }
            if(puzzleOrder[1].Equals(playerOrder[1])){
                check2 = true;
            }
            if(puzzleOrder[2].Equals(playerOrder[2])){
                check3 = true;
            }
            if(puzzleOrder[3].Equals(playerOrder[3])){
                check4 = true;
            }
            if(puzzleOrder[4].Equals(playerOrder[4])){
                check5 = true;
            }

            // if(check1 || check2 || check3 || check4 || check5){
            //     playerOrder.RemoveRange(0,5);
            // }
        }   

        if(check1 && check2 && check3 && check4 && check5){
            completed = true;
        }

        if(completed){
            companion.gameObject.SetActive(true);
            completed = false;
        }

    }
}
