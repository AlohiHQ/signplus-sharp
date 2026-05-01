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

var signature = new AddTemplateAnnotationRequestSignature(Optional<string?>.Of("string"));
var initials = new AddTemplateAnnotationRequestInitials(Optional<string?>.Of("string"));
var font = new TextFont2(Optional<string?>.Of("SANS"), Optional<bool?>.Of(false), Optional<bool?>.Of(false));
var text = new AddTemplateAnnotationRequestText(Optional<double?>.Of(6190.822136605691), Optional<double?>.Of(6489.781325519173), Optional<string?>.Of("string"), Optional<string?>.Of("string"), Optional<string?>.Of("string"), Optional<TextFont2?>.Of(font));
var datetime = new AddTemplateAnnotationRequestDatetime(Optional<double?>.Of(3773.1065479576364), Optional<DatetimeFont2?>.Of(font), Optional<string?>.Of("string"), Optional<bool?>.Of(true), Optional<string?>.Of("string"), Optional<double?>.Of(6868), Optional<string?>.Of("MDY_TEXT_SPACE_SHORT"));
var checkbox = new AddTemplateAnnotationRequestCheckbox(Optional<bool?>.Of(false), Optional<string?>.Of("SQUARE_CHECK"));
var input = new AddTemplateAnnotationRequest(Optional<string?>.Of("string"), Optional<double?>.Of(6387), Optional<double?>.Of(4410.13346533615), Optional<double?>.Of(5148.888749329143), Optional<double?>.Of(3756.0248729763225), Optional<double?>.Of(4178.76189579703), Optional<string?>.Of("INITIALS"), Optional<string?>.Of("string"), Optional<bool?>.Of(false), Optional<AddTemplateAnnotationRequestSignature?>.Of(signature), Optional<AddTemplateAnnotationRequestInitials?>.Of(initials), Optional<AddTemplateAnnotationRequestText?>.Of(text), Optional<AddTemplateAnnotationRequestDatetime?>.Of(datetime), Optional<AddTemplateAnnotationRequestCheckbox?>.Of(checkbox));

var response = await client.TemplateTemplateIdAnnotation.AddTemplateAnnotationAsync(input, "template_id", "application/json");

Console.WriteLine(response);
```
