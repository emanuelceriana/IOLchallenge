/*
 * Refactorear la clase para respetar principios de programación orientada a objetos. Qué pasa si debemos soportar un nuevo idioma para los reportes, o
 * agregar más formas geométricas?
 *
 * Se puede hacer cualquier cambio que se crea necesario tanto en el código como en los tests. La única condición es que los tests pasen OK.
 *
 * TODO: Implementar Trapecio/Rectangulo, agregar otro idioma a reporting.
 * */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingChallenge.Data.Classes
{
    public class ControladorReporte
    {
        public static string Imprimir(List<OperacionesFiguras> figuras, Idioma idioma)
        {
            var sb = new StringBuilder();
            var reporte = new Reporte(figuras,idioma);

            if (!figuras.Any())
            {
                reporte.HeaderReporte("ListaVacia");
            }
            else
            {
                reporte.HeaderReporte("ReporteFormas");

                foreach (OperacionesFiguras fg in figuras)
                {
                    reporte.SetCantidad(((FiguraGeometrica)fg).Tipo);
                    reporte.SetArea(((FiguraGeometrica)fg).Tipo, fg.GetArea());
                    reporte.SetPerimetro(((FiguraGeometrica)fg).Tipo, fg.GetPerimetro());
                }

                reporte.BodyReporte();
                reporte.FooterReporte();

            }

            return reporte.Print();

        }
    }
}
