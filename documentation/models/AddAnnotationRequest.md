# AddAnnotationRequest

**Properties**

| Name        | Type                | Required | Description                                                                                     |
| :---------- | :------------------ | :------- | :---------------------------------------------------------------------------------------------- |
| DocumentId  | string              | ✅       | ID of the document                                                                              |
| Page        | long                | ✅       | Page number where the annotation is placed                                                      |
| X           | double              | ✅       | X coordinate of the annotation (in % of the page width from 0 to 100) from the top left corner  |
| Y           | double              | ✅       | Y coordinate of the annotation (in % of the page height from 0 to 100) from the top left corner |
| Width       | double              | ✅       | Width of the annotation (in % of the page width from 0 to 100)                                  |
| Height      | double              | ✅       | Height of the annotation (in % of the page height from 0 to 100)                                |
| Type\_      | AnnotationType      | ✅       | Type of the annotation                                                                          |
| RecipientId | string              | ❌       | ID of the recipient                                                                             |
| Required    | bool                | ❌       |                                                                                                 |
| Signature   | AnnotationSignature | ❌       | Signature annotation (null if annotation is not a signature)                                    |
| Initials    | AnnotationInitials  | ❌       | Initials annotation (null if annotation is not initials)                                        |
| Text        | AnnotationText      | ❌       | Text annotation (null if annotation is not a text)                                              |
| Datetime    | AnnotationDateTime  | ❌       | Date annotation (null if annotation is not a date)                                              |
| Checkbox    | AnnotationCheckbox  | ❌       | Checkbox annotation (null if annotation is not a checkbox)                                      |
