using Data.Entities;

namespace Business.Models
{
    public class TableOrderModel
    {
        public int Id { get; set; }
        public TimeOnly TimeBegin { get; set; }
        public TimeOnly TimeEnd { get; set; }
        public string Name { get; set; }
        public TableZone Zone { get; set; }

    }
}
