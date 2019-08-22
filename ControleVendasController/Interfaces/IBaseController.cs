﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleVendasController.Interfaces
{
    public interface IBaseController<T>
    {
        T Inserir(T model);

        void Alterar(T model);

        void Excluir(T model);

        T ListarPorId(long id);

        List<T> ListarTodos(string where);
    }
}
