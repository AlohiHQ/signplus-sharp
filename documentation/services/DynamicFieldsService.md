# DynamicFieldsService

A list of all methods in the `DynamicFieldsService` service. Click on the method name to view detailed information about that method.

| Methods                                                         | Description                 |
| :-------------------------------------------------------------- | :-------------------------- |
| [SetEnvelopeDynamicFieldsAsync](#setenvelopedynamicfieldsasync) | Set envelope dynamic fields |

## SetEnvelopeDynamicFieldsAsync

Set envelope dynamic fields

- HTTP Method: `PUT`
- Endpoint: `/envelope/{envelope_id}/dynamic_fields`

**Parameters**

| Name       | Type                            | Required | Description       |
| :--------- | :------------------------------ | :------- | :---------------- |
| input      | SetEnvelopeDynamicFieldsRequest | ✅       | The request body. |
| envelopeId | string                          | ✅       |                   |
| accept     | string                          | ✅       |                   |

**Return Type**

`object`

**Example Usage Code Snippet**

```csharp
using Alohi.Signplus;
using Alohi.Signplus.Config;
using Alohi.Signplus.Models;

var config = new SignplusConfig{};

var client = new SignplusClient(config);

var dynamicFieldsItem = new DynamicFields(Optional<string?>.Of("<string>"), Optional<string?>.Of("<string>"));
var dynamicFields = new List<DynamicFields>() { dynamicFieldsItem };
var input = new SetEnvelopeDynamicFieldsRequest(Optional<List<DynamicFields>?>.Of(dynamicFields));

var response = await client.DynamicFields.SetEnvelopeDynamicFieldsAsync(input, "envelope_id", "application/json");

Console.WriteLine(response);
```
