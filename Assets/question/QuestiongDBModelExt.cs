using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public partial class QuestionDBModel : DataTableDBModelBase<QuestionDBModel, QuestionEntity>
{
    protected override string FilePath
    {
        get
        {
            return UnityEngine.Application.dataPath + "/question/Resources";
        }
    }
}
