# TemplateTemplateIdAnnotationService

A list of all methods in the `TemplateTemplateIdAnnotationService` service. Click on the method name to view detailed information about that method.

| Methods                                                   | Description             |
| :-------------------------------------------------------- | :---------------------- |
| [AddTemplateAnnotationAsync](#addtemplateannotationasync) | Add template annotation |

## AddTemplateAnnotationAsync

Add template annotation

- HTTP Method: `POST`
- Endpoint: `/template/{template_id}/annotation`

**Parameters**

| Name       | Type                         | Required | Description       |
| :--------- | :--------------------------- | :------- | :---------------- |
| input      | AddTemplateAnnotationRequest | ✅       | The request body. |
| templateId | string                       | ✅       |                   |
| accept     | string                       | ✅       |                   |

**Return Type**

`object`

**Example Usage Code Snippet**

```csharp
using Alohi.Signplus;
using Alohi.Signplus.Config;
using Alohi.Signplus.Models;

var config = new SignplusConfig{};

var client = new SignplusClient(config);

var signature = new AddTemplateAnnotationRequestSignature(Optional<string?>.Of("<string>"));
var initials = new AddTemplateAnnotationRequestInitials(Optional<string?>.Of("<string>"));
var font = new TextFont2(Optional<string?>.Of("SANS"), Optional<string?>.Of("<boolean>"), Optional<string?>.Of("<boolean>"));
var text = new AddTemplateAnnotationRequestText(Optional<string?>.Of("<number>"), Optional<string?>.Of("<number>"), Optional<string?>.Of("<string>"), Optional<string?>.Of("<string>"), Optional<string?>.Of("<string>"), Optional<TextFont2?>.Of(font));
var datetime = new AddTemplateAnnotationRequestDatetime(Optional<string?>.Of("<number>"), Optional<DatetimeFont2?>.Of(font), Optional<string?>.Of("<string>"), Optional<string?>.Of("<boolean>"), Optional<string?>.Of("<string>"), Optional<string?>.Of("<integer>"), Optional<string?>.Of("YMD_NUMERIC_SLASH"));
var checkbox = new AddTemplateAnnotationRequestCheckbox(Optional<string?>.Of("<boolean>"), Optional<string?>.Of("TIMES_SQUARE"));
var input = new AddTemplateAnnotationRequest(Optional<string?>.Of("<string>"), Optional<string?>.Of("<integer>"), Optional<string?>.Of("<float>"), Optional<string?>.Of("<float>"), Optional<string?>.Of("<float>"), Optional<string?>.Of("<float>"), Optional<string?>.Of("INITIALS"), Optional<string?>.Of("<string>"), Optional<string?>.Of("<boolean>"), Optional<AddTemplateAnnotationRequestSignature?>.Of(signature), Optional<AddTemplateAnnotationRequestInitials?>.Of(initials), Optional<AddTemplateAnnotationRequestText?>.Of(text), Optional<AddTemplateAnnotationRequestDatetime?>.Of(datetime), Optional<AddTemplateAnnotationRequestCheckbox?>.Of(checkbox));

var response = await client.TemplateTemplateIdAnnotation.AddTemplateAnnotationAsync(input, "template_id", "application/json");

Console.WriteLine(response);
```
