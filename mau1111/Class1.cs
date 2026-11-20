using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System.Windows.Forms;

namespace mau1111
{
    [Autodesk.Revit.Attributes.Transaction(Autodesk.Revit.Attributes.TransactionMode.Manual)]
    public class Class1 : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            UIDocument uidoc = commandData.Application.ActiveUIDocument;
            ICollection<ElementId> selectElements = uidoc.Selection.GetElementIds();
            int totalCount = selectElements.Count;
            MessageBox.Show("Ban da chon" + totalCount.ToString() + "elements");
            return Result.Succeeded;
        }
    }
}
