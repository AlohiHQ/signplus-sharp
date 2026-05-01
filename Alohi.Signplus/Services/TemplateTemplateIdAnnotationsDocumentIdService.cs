using System.Net.Http.Json;
using Alohi.Signplus.Config;
using Alohi.Signplus.Http;
using Alohi.Signplus.Http.Exceptions;
using Alohi.Signplus.Http.Extensions;
using Alohi.Signplus.Http.Handlers;
using Alohi.Signplus.Http.Serialization;
using Alohi.Signplus.Validation;
using Alohi.Signplus.Validation.Extensions;

namespace Alohi.Signplus.Services;

/// <summary>
/// Service class providing access to API endpoints for TemplateTemplateIdAnnotationsDocumentIdService.
/// Inherits HTTP client management, JSON serialization, and streaming capabilities from the base service.
/// Each method corresponds to an API operation and handles request building, execution, and response parsing.
/// </summary>
public class TemplateTemplateIdAnnotationsDocumentIdService : BaseService
{
    private RequestConfig? _getDocumentTemplateAnnotationsAsyncConfig;

    internal TemplateTemplateIdAnnotationsDocumentIdService(Client httpClient)
        : base(httpClient) { }

    /// <summary>
    /// Sets method-level configuration for <c>GetDocumentTemplateAnnotationsAsync</c>.
    /// Method-level config overrides service-level config but is overridden by per-request config.
    /// </summary>
    public TemplateTemplateIdAnnotationsDocumentIdService SetGetDocumentTemplateAnnotationsAsyncConfig(
        RequestConfig config
    )
    {
        _getDocumentTemplateAnnotationsAsyncConfig = config;
        return this;
    }

    /// <summary>Get document template annotations</summary>
    public async Task<object> GetDocumentTemplateAnnotationsAsync(
        string templateId,
        string documentId,
        string? accept,
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
        ;
        var acceptValidationResult = new StringValidator().ValidateRequired<string>(accept);
        if (acceptValidationResult != null)
        {
            validationResults.Add(acceptValidationResult);
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
            .SetHeader("Accept", accept)
            .Build();

        var response = await ExecuteAsync(request, resolvedConfig, cancellationToken)
            .ConfigureAwait(false);

        // Custom deserialization with required field validation for JSON responses
        var jsonContent = await response
            .Content.ReadAsStringAsync(cancellationToken)
            .ConfigureAwait(false);

        var result = DeserializationValidation.DeserializeWithRequiredFieldValidation<object>(
            jsonContent,
            _jsonSerializerOptions
        );

        // Validate the response
        // Skip validation for primitive types or OneOf types

        return result;
    }
}
