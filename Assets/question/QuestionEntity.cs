
//===================================================
//作    者：Lixi  
//创建时间：2020-04-24 09:12:15
//===================================================
using System.Collections;

/// <summary>
/// Question实体
/// </summary>
public partial class QuestionEntity : DataTableEntityBase
{
    /// <summary>
    /// answer
    /// </summary>
    public string answer;

    /// <summary>
    /// 摄像机出生点坐标
    /// </summary>
    public string A;

    /// <summary>
    /// 摄像机旋转角度
    /// </summary>
    public string B;

    /// <summary>
    /// 摄像机前后移动速度
    /// </summary>
    public string C;

    /// <summary>
    /// 摄像机上下左右移动速度
    /// </summary>
    public string D;

    /// <summary>
    /// 描述
    /// </summary>
    public string question;

  public QuestionEntity XmlToObject(System.Xml.XmlElement element)
  {
	 if (element.HasAttribute("id") && !string.IsNullOrEmpty(element.GetAttribute("id")))
	 {
		id= element.GetAttribute("id");
	 }

	 if (element.HasAttribute("answer") && !string.IsNullOrEmpty(element.GetAttribute("answer")))
	 {
		answer= element.GetAttribute("answer");
	 }

	 if (element.HasAttribute("A") && !string.IsNullOrEmpty(element.GetAttribute("A")))
	 {
		A= element.GetAttribute("A");
	 }

	 if (element.HasAttribute("B") && !string.IsNullOrEmpty(element.GetAttribute("B")))
	 {
		B= element.GetAttribute("B");
	 }

	 if (element.HasAttribute("C") && !string.IsNullOrEmpty(element.GetAttribute("C")))
	 {
		C= element.GetAttribute("C");
	 }

	 if (element.HasAttribute("D") && !string.IsNullOrEmpty(element.GetAttribute("D")))
	 {
		D= element.GetAttribute("D");
	 }

	 if (element.HasAttribute("question") && !string.IsNullOrEmpty(element.GetAttribute("question")))
	 {
		question= element.GetAttribute("question");
	 }

     return this;
  }
}
