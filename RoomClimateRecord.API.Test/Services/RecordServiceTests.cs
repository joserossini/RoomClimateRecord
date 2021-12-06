using System.Collections.Generic;
using System.Linq;
using Moq;
using Xunit;
using RoomClimateRecord.API.Services;
using Tynamix.ObjectFiller;

namespace RoomClimateRecord.API.Test;

public class RecordServiceTests
{
    private readonly Mock<IRecordService> RecordServiceMock;

    public RecordServiceTests()
    {
        this.RecordServiceMock = new Mock<IRecordService>();
    }

    [Fact]
    public void TestGetAllRecordData()
    {
        //Given
        var recordFiller = new Filler<Record>();
        IEnumerable<Record> listOfRecords = recordFiller.Create(5);

        //When

        //Then

    }
}