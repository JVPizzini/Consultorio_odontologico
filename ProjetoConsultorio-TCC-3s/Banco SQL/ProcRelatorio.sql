Create or Alter Procedure ProcRelatorio
(
  @indexConsulta int,
  @dtIni         DateTime,
  @dtFim         DateTime
)
As
Begin

  if(@IndexConsulta = 0)
    Begin
      Select Consultas.Data,
	    Case Consultas.Status
	      When 'C' Then 'CANCELADA'
	   When 'E' Then 'CONSULTADA' end
	   As Status,	   
	   Left (Consultas.HorarioIni , 5) Inicio, Left (Consultas.HorarioFim, 5) Fim, Clientes.Nome Cliente, Servicos.Descricao Serviço, Profissionais.Nome Doutor, Funcionarios.Nome Funcionário, MotivoCanc [Motivo de Canc.]
	   From Consultas          (Nolock)
	   Inner Join Clientes      (Nolock) On Clientes.CodCliente = Consultas.CodCliente
	   Inner Join Servicos      (Nolock) On Servicos.CodServico = Consultas.CodServico
	   Inner Join Profissionais (Nolock) On Profissionais.CodProfis = Consultas.CodProfis
	   Inner Join Funcionarios  (Nolock) On Funcionarios.CodFunc = Consultas.CodFuncInc
       Where (Consultas.Status = 'C' OR Consultas.Status = 'E') AND Consultas.Data BetWeen @dtIni and @dtFim --(Consultas.Data >= @dtIni and Consultas.Data <= @dtFim) --
	   Order By Consultas.Data, Consultas.HorarioIni
    End
      Else If (@IndexConsulta = 1)
        Begin
          Select Consultas.Data,
		    Case Consultas.Status
	          When 'C' Then 'CANCELADA'
			  When 'E' Then 'CONSULTADA' end
	       As Status,
	       Left (Consultas.HorarioIni , 5) Inicio, Left (Consultas.HorarioFim, 5) Fim, Clientes.Nome Cliente, Servicos.Descricao Serviço, Profissionais.Nome Doutor, Funcionarios.Nome Funcionário
	       From Consultas          (Nolock)
	       Inner Join Clientes      (Nolock) On Clientes.CodCliente = Consultas.CodCliente
	       Inner Join Servicos      (Nolock) On Servicos.CodServico = Consultas.CodServico
	       Inner Join Profissionais (Nolock) On Profissionais.CodProfis = Consultas.CodProfis
	       Inner Join Funcionarios  (Nolock) On Funcionarios.CodFunc = Consultas.CodFuncInc
           Where (Consultas.Status = 'E') And Consultas.Data BetWeen @dtIni and @dtFim --(Data >= @dtIni and Data <= @dtFim) 
	       Order By Consultas.Data, Consultas.HorarioIni
        End
          Else If (@IndexConsulta = 2)
		    Begin
              Select Consultas.Data,
			   Case Consultas.Status
	             When 'C' Then 'CANCELADA'
			     When 'E' Then 'CONSULTADA' end
	          As Status,
			  Left (Consultas.HorarioIni , 5) Inicio, Left (Consultas.HorarioFim, 5) Fim, Clientes.Nome Cliente, Servicos.Descricao Serviço, Profissionais.Nome Doutor, Funcionarios.Nome Funcionário, MotivoCanc [Motivo de Canc.]
	          From Consultas           (Nolock)
	          Inner Join Clientes      (Nolock) On Clientes.CodCliente = Consultas.CodCliente
	          Inner Join Servicos      (Nolock) On Servicos.CodServico = Consultas.CodServico
	          Inner Join Profissionais (Nolock) On Profissionais.CodProfis = Consultas.CodProfis
	          Inner Join Funcionarios  (Nolock) On Funcionarios.CodFunc = Consultas.CodFuncInc
              Where (Consultas.Status = 'C') And Consultas.Data BetWeen @dtIni and @dtFim --(Data >= @dtIni and Data <= @dtFim) 
	          Order By Consultas.Data, Consultas.HorarioIni
            End
End
