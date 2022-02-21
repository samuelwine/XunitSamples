   [Fact]
    public async void GivenEmptyStringResponseThrowsJsonException()
    {
        var sut = new Rubystone_GetAccountsService(SetupHttpClientFactory(), new Mock<ILogger>().Object);
        Func<Task> func = async () => await sut.GetAccountsWithPins("1234");
        await Assert.ThrowsAsync<JsonException>(func);
    }
