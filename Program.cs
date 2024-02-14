using System.Text;
using System.Text.Json;
using Azure;

// 添加 Azure OpenAI 套件
using Azure.AI.OpenAI;

string? oaiEndpoint = "https://👉endppoint👈.openai.azure.com";
string? oaiKey = "👉api_key👈";
string? oaiModelName = "👉DeploymentName👈";
string? UserPrompt = "";

// 初始化 Azure OpenAI 物件
OpenAIClient client = new OpenAIClient(new Uri(oaiEndpoint), new AzureKeyCredential(oaiKey));

while (true)
{
    // 輸入問題
    Console.Write("\n請輸入您的問題(輸入'exit'離開): ");
    UserPrompt = Console.ReadLine();
    if (UserPrompt == "exit") break;

    // 建立 ChatCompletionsOptions參數 物件
    ChatCompletionsOptions chatCompletionsOptions = new ChatCompletionsOptions()
    {
        // 設定對話訊息
        Messages =
        {
            new ChatMessage(ChatRole.System, "您是一個有用的AI助手。"),
            new ChatMessage(ChatRole.User, " \n" + UserPrompt),
        },
        MaxTokens = 300, // 最大字數
        Temperature = 0.7f, // 溫度
        DeploymentName = oaiModelName // 部署名稱
    };

    // 呼叫 API 發送請求至 Azure OpenAI 模型
    ChatCompletions response = client.GetChatCompletions(chatCompletionsOptions);
    // 取得回覆訊息
    string completion = response.Choices[0].Message.Content;
    // 顯示回覆訊息
    Console.WriteLine("回覆訊息: \n" + completion + "\n");
}
