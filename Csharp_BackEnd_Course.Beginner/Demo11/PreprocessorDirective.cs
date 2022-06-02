#define DEBUG
#define DEV
//#undef DEBUG
using static System.Console;

namespace Day06
{
    public class PreprocessorDirective
    {
        #region  Conditional Pre-processor code

        public void ConditionalProcessor() =>
#if (DEBUG && !DEV)
            WriteLine("Symbol is DEBUG.");
#elif (!DEBUG && DEV)
            WriteLine("Symbol is DEV");
#else
            WriteLine("Symbols are DEBUG & DEV");
#endif

        #endregion
        public void LinePreprocessor()
        {
#line 85 "LineprocessorIsTheFileName"
            WriteLine("This statement is at line#85 and not at line# 25"); // CS0168 on line 85  
#line default
            WriteLine("This statement is at line#29 and not at line# 28");
#line hidden
            WriteLine("This statement is at line#30");
        }
        public void WarningPreProcessor()
        {
#if DEBUG
#warning "This is a DEBUG compilation."
            WriteLine("Environment is DEBUG.");
#endif
        }
//        public void ErrorPreProcessor()
//        {
//#if DEV
//#error "This is a DEV compilation."
//            WriteLine("Environment is DEV.");
//#endif
//        }
    }
}