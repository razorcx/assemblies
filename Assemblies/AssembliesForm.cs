using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Tekla.Structures.Model;
using Tekla.Structures.Model.UI;

namespace Assemblies
{
	public partial class Assemblies : Form
	{
		private List<Assembly> _assemblies;
		private GraphicsDrawer _drawer = new GraphicsDrawer();

		public Assemblies()
		{
			InitializeComponent();
		}

		private void buttonGetAssemblies_Click(object sender, EventArgs e)
		{
			ModelObjectEnumerator.AutoFetch = true;

			_assemblies = new Model()
				.GetModelObjectSelector()
				.GetAllObjectsWithType(ModelObject.ModelObjectEnum.ASSEMBLY)
				.ToList()
				.OfType<Assembly>()
				.ToList();

			textBoxAssyQuantity.Text = _assemblies.Count.ToString();
		}

		private void buttonShowAssemblies_Click(object sender, EventArgs e)
		{
			var assyList = _assemblies.AsParallel()
				.Where(a => a.GetSubAssemblies().ToArray().Any())
				.OfType<Assembly>()
				.ToList();

			textBoxAssyWithSubAssyQuantity.Text = assyList.Count.ToString();

			assyList.ForEach(a =>
			{
				var location = a.GetMainPart().GetCoordinateSystem().Origin;
				var text = a.Name;
				_drawer.DrawText(location, text, new Color(0, 0, 0));
			});
		}

		private void buttonShowSubAssemblies_Click(object sender, EventArgs e)
		{
			var subAssyList = _assemblies.AsParallel()
				.SelectMany(a => a.GetSubAssemblies().ToArray())
				.OfType<Assembly>()
				.ToList();

			textBoxSubAssembliesQuantity.Text = subAssyList.Count.ToString();

			subAssyList.ForEach(a =>
			{
				var location = a.GetMainPart().GetCoordinateSystem().Origin;
				var text = a.GetAssembly().Identifier.ID.ToString();
				_drawer.DrawText(location, text, new Color(0, 0, 0));
			});
		}
	}

	public static class TeklaExtensionMethods
	{
		public static List<ModelObject> ToList(this ModelObjectEnumerator enumerator)
		{
			var modelObjects = new List<ModelObject>();
			while (enumerator.MoveNext())
			{
				var modelObject = enumerator.Current;
				if (modelObject == null) continue;
				modelObjects.Add(modelObject);
			}

			return modelObjects;
		}
	}
}
