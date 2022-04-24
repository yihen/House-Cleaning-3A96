using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tryspray : MonoBehaviour
{
    public GameObject water;

	[SerializeField] private GameObject muzzlePt;
    [SerializeField] private float waterSpeed = 100f;


    public void OnShoot()
{
    GameObject tmpWater;
    tmpWater = Instantiate(water, muzzlePt.transform.position,  Quaternion.identity);
    tmpWater.GetComponent<Rigidbody>().AddForce(muzzlePt.transform.forward *  waterSpeed);

}




}
