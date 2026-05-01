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
/// Service class providing access to API endpoints for WebhookIdService.
/// Inherits HTTP client management, JSON serialization, and streaming capabilities from the base service.
/// Each method corresponds to an API operation and handles request building, execution, and response parsing.
/// </summary>
public class WebhookIdService : BaseService
{
    private RequestConfig? _deleteWebhookAsyncConfig;

    internal WebhookIdService(Client httpClient)
        : base(httpClient) { }

    /// <summary>
    /// Sets method-level configuration for <c>DeleteWebhookAsync</c>.
    /// Method-level config overrides service-level config but is overridden by per-request config.
    /// </summary>
    public WebhookIdService SetDeleteWebhookAsyncConfig(RequestConfig config)
    {
        _deleteWebhookAsyncConfig = config;
        return this;
    }

    /// <summary>Delete webhook</summary>
    public async Task<object> DeleteWebhookAsync(
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
