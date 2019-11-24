using System.Collections.Generic;
using Domain.Transaction;
using Domain.User;

namespace Domain.Room
{
    public class RoomEntity : AbstractEntity
    {
        public RoomType RoomType { get; set; }
        public uint Cost { get; set; }
        public ISet<UserEntity> Employees { get; protected set; } = new HashSet<UserEntity>();
        public ISet<TransactionEntity> Transactions { get; protected set; } = new HashSet<TransactionEntity>();

        public RoomEntity(RoomType roomType, uint cost)
        {
            Identify();

            RoomType = roomType;
            Cost = cost;
        }
    }

    public enum RoomType
    {
        Single,
        Double,
        Triple
    }
}
