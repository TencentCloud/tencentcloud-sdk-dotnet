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

namespace TencentCloud.Gse.V20191112
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Gse.V20191112.Models;

   public class GseClient : AbstractClient{

       private const string endpoint = "gse.tencentcloudapi.com";
       private const string version = "2019-11-12";
       private const string sdkVersion = "SDK_NET_3.0.1189";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public GseClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public GseClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 此接口无法使用，游戏服务器引擎GSE已于6.1正式下架，感谢您的支持
        /// 
        /// 本接口（AttachCcnInstances）用于关联云联网实例。
        /// </summary>
        /// <param name="req"><see cref="AttachCcnInstancesRequest"/></param>
        /// <returns><see cref="AttachCcnInstancesResponse"/></returns>
        public Task<AttachCcnInstancesResponse> AttachCcnInstances(AttachCcnInstancesRequest req)
        {
            return InternalRequestAsync<AttachCcnInstancesResponse>(req, "AttachCcnInstances");
        }

        /// <summary>
        /// 此接口无法使用，游戏服务器引擎GSE已于6.1正式下架，感谢您的支持
        /// 
        /// 本接口（AttachCcnInstances）用于关联云联网实例。
        /// </summary>
        /// <param name="req"><see cref="AttachCcnInstancesRequest"/></param>
        /// <returns><see cref="AttachCcnInstancesResponse"/></returns>
        public AttachCcnInstancesResponse AttachCcnInstancesSync(AttachCcnInstancesRequest req)
        {
            return InternalRequestAsync<AttachCcnInstancesResponse>(req, "AttachCcnInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口无法使用，游戏服务器引擎GSE已于6.1正式下架，感谢您的支持
        /// 
        /// 本接口（CopyFleet）用于复制服务器舰队。
        /// </summary>
        /// <param name="req"><see cref="CopyFleetRequest"/></param>
        /// <returns><see cref="CopyFleetResponse"/></returns>
        public Task<CopyFleetResponse> CopyFleet(CopyFleetRequest req)
        {
            return InternalRequestAsync<CopyFleetResponse>(req, "CopyFleet");
        }

        /// <summary>
        /// 此接口无法使用，游戏服务器引擎GSE已于6.1正式下架，感谢您的支持
        /// 
        /// 本接口（CopyFleet）用于复制服务器舰队。
        /// </summary>
        /// <param name="req"><see cref="CopyFleetRequest"/></param>
        /// <returns><see cref="CopyFleetResponse"/></returns>
        public CopyFleetResponse CopyFleetSync(CopyFleetRequest req)
        {
            return InternalRequestAsync<CopyFleetResponse>(req, "CopyFleet")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口无法使用，游戏服务器引擎GSE已于6.1正式下架，感谢您的支持
        /// 
        /// 本接口（CreateAlias）用于创建别名。
        /// </summary>
        /// <param name="req"><see cref="CreateAliasRequest"/></param>
        /// <returns><see cref="CreateAliasResponse"/></returns>
        public Task<CreateAliasResponse> CreateAlias(CreateAliasRequest req)
        {
            return InternalRequestAsync<CreateAliasResponse>(req, "CreateAlias");
        }

        /// <summary>
        /// 此接口无法使用，游戏服务器引擎GSE已于6.1正式下架，感谢您的支持
        /// 
        /// 本接口（CreateAlias）用于创建别名。
        /// </summary>
        /// <param name="req"><see cref="CreateAliasRequest"/></param>
        /// <returns><see cref="CreateAliasResponse"/></returns>
        public CreateAliasResponse CreateAliasSync(CreateAliasRequest req)
        {
            return InternalRequestAsync<CreateAliasResponse>(req, "CreateAlias")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口无法使用，游戏服务器引擎GSE已于6.1正式下架，感谢您的支持
        /// 
        /// 本接口（CreateAsset）用于创建生成包。
        /// 通过获取上传cos的临时密钥，将文件上传至cos，然后将生成包的zip名称下发给本接口完成资源创建。  
        /// 
        /// 上传文件至 cos支持俩种方式：
        /// 
        /// - 获取预签名方式，COS 简单上传
        ///     1. [GetUploadCredentials](https://cloud.tencent.com/document/product/1165/48727) 获取预签名信息
        ///     2. 使用 COS API 进行上传([参考文档](https://cloud.tencent.com/document/product/436/7749))
        /// -  临时密钥方式，COS 简单上传或者分块上传方式
        ///     1. [GetUploadCredentials](https://cloud.tencent.com/document/product/1165/48727)（获取上传 bucket  第一次调用需要，后续可以不用调用）
        ///     2. [GetUploadFederationToken](https://cloud.tencent.com/document/product/1165/48742) 获取临时密钥
        ///     3. 使用 COS API 进行上传([参考文档](https://cloud.tencent.com/document/product/436/7742))
        /// 
        /// 具体使用场景可以参考 [GetUploadCredentials](https://cloud.tencent.com/document/product/1165/48727) ,  [GetUploadFederationToken](https://cloud.tencent.com/document/product/1165/48742)和下面 CreateAsset 示例。  
        /// </summary>
        /// <param name="req"><see cref="CreateAssetRequest"/></param>
        /// <returns><see cref="CreateAssetResponse"/></returns>
        public Task<CreateAssetResponse> CreateAsset(CreateAssetRequest req)
        {
            return InternalRequestAsync<CreateAssetResponse>(req, "CreateAsset");
        }

        /// <summary>
        /// 此接口无法使用，游戏服务器引擎GSE已于6.1正式下架，感谢您的支持
        /// 
        /// 本接口（CreateAsset）用于创建生成包。
        /// 通过获取上传cos的临时密钥，将文件上传至cos，然后将生成包的zip名称下发给本接口完成资源创建。  
        /// 
        /// 上传文件至 cos支持俩种方式：
        /// 
        /// - 获取预签名方式，COS 简单上传
        ///     1. [GetUploadCredentials](https://cloud.tencent.com/document/product/1165/48727) 获取预签名信息
        ///     2. 使用 COS API 进行上传([参考文档](https://cloud.tencent.com/document/product/436/7749))
        /// -  临时密钥方式，COS 简单上传或者分块上传方式
        ///     1. [GetUploadCredentials](https://cloud.tencent.com/document/product/1165/48727)（获取上传 bucket  第一次调用需要，后续可以不用调用）
        ///     2. [GetUploadFederationToken](https://cloud.tencent.com/document/product/1165/48742) 获取临时密钥
        ///     3. 使用 COS API 进行上传([参考文档](https://cloud.tencent.com/document/product/436/7742))
        /// 
        /// 具体使用场景可以参考 [GetUploadCredentials](https://cloud.tencent.com/document/product/1165/48727) ,  [GetUploadFederationToken](https://cloud.tencent.com/document/product/1165/48742)和下面 CreateAsset 示例。  
        /// </summary>
        /// <param name="req"><see cref="CreateAssetRequest"/></param>
        /// <returns><see cref="CreateAssetResponse"/></returns>
        public CreateAssetResponse CreateAssetSync(CreateAssetRequest req)
        {
            return InternalRequestAsync<CreateAssetResponse>(req, "CreateAsset")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口无法使用，游戏服务器引擎GSE已于6.1正式下架，感谢您的支持
        /// 
        /// 本接口（CreateAssetWithImage）用于创建生成包镜像信息。
        /// </summary>
        /// <param name="req"><see cref="CreateAssetWithImageRequest"/></param>
        /// <returns><see cref="CreateAssetWithImageResponse"/></returns>
        public Task<CreateAssetWithImageResponse> CreateAssetWithImage(CreateAssetWithImageRequest req)
        {
            return InternalRequestAsync<CreateAssetWithImageResponse>(req, "CreateAssetWithImage");
        }

        /// <summary>
        /// 此接口无法使用，游戏服务器引擎GSE已于6.1正式下架，感谢您的支持
        /// 
        /// 本接口（CreateAssetWithImage）用于创建生成包镜像信息。
        /// </summary>
        /// <param name="req"><see cref="CreateAssetWithImageRequest"/></param>
        /// <returns><see cref="CreateAssetWithImageResponse"/></returns>
        public CreateAssetWithImageResponse CreateAssetWithImageSync(CreateAssetWithImageRequest req)
        {
            return InternalRequestAsync<CreateAssetWithImageResponse>(req, "CreateAssetWithImage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口无法使用，游戏服务器引擎GSE已于6.1正式下架，感谢您的支持
        /// 
        /// 本接口（CreateFleet）用于创建服务器舰队。
        /// </summary>
        /// <param name="req"><see cref="CreateFleetRequest"/></param>
        /// <returns><see cref="CreateFleetResponse"/></returns>
        public Task<CreateFleetResponse> CreateFleet(CreateFleetRequest req)
        {
            return InternalRequestAsync<CreateFleetResponse>(req, "CreateFleet");
        }

        /// <summary>
        /// 此接口无法使用，游戏服务器引擎GSE已于6.1正式下架，感谢您的支持
        /// 
        /// 本接口（CreateFleet）用于创建服务器舰队。
        /// </summary>
        /// <param name="req"><see cref="CreateFleetRequest"/></param>
        /// <returns><see cref="CreateFleetResponse"/></returns>
        public CreateFleetResponse CreateFleetSync(CreateFleetRequest req)
        {
            return InternalRequestAsync<CreateFleetResponse>(req, "CreateFleet")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口无法使用，游戏服务器引擎GSE已于6.1正式下架，感谢您的支持
        /// 
        /// 本接口（CreateGameServerSession）用于创建游戏服务会话。
        /// </summary>
        /// <param name="req"><see cref="CreateGameServerSessionRequest"/></param>
        /// <returns><see cref="CreateGameServerSessionResponse"/></returns>
        public Task<CreateGameServerSessionResponse> CreateGameServerSession(CreateGameServerSessionRequest req)
        {
            return InternalRequestAsync<CreateGameServerSessionResponse>(req, "CreateGameServerSession");
        }

        /// <summary>
        /// 此接口无法使用，游戏服务器引擎GSE已于6.1正式下架，感谢您的支持
        /// 
        /// 本接口（CreateGameServerSession）用于创建游戏服务会话。
        /// </summary>
        /// <param name="req"><see cref="CreateGameServerSessionRequest"/></param>
        /// <returns><see cref="CreateGameServerSessionResponse"/></returns>
        public CreateGameServerSessionResponse CreateGameServerSessionSync(CreateGameServerSessionRequest req)
        {
            return InternalRequestAsync<CreateGameServerSessionResponse>(req, "CreateGameServerSession")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口无法使用，游戏服务器引擎GSE已于6.1正式下架，感谢您的支持
        /// 
        /// 本接口（CreateGameServerSessionQueue）用于创建游戏服务器会话队列。
        /// </summary>
        /// <param name="req"><see cref="CreateGameServerSessionQueueRequest"/></param>
        /// <returns><see cref="CreateGameServerSessionQueueResponse"/></returns>
        public Task<CreateGameServerSessionQueueResponse> CreateGameServerSessionQueue(CreateGameServerSessionQueueRequest req)
        {
            return InternalRequestAsync<CreateGameServerSessionQueueResponse>(req, "CreateGameServerSessionQueue");
        }

        /// <summary>
        /// 此接口无法使用，游戏服务器引擎GSE已于6.1正式下架，感谢您的支持
        /// 
        /// 本接口（CreateGameServerSessionQueue）用于创建游戏服务器会话队列。
        /// </summary>
        /// <param name="req"><see cref="CreateGameServerSessionQueueRequest"/></param>
        /// <returns><see cref="CreateGameServerSessionQueueResponse"/></returns>
        public CreateGameServerSessionQueueResponse CreateGameServerSessionQueueSync(CreateGameServerSessionQueueRequest req)
        {
            return InternalRequestAsync<CreateGameServerSessionQueueResponse>(req, "CreateGameServerSessionQueue")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口无法使用，游戏服务器引擎GSE已于6.1正式下架，感谢您的支持
        /// 
        /// 本接口（DeleteAlias）用于删除别名。
        /// </summary>
        /// <param name="req"><see cref="DeleteAliasRequest"/></param>
        /// <returns><see cref="DeleteAliasResponse"/></returns>
        public Task<DeleteAliasResponse> DeleteAlias(DeleteAliasRequest req)
        {
            return InternalRequestAsync<DeleteAliasResponse>(req, "DeleteAlias");
        }

        /// <summary>
        /// 此接口无法使用，游戏服务器引擎GSE已于6.1正式下架，感谢您的支持
        /// 
        /// 本接口（DeleteAlias）用于删除别名。
        /// </summary>
        /// <param name="req"><see cref="DeleteAliasRequest"/></param>
        /// <returns><see cref="DeleteAliasResponse"/></returns>
        public DeleteAliasResponse DeleteAliasSync(DeleteAliasRequest req)
        {
            return InternalRequestAsync<DeleteAliasResponse>(req, "DeleteAlias")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口无法使用，游戏服务器引擎GSE已于6.1正式下架，感谢您的支持
        /// 
        /// 本接口（DeleteAsset）用于删除生成包。
        /// </summary>
        /// <param name="req"><see cref="DeleteAssetRequest"/></param>
        /// <returns><see cref="DeleteAssetResponse"/></returns>
        public Task<DeleteAssetResponse> DeleteAsset(DeleteAssetRequest req)
        {
            return InternalRequestAsync<DeleteAssetResponse>(req, "DeleteAsset");
        }

        /// <summary>
        /// 此接口无法使用，游戏服务器引擎GSE已于6.1正式下架，感谢您的支持
        /// 
        /// 本接口（DeleteAsset）用于删除生成包。
        /// </summary>
        /// <param name="req"><see cref="DeleteAssetRequest"/></param>
        /// <returns><see cref="DeleteAssetResponse"/></returns>
        public DeleteAssetResponse DeleteAssetSync(DeleteAssetRequest req)
        {
            return InternalRequestAsync<DeleteAssetResponse>(req, "DeleteAsset")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口无法使用，游戏服务器引擎GSE已于6.1正式下架，感谢您的支持
        /// 
        /// 本接口（DeleteFleet）用于删除服务器舰队。
        /// </summary>
        /// <param name="req"><see cref="DeleteFleetRequest"/></param>
        /// <returns><see cref="DeleteFleetResponse"/></returns>
        public Task<DeleteFleetResponse> DeleteFleet(DeleteFleetRequest req)
        {
            return InternalRequestAsync<DeleteFleetResponse>(req, "DeleteFleet");
        }

        /// <summary>
        /// 此接口无法使用，游戏服务器引擎GSE已于6.1正式下架，感谢您的支持
        /// 
        /// 本接口（DeleteFleet）用于删除服务器舰队。
        /// </summary>
        /// <param name="req"><see cref="DeleteFleetRequest"/></param>
        /// <returns><see cref="DeleteFleetResponse"/></returns>
        public DeleteFleetResponse DeleteFleetSync(DeleteFleetRequest req)
        {
            return InternalRequestAsync<DeleteFleetResponse>(req, "DeleteFleet")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口无法使用，游戏服务器引擎GSE已于6.1正式下架，感谢您的支持
        /// 
        /// 本接口（DeleteGameServerSessionQueue）用于删除游戏服务器会话队列。
        /// </summary>
        /// <param name="req"><see cref="DeleteGameServerSessionQueueRequest"/></param>
        /// <returns><see cref="DeleteGameServerSessionQueueResponse"/></returns>
        public Task<DeleteGameServerSessionQueueResponse> DeleteGameServerSessionQueue(DeleteGameServerSessionQueueRequest req)
        {
            return InternalRequestAsync<DeleteGameServerSessionQueueResponse>(req, "DeleteGameServerSessionQueue");
        }

        /// <summary>
        /// 此接口无法使用，游戏服务器引擎GSE已于6.1正式下架，感谢您的支持
        /// 
        /// 本接口（DeleteGameServerSessionQueue）用于删除游戏服务器会话队列。
        /// </summary>
        /// <param name="req"><see cref="DeleteGameServerSessionQueueRequest"/></param>
        /// <returns><see cref="DeleteGameServerSessionQueueResponse"/></returns>
        public DeleteGameServerSessionQueueResponse DeleteGameServerSessionQueueSync(DeleteGameServerSessionQueueRequest req)
        {
            return InternalRequestAsync<DeleteGameServerSessionQueueResponse>(req, "DeleteGameServerSessionQueue")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口无法使用，游戏服务器引擎GSE已于6.1正式下架，感谢您的支持
        /// 
        /// 本接口（DeleteScalingPolicy）用于删除服务器舰队的扩缩容策略。
        /// 通过服务器舰队ID和策略名称删除服务器舰队的扩缩容策略，只传递服务器舰队ID时，会将这个服务器舰队下的所有策略都删除。
        /// 传递策略名称时，单独删除策略名称对应的策略。
        /// </summary>
        /// <param name="req"><see cref="DeleteScalingPolicyRequest"/></param>
        /// <returns><see cref="DeleteScalingPolicyResponse"/></returns>
        public Task<DeleteScalingPolicyResponse> DeleteScalingPolicy(DeleteScalingPolicyRequest req)
        {
            return InternalRequestAsync<DeleteScalingPolicyResponse>(req, "DeleteScalingPolicy");
        }

        /// <summary>
        /// 此接口无法使用，游戏服务器引擎GSE已于6.1正式下架，感谢您的支持
        /// 
        /// 本接口（DeleteScalingPolicy）用于删除服务器舰队的扩缩容策略。
        /// 通过服务器舰队ID和策略名称删除服务器舰队的扩缩容策略，只传递服务器舰队ID时，会将这个服务器舰队下的所有策略都删除。
        /// 传递策略名称时，单独删除策略名称对应的策略。
        /// </summary>
        /// <param name="req"><see cref="DeleteScalingPolicyRequest"/></param>
        /// <returns><see cref="DeleteScalingPolicyResponse"/></returns>
        public DeleteScalingPolicyResponse DeleteScalingPolicySync(DeleteScalingPolicyRequest req)
        {
            return InternalRequestAsync<DeleteScalingPolicyResponse>(req, "DeleteScalingPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口无法使用，游戏服务器引擎GSE已于6.1正式下架，感谢您的支持
        /// 
        /// 本接口（DeleteTimerScalingPolicy）用于删除fleet下的定时器。
        /// </summary>
        /// <param name="req"><see cref="DeleteTimerScalingPolicyRequest"/></param>
        /// <returns><see cref="DeleteTimerScalingPolicyResponse"/></returns>
        public Task<DeleteTimerScalingPolicyResponse> DeleteTimerScalingPolicy(DeleteTimerScalingPolicyRequest req)
        {
            return InternalRequestAsync<DeleteTimerScalingPolicyResponse>(req, "DeleteTimerScalingPolicy");
        }

        /// <summary>
        /// 此接口无法使用，游戏服务器引擎GSE已于6.1正式下架，感谢您的支持
        /// 
        /// 本接口（DeleteTimerScalingPolicy）用于删除fleet下的定时器。
        /// </summary>
        /// <param name="req"><see cref="DeleteTimerScalingPolicyRequest"/></param>
        /// <returns><see cref="DeleteTimerScalingPolicyResponse"/></returns>
        public DeleteTimerScalingPolicyResponse DeleteTimerScalingPolicySync(DeleteTimerScalingPolicyRequest req)
        {
            return InternalRequestAsync<DeleteTimerScalingPolicyResponse>(req, "DeleteTimerScalingPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口无法使用，游戏服务器引擎GSE已于6.1正式下架，感谢您的支持
        /// 
        /// 本接口（DescribeAlias）用于获取别名详情。
        /// </summary>
        /// <param name="req"><see cref="DescribeAliasRequest"/></param>
        /// <returns><see cref="DescribeAliasResponse"/></returns>
        public Task<DescribeAliasResponse> DescribeAlias(DescribeAliasRequest req)
        {
            return InternalRequestAsync<DescribeAliasResponse>(req, "DescribeAlias");
        }

        /// <summary>
        /// 此接口无法使用，游戏服务器引擎GSE已于6.1正式下架，感谢您的支持
        /// 
        /// 本接口（DescribeAlias）用于获取别名详情。
        /// </summary>
        /// <param name="req"><see cref="DescribeAliasRequest"/></param>
        /// <returns><see cref="DescribeAliasResponse"/></returns>
        public DescribeAliasResponse DescribeAliasSync(DescribeAliasRequest req)
        {
            return InternalRequestAsync<DescribeAliasResponse>(req, "DescribeAlias")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口无法使用，游戏服务器引擎GSE已于6.1正式下架，感谢您的支持
        /// 
        /// 本接口（DescribeAsset）获取生成包信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetRequest"/></param>
        /// <returns><see cref="DescribeAssetResponse"/></returns>
        public Task<DescribeAssetResponse> DescribeAsset(DescribeAssetRequest req)
        {
            return InternalRequestAsync<DescribeAssetResponse>(req, "DescribeAsset");
        }

        /// <summary>
        /// 此接口无法使用，游戏服务器引擎GSE已于6.1正式下架，感谢您的支持
        /// 
        /// 本接口（DescribeAsset）获取生成包信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetRequest"/></param>
        /// <returns><see cref="DescribeAssetResponse"/></returns>
        public DescribeAssetResponse DescribeAssetSync(DescribeAssetRequest req)
        {
            return InternalRequestAsync<DescribeAssetResponse>(req, "DescribeAsset")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口无法使用，游戏服务器引擎GSE已于6.1正式下架，感谢您的支持
        /// 
        /// 本接口（DescribeAssetSystems）用于获取生成包支持的操作系统。
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetSystemsRequest"/></param>
        /// <returns><see cref="DescribeAssetSystemsResponse"/></returns>
        public Task<DescribeAssetSystemsResponse> DescribeAssetSystems(DescribeAssetSystemsRequest req)
        {
            return InternalRequestAsync<DescribeAssetSystemsResponse>(req, "DescribeAssetSystems");
        }

        /// <summary>
        /// 此接口无法使用，游戏服务器引擎GSE已于6.1正式下架，感谢您的支持
        /// 
        /// 本接口（DescribeAssetSystems）用于获取生成包支持的操作系统。
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetSystemsRequest"/></param>
        /// <returns><see cref="DescribeAssetSystemsResponse"/></returns>
        public DescribeAssetSystemsResponse DescribeAssetSystemsSync(DescribeAssetSystemsRequest req)
        {
            return InternalRequestAsync<DescribeAssetSystemsResponse>(req, "DescribeAssetSystems")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口无法使用，游戏服务器引擎GSE已于6.1正式下架，感谢您的支持
        /// 
        /// 本接口（DescribeAssets）用于获取生成包列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetsRequest"/></param>
        /// <returns><see cref="DescribeAssetsResponse"/></returns>
        public Task<DescribeAssetsResponse> DescribeAssets(DescribeAssetsRequest req)
        {
            return InternalRequestAsync<DescribeAssetsResponse>(req, "DescribeAssets");
        }

        /// <summary>
        /// 此接口无法使用，游戏服务器引擎GSE已于6.1正式下架，感谢您的支持
        /// 
        /// 本接口（DescribeAssets）用于获取生成包列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetsRequest"/></param>
        /// <returns><see cref="DescribeAssetsResponse"/></returns>
        public DescribeAssetsResponse DescribeAssetsSync(DescribeAssetsRequest req)
        {
            return InternalRequestAsync<DescribeAssetsResponse>(req, "DescribeAssets")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口无法使用，游戏服务器引擎GSE已于6.1正式下架，感谢您的支持
        /// 
        /// 本接口（DescribeCcnInstances）用于查询云联网实例。
        /// </summary>
        /// <param name="req"><see cref="DescribeCcnInstancesRequest"/></param>
        /// <returns><see cref="DescribeCcnInstancesResponse"/></returns>
        public Task<DescribeCcnInstancesResponse> DescribeCcnInstances(DescribeCcnInstancesRequest req)
        {
            return InternalRequestAsync<DescribeCcnInstancesResponse>(req, "DescribeCcnInstances");
        }

        /// <summary>
        /// 此接口无法使用，游戏服务器引擎GSE已于6.1正式下架，感谢您的支持
        /// 
        /// 本接口（DescribeCcnInstances）用于查询云联网实例。
        /// </summary>
        /// <param name="req"><see cref="DescribeCcnInstancesRequest"/></param>
        /// <returns><see cref="DescribeCcnInstancesResponse"/></returns>
        public DescribeCcnInstancesResponse DescribeCcnInstancesSync(DescribeCcnInstancesRequest req)
        {
            return InternalRequestAsync<DescribeCcnInstancesResponse>(req, "DescribeCcnInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口无法使用，游戏服务器引擎GSE已于6.1正式下架，感谢您的支持
        /// 
        /// 本接口（DescribeFleetAttributes）用于查询服务器舰队属性。
        /// </summary>
        /// <param name="req"><see cref="DescribeFleetAttributesRequest"/></param>
        /// <returns><see cref="DescribeFleetAttributesResponse"/></returns>
        public Task<DescribeFleetAttributesResponse> DescribeFleetAttributes(DescribeFleetAttributesRequest req)
        {
            return InternalRequestAsync<DescribeFleetAttributesResponse>(req, "DescribeFleetAttributes");
        }

        /// <summary>
        /// 此接口无法使用，游戏服务器引擎GSE已于6.1正式下架，感谢您的支持
        /// 
        /// 本接口（DescribeFleetAttributes）用于查询服务器舰队属性。
        /// </summary>
        /// <param name="req"><see cref="DescribeFleetAttributesRequest"/></param>
        /// <returns><see cref="DescribeFleetAttributesResponse"/></returns>
        public DescribeFleetAttributesResponse DescribeFleetAttributesSync(DescribeFleetAttributesRequest req)
        {
            return InternalRequestAsync<DescribeFleetAttributesResponse>(req, "DescribeFleetAttributes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口无法使用，游戏服务器引擎GSE已于6.1正式下架，感谢您的支持
        /// 
        /// 本接口（DescribeFleetCapacity）用于查询服务部署容量配置。
        /// </summary>
        /// <param name="req"><see cref="DescribeFleetCapacityRequest"/></param>
        /// <returns><see cref="DescribeFleetCapacityResponse"/></returns>
        public Task<DescribeFleetCapacityResponse> DescribeFleetCapacity(DescribeFleetCapacityRequest req)
        {
            return InternalRequestAsync<DescribeFleetCapacityResponse>(req, "DescribeFleetCapacity");
        }

        /// <summary>
        /// 此接口无法使用，游戏服务器引擎GSE已于6.1正式下架，感谢您的支持
        /// 
        /// 本接口（DescribeFleetCapacity）用于查询服务部署容量配置。
        /// </summary>
        /// <param name="req"><see cref="DescribeFleetCapacityRequest"/></param>
        /// <returns><see cref="DescribeFleetCapacityResponse"/></returns>
        public DescribeFleetCapacityResponse DescribeFleetCapacitySync(DescribeFleetCapacityRequest req)
        {
            return InternalRequestAsync<DescribeFleetCapacityResponse>(req, "DescribeFleetCapacity")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口无法使用，游戏服务器引擎GSE已于6.1正式下架，感谢您的支持
        /// 
        /// 本接口（DescribeFleetEvents）用于查询服务器舰队相关的事件列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeFleetEventsRequest"/></param>
        /// <returns><see cref="DescribeFleetEventsResponse"/></returns>
        public Task<DescribeFleetEventsResponse> DescribeFleetEvents(DescribeFleetEventsRequest req)
        {
            return InternalRequestAsync<DescribeFleetEventsResponse>(req, "DescribeFleetEvents");
        }

        /// <summary>
        /// 此接口无法使用，游戏服务器引擎GSE已于6.1正式下架，感谢您的支持
        /// 
        /// 本接口（DescribeFleetEvents）用于查询服务器舰队相关的事件列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeFleetEventsRequest"/></param>
        /// <returns><see cref="DescribeFleetEventsResponse"/></returns>
        public DescribeFleetEventsResponse DescribeFleetEventsSync(DescribeFleetEventsRequest req)
        {
            return InternalRequestAsync<DescribeFleetEventsResponse>(req, "DescribeFleetEvents")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口无法使用，游戏服务器引擎GSE已于6.1正式下架，感谢您的支持
        /// 
        /// 本接口（DescribeFleetPortSettings）用于获取服务器舰队安全组信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeFleetPortSettingsRequest"/></param>
        /// <returns><see cref="DescribeFleetPortSettingsResponse"/></returns>
        public Task<DescribeFleetPortSettingsResponse> DescribeFleetPortSettings(DescribeFleetPortSettingsRequest req)
        {
            return InternalRequestAsync<DescribeFleetPortSettingsResponse>(req, "DescribeFleetPortSettings");
        }

        /// <summary>
        /// 此接口无法使用，游戏服务器引擎GSE已于6.1正式下架，感谢您的支持
        /// 
        /// 本接口（DescribeFleetPortSettings）用于获取服务器舰队安全组信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeFleetPortSettingsRequest"/></param>
        /// <returns><see cref="DescribeFleetPortSettingsResponse"/></returns>
        public DescribeFleetPortSettingsResponse DescribeFleetPortSettingsSync(DescribeFleetPortSettingsRequest req)
        {
            return InternalRequestAsync<DescribeFleetPortSettingsResponse>(req, "DescribeFleetPortSettings")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口无法使用，游戏服务器引擎GSE已于6.1正式下架，感谢您的支持
        /// 
        /// 本接口（DescribeFleetRelatedResources）用于获取与游戏服务器舰队关联的资源信息，如别名、队列
        /// </summary>
        /// <param name="req"><see cref="DescribeFleetRelatedResourcesRequest"/></param>
        /// <returns><see cref="DescribeFleetRelatedResourcesResponse"/></returns>
        public Task<DescribeFleetRelatedResourcesResponse> DescribeFleetRelatedResources(DescribeFleetRelatedResourcesRequest req)
        {
            return InternalRequestAsync<DescribeFleetRelatedResourcesResponse>(req, "DescribeFleetRelatedResources");
        }

        /// <summary>
        /// 此接口无法使用，游戏服务器引擎GSE已于6.1正式下架，感谢您的支持
        /// 
        /// 本接口（DescribeFleetRelatedResources）用于获取与游戏服务器舰队关联的资源信息，如别名、队列
        /// </summary>
        /// <param name="req"><see cref="DescribeFleetRelatedResourcesRequest"/></param>
        /// <returns><see cref="DescribeFleetRelatedResourcesResponse"/></returns>
        public DescribeFleetRelatedResourcesResponse DescribeFleetRelatedResourcesSync(DescribeFleetRelatedResourcesRequest req)
        {
            return InternalRequestAsync<DescribeFleetRelatedResourcesResponse>(req, "DescribeFleetRelatedResources")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口无法使用，游戏服务器引擎GSE已于6.1正式下架，感谢您的支持
        /// 
        /// 本接口（DescribeFleetStatisticDetails）用于查询服务部署统计详情。
        /// </summary>
        /// <param name="req"><see cref="DescribeFleetStatisticDetailsRequest"/></param>
        /// <returns><see cref="DescribeFleetStatisticDetailsResponse"/></returns>
        public Task<DescribeFleetStatisticDetailsResponse> DescribeFleetStatisticDetails(DescribeFleetStatisticDetailsRequest req)
        {
            return InternalRequestAsync<DescribeFleetStatisticDetailsResponse>(req, "DescribeFleetStatisticDetails");
        }

        /// <summary>
        /// 此接口无法使用，游戏服务器引擎GSE已于6.1正式下架，感谢您的支持
        /// 
        /// 本接口（DescribeFleetStatisticDetails）用于查询服务部署统计详情。
        /// </summary>
        /// <param name="req"><see cref="DescribeFleetStatisticDetailsRequest"/></param>
        /// <returns><see cref="DescribeFleetStatisticDetailsResponse"/></returns>
        public DescribeFleetStatisticDetailsResponse DescribeFleetStatisticDetailsSync(DescribeFleetStatisticDetailsRequest req)
        {
            return InternalRequestAsync<DescribeFleetStatisticDetailsResponse>(req, "DescribeFleetStatisticDetails")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口无法使用，游戏服务器引擎GSE已于6.1正式下架，感谢您的支持
        /// 
        /// 本接口（DescribeFleetStatisticFlows）用于查询服务部署统计用量。
        /// </summary>
        /// <param name="req"><see cref="DescribeFleetStatisticFlowsRequest"/></param>
        /// <returns><see cref="DescribeFleetStatisticFlowsResponse"/></returns>
        public Task<DescribeFleetStatisticFlowsResponse> DescribeFleetStatisticFlows(DescribeFleetStatisticFlowsRequest req)
        {
            return InternalRequestAsync<DescribeFleetStatisticFlowsResponse>(req, "DescribeFleetStatisticFlows");
        }

        /// <summary>
        /// 此接口无法使用，游戏服务器引擎GSE已于6.1正式下架，感谢您的支持
        /// 
        /// 本接口（DescribeFleetStatisticFlows）用于查询服务部署统计用量。
        /// </summary>
        /// <param name="req"><see cref="DescribeFleetStatisticFlowsRequest"/></param>
        /// <returns><see cref="DescribeFleetStatisticFlowsResponse"/></returns>
        public DescribeFleetStatisticFlowsResponse DescribeFleetStatisticFlowsSync(DescribeFleetStatisticFlowsRequest req)
        {
            return InternalRequestAsync<DescribeFleetStatisticFlowsResponse>(req, "DescribeFleetStatisticFlows")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口无法使用，游戏服务器引擎GSE已于6.1正式下架，感谢您的支持
        /// 
        /// 本接口（DescribeFleetStatisticSummary）用于查询服务部署统计汇总信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeFleetStatisticSummaryRequest"/></param>
        /// <returns><see cref="DescribeFleetStatisticSummaryResponse"/></returns>
        public Task<DescribeFleetStatisticSummaryResponse> DescribeFleetStatisticSummary(DescribeFleetStatisticSummaryRequest req)
        {
            return InternalRequestAsync<DescribeFleetStatisticSummaryResponse>(req, "DescribeFleetStatisticSummary");
        }

        /// <summary>
        /// 此接口无法使用，游戏服务器引擎GSE已于6.1正式下架，感谢您的支持
        /// 
        /// 本接口（DescribeFleetStatisticSummary）用于查询服务部署统计汇总信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeFleetStatisticSummaryRequest"/></param>
        /// <returns><see cref="DescribeFleetStatisticSummaryResponse"/></returns>
        public DescribeFleetStatisticSummaryResponse DescribeFleetStatisticSummarySync(DescribeFleetStatisticSummaryRequest req)
        {
            return InternalRequestAsync<DescribeFleetStatisticSummaryResponse>(req, "DescribeFleetStatisticSummary")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口无法使用，游戏服务器引擎GSE已于6.1正式下架，感谢您的支持
        /// 
        /// 本接口（DescribeFleetUtilization）用于查询服务器舰队的利用率信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeFleetUtilizationRequest"/></param>
        /// <returns><see cref="DescribeFleetUtilizationResponse"/></returns>
        public Task<DescribeFleetUtilizationResponse> DescribeFleetUtilization(DescribeFleetUtilizationRequest req)
        {
            return InternalRequestAsync<DescribeFleetUtilizationResponse>(req, "DescribeFleetUtilization");
        }

        /// <summary>
        /// 此接口无法使用，游戏服务器引擎GSE已于6.1正式下架，感谢您的支持
        /// 
        /// 本接口（DescribeFleetUtilization）用于查询服务器舰队的利用率信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeFleetUtilizationRequest"/></param>
        /// <returns><see cref="DescribeFleetUtilizationResponse"/></returns>
        public DescribeFleetUtilizationResponse DescribeFleetUtilizationSync(DescribeFleetUtilizationRequest req)
        {
            return InternalRequestAsync<DescribeFleetUtilizationResponse>(req, "DescribeFleetUtilization")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口无法使用，游戏服务器引擎GSE已于6.1正式下架，感谢您的支持
        /// 
        /// 本接口（DescribeGameServerSessionDetails）用于查询游戏服务器会话详情列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeGameServerSessionDetailsRequest"/></param>
        /// <returns><see cref="DescribeGameServerSessionDetailsResponse"/></returns>
        public Task<DescribeGameServerSessionDetailsResponse> DescribeGameServerSessionDetails(DescribeGameServerSessionDetailsRequest req)
        {
            return InternalRequestAsync<DescribeGameServerSessionDetailsResponse>(req, "DescribeGameServerSessionDetails");
        }

        /// <summary>
        /// 此接口无法使用，游戏服务器引擎GSE已于6.1正式下架，感谢您的支持
        /// 
        /// 本接口（DescribeGameServerSessionDetails）用于查询游戏服务器会话详情列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeGameServerSessionDetailsRequest"/></param>
        /// <returns><see cref="DescribeGameServerSessionDetailsResponse"/></returns>
        public DescribeGameServerSessionDetailsResponse DescribeGameServerSessionDetailsSync(DescribeGameServerSessionDetailsRequest req)
        {
            return InternalRequestAsync<DescribeGameServerSessionDetailsResponse>(req, "DescribeGameServerSessionDetails")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口无法使用，游戏服务器引擎GSE已于6.1正式下架，感谢您的支持
        /// 
        /// 本接口（DescribeGameServerSessionPlacement）用于查询游戏服务器会话的放置。
        /// </summary>
        /// <param name="req"><see cref="DescribeGameServerSessionPlacementRequest"/></param>
        /// <returns><see cref="DescribeGameServerSessionPlacementResponse"/></returns>
        public Task<DescribeGameServerSessionPlacementResponse> DescribeGameServerSessionPlacement(DescribeGameServerSessionPlacementRequest req)
        {
            return InternalRequestAsync<DescribeGameServerSessionPlacementResponse>(req, "DescribeGameServerSessionPlacement");
        }

        /// <summary>
        /// 此接口无法使用，游戏服务器引擎GSE已于6.1正式下架，感谢您的支持
        /// 
        /// 本接口（DescribeGameServerSessionPlacement）用于查询游戏服务器会话的放置。
        /// </summary>
        /// <param name="req"><see cref="DescribeGameServerSessionPlacementRequest"/></param>
        /// <returns><see cref="DescribeGameServerSessionPlacementResponse"/></returns>
        public DescribeGameServerSessionPlacementResponse DescribeGameServerSessionPlacementSync(DescribeGameServerSessionPlacementRequest req)
        {
            return InternalRequestAsync<DescribeGameServerSessionPlacementResponse>(req, "DescribeGameServerSessionPlacement")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口无法使用，游戏服务器引擎GSE已于6.1正式下架，感谢您的支持
        /// 
        /// 本接口（DescribeGameServerSessionQueues）用于查询游戏服务器会话队列。
        /// </summary>
        /// <param name="req"><see cref="DescribeGameServerSessionQueuesRequest"/></param>
        /// <returns><see cref="DescribeGameServerSessionQueuesResponse"/></returns>
        public Task<DescribeGameServerSessionQueuesResponse> DescribeGameServerSessionQueues(DescribeGameServerSessionQueuesRequest req)
        {
            return InternalRequestAsync<DescribeGameServerSessionQueuesResponse>(req, "DescribeGameServerSessionQueues");
        }

        /// <summary>
        /// 此接口无法使用，游戏服务器引擎GSE已于6.1正式下架，感谢您的支持
        /// 
        /// 本接口（DescribeGameServerSessionQueues）用于查询游戏服务器会话队列。
        /// </summary>
        /// <param name="req"><see cref="DescribeGameServerSessionQueuesRequest"/></param>
        /// <returns><see cref="DescribeGameServerSessionQueuesResponse"/></returns>
        public DescribeGameServerSessionQueuesResponse DescribeGameServerSessionQueuesSync(DescribeGameServerSessionQueuesRequest req)
        {
            return InternalRequestAsync<DescribeGameServerSessionQueuesResponse>(req, "DescribeGameServerSessionQueues")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口无法使用，游戏服务器引擎GSE已于6.1正式下架，感谢您的支持
        /// 
        /// 本接口（DescribeGameServerSessions）用于查询游戏服务器会话列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeGameServerSessionsRequest"/></param>
        /// <returns><see cref="DescribeGameServerSessionsResponse"/></returns>
        public Task<DescribeGameServerSessionsResponse> DescribeGameServerSessions(DescribeGameServerSessionsRequest req)
        {
            return InternalRequestAsync<DescribeGameServerSessionsResponse>(req, "DescribeGameServerSessions");
        }

        /// <summary>
        /// 此接口无法使用，游戏服务器引擎GSE已于6.1正式下架，感谢您的支持
        /// 
        /// 本接口（DescribeGameServerSessions）用于查询游戏服务器会话列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeGameServerSessionsRequest"/></param>
        /// <returns><see cref="DescribeGameServerSessionsResponse"/></returns>
        public DescribeGameServerSessionsResponse DescribeGameServerSessionsSync(DescribeGameServerSessionsRequest req)
        {
            return InternalRequestAsync<DescribeGameServerSessionsResponse>(req, "DescribeGameServerSessions")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口无法使用，游戏服务器引擎GSE已于6.1正式下架，感谢您的支持
        /// 
        /// 本接口（DescribeInstanceLimit）用于查询用户实例数限额。
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceLimitRequest"/></param>
        /// <returns><see cref="DescribeInstanceLimitResponse"/></returns>
        public Task<DescribeInstanceLimitResponse> DescribeInstanceLimit(DescribeInstanceLimitRequest req)
        {
            return InternalRequestAsync<DescribeInstanceLimitResponse>(req, "DescribeInstanceLimit");
        }

        /// <summary>
        /// 此接口无法使用，游戏服务器引擎GSE已于6.1正式下架，感谢您的支持
        /// 
        /// 本接口（DescribeInstanceLimit）用于查询用户实例数限额。
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceLimitRequest"/></param>
        /// <returns><see cref="DescribeInstanceLimitResponse"/></returns>
        public DescribeInstanceLimitResponse DescribeInstanceLimitSync(DescribeInstanceLimitRequest req)
        {
            return InternalRequestAsync<DescribeInstanceLimitResponse>(req, "DescribeInstanceLimit")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口无法使用，游戏服务器引擎GSE已于6.1正式下架，感谢您的支持
        /// 
        /// 本接口（DescribeInstanceTypes）用于获取服务器实例类型列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceTypesRequest"/></param>
        /// <returns><see cref="DescribeInstanceTypesResponse"/></returns>
        public Task<DescribeInstanceTypesResponse> DescribeInstanceTypes(DescribeInstanceTypesRequest req)
        {
            return InternalRequestAsync<DescribeInstanceTypesResponse>(req, "DescribeInstanceTypes");
        }

        /// <summary>
        /// 此接口无法使用，游戏服务器引擎GSE已于6.1正式下架，感谢您的支持
        /// 
        /// 本接口（DescribeInstanceTypes）用于获取服务器实例类型列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceTypesRequest"/></param>
        /// <returns><see cref="DescribeInstanceTypesResponse"/></returns>
        public DescribeInstanceTypesResponse DescribeInstanceTypesSync(DescribeInstanceTypesRequest req)
        {
            return InternalRequestAsync<DescribeInstanceTypesResponse>(req, "DescribeInstanceTypes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口无法使用，游戏服务器引擎GSE已于6.1正式下架，感谢您的支持
        /// 
        /// 本接口（DescribeInstances）用于查询服务器实例列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesRequest"/></param>
        /// <returns><see cref="DescribeInstancesResponse"/></returns>
        public Task<DescribeInstancesResponse> DescribeInstances(DescribeInstancesRequest req)
        {
            return InternalRequestAsync<DescribeInstancesResponse>(req, "DescribeInstances");
        }

        /// <summary>
        /// 此接口无法使用，游戏服务器引擎GSE已于6.1正式下架，感谢您的支持
        /// 
        /// 本接口（DescribeInstances）用于查询服务器实例列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesRequest"/></param>
        /// <returns><see cref="DescribeInstancesResponse"/></returns>
        public DescribeInstancesResponse DescribeInstancesSync(DescribeInstancesRequest req)
        {
            return InternalRequestAsync<DescribeInstancesResponse>(req, "DescribeInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口无法使用，游戏服务器引擎GSE已于6.1正式下架，感谢您的支持
        /// 
        /// 本接口（DescribeInstancesExtend）用于查询实例扩展信息列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesExtendRequest"/></param>
        /// <returns><see cref="DescribeInstancesExtendResponse"/></returns>
        public Task<DescribeInstancesExtendResponse> DescribeInstancesExtend(DescribeInstancesExtendRequest req)
        {
            return InternalRequestAsync<DescribeInstancesExtendResponse>(req, "DescribeInstancesExtend");
        }

        /// <summary>
        /// 此接口无法使用，游戏服务器引擎GSE已于6.1正式下架，感谢您的支持
        /// 
        /// 本接口（DescribeInstancesExtend）用于查询实例扩展信息列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesExtendRequest"/></param>
        /// <returns><see cref="DescribeInstancesExtendResponse"/></returns>
        public DescribeInstancesExtendResponse DescribeInstancesExtendSync(DescribeInstancesExtendRequest req)
        {
            return InternalRequestAsync<DescribeInstancesExtendResponse>(req, "DescribeInstancesExtend")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口无法使用，游戏服务器引擎GSE已于6.1正式下架，感谢您的支持
        /// 
        /// 本接口（DescribePlayerSessions）用于获取玩家会话列表。
        /// </summary>
        /// <param name="req"><see cref="DescribePlayerSessionsRequest"/></param>
        /// <returns><see cref="DescribePlayerSessionsResponse"/></returns>
        public Task<DescribePlayerSessionsResponse> DescribePlayerSessions(DescribePlayerSessionsRequest req)
        {
            return InternalRequestAsync<DescribePlayerSessionsResponse>(req, "DescribePlayerSessions");
        }

        /// <summary>
        /// 此接口无法使用，游戏服务器引擎GSE已于6.1正式下架，感谢您的支持
        /// 
        /// 本接口（DescribePlayerSessions）用于获取玩家会话列表。
        /// </summary>
        /// <param name="req"><see cref="DescribePlayerSessionsRequest"/></param>
        /// <returns><see cref="DescribePlayerSessionsResponse"/></returns>
        public DescribePlayerSessionsResponse DescribePlayerSessionsSync(DescribePlayerSessionsRequest req)
        {
            return InternalRequestAsync<DescribePlayerSessionsResponse>(req, "DescribePlayerSessions")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口无法使用，游戏服务器引擎GSE已于6.1正式下架，感谢您的支持
        /// 
        /// 本接口（DescribeRuntimeConfiguration）用于获取服务器舰队运行配置。
        /// </summary>
        /// <param name="req"><see cref="DescribeRuntimeConfigurationRequest"/></param>
        /// <returns><see cref="DescribeRuntimeConfigurationResponse"/></returns>
        public Task<DescribeRuntimeConfigurationResponse> DescribeRuntimeConfiguration(DescribeRuntimeConfigurationRequest req)
        {
            return InternalRequestAsync<DescribeRuntimeConfigurationResponse>(req, "DescribeRuntimeConfiguration");
        }

        /// <summary>
        /// 此接口无法使用，游戏服务器引擎GSE已于6.1正式下架，感谢您的支持
        /// 
        /// 本接口（DescribeRuntimeConfiguration）用于获取服务器舰队运行配置。
        /// </summary>
        /// <param name="req"><see cref="DescribeRuntimeConfigurationRequest"/></param>
        /// <returns><see cref="DescribeRuntimeConfigurationResponse"/></returns>
        public DescribeRuntimeConfigurationResponse DescribeRuntimeConfigurationSync(DescribeRuntimeConfigurationRequest req)
        {
            return InternalRequestAsync<DescribeRuntimeConfigurationResponse>(req, "DescribeRuntimeConfiguration")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口无法使用，游戏服务器引擎GSE已于6.1正式下架，感谢您的支持
        /// 
        /// 本接口（DescribeScalingPolicies）用于查询服务器舰队的动态扩缩容策略列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeScalingPoliciesRequest"/></param>
        /// <returns><see cref="DescribeScalingPoliciesResponse"/></returns>
        public Task<DescribeScalingPoliciesResponse> DescribeScalingPolicies(DescribeScalingPoliciesRequest req)
        {
            return InternalRequestAsync<DescribeScalingPoliciesResponse>(req, "DescribeScalingPolicies");
        }

        /// <summary>
        /// 此接口无法使用，游戏服务器引擎GSE已于6.1正式下架，感谢您的支持
        /// 
        /// 本接口（DescribeScalingPolicies）用于查询服务器舰队的动态扩缩容策略列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeScalingPoliciesRequest"/></param>
        /// <returns><see cref="DescribeScalingPoliciesResponse"/></returns>
        public DescribeScalingPoliciesResponse DescribeScalingPoliciesSync(DescribeScalingPoliciesRequest req)
        {
            return InternalRequestAsync<DescribeScalingPoliciesResponse>(req, "DescribeScalingPolicies")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口无法使用，游戏服务器引擎GSE已于6.1正式下架，感谢您的支持
        /// 
        /// 本接口（DescribeTimerScalingPolicies）用于查询fleet下的定时器列表。可以通过fleetid，定时器名称分页查询。
        /// </summary>
        /// <param name="req"><see cref="DescribeTimerScalingPoliciesRequest"/></param>
        /// <returns><see cref="DescribeTimerScalingPoliciesResponse"/></returns>
        public Task<DescribeTimerScalingPoliciesResponse> DescribeTimerScalingPolicies(DescribeTimerScalingPoliciesRequest req)
        {
            return InternalRequestAsync<DescribeTimerScalingPoliciesResponse>(req, "DescribeTimerScalingPolicies");
        }

        /// <summary>
        /// 此接口无法使用，游戏服务器引擎GSE已于6.1正式下架，感谢您的支持
        /// 
        /// 本接口（DescribeTimerScalingPolicies）用于查询fleet下的定时器列表。可以通过fleetid，定时器名称分页查询。
        /// </summary>
        /// <param name="req"><see cref="DescribeTimerScalingPoliciesRequest"/></param>
        /// <returns><see cref="DescribeTimerScalingPoliciesResponse"/></returns>
        public DescribeTimerScalingPoliciesResponse DescribeTimerScalingPoliciesSync(DescribeTimerScalingPoliciesRequest req)
        {
            return InternalRequestAsync<DescribeTimerScalingPoliciesResponse>(req, "DescribeTimerScalingPolicies")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口无法使用，游戏服务器引擎GSE已于6.1正式下架，感谢您的支持
        /// 
        /// 本接口（DescribeUserQuota）获取用户单个模块配额。
        /// </summary>
        /// <param name="req"><see cref="DescribeUserQuotaRequest"/></param>
        /// <returns><see cref="DescribeUserQuotaResponse"/></returns>
        public Task<DescribeUserQuotaResponse> DescribeUserQuota(DescribeUserQuotaRequest req)
        {
            return InternalRequestAsync<DescribeUserQuotaResponse>(req, "DescribeUserQuota");
        }

        /// <summary>
        /// 此接口无法使用，游戏服务器引擎GSE已于6.1正式下架，感谢您的支持
        /// 
        /// 本接口（DescribeUserQuota）获取用户单个模块配额。
        /// </summary>
        /// <param name="req"><see cref="DescribeUserQuotaRequest"/></param>
        /// <returns><see cref="DescribeUserQuotaResponse"/></returns>
        public DescribeUserQuotaResponse DescribeUserQuotaSync(DescribeUserQuotaRequest req)
        {
            return InternalRequestAsync<DescribeUserQuotaResponse>(req, "DescribeUserQuota")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口无法使用，游戏服务器引擎GSE已于6.1正式下架，感谢您的支持
        /// 
        /// 本接口（DescribeUserQuotas）用于获取用户配额
        /// </summary>
        /// <param name="req"><see cref="DescribeUserQuotasRequest"/></param>
        /// <returns><see cref="DescribeUserQuotasResponse"/></returns>
        public Task<DescribeUserQuotasResponse> DescribeUserQuotas(DescribeUserQuotasRequest req)
        {
            return InternalRequestAsync<DescribeUserQuotasResponse>(req, "DescribeUserQuotas");
        }

        /// <summary>
        /// 此接口无法使用，游戏服务器引擎GSE已于6.1正式下架，感谢您的支持
        /// 
        /// 本接口（DescribeUserQuotas）用于获取用户配额
        /// </summary>
        /// <param name="req"><see cref="DescribeUserQuotasRequest"/></param>
        /// <returns><see cref="DescribeUserQuotasResponse"/></returns>
        public DescribeUserQuotasResponse DescribeUserQuotasSync(DescribeUserQuotasRequest req)
        {
            return InternalRequestAsync<DescribeUserQuotasResponse>(req, "DescribeUserQuotas")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口无法使用，游戏服务器引擎GSE已于6.1正式下架，感谢您的支持
        /// 
        /// 本接口（DetachCcnInstances）用于解关联云联网实例。
        /// </summary>
        /// <param name="req"><see cref="DetachCcnInstancesRequest"/></param>
        /// <returns><see cref="DetachCcnInstancesResponse"/></returns>
        public Task<DetachCcnInstancesResponse> DetachCcnInstances(DetachCcnInstancesRequest req)
        {
            return InternalRequestAsync<DetachCcnInstancesResponse>(req, "DetachCcnInstances");
        }

        /// <summary>
        /// 此接口无法使用，游戏服务器引擎GSE已于6.1正式下架，感谢您的支持
        /// 
        /// 本接口（DetachCcnInstances）用于解关联云联网实例。
        /// </summary>
        /// <param name="req"><see cref="DetachCcnInstancesRequest"/></param>
        /// <returns><see cref="DetachCcnInstancesResponse"/></returns>
        public DetachCcnInstancesResponse DetachCcnInstancesSync(DetachCcnInstancesRequest req)
        {
            return InternalRequestAsync<DetachCcnInstancesResponse>(req, "DetachCcnInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口无法使用，游戏服务器引擎GSE已于6.1正式下架，感谢您的支持
        /// 
        /// 本接口（EndGameServerSessionAndProcess）用于终止游戏服务器会话和对应的进程，适用于时限保护和不保护。
        /// </summary>
        /// <param name="req"><see cref="EndGameServerSessionAndProcessRequest"/></param>
        /// <returns><see cref="EndGameServerSessionAndProcessResponse"/></returns>
        public Task<EndGameServerSessionAndProcessResponse> EndGameServerSessionAndProcess(EndGameServerSessionAndProcessRequest req)
        {
            return InternalRequestAsync<EndGameServerSessionAndProcessResponse>(req, "EndGameServerSessionAndProcess");
        }

        /// <summary>
        /// 此接口无法使用，游戏服务器引擎GSE已于6.1正式下架，感谢您的支持
        /// 
        /// 本接口（EndGameServerSessionAndProcess）用于终止游戏服务器会话和对应的进程，适用于时限保护和不保护。
        /// </summary>
        /// <param name="req"><see cref="EndGameServerSessionAndProcessRequest"/></param>
        /// <returns><see cref="EndGameServerSessionAndProcessResponse"/></returns>
        public EndGameServerSessionAndProcessResponse EndGameServerSessionAndProcessSync(EndGameServerSessionAndProcessRequest req)
        {
            return InternalRequestAsync<EndGameServerSessionAndProcessResponse>(req, "EndGameServerSessionAndProcess")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口无法使用，游戏服务器引擎GSE已于6.1正式下架，感谢您的支持
        /// 
        /// 本接口用于获取游戏服务器实例的日志URL。
        /// </summary>
        /// <param name="req"><see cref="GetGameServerInstanceLogUrlRequest"/></param>
        /// <returns><see cref="GetGameServerInstanceLogUrlResponse"/></returns>
        public Task<GetGameServerInstanceLogUrlResponse> GetGameServerInstanceLogUrl(GetGameServerInstanceLogUrlRequest req)
        {
            return InternalRequestAsync<GetGameServerInstanceLogUrlResponse>(req, "GetGameServerInstanceLogUrl");
        }

        /// <summary>
        /// 此接口无法使用，游戏服务器引擎GSE已于6.1正式下架，感谢您的支持
        /// 
        /// 本接口用于获取游戏服务器实例的日志URL。
        /// </summary>
        /// <param name="req"><see cref="GetGameServerInstanceLogUrlRequest"/></param>
        /// <returns><see cref="GetGameServerInstanceLogUrlResponse"/></returns>
        public GetGameServerInstanceLogUrlResponse GetGameServerInstanceLogUrlSync(GetGameServerInstanceLogUrlRequest req)
        {
            return InternalRequestAsync<GetGameServerInstanceLogUrlResponse>(req, "GetGameServerInstanceLogUrl")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口无法使用，游戏服务器引擎GSE已于6.1正式下架，感谢您的支持
        /// 
        /// 本接口（GetGameServerSessionLogUrl）用于获取游戏服务器会话的日志URL。
        /// </summary>
        /// <param name="req"><see cref="GetGameServerSessionLogUrlRequest"/></param>
        /// <returns><see cref="GetGameServerSessionLogUrlResponse"/></returns>
        public Task<GetGameServerSessionLogUrlResponse> GetGameServerSessionLogUrl(GetGameServerSessionLogUrlRequest req)
        {
            return InternalRequestAsync<GetGameServerSessionLogUrlResponse>(req, "GetGameServerSessionLogUrl");
        }

        /// <summary>
        /// 此接口无法使用，游戏服务器引擎GSE已于6.1正式下架，感谢您的支持
        /// 
        /// 本接口（GetGameServerSessionLogUrl）用于获取游戏服务器会话的日志URL。
        /// </summary>
        /// <param name="req"><see cref="GetGameServerSessionLogUrlRequest"/></param>
        /// <returns><see cref="GetGameServerSessionLogUrlResponse"/></returns>
        public GetGameServerSessionLogUrlResponse GetGameServerSessionLogUrlSync(GetGameServerSessionLogUrlRequest req)
        {
            return InternalRequestAsync<GetGameServerSessionLogUrlResponse>(req, "GetGameServerSessionLogUrl")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口无法使用，游戏服务器引擎GSE已于6.1正式下架，感谢您的支持
        /// 
        /// 本接口（GetInstanceAccess）用于获取实例登录所需要的凭据。
        /// </summary>
        /// <param name="req"><see cref="GetInstanceAccessRequest"/></param>
        /// <returns><see cref="GetInstanceAccessResponse"/></returns>
        public Task<GetInstanceAccessResponse> GetInstanceAccess(GetInstanceAccessRequest req)
        {
            return InternalRequestAsync<GetInstanceAccessResponse>(req, "GetInstanceAccess");
        }

        /// <summary>
        /// 此接口无法使用，游戏服务器引擎GSE已于6.1正式下架，感谢您的支持
        /// 
        /// 本接口（GetInstanceAccess）用于获取实例登录所需要的凭据。
        /// </summary>
        /// <param name="req"><see cref="GetInstanceAccessRequest"/></param>
        /// <returns><see cref="GetInstanceAccessResponse"/></returns>
        public GetInstanceAccessResponse GetInstanceAccessSync(GetInstanceAccessRequest req)
        {
            return InternalRequestAsync<GetInstanceAccessResponse>(req, "GetInstanceAccess")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口无法使用，游戏服务器引擎GSE已于6.1正式下架，感谢您的支持
        /// 
        /// 本接口（GetUploadCredentials）获取上传文件授权信息。
        /// 通过 [GetUploadCredentials](https://cloud.tencent.com/document/product/1165/48727) 接口获取临时授权信息后，调用 COS API将数据上传，根据上传的 BucketKey 信息进行生成包 [CreateAsset](https://cloud.tencent.com/document/product/1165/48731) 的创建。参考下面的示例部分。
        /// </summary>
        /// <param name="req"><see cref="GetUploadCredentialsRequest"/></param>
        /// <returns><see cref="GetUploadCredentialsResponse"/></returns>
        public Task<GetUploadCredentialsResponse> GetUploadCredentials(GetUploadCredentialsRequest req)
        {
            return InternalRequestAsync<GetUploadCredentialsResponse>(req, "GetUploadCredentials");
        }

        /// <summary>
        /// 此接口无法使用，游戏服务器引擎GSE已于6.1正式下架，感谢您的支持
        /// 
        /// 本接口（GetUploadCredentials）获取上传文件授权信息。
        /// 通过 [GetUploadCredentials](https://cloud.tencent.com/document/product/1165/48727) 接口获取临时授权信息后，调用 COS API将数据上传，根据上传的 BucketKey 信息进行生成包 [CreateAsset](https://cloud.tencent.com/document/product/1165/48731) 的创建。参考下面的示例部分。
        /// </summary>
        /// <param name="req"><see cref="GetUploadCredentialsRequest"/></param>
        /// <returns><see cref="GetUploadCredentialsResponse"/></returns>
        public GetUploadCredentialsResponse GetUploadCredentialsSync(GetUploadCredentialsRequest req)
        {
            return InternalRequestAsync<GetUploadCredentialsResponse>(req, "GetUploadCredentials")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口无法使用，游戏服务器引擎GSE已于6.1正式下架，感谢您的支持
        /// 
        /// 本接口（GetUploadFederationToken）用于 获取生成包上传所需要的临时密钥。
        /// </summary>
        /// <param name="req"><see cref="GetUploadFederationTokenRequest"/></param>
        /// <returns><see cref="GetUploadFederationTokenResponse"/></returns>
        public Task<GetUploadFederationTokenResponse> GetUploadFederationToken(GetUploadFederationTokenRequest req)
        {
            return InternalRequestAsync<GetUploadFederationTokenResponse>(req, "GetUploadFederationToken");
        }

        /// <summary>
        /// 此接口无法使用，游戏服务器引擎GSE已于6.1正式下架，感谢您的支持
        /// 
        /// 本接口（GetUploadFederationToken）用于 获取生成包上传所需要的临时密钥。
        /// </summary>
        /// <param name="req"><see cref="GetUploadFederationTokenRequest"/></param>
        /// <returns><see cref="GetUploadFederationTokenResponse"/></returns>
        public GetUploadFederationTokenResponse GetUploadFederationTokenSync(GetUploadFederationTokenRequest req)
        {
            return InternalRequestAsync<GetUploadFederationTokenResponse>(req, "GetUploadFederationToken")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口无法使用，游戏服务器引擎GSE已于6.1正式下架，感谢您的支持
        /// 
        /// 本接口（JoinGameServerSession）用于加入游戏服务器会话。
        /// </summary>
        /// <param name="req"><see cref="JoinGameServerSessionRequest"/></param>
        /// <returns><see cref="JoinGameServerSessionResponse"/></returns>
        public Task<JoinGameServerSessionResponse> JoinGameServerSession(JoinGameServerSessionRequest req)
        {
            return InternalRequestAsync<JoinGameServerSessionResponse>(req, "JoinGameServerSession");
        }

        /// <summary>
        /// 此接口无法使用，游戏服务器引擎GSE已于6.1正式下架，感谢您的支持
        /// 
        /// 本接口（JoinGameServerSession）用于加入游戏服务器会话。
        /// </summary>
        /// <param name="req"><see cref="JoinGameServerSessionRequest"/></param>
        /// <returns><see cref="JoinGameServerSessionResponse"/></returns>
        public JoinGameServerSessionResponse JoinGameServerSessionSync(JoinGameServerSessionRequest req)
        {
            return InternalRequestAsync<JoinGameServerSessionResponse>(req, "JoinGameServerSession")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口无法使用，游戏服务器引擎GSE已于6.1正式下架，感谢您的支持
        /// 
        /// 本接口（JoinGameServerSessionBatch）用于批量加入游戏服务器会话。
        /// </summary>
        /// <param name="req"><see cref="JoinGameServerSessionBatchRequest"/></param>
        /// <returns><see cref="JoinGameServerSessionBatchResponse"/></returns>
        public Task<JoinGameServerSessionBatchResponse> JoinGameServerSessionBatch(JoinGameServerSessionBatchRequest req)
        {
            return InternalRequestAsync<JoinGameServerSessionBatchResponse>(req, "JoinGameServerSessionBatch");
        }

        /// <summary>
        /// 此接口无法使用，游戏服务器引擎GSE已于6.1正式下架，感谢您的支持
        /// 
        /// 本接口（JoinGameServerSessionBatch）用于批量加入游戏服务器会话。
        /// </summary>
        /// <param name="req"><see cref="JoinGameServerSessionBatchRequest"/></param>
        /// <returns><see cref="JoinGameServerSessionBatchResponse"/></returns>
        public JoinGameServerSessionBatchResponse JoinGameServerSessionBatchSync(JoinGameServerSessionBatchRequest req)
        {
            return InternalRequestAsync<JoinGameServerSessionBatchResponse>(req, "JoinGameServerSessionBatch")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口无法使用，游戏服务器引擎GSE已于6.1正式下架，感谢您的支持
        /// 
        /// 本接口（ListAliases）用于检索帐户下的所有别名。
        /// </summary>
        /// <param name="req"><see cref="ListAliasesRequest"/></param>
        /// <returns><see cref="ListAliasesResponse"/></returns>
        public Task<ListAliasesResponse> ListAliases(ListAliasesRequest req)
        {
            return InternalRequestAsync<ListAliasesResponse>(req, "ListAliases");
        }

        /// <summary>
        /// 此接口无法使用，游戏服务器引擎GSE已于6.1正式下架，感谢您的支持
        /// 
        /// 本接口（ListAliases）用于检索帐户下的所有别名。
        /// </summary>
        /// <param name="req"><see cref="ListAliasesRequest"/></param>
        /// <returns><see cref="ListAliasesResponse"/></returns>
        public ListAliasesResponse ListAliasesSync(ListAliasesRequest req)
        {
            return InternalRequestAsync<ListAliasesResponse>(req, "ListAliases")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口无法使用，游戏服务器引擎GSE已于6.1正式下架，感谢您的支持
        /// 
        /// 本接口（ListFleets）用于获取服务器舰队列表。
        /// </summary>
        /// <param name="req"><see cref="ListFleetsRequest"/></param>
        /// <returns><see cref="ListFleetsResponse"/></returns>
        public Task<ListFleetsResponse> ListFleets(ListFleetsRequest req)
        {
            return InternalRequestAsync<ListFleetsResponse>(req, "ListFleets");
        }

        /// <summary>
        /// 此接口无法使用，游戏服务器引擎GSE已于6.1正式下架，感谢您的支持
        /// 
        /// 本接口（ListFleets）用于获取服务器舰队列表。
        /// </summary>
        /// <param name="req"><see cref="ListFleetsRequest"/></param>
        /// <returns><see cref="ListFleetsResponse"/></returns>
        public ListFleetsResponse ListFleetsSync(ListFleetsRequest req)
        {
            return InternalRequestAsync<ListFleetsResponse>(req, "ListFleets")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口无法使用，游戏服务器引擎GSE已于6.1正式下架，感谢您的支持
        /// 
        /// 本接口（PutScalingPolicy）用于设置服务器舰队的动态扩缩容策略。
        /// 
        /// 通过此接口可以增加或者更新服务器舰队的扩缩容策略。
        /// 服务器舰队可以有多个扩缩容策略，但是只有一个TargetBased基于目标的策略。
        /// 
        /// ## TargetBased基于目标的策略
        /// 
        /// TargetBased策略计算的指标是PercentAvailableGameSessions，这个策略用于计算当前服务器舰队应该有多少个CVM实例来支撑和分配游戏会话。
        /// PercentAvailableGameSessions表示服务器舰队的缓冲值；用来计算服务器舰队在当前容量下可以处理的额外玩家会话数量。
        /// 如果使用基于目标的策略，可以按照业务需求设置一个期望的缓冲区大小，GSE的会按照配置的策略来扩容和缩容到这个目标要求的CVM实例数。
        /// 
        /// 例如：客户可以设置同时承载100个游戏会话的服务器舰队预留10%的缓冲区。GSE会按照这个策略执行时，若服务器舰队的可用容量低于或高于10%的游戏服务器会话时，执行扩缩容动作。
        /// GSE按照策略期望，扩容新CVM实例或缩容未使用的实例，保持在10%左右的缓冲区。
        /// 
        /// #### 请求参数取值说明
        /// 
        /// ```
        /// Name取值策略名称，
        /// FleetId取值为选择的服务器舰队ID，
        /// PolicyType取值TargetBased，
        /// MetricName取值PercentAvailableGameSessions，
        /// TargetConfiguration取值为所需的缓冲区值对象，
        /// 其他参数不用传递。
        /// 请求成功时，将返回策略名称。扩缩容策略在成功创建立即自动生效。
        /// ```
        /// 
        /// 
        /// 
        /// ## RuleBased基于规则的策略
        /// 
        /// ####  请求参数取值说明
        /// 
        /// ```
        /// Name取值策略名称，
        /// FleetId取值为选择的服务器舰队ID，
        /// PolicyType取值RuleBased，
        /// MetricName取值（AvailableGameServerSessions，AvailableCustomCount，PercentAvailableCustomCount，ActiveInstances，IdleInstances，CurrentPlayerSessions和PercentIdleInstances）说明见备注1，
        /// 其他参数不用传递。
        /// ComparisonOperator取值为 >,>=,<,<=这4个比较符号中的一个，
        /// Threshold取值为指标MetricName达到的阈值是多少，
        /// EvaluationPeriods取值为指标MetricName达到的阈值持续了多少时间，单位是分钟，
        /// ScalingAdjustmentType取值（ChangeInCapacity，ExactCapacity，PercentChangeInCapacity）说明见备注2
        /// ScalingAdjustment取值为指标MetricName达到的阈值的条件后，扩缩容多少个CVM实例。
        /// 请求成功时，将返回策略名称。扩缩容策略在成功创建立即自动生效。
        /// ```
        /// 
        /// 规则执行的条件表达式如下所示：
        /// 
        /// ```
        /// 若 [MetricName] 是 [ComparisonOperator] [Threshold] 持续 [EvaluationPeriods] 分钟, 则 [ScalingAdjustmentType] 调整 [ScalingAdjustment]个实例。
        /// ```
        /// ```
        /// if [MetricName] ComparisonOperator [Threshold] for [EvaluationPeriods] minutes, then scaling up by/to  [ScalingAdjustment]
        /// ```
        /// 例如1：如果当前AvailableCustomCount值大于等于10，持续5分钟，扩容1台CVM实例。
        /// ```
        /// ScalingAdjustmentType = ChangeInCapacity
        /// if [AvailableGameServerSessions] >= [10] for [5] minutes, then scaling up [1]
        /// ```
        /// 例如2：如果当前AvailableGameServerSessions值大于等于200，持续5分钟，扩容到2台CVM实例。
        /// ```
        /// ScalingAdjustmentType = ExactCapacity
        /// if [AvailableGameServerSessions] >= [200] for [5] minutes, then scaling to [2]
        /// ```
        /// 例如3：如果当前AvailableCustomCount值大于等于400，持续5分钟，扩容20%台CVM实例。
        /// 当前CVM实例数为10台。扩容20%台CVM实例就是增加 10*20%等于2台
        /// ```
        /// ScalingAdjustmentType = PercentChangeInCapacity
        /// if [AvailableGameServerSessions] >= [400] for [5] minutes, then scaling by [currentCVMCount * 20 %]
        /// ```
        /// **备注1**
        /// 
        /// - | 策略名称（MetricName）                                       | 计算公式                                   | 场景                                        | 场景使用举例                                                 |
        ///   | :----------------------------------------------------------- | :----------------------------------------- | :------------------------------------------ | :----------------------------------------------------------- |
        ///   | CurrentPlayerSessions<br>当前玩家数指标                      | = 当前在线的玩家数                         | CVM随着玩家会话数变化做扩缩容。             | 例如：<br>MetricName: CurrentPlayerSessions<br>ComparisonOperator: '<=' <br>Threshold: 300<br/>EvaluationPeriods: 1<br/>ScalingAdjustment: 2<br/>ScalingAdjustment: ChangeInCapacity<br>说明：若当前CurrentPlayerSessions小于等于300，持续1分钟，则扩容2台CVM。 |
        ///   | AvailableGameServerSessions<br>可用游戏服务器会话数          | = 可用游戏服务会话数                       | CVM随着可用游戏会话数变化做扩缩容。         | 例如：<br/>MetricName: AvailableGameServerSessions<br/>ComparisonOperator: '<' <br/>Threshold: 50<br/>EvaluationPeriods: 5<br/>ScalingAdjustment: 2<br/>ScalingAdjustment: ExactCapacity<br/>说明：若当前AvailableGameServerSessions小于50，持续5分钟，则扩容到2台CVM。 |
        ///   | PercentAvailableGameServerSessions<br>可用游戏服务器会话百分比 | = 空闲游戏会话数 / 所有的游戏会话数 * 100% | CVM随着可用游戏会话数百分比变化做扩缩容。   | 例如：<br/>MetricName: PercentAvailableGameServerSessions<br/>ComparisonOperator: '<' <br/>Threshold: 50<br/>EvaluationPeriods: 1<br/>ScalingAdjustment: -30<br/>ScalingAdjustment: PercentChangeInCapacity<br/>说明：若当前PercentAvailableGameServerSessions小于50%，持续1分钟，则缩容当前实例数30%台CVM。 |
        ///   | AvailableCustomCount<br>可用客户自定义数指标                 | = 客户自定义的数                           | CVM随着可用客户自定义数变化做扩缩容。       | 例如：<br/>MetricName: AvailableCustomCount<br/>ComparisonOperator: '>=' <br/>Threshold: 6<br/>EvaluationPeriods: 3<br/>ScalingAdjustment: -1<br/>ScalingAdjustment: ExactCapacity<br/>说明：若当前AvailableCustomCount大于等于6，持续3分钟，则缩容到1台CVM。 |
        ///   | PercentAvailableCustomCount<br>可用客户自定义数百分比        | = 客户自定义数 / 客户最大自定义数* 100%    | CVM随着可用客户自定义数百分比变化做扩缩容。 | 例如：<br/>MetricName: PercentAvailableCustomCount<br/>ComparisonOperator: '<' <br/>Threshold: 15<br/>EvaluationPeriods: 3<br/>ScalingAdjustment: 1<br/>ScalingAdjustment: ChangeInCapacity<br/>说明：若当前PercentAvailableCustomCount小于15%，持续3分钟，则扩容1台CVM。 |
        ///   | ActiveInstances<br>活跃实例数指标                            | = 总实例数 - 缩容中的实例数                | CVM随着活跃实例数变化做扩缩容。             | 例如：<br/>MetricName: ActiveInstances<br/>ComparisonOperator: '<' <br/>Threshold: 3<br/>EvaluationPeriods: 1<br/>ScalingAdjustment: 3<br/>ScalingAdjustment: ExactCapacity<br/>说明：若当前ActiveInstances小于3台，持续1分钟，则扩容保留到3台CVM。 |
        ///   | IdleInstances<br>空闲实例数指标                              | = 未使用的进程数 / 每实例进程数            | CVM随着空闲实例数变化做扩缩容。             | 例如：<br/>MetricName: IdleInstances<br/>ComparisonOperator: '<' <br/>Threshold: 2<br/>EvaluationPeriods: 3<br/>ScalingAdjustment: 1<br/>ScalingAdjustment: ChangeInCapacity<br/>说明：若当前IdleInstances小于2台，持续3分钟，则扩容1台CVM。 |
        ///   | PercentIdleInstances<br>空闲实例百分比                       | = IdleInstances / ActiveInstances * 100%   | CVM随着空闲实例百分比变化做扩缩容。         | 例如：<br/>MetricName: PercentIdleInstances<br/>ComparisonOperator: '<' <br/>Threshold: 50<br/>EvaluationPeriods: 3<br/>ScalingAdjustment: 1<br/>ScalingAdjustment: ChangeInCapacity<br/>说明：若当前PercentIdleInstances小于50%，持续3分钟，则扩容1台CVM。 |
        /// 
        /// 
        /// 
        /// **备注2**
        /// 
        /// **ChangeInCapacity**
        /// 
        ///     当前CVM实例个数的扩容或缩容的调整值。正值按值扩容，负值按值缩容。
        /// 
        /// **ExactCapacity**
        /// 
        ///     把当前CVM实例个数调整为ScalingAdjustment设置的CVM实例数。
        /// 
        /// **PercentChangeInCapacity**
        /// 
        ///     按比例增加或减少的百分比。正值按比例扩容，负值按比例缩容；例如，值“-10”将按10%的比例缩容CVM实例。
        /// </summary>
        /// <param name="req"><see cref="PutScalingPolicyRequest"/></param>
        /// <returns><see cref="PutScalingPolicyResponse"/></returns>
        public Task<PutScalingPolicyResponse> PutScalingPolicy(PutScalingPolicyRequest req)
        {
            return InternalRequestAsync<PutScalingPolicyResponse>(req, "PutScalingPolicy");
        }

        /// <summary>
        /// 此接口无法使用，游戏服务器引擎GSE已于6.1正式下架，感谢您的支持
        /// 
        /// 本接口（PutScalingPolicy）用于设置服务器舰队的动态扩缩容策略。
        /// 
        /// 通过此接口可以增加或者更新服务器舰队的扩缩容策略。
        /// 服务器舰队可以有多个扩缩容策略，但是只有一个TargetBased基于目标的策略。
        /// 
        /// ## TargetBased基于目标的策略
        /// 
        /// TargetBased策略计算的指标是PercentAvailableGameSessions，这个策略用于计算当前服务器舰队应该有多少个CVM实例来支撑和分配游戏会话。
        /// PercentAvailableGameSessions表示服务器舰队的缓冲值；用来计算服务器舰队在当前容量下可以处理的额外玩家会话数量。
        /// 如果使用基于目标的策略，可以按照业务需求设置一个期望的缓冲区大小，GSE的会按照配置的策略来扩容和缩容到这个目标要求的CVM实例数。
        /// 
        /// 例如：客户可以设置同时承载100个游戏会话的服务器舰队预留10%的缓冲区。GSE会按照这个策略执行时，若服务器舰队的可用容量低于或高于10%的游戏服务器会话时，执行扩缩容动作。
        /// GSE按照策略期望，扩容新CVM实例或缩容未使用的实例，保持在10%左右的缓冲区。
        /// 
        /// #### 请求参数取值说明
        /// 
        /// ```
        /// Name取值策略名称，
        /// FleetId取值为选择的服务器舰队ID，
        /// PolicyType取值TargetBased，
        /// MetricName取值PercentAvailableGameSessions，
        /// TargetConfiguration取值为所需的缓冲区值对象，
        /// 其他参数不用传递。
        /// 请求成功时，将返回策略名称。扩缩容策略在成功创建立即自动生效。
        /// ```
        /// 
        /// 
        /// 
        /// ## RuleBased基于规则的策略
        /// 
        /// ####  请求参数取值说明
        /// 
        /// ```
        /// Name取值策略名称，
        /// FleetId取值为选择的服务器舰队ID，
        /// PolicyType取值RuleBased，
        /// MetricName取值（AvailableGameServerSessions，AvailableCustomCount，PercentAvailableCustomCount，ActiveInstances，IdleInstances，CurrentPlayerSessions和PercentIdleInstances）说明见备注1，
        /// 其他参数不用传递。
        /// ComparisonOperator取值为 >,>=,<,<=这4个比较符号中的一个，
        /// Threshold取值为指标MetricName达到的阈值是多少，
        /// EvaluationPeriods取值为指标MetricName达到的阈值持续了多少时间，单位是分钟，
        /// ScalingAdjustmentType取值（ChangeInCapacity，ExactCapacity，PercentChangeInCapacity）说明见备注2
        /// ScalingAdjustment取值为指标MetricName达到的阈值的条件后，扩缩容多少个CVM实例。
        /// 请求成功时，将返回策略名称。扩缩容策略在成功创建立即自动生效。
        /// ```
        /// 
        /// 规则执行的条件表达式如下所示：
        /// 
        /// ```
        /// 若 [MetricName] 是 [ComparisonOperator] [Threshold] 持续 [EvaluationPeriods] 分钟, 则 [ScalingAdjustmentType] 调整 [ScalingAdjustment]个实例。
        /// ```
        /// ```
        /// if [MetricName] ComparisonOperator [Threshold] for [EvaluationPeriods] minutes, then scaling up by/to  [ScalingAdjustment]
        /// ```
        /// 例如1：如果当前AvailableCustomCount值大于等于10，持续5分钟，扩容1台CVM实例。
        /// ```
        /// ScalingAdjustmentType = ChangeInCapacity
        /// if [AvailableGameServerSessions] >= [10] for [5] minutes, then scaling up [1]
        /// ```
        /// 例如2：如果当前AvailableGameServerSessions值大于等于200，持续5分钟，扩容到2台CVM实例。
        /// ```
        /// ScalingAdjustmentType = ExactCapacity
        /// if [AvailableGameServerSessions] >= [200] for [5] minutes, then scaling to [2]
        /// ```
        /// 例如3：如果当前AvailableCustomCount值大于等于400，持续5分钟，扩容20%台CVM实例。
        /// 当前CVM实例数为10台。扩容20%台CVM实例就是增加 10*20%等于2台
        /// ```
        /// ScalingAdjustmentType = PercentChangeInCapacity
        /// if [AvailableGameServerSessions] >= [400] for [5] minutes, then scaling by [currentCVMCount * 20 %]
        /// ```
        /// **备注1**
        /// 
        /// - | 策略名称（MetricName）                                       | 计算公式                                   | 场景                                        | 场景使用举例                                                 |
        ///   | :----------------------------------------------------------- | :----------------------------------------- | :------------------------------------------ | :----------------------------------------------------------- |
        ///   | CurrentPlayerSessions<br>当前玩家数指标                      | = 当前在线的玩家数                         | CVM随着玩家会话数变化做扩缩容。             | 例如：<br>MetricName: CurrentPlayerSessions<br>ComparisonOperator: '<=' <br>Threshold: 300<br/>EvaluationPeriods: 1<br/>ScalingAdjustment: 2<br/>ScalingAdjustment: ChangeInCapacity<br>说明：若当前CurrentPlayerSessions小于等于300，持续1分钟，则扩容2台CVM。 |
        ///   | AvailableGameServerSessions<br>可用游戏服务器会话数          | = 可用游戏服务会话数                       | CVM随着可用游戏会话数变化做扩缩容。         | 例如：<br/>MetricName: AvailableGameServerSessions<br/>ComparisonOperator: '<' <br/>Threshold: 50<br/>EvaluationPeriods: 5<br/>ScalingAdjustment: 2<br/>ScalingAdjustment: ExactCapacity<br/>说明：若当前AvailableGameServerSessions小于50，持续5分钟，则扩容到2台CVM。 |
        ///   | PercentAvailableGameServerSessions<br>可用游戏服务器会话百分比 | = 空闲游戏会话数 / 所有的游戏会话数 * 100% | CVM随着可用游戏会话数百分比变化做扩缩容。   | 例如：<br/>MetricName: PercentAvailableGameServerSessions<br/>ComparisonOperator: '<' <br/>Threshold: 50<br/>EvaluationPeriods: 1<br/>ScalingAdjustment: -30<br/>ScalingAdjustment: PercentChangeInCapacity<br/>说明：若当前PercentAvailableGameServerSessions小于50%，持续1分钟，则缩容当前实例数30%台CVM。 |
        ///   | AvailableCustomCount<br>可用客户自定义数指标                 | = 客户自定义的数                           | CVM随着可用客户自定义数变化做扩缩容。       | 例如：<br/>MetricName: AvailableCustomCount<br/>ComparisonOperator: '>=' <br/>Threshold: 6<br/>EvaluationPeriods: 3<br/>ScalingAdjustment: -1<br/>ScalingAdjustment: ExactCapacity<br/>说明：若当前AvailableCustomCount大于等于6，持续3分钟，则缩容到1台CVM。 |
        ///   | PercentAvailableCustomCount<br>可用客户自定义数百分比        | = 客户自定义数 / 客户最大自定义数* 100%    | CVM随着可用客户自定义数百分比变化做扩缩容。 | 例如：<br/>MetricName: PercentAvailableCustomCount<br/>ComparisonOperator: '<' <br/>Threshold: 15<br/>EvaluationPeriods: 3<br/>ScalingAdjustment: 1<br/>ScalingAdjustment: ChangeInCapacity<br/>说明：若当前PercentAvailableCustomCount小于15%，持续3分钟，则扩容1台CVM。 |
        ///   | ActiveInstances<br>活跃实例数指标                            | = 总实例数 - 缩容中的实例数                | CVM随着活跃实例数变化做扩缩容。             | 例如：<br/>MetricName: ActiveInstances<br/>ComparisonOperator: '<' <br/>Threshold: 3<br/>EvaluationPeriods: 1<br/>ScalingAdjustment: 3<br/>ScalingAdjustment: ExactCapacity<br/>说明：若当前ActiveInstances小于3台，持续1分钟，则扩容保留到3台CVM。 |
        ///   | IdleInstances<br>空闲实例数指标                              | = 未使用的进程数 / 每实例进程数            | CVM随着空闲实例数变化做扩缩容。             | 例如：<br/>MetricName: IdleInstances<br/>ComparisonOperator: '<' <br/>Threshold: 2<br/>EvaluationPeriods: 3<br/>ScalingAdjustment: 1<br/>ScalingAdjustment: ChangeInCapacity<br/>说明：若当前IdleInstances小于2台，持续3分钟，则扩容1台CVM。 |
        ///   | PercentIdleInstances<br>空闲实例百分比                       | = IdleInstances / ActiveInstances * 100%   | CVM随着空闲实例百分比变化做扩缩容。         | 例如：<br/>MetricName: PercentIdleInstances<br/>ComparisonOperator: '<' <br/>Threshold: 50<br/>EvaluationPeriods: 3<br/>ScalingAdjustment: 1<br/>ScalingAdjustment: ChangeInCapacity<br/>说明：若当前PercentIdleInstances小于50%，持续3分钟，则扩容1台CVM。 |
        /// 
        /// 
        /// 
        /// **备注2**
        /// 
        /// **ChangeInCapacity**
        /// 
        ///     当前CVM实例个数的扩容或缩容的调整值。正值按值扩容，负值按值缩容。
        /// 
        /// **ExactCapacity**
        /// 
        ///     把当前CVM实例个数调整为ScalingAdjustment设置的CVM实例数。
        /// 
        /// **PercentChangeInCapacity**
        /// 
        ///     按比例增加或减少的百分比。正值按比例扩容，负值按比例缩容；例如，值“-10”将按10%的比例缩容CVM实例。
        /// </summary>
        /// <param name="req"><see cref="PutScalingPolicyRequest"/></param>
        /// <returns><see cref="PutScalingPolicyResponse"/></returns>
        public PutScalingPolicyResponse PutScalingPolicySync(PutScalingPolicyRequest req)
        {
            return InternalRequestAsync<PutScalingPolicyResponse>(req, "PutScalingPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口无法使用，游戏服务器引擎GSE已于6.1正式下架，感谢您的支持
        /// 
        /// 本接口（PutTimerScalingPolicy）用于给fleet创建或更新定时器。
        /// 
        /// 填写字段timer_id，表示更新；不填字段timer_id表示新增。
        /// </summary>
        /// <param name="req"><see cref="PutTimerScalingPolicyRequest"/></param>
        /// <returns><see cref="PutTimerScalingPolicyResponse"/></returns>
        public Task<PutTimerScalingPolicyResponse> PutTimerScalingPolicy(PutTimerScalingPolicyRequest req)
        {
            return InternalRequestAsync<PutTimerScalingPolicyResponse>(req, "PutTimerScalingPolicy");
        }

        /// <summary>
        /// 此接口无法使用，游戏服务器引擎GSE已于6.1正式下架，感谢您的支持
        /// 
        /// 本接口（PutTimerScalingPolicy）用于给fleet创建或更新定时器。
        /// 
        /// 填写字段timer_id，表示更新；不填字段timer_id表示新增。
        /// </summary>
        /// <param name="req"><see cref="PutTimerScalingPolicyRequest"/></param>
        /// <returns><see cref="PutTimerScalingPolicyResponse"/></returns>
        public PutTimerScalingPolicyResponse PutTimerScalingPolicySync(PutTimerScalingPolicyRequest req)
        {
            return InternalRequestAsync<PutTimerScalingPolicyResponse>(req, "PutTimerScalingPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口无法使用，游戏服务器引擎GSE已于6.1正式下架，感谢您的支持
        /// 
        /// 本接口（ResolveAlias）用于获取别名当前指向的fleetId。
        /// </summary>
        /// <param name="req"><see cref="ResolveAliasRequest"/></param>
        /// <returns><see cref="ResolveAliasResponse"/></returns>
        public Task<ResolveAliasResponse> ResolveAlias(ResolveAliasRequest req)
        {
            return InternalRequestAsync<ResolveAliasResponse>(req, "ResolveAlias");
        }

        /// <summary>
        /// 此接口无法使用，游戏服务器引擎GSE已于6.1正式下架，感谢您的支持
        /// 
        /// 本接口（ResolveAlias）用于获取别名当前指向的fleetId。
        /// </summary>
        /// <param name="req"><see cref="ResolveAliasRequest"/></param>
        /// <returns><see cref="ResolveAliasResponse"/></returns>
        public ResolveAliasResponse ResolveAliasSync(ResolveAliasRequest req)
        {
            return InternalRequestAsync<ResolveAliasResponse>(req, "ResolveAlias")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口无法使用，游戏服务器引擎GSE已于6.1正式下架，感谢您的支持
        /// 
        /// 本接口（SearchGameServerSessions）用于搜索游戏服务器会话列表。
        /// </summary>
        /// <param name="req"><see cref="SearchGameServerSessionsRequest"/></param>
        /// <returns><see cref="SearchGameServerSessionsResponse"/></returns>
        public Task<SearchGameServerSessionsResponse> SearchGameServerSessions(SearchGameServerSessionsRequest req)
        {
            return InternalRequestAsync<SearchGameServerSessionsResponse>(req, "SearchGameServerSessions");
        }

        /// <summary>
        /// 此接口无法使用，游戏服务器引擎GSE已于6.1正式下架，感谢您的支持
        /// 
        /// 本接口（SearchGameServerSessions）用于搜索游戏服务器会话列表。
        /// </summary>
        /// <param name="req"><see cref="SearchGameServerSessionsRequest"/></param>
        /// <returns><see cref="SearchGameServerSessionsResponse"/></returns>
        public SearchGameServerSessionsResponse SearchGameServerSessionsSync(SearchGameServerSessionsRequest req)
        {
            return InternalRequestAsync<SearchGameServerSessionsResponse>(req, "SearchGameServerSessions")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口无法使用，游戏服务器引擎GSE已于6.1正式下架，感谢您的支持
        /// 
        /// 本接口（SetServerReserved）用于将异常的实例标记为保留，用于问题排查。
        /// 
        /// 字段ReserveValue：0默认值，不保留；1 保留
        /// </summary>
        /// <param name="req"><see cref="SetServerReservedRequest"/></param>
        /// <returns><see cref="SetServerReservedResponse"/></returns>
        public Task<SetServerReservedResponse> SetServerReserved(SetServerReservedRequest req)
        {
            return InternalRequestAsync<SetServerReservedResponse>(req, "SetServerReserved");
        }

        /// <summary>
        /// 此接口无法使用，游戏服务器引擎GSE已于6.1正式下架，感谢您的支持
        /// 
        /// 本接口（SetServerReserved）用于将异常的实例标记为保留，用于问题排查。
        /// 
        /// 字段ReserveValue：0默认值，不保留；1 保留
        /// </summary>
        /// <param name="req"><see cref="SetServerReservedRequest"/></param>
        /// <returns><see cref="SetServerReservedResponse"/></returns>
        public SetServerReservedResponse SetServerReservedSync(SetServerReservedRequest req)
        {
            return InternalRequestAsync<SetServerReservedResponse>(req, "SetServerReserved")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口无法使用，游戏服务器引擎GSE已于6.1正式下架，感谢您的支持
        /// 
        /// 本接口（SetServerWeight）用于设置服务器权重。
        /// </summary>
        /// <param name="req"><see cref="SetServerWeightRequest"/></param>
        /// <returns><see cref="SetServerWeightResponse"/></returns>
        public Task<SetServerWeightResponse> SetServerWeight(SetServerWeightRequest req)
        {
            return InternalRequestAsync<SetServerWeightResponse>(req, "SetServerWeight");
        }

        /// <summary>
        /// 此接口无法使用，游戏服务器引擎GSE已于6.1正式下架，感谢您的支持
        /// 
        /// 本接口（SetServerWeight）用于设置服务器权重。
        /// </summary>
        /// <param name="req"><see cref="SetServerWeightRequest"/></param>
        /// <returns><see cref="SetServerWeightResponse"/></returns>
        public SetServerWeightResponse SetServerWeightSync(SetServerWeightRequest req)
        {
            return InternalRequestAsync<SetServerWeightResponse>(req, "SetServerWeight")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口无法使用，游戏服务器引擎GSE已于6.1正式下架，感谢您的支持
        /// 
        /// 本接口（StartFleetActions）用于启用服务器舰队自动扩缩容。
        /// </summary>
        /// <param name="req"><see cref="StartFleetActionsRequest"/></param>
        /// <returns><see cref="StartFleetActionsResponse"/></returns>
        public Task<StartFleetActionsResponse> StartFleetActions(StartFleetActionsRequest req)
        {
            return InternalRequestAsync<StartFleetActionsResponse>(req, "StartFleetActions");
        }

        /// <summary>
        /// 此接口无法使用，游戏服务器引擎GSE已于6.1正式下架，感谢您的支持
        /// 
        /// 本接口（StartFleetActions）用于启用服务器舰队自动扩缩容。
        /// </summary>
        /// <param name="req"><see cref="StartFleetActionsRequest"/></param>
        /// <returns><see cref="StartFleetActionsResponse"/></returns>
        public StartFleetActionsResponse StartFleetActionsSync(StartFleetActionsRequest req)
        {
            return InternalRequestAsync<StartFleetActionsResponse>(req, "StartFleetActions")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口无法使用，游戏服务器引擎GSE已于6.1正式下架，感谢您的支持
        /// 
        /// 本接口（StartGameServerSessionPlacement）用于开始放置游戏服务器会话。
        /// </summary>
        /// <param name="req"><see cref="StartGameServerSessionPlacementRequest"/></param>
        /// <returns><see cref="StartGameServerSessionPlacementResponse"/></returns>
        public Task<StartGameServerSessionPlacementResponse> StartGameServerSessionPlacement(StartGameServerSessionPlacementRequest req)
        {
            return InternalRequestAsync<StartGameServerSessionPlacementResponse>(req, "StartGameServerSessionPlacement");
        }

        /// <summary>
        /// 此接口无法使用，游戏服务器引擎GSE已于6.1正式下架，感谢您的支持
        /// 
        /// 本接口（StartGameServerSessionPlacement）用于开始放置游戏服务器会话。
        /// </summary>
        /// <param name="req"><see cref="StartGameServerSessionPlacementRequest"/></param>
        /// <returns><see cref="StartGameServerSessionPlacementResponse"/></returns>
        public StartGameServerSessionPlacementResponse StartGameServerSessionPlacementSync(StartGameServerSessionPlacementRequest req)
        {
            return InternalRequestAsync<StartGameServerSessionPlacementResponse>(req, "StartGameServerSessionPlacement")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口无法使用，游戏服务器引擎GSE已于6.1正式下架，感谢您的支持
        /// 
        /// 本接口（StopFleetActions）用于停止服务器舰队自动扩缩容，改为手动扩缩容。
        /// </summary>
        /// <param name="req"><see cref="StopFleetActionsRequest"/></param>
        /// <returns><see cref="StopFleetActionsResponse"/></returns>
        public Task<StopFleetActionsResponse> StopFleetActions(StopFleetActionsRequest req)
        {
            return InternalRequestAsync<StopFleetActionsResponse>(req, "StopFleetActions");
        }

        /// <summary>
        /// 此接口无法使用，游戏服务器引擎GSE已于6.1正式下架，感谢您的支持
        /// 
        /// 本接口（StopFleetActions）用于停止服务器舰队自动扩缩容，改为手动扩缩容。
        /// </summary>
        /// <param name="req"><see cref="StopFleetActionsRequest"/></param>
        /// <returns><see cref="StopFleetActionsResponse"/></returns>
        public StopFleetActionsResponse StopFleetActionsSync(StopFleetActionsRequest req)
        {
            return InternalRequestAsync<StopFleetActionsResponse>(req, "StopFleetActions")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口无法使用，游戏服务器引擎GSE已于6.1正式下架，感谢您的支持
        /// 
        /// 本接口（StopGameServerSessionPlacement）用于停止放置游戏服务器会话。
        /// </summary>
        /// <param name="req"><see cref="StopGameServerSessionPlacementRequest"/></param>
        /// <returns><see cref="StopGameServerSessionPlacementResponse"/></returns>
        public Task<StopGameServerSessionPlacementResponse> StopGameServerSessionPlacement(StopGameServerSessionPlacementRequest req)
        {
            return InternalRequestAsync<StopGameServerSessionPlacementResponse>(req, "StopGameServerSessionPlacement");
        }

        /// <summary>
        /// 此接口无法使用，游戏服务器引擎GSE已于6.1正式下架，感谢您的支持
        /// 
        /// 本接口（StopGameServerSessionPlacement）用于停止放置游戏服务器会话。
        /// </summary>
        /// <param name="req"><see cref="StopGameServerSessionPlacementRequest"/></param>
        /// <returns><see cref="StopGameServerSessionPlacementResponse"/></returns>
        public StopGameServerSessionPlacementResponse StopGameServerSessionPlacementSync(StopGameServerSessionPlacementRequest req)
        {
            return InternalRequestAsync<StopGameServerSessionPlacementResponse>(req, "StopGameServerSessionPlacement")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口无法使用，游戏服务器引擎GSE已于6.1正式下架，感谢您的支持
        /// 
        /// 本接口（UpdateAlias）用于更新别名的属性。
        /// </summary>
        /// <param name="req"><see cref="UpdateAliasRequest"/></param>
        /// <returns><see cref="UpdateAliasResponse"/></returns>
        public Task<UpdateAliasResponse> UpdateAlias(UpdateAliasRequest req)
        {
            return InternalRequestAsync<UpdateAliasResponse>(req, "UpdateAlias");
        }

        /// <summary>
        /// 此接口无法使用，游戏服务器引擎GSE已于6.1正式下架，感谢您的支持
        /// 
        /// 本接口（UpdateAlias）用于更新别名的属性。
        /// </summary>
        /// <param name="req"><see cref="UpdateAliasRequest"/></param>
        /// <returns><see cref="UpdateAliasResponse"/></returns>
        public UpdateAliasResponse UpdateAliasSync(UpdateAliasRequest req)
        {
            return InternalRequestAsync<UpdateAliasResponse>(req, "UpdateAlias")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口无法使用，游戏服务器引擎GSE已于6.1正式下架，感谢您的支持
        /// 
        /// 本接口（UpdateAsset）用于修改生成包信息。
        /// </summary>
        /// <param name="req"><see cref="UpdateAssetRequest"/></param>
        /// <returns><see cref="UpdateAssetResponse"/></returns>
        public Task<UpdateAssetResponse> UpdateAsset(UpdateAssetRequest req)
        {
            return InternalRequestAsync<UpdateAssetResponse>(req, "UpdateAsset");
        }

        /// <summary>
        /// 此接口无法使用，游戏服务器引擎GSE已于6.1正式下架，感谢您的支持
        /// 
        /// 本接口（UpdateAsset）用于修改生成包信息。
        /// </summary>
        /// <param name="req"><see cref="UpdateAssetRequest"/></param>
        /// <returns><see cref="UpdateAssetResponse"/></returns>
        public UpdateAssetResponse UpdateAssetSync(UpdateAssetRequest req)
        {
            return InternalRequestAsync<UpdateAssetResponse>(req, "UpdateAsset")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口无法使用，游戏服务器引擎GSE已于6.1正式下架，感谢您的支持
        /// 
        /// 本接口（UpdateBucketAccelerateOpt）用于开启cos全球加速。
        /// </summary>
        /// <param name="req"><see cref="UpdateBucketAccelerateOptRequest"/></param>
        /// <returns><see cref="UpdateBucketAccelerateOptResponse"/></returns>
        public Task<UpdateBucketAccelerateOptResponse> UpdateBucketAccelerateOpt(UpdateBucketAccelerateOptRequest req)
        {
            return InternalRequestAsync<UpdateBucketAccelerateOptResponse>(req, "UpdateBucketAccelerateOpt");
        }

        /// <summary>
        /// 此接口无法使用，游戏服务器引擎GSE已于6.1正式下架，感谢您的支持
        /// 
        /// 本接口（UpdateBucketAccelerateOpt）用于开启cos全球加速。
        /// </summary>
        /// <param name="req"><see cref="UpdateBucketAccelerateOptRequest"/></param>
        /// <returns><see cref="UpdateBucketAccelerateOptResponse"/></returns>
        public UpdateBucketAccelerateOptResponse UpdateBucketAccelerateOptSync(UpdateBucketAccelerateOptRequest req)
        {
            return InternalRequestAsync<UpdateBucketAccelerateOptResponse>(req, "UpdateBucketAccelerateOpt")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口无法使用，游戏服务器引擎GSE已于6.1正式下架，感谢您的支持
        /// 
        /// 本接口（UpdateBucketCORSOpt）用于设置cos跨域访问。
        /// </summary>
        /// <param name="req"><see cref="UpdateBucketCORSOptRequest"/></param>
        /// <returns><see cref="UpdateBucketCORSOptResponse"/></returns>
        public Task<UpdateBucketCORSOptResponse> UpdateBucketCORSOpt(UpdateBucketCORSOptRequest req)
        {
            return InternalRequestAsync<UpdateBucketCORSOptResponse>(req, "UpdateBucketCORSOpt");
        }

        /// <summary>
        /// 此接口无法使用，游戏服务器引擎GSE已于6.1正式下架，感谢您的支持
        /// 
        /// 本接口（UpdateBucketCORSOpt）用于设置cos跨域访问。
        /// </summary>
        /// <param name="req"><see cref="UpdateBucketCORSOptRequest"/></param>
        /// <returns><see cref="UpdateBucketCORSOptResponse"/></returns>
        public UpdateBucketCORSOptResponse UpdateBucketCORSOptSync(UpdateBucketCORSOptRequest req)
        {
            return InternalRequestAsync<UpdateBucketCORSOptResponse>(req, "UpdateBucketCORSOpt")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口无法使用，游戏服务器引擎GSE已于6.1正式下架，感谢您的支持
        /// 
        /// 本接口（UpdateFleetAttributes）用于更新服务器舰队属性。
        /// </summary>
        /// <param name="req"><see cref="UpdateFleetAttributesRequest"/></param>
        /// <returns><see cref="UpdateFleetAttributesResponse"/></returns>
        public Task<UpdateFleetAttributesResponse> UpdateFleetAttributes(UpdateFleetAttributesRequest req)
        {
            return InternalRequestAsync<UpdateFleetAttributesResponse>(req, "UpdateFleetAttributes");
        }

        /// <summary>
        /// 此接口无法使用，游戏服务器引擎GSE已于6.1正式下架，感谢您的支持
        /// 
        /// 本接口（UpdateFleetAttributes）用于更新服务器舰队属性。
        /// </summary>
        /// <param name="req"><see cref="UpdateFleetAttributesRequest"/></param>
        /// <returns><see cref="UpdateFleetAttributesResponse"/></returns>
        public UpdateFleetAttributesResponse UpdateFleetAttributesSync(UpdateFleetAttributesRequest req)
        {
            return InternalRequestAsync<UpdateFleetAttributesResponse>(req, "UpdateFleetAttributes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口无法使用，游戏服务器引擎GSE已于6.1正式下架，感谢您的支持
        /// 
        /// 本接口（UpdateFleetCapacity）用于更新服务器舰队容量配置。
        /// </summary>
        /// <param name="req"><see cref="UpdateFleetCapacityRequest"/></param>
        /// <returns><see cref="UpdateFleetCapacityResponse"/></returns>
        public Task<UpdateFleetCapacityResponse> UpdateFleetCapacity(UpdateFleetCapacityRequest req)
        {
            return InternalRequestAsync<UpdateFleetCapacityResponse>(req, "UpdateFleetCapacity");
        }

        /// <summary>
        /// 此接口无法使用，游戏服务器引擎GSE已于6.1正式下架，感谢您的支持
        /// 
        /// 本接口（UpdateFleetCapacity）用于更新服务器舰队容量配置。
        /// </summary>
        /// <param name="req"><see cref="UpdateFleetCapacityRequest"/></param>
        /// <returns><see cref="UpdateFleetCapacityResponse"/></returns>
        public UpdateFleetCapacityResponse UpdateFleetCapacitySync(UpdateFleetCapacityRequest req)
        {
            return InternalRequestAsync<UpdateFleetCapacityResponse>(req, "UpdateFleetCapacity")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口无法使用，游戏服务器引擎GSE已于6.1正式下架，感谢您的支持
        /// 
        /// 本接口（UpdateFleetName）用于更新服务器舰队名称。
        /// </summary>
        /// <param name="req"><see cref="UpdateFleetNameRequest"/></param>
        /// <returns><see cref="UpdateFleetNameResponse"/></returns>
        public Task<UpdateFleetNameResponse> UpdateFleetName(UpdateFleetNameRequest req)
        {
            return InternalRequestAsync<UpdateFleetNameResponse>(req, "UpdateFleetName");
        }

        /// <summary>
        /// 此接口无法使用，游戏服务器引擎GSE已于6.1正式下架，感谢您的支持
        /// 
        /// 本接口（UpdateFleetName）用于更新服务器舰队名称。
        /// </summary>
        /// <param name="req"><see cref="UpdateFleetNameRequest"/></param>
        /// <returns><see cref="UpdateFleetNameResponse"/></returns>
        public UpdateFleetNameResponse UpdateFleetNameSync(UpdateFleetNameRequest req)
        {
            return InternalRequestAsync<UpdateFleetNameResponse>(req, "UpdateFleetName")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口无法使用，游戏服务器引擎GSE已于6.1正式下架，感谢您的支持
        /// 
        /// 本接口（UpdateFleetPortSettings）用于更新服务器舰队安全组。
        /// </summary>
        /// <param name="req"><see cref="UpdateFleetPortSettingsRequest"/></param>
        /// <returns><see cref="UpdateFleetPortSettingsResponse"/></returns>
        public Task<UpdateFleetPortSettingsResponse> UpdateFleetPortSettings(UpdateFleetPortSettingsRequest req)
        {
            return InternalRequestAsync<UpdateFleetPortSettingsResponse>(req, "UpdateFleetPortSettings");
        }

        /// <summary>
        /// 此接口无法使用，游戏服务器引擎GSE已于6.1正式下架，感谢您的支持
        /// 
        /// 本接口（UpdateFleetPortSettings）用于更新服务器舰队安全组。
        /// </summary>
        /// <param name="req"><see cref="UpdateFleetPortSettingsRequest"/></param>
        /// <returns><see cref="UpdateFleetPortSettingsResponse"/></returns>
        public UpdateFleetPortSettingsResponse UpdateFleetPortSettingsSync(UpdateFleetPortSettingsRequest req)
        {
            return InternalRequestAsync<UpdateFleetPortSettingsResponse>(req, "UpdateFleetPortSettings")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口无法使用，游戏服务器引擎GSE已于6.1正式下架，感谢您的支持
        /// 
        /// 本接口（UpdateGameServerSession）用于更新游戏服务器会话。
        /// </summary>
        /// <param name="req"><see cref="UpdateGameServerSessionRequest"/></param>
        /// <returns><see cref="UpdateGameServerSessionResponse"/></returns>
        public Task<UpdateGameServerSessionResponse> UpdateGameServerSession(UpdateGameServerSessionRequest req)
        {
            return InternalRequestAsync<UpdateGameServerSessionResponse>(req, "UpdateGameServerSession");
        }

        /// <summary>
        /// 此接口无法使用，游戏服务器引擎GSE已于6.1正式下架，感谢您的支持
        /// 
        /// 本接口（UpdateGameServerSession）用于更新游戏服务器会话。
        /// </summary>
        /// <param name="req"><see cref="UpdateGameServerSessionRequest"/></param>
        /// <returns><see cref="UpdateGameServerSessionResponse"/></returns>
        public UpdateGameServerSessionResponse UpdateGameServerSessionSync(UpdateGameServerSessionRequest req)
        {
            return InternalRequestAsync<UpdateGameServerSessionResponse>(req, "UpdateGameServerSession")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口无法使用，游戏服务器引擎GSE已于6.1正式下架，感谢您的支持
        /// 
        /// 本接口（UpdateGameServerSessionQueue）用于修改游戏服务器会话队列。
        /// </summary>
        /// <param name="req"><see cref="UpdateGameServerSessionQueueRequest"/></param>
        /// <returns><see cref="UpdateGameServerSessionQueueResponse"/></returns>
        public Task<UpdateGameServerSessionQueueResponse> UpdateGameServerSessionQueue(UpdateGameServerSessionQueueRequest req)
        {
            return InternalRequestAsync<UpdateGameServerSessionQueueResponse>(req, "UpdateGameServerSessionQueue");
        }

        /// <summary>
        /// 此接口无法使用，游戏服务器引擎GSE已于6.1正式下架，感谢您的支持
        /// 
        /// 本接口（UpdateGameServerSessionQueue）用于修改游戏服务器会话队列。
        /// </summary>
        /// <param name="req"><see cref="UpdateGameServerSessionQueueRequest"/></param>
        /// <returns><see cref="UpdateGameServerSessionQueueResponse"/></returns>
        public UpdateGameServerSessionQueueResponse UpdateGameServerSessionQueueSync(UpdateGameServerSessionQueueRequest req)
        {
            return InternalRequestAsync<UpdateGameServerSessionQueueResponse>(req, "UpdateGameServerSessionQueue")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口无法使用，游戏服务器引擎GSE已于6.1正式下架，感谢您的支持
        /// 
        /// 本接口（UpdateRuntimeConfiguration）用于更新服务器舰队配置。
        /// </summary>
        /// <param name="req"><see cref="UpdateRuntimeConfigurationRequest"/></param>
        /// <returns><see cref="UpdateRuntimeConfigurationResponse"/></returns>
        public Task<UpdateRuntimeConfigurationResponse> UpdateRuntimeConfiguration(UpdateRuntimeConfigurationRequest req)
        {
            return InternalRequestAsync<UpdateRuntimeConfigurationResponse>(req, "UpdateRuntimeConfiguration");
        }

        /// <summary>
        /// 此接口无法使用，游戏服务器引擎GSE已于6.1正式下架，感谢您的支持
        /// 
        /// 本接口（UpdateRuntimeConfiguration）用于更新服务器舰队配置。
        /// </summary>
        /// <param name="req"><see cref="UpdateRuntimeConfigurationRequest"/></param>
        /// <returns><see cref="UpdateRuntimeConfigurationResponse"/></returns>
        public UpdateRuntimeConfigurationResponse UpdateRuntimeConfigurationSync(UpdateRuntimeConfigurationRequest req)
        {
            return InternalRequestAsync<UpdateRuntimeConfigurationResponse>(req, "UpdateRuntimeConfiguration")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
