# AnnotationIdService

A list of all methods in the `AnnotationIdService` service. Click on the method name to view detailed information about that method.

| Methods                                                         | Description                |
| :-------------------------------------------------------------- | :------------------------- |
| [DeleteEnvelopeAnnotationAsync](#deleteenvelopeannotationasync) | Delete envelope annotation |

## DeleteEnvelopeAnnotationAsync

Delete envelope annotation

- HTTP Method: `DELETE`
- Endpoint: `/envelope/{envelope_id}/annotation/{annotation_id}`

**Parameters**

| Name         | Type   | Required | Description |
| :----------- | :----- | :------- | :---------- |
| envelopeId   | string | ✅       |             |
| annotationId | string | ✅       |             |

**Return Type**

`object`

**Example Usage Code Snippet**

```csharp
using Alohi.Signplus;
using Alohi.Signplus.Config;

var config = new SignplusConfig{};

var client = new SignplusClient(config);

var response = await client.AnnotationId.DeleteEnvelopeAnnotationAsync("envelope_id", "annotation_id");

Console.WriteLine(response);
```
