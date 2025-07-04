# Currency Converter

## Description
Outil pour convertir un montant d'une devise à une autre. Il utilise les taux de change actuels pour effectuer la conversion

## Fonctionnalités
- Conversion de devises
- Support pour plusieurs devises
- Support pour les conversions en temps réel
- Support pour les conversions hors ligne

## Exemples
- Quelle que soit la devise, si le montant en entrée vaut 0, le montant en sortie doit aussi valoir 0
//Propose des exemples
- Convertir 0 USD en EUR doit donner 0 EUR
- Convertir 0 GBP en JPY doit donner 0 JPY
### Même devise source et cible
- Convertir 1 EUR en EUR doit donner 1 EUR
- Convertir 100 USD en USD doit donner 100 USD
### Conversions avec un taux de change
- Sachant que le taux de change de l'EUR vers l'USD est de 1.18, convertir 1 EUR en USD doit donner 1.18 USD 
- Sachant que le taux de change de l'USD vers l'EUR est de 0.85, convertir 1 USD en EUR doit donner 0.85 EUR
- Sachant que le taux de change de l'USD vers l'EUR est de 0.85, convertir -100 USD en EUR doit donner -85 EUR
- Sachant que le taux de change du JPY vers l'EUR est de 0.85, convertir -100 USD en EUR doit donner -85 EUR

- Sachant que le taux de change de l'EUR vers l'USD est de 1.18, et le taux de change de l'EUR vers JPY est de 170.23, convertir 1 EUR en USD doit donner 1.18 USD
### Règles de conversion

- Les utilisateurs ne saisiront pas des montants de plus de 6 chiffres avant la virgule
//Propose des exemples
- Sachant que le taux de change de l'USD vers l'EUR est de 0.85, convertir 1000000 USD en EUR doit donner 850000 EUR
- Sachant que le taux de change du JPY vers le franc CFA est de 0.005, convertir 1000000 JPY en francs CFA doit donner 5000 francs CFA
- Les résultats doivent être arrondis au nombre de décimales approprié pour la devise cible
//Propose des exemples
- Sachant que le taux de change de l'EUR vers l'USD est de 1.18, convertir 1 EUR en USD doit donner 1.18 USD
//Propose des exemples avec des devises autres que l'EUR et l'USD
- Sachant que le taux de change du GBP vers le JPY est de 197.71, et que le JPY n'a pas de décimale, convertir 1 GBP en JPY doit donner 197 JPY
- Sachant que le taux de change du GBP vers le TND est de 3.9711, et que le TND est à trois décimales, convertir 1 GBP en TND doit donner 3.971 TND 
- Sachant que le taux de change de l'USD vers l'EUR est de 2.7899, et que l'EUR est à deux décimales, convertir 1 USD en EUR doit donner 2.78 EUR

