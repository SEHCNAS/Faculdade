# Conversão de Celsius para fahrenheit e kelvin
print('-- Conversão de celsius para fahrenheit e kelvin --')
try:
    TempCelsius = float(input("digite uma temperatura: "))
except ValueError as error:
    print(error)
else:
    TempFahrenheit = (1.8 * TempCelsius) + 32
    TempKelvin = TempCelsius + 273
    print("temperatura fahrenheit = %.2f" % (TempFahrenheit))
    print("temperaatura kelvin = %.2f" % (TempKelvin))
