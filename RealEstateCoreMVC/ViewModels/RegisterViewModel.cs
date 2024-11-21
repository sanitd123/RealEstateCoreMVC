using Microsoft.AspNetCore.Mvc.Rendering;
using RealEstateCoreMVC.Models;

namespace RealEstateCoreMVC.ViewModels
{
    public class RegisterViewModel
    {
        private Account account = new Account();
        private string usernameInput = "";
        private string passwordInput = "";
        private List<SelectListItem> questionSet1 = new List<SelectListItem>();
        private List<SelectListItem> questionSet2 = new List<SelectListItem>();
        private List<SelectListItem> questionSet3 = new List<SelectListItem>();
        private string selectedQuestion1 = "";
        private string selectedQuestion2 = "";
        private string selectedQuestion3 = "";

        public RegisterViewModel()
        {
            questionSet1.Add(new SelectListItem
            {
                Text = "What is your mother's maiden name?"

            });
            questionSet1.Add(new SelectListItem
            {
                Text = "What is the name of your first pet?"
            });
            questionSet1.Add(new SelectListItem
            {
                Text = "What was the name of the street you grew up on?"
            });

            questionSet2.Add(new SelectListItem
            {
                Text = "What is your favorite color?"
            });
            questionSet2.Add(new SelectListItem
            {
                Text = "What was the name of your elementary school?"
            });
            questionSet2.Add(new SelectListItem
            {
                Text = "What is your father's middle name?"
            });

            questionSet3.Add(new SelectListItem
            {
                Text = "In what city were you born?"
            });
            questionSet3.Add(new SelectListItem
            {
                Text = "What is the name of your childhood bestfriend?"
            });
            questionSet3.Add(new SelectListItem
            {
                Text = "What was your first car?"
            });

            selectedQuestion1 = questionSet1[0].Text;
            selectedQuestion2 = questionSet2[0].Text;
            selectedQuestion3 = questionSet3[0].Text;
        }
        public Account Account
        {
            get { return account; }
            set { account = value; }
        }
        public List<SelectListItem> QuestionSet1
        {
            get { return questionSet1; }
            set { questionSet1 = value; }
        }
        public List<SelectListItem> QuestionSet2
        {
            get { return questionSet2; }
            set { questionSet2 = value; }
        }
        public List<SelectListItem> QuestionSet3
        {
            get { return questionSet3; }
            set { questionSet3 = value; }
        }
        public string SelectedQuestion1
        {
            get { return selectedQuestion1; }
            set { selectedQuestion1 = value; }
        }
        public string SelectedQuestion2
        {
            get { return selectedQuestion2; }
            set { selectedQuestion2 = value; }
        }
        public string SelectedQuestion3
        {
            get { return selectedQuestion3; }
            set { selectedQuestion3 = value; }
        }
    }
}
