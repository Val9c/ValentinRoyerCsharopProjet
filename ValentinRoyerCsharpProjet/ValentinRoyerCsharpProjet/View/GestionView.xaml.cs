using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using ValentinRoyerCsharpProjet.Controller;
using ValentinRoyerCsharpProjet.Model;

namespace ValentinRoyerCsharpProjet.View;

public partial class GestionView : Window
{
    private Manager _monManager = new Manager();

    public List<Compte> ListeComptes = new List<Compte>();


    private List<Client> _listeClients = new List<Client>();

    public GestionView()
    {
        InitializeComponent();

        _listeClients = _monManager.ChargementListClients();

        if (_listeClients.Count != 0)
        {
            RafraichirListBoxClient();
        }
    }

    private void CréditerMenuItemOnClick(object sender, RoutedEventArgs e)
    {
        LabelChange.Visibility = Visibility.Visible;
        LabelChange.Content = "Montant à créditer: ";

        TextBoxVal.Visibility = Visibility.Visible;


        ButtonValid.Visibility = Visibility.Visible;
        ButtonValid.Content = "Valider la créditation";
    }

    private void DébiterMenuItemOnClick(object sender, RoutedEventArgs e)
    {
        LabelChange.Visibility = Visibility.Visible;
        LabelChange.Content = "Montant à débiter: ";

        TextBoxVal.Visibility = Visibility.Visible;

        ButtonValid.Visibility = Visibility.Visible;
        ButtonValid.Content = "Valider la débitation";
    }

    private void DécouvertMenuItemOnClick(object sender, RoutedEventArgs e)
    {
        LabelChange.Visibility = Visibility.Visible;
        LabelChange.Content = "Saisir le nouveau dévouvert: ";

        TextBoxVal.Visibility = Visibility.Visible;


        ButtonValid.Visibility = Visibility.Visible;
        ButtonValid.Content = "Valider le découvert";
    }

    private void ClientMenuItemOnClick(object sender, RoutedEventArgs e)
    {
        int i = ListBoxClient.SelectedIndex;

        if (i != -1)
        {
            Client client = _listeClients[i];

            ModifClientView modifClientView = new ModifClientView(client);
            modifClientView.ShowDialog();

            RafraichirListBoxClient();
        }
        else
        {
            MessageBox.Show("Merci de selectionner un client.");
        }
    }


    private void RafraichirListBoxClient()
    {
        _listeClients = _monManager.ChargementListClients();
        ListBoxClient.ItemsSource = null;
        ListBoxClient.ItemsSource = _listeClients;
    }

    private void RafraichirListBoxCompte(Client client)
    {
        ListeComptes = _monManager.ChargementListComptes(client);
        ListBoxCompte.ItemsSource = null;
        ListBoxCompte.ItemsSource = ListeComptes;
    }

    private void ListBoxClient_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        int i = ListBoxClient.SelectedIndex;

        if (i != -1)
        {
            Client client = _listeClients[i];

            ListeComptes = _monManager.ChargementListComptes(client);


            if (ListeComptes.Count != 0)
            {
                RafraichirListBoxCompte(client);
            }

            else
            {
                ListBoxCompte.ItemsSource = null;
            }
        }
    }

    private void ButtonValid_OnClick(object sender, RoutedEventArgs e)
    {
        int i = ListBoxCompte.SelectedIndex;
        int j = ListBoxClient.SelectedIndex;

        if (i != -1)
        {
            Compte compte = ListeComptes[i];
            Client client = _listeClients[j];

            switch (ButtonValid.Content)
            {
                case "Valider la créditation":
                    try
                    {
                        var val = Convert.ToInt32(TextBoxVal.Text);

                        if (val > 0)
                        {
                            _monManager.CrediterCompte(compte, val);
                            RafraichirListBoxCompte(client);
                        }

                        else
                        {
                            MessageBox.Show("Merci de bien vouloir saisir un montant supérieur à 0.");
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Le montant doit être un entier.");
                    }

                    break;

                case "Valider la débitation":
                    try
                    {
                        var val = Convert.ToInt32(TextBoxVal.Text);

                        if (val > 0)
                        {
                            if (!(compte.Solde - val < -compte.Decouvert))
                            {
                                _monManager.DebiterCompte(compte, val);
                                RafraichirListBoxCompte(client);
                            }
                            else
                            {
                                MessageBox.Show("Impossible de débiter, le découvert ne le permet pas.");
                            }
                        }

                        else
                        {
                            MessageBox.Show("Merci de bien vouloir saisir un montant supérieur à 0.");
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Le montant doit être un entier.");
                    }

                    break;

                case "Valider le découvert":
                    try
                    {
                        var val = Convert.ToInt32(TextBoxVal.Text);

                        if (val > 0)
                        {
                            if (compte.TypeCompte == "Epargne")
                            {
                                MessageBox.Show("Le découvert d'un compte epargne n'est pas modifiable.");
                            }

                            else
                            {
                                _monManager.DecouvertCompte(compte, val);
                                RafraichirListBoxCompte(client);
                            }
                        }

                        else
                        {
                            MessageBox.Show("Merci de bien vouloir saisir un montant supérieur à 0.");
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Le montant doit être un entier.");
                    }

                    break;
            }
        }

        else
        {
            MessageBox.Show("Merci de sélectionner un compte.");
        }
    }
}