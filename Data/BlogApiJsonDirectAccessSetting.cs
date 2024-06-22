namespace Data;

/// <summary>
/// The clas hold the settings and folders we will use to store
/// out JSON files.
/// </summary>
public class BlogApiJsonDirectAccessSetting
{
    public string BlogPostsFolder { get; set; } = string.Empty;
    public string CategoriesFolder { get; set; } = string.Empty;
    public string TagsFolder { get; set; } = string.Empty;
    public string CommentsFolder { get; set; } = string.Empty;
    public string DataPath { get; set; } = string.Empty;
}
