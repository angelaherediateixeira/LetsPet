namespace LetsPet854.Domain.Services
{
    public class Validations
    {
        public static bool Resposta(string resposta)
        {
            if (resposta != "S" && resposta != "N")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool SimNao(string resposta)
        {
            if (resposta == "S")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //public void Validate(string answer)
        //{
        //    bool valid = false;
        //    do
        //    {
        //        answer = answer.ToLower();
        //        var pattern1 = @"^((s)|(sim)){1}$";
        //        var pattern2 = @"^((n)|(nao)|(não)){1}$";
        //        Regex regex1 = new Regex(pattern1);
        //        Regex regex2 = new Regex(pattern2);
        //        if (regex1.Match(answer).Success)
        //        {
        //            valid = true;
        //            return true;
        //        }
        //        else if (regex2.Match(answer).Success)
        //        {
        //            valid = true;
        //            return false;
        //        }
        //        else
        //            Console.WriteLine("Opção inválida");
        //    }while (valid == false);
        //}
        //public bool ValidateAnswer(string valid)
        //{
        //    if (regex.Match().Success)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}
    }
}
