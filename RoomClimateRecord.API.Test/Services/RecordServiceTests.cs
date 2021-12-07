using System.Collections.Generic;
using System.Linq;
using Moq;
using Xunit;
using RoomClimateRecord.API.Services;
using Tynamix.ObjectFiller;
using RoomClimateRecord.API.Brokers;
using FluentAssertions;

namespace RoomClimateRecord.API.Test;

public class RecordServiceTests
{
    private readonly IRecordService recordService;
    private readonly Mock<IStorageBroker> storageBroker;


    public RecordServiceTests()
    {
        this.storageBroker =  new Mock<IStorageBroker>();
        this.recordService = new RecordService(
            storageBroker: this.storageBroker.Object);
    }

    public IQueryable<Models.Record> CreateCollectionOfRecords ()
    {
        return new Filler<Models.Record>()
                        .Create(new IntRange(min: 2, max: 10).GetValue())
                            .AsQueryable();
    }

    public Models.Record CreateRecord ()
    {
        return new Filler<Models.Record>().Create();
    }

    [Fact]
    public void TestGetAllRecordData()
    {
        //Given
        IQueryable<Models.Record> generatedBrokerData = CreateCollectionOfRecords();
        IQueryable<Models.Record> expectedData = generatedBrokerData;  
            
        this.storageBroker.Setup(broker =>
            broker.GetAllRecords())
            .Returns(generatedBrokerData);

        //When
        IQueryable<Models.Record> actualServiceData = 
            this.recordService.GetAllRecordData();
        
        //Then
        actualServiceData.Should().
            BeEquivalentTo(expectedData,
            because: "Returned data should be the same as broker Records.");

        this.storageBroker.Verify(broke =>
            broke.GetAllRecords(), 
            Times.Once, 
            "Storage broker should be call once.");

    }
}