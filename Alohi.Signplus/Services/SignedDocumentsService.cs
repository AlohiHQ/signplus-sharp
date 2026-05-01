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
/// Service class providing access to API endpoints for SignedDocumentsService.
/// Inherits HTTP client management, JSON serialization, and streaming capabilities from the base service.
/// Each method corresponds to an API operation and handles request building, execution, and response parsing.
/// </summary>
public class SignedDocumentsService : BaseService
{
    private RequestConfig? _downloadEnvelopeSignedDocumentsAsyncConfig;

    internal SignedDocumentsService(Client httpClient)
        : base(httpClient) { }

    /// <summary>
    /// Sets method-level configuration for <c>DownloadEnvelopeSignedDocumentsAsync</c>.
    /// Method-level config overrides service-level config but is overridden by per-request config.
    /// </summary>
    public SignedDocumentsService SetDownloadEnvelopeSignedDocumentsAsyncConfig(
        RequestConfig config
    )
    {
        _downloadEnvelopeSignedDocumentsAsyncConfig = config;
        return this;
    }

    /// <summary>Download signed documents for an envelope</summary>
    /// <param name="certificateOfCompletion">Whether to include the certificate of completion in the downloaded file</param>
    public async Task<object> DownloadEnvelopeSignedDocumentsAsync(
        string envelopeId,
        string? accept,
        string? certificateOfCompletion = null,
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
            _downloadEnvelopeSignedDocumentsAsyncConfig,
            requestConfig
        );

        var request = new RequestBuilder(HttpMethod.Get, "envelope/{envelope_id}/signed_documents")
            .SetPathParameter("envelope_id", envelopeId)
            .SetHeader("Accept", accept)
            .SetQueryParameter("certificate_of_completion", certificateOfCompletion)
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
