Create or Alter Procedure ProcBuscarAgendamento
(
  @dtIni         Date,
  @dtFim         Date
)
As
Begin

    Begin
      Select Consultas.CodConsulta Código,
			 Consultas.Data,
			 Left (Consultas.HorarioIni , 5) Inicio 
            ,Left (Consultas.HorarioFim, 5) Fim, 
             Clientes.Nome Cliente,
             Servicos.Descricao Serviço,
             Profissionais.Nome Doutor
             --Funcionarios.Nome Funcionário
       From Consultas          (Nolock)
       Inner Join Clientes      (Nolock) On Clientes.CodCliente = Consultas.CodCliente
       Inner Join Servicos      (Nolock) On Servicos.CodServico = Consultas.CodServico
       Inner Join Profissionais (Nolock) On Profissionais.CodProfis = Consultas.CodProfis
       Inner Join Funcionarios  (Nolock) On Funcionarios.CodFunc = Consultas.CodFuncInc
       Where Consultas.Status = 'A' AND Consultas.Data BetWeen @dtIni and @dtFim --(Consultas.Data >= @dtIni and Consultas.Data <= @dtFim)
       Order By Consultas.Data, Consultas.HorarioIni
    End
End