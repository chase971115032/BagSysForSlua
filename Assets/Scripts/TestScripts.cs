using UnityEngine;
using System.Collections;
using DG.Tweening;

public class TestScripts : MonoBehaviour {

	// Use this for initialization
	void Start () {
        //ToSluaTool.MoveToWords(transform.GetComponent<RectTransform>(),new Vector3(0,0,0),1f);
        //transform.GetComponent<RectTransform>().DOMove(new Vector3(0, 0, 0), 2);
        transform.GetComponent<RectTransform>().DOScale(1,2);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
