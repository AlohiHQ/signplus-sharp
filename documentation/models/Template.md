# Template

**Properties**

| Name            | Type                      | Required | Description                                                                                                                                                             |
| :-------------- | :------------------------ | :------- | :---------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| Id              | string                    | ❌       | Unique identifier of the template                                                                                                                                       |
| Name            | string                    | ❌       | Name of the template                                                                                                                                                    |
| Comment         | string                    | ❌       | Comment for the template                                                                                                                                                |
| Pages           | long                      | ❌       | Total number of pages in the template                                                                                                                                   |
| LegalityLevel   | EnvelopeLegalityLevel     | ❌       | Legal level of the envelope (SES is Simple Electronic Signature, QES_EIDAS is Qualified Electronic Signature, QES_ZERTES is Qualified Electronic Signature with Zertes) |
| CreatedAt       | long                      | ❌       | Unix timestamp of the creation date                                                                                                                                     |
| UpdatedAt       | long                      | ❌       | Unix timestamp of the last modification date                                                                                                                            |
| ExpirationDelay | long                      | ❌       | Expiration delay added to the current time when an envelope is created from this template                                                                               |
| NumRecipients   | long                      | ❌       | Number of recipients in the envelope                                                                                                                                    |
| SigningSteps    | List<TemplateSigningStep> | ❌       |                                                                                                                                                                         |
| Documents       | List<Document>            | ❌       |                                                                                                                                                                         |
| Notification    | EnvelopeNotification      | ❌       |                                                                                                                                                                         |
| DynamicFields   | List<string>              | ❌       | List of dynamic fields                                                                                                                                                  |
