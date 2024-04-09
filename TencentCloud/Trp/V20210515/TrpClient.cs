/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

namespace TencentCloud.Trp.V20210515
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Trp.V20210515.Models;

   public class TrpClient : AbstractClient{

       private const string endpoint = "trp.tencentcloudapi.com";
       private const string version = "2021-05-15";
       private const string sdkVersion = "SDK_NET_3.0.982";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public TrpClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public TrpClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 接收客户侧的用户已授权的号码。
        /// </summary>
        /// <param name="req"><see cref="AuthorizedTransferRequest"/></param>
        /// <returns><see cref="AuthorizedTransferResponse"/></returns>
        public Task<AuthorizedTransferResponse> AuthorizedTransfer(AuthorizedTransferRequest req)
        {
            return InternalRequestAsync<AuthorizedTransferResponse>(req, "AuthorizedTransfer");
        }

        /// <summary>
        /// 接收客户侧的用户已授权的号码。
        /// </summary>
        /// <param name="req"><see cref="AuthorizedTransferRequest"/></param>
        /// <returns><see cref="AuthorizedTransferResponse"/></returns>
        public AuthorizedTransferResponse AuthorizedTransferSync(AuthorizedTransferRequest req)
        {
            return InternalRequestAsync<AuthorizedTransferResponse>(req, "AuthorizedTransfer")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 新增批次
        /// </summary>
        /// <param name="req"><see cref="CreateCodeBatchRequest"/></param>
        /// <returns><see cref="CreateCodeBatchResponse"/></returns>
        public Task<CreateCodeBatchResponse> CreateCodeBatch(CreateCodeBatchRequest req)
        {
            return InternalRequestAsync<CreateCodeBatchResponse>(req, "CreateCodeBatch");
        }

        /// <summary>
        /// 新增批次
        /// </summary>
        /// <param name="req"><see cref="CreateCodeBatchRequest"/></param>
        /// <returns><see cref="CreateCodeBatchResponse"/></returns>
        public CreateCodeBatchResponse CreateCodeBatchSync(CreateCodeBatchRequest req)
        {
            return InternalRequestAsync<CreateCodeBatchResponse>(req, "CreateCodeBatch")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 生成普通码包
        /// </summary>
        /// <param name="req"><see cref="CreateCodePackRequest"/></param>
        /// <returns><see cref="CreateCodePackResponse"/></returns>
        public Task<CreateCodePackResponse> CreateCodePack(CreateCodePackRequest req)
        {
            return InternalRequestAsync<CreateCodePackResponse>(req, "CreateCodePack");
        }

        /// <summary>
        /// 生成普通码包
        /// </summary>
        /// <param name="req"><see cref="CreateCodePackRequest"/></param>
        /// <returns><see cref="CreateCodePackResponse"/></returns>
        public CreateCodePackResponse CreateCodePackSync(CreateCodePackRequest req)
        {
            return InternalRequestAsync<CreateCodePackResponse>(req, "CreateCodePack")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 以订单方式新建企业信息/配额信息
        /// </summary>
        /// <param name="req"><see cref="CreateCorporationOrderRequest"/></param>
        /// <returns><see cref="CreateCorporationOrderResponse"/></returns>
        public Task<CreateCorporationOrderResponse> CreateCorporationOrder(CreateCorporationOrderRequest req)
        {
            return InternalRequestAsync<CreateCorporationOrderResponse>(req, "CreateCorporationOrder");
        }

        /// <summary>
        /// 以订单方式新建企业信息/配额信息
        /// </summary>
        /// <param name="req"><see cref="CreateCorporationOrderRequest"/></param>
        /// <returns><see cref="CreateCorporationOrderResponse"/></returns>
        public CreateCorporationOrderResponse CreateCorporationOrderSync(CreateCorporationOrderRequest req)
        {
            return InternalRequestAsync<CreateCorporationOrderResponse>(req, "CreateCorporationOrder")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 生成自定义码包
        /// </summary>
        /// <param name="req"><see cref="CreateCustomPackRequest"/></param>
        /// <returns><see cref="CreateCustomPackResponse"/></returns>
        public Task<CreateCustomPackResponse> CreateCustomPack(CreateCustomPackRequest req)
        {
            return InternalRequestAsync<CreateCustomPackResponse>(req, "CreateCustomPack");
        }

        /// <summary>
        /// 生成自定义码包
        /// </summary>
        /// <param name="req"><see cref="CreateCustomPackRequest"/></param>
        /// <returns><see cref="CreateCustomPackResponse"/></returns>
        public CreateCustomPackResponse CreateCustomPackSync(CreateCustomPackRequest req)
        {
            return InternalRequestAsync<CreateCustomPackResponse>(req, "CreateCustomPack")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 新建自定义码规则
        /// </summary>
        /// <param name="req"><see cref="CreateCustomRuleRequest"/></param>
        /// <returns><see cref="CreateCustomRuleResponse"/></returns>
        public Task<CreateCustomRuleResponse> CreateCustomRule(CreateCustomRuleRequest req)
        {
            return InternalRequestAsync<CreateCustomRuleResponse>(req, "CreateCustomRule");
        }

        /// <summary>
        /// 新建自定义码规则
        /// </summary>
        /// <param name="req"><see cref="CreateCustomRuleRequest"/></param>
        /// <returns><see cref="CreateCustomRuleResponse"/></returns>
        public CreateCustomRuleResponse CreateCustomRuleSync(CreateCustomRuleRequest req)
        {
            return InternalRequestAsync<CreateCustomRuleResponse>(req, "CreateCustomRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 新建商户
        /// </summary>
        /// <param name="req"><see cref="CreateMerchantRequest"/></param>
        /// <returns><see cref="CreateMerchantResponse"/></returns>
        public Task<CreateMerchantResponse> CreateMerchant(CreateMerchantRequest req)
        {
            return InternalRequestAsync<CreateMerchantResponse>(req, "CreateMerchant");
        }

        /// <summary>
        /// 新建商户
        /// </summary>
        /// <param name="req"><see cref="CreateMerchantRequest"/></param>
        /// <returns><see cref="CreateMerchantResponse"/></returns>
        public CreateMerchantResponse CreateMerchantSync(CreateMerchantRequest req)
        {
            return InternalRequestAsync<CreateMerchantResponse>(req, "CreateMerchant")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 新建商品
        /// </summary>
        /// <param name="req"><see cref="CreateProductRequest"/></param>
        /// <returns><see cref="CreateProductResponse"/></returns>
        public Task<CreateProductResponse> CreateProduct(CreateProductRequest req)
        {
            return InternalRequestAsync<CreateProductResponse>(req, "CreateProduct");
        }

        /// <summary>
        /// 新建商品
        /// </summary>
        /// <param name="req"><see cref="CreateProductRequest"/></param>
        /// <returns><see cref="CreateProductResponse"/></returns>
        public CreateProductResponse CreateProductSync(CreateProductRequest req)
        {
            return InternalRequestAsync<CreateProductResponse>(req, "CreateProduct")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 上链溯源信息
        /// </summary>
        /// <param name="req"><see cref="CreateTraceChainRequest"/></param>
        /// <returns><see cref="CreateTraceChainResponse"/></returns>
        public Task<CreateTraceChainResponse> CreateTraceChain(CreateTraceChainRequest req)
        {
            return InternalRequestAsync<CreateTraceChainResponse>(req, "CreateTraceChain");
        }

        /// <summary>
        /// 上链溯源信息
        /// </summary>
        /// <param name="req"><see cref="CreateTraceChainRequest"/></param>
        /// <returns><see cref="CreateTraceChainResponse"/></returns>
        public CreateTraceChainResponse CreateTraceChainSync(CreateTraceChainRequest req)
        {
            return InternalRequestAsync<CreateTraceChainResponse>(req, "CreateTraceChain")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 批量绑定指定批次并激活二维码，只支持平台发的码，且只会激活没有使用过的码
        /// </summary>
        /// <param name="req"><see cref="CreateTraceCodesRequest"/></param>
        /// <returns><see cref="CreateTraceCodesResponse"/></returns>
        public Task<CreateTraceCodesResponse> CreateTraceCodes(CreateTraceCodesRequest req)
        {
            return InternalRequestAsync<CreateTraceCodesResponse>(req, "CreateTraceCodes");
        }

        /// <summary>
        /// 批量绑定指定批次并激活二维码，只支持平台发的码，且只会激活没有使用过的码
        /// </summary>
        /// <param name="req"><see cref="CreateTraceCodesRequest"/></param>
        /// <returns><see cref="CreateTraceCodesResponse"/></returns>
        public CreateTraceCodesResponse CreateTraceCodesSync(CreateTraceCodesRequest req)
        {
            return InternalRequestAsync<CreateTraceCodesResponse>(req, "CreateTraceCodes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 异步导入激活码包，如果是第三方码包，需要域名跟配置的匹配
        /// </summary>
        /// <param name="req"><see cref="CreateTraceCodesAsyncRequest"/></param>
        /// <returns><see cref="CreateTraceCodesAsyncResponse"/></returns>
        public Task<CreateTraceCodesAsyncResponse> CreateTraceCodesAsync(CreateTraceCodesAsyncRequest req)
        {
            return InternalRequestAsync<CreateTraceCodesAsyncResponse>(req, "CreateTraceCodesAsync");
        }

        /// <summary>
        /// 异步导入激活码包，如果是第三方码包，需要域名跟配置的匹配
        /// </summary>
        /// <param name="req"><see cref="CreateTraceCodesAsyncRequest"/></param>
        /// <returns><see cref="CreateTraceCodesAsyncResponse"/></returns>
        public CreateTraceCodesAsyncResponse CreateTraceCodesAsyncSync(CreateTraceCodesAsyncRequest req)
        {
            return InternalRequestAsync<CreateTraceCodesAsyncResponse>(req, "CreateTraceCodesAsync")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 新增溯源信息
        /// </summary>
        /// <param name="req"><see cref="CreateTraceDataRequest"/></param>
        /// <returns><see cref="CreateTraceDataResponse"/></returns>
        public Task<CreateTraceDataResponse> CreateTraceData(CreateTraceDataRequest req)
        {
            return InternalRequestAsync<CreateTraceDataResponse>(req, "CreateTraceData");
        }

        /// <summary>
        /// 新增溯源信息
        /// </summary>
        /// <param name="req"><see cref="CreateTraceDataRequest"/></param>
        /// <returns><see cref="CreateTraceDataResponse"/></returns>
        public CreateTraceDataResponse CreateTraceDataSync(CreateTraceDataRequest req)
        {
            return InternalRequestAsync<CreateTraceDataResponse>(req, "CreateTraceData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除批次
        /// </summary>
        /// <param name="req"><see cref="DeleteCodeBatchRequest"/></param>
        /// <returns><see cref="DeleteCodeBatchResponse"/></returns>
        public Task<DeleteCodeBatchResponse> DeleteCodeBatch(DeleteCodeBatchRequest req)
        {
            return InternalRequestAsync<DeleteCodeBatchResponse>(req, "DeleteCodeBatch");
        }

        /// <summary>
        /// 删除批次
        /// </summary>
        /// <param name="req"><see cref="DeleteCodeBatchRequest"/></param>
        /// <returns><see cref="DeleteCodeBatchResponse"/></returns>
        public DeleteCodeBatchResponse DeleteCodeBatchSync(DeleteCodeBatchRequest req)
        {
            return InternalRequestAsync<DeleteCodeBatchResponse>(req, "DeleteCodeBatch")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除商户
        /// </summary>
        /// <param name="req"><see cref="DeleteMerchantRequest"/></param>
        /// <returns><see cref="DeleteMerchantResponse"/></returns>
        public Task<DeleteMerchantResponse> DeleteMerchant(DeleteMerchantRequest req)
        {
            return InternalRequestAsync<DeleteMerchantResponse>(req, "DeleteMerchant");
        }

        /// <summary>
        /// 删除商户
        /// </summary>
        /// <param name="req"><see cref="DeleteMerchantRequest"/></param>
        /// <returns><see cref="DeleteMerchantResponse"/></returns>
        public DeleteMerchantResponse DeleteMerchantSync(DeleteMerchantRequest req)
        {
            return InternalRequestAsync<DeleteMerchantResponse>(req, "DeleteMerchant")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除商品，如果商品被使用，则不可删除
        /// </summary>
        /// <param name="req"><see cref="DeleteProductRequest"/></param>
        /// <returns><see cref="DeleteProductResponse"/></returns>
        public Task<DeleteProductResponse> DeleteProduct(DeleteProductRequest req)
        {
            return InternalRequestAsync<DeleteProductResponse>(req, "DeleteProduct");
        }

        /// <summary>
        /// 删除商品，如果商品被使用，则不可删除
        /// </summary>
        /// <param name="req"><see cref="DeleteProductRequest"/></param>
        /// <returns><see cref="DeleteProductResponse"/></returns>
        public DeleteProductResponse DeleteProductSync(DeleteProductRequest req)
        {
            return InternalRequestAsync<DeleteProductResponse>(req, "DeleteProduct")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除溯源信息，如果已经上链则不可删除
        /// </summary>
        /// <param name="req"><see cref="DeleteTraceDataRequest"/></param>
        /// <returns><see cref="DeleteTraceDataResponse"/></returns>
        public Task<DeleteTraceDataResponse> DeleteTraceData(DeleteTraceDataRequest req)
        {
            return InternalRequestAsync<DeleteTraceDataResponse>(req, "DeleteTraceData");
        }

        /// <summary>
        /// 删除溯源信息，如果已经上链则不可删除
        /// </summary>
        /// <param name="req"><see cref="DeleteTraceDataRequest"/></param>
        /// <returns><see cref="DeleteTraceDataResponse"/></returns>
        public DeleteTraceDataResponse DeleteTraceDataSync(DeleteTraceDataRequest req)
        {
            return InternalRequestAsync<DeleteTraceDataResponse>(req, "DeleteTraceData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询渠道企业列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAgentCorpsRequest"/></param>
        /// <returns><see cref="DescribeAgentCorpsResponse"/></returns>
        public Task<DescribeAgentCorpsResponse> DescribeAgentCorps(DescribeAgentCorpsRequest req)
        {
            return InternalRequestAsync<DescribeAgentCorpsResponse>(req, "DescribeAgentCorps");
        }

        /// <summary>
        /// 查询渠道企业列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAgentCorpsRequest"/></param>
        /// <returns><see cref="DescribeAgentCorpsResponse"/></returns>
        public DescribeAgentCorpsResponse DescribeAgentCorpsSync(DescribeAgentCorpsRequest req)
        {
            return InternalRequestAsync<DescribeAgentCorpsResponse>(req, "DescribeAgentCorps")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询批次信息
        /// </summary>
        /// <param name="req"><see cref="DescribeCodeBatchByIdRequest"/></param>
        /// <returns><see cref="DescribeCodeBatchByIdResponse"/></returns>
        public Task<DescribeCodeBatchByIdResponse> DescribeCodeBatchById(DescribeCodeBatchByIdRequest req)
        {
            return InternalRequestAsync<DescribeCodeBatchByIdResponse>(req, "DescribeCodeBatchById");
        }

        /// <summary>
        /// 查询批次信息
        /// </summary>
        /// <param name="req"><see cref="DescribeCodeBatchByIdRequest"/></param>
        /// <returns><see cref="DescribeCodeBatchByIdResponse"/></returns>
        public DescribeCodeBatchByIdResponse DescribeCodeBatchByIdSync(DescribeCodeBatchByIdRequest req)
        {
            return InternalRequestAsync<DescribeCodeBatchByIdResponse>(req, "DescribeCodeBatchById")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询批次列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCodeBatchesRequest"/></param>
        /// <returns><see cref="DescribeCodeBatchesResponse"/></returns>
        public Task<DescribeCodeBatchesResponse> DescribeCodeBatches(DescribeCodeBatchesRequest req)
        {
            return InternalRequestAsync<DescribeCodeBatchesResponse>(req, "DescribeCodeBatches");
        }

        /// <summary>
        /// 查询批次列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCodeBatchesRequest"/></param>
        /// <returns><see cref="DescribeCodeBatchesResponse"/></returns>
        public DescribeCodeBatchesResponse DescribeCodeBatchesSync(DescribeCodeBatchesRequest req)
        {
            return InternalRequestAsync<DescribeCodeBatchesResponse>(req, "DescribeCodeBatches")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询批次列表
        /// 
        /// 旧版接口已经弃用，新业务请使用新版的接口 DescribeCodeBatches
        /// </summary>
        /// <param name="req"><see cref="DescribeCodeBatchsRequest"/></param>
        /// <returns><see cref="DescribeCodeBatchsResponse"/></returns>
        public Task<DescribeCodeBatchsResponse> DescribeCodeBatchs(DescribeCodeBatchsRequest req)
        {
            return InternalRequestAsync<DescribeCodeBatchsResponse>(req, "DescribeCodeBatchs");
        }

        /// <summary>
        /// 查询批次列表
        /// 
        /// 旧版接口已经弃用，新业务请使用新版的接口 DescribeCodeBatches
        /// </summary>
        /// <param name="req"><see cref="DescribeCodeBatchsRequest"/></param>
        /// <returns><see cref="DescribeCodeBatchsResponse"/></returns>
        public DescribeCodeBatchsResponse DescribeCodeBatchsSync(DescribeCodeBatchsRequest req)
        {
            return InternalRequestAsync<DescribeCodeBatchsResponse>(req, "DescribeCodeBatchs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询码包状态
        /// </summary>
        /// <param name="req"><see cref="DescribeCodePackStatusRequest"/></param>
        /// <returns><see cref="DescribeCodePackStatusResponse"/></returns>
        public Task<DescribeCodePackStatusResponse> DescribeCodePackStatus(DescribeCodePackStatusRequest req)
        {
            return InternalRequestAsync<DescribeCodePackStatusResponse>(req, "DescribeCodePackStatus");
        }

        /// <summary>
        /// 查询码包状态
        /// </summary>
        /// <param name="req"><see cref="DescribeCodePackStatusRequest"/></param>
        /// <returns><see cref="DescribeCodePackStatusResponse"/></returns>
        public DescribeCodePackStatusResponse DescribeCodePackStatusSync(DescribeCodePackStatusRequest req)
        {
            return InternalRequestAsync<DescribeCodePackStatusResponse>(req, "DescribeCodePackStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询码包地址
        /// </summary>
        /// <param name="req"><see cref="DescribeCodePackUrlRequest"/></param>
        /// <returns><see cref="DescribeCodePackUrlResponse"/></returns>
        public Task<DescribeCodePackUrlResponse> DescribeCodePackUrl(DescribeCodePackUrlRequest req)
        {
            return InternalRequestAsync<DescribeCodePackUrlResponse>(req, "DescribeCodePackUrl");
        }

        /// <summary>
        /// 查询码包地址
        /// </summary>
        /// <param name="req"><see cref="DescribeCodePackUrlRequest"/></param>
        /// <returns><see cref="DescribeCodePackUrlResponse"/></returns>
        public DescribeCodePackUrlResponse DescribeCodePackUrlSync(DescribeCodePackUrlRequest req)
        {
            return InternalRequestAsync<DescribeCodePackUrlResponse>(req, "DescribeCodePackUrl")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询码包列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCodePacksRequest"/></param>
        /// <returns><see cref="DescribeCodePacksResponse"/></returns>
        public Task<DescribeCodePacksResponse> DescribeCodePacks(DescribeCodePacksRequest req)
        {
            return InternalRequestAsync<DescribeCodePacksResponse>(req, "DescribeCodePacks");
        }

        /// <summary>
        /// 查询码包列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCodePacksRequest"/></param>
        /// <returns><see cref="DescribeCodePacksResponse"/></returns>
        public DescribeCodePacksResponse DescribeCodePacksSync(DescribeCodePacksRequest req)
        {
            return InternalRequestAsync<DescribeCodePacksResponse>(req, "DescribeCodePacks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询码包的二维码列表，上限 3 万
        /// </summary>
        /// <param name="req"><see cref="DescribeCodesByPackRequest"/></param>
        /// <returns><see cref="DescribeCodesByPackResponse"/></returns>
        public Task<DescribeCodesByPackResponse> DescribeCodesByPack(DescribeCodesByPackRequest req)
        {
            return InternalRequestAsync<DescribeCodesByPackResponse>(req, "DescribeCodesByPack");
        }

        /// <summary>
        /// 查询码包的二维码列表，上限 3 万
        /// </summary>
        /// <param name="req"><see cref="DescribeCodesByPackRequest"/></param>
        /// <returns><see cref="DescribeCodesByPackResponse"/></returns>
        public DescribeCodesByPackResponse DescribeCodesByPackSync(DescribeCodesByPackRequest req)
        {
            return InternalRequestAsync<DescribeCodesByPackResponse>(req, "DescribeCodesByPack")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询渠道商下属企业额度使用情况
        /// </summary>
        /// <param name="req"><see cref="DescribeCorpQuotasRequest"/></param>
        /// <returns><see cref="DescribeCorpQuotasResponse"/></returns>
        public Task<DescribeCorpQuotasResponse> DescribeCorpQuotas(DescribeCorpQuotasRequest req)
        {
            return InternalRequestAsync<DescribeCorpQuotasResponse>(req, "DescribeCorpQuotas");
        }

        /// <summary>
        /// 查询渠道商下属企业额度使用情况
        /// </summary>
        /// <param name="req"><see cref="DescribeCorpQuotasRequest"/></param>
        /// <returns><see cref="DescribeCorpQuotasResponse"/></returns>
        public DescribeCorpQuotasResponse DescribeCorpQuotasSync(DescribeCorpQuotasRequest req)
        {
            return InternalRequestAsync<DescribeCorpQuotasResponse>(req, "DescribeCorpQuotas")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查自定义码规则
        /// </summary>
        /// <param name="req"><see cref="DescribeCustomRuleByIdRequest"/></param>
        /// <returns><see cref="DescribeCustomRuleByIdResponse"/></returns>
        public Task<DescribeCustomRuleByIdResponse> DescribeCustomRuleById(DescribeCustomRuleByIdRequest req)
        {
            return InternalRequestAsync<DescribeCustomRuleByIdResponse>(req, "DescribeCustomRuleById");
        }

        /// <summary>
        /// 查自定义码规则
        /// </summary>
        /// <param name="req"><see cref="DescribeCustomRuleByIdRequest"/></param>
        /// <returns><see cref="DescribeCustomRuleByIdResponse"/></returns>
        public DescribeCustomRuleByIdResponse DescribeCustomRuleByIdSync(DescribeCustomRuleByIdRequest req)
        {
            return InternalRequestAsync<DescribeCustomRuleByIdResponse>(req, "DescribeCustomRuleById")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查自定义码规则列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCustomRulesRequest"/></param>
        /// <returns><see cref="DescribeCustomRulesResponse"/></returns>
        public Task<DescribeCustomRulesResponse> DescribeCustomRules(DescribeCustomRulesRequest req)
        {
            return InternalRequestAsync<DescribeCustomRulesResponse>(req, "DescribeCustomRules");
        }

        /// <summary>
        /// 查自定义码规则列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCustomRulesRequest"/></param>
        /// <returns><see cref="DescribeCustomRulesResponse"/></returns>
        public DescribeCustomRulesResponse DescribeCustomRulesSync(DescribeCustomRulesRequest req)
        {
            return InternalRequestAsync<DescribeCustomRulesResponse>(req, "DescribeCustomRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取异步任务的输出地址
        /// </summary>
        /// <param name="req"><see cref="DescribeJobFileUrlRequest"/></param>
        /// <returns><see cref="DescribeJobFileUrlResponse"/></returns>
        public Task<DescribeJobFileUrlResponse> DescribeJobFileUrl(DescribeJobFileUrlRequest req)
        {
            return InternalRequestAsync<DescribeJobFileUrlResponse>(req, "DescribeJobFileUrl");
        }

        /// <summary>
        /// 获取异步任务的输出地址
        /// </summary>
        /// <param name="req"><see cref="DescribeJobFileUrlRequest"/></param>
        /// <returns><see cref="DescribeJobFileUrlResponse"/></returns>
        public DescribeJobFileUrlResponse DescribeJobFileUrlSync(DescribeJobFileUrlRequest req)
        {
            return InternalRequestAsync<DescribeJobFileUrlResponse>(req, "DescribeJobFileUrl")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询商户信息
        /// </summary>
        /// <param name="req"><see cref="DescribeMerchantByIdRequest"/></param>
        /// <returns><see cref="DescribeMerchantByIdResponse"/></returns>
        public Task<DescribeMerchantByIdResponse> DescribeMerchantById(DescribeMerchantByIdRequest req)
        {
            return InternalRequestAsync<DescribeMerchantByIdResponse>(req, "DescribeMerchantById");
        }

        /// <summary>
        /// 查询商户信息
        /// </summary>
        /// <param name="req"><see cref="DescribeMerchantByIdRequest"/></param>
        /// <returns><see cref="DescribeMerchantByIdResponse"/></returns>
        public DescribeMerchantByIdResponse DescribeMerchantByIdSync(DescribeMerchantByIdRequest req)
        {
            return InternalRequestAsync<DescribeMerchantByIdResponse>(req, "DescribeMerchantById")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询商户列表
        /// </summary>
        /// <param name="req"><see cref="DescribeMerchantsRequest"/></param>
        /// <returns><see cref="DescribeMerchantsResponse"/></returns>
        public Task<DescribeMerchantsResponse> DescribeMerchants(DescribeMerchantsRequest req)
        {
            return InternalRequestAsync<DescribeMerchantsResponse>(req, "DescribeMerchants");
        }

        /// <summary>
        /// 查询商户列表
        /// </summary>
        /// <param name="req"><see cref="DescribeMerchantsRequest"/></param>
        /// <returns><see cref="DescribeMerchantsResponse"/></returns>
        public DescribeMerchantsResponse DescribeMerchantsSync(DescribeMerchantsRequest req)
        {
            return InternalRequestAsync<DescribeMerchantsResponse>(req, "DescribeMerchants")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询安心计划二维码扫码记录
        /// </summary>
        /// <param name="req"><see cref="DescribePlanQRCodeScanRecordsRequest"/></param>
        /// <returns><see cref="DescribePlanQRCodeScanRecordsResponse"/></returns>
        public Task<DescribePlanQRCodeScanRecordsResponse> DescribePlanQRCodeScanRecords(DescribePlanQRCodeScanRecordsRequest req)
        {
            return InternalRequestAsync<DescribePlanQRCodeScanRecordsResponse>(req, "DescribePlanQRCodeScanRecords");
        }

        /// <summary>
        /// 查询安心计划二维码扫码记录
        /// </summary>
        /// <param name="req"><see cref="DescribePlanQRCodeScanRecordsRequest"/></param>
        /// <returns><see cref="DescribePlanQRCodeScanRecordsResponse"/></returns>
        public DescribePlanQRCodeScanRecordsResponse DescribePlanQRCodeScanRecordsSync(DescribePlanQRCodeScanRecordsRequest req)
        {
            return InternalRequestAsync<DescribePlanQRCodeScanRecordsResponse>(req, "DescribePlanQRCodeScanRecords")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询安心计划二维码列表
        /// </summary>
        /// <param name="req"><see cref="DescribePlanQRCodesRequest"/></param>
        /// <returns><see cref="DescribePlanQRCodesResponse"/></returns>
        public Task<DescribePlanQRCodesResponse> DescribePlanQRCodes(DescribePlanQRCodesRequest req)
        {
            return InternalRequestAsync<DescribePlanQRCodesResponse>(req, "DescribePlanQRCodes");
        }

        /// <summary>
        /// 查询安心计划二维码列表
        /// </summary>
        /// <param name="req"><see cref="DescribePlanQRCodesRequest"/></param>
        /// <returns><see cref="DescribePlanQRCodesResponse"/></returns>
        public DescribePlanQRCodesResponse DescribePlanQRCodesSync(DescribePlanQRCodesRequest req)
        {
            return InternalRequestAsync<DescribePlanQRCodesResponse>(req, "DescribePlanQRCodes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询商品信息
        /// </summary>
        /// <param name="req"><see cref="DescribeProductByIdRequest"/></param>
        /// <returns><see cref="DescribeProductByIdResponse"/></returns>
        public Task<DescribeProductByIdResponse> DescribeProductById(DescribeProductByIdRequest req)
        {
            return InternalRequestAsync<DescribeProductByIdResponse>(req, "DescribeProductById");
        }

        /// <summary>
        /// 查询商品信息
        /// </summary>
        /// <param name="req"><see cref="DescribeProductByIdRequest"/></param>
        /// <returns><see cref="DescribeProductByIdResponse"/></returns>
        public DescribeProductByIdResponse DescribeProductByIdSync(DescribeProductByIdRequest req)
        {
            return InternalRequestAsync<DescribeProductByIdResponse>(req, "DescribeProductById")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询商品列表
        /// </summary>
        /// <param name="req"><see cref="DescribeProductsRequest"/></param>
        /// <returns><see cref="DescribeProductsResponse"/></returns>
        public Task<DescribeProductsResponse> DescribeProducts(DescribeProductsRequest req)
        {
            return InternalRequestAsync<DescribeProductsResponse>(req, "DescribeProducts");
        }

        /// <summary>
        /// 查询商品列表
        /// </summary>
        /// <param name="req"><see cref="DescribeProductsRequest"/></param>
        /// <returns><see cref="DescribeProductsResponse"/></returns>
        public DescribeProductsResponse DescribeProductsSync(DescribeProductsRequest req)
        {
            return InternalRequestAsync<DescribeProductsResponse>(req, "DescribeProducts")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 支持增量查询扫码日志，通常提供给数据同步使用，调用时需要指定从哪一行开始查询数据
        /// </summary>
        /// <param name="req"><see cref="DescribeRawScanLogsRequest"/></param>
        /// <returns><see cref="DescribeRawScanLogsResponse"/></returns>
        public Task<DescribeRawScanLogsResponse> DescribeRawScanLogs(DescribeRawScanLogsRequest req)
        {
            return InternalRequestAsync<DescribeRawScanLogsResponse>(req, "DescribeRawScanLogs");
        }

        /// <summary>
        /// 支持增量查询扫码日志，通常提供给数据同步使用，调用时需要指定从哪一行开始查询数据
        /// </summary>
        /// <param name="req"><see cref="DescribeRawScanLogsRequest"/></param>
        /// <returns><see cref="DescribeRawScanLogsResponse"/></returns>
        public DescribeRawScanLogsResponse DescribeRawScanLogsSync(DescribeRawScanLogsRequest req)
        {
            return InternalRequestAsync<DescribeRawScanLogsResponse>(req, "DescribeRawScanLogs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询扫码日志明细
        /// </summary>
        /// <param name="req"><see cref="DescribeScanLogsRequest"/></param>
        /// <returns><see cref="DescribeScanLogsResponse"/></returns>
        public Task<DescribeScanLogsResponse> DescribeScanLogs(DescribeScanLogsRequest req)
        {
            return InternalRequestAsync<DescribeScanLogsResponse>(req, "DescribeScanLogs");
        }

        /// <summary>
        /// 查询扫码日志明细
        /// </summary>
        /// <param name="req"><see cref="DescribeScanLogsRequest"/></param>
        /// <returns><see cref="DescribeScanLogsResponse"/></returns>
        public DescribeScanLogsResponse DescribeScanLogsSync(DescribeScanLogsRequest req)
        {
            return InternalRequestAsync<DescribeScanLogsResponse>(req, "DescribeScanLogs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询扫码的统计信息列表，支持按照商户ID，产品ID，批次ID，安心码筛选，筛选条件至少有一个
        /// 没有被扫过的不会返回
        /// </summary>
        /// <param name="req"><see cref="DescribeScanStatsRequest"/></param>
        /// <returns><see cref="DescribeScanStatsResponse"/></returns>
        public Task<DescribeScanStatsResponse> DescribeScanStats(DescribeScanStatsRequest req)
        {
            return InternalRequestAsync<DescribeScanStatsResponse>(req, "DescribeScanStats");
        }

        /// <summary>
        /// 查询扫码的统计信息列表，支持按照商户ID，产品ID，批次ID，安心码筛选，筛选条件至少有一个
        /// 没有被扫过的不会返回
        /// </summary>
        /// <param name="req"><see cref="DescribeScanStatsRequest"/></param>
        /// <returns><see cref="DescribeScanStatsResponse"/></returns>
        public DescribeScanStatsResponse DescribeScanStatsSync(DescribeScanStatsRequest req)
        {
            return InternalRequestAsync<DescribeScanStatsResponse>(req, "DescribeScanStats")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询临时Token，主要用于上传接口
        /// </summary>
        /// <param name="req"><see cref="DescribeTmpTokenRequest"/></param>
        /// <returns><see cref="DescribeTmpTokenResponse"/></returns>
        public Task<DescribeTmpTokenResponse> DescribeTmpToken(DescribeTmpTokenRequest req)
        {
            return InternalRequestAsync<DescribeTmpTokenResponse>(req, "DescribeTmpToken");
        }

        /// <summary>
        /// 查询临时Token，主要用于上传接口
        /// </summary>
        /// <param name="req"><see cref="DescribeTmpTokenRequest"/></param>
        /// <returns><see cref="DescribeTmpTokenResponse"/></returns>
        public DescribeTmpTokenResponse DescribeTmpTokenSync(DescribeTmpTokenRequest req)
        {
            return InternalRequestAsync<DescribeTmpTokenResponse>(req, "DescribeTmpToken")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询二维码信息
        /// </summary>
        /// <param name="req"><see cref="DescribeTraceCodeByIdRequest"/></param>
        /// <returns><see cref="DescribeTraceCodeByIdResponse"/></returns>
        public Task<DescribeTraceCodeByIdResponse> DescribeTraceCodeById(DescribeTraceCodeByIdRequest req)
        {
            return InternalRequestAsync<DescribeTraceCodeByIdResponse>(req, "DescribeTraceCodeById");
        }

        /// <summary>
        /// 查询二维码信息
        /// </summary>
        /// <param name="req"><see cref="DescribeTraceCodeByIdRequest"/></param>
        /// <returns><see cref="DescribeTraceCodeByIdResponse"/></returns>
        public DescribeTraceCodeByIdResponse DescribeTraceCodeByIdSync(DescribeTraceCodeByIdRequest req)
        {
            return InternalRequestAsync<DescribeTraceCodeByIdResponse>(req, "DescribeTraceCodeById")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询二维码列表
        /// </summary>
        /// <param name="req"><see cref="DescribeTraceCodesRequest"/></param>
        /// <returns><see cref="DescribeTraceCodesResponse"/></returns>
        public Task<DescribeTraceCodesResponse> DescribeTraceCodes(DescribeTraceCodesRequest req)
        {
            return InternalRequestAsync<DescribeTraceCodesResponse>(req, "DescribeTraceCodes");
        }

        /// <summary>
        /// 查询二维码列表
        /// </summary>
        /// <param name="req"><see cref="DescribeTraceCodesRequest"/></param>
        /// <returns><see cref="DescribeTraceCodesResponse"/></returns>
        public DescribeTraceCodesResponse DescribeTraceCodesSync(DescribeTraceCodesRequest req)
        {
            return InternalRequestAsync<DescribeTraceCodesResponse>(req, "DescribeTraceCodes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询溯源ID查溯源信息，通常溯源信息跟生产批次绑定，即一个批次的所有溯源信息都是一样的
        /// </summary>
        /// <param name="req"><see cref="DescribeTraceDataByIdRequest"/></param>
        /// <returns><see cref="DescribeTraceDataByIdResponse"/></returns>
        public Task<DescribeTraceDataByIdResponse> DescribeTraceDataById(DescribeTraceDataByIdRequest req)
        {
            return InternalRequestAsync<DescribeTraceDataByIdResponse>(req, "DescribeTraceDataById");
        }

        /// <summary>
        /// 查询溯源ID查溯源信息，通常溯源信息跟生产批次绑定，即一个批次的所有溯源信息都是一样的
        /// </summary>
        /// <param name="req"><see cref="DescribeTraceDataByIdRequest"/></param>
        /// <returns><see cref="DescribeTraceDataByIdResponse"/></returns>
        public DescribeTraceDataByIdResponse DescribeTraceDataByIdSync(DescribeTraceDataByIdRequest req)
        {
            return InternalRequestAsync<DescribeTraceDataByIdResponse>(req, "DescribeTraceDataById")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询溯源信息，通常溯源信息跟生产批次绑定，即一个批次的所有溯源信息都是一样的
        /// </summary>
        /// <param name="req"><see cref="DescribeTraceDataListRequest"/></param>
        /// <returns><see cref="DescribeTraceDataListResponse"/></returns>
        public Task<DescribeTraceDataListResponse> DescribeTraceDataList(DescribeTraceDataListRequest req)
        {
            return InternalRequestAsync<DescribeTraceDataListResponse>(req, "DescribeTraceDataList");
        }

        /// <summary>
        /// 查询溯源信息，通常溯源信息跟生产批次绑定，即一个批次的所有溯源信息都是一样的
        /// </summary>
        /// <param name="req"><see cref="DescribeTraceDataListRequest"/></param>
        /// <returns><see cref="DescribeTraceDataListResponse"/></returns>
        public DescribeTraceDataListResponse DescribeTraceDataListSync(DescribeTraceDataListRequest req)
        {
            return InternalRequestAsync<DescribeTraceDataListResponse>(req, "DescribeTraceDataList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 接收客户反馈的各环节数据
        /// </summary>
        /// <param name="req"><see cref="EffectFeedbackRequest"/></param>
        /// <returns><see cref="EffectFeedbackResponse"/></returns>
        public Task<EffectFeedbackResponse> EffectFeedback(EffectFeedbackRequest req)
        {
            return InternalRequestAsync<EffectFeedbackResponse>(req, "EffectFeedback");
        }

        /// <summary>
        /// 接收客户反馈的各环节数据
        /// </summary>
        /// <param name="req"><see cref="EffectFeedbackRequest"/></param>
        /// <returns><see cref="EffectFeedbackResponse"/></returns>
        public EffectFeedbackResponse EffectFeedbackSync(EffectFeedbackRequest req)
        {
            return InternalRequestAsync<EffectFeedbackResponse>(req, "EffectFeedback")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改批次
        /// </summary>
        /// <param name="req"><see cref="ModifyCodeBatchRequest"/></param>
        /// <returns><see cref="ModifyCodeBatchResponse"/></returns>
        public Task<ModifyCodeBatchResponse> ModifyCodeBatch(ModifyCodeBatchRequest req)
        {
            return InternalRequestAsync<ModifyCodeBatchResponse>(req, "ModifyCodeBatch");
        }

        /// <summary>
        /// 修改批次
        /// </summary>
        /// <param name="req"><see cref="ModifyCodeBatchRequest"/></param>
        /// <returns><see cref="ModifyCodeBatchResponse"/></returns>
        public ModifyCodeBatchResponse ModifyCodeBatchSync(ModifyCodeBatchRequest req)
        {
            return InternalRequestAsync<ModifyCodeBatchResponse>(req, "ModifyCodeBatch")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改自定义码规则
        /// </summary>
        /// <param name="req"><see cref="ModifyCustomRuleRequest"/></param>
        /// <returns><see cref="ModifyCustomRuleResponse"/></returns>
        public Task<ModifyCustomRuleResponse> ModifyCustomRule(ModifyCustomRuleRequest req)
        {
            return InternalRequestAsync<ModifyCustomRuleResponse>(req, "ModifyCustomRule");
        }

        /// <summary>
        /// 修改自定义码规则
        /// </summary>
        /// <param name="req"><see cref="ModifyCustomRuleRequest"/></param>
        /// <returns><see cref="ModifyCustomRuleResponse"/></returns>
        public ModifyCustomRuleResponse ModifyCustomRuleSync(ModifyCustomRuleRequest req)
        {
            return InternalRequestAsync<ModifyCustomRuleResponse>(req, "ModifyCustomRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新自定义码规则状态
        /// </summary>
        /// <param name="req"><see cref="ModifyCustomRuleStatusRequest"/></param>
        /// <returns><see cref="ModifyCustomRuleStatusResponse"/></returns>
        public Task<ModifyCustomRuleStatusResponse> ModifyCustomRuleStatus(ModifyCustomRuleStatusRequest req)
        {
            return InternalRequestAsync<ModifyCustomRuleStatusResponse>(req, "ModifyCustomRuleStatus");
        }

        /// <summary>
        /// 更新自定义码规则状态
        /// </summary>
        /// <param name="req"><see cref="ModifyCustomRuleStatusRequest"/></param>
        /// <returns><see cref="ModifyCustomRuleStatusResponse"/></returns>
        public ModifyCustomRuleStatusResponse ModifyCustomRuleStatusSync(ModifyCustomRuleStatusRequest req)
        {
            return InternalRequestAsync<ModifyCustomRuleStatusResponse>(req, "ModifyCustomRuleStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 编辑商户
        /// </summary>
        /// <param name="req"><see cref="ModifyMerchantRequest"/></param>
        /// <returns><see cref="ModifyMerchantResponse"/></returns>
        public Task<ModifyMerchantResponse> ModifyMerchant(ModifyMerchantRequest req)
        {
            return InternalRequestAsync<ModifyMerchantResponse>(req, "ModifyMerchant");
        }

        /// <summary>
        /// 编辑商户
        /// </summary>
        /// <param name="req"><see cref="ModifyMerchantRequest"/></param>
        /// <returns><see cref="ModifyMerchantResponse"/></returns>
        public ModifyMerchantResponse ModifyMerchantSync(ModifyMerchantRequest req)
        {
            return InternalRequestAsync<ModifyMerchantResponse>(req, "ModifyMerchant")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 编辑商品
        /// </summary>
        /// <param name="req"><see cref="ModifyProductRequest"/></param>
        /// <returns><see cref="ModifyProductResponse"/></returns>
        public Task<ModifyProductResponse> ModifyProduct(ModifyProductRequest req)
        {
            return InternalRequestAsync<ModifyProductResponse>(req, "ModifyProduct");
        }

        /// <summary>
        /// 编辑商品
        /// </summary>
        /// <param name="req"><see cref="ModifyProductRequest"/></param>
        /// <returns><see cref="ModifyProductResponse"/></returns>
        public ModifyProductResponse ModifyProductSync(ModifyProductRequest req)
        {
            return InternalRequestAsync<ModifyProductResponse>(req, "ModifyProduct")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 冻结或者激活二维码，所属的批次的冻结状态优先级大于单个二维码的状态，即如果批次是冻结的，那么该批次下二维码的状态都是冻结的
        /// </summary>
        /// <param name="req"><see cref="ModifyTraceCodeRequest"/></param>
        /// <returns><see cref="ModifyTraceCodeResponse"/></returns>
        public Task<ModifyTraceCodeResponse> ModifyTraceCode(ModifyTraceCodeRequest req)
        {
            return InternalRequestAsync<ModifyTraceCodeResponse>(req, "ModifyTraceCode");
        }

        /// <summary>
        /// 冻结或者激活二维码，所属的批次的冻结状态优先级大于单个二维码的状态，即如果批次是冻结的，那么该批次下二维码的状态都是冻结的
        /// </summary>
        /// <param name="req"><see cref="ModifyTraceCodeRequest"/></param>
        /// <returns><see cref="ModifyTraceCodeResponse"/></returns>
        public ModifyTraceCodeResponse ModifyTraceCodeSync(ModifyTraceCodeRequest req)
        {
            return InternalRequestAsync<ModifyTraceCodeResponse>(req, "ModifyTraceCode")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 解绑溯源码和批次的关系，让溯源码重置为未关联的状态，以便关联其他批次
        /// 注意：溯源码必须属于指定的批次才会解绑
        /// </summary>
        /// <param name="req"><see cref="ModifyTraceCodeUnlinkRequest"/></param>
        /// <returns><see cref="ModifyTraceCodeUnlinkResponse"/></returns>
        public Task<ModifyTraceCodeUnlinkResponse> ModifyTraceCodeUnlink(ModifyTraceCodeUnlinkRequest req)
        {
            return InternalRequestAsync<ModifyTraceCodeUnlinkResponse>(req, "ModifyTraceCodeUnlink");
        }

        /// <summary>
        /// 解绑溯源码和批次的关系，让溯源码重置为未关联的状态，以便关联其他批次
        /// 注意：溯源码必须属于指定的批次才会解绑
        /// </summary>
        /// <param name="req"><see cref="ModifyTraceCodeUnlinkRequest"/></param>
        /// <returns><see cref="ModifyTraceCodeUnlinkResponse"/></returns>
        public ModifyTraceCodeUnlinkResponse ModifyTraceCodeUnlinkSync(ModifyTraceCodeUnlinkRequest req)
        {
            return InternalRequestAsync<ModifyTraceCodeUnlinkResponse>(req, "ModifyTraceCodeUnlink")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改溯源信息
        /// </summary>
        /// <param name="req"><see cref="ModifyTraceDataRequest"/></param>
        /// <returns><see cref="ModifyTraceDataResponse"/></returns>
        public Task<ModifyTraceDataResponse> ModifyTraceData(ModifyTraceDataRequest req)
        {
            return InternalRequestAsync<ModifyTraceDataResponse>(req, "ModifyTraceData");
        }

        /// <summary>
        /// 修改溯源信息
        /// </summary>
        /// <param name="req"><see cref="ModifyTraceDataRequest"/></param>
        /// <returns><see cref="ModifyTraceDataResponse"/></returns>
        public ModifyTraceDataResponse ModifyTraceDataSync(ModifyTraceDataRequest req)
        {
            return InternalRequestAsync<ModifyTraceDataResponse>(req, "ModifyTraceData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改溯源信息的排序
        /// </summary>
        /// <param name="req"><see cref="ModifyTraceDataRanksRequest"/></param>
        /// <returns><see cref="ModifyTraceDataRanksResponse"/></returns>
        public Task<ModifyTraceDataRanksResponse> ModifyTraceDataRanks(ModifyTraceDataRanksRequest req)
        {
            return InternalRequestAsync<ModifyTraceDataRanksResponse>(req, "ModifyTraceDataRanks");
        }

        /// <summary>
        /// 修改溯源信息的排序
        /// </summary>
        /// <param name="req"><see cref="ModifyTraceDataRanksRequest"/></param>
        /// <returns><see cref="ModifyTraceDataRanksResponse"/></returns>
        public ModifyTraceDataRanksResponse ModifyTraceDataRanksSync(ModifyTraceDataRanksRequest req)
        {
            return InternalRequestAsync<ModifyTraceDataRanksResponse>(req, "ModifyTraceDataRanks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 接收离线筛选包回执，用于效果统计和分析。
        /// </summary>
        /// <param name="req"><see cref="ReportBatchCallbackStatusRequest"/></param>
        /// <returns><see cref="ReportBatchCallbackStatusResponse"/></returns>
        public Task<ReportBatchCallbackStatusResponse> ReportBatchCallbackStatus(ReportBatchCallbackStatusRequest req)
        {
            return InternalRequestAsync<ReportBatchCallbackStatusResponse>(req, "ReportBatchCallbackStatus");
        }

        /// <summary>
        /// 接收离线筛选包回执，用于效果统计和分析。
        /// </summary>
        /// <param name="req"><see cref="ReportBatchCallbackStatusRequest"/></param>
        /// <returns><see cref="ReportBatchCallbackStatusResponse"/></returns>
        public ReportBatchCallbackStatusResponse ReportBatchCallbackStatusSync(ReportBatchCallbackStatusRequest req)
        {
            return InternalRequestAsync<ReportBatchCallbackStatusResponse>(req, "ReportBatchCallbackStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
