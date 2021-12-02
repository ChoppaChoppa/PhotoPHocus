using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PHotoFockus.Data.Interfaces;
using PHotoFockus.Data.models;

namespace PHotoFockus.Data.Repository
{
    public class AboutUsRepository : IAboutUs
    {
        private readonly AppDBContent _appDbContent;

        public AboutUsRepository(AppDBContent appDB)
        {
            _appDbContent = appDB;
        }

        public void AboutUsText(AboutUs about)
        {
            _appDbContent.AboutUs.Add(new AboutUs
            {
                AboutUsText = "ihifpquwhfpiuwqhfpiwqufehpwdufhmwiufhcnwifuhodiufoaiuwfehcoiwufhoieaufhoiasuhdfoiauwhfoi uhfoiuaeh oiauhf oaiurh oiaeu eoiruhoeuifh aoifasdoubv oer oei erou neru oiun oiu",
                AboutUsText_1 = "w efwe i wefhwewfefaw efifpquawef iuwawef awef odiufoaiuwfehcoiwufhoieaufhoiasuhdfoiauwhfoi foa aodb asod ybawuy bauo a f",
                AboutUsText_2 = " asdisjdfpawief awef awefuawfnsiudfh ayfeuyruevn euvsy iuyv c mx ee,xaw pox,re sgse rger gserg fuy bfwdyuw iwi ebwuyfbweiyfubwiuef yb",
                AboutUsText_4 = " ousdhfawofeunaoifn oiwefn ian wiu f378 239467 r1976r h1239r6h 12743r6h 18fh13 948 394 64 182376519287518yfhwuyfb siuadbfaiusd cbasudcb aisudybcsauyd bciasuyd bisaudycb aisudybc aiusdybc iasudybc"
            });
        }
    }
}
