using System;
using System.Drawing;
using System.Drawing.Text;
using System.Reflection;

namespace Computator.NET.DataTypes
{
    public static class CustomFonts
    {
        private static readonly SimpleLogger.SimpleLogger logger = new SimpleLogger.SimpleLogger(AppInformation.Name)
        {
            ClassName = typeof(PathUtility).FullName
        };

        private static PrivateFontCollection mathFontCollection;

        private static PrivateFontCollection scriptingFontCollection;


        public static Font GetMathFont(float fontSize)
        {
            if (mathFontCollection == null) GetCustomFonts();
            return new Font(mathFontCollection.Families[0], fontSize, GraphicsUnit.Point);
        }

        public static Font GetScriptingFont(float fontSize)
        {
            if (scriptingFontCollection == null) GetCustomFonts();
            return new Font(scriptingFontCollection.Families[0], fontSize, GraphicsUnit.Point);
        }


        private static void GetCustomFonts()
        {
            mathFontCollection = new PrivateFontCollection();
            scriptingFontCollection = new PrivateFontCollection();

            var pathToFont = PathUtility.GetFullPath("Static", "fonts", "CAMBRIA.TTC");
            var pathToFont2 = PathUtility.GetFullPath("Static", "fonts", "consola.ttf");
            try
            {
                mathFontCollection.AddFontFile(pathToFont);
                scriptingFontCollection.AddFontFile(pathToFont2);
            }
            catch (Exception ex)
            {
                var nex =
                    new Exception(
                        "Probably missing " + pathToFont + " or " + pathToFont2 + " file\nDetails:" + ex.Message, ex);
                logger.MethodName = MethodBase.GetCurrentMethod().Name;
                logger.Log("Probably missing " + pathToFont + " file\nDetails:" + ex.Message, ErrorType.General, nex);
                throw nex;
            }
        }
    }
}