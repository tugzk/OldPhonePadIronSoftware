using OldPhonePadIronSoftware;

namespace OldPhonePadTestsIronSoftware
{
    public class OldPhonePadTest
    {
        [Fact]
        public void VerifyOldPhonePadOutput_ExpectedResults()
        {
            object[] testCases =
            {
                new object[] { "33#", "E" },
                new object[] { "227 *#", "B" },
                new object[] { "4433555 555666#", "HELLO" },
                new object[] { "8 88777444666*664#", "TURNG" },
                new object[] { "8 88477788555#", "TUGRUL" },
                new object[] { "227 **#", "" },
                new object[] { "777729283 33 33 5577727#", "SAWATDEEKRAP" }
            };

            foreach (object[] testCase in testCases)
            {
                string input = (string)testCase[0];
                string expected = (string)testCase[1];
                string actual = Program.OldPhonePad(input);
                Assert.Equal(expected, actual);
            }
        }
    }
}