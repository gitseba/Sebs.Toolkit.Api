using Sebs.Toolkit.Api.Helpers;
using Sebs.Toolkit.Api.UnitTests.Models;

namespace Sebs.Toolkit.Api.UnitTests.Helpers
{
    /// <summary>
    /// Purpose: 
    /// Created by: sebde
    /// Created at: 5/28/2023 9:20:17 PM
    /// </summary>
    public class ApiHelperTests
    {
        [Theory]
        [InlineData("https://official-joke-api.appspot.com/random_joke")]
        public async Task Should_Return_From_Api_An_Object_Model(string url)
        {
            var result = await ApiHelper
                .GetDataFromAsync<OfficialJokeModel>(url);

            Assert.NotNull(result.model);
        }
    }
}
