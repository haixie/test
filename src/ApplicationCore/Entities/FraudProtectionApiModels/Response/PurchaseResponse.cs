// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.

using System.Text.Json.Serialization;

namespace Contoso.FraudProtection.ApplicationCore.Entities.FraudProtectionApiModels
{
    public class PurchaseResponse
    {
        [JsonPropertyName("resultDetails")]
        public PurchaseResultDetails ResultDetails { get; set; }
    }

    public class PurchaseResultDetails : BaseAssessmentResponse
    {
        public string MIDFlag { get; set; }
        public string PolicyApplied { get; set; }
    }
}
