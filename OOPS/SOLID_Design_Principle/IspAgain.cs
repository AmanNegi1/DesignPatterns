using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Design_Principle
{
    public interface IMultiFunction
    {
        public void Print();
        public void GetPrintSpoolDetails();
        public void Scan();
        public void ScanPhoto();
        public void Fax();
        public void InternetFax();

    }
    public class XeroxWorkCentrw : IMultiFunction
    {
        public void Fax()
        {
            //code
        }

        public void GetPrintSpoolDetails()
        {
            //code
        }

        public void InternetFax()
        {
            //code
        }

        public void Print()
        {
            //code
        }

        public void Scan()
        {
            //code
        }

        public void ScanPhoto()
        {
            //code
        }
    }
    ////bad desing according to ISP
    public class HpPrinterNScanner : IMultiFunction
    {
       

        public void GetPrintSpoolDetails()
        {
            //code
        }

        

        public void Print()
        {
            //code
        }

        public void Scan()
        {
            //code   
        }

        public void ScanPhoto()
        {
            //code
        }
        public void Fax()
        {
            throw new NotImplementedException();
        }
        public void InternetFax()
        {
            throw new NotImplementedException();
        }
    }

    //bad desing according to ISP
    public class CanonPrinter : IMultiFunction
    {
        
        public void Print()
        {
            //some code
        }
        public void GetPrintSpoolDetails()
        {
            //some code
        }

        public void InternetFax()
        {
            throw new NotImplementedException();
        }

        public void Fax()
        {
            throw new NotImplementedException();
        }

        public void Scan()
        {
            throw new NotImplementedException();
        }

        public void ScanPhoto()
        {
            throw new NotImplementedException();
        }
    }
    public interface IPrint
    {
        public void Print();
        public void GetPrintSpoolDetails();
    }
    public interface IScan
    {
        public void Scan();
        public void ScanPhoto();    

    }

    public interface IFax
    {
        public void Fax();
        public void InternetFax();
    }
    public class XeroxWorkCentre_ : IPrint, IScan, IFax
    {
        public void Fax()
        {
            //some code
        }

        public void GetPrintSpoolDetails()
        {
            //some code
        }

        public void InternetFax()
        {
            //some code
        }

        public void Print()
        {
            //some code
        }

        public void Scan()
        {
            //some code
        }

        public void ScanPhoto()
        {
            //some code
        }
    }
    public class HPPrinterNScanner : IPrint, IScan
    {
        public void GetPrintSpoolDetails()
        {
            //some code
        }

        public void Print()
        {
            //some code
        }

        public void Scan()
        {
            //some code
        }

        public void ScanPhoto()
        {
            //some code
        }
    }
    public class CanonPrinter_ : IFax
    {
        public void Fax()
        {
            //some code
        }

        public void InternetFax()
        {
            //some code
        }
    }
    internal class IspAgain
    {

    }
}
