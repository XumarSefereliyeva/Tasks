namespace CharityProjectMVC.Exceptions
{
    public class CauseException:Exception
    {
        public CauseException():base("Default message")
        {
                
        }
        public CauseException(string errormessage):base(errormessage) 
        {
                
        }
    }
}
