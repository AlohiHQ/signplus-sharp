using System.Text.Json.Serialization;
using Signplus.Json;

namespace Signplus.Models;

/// <summary>Field to order templates by</summary>
public record TemplateOrderField : ValueEnum<string>
{
    internal TemplateOrderField(string value)
        : base(value) { }

    public TemplateOrderField()
        : base("TEMPLATE_ID") { }

    public static TemplateOrderField TemplateId = new("TEMPLATE_ID");
    public static TemplateOrderField TemplateCreationDate = new("TEMPLATE_CREATION_DATE");
    public static TemplateOrderField TemplateModificationDate = new("TEMPLATE_MODIFICATION_DATE");
    public static TemplateOrderField TemplateName = new("TEMPLATE_NAME");
}
