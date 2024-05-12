# TossInfra
```mermaid
classDiagram
    class TossAPIService {
        -HttpClient _httpClient
        -IConfiguration _configuration
        +결제생성Async(결제생성Request) Task<결제생성Response>
        +결제승인Async(결제승인Request) Task<HttpResponseMessage>
        +결제환불Async(결제환불Request) Task<HttpResponseMessage>
        +결제상태확인Async(결제상태확인Request) Task<결제상태확인Response>
        -SendRequestAsync~T~(string, object) Task~T~
    }

    TossAPIService --> HttpClient : Uses
    TossAPIService --> IConfiguration : Uses

    TossAPIService : 결제생성Async(결제생성Request)
    TossAPIService : 결제승인Async(결제승인Request)
    TossAPIService : 결제환불Async(결제환불Request)
    TossAPIService : 결제상태확인Async(결제상태확인Request)
    TossAPIService : SendRequestAsync~T~(string url, object request)

    class HttpClient {
        <<external>>
    }
    class IConfiguration {
        <<external>>
    }

    note right of TossAPIService : SendRequestAsync is a private method\n that handles all HTTP requests.

```
