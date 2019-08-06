using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace SampleREST.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ScoringController : ControllerBase
    {
        public class Inbound
        {
            public long AceId { get; set; }
            public Guid TransactionKey { get; set; }
            public Guid TransactionSubkey { get; set; }
            public string WorkflowID { get; set; }
            public IDictionary<string, string> Variables { get; set; } = new Dictionary<string, string>();
        }
        public class Outbound
        {
            public long AceId { get; set; }
            public long LiveScoreLogId { get; set; }
            public double PdScore { get; set; }
            public decimal LoanAmount { get; set; }
            public IDictionary<string, string> AdverseActionReasons { get; set; } = new Dictionary<string, string>();
        }
        public static readonly Random _random = new Random();
        // POST: api/Scoring
        [HttpPost]
        [ProducesResponseType(typeof(Outbound), 200)]
        public IActionResult Post([FromBody] Inbound value)
        {
            var result = new Outbound
            {
                AceId = DateTime.Now.Ticks,
                LiveScoreLogId = DateTime.UtcNow.Ticks,
                PdScore = _random.NextDouble(),
                LoanAmount = _random.Next(10000, 100000) / 100.0m,
            };
            if (result.PdScore > 0.5)
            {
                for(int i = 0; i < _random.Next(1,4); i++)
                {
                    result.AdverseActionReasons[$"Reason {i}"] = $"Adding {Guid.NewGuid()} as a reason at {DateTime.UtcNow}";
                }
            }
            return Ok(result);
        }
    }
}
