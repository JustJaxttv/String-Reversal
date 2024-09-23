namespace String_Reversal.Models
{
    public class GetString
    {
        // Create Input and Output strings
        public string Input { get; set; }
        public string Output { get; set; }

        // Create ReverseString method for reversing user input
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
