
//===================================================
//作    者：Lixi  
//创建时间：2020-04-24 09:12:15
//===================================================
using System.Collections;
using System.Collections.Generic;
using System;
using System.Xml;

/// <summary>
/// Question数据管理
/// </summary>
public partial class QuestionDBModel : DataTableDBModelBase<QuestionDBModel, QuestionEntity>
{
    /// <summary>
    /// 文件名称
    /// </summary>
    public override string DataTableName { get { return "Question"; } }

    /// <summary>
    /// 加载列表
    /// </summary>
    protected override void LoadList(string dataTableData)
    {
        XmlDocument doc = new XmlDocument();
        doc.LoadXml(dataTableData);
        XmlElement root = doc.DocumentElement;

        foreach (XmlElement node in root)
        {
            QuestionEntity entity = new QuestionEntity();
            entity = entity.XmlToObject(node);

            m_List.Add(entity);
            m_Dic[entity.id] = entity;
        }
    }
}