using System;
using System.Collections.Generic;

namespace Hybrid.ai.Geoposition.Common.Models.BaseModels
{
    public class CustomException : Exception
    {
        public List<CustomErrors> Errors { get; set; }

        public CustomException(ResponseCodes responseCode, string errorMessage, int? batchId = null)
        {
            if (Errors == null)
                Errors = new List<CustomErrors>();
			
            Errors.Add(new CustomErrors
            {
                ResponseCode = responseCode,
                ResultMessage = errorMessage,
                BatchId = batchId
            });
        }
        public CustomException(IEnumerable<CustomErrors> errors)
        {
            if (Errors == null)
                Errors = new List<CustomErrors>();
            
            Errors.AddRange(errors);
        }
    }
}