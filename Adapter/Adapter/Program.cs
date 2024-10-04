using Adapter;

var pessoasArray = SistemaItau.PessoasArrayString();
ICalculaValorHora calculo = new NubackAdapter();
calculo.ProcessaCalculoValorHora(pessoasArray);
