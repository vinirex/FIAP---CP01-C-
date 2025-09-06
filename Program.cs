namespace CheckPoint1;

internal static class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("=== CHECKPOINT 1 - FUNDAMENTOS C# - Turma  3ESPY ===\n");

        // ENTREGA ATÉ DIA 08/09 AS 23:59
        // Você deve criar um repositório público ou branch no github e me enviar o link pelo
        // teams antes do fim do prazo.
        // IMPORTANTE:
        // - Não haverá reposição do checkpoint.
        // - Fique atento ao prazo, nenhum trabalho será aceito após a data e vou me basear
        // - O link do seu git deve ser enviado no teams. A data e hora do recebimento do git será utilizada para verificar se foi enviado no prazo.
        // 
        
        // TODO: Implemente as chamadas de teste para demonstrar funcionamento
        // NÃO é obrigatório testar todos os caminhos/casos - apenas mostrar que funciona
        // Use valores de teste simples para validar cada implementação

        //  Treinem rodar o debugger.
        //  F9 - Coloca o breakpoint
        //  F10 - Passa sobre o método no passo a passo
        //  F11 - Entra nos métodos no passo a passo
        //  shift  + F11 - Volta do método

        
        
        Console.WriteLine("1. Testando DemonstrarTiposDados...");
        Console.WriteLine(DemonstrarTiposDados());

        Console.WriteLine("\n2. Testando CalculadoraBasica (SWITCH)...");
        Console.WriteLine(CalculadoraBasica(5, 0, '/'));
        Console.WriteLine(CalculadoraBasica(10, 5, '+'));

        Console.WriteLine("\n3. Testando ValidarIdade (IF/ELSE)...");
        Console.WriteLine(ValidarIdade(25));

        Console.WriteLine("\n4. Testando ConverterString...");
        Exemplo: Console.WriteLine(ConverterString("123", "int"));

        Console.WriteLine("\n5. Testando ClassificarNota (SWITCH)...");
        Console.WriteLine(ClassificarNota(8.5));

        Console.WriteLine("\n6. Testando GerarTabuada (FOR)...");
        Console.WriteLine(GerarTabuada(5));

        Console.WriteLine("\n7. Testando JogoAdivinhacao (WHILE)...");
        JogoAdivinhacao();

        Console.WriteLine("\n8. Testando ValidarSenha (DO-WHILE)...");
        Console.WriteLine(ValidarSenha("MinhaSenh@123"));

        Console.WriteLine("\n9. Testando AnalisarNotas (FOREACH)...");
        Console.WriteLine(AnalisarNotas(new double[]{8.5, 7.0, 9.2, 6.5, 10.0}));

        Console.WriteLine("\n10. Testando ProcessarVendas (FOREACH múltiplo)...");
        // Exemplo: Console.WriteLine(ProcessarVendas(...));

        Console.WriteLine("\n=== RESUMO: TODAS AS ESTRUTURAS FORAM TESTADAS ===");
        Console.WriteLine("✅ IF/ELSE: Testado na validação de idade");
        Console.WriteLine("✅ SWITCH: Testado na calculadora e classificação de notas");
        Console.WriteLine("✅ FOR: Testado na tabuada");
        Console.WriteLine("✅ WHILE: Testado no jogo de adivinhação");
        Console.WriteLine("✅ DO-WHILE: Testado na validação de senha");
        Console.WriteLine("✅ FOREACH: Testado na análise de notas e processamento de vendas");

        Console.WriteLine("\nPressione qualquer tecla para sair...");
        Console.ReadKey();
    }

    // =====================================================================
    // QUESTÃO 1 - VARIÁVEIS E TIPOS DE DADOS (10 pontos)
    // =====================================================================

    /// <summary>
    /// TODO: Complete o método para demonstrar diferentes tipos de dados
    /// - Declare uma variável de cada tipo primitivo (int, double, bool, char, string)
    /// - Use inferência de tipos (var) onde apropriado
    /// - Retorne uma string concatenando todos os valores
    /// </summary>
    private static string DemonstrarTiposDados()
    {
        int inteiro = 21;
        double tupla = 55.21;
        bool booleana = false;
        char tipochar = 'V';
        string texto = "Amoeba";

        var tipos  = $"Inteiro: {inteiro}, duble: {tupla}, boolean: {booleana}, Char: {tipochar}, String: {texto}  ";

        return tipos;
    }

    // =====================================================================
    // QUESTÃO 2 - OPERADORES ARITMÉTICOS (10 pontos)
    // =====================================================================

    /// <summary>
    /// TODO: Implemente uma calculadora básica usando SWITCH
    /// - Receba dois números e um operador (+, -, *, /)
    /// - Use SWITCH para selecionar a operação
    /// - Trate divisão por zero retornando 0
    /// - Para operadores inválidos, retorne -1
    /// </summary>
    private static double CalculadoraBasica(double num1, double num2, char operador)
    {
        switch (operador)
        {
            case '+':
                return num1 + num2;
            case '-':
                return num1 - num2;
            case '*':
                return num1 * num2;
            case '/':
                return num2 != 0 ? num1 / num2 : 0; // Handle division by zero
            default:
                return -1; // Invalid operator
        }
    }

    // =====================================================================
    // QUESTÃO 3 - OPERADORES RELACIONAIS E LÓGICOS (10 pontos)  
    // =====================================================================

    /// <summary>
    /// TODO: Valide se uma idade é válida para diferentes contextos usando IF/ELSE
    /// - Use IF/ELSE encadeados (não switch)
    /// - Retorna "Criança" se idade < 12
    /// - Retorna "Adolescente" se idade >= 12 e < 18  
    /// - Retorna "Adulto" se idade >= 18 e <= 65
    /// - Retorna "Idoso" se idade > 65
    /// - Retorna "Idade inválida" se idade < 0 ou > 120
    /// Use operadores relacionais e lógicos
    /// </summary>
    private static string ValidarIdade(int idade)
    {
        if (idade < 0 || idade > 120)
        {
            throw new NotImplementedException("Coloque uma idade válida");
        }
        else if (idade > 65)
        {
            return "Idoso";
        }
        else if (idade > 18)
        {
            return "Adulto";
        }
        else if (idade > 12)
        {
            return "Adolescente";
        }
        else { return "Criança"; }
    }

    // =====================================================================
    // QUESTÃO 4 - CONVERSÃO DE TIPOS (10 pontos)
    // =====================================================================

    /// <summary>
    /// TODO: Converta uma string para diferentes tipos
    /// - Tente converter 'valor' para int, double e bool
    /// - Se a conversão for bem-sucedida, retorne "Tipo: Valor convertido"
    /// - Se falhar, retorne "Conversão impossível para [tipo]"
    /// - Use TryParse para conversões seguras
    /// </summary>
    private static string ConverterString(string valor, string tipoDesejado)
    {
        switch (tipoDesejado.ToLower())
        {
            case "int":
                if (int.TryParse(valor, out int intValue))
                    return $"Tipo: int, Valor convertido: {intValue}";
                return "Conversão impossível para int";

            case "double":
                if (double.TryParse(valor, out double doubleValue))
                    return $"Tipo: double, Valor convertido: {doubleValue}";
                return "Conversão impossível para double";

            case "bool":
                if (bool.TryParse(valor, out bool boolValue))
                    return $"Tipo: bool, Valor convertido: {boolValue}";
                return "Conversão impossível para bool";

            default:
                return "Tipo desejado inválido";
        }
    }

    // =====================================================================
    // QUESTÃO 5 - ESTRUTURA CONDICIONAL SWITCH (10 pontos)
    // =====================================================================

    /// <summary>
    /// TODO: Classifique uma nota usando switch expression (C# 8+) ou switch tradicional
    /// - 9.0 a 10.0: "Excelente"
    /// - 7.0 a 8.9: "Bom" 
    /// - 5.0 a 6.9: "Regular"
    /// - 0.0 a 4.9: "Insuficiente"
    /// - Fora da faixa: "Nota inválida"
    /// </summary>
    private static string ClassificarNota(double nota)
    {
        return nota switch
        {
            >= 9.0 and <= 10.0 => "Excelente",
            >= 7.0 and < 9.0 => "Bom",
            >= 5.0 and < 7.0 => "Regular",
            >= 0.0 and < 5.0 => "Insuficiente",
            _ => "Nota inválida"
        };
    }

    // =====================================================================
    // QUESTÃO 6 - ESTRUTURA FOR (10 pontos)
    // =====================================================================

    /// <summary>
    /// TODO: OBRIGATÓRIO USAR FOR
    /// Gere a tabuada de um número de 1 a 10
    /// - Use FOR para iterar de 1 a 10
    /// - Retorne string formatada: "2 x 1 = 2\n2 x 2 = 4\n..." 
    /// - Se número for <= 0, retorne "Número inválido"
    /// </summary>
    private static string GerarTabuada(int numero)
    {
        if (numero <= 0)
        {
            return "Número inválido";
        }

        string resultado = string.Empty;
        for (int i = 1; i <= 10; i++)
        {
            resultado += $"{numero} x {i} = {numero * i}\n";
        }

        return resultado;
    }

    // =====================================================================
    // QUESTÃO 7 - ESTRUTURA WHILE (15 pontos)
    // =====================================================================

    /// <summary>
    /// TODO: OBRIGATÓRIO USAR WHILE
    /// Simule um jogo de adivinhar número com tentativas limitadas
    /// - numeroSecreto: número a ser adivinhado (1-100)
    /// - tentativas: array com os palpites do jogador
    /// - Use WHILE para percorrer as tentativas
    /// - Para cada tentativa: "Tentativa X: muito alto/baixo/correto"
    /// - Pare no acerto ou quando acabar as tentativas
    /// - Retorne string com histórico completo
    /// </summary>
    private static void JogoAdivinhacao()
    {
        Random random = new Random();
        int numSecret = random.Next(1, 100);


        Console.WriteLine("Adivinhe o numero de 1 a 100");
        int tries = 0;

        do
        {
            Console.Write("Qual numero voçê acha que é?: ");
            int guess = int.Parse(Console.ReadLine()!);

            if (guess == numSecret)
            {
                tries++;
                Console.WriteLine("***********************************************");
                Console.WriteLine($"Parabéns você acertou!!! em {tries} tentativas");
                Console.WriteLine("***********************************************");
                break;
            }
            else if (guess < numSecret)
            {
                Console.WriteLine("O numero secreto é maior");
                tries++;
            }
            else
            {
                Console.WriteLine("O numero secreto é menor");
                tries++;
            }
        }
        while (true);
    }

    // =====================================================================
    // QUESTÃO 8 - ESTRUTURA DO-WHILE (15 pontos)
    // =====================================================================

    /// <summary>
    /// TODO: OBRIGATÓRIO USAR DO-WHILE
    /// Valide uma senha seguindo critérios de segurança
    /// - A senha deve ter pelo menos 8 caracteres
    /// - Deve ter pelo menos 1 número
    /// - Deve ter pelo menos 1 letra maiúscula  
    /// - Deve ter pelo menos 1 caractere especial (!@#$%&*)
    /// - Use DO-WHILE para verificar cada critério
    /// - Retorne string explicando quais critérios não foram atendidos
    /// - Se senha válida, retorne "Senha válida"
    /// </summary>
    private static string ValidarSenha(string senha)
    {
        string erros = "";
        bool valido;
        do
        {
            erros = "";
            valido = true;

            if (senha.Length < 8)
            {
                erros += "- A senha deve ter pelo menos 8 caracteres\n";
                valido = false;
            }
            if (!senha.Any(char.IsDigit))
            {
                erros += "- Deve ter pelo menos 1 número\n";
                valido = false;
            }
            if (!senha.Any(char.IsUpper))
            {
                erros += "- Deve ter pelo menos 1 letra maiúscula\n";
                valido = false;
            }
            if (!senha.Any(c => "!@#$%&*".Contains(c)))
            {
                erros += "- Deve ter pelo menos 1 caractere especial (!@#$%&*)\n";
                valido = false;
            }
            if (!valido)
            {
                return "Senha não segue os critérios:\n" + erros.TrimEnd();
            }
        } while (!valido);

        return "Senha válida";
    }

    // =====================================================================
    // QUESTÃO 9 - ESTRUTURA FOREACH (15 pontos)
    // =====================================================================

    /// <summary>
    /// TODO: OBRIGATÓRIO USAR FOREACH
    /// Analise um array de notas de alunos
    /// - Use FOREACH para percorrer todas as notas
    /// - Calcule: média, quantidade de aprovados (>=7), maior nota, menor nota
    /// - Conte quantas notas estão em cada faixa: A(9-10), B(8-8.9), C(7-7.9), D(5-6.9), F(<5)
    /// - Retorne string formatada com todas as estatísticas
    /// - Se array vazio/null: "Nenhuma nota para analisar"
    /// </summary>
    private static string AnalisarNotas(double[] notas)
    {
        // TODO: Implementar OBRIGATORIAMENTE com FOREACH
        // Retorno exemplo: "Média: 7.5\nAprovados: 15\nMaior: 9.8\nMenor: 3.2\nA: 3, B: 4, C: 8, D: 2, F: 1"
        double media = 0;
        int aprovados = 0;
        double maior = 0;
        double menor = 10;
        Dictionary<string, int> faixas = new Dictionary<string, int> { { "A", 0 }, { "B", 0 }, { "C", 0 }, { "D", 0 }, { "F", 0 } };
        if (notas.Length < 0)
        {
            return "Nenhuma nota para analisar";
        }
        foreach (double val in notas)
        {
            media += val;
            if (val > maior)
            {
                maior = val;
            }
            if (val < menor)
            {
                menor = val;
            }
            if (val >= 9.0 && val <= 10.0)
            {
                faixas["A"] += 1;
                aprovados++;
            }
            else if (val >= 8.0 && val < 9.0)
            {
                faixas["B"] += 1;
                aprovados++;
            }
            else if (val >= 7.0 && val < 8.0)
            {
                faixas["C"] += 1;
                aprovados++;
            }
            else if (val >= 5.0 && val < 7.0)
            {
                faixas["D"] += 1;
            }
            else if (val < 5.0)
            {
                faixas["F"] += 1;
            }
        }
        string faixasResumo = "";
        foreach (var faixa in faixas)
        {
            faixasResumo += $"{faixa.Key}: {faixa.Value}, ";
        }
        if (faixasResumo.EndsWith(", "))
            faixasResumo = faixasResumo.Substring(0, faixasResumo.Length - 2);

        string resumo = $"Média: {media / notas.Length}\nAprovados: {aprovados}\nMaior: {maior}\nMenor: {menor}\n{faixasResumo}";
        return resumo;
    }

    // =====================================================================
    // QUESTÃO 10 - MULTIPLE FOREACH (DESAFIO) (20 pontos)
    // =====================================================================

    /// <summary>
    /// TODO: OBRIGATÓRIO USAR FOREACH (múltiplos)
    /// Processe vendas por categoria e calcule comissões
    /// - vendas: array com valores de vendas
    /// - categorias: array com categorias correspondentes ("A", "B", "C")
    /// - comissoes: array com percentuais de comissão por categoria (ex: A=10%, B=7%, C=5%)
    /// - Use FOREACH para percorrer vendas e categorias simultaneamente
    /// - Use FOREACH separado para encontrar a comissão da categoria
    /// - Calcule total de vendas e total de comissões por categoria
    /// - Retorne string com relatório detalhado
    /// </summary>
    private static string ProcessarVendas(double[] vendas, string[] categorias, double[] comissoes, string[] nomesCategorias)
    {
        if (vendas == null || categorias == null || comissoes == null || nomesCategorias == null ||
            vendas.Length != categorias.Length || comissoes.Length != nomesCategorias.Length)
        {
            return "Dados de entrada inválidos";
        }

        // Inicializa dicionários para acumular vendas e comissões por categoria
        Dictionary<string, double> totalVendasPorCategoria = new Dictionary<string, double>();
        Dictionary<string, double> totalComissaoPorCategoria = new Dictionary<string, double>();

        // Inicializa as categorias
        foreach (var cat in nomesCategorias)
        {
            totalVendasPorCategoria[cat] = 0;
            totalComissaoPorCategoria[cat] = 0;
        }

        // Percorre vendas e categorias simultaneamente
        int idx = 0;
        foreach (var venda in vendas)
        {
            string categoria = categorias[idx];
            double percentualComissao = 0;

            // Busca o percentual de comissão correspondente à categoria
            int catIdx = 0;
            foreach (var nomeCat in nomesCategorias)
            {
                if (nomeCat == categoria)
                {
                    percentualComissao = comissoes[catIdx];
                    break;
                }
                catIdx++;
            }

            if (totalVendasPorCategoria.ContainsKey(categoria))
            {
                totalVendasPorCategoria[categoria] += venda;
                totalComissaoPorCategoria[categoria] += venda * percentualComissao / 100.0;
            }
            idx++;
        }

        // Monta o relatório
        string relatorio = "";
        foreach (var cat in nomesCategorias)
        {
            relatorio += $"Categoria {cat}: Vendas R$ {totalVendasPorCategoria[cat]:N2}, Comissão R$ {totalComissaoPorCategoria[cat]:N2}\n";
        }

        return relatorio.TrimEnd();
    }

    // =====================================================================
    // MÉTODOS AUXILIARES (NÃO ALTERAR - APENAS PARA REFERÊNCIA)
    // =====================================================================

    /// <summary>
    /// Método de exemplo demonstrando diferença entre estático e de instância
    /// ESTÁTICO: Pertence à classe, não precisa criar objeto para usar
    /// </summary>
    private static void ExemploMetodoEstatico()
    {
        Console.WriteLine("Sou um método estático - chamado direto da classe");
    }

    /// <summary>
    /// Método de exemplo de instância (comentado pois não pode ser chamado do Main estático)
    /// DE INSTÂNCIA: Pertence ao objeto, precisa criar instância da classe
    /// </summary>
    /*
    void ExemploMetodoInstancia()
    {
        Console.WriteLine("Sou um método de instância - preciso de um objeto para ser chamado");
    }
    */
}