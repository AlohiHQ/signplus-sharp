# SigningStepsService

A list of all methods in the `SigningStepsService` service. Click on the method name to view detailed information about that method.

| Methods                                                       | Description                |
| :------------------------------------------------------------ | :------------------------- |
| [AddEnvelopeSigningStepsAsync](#addenvelopesigningstepsasync) | Add envelope signing steps |

## AddEnvelopeSigningStepsAsync

Add envelope signing steps

- HTTP Method: `POST`
- Endpoint: `/envelope/{envelope_id}/signing_steps`

**Parameters**

| Name       | Type                           | Required | Description       |
| :--------- | :----------------------------- | :------- | :---------------- |
| input      | AddEnvelopeSigningStepsRequest | ✅       | The request body. |
| envelopeId | string                         | ✅       |                   |
| accept     | string                         | ✅       |                   |

**Return Type**

`object`

**Example Usage Code Snippet**

```csharp
using Alohi.Signplus;
using Alohi.Signplus.Config;
using Alohi.Signplus.Models;

var config = new SignplusConfig{};

var client = new SignplusClient(config);

var verification = new Verification(Optional<string?>.Of("SMS"), Optional<string?>.Of("string"));
var recipientsItem = new SigningStepsRecipients1(Optional<string?>.Of("string"), Optional<string?>.Of("string"), Optional<string?>.Of("IN_PERSON_SIGNER"), Optional<string?>.Of("string"), Optional<string?>.Of("string"), Optional<Verification?>.Of(verification));
var recipients = new List<SigningStepsRecipients1>() { recipientsItem };
var signingStepsItem = new AddEnvelopeSigningStepsRequestSigningSteps(Optional<List<SigningStepsRecipients1>?>.Of(recipients));
var signingSteps = new List<AddEnvelopeSigningStepsRequestSigningSteps>() { signingStepsItem };
var input = new AddEnvelopeSigningStepsRequest(Optional<List<AddEnvelopeSigningStepsRequestSigningSteps>?>.Of(signingSteps));

var response = await client.SigningSteps.AddEnvelopeSigningStepsAsync(input, "envelope_id", "application/json");

Console.WriteLine(response);
```
