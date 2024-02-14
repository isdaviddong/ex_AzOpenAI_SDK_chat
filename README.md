## Example Azure OpenAI SDK ChatCompletion 
> 這段程式碼的主要目的是使用 Azure OpenAI 來實現一個簡單的 AI 聊天機器人，用戶可以輸入問題，程式碼會將問題傳送到 Azure OpenAI 模型，並將模型的回覆顯示給用戶。

以下是詳細的步驟說明：
1. 首先，程式碼引入了所需的命名空間，包括 System.Text, System.Text.Json, Azure 和 Azure.AI.OpenAI。
2. 接著，程式碼定義了一些變數，包括 oaiEndpoint（OpenAI 的端點 URL）、oaiKey（OpenAI 的金鑰）、oaiModelName（OpenAI 的模型名稱）和 UserPrompt（用戶的問題）。
3. 程式碼然後初始化了一個 OpenAIClient 物件，並將 oaiEndpoint 和 oaiKey 作為參數傳入。
4. 在無窮迴圈中，程式碼首先提示用戶輸入問題，並讀取用戶的輸入。如果用戶輸入的是 "exit"，則跳出迴圈。
5. 程式碼接著建立了一個 ChatCompletionsOptions 物件，並設定了對話訊息、最大字數、溫度和部署名稱等參數。
6. 程式碼然後呼叫 GetChatCompletions 方法，將 ChatCompletionsOptions 物件傳入，並從 Azure OpenAI 模型獲取回覆。
7. 最後，程式碼從回覆中取得訊息內容，並將其顯示出來。

