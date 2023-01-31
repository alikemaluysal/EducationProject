using Framework.Services.Basic;

namespace External.Services.Storage
{
    public class Storage
    {
        protected delegate bool HasFile(string path, string fileName);
        protected async Task<string> RenameFileAsync(string path, string saltFileName, HasFile hasFileMethod, int number = 1)
        {
            return await Task.Run(async () =>
            {
                string extension = Path.GetExtension(saltFileName);
                string oldName = $"{Path.GetFileNameWithoutExtension(saltFileName)}-{number}";
                string newFileName = $"{NameService.CharacterRegulator(oldName)}{extension}";

                if (hasFileMethod(path, newFileName))
                    return await RenameFileAsync(path, $"{newFileName.Split($"-{number}")[0]}{extension}", hasFileMethod, ++number);

                return newFileName;
            });
        }
    }
}
