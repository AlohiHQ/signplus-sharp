using Alohi.Signplus.Config;
using Alohi.Signplus.Http;
using Alohi.Signplus.Http.Extensions;
using Alohi.Signplus.Http.Handlers;
using Alohi.Signplus.Services;
using Environment = Alohi.Signplus.Http.Environment;

namespace Alohi.Signplus;

/// <summary>
/// The main SDK client that provides access to all service endpoints.
/// Manages HTTP client lifecycle, authentication handlers, and service instances with centralized configuration.
/// Implements IDisposable to properly clean up HTTP resources.
/// </summary>
public class SignplusClient : IDisposable
{
    private readonly Client _httpClient;

    private readonly TokenHandler _accessTokenHandler;

    public TemplateIdService TemplateId { get; private set; }
    public SignedDocumentsService SignedDocuments { get; private set; }
    public CertificateService Certificate { get; private set; }
    public DocumentIdService DocumentId { get; private set; }
    public DocumentService Document { get; private set; }
    public DocumentsService Documents { get; private set; }
    public DynamicFieldsService DynamicFields { get; private set; }
    public SigningStepsService SigningSteps { get; private set; }
    public SettingsService Settings { get; private set; }
    public PlaceholdersService Placeholders { get; private set; }
    public FileIdService FileId { get; private set; }
    public SendService Send { get; private set; }
    public DuplicateService Duplicate { get; private set; }
    public VoidService Void_ { get; private set; }
    public RenameService Rename { get; private set; }
    public SetCommentService SetComment { get; private set; }
    public SetNotificationService SetNotification { get; private set; }
    public SetExpirationDateService SetExpirationDate { get; private set; }
    public SetLegalityLevelService SetLegalityLevel { get; private set; }
    public EnvelopeEnvelopeIdAnnotationsDocumentIdService EnvelopeEnvelopeIdAnnotationsDocumentId
    {
        get;
        private set;
    }
    public AnnotationsService Annotations { get; private set; }
    public AnnotationIdService AnnotationId { get; private set; }
    public AnnotationService Annotation { get; private set; }
    public EnvelopeIdService EnvelopeId { get; private set; }
    public EnvelopeService Envelope { get; private set; }
    public EnvelopesService Envelopes { get; private set; }
    public TemplateTemplateIdDuplicateService TemplateTemplateIdDuplicate { get; private set; }
    public TemplateTemplateIdDocumentDocumentIdService TemplateTemplateIdDocumentDocumentId
    {
        get;
        private set;
    }
    public TemplateTemplateIdDocumentService TemplateTemplateIdDocument { get; private set; }
    public TemplateTemplateIdDocumentsService TemplateTemplateIdDocuments { get; private set; }
    public TemplateTemplateIdSigningStepsService TemplateTemplateIdSigningSteps
    {
        get;
        private set;
    }
    public TemplateTemplateIdRenameService TemplateTemplateIdRename { get; private set; }
    public TemplateTemplateIdSetCommentService TemplateTemplateIdSetComment { get; private set; }
    public TemplateTemplateIdSetNotificationService TemplateTemplateIdSetNotification
    {
        get;
        private set;
    }
    public TemplateTemplateIdAnnotationsDocumentIdService TemplateTemplateIdAnnotationsDocumentId
    {
        get;
        private set;
    }
    public TemplateTemplateIdAnnotationsService TemplateTemplateIdAnnotations { get; private set; }
    public TemplateTemplateIdAnnotationAnnotationIdService TemplateTemplateIdAnnotationAnnotationId
    {
        get;
        private set;
    }
    public TemplateTemplateIdAnnotationService TemplateTemplateIdAnnotation { get; private set; }
    public TemplateTemplateIdAttachmentsSettingsService TemplateTemplateIdAttachmentsSettings
    {
        get;
        private set;
    }
    public TemplateTemplateIdAttachmentsPlaceholdersService TemplateTemplateIdAttachmentsPlaceholders
    {
        get;
        private set;
    }
    public TemplateTemplateIdService TemplateTemplateId { get; private set; }
    public TemplateService Template { get; private set; }
    public TemplatesService Templates { get; private set; }
    public WebhookIdService WebhookId { get; private set; }
    public WebhookService Webhook { get; private set; }
    public WebhooksService Webhooks { get; private set; }

    /// <summary>Initializes a new instance of the SignplusClient client.</summary>
    /// <param name="config">SDK configuration options.</param>
    public SignplusClient(SignplusConfig? config = null)
    {
        var retryHandler = new RetryHandler();
        _accessTokenHandler = new TokenHandler(retryHandler)
        {
            Header = "Authorization",
            Prefix = "Bearer",
            Token = config?.AccessToken,
            OverrideTokenOptionsKey = "_RequestConfig_OverrideAccessToken",
        };

        _httpClient = new Client(config, _accessTokenHandler);

        TemplateId = new TemplateIdService(_httpClient);
        SignedDocuments = new SignedDocumentsService(_httpClient);
        Certificate = new CertificateService(_httpClient);
        DocumentId = new DocumentIdService(_httpClient);
        Document = new DocumentService(_httpClient);
        Documents = new DocumentsService(_httpClient);
        DynamicFields = new DynamicFieldsService(_httpClient);
        SigningSteps = new SigningStepsService(_httpClient);
        Settings = new SettingsService(_httpClient);
        Placeholders = new PlaceholdersService(_httpClient);
        FileId = new FileIdService(_httpClient);
        Send = new SendService(_httpClient);
        Duplicate = new DuplicateService(_httpClient);
        Void_ = new VoidService(_httpClient);
        Rename = new RenameService(_httpClient);
        SetComment = new SetCommentService(_httpClient);
        SetNotification = new SetNotificationService(_httpClient);
        SetExpirationDate = new SetExpirationDateService(_httpClient);
        SetLegalityLevel = new SetLegalityLevelService(_httpClient);
        EnvelopeEnvelopeIdAnnotationsDocumentId =
            new EnvelopeEnvelopeIdAnnotationsDocumentIdService(_httpClient);
        Annotations = new AnnotationsService(_httpClient);
        AnnotationId = new AnnotationIdService(_httpClient);
        Annotation = new AnnotationService(_httpClient);
        EnvelopeId = new EnvelopeIdService(_httpClient);
        Envelope = new EnvelopeService(_httpClient);
        Envelopes = new EnvelopesService(_httpClient);
        TemplateTemplateIdDuplicate = new TemplateTemplateIdDuplicateService(_httpClient);
        TemplateTemplateIdDocumentDocumentId = new TemplateTemplateIdDocumentDocumentIdService(
            _httpClient
        );
        TemplateTemplateIdDocument = new TemplateTemplateIdDocumentService(_httpClient);
        TemplateTemplateIdDocuments = new TemplateTemplateIdDocumentsService(_httpClient);
        TemplateTemplateIdSigningSteps = new TemplateTemplateIdSigningStepsService(_httpClient);
        TemplateTemplateIdRename = new TemplateTemplateIdRenameService(_httpClient);
        TemplateTemplateIdSetComment = new TemplateTemplateIdSetCommentService(_httpClient);
        TemplateTemplateIdSetNotification = new TemplateTemplateIdSetNotificationService(
            _httpClient
        );
        TemplateTemplateIdAnnotationsDocumentId =
            new TemplateTemplateIdAnnotationsDocumentIdService(_httpClient);
        TemplateTemplateIdAnnotations = new TemplateTemplateIdAnnotationsService(_httpClient);
        TemplateTemplateIdAnnotationAnnotationId =
            new TemplateTemplateIdAnnotationAnnotationIdService(_httpClient);
        TemplateTemplateIdAnnotation = new TemplateTemplateIdAnnotationService(_httpClient);
        TemplateTemplateIdAttachmentsSettings = new TemplateTemplateIdAttachmentsSettingsService(
            _httpClient
        );
        TemplateTemplateIdAttachmentsPlaceholders =
            new TemplateTemplateIdAttachmentsPlaceholdersService(_httpClient);
        TemplateTemplateId = new TemplateTemplateIdService(_httpClient);
        Template = new TemplateService(_httpClient);
        Templates = new TemplatesService(_httpClient);
        WebhookId = new WebhookIdService(_httpClient);
        Webhook = new WebhookService(_httpClient);
        Webhooks = new WebhooksService(_httpClient);
    }

    /// <summary>
    /// Set the environment for the entire SDK.
    /// </summary>
    public void SetEnvironment(Environment environment)
    {
        SetBaseUrl(environment.Uri);
    }

    /// <summary>
    /// Sets the base URL for the entire SDK.
    /// </summary>
    public void SetBaseUrl(string baseUrl)
    {
        SetBaseUrl(new Uri(baseUrl));
    }

    /// <summary>
    /// Sets the base URL for the entire SDK.
    /// </summary>
    public void SetBaseUrl(Uri uri)
    {
        _httpClient.SetBaseAddress(uri.EnsureTrailingSlash());
    }

    /// <summary>
    /// Sets the timeout for the entire SDK.
    /// </summary>
    /// <param name="timeout">The timeout value. Must be a positive TimeSpan or Timeout.InfiniteTimeSpan.</param>
    /// <exception cref="ArgumentOutOfRangeException">Thrown if the timeout is not valid.</exception>
    public void SetTimeout(TimeSpan timeout)
    {
        if (timeout <= TimeSpan.Zero && timeout != Timeout.InfiniteTimeSpan)
        {
            throw new ArgumentOutOfRangeException(
                nameof(timeout),
                "Timeout must be a positive value or Timeout.InfiniteTimeSpan."
            );
        }

        _httpClient.SetTimeout(timeout);
    }

    /// <summary>
    /// Sets the access token for the entire SDK.
    /// </summary>
    public void SetAccessToken(string token)
    {
        _accessTokenHandler.Token = token;
    }

    public void Dispose()
    {
        _httpClient.Dispose();
    }
}

// c029837e0e474b76bc487506e8799df5e3335891efe4fb02bda7a1441840310c
