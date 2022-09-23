

    class RegisterSystem
    {
        string UserName;
        string Password;
        string ConfirmedPassword;
        string Email;
        string ChampName;
        Avatar UserAvatar;
        
        public RegisterSystem(string userName, string password, string confirmedPassword, string email, string champName, Avatar userAvatar)
        {
            UserName = userName;
            Password = password;
            ConfirmedPassword = confirmedPassword;
            Email = email;
            ChampName = champName;
            UserAvatar = userAvatar;
        }
        private bool CheckEmailCorrectness()
        {
          bool CheckIfEmailAreCorrect()
          {
            return this.Email.Contains("@") ? true : false;
          }
          bool CheckIfEmailsExistInSystem()
          {
            dbAcces newSql = new dbAcces();
            return newSql.CheckUserExist(this.Email);
          }
          return CheckIfEmailAreCorrect() && !CheckIfEmailsExistInSystem()?true:false;
        }
        private bool CheckUserNameCorrectness()
        {
            dbAcces newSql = new dbAcces();
            return !newSql.CheckUserExist(this.UserName);
        }
        private bool CheckPasswordNameCorrectness()
        {
            return (Password == ConfirmedPassword)?true:false;
        }
        public bool CheckInputsCorrectnes()
        {
            return (CheckEmailCorrectness() && CheckUserNameCorrectness() && CheckPasswordNameCorrectness()) ? true : false;
        }
        public void RegisterUser()
        {
            Stats newStats = new Stats(0,0,0);
            Attributes newAttribute = new Attributes(80,10,10,10); 
            Sets newSet = new Sets();
            int newUserStartMoney = 1;
            int newUserStartLevel = 1;
            User newUser = new User(UserName,Email,ChampName,newUserStartMoney,newUserStartLevel,newAttribute,newStats,newSet,UserAvatar);
            dbAcces newSql = new dbAcces();
            Cryptography toHashedPassword = new Cryptography(Password,UserName);
            newSql.InsertNewUser(newUser,toHashedPassword.GetHash());
        }

}

