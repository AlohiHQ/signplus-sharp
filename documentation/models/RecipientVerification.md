# RecipientVerification

**Properties**

| Name   | Type                      | Required | Description                                                                                                                                                                                                                                          |
| :----- | :------------------------ | :------- | :--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| Type\_ | RecipientVerificationType | ❌       | Type of verification the recipient must complete before accessing the envelope. - `PASSCODE`: requires a code to be entered. - `SMS`: sends a code via SMS. - `ID_VERIFICATION`: prompts the recipient to complete an automated ID and selfie check. |
| Value  | string                    | ❌       | Required for `PASSCODE` and `SMS` verification. - `PASSCODE`: code required by the recipient to sign the document. - `SMS`: recipient's phone number. - `ID_VERIFICATION`: leave empty.                                                              |
