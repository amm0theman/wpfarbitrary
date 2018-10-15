using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp3
{
    public class EntryFieldVM : ViewModelBase, INotifyDataErrorInfo
    {
        private string _username;
        private string _password;
        private string _email;

        public string Username => "Username";
        public string Password => "Password";
        public string Email => "Email";

        public string Username_Entry
        {
            get
            {
                return _username;
            }
            set
            {
                if (value == _username)
                    return;
                if(isUsernameValid(value))
                    _username = value;
                NotifyPropertyChanged();
            }
        }
        public string Password_Entry
        {
            get
            {
                return _password;
            }
            set
            {
                if (value == _username)
                    return;
                if(isPasswordValid(value))
                _password = value;
                NotifyPropertyChanged();
            }
        }
        public string Email_Entry
        {
            get
            {
                return _email;
            }
            set
            {
                if(isEmailValid(value))
                    _email = value;
                NotifyPropertyChanged();
            }
        }

        public int converterDemo => 0;

        private ConcurrentDictionary<string, List<string>> _errors = new ConcurrentDictionary<string, List<string>>();

        public bool HasErrors => _errors.Count() > 0;

        public event EventHandler<DataErrorsChangedEventArgs> ErrorsChanged;

        public IEnumerable GetErrors(string propertyName)
        {
            if (String.IsNullOrEmpty(propertyName) ||
                !_errors.ContainsKey(propertyName)) return null;
            return _errors[propertyName];
        }

        private const string USERNAME_ERROR = "Username cannot contain ',#,@,!";
        public bool isUsernameValid(string value)
        {
            bool isValid = true;
            if (value.Contains("'") | value.Contains("@") | value.Contains("#") | value.Contains("!"))
            {
                AddError("Username_Entry", USERNAME_ERROR, false);
                return isValid = false;
            }
            else RemoveError("Username_Entry", USERNAME_ERROR);
            return isValid;
        }

        private const string EMAIL_ERROR = "Email must contain @ symbol";
        public bool isEmailValid(string value)
        {
            if (!value.Contains("@"))
            {
                AddError("Email_Entry", EMAIL_ERROR, false);
                return true;
            }
            else RemoveError("Email_Entry", EMAIL_ERROR);
            return false;
        }

        private const string PASSWORD_ERROR = "Password must be more than 7 characters long.";
        public bool isPasswordValid(string value)
        {
            if (value.Length < 7)
            {
                AddError("Password_Entry", PASSWORD_ERROR, false);
                return false;
            }
            else RemoveError("Password_Entry", PASSWORD_ERROR);
            return true;
        }

        public void AddError(string propertyName, string error, bool isWarning)
        {
            if (!_errors.ContainsKey(propertyName))
                _errors[propertyName] = new List<string>();

            if (!_errors[propertyName].Contains(error))
            {
                if (isWarning) _errors[propertyName].Add(error);
                else _errors[propertyName].Insert(0, error);
                RaiseErrorsChanged(propertyName);
            }
        }

        public void RemoveError(string propertyName, string error)
        {
            if (_errors.ContainsKey(propertyName) &&
                _errors[propertyName].Contains(error))
            {
                _errors[propertyName].Remove(error);
                if (_errors[propertyName].Count == 0) _errors.TryRemove(propertyName, out var as1);
                RaiseErrorsChanged(propertyName);
            }
        }

        public void RaiseErrorsChanged(string propertyName)
        {
            ErrorsChanged?.Invoke(this, new DataErrorsChangedEventArgs(propertyName));
        }
    }
}
