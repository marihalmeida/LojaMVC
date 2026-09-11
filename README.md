# 🛒 LojaMVC

Projeto de sistema de e-commerce desenvolvido em **C#** utilizando a arquitetura **MVC (Model-View-Controller)** e **SQL Server**, focado na gestão de **Clientes** e **Produtos**, com uma suíte de testes funcionais desenvolvida em **xUnit**.

---

## 📌 Sobre o Projeto

O **LojaMVC** foi desenvolvido com o objetivo de demonstrar a aplicação do padrão MVC em ambiente .NET, separando claramente as responsabilidades da aplicação, gerenciando a persistência de dados no SQL Server e garantindo a qualidade do software através de testes automatizados com xUnit para validar regras de negócio fundamentais.

---

## 🛠️ Tecnologias Utilizadas

* **Linguagem:** C# (.NET)
* **Arquitetura:** MVC (Model-View-Controller)
* **Banco de Dados:** Microsoft SQL Server
* **Suíte de Testes:** xUnit

---

## 🏗️ Estrutura da Arquitetura

O projeto utiliza **Controllers** dedicados para isolar e manipular a lógica de apresentação e processamento das requisições:

* **`ClienteController`**: Responsável pelo gerenciamento, cadastro e validações das operações de Clientes.
* **`ProdutoController`**: Responsável pela manutenção do catálogo, controle de preços e estoque de Produtos.

---

## 🧪 Suíte de Testes (xUnit)

A aplicação conta com testes funcionais e de regras de negócio implementados utilizando o **xUnit**:

### 👤 Testes de Cliente
* ❌ **Validação de Idade Mínima:** Verifica se o cadastro é recusado/inválido caso o cliente seja menor de 18 anos.
* ✅ **Validação de Maioridade:** Confirma se o cliente pode realizar compras por ser maior de idade.
* 🚫 **Status do Cliente:** Verifica se o cliente com status **Inativo** é impedido de efetuar compras.

### 📦 Testes de Produto
* 💰 **Preço Positivo:** Verifica se o valor do produto é estritamente maior que zero (`> 0`).
* 📦 **Estoque Válido:** Valida se o estoque é marcado como inválido ao tentar inserir valores negativos.
* 🔤 **Nome do Produto:** Valida e rejeita cadastros com nome nulo, vazio ou inválido.
* ✅ **Validação Completa do Produto:** Valida a integridade do produto quando nome, preço e estoque estão corretos simultaneamente.

---

## 🚀 Como Executar o Projeto

### Pré-requisitos

* [.NET SDK](https://dotnet.microsoft.com/download) (versão 6.0 ou superior)
* [SQL Server](https://www.microsoft.com/pt-br/sql-server/sql-server-downloads) instalado e em execução
* IDE de sua preferência (Visual Studio, VS Code ou JetBrains Rider)

### Passo a Passo

1. **Clone o repositório:**
   ```bash
   git clone [https://github.com/seu-usuario/LojaMVC.git](https://github.com/seu-usuario/LojaMVC.git)
   cd LojaMVC
