using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxEvent1 : MonoBehaviour
{
    //public MissionCtrl missions;
    [SerializeField] private string boxTag;
    [SerializeField] private bool placeIn;
    public int boxes = 0;
    //public bool boxesArranged = false;
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("obj: " + other.tag + " has entered");
        if (other.tag == /*boxTag*/"box" || other.tag == "box1" || other.tag == "box2")
        {
            //Debug.Log(other.tag);
            //Debug.Log(targetTag);
            boxes = boxes + 1;
            Debug.Log(boxes);
            bool res = placeIn;
            Getwinfunction(boxes, other.tag, res);
            //Debug.Log(placeIn);
            //Debug.Log(res);
            //Mission(other.tag, res);
        }
        
    }
    private void OnTriggerExit(Collider other)
    {
        Debug.Log("obj: " + other.tag + " has exited");
        if (other.tag == /*boxTag*/"box" || other.tag == "box1" || other.tag == "box2")
        {
            boxes = boxes - 1;
            Debug.Log(boxes);
            //Getwinfunction(boxes);
            //bool res = !placeIn;
            //Getwinfunction(boxes, other.tag);
            //Debug.Log(placeIn);
            //Debug.Log(res);
            //Mission(other.tag, res);
        }
    }

    public void Getwinfunction(int boxesNo, string tag, bool res) 
    {
        //Debug.Log(tag);
        Debug.Log(res);
        if(boxesNo == 3)
        {
            Debug.Log("boxes arranged");
            //boxesArranged = !boxesArranged;
            //Debug.Log(boxesArranged);
        }
        /*if(boxesNo == 3){
            Debug.Log("Boxes are put in the correct place");
        }*/
    }

    /*void Mission(string tag, bool stat)
    {
        if (tag == "box")
        {
            Debug.Log("go to win function");
            Debug.Log(tag);
            Debug.Log(stat);
            //missions.disposePaperStat = stat;
            //missions.MissionRefresh();
        }
    }*/
}
