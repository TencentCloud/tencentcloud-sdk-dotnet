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
       private const string sdkVersion = "SDK_NET_3.0.1035";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public ScfClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
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
            SdkVersion = sdkVersion;
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
        public Task<CopyFunctionResponse> CopyFunction(CopyFunctionRequest req)
        {
            return InternalRequestAsync<CopyFunctionResponse>(req, "CopyFunction");
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
            return InternalRequestAsync<CopyFunctionResponse>(req, "CopyFunction")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 为某个函数版本创建一个别名，您可以使用别名来标记特定的函数版本，如DEV/RELEASE版本，也可以随时修改别名指向的版本。
        /// 一个别名必须指向一个主版本，此外还可以同时指向一个附加版本。调用函数时指定特定的别名，则请求会被发送到别名指向的版本上，您可以配置请求发送到主版本和附加版本的比例。
        /// </summary>
        /// <param name="req"><see cref="CreateAliasRequest"/></param>
        /// <returns><see cref="CreateAliasResponse"/></returns>
        public Task<CreateAliasResponse> CreateAlias(CreateAliasRequest req)
        {
            return InternalRequestAsync<CreateAliasResponse>(req, "CreateAlias");
        }

        /// <summary>
        /// 为某个函数版本创建一个别名，您可以使用别名来标记特定的函数版本，如DEV/RELEASE版本，也可以随时修改别名指向的版本。
        /// 一个别名必须指向一个主版本，此外还可以同时指向一个附加版本。调用函数时指定特定的别名，则请求会被发送到别名指向的版本上，您可以配置请求发送到主版本和附加版本的比例。
        /// </summary>
        /// <param name="req"><see cref="CreateAliasRequest"/></param>
        /// <returns><see cref="CreateAliasResponse"/></returns>
        public CreateAliasResponse CreateAliasSync(CreateAliasRequest req)
        {
            return InternalRequestAsync<CreateAliasResponse>(req, "CreateAlias")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口根据传入参数创建新的函数。
        /// </summary>
        /// <param name="req"><see cref="CreateFunctionRequest"/></param>
        /// <returns><see cref="CreateFunctionResponse"/></returns>
        public Task<CreateFunctionResponse> CreateFunction(CreateFunctionRequest req)
        {
            return InternalRequestAsync<CreateFunctionResponse>(req, "CreateFunction");
        }

        /// <summary>
        /// 该接口根据传入参数创建新的函数。
        /// </summary>
        /// <param name="req"><see cref="CreateFunctionRequest"/></param>
        /// <returns><see cref="CreateFunctionResponse"/></returns>
        public CreateFunctionResponse CreateFunctionSync(CreateFunctionRequest req)
        {
            return InternalRequestAsync<CreateFunctionResponse>(req, "CreateFunction")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口根据传入的参数创建命名空间。
        /// </summary>
        /// <param name="req"><see cref="CreateNamespaceRequest"/></param>
        /// <returns><see cref="CreateNamespaceResponse"/></returns>
        public Task<CreateNamespaceResponse> CreateNamespace(CreateNamespaceRequest req)
        {
            return InternalRequestAsync<CreateNamespaceResponse>(req, "CreateNamespace");
        }

        /// <summary>
        /// 该接口根据传入的参数创建命名空间。
        /// </summary>
        /// <param name="req"><see cref="CreateNamespaceRequest"/></param>
        /// <returns><see cref="CreateNamespaceResponse"/></returns>
        public CreateNamespaceResponse CreateNamespaceSync(CreateNamespaceRequest req)
        {
            return InternalRequestAsync<CreateNamespaceResponse>(req, "CreateNamespace")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口根据参数输入设置新的触发方式。
        /// </summary>
        /// <param name="req"><see cref="CreateTriggerRequest"/></param>
        /// <returns><see cref="CreateTriggerResponse"/></returns>
        public Task<CreateTriggerResponse> CreateTrigger(CreateTriggerRequest req)
        {
            return InternalRequestAsync<CreateTriggerResponse>(req, "CreateTrigger");
        }

        /// <summary>
        /// 该接口根据参数输入设置新的触发方式。
        /// </summary>
        /// <param name="req"><see cref="CreateTriggerRequest"/></param>
        /// <returns><see cref="CreateTriggerResponse"/></returns>
        public CreateTriggerResponse CreateTriggerSync(CreateTriggerRequest req)
        {
            return InternalRequestAsync<CreateTriggerResponse>(req, "CreateTrigger")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除一个函数版本的别名
        /// </summary>
        /// <param name="req"><see cref="DeleteAliasRequest"/></param>
        /// <returns><see cref="DeleteAliasResponse"/></returns>
        public Task<DeleteAliasResponse> DeleteAlias(DeleteAliasRequest req)
        {
            return InternalRequestAsync<DeleteAliasResponse>(req, "DeleteAlias");
        }

        /// <summary>
        /// 删除一个函数版本的别名
        /// </summary>
        /// <param name="req"><see cref="DeleteAliasRequest"/></param>
        /// <returns><see cref="DeleteAliasResponse"/></returns>
        public DeleteAliasResponse DeleteAliasSync(DeleteAliasRequest req)
        {
            return InternalRequestAsync<DeleteAliasResponse>(req, "DeleteAlias")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口根据传入参数删除函数。
        /// </summary>
        /// <param name="req"><see cref="DeleteFunctionRequest"/></param>
        /// <returns><see cref="DeleteFunctionResponse"/></returns>
        public Task<DeleteFunctionResponse> DeleteFunction(DeleteFunctionRequest req)
        {
            return InternalRequestAsync<DeleteFunctionResponse>(req, "DeleteFunction");
        }

        /// <summary>
        /// 该接口根据传入参数删除函数。
        /// </summary>
        /// <param name="req"><see cref="DeleteFunctionRequest"/></param>
        /// <returns><see cref="DeleteFunctionResponse"/></returns>
        public DeleteFunctionResponse DeleteFunctionSync(DeleteFunctionRequest req)
        {
            return InternalRequestAsync<DeleteFunctionResponse>(req, "DeleteFunction")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除指定层的指定版本，被删除的版本无法再关联到函数上，但不会影响正在引用这个层的函数。
        /// </summary>
        /// <param name="req"><see cref="DeleteLayerVersionRequest"/></param>
        /// <returns><see cref="DeleteLayerVersionResponse"/></returns>
        public Task<DeleteLayerVersionResponse> DeleteLayerVersion(DeleteLayerVersionRequest req)
        {
            return InternalRequestAsync<DeleteLayerVersionResponse>(req, "DeleteLayerVersion");
        }

        /// <summary>
        /// 删除指定层的指定版本，被删除的版本无法再关联到函数上，但不会影响正在引用这个层的函数。
        /// </summary>
        /// <param name="req"><see cref="DeleteLayerVersionRequest"/></param>
        /// <returns><see cref="DeleteLayerVersionResponse"/></returns>
        public DeleteLayerVersionResponse DeleteLayerVersionSync(DeleteLayerVersionRequest req)
        {
            return InternalRequestAsync<DeleteLayerVersionResponse>(req, "DeleteLayerVersion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口根据传入的参数删除命名空间。
        /// </summary>
        /// <param name="req"><see cref="DeleteNamespaceRequest"/></param>
        /// <returns><see cref="DeleteNamespaceResponse"/></returns>
        public Task<DeleteNamespaceResponse> DeleteNamespace(DeleteNamespaceRequest req)
        {
            return InternalRequestAsync<DeleteNamespaceResponse>(req, "DeleteNamespace");
        }

        /// <summary>
        /// 该接口根据传入的参数删除命名空间。
        /// </summary>
        /// <param name="req"><see cref="DeleteNamespaceRequest"/></param>
        /// <returns><see cref="DeleteNamespaceResponse"/></returns>
        public DeleteNamespaceResponse DeleteNamespaceSync(DeleteNamespaceRequest req)
        {
            return InternalRequestAsync<DeleteNamespaceResponse>(req, "DeleteNamespace")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除函数版本的预置并发配置。
        /// </summary>
        /// <param name="req"><see cref="DeleteProvisionedConcurrencyConfigRequest"/></param>
        /// <returns><see cref="DeleteProvisionedConcurrencyConfigResponse"/></returns>
        public Task<DeleteProvisionedConcurrencyConfigResponse> DeleteProvisionedConcurrencyConfig(DeleteProvisionedConcurrencyConfigRequest req)
        {
            return InternalRequestAsync<DeleteProvisionedConcurrencyConfigResponse>(req, "DeleteProvisionedConcurrencyConfig");
        }

        /// <summary>
        /// 删除函数版本的预置并发配置。
        /// </summary>
        /// <param name="req"><see cref="DeleteProvisionedConcurrencyConfigRequest"/></param>
        /// <returns><see cref="DeleteProvisionedConcurrencyConfigResponse"/></returns>
        public DeleteProvisionedConcurrencyConfigResponse DeleteProvisionedConcurrencyConfigSync(DeleteProvisionedConcurrencyConfigRequest req)
        {
            return InternalRequestAsync<DeleteProvisionedConcurrencyConfigResponse>(req, "DeleteProvisionedConcurrencyConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除函数的最大独占配额配置。
        /// </summary>
        /// <param name="req"><see cref="DeleteReservedConcurrencyConfigRequest"/></param>
        /// <returns><see cref="DeleteReservedConcurrencyConfigResponse"/></returns>
        public Task<DeleteReservedConcurrencyConfigResponse> DeleteReservedConcurrencyConfig(DeleteReservedConcurrencyConfigRequest req)
        {
            return InternalRequestAsync<DeleteReservedConcurrencyConfigResponse>(req, "DeleteReservedConcurrencyConfig");
        }

        /// <summary>
        /// 删除函数的最大独占配额配置。
        /// </summary>
        /// <param name="req"><see cref="DeleteReservedConcurrencyConfigRequest"/></param>
        /// <returns><see cref="DeleteReservedConcurrencyConfigResponse"/></returns>
        public DeleteReservedConcurrencyConfigResponse DeleteReservedConcurrencyConfigSync(DeleteReservedConcurrencyConfigRequest req)
        {
            return InternalRequestAsync<DeleteReservedConcurrencyConfigResponse>(req, "DeleteReservedConcurrencyConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口根据参数传入删除已有的触发方式。
        /// </summary>
        /// <param name="req"><see cref="DeleteTriggerRequest"/></param>
        /// <returns><see cref="DeleteTriggerResponse"/></returns>
        public Task<DeleteTriggerResponse> DeleteTrigger(DeleteTriggerRequest req)
        {
            return InternalRequestAsync<DeleteTriggerResponse>(req, "DeleteTrigger");
        }

        /// <summary>
        /// 该接口根据参数传入删除已有的触发方式。
        /// </summary>
        /// <param name="req"><see cref="DeleteTriggerRequest"/></param>
        /// <returns><see cref="DeleteTriggerResponse"/></returns>
        public DeleteTriggerResponse DeleteTriggerSync(DeleteTriggerRequest req)
        {
            return InternalRequestAsync<DeleteTriggerResponse>(req, "DeleteTrigger")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取账户信息
        /// </summary>
        /// <param name="req"><see cref="GetAccountRequest"/></param>
        /// <returns><see cref="GetAccountResponse"/></returns>
        public Task<GetAccountResponse> GetAccount(GetAccountRequest req)
        {
            return InternalRequestAsync<GetAccountResponse>(req, "GetAccount");
        }

        /// <summary>
        /// 获取账户信息
        /// </summary>
        /// <param name="req"><see cref="GetAccountRequest"/></param>
        /// <returns><see cref="GetAccountResponse"/></returns>
        public GetAccountResponse GetAccountSync(GetAccountRequest req)
        {
            return InternalRequestAsync<GetAccountResponse>(req, "GetAccount")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取别名的详细信息，包括名称、描述、版本、路由信息等。
        /// </summary>
        /// <param name="req"><see cref="GetAliasRequest"/></param>
        /// <returns><see cref="GetAliasResponse"/></returns>
        public Task<GetAliasResponse> GetAlias(GetAliasRequest req)
        {
            return InternalRequestAsync<GetAliasResponse>(req, "GetAlias");
        }

        /// <summary>
        /// 获取别名的详细信息，包括名称、描述、版本、路由信息等。
        /// </summary>
        /// <param name="req"><see cref="GetAliasRequest"/></param>
        /// <returns><see cref="GetAliasResponse"/></returns>
        public GetAliasResponse GetAliasSync(GetAliasRequest req)
        {
            return InternalRequestAsync<GetAliasResponse>(req, "GetAlias")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取函数异步执行事件状态，事件状态保留 3 * 24 小时（从事件完成开始计时）。
        /// </summary>
        /// <param name="req"><see cref="GetAsyncEventStatusRequest"/></param>
        /// <returns><see cref="GetAsyncEventStatusResponse"/></returns>
        public Task<GetAsyncEventStatusResponse> GetAsyncEventStatus(GetAsyncEventStatusRequest req)
        {
            return InternalRequestAsync<GetAsyncEventStatusResponse>(req, "GetAsyncEventStatus");
        }

        /// <summary>
        /// 获取函数异步执行事件状态，事件状态保留 3 * 24 小时（从事件完成开始计时）。
        /// </summary>
        /// <param name="req"><see cref="GetAsyncEventStatusRequest"/></param>
        /// <returns><see cref="GetAsyncEventStatusResponse"/></returns>
        public GetAsyncEventStatusResponse GetAsyncEventStatusSync(GetAsyncEventStatusRequest req)
        {
            return InternalRequestAsync<GetAsyncEventStatusResponse>(req, "GetAsyncEventStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口获取某个函数的详细信息，包括名称、代码、处理方法、关联触发器和超时时间等字段。
        /// </summary>
        /// <param name="req"><see cref="GetFunctionRequest"/></param>
        /// <returns><see cref="GetFunctionResponse"/></returns>
        public Task<GetFunctionResponse> GetFunction(GetFunctionRequest req)
        {
            return InternalRequestAsync<GetFunctionResponse>(req, "GetFunction");
        }

        /// <summary>
        /// 该接口获取某个函数的详细信息，包括名称、代码、处理方法、关联触发器和超时时间等字段。
        /// </summary>
        /// <param name="req"><see cref="GetFunctionRequest"/></param>
        /// <returns><see cref="GetFunctionResponse"/></returns>
        public GetFunctionResponse GetFunctionSync(GetFunctionRequest req)
        {
            return InternalRequestAsync<GetFunctionResponse>(req, "GetFunction")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口用于获取函数代码包的下载地址。
        /// </summary>
        /// <param name="req"><see cref="GetFunctionAddressRequest"/></param>
        /// <returns><see cref="GetFunctionAddressResponse"/></returns>
        public Task<GetFunctionAddressResponse> GetFunctionAddress(GetFunctionAddressRequest req)
        {
            return InternalRequestAsync<GetFunctionAddressResponse>(req, "GetFunctionAddress");
        }

        /// <summary>
        /// 该接口用于获取函数代码包的下载地址。
        /// </summary>
        /// <param name="req"><see cref="GetFunctionAddressRequest"/></param>
        /// <returns><see cref="GetFunctionAddressResponse"/></returns>
        public GetFunctionAddressResponse GetFunctionAddressSync(GetFunctionAddressRequest req)
        {
            return InternalRequestAsync<GetFunctionAddressResponse>(req, "GetFunctionAddress")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取函数异步重试配置，包括重试次数和消息保留时间
        /// </summary>
        /// <param name="req"><see cref="GetFunctionEventInvokeConfigRequest"/></param>
        /// <returns><see cref="GetFunctionEventInvokeConfigResponse"/></returns>
        public Task<GetFunctionEventInvokeConfigResponse> GetFunctionEventInvokeConfig(GetFunctionEventInvokeConfigRequest req)
        {
            return InternalRequestAsync<GetFunctionEventInvokeConfigResponse>(req, "GetFunctionEventInvokeConfig");
        }

        /// <summary>
        /// 获取函数异步重试配置，包括重试次数和消息保留时间
        /// </summary>
        /// <param name="req"><see cref="GetFunctionEventInvokeConfigRequest"/></param>
        /// <returns><see cref="GetFunctionEventInvokeConfigResponse"/></returns>
        public GetFunctionEventInvokeConfigResponse GetFunctionEventInvokeConfigSync(GetFunctionEventInvokeConfigRequest req)
        {
            return InternalRequestAsync<GetFunctionEventInvokeConfigResponse>(req, "GetFunctionEventInvokeConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口根据指定的日志查询条件返回函数运行日志。该接口已下线，查询函数请求运行的返回信息，请使用 [GetRequestStatus](https://cloud.tencent.com/document/product/583/65348)。查询函数运行日志，请参考[日志检索教程](https://cloud.tencent.com/document/product/583/52637)。
        /// </summary>
        /// <param name="req"><see cref="GetFunctionLogsRequest"/></param>
        /// <returns><see cref="GetFunctionLogsResponse"/></returns>
        public Task<GetFunctionLogsResponse> GetFunctionLogs(GetFunctionLogsRequest req)
        {
            return InternalRequestAsync<GetFunctionLogsResponse>(req, "GetFunctionLogs");
        }

        /// <summary>
        /// 该接口根据指定的日志查询条件返回函数运行日志。该接口已下线，查询函数请求运行的返回信息，请使用 [GetRequestStatus](https://cloud.tencent.com/document/product/583/65348)。查询函数运行日志，请参考[日志检索教程](https://cloud.tencent.com/document/product/583/52637)。
        /// </summary>
        /// <param name="req"><see cref="GetFunctionLogsRequest"/></param>
        /// <returns><see cref="GetFunctionLogsResponse"/></returns>
        public GetFunctionLogsResponse GetFunctionLogsSync(GetFunctionLogsRequest req)
        {
            return InternalRequestAsync<GetFunctionLogsResponse>(req, "GetFunctionLogs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取层版本详细信息，包括用于下载层中文件的链接。
        /// </summary>
        /// <param name="req"><see cref="GetLayerVersionRequest"/></param>
        /// <returns><see cref="GetLayerVersionResponse"/></returns>
        public Task<GetLayerVersionResponse> GetLayerVersion(GetLayerVersionRequest req)
        {
            return InternalRequestAsync<GetLayerVersionResponse>(req, "GetLayerVersion");
        }

        /// <summary>
        /// 获取层版本详细信息，包括用于下载层中文件的链接。
        /// </summary>
        /// <param name="req"><see cref="GetLayerVersionRequest"/></param>
        /// <returns><see cref="GetLayerVersionResponse"/></returns>
        public GetLayerVersionResponse GetLayerVersionSync(GetLayerVersionRequest req)
        {
            return InternalRequestAsync<GetLayerVersionResponse>(req, "GetLayerVersion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取函数或函数某一版本的预置并发详情。
        /// </summary>
        /// <param name="req"><see cref="GetProvisionedConcurrencyConfigRequest"/></param>
        /// <returns><see cref="GetProvisionedConcurrencyConfigResponse"/></returns>
        public Task<GetProvisionedConcurrencyConfigResponse> GetProvisionedConcurrencyConfig(GetProvisionedConcurrencyConfigRequest req)
        {
            return InternalRequestAsync<GetProvisionedConcurrencyConfigResponse>(req, "GetProvisionedConcurrencyConfig");
        }

        /// <summary>
        /// 获取函数或函数某一版本的预置并发详情。
        /// </summary>
        /// <param name="req"><see cref="GetProvisionedConcurrencyConfigRequest"/></param>
        /// <returns><see cref="GetProvisionedConcurrencyConfigResponse"/></returns>
        public GetProvisionedConcurrencyConfigResponse GetProvisionedConcurrencyConfigSync(GetProvisionedConcurrencyConfigRequest req)
        {
            return InternalRequestAsync<GetProvisionedConcurrencyConfigResponse>(req, "GetProvisionedConcurrencyConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口根据指定的查询条件返回函数单个请求运行状态。
        /// </summary>
        /// <param name="req"><see cref="GetRequestStatusRequest"/></param>
        /// <returns><see cref="GetRequestStatusResponse"/></returns>
        public Task<GetRequestStatusResponse> GetRequestStatus(GetRequestStatusRequest req)
        {
            return InternalRequestAsync<GetRequestStatusResponse>(req, "GetRequestStatus");
        }

        /// <summary>
        /// 该接口根据指定的查询条件返回函数单个请求运行状态。
        /// </summary>
        /// <param name="req"><see cref="GetRequestStatusRequest"/></param>
        /// <returns><see cref="GetRequestStatusResponse"/></returns>
        public GetRequestStatusResponse GetRequestStatusSync(GetRequestStatusRequest req)
        {
            return InternalRequestAsync<GetRequestStatusResponse>(req, "GetRequestStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取函数的最大独占配额详情。
        /// </summary>
        /// <param name="req"><see cref="GetReservedConcurrencyConfigRequest"/></param>
        /// <returns><see cref="GetReservedConcurrencyConfigResponse"/></returns>
        public Task<GetReservedConcurrencyConfigResponse> GetReservedConcurrencyConfig(GetReservedConcurrencyConfigRequest req)
        {
            return InternalRequestAsync<GetReservedConcurrencyConfigResponse>(req, "GetReservedConcurrencyConfig");
        }

        /// <summary>
        /// 获取函数的最大独占配额详情。
        /// </summary>
        /// <param name="req"><see cref="GetReservedConcurrencyConfigRequest"/></param>
        /// <returns><see cref="GetReservedConcurrencyConfigResponse"/></returns>
        public GetReservedConcurrencyConfigResponse GetReservedConcurrencyConfigSync(GetReservedConcurrencyConfigRequest req)
        {
            return InternalRequestAsync<GetReservedConcurrencyConfigResponse>(req, "GetReservedConcurrencyConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口用于运行函数。
        /// </summary>
        /// <param name="req"><see cref="InvokeRequest"/></param>
        /// <returns><see cref="InvokeResponse"/></returns>
        public Task<InvokeResponse> Invoke(InvokeRequest req)
        {
            return InternalRequestAsync<InvokeResponse>(req, "Invoke");
        }

        /// <summary>
        /// 该接口用于运行函数。
        /// </summary>
        /// <param name="req"><see cref="InvokeRequest"/></param>
        /// <returns><see cref="InvokeResponse"/></returns>
        public InvokeResponse InvokeSync(InvokeRequest req)
        {
            return InternalRequestAsync<InvokeResponse>(req, "Invoke")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        ///  SCF同步调用函数接口
        /// </summary>
        /// <param name="req"><see cref="InvokeFunctionRequest"/></param>
        /// <returns><see cref="InvokeFunctionResponse"/></returns>
        public Task<InvokeFunctionResponse> InvokeFunction(InvokeFunctionRequest req)
        {
            return InternalRequestAsync<InvokeFunctionResponse>(req, "InvokeFunction");
        }

        /// <summary>
        ///  SCF同步调用函数接口
        /// </summary>
        /// <param name="req"><see cref="InvokeFunctionRequest"/></param>
        /// <returns><see cref="InvokeFunctionResponse"/></returns>
        public InvokeFunctionResponse InvokeFunctionSync(InvokeFunctionRequest req)
        {
            return InternalRequestAsync<InvokeFunctionResponse>(req, "InvokeFunction")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 返回一个函数下的全部别名，可以根据特定函数版本过滤。
        /// </summary>
        /// <param name="req"><see cref="ListAliasesRequest"/></param>
        /// <returns><see cref="ListAliasesResponse"/></returns>
        public Task<ListAliasesResponse> ListAliases(ListAliasesRequest req)
        {
            return InternalRequestAsync<ListAliasesResponse>(req, "ListAliases");
        }

        /// <summary>
        /// 返回一个函数下的全部别名，可以根据特定函数版本过滤。
        /// </summary>
        /// <param name="req"><see cref="ListAliasesRequest"/></param>
        /// <returns><see cref="ListAliasesResponse"/></returns>
        public ListAliasesResponse ListAliasesSync(ListAliasesRequest req)
        {
            return InternalRequestAsync<ListAliasesResponse>(req, "ListAliases")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 拉取函数异步事件列表
        /// </summary>
        /// <param name="req"><see cref="ListAsyncEventsRequest"/></param>
        /// <returns><see cref="ListAsyncEventsResponse"/></returns>
        public Task<ListAsyncEventsResponse> ListAsyncEvents(ListAsyncEventsRequest req)
        {
            return InternalRequestAsync<ListAsyncEventsResponse>(req, "ListAsyncEvents");
        }

        /// <summary>
        /// 拉取函数异步事件列表
        /// </summary>
        /// <param name="req"><see cref="ListAsyncEventsRequest"/></param>
        /// <returns><see cref="ListAsyncEventsResponse"/></returns>
        public ListAsyncEventsResponse ListAsyncEventsSync(ListAsyncEventsRequest req)
        {
            return InternalRequestAsync<ListAsyncEventsResponse>(req, "ListAsyncEvents")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口根据传入的查询参数返回相关函数信息。
        /// </summary>
        /// <param name="req"><see cref="ListFunctionsRequest"/></param>
        /// <returns><see cref="ListFunctionsResponse"/></returns>
        public Task<ListFunctionsResponse> ListFunctions(ListFunctionsRequest req)
        {
            return InternalRequestAsync<ListFunctionsResponse>(req, "ListFunctions");
        }

        /// <summary>
        /// 该接口根据传入的查询参数返回相关函数信息。
        /// </summary>
        /// <param name="req"><see cref="ListFunctionsRequest"/></param>
        /// <returns><see cref="ListFunctionsResponse"/></returns>
        public ListFunctionsResponse ListFunctionsSync(ListFunctionsRequest req)
        {
            return InternalRequestAsync<ListFunctionsResponse>(req, "ListFunctions")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 返回指定层的全部版本的信息
        /// </summary>
        /// <param name="req"><see cref="ListLayerVersionsRequest"/></param>
        /// <returns><see cref="ListLayerVersionsResponse"/></returns>
        public Task<ListLayerVersionsResponse> ListLayerVersions(ListLayerVersionsRequest req)
        {
            return InternalRequestAsync<ListLayerVersionsResponse>(req, "ListLayerVersions");
        }

        /// <summary>
        /// 返回指定层的全部版本的信息
        /// </summary>
        /// <param name="req"><see cref="ListLayerVersionsRequest"/></param>
        /// <returns><see cref="ListLayerVersionsResponse"/></returns>
        public ListLayerVersionsResponse ListLayerVersionsSync(ListLayerVersionsRequest req)
        {
            return InternalRequestAsync<ListLayerVersionsResponse>(req, "ListLayerVersions")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 返回全部层的列表，其中包含了每个层最新版本的信息，可以通过适配运行时进行过滤。
        /// </summary>
        /// <param name="req"><see cref="ListLayersRequest"/></param>
        /// <returns><see cref="ListLayersResponse"/></returns>
        public Task<ListLayersResponse> ListLayers(ListLayersRequest req)
        {
            return InternalRequestAsync<ListLayersResponse>(req, "ListLayers");
        }

        /// <summary>
        /// 返回全部层的列表，其中包含了每个层最新版本的信息，可以通过适配运行时进行过滤。
        /// </summary>
        /// <param name="req"><see cref="ListLayersRequest"/></param>
        /// <returns><see cref="ListLayersResponse"/></returns>
        public ListLayersResponse ListLayersSync(ListLayersRequest req)
        {
            return InternalRequestAsync<ListLayersResponse>(req, "ListLayers")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 列出命名空间列表
        /// </summary>
        /// <param name="req"><see cref="ListNamespacesRequest"/></param>
        /// <returns><see cref="ListNamespacesResponse"/></returns>
        public Task<ListNamespacesResponse> ListNamespaces(ListNamespacesRequest req)
        {
            return InternalRequestAsync<ListNamespacesResponse>(req, "ListNamespaces");
        }

        /// <summary>
        /// 列出命名空间列表
        /// </summary>
        /// <param name="req"><see cref="ListNamespacesRequest"/></param>
        /// <returns><see cref="ListNamespacesResponse"/></returns>
        public ListNamespacesResponse ListNamespacesSync(ListNamespacesRequest req)
        {
            return InternalRequestAsync<ListNamespacesResponse>(req, "ListNamespaces")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取函数触发器列表
        /// </summary>
        /// <param name="req"><see cref="ListTriggersRequest"/></param>
        /// <returns><see cref="ListTriggersResponse"/></returns>
        public Task<ListTriggersResponse> ListTriggers(ListTriggersRequest req)
        {
            return InternalRequestAsync<ListTriggersResponse>(req, "ListTriggers");
        }

        /// <summary>
        /// 获取函数触发器列表
        /// </summary>
        /// <param name="req"><see cref="ListTriggersRequest"/></param>
        /// <returns><see cref="ListTriggersResponse"/></returns>
        public ListTriggersResponse ListTriggersSync(ListTriggersRequest req)
        {
            return InternalRequestAsync<ListTriggersResponse>(req, "ListTriggers")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口根据传入的参数查询函数的版本。
        /// </summary>
        /// <param name="req"><see cref="ListVersionByFunctionRequest"/></param>
        /// <returns><see cref="ListVersionByFunctionResponse"/></returns>
        public Task<ListVersionByFunctionResponse> ListVersionByFunction(ListVersionByFunctionRequest req)
        {
            return InternalRequestAsync<ListVersionByFunctionResponse>(req, "ListVersionByFunction");
        }

        /// <summary>
        /// 该接口根据传入的参数查询函数的版本。
        /// </summary>
        /// <param name="req"><see cref="ListVersionByFunctionRequest"/></param>
        /// <returns><see cref="ListVersionByFunctionResponse"/></returns>
        public ListVersionByFunctionResponse ListVersionByFunctionSync(ListVersionByFunctionRequest req)
        {
            return InternalRequestAsync<ListVersionByFunctionResponse>(req, "ListVersionByFunction")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 使用给定的zip文件或cos对象创建一个层的新版本，每次使用相同的层的名称调用本接口，都会生成一个新版本。
        /// </summary>
        /// <param name="req"><see cref="PublishLayerVersionRequest"/></param>
        /// <returns><see cref="PublishLayerVersionResponse"/></returns>
        public Task<PublishLayerVersionResponse> PublishLayerVersion(PublishLayerVersionRequest req)
        {
            return InternalRequestAsync<PublishLayerVersionResponse>(req, "PublishLayerVersion");
        }

        /// <summary>
        /// 使用给定的zip文件或cos对象创建一个层的新版本，每次使用相同的层的名称调用本接口，都会生成一个新版本。
        /// </summary>
        /// <param name="req"><see cref="PublishLayerVersionRequest"/></param>
        /// <returns><see cref="PublishLayerVersionResponse"/></returns>
        public PublishLayerVersionResponse PublishLayerVersionSync(PublishLayerVersionRequest req)
        {
            return InternalRequestAsync<PublishLayerVersionResponse>(req, "PublishLayerVersion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口用于用户发布新版本函数。
        /// </summary>
        /// <param name="req"><see cref="PublishVersionRequest"/></param>
        /// <returns><see cref="PublishVersionResponse"/></returns>
        public Task<PublishVersionResponse> PublishVersion(PublishVersionRequest req)
        {
            return InternalRequestAsync<PublishVersionResponse>(req, "PublishVersion");
        }

        /// <summary>
        /// 该接口用于用户发布新版本函数。
        /// </summary>
        /// <param name="req"><see cref="PublishVersionRequest"/></param>
        /// <returns><see cref="PublishVersionResponse"/></returns>
        public PublishVersionResponse PublishVersionSync(PublishVersionRequest req)
        {
            return InternalRequestAsync<PublishVersionResponse>(req, "PublishVersion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 设置函数某一非$LATEST版本的预置并发。
        /// </summary>
        /// <param name="req"><see cref="PutProvisionedConcurrencyConfigRequest"/></param>
        /// <returns><see cref="PutProvisionedConcurrencyConfigResponse"/></returns>
        public Task<PutProvisionedConcurrencyConfigResponse> PutProvisionedConcurrencyConfig(PutProvisionedConcurrencyConfigRequest req)
        {
            return InternalRequestAsync<PutProvisionedConcurrencyConfigResponse>(req, "PutProvisionedConcurrencyConfig");
        }

        /// <summary>
        /// 设置函数某一非$LATEST版本的预置并发。
        /// </summary>
        /// <param name="req"><see cref="PutProvisionedConcurrencyConfigRequest"/></param>
        /// <returns><see cref="PutProvisionedConcurrencyConfigResponse"/></returns>
        public PutProvisionedConcurrencyConfigResponse PutProvisionedConcurrencyConfigSync(PutProvisionedConcurrencyConfigRequest req)
        {
            return InternalRequestAsync<PutProvisionedConcurrencyConfigResponse>(req, "PutProvisionedConcurrencyConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 设置函数最大独占配额
        /// </summary>
        /// <param name="req"><see cref="PutReservedConcurrencyConfigRequest"/></param>
        /// <returns><see cref="PutReservedConcurrencyConfigResponse"/></returns>
        public Task<PutReservedConcurrencyConfigResponse> PutReservedConcurrencyConfig(PutReservedConcurrencyConfigRequest req)
        {
            return InternalRequestAsync<PutReservedConcurrencyConfigResponse>(req, "PutReservedConcurrencyConfig");
        }

        /// <summary>
        /// 设置函数最大独占配额
        /// </summary>
        /// <param name="req"><see cref="PutReservedConcurrencyConfigRequest"/></param>
        /// <returns><see cref="PutReservedConcurrencyConfigResponse"/></returns>
        public PutReservedConcurrencyConfigResponse PutReservedConcurrencyConfigSync(PutReservedConcurrencyConfigRequest req)
        {
            return InternalRequestAsync<PutReservedConcurrencyConfigResponse>(req, "PutReservedConcurrencyConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改账号并发限制配额
        /// </summary>
        /// <param name="req"><see cref="PutTotalConcurrencyConfigRequest"/></param>
        /// <returns><see cref="PutTotalConcurrencyConfigResponse"/></returns>
        public Task<PutTotalConcurrencyConfigResponse> PutTotalConcurrencyConfig(PutTotalConcurrencyConfigRequest req)
        {
            return InternalRequestAsync<PutTotalConcurrencyConfigResponse>(req, "PutTotalConcurrencyConfig");
        }

        /// <summary>
        /// 修改账号并发限制配额
        /// </summary>
        /// <param name="req"><see cref="PutTotalConcurrencyConfigRequest"/></param>
        /// <returns><see cref="PutTotalConcurrencyConfigResponse"/></returns>
        public PutTotalConcurrencyConfigResponse PutTotalConcurrencyConfigSync(PutTotalConcurrencyConfigRequest req)
        {
            return InternalRequestAsync<PutTotalConcurrencyConfigResponse>(req, "PutTotalConcurrencyConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 终止正在运行中的函数异步事件
        /// </summary>
        /// <param name="req"><see cref="TerminateAsyncEventRequest"/></param>
        /// <returns><see cref="TerminateAsyncEventResponse"/></returns>
        public Task<TerminateAsyncEventResponse> TerminateAsyncEvent(TerminateAsyncEventRequest req)
        {
            return InternalRequestAsync<TerminateAsyncEventResponse>(req, "TerminateAsyncEvent");
        }

        /// <summary>
        /// 终止正在运行中的函数异步事件
        /// </summary>
        /// <param name="req"><see cref="TerminateAsyncEventRequest"/></param>
        /// <returns><see cref="TerminateAsyncEventResponse"/></returns>
        public TerminateAsyncEventResponse TerminateAsyncEventSync(TerminateAsyncEventRequest req)
        {
            return InternalRequestAsync<TerminateAsyncEventResponse>(req, "TerminateAsyncEvent")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新别名的配置
        /// </summary>
        /// <param name="req"><see cref="UpdateAliasRequest"/></param>
        /// <returns><see cref="UpdateAliasResponse"/></returns>
        public Task<UpdateAliasResponse> UpdateAlias(UpdateAliasRequest req)
        {
            return InternalRequestAsync<UpdateAliasResponse>(req, "UpdateAlias");
        }

        /// <summary>
        /// 更新别名的配置
        /// </summary>
        /// <param name="req"><see cref="UpdateAliasRequest"/></param>
        /// <returns><see cref="UpdateAliasResponse"/></returns>
        public UpdateAliasResponse UpdateAliasSync(UpdateAliasRequest req)
        {
            return InternalRequestAsync<UpdateAliasResponse>(req, "UpdateAlias")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口根据传入参数更新函数代码。
        /// </summary>
        /// <param name="req"><see cref="UpdateFunctionCodeRequest"/></param>
        /// <returns><see cref="UpdateFunctionCodeResponse"/></returns>
        public Task<UpdateFunctionCodeResponse> UpdateFunctionCode(UpdateFunctionCodeRequest req)
        {
            return InternalRequestAsync<UpdateFunctionCodeResponse>(req, "UpdateFunctionCode");
        }

        /// <summary>
        /// 该接口根据传入参数更新函数代码。
        /// </summary>
        /// <param name="req"><see cref="UpdateFunctionCodeRequest"/></param>
        /// <returns><see cref="UpdateFunctionCodeResponse"/></returns>
        public UpdateFunctionCodeResponse UpdateFunctionCodeSync(UpdateFunctionCodeRequest req)
        {
            return InternalRequestAsync<UpdateFunctionCodeResponse>(req, "UpdateFunctionCode")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口根据传入参数更新函数配置。
        /// </summary>
        /// <param name="req"><see cref="UpdateFunctionConfigurationRequest"/></param>
        /// <returns><see cref="UpdateFunctionConfigurationResponse"/></returns>
        public Task<UpdateFunctionConfigurationResponse> UpdateFunctionConfiguration(UpdateFunctionConfigurationRequest req)
        {
            return InternalRequestAsync<UpdateFunctionConfigurationResponse>(req, "UpdateFunctionConfiguration");
        }

        /// <summary>
        /// 该接口根据传入参数更新函数配置。
        /// </summary>
        /// <param name="req"><see cref="UpdateFunctionConfigurationRequest"/></param>
        /// <returns><see cref="UpdateFunctionConfigurationResponse"/></returns>
        public UpdateFunctionConfigurationResponse UpdateFunctionConfigurationSync(UpdateFunctionConfigurationRequest req)
        {
            return InternalRequestAsync<UpdateFunctionConfigurationResponse>(req, "UpdateFunctionConfiguration")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新函数的异步重试配置，包括重试次数和消息保留时间
        /// </summary>
        /// <param name="req"><see cref="UpdateFunctionEventInvokeConfigRequest"/></param>
        /// <returns><see cref="UpdateFunctionEventInvokeConfigResponse"/></returns>
        public Task<UpdateFunctionEventInvokeConfigResponse> UpdateFunctionEventInvokeConfig(UpdateFunctionEventInvokeConfigRequest req)
        {
            return InternalRequestAsync<UpdateFunctionEventInvokeConfigResponse>(req, "UpdateFunctionEventInvokeConfig");
        }

        /// <summary>
        /// 更新函数的异步重试配置，包括重试次数和消息保留时间
        /// </summary>
        /// <param name="req"><see cref="UpdateFunctionEventInvokeConfigRequest"/></param>
        /// <returns><see cref="UpdateFunctionEventInvokeConfigResponse"/></returns>
        public UpdateFunctionEventInvokeConfigResponse UpdateFunctionEventInvokeConfigSync(UpdateFunctionEventInvokeConfigRequest req)
        {
            return InternalRequestAsync<UpdateFunctionEventInvokeConfigResponse>(req, "UpdateFunctionEventInvokeConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新命名空间
        /// </summary>
        /// <param name="req"><see cref="UpdateNamespaceRequest"/></param>
        /// <returns><see cref="UpdateNamespaceResponse"/></returns>
        public Task<UpdateNamespaceResponse> UpdateNamespace(UpdateNamespaceRequest req)
        {
            return InternalRequestAsync<UpdateNamespaceResponse>(req, "UpdateNamespace");
        }

        /// <summary>
        /// 更新命名空间
        /// </summary>
        /// <param name="req"><see cref="UpdateNamespaceRequest"/></param>
        /// <returns><see cref="UpdateNamespaceResponse"/></returns>
        public UpdateNamespaceResponse UpdateNamespaceSync(UpdateNamespaceRequest req)
        {
            return InternalRequestAsync<UpdateNamespaceResponse>(req, "UpdateNamespace")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 支持触发器配置更新。
        /// 默认接口请求频率限制：20次/秒
        /// 
        /// 注意：目前只支持timer触发器和ckafka触发器更新！
        /// 
        /// timer触发器和ckafka触发器支持更新字段有：Enable、TriggerDesc、Description、CustomArgument。
        /// 
        /// timer触发器TriggerDesc支持5段式和7段式的更新。
        /// 
        /// ckafka触发器TriggerDesc支持Retry、MaxMsgNum、TimeOut参数更新，不传值表示原值不变，传值不能为空。
        /// 
        /// Enable 触发器开启或关闭，传参为OPEN为开启，CLOSE为关闭。不传值表示原值不变，传值不能为空。
        /// 
        /// Description 触发器描述，不传值保持原值不变，传值为空则为空。
        /// 
        /// CustomArgument 触发器用户附加信息（注意：只有timer触发器展示），不传值保持原值不变，传值为空则为空。
        /// </summary>
        /// <param name="req"><see cref="UpdateTriggerRequest"/></param>
        /// <returns><see cref="UpdateTriggerResponse"/></returns>
        public Task<UpdateTriggerResponse> UpdateTrigger(UpdateTriggerRequest req)
        {
            return InternalRequestAsync<UpdateTriggerResponse>(req, "UpdateTrigger");
        }

        /// <summary>
        /// 支持触发器配置更新。
        /// 默认接口请求频率限制：20次/秒
        /// 
        /// 注意：目前只支持timer触发器和ckafka触发器更新！
        /// 
        /// timer触发器和ckafka触发器支持更新字段有：Enable、TriggerDesc、Description、CustomArgument。
        /// 
        /// timer触发器TriggerDesc支持5段式和7段式的更新。
        /// 
        /// ckafka触发器TriggerDesc支持Retry、MaxMsgNum、TimeOut参数更新，不传值表示原值不变，传值不能为空。
        /// 
        /// Enable 触发器开启或关闭，传参为OPEN为开启，CLOSE为关闭。不传值表示原值不变，传值不能为空。
        /// 
        /// Description 触发器描述，不传值保持原值不变，传值为空则为空。
        /// 
        /// CustomArgument 触发器用户附加信息（注意：只有timer触发器展示），不传值保持原值不变，传值为空则为空。
        /// </summary>
        /// <param name="req"><see cref="UpdateTriggerRequest"/></param>
        /// <returns><see cref="UpdateTriggerResponse"/></returns>
        public UpdateTriggerResponse UpdateTriggerSync(UpdateTriggerRequest req)
        {
            return InternalRequestAsync<UpdateTriggerResponse>(req, "UpdateTrigger")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新触发器状态的值
        /// </summary>
        /// <param name="req"><see cref="UpdateTriggerStatusRequest"/></param>
        /// <returns><see cref="UpdateTriggerStatusResponse"/></returns>
        public Task<UpdateTriggerStatusResponse> UpdateTriggerStatus(UpdateTriggerStatusRequest req)
        {
            return InternalRequestAsync<UpdateTriggerStatusResponse>(req, "UpdateTriggerStatus");
        }

        /// <summary>
        /// 更新触发器状态的值
        /// </summary>
        /// <param name="req"><see cref="UpdateTriggerStatusRequest"/></param>
        /// <returns><see cref="UpdateTriggerStatusResponse"/></returns>
        public UpdateTriggerStatusResponse UpdateTriggerStatusSync(UpdateTriggerStatusRequest req)
        {
            return InternalRequestAsync<UpdateTriggerStatusResponse>(req, "UpdateTriggerStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
