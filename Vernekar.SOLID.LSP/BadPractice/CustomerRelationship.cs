﻿
using System.Collections.Generic;

namespace Vernekar.SOLID.LSP.BadPractice
{
    public abstract class CustomerRelationship
    {
        public abstract List<string> GetClubAccessDetails();

        public abstract List<string> GetResortAccessDetails();
    }
}
