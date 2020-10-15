Alter Procedure ProcGridData
(
  @Data date
)
As
Begin

  Select Consultas.CodConsulta As [Código],
		 Left(HorarioIni, 5)   As [Início],
         Left(HorarioFim, 5)   As [Fim],
         Clientes.Nome         As [Paciente],
         Servicos.Descricao    As [Serviço],
         Profissionais.Nome    As [Profissional]
  From Consultas
  Inner Join Clientes On Clientes.CodCliente = Consultas.CodCliente
  Inner Join Servicos On Servicos.CodServico = Consultas.CodServico
  Inner Join Profissionais On Profissionais.CodProfis = Consultas.CodProfis
  Where Data = @Data
  and Status = 'A'
  Order By HorarioIni

End