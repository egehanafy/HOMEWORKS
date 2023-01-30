using NetECommerce.Entity.Enum;
using NetECommerce.Entity.Interface;
using System;

namespace NetECommerce.Entity.Base
{
    public class BaseEntity : IEntity<Guid>
    {
        public BaseEntity()
        {
            IsActive = true;
            Status = Status.Inserted;
            CreatedDate = DateTime.Now;
        }
        public int Id { get ; set ; }
        public Guid MasterId { get ; set ; }
        //todo: Master Id doldurulacak.
        public DateTime CreatedDate { get ; set ; }
        public string CreatedComputerName { get ; set ; }
        //todo: Bilgisatar adı veri eklendiğinde otomatik alınacak.
        public string CreatedIpAddress { get ; set ; }
        //todo: Ip adresi veri eklendiğinde otomatik alınacak.
        public DateTime UpdatedDate { get ; set ; }
        //todo: Veri güncellendiğinde tarih doldurulacak.
        public string UpdatedComputerName { get ; set ; }
        //todo: Veri güncellendiğinde bilgisayar adı doldurulacak.
        public string UpdatedIpAddress { get ; set ; }
        //todo: Veri güncellendiğinde Ip adresi doldurulacak.
        public DateTime DeletedDate { get; set; }

        public bool IsActive { get ; set ; }
        public Status Status { get; set; }
    }
}
