using System.Windows;
using ValentinRoyerCsharpProjet.Controller;
using ValentinRoyerCsharpProjet.Model;

namespace ValentinRoyerCsharpProjet.View;

public partial class ModifClientView : Window
{
    private Client _client;
    private Manager _monManager = new Manager();

    public ModifClientView(Client client)
    {
        InitializeComponent();
        _client = client;

        IdClientTb.Text = client.IdClient.ToString();
        NomClientTb.Text = client.Nom;
        PrenomClientTb.Text = client.Prénom;
        AdresseClientTb.Text = client.Adresse;
    }

    private void BtnValider_OnClick(object sender, RoutedEventArgs e)
    {
        if (string.IsNullOrWhiteSpace(AdresseClientTb.Text))
        {
            MessageBox.Show("Merci de saisir une adresse valide.");
        }

        else
        {
            _monManager.ModifClient(_client, AdresseClientTb.Text);
            this.Close();
        }
    }
}