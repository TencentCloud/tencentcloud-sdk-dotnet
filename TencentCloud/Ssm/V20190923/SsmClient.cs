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

namespace TencentCloud.Ssm.V20190923
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Ssm.V20190923.Models;

   public class SsmClient : AbstractClient{

       private const string endpoint = "ssm.tencentcloudapi.com";
       private const string version = "2019-09-23";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public SsmClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public SsmClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 创建云产品凭据
        /// </summary>
        /// <param name="req"><see cref="CreateProductSecretRequest"/></param>
        /// <returns><see cref="CreateProductSecretResponse"/></returns>
        public async Task<CreateProductSecretResponse> CreateProductSecret(CreateProductSecretRequest req)
        {
             JsonResponseModel<CreateProductSecretResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateProductSecret");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateProductSecretResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建云产品凭据
        /// </summary>
        /// <param name="req"><see cref="CreateProductSecretRequest"/></param>
        /// <returns><see cref="CreateProductSecretResponse"/></returns>
        public CreateProductSecretResponse CreateProductSecretSync(CreateProductSecretRequest req)
        {
             JsonResponseModel<CreateProductSecretResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateProductSecret");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateProductSecretResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建用于托管SSH密钥对的凭据
        /// </summary>
        /// <param name="req"><see cref="CreateSSHKeyPairSecretRequest"/></param>
        /// <returns><see cref="CreateSSHKeyPairSecretResponse"/></returns>
        public async Task<CreateSSHKeyPairSecretResponse> CreateSSHKeyPairSecret(CreateSSHKeyPairSecretRequest req)
        {
             JsonResponseModel<CreateSSHKeyPairSecretResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateSSHKeyPairSecret");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSSHKeyPairSecretResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建用于托管SSH密钥对的凭据
        /// </summary>
        /// <param name="req"><see cref="CreateSSHKeyPairSecretRequest"/></param>
        /// <returns><see cref="CreateSSHKeyPairSecretResponse"/></returns>
        public CreateSSHKeyPairSecretResponse CreateSSHKeyPairSecretSync(CreateSSHKeyPairSecretRequest req)
        {
             JsonResponseModel<CreateSSHKeyPairSecretResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateSSHKeyPairSecret");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSSHKeyPairSecretResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建新的凭据信息，通过KMS进行加密保护。每个Region最多可创建存储1000个凭据信息。
        /// </summary>
        /// <param name="req"><see cref="CreateSecretRequest"/></param>
        /// <returns><see cref="CreateSecretResponse"/></returns>
        public async Task<CreateSecretResponse> CreateSecret(CreateSecretRequest req)
        {
             JsonResponseModel<CreateSecretResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateSecret");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSecretResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建新的凭据信息，通过KMS进行加密保护。每个Region最多可创建存储1000个凭据信息。
        /// </summary>
        /// <param name="req"><see cref="CreateSecretRequest"/></param>
        /// <returns><see cref="CreateSecretResponse"/></returns>
        public CreateSecretResponse CreateSecretSync(CreateSecretRequest req)
        {
             JsonResponseModel<CreateSecretResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateSecret");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSecretResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除指定的凭据信息，可以通过RecoveryWindowInDays参数设置立即删除或者计划删除。对于计划删除的凭据，在删除日期到达之前状态为 PendingDelete，并可以通过RestoreSecret 进行恢复，超出指定删除日期之后会被彻底删除。您必须先通过 DisableSecret 停用凭据后才可以进行（计划）删除操作。
        /// </summary>
        /// <param name="req"><see cref="DeleteSecretRequest"/></param>
        /// <returns><see cref="DeleteSecretResponse"/></returns>
        public async Task<DeleteSecretResponse> DeleteSecret(DeleteSecretRequest req)
        {
             JsonResponseModel<DeleteSecretResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteSecret");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteSecretResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除指定的凭据信息，可以通过RecoveryWindowInDays参数设置立即删除或者计划删除。对于计划删除的凭据，在删除日期到达之前状态为 PendingDelete，并可以通过RestoreSecret 进行恢复，超出指定删除日期之后会被彻底删除。您必须先通过 DisableSecret 停用凭据后才可以进行（计划）删除操作。
        /// </summary>
        /// <param name="req"><see cref="DeleteSecretRequest"/></param>
        /// <returns><see cref="DeleteSecretResponse"/></returns>
        public DeleteSecretResponse DeleteSecretSync(DeleteSecretRequest req)
        {
             JsonResponseModel<DeleteSecretResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteSecret");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteSecretResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口用于直接删除指定凭据下的单个版本凭据，删除操作立即生效，对所有状态下的凭据版本都可以删除。
        /// 本接口仅适用于用户自定义凭据，本接口不能对云产品凭据进行操作。
        /// </summary>
        /// <param name="req"><see cref="DeleteSecretVersionRequest"/></param>
        /// <returns><see cref="DeleteSecretVersionResponse"/></returns>
        public async Task<DeleteSecretVersionResponse> DeleteSecretVersion(DeleteSecretVersionRequest req)
        {
             JsonResponseModel<DeleteSecretVersionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteSecretVersion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteSecretVersionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口用于直接删除指定凭据下的单个版本凭据，删除操作立即生效，对所有状态下的凭据版本都可以删除。
        /// 本接口仅适用于用户自定义凭据，本接口不能对云产品凭据进行操作。
        /// </summary>
        /// <param name="req"><see cref="DeleteSecretVersionRequest"/></param>
        /// <returns><see cref="DeleteSecretVersionResponse"/></returns>
        public DeleteSecretVersionResponse DeleteSecretVersionSync(DeleteSecretVersionRequest req)
        {
             JsonResponseModel<DeleteSecretVersionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteSecretVersion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteSecretVersionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询异步任务的执行结果
        /// </summary>
        /// <param name="req"><see cref="DescribeAsyncRequestInfoRequest"/></param>
        /// <returns><see cref="DescribeAsyncRequestInfoResponse"/></returns>
        public async Task<DescribeAsyncRequestInfoResponse> DescribeAsyncRequestInfo(DescribeAsyncRequestInfoRequest req)
        {
             JsonResponseModel<DescribeAsyncRequestInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAsyncRequestInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAsyncRequestInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询异步任务的执行结果
        /// </summary>
        /// <param name="req"><see cref="DescribeAsyncRequestInfoRequest"/></param>
        /// <returns><see cref="DescribeAsyncRequestInfoResponse"/></returns>
        public DescribeAsyncRequestInfoResponse DescribeAsyncRequestInfoSync(DescribeAsyncRequestInfoRequest req)
        {
             JsonResponseModel<DescribeAsyncRequestInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAsyncRequestInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAsyncRequestInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询凭据轮转策略详情。
        /// 本接口只适用于云产品凭据。
        /// </summary>
        /// <param name="req"><see cref="DescribeRotationDetailRequest"/></param>
        /// <returns><see cref="DescribeRotationDetailResponse"/></returns>
        public async Task<DescribeRotationDetailResponse> DescribeRotationDetail(DescribeRotationDetailRequest req)
        {
             JsonResponseModel<DescribeRotationDetailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRotationDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRotationDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询凭据轮转策略详情。
        /// 本接口只适用于云产品凭据。
        /// </summary>
        /// <param name="req"><see cref="DescribeRotationDetailRequest"/></param>
        /// <returns><see cref="DescribeRotationDetailResponse"/></returns>
        public DescribeRotationDetailResponse DescribeRotationDetailSync(DescribeRotationDetailRequest req)
        {
             JsonResponseModel<DescribeRotationDetailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRotationDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRotationDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询凭据轮转历史版本。
        /// 本接口仅适用于云产品凭据。
        /// </summary>
        /// <param name="req"><see cref="DescribeRotationHistoryRequest"/></param>
        /// <returns><see cref="DescribeRotationHistoryResponse"/></returns>
        public async Task<DescribeRotationHistoryResponse> DescribeRotationHistory(DescribeRotationHistoryRequest req)
        {
             JsonResponseModel<DescribeRotationHistoryResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRotationHistory");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRotationHistoryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询凭据轮转历史版本。
        /// 本接口仅适用于云产品凭据。
        /// </summary>
        /// <param name="req"><see cref="DescribeRotationHistoryRequest"/></param>
        /// <returns><see cref="DescribeRotationHistoryResponse"/></returns>
        public DescribeRotationHistoryResponse DescribeRotationHistorySync(DescribeRotationHistoryRequest req)
        {
             JsonResponseModel<DescribeRotationHistoryResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRotationHistory");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRotationHistoryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取凭据的详细属性信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeSecretRequest"/></param>
        /// <returns><see cref="DescribeSecretResponse"/></returns>
        public async Task<DescribeSecretResponse> DescribeSecret(DescribeSecretRequest req)
        {
             JsonResponseModel<DescribeSecretResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSecret");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSecretResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取凭据的详细属性信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeSecretRequest"/></param>
        /// <returns><see cref="DescribeSecretResponse"/></returns>
        public DescribeSecretResponse DescribeSecretSync(DescribeSecretRequest req)
        {
             JsonResponseModel<DescribeSecretResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSecret");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSecretResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询支持的云产品列表
        /// </summary>
        /// <param name="req"><see cref="DescribeSupportedProductsRequest"/></param>
        /// <returns><see cref="DescribeSupportedProductsResponse"/></returns>
        public async Task<DescribeSupportedProductsResponse> DescribeSupportedProducts(DescribeSupportedProductsRequest req)
        {
             JsonResponseModel<DescribeSupportedProductsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSupportedProducts");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSupportedProductsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询支持的云产品列表
        /// </summary>
        /// <param name="req"><see cref="DescribeSupportedProductsRequest"/></param>
        /// <returns><see cref="DescribeSupportedProductsResponse"/></returns>
        public DescribeSupportedProductsResponse DescribeSupportedProductsSync(DescribeSupportedProductsRequest req)
        {
             JsonResponseModel<DescribeSupportedProductsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSupportedProducts");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSupportedProductsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 停用指定的凭据，停用后状态为 Disabled，无法通过接口获取该凭据的明文。
        /// </summary>
        /// <param name="req"><see cref="DisableSecretRequest"/></param>
        /// <returns><see cref="DisableSecretResponse"/></returns>
        public async Task<DisableSecretResponse> DisableSecret(DisableSecretRequest req)
        {
             JsonResponseModel<DisableSecretResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DisableSecret");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisableSecretResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 停用指定的凭据，停用后状态为 Disabled，无法通过接口获取该凭据的明文。
        /// </summary>
        /// <param name="req"><see cref="DisableSecretRequest"/></param>
        /// <returns><see cref="DisableSecretResponse"/></returns>
        public DisableSecretResponse DisableSecretSync(DisableSecretRequest req)
        {
             JsonResponseModel<DisableSecretResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DisableSecret");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisableSecretResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口用于开启凭据，状态为Enabled。可以通过 GetSecretValue 接口获取凭据明文。处于PendingDelete状态的凭据不能直接开启，需要通过RestoreSecret 恢复后再开启使用。
        /// </summary>
        /// <param name="req"><see cref="EnableSecretRequest"/></param>
        /// <returns><see cref="EnableSecretResponse"/></returns>
        public async Task<EnableSecretResponse> EnableSecret(EnableSecretRequest req)
        {
             JsonResponseModel<EnableSecretResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "EnableSecret");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EnableSecretResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口用于开启凭据，状态为Enabled。可以通过 GetSecretValue 接口获取凭据明文。处于PendingDelete状态的凭据不能直接开启，需要通过RestoreSecret 恢复后再开启使用。
        /// </summary>
        /// <param name="req"><see cref="EnableSecretRequest"/></param>
        /// <returns><see cref="EnableSecretResponse"/></returns>
        public EnableSecretResponse EnableSecretSync(EnableSecretRequest req)
        {
             JsonResponseModel<EnableSecretResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "EnableSecret");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EnableSecretResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取控制台展示region列表
        /// </summary>
        /// <param name="req"><see cref="GetRegionsRequest"/></param>
        /// <returns><see cref="GetRegionsResponse"/></returns>
        public async Task<GetRegionsResponse> GetRegions(GetRegionsRequest req)
        {
             JsonResponseModel<GetRegionsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetRegions");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetRegionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取控制台展示region列表
        /// </summary>
        /// <param name="req"><see cref="GetRegionsRequest"/></param>
        /// <returns><see cref="GetRegionsResponse"/></returns>
        public GetRegionsResponse GetRegionsSync(GetRegionsRequest req)
        {
             JsonResponseModel<GetRegionsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetRegions");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetRegionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取SSH密钥对凭据明文信息。
        /// </summary>
        /// <param name="req"><see cref="GetSSHKeyPairValueRequest"/></param>
        /// <returns><see cref="GetSSHKeyPairValueResponse"/></returns>
        public async Task<GetSSHKeyPairValueResponse> GetSSHKeyPairValue(GetSSHKeyPairValueRequest req)
        {
             JsonResponseModel<GetSSHKeyPairValueResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetSSHKeyPairValue");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetSSHKeyPairValueResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取SSH密钥对凭据明文信息。
        /// </summary>
        /// <param name="req"><see cref="GetSSHKeyPairValueRequest"/></param>
        /// <returns><see cref="GetSSHKeyPairValueResponse"/></returns>
        public GetSSHKeyPairValueResponse GetSSHKeyPairValueSync(GetSSHKeyPairValueRequest req)
        {
             JsonResponseModel<GetSSHKeyPairValueResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetSSHKeyPairValue");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetSSHKeyPairValueResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 对于用户自定义凭据，通过指定凭据名称和版本来获取凭据的明文信息；
        /// 对于云产品凭据如Mysql凭据，通过指定凭据名称和历史版本号来获取历史轮转凭据的明文信息，如果要获取当前正在使用的凭据版本的明文，需要将版本号指定为：SSM_Current。
        /// </summary>
        /// <param name="req"><see cref="GetSecretValueRequest"/></param>
        /// <returns><see cref="GetSecretValueResponse"/></returns>
        public async Task<GetSecretValueResponse> GetSecretValue(GetSecretValueRequest req)
        {
             JsonResponseModel<GetSecretValueResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetSecretValue");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetSecretValueResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 对于用户自定义凭据，通过指定凭据名称和版本来获取凭据的明文信息；
        /// 对于云产品凭据如Mysql凭据，通过指定凭据名称和历史版本号来获取历史轮转凭据的明文信息，如果要获取当前正在使用的凭据版本的明文，需要将版本号指定为：SSM_Current。
        /// </summary>
        /// <param name="req"><see cref="GetSecretValueRequest"/></param>
        /// <returns><see cref="GetSecretValueResponse"/></returns>
        public GetSecretValueResponse GetSecretValueSync(GetSecretValueRequest req)
        {
             JsonResponseModel<GetSecretValueResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetSecretValue");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetSecretValueResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口用户获取用户SecretsManager服务开通状态。
        /// </summary>
        /// <param name="req"><see cref="GetServiceStatusRequest"/></param>
        /// <returns><see cref="GetServiceStatusResponse"/></returns>
        public async Task<GetServiceStatusResponse> GetServiceStatus(GetServiceStatusRequest req)
        {
             JsonResponseModel<GetServiceStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetServiceStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetServiceStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口用户获取用户SecretsManager服务开通状态。
        /// </summary>
        /// <param name="req"><see cref="GetServiceStatusRequest"/></param>
        /// <returns><see cref="GetServiceStatusResponse"/></returns>
        public GetServiceStatusResponse GetServiceStatusSync(GetServiceStatusRequest req)
        {
             JsonResponseModel<GetServiceStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetServiceStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetServiceStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口用于获取指定凭据下的版本列表信息
        /// </summary>
        /// <param name="req"><see cref="ListSecretVersionIdsRequest"/></param>
        /// <returns><see cref="ListSecretVersionIdsResponse"/></returns>
        public async Task<ListSecretVersionIdsResponse> ListSecretVersionIds(ListSecretVersionIdsRequest req)
        {
             JsonResponseModel<ListSecretVersionIdsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ListSecretVersionIds");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListSecretVersionIdsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口用于获取指定凭据下的版本列表信息
        /// </summary>
        /// <param name="req"><see cref="ListSecretVersionIdsRequest"/></param>
        /// <returns><see cref="ListSecretVersionIdsResponse"/></returns>
        public ListSecretVersionIdsResponse ListSecretVersionIdsSync(ListSecretVersionIdsRequest req)
        {
             JsonResponseModel<ListSecretVersionIdsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ListSecretVersionIds");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListSecretVersionIdsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口用于获取所有凭据的详细列表，可以指定过滤字段、排序方式等。
        /// </summary>
        /// <param name="req"><see cref="ListSecretsRequest"/></param>
        /// <returns><see cref="ListSecretsResponse"/></returns>
        public async Task<ListSecretsResponse> ListSecrets(ListSecretsRequest req)
        {
             JsonResponseModel<ListSecretsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ListSecrets");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListSecretsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口用于获取所有凭据的详细列表，可以指定过滤字段、排序方式等。
        /// </summary>
        /// <param name="req"><see cref="ListSecretsRequest"/></param>
        /// <returns><see cref="ListSecretsResponse"/></returns>
        public ListSecretsResponse ListSecretsSync(ListSecretsRequest req)
        {
             JsonResponseModel<ListSecretsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ListSecrets");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListSecretsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口在指定名称的凭据下增加新版本的凭据内容，一个凭据下最多可以支持10个版本。只能对处于Enabled 和 Disabled 状态的凭据添加新的版本。
        /// 本接口仅适用于用户自定义凭据，对云产品凭据不能操作。
        /// </summary>
        /// <param name="req"><see cref="PutSecretValueRequest"/></param>
        /// <returns><see cref="PutSecretValueResponse"/></returns>
        public async Task<PutSecretValueResponse> PutSecretValue(PutSecretValueRequest req)
        {
             JsonResponseModel<PutSecretValueResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "PutSecretValue");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<PutSecretValueResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口在指定名称的凭据下增加新版本的凭据内容，一个凭据下最多可以支持10个版本。只能对处于Enabled 和 Disabled 状态的凭据添加新的版本。
        /// 本接口仅适用于用户自定义凭据，对云产品凭据不能操作。
        /// </summary>
        /// <param name="req"><see cref="PutSecretValueRequest"/></param>
        /// <returns><see cref="PutSecretValueResponse"/></returns>
        public PutSecretValueResponse PutSecretValueSync(PutSecretValueRequest req)
        {
             JsonResponseModel<PutSecretValueResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "PutSecretValue");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<PutSecretValueResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口用于恢复计划删除（PendingDelete状态）中的凭据，取消计划删除。取消计划删除的凭据将处于Disabled 状态，如需恢复使用，通过EnableSecret 接口开启凭据。
        /// </summary>
        /// <param name="req"><see cref="RestoreSecretRequest"/></param>
        /// <returns><see cref="RestoreSecretResponse"/></returns>
        public async Task<RestoreSecretResponse> RestoreSecret(RestoreSecretRequest req)
        {
             JsonResponseModel<RestoreSecretResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RestoreSecret");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RestoreSecretResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口用于恢复计划删除（PendingDelete状态）中的凭据，取消计划删除。取消计划删除的凭据将处于Disabled 状态，如需恢复使用，通过EnableSecret 接口开启凭据。
        /// </summary>
        /// <param name="req"><see cref="RestoreSecretRequest"/></param>
        /// <returns><see cref="RestoreSecretResponse"/></returns>
        public RestoreSecretResponse RestoreSecretSync(RestoreSecretRequest req)
        {
             JsonResponseModel<RestoreSecretResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RestoreSecret");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RestoreSecretResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 轮转云产品凭据或云API密钥对凭据。
        /// 该接口仅适用于处于Enabled状态的云产品凭据或处于Enable状态的云API密钥对凭据，对于其他状态的云产品凭据或云API密钥对凭据或用户自定义凭据不适用。
        /// </summary>
        /// <param name="req"><see cref="RotateProductSecretRequest"/></param>
        /// <returns><see cref="RotateProductSecretResponse"/></returns>
        public async Task<RotateProductSecretResponse> RotateProductSecret(RotateProductSecretRequest req)
        {
             JsonResponseModel<RotateProductSecretResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RotateProductSecret");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RotateProductSecretResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 轮转云产品凭据或云API密钥对凭据。
        /// 该接口仅适用于处于Enabled状态的云产品凭据或处于Enable状态的云API密钥对凭据，对于其他状态的云产品凭据或云API密钥对凭据或用户自定义凭据不适用。
        /// </summary>
        /// <param name="req"><see cref="RotateProductSecretRequest"/></param>
        /// <returns><see cref="RotateProductSecretResponse"/></returns>
        public RotateProductSecretResponse RotateProductSecretSync(RotateProductSecretRequest req)
        {
             JsonResponseModel<RotateProductSecretResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RotateProductSecret");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RotateProductSecretResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口用于修改指定凭据的描述信息，仅能修改Enabled 和 Disabled 状态的凭据。
        /// </summary>
        /// <param name="req"><see cref="UpdateDescriptionRequest"/></param>
        /// <returns><see cref="UpdateDescriptionResponse"/></returns>
        public async Task<UpdateDescriptionResponse> UpdateDescription(UpdateDescriptionRequest req)
        {
             JsonResponseModel<UpdateDescriptionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateDescription");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateDescriptionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口用于修改指定凭据的描述信息，仅能修改Enabled 和 Disabled 状态的凭据。
        /// </summary>
        /// <param name="req"><see cref="UpdateDescriptionRequest"/></param>
        /// <returns><see cref="UpdateDescriptionResponse"/></returns>
        public UpdateDescriptionResponse UpdateDescriptionSync(UpdateDescriptionRequest req)
        {
             JsonResponseModel<UpdateDescriptionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateDescription");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateDescriptionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 设置云产品凭据轮转策略，可以设置：
        /// 是否开启轮转
        /// 轮转周期
        /// 轮转开始时间
        /// </summary>
        /// <param name="req"><see cref="UpdateRotationStatusRequest"/></param>
        /// <returns><see cref="UpdateRotationStatusResponse"/></returns>
        public async Task<UpdateRotationStatusResponse> UpdateRotationStatus(UpdateRotationStatusRequest req)
        {
             JsonResponseModel<UpdateRotationStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateRotationStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateRotationStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 设置云产品凭据轮转策略，可以设置：
        /// 是否开启轮转
        /// 轮转周期
        /// 轮转开始时间
        /// </summary>
        /// <param name="req"><see cref="UpdateRotationStatusRequest"/></param>
        /// <returns><see cref="UpdateRotationStatusResponse"/></returns>
        public UpdateRotationStatusResponse UpdateRotationStatusSync(UpdateRotationStatusRequest req)
        {
             JsonResponseModel<UpdateRotationStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateRotationStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateRotationStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口用于更新指定凭据名称和版本号的内容，调用该接口会对新的凭据内容加密后覆盖旧的内容。仅允许更新Enabled 和 Disabled 状态的凭据。
        /// 本接口仅适用于用户自定义凭据，不能对云产品凭据操作。
        /// </summary>
        /// <param name="req"><see cref="UpdateSecretRequest"/></param>
        /// <returns><see cref="UpdateSecretResponse"/></returns>
        public async Task<UpdateSecretResponse> UpdateSecret(UpdateSecretRequest req)
        {
             JsonResponseModel<UpdateSecretResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateSecret");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateSecretResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口用于更新指定凭据名称和版本号的内容，调用该接口会对新的凭据内容加密后覆盖旧的内容。仅允许更新Enabled 和 Disabled 状态的凭据。
        /// 本接口仅适用于用户自定义凭据，不能对云产品凭据操作。
        /// </summary>
        /// <param name="req"><see cref="UpdateSecretRequest"/></param>
        /// <returns><see cref="UpdateSecretResponse"/></returns>
        public UpdateSecretResponse UpdateSecretSync(UpdateSecretRequest req)
        {
             JsonResponseModel<UpdateSecretResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateSecret");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateSecretResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
