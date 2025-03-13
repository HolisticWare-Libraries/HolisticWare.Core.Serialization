using System.Text.Json;

namespace HolisticWare.System.Text.Json;

public class 
                                        PropertyNamingPolicy
                                        :
                                        JsonNamingPolicy
{
    public override 
            string 
                                        ConvertName
                                        (
                                            string name
                                        )
    {
        string name_mapped = name;

        switch (name)
        {
            case null:
                break;
            default:
                break;
        }
        
        return name_mapped;
    }
}