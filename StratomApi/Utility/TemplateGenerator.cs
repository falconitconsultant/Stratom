using Domain.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StratomApi.Utility
{
    public class TemplateGenerator
    {
        public static string GetHTMLString(MainViewModel model)
        {
            //var employees = DataStorage.GetAllEmployess();
            var sb = new StringBuilder();
            sb.Append(@"
                        <html>
                            <head>
                            </head>
                            <body>
                                <div class='header'><h1>E32 - Business development and maintainance</h1><div>Fiche d’activité "+model.NumberOfDocuments+"</div></div>");
            sb.Append(@"<div>NOM : "+model.Nom+"</div>");
            sb.Append(@"<div>Prénom : " + model.Prenom + "</div>");
            string activitiesType = string.Empty;
            foreach(var activiteItems in model.activiteType)
            {
                activitiesType +="<input checked type='checkbox' name="+ activiteItems.Libelle +">"+
                "<label>"+activiteItems.Libelle+ "</label>";
            }
            if (!activitiesType.Equals(""))
            {
                sb.Append(activitiesType);
                sb.Append("<div>Dans l’idéal il faudrait avoir au moins une activité réelle sur les 5 fiches mais à défaut il faudra bien cocher la case activité simulée.</div>");
            }
            string activities = "<div>Titre/nature de l’activité: Souscription:";
            foreach (var activiteItems in model.activite)
            {
                activities += activiteItems.Souscription+"/";
            }
            activities += "</div>";
            sb.Append(activities);
            string TypeDeContrat = "<div>Type de contrat:</div>";
            TypeDeContrat += "<div><u>Assurance de personnes</u></div>";
            TypeDeContrat += "<Row>";
            foreach (var assurancePersonne in model.assurancePersonne)
            {
                TypeDeContrat += "<input type='checkbox' name=" + assurancePersonne.Libelle + ">" +
                "<label>" + assurancePersonne.Libelle + "</label>";
            }
            TypeDeContrat += "</Row>";
            sb.Append(TypeDeContrat);
            TypeDeContrat += "<div><u>Assurance de Dommages :</u></div>";
            TypeDeContrat += "<Row>";
            foreach (var assuranceDommage in model.assuranceDommage)
            {
                TypeDeContrat += "<input checked type='checkbox' name=" + assuranceDommage.Libelle + ">" +
                "<label>" + assuranceDommage.Libelle + "</label>";
            }
            TypeDeContrat += "</Row>";
            sb.Append(TypeDeContrat);
            //foreach (var emp in employees)
            //{
            //    sb.AppendFormat(@"<tr>
            //                        <td>{0}</td>
            //                        <td>{1}</td>
            //                        <td>{2}</td>
            //                        <td>{3}</td>
            //                      </tr>", emp.Name, emp.LastName, emp.Age, emp.Gender);
            //}
            //
            sb.Append(@"
                                </table>
                            </body>
                        </html>");
            return sb.ToString();
        }
    }
}
