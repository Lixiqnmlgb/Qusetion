using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestionTest : MonoBehaviour {
	public Text ques;
	// Use this for initialization
	void Start () {
		QuestionEntity entity= QuestionDBModel.Instance.Get("2");
		Debug.Log(entity.answer);
		Debug.Log(entity.A);
		Debug.Log(entity.B);
		Debug.Log(entity.C);
		Debug.Log(entity.question);
	}

	public int currentIndex = 0;
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonUp(2))
		if(currentIndex < QuestionDBModel.Instance.GetList().Count)
		{
			QuestionEntity entity = QuestionDBModel.Instance.Get(currentIndex.ToString());
			currentIndex++;
			ques.text = entity.question + "\n";
			ques.text += entity.A + "\n";
			ques.text += entity.B + "\n";
			ques.text += entity.C + "\n";
			ques.text += entity.D + "\n";
		}
	}



  
}
