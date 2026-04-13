using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberSecurityAwarenessBot.Services
{
    public class ResponseService
    {
        public string GetResponse(string userInput, string userName)
        {
            string input = userInput.ToLower().Trim();

            if (string.IsNullOrWhiteSpace(input))
            {
                return "You entered nothing. Please type a question so I can help you.";
            }

            if (input.Contains("how are you"))
            {
                return $"I don't have feelings, {userName}. However, I am ready to help you with cybersecurity awareness.";
            }

            if (input.Contains("what's your purpose") || input.Contains("what is your purpose"))
            {
                return "My purpose is to teach users about common cyber threats,\n" +
                       "warn them about risks like phishing and scams also provide useful tips to protect personal\n" +
                       "information and help reduce the chances of cyber attacks.";
            }

            if (input.Contains("what can i ask you about"))
            {
                return "Ask about password safety,\n" +
                       "phishing, suspicious links, scams,\n" +
                       "safe browsing and basic online protection.";
            }

            if (input.Contains("password"))
            {
                return "What I can say is that, password safety is important for protecting your accounts from being hacked. \n" +
                        "A strong password should be long and include a mix of letters, numbers and symbols you should " +
                        "avoid using the same \npassword for different accounts. \n" +
                        "Here are some key tips: \n" +
                        "-Don't use personal information \n" +
                        "-Don't share your password \n" +
                        "-Avoid suspicious links or emails \n" +
                        "-Change your password if needed";
            }

            if (input.Contains("phishing"))
            {
                return "Phishing is a type of online scam where attackers trick people into giving away sensitive information like \n" +
                       "passwords or bank details by pretending to be a trusted source. This is usually done through fake emails, \n" +
                       "messages or websites that look real.\n" +
                       "Some signs of phishing:\n" +
                       "-Messages asking for your password or personal details.\n" +
                       "-Suspicious links or attachments.\n" +
                       "-Urgent or threatening (“your account will be locked”).\n" +
                       "-Email addresses that look slightly wrong or wrong completely.\n" +
                       "To stay safe:\n" +
                       "-Don’t click unknown links.\n" +
                       "-Never share your passwords.\n" +
                       "-Verify websites before entering information.";
            }

            if (input.Contains("safe browsing") || input.Contains("browse safely") || input.Contains("browsing"))
            {
                return "Safe browsing means using the internet in a way that protects your personal information and avoids harmful\n" +
                       "websites. It helps prevent scams, viruses and data theft.\n" +
                       "Some key tips for safe browsing:\n" +
                       "-Only visit trusted and secure websites (look for https).\n" +
                       "-Don’t click on suspicious links.\n" +
                       "-Avoid downloading files from unknown sources.\n" +
                       "-Keep your browser and antivirus updated.\n" +
                       "-Log out of accounts on shared devices.";
            }

            if (input.Contains("suspicious link") || input.Contains("link"))
            {
                return "A suspicious link is a link that may lead to a fake or harmful website designed to steal your information or\n" +
                       "infect your device. These links are often used in phishing scams and can look similar to real websites but\n" +
                       "have small differences.\n" +
                       "Some signs of a suspicious links:\n" +
                       "-Strange or misspelled website names.\n" +
                       "-Shortened links (like bit.ly) that hide the real address.\n" +
                       "-Links sent from unknown or unusual senders.\n" +
                       "-Messages creating urgency to click the link.\n" +
                       "To stay safe:\n" +
                       "-Don’t click links you don’t trust.\n" +
                       "-Hover over the link to see the real URL.\n" +
                       "-Type the website address manually instead of clicking.\n" +
                       "-Delete messages that seem suspicious.";
            }

            if (input.Contains("scam"))
            {
                return "A scam is a dishonest attempt to trick people into giving away money or personal information by pretending\n" +
                       "to be someone trustworthy. Scammers often use messages, calls or fake websites to deceive victims.\n" +
                       "Some common signs of a scam:\n" +
                       "-Promises of easy money or prizes.\n" +
                       "-Requests for personal or banking details.\n" +
                       "-Urgent messages that pressure you to act quickly.\n" +
                       "-Unknown or suspicious contacts.\n" +
                       "To stay safe:\n" +
                       "-Don’t share personal information.\n" +
                       "-Ignore offers that seem too good to be true.\n" +
                       "-Verify the source before responding.\n" +
                       "-Block and report suspicious contacts.\n";
            }

            if (input == "exit")
            {
                return $"Goodbye {userName}. Stay safe online!";
            }

            return "I didn’t quite understand that. Could you rephrase? You can ask about passwords, phishing, or safe browsing.";
        }
    }
}

