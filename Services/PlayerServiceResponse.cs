using System.Collections.Generic;

namespace Services
{
    public class PlayerServiceResponse
    {
        
            public List<string> Notifications { get; set; }
            public bool Success { get; set; }
            public string ErrorMessage { get; set; }
            public string ErrorCode { get; set; }
            public decimal BasketTotal { get; set; }
        
    }
}