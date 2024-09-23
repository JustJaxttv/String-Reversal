namespace String_Reversal.Models
{
    public class GetString
    {
        public string Input { get; set; }
        public string Output { get; set; }

        public void ReverseString()
        {
            if (!string.IsNullOrEmpty(Input)) 
            {
                char[] charArray = Input.ToCharArray();
                System.Array.Reverse(charArray);
                Output = new string(charArray);
            }
        }
    }
}
