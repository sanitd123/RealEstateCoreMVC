namespace RealEstateCoreMVC.Models
{
    public class Account
    {
        private int accountID;
        private string? username;
        private string? password;
        private string? email;
        private string? securityQuestion1;
        private string? securityQuestion2;
        private string? securityQuestion3;
        private string? answer1;
        private string? answer2;
        private string? answer3;

        public int BrokerID
        {
            get { return accountID; }
            set { accountID = value; }
        }
        public string? Username 
        { 
            get { return username; } 
            set { username = value; } 
        } 
        public string? Password 
        { 
            get { return password; } 
            set { password = value; } 
        }
        public string? Email 
        { 
            get { return email; } 
            set { email = value; } 
        }
        public string? SecurityQuestion1 
        { 
            get {  return securityQuestion1; } 
            set {  securityQuestion1 = value; } 
        }
        public string? SecurityQuestion2 
        { 
            get {  return securityQuestion2; } 
            set {  securityQuestion2 = value; } 
        }
        public string? SecurityQuestion3 
        { 
            get {  return securityQuestion3; } 
            set {  securityQuestion3 = value; } 
        }
        public string? Answer1 
        { 
            get { return answer1; } 
            set { answer1 = value; } 
        }
        public string? Answer2 
        { 
            get { return answer2; } 
            set {  answer2 = value; } 
        }
        public string? Answer3 
        { 
            get { return answer3; } 
            set { answer3 = value;} 
        }
    }
}
