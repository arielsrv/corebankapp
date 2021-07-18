using System.Collections.Generic;
using Bank.Services;
using Moq;
using NUnit.Framework;

namespace Bank.Test
{
    public class RateServiceTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GetRates()
        {
            Mock<IRateClient> rateClient = new();
            rateClient.Setup(client => client.GetRates()).ReturnsAsync(GetListResponse());

            IRateService rateService = new RateService(rateClient.Object);

            List<RateDto> expected = rateService.GetRates().Result;

            Assert.AreEqual(4, expected.Count);
        }

        private List<RateResponse> GetListResponse()
        {
            List<RateResponse> responses = new();

            RateResponse rate1 = new RateResponse
            {
                From = "EUR",
                To = "USD",
                Rate = 1.359
            };

            RateResponse rate2 = new RateResponse
            {
                From = "CAD",
                To = "EUR",
                Rate = 0.732
            };

            RateResponse rate3 = new RateResponse
            {
                From = "USD",
                To = "EUR",
                Rate = 0.736
            };

            RateResponse rate4 = new RateResponse
            {
                From = "EUR",
                To = "CAD",
                Rate = 1.366
            };

            responses.Add(rate1);
            responses.Add(rate2);
            responses.Add(rate3);
            responses.Add(rate4);

            return responses;
        }
    }
}