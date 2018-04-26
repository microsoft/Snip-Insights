// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.
using SnipInsight.AIServices.AIModels;
namespace SnipInsight.AIServices.AILogic
{
    /// <summary>
    /// Printed Text OCR call
    /// </summary>
    class PrintedTextHandler : CloudService<PrintedModel>
    {
        /// <summary>
        /// Initalizes handler with correct endpoint
        /// </summary>
        public PrintedTextHandler(string keyFile) : base(keyFile)
        {
            Host = "westcentralus.api.cognitive.microsoft.com";
            Endpoint = "vision/v1.0/ocr";
            RequestParams = "language=unk&detectOrientation=true";
        }
    }
}
