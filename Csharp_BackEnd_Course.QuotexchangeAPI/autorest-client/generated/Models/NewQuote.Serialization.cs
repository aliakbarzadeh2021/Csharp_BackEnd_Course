// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace QuotexchangeAPI.Models
{
    public partial class NewQuote : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("quote");
            writer.WriteStringValue(Quote);
            writer.WritePropertyName("source");
            writer.WriteStringValue(Source);
            writer.WriteEndObject();
        }
    }
}
