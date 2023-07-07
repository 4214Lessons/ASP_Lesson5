using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Lesson5.TagHelpers
{
    public class EmailTagHelper : TagHelper
    {
        public string SendTo { get; set; }
        public string Content { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "a";
            output.Attributes.Add("href", $"mailto:{SendTo}");
            output.Content.Append(Content);
        }
    }
}
