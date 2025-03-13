using SpanJson;
using SpanJson.Resolvers;

public partial class 
                                        CustomResolver<TSymbol> 
                                        :
                                        ResolverBase
                                            <
                                                TSymbol, 
                                                CustomResolver<TSymbol>
                                            > 
                                        where 
                                            TSymbol : struct
{
    public
        CustomResolver
        (
            SpanJsonOptions spanJsonOptions
        ) 
        : base(spanJsonOptions)
    {
    }

    public
                                        CustomResolver
                                        (
                                        ) 
                                        : base(new SpanJsonOptions())
    {
    }

    partial class 
                                        CustomNameSerializer 
                                        : 
                                        ICustomJsonFormatter
    {
        public
                                        CustomNameSerializer
                                        (
                                        )
        {
            
        }

        public 
            void 
                                        Serialize<TValue>
                                        (
                                            ref JsonWriter<TSymbol> writer, 
                                            TValue value, 
                                            IJsonFormatterResolver resolver
                                        )
        {
            var originalName = value.ToString();
            var customName = GetCustomName(originalName);
            writer.WriteUtf16String(customName);

            return;
        }

        public 
            TValue 
                                        Deserialize<TValue>
                                        (
                                            ref JsonReader<TSymbol> reader, 
                                            IJsonFormatterResolver resolver
                                        )
        {
            string? customName = reader.ReadString();
            string originalName = GetOriginalName(customName);

            return (TValue)Convert.ChangeType(originalName, typeof(TValue));
        }

        private 
            string 
                                        GetCustomName
                                        (
                                            string originalName
                                        )
        {
            // Implement your custom naming logic here
            return originalName switch
            {
                "OriginalName" => "custom_name",
                _ => originalName
            };
        }

        private 
            string 
                                        GetOriginalName
                                        (
                                            string customName
                                        )
        {
            // Implement your reverse naming logic here
            return customName switch
            {
                "custom_name" => "OriginalName",
                _ => customName
            };
        }

        public
            object?
                                        Arguments
        {
            get; 
            set;
        }
    }
}