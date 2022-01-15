using System.Collections.Generic;

 
    public class StringConnectionParse
    {
        //Retur values
        public readonly List<Parser> Parses = new List<Parser>();

        /// <summary>
        ///     Add string complete connection
        /// </summary>
        /// <param name="ConnectionString"></param>
        public void Parse(string ConnectionString)
        {
            var splitOne = ConnectionString.Split(';');

            foreach (var t in splitOne)
            {
                var splitTwo = t.Split('=');
                var parser = new Parser { Parameter = splitTwo[0], Value = splitTwo[1]};
                Parses.Add(parser);
            }
        }

        public class Parser
        {
            public string Parameter { get; set; }
            public string Value { get; set; }
        }
    }
 
