namespace PurchasingV1Web.Models
{
    public class ErrorViewModel
    {
        public string? RequestId { get; set; }

        public bool IsRequestIdAvailable => !string.IsNullOrEmpty(RequestId);

        public string Message { get; set; }

        public int? StatusCode { get; set; }

        public bool ShowRequestId { get; set; } = false; // Varsayýlan deðeri false olarak ayarlayýn
    }
}