# Recipient

**Properties**

| Name         | Type                  | Required | Description                                                                                                                                                                |
| :----------- | :-------------------- | :------- | :------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| Name         | string                | ✅       | Name of the recipient                                                                                                                                                      |
| Email        | string                | ✅       | Email of the recipient                                                                                                                                                     |
| Role         | RecipientRole         | ✅       | Role of the recipient (SIGNER signs the document, RECEIVES_COPY receives a copy of the document, IN_PERSON_SIGNER signs the document in person, SENDER sends the document) |
| Id           | string                | ❌       | Unique identifier of the recipient                                                                                                                                         |
| Uid          | string                | ❌       | Unique identifier of the user associated with the recipient                                                                                                                |
| Verification | RecipientVerification | ❌       |                                                                                                                                                                            |
