using System.Text.Json.Serialization;

namespace Alohi.Signplus.Models;

public record AddTemplateDocumentRequest(
    /// <value>File to upload in binary format</value>
    [property: JsonPropertyName("file")] byte[] File
);
