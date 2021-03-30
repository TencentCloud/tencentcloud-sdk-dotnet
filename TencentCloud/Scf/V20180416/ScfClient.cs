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

namespace TencentCloud.Scf.V20180416
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Scf.V20180416.Models;

   public class ScfClient : AbstractClient{

       private const string endpoint = "scf.tencentcloudapi.com";
       private const string version = "2018-04-16";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public ScfClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public ScfClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 复制一个函数，您可以选择将复制出的新函数放置在特定的Region和Namespace。
        /// 注：本接口**不会**复制函数的以下对象或属性：
        /// 1. 函数的触发器
        /// 2. 除了$LATEST以外的其它版本
        /// 3. 函数配置的日志投递到的CLS目标。
        /// 
        /// 如有需要，您可以在复制后手动配置新函数。
        /// </summary>
        /// <param name="req"><see cref="CopyFunctionRequest"/></param>
        /// <returns><see cref="CopyFunctionResponse"/></returns>
        public async Task<CopyFunctionResponse> CopyFunction(CopyFunctionRequest req)
        {
             JsonResponseModel<CopyFunctionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CopyFunction");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CopyFunctionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 复制一个函数，您可以选择将复制出的新函数放置在特定的Region和Namespace。
        /// 注：本接口**不会**复制函数的以下对象或属性：
        /// 1. 函数的触发器
        /// 2. 除了$LATEST以外的其它版本
        /// 3. 函数配置的日志投递到的CLS目标。
        /// 
        /// 如有需要，您可以在复制后手动配置新函数。
        /// </summary>
        /// <param name="req"><see cref="CopyFunctionRequest"/></param>
        /// <returns><see cref="CopyFunctionResponse"/></returns>
        public CopyFunctionResponse CopyFunctionSync(CopyFunctionRequest req)
        {
             JsonResponseModel<CopyFunctionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CopyFunction");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CopyFunctionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 为某个函数版本创建一个别名，您可以使用别名来标记特定的函数版本，如DEV/RELEASE版本，也可以随时修改别名指向的版本。
        /// 一个别名必须指向一个主版本，此外还可以同时指向一个附加版本。调用函数时指定特定的别名，则请求会被发送到别名指向的版本上，您可以配置请求发送到主版本和附加版本的比例。
        /// </summary>
        /// <param name="req"><see cref="CreateAliasRequest"/></param>
        /// <returns><see cref="CreateAliasResponse"/></returns>
        public async Task<CreateAliasResponse> CreateAlias(CreateAliasRequest req)
        {
             JsonResponseModel<CreateAliasResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateAlias");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAliasResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 为某个函数版本创建一个别名，您可以使用别名来标记特定的函数版本，如DEV/RELEASE版本，也可以随时修改别名指向的版本。
        /// 一个别名必须指向一个主版本，此外还可以同时指向一个附加版本。调用函数时指定特定的别名，则请求会被发送到别名指向的版本上，您可以配置请求发送到主版本和附加版本的比例。
        /// </summary>
        /// <param name="req"><see cref="CreateAliasRequest"/></param>
        /// <returns><see cref="CreateAliasResponse"/></returns>
        public CreateAliasResponse CreateAliasSync(CreateAliasRequest req)
        {
             JsonResponseModel<CreateAliasResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateAlias");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAliasResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口根据传入参数创建新的函数。
        /// </summary>
        /// <param name="req"><see cref="CreateFunctionRequest"/></param>
        /// <returns><see cref="CreateFunctionResponse"/></returns>
        public async Task<CreateFunctionResponse> CreateFunction(CreateFunctionRequest req)
        {
             JsonResponseModel<CreateFunctionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateFunction");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateFunctionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口根据传入参数创建新的函数。
        /// </summary>
        /// <param name="req"><see cref="CreateFunctionRequest"/></param>
        /// <returns><see cref="CreateFunctionResponse"/></returns>
        public CreateFunctionResponse CreateFunctionSync(CreateFunctionRequest req)
        {
             JsonResponseModel<CreateFunctionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateFunction");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateFunctionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口根据传入的参数创建命名空间。
        /// </summary>
        /// <param name="req"><see cref="CreateNamespaceRequest"/></param>
        /// <returns><see cref="CreateNamespaceResponse"/></returns>
        public async Task<CreateNamespaceResponse> CreateNamespace(CreateNamespaceRequest req)
        {
             JsonResponseModel<CreateNamespaceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateNamespace");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateNamespaceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口根据传入的参数创建命名空间。
        /// </summary>
        /// <param name="req"><see cref="CreateNamespaceRequest"/></param>
        /// <returns><see cref="CreateNamespaceResponse"/></returns>
        public CreateNamespaceResponse CreateNamespaceSync(CreateNamespaceRequest req)
        {
             JsonResponseModel<CreateNamespaceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateNamespace");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateNamespaceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口根据参数输入设置新的触发方式。
        /// </summary>
        /// <param name="req"><see cref="CreateTriggerRequest"/></param>
        /// <returns><see cref="CreateTriggerResponse"/></returns>
        public async Task<CreateTriggerResponse> CreateTrigger(CreateTriggerRequest req)
        {
             JsonResponseModel<CreateTriggerResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateTrigger");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateTriggerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口根据参数输入设置新的触发方式。
        /// </summary>
        /// <param name="req"><see cref="CreateTriggerRequest"/></param>
        /// <returns><see cref="CreateTriggerResponse"/></returns>
        public CreateTriggerResponse CreateTriggerSync(CreateTriggerRequest req)
        {
             JsonResponseModel<CreateTriggerResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateTrigger");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateTriggerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除一个函数版本的别名
        /// </summary>
        /// <param name="req"><see cref="DeleteAliasRequest"/></param>
        /// <returns><see cref="DeleteAliasResponse"/></returns>
        public async Task<DeleteAliasResponse> DeleteAlias(DeleteAliasRequest req)
        {
             JsonResponseModel<DeleteAliasResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteAlias");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAliasResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除一个函数版本的别名
        /// </summary>
        /// <param name="req"><see cref="DeleteAliasRequest"/></param>
        /// <returns><see cref="DeleteAliasResponse"/></returns>
        public DeleteAliasResponse DeleteAliasSync(DeleteAliasRequest req)
        {
             JsonResponseModel<DeleteAliasResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteAlias");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAliasResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口根据传入参数删除函数。
        /// </summary>
        /// <param name="req"><see cref="DeleteFunctionRequest"/></param>
        /// <returns><see cref="DeleteFunctionResponse"/></returns>
        public async Task<DeleteFunctionResponse> DeleteFunction(DeleteFunctionRequest req)
        {
             JsonResponseModel<DeleteFunctionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteFunction");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteFunctionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口根据传入参数删除函数。
        /// </summary>
        /// <param name="req"><see cref="DeleteFunctionRequest"/></param>
        /// <returns><see cref="DeleteFunctionResponse"/></returns>
        public DeleteFunctionResponse DeleteFunctionSync(DeleteFunctionRequest req)
        {
             JsonResponseModel<DeleteFunctionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteFunction");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteFunctionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除指定层的指定版本，被删除的版本无法再关联到函数上，但不会影响正在引用这个层的函数。
        /// </summary>
        /// <param name="req"><see cref="DeleteLayerVersionRequest"/></param>
        /// <returns><see cref="DeleteLayerVersionResponse"/></returns>
        public async Task<DeleteLayerVersionResponse> DeleteLayerVersion(DeleteLayerVersionRequest req)
        {
             JsonResponseModel<DeleteLayerVersionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteLayerVersion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteLayerVersionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除指定层的指定版本，被删除的版本无法再关联到函数上，但不会影响正在引用这个层的函数。
        /// </summary>
        /// <param name="req"><see cref="DeleteLayerVersionRequest"/></param>
        /// <returns><see cref="DeleteLayerVersionResponse"/></returns>
        public DeleteLayerVersionResponse DeleteLayerVersionSync(DeleteLayerVersionRequest req)
        {
             JsonResponseModel<DeleteLayerVersionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteLayerVersion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteLayerVersionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口根据传入的参数删除命名空间。
        /// </summary>
        /// <param name="req"><see cref="DeleteNamespaceRequest"/></param>
        /// <returns><see cref="DeleteNamespaceResponse"/></returns>
        public async Task<DeleteNamespaceResponse> DeleteNamespace(DeleteNamespaceRequest req)
        {
             JsonResponseModel<DeleteNamespaceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteNamespace");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteNamespaceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口根据传入的参数删除命名空间。
        /// </summary>
        /// <param name="req"><see cref="DeleteNamespaceRequest"/></param>
        /// <returns><see cref="DeleteNamespaceResponse"/></returns>
        public DeleteNamespaceResponse DeleteNamespaceSync(DeleteNamespaceRequest req)
        {
             JsonResponseModel<DeleteNamespaceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteNamespace");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteNamespaceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除函数版本的预置并发配置。
        /// </summary>
        /// <param name="req"><see cref="DeleteProvisionedConcurrencyConfigRequest"/></param>
        /// <returns><see cref="DeleteProvisionedConcurrencyConfigResponse"/></returns>
        public async Task<DeleteProvisionedConcurrencyConfigResponse> DeleteProvisionedConcurrencyConfig(DeleteProvisionedConcurrencyConfigRequest req)
        {
             JsonResponseModel<DeleteProvisionedConcurrencyConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteProvisionedConcurrencyConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteProvisionedConcurrencyConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除函数版本的预置并发配置。
        /// </summary>
        /// <param name="req"><see cref="DeleteProvisionedConcurrencyConfigRequest"/></param>
        /// <returns><see cref="DeleteProvisionedConcurrencyConfigResponse"/></returns>
        public DeleteProvisionedConcurrencyConfigResponse DeleteProvisionedConcurrencyConfigSync(DeleteProvisionedConcurrencyConfigRequest req)
        {
             JsonResponseModel<DeleteProvisionedConcurrencyConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteProvisionedConcurrencyConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteProvisionedConcurrencyConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除函数的保留并发配置。
        /// </summary>
        /// <param name="req"><see cref="DeleteReservedConcurrencyConfigRequest"/></param>
        /// <returns><see cref="DeleteReservedConcurrencyConfigResponse"/></returns>
        public async Task<DeleteReservedConcurrencyConfigResponse> DeleteReservedConcurrencyConfig(DeleteReservedConcurrencyConfigRequest req)
        {
             JsonResponseModel<DeleteReservedConcurrencyConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteReservedConcurrencyConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteReservedConcurrencyConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除函数的保留并发配置。
        /// </summary>
        /// <param name="req"><see cref="DeleteReservedConcurrencyConfigRequest"/></param>
        /// <returns><see cref="DeleteReservedConcurrencyConfigResponse"/></returns>
        public DeleteReservedConcurrencyConfigResponse DeleteReservedConcurrencyConfigSync(DeleteReservedConcurrencyConfigRequest req)
        {
             JsonResponseModel<DeleteReservedConcurrencyConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteReservedConcurrencyConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteReservedConcurrencyConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口根据参数传入删除已有的触发方式。
        /// </summary>
        /// <param name="req"><see cref="DeleteTriggerRequest"/></param>
        /// <returns><see cref="DeleteTriggerResponse"/></returns>
        public async Task<DeleteTriggerResponse> DeleteTrigger(DeleteTriggerRequest req)
        {
             JsonResponseModel<DeleteTriggerResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteTrigger");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteTriggerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口根据参数传入删除已有的触发方式。
        /// </summary>
        /// <param name="req"><see cref="DeleteTriggerRequest"/></param>
        /// <returns><see cref="DeleteTriggerResponse"/></returns>
        public DeleteTriggerResponse DeleteTriggerSync(DeleteTriggerRequest req)
        {
             JsonResponseModel<DeleteTriggerResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteTrigger");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteTriggerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取账户信息
        /// </summary>
        /// <param name="req"><see cref="GetAccountRequest"/></param>
        /// <returns><see cref="GetAccountResponse"/></returns>
        public async Task<GetAccountResponse> GetAccount(GetAccountRequest req)
        {
             JsonResponseModel<GetAccountResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetAccount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetAccountResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取账户信息
        /// </summary>
        /// <param name="req"><see cref="GetAccountRequest"/></param>
        /// <returns><see cref="GetAccountResponse"/></returns>
        public GetAccountResponse GetAccountSync(GetAccountRequest req)
        {
             JsonResponseModel<GetAccountResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetAccount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetAccountResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取别名的详细信息，包括名称、描述、版本、路由信息等。
        /// </summary>
        /// <param name="req"><see cref="GetAliasRequest"/></param>
        /// <returns><see cref="GetAliasResponse"/></returns>
        public async Task<GetAliasResponse> GetAlias(GetAliasRequest req)
        {
             JsonResponseModel<GetAliasResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetAlias");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetAliasResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取别名的详细信息，包括名称、描述、版本、路由信息等。
        /// </summary>
        /// <param name="req"><see cref="GetAliasRequest"/></param>
        /// <returns><see cref="GetAliasResponse"/></returns>
        public GetAliasResponse GetAliasSync(GetAliasRequest req)
        {
             JsonResponseModel<GetAliasResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetAlias");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetAliasResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口获取某个函数的详细信息，包括名称、代码、处理方法、关联触发器和超时时间等字段。
        /// </summary>
        /// <param name="req"><see cref="GetFunctionRequest"/></param>
        /// <returns><see cref="GetFunctionResponse"/></returns>
        public async Task<GetFunctionResponse> GetFunction(GetFunctionRequest req)
        {
             JsonResponseModel<GetFunctionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetFunction");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetFunctionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口获取某个函数的详细信息，包括名称、代码、处理方法、关联触发器和超时时间等字段。
        /// </summary>
        /// <param name="req"><see cref="GetFunctionRequest"/></param>
        /// <returns><see cref="GetFunctionResponse"/></returns>
        public GetFunctionResponse GetFunctionSync(GetFunctionRequest req)
        {
             JsonResponseModel<GetFunctionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetFunction");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetFunctionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口用于获取函数代码包的下载地址。
        /// </summary>
        /// <param name="req"><see cref="GetFunctionAddressRequest"/></param>
        /// <returns><see cref="GetFunctionAddressResponse"/></returns>
        public async Task<GetFunctionAddressResponse> GetFunctionAddress(GetFunctionAddressRequest req)
        {
             JsonResponseModel<GetFunctionAddressResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetFunctionAddress");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetFunctionAddressResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口用于获取函数代码包的下载地址。
        /// </summary>
        /// <param name="req"><see cref="GetFunctionAddressRequest"/></param>
        /// <returns><see cref="GetFunctionAddressResponse"/></returns>
        public GetFunctionAddressResponse GetFunctionAddressSync(GetFunctionAddressRequest req)
        {
             JsonResponseModel<GetFunctionAddressResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetFunctionAddress");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetFunctionAddressResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取函数异步重试配置，包括重试次数和消息保留时间
        /// </summary>
        /// <param name="req"><see cref="GetFunctionEventInvokeConfigRequest"/></param>
        /// <returns><see cref="GetFunctionEventInvokeConfigResponse"/></returns>
        public async Task<GetFunctionEventInvokeConfigResponse> GetFunctionEventInvokeConfig(GetFunctionEventInvokeConfigRequest req)
        {
             JsonResponseModel<GetFunctionEventInvokeConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetFunctionEventInvokeConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetFunctionEventInvokeConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取函数异步重试配置，包括重试次数和消息保留时间
        /// </summary>
        /// <param name="req"><see cref="GetFunctionEventInvokeConfigRequest"/></param>
        /// <returns><see cref="GetFunctionEventInvokeConfigResponse"/></returns>
        public GetFunctionEventInvokeConfigResponse GetFunctionEventInvokeConfigSync(GetFunctionEventInvokeConfigRequest req)
        {
             JsonResponseModel<GetFunctionEventInvokeConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetFunctionEventInvokeConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetFunctionEventInvokeConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口根据指定的日志查询条件返回函数运行日志。
        /// </summary>
        /// <param name="req"><see cref="GetFunctionLogsRequest"/></param>
        /// <returns><see cref="GetFunctionLogsResponse"/></returns>
        public async Task<GetFunctionLogsResponse> GetFunctionLogs(GetFunctionLogsRequest req)
        {
             JsonResponseModel<GetFunctionLogsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetFunctionLogs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetFunctionLogsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口根据指定的日志查询条件返回函数运行日志。
        /// </summary>
        /// <param name="req"><see cref="GetFunctionLogsRequest"/></param>
        /// <returns><see cref="GetFunctionLogsResponse"/></returns>
        public GetFunctionLogsResponse GetFunctionLogsSync(GetFunctionLogsRequest req)
        {
             JsonResponseModel<GetFunctionLogsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetFunctionLogs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetFunctionLogsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取层版本详细信息，包括用于下载层中文件的链接。
        /// </summary>
        /// <param name="req"><see cref="GetLayerVersionRequest"/></param>
        /// <returns><see cref="GetLayerVersionResponse"/></returns>
        public async Task<GetLayerVersionResponse> GetLayerVersion(GetLayerVersionRequest req)
        {
             JsonResponseModel<GetLayerVersionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetLayerVersion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetLayerVersionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取层版本详细信息，包括用于下载层中文件的链接。
        /// </summary>
        /// <param name="req"><see cref="GetLayerVersionRequest"/></param>
        /// <returns><see cref="GetLayerVersionResponse"/></returns>
        public GetLayerVersionResponse GetLayerVersionSync(GetLayerVersionRequest req)
        {
             JsonResponseModel<GetLayerVersionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetLayerVersion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetLayerVersionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取函数或函数某一版本的预置并发详情。
        /// </summary>
        /// <param name="req"><see cref="GetProvisionedConcurrencyConfigRequest"/></param>
        /// <returns><see cref="GetProvisionedConcurrencyConfigResponse"/></returns>
        public async Task<GetProvisionedConcurrencyConfigResponse> GetProvisionedConcurrencyConfig(GetProvisionedConcurrencyConfigRequest req)
        {
             JsonResponseModel<GetProvisionedConcurrencyConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetProvisionedConcurrencyConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetProvisionedConcurrencyConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取函数或函数某一版本的预置并发详情。
        /// </summary>
        /// <param name="req"><see cref="GetProvisionedConcurrencyConfigRequest"/></param>
        /// <returns><see cref="GetProvisionedConcurrencyConfigResponse"/></returns>
        public GetProvisionedConcurrencyConfigResponse GetProvisionedConcurrencyConfigSync(GetProvisionedConcurrencyConfigRequest req)
        {
             JsonResponseModel<GetProvisionedConcurrencyConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetProvisionedConcurrencyConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetProvisionedConcurrencyConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取函数的保留并发详情。
        /// </summary>
        /// <param name="req"><see cref="GetReservedConcurrencyConfigRequest"/></param>
        /// <returns><see cref="GetReservedConcurrencyConfigResponse"/></returns>
        public async Task<GetReservedConcurrencyConfigResponse> GetReservedConcurrencyConfig(GetReservedConcurrencyConfigRequest req)
        {
             JsonResponseModel<GetReservedConcurrencyConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetReservedConcurrencyConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetReservedConcurrencyConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取函数的保留并发详情。
        /// </summary>
        /// <param name="req"><see cref="GetReservedConcurrencyConfigRequest"/></param>
        /// <returns><see cref="GetReservedConcurrencyConfigResponse"/></returns>
        public GetReservedConcurrencyConfigResponse GetReservedConcurrencyConfigSync(GetReservedConcurrencyConfigRequest req)
        {
             JsonResponseModel<GetReservedConcurrencyConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetReservedConcurrencyConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetReservedConcurrencyConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口用于运行函数。
        /// </summary>
        /// <param name="req"><see cref="InvokeRequest"/></param>
        /// <returns><see cref="InvokeResponse"/></returns>
        public async Task<InvokeResponse> Invoke(InvokeRequest req)
        {
             JsonResponseModel<InvokeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "Invoke");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InvokeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口用于运行函数。
        /// </summary>
        /// <param name="req"><see cref="InvokeRequest"/></param>
        /// <returns><see cref="InvokeResponse"/></returns>
        public InvokeResponse InvokeSync(InvokeRequest req)
        {
             JsonResponseModel<InvokeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "Invoke");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InvokeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 返回一个函数下的全部别名，可以根据特定函数版本过滤。
        /// </summary>
        /// <param name="req"><see cref="ListAliasesRequest"/></param>
        /// <returns><see cref="ListAliasesResponse"/></returns>
        public async Task<ListAliasesResponse> ListAliases(ListAliasesRequest req)
        {
             JsonResponseModel<ListAliasesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ListAliases");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListAliasesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 返回一个函数下的全部别名，可以根据特定函数版本过滤。
        /// </summary>
        /// <param name="req"><see cref="ListAliasesRequest"/></param>
        /// <returns><see cref="ListAliasesResponse"/></returns>
        public ListAliasesResponse ListAliasesSync(ListAliasesRequest req)
        {
             JsonResponseModel<ListAliasesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ListAliases");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListAliasesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 拉取函数异步事件列表
        /// </summary>
        /// <param name="req"><see cref="ListAsyncEventsRequest"/></param>
        /// <returns><see cref="ListAsyncEventsResponse"/></returns>
        public async Task<ListAsyncEventsResponse> ListAsyncEvents(ListAsyncEventsRequest req)
        {
             JsonResponseModel<ListAsyncEventsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ListAsyncEvents");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListAsyncEventsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 拉取函数异步事件列表
        /// </summary>
        /// <param name="req"><see cref="ListAsyncEventsRequest"/></param>
        /// <returns><see cref="ListAsyncEventsResponse"/></returns>
        public ListAsyncEventsResponse ListAsyncEventsSync(ListAsyncEventsRequest req)
        {
             JsonResponseModel<ListAsyncEventsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ListAsyncEvents");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListAsyncEventsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口根据传入的查询参数返回相关函数信息。
        /// </summary>
        /// <param name="req"><see cref="ListFunctionsRequest"/></param>
        /// <returns><see cref="ListFunctionsResponse"/></returns>
        public async Task<ListFunctionsResponse> ListFunctions(ListFunctionsRequest req)
        {
             JsonResponseModel<ListFunctionsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ListFunctions");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListFunctionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口根据传入的查询参数返回相关函数信息。
        /// </summary>
        /// <param name="req"><see cref="ListFunctionsRequest"/></param>
        /// <returns><see cref="ListFunctionsResponse"/></returns>
        public ListFunctionsResponse ListFunctionsSync(ListFunctionsRequest req)
        {
             JsonResponseModel<ListFunctionsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ListFunctions");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListFunctionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 返回指定层的全部版本的信息
        /// </summary>
        /// <param name="req"><see cref="ListLayerVersionsRequest"/></param>
        /// <returns><see cref="ListLayerVersionsResponse"/></returns>
        public async Task<ListLayerVersionsResponse> ListLayerVersions(ListLayerVersionsRequest req)
        {
             JsonResponseModel<ListLayerVersionsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ListLayerVersions");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListLayerVersionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 返回指定层的全部版本的信息
        /// </summary>
        /// <param name="req"><see cref="ListLayerVersionsRequest"/></param>
        /// <returns><see cref="ListLayerVersionsResponse"/></returns>
        public ListLayerVersionsResponse ListLayerVersionsSync(ListLayerVersionsRequest req)
        {
             JsonResponseModel<ListLayerVersionsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ListLayerVersions");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListLayerVersionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 返回全部层的列表，其中包含了每个层最新版本的信息，可以通过适配运行时进行过滤。
        /// </summary>
        /// <param name="req"><see cref="ListLayersRequest"/></param>
        /// <returns><see cref="ListLayersResponse"/></returns>
        public async Task<ListLayersResponse> ListLayers(ListLayersRequest req)
        {
             JsonResponseModel<ListLayersResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ListLayers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListLayersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 返回全部层的列表，其中包含了每个层最新版本的信息，可以通过适配运行时进行过滤。
        /// </summary>
        /// <param name="req"><see cref="ListLayersRequest"/></param>
        /// <returns><see cref="ListLayersResponse"/></returns>
        public ListLayersResponse ListLayersSync(ListLayersRequest req)
        {
             JsonResponseModel<ListLayersResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ListLayers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListLayersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 列出命名空间列表
        /// </summary>
        /// <param name="req"><see cref="ListNamespacesRequest"/></param>
        /// <returns><see cref="ListNamespacesResponse"/></returns>
        public async Task<ListNamespacesResponse> ListNamespaces(ListNamespacesRequest req)
        {
             JsonResponseModel<ListNamespacesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ListNamespaces");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListNamespacesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 列出命名空间列表
        /// </summary>
        /// <param name="req"><see cref="ListNamespacesRequest"/></param>
        /// <returns><see cref="ListNamespacesResponse"/></returns>
        public ListNamespacesResponse ListNamespacesSync(ListNamespacesRequest req)
        {
             JsonResponseModel<ListNamespacesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ListNamespaces");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListNamespacesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取函数触发器列表
        /// </summary>
        /// <param name="req"><see cref="ListTriggersRequest"/></param>
        /// <returns><see cref="ListTriggersResponse"/></returns>
        public async Task<ListTriggersResponse> ListTriggers(ListTriggersRequest req)
        {
             JsonResponseModel<ListTriggersResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ListTriggers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListTriggersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取函数触发器列表
        /// </summary>
        /// <param name="req"><see cref="ListTriggersRequest"/></param>
        /// <returns><see cref="ListTriggersResponse"/></returns>
        public ListTriggersResponse ListTriggersSync(ListTriggersRequest req)
        {
             JsonResponseModel<ListTriggersResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ListTriggers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListTriggersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口根据传入的参数查询函数的版本。
        /// </summary>
        /// <param name="req"><see cref="ListVersionByFunctionRequest"/></param>
        /// <returns><see cref="ListVersionByFunctionResponse"/></returns>
        public async Task<ListVersionByFunctionResponse> ListVersionByFunction(ListVersionByFunctionRequest req)
        {
             JsonResponseModel<ListVersionByFunctionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ListVersionByFunction");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListVersionByFunctionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口根据传入的参数查询函数的版本。
        /// </summary>
        /// <param name="req"><see cref="ListVersionByFunctionRequest"/></param>
        /// <returns><see cref="ListVersionByFunctionResponse"/></returns>
        public ListVersionByFunctionResponse ListVersionByFunctionSync(ListVersionByFunctionRequest req)
        {
             JsonResponseModel<ListVersionByFunctionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ListVersionByFunction");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListVersionByFunctionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 使用给定的zip文件或cos对象创建一个层的新版本，每次使用相同的层的名称调用本接口，都会生成一个新版本。
        /// </summary>
        /// <param name="req"><see cref="PublishLayerVersionRequest"/></param>
        /// <returns><see cref="PublishLayerVersionResponse"/></returns>
        public async Task<PublishLayerVersionResponse> PublishLayerVersion(PublishLayerVersionRequest req)
        {
             JsonResponseModel<PublishLayerVersionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "PublishLayerVersion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<PublishLayerVersionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 使用给定的zip文件或cos对象创建一个层的新版本，每次使用相同的层的名称调用本接口，都会生成一个新版本。
        /// </summary>
        /// <param name="req"><see cref="PublishLayerVersionRequest"/></param>
        /// <returns><see cref="PublishLayerVersionResponse"/></returns>
        public PublishLayerVersionResponse PublishLayerVersionSync(PublishLayerVersionRequest req)
        {
             JsonResponseModel<PublishLayerVersionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "PublishLayerVersion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<PublishLayerVersionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口用于用户发布新版本函数。
        /// </summary>
        /// <param name="req"><see cref="PublishVersionRequest"/></param>
        /// <returns><see cref="PublishVersionResponse"/></returns>
        public async Task<PublishVersionResponse> PublishVersion(PublishVersionRequest req)
        {
             JsonResponseModel<PublishVersionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "PublishVersion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<PublishVersionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口用于用户发布新版本函数。
        /// </summary>
        /// <param name="req"><see cref="PublishVersionRequest"/></param>
        /// <returns><see cref="PublishVersionResponse"/></returns>
        public PublishVersionResponse PublishVersionSync(PublishVersionRequest req)
        {
             JsonResponseModel<PublishVersionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "PublishVersion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<PublishVersionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 设置函数某一非$LATEST版本的预置并发。
        /// </summary>
        /// <param name="req"><see cref="PutProvisionedConcurrencyConfigRequest"/></param>
        /// <returns><see cref="PutProvisionedConcurrencyConfigResponse"/></returns>
        public async Task<PutProvisionedConcurrencyConfigResponse> PutProvisionedConcurrencyConfig(PutProvisionedConcurrencyConfigRequest req)
        {
             JsonResponseModel<PutProvisionedConcurrencyConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "PutProvisionedConcurrencyConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<PutProvisionedConcurrencyConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 设置函数某一非$LATEST版本的预置并发。
        /// </summary>
        /// <param name="req"><see cref="PutProvisionedConcurrencyConfigRequest"/></param>
        /// <returns><see cref="PutProvisionedConcurrencyConfigResponse"/></returns>
        public PutProvisionedConcurrencyConfigResponse PutProvisionedConcurrencyConfigSync(PutProvisionedConcurrencyConfigRequest req)
        {
             JsonResponseModel<PutProvisionedConcurrencyConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "PutProvisionedConcurrencyConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<PutProvisionedConcurrencyConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 设置函数保留并发
        /// </summary>
        /// <param name="req"><see cref="PutReservedConcurrencyConfigRequest"/></param>
        /// <returns><see cref="PutReservedConcurrencyConfigResponse"/></returns>
        public async Task<PutReservedConcurrencyConfigResponse> PutReservedConcurrencyConfig(PutReservedConcurrencyConfigRequest req)
        {
             JsonResponseModel<PutReservedConcurrencyConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "PutReservedConcurrencyConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<PutReservedConcurrencyConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 设置函数保留并发
        /// </summary>
        /// <param name="req"><see cref="PutReservedConcurrencyConfigRequest"/></param>
        /// <returns><see cref="PutReservedConcurrencyConfigResponse"/></returns>
        public PutReservedConcurrencyConfigResponse PutReservedConcurrencyConfigSync(PutReservedConcurrencyConfigRequest req)
        {
             JsonResponseModel<PutReservedConcurrencyConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "PutReservedConcurrencyConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<PutReservedConcurrencyConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改账号并发限制配额
        /// </summary>
        /// <param name="req"><see cref="PutTotalConcurrencyConfigRequest"/></param>
        /// <returns><see cref="PutTotalConcurrencyConfigResponse"/></returns>
        public async Task<PutTotalConcurrencyConfigResponse> PutTotalConcurrencyConfig(PutTotalConcurrencyConfigRequest req)
        {
             JsonResponseModel<PutTotalConcurrencyConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "PutTotalConcurrencyConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<PutTotalConcurrencyConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改账号并发限制配额
        /// </summary>
        /// <param name="req"><see cref="PutTotalConcurrencyConfigRequest"/></param>
        /// <returns><see cref="PutTotalConcurrencyConfigResponse"/></returns>
        public PutTotalConcurrencyConfigResponse PutTotalConcurrencyConfigSync(PutTotalConcurrencyConfigRequest req)
        {
             JsonResponseModel<PutTotalConcurrencyConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "PutTotalConcurrencyConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<PutTotalConcurrencyConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 终止正在运行中的函数异步事件
        /// </summary>
        /// <param name="req"><see cref="TerminateAsyncEventRequest"/></param>
        /// <returns><see cref="TerminateAsyncEventResponse"/></returns>
        public async Task<TerminateAsyncEventResponse> TerminateAsyncEvent(TerminateAsyncEventRequest req)
        {
             JsonResponseModel<TerminateAsyncEventResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "TerminateAsyncEvent");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<TerminateAsyncEventResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 终止正在运行中的函数异步事件
        /// </summary>
        /// <param name="req"><see cref="TerminateAsyncEventRequest"/></param>
        /// <returns><see cref="TerminateAsyncEventResponse"/></returns>
        public TerminateAsyncEventResponse TerminateAsyncEventSync(TerminateAsyncEventRequest req)
        {
             JsonResponseModel<TerminateAsyncEventResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "TerminateAsyncEvent");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<TerminateAsyncEventResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新别名的配置
        /// </summary>
        /// <param name="req"><see cref="UpdateAliasRequest"/></param>
        /// <returns><see cref="UpdateAliasResponse"/></returns>
        public async Task<UpdateAliasResponse> UpdateAlias(UpdateAliasRequest req)
        {
             JsonResponseModel<UpdateAliasResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateAlias");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateAliasResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新别名的配置
        /// </summary>
        /// <param name="req"><see cref="UpdateAliasRequest"/></param>
        /// <returns><see cref="UpdateAliasResponse"/></returns>
        public UpdateAliasResponse UpdateAliasSync(UpdateAliasRequest req)
        {
             JsonResponseModel<UpdateAliasResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateAlias");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateAliasResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口根据传入参数更新函数代码。
        /// </summary>
        /// <param name="req"><see cref="UpdateFunctionCodeRequest"/></param>
        /// <returns><see cref="UpdateFunctionCodeResponse"/></returns>
        public async Task<UpdateFunctionCodeResponse> UpdateFunctionCode(UpdateFunctionCodeRequest req)
        {
             JsonResponseModel<UpdateFunctionCodeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateFunctionCode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateFunctionCodeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口根据传入参数更新函数代码。
        /// </summary>
        /// <param name="req"><see cref="UpdateFunctionCodeRequest"/></param>
        /// <returns><see cref="UpdateFunctionCodeResponse"/></returns>
        public UpdateFunctionCodeResponse UpdateFunctionCodeSync(UpdateFunctionCodeRequest req)
        {
             JsonResponseModel<UpdateFunctionCodeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateFunctionCode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateFunctionCodeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口根据传入参数更新函数配置。
        /// </summary>
        /// <param name="req"><see cref="UpdateFunctionConfigurationRequest"/></param>
        /// <returns><see cref="UpdateFunctionConfigurationResponse"/></returns>
        public async Task<UpdateFunctionConfigurationResponse> UpdateFunctionConfiguration(UpdateFunctionConfigurationRequest req)
        {
             JsonResponseModel<UpdateFunctionConfigurationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateFunctionConfiguration");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateFunctionConfigurationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口根据传入参数更新函数配置。
        /// </summary>
        /// <param name="req"><see cref="UpdateFunctionConfigurationRequest"/></param>
        /// <returns><see cref="UpdateFunctionConfigurationResponse"/></returns>
        public UpdateFunctionConfigurationResponse UpdateFunctionConfigurationSync(UpdateFunctionConfigurationRequest req)
        {
             JsonResponseModel<UpdateFunctionConfigurationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateFunctionConfiguration");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateFunctionConfigurationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新函数的异步重试配置，包括重试次数和消息保留时间
        /// </summary>
        /// <param name="req"><see cref="UpdateFunctionEventInvokeConfigRequest"/></param>
        /// <returns><see cref="UpdateFunctionEventInvokeConfigResponse"/></returns>
        public async Task<UpdateFunctionEventInvokeConfigResponse> UpdateFunctionEventInvokeConfig(UpdateFunctionEventInvokeConfigRequest req)
        {
             JsonResponseModel<UpdateFunctionEventInvokeConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateFunctionEventInvokeConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateFunctionEventInvokeConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新函数的异步重试配置，包括重试次数和消息保留时间
        /// </summary>
        /// <param name="req"><see cref="UpdateFunctionEventInvokeConfigRequest"/></param>
        /// <returns><see cref="UpdateFunctionEventInvokeConfigResponse"/></returns>
        public UpdateFunctionEventInvokeConfigResponse UpdateFunctionEventInvokeConfigSync(UpdateFunctionEventInvokeConfigRequest req)
        {
             JsonResponseModel<UpdateFunctionEventInvokeConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateFunctionEventInvokeConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateFunctionEventInvokeConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新命名空间
        /// </summary>
        /// <param name="req"><see cref="UpdateNamespaceRequest"/></param>
        /// <returns><see cref="UpdateNamespaceResponse"/></returns>
        public async Task<UpdateNamespaceResponse> UpdateNamespace(UpdateNamespaceRequest req)
        {
             JsonResponseModel<UpdateNamespaceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateNamespace");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateNamespaceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新命名空间
        /// </summary>
        /// <param name="req"><see cref="UpdateNamespaceRequest"/></param>
        /// <returns><see cref="UpdateNamespaceResponse"/></returns>
        public UpdateNamespaceResponse UpdateNamespaceSync(UpdateNamespaceRequest req)
        {
             JsonResponseModel<UpdateNamespaceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateNamespace");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateNamespaceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
