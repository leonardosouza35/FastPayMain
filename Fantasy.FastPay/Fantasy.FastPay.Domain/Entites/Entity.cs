using System.Collections.Generic;
namespace Fantasy.FastPay.Domain.Entites
{
    public abstract class Entity
    {
        public int Id { get; set; }
        
        private List<string> _validationMessages;
        protected List<string> ValidationMessages
        { get {return _validationMessages ?? (_validationMessages = new List<string>());} }

        protected void ClearValidationMessages(){
            ValidationMessages.Clear();
        }
        protected void AddValidationMessage(string message){
            ValidationMessages.Add(message);
        }

        public bool IsValidated
        {
          get{ return ValidationMessages.Count == 0;}   
        }
        public abstract void Validate();
        


        
    }
}
