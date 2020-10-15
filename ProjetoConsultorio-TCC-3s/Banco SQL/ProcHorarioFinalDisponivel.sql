Alter Procedure ProcHorarioFinalDisponivel
(
  @Data date,
  @HoraIni int
)
As
Begin
  Declare @HoraFinalPermitida int

  Set @HoraFinalPermitida = (Select Top 1 CodHorarioIni
                             From Consultas
                             Where Data = @Data
                             And CodCliente Is Not Null
                             And CodHorarioIni > @HoraIni
                             And Status = 'A'
                             Order By CodHorarioIni)

  if (@HoraFinalPermitida Is Null)
    Begin
      Select CodHorario, Horario
      From Horarios
      Where CodHorario > @HoraIni
      and CodHorario Not In (1)
    End
  Else
    Begin
      Select CodHorario, Horario
      From Horarios
      Where CodHorario > @HoraIni
      and CodHorario <= @HoraFinalPermitida
      and CodHorario Not In (1)
    End
End
Go