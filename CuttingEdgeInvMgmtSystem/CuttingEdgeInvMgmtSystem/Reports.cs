using System;
using System.IO;
using System.Linq;
using System.Data;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;

namespace CuttingEdgeInvMgmtSystem
{
    public class Reports
    {
        private dbCounterTopsDataContext dbContext = new dbCounterTopsDataContext();
        private static string DEST = $"reports/{DateTime.Now:dddd, dd MMMM yyyy}.pdf";

        public static void CreateReport()
        {
            FileInfo file = new FileInfo(DEST);
            if (!file.Directory.Exists) file.Directory.Create();

            new Reports().CreateFile(DEST);
        }

        public void CreateFile(String dest)
        {
            PdfWriter writer = new PdfWriter(dest);
            PdfDocument pdf = new PdfDocument(writer);
            Document document = new Document(pdf);

            // Adds title to file
            Text title = new Text("Inventory Report").SetFontSize(32);
            Paragraph p = new Paragraph().Add(title);
            p.SetTextAlignment(TextAlignment.CENTER);
            document.Add(p);

            // Adds Inventory on BarTops
            Paragraph barTops = new Paragraph(new Text("BarTop Inventory\n").SetFontSize(16));
            var dbBarTops = (from BarTops in dbContext.BarTops
                             group BarTops by new
                             {
                                 BarTops.Length,
                                 BarTops.Width,
                                 BarTops.ColorID
                             } into g
                             select new
                             {
                                 g.Key.ColorID,
                                 g.Key.Length,
                                 g.Key.Width,
                                 Quantity = g.Count()
                             });

            barTops.Add(new Text("Color, Length, Width, Quantity\n"));

            foreach(var bar in dbBarTops)
            {
                barTops.Add(new Text($"{DataAccess.DataAdapter.GetColor(bar.ColorID)}, {bar.Length}, {bar.Width}, {bar.Quantity} \n"));
            }
            document.Add(barTops);
            
            // Adds Inventory on KitchenTops
            Paragraph kitchenTops = new Paragraph(new Text("KitchenTop Inventory\n").SetFontSize(16));
            var dbKitchenTops = (from Kitchens in dbContext.Kitchens
                                 group Kitchens by new
                                 {
                                     Kitchens.Length,
                                     Kitchens.ColorID
                                 } into g
                                 select new
                                 {
                                     g.Key.ColorID,
                                     g.Key.Length,
                                     Quantity = g.Count()
                                 });
            kitchenTops.Add(new Text("Color, Length, Quantity\n"));
            foreach (var kitchen in dbKitchenTops)
            {
                kitchenTops.Add(new Text($"{DataAccess.DataAdapter.GetColor(kitchen.ColorID)}, {kitchen.Length}, {kitchen.Quantity} \n"));
            }
            document.Add(kitchenTops);



            // Adds Inventory on Vanity
            Paragraph vanity = new Paragraph(new Text("VanityTop Inventory\n").SetFontSize(16));
            var dbVanityTops = (from vanities in dbContext.Vanities
                                group vanity by new
                                {
                                    vanities.Length,
                                    vanities.ColorID
                                } into g
                                select new
                                {
                                    g.Key.ColorID,
                                    g.Key.Length,
                                    Quantity = g.Count()
                                });
            vanity.Add(new Text("Color, Length, Quantity\n"));
            foreach (var vanities in dbVanityTops)
            {
               vanity.Add(new Text($"{DataAccess.DataAdapter.GetColor(vanities.ColorID)}, {vanities.Length}, {vanities.Quantity} \n"));
            }
            document.Add(vanity);

            document.Close();
        }


    }
}

