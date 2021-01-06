﻿using MilitaryElite.Models.Contracts.Private;

namespace MilitaryElite.Models.Entities.Private
{
    public class Private : Soldier, IPrivate
    {
        public Private(int id, string firstName, string lastName, decimal salary) : base(id, firstName, lastName)
        {
            this.Salary = salary;
        }

        public decimal Salary {get; private set;}
    }
}