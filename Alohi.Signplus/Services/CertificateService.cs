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
/// Service class providing access to API endpoints for CertificateService.
/// Inherits HTTP client management, JSON serialization, and streaming capabilities from the base service.
/// Each method corresponds to an API operation and handles request building, execution, and response parsing.
/// </summary>
public class CertificateService : BaseService
{
    private RequestConfig? _downloadEnvelopeCertificateAsyncConfig;

    internal CertificateService(Client httpClient)
        : base(httpClient) { }

    /// <summary>
    /// Sets method-level configuration for <c>DownloadEnvelopeCertificateAsync</c>.
    /// Method-level config overrides service-level config but is overridden by per-request config.
    /// </summary>
    public CertificateService SetDownloadEnvelopeCertificateAsyncConfig(RequestConfig config)
    {
        _downloadEnvelopeCertificateAsyncConfig = config;
        return this;
    }

    /// <summary>Download certificate of completion for an envelope</summary>
    public async Task<object> DownloadEnvelopeCertificateAsync(
        string envelopeId,
        string? accept,
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
            _downloadEnvelopeCertificateAsyncConfig,
            requestConfig
        );

        var request = new RequestBuilder(HttpMethod.Get, "envelope/{envelope_id}/certificate")
            .SetPathParameter("envelope_id", envelopeId)
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
