Create or Alter Procedure ProcHorarioInicialDisponivel
(
  @Data        date,
  @Insert      bit = Null,
  @Update      bit = Null,
  @CodConsulta int = Null
)
As
Begin

  Declare @Qtd int
  Declare @While int = 1

  Create Table #TabTemp (Seq int identity, CodConsulta int, CodHorarioIni int, CodHorarioFim int)

  if (@Insert = 1) 
  Begin

    Insert Into #TabTemp (CodConsulta, CodHorarioIni, CodHorarioFim)
    Select CodConsulta, 
           CodHorarioIni, 
           CodHorarioFim
      From Consultas
    Where Data = @Data
      and Status = 'A'
    Order By CodConsulta

    Set @Qtd = (Select Max(Seq) From #TabTemp)

    Create Table #TabHorarios1 (CodHorario int) 
     
    While (@While <= @Qtd)
    Begin
      Insert into #TabHorarios1 (CodHorario) 
      Select CodHorario As CodHorario
      From Horarios
      Where CodHorario > (Select CodHorarioIni From #TabTemp Where Seq = @While)
        and CodHorario < (Select CodHorarioFim From #TabTemp Where Seq = @While)
      
      Set @While = @While + 1
    End
    
    Select Horarios.CodHorario,
           Left(Horario,8) As Horario
    From Horarios
    Where Not Exists (Select CodHorarioIni 
                      From Consultas
                      Where Consultas.Data = @Data
                      and Status = 'A'
                      and CodHorarioIni = CodHorario)
      and Not Exists (Select CodHorario 
                      From #TabHorarios1
                      Where #TabHorarios1.CodHorario = Horarios.CodHorario)
      and CodHorario Not In (28)
    Order By CodHorario
  End


  if (@Update = 1)
  Begin
    
    Insert Into #TabTemp (CodConsulta, CodHorarioIni, CodHorarioFim)
    Select CodConsulta, 
           CodHorarioIni, 
           CodHorarioFim
      From Consultas
    Where Data = @Data
      and Status = 'A'
    Order By CodConsulta

    Set @Qtd = (Select Max(Seq) From #TabTemp)

    Create Table #TabHorarios2 (CodHorario int) 
     
    While (@While <= @Qtd)
    Begin
      Insert into #TabHorarios2 (CodHorario) 
      Select CodHorario As CodHorario
      From Horarios
      Where CodHorario > (Select CodHorarioIni From #TabTemp Where Seq = @While)
        and CodHorario < (Select CodHorarioFim From #TabTemp Where Seq = @While)
      
      Set @While = @While + 1
    End
    
    Delete From #TabHorarios2 Where #TabHorarios2.CodHorario = (Select CodHorarioIni From Consultas Where CodConsulta = @CodConsulta)

    Select Horarios.CodHorario,
           Left(Horario,8) As Horario
    From Horarios
    Where Not Exists (Select CodHorarioIni 
                      From Consultas
                      Where Consultas.Data = @Data
                      and Status = 'A'
                      and CodHorarioIni = CodHorario
                      and CodHorarioIni <> (Select CodHorarioIni From Consultas Where CodConsulta = @CodConsulta))
      and Not Exists (Select CodHorario 
                      From #TabHorarios2
                      Where #TabHorarios2.CodHorario = Horarios.CodHorario)
      and CodHorario Not In (28)
    Order By CodHorario
  End
End
