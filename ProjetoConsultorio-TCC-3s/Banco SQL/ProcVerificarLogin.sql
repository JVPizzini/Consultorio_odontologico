Create or Alter Procedure ProcVerificarLogin
(
    @Login    VarChar(Max),
    @Senha    VarChar(Max),
    @LoginOK  VarChar(Max) = Null OUT,
    @CodFunc           Int = Null OUT,
    @NomeFunc VarChar(Max) = Null OUT
)
As
Begin

if Exists(Select Top 1 1 From Funcionarios Where CPF = @Login and Ativo = 0)
  Begin
      Set @LoginOK = 'Funcionário inativo no sistema'
  End

Else
  Begin
    if Exists( Select Top 1 1
               From Funcionarios (Nolock)
               Where CPF = @Login and Senha = @Senha and Ativo = 1)
      Begin
        Set @LoginOK = 'OK'
        Set @CodFunc =  (Select CodFunc From Funcionarios Where CPF = @Login and Senha = @Senha )
        Set @NomeFunc = (Select Nome From Funcionarios Where CPF = @Login and Senha = @Senha )
      End
    Else
      Begin
        Set @LoginOK = 'Login/senha incorreta'
      End
      
        Select @CodFunc
        Select @NomeFunc
  End

  Select @LoginOK
End
