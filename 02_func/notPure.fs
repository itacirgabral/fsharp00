let notPure arq =
    System.DateTime.Now.Second * (if arq % 2 = 0 then 2 else 1)