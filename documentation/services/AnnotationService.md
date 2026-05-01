# AnnotationService

A list of all methods in the `AnnotationService` service. Click on the method name to view detailed information about that method.

| Methods                                                   | Description             |
| :-------------------------------------------------------- | :---------------------- |
| [AddEnvelopeAnnotationAsync](#addenvelopeannotationasync) | Add envelope annotation |

## AddEnvelopeAnnotationAsync

Add envelope annotation

- HTTP Method: `POST`
- Endpoint: `/envelope/{envelope_id}/annotation`

**Parameters**

| Name       | Type                         | Required | Description       |
| :--------- | :--------------------------- | :------- | :---------------- |
| input      | AddEnvelopeAnnotationRequest | ✅       | The request body. |
| envelopeId | string                       | ✅       |                   |
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

var signature = new AddEnvelopeAnnotationRequestSignature(Optional<string?>.Of("<string>"));
var initials = new AddEnvelopeAnnotationRequestInitials(Optional<string?>.Of("<string>"));
var font = new TextFont1(Optional<string?>.Of("SANS"), Optional<string?>.Of("<boolean>"), Optional<string?>.Of("<boolean>"));
var text = new AddEnvelopeAnnotationRequestText(Optional<string?>.Of("<number>"), Optional<string?>.Of("<number>"), Optional<string?>.Of("<string>"), Optional<string?>.Of("<string>"), Optional<string?>.Of("<string>"), Optional<TextFont1?>.Of(font));
var datetime = new AddEnvelopeAnnotationRequestDatetime(Optional<string?>.Of("<number>"), Optional<DatetimeFont1?>.Of(font), Optional<string?>.Of("<string>"), Optional<string?>.Of("<boolean>"), Optional<string?>.Of("<string>"), Optional<string?>.Of("<integer>"), Optional<string?>.Of("YMD_NUMERIC_SLASH"));
var checkbox = new AddEnvelopeAnnotationRequestCheckbox(Optional<string?>.Of("<boolean>"), Optional<string?>.Of("TIMES_SQUARE"));
var input = new AddEnvelopeAnnotationRequest(Optional<string?>.Of("<string>"), Optional<string?>.Of("<integer>"), Optional<string?>.Of("<float>"), Optional<string?>.Of("<float>"), Optional<string?>.Of("<float>"), Optional<string?>.Of("<float>"), Optional<string?>.Of("INITIALS"), Optional<string?>.Of("<string>"), Optional<string?>.Of("<boolean>"), Optional<AddEnvelopeAnnotationRequestSignature?>.Of(signature), Optional<AddEnvelopeAnnotationRequestInitials?>.Of(initials), Optional<AddEnvelopeAnnotationRequestText?>.Of(text), Optional<AddEnvelopeAnnotationRequestDatetime?>.Of(datetime), Optional<AddEnvelopeAnnotationRequestCheckbox?>.Of(checkbox));

var response = await client.Annotation.AddEnvelopeAnnotationAsync(input, "envelope_id", "application/json");

Console.WriteLine(response);
```
