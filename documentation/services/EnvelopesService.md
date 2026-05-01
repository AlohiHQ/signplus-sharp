# EnvelopesService

A list of all methods in the `EnvelopesService` service. Click on the method name to view detailed information about that method.

| Methods                                   | Description    |
| :---------------------------------------- | :------------- |
| [ListEnvelopesAsync](#listenvelopesasync) | List envelopes |

## ListEnvelopesAsync

List envelopes

- HTTP Method: `POST`
- Endpoint: `/envelopes`

**Parameters**

| Name   | Type                 | Required | Description       |
| :----- | :------------------- | :------- | :---------------- |
| input  | ListEnvelopesRequest | ✅       | The request body. |
| accept | string               | ✅       |                   |

**Return Type**

`object`

**Example Usage Code Snippet**

```csharp
using Alohi.Signplus;
using Alohi.Signplus.Config;
using Alohi.Signplus.Models;

var config = new SignplusConfig{};

var client = new SignplusClient(config);

var tags = new List<string>() { "string" };
var ids = new List<string>() { "string" };
var statuses = new List<string>() { "DRAFT" };
var folderIds = new List<string>() { "string" };
var input = new ListEnvelopesRequest(Optional<string?>.Of("string"), Optional<List<string>?>.Of(tags), Optional<string?>.Of("string"), Optional<List<string>?>.Of(ids), Optional<List<string>?>.Of(statuses), Optional<List<string>?>.Of(folderIds), Optional<bool?>.Of(false), Optional<double?>.Of(6508), Optional<double?>.Of(690), Optional<string?>.Of("string"), Optional<double?>.Of(6875), Optional<double?>.Of(4384), Optional<string?>.Of("string"), Optional<string?>.Of("string"), Optional<string?>.Of("LAST_DOCUMENT_CHANGE"), Optional<bool?>.Of(false), Optional<bool?>.Of(false));

var response = await client.Envelopes.ListEnvelopesAsync(input, "application/json");

Console.WriteLine(response);
```
