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

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public TrpClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
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

        }

        /// <summary>
        /// 新增批次
        /// </summary>
        /// <param name="req"><see cref="CreateCodeBatchRequest"/></param>
        /// <returns><see cref="CreateCodeBatchResponse"/></returns>
        public async Task<CreateCodeBatchResponse> CreateCodeBatch(CreateCodeBatchRequest req)
        {
             JsonResponseModel<CreateCodeBatchResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateCodeBatch");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCodeBatchResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 新增批次
        /// </summary>
        /// <param name="req"><see cref="CreateCodeBatchRequest"/></param>
        /// <returns><see cref="CreateCodeBatchResponse"/></returns>
        public CreateCodeBatchResponse CreateCodeBatchSync(CreateCodeBatchRequest req)
        {
             JsonResponseModel<CreateCodeBatchResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateCodeBatch");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCodeBatchResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 生成普通码包
        /// </summary>
        /// <param name="req"><see cref="CreateCodePackRequest"/></param>
        /// <returns><see cref="CreateCodePackResponse"/></returns>
        public async Task<CreateCodePackResponse> CreateCodePack(CreateCodePackRequest req)
        {
             JsonResponseModel<CreateCodePackResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateCodePack");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCodePackResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 生成普通码包
        /// </summary>
        /// <param name="req"><see cref="CreateCodePackRequest"/></param>
        /// <returns><see cref="CreateCodePackResponse"/></returns>
        public CreateCodePackResponse CreateCodePackSync(CreateCodePackRequest req)
        {
             JsonResponseModel<CreateCodePackResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateCodePack");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCodePackResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 以订单方式新建企业信息/配额信息
        /// </summary>
        /// <param name="req"><see cref="CreateCorporationOrderRequest"/></param>
        /// <returns><see cref="CreateCorporationOrderResponse"/></returns>
        public async Task<CreateCorporationOrderResponse> CreateCorporationOrder(CreateCorporationOrderRequest req)
        {
             JsonResponseModel<CreateCorporationOrderResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateCorporationOrder");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCorporationOrderResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 以订单方式新建企业信息/配额信息
        /// </summary>
        /// <param name="req"><see cref="CreateCorporationOrderRequest"/></param>
        /// <returns><see cref="CreateCorporationOrderResponse"/></returns>
        public CreateCorporationOrderResponse CreateCorporationOrderSync(CreateCorporationOrderRequest req)
        {
             JsonResponseModel<CreateCorporationOrderResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateCorporationOrder");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCorporationOrderResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 生成自定义码包
        /// </summary>
        /// <param name="req"><see cref="CreateCustomPackRequest"/></param>
        /// <returns><see cref="CreateCustomPackResponse"/></returns>
        public async Task<CreateCustomPackResponse> CreateCustomPack(CreateCustomPackRequest req)
        {
             JsonResponseModel<CreateCustomPackResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateCustomPack");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCustomPackResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 生成自定义码包
        /// </summary>
        /// <param name="req"><see cref="CreateCustomPackRequest"/></param>
        /// <returns><see cref="CreateCustomPackResponse"/></returns>
        public CreateCustomPackResponse CreateCustomPackSync(CreateCustomPackRequest req)
        {
             JsonResponseModel<CreateCustomPackResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateCustomPack");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCustomPackResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 新建自定义码规则
        /// </summary>
        /// <param name="req"><see cref="CreateCustomRuleRequest"/></param>
        /// <returns><see cref="CreateCustomRuleResponse"/></returns>
        public async Task<CreateCustomRuleResponse> CreateCustomRule(CreateCustomRuleRequest req)
        {
             JsonResponseModel<CreateCustomRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateCustomRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCustomRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 新建自定义码规则
        /// </summary>
        /// <param name="req"><see cref="CreateCustomRuleRequest"/></param>
        /// <returns><see cref="CreateCustomRuleResponse"/></returns>
        public CreateCustomRuleResponse CreateCustomRuleSync(CreateCustomRuleRequest req)
        {
             JsonResponseModel<CreateCustomRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateCustomRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCustomRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 新建商户
        /// </summary>
        /// <param name="req"><see cref="CreateMerchantRequest"/></param>
        /// <returns><see cref="CreateMerchantResponse"/></returns>
        public async Task<CreateMerchantResponse> CreateMerchant(CreateMerchantRequest req)
        {
             JsonResponseModel<CreateMerchantResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateMerchant");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateMerchantResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 新建商户
        /// </summary>
        /// <param name="req"><see cref="CreateMerchantRequest"/></param>
        /// <returns><see cref="CreateMerchantResponse"/></returns>
        public CreateMerchantResponse CreateMerchantSync(CreateMerchantRequest req)
        {
             JsonResponseModel<CreateMerchantResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateMerchant");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateMerchantResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 新建商品
        /// </summary>
        /// <param name="req"><see cref="CreateProductRequest"/></param>
        /// <returns><see cref="CreateProductResponse"/></returns>
        public async Task<CreateProductResponse> CreateProduct(CreateProductRequest req)
        {
             JsonResponseModel<CreateProductResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateProduct");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateProductResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 新建商品
        /// </summary>
        /// <param name="req"><see cref="CreateProductRequest"/></param>
        /// <returns><see cref="CreateProductResponse"/></returns>
        public CreateProductResponse CreateProductSync(CreateProductRequest req)
        {
             JsonResponseModel<CreateProductResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateProduct");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateProductResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 上链溯源信息
        /// </summary>
        /// <param name="req"><see cref="CreateTraceChainRequest"/></param>
        /// <returns><see cref="CreateTraceChainResponse"/></returns>
        public async Task<CreateTraceChainResponse> CreateTraceChain(CreateTraceChainRequest req)
        {
             JsonResponseModel<CreateTraceChainResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateTraceChain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateTraceChainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 上链溯源信息
        /// </summary>
        /// <param name="req"><see cref="CreateTraceChainRequest"/></param>
        /// <returns><see cref="CreateTraceChainResponse"/></returns>
        public CreateTraceChainResponse CreateTraceChainSync(CreateTraceChainRequest req)
        {
             JsonResponseModel<CreateTraceChainResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateTraceChain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateTraceChainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 批量导入二维码，只支持平台发的码
        /// </summary>
        /// <param name="req"><see cref="CreateTraceCodesRequest"/></param>
        /// <returns><see cref="CreateTraceCodesResponse"/></returns>
        public async Task<CreateTraceCodesResponse> CreateTraceCodes(CreateTraceCodesRequest req)
        {
             JsonResponseModel<CreateTraceCodesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateTraceCodes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateTraceCodesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 批量导入二维码，只支持平台发的码
        /// </summary>
        /// <param name="req"><see cref="CreateTraceCodesRequest"/></param>
        /// <returns><see cref="CreateTraceCodesResponse"/></returns>
        public CreateTraceCodesResponse CreateTraceCodesSync(CreateTraceCodesRequest req)
        {
             JsonResponseModel<CreateTraceCodesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateTraceCodes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateTraceCodesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 异步导入激活码包，如果是第三方码包，需要域名跟配置的匹配
        /// </summary>
        /// <param name="req"><see cref="CreateTraceCodesAsyncRequest"/></param>
        /// <returns><see cref="CreateTraceCodesAsyncResponse"/></returns>
        public async Task<CreateTraceCodesAsyncResponse> CreateTraceCodesAsync(CreateTraceCodesAsyncRequest req)
        {
             JsonResponseModel<CreateTraceCodesAsyncResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateTraceCodesAsync");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateTraceCodesAsyncResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 异步导入激活码包，如果是第三方码包，需要域名跟配置的匹配
        /// </summary>
        /// <param name="req"><see cref="CreateTraceCodesAsyncRequest"/></param>
        /// <returns><see cref="CreateTraceCodesAsyncResponse"/></returns>
        public CreateTraceCodesAsyncResponse CreateTraceCodesAsyncSync(CreateTraceCodesAsyncRequest req)
        {
             JsonResponseModel<CreateTraceCodesAsyncResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateTraceCodesAsync");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateTraceCodesAsyncResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 新增溯源信息
        /// </summary>
        /// <param name="req"><see cref="CreateTraceDataRequest"/></param>
        /// <returns><see cref="CreateTraceDataResponse"/></returns>
        public async Task<CreateTraceDataResponse> CreateTraceData(CreateTraceDataRequest req)
        {
             JsonResponseModel<CreateTraceDataResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateTraceData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateTraceDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 新增溯源信息
        /// </summary>
        /// <param name="req"><see cref="CreateTraceDataRequest"/></param>
        /// <returns><see cref="CreateTraceDataResponse"/></returns>
        public CreateTraceDataResponse CreateTraceDataSync(CreateTraceDataRequest req)
        {
             JsonResponseModel<CreateTraceDataResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateTraceData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateTraceDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除批次
        /// </summary>
        /// <param name="req"><see cref="DeleteCodeBatchRequest"/></param>
        /// <returns><see cref="DeleteCodeBatchResponse"/></returns>
        public async Task<DeleteCodeBatchResponse> DeleteCodeBatch(DeleteCodeBatchRequest req)
        {
             JsonResponseModel<DeleteCodeBatchResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteCodeBatch");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteCodeBatchResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除批次
        /// </summary>
        /// <param name="req"><see cref="DeleteCodeBatchRequest"/></param>
        /// <returns><see cref="DeleteCodeBatchResponse"/></returns>
        public DeleteCodeBatchResponse DeleteCodeBatchSync(DeleteCodeBatchRequest req)
        {
             JsonResponseModel<DeleteCodeBatchResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteCodeBatch");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteCodeBatchResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除商户
        /// </summary>
        /// <param name="req"><see cref="DeleteMerchantRequest"/></param>
        /// <returns><see cref="DeleteMerchantResponse"/></returns>
        public async Task<DeleteMerchantResponse> DeleteMerchant(DeleteMerchantRequest req)
        {
             JsonResponseModel<DeleteMerchantResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteMerchant");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteMerchantResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除商户
        /// </summary>
        /// <param name="req"><see cref="DeleteMerchantRequest"/></param>
        /// <returns><see cref="DeleteMerchantResponse"/></returns>
        public DeleteMerchantResponse DeleteMerchantSync(DeleteMerchantRequest req)
        {
             JsonResponseModel<DeleteMerchantResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteMerchant");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteMerchantResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除商品，如果商品被使用，则不可删除
        /// </summary>
        /// <param name="req"><see cref="DeleteProductRequest"/></param>
        /// <returns><see cref="DeleteProductResponse"/></returns>
        public async Task<DeleteProductResponse> DeleteProduct(DeleteProductRequest req)
        {
             JsonResponseModel<DeleteProductResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteProduct");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteProductResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除商品，如果商品被使用，则不可删除
        /// </summary>
        /// <param name="req"><see cref="DeleteProductRequest"/></param>
        /// <returns><see cref="DeleteProductResponse"/></returns>
        public DeleteProductResponse DeleteProductSync(DeleteProductRequest req)
        {
             JsonResponseModel<DeleteProductResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteProduct");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteProductResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除溯源信息，如果已经上链则不可删除
        /// </summary>
        /// <param name="req"><see cref="DeleteTraceDataRequest"/></param>
        /// <returns><see cref="DeleteTraceDataResponse"/></returns>
        public async Task<DeleteTraceDataResponse> DeleteTraceData(DeleteTraceDataRequest req)
        {
             JsonResponseModel<DeleteTraceDataResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteTraceData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteTraceDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除溯源信息，如果已经上链则不可删除
        /// </summary>
        /// <param name="req"><see cref="DeleteTraceDataRequest"/></param>
        /// <returns><see cref="DeleteTraceDataResponse"/></returns>
        public DeleteTraceDataResponse DeleteTraceDataSync(DeleteTraceDataRequest req)
        {
             JsonResponseModel<DeleteTraceDataResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteTraceData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteTraceDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询批次信息
        /// </summary>
        /// <param name="req"><see cref="DescribeCodeBatchByIdRequest"/></param>
        /// <returns><see cref="DescribeCodeBatchByIdResponse"/></returns>
        public async Task<DescribeCodeBatchByIdResponse> DescribeCodeBatchById(DescribeCodeBatchByIdRequest req)
        {
             JsonResponseModel<DescribeCodeBatchByIdResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCodeBatchById");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCodeBatchByIdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询批次信息
        /// </summary>
        /// <param name="req"><see cref="DescribeCodeBatchByIdRequest"/></param>
        /// <returns><see cref="DescribeCodeBatchByIdResponse"/></returns>
        public DescribeCodeBatchByIdResponse DescribeCodeBatchByIdSync(DescribeCodeBatchByIdRequest req)
        {
             JsonResponseModel<DescribeCodeBatchByIdResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCodeBatchById");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCodeBatchByIdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询批次列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCodeBatchsRequest"/></param>
        /// <returns><see cref="DescribeCodeBatchsResponse"/></returns>
        public async Task<DescribeCodeBatchsResponse> DescribeCodeBatchs(DescribeCodeBatchsRequest req)
        {
             JsonResponseModel<DescribeCodeBatchsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCodeBatchs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCodeBatchsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询批次列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCodeBatchsRequest"/></param>
        /// <returns><see cref="DescribeCodeBatchsResponse"/></returns>
        public DescribeCodeBatchsResponse DescribeCodeBatchsSync(DescribeCodeBatchsRequest req)
        {
             JsonResponseModel<DescribeCodeBatchsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCodeBatchs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCodeBatchsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询码包状态
        /// </summary>
        /// <param name="req"><see cref="DescribeCodePackStatusRequest"/></param>
        /// <returns><see cref="DescribeCodePackStatusResponse"/></returns>
        public async Task<DescribeCodePackStatusResponse> DescribeCodePackStatus(DescribeCodePackStatusRequest req)
        {
             JsonResponseModel<DescribeCodePackStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCodePackStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCodePackStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询码包状态
        /// </summary>
        /// <param name="req"><see cref="DescribeCodePackStatusRequest"/></param>
        /// <returns><see cref="DescribeCodePackStatusResponse"/></returns>
        public DescribeCodePackStatusResponse DescribeCodePackStatusSync(DescribeCodePackStatusRequest req)
        {
             JsonResponseModel<DescribeCodePackStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCodePackStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCodePackStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询码包地址
        /// </summary>
        /// <param name="req"><see cref="DescribeCodePackUrlRequest"/></param>
        /// <returns><see cref="DescribeCodePackUrlResponse"/></returns>
        public async Task<DescribeCodePackUrlResponse> DescribeCodePackUrl(DescribeCodePackUrlRequest req)
        {
             JsonResponseModel<DescribeCodePackUrlResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCodePackUrl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCodePackUrlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询码包地址
        /// </summary>
        /// <param name="req"><see cref="DescribeCodePackUrlRequest"/></param>
        /// <returns><see cref="DescribeCodePackUrlResponse"/></returns>
        public DescribeCodePackUrlResponse DescribeCodePackUrlSync(DescribeCodePackUrlRequest req)
        {
             JsonResponseModel<DescribeCodePackUrlResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCodePackUrl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCodePackUrlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询码包列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCodePacksRequest"/></param>
        /// <returns><see cref="DescribeCodePacksResponse"/></returns>
        public async Task<DescribeCodePacksResponse> DescribeCodePacks(DescribeCodePacksRequest req)
        {
             JsonResponseModel<DescribeCodePacksResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCodePacks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCodePacksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询码包列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCodePacksRequest"/></param>
        /// <returns><see cref="DescribeCodePacksResponse"/></returns>
        public DescribeCodePacksResponse DescribeCodePacksSync(DescribeCodePacksRequest req)
        {
             JsonResponseModel<DescribeCodePacksResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCodePacks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCodePacksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询码包的二维码列表，上限 3 万
        /// </summary>
        /// <param name="req"><see cref="DescribeCodesByPackRequest"/></param>
        /// <returns><see cref="DescribeCodesByPackResponse"/></returns>
        public async Task<DescribeCodesByPackResponse> DescribeCodesByPack(DescribeCodesByPackRequest req)
        {
             JsonResponseModel<DescribeCodesByPackResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCodesByPack");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCodesByPackResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询码包的二维码列表，上限 3 万
        /// </summary>
        /// <param name="req"><see cref="DescribeCodesByPackRequest"/></param>
        /// <returns><see cref="DescribeCodesByPackResponse"/></returns>
        public DescribeCodesByPackResponse DescribeCodesByPackSync(DescribeCodesByPackRequest req)
        {
             JsonResponseModel<DescribeCodesByPackResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCodesByPack");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCodesByPackResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询渠道商下属企业额度使用情况
        /// </summary>
        /// <param name="req"><see cref="DescribeCorpQuotasRequest"/></param>
        /// <returns><see cref="DescribeCorpQuotasResponse"/></returns>
        public async Task<DescribeCorpQuotasResponse> DescribeCorpQuotas(DescribeCorpQuotasRequest req)
        {
             JsonResponseModel<DescribeCorpQuotasResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCorpQuotas");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCorpQuotasResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询渠道商下属企业额度使用情况
        /// </summary>
        /// <param name="req"><see cref="DescribeCorpQuotasRequest"/></param>
        /// <returns><see cref="DescribeCorpQuotasResponse"/></returns>
        public DescribeCorpQuotasResponse DescribeCorpQuotasSync(DescribeCorpQuotasRequest req)
        {
             JsonResponseModel<DescribeCorpQuotasResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCorpQuotas");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCorpQuotasResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查自定义码规则
        /// </summary>
        /// <param name="req"><see cref="DescribeCustomRuleByIdRequest"/></param>
        /// <returns><see cref="DescribeCustomRuleByIdResponse"/></returns>
        public async Task<DescribeCustomRuleByIdResponse> DescribeCustomRuleById(DescribeCustomRuleByIdRequest req)
        {
             JsonResponseModel<DescribeCustomRuleByIdResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCustomRuleById");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCustomRuleByIdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查自定义码规则
        /// </summary>
        /// <param name="req"><see cref="DescribeCustomRuleByIdRequest"/></param>
        /// <returns><see cref="DescribeCustomRuleByIdResponse"/></returns>
        public DescribeCustomRuleByIdResponse DescribeCustomRuleByIdSync(DescribeCustomRuleByIdRequest req)
        {
             JsonResponseModel<DescribeCustomRuleByIdResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCustomRuleById");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCustomRuleByIdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查自定义码规则列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCustomRulesRequest"/></param>
        /// <returns><see cref="DescribeCustomRulesResponse"/></returns>
        public async Task<DescribeCustomRulesResponse> DescribeCustomRules(DescribeCustomRulesRequest req)
        {
             JsonResponseModel<DescribeCustomRulesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCustomRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCustomRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查自定义码规则列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCustomRulesRequest"/></param>
        /// <returns><see cref="DescribeCustomRulesResponse"/></returns>
        public DescribeCustomRulesResponse DescribeCustomRulesSync(DescribeCustomRulesRequest req)
        {
             JsonResponseModel<DescribeCustomRulesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCustomRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCustomRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取异步任务的输出地址
        /// </summary>
        /// <param name="req"><see cref="DescribeJobFileUrlRequest"/></param>
        /// <returns><see cref="DescribeJobFileUrlResponse"/></returns>
        public async Task<DescribeJobFileUrlResponse> DescribeJobFileUrl(DescribeJobFileUrlRequest req)
        {
             JsonResponseModel<DescribeJobFileUrlResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeJobFileUrl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeJobFileUrlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取异步任务的输出地址
        /// </summary>
        /// <param name="req"><see cref="DescribeJobFileUrlRequest"/></param>
        /// <returns><see cref="DescribeJobFileUrlResponse"/></returns>
        public DescribeJobFileUrlResponse DescribeJobFileUrlSync(DescribeJobFileUrlRequest req)
        {
             JsonResponseModel<DescribeJobFileUrlResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeJobFileUrl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeJobFileUrlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询商户信息
        /// </summary>
        /// <param name="req"><see cref="DescribeMerchantByIdRequest"/></param>
        /// <returns><see cref="DescribeMerchantByIdResponse"/></returns>
        public async Task<DescribeMerchantByIdResponse> DescribeMerchantById(DescribeMerchantByIdRequest req)
        {
             JsonResponseModel<DescribeMerchantByIdResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeMerchantById");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMerchantByIdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询商户信息
        /// </summary>
        /// <param name="req"><see cref="DescribeMerchantByIdRequest"/></param>
        /// <returns><see cref="DescribeMerchantByIdResponse"/></returns>
        public DescribeMerchantByIdResponse DescribeMerchantByIdSync(DescribeMerchantByIdRequest req)
        {
             JsonResponseModel<DescribeMerchantByIdResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeMerchantById");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMerchantByIdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询商户列表
        /// </summary>
        /// <param name="req"><see cref="DescribeMerchantsRequest"/></param>
        /// <returns><see cref="DescribeMerchantsResponse"/></returns>
        public async Task<DescribeMerchantsResponse> DescribeMerchants(DescribeMerchantsRequest req)
        {
             JsonResponseModel<DescribeMerchantsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeMerchants");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMerchantsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询商户列表
        /// </summary>
        /// <param name="req"><see cref="DescribeMerchantsRequest"/></param>
        /// <returns><see cref="DescribeMerchantsResponse"/></returns>
        public DescribeMerchantsResponse DescribeMerchantsSync(DescribeMerchantsRequest req)
        {
             JsonResponseModel<DescribeMerchantsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeMerchants");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMerchantsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询商品信息
        /// </summary>
        /// <param name="req"><see cref="DescribeProductByIdRequest"/></param>
        /// <returns><see cref="DescribeProductByIdResponse"/></returns>
        public async Task<DescribeProductByIdResponse> DescribeProductById(DescribeProductByIdRequest req)
        {
             JsonResponseModel<DescribeProductByIdResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeProductById");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProductByIdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询商品信息
        /// </summary>
        /// <param name="req"><see cref="DescribeProductByIdRequest"/></param>
        /// <returns><see cref="DescribeProductByIdResponse"/></returns>
        public DescribeProductByIdResponse DescribeProductByIdSync(DescribeProductByIdRequest req)
        {
             JsonResponseModel<DescribeProductByIdResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeProductById");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProductByIdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询商品列表
        /// </summary>
        /// <param name="req"><see cref="DescribeProductsRequest"/></param>
        /// <returns><see cref="DescribeProductsResponse"/></returns>
        public async Task<DescribeProductsResponse> DescribeProducts(DescribeProductsRequest req)
        {
             JsonResponseModel<DescribeProductsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeProducts");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProductsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询商品列表
        /// </summary>
        /// <param name="req"><see cref="DescribeProductsRequest"/></param>
        /// <returns><see cref="DescribeProductsResponse"/></returns>
        public DescribeProductsResponse DescribeProductsSync(DescribeProductsRequest req)
        {
             JsonResponseModel<DescribeProductsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeProducts");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProductsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询扫码日志明细
        /// </summary>
        /// <param name="req"><see cref="DescribeScanLogsRequest"/></param>
        /// <returns><see cref="DescribeScanLogsResponse"/></returns>
        public async Task<DescribeScanLogsResponse> DescribeScanLogs(DescribeScanLogsRequest req)
        {
             JsonResponseModel<DescribeScanLogsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeScanLogs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeScanLogsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询扫码日志明细
        /// </summary>
        /// <param name="req"><see cref="DescribeScanLogsRequest"/></param>
        /// <returns><see cref="DescribeScanLogsResponse"/></returns>
        public DescribeScanLogsResponse DescribeScanLogsSync(DescribeScanLogsRequest req)
        {
             JsonResponseModel<DescribeScanLogsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeScanLogs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeScanLogsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询扫码的统计信息列表，支持按照商户ID，产品ID，批次ID，安心码筛选，筛选条件至少有一个
        /// 没有被扫过的不会返回
        /// </summary>
        /// <param name="req"><see cref="DescribeScanStatsRequest"/></param>
        /// <returns><see cref="DescribeScanStatsResponse"/></returns>
        public async Task<DescribeScanStatsResponse> DescribeScanStats(DescribeScanStatsRequest req)
        {
             JsonResponseModel<DescribeScanStatsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeScanStats");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeScanStatsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询扫码的统计信息列表，支持按照商户ID，产品ID，批次ID，安心码筛选，筛选条件至少有一个
        /// 没有被扫过的不会返回
        /// </summary>
        /// <param name="req"><see cref="DescribeScanStatsRequest"/></param>
        /// <returns><see cref="DescribeScanStatsResponse"/></returns>
        public DescribeScanStatsResponse DescribeScanStatsSync(DescribeScanStatsRequest req)
        {
             JsonResponseModel<DescribeScanStatsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeScanStats");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeScanStatsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询临时Token，主要用于上传接口
        /// </summary>
        /// <param name="req"><see cref="DescribeTmpTokenRequest"/></param>
        /// <returns><see cref="DescribeTmpTokenResponse"/></returns>
        public async Task<DescribeTmpTokenResponse> DescribeTmpToken(DescribeTmpTokenRequest req)
        {
             JsonResponseModel<DescribeTmpTokenResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTmpToken");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTmpTokenResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询临时Token，主要用于上传接口
        /// </summary>
        /// <param name="req"><see cref="DescribeTmpTokenRequest"/></param>
        /// <returns><see cref="DescribeTmpTokenResponse"/></returns>
        public DescribeTmpTokenResponse DescribeTmpTokenSync(DescribeTmpTokenRequest req)
        {
             JsonResponseModel<DescribeTmpTokenResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTmpToken");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTmpTokenResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询二维码信息
        /// </summary>
        /// <param name="req"><see cref="DescribeTraceCodeByIdRequest"/></param>
        /// <returns><see cref="DescribeTraceCodeByIdResponse"/></returns>
        public async Task<DescribeTraceCodeByIdResponse> DescribeTraceCodeById(DescribeTraceCodeByIdRequest req)
        {
             JsonResponseModel<DescribeTraceCodeByIdResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTraceCodeById");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTraceCodeByIdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询二维码信息
        /// </summary>
        /// <param name="req"><see cref="DescribeTraceCodeByIdRequest"/></param>
        /// <returns><see cref="DescribeTraceCodeByIdResponse"/></returns>
        public DescribeTraceCodeByIdResponse DescribeTraceCodeByIdSync(DescribeTraceCodeByIdRequest req)
        {
             JsonResponseModel<DescribeTraceCodeByIdResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTraceCodeById");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTraceCodeByIdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询二维码列表
        /// </summary>
        /// <param name="req"><see cref="DescribeTraceCodesRequest"/></param>
        /// <returns><see cref="DescribeTraceCodesResponse"/></returns>
        public async Task<DescribeTraceCodesResponse> DescribeTraceCodes(DescribeTraceCodesRequest req)
        {
             JsonResponseModel<DescribeTraceCodesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTraceCodes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTraceCodesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询二维码列表
        /// </summary>
        /// <param name="req"><see cref="DescribeTraceCodesRequest"/></param>
        /// <returns><see cref="DescribeTraceCodesResponse"/></returns>
        public DescribeTraceCodesResponse DescribeTraceCodesSync(DescribeTraceCodesRequest req)
        {
             JsonResponseModel<DescribeTraceCodesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTraceCodes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTraceCodesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询溯源信息，通常溯源信息跟生产批次绑定，即一个批次的所有溯源信息都是一样的
        /// </summary>
        /// <param name="req"><see cref="DescribeTraceDataListRequest"/></param>
        /// <returns><see cref="DescribeTraceDataListResponse"/></returns>
        public async Task<DescribeTraceDataListResponse> DescribeTraceDataList(DescribeTraceDataListRequest req)
        {
             JsonResponseModel<DescribeTraceDataListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTraceDataList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTraceDataListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询溯源信息，通常溯源信息跟生产批次绑定，即一个批次的所有溯源信息都是一样的
        /// </summary>
        /// <param name="req"><see cref="DescribeTraceDataListRequest"/></param>
        /// <returns><see cref="DescribeTraceDataListResponse"/></returns>
        public DescribeTraceDataListResponse DescribeTraceDataListSync(DescribeTraceDataListRequest req)
        {
             JsonResponseModel<DescribeTraceDataListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTraceDataList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTraceDataListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改批次
        /// </summary>
        /// <param name="req"><see cref="ModifyCodeBatchRequest"/></param>
        /// <returns><see cref="ModifyCodeBatchResponse"/></returns>
        public async Task<ModifyCodeBatchResponse> ModifyCodeBatch(ModifyCodeBatchRequest req)
        {
             JsonResponseModel<ModifyCodeBatchResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyCodeBatch");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCodeBatchResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改批次
        /// </summary>
        /// <param name="req"><see cref="ModifyCodeBatchRequest"/></param>
        /// <returns><see cref="ModifyCodeBatchResponse"/></returns>
        public ModifyCodeBatchResponse ModifyCodeBatchSync(ModifyCodeBatchRequest req)
        {
             JsonResponseModel<ModifyCodeBatchResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyCodeBatch");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCodeBatchResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改自定义码规则
        /// </summary>
        /// <param name="req"><see cref="ModifyCustomRuleRequest"/></param>
        /// <returns><see cref="ModifyCustomRuleResponse"/></returns>
        public async Task<ModifyCustomRuleResponse> ModifyCustomRule(ModifyCustomRuleRequest req)
        {
             JsonResponseModel<ModifyCustomRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyCustomRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCustomRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改自定义码规则
        /// </summary>
        /// <param name="req"><see cref="ModifyCustomRuleRequest"/></param>
        /// <returns><see cref="ModifyCustomRuleResponse"/></returns>
        public ModifyCustomRuleResponse ModifyCustomRuleSync(ModifyCustomRuleRequest req)
        {
             JsonResponseModel<ModifyCustomRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyCustomRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCustomRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新自定义码规则状态
        /// </summary>
        /// <param name="req"><see cref="ModifyCustomRuleStatusRequest"/></param>
        /// <returns><see cref="ModifyCustomRuleStatusResponse"/></returns>
        public async Task<ModifyCustomRuleStatusResponse> ModifyCustomRuleStatus(ModifyCustomRuleStatusRequest req)
        {
             JsonResponseModel<ModifyCustomRuleStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyCustomRuleStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCustomRuleStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新自定义码规则状态
        /// </summary>
        /// <param name="req"><see cref="ModifyCustomRuleStatusRequest"/></param>
        /// <returns><see cref="ModifyCustomRuleStatusResponse"/></returns>
        public ModifyCustomRuleStatusResponse ModifyCustomRuleStatusSync(ModifyCustomRuleStatusRequest req)
        {
             JsonResponseModel<ModifyCustomRuleStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyCustomRuleStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCustomRuleStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 编辑商户
        /// </summary>
        /// <param name="req"><see cref="ModifyMerchantRequest"/></param>
        /// <returns><see cref="ModifyMerchantResponse"/></returns>
        public async Task<ModifyMerchantResponse> ModifyMerchant(ModifyMerchantRequest req)
        {
             JsonResponseModel<ModifyMerchantResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyMerchant");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyMerchantResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 编辑商户
        /// </summary>
        /// <param name="req"><see cref="ModifyMerchantRequest"/></param>
        /// <returns><see cref="ModifyMerchantResponse"/></returns>
        public ModifyMerchantResponse ModifyMerchantSync(ModifyMerchantRequest req)
        {
             JsonResponseModel<ModifyMerchantResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyMerchant");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyMerchantResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 编辑商品
        /// </summary>
        /// <param name="req"><see cref="ModifyProductRequest"/></param>
        /// <returns><see cref="ModifyProductResponse"/></returns>
        public async Task<ModifyProductResponse> ModifyProduct(ModifyProductRequest req)
        {
             JsonResponseModel<ModifyProductResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyProduct");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyProductResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 编辑商品
        /// </summary>
        /// <param name="req"><see cref="ModifyProductRequest"/></param>
        /// <returns><see cref="ModifyProductResponse"/></returns>
        public ModifyProductResponse ModifyProductSync(ModifyProductRequest req)
        {
             JsonResponseModel<ModifyProductResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyProduct");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyProductResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 冻结或者激活二维码，所属的批次的冻结状态优先级大于单个二维码的状态，即如果批次是冻结的，那么该批次下二维码的状态都是冻结的
        /// </summary>
        /// <param name="req"><see cref="ModifyTraceCodeRequest"/></param>
        /// <returns><see cref="ModifyTraceCodeResponse"/></returns>
        public async Task<ModifyTraceCodeResponse> ModifyTraceCode(ModifyTraceCodeRequest req)
        {
             JsonResponseModel<ModifyTraceCodeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyTraceCode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyTraceCodeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 冻结或者激活二维码，所属的批次的冻结状态优先级大于单个二维码的状态，即如果批次是冻结的，那么该批次下二维码的状态都是冻结的
        /// </summary>
        /// <param name="req"><see cref="ModifyTraceCodeRequest"/></param>
        /// <returns><see cref="ModifyTraceCodeResponse"/></returns>
        public ModifyTraceCodeResponse ModifyTraceCodeSync(ModifyTraceCodeRequest req)
        {
             JsonResponseModel<ModifyTraceCodeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyTraceCode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyTraceCodeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 解绑溯源码和批次的关系，让溯源码重置为未关联的状态，以便关联其他批次
        /// 注意：溯源码必须属于指定的批次才会解绑
        /// </summary>
        /// <param name="req"><see cref="ModifyTraceCodeUnlinkRequest"/></param>
        /// <returns><see cref="ModifyTraceCodeUnlinkResponse"/></returns>
        public async Task<ModifyTraceCodeUnlinkResponse> ModifyTraceCodeUnlink(ModifyTraceCodeUnlinkRequest req)
        {
             JsonResponseModel<ModifyTraceCodeUnlinkResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyTraceCodeUnlink");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyTraceCodeUnlinkResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 解绑溯源码和批次的关系，让溯源码重置为未关联的状态，以便关联其他批次
        /// 注意：溯源码必须属于指定的批次才会解绑
        /// </summary>
        /// <param name="req"><see cref="ModifyTraceCodeUnlinkRequest"/></param>
        /// <returns><see cref="ModifyTraceCodeUnlinkResponse"/></returns>
        public ModifyTraceCodeUnlinkResponse ModifyTraceCodeUnlinkSync(ModifyTraceCodeUnlinkRequest req)
        {
             JsonResponseModel<ModifyTraceCodeUnlinkResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyTraceCodeUnlink");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyTraceCodeUnlinkResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改溯源信息
        /// </summary>
        /// <param name="req"><see cref="ModifyTraceDataRequest"/></param>
        /// <returns><see cref="ModifyTraceDataResponse"/></returns>
        public async Task<ModifyTraceDataResponse> ModifyTraceData(ModifyTraceDataRequest req)
        {
             JsonResponseModel<ModifyTraceDataResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyTraceData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyTraceDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改溯源信息
        /// </summary>
        /// <param name="req"><see cref="ModifyTraceDataRequest"/></param>
        /// <returns><see cref="ModifyTraceDataResponse"/></returns>
        public ModifyTraceDataResponse ModifyTraceDataSync(ModifyTraceDataRequest req)
        {
             JsonResponseModel<ModifyTraceDataResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyTraceData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyTraceDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改溯源信息的排序
        /// </summary>
        /// <param name="req"><see cref="ModifyTraceDataRanksRequest"/></param>
        /// <returns><see cref="ModifyTraceDataRanksResponse"/></returns>
        public async Task<ModifyTraceDataRanksResponse> ModifyTraceDataRanks(ModifyTraceDataRanksRequest req)
        {
             JsonResponseModel<ModifyTraceDataRanksResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyTraceDataRanks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyTraceDataRanksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改溯源信息的排序
        /// </summary>
        /// <param name="req"><see cref="ModifyTraceDataRanksRequest"/></param>
        /// <returns><see cref="ModifyTraceDataRanksResponse"/></returns>
        public ModifyTraceDataRanksResponse ModifyTraceDataRanksSync(ModifyTraceDataRanksRequest req)
        {
             JsonResponseModel<ModifyTraceDataRanksResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyTraceDataRanks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyTraceDataRanksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
