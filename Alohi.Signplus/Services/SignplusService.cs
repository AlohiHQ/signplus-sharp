using System.Net.Http.Headers;
using System.Net.Http.Json;
using Alohi.Signplus.Config;
using Alohi.Signplus.Http;
using Alohi.Signplus.Http.Exceptions;
using Alohi.Signplus.Http.Extensions;
using Alohi.Signplus.Http.Handlers;
using Alohi.Signplus.Http.Serialization;
using Alohi.Signplus.Models;
using Alohi.Signplus.Validation;
using Alohi.Signplus.Validation.Extensions;

namespace Alohi.Signplus.Services;

/// <summary>
/// Service class providing access to API endpoints for SignplusService.
/// Inherits HTTP client management, JSON serialization, and streaming capabilities from the base service.
/// Each method corresponds to an API operation and handles request building, execution, and response parsing.
/// </summary>
public class SignplusService : BaseService
{
    private RequestConfig? _createEnvelopeAsyncConfig;
    private RequestConfig? _createEnvelopeFromTemplateAsyncConfig;
    private RequestConfig? _listEnvelopesAsyncConfig;
    private RequestConfig? _getEnvelopeAsyncConfig;
    private RequestConfig? _deleteEnvelopeAsyncConfig;
    private RequestConfig? _downloadEnvelopeSignedDocumentsAsyncConfig;
    private RequestConfig? _downloadEnvelopeCertificateAsyncConfig;
    private RequestConfig? _getEnvelopeDocumentAsyncConfig;
    private RequestConfig? _getEnvelopeDocumentsAsyncConfig;
    private RequestConfig? _addEnvelopeDocumentAsyncConfig;
    private RequestConfig? _setEnvelopeDynamicFieldsAsyncConfig;
    private RequestConfig? _addEnvelopeSigningStepsAsyncConfig;
    private RequestConfig? _setEnvelopeAttachmentsSettingsAsyncConfig;
    private RequestConfig? _setEnvelopeAttachmentsPlaceholdersAsyncConfig;
    private RequestConfig? _getAttachmentFileAsyncConfig;
    private RequestConfig? _sendEnvelopeAsyncConfig;
    private RequestConfig? _duplicateEnvelopeAsyncConfig;
    private RequestConfig? _voidEnvelopeAsyncConfig;
    private RequestConfig? _renameEnvelopeAsyncConfig;
    private RequestConfig? _setEnvelopeCommentAsyncConfig;
    private RequestConfig? _setEnvelopeNotificationAsyncConfig;
    private RequestConfig? _setEnvelopeExpirationDateAsyncConfig;
    private RequestConfig? _setEnvelopeLegalityLevelAsyncConfig;
    private RequestConfig? _getEnvelopeAnnotationsAsyncConfig;
    private RequestConfig? _getEnvelopeDocumentAnnotationsAsyncConfig;
    private RequestConfig? _addEnvelopeAnnotationAsyncConfig;
    private RequestConfig? _deleteEnvelopeAnnotationAsyncConfig;
    private RequestConfig? _createTemplateAsyncConfig;
    private RequestConfig? _listTemplatesAsyncConfig;
    private RequestConfig? _getTemplateAsyncConfig;
    private RequestConfig? _deleteTemplateAsyncConfig;
    private RequestConfig? _duplicateTemplateAsyncConfig;
    private RequestConfig? _addTemplateDocumentAsyncConfig;
    private RequestConfig? _getTemplateDocumentAsyncConfig;
    private RequestConfig? _getTemplateDocumentsAsyncConfig;
    private RequestConfig? _addTemplateSigningStepsAsyncConfig;
    private RequestConfig? _renameTemplateAsyncConfig;
    private RequestConfig? _setTemplateCommentAsyncConfig;
    private RequestConfig? _setTemplateNotificationAsyncConfig;
    private RequestConfig? _getTemplateAnnotationsAsyncConfig;
    private RequestConfig? _getDocumentTemplateAnnotationsAsyncConfig;
    private RequestConfig? _addTemplateAnnotationAsyncConfig;
    private RequestConfig? _deleteTemplateAnnotationAsyncConfig;
    private RequestConfig? _setTemplateAttachmentsSettingsAsyncConfig;
    private RequestConfig? _setTemplateAttachmentsPlaceholdersAsyncConfig;
    private RequestConfig? _createWebhookAsyncConfig;
    private RequestConfig? _listWebhooksAsyncConfig;
    private RequestConfig? _deleteWebhookAsyncConfig;

    internal SignplusService(global::Alohi.Signplus.Http.Client httpClient)
        : base(httpClient) { }

    /// <summary>
    /// Sets method-level configuration for <c>CreateEnvelopeAsync</c>.
    /// Method-level config overrides service-level config but is overridden by per-request config.
    /// </summary>
    public SignplusService SetCreateEnvelopeAsyncConfig(RequestConfig config)
    {
        _createEnvelopeAsyncConfig = config;
        return this;
    }

    /// <summary>
    /// Sets method-level configuration for <c>CreateEnvelopeFromTemplateAsync</c>.
    /// Method-level config overrides service-level config but is overridden by per-request config.
    /// </summary>
    public SignplusService SetCreateEnvelopeFromTemplateAsyncConfig(RequestConfig config)
    {
        _createEnvelopeFromTemplateAsyncConfig = config;
        return this;
    }

    /// <summary>
    /// Sets method-level configuration for <c>ListEnvelopesAsync</c>.
    /// Method-level config overrides service-level config but is overridden by per-request config.
    /// </summary>
    public SignplusService SetListEnvelopesAsyncConfig(RequestConfig config)
    {
        _listEnvelopesAsyncConfig = config;
        return this;
    }

    /// <summary>
    /// Sets method-level configuration for <c>GetEnvelopeAsync</c>.
    /// Method-level config overrides service-level config but is overridden by per-request config.
    /// </summary>
    public SignplusService SetGetEnvelopeAsyncConfig(RequestConfig config)
    {
        _getEnvelopeAsyncConfig = config;
        return this;
    }

    /// <summary>
    /// Sets method-level configuration for <c>DeleteEnvelopeAsync</c>.
    /// Method-level config overrides service-level config but is overridden by per-request config.
    /// </summary>
    public SignplusService SetDeleteEnvelopeAsyncConfig(RequestConfig config)
    {
        _deleteEnvelopeAsyncConfig = config;
        return this;
    }

    /// <summary>
    /// Sets method-level configuration for <c>DownloadEnvelopeSignedDocumentsAsync</c>.
    /// Method-level config overrides service-level config but is overridden by per-request config.
    /// </summary>
    public SignplusService SetDownloadEnvelopeSignedDocumentsAsyncConfig(RequestConfig config)
    {
        _downloadEnvelopeSignedDocumentsAsyncConfig = config;
        return this;
    }

    /// <summary>
    /// Sets method-level configuration for <c>DownloadEnvelopeCertificateAsync</c>.
    /// Method-level config overrides service-level config but is overridden by per-request config.
    /// </summary>
    public SignplusService SetDownloadEnvelopeCertificateAsyncConfig(RequestConfig config)
    {
        _downloadEnvelopeCertificateAsyncConfig = config;
        return this;
    }

    /// <summary>
    /// Sets method-level configuration for <c>GetEnvelopeDocumentAsync</c>.
    /// Method-level config overrides service-level config but is overridden by per-request config.
    /// </summary>
    public SignplusService SetGetEnvelopeDocumentAsyncConfig(RequestConfig config)
    {
        _getEnvelopeDocumentAsyncConfig = config;
        return this;
    }

    /// <summary>
    /// Sets method-level configuration for <c>GetEnvelopeDocumentsAsync</c>.
    /// Method-level config overrides service-level config but is overridden by per-request config.
    /// </summary>
    public SignplusService SetGetEnvelopeDocumentsAsyncConfig(RequestConfig config)
    {
        _getEnvelopeDocumentsAsyncConfig = config;
        return this;
    }

    /// <summary>
    /// Sets method-level configuration for <c>AddEnvelopeDocumentAsync</c>.
    /// Method-level config overrides service-level config but is overridden by per-request config.
    /// </summary>
    public SignplusService SetAddEnvelopeDocumentAsyncConfig(RequestConfig config)
    {
        _addEnvelopeDocumentAsyncConfig = config;
        return this;
    }

    /// <summary>
    /// Sets method-level configuration for <c>SetEnvelopeDynamicFieldsAsync</c>.
    /// Method-level config overrides service-level config but is overridden by per-request config.
    /// </summary>
    public SignplusService SetSetEnvelopeDynamicFieldsAsyncConfig(RequestConfig config)
    {
        _setEnvelopeDynamicFieldsAsyncConfig = config;
        return this;
    }

    /// <summary>
    /// Sets method-level configuration for <c>AddEnvelopeSigningStepsAsync</c>.
    /// Method-level config overrides service-level config but is overridden by per-request config.
    /// </summary>
    public SignplusService SetAddEnvelopeSigningStepsAsyncConfig(RequestConfig config)
    {
        _addEnvelopeSigningStepsAsyncConfig = config;
        return this;
    }

    /// <summary>
    /// Sets method-level configuration for <c>SetEnvelopeAttachmentsSettingsAsync</c>.
    /// Method-level config overrides service-level config but is overridden by per-request config.
    /// </summary>
    public SignplusService SetSetEnvelopeAttachmentsSettingsAsyncConfig(RequestConfig config)
    {
        _setEnvelopeAttachmentsSettingsAsyncConfig = config;
        return this;
    }

    /// <summary>
    /// Sets method-level configuration for <c>SetEnvelopeAttachmentsPlaceholdersAsync</c>.
    /// Method-level config overrides service-level config but is overridden by per-request config.
    /// </summary>
    public SignplusService SetSetEnvelopeAttachmentsPlaceholdersAsyncConfig(RequestConfig config)
    {
        _setEnvelopeAttachmentsPlaceholdersAsyncConfig = config;
        return this;
    }

    /// <summary>
    /// Sets method-level configuration for <c>GetAttachmentFileAsync</c>.
    /// Method-level config overrides service-level config but is overridden by per-request config.
    /// </summary>
    public SignplusService SetGetAttachmentFileAsyncConfig(RequestConfig config)
    {
        _getAttachmentFileAsyncConfig = config;
        return this;
    }

    /// <summary>
    /// Sets method-level configuration for <c>SendEnvelopeAsync</c>.
    /// Method-level config overrides service-level config but is overridden by per-request config.
    /// </summary>
    public SignplusService SetSendEnvelopeAsyncConfig(RequestConfig config)
    {
        _sendEnvelopeAsyncConfig = config;
        return this;
    }

    /// <summary>
    /// Sets method-level configuration for <c>DuplicateEnvelopeAsync</c>.
    /// Method-level config overrides service-level config but is overridden by per-request config.
    /// </summary>
    public SignplusService SetDuplicateEnvelopeAsyncConfig(RequestConfig config)
    {
        _duplicateEnvelopeAsyncConfig = config;
        return this;
    }

    /// <summary>
    /// Sets method-level configuration for <c>VoidEnvelopeAsync</c>.
    /// Method-level config overrides service-level config but is overridden by per-request config.
    /// </summary>
    public SignplusService SetVoidEnvelopeAsyncConfig(RequestConfig config)
    {
        _voidEnvelopeAsyncConfig = config;
        return this;
    }

    /// <summary>
    /// Sets method-level configuration for <c>RenameEnvelopeAsync</c>.
    /// Method-level config overrides service-level config but is overridden by per-request config.
    /// </summary>
    public SignplusService SetRenameEnvelopeAsyncConfig(RequestConfig config)
    {
        _renameEnvelopeAsyncConfig = config;
        return this;
    }

    /// <summary>
    /// Sets method-level configuration for <c>SetEnvelopeCommentAsync</c>.
    /// Method-level config overrides service-level config but is overridden by per-request config.
    /// </summary>
    public SignplusService SetSetEnvelopeCommentAsyncConfig(RequestConfig config)
    {
        _setEnvelopeCommentAsyncConfig = config;
        return this;
    }

    /// <summary>
    /// Sets method-level configuration for <c>SetEnvelopeNotificationAsync</c>.
    /// Method-level config overrides service-level config but is overridden by per-request config.
    /// </summary>
    public SignplusService SetSetEnvelopeNotificationAsyncConfig(RequestConfig config)
    {
        _setEnvelopeNotificationAsyncConfig = config;
        return this;
    }

    /// <summary>
    /// Sets method-level configuration for <c>SetEnvelopeExpirationDateAsync</c>.
    /// Method-level config overrides service-level config but is overridden by per-request config.
    /// </summary>
    public SignplusService SetSetEnvelopeExpirationDateAsyncConfig(RequestConfig config)
    {
        _setEnvelopeExpirationDateAsyncConfig = config;
        return this;
    }

    /// <summary>
    /// Sets method-level configuration for <c>SetEnvelopeLegalityLevelAsync</c>.
    /// Method-level config overrides service-level config but is overridden by per-request config.
    /// </summary>
    public SignplusService SetSetEnvelopeLegalityLevelAsyncConfig(RequestConfig config)
    {
        _setEnvelopeLegalityLevelAsyncConfig = config;
        return this;
    }

    /// <summary>
    /// Sets method-level configuration for <c>GetEnvelopeAnnotationsAsync</c>.
    /// Method-level config overrides service-level config but is overridden by per-request config.
    /// </summary>
    public SignplusService SetGetEnvelopeAnnotationsAsyncConfig(RequestConfig config)
    {
        _getEnvelopeAnnotationsAsyncConfig = config;
        return this;
    }

    /// <summary>
    /// Sets method-level configuration for <c>GetEnvelopeDocumentAnnotationsAsync</c>.
    /// Method-level config overrides service-level config but is overridden by per-request config.
    /// </summary>
    public SignplusService SetGetEnvelopeDocumentAnnotationsAsyncConfig(RequestConfig config)
    {
        _getEnvelopeDocumentAnnotationsAsyncConfig = config;
        return this;
    }

    /// <summary>
    /// Sets method-level configuration for <c>AddEnvelopeAnnotationAsync</c>.
    /// Method-level config overrides service-level config but is overridden by per-request config.
    /// </summary>
    public SignplusService SetAddEnvelopeAnnotationAsyncConfig(RequestConfig config)
    {
        _addEnvelopeAnnotationAsyncConfig = config;
        return this;
    }

    /// <summary>
    /// Sets method-level configuration for <c>DeleteEnvelopeAnnotationAsync</c>.
    /// Method-level config overrides service-level config but is overridden by per-request config.
    /// </summary>
    public SignplusService SetDeleteEnvelopeAnnotationAsyncConfig(RequestConfig config)
    {
        _deleteEnvelopeAnnotationAsyncConfig = config;
        return this;
    }

    /// <summary>
    /// Sets method-level configuration for <c>CreateTemplateAsync</c>.
    /// Method-level config overrides service-level config but is overridden by per-request config.
    /// </summary>
    public SignplusService SetCreateTemplateAsyncConfig(RequestConfig config)
    {
        _createTemplateAsyncConfig = config;
        return this;
    }

    /// <summary>
    /// Sets method-level configuration for <c>ListTemplatesAsync</c>.
    /// Method-level config overrides service-level config but is overridden by per-request config.
    /// </summary>
    public SignplusService SetListTemplatesAsyncConfig(RequestConfig config)
    {
        _listTemplatesAsyncConfig = config;
        return this;
    }

    /// <summary>
    /// Sets method-level configuration for <c>GetTemplateAsync</c>.
    /// Method-level config overrides service-level config but is overridden by per-request config.
    /// </summary>
    public SignplusService SetGetTemplateAsyncConfig(RequestConfig config)
    {
        _getTemplateAsyncConfig = config;
        return this;
    }

    /// <summary>
    /// Sets method-level configuration for <c>DeleteTemplateAsync</c>.
    /// Method-level config overrides service-level config but is overridden by per-request config.
    /// </summary>
    public SignplusService SetDeleteTemplateAsyncConfig(RequestConfig config)
    {
        _deleteTemplateAsyncConfig = config;
        return this;
    }

    /// <summary>
    /// Sets method-level configuration for <c>DuplicateTemplateAsync</c>.
    /// Method-level config overrides service-level config but is overridden by per-request config.
    /// </summary>
    public SignplusService SetDuplicateTemplateAsyncConfig(RequestConfig config)
    {
        _duplicateTemplateAsyncConfig = config;
        return this;
    }

    /// <summary>
    /// Sets method-level configuration for <c>AddTemplateDocumentAsync</c>.
    /// Method-level config overrides service-level config but is overridden by per-request config.
    /// </summary>
    public SignplusService SetAddTemplateDocumentAsyncConfig(RequestConfig config)
    {
        _addTemplateDocumentAsyncConfig = config;
        return this;
    }

    /// <summary>
    /// Sets method-level configuration for <c>GetTemplateDocumentAsync</c>.
    /// Method-level config overrides service-level config but is overridden by per-request config.
    /// </summary>
    public SignplusService SetGetTemplateDocumentAsyncConfig(RequestConfig config)
    {
        _getTemplateDocumentAsyncConfig = config;
        return this;
    }

    /// <summary>
    /// Sets method-level configuration for <c>GetTemplateDocumentsAsync</c>.
    /// Method-level config overrides service-level config but is overridden by per-request config.
    /// </summary>
    public SignplusService SetGetTemplateDocumentsAsyncConfig(RequestConfig config)
    {
        _getTemplateDocumentsAsyncConfig = config;
        return this;
    }

    /// <summary>
    /// Sets method-level configuration for <c>AddTemplateSigningStepsAsync</c>.
    /// Method-level config overrides service-level config but is overridden by per-request config.
    /// </summary>
    public SignplusService SetAddTemplateSigningStepsAsyncConfig(RequestConfig config)
    {
        _addTemplateSigningStepsAsyncConfig = config;
        return this;
    }

    /// <summary>
    /// Sets method-level configuration for <c>RenameTemplateAsync</c>.
    /// Method-level config overrides service-level config but is overridden by per-request config.
    /// </summary>
    public SignplusService SetRenameTemplateAsyncConfig(RequestConfig config)
    {
        _renameTemplateAsyncConfig = config;
        return this;
    }

    /// <summary>
    /// Sets method-level configuration for <c>SetTemplateCommentAsync</c>.
    /// Method-level config overrides service-level config but is overridden by per-request config.
    /// </summary>
    public SignplusService SetSetTemplateCommentAsyncConfig(RequestConfig config)
    {
        _setTemplateCommentAsyncConfig = config;
        return this;
    }

    /// <summary>
    /// Sets method-level configuration for <c>SetTemplateNotificationAsync</c>.
    /// Method-level config overrides service-level config but is overridden by per-request config.
    /// </summary>
    public SignplusService SetSetTemplateNotificationAsyncConfig(RequestConfig config)
    {
        _setTemplateNotificationAsyncConfig = config;
        return this;
    }

    /// <summary>
    /// Sets method-level configuration for <c>GetTemplateAnnotationsAsync</c>.
    /// Method-level config overrides service-level config but is overridden by per-request config.
    /// </summary>
    public SignplusService SetGetTemplateAnnotationsAsyncConfig(RequestConfig config)
    {
        _getTemplateAnnotationsAsyncConfig = config;
        return this;
    }

    /// <summary>
    /// Sets method-level configuration for <c>GetDocumentTemplateAnnotationsAsync</c>.
    /// Method-level config overrides service-level config but is overridden by per-request config.
    /// </summary>
    public SignplusService SetGetDocumentTemplateAnnotationsAsyncConfig(RequestConfig config)
    {
        _getDocumentTemplateAnnotationsAsyncConfig = config;
        return this;
    }

    /// <summary>
    /// Sets method-level configuration for <c>AddTemplateAnnotationAsync</c>.
    /// Method-level config overrides service-level config but is overridden by per-request config.
    /// </summary>
    public SignplusService SetAddTemplateAnnotationAsyncConfig(RequestConfig config)
    {
        _addTemplateAnnotationAsyncConfig = config;
        return this;
    }

    /// <summary>
    /// Sets method-level configuration for <c>DeleteTemplateAnnotationAsync</c>.
    /// Method-level config overrides service-level config but is overridden by per-request config.
    /// </summary>
    public SignplusService SetDeleteTemplateAnnotationAsyncConfig(RequestConfig config)
    {
        _deleteTemplateAnnotationAsyncConfig = config;
        return this;
    }

    /// <summary>
    /// Sets method-level configuration for <c>SetTemplateAttachmentsSettingsAsync</c>.
    /// Method-level config overrides service-level config but is overridden by per-request config.
    /// </summary>
    public SignplusService SetSetTemplateAttachmentsSettingsAsyncConfig(RequestConfig config)
    {
        _setTemplateAttachmentsSettingsAsyncConfig = config;
        return this;
    }

    /// <summary>
    /// Sets method-level configuration for <c>SetTemplateAttachmentsPlaceholdersAsync</c>.
    /// Method-level config overrides service-level config but is overridden by per-request config.
    /// </summary>
    public SignplusService SetSetTemplateAttachmentsPlaceholdersAsyncConfig(RequestConfig config)
    {
        _setTemplateAttachmentsPlaceholdersAsyncConfig = config;
        return this;
    }

    /// <summary>
    /// Sets method-level configuration for <c>CreateWebhookAsync</c>.
    /// Method-level config overrides service-level config but is overridden by per-request config.
    /// </summary>
    public SignplusService SetCreateWebhookAsyncConfig(RequestConfig config)
    {
        _createWebhookAsyncConfig = config;
        return this;
    }

    /// <summary>
    /// Sets method-level configuration for <c>ListWebhooksAsync</c>.
    /// Method-level config overrides service-level config but is overridden by per-request config.
    /// </summary>
    public SignplusService SetListWebhooksAsyncConfig(RequestConfig config)
    {
        _listWebhooksAsyncConfig = config;
        return this;
    }

    /// <summary>
    /// Sets method-level configuration for <c>DeleteWebhookAsync</c>.
    /// Method-level config overrides service-level config but is overridden by per-request config.
    /// </summary>
    public SignplusService SetDeleteWebhookAsyncConfig(RequestConfig config)
    {
        _deleteWebhookAsyncConfig = config;
        return this;
    }

    /// <summary>Create new envelope</summary>
    public async global::System.Threading.Tasks.Task<global::Alohi.Signplus.Models.Envelope> CreateEnvelopeAsync(
        global::Alohi.Signplus.Models.CreateEnvelopeRequest input,
        RequestConfig? requestConfig = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(input, nameof(input));
        var validationResults = new List<FluentValidation.Results.ValidationResult> { };
        var validator = new CreateEnvelopeRequestValidator();
        var validationResult = validator.Validate(input);
        validationResults.Add(validationResult);

        var combinedFailures = validationResults.SelectMany(result => result.Errors).ToList();
        if (combinedFailures.Any())
        {
            throw new Http.Exceptions.ValidationException(combinedFailures);
        }

        var resolvedConfig = GetResolvedConfig(_createEnvelopeAsyncConfig, requestConfig);

        var request = new RequestBuilder(HttpMethod.Post, "envelope")
            .SetContentAsJson(input, _jsonSerializerOptions)
            .Build();

        var response = await ExecuteAsync(request, resolvedConfig, cancellationToken)
            .ConfigureAwait(false);

        // Custom deserialization with required field validation for JSON responses
        var jsonContent = await response
            .Content.ReadAsStringAsync(cancellationToken)
            .ConfigureAwait(false);

        var result =
            DeserializationValidation.DeserializeWithRequiredFieldValidation<global::Alohi.Signplus.Models.Envelope>(
                jsonContent,
                _jsonSerializerOptions
            );

        // Validate the response
        var responseValidator = new EnvelopeValidator();
        var responseValidationResult = responseValidator.ValidateRequired(result);
        if (!responseValidationResult.IsValid)
        {
            throw new Http.Exceptions.ValidationException(responseValidationResult.Errors);
        }

        return result;
    }

    /// <summary>Create new envelope from template</summary>
    public async global::System.Threading.Tasks.Task<global::Alohi.Signplus.Models.Envelope> CreateEnvelopeFromTemplateAsync(
        global::Alohi.Signplus.Models.CreateEnvelopeFromTemplateRequest input,
        string templateId,
        RequestConfig? requestConfig = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(input, nameof(input));
        ArgumentNullException.ThrowIfNull(templateId, nameof(templateId));
        var validationResults = new List<FluentValidation.Results.ValidationResult> { };
        var templateIdValidationResult = new StringValidator().ValidateRequired<string>(templateId);
        if (templateIdValidationResult != null)
        {
            validationResults.Add(templateIdValidationResult);
        }
        ;
        var validator = new CreateEnvelopeFromTemplateRequestValidator();
        var validationResult = validator.Validate(input);
        validationResults.Add(validationResult);

        var combinedFailures = validationResults.SelectMany(result => result.Errors).ToList();
        if (combinedFailures.Any())
        {
            throw new Http.Exceptions.ValidationException(combinedFailures);
        }

        var resolvedConfig = GetResolvedConfig(
            _createEnvelopeFromTemplateAsyncConfig,
            requestConfig
        );

        var request = new RequestBuilder(HttpMethod.Post, "envelope/from_template/{template_id}")
            .SetPathParameter("template_id", templateId)
            .SetContentAsJson(input, _jsonSerializerOptions)
            .Build();

        var response = await ExecuteAsync(request, resolvedConfig, cancellationToken)
            .ConfigureAwait(false);

        // Custom deserialization with required field validation for JSON responses
        var jsonContent = await response
            .Content.ReadAsStringAsync(cancellationToken)
            .ConfigureAwait(false);

        var result =
            DeserializationValidation.DeserializeWithRequiredFieldValidation<global::Alohi.Signplus.Models.Envelope>(
                jsonContent,
                _jsonSerializerOptions
            );

        // Validate the response
        var responseValidator = new EnvelopeValidator();
        var responseValidationResult = responseValidator.ValidateRequired(result);
        if (!responseValidationResult.IsValid)
        {
            throw new Http.Exceptions.ValidationException(responseValidationResult.Errors);
        }

        return result;
    }

    /// <summary>List envelopes</summary>
    public async global::System.Threading.Tasks.Task<global::Alohi.Signplus.Models.ListEnvelopesResponse> ListEnvelopesAsync(
        global::Alohi.Signplus.Models.ListEnvelopesRequest input,
        RequestConfig? requestConfig = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(input, nameof(input));
        var validationResults = new List<FluentValidation.Results.ValidationResult> { };
        var validator = new ListEnvelopesRequestValidator();
        var validationResult = validator.Validate(input);
        validationResults.Add(validationResult);

        var combinedFailures = validationResults.SelectMany(result => result.Errors).ToList();
        if (combinedFailures.Any())
        {
            throw new Http.Exceptions.ValidationException(combinedFailures);
        }

        var resolvedConfig = GetResolvedConfig(_listEnvelopesAsyncConfig, requestConfig);

        var request = new RequestBuilder(HttpMethod.Post, "envelopes")
            .SetContentAsJson(input, _jsonSerializerOptions)
            .Build();

        var response = await ExecuteAsync(request, resolvedConfig, cancellationToken)
            .ConfigureAwait(false);

        // Custom deserialization with required field validation for JSON responses
        var jsonContent = await response
            .Content.ReadAsStringAsync(cancellationToken)
            .ConfigureAwait(false);

        var result =
            DeserializationValidation.DeserializeWithRequiredFieldValidation<global::Alohi.Signplus.Models.ListEnvelopesResponse>(
                jsonContent,
                _jsonSerializerOptions
            );

        // Validate the response
        var responseValidator = new ListEnvelopesResponseValidator();
        var responseValidationResult = responseValidator.ValidateRequired(result);
        if (!responseValidationResult.IsValid)
        {
            throw new Http.Exceptions.ValidationException(responseValidationResult.Errors);
        }

        return result;
    }

    /// <summary>Get envelope</summary>
    public async global::System.Threading.Tasks.Task<global::Alohi.Signplus.Models.Envelope> GetEnvelopeAsync(
        string envelopeId,
        RequestConfig? requestConfig = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(envelopeId, nameof(envelopeId));
        var validationResults = new List<FluentValidation.Results.ValidationResult> { };
        var envelopeIdValidationResult = new StringValidator().ValidateRequired<string>(envelopeId);
        if (envelopeIdValidationResult != null)
        {
            validationResults.Add(envelopeIdValidationResult);
        }

        var combinedFailures = validationResults.SelectMany(result => result.Errors).ToList();
        if (combinedFailures.Any())
        {
            throw new Http.Exceptions.ValidationException(combinedFailures);
        }

        var resolvedConfig = GetResolvedConfig(_getEnvelopeAsyncConfig, requestConfig);

        var request = new RequestBuilder(HttpMethod.Get, "envelope/{envelope_id}")
            .SetPathParameter("envelope_id", envelopeId)
            .Build();

        var response = await ExecuteAsync(request, resolvedConfig, cancellationToken)
            .ConfigureAwait(false);

        // Custom deserialization with required field validation for JSON responses
        var jsonContent = await response
            .Content.ReadAsStringAsync(cancellationToken)
            .ConfigureAwait(false);

        var result =
            DeserializationValidation.DeserializeWithRequiredFieldValidation<global::Alohi.Signplus.Models.Envelope>(
                jsonContent,
                _jsonSerializerOptions
            );

        // Validate the response
        var responseValidator = new EnvelopeValidator();
        var responseValidationResult = responseValidator.ValidateRequired(result);
        if (!responseValidationResult.IsValid)
        {
            throw new Http.Exceptions.ValidationException(responseValidationResult.Errors);
        }

        return result;
    }

    /// <summary>Delete envelope</summary>
    public async global::System.Threading.Tasks.Task DeleteEnvelopeAsync(
        string envelopeId,
        RequestConfig? requestConfig = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(envelopeId, nameof(envelopeId));
        var validationResults = new List<FluentValidation.Results.ValidationResult> { };
        var envelopeIdValidationResult = new StringValidator().ValidateRequired<string>(envelopeId);
        if (envelopeIdValidationResult != null)
        {
            validationResults.Add(envelopeIdValidationResult);
        }

        var combinedFailures = validationResults.SelectMany(result => result.Errors).ToList();
        if (combinedFailures.Any())
        {
            throw new Http.Exceptions.ValidationException(combinedFailures);
        }

        var resolvedConfig = GetResolvedConfig(_deleteEnvelopeAsyncConfig, requestConfig);

        var request = new RequestBuilder(HttpMethod.Delete, "envelope/{envelope_id}")
            .SetPathParameter("envelope_id", envelopeId)
            .Build();

        var response = await ExecuteAsync(request, resolvedConfig, cancellationToken)
            .ConfigureAwait(false);
    }

    /// <summary>Download signed documents for an envelope</summary>
    /// <param name="envelopeId">ID of the envelope</param>
    /// <param name="certificateOfCompletion">Whether to include the certificate of completion in the downloaded file</param>
    public async global::System.Threading.Tasks.Task<byte[]> DownloadEnvelopeSignedDocumentsAsync(
        string envelopeId,
        bool? certificateOfCompletion = true,
        RequestConfig? requestConfig = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(envelopeId, nameof(envelopeId));
        var validationResults = new List<FluentValidation.Results.ValidationResult> { };
        var envelopeIdValidationResult = new StringValidator().ValidateRequired<string>(envelopeId);
        if (envelopeIdValidationResult != null)
        {
            validationResults.Add(envelopeIdValidationResult);
        }

        var combinedFailures = validationResults.SelectMany(result => result.Errors).ToList();
        if (combinedFailures.Any())
        {
            throw new Http.Exceptions.ValidationException(combinedFailures);
        }

        var resolvedConfig = GetResolvedConfig(
            _downloadEnvelopeSignedDocumentsAsyncConfig,
            requestConfig
        );

        var request = new RequestBuilder(HttpMethod.Get, "envelope/{envelope_id}/signed_documents")
            .SetPathParameter("envelope_id", envelopeId)
            .SetOptionalQueryParameter("certificate_of_completion", certificateOfCompletion)
            .Build();

        var response = await ExecuteAsync(request, resolvedConfig, cancellationToken)
            .ConfigureAwait(false);

        // Standard deserialization
        var result = await response
            .Content.ReadAsByteArrayAsync(cancellationToken)
            .ConfigureAwait(false);

        // Validate the response
        // Skip validation for primitive types or OneOf types

        return result;
    }

    /// <summary>Download certificate of completion for an envelope</summary>
    /// <param name="envelopeId">ID of the envelope</param>
    public async global::System.Threading.Tasks.Task<byte[]> DownloadEnvelopeCertificateAsync(
        string envelopeId,
        RequestConfig? requestConfig = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(envelopeId, nameof(envelopeId));
        var validationResults = new List<FluentValidation.Results.ValidationResult> { };
        var envelopeIdValidationResult = new StringValidator().ValidateRequired<string>(envelopeId);
        if (envelopeIdValidationResult != null)
        {
            validationResults.Add(envelopeIdValidationResult);
        }

        var combinedFailures = validationResults.SelectMany(result => result.Errors).ToList();
        if (combinedFailures.Any())
        {
            throw new Http.Exceptions.ValidationException(combinedFailures);
        }

        var resolvedConfig = GetResolvedConfig(
            _downloadEnvelopeCertificateAsyncConfig,
            requestConfig
        );

        var request = new RequestBuilder(HttpMethod.Get, "envelope/{envelope_id}/certificate")
            .SetPathParameter("envelope_id", envelopeId)
            .Build();

        var response = await ExecuteAsync(request, resolvedConfig, cancellationToken)
            .ConfigureAwait(false);

        // Standard deserialization
        var result = await response
            .Content.ReadAsByteArrayAsync(cancellationToken)
            .ConfigureAwait(false);

        // Validate the response
        // Skip validation for primitive types or OneOf types

        return result;
    }

    /// <summary>Get envelope document</summary>
    public async global::System.Threading.Tasks.Task<global::Alohi.Signplus.Models.Document> GetEnvelopeDocumentAsync(
        string envelopeId,
        string documentId,
        RequestConfig? requestConfig = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(envelopeId, nameof(envelopeId));
        ArgumentNullException.ThrowIfNull(documentId, nameof(documentId));
        var validationResults = new List<FluentValidation.Results.ValidationResult> { };
        var envelopeIdValidationResult = new StringValidator().ValidateRequired<string>(envelopeId);
        if (envelopeIdValidationResult != null)
        {
            validationResults.Add(envelopeIdValidationResult);
        }
        ;
        var documentIdValidationResult = new StringValidator().ValidateRequired<string>(documentId);
        if (documentIdValidationResult != null)
        {
            validationResults.Add(documentIdValidationResult);
        }

        var combinedFailures = validationResults.SelectMany(result => result.Errors).ToList();
        if (combinedFailures.Any())
        {
            throw new Http.Exceptions.ValidationException(combinedFailures);
        }

        var resolvedConfig = GetResolvedConfig(_getEnvelopeDocumentAsyncConfig, requestConfig);

        var request = new RequestBuilder(
            HttpMethod.Get,
            "envelope/{envelope_id}/document/{document_id}"
        )
            .SetPathParameter("envelope_id", envelopeId)
            .SetPathParameter("document_id", documentId)
            .Build();

        var response = await ExecuteAsync(request, resolvedConfig, cancellationToken)
            .ConfigureAwait(false);

        // Custom deserialization with required field validation for JSON responses
        var jsonContent = await response
            .Content.ReadAsStringAsync(cancellationToken)
            .ConfigureAwait(false);

        var result =
            DeserializationValidation.DeserializeWithRequiredFieldValidation<global::Alohi.Signplus.Models.Document>(
                jsonContent,
                _jsonSerializerOptions
            );

        // Validate the response
        var responseValidator = new DocumentValidator();
        var responseValidationResult = responseValidator.ValidateRequired(result);
        if (!responseValidationResult.IsValid)
        {
            throw new Http.Exceptions.ValidationException(responseValidationResult.Errors);
        }

        return result;
    }

    /// <summary>Get envelope documents</summary>
    public async global::System.Threading.Tasks.Task<global::Alohi.Signplus.Models.ListEnvelopeDocumentsResponse> GetEnvelopeDocumentsAsync(
        string envelopeId,
        RequestConfig? requestConfig = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(envelopeId, nameof(envelopeId));
        var validationResults = new List<FluentValidation.Results.ValidationResult> { };
        var envelopeIdValidationResult = new StringValidator().ValidateRequired<string>(envelopeId);
        if (envelopeIdValidationResult != null)
        {
            validationResults.Add(envelopeIdValidationResult);
        }

        var combinedFailures = validationResults.SelectMany(result => result.Errors).ToList();
        if (combinedFailures.Any())
        {
            throw new Http.Exceptions.ValidationException(combinedFailures);
        }

        var resolvedConfig = GetResolvedConfig(_getEnvelopeDocumentsAsyncConfig, requestConfig);

        var request = new RequestBuilder(HttpMethod.Get, "envelope/{envelope_id}/documents")
            .SetPathParameter("envelope_id", envelopeId)
            .Build();

        var response = await ExecuteAsync(request, resolvedConfig, cancellationToken)
            .ConfigureAwait(false);

        // Custom deserialization with required field validation for JSON responses
        var jsonContent = await response
            .Content.ReadAsStringAsync(cancellationToken)
            .ConfigureAwait(false);

        var result =
            DeserializationValidation.DeserializeWithRequiredFieldValidation<global::Alohi.Signplus.Models.ListEnvelopeDocumentsResponse>(
                jsonContent,
                _jsonSerializerOptions
            );

        // Validate the response
        var responseValidator = new ListEnvelopeDocumentsResponseValidator();
        var responseValidationResult = responseValidator.ValidateRequired(result);
        if (!responseValidationResult.IsValid)
        {
            throw new Http.Exceptions.ValidationException(responseValidationResult.Errors);
        }

        return result;
    }

    /// <summary>Add envelope document</summary>
    public async global::System.Threading.Tasks.Task<global::Alohi.Signplus.Models.Document> AddEnvelopeDocumentAsync(
        global::Alohi.Signplus.Models.AddEnvelopeDocumentRequest input,
        string envelopeId,
        RequestConfig? requestConfig = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(input, nameof(input));
        ArgumentNullException.ThrowIfNull(envelopeId, nameof(envelopeId));
        var validationResults = new List<FluentValidation.Results.ValidationResult> { };
        var envelopeIdValidationResult = new StringValidator().ValidateRequired<string>(envelopeId);
        if (envelopeIdValidationResult != null)
        {
            validationResults.Add(envelopeIdValidationResult);
        }
        ;
        var validator = new AddEnvelopeDocumentRequestValidator();
        var validationResult = validator.Validate(input);
        validationResults.Add(validationResult);

        var combinedFailures = validationResults.SelectMany(result => result.Errors).ToList();
        if (combinedFailures.Any())
        {
            throw new Http.Exceptions.ValidationException(combinedFailures);
        }

        var resolvedConfig = GetResolvedConfig(_addEnvelopeDocumentAsyncConfig, requestConfig);

        var request = new RequestBuilder(HttpMethod.Post, "envelope/{envelope_id}/document")
            .SetPathParameter("envelope_id", envelopeId)
            .SetContentAsMultipartFormData(input, _jsonSerializerOptions)
            .Build();

        var response = await ExecuteAsync(request, resolvedConfig, cancellationToken)
            .ConfigureAwait(false);

        // Custom deserialization with required field validation for JSON responses
        var jsonContent = await response
            .Content.ReadAsStringAsync(cancellationToken)
            .ConfigureAwait(false);

        var result =
            DeserializationValidation.DeserializeWithRequiredFieldValidation<global::Alohi.Signplus.Models.Document>(
                jsonContent,
                _jsonSerializerOptions
            );

        // Validate the response
        var responseValidator = new DocumentValidator();
        var responseValidationResult = responseValidator.ValidateRequired(result);
        if (!responseValidationResult.IsValid)
        {
            throw new Http.Exceptions.ValidationException(responseValidationResult.Errors);
        }

        return result;
    }

    /// <summary>Set envelope dynamic fields</summary>
    public async global::System.Threading.Tasks.Task<global::Alohi.Signplus.Models.Envelope> SetEnvelopeDynamicFieldsAsync(
        global::Alohi.Signplus.Models.SetEnvelopeDynamicFieldsRequest input,
        string envelopeId,
        RequestConfig? requestConfig = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(input, nameof(input));
        ArgumentNullException.ThrowIfNull(envelopeId, nameof(envelopeId));
        var validationResults = new List<FluentValidation.Results.ValidationResult> { };
        var envelopeIdValidationResult = new StringValidator().ValidateRequired<string>(envelopeId);
        if (envelopeIdValidationResult != null)
        {
            validationResults.Add(envelopeIdValidationResult);
        }
        ;
        var validator = new SetEnvelopeDynamicFieldsRequestValidator();
        var validationResult = validator.Validate(input);
        validationResults.Add(validationResult);

        var combinedFailures = validationResults.SelectMany(result => result.Errors).ToList();
        if (combinedFailures.Any())
        {
            throw new Http.Exceptions.ValidationException(combinedFailures);
        }

        var resolvedConfig = GetResolvedConfig(_setEnvelopeDynamicFieldsAsyncConfig, requestConfig);

        var request = new RequestBuilder(HttpMethod.Put, "envelope/{envelope_id}/dynamic_fields")
            .SetPathParameter("envelope_id", envelopeId)
            .SetContentAsJson(input, _jsonSerializerOptions)
            .Build();

        var response = await ExecuteAsync(request, resolvedConfig, cancellationToken)
            .ConfigureAwait(false);

        // Custom deserialization with required field validation for JSON responses
        var jsonContent = await response
            .Content.ReadAsStringAsync(cancellationToken)
            .ConfigureAwait(false);

        var result =
            DeserializationValidation.DeserializeWithRequiredFieldValidation<global::Alohi.Signplus.Models.Envelope>(
                jsonContent,
                _jsonSerializerOptions
            );

        // Validate the response
        var responseValidator = new EnvelopeValidator();
        var responseValidationResult = responseValidator.ValidateRequired(result);
        if (!responseValidationResult.IsValid)
        {
            throw new Http.Exceptions.ValidationException(responseValidationResult.Errors);
        }

        return result;
    }

    /// <summary>Add envelope signing steps</summary>
    public async global::System.Threading.Tasks.Task<global::Alohi.Signplus.Models.Envelope> AddEnvelopeSigningStepsAsync(
        global::Alohi.Signplus.Models.AddEnvelopeSigningStepsRequest input,
        string envelopeId,
        RequestConfig? requestConfig = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(input, nameof(input));
        ArgumentNullException.ThrowIfNull(envelopeId, nameof(envelopeId));
        var validationResults = new List<FluentValidation.Results.ValidationResult> { };
        var envelopeIdValidationResult = new StringValidator().ValidateRequired<string>(envelopeId);
        if (envelopeIdValidationResult != null)
        {
            validationResults.Add(envelopeIdValidationResult);
        }
        ;
        var validator = new AddEnvelopeSigningStepsRequestValidator();
        var validationResult = validator.Validate(input);
        validationResults.Add(validationResult);

        var combinedFailures = validationResults.SelectMany(result => result.Errors).ToList();
        if (combinedFailures.Any())
        {
            throw new Http.Exceptions.ValidationException(combinedFailures);
        }

        var resolvedConfig = GetResolvedConfig(_addEnvelopeSigningStepsAsyncConfig, requestConfig);

        var request = new RequestBuilder(HttpMethod.Post, "envelope/{envelope_id}/signing_steps")
            .SetPathParameter("envelope_id", envelopeId)
            .SetContentAsJson(input, _jsonSerializerOptions)
            .Build();

        var response = await ExecuteAsync(request, resolvedConfig, cancellationToken)
            .ConfigureAwait(false);

        // Custom deserialization with required field validation for JSON responses
        var jsonContent = await response
            .Content.ReadAsStringAsync(cancellationToken)
            .ConfigureAwait(false);

        var result =
            DeserializationValidation.DeserializeWithRequiredFieldValidation<global::Alohi.Signplus.Models.Envelope>(
                jsonContent,
                _jsonSerializerOptions
            );

        // Validate the response
        var responseValidator = new EnvelopeValidator();
        var responseValidationResult = responseValidator.ValidateRequired(result);
        if (!responseValidationResult.IsValid)
        {
            throw new Http.Exceptions.ValidationException(responseValidationResult.Errors);
        }

        return result;
    }

    /// <summary>Set envelope attachment settings</summary>
    public async global::System.Threading.Tasks.Task<global::Alohi.Signplus.Models.EnvelopeAttachments> SetEnvelopeAttachmentsSettingsAsync(
        global::Alohi.Signplus.Models.SetEnvelopeAttachmentsSettingsRequest input,
        string envelopeId,
        RequestConfig? requestConfig = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(input, nameof(input));
        ArgumentNullException.ThrowIfNull(envelopeId, nameof(envelopeId));
        var validationResults = new List<FluentValidation.Results.ValidationResult> { };
        var envelopeIdValidationResult = new StringValidator().ValidateRequired<string>(envelopeId);
        if (envelopeIdValidationResult != null)
        {
            validationResults.Add(envelopeIdValidationResult);
        }
        ;
        var validator = new SetEnvelopeAttachmentsSettingsRequestValidator();
        var validationResult = validator.Validate(input);
        validationResults.Add(validationResult);

        var combinedFailures = validationResults.SelectMany(result => result.Errors).ToList();
        if (combinedFailures.Any())
        {
            throw new Http.Exceptions.ValidationException(combinedFailures);
        }

        var resolvedConfig = GetResolvedConfig(
            _setEnvelopeAttachmentsSettingsAsyncConfig,
            requestConfig
        );

        var request = new RequestBuilder(
            HttpMethod.Put,
            "envelope/{envelope_id}/attachments/settings"
        )
            .SetPathParameter("envelope_id", envelopeId)
            .SetContentAsJson(input, _jsonSerializerOptions)
            .Build();

        var response = await ExecuteAsync(request, resolvedConfig, cancellationToken)
            .ConfigureAwait(false);

        // Custom deserialization with required field validation for JSON responses
        var jsonContent = await response
            .Content.ReadAsStringAsync(cancellationToken)
            .ConfigureAwait(false);

        var result =
            DeserializationValidation.DeserializeWithRequiredFieldValidation<global::Alohi.Signplus.Models.EnvelopeAttachments>(
                jsonContent,
                _jsonSerializerOptions
            );

        // Validate the response
        var responseValidator = new EnvelopeAttachmentsValidator();
        var responseValidationResult = responseValidator.ValidateRequired(result);
        if (!responseValidationResult.IsValid)
        {
            throw new Http.Exceptions.ValidationException(responseValidationResult.Errors);
        }

        return result;
    }

    /// <summary>Placeholders to be set, completely replacing the existing ones.</summary>
    public async global::System.Threading.Tasks.Task<global::Alohi.Signplus.Models.EnvelopeAttachments> SetEnvelopeAttachmentsPlaceholdersAsync(
        global::Alohi.Signplus.Models.SetEnvelopeAttachmentsPlaceholdersRequest input,
        string envelopeId,
        RequestConfig? requestConfig = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(input, nameof(input));
        ArgumentNullException.ThrowIfNull(envelopeId, nameof(envelopeId));
        var validationResults = new List<FluentValidation.Results.ValidationResult> { };
        var envelopeIdValidationResult = new StringValidator().ValidateRequired<string>(envelopeId);
        if (envelopeIdValidationResult != null)
        {
            validationResults.Add(envelopeIdValidationResult);
        }
        ;
        var validator = new SetEnvelopeAttachmentsPlaceholdersRequestValidator();
        var validationResult = validator.Validate(input);
        validationResults.Add(validationResult);

        var combinedFailures = validationResults.SelectMany(result => result.Errors).ToList();
        if (combinedFailures.Any())
        {
            throw new Http.Exceptions.ValidationException(combinedFailures);
        }

        var resolvedConfig = GetResolvedConfig(
            _setEnvelopeAttachmentsPlaceholdersAsyncConfig,
            requestConfig
        );

        var request = new RequestBuilder(
            HttpMethod.Put,
            "envelope/{envelope_id}/attachments/placeholders"
        )
            .SetPathParameter("envelope_id", envelopeId)
            .SetContentAsJson(input, _jsonSerializerOptions)
            .Build();

        var response = await ExecuteAsync(request, resolvedConfig, cancellationToken)
            .ConfigureAwait(false);

        // Custom deserialization with required field validation for JSON responses
        var jsonContent = await response
            .Content.ReadAsStringAsync(cancellationToken)
            .ConfigureAwait(false);

        var result =
            DeserializationValidation.DeserializeWithRequiredFieldValidation<global::Alohi.Signplus.Models.EnvelopeAttachments>(
                jsonContent,
                _jsonSerializerOptions
            );

        // Validate the response
        var responseValidator = new EnvelopeAttachmentsValidator();
        var responseValidationResult = responseValidator.ValidateRequired(result);
        if (!responseValidationResult.IsValid)
        {
            throw new Http.Exceptions.ValidationException(responseValidationResult.Errors);
        }

        return result;
    }

    /// <summary>Get envelope attachment file</summary>
    public async global::System.Threading.Tasks.Task<byte[]> GetAttachmentFileAsync(
        string envelopeId,
        string fileId,
        RequestConfig? requestConfig = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(envelopeId, nameof(envelopeId));
        ArgumentNullException.ThrowIfNull(fileId, nameof(fileId));
        var validationResults = new List<FluentValidation.Results.ValidationResult> { };
        var envelopeIdValidationResult = new StringValidator().ValidateRequired<string>(envelopeId);
        if (envelopeIdValidationResult != null)
        {
            validationResults.Add(envelopeIdValidationResult);
        }
        ;
        var fileIdValidationResult = new StringValidator().ValidateRequired<string>(fileId);
        if (fileIdValidationResult != null)
        {
            validationResults.Add(fileIdValidationResult);
        }

        var combinedFailures = validationResults.SelectMany(result => result.Errors).ToList();
        if (combinedFailures.Any())
        {
            throw new Http.Exceptions.ValidationException(combinedFailures);
        }

        var resolvedConfig = GetResolvedConfig(_getAttachmentFileAsyncConfig, requestConfig);

        var request = new RequestBuilder(
            HttpMethod.Get,
            "envelope/{envelope_id}/attachments/{file_id}"
        )
            .SetPathParameter("envelope_id", envelopeId)
            .SetPathParameter("file_id", fileId)
            .Build();

        var response = await ExecuteAsync(request, resolvedConfig, cancellationToken)
            .ConfigureAwait(false);

        // Standard deserialization
        var result = await response
            .Content.ReadAsByteArrayAsync(cancellationToken)
            .ConfigureAwait(false);

        // Validate the response
        // Skip validation for primitive types or OneOf types

        return result;
    }

    /// <summary>Send envelope for signature</summary>
    public async global::System.Threading.Tasks.Task<global::Alohi.Signplus.Models.Envelope> SendEnvelopeAsync(
        string envelopeId,
        RequestConfig? requestConfig = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(envelopeId, nameof(envelopeId));
        var validationResults = new List<FluentValidation.Results.ValidationResult> { };
        var envelopeIdValidationResult = new StringValidator().ValidateRequired<string>(envelopeId);
        if (envelopeIdValidationResult != null)
        {
            validationResults.Add(envelopeIdValidationResult);
        }

        var combinedFailures = validationResults.SelectMany(result => result.Errors).ToList();
        if (combinedFailures.Any())
        {
            throw new Http.Exceptions.ValidationException(combinedFailures);
        }

        var resolvedConfig = GetResolvedConfig(_sendEnvelopeAsyncConfig, requestConfig);

        var request = new RequestBuilder(HttpMethod.Post, "envelope/{envelope_id}/send")
            .SetPathParameter("envelope_id", envelopeId)
            .Build();

        var response = await ExecuteAsync(request, resolvedConfig, cancellationToken)
            .ConfigureAwait(false);

        // Custom deserialization with required field validation for JSON responses
        var jsonContent = await response
            .Content.ReadAsStringAsync(cancellationToken)
            .ConfigureAwait(false);

        var result =
            DeserializationValidation.DeserializeWithRequiredFieldValidation<global::Alohi.Signplus.Models.Envelope>(
                jsonContent,
                _jsonSerializerOptions
            );

        // Validate the response
        var responseValidator = new EnvelopeValidator();
        var responseValidationResult = responseValidator.ValidateRequired(result);
        if (!responseValidationResult.IsValid)
        {
            throw new Http.Exceptions.ValidationException(responseValidationResult.Errors);
        }

        return result;
    }

    /// <summary>Duplicate envelope</summary>
    public async global::System.Threading.Tasks.Task<global::Alohi.Signplus.Models.Envelope> DuplicateEnvelopeAsync(
        string envelopeId,
        RequestConfig? requestConfig = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(envelopeId, nameof(envelopeId));
        var validationResults = new List<FluentValidation.Results.ValidationResult> { };
        var envelopeIdValidationResult = new StringValidator().ValidateRequired<string>(envelopeId);
        if (envelopeIdValidationResult != null)
        {
            validationResults.Add(envelopeIdValidationResult);
        }

        var combinedFailures = validationResults.SelectMany(result => result.Errors).ToList();
        if (combinedFailures.Any())
        {
            throw new Http.Exceptions.ValidationException(combinedFailures);
        }

        var resolvedConfig = GetResolvedConfig(_duplicateEnvelopeAsyncConfig, requestConfig);

        var request = new RequestBuilder(HttpMethod.Post, "envelope/{envelope_id}/duplicate")
            .SetPathParameter("envelope_id", envelopeId)
            .Build();

        var response = await ExecuteAsync(request, resolvedConfig, cancellationToken)
            .ConfigureAwait(false);

        // Custom deserialization with required field validation for JSON responses
        var jsonContent = await response
            .Content.ReadAsStringAsync(cancellationToken)
            .ConfigureAwait(false);

        var result =
            DeserializationValidation.DeserializeWithRequiredFieldValidation<global::Alohi.Signplus.Models.Envelope>(
                jsonContent,
                _jsonSerializerOptions
            );

        // Validate the response
        var responseValidator = new EnvelopeValidator();
        var responseValidationResult = responseValidator.ValidateRequired(result);
        if (!responseValidationResult.IsValid)
        {
            throw new Http.Exceptions.ValidationException(responseValidationResult.Errors);
        }

        return result;
    }

    /// <summary>Void envelope</summary>
    public async global::System.Threading.Tasks.Task<global::Alohi.Signplus.Models.Envelope> VoidEnvelopeAsync(
        string envelopeId,
        RequestConfig? requestConfig = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(envelopeId, nameof(envelopeId));
        var validationResults = new List<FluentValidation.Results.ValidationResult> { };
        var envelopeIdValidationResult = new StringValidator().ValidateRequired<string>(envelopeId);
        if (envelopeIdValidationResult != null)
        {
            validationResults.Add(envelopeIdValidationResult);
        }

        var combinedFailures = validationResults.SelectMany(result => result.Errors).ToList();
        if (combinedFailures.Any())
        {
            throw new Http.Exceptions.ValidationException(combinedFailures);
        }

        var resolvedConfig = GetResolvedConfig(_voidEnvelopeAsyncConfig, requestConfig);

        var request = new RequestBuilder(HttpMethod.Put, "envelope/{envelope_id}/void")
            .SetPathParameter("envelope_id", envelopeId)
            .Build();

        var response = await ExecuteAsync(request, resolvedConfig, cancellationToken)
            .ConfigureAwait(false);

        // Custom deserialization with required field validation for JSON responses
        var jsonContent = await response
            .Content.ReadAsStringAsync(cancellationToken)
            .ConfigureAwait(false);

        var result =
            DeserializationValidation.DeserializeWithRequiredFieldValidation<global::Alohi.Signplus.Models.Envelope>(
                jsonContent,
                _jsonSerializerOptions
            );

        // Validate the response
        var responseValidator = new EnvelopeValidator();
        var responseValidationResult = responseValidator.ValidateRequired(result);
        if (!responseValidationResult.IsValid)
        {
            throw new Http.Exceptions.ValidationException(responseValidationResult.Errors);
        }

        return result;
    }

    /// <summary>Rename envelope</summary>
    public async global::System.Threading.Tasks.Task<global::Alohi.Signplus.Models.Envelope> RenameEnvelopeAsync(
        global::Alohi.Signplus.Models.RenameEnvelopeRequest input,
        string envelopeId,
        RequestConfig? requestConfig = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(input, nameof(input));
        ArgumentNullException.ThrowIfNull(envelopeId, nameof(envelopeId));
        var validationResults = new List<FluentValidation.Results.ValidationResult> { };
        var envelopeIdValidationResult = new StringValidator().ValidateRequired<string>(envelopeId);
        if (envelopeIdValidationResult != null)
        {
            validationResults.Add(envelopeIdValidationResult);
        }
        ;
        var validator = new RenameEnvelopeRequestValidator();
        var validationResult = validator.Validate(input);
        validationResults.Add(validationResult);

        var combinedFailures = validationResults.SelectMany(result => result.Errors).ToList();
        if (combinedFailures.Any())
        {
            throw new Http.Exceptions.ValidationException(combinedFailures);
        }

        var resolvedConfig = GetResolvedConfig(_renameEnvelopeAsyncConfig, requestConfig);

        var request = new RequestBuilder(HttpMethod.Put, "envelope/{envelope_id}/rename")
            .SetPathParameter("envelope_id", envelopeId)
            .SetContentAsJson(input, _jsonSerializerOptions)
            .Build();

        var response = await ExecuteAsync(request, resolvedConfig, cancellationToken)
            .ConfigureAwait(false);

        // Custom deserialization with required field validation for JSON responses
        var jsonContent = await response
            .Content.ReadAsStringAsync(cancellationToken)
            .ConfigureAwait(false);

        var result =
            DeserializationValidation.DeserializeWithRequiredFieldValidation<global::Alohi.Signplus.Models.Envelope>(
                jsonContent,
                _jsonSerializerOptions
            );

        // Validate the response
        var responseValidator = new EnvelopeValidator();
        var responseValidationResult = responseValidator.ValidateRequired(result);
        if (!responseValidationResult.IsValid)
        {
            throw new Http.Exceptions.ValidationException(responseValidationResult.Errors);
        }

        return result;
    }

    /// <summary>Set envelope comment</summary>
    public async global::System.Threading.Tasks.Task<global::Alohi.Signplus.Models.Envelope> SetEnvelopeCommentAsync(
        global::Alohi.Signplus.Models.SetEnvelopeCommentRequest input,
        string envelopeId,
        RequestConfig? requestConfig = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(input, nameof(input));
        ArgumentNullException.ThrowIfNull(envelopeId, nameof(envelopeId));
        var validationResults = new List<FluentValidation.Results.ValidationResult> { };
        var envelopeIdValidationResult = new StringValidator().ValidateRequired<string>(envelopeId);
        if (envelopeIdValidationResult != null)
        {
            validationResults.Add(envelopeIdValidationResult);
        }
        ;
        var validator = new SetEnvelopeCommentRequestValidator();
        var validationResult = validator.Validate(input);
        validationResults.Add(validationResult);

        var combinedFailures = validationResults.SelectMany(result => result.Errors).ToList();
        if (combinedFailures.Any())
        {
            throw new Http.Exceptions.ValidationException(combinedFailures);
        }

        var resolvedConfig = GetResolvedConfig(_setEnvelopeCommentAsyncConfig, requestConfig);

        var request = new RequestBuilder(HttpMethod.Put, "envelope/{envelope_id}/set_comment")
            .SetPathParameter("envelope_id", envelopeId)
            .SetContentAsJson(input, _jsonSerializerOptions)
            .Build();

        var response = await ExecuteAsync(request, resolvedConfig, cancellationToken)
            .ConfigureAwait(false);

        // Custom deserialization with required field validation for JSON responses
        var jsonContent = await response
            .Content.ReadAsStringAsync(cancellationToken)
            .ConfigureAwait(false);

        var result =
            DeserializationValidation.DeserializeWithRequiredFieldValidation<global::Alohi.Signplus.Models.Envelope>(
                jsonContent,
                _jsonSerializerOptions
            );

        // Validate the response
        var responseValidator = new EnvelopeValidator();
        var responseValidationResult = responseValidator.ValidateRequired(result);
        if (!responseValidationResult.IsValid)
        {
            throw new Http.Exceptions.ValidationException(responseValidationResult.Errors);
        }

        return result;
    }

    /// <summary>Set envelope notification</summary>
    public async global::System.Threading.Tasks.Task<global::Alohi.Signplus.Models.Envelope> SetEnvelopeNotificationAsync(
        global::Alohi.Signplus.Models.EnvelopeNotification input,
        string envelopeId,
        RequestConfig? requestConfig = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(input, nameof(input));
        ArgumentNullException.ThrowIfNull(envelopeId, nameof(envelopeId));
        var validationResults = new List<FluentValidation.Results.ValidationResult> { };
        var envelopeIdValidationResult = new StringValidator().ValidateRequired<string>(envelopeId);
        if (envelopeIdValidationResult != null)
        {
            validationResults.Add(envelopeIdValidationResult);
        }
        ;
        var validator = new EnvelopeNotificationValidator();
        var validationResult = validator.Validate(input);
        validationResults.Add(validationResult);

        var combinedFailures = validationResults.SelectMany(result => result.Errors).ToList();
        if (combinedFailures.Any())
        {
            throw new Http.Exceptions.ValidationException(combinedFailures);
        }

        var resolvedConfig = GetResolvedConfig(_setEnvelopeNotificationAsyncConfig, requestConfig);

        var request = new RequestBuilder(HttpMethod.Put, "envelope/{envelope_id}/set_notification")
            .SetPathParameter("envelope_id", envelopeId)
            .SetContentAsJson(input, _jsonSerializerOptions)
            .Build();

        var response = await ExecuteAsync(request, resolvedConfig, cancellationToken)
            .ConfigureAwait(false);

        // Custom deserialization with required field validation for JSON responses
        var jsonContent = await response
            .Content.ReadAsStringAsync(cancellationToken)
            .ConfigureAwait(false);

        var result =
            DeserializationValidation.DeserializeWithRequiredFieldValidation<global::Alohi.Signplus.Models.Envelope>(
                jsonContent,
                _jsonSerializerOptions
            );

        // Validate the response
        var responseValidator = new EnvelopeValidator();
        var responseValidationResult = responseValidator.ValidateRequired(result);
        if (!responseValidationResult.IsValid)
        {
            throw new Http.Exceptions.ValidationException(responseValidationResult.Errors);
        }

        return result;
    }

    /// <summary>Set envelope expiration date</summary>
    public async global::System.Threading.Tasks.Task<global::Alohi.Signplus.Models.Envelope> SetEnvelopeExpirationDateAsync(
        global::Alohi.Signplus.Models.SetEnvelopeExpirationRequest input,
        string envelopeId,
        RequestConfig? requestConfig = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(input, nameof(input));
        ArgumentNullException.ThrowIfNull(envelopeId, nameof(envelopeId));
        var validationResults = new List<FluentValidation.Results.ValidationResult> { };
        var envelopeIdValidationResult = new StringValidator().ValidateRequired<string>(envelopeId);
        if (envelopeIdValidationResult != null)
        {
            validationResults.Add(envelopeIdValidationResult);
        }
        ;
        var validator = new SetEnvelopeExpirationRequestValidator();
        var validationResult = validator.Validate(input);
        validationResults.Add(validationResult);

        var combinedFailures = validationResults.SelectMany(result => result.Errors).ToList();
        if (combinedFailures.Any())
        {
            throw new Http.Exceptions.ValidationException(combinedFailures);
        }

        var resolvedConfig = GetResolvedConfig(
            _setEnvelopeExpirationDateAsyncConfig,
            requestConfig
        );

        var request = new RequestBuilder(
            HttpMethod.Put,
            "envelope/{envelope_id}/set_expiration_date"
        )
            .SetPathParameter("envelope_id", envelopeId)
            .SetContentAsJson(input, _jsonSerializerOptions)
            .Build();

        var response = await ExecuteAsync(request, resolvedConfig, cancellationToken)
            .ConfigureAwait(false);

        // Custom deserialization with required field validation for JSON responses
        var jsonContent = await response
            .Content.ReadAsStringAsync(cancellationToken)
            .ConfigureAwait(false);

        var result =
            DeserializationValidation.DeserializeWithRequiredFieldValidation<global::Alohi.Signplus.Models.Envelope>(
                jsonContent,
                _jsonSerializerOptions
            );

        // Validate the response
        var responseValidator = new EnvelopeValidator();
        var responseValidationResult = responseValidator.ValidateRequired(result);
        if (!responseValidationResult.IsValid)
        {
            throw new Http.Exceptions.ValidationException(responseValidationResult.Errors);
        }

        return result;
    }

    /// <summary>Set envelope legality level</summary>
    public async global::System.Threading.Tasks.Task<global::Alohi.Signplus.Models.Envelope> SetEnvelopeLegalityLevelAsync(
        global::Alohi.Signplus.Models.SetEnvelopeLegalityLevelRequest input,
        string envelopeId,
        RequestConfig? requestConfig = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(input, nameof(input));
        ArgumentNullException.ThrowIfNull(envelopeId, nameof(envelopeId));
        var validationResults = new List<FluentValidation.Results.ValidationResult> { };
        var envelopeIdValidationResult = new StringValidator().ValidateRequired<string>(envelopeId);
        if (envelopeIdValidationResult != null)
        {
            validationResults.Add(envelopeIdValidationResult);
        }
        ;
        var validator = new SetEnvelopeLegalityLevelRequestValidator();
        var validationResult = validator.Validate(input);
        validationResults.Add(validationResult);

        var combinedFailures = validationResults.SelectMany(result => result.Errors).ToList();
        if (combinedFailures.Any())
        {
            throw new Http.Exceptions.ValidationException(combinedFailures);
        }

        var resolvedConfig = GetResolvedConfig(_setEnvelopeLegalityLevelAsyncConfig, requestConfig);

        var request = new RequestBuilder(
            HttpMethod.Put,
            "envelope/{envelope_id}/set_legality_level"
        )
            .SetPathParameter("envelope_id", envelopeId)
            .SetContentAsJson(input, _jsonSerializerOptions)
            .Build();

        var response = await ExecuteAsync(request, resolvedConfig, cancellationToken)
            .ConfigureAwait(false);

        // Custom deserialization with required field validation for JSON responses
        var jsonContent = await response
            .Content.ReadAsStringAsync(cancellationToken)
            .ConfigureAwait(false);

        var result =
            DeserializationValidation.DeserializeWithRequiredFieldValidation<global::Alohi.Signplus.Models.Envelope>(
                jsonContent,
                _jsonSerializerOptions
            );

        // Validate the response
        var responseValidator = new EnvelopeValidator();
        var responseValidationResult = responseValidator.ValidateRequired(result);
        if (!responseValidationResult.IsValid)
        {
            throw new Http.Exceptions.ValidationException(responseValidationResult.Errors);
        }

        return result;
    }

    /// <summary>Get envelope annotations</summary>
    /// <param name="envelopeId">ID of the envelope</param>
    public async global::System.Threading.Tasks.Task<
        List<global::Alohi.Signplus.Models.Annotation>
    > GetEnvelopeAnnotationsAsync(
        string envelopeId,
        RequestConfig? requestConfig = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(envelopeId, nameof(envelopeId));
        var validationResults = new List<FluentValidation.Results.ValidationResult> { };
        var envelopeIdValidationResult = new StringValidator().ValidateRequired<string>(envelopeId);
        if (envelopeIdValidationResult != null)
        {
            validationResults.Add(envelopeIdValidationResult);
        }

        var combinedFailures = validationResults.SelectMany(result => result.Errors).ToList();
        if (combinedFailures.Any())
        {
            throw new Http.Exceptions.ValidationException(combinedFailures);
        }

        var resolvedConfig = GetResolvedConfig(_getEnvelopeAnnotationsAsyncConfig, requestConfig);

        var request = new RequestBuilder(HttpMethod.Get, "envelope/{envelope_id}/annotations")
            .SetPathParameter("envelope_id", envelopeId)
            .Build();

        var response = await ExecuteAsync(request, resolvedConfig, cancellationToken)
            .ConfigureAwait(false);

        // Custom deserialization with required field validation for JSON responses
        var jsonContent = await response
            .Content.ReadAsStringAsync(cancellationToken)
            .ConfigureAwait(false);

        var result = DeserializationValidation.DeserializeWithRequiredFieldValidation<
            List<global::Alohi.Signplus.Models.Annotation>
        >(jsonContent, _jsonSerializerOptions);

        // Validate the response
        var responseValidator = new ListValidator<global::Alohi.Signplus.Models.Annotation>();
        var responseValidationResult = responseValidator.ValidateRequiredList(result);
        if (!responseValidationResult.IsValid)
        {
            throw new Http.Exceptions.ValidationException(responseValidationResult.Errors);
        }
        var itemFailures = new List<FluentValidation.Results.ValidationFailure>();
        var itemValidator = new AnnotationValidator();
        foreach (var item in result)
        {
            var itemResult = itemValidator.Validate(item);
            if (!itemResult.IsValid)
                itemFailures.AddRange(itemResult.Errors);
        }
        if (itemFailures.Any())
        {
            throw new Http.Exceptions.ValidationException(itemFailures);
        }

        return result;
    }

    /// <summary>Get envelope document annotations</summary>
    /// <param name="envelopeId">ID of the envelope</param>
    /// <param name="documentId">ID of document</param>
    public async global::System.Threading.Tasks.Task<global::Alohi.Signplus.Models.ListEnvelopeDocumentAnnotationsResponse> GetEnvelopeDocumentAnnotationsAsync(
        string envelopeId,
        string documentId,
        RequestConfig? requestConfig = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(envelopeId, nameof(envelopeId));
        ArgumentNullException.ThrowIfNull(documentId, nameof(documentId));
        var validationResults = new List<FluentValidation.Results.ValidationResult> { };
        var envelopeIdValidationResult = new StringValidator().ValidateRequired<string>(envelopeId);
        if (envelopeIdValidationResult != null)
        {
            validationResults.Add(envelopeIdValidationResult);
        }
        ;
        var documentIdValidationResult = new StringValidator().ValidateRequired<string>(documentId);
        if (documentIdValidationResult != null)
        {
            validationResults.Add(documentIdValidationResult);
        }

        var combinedFailures = validationResults.SelectMany(result => result.Errors).ToList();
        if (combinedFailures.Any())
        {
            throw new Http.Exceptions.ValidationException(combinedFailures);
        }

        var resolvedConfig = GetResolvedConfig(
            _getEnvelopeDocumentAnnotationsAsyncConfig,
            requestConfig
        );

        var request = new RequestBuilder(
            HttpMethod.Get,
            "envelope/{envelope_id}/annotations/{document_id}"
        )
            .SetPathParameter("envelope_id", envelopeId)
            .SetPathParameter("document_id", documentId)
            .Build();

        var response = await ExecuteAsync(request, resolvedConfig, cancellationToken)
            .ConfigureAwait(false);

        // Custom deserialization with required field validation for JSON responses
        var jsonContent = await response
            .Content.ReadAsStringAsync(cancellationToken)
            .ConfigureAwait(false);

        var result =
            DeserializationValidation.DeserializeWithRequiredFieldValidation<global::Alohi.Signplus.Models.ListEnvelopeDocumentAnnotationsResponse>(
                jsonContent,
                _jsonSerializerOptions
            );

        // Validate the response
        var responseValidator = new ListEnvelopeDocumentAnnotationsResponseValidator();
        var responseValidationResult = responseValidator.ValidateRequired(result);
        if (!responseValidationResult.IsValid)
        {
            throw new Http.Exceptions.ValidationException(responseValidationResult.Errors);
        }

        return result;
    }

    /// <summary>Add envelope annotation</summary>
    /// <param name="envelopeId">ID of the envelope</param>
    public async global::System.Threading.Tasks.Task<global::Alohi.Signplus.Models.Annotation> AddEnvelopeAnnotationAsync(
        global::Alohi.Signplus.Models.AddAnnotationRequest input,
        string envelopeId,
        RequestConfig? requestConfig = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(input, nameof(input));
        ArgumentNullException.ThrowIfNull(envelopeId, nameof(envelopeId));
        var validationResults = new List<FluentValidation.Results.ValidationResult> { };
        var envelopeIdValidationResult = new StringValidator().ValidateRequired<string>(envelopeId);
        if (envelopeIdValidationResult != null)
        {
            validationResults.Add(envelopeIdValidationResult);
        }
        ;
        var validator = new AddAnnotationRequestValidator();
        var validationResult = validator.Validate(input);
        validationResults.Add(validationResult);

        var combinedFailures = validationResults.SelectMany(result => result.Errors).ToList();
        if (combinedFailures.Any())
        {
            throw new Http.Exceptions.ValidationException(combinedFailures);
        }

        var resolvedConfig = GetResolvedConfig(_addEnvelopeAnnotationAsyncConfig, requestConfig);

        var request = new RequestBuilder(HttpMethod.Post, "envelope/{envelope_id}/annotation")
            .SetPathParameter("envelope_id", envelopeId)
            .SetContentAsJson(input, _jsonSerializerOptions)
            .Build();

        var response = await ExecuteAsync(request, resolvedConfig, cancellationToken)
            .ConfigureAwait(false);

        // Custom deserialization with required field validation for JSON responses
        var jsonContent = await response
            .Content.ReadAsStringAsync(cancellationToken)
            .ConfigureAwait(false);

        var result =
            DeserializationValidation.DeserializeWithRequiredFieldValidation<global::Alohi.Signplus.Models.Annotation>(
                jsonContent,
                _jsonSerializerOptions
            );

        // Validate the response
        var responseValidator = new AnnotationValidator();
        var responseValidationResult = responseValidator.ValidateRequired(result);
        if (!responseValidationResult.IsValid)
        {
            throw new Http.Exceptions.ValidationException(responseValidationResult.Errors);
        }

        return result;
    }

    /// <summary>Delete envelope annotation</summary>
    /// <param name="envelopeId">ID of the envelope</param>
    /// <param name="annotationId">ID of the annotation to delete</param>
    public async global::System.Threading.Tasks.Task DeleteEnvelopeAnnotationAsync(
        string envelopeId,
        string annotationId,
        RequestConfig? requestConfig = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(envelopeId, nameof(envelopeId));
        ArgumentNullException.ThrowIfNull(annotationId, nameof(annotationId));
        var validationResults = new List<FluentValidation.Results.ValidationResult> { };
        var envelopeIdValidationResult = new StringValidator().ValidateRequired<string>(envelopeId);
        if (envelopeIdValidationResult != null)
        {
            validationResults.Add(envelopeIdValidationResult);
        }
        ;
        var annotationIdValidationResult = new StringValidator().ValidateRequired<string>(
            annotationId
        );
        if (annotationIdValidationResult != null)
        {
            validationResults.Add(annotationIdValidationResult);
        }

        var combinedFailures = validationResults.SelectMany(result => result.Errors).ToList();
        if (combinedFailures.Any())
        {
            throw new Http.Exceptions.ValidationException(combinedFailures);
        }

        var resolvedConfig = GetResolvedConfig(_deleteEnvelopeAnnotationAsyncConfig, requestConfig);

        var request = new RequestBuilder(
            HttpMethod.Delete,
            "envelope/{envelope_id}/annotation/{annotation_id}"
        )
            .SetPathParameter("envelope_id", envelopeId)
            .SetPathParameter("annotation_id", annotationId)
            .Build();

        var response = await ExecuteAsync(request, resolvedConfig, cancellationToken)
            .ConfigureAwait(false);
    }

    /// <summary>Create new template</summary>
    public async global::System.Threading.Tasks.Task<global::Alohi.Signplus.Models.Template> CreateTemplateAsync(
        global::Alohi.Signplus.Models.CreateTemplateRequest input,
        RequestConfig? requestConfig = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(input, nameof(input));
        var validationResults = new List<FluentValidation.Results.ValidationResult> { };
        var validator = new CreateTemplateRequestValidator();
        var validationResult = validator.Validate(input);
        validationResults.Add(validationResult);

        var combinedFailures = validationResults.SelectMany(result => result.Errors).ToList();
        if (combinedFailures.Any())
        {
            throw new Http.Exceptions.ValidationException(combinedFailures);
        }

        var resolvedConfig = GetResolvedConfig(_createTemplateAsyncConfig, requestConfig);

        var request = new RequestBuilder(HttpMethod.Post, "template")
            .SetContentAsJson(input, _jsonSerializerOptions)
            .Build();

        var response = await ExecuteAsync(request, resolvedConfig, cancellationToken)
            .ConfigureAwait(false);

        // Custom deserialization with required field validation for JSON responses
        var jsonContent = await response
            .Content.ReadAsStringAsync(cancellationToken)
            .ConfigureAwait(false);

        var result =
            DeserializationValidation.DeserializeWithRequiredFieldValidation<global::Alohi.Signplus.Models.Template>(
                jsonContent,
                _jsonSerializerOptions
            );

        // Validate the response
        var responseValidator = new TemplateValidator();
        var responseValidationResult = responseValidator.ValidateRequired(result);
        if (!responseValidationResult.IsValid)
        {
            throw new Http.Exceptions.ValidationException(responseValidationResult.Errors);
        }

        return result;
    }

    /// <summary>List templates</summary>
    public async global::System.Threading.Tasks.Task<global::Alohi.Signplus.Models.ListTemplatesResponse> ListTemplatesAsync(
        global::Alohi.Signplus.Models.ListTemplatesRequest input,
        RequestConfig? requestConfig = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(input, nameof(input));
        var validationResults = new List<FluentValidation.Results.ValidationResult> { };
        var validator = new ListTemplatesRequestValidator();
        var validationResult = validator.Validate(input);
        validationResults.Add(validationResult);

        var combinedFailures = validationResults.SelectMany(result => result.Errors).ToList();
        if (combinedFailures.Any())
        {
            throw new Http.Exceptions.ValidationException(combinedFailures);
        }

        var resolvedConfig = GetResolvedConfig(_listTemplatesAsyncConfig, requestConfig);

        var request = new RequestBuilder(HttpMethod.Post, "templates")
            .SetContentAsJson(input, _jsonSerializerOptions)
            .Build();

        var response = await ExecuteAsync(request, resolvedConfig, cancellationToken)
            .ConfigureAwait(false);

        // Custom deserialization with required field validation for JSON responses
        var jsonContent = await response
            .Content.ReadAsStringAsync(cancellationToken)
            .ConfigureAwait(false);

        var result =
            DeserializationValidation.DeserializeWithRequiredFieldValidation<global::Alohi.Signplus.Models.ListTemplatesResponse>(
                jsonContent,
                _jsonSerializerOptions
            );

        // Validate the response
        var responseValidator = new ListTemplatesResponseValidator();
        var responseValidationResult = responseValidator.ValidateRequired(result);
        if (!responseValidationResult.IsValid)
        {
            throw new Http.Exceptions.ValidationException(responseValidationResult.Errors);
        }

        return result;
    }

    /// <summary>Get template</summary>
    public async global::System.Threading.Tasks.Task<global::Alohi.Signplus.Models.Template> GetTemplateAsync(
        string templateId,
        RequestConfig? requestConfig = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(templateId, nameof(templateId));
        var validationResults = new List<FluentValidation.Results.ValidationResult> { };
        var templateIdValidationResult = new StringValidator().ValidateRequired<string>(templateId);
        if (templateIdValidationResult != null)
        {
            validationResults.Add(templateIdValidationResult);
        }

        var combinedFailures = validationResults.SelectMany(result => result.Errors).ToList();
        if (combinedFailures.Any())
        {
            throw new Http.Exceptions.ValidationException(combinedFailures);
        }

        var resolvedConfig = GetResolvedConfig(_getTemplateAsyncConfig, requestConfig);

        var request = new RequestBuilder(HttpMethod.Get, "template/{template_id}")
            .SetPathParameter("template_id", templateId)
            .Build();

        var response = await ExecuteAsync(request, resolvedConfig, cancellationToken)
            .ConfigureAwait(false);

        // Custom deserialization with required field validation for JSON responses
        var jsonContent = await response
            .Content.ReadAsStringAsync(cancellationToken)
            .ConfigureAwait(false);

        var result =
            DeserializationValidation.DeserializeWithRequiredFieldValidation<global::Alohi.Signplus.Models.Template>(
                jsonContent,
                _jsonSerializerOptions
            );

        // Validate the response
        var responseValidator = new TemplateValidator();
        var responseValidationResult = responseValidator.ValidateRequired(result);
        if (!responseValidationResult.IsValid)
        {
            throw new Http.Exceptions.ValidationException(responseValidationResult.Errors);
        }

        return result;
    }

    /// <summary>Delete template</summary>
    public async global::System.Threading.Tasks.Task DeleteTemplateAsync(
        string templateId,
        RequestConfig? requestConfig = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(templateId, nameof(templateId));
        var validationResults = new List<FluentValidation.Results.ValidationResult> { };
        var templateIdValidationResult = new StringValidator().ValidateRequired<string>(templateId);
        if (templateIdValidationResult != null)
        {
            validationResults.Add(templateIdValidationResult);
        }

        var combinedFailures = validationResults.SelectMany(result => result.Errors).ToList();
        if (combinedFailures.Any())
        {
            throw new Http.Exceptions.ValidationException(combinedFailures);
        }

        var resolvedConfig = GetResolvedConfig(_deleteTemplateAsyncConfig, requestConfig);

        var request = new RequestBuilder(HttpMethod.Delete, "template/{template_id}")
            .SetPathParameter("template_id", templateId)
            .Build();

        var response = await ExecuteAsync(request, resolvedConfig, cancellationToken)
            .ConfigureAwait(false);
    }

    /// <summary>Duplicate template</summary>
    public async global::System.Threading.Tasks.Task<global::Alohi.Signplus.Models.Template> DuplicateTemplateAsync(
        string templateId,
        RequestConfig? requestConfig = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(templateId, nameof(templateId));
        var validationResults = new List<FluentValidation.Results.ValidationResult> { };
        var templateIdValidationResult = new StringValidator().ValidateRequired<string>(templateId);
        if (templateIdValidationResult != null)
        {
            validationResults.Add(templateIdValidationResult);
        }

        var combinedFailures = validationResults.SelectMany(result => result.Errors).ToList();
        if (combinedFailures.Any())
        {
            throw new Http.Exceptions.ValidationException(combinedFailures);
        }

        var resolvedConfig = GetResolvedConfig(_duplicateTemplateAsyncConfig, requestConfig);

        var request = new RequestBuilder(HttpMethod.Post, "template/{template_id}/duplicate")
            .SetPathParameter("template_id", templateId)
            .Build();

        var response = await ExecuteAsync(request, resolvedConfig, cancellationToken)
            .ConfigureAwait(false);

        // Custom deserialization with required field validation for JSON responses
        var jsonContent = await response
            .Content.ReadAsStringAsync(cancellationToken)
            .ConfigureAwait(false);

        var result =
            DeserializationValidation.DeserializeWithRequiredFieldValidation<global::Alohi.Signplus.Models.Template>(
                jsonContent,
                _jsonSerializerOptions
            );

        // Validate the response
        var responseValidator = new TemplateValidator();
        var responseValidationResult = responseValidator.ValidateRequired(result);
        if (!responseValidationResult.IsValid)
        {
            throw new Http.Exceptions.ValidationException(responseValidationResult.Errors);
        }

        return result;
    }

    /// <summary>Add template document</summary>
    public async global::System.Threading.Tasks.Task<global::Alohi.Signplus.Models.Document> AddTemplateDocumentAsync(
        global::Alohi.Signplus.Models.AddTemplateDocumentRequest input,
        string templateId,
        RequestConfig? requestConfig = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(input, nameof(input));
        ArgumentNullException.ThrowIfNull(templateId, nameof(templateId));
        var validationResults = new List<FluentValidation.Results.ValidationResult> { };
        var templateIdValidationResult = new StringValidator().ValidateRequired<string>(templateId);
        if (templateIdValidationResult != null)
        {
            validationResults.Add(templateIdValidationResult);
        }
        ;
        var validator = new AddTemplateDocumentRequestValidator();
        var validationResult = validator.Validate(input);
        validationResults.Add(validationResult);

        var combinedFailures = validationResults.SelectMany(result => result.Errors).ToList();
        if (combinedFailures.Any())
        {
            throw new Http.Exceptions.ValidationException(combinedFailures);
        }

        var resolvedConfig = GetResolvedConfig(_addTemplateDocumentAsyncConfig, requestConfig);

        var request = new RequestBuilder(HttpMethod.Post, "template/{template_id}/document")
            .SetPathParameter("template_id", templateId)
            .SetContentAsMultipartFormData(input, _jsonSerializerOptions)
            .Build();

        var response = await ExecuteAsync(request, resolvedConfig, cancellationToken)
            .ConfigureAwait(false);

        // Custom deserialization with required field validation for JSON responses
        var jsonContent = await response
            .Content.ReadAsStringAsync(cancellationToken)
            .ConfigureAwait(false);

        var result =
            DeserializationValidation.DeserializeWithRequiredFieldValidation<global::Alohi.Signplus.Models.Document>(
                jsonContent,
                _jsonSerializerOptions
            );

        // Validate the response
        var responseValidator = new DocumentValidator();
        var responseValidationResult = responseValidator.ValidateRequired(result);
        if (!responseValidationResult.IsValid)
        {
            throw new Http.Exceptions.ValidationException(responseValidationResult.Errors);
        }

        return result;
    }

    /// <summary>Get template document</summary>
    public async global::System.Threading.Tasks.Task<global::Alohi.Signplus.Models.Document> GetTemplateDocumentAsync(
        string templateId,
        string documentId,
        RequestConfig? requestConfig = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(templateId, nameof(templateId));
        ArgumentNullException.ThrowIfNull(documentId, nameof(documentId));
        var validationResults = new List<FluentValidation.Results.ValidationResult> { };
        var templateIdValidationResult = new StringValidator().ValidateRequired<string>(templateId);
        if (templateIdValidationResult != null)
        {
            validationResults.Add(templateIdValidationResult);
        }
        ;
        var documentIdValidationResult = new StringValidator().ValidateRequired<string>(documentId);
        if (documentIdValidationResult != null)
        {
            validationResults.Add(documentIdValidationResult);
        }

        var combinedFailures = validationResults.SelectMany(result => result.Errors).ToList();
        if (combinedFailures.Any())
        {
            throw new Http.Exceptions.ValidationException(combinedFailures);
        }

        var resolvedConfig = GetResolvedConfig(_getTemplateDocumentAsyncConfig, requestConfig);

        var request = new RequestBuilder(
            HttpMethod.Get,
            "template/{template_id}/document/{document_id}"
        )
            .SetPathParameter("template_id", templateId)
            .SetPathParameter("document_id", documentId)
            .Build();

        var response = await ExecuteAsync(request, resolvedConfig, cancellationToken)
            .ConfigureAwait(false);

        // Custom deserialization with required field validation for JSON responses
        var jsonContent = await response
            .Content.ReadAsStringAsync(cancellationToken)
            .ConfigureAwait(false);

        var result =
            DeserializationValidation.DeserializeWithRequiredFieldValidation<global::Alohi.Signplus.Models.Document>(
                jsonContent,
                _jsonSerializerOptions
            );

        // Validate the response
        var responseValidator = new DocumentValidator();
        var responseValidationResult = responseValidator.ValidateRequired(result);
        if (!responseValidationResult.IsValid)
        {
            throw new Http.Exceptions.ValidationException(responseValidationResult.Errors);
        }

        return result;
    }

    /// <summary>Get template documents</summary>
    public async global::System.Threading.Tasks.Task<global::Alohi.Signplus.Models.ListTemplateDocumentsResponse> GetTemplateDocumentsAsync(
        string templateId,
        RequestConfig? requestConfig = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(templateId, nameof(templateId));
        var validationResults = new List<FluentValidation.Results.ValidationResult> { };
        var templateIdValidationResult = new StringValidator().ValidateRequired<string>(templateId);
        if (templateIdValidationResult != null)
        {
            validationResults.Add(templateIdValidationResult);
        }

        var combinedFailures = validationResults.SelectMany(result => result.Errors).ToList();
        if (combinedFailures.Any())
        {
            throw new Http.Exceptions.ValidationException(combinedFailures);
        }

        var resolvedConfig = GetResolvedConfig(_getTemplateDocumentsAsyncConfig, requestConfig);

        var request = new RequestBuilder(HttpMethod.Get, "template/{template_id}/documents")
            .SetPathParameter("template_id", templateId)
            .Build();

        var response = await ExecuteAsync(request, resolvedConfig, cancellationToken)
            .ConfigureAwait(false);

        // Custom deserialization with required field validation for JSON responses
        var jsonContent = await response
            .Content.ReadAsStringAsync(cancellationToken)
            .ConfigureAwait(false);

        var result =
            DeserializationValidation.DeserializeWithRequiredFieldValidation<global::Alohi.Signplus.Models.ListTemplateDocumentsResponse>(
                jsonContent,
                _jsonSerializerOptions
            );

        // Validate the response
        var responseValidator = new ListTemplateDocumentsResponseValidator();
        var responseValidationResult = responseValidator.ValidateRequired(result);
        if (!responseValidationResult.IsValid)
        {
            throw new Http.Exceptions.ValidationException(responseValidationResult.Errors);
        }

        return result;
    }

    /// <summary>Add template signing steps</summary>
    public async global::System.Threading.Tasks.Task<global::Alohi.Signplus.Models.Template> AddTemplateSigningStepsAsync(
        global::Alohi.Signplus.Models.AddTemplateSigningStepsRequest input,
        string templateId,
        RequestConfig? requestConfig = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(input, nameof(input));
        ArgumentNullException.ThrowIfNull(templateId, nameof(templateId));
        var validationResults = new List<FluentValidation.Results.ValidationResult> { };
        var templateIdValidationResult = new StringValidator().ValidateRequired<string>(templateId);
        if (templateIdValidationResult != null)
        {
            validationResults.Add(templateIdValidationResult);
        }
        ;
        var validator = new AddTemplateSigningStepsRequestValidator();
        var validationResult = validator.Validate(input);
        validationResults.Add(validationResult);

        var combinedFailures = validationResults.SelectMany(result => result.Errors).ToList();
        if (combinedFailures.Any())
        {
            throw new Http.Exceptions.ValidationException(combinedFailures);
        }

        var resolvedConfig = GetResolvedConfig(_addTemplateSigningStepsAsyncConfig, requestConfig);

        var request = new RequestBuilder(HttpMethod.Post, "template/{template_id}/signing_steps")
            .SetPathParameter("template_id", templateId)
            .SetContentAsJson(input, _jsonSerializerOptions)
            .Build();

        var response = await ExecuteAsync(request, resolvedConfig, cancellationToken)
            .ConfigureAwait(false);

        // Custom deserialization with required field validation for JSON responses
        var jsonContent = await response
            .Content.ReadAsStringAsync(cancellationToken)
            .ConfigureAwait(false);

        var result =
            DeserializationValidation.DeserializeWithRequiredFieldValidation<global::Alohi.Signplus.Models.Template>(
                jsonContent,
                _jsonSerializerOptions
            );

        // Validate the response
        var responseValidator = new TemplateValidator();
        var responseValidationResult = responseValidator.ValidateRequired(result);
        if (!responseValidationResult.IsValid)
        {
            throw new Http.Exceptions.ValidationException(responseValidationResult.Errors);
        }

        return result;
    }

    /// <summary>Rename template</summary>
    public async global::System.Threading.Tasks.Task<global::Alohi.Signplus.Models.Template> RenameTemplateAsync(
        global::Alohi.Signplus.Models.RenameTemplateRequest input,
        string templateId,
        RequestConfig? requestConfig = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(input, nameof(input));
        ArgumentNullException.ThrowIfNull(templateId, nameof(templateId));
        var validationResults = new List<FluentValidation.Results.ValidationResult> { };
        var templateIdValidationResult = new StringValidator().ValidateRequired<string>(templateId);
        if (templateIdValidationResult != null)
        {
            validationResults.Add(templateIdValidationResult);
        }
        ;
        var validator = new RenameTemplateRequestValidator();
        var validationResult = validator.Validate(input);
        validationResults.Add(validationResult);

        var combinedFailures = validationResults.SelectMany(result => result.Errors).ToList();
        if (combinedFailures.Any())
        {
            throw new Http.Exceptions.ValidationException(combinedFailures);
        }

        var resolvedConfig = GetResolvedConfig(_renameTemplateAsyncConfig, requestConfig);

        var request = new RequestBuilder(HttpMethod.Put, "template/{template_id}/rename")
            .SetPathParameter("template_id", templateId)
            .SetContentAsJson(input, _jsonSerializerOptions)
            .Build();

        var response = await ExecuteAsync(request, resolvedConfig, cancellationToken)
            .ConfigureAwait(false);

        // Custom deserialization with required field validation for JSON responses
        var jsonContent = await response
            .Content.ReadAsStringAsync(cancellationToken)
            .ConfigureAwait(false);

        var result =
            DeserializationValidation.DeserializeWithRequiredFieldValidation<global::Alohi.Signplus.Models.Template>(
                jsonContent,
                _jsonSerializerOptions
            );

        // Validate the response
        var responseValidator = new TemplateValidator();
        var responseValidationResult = responseValidator.ValidateRequired(result);
        if (!responseValidationResult.IsValid)
        {
            throw new Http.Exceptions.ValidationException(responseValidationResult.Errors);
        }

        return result;
    }

    /// <summary>Set template comment</summary>
    public async global::System.Threading.Tasks.Task<global::Alohi.Signplus.Models.Template> SetTemplateCommentAsync(
        global::Alohi.Signplus.Models.SetTemplateCommentRequest input,
        string templateId,
        RequestConfig? requestConfig = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(input, nameof(input));
        ArgumentNullException.ThrowIfNull(templateId, nameof(templateId));
        var validationResults = new List<FluentValidation.Results.ValidationResult> { };
        var templateIdValidationResult = new StringValidator().ValidateRequired<string>(templateId);
        if (templateIdValidationResult != null)
        {
            validationResults.Add(templateIdValidationResult);
        }
        ;
        var validator = new SetTemplateCommentRequestValidator();
        var validationResult = validator.Validate(input);
        validationResults.Add(validationResult);

        var combinedFailures = validationResults.SelectMany(result => result.Errors).ToList();
        if (combinedFailures.Any())
        {
            throw new Http.Exceptions.ValidationException(combinedFailures);
        }

        var resolvedConfig = GetResolvedConfig(_setTemplateCommentAsyncConfig, requestConfig);

        var request = new RequestBuilder(HttpMethod.Put, "template/{template_id}/set_comment")
            .SetPathParameter("template_id", templateId)
            .SetContentAsJson(input, _jsonSerializerOptions)
            .Build();

        var response = await ExecuteAsync(request, resolvedConfig, cancellationToken)
            .ConfigureAwait(false);

        // Custom deserialization with required field validation for JSON responses
        var jsonContent = await response
            .Content.ReadAsStringAsync(cancellationToken)
            .ConfigureAwait(false);

        var result =
            DeserializationValidation.DeserializeWithRequiredFieldValidation<global::Alohi.Signplus.Models.Template>(
                jsonContent,
                _jsonSerializerOptions
            );

        // Validate the response
        var responseValidator = new TemplateValidator();
        var responseValidationResult = responseValidator.ValidateRequired(result);
        if (!responseValidationResult.IsValid)
        {
            throw new Http.Exceptions.ValidationException(responseValidationResult.Errors);
        }

        return result;
    }

    /// <summary>Set template notification</summary>
    public async global::System.Threading.Tasks.Task<global::Alohi.Signplus.Models.Template> SetTemplateNotificationAsync(
        global::Alohi.Signplus.Models.EnvelopeNotification input,
        string templateId,
        RequestConfig? requestConfig = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(input, nameof(input));
        ArgumentNullException.ThrowIfNull(templateId, nameof(templateId));
        var validationResults = new List<FluentValidation.Results.ValidationResult> { };
        var templateIdValidationResult = new StringValidator().ValidateRequired<string>(templateId);
        if (templateIdValidationResult != null)
        {
            validationResults.Add(templateIdValidationResult);
        }
        ;
        var validator = new EnvelopeNotificationValidator();
        var validationResult = validator.Validate(input);
        validationResults.Add(validationResult);

        var combinedFailures = validationResults.SelectMany(result => result.Errors).ToList();
        if (combinedFailures.Any())
        {
            throw new Http.Exceptions.ValidationException(combinedFailures);
        }

        var resolvedConfig = GetResolvedConfig(_setTemplateNotificationAsyncConfig, requestConfig);

        var request = new RequestBuilder(HttpMethod.Put, "template/{template_id}/set_notification")
            .SetPathParameter("template_id", templateId)
            .SetContentAsJson(input, _jsonSerializerOptions)
            .Build();

        var response = await ExecuteAsync(request, resolvedConfig, cancellationToken)
            .ConfigureAwait(false);

        // Custom deserialization with required field validation for JSON responses
        var jsonContent = await response
            .Content.ReadAsStringAsync(cancellationToken)
            .ConfigureAwait(false);

        var result =
            DeserializationValidation.DeserializeWithRequiredFieldValidation<global::Alohi.Signplus.Models.Template>(
                jsonContent,
                _jsonSerializerOptions
            );

        // Validate the response
        var responseValidator = new TemplateValidator();
        var responseValidationResult = responseValidator.ValidateRequired(result);
        if (!responseValidationResult.IsValid)
        {
            throw new Http.Exceptions.ValidationException(responseValidationResult.Errors);
        }

        return result;
    }

    /// <summary>Get template annotations</summary>
    /// <param name="templateId">ID of the template</param>
    public async global::System.Threading.Tasks.Task<global::Alohi.Signplus.Models.ListTemplateAnnotationsResponse> GetTemplateAnnotationsAsync(
        string templateId,
        RequestConfig? requestConfig = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(templateId, nameof(templateId));
        var validationResults = new List<FluentValidation.Results.ValidationResult> { };
        var templateIdValidationResult = new StringValidator().ValidateRequired<string>(templateId);
        if (templateIdValidationResult != null)
        {
            validationResults.Add(templateIdValidationResult);
        }

        var combinedFailures = validationResults.SelectMany(result => result.Errors).ToList();
        if (combinedFailures.Any())
        {
            throw new Http.Exceptions.ValidationException(combinedFailures);
        }

        var resolvedConfig = GetResolvedConfig(_getTemplateAnnotationsAsyncConfig, requestConfig);

        var request = new RequestBuilder(HttpMethod.Get, "template/{template_id}/annotations")
            .SetPathParameter("template_id", templateId)
            .Build();

        var response = await ExecuteAsync(request, resolvedConfig, cancellationToken)
            .ConfigureAwait(false);

        // Custom deserialization with required field validation for JSON responses
        var jsonContent = await response
            .Content.ReadAsStringAsync(cancellationToken)
            .ConfigureAwait(false);

        var result =
            DeserializationValidation.DeserializeWithRequiredFieldValidation<global::Alohi.Signplus.Models.ListTemplateAnnotationsResponse>(
                jsonContent,
                _jsonSerializerOptions
            );

        // Validate the response
        var responseValidator = new ListTemplateAnnotationsResponseValidator();
        var responseValidationResult = responseValidator.ValidateRequired(result);
        if (!responseValidationResult.IsValid)
        {
            throw new Http.Exceptions.ValidationException(responseValidationResult.Errors);
        }

        return result;
    }

    /// <summary>Get document template annotations</summary>
    /// <param name="templateId">ID of the template</param>
    /// <param name="documentId">ID of document</param>
    public async global::System.Threading.Tasks.Task<global::Alohi.Signplus.Models.ListTemplateDocumentAnnotationsResponse> GetDocumentTemplateAnnotationsAsync(
        string templateId,
        string documentId,
        RequestConfig? requestConfig = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(templateId, nameof(templateId));
        ArgumentNullException.ThrowIfNull(documentId, nameof(documentId));
        var validationResults = new List<FluentValidation.Results.ValidationResult> { };
        var templateIdValidationResult = new StringValidator().ValidateRequired<string>(templateId);
        if (templateIdValidationResult != null)
        {
            validationResults.Add(templateIdValidationResult);
        }
        ;
        var documentIdValidationResult = new StringValidator().ValidateRequired<string>(documentId);
        if (documentIdValidationResult != null)
        {
            validationResults.Add(documentIdValidationResult);
        }

        var combinedFailures = validationResults.SelectMany(result => result.Errors).ToList();
        if (combinedFailures.Any())
        {
            throw new Http.Exceptions.ValidationException(combinedFailures);
        }

        var resolvedConfig = GetResolvedConfig(
            _getDocumentTemplateAnnotationsAsyncConfig,
            requestConfig
        );

        var request = new RequestBuilder(
            HttpMethod.Get,
            "template/{template_id}/annotations/{document_id}"
        )
            .SetPathParameter("template_id", templateId)
            .SetPathParameter("document_id", documentId)
            .Build();

        var response = await ExecuteAsync(request, resolvedConfig, cancellationToken)
            .ConfigureAwait(false);

        // Custom deserialization with required field validation for JSON responses
        var jsonContent = await response
            .Content.ReadAsStringAsync(cancellationToken)
            .ConfigureAwait(false);

        var result =
            DeserializationValidation.DeserializeWithRequiredFieldValidation<global::Alohi.Signplus.Models.ListTemplateDocumentAnnotationsResponse>(
                jsonContent,
                _jsonSerializerOptions
            );

        // Validate the response
        var responseValidator = new ListTemplateDocumentAnnotationsResponseValidator();
        var responseValidationResult = responseValidator.ValidateRequired(result);
        if (!responseValidationResult.IsValid)
        {
            throw new Http.Exceptions.ValidationException(responseValidationResult.Errors);
        }

        return result;
    }

    /// <summary>Add template annotation</summary>
    /// <param name="templateId">ID of the template</param>
    public async global::System.Threading.Tasks.Task<global::Alohi.Signplus.Models.Annotation> AddTemplateAnnotationAsync(
        global::Alohi.Signplus.Models.AddAnnotationRequest input,
        string templateId,
        RequestConfig? requestConfig = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(input, nameof(input));
        ArgumentNullException.ThrowIfNull(templateId, nameof(templateId));
        var validationResults = new List<FluentValidation.Results.ValidationResult> { };
        var templateIdValidationResult = new StringValidator().ValidateRequired<string>(templateId);
        if (templateIdValidationResult != null)
        {
            validationResults.Add(templateIdValidationResult);
        }
        ;
        var validator = new AddAnnotationRequestValidator();
        var validationResult = validator.Validate(input);
        validationResults.Add(validationResult);

        var combinedFailures = validationResults.SelectMany(result => result.Errors).ToList();
        if (combinedFailures.Any())
        {
            throw new Http.Exceptions.ValidationException(combinedFailures);
        }

        var resolvedConfig = GetResolvedConfig(_addTemplateAnnotationAsyncConfig, requestConfig);

        var request = new RequestBuilder(HttpMethod.Post, "template/{template_id}/annotation")
            .SetPathParameter("template_id", templateId)
            .SetContentAsJson(input, _jsonSerializerOptions)
            .Build();

        var response = await ExecuteAsync(request, resolvedConfig, cancellationToken)
            .ConfigureAwait(false);

        // Custom deserialization with required field validation for JSON responses
        var jsonContent = await response
            .Content.ReadAsStringAsync(cancellationToken)
            .ConfigureAwait(false);

        var result =
            DeserializationValidation.DeserializeWithRequiredFieldValidation<global::Alohi.Signplus.Models.Annotation>(
                jsonContent,
                _jsonSerializerOptions
            );

        // Validate the response
        var responseValidator = new AnnotationValidator();
        var responseValidationResult = responseValidator.ValidateRequired(result);
        if (!responseValidationResult.IsValid)
        {
            throw new Http.Exceptions.ValidationException(responseValidationResult.Errors);
        }

        return result;
    }

    /// <summary>Delete template annotation</summary>
    /// <param name="templateId">ID of the template</param>
    /// <param name="annotationId">ID of the annotation to delete</param>
    public async global::System.Threading.Tasks.Task DeleteTemplateAnnotationAsync(
        string templateId,
        string annotationId,
        RequestConfig? requestConfig = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(templateId, nameof(templateId));
        ArgumentNullException.ThrowIfNull(annotationId, nameof(annotationId));
        var validationResults = new List<FluentValidation.Results.ValidationResult> { };
        var templateIdValidationResult = new StringValidator().ValidateRequired<string>(templateId);
        if (templateIdValidationResult != null)
        {
            validationResults.Add(templateIdValidationResult);
        }
        ;
        var annotationIdValidationResult = new StringValidator().ValidateRequired<string>(
            annotationId
        );
        if (annotationIdValidationResult != null)
        {
            validationResults.Add(annotationIdValidationResult);
        }

        var combinedFailures = validationResults.SelectMany(result => result.Errors).ToList();
        if (combinedFailures.Any())
        {
            throw new Http.Exceptions.ValidationException(combinedFailures);
        }

        var resolvedConfig = GetResolvedConfig(_deleteTemplateAnnotationAsyncConfig, requestConfig);

        var request = new RequestBuilder(
            HttpMethod.Delete,
            "template/{template_id}/annotation/{annotation_id}"
        )
            .SetPathParameter("template_id", templateId)
            .SetPathParameter("annotation_id", annotationId)
            .Build();

        var response = await ExecuteAsync(request, resolvedConfig, cancellationToken)
            .ConfigureAwait(false);
    }

    /// <summary>Set template attachment settings</summary>
    public async global::System.Threading.Tasks.Task<global::Alohi.Signplus.Models.EnvelopeAttachments> SetTemplateAttachmentsSettingsAsync(
        global::Alohi.Signplus.Models.SetEnvelopeAttachmentsSettingsRequest input,
        string templateId,
        RequestConfig? requestConfig = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(input, nameof(input));
        ArgumentNullException.ThrowIfNull(templateId, nameof(templateId));
        var validationResults = new List<FluentValidation.Results.ValidationResult> { };
        var templateIdValidationResult = new StringValidator().ValidateRequired<string>(templateId);
        if (templateIdValidationResult != null)
        {
            validationResults.Add(templateIdValidationResult);
        }
        ;
        var validator = new SetEnvelopeAttachmentsSettingsRequestValidator();
        var validationResult = validator.Validate(input);
        validationResults.Add(validationResult);

        var combinedFailures = validationResults.SelectMany(result => result.Errors).ToList();
        if (combinedFailures.Any())
        {
            throw new Http.Exceptions.ValidationException(combinedFailures);
        }

        var resolvedConfig = GetResolvedConfig(
            _setTemplateAttachmentsSettingsAsyncConfig,
            requestConfig
        );

        var request = new RequestBuilder(
            HttpMethod.Put,
            "template/{template_id}/attachments/settings"
        )
            .SetPathParameter("template_id", templateId)
            .SetContentAsJson(input, _jsonSerializerOptions)
            .Build();

        var response = await ExecuteAsync(request, resolvedConfig, cancellationToken)
            .ConfigureAwait(false);

        // Custom deserialization with required field validation for JSON responses
        var jsonContent = await response
            .Content.ReadAsStringAsync(cancellationToken)
            .ConfigureAwait(false);

        var result =
            DeserializationValidation.DeserializeWithRequiredFieldValidation<global::Alohi.Signplus.Models.EnvelopeAttachments>(
                jsonContent,
                _jsonSerializerOptions
            );

        // Validate the response
        var responseValidator = new EnvelopeAttachmentsValidator();
        var responseValidationResult = responseValidator.ValidateRequired(result);
        if (!responseValidationResult.IsValid)
        {
            throw new Http.Exceptions.ValidationException(responseValidationResult.Errors);
        }

        return result;
    }

    /// <summary>Placeholders to be set, completely replacing the existing ones.</summary>
    public async global::System.Threading.Tasks.Task<global::Alohi.Signplus.Models.EnvelopeAttachments> SetTemplateAttachmentsPlaceholdersAsync(
        global::Alohi.Signplus.Models.SetEnvelopeAttachmentsPlaceholdersRequest input,
        string templateId,
        RequestConfig? requestConfig = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(input, nameof(input));
        ArgumentNullException.ThrowIfNull(templateId, nameof(templateId));
        var validationResults = new List<FluentValidation.Results.ValidationResult> { };
        var templateIdValidationResult = new StringValidator().ValidateRequired<string>(templateId);
        if (templateIdValidationResult != null)
        {
            validationResults.Add(templateIdValidationResult);
        }
        ;
        var validator = new SetEnvelopeAttachmentsPlaceholdersRequestValidator();
        var validationResult = validator.Validate(input);
        validationResults.Add(validationResult);

        var combinedFailures = validationResults.SelectMany(result => result.Errors).ToList();
        if (combinedFailures.Any())
        {
            throw new Http.Exceptions.ValidationException(combinedFailures);
        }

        var resolvedConfig = GetResolvedConfig(
            _setTemplateAttachmentsPlaceholdersAsyncConfig,
            requestConfig
        );

        var request = new RequestBuilder(
            HttpMethod.Put,
            "template/{template_id}/attachments/placeholders"
        )
            .SetPathParameter("template_id", templateId)
            .SetContentAsJson(input, _jsonSerializerOptions)
            .Build();

        var response = await ExecuteAsync(request, resolvedConfig, cancellationToken)
            .ConfigureAwait(false);

        // Custom deserialization with required field validation for JSON responses
        var jsonContent = await response
            .Content.ReadAsStringAsync(cancellationToken)
            .ConfigureAwait(false);

        var result =
            DeserializationValidation.DeserializeWithRequiredFieldValidation<global::Alohi.Signplus.Models.EnvelopeAttachments>(
                jsonContent,
                _jsonSerializerOptions
            );

        // Validate the response
        var responseValidator = new EnvelopeAttachmentsValidator();
        var responseValidationResult = responseValidator.ValidateRequired(result);
        if (!responseValidationResult.IsValid)
        {
            throw new Http.Exceptions.ValidationException(responseValidationResult.Errors);
        }

        return result;
    }

    /// <summary>Create webhook</summary>
    public async global::System.Threading.Tasks.Task<global::Alohi.Signplus.Models.Webhook> CreateWebhookAsync(
        global::Alohi.Signplus.Models.CreateWebhookRequest input,
        RequestConfig? requestConfig = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(input, nameof(input));
        var validationResults = new List<FluentValidation.Results.ValidationResult> { };
        var validator = new CreateWebhookRequestValidator();
        var validationResult = validator.Validate(input);
        validationResults.Add(validationResult);

        var combinedFailures = validationResults.SelectMany(result => result.Errors).ToList();
        if (combinedFailures.Any())
        {
            throw new Http.Exceptions.ValidationException(combinedFailures);
        }

        var resolvedConfig = GetResolvedConfig(_createWebhookAsyncConfig, requestConfig);

        var request = new RequestBuilder(HttpMethod.Post, "webhook")
            .SetContentAsJson(input, _jsonSerializerOptions)
            .Build();

        var response = await ExecuteAsync(request, resolvedConfig, cancellationToken)
            .ConfigureAwait(false);

        // Custom deserialization with required field validation for JSON responses
        var jsonContent = await response
            .Content.ReadAsStringAsync(cancellationToken)
            .ConfigureAwait(false);

        var result =
            DeserializationValidation.DeserializeWithRequiredFieldValidation<global::Alohi.Signplus.Models.Webhook>(
                jsonContent,
                _jsonSerializerOptions
            );

        // Validate the response
        var responseValidator = new WebhookValidator();
        var responseValidationResult = responseValidator.ValidateRequired(result);
        if (!responseValidationResult.IsValid)
        {
            throw new Http.Exceptions.ValidationException(responseValidationResult.Errors);
        }

        return result;
    }

    /// <summary>List webhooks</summary>
    public async global::System.Threading.Tasks.Task<global::Alohi.Signplus.Models.ListWebhooksResponse> ListWebhooksAsync(
        global::Alohi.Signplus.Models.ListWebhooksRequest input,
        RequestConfig? requestConfig = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(input, nameof(input));
        var validationResults = new List<FluentValidation.Results.ValidationResult> { };
        var validator = new ListWebhooksRequestValidator();
        var validationResult = validator.Validate(input);
        validationResults.Add(validationResult);

        var combinedFailures = validationResults.SelectMany(result => result.Errors).ToList();
        if (combinedFailures.Any())
        {
            throw new Http.Exceptions.ValidationException(combinedFailures);
        }

        var resolvedConfig = GetResolvedConfig(_listWebhooksAsyncConfig, requestConfig);

        var request = new RequestBuilder(HttpMethod.Post, "webhooks")
            .SetContentAsJson(input, _jsonSerializerOptions)
            .Build();

        var response = await ExecuteAsync(request, resolvedConfig, cancellationToken)
            .ConfigureAwait(false);

        // Custom deserialization with required field validation for JSON responses
        var jsonContent = await response
            .Content.ReadAsStringAsync(cancellationToken)
            .ConfigureAwait(false);

        var result =
            DeserializationValidation.DeserializeWithRequiredFieldValidation<global::Alohi.Signplus.Models.ListWebhooksResponse>(
                jsonContent,
                _jsonSerializerOptions
            );

        // Validate the response
        var responseValidator = new ListWebhooksResponseValidator();
        var responseValidationResult = responseValidator.ValidateRequired(result);
        if (!responseValidationResult.IsValid)
        {
            throw new Http.Exceptions.ValidationException(responseValidationResult.Errors);
        }

        return result;
    }

    /// <summary>Delete webhook</summary>
    public async global::System.Threading.Tasks.Task DeleteWebhookAsync(
        string webhookId,
        RequestConfig? requestConfig = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(webhookId, nameof(webhookId));
        var validationResults = new List<FluentValidation.Results.ValidationResult> { };
        var webhookIdValidationResult = new StringValidator().ValidateRequired<string>(webhookId);
        if (webhookIdValidationResult != null)
        {
            validationResults.Add(webhookIdValidationResult);
        }

        var combinedFailures = validationResults.SelectMany(result => result.Errors).ToList();
        if (combinedFailures.Any())
        {
            throw new Http.Exceptions.ValidationException(combinedFailures);
        }

        var resolvedConfig = GetResolvedConfig(_deleteWebhookAsyncConfig, requestConfig);

        var request = new RequestBuilder(HttpMethod.Delete, "webhook/{webhook_id}")
            .SetPathParameter("webhook_id", webhookId)
            .Build();

        var response = await ExecuteAsync(request, resolvedConfig, cancellationToken)
            .ConfigureAwait(false);
    }
}
