using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateProject.Model
{
    public class RealEstateModel
    {
        private string owner, realEstateID, address, realEstateNumber;

        public string Owner { get => owner; set => owner = value; }
        public string RealEstateID { get => realEstateID; set => realEstateID = value; }
        public string Address { get => address; set => address = value; }
        public string RealEstateNumber { get => realEstateNumber; set => realEstateNumber = value; }

        public override string ToString()
        {
            return RealEstateNumber + " || " + Owner + " || " + Address;
        }

        public RealEstateModel(string owner, string realEstateID, string address, string realEstateNumber)
        {
            this.owner = owner;
            this.realEstateID = realEstateID;
            this.address = address;
            this.realEstateNumber = realEstateNumber;
        }

    }
}
