namespace RealEstateCoreMVC.Models
{
    public class Broker
    {
        private int brokerID;
        private string? username;
        private string? password;
        private string? email;
        private string? phoneNumber;
        private string? personalAddress;
        private string? personalState;
        private int? personalZipcode;
        private string? workAddress;
        private string? workState;
        private int? workZipcode;
        private string? companyName;
        private int? yearsExperience;
        private string? licenceNumber;

        public int BrokerID 
        { 
            get {  return brokerID; } 
            set {  brokerID = value; } 
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
        public string? PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }
        public string? PersonalAddress
        {
            get { return personalAddress; }
            set { personalAddress = value; }
        }
        public string? PersonalState
        {
            get { return personalState; }
            set { personalState = value; }
        }
        public int? PersonalZipcode
        {
            get { return personalZipcode; }
            set { personalZipcode = value; }
        }
        public string? WorkAddress
        {
            get { return workAddress; }
            set { workAddress = value; }
        }
        public string? WorkState
        {
            get { return workState; }
            set { workState = value; }
        }
        public int? WorkZipcode
        {
            get { return workZipcode; }
            set { workZipcode = value; }
        }
        public string? CompanyName
        {
            get { return companyName; }
            set { companyName = value; }
        }
        public int? YearsExperience
        {
            get { return yearsExperience; }
            set { yearsExperience = value; }
        }
        public string? LicenceNumber
        {
            get { return licenceNumber; }
            set { licenceNumber = value; }
        }
    }
}
