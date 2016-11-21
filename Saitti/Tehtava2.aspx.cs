using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Tehtava2 : System.Web.UI.Page
{
    List<int> tulos;
    BLLotto lotto = new BLLotto();
    protected void Page_Load(object sender, EventArgs e)
    {
        tulos = new List<int>();
        lotto = new BLLotto();
    }

    protected void btnSuomiLotto_Click(object sender, EventArgs e)
    {
        lotto.LotonTyyppi = 1;
        tulos = lotto.Arvonta();
        gvTulokset.DataSource = tulos;
        gvTulokset.DataBind();
    }

    protected void btnVikingLotto_Click(object sender, EventArgs e)
    {
        lotto.LotonTyyppi = 2;
        tulos = lotto.Arvonta();
        gvTulokset.DataSource = tulos;
        gvTulokset.DataBind();
    }
}