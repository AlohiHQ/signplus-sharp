# SetLegalityLevelService

A list of all methods in the `SetLegalityLevelService` service. Click on the method name to view detailed information about that method.

| Methods                                                         | Description                 |
| :-------------------------------------------------------------- | :-------------------------- |
| [SetEnvelopeLegalityLevelAsync](#setenvelopelegalitylevelasync) | Set envelope legality level |

## SetEnvelopeLegalityLevelAsync

Set envelope legality level

- HTTP Method: `PUT`
- Endpoint: `/envelope/{envelope_id}/set_legality_level`

**Parameters**

| Name       | Type                            | Required | Description       |
| :--------- | :------------------------------ | :------- | :---------------- |
| input      | SetEnvelopeLegalityLevelRequest | ✅       | The request body. |
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

var input = new SetEnvelopeLegalityLevelRequest(Optional<string?>.Of("QES_EIDAS"));

var response = await client.SetLegalityLevel.SetEnvelopeLegalityLevelAsync(input, "envelope_id", "application/json");

Console.WriteLine(response);
```
