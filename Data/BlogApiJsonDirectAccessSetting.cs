namespace Data;
/// <summary>
/// This is the class where we hold our settings and the folders used to store our json files.
/// </summary>
public class BlogApiJsonDirectAccessSetting
{
    public string BlogPostsFolder { get; set; } = string.Empty;
    public string CategoriesFolder { get; set; } = string.Empty;
    public string TagsFolder { get; set;} = string.Empty;
    public string CommentsFolder { get; set; } = string.Empty;
    public string DataPath { get; set; } = string.Empty;
}