
using System.Collections.Generic;

namespace Vernekar.SOLID.LSP.GoodPractice
{
    public abstract class CustomerRelationship : IClub, IResort
    {
        public abstract List<string> GetClubAccessDetails();

        public abstract List<string> GetResortAccessDetails();
    }
}
