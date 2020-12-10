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
            string FicheContexte = "<div><h3>Fiche contexte simplifiée*</h3></div>";
            FicheContexte += "<div>Contexte commercial de l’activité :</div></ br>";
            FicheContexte += "<div>"+model.ficheContexteSimplifiee.EntrepriseNom+"</div>";
            FicheContexte += "<div>" + model.ficheContexteSimplifiee.CompagnieMandante + "</div>";
            FicheContexte += "<div><h3>Business context of the activity:</h3></div>";
            FicheContexte += "<div><h5>Historique</h5>" + model.ficheContexteSimplifiee.Historique + "</div>";
            FicheContexte += "<div><h5>Presentation Portefeuille Clients</h5>" + model.ficheContexteSimplifiee.PresentationPortefeuilleClients + "</div>";
            FicheContexte += "<div><h5>Activites Entreprise</h5>" + model.ficheContexteSimplifiee.ActivitesEntreprise + "</div>";
            FicheContexte += "<div><h5>Cible</h5>" + model.ficheContexteSimplifiee.Cible + "</div>";
            FicheContexte += "<div><h5>Actions Commerciales</h5>" + model.ficheContexteSimplifiee.ActionsCommerciales + "</div>";
            FicheContexte += "<div><h5>Reductions Nature</h5>" + model.ficheContexteSimplifiee.ReductionsNature + "</div>";
            FicheContexte += "<div><h5>Reductions Montant</h5>" + model.ficheContexteSimplifiee.ReductionsMontant + "</div>";
            FicheContexte += "<div><h5>Reductions Periode</h5>" + model.ficheContexteSimplifiee.ReductionsPeriode + "</div>";
            FicheContexte += "<div><h5>Reductions Autre</h5>" + model.ficheContexteSimplifiee.ReductionsAutre + "</div>";
            FicheContexte += "<div style='color:red;'>*La fiche contexte intégrale annexée à la circulaire peut également être utilisée à la place ou en complément de cette fiche contexte simplifiée</div>";
            sb.Append(FicheContexte);

            string ficheClientProspect = "<div style='margin-Top:20px;'><h3>Fiche client ou prospect **</h3></div>";
            ficheClientProspect += "<div><h4>Identification :</h4></div>";
            ficheClientProspect += "<div><h5>Nom :</h5>" + model.ficheClientProspect.Nom+ "</div>";
            ficheClientProspect += "<div><h5>Prenom :</h5>" + model.ficheClientProspect.Prenom + "</div>";
            ficheClientProspect += "<div><h5>Sexe :</h5>" + model.ficheClientProspect.Sexe + "</div>";
            ficheClientProspect += "<div><h5>Age :</h5>" + model.ficheClientProspect.Age + "</div>";
            ficheClientProspect += "<div><h5>Adresse :</h5>" + model.ficheClientProspect.Adresse + "</div>";
            ficheClientProspect += "<div><h5>CodePostal :</h5>" + model.ficheClientProspect.CodePostal + "</div>";
            ficheClientProspect += "<div><h5>Ville :</h5>" + model.ficheClientProspect.Ville + "</div>";
            ficheClientProspect += "<div><h5>Telephone :</h5>" + model.ficheClientProspect.Telephone + "</div>";
            ficheClientProspect += "<div><h5>Mobile :</h5>" + model.ficheClientProspect.Mobile + "</div>";
            ficheClientProspect += "<div><h5>Mail :</h5>" + model.ficheClientProspect.Mail + "</div>";
            ficheClientProspect += "<div><h5>Autre :</h5>" + model.ficheClientProspect.Autre + "</div>";
            sb.Append(ficheClientProspect);

            string situationFamiliale = "<div><h4>Situation familiale :</h4></div>";
            situationFamiliale += "<div><h4>Identification :</h4></div>";
            situationFamiliale += "<div><h5>SituationFamiliale :</h5>" + model.ficheClientProspect.SituationFamiliale + "</div>";
            situationFamiliale += "<div><h5>NbEnfants :</h5>" + model.ficheClientProspect.NbEnfants + "</div>";
            situationFamiliale += "<div><h5>AgesEnfants :</h5>" + model.ficheClientProspect.AgesEnfants + "</div>";
            situationFamiliale += "<div><h5>SituationProfessionnelle :</h5>" + model.ficheClientProspect.SituationProfessionnelle + "</div>";
            sb.Append(situationFamiliale);

            if (model.ficheClientProspect.IsClient)
            {
                string clientInfo = "<div><h3>Si client :</h3></div>";
                clientInfo += "<div><h5>Statut et ancienneté :</h5></div>";
                clientInfo += "<div>Statut et ancienneté :</div>";
                clientInfo += "<div><h5>Statut :</h5>" + model.ficheClientProspect.Statut + "</div>";
                clientInfo += "<div><h5>Anciennete :</h5>" + model.ficheClientProspect.Anciennete + "</div>";
                clientInfo += "<div>Contrats détenus en portefeuille</div>";
                clientInfo += "<div><h5>ContratsType :</h5>" + model.ficheClientProspect.ContratsType + "</div>";
                clientInfo += "<div><h5>ContratsGarantie :</h5>" + model.ficheClientProspect.ContratsGarantie + "</div>";
                clientInfo += "<div><h5>ContratsDateSouscription :</h5>" + model.ficheClientProspect.ContratsDateSouscription + "</div>";
                clientInfo += "<div><h5>ContratsAnnualSubscription :</h5>" + model.ficheClientProspect.ContratsAnnualSubscription + "</div>";
                clientInfo += "<div>Autres informations</div>";
                clientInfo += "<div><h5>Revenus :</h5>" + model.ficheClientProspect.Revenus + "</div>";
                clientInfo += "<div><h5>TauxImposition :</h5>" + model.ficheClientProspect.TauxImposition + "</div>";
                clientInfo += "<div><h5>Placements :</h5>" + model.ficheClientProspect.Placements + "</div>";
                sb.Append(clientInfo);
            }
            sb.Append((model.descriptionActivite.ContactOrigine != null) ? model.descriptionActivite.ContactOrigine : "");
            sb.Append((model.descriptionActivite.ContactFonction != null) ? model.descriptionActivite.ContactFonction: "");
            sb.Append((model.descriptionActivite.EntretienDeroulement != null) ? model.descriptionActivite.EntretienDeroulement: "");
            sb.Append((model.phase.PhaseContact != null) ? model.phase.PhaseContact : "");
            sb.Append((model.phase.PhaseDecouverte != null) ? model.phase.PhaseDecouverte : "");
            sb.Append((model.phase.PhaseContact != null) ? model.phase.PhaseContact : "");
            sb.Append((model.phase.PhaseTransition != null) ? model.phase.PhaseTransition : "");
            sb.Append((model.phase.PhaseVente != null) ? model.phase.PhaseVente : "");
            sb.Append((model.phase.PhaseConclusion != null) ? model.phase.PhaseConclusion : "");
            sb.Append((model.phase.PhaseAsseoirVente != null) ? model.phase.PhaseAsseoirVente : "");
            sb.Append((model.phase.PhasePriseConge != null) ? model.phase.PhasePriseConge : "");
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
