using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIMgr : MonoBehaviour {

	public Text questionTxt;

	public Button ABtn;
	public Button BBtn;
	public Button CBtn;
	public Button DBtn;

	List<Button> btns;
	void Start () {
		btns = new List<Button>();
		questionTxt =transform.Find("question").GetComponent<Text>();
		ABtn = transform.Find("AButton").GetComponent<Button>();
		BBtn = transform.Find("BButton").GetComponent<Button>();
		CBtn = transform.Find("CButton").GetComponent<Button>();
		DBtn = transform.Find("DButton").GetComponent<Button>();

		btns.Add(ABtn);
		btns.Add(BBtn);
		btns.Add(CBtn);
		btns.Add(DBtn);

		DBtn.gameObject.SetActive(false);
	}
	public Text ques;
	public int currentIndex = 0;
	void Update () {
		if (Input.GetMouseButtonUp(2))
			if (currentIndex < QuestionDBModel.Instance.GetList().Count)
			{

				NextQuestion();

			}
	}

	void NextQuestion()
	{
		if (currentIndex >= QuestionDBModel.Instance.GetList().Count) return;
		RemoveClickListener();

		QuestionEntity entity = QuestionDBModel.Instance.Get(currentIndex.ToString());

		questionTxt.text = entity.question;
		ABtn.transform.Find("Text").GetComponent<Text>().text = entity.A;
		BBtn.transform.Find("Text").GetComponent<Text>().text = entity.B;
		CBtn.transform.Find("Text").GetComponent<Text>().text = entity.C;

		foreach(var item in btns)
		{
			if(entity.answer == item.name[0].ToString())
			{
				AddRightListner(item);
			}else
			{
				AddWrongListner(item);
			}
		}

		if (!string.IsNullOrEmpty(entity.D))
		{
			DBtn.transform.Find("Text").GetComponent<Text>().text = entity.D;
			DBtn.gameObject.SetActive(true);
		}
		else
		{
			DBtn.gameObject.SetActive(false);

		}
	}

	void RemoveClickListener()
	{
		ABtn.onClick.RemoveAllListeners();
		BBtn.onClick.RemoveAllListeners();
		CBtn.onClick.RemoveAllListeners();
		DBtn.onClick.RemoveAllListeners();
	}

	void AddWrongListner(Button btn)
	{
		


		btn.onClick.AddListener(()=> {
			Debug.Log("错误");
		});
	}

	void AddRightListner(Button btn)
	{
		btn.onClick.AddListener(() => {
			Debug.Log("正确");
			currentIndex++;
			NextQuestion();
		});
	}
}
