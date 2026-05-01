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

var signature = new AddEnvelopeAnnotationRequestSignature(Optional<string?>.Of("string"));
var initials = new AddEnvelopeAnnotationRequestInitials(Optional<string?>.Of("string"));
var font = new TextFont1(Optional<string?>.Of("SANS"), Optional<bool?>.Of(false), Optional<bool?>.Of(false));
var text = new AddEnvelopeAnnotationRequestText(Optional<double?>.Of(6190.822136605691), Optional<double?>.Of(6489.781325519173), Optional<string?>.Of("string"), Optional<string?>.Of("string"), Optional<string?>.Of("string"), Optional<TextFont1?>.Of(font));
var datetime = new AddEnvelopeAnnotationRequestDatetime(Optional<double?>.Of(3773.1065479576364), Optional<DatetimeFont1?>.Of(font), Optional<string?>.Of("string"), Optional<bool?>.Of(true), Optional<string?>.Of("string"), Optional<double?>.Of(6868), Optional<string?>.Of("MDY_TEXT_SPACE_SHORT"));
var checkbox = new AddEnvelopeAnnotationRequestCheckbox(Optional<bool?>.Of(false), Optional<string?>.Of("SQUARE_CHECK"));
var input = new AddEnvelopeAnnotationRequest(Optional<string?>.Of("string"), Optional<double?>.Of(6387), Optional<double?>.Of(4410.13346533615), Optional<double?>.Of(5148.888749329143), Optional<double?>.Of(3756.0248729763225), Optional<double?>.Of(4178.76189579703), Optional<string?>.Of("INITIALS"), Optional<string?>.Of("string"), Optional<bool?>.Of(false), Optional<AddEnvelopeAnnotationRequestSignature?>.Of(signature), Optional<AddEnvelopeAnnotationRequestInitials?>.Of(initials), Optional<AddEnvelopeAnnotationRequestText?>.Of(text), Optional<AddEnvelopeAnnotationRequestDatetime?>.Of(datetime), Optional<AddEnvelopeAnnotationRequestCheckbox?>.Of(checkbox));

var response = await client.Annotation.AddEnvelopeAnnotationAsync(input, "envelope_id", "application/json");

Console.WriteLine(response);
```
