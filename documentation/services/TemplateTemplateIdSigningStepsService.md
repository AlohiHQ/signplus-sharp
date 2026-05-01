# TemplateTemplateIdSigningStepsService

A list of all methods in the `TemplateTemplateIdSigningStepsService` service. Click on the method name to view detailed information about that method.

| Methods                                                       | Description                |
| :------------------------------------------------------------ | :------------------------- |
| [AddTemplateSigningStepsAsync](#addtemplatesigningstepsasync) | Add template signing steps |

## AddTemplateSigningStepsAsync

Add template signing steps

- HTTP Method: `POST`
- Endpoint: `/template/{template_id}/signing_steps`

**Parameters**

| Name       | Type                           | Required | Description       |
| :--------- | :----------------------------- | :------- | :---------------- |
| input      | AddTemplateSigningStepsRequest | ✅       | The request body. |
| templateId | string                         | ✅       |                   |
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

var recipientsItem = new SigningStepsRecipients2(Optional<string?>.Of("<string>"), Optional<string?>.Of("<string>"), Optional<string?>.Of("<string>"), Optional<string?>.Of("<string>"), Optional<string?>.Of("SIGNER"));
var recipients = new List<SigningStepsRecipients2>() { recipientsItem };
var signingStepsItem = new AddTemplateSigningStepsRequestSigningSteps(Optional<List<SigningStepsRecipients2>?>.Of(recipients));
var signingSteps = new List<AddTemplateSigningStepsRequestSigningSteps>() { signingStepsItem };
var input = new AddTemplateSigningStepsRequest(Optional<List<AddTemplateSigningStepsRequestSigningSteps>?>.Of(signingSteps));

var response = await client.TemplateTemplateIdSigningSteps.AddTemplateSigningStepsAsync(input, "template_id", "application/json");

Console.WriteLine(response);
```
