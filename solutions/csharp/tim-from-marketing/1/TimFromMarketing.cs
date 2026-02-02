static class Badge
{
    public static string Print(int? id, string name, string? department)
    {
        if(department == null)
        {
          return  id != null ? $"[{id}] - {name} - OWNER" : $"{name} - OWNER";   
        }else if(id == null && department != null)
        {
             return  $"{name} - {department?.ToUpper()}";   
        }

        return  $"[{id}] - {name} - {department?.ToUpper()}";   
    }
}
