Create or Alter Procedure ProcInserirFuncionario
(
  @Insert      bit           = Null,
  @Update      bit           = Null,
  @CodFunc     int           = Null,
  @Nome        varchar(100)  = Null,
  @CPF         varchar(14)   = Null,
  @Senha       varchar(20)   = Null,
  @Tel1        varchar(100)  = Null,
  @CEP         varchar(100)  = Null,
  @Rua         varchar(100)  = Null,
  @Numero      int           = Null,
  @Complemento varchar(100)  = Null,
  @Bairro      varchar(100)  = Null,
  @CodCidade   int           = Null,
  @CodEstado   int           = Null,
  @Ativo       bit           = 1,
  @MsgRetorno  varchar(2000) = Null OUT,
  @IsOk        bit           = Null OUT
)
As
Begin
  if (@Insert = 1)
    Begin
    if not exists (Select 1 From Funcionarios Where CPF = @CPF)
    Begin
      Insert Into Funcionarios(Nome,CPF,Senha,Tel1,CEP,Rua,Numero,Complemento,Bairro,CodCidade,Cidade,CodEstado,Estado,Ativo,Principal)
      Select @Nome        As Nome,
             @CPF         As CPF,
             @Senha       As Senha,
             @Tel1        As Tel1,
             @CEP         As CEP,
             @Rua         As Rua,
             @Numero      As Numero,
             @Complemento As Complemento,
             @Bairro      As Bairro,
             @CodCidade   As CodCidade,
             (Select Cidade.Nome From Cidade Where CodCidade = @CodCidade) As Cidade,
             @CodEstado   As CodEstado,
             (Select Estado.Nome From Estado Where CodEstado = @CodEstado) As Estado,
             @Ativo       As Ativo,
			 Principal = 0
    
      if exists (Select 1 From Funcionarios Where CPF = @CPF)
        Begin
          Set @MsgRetorno = 'Funcionário inserido com sucesso'
          Set @IsOk = 1
          Select @MsgRetorno
        End
      Else
        Begin
          Set @MsgRetorno = 'Ocorreu um problema ao inserir o funcionário, tente novamente'
          Set @IsOk = 0
          Select @MsgRetorno 
        End
    End
    Else
      Begin
        Set @MsgRetorno = 'O CPF informado já possui cadastro'
        Set @IsOk = 0
        Select @MsgRetorno
    End
  End
  if (@Update = 1)
    Begin
      if exists (Select top 1 1 From Funcionarios Where CPF = @CPF and Principal = 1) and @Ativo = 0
        Begin
		      Set @MsgRetorno = 'Esse funcionário não pode ser inativado'
			  set @IsOk = 0
          Select @MsgRetorno
		    End
		 Else
		   Begin
             Update Funcionarios Set Nome        = @Nome,
                                     Senha       = @Senha,
                                     Tel1        = @Tel1,       
                                     CEP         = @CEP,        
                                     Rua         = @Rua,        
                                     Numero      = @Numero,     
                                     Complemento = @Complemento,
                                     Bairro      = @Bairro,     
                                     CodCidade   = @CodCidade,  
                                     Cidade      = (Select Cidade.Nome From Cidade Where CodCidade = @CodCidade),
                                     CodEstado   = @CodEstado,
                                     Estado      = (Select Estado.Nome From Estado Where CodEstado = @CodEstado),
                                     Ativo       = @Ativo
             Where CodFunc = @CodFunc
             Set @MsgRetorno = 'Funcionário alterado com sucesso'
             Select @MsgRetorno
             Set @IsOk = 1
		  End
     End
End
Go