Create or Alter Procedure ProcRemoverServico
(
  @CodServico int,
  @MsgRetorno varchar(2000) OUT,
  @IsOk bit OUT
)
As
Begin

  if exists (Select * From Consultas Where CodServico = @CodServico)
  Begin
    Set @MsgRetorno = 'O serviço não pode ser removido pois está vinculado a consultas dentro do sistema.'
    Select @MsgRetorno
    Set @IsOk = 0
  End
  Else
  Begin
    Delete From Servicos Where CodServico = @CodServico
    Set @MsgRetorno = 'Serviço removido com sucesso.'
    Select @MsgRetorno
    Set @IsOk = 1
  End

End