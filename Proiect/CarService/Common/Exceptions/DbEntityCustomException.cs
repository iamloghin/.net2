namespace CarService.Common.Exceptions
{
    using System;
    using System.Data.Entity.Validation;
    using System.Text;

    public class DbEntityCustomException : Exception
    {
        private static readonly StringBuilder ExceptionObject = new StringBuilder();

        public DbEntityCustomException(string message) : base(message)
        {
        }

        public static string BuildMessageExceptions(Exception exception)
        {
            if (!(exception is DbEntityValidationException)) return exception.Message;

            var conversException = (DbEntityValidationException) exception;

            foreach (var eve in conversException.EntityValidationErrors)
            {
                ExceptionObject.AppendFormat(
                    $"Entity of type {eve.Entry.Entity.GetType().Name} in state {eve.Entry.State} has the following validation errors:\n");

                foreach (var ve in eve.ValidationErrors)
                {
                    ExceptionObject.AppendFormat($"- Property: {ve.PropertyName}, Error: {ve.ErrorMessage}\n");
                }
            }

            return ExceptionObject.ToString();
        }
    }
}
