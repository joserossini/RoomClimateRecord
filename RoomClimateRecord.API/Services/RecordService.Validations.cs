using RoomClimateRecord.API.Models;
using FluentValidation;

namespace RoomClimateRecord.API.Services
{

    public partial class RecordService : IRecordService
    {
        public class RecordValidator : AbstractValidator<Record>
        {
            public RecordValidator()
            {
                RuleFor(record => record).NotNull();
                RuleFor(Record => Record.Id).NotEmpty();
                RuleFor(Record => Record.Stamp).NotEmpty();
                RuleFor(Record => Record).Must(HaveAtLeastOneReading).WithMessage("Record Must have at least one valid reading");
            }

            private bool HaveAtLeastOneReading(Record record)
            {
                if(record.Humidity is null 
                    & record.Motion is null 
                        & record.Temperature is null)
                    return false;
                else
                return true;
            }

        }
    }
}   