namespace LeetCode.Easy
{
    public class UniqueEmailAddresses
    {
        public static int NumUniqueEmails(string[] emails)
        {
            HashSet<string> uniqueEmails = new HashSet<string>();

            foreach (string email in emails)
            {
                var e = email.Split("@");
                string outEmail = e[0].Replace(".", "").Split("+")[0] + "@" + e[1];
                uniqueEmails.Add(outEmail);
            }

            return uniqueEmails.Count;
        }

    }
}
