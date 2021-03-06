﻿using System.Collections.Generic;
using System.Text;
using MilitaryElite.Models.Contracts.Private;
using MilitaryElite.Models.Contracts.Private.LieutenantGeneral;

namespace MilitaryElite.Models.Entities.Private.LieutenantGeneral
{
    public class LieutenantGeneral : Private, ILieutenantGeneral
    {
        private IList<IPrivate> _privates;

        public LieutenantGeneral(int id, string firstName, string lastName, decimal salary) : base(id, firstName, lastName, salary)
        {
           this._privates = new List<IPrivate>();
        }

        public IReadOnlyCollection<IPrivate> Privates => (IReadOnlyCollection<IPrivate>)_privates;

        public void AddPrivates(IPrivate @private)
        {
            this._privates.Add(@private);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());

            sb.AppendLine("Privates:");
            foreach (IPrivate @private in this._privates)
            {
                sb.AppendLine($"  {@private.ToString()}");
            }

            return sb.ToString().TrimEnd();
        }
    }
}
