/// <summary>
/// 实体父类
/// </summary>
public class BaseEntity
{
    private string sortfield;

    /// <summary>
    /// 排序字段
    /// </summary>
    public string SortField
    {
        get { return sortfield; }
        set { sortfield = value; }
    }

    private bool isDesc = false;

    /// <summary>
    /// 排序的顺序 true倒序 false正序 默认正序
    /// </summary>
    public bool IsDesc
    {
        get { return isDesc; }
        set { isDesc = value; }
    }

}