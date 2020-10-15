Create or Alter Procedure ProcMostrarCodigoFonte
(
  @Rotina varchar(100),
  @Maiuscula bit = 0
)
As
Begin

  Set NoCount On

  Declare @Tipo varchar(100), @AuxTipo varchar(20)

  Select @Tipo = XType
  From SysObjects(NoLock)
  Where Name = @Rotina

  Set @Tipo = ISNULL (@Tipo, '')
  if @Tipo = 'FN'
    Set @AuxTipo = 'Function'
  else if @Tipo = 'p'
    Set @AuxTipo = 'Procedure'
  else if @Tipo = 'TR'
    Set @AuxTipo = 'Trigger'
  Else
  begin
    Declare @MsgErro varchar(100)
    if @Tipo = ''
      Set @MsgErro = 'Rotina não encontrada'
    else
      Set @MsgErro = 'Tipo "' + @Tipo + '" inválido!'
    RaisError (@MsgErro, 16, 1)
  end

  Declare @Sql varchar(200)
  Declare @TabRotina Table (Linha varchar(max), Seq int identity)
  Set @Sql = 'sp_helptext ' + @Rotina
  Insert into @TabRotina (Linha)
  Exec (@Sql)

  Declare @Ini int, @Fim int, @Linha varchar(max)
  Select @Ini = 1, @Fim = IsNull (Max (Seq), 0) From @TabRotina

  While @Ini <= @Fim
  begin
    
    Select @Linha = Linha
    From @TabRotina
    Where Seq = @Ini

    if @Maiuscula = 1
      Set @Linha = Upper(@Linha)

    if @Ini = 1
      print replace(@Linha, 'create', 'Alter')
    
    else
      print @Linha

    Set @Ini = @Ini + 1
  End
End