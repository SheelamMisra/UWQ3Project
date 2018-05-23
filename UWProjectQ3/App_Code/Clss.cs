using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UWProjectQ3
{
    /// <summary>
    /// Summary description for AllSubjects
    /// </summary>
    public class Clss
    {
            public int Id { get; private set; }
            public string ClassName { get; private set; }
            public DateTime ClassDate { get; private set; }
            public string ClassDesc { get; private set; }
            public Clss(int _id, string _className, DateTime _classDate, string _classDesc)
            {
                Id = _id;
                ClassName = _className;
                ClassDate = _classDate;
                ClassDesc = _classDesc;
            }
        }
}