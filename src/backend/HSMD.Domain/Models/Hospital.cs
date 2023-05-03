using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSMD.Domain.Models
{
    public class Hospital : HospitalAddress
    {
        [ForeignKey(nameof(HospitalAddress))]
        public int AddressId { get; set; }
        public string? HospitalName { get; set; }
        public string? HospitalMD { get; set; }

        public HospitalAddress? HospitalAddress { get; set; }
    }
}

/*This is a C# class named `Hospital`, which inherits from `HospitalAddress`
 * (not shown here). The class has several properties that represent 
 * attributes of a hospital, such as the hospital name and the name of the managing director.

The class also has a property named `AddressId`, which is marked with the 
`[ForeignKey]` attribute, indicating that it is a foreign key that links to 
another entity or table that represents the hospital's address. This property is 
likely to be used to establish a relationship between the `Hospital` object and the 
`HospitalAddress` object.

The `Hospital` class also has a reference to a `HospitalAddress` object, represented 
by the `HospitalAddress` property. This indicates that a `Hospital` object can have an 
associated `HospitalAddress` object, and suggests that the two classes are related in some way.

Overall, this class seems to represent a hospital entity in a database or other data 
storage system, and includes information about the hospital's name, managing director, 
and address.*/