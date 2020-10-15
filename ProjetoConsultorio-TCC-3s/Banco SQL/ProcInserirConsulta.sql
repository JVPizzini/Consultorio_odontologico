Alter Procedure ProcInserirConsulta
(
  @Insert        int = Null,
  @Update        int = Null,
  @CodConsulta   int = Null,
  @CodProfis     int,
  @CodCliente    int,
  @CodServico    int,
  @Data          date,
  @CodHorarioIni int,
  @CodHorarioFim int,
  @CodFunc       int,
  @Status        char,
  @MsgRetorno	   varchar(max) OUT,
  @IsOk			     bit OUT,
  @Cancelamento  bit = Null,
  @MotivoCanc    varchar(max) = Null
)
As
Begin

  if (@Data < GetDate())
    Begin
      Set @MsgRetorno = 'Não é possível inserir uma consulta em data retroativa'
	  Set @IsOk = 0
      Select @MsgRetorno
    End
  Else 
    if (@Insert = 1)
      Begin
        Insert Into Consultas(CodProfis, CodCliente, CodServico, Data, CodHorarioIni, HorarioIni, CodHorarioFim, HorarioFim, CodFuncInc, DtInclusao, Status)
        Select @CodProfis       As CodProfis,
               @CodCliente      As CodCliente, 
               @CodServico      As CodServico, 
               @Data            As Data, 
               @CodHorarioIni   As CodHorarioIni, 
               (Select Horario From Horarios Where CodHorario = @CodHorarioIni) As HorarioIni, 
               @CodHorarioFim   As CodHorarioFim, 
               (Select Horario From Horarios Where CodHorario = @CodHorarioFim) As HorarioFim, 
               @CodFunc         As CodFuncInc, 
               (Select GetDate()) As DtInclusao, 
               @Status          As Status 

        Set @MsgRetorno = 'Consulta inserida com sucesso'
		Set @IsOk = 1
        Select @MsgRetorno
		Select @IsOk = 1
      End
    if (@Update = 1)
    Begin
      if (@Cancelamento = 1)
      Begin
        Update Consultas Set CodProfis     = @CodProfis,
                             CodServico    = @CodServico,
                             Data          = @Data,
                             CodHorarioIni = @CodHorarioIni,
                             HorarioIni    = (Select Horario From Horarios Where CodHorario = @CodHorarioIni),
                             CodHorarioFim = @CodHorarioFim,
                             HorarioFim    = (Select Horario From Horarios Where CodHorario = @CodHorarioFim),
                             Status        = @Status,
                             CodFuncCanc   = @CodFunc,
                             DtCancel      = GetDate(),
                             MotivoCanc    = @MotivoCanc
			  Where CodConsulta = @CodConsulta
        Set @MsgRetorno = 'Cancelamento efetuado com sucesso'
	      Set @IsOk = 1
      End
      Else 
      Begin
        Update Consultas Set CodProfis     = @CodProfis,
                             CodCliente    = @CodCliente,
                             CodServico    = @CodServico,
                             Data          = @Data,
                             CodHorarioIni = @CodHorarioIni,
                             HorarioIni    = (Select Horario From Horarios Where CodHorario = @CodHorarioIni),
                             CodHorarioFim = @CodHorarioFim,
                             HorarioFim    = (Select Horario From Horarios Where CodHorario = @CodHorarioFim),
                             Status        = @Status
			  Where CodConsulta = @CodConsulta
        Set @MsgRetorno = 'Alteração efetuada com sucesso'
	      Set @IsOk = 1
      End
    End 
End
