using System;
using todogiraldo.Functions.Functions;
using todogiraldo.Test.Helpers;
using Xunit;

namespace todogiraldo.Test.Test
{
    public class ScheduledFuctionTest
    {

        [Fact]
        public void ScheduledFuction_Should_Log_Message()
        {
            // Arrange
            MockCloudTableTodos mockTodos = new MockCloudTableTodos(new Uri("http://127.0.0.1:10002/devstoreaccount1/reports"));
            ListLogger logger = (ListLogger)TestFactory.CreateLogger(LoggerTypes.List);

            // Add
            ScheduleFunction.Run(null, mockTodos, logger);
            string message = logger.Logs[0];

            // Assert
            Assert.Contains("Deleting completed", message);
        }
    }
}
