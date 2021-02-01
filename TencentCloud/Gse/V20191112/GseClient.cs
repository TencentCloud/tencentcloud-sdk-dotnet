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

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public GseClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
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

        }

        /// <summary>
        /// 本接口（AttachCcnInstances）用于关联云联网实例。
        /// </summary>
        /// <param name="req"><see cref="AttachCcnInstancesRequest"/></param>
        /// <returns><see cref="AttachCcnInstancesResponse"/></returns>
        public async Task<AttachCcnInstancesResponse> AttachCcnInstances(AttachCcnInstancesRequest req)
        {
             JsonResponseModel<AttachCcnInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AttachCcnInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AttachCcnInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（AttachCcnInstances）用于关联云联网实例。
        /// </summary>
        /// <param name="req"><see cref="AttachCcnInstancesRequest"/></param>
        /// <returns><see cref="AttachCcnInstancesResponse"/></returns>
        public AttachCcnInstancesResponse AttachCcnInstancesSync(AttachCcnInstancesRequest req)
        {
             JsonResponseModel<AttachCcnInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AttachCcnInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AttachCcnInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CopyFleet）用于复制服务器舰队。
        /// </summary>
        /// <param name="req"><see cref="CopyFleetRequest"/></param>
        /// <returns><see cref="CopyFleetResponse"/></returns>
        public async Task<CopyFleetResponse> CopyFleet(CopyFleetRequest req)
        {
             JsonResponseModel<CopyFleetResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CopyFleet");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CopyFleetResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CopyFleet）用于复制服务器舰队。
        /// </summary>
        /// <param name="req"><see cref="CopyFleetRequest"/></param>
        /// <returns><see cref="CopyFleetResponse"/></returns>
        public CopyFleetResponse CopyFleetSync(CopyFleetRequest req)
        {
             JsonResponseModel<CopyFleetResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CopyFleet");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CopyFleetResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateAlias）用于创建别名。
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
        /// 本接口（CreateAlias）用于创建别名。
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
        public async Task<CreateAssetResponse> CreateAsset(CreateAssetRequest req)
        {
             JsonResponseModel<CreateAssetResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateAsset");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAssetResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
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
             JsonResponseModel<CreateAssetResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateAsset");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAssetResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateAssetWithImage）用于创建生成包镜像信息。
        /// </summary>
        /// <param name="req"><see cref="CreateAssetWithImageRequest"/></param>
        /// <returns><see cref="CreateAssetWithImageResponse"/></returns>
        public async Task<CreateAssetWithImageResponse> CreateAssetWithImage(CreateAssetWithImageRequest req)
        {
             JsonResponseModel<CreateAssetWithImageResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateAssetWithImage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAssetWithImageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateAssetWithImage）用于创建生成包镜像信息。
        /// </summary>
        /// <param name="req"><see cref="CreateAssetWithImageRequest"/></param>
        /// <returns><see cref="CreateAssetWithImageResponse"/></returns>
        public CreateAssetWithImageResponse CreateAssetWithImageSync(CreateAssetWithImageRequest req)
        {
             JsonResponseModel<CreateAssetWithImageResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateAssetWithImage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAssetWithImageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateFleet）用于创建服务器舰队。
        /// </summary>
        /// <param name="req"><see cref="CreateFleetRequest"/></param>
        /// <returns><see cref="CreateFleetResponse"/></returns>
        public async Task<CreateFleetResponse> CreateFleet(CreateFleetRequest req)
        {
             JsonResponseModel<CreateFleetResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateFleet");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateFleetResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateFleet）用于创建服务器舰队。
        /// </summary>
        /// <param name="req"><see cref="CreateFleetRequest"/></param>
        /// <returns><see cref="CreateFleetResponse"/></returns>
        public CreateFleetResponse CreateFleetSync(CreateFleetRequest req)
        {
             JsonResponseModel<CreateFleetResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateFleet");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateFleetResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateGameServerSession）用于创建游戏服务会话。
        /// </summary>
        /// <param name="req"><see cref="CreateGameServerSessionRequest"/></param>
        /// <returns><see cref="CreateGameServerSessionResponse"/></returns>
        public async Task<CreateGameServerSessionResponse> CreateGameServerSession(CreateGameServerSessionRequest req)
        {
             JsonResponseModel<CreateGameServerSessionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateGameServerSession");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateGameServerSessionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateGameServerSession）用于创建游戏服务会话。
        /// </summary>
        /// <param name="req"><see cref="CreateGameServerSessionRequest"/></param>
        /// <returns><see cref="CreateGameServerSessionResponse"/></returns>
        public CreateGameServerSessionResponse CreateGameServerSessionSync(CreateGameServerSessionRequest req)
        {
             JsonResponseModel<CreateGameServerSessionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateGameServerSession");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateGameServerSessionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateGameServerSessionQueue）用于创建游戏服务器会话队列。
        /// </summary>
        /// <param name="req"><see cref="CreateGameServerSessionQueueRequest"/></param>
        /// <returns><see cref="CreateGameServerSessionQueueResponse"/></returns>
        public async Task<CreateGameServerSessionQueueResponse> CreateGameServerSessionQueue(CreateGameServerSessionQueueRequest req)
        {
             JsonResponseModel<CreateGameServerSessionQueueResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateGameServerSessionQueue");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateGameServerSessionQueueResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateGameServerSessionQueue）用于创建游戏服务器会话队列。
        /// </summary>
        /// <param name="req"><see cref="CreateGameServerSessionQueueRequest"/></param>
        /// <returns><see cref="CreateGameServerSessionQueueResponse"/></returns>
        public CreateGameServerSessionQueueResponse CreateGameServerSessionQueueSync(CreateGameServerSessionQueueRequest req)
        {
             JsonResponseModel<CreateGameServerSessionQueueResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateGameServerSessionQueue");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateGameServerSessionQueueResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DeleteAlias）用于删除别名。
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
        /// 本接口（DeleteAlias）用于删除别名。
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
        /// 本接口（DeleteAsset）用于删除生成包。
        /// </summary>
        /// <param name="req"><see cref="DeleteAssetRequest"/></param>
        /// <returns><see cref="DeleteAssetResponse"/></returns>
        public async Task<DeleteAssetResponse> DeleteAsset(DeleteAssetRequest req)
        {
             JsonResponseModel<DeleteAssetResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteAsset");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAssetResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DeleteAsset）用于删除生成包。
        /// </summary>
        /// <param name="req"><see cref="DeleteAssetRequest"/></param>
        /// <returns><see cref="DeleteAssetResponse"/></returns>
        public DeleteAssetResponse DeleteAssetSync(DeleteAssetRequest req)
        {
             JsonResponseModel<DeleteAssetResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteAsset");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAssetResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DeleteFleet）用于删除服务器舰队。
        /// </summary>
        /// <param name="req"><see cref="DeleteFleetRequest"/></param>
        /// <returns><see cref="DeleteFleetResponse"/></returns>
        public async Task<DeleteFleetResponse> DeleteFleet(DeleteFleetRequest req)
        {
             JsonResponseModel<DeleteFleetResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteFleet");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteFleetResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DeleteFleet）用于删除服务器舰队。
        /// </summary>
        /// <param name="req"><see cref="DeleteFleetRequest"/></param>
        /// <returns><see cref="DeleteFleetResponse"/></returns>
        public DeleteFleetResponse DeleteFleetSync(DeleteFleetRequest req)
        {
             JsonResponseModel<DeleteFleetResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteFleet");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteFleetResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DeleteGameServerSessionQueue）用于删除游戏服务器会话队列。
        /// </summary>
        /// <param name="req"><see cref="DeleteGameServerSessionQueueRequest"/></param>
        /// <returns><see cref="DeleteGameServerSessionQueueResponse"/></returns>
        public async Task<DeleteGameServerSessionQueueResponse> DeleteGameServerSessionQueue(DeleteGameServerSessionQueueRequest req)
        {
             JsonResponseModel<DeleteGameServerSessionQueueResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteGameServerSessionQueue");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteGameServerSessionQueueResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DeleteGameServerSessionQueue）用于删除游戏服务器会话队列。
        /// </summary>
        /// <param name="req"><see cref="DeleteGameServerSessionQueueRequest"/></param>
        /// <returns><see cref="DeleteGameServerSessionQueueResponse"/></returns>
        public DeleteGameServerSessionQueueResponse DeleteGameServerSessionQueueSync(DeleteGameServerSessionQueueRequest req)
        {
             JsonResponseModel<DeleteGameServerSessionQueueResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteGameServerSessionQueue");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteGameServerSessionQueueResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DeleteScalingPolicy）用于删除服务器舰队的扩缩容策略。
        /// 通过服务器舰队ID和策略名称删除服务器舰队的扩缩容策略，只传递服务器舰队ID时，会将这个服务器舰队下的所有策略都删除。
        /// 传递策略名称时，单独删除策略名称对应的策略。
        /// </summary>
        /// <param name="req"><see cref="DeleteScalingPolicyRequest"/></param>
        /// <returns><see cref="DeleteScalingPolicyResponse"/></returns>
        public async Task<DeleteScalingPolicyResponse> DeleteScalingPolicy(DeleteScalingPolicyRequest req)
        {
             JsonResponseModel<DeleteScalingPolicyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteScalingPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteScalingPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DeleteScalingPolicy）用于删除服务器舰队的扩缩容策略。
        /// 通过服务器舰队ID和策略名称删除服务器舰队的扩缩容策略，只传递服务器舰队ID时，会将这个服务器舰队下的所有策略都删除。
        /// 传递策略名称时，单独删除策略名称对应的策略。
        /// </summary>
        /// <param name="req"><see cref="DeleteScalingPolicyRequest"/></param>
        /// <returns><see cref="DeleteScalingPolicyResponse"/></returns>
        public DeleteScalingPolicyResponse DeleteScalingPolicySync(DeleteScalingPolicyRequest req)
        {
             JsonResponseModel<DeleteScalingPolicyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteScalingPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteScalingPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeAlias）用于获取别名详情。
        /// </summary>
        /// <param name="req"><see cref="DescribeAliasRequest"/></param>
        /// <returns><see cref="DescribeAliasResponse"/></returns>
        public async Task<DescribeAliasResponse> DescribeAlias(DescribeAliasRequest req)
        {
             JsonResponseModel<DescribeAliasResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAlias");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAliasResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeAlias）用于获取别名详情。
        /// </summary>
        /// <param name="req"><see cref="DescribeAliasRequest"/></param>
        /// <returns><see cref="DescribeAliasResponse"/></returns>
        public DescribeAliasResponse DescribeAliasSync(DescribeAliasRequest req)
        {
             JsonResponseModel<DescribeAliasResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAlias");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAliasResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeAsset）获取生成包信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetRequest"/></param>
        /// <returns><see cref="DescribeAssetResponse"/></returns>
        public async Task<DescribeAssetResponse> DescribeAsset(DescribeAssetRequest req)
        {
             JsonResponseModel<DescribeAssetResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAsset");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeAsset）获取生成包信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetRequest"/></param>
        /// <returns><see cref="DescribeAssetResponse"/></returns>
        public DescribeAssetResponse DescribeAssetSync(DescribeAssetRequest req)
        {
             JsonResponseModel<DescribeAssetResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAsset");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeAssetSystems）用于获取生成包支持的操作系统。
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetSystemsRequest"/></param>
        /// <returns><see cref="DescribeAssetSystemsResponse"/></returns>
        public async Task<DescribeAssetSystemsResponse> DescribeAssetSystems(DescribeAssetSystemsRequest req)
        {
             JsonResponseModel<DescribeAssetSystemsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAssetSystems");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetSystemsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeAssetSystems）用于获取生成包支持的操作系统。
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetSystemsRequest"/></param>
        /// <returns><see cref="DescribeAssetSystemsResponse"/></returns>
        public DescribeAssetSystemsResponse DescribeAssetSystemsSync(DescribeAssetSystemsRequest req)
        {
             JsonResponseModel<DescribeAssetSystemsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAssetSystems");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetSystemsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeAssets）用于获取生成包列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetsRequest"/></param>
        /// <returns><see cref="DescribeAssetsResponse"/></returns>
        public async Task<DescribeAssetsResponse> DescribeAssets(DescribeAssetsRequest req)
        {
             JsonResponseModel<DescribeAssetsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAssets");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeAssets）用于获取生成包列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetsRequest"/></param>
        /// <returns><see cref="DescribeAssetsResponse"/></returns>
        public DescribeAssetsResponse DescribeAssetsSync(DescribeAssetsRequest req)
        {
             JsonResponseModel<DescribeAssetsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAssets");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeCcnInstances）用于查询云联网实例。
        /// </summary>
        /// <param name="req"><see cref="DescribeCcnInstancesRequest"/></param>
        /// <returns><see cref="DescribeCcnInstancesResponse"/></returns>
        public async Task<DescribeCcnInstancesResponse> DescribeCcnInstances(DescribeCcnInstancesRequest req)
        {
             JsonResponseModel<DescribeCcnInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCcnInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCcnInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeCcnInstances）用于查询云联网实例。
        /// </summary>
        /// <param name="req"><see cref="DescribeCcnInstancesRequest"/></param>
        /// <returns><see cref="DescribeCcnInstancesResponse"/></returns>
        public DescribeCcnInstancesResponse DescribeCcnInstancesSync(DescribeCcnInstancesRequest req)
        {
             JsonResponseModel<DescribeCcnInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCcnInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCcnInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeFleetAttributes）用于查询服务器舰队属性。
        /// </summary>
        /// <param name="req"><see cref="DescribeFleetAttributesRequest"/></param>
        /// <returns><see cref="DescribeFleetAttributesResponse"/></returns>
        public async Task<DescribeFleetAttributesResponse> DescribeFleetAttributes(DescribeFleetAttributesRequest req)
        {
             JsonResponseModel<DescribeFleetAttributesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeFleetAttributes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeFleetAttributesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeFleetAttributes）用于查询服务器舰队属性。
        /// </summary>
        /// <param name="req"><see cref="DescribeFleetAttributesRequest"/></param>
        /// <returns><see cref="DescribeFleetAttributesResponse"/></returns>
        public DescribeFleetAttributesResponse DescribeFleetAttributesSync(DescribeFleetAttributesRequest req)
        {
             JsonResponseModel<DescribeFleetAttributesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeFleetAttributes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeFleetAttributesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeFleetCapacity）用于查询服务部署容量配置。
        /// </summary>
        /// <param name="req"><see cref="DescribeFleetCapacityRequest"/></param>
        /// <returns><see cref="DescribeFleetCapacityResponse"/></returns>
        public async Task<DescribeFleetCapacityResponse> DescribeFleetCapacity(DescribeFleetCapacityRequest req)
        {
             JsonResponseModel<DescribeFleetCapacityResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeFleetCapacity");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeFleetCapacityResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeFleetCapacity）用于查询服务部署容量配置。
        /// </summary>
        /// <param name="req"><see cref="DescribeFleetCapacityRequest"/></param>
        /// <returns><see cref="DescribeFleetCapacityResponse"/></returns>
        public DescribeFleetCapacityResponse DescribeFleetCapacitySync(DescribeFleetCapacityRequest req)
        {
             JsonResponseModel<DescribeFleetCapacityResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeFleetCapacity");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeFleetCapacityResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeFleetEvents）用于查询服务器舰队相关的事件列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeFleetEventsRequest"/></param>
        /// <returns><see cref="DescribeFleetEventsResponse"/></returns>
        public async Task<DescribeFleetEventsResponse> DescribeFleetEvents(DescribeFleetEventsRequest req)
        {
             JsonResponseModel<DescribeFleetEventsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeFleetEvents");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeFleetEventsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeFleetEvents）用于查询服务器舰队相关的事件列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeFleetEventsRequest"/></param>
        /// <returns><see cref="DescribeFleetEventsResponse"/></returns>
        public DescribeFleetEventsResponse DescribeFleetEventsSync(DescribeFleetEventsRequest req)
        {
             JsonResponseModel<DescribeFleetEventsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeFleetEvents");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeFleetEventsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeFleetPortSettings）用于获取服务器舰队安全组信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeFleetPortSettingsRequest"/></param>
        /// <returns><see cref="DescribeFleetPortSettingsResponse"/></returns>
        public async Task<DescribeFleetPortSettingsResponse> DescribeFleetPortSettings(DescribeFleetPortSettingsRequest req)
        {
             JsonResponseModel<DescribeFleetPortSettingsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeFleetPortSettings");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeFleetPortSettingsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeFleetPortSettings）用于获取服务器舰队安全组信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeFleetPortSettingsRequest"/></param>
        /// <returns><see cref="DescribeFleetPortSettingsResponse"/></returns>
        public DescribeFleetPortSettingsResponse DescribeFleetPortSettingsSync(DescribeFleetPortSettingsRequest req)
        {
             JsonResponseModel<DescribeFleetPortSettingsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeFleetPortSettings");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeFleetPortSettingsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeFleetStatisticDetails）用于查询服务部署统计详情。
        /// </summary>
        /// <param name="req"><see cref="DescribeFleetStatisticDetailsRequest"/></param>
        /// <returns><see cref="DescribeFleetStatisticDetailsResponse"/></returns>
        public async Task<DescribeFleetStatisticDetailsResponse> DescribeFleetStatisticDetails(DescribeFleetStatisticDetailsRequest req)
        {
             JsonResponseModel<DescribeFleetStatisticDetailsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeFleetStatisticDetails");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeFleetStatisticDetailsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeFleetStatisticDetails）用于查询服务部署统计详情。
        /// </summary>
        /// <param name="req"><see cref="DescribeFleetStatisticDetailsRequest"/></param>
        /// <returns><see cref="DescribeFleetStatisticDetailsResponse"/></returns>
        public DescribeFleetStatisticDetailsResponse DescribeFleetStatisticDetailsSync(DescribeFleetStatisticDetailsRequest req)
        {
             JsonResponseModel<DescribeFleetStatisticDetailsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeFleetStatisticDetails");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeFleetStatisticDetailsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeFleetStatisticFlows）用于查询服务部署统计用量。
        /// </summary>
        /// <param name="req"><see cref="DescribeFleetStatisticFlowsRequest"/></param>
        /// <returns><see cref="DescribeFleetStatisticFlowsResponse"/></returns>
        public async Task<DescribeFleetStatisticFlowsResponse> DescribeFleetStatisticFlows(DescribeFleetStatisticFlowsRequest req)
        {
             JsonResponseModel<DescribeFleetStatisticFlowsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeFleetStatisticFlows");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeFleetStatisticFlowsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeFleetStatisticFlows）用于查询服务部署统计用量。
        /// </summary>
        /// <param name="req"><see cref="DescribeFleetStatisticFlowsRequest"/></param>
        /// <returns><see cref="DescribeFleetStatisticFlowsResponse"/></returns>
        public DescribeFleetStatisticFlowsResponse DescribeFleetStatisticFlowsSync(DescribeFleetStatisticFlowsRequest req)
        {
             JsonResponseModel<DescribeFleetStatisticFlowsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeFleetStatisticFlows");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeFleetStatisticFlowsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeFleetStatisticSummary）用于查询服务部署统计汇总信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeFleetStatisticSummaryRequest"/></param>
        /// <returns><see cref="DescribeFleetStatisticSummaryResponse"/></returns>
        public async Task<DescribeFleetStatisticSummaryResponse> DescribeFleetStatisticSummary(DescribeFleetStatisticSummaryRequest req)
        {
             JsonResponseModel<DescribeFleetStatisticSummaryResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeFleetStatisticSummary");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeFleetStatisticSummaryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeFleetStatisticSummary）用于查询服务部署统计汇总信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeFleetStatisticSummaryRequest"/></param>
        /// <returns><see cref="DescribeFleetStatisticSummaryResponse"/></returns>
        public DescribeFleetStatisticSummaryResponse DescribeFleetStatisticSummarySync(DescribeFleetStatisticSummaryRequest req)
        {
             JsonResponseModel<DescribeFleetStatisticSummaryResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeFleetStatisticSummary");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeFleetStatisticSummaryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeFleetUtilization）用于查询服务器舰队的利用率信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeFleetUtilizationRequest"/></param>
        /// <returns><see cref="DescribeFleetUtilizationResponse"/></returns>
        public async Task<DescribeFleetUtilizationResponse> DescribeFleetUtilization(DescribeFleetUtilizationRequest req)
        {
             JsonResponseModel<DescribeFleetUtilizationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeFleetUtilization");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeFleetUtilizationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeFleetUtilization）用于查询服务器舰队的利用率信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeFleetUtilizationRequest"/></param>
        /// <returns><see cref="DescribeFleetUtilizationResponse"/></returns>
        public DescribeFleetUtilizationResponse DescribeFleetUtilizationSync(DescribeFleetUtilizationRequest req)
        {
             JsonResponseModel<DescribeFleetUtilizationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeFleetUtilization");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeFleetUtilizationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeGameServerSessionDetails）用于查询游戏服务器会话详情列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeGameServerSessionDetailsRequest"/></param>
        /// <returns><see cref="DescribeGameServerSessionDetailsResponse"/></returns>
        public async Task<DescribeGameServerSessionDetailsResponse> DescribeGameServerSessionDetails(DescribeGameServerSessionDetailsRequest req)
        {
             JsonResponseModel<DescribeGameServerSessionDetailsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeGameServerSessionDetails");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeGameServerSessionDetailsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeGameServerSessionDetails）用于查询游戏服务器会话详情列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeGameServerSessionDetailsRequest"/></param>
        /// <returns><see cref="DescribeGameServerSessionDetailsResponse"/></returns>
        public DescribeGameServerSessionDetailsResponse DescribeGameServerSessionDetailsSync(DescribeGameServerSessionDetailsRequest req)
        {
             JsonResponseModel<DescribeGameServerSessionDetailsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeGameServerSessionDetails");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeGameServerSessionDetailsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeGameServerSessionPlacement）用于查询游戏服务器会话的放置。
        /// </summary>
        /// <param name="req"><see cref="DescribeGameServerSessionPlacementRequest"/></param>
        /// <returns><see cref="DescribeGameServerSessionPlacementResponse"/></returns>
        public async Task<DescribeGameServerSessionPlacementResponse> DescribeGameServerSessionPlacement(DescribeGameServerSessionPlacementRequest req)
        {
             JsonResponseModel<DescribeGameServerSessionPlacementResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeGameServerSessionPlacement");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeGameServerSessionPlacementResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeGameServerSessionPlacement）用于查询游戏服务器会话的放置。
        /// </summary>
        /// <param name="req"><see cref="DescribeGameServerSessionPlacementRequest"/></param>
        /// <returns><see cref="DescribeGameServerSessionPlacementResponse"/></returns>
        public DescribeGameServerSessionPlacementResponse DescribeGameServerSessionPlacementSync(DescribeGameServerSessionPlacementRequest req)
        {
             JsonResponseModel<DescribeGameServerSessionPlacementResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeGameServerSessionPlacement");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeGameServerSessionPlacementResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeGameServerSessionQueues）用于查询游戏服务器会话队列。
        /// </summary>
        /// <param name="req"><see cref="DescribeGameServerSessionQueuesRequest"/></param>
        /// <returns><see cref="DescribeGameServerSessionQueuesResponse"/></returns>
        public async Task<DescribeGameServerSessionQueuesResponse> DescribeGameServerSessionQueues(DescribeGameServerSessionQueuesRequest req)
        {
             JsonResponseModel<DescribeGameServerSessionQueuesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeGameServerSessionQueues");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeGameServerSessionQueuesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeGameServerSessionQueues）用于查询游戏服务器会话队列。
        /// </summary>
        /// <param name="req"><see cref="DescribeGameServerSessionQueuesRequest"/></param>
        /// <returns><see cref="DescribeGameServerSessionQueuesResponse"/></returns>
        public DescribeGameServerSessionQueuesResponse DescribeGameServerSessionQueuesSync(DescribeGameServerSessionQueuesRequest req)
        {
             JsonResponseModel<DescribeGameServerSessionQueuesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeGameServerSessionQueues");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeGameServerSessionQueuesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeGameServerSessions）用于查询游戏服务器会话列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeGameServerSessionsRequest"/></param>
        /// <returns><see cref="DescribeGameServerSessionsResponse"/></returns>
        public async Task<DescribeGameServerSessionsResponse> DescribeGameServerSessions(DescribeGameServerSessionsRequest req)
        {
             JsonResponseModel<DescribeGameServerSessionsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeGameServerSessions");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeGameServerSessionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeGameServerSessions）用于查询游戏服务器会话列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeGameServerSessionsRequest"/></param>
        /// <returns><see cref="DescribeGameServerSessionsResponse"/></returns>
        public DescribeGameServerSessionsResponse DescribeGameServerSessionsSync(DescribeGameServerSessionsRequest req)
        {
             JsonResponseModel<DescribeGameServerSessionsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeGameServerSessions");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeGameServerSessionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeInstanceLimit）用于查询用户实例数限额。
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceLimitRequest"/></param>
        /// <returns><see cref="DescribeInstanceLimitResponse"/></returns>
        public async Task<DescribeInstanceLimitResponse> DescribeInstanceLimit(DescribeInstanceLimitRequest req)
        {
             JsonResponseModel<DescribeInstanceLimitResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInstanceLimit");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceLimitResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeInstanceLimit）用于查询用户实例数限额。
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceLimitRequest"/></param>
        /// <returns><see cref="DescribeInstanceLimitResponse"/></returns>
        public DescribeInstanceLimitResponse DescribeInstanceLimitSync(DescribeInstanceLimitRequest req)
        {
             JsonResponseModel<DescribeInstanceLimitResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInstanceLimit");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceLimitResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeInstanceTypes）用于获取服务器实例类型列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceTypesRequest"/></param>
        /// <returns><see cref="DescribeInstanceTypesResponse"/></returns>
        public async Task<DescribeInstanceTypesResponse> DescribeInstanceTypes(DescribeInstanceTypesRequest req)
        {
             JsonResponseModel<DescribeInstanceTypesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInstanceTypes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceTypesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeInstanceTypes）用于获取服务器实例类型列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceTypesRequest"/></param>
        /// <returns><see cref="DescribeInstanceTypesResponse"/></returns>
        public DescribeInstanceTypesResponse DescribeInstanceTypesSync(DescribeInstanceTypesRequest req)
        {
             JsonResponseModel<DescribeInstanceTypesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInstanceTypes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceTypesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeInstances）用于查询服务器实例列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesRequest"/></param>
        /// <returns><see cref="DescribeInstancesResponse"/></returns>
        public async Task<DescribeInstancesResponse> DescribeInstances(DescribeInstancesRequest req)
        {
             JsonResponseModel<DescribeInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeInstances）用于查询服务器实例列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesRequest"/></param>
        /// <returns><see cref="DescribeInstancesResponse"/></returns>
        public DescribeInstancesResponse DescribeInstancesSync(DescribeInstancesRequest req)
        {
             JsonResponseModel<DescribeInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeInstancesExtend）用于查询实例扩展信息列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesExtendRequest"/></param>
        /// <returns><see cref="DescribeInstancesExtendResponse"/></returns>
        public async Task<DescribeInstancesExtendResponse> DescribeInstancesExtend(DescribeInstancesExtendRequest req)
        {
             JsonResponseModel<DescribeInstancesExtendResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInstancesExtend");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstancesExtendResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeInstancesExtend）用于查询实例扩展信息列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesExtendRequest"/></param>
        /// <returns><see cref="DescribeInstancesExtendResponse"/></returns>
        public DescribeInstancesExtendResponse DescribeInstancesExtendSync(DescribeInstancesExtendRequest req)
        {
             JsonResponseModel<DescribeInstancesExtendResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInstancesExtend");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstancesExtendResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribePlayerSessions）用于获取玩家会话列表。
        /// </summary>
        /// <param name="req"><see cref="DescribePlayerSessionsRequest"/></param>
        /// <returns><see cref="DescribePlayerSessionsResponse"/></returns>
        public async Task<DescribePlayerSessionsResponse> DescribePlayerSessions(DescribePlayerSessionsRequest req)
        {
             JsonResponseModel<DescribePlayerSessionsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePlayerSessions");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePlayerSessionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribePlayerSessions）用于获取玩家会话列表。
        /// </summary>
        /// <param name="req"><see cref="DescribePlayerSessionsRequest"/></param>
        /// <returns><see cref="DescribePlayerSessionsResponse"/></returns>
        public DescribePlayerSessionsResponse DescribePlayerSessionsSync(DescribePlayerSessionsRequest req)
        {
             JsonResponseModel<DescribePlayerSessionsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribePlayerSessions");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePlayerSessionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeRuntimeConfiguration）用于获取服务器舰队运行配置。
        /// </summary>
        /// <param name="req"><see cref="DescribeRuntimeConfigurationRequest"/></param>
        /// <returns><see cref="DescribeRuntimeConfigurationResponse"/></returns>
        public async Task<DescribeRuntimeConfigurationResponse> DescribeRuntimeConfiguration(DescribeRuntimeConfigurationRequest req)
        {
             JsonResponseModel<DescribeRuntimeConfigurationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRuntimeConfiguration");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRuntimeConfigurationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeRuntimeConfiguration）用于获取服务器舰队运行配置。
        /// </summary>
        /// <param name="req"><see cref="DescribeRuntimeConfigurationRequest"/></param>
        /// <returns><see cref="DescribeRuntimeConfigurationResponse"/></returns>
        public DescribeRuntimeConfigurationResponse DescribeRuntimeConfigurationSync(DescribeRuntimeConfigurationRequest req)
        {
             JsonResponseModel<DescribeRuntimeConfigurationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRuntimeConfiguration");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRuntimeConfigurationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeScalingPolicies）用于查询服务器舰队的动态扩缩容策略列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeScalingPoliciesRequest"/></param>
        /// <returns><see cref="DescribeScalingPoliciesResponse"/></returns>
        public async Task<DescribeScalingPoliciesResponse> DescribeScalingPolicies(DescribeScalingPoliciesRequest req)
        {
             JsonResponseModel<DescribeScalingPoliciesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeScalingPolicies");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeScalingPoliciesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeScalingPolicies）用于查询服务器舰队的动态扩缩容策略列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeScalingPoliciesRequest"/></param>
        /// <returns><see cref="DescribeScalingPoliciesResponse"/></returns>
        public DescribeScalingPoliciesResponse DescribeScalingPoliciesSync(DescribeScalingPoliciesRequest req)
        {
             JsonResponseModel<DescribeScalingPoliciesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeScalingPolicies");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeScalingPoliciesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeUserQuota）获取用户单个模块配额。
        /// </summary>
        /// <param name="req"><see cref="DescribeUserQuotaRequest"/></param>
        /// <returns><see cref="DescribeUserQuotaResponse"/></returns>
        public async Task<DescribeUserQuotaResponse> DescribeUserQuota(DescribeUserQuotaRequest req)
        {
             JsonResponseModel<DescribeUserQuotaResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeUserQuota");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUserQuotaResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeUserQuota）获取用户单个模块配额。
        /// </summary>
        /// <param name="req"><see cref="DescribeUserQuotaRequest"/></param>
        /// <returns><see cref="DescribeUserQuotaResponse"/></returns>
        public DescribeUserQuotaResponse DescribeUserQuotaSync(DescribeUserQuotaRequest req)
        {
             JsonResponseModel<DescribeUserQuotaResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeUserQuota");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUserQuotaResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeUserQuotas）用于获取用户配额
        /// </summary>
        /// <param name="req"><see cref="DescribeUserQuotasRequest"/></param>
        /// <returns><see cref="DescribeUserQuotasResponse"/></returns>
        public async Task<DescribeUserQuotasResponse> DescribeUserQuotas(DescribeUserQuotasRequest req)
        {
             JsonResponseModel<DescribeUserQuotasResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeUserQuotas");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUserQuotasResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeUserQuotas）用于获取用户配额
        /// </summary>
        /// <param name="req"><see cref="DescribeUserQuotasRequest"/></param>
        /// <returns><see cref="DescribeUserQuotasResponse"/></returns>
        public DescribeUserQuotasResponse DescribeUserQuotasSync(DescribeUserQuotasRequest req)
        {
             JsonResponseModel<DescribeUserQuotasResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeUserQuotas");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUserQuotasResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DetachCcnInstances）用于解关联云联网实例。
        /// </summary>
        /// <param name="req"><see cref="DetachCcnInstancesRequest"/></param>
        /// <returns><see cref="DetachCcnInstancesResponse"/></returns>
        public async Task<DetachCcnInstancesResponse> DetachCcnInstances(DetachCcnInstancesRequest req)
        {
             JsonResponseModel<DetachCcnInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DetachCcnInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DetachCcnInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DetachCcnInstances）用于解关联云联网实例。
        /// </summary>
        /// <param name="req"><see cref="DetachCcnInstancesRequest"/></param>
        /// <returns><see cref="DetachCcnInstancesResponse"/></returns>
        public DetachCcnInstancesResponse DetachCcnInstancesSync(DetachCcnInstancesRequest req)
        {
             JsonResponseModel<DetachCcnInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DetachCcnInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DetachCcnInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（GetGameServerSessionLogUrl）用于获取游戏服务器会话的日志URL。
        /// </summary>
        /// <param name="req"><see cref="GetGameServerSessionLogUrlRequest"/></param>
        /// <returns><see cref="GetGameServerSessionLogUrlResponse"/></returns>
        public async Task<GetGameServerSessionLogUrlResponse> GetGameServerSessionLogUrl(GetGameServerSessionLogUrlRequest req)
        {
             JsonResponseModel<GetGameServerSessionLogUrlResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetGameServerSessionLogUrl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetGameServerSessionLogUrlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（GetGameServerSessionLogUrl）用于获取游戏服务器会话的日志URL。
        /// </summary>
        /// <param name="req"><see cref="GetGameServerSessionLogUrlRequest"/></param>
        /// <returns><see cref="GetGameServerSessionLogUrlResponse"/></returns>
        public GetGameServerSessionLogUrlResponse GetGameServerSessionLogUrlSync(GetGameServerSessionLogUrlRequest req)
        {
             JsonResponseModel<GetGameServerSessionLogUrlResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetGameServerSessionLogUrl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetGameServerSessionLogUrlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（GetInstanceAccess）用于获取实例登录所需要的凭据。
        /// </summary>
        /// <param name="req"><see cref="GetInstanceAccessRequest"/></param>
        /// <returns><see cref="GetInstanceAccessResponse"/></returns>
        public async Task<GetInstanceAccessResponse> GetInstanceAccess(GetInstanceAccessRequest req)
        {
             JsonResponseModel<GetInstanceAccessResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetInstanceAccess");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetInstanceAccessResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（GetInstanceAccess）用于获取实例登录所需要的凭据。
        /// </summary>
        /// <param name="req"><see cref="GetInstanceAccessRequest"/></param>
        /// <returns><see cref="GetInstanceAccessResponse"/></returns>
        public GetInstanceAccessResponse GetInstanceAccessSync(GetInstanceAccessRequest req)
        {
             JsonResponseModel<GetInstanceAccessResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetInstanceAccess");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetInstanceAccessResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（GetUploadCredentials）获取上传文件授权信息。
        /// 通过 [GetUploadCredentials](https://cloud.tencent.com/document/product/1165/48727) 接口获取临时授权信息后，调用 COS API将数据上传，根据上传的 BucketKey 信息进行生成包 [CreateAsset](https://cloud.tencent.com/document/product/1165/48731) 的创建。参考下面的示例部分。
        /// </summary>
        /// <param name="req"><see cref="GetUploadCredentialsRequest"/></param>
        /// <returns><see cref="GetUploadCredentialsResponse"/></returns>
        public async Task<GetUploadCredentialsResponse> GetUploadCredentials(GetUploadCredentialsRequest req)
        {
             JsonResponseModel<GetUploadCredentialsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetUploadCredentials");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetUploadCredentialsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（GetUploadCredentials）获取上传文件授权信息。
        /// 通过 [GetUploadCredentials](https://cloud.tencent.com/document/product/1165/48727) 接口获取临时授权信息后，调用 COS API将数据上传，根据上传的 BucketKey 信息进行生成包 [CreateAsset](https://cloud.tencent.com/document/product/1165/48731) 的创建。参考下面的示例部分。
        /// </summary>
        /// <param name="req"><see cref="GetUploadCredentialsRequest"/></param>
        /// <returns><see cref="GetUploadCredentialsResponse"/></returns>
        public GetUploadCredentialsResponse GetUploadCredentialsSync(GetUploadCredentialsRequest req)
        {
             JsonResponseModel<GetUploadCredentialsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetUploadCredentials");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetUploadCredentialsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（GetUploadFederationToken）用于 获取生成包上传所需要的临时密钥。
        /// </summary>
        /// <param name="req"><see cref="GetUploadFederationTokenRequest"/></param>
        /// <returns><see cref="GetUploadFederationTokenResponse"/></returns>
        public async Task<GetUploadFederationTokenResponse> GetUploadFederationToken(GetUploadFederationTokenRequest req)
        {
             JsonResponseModel<GetUploadFederationTokenResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetUploadFederationToken");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetUploadFederationTokenResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（GetUploadFederationToken）用于 获取生成包上传所需要的临时密钥。
        /// </summary>
        /// <param name="req"><see cref="GetUploadFederationTokenRequest"/></param>
        /// <returns><see cref="GetUploadFederationTokenResponse"/></returns>
        public GetUploadFederationTokenResponse GetUploadFederationTokenSync(GetUploadFederationTokenRequest req)
        {
             JsonResponseModel<GetUploadFederationTokenResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetUploadFederationToken");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetUploadFederationTokenResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（JoinGameServerSession）用于加入游戏服务器会话。
        /// </summary>
        /// <param name="req"><see cref="JoinGameServerSessionRequest"/></param>
        /// <returns><see cref="JoinGameServerSessionResponse"/></returns>
        public async Task<JoinGameServerSessionResponse> JoinGameServerSession(JoinGameServerSessionRequest req)
        {
             JsonResponseModel<JoinGameServerSessionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "JoinGameServerSession");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<JoinGameServerSessionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（JoinGameServerSession）用于加入游戏服务器会话。
        /// </summary>
        /// <param name="req"><see cref="JoinGameServerSessionRequest"/></param>
        /// <returns><see cref="JoinGameServerSessionResponse"/></returns>
        public JoinGameServerSessionResponse JoinGameServerSessionSync(JoinGameServerSessionRequest req)
        {
             JsonResponseModel<JoinGameServerSessionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "JoinGameServerSession");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<JoinGameServerSessionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（JoinGameServerSessionBatch）用于批量加入游戏服务器会话。
        /// </summary>
        /// <param name="req"><see cref="JoinGameServerSessionBatchRequest"/></param>
        /// <returns><see cref="JoinGameServerSessionBatchResponse"/></returns>
        public async Task<JoinGameServerSessionBatchResponse> JoinGameServerSessionBatch(JoinGameServerSessionBatchRequest req)
        {
             JsonResponseModel<JoinGameServerSessionBatchResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "JoinGameServerSessionBatch");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<JoinGameServerSessionBatchResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（JoinGameServerSessionBatch）用于批量加入游戏服务器会话。
        /// </summary>
        /// <param name="req"><see cref="JoinGameServerSessionBatchRequest"/></param>
        /// <returns><see cref="JoinGameServerSessionBatchResponse"/></returns>
        public JoinGameServerSessionBatchResponse JoinGameServerSessionBatchSync(JoinGameServerSessionBatchRequest req)
        {
             JsonResponseModel<JoinGameServerSessionBatchResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "JoinGameServerSessionBatch");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<JoinGameServerSessionBatchResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ListAliases）用于检索帐户下的所有别名。
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
        /// 本接口（ListAliases）用于检索帐户下的所有别名。
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
        /// 本接口（ListFleets）用于获取服务器舰队列表。
        /// </summary>
        /// <param name="req"><see cref="ListFleetsRequest"/></param>
        /// <returns><see cref="ListFleetsResponse"/></returns>
        public async Task<ListFleetsResponse> ListFleets(ListFleetsRequest req)
        {
             JsonResponseModel<ListFleetsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ListFleets");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListFleetsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ListFleets）用于获取服务器舰队列表。
        /// </summary>
        /// <param name="req"><see cref="ListFleetsRequest"/></param>
        /// <returns><see cref="ListFleetsResponse"/></returns>
        public ListFleetsResponse ListFleetsSync(ListFleetsRequest req)
        {
             JsonResponseModel<ListFleetsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ListFleets");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListFleetsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
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
        public async Task<PutScalingPolicyResponse> PutScalingPolicy(PutScalingPolicyRequest req)
        {
             JsonResponseModel<PutScalingPolicyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "PutScalingPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<PutScalingPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
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
             JsonResponseModel<PutScalingPolicyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "PutScalingPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<PutScalingPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ResolveAlias）用于获取别名当前指向的fleetId。
        /// </summary>
        /// <param name="req"><see cref="ResolveAliasRequest"/></param>
        /// <returns><see cref="ResolveAliasResponse"/></returns>
        public async Task<ResolveAliasResponse> ResolveAlias(ResolveAliasRequest req)
        {
             JsonResponseModel<ResolveAliasResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ResolveAlias");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResolveAliasResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ResolveAlias）用于获取别名当前指向的fleetId。
        /// </summary>
        /// <param name="req"><see cref="ResolveAliasRequest"/></param>
        /// <returns><see cref="ResolveAliasResponse"/></returns>
        public ResolveAliasResponse ResolveAliasSync(ResolveAliasRequest req)
        {
             JsonResponseModel<ResolveAliasResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ResolveAlias");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResolveAliasResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（SearchGameServerSessions）用于搜索游戏服务器会话列表。
        /// </summary>
        /// <param name="req"><see cref="SearchGameServerSessionsRequest"/></param>
        /// <returns><see cref="SearchGameServerSessionsResponse"/></returns>
        public async Task<SearchGameServerSessionsResponse> SearchGameServerSessions(SearchGameServerSessionsRequest req)
        {
             JsonResponseModel<SearchGameServerSessionsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SearchGameServerSessions");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SearchGameServerSessionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（SearchGameServerSessions）用于搜索游戏服务器会话列表。
        /// </summary>
        /// <param name="req"><see cref="SearchGameServerSessionsRequest"/></param>
        /// <returns><see cref="SearchGameServerSessionsResponse"/></returns>
        public SearchGameServerSessionsResponse SearchGameServerSessionsSync(SearchGameServerSessionsRequest req)
        {
             JsonResponseModel<SearchGameServerSessionsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SearchGameServerSessions");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SearchGameServerSessionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（SetServerWeight）用于设置服务器权重。
        /// </summary>
        /// <param name="req"><see cref="SetServerWeightRequest"/></param>
        /// <returns><see cref="SetServerWeightResponse"/></returns>
        public async Task<SetServerWeightResponse> SetServerWeight(SetServerWeightRequest req)
        {
             JsonResponseModel<SetServerWeightResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SetServerWeight");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SetServerWeightResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（SetServerWeight）用于设置服务器权重。
        /// </summary>
        /// <param name="req"><see cref="SetServerWeightRequest"/></param>
        /// <returns><see cref="SetServerWeightResponse"/></returns>
        public SetServerWeightResponse SetServerWeightSync(SetServerWeightRequest req)
        {
             JsonResponseModel<SetServerWeightResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SetServerWeight");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SetServerWeightResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（StartFleetActions）用于启用服务器舰队自动扩缩容。
        /// </summary>
        /// <param name="req"><see cref="StartFleetActionsRequest"/></param>
        /// <returns><see cref="StartFleetActionsResponse"/></returns>
        public async Task<StartFleetActionsResponse> StartFleetActions(StartFleetActionsRequest req)
        {
             JsonResponseModel<StartFleetActionsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "StartFleetActions");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StartFleetActionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（StartFleetActions）用于启用服务器舰队自动扩缩容。
        /// </summary>
        /// <param name="req"><see cref="StartFleetActionsRequest"/></param>
        /// <returns><see cref="StartFleetActionsResponse"/></returns>
        public StartFleetActionsResponse StartFleetActionsSync(StartFleetActionsRequest req)
        {
             JsonResponseModel<StartFleetActionsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "StartFleetActions");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StartFleetActionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（StartGameServerSessionPlacement）用于开始放置游戏服务器会话。
        /// </summary>
        /// <param name="req"><see cref="StartGameServerSessionPlacementRequest"/></param>
        /// <returns><see cref="StartGameServerSessionPlacementResponse"/></returns>
        public async Task<StartGameServerSessionPlacementResponse> StartGameServerSessionPlacement(StartGameServerSessionPlacementRequest req)
        {
             JsonResponseModel<StartGameServerSessionPlacementResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "StartGameServerSessionPlacement");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StartGameServerSessionPlacementResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（StartGameServerSessionPlacement）用于开始放置游戏服务器会话。
        /// </summary>
        /// <param name="req"><see cref="StartGameServerSessionPlacementRequest"/></param>
        /// <returns><see cref="StartGameServerSessionPlacementResponse"/></returns>
        public StartGameServerSessionPlacementResponse StartGameServerSessionPlacementSync(StartGameServerSessionPlacementRequest req)
        {
             JsonResponseModel<StartGameServerSessionPlacementResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "StartGameServerSessionPlacement");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StartGameServerSessionPlacementResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（StopFleetActions）用于停止服务器舰队自动扩缩容，改为手动扩缩容。
        /// </summary>
        /// <param name="req"><see cref="StopFleetActionsRequest"/></param>
        /// <returns><see cref="StopFleetActionsResponse"/></returns>
        public async Task<StopFleetActionsResponse> StopFleetActions(StopFleetActionsRequest req)
        {
             JsonResponseModel<StopFleetActionsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "StopFleetActions");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StopFleetActionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（StopFleetActions）用于停止服务器舰队自动扩缩容，改为手动扩缩容。
        /// </summary>
        /// <param name="req"><see cref="StopFleetActionsRequest"/></param>
        /// <returns><see cref="StopFleetActionsResponse"/></returns>
        public StopFleetActionsResponse StopFleetActionsSync(StopFleetActionsRequest req)
        {
             JsonResponseModel<StopFleetActionsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "StopFleetActions");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StopFleetActionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（StopGameServerSessionPlacement）用于停止放置游戏服务器会话。
        /// </summary>
        /// <param name="req"><see cref="StopGameServerSessionPlacementRequest"/></param>
        /// <returns><see cref="StopGameServerSessionPlacementResponse"/></returns>
        public async Task<StopGameServerSessionPlacementResponse> StopGameServerSessionPlacement(StopGameServerSessionPlacementRequest req)
        {
             JsonResponseModel<StopGameServerSessionPlacementResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "StopGameServerSessionPlacement");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StopGameServerSessionPlacementResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（StopGameServerSessionPlacement）用于停止放置游戏服务器会话。
        /// </summary>
        /// <param name="req"><see cref="StopGameServerSessionPlacementRequest"/></param>
        /// <returns><see cref="StopGameServerSessionPlacementResponse"/></returns>
        public StopGameServerSessionPlacementResponse StopGameServerSessionPlacementSync(StopGameServerSessionPlacementRequest req)
        {
             JsonResponseModel<StopGameServerSessionPlacementResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "StopGameServerSessionPlacement");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StopGameServerSessionPlacementResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（UpdateAlias）用于更新别名的属性。
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
        /// 本接口（UpdateAlias）用于更新别名的属性。
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
        /// 本接口（UpdateAsset）用于修改生成包信息。
        /// </summary>
        /// <param name="req"><see cref="UpdateAssetRequest"/></param>
        /// <returns><see cref="UpdateAssetResponse"/></returns>
        public async Task<UpdateAssetResponse> UpdateAsset(UpdateAssetRequest req)
        {
             JsonResponseModel<UpdateAssetResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateAsset");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateAssetResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（UpdateAsset）用于修改生成包信息。
        /// </summary>
        /// <param name="req"><see cref="UpdateAssetRequest"/></param>
        /// <returns><see cref="UpdateAssetResponse"/></returns>
        public UpdateAssetResponse UpdateAssetSync(UpdateAssetRequest req)
        {
             JsonResponseModel<UpdateAssetResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateAsset");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateAssetResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（UpdateBucketAccelerateOpt）用于开启cos全球加速。
        /// </summary>
        /// <param name="req"><see cref="UpdateBucketAccelerateOptRequest"/></param>
        /// <returns><see cref="UpdateBucketAccelerateOptResponse"/></returns>
        public async Task<UpdateBucketAccelerateOptResponse> UpdateBucketAccelerateOpt(UpdateBucketAccelerateOptRequest req)
        {
             JsonResponseModel<UpdateBucketAccelerateOptResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateBucketAccelerateOpt");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateBucketAccelerateOptResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（UpdateBucketAccelerateOpt）用于开启cos全球加速。
        /// </summary>
        /// <param name="req"><see cref="UpdateBucketAccelerateOptRequest"/></param>
        /// <returns><see cref="UpdateBucketAccelerateOptResponse"/></returns>
        public UpdateBucketAccelerateOptResponse UpdateBucketAccelerateOptSync(UpdateBucketAccelerateOptRequest req)
        {
             JsonResponseModel<UpdateBucketAccelerateOptResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateBucketAccelerateOpt");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateBucketAccelerateOptResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（UpdateBucketCORSOpt）用于设置cos跨域访问。
        /// </summary>
        /// <param name="req"><see cref="UpdateBucketCORSOptRequest"/></param>
        /// <returns><see cref="UpdateBucketCORSOptResponse"/></returns>
        public async Task<UpdateBucketCORSOptResponse> UpdateBucketCORSOpt(UpdateBucketCORSOptRequest req)
        {
             JsonResponseModel<UpdateBucketCORSOptResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateBucketCORSOpt");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateBucketCORSOptResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（UpdateBucketCORSOpt）用于设置cos跨域访问。
        /// </summary>
        /// <param name="req"><see cref="UpdateBucketCORSOptRequest"/></param>
        /// <returns><see cref="UpdateBucketCORSOptResponse"/></returns>
        public UpdateBucketCORSOptResponse UpdateBucketCORSOptSync(UpdateBucketCORSOptRequest req)
        {
             JsonResponseModel<UpdateBucketCORSOptResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateBucketCORSOpt");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateBucketCORSOptResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（UpdateFleetAttributes）用于更新服务器舰队属性。
        /// </summary>
        /// <param name="req"><see cref="UpdateFleetAttributesRequest"/></param>
        /// <returns><see cref="UpdateFleetAttributesResponse"/></returns>
        public async Task<UpdateFleetAttributesResponse> UpdateFleetAttributes(UpdateFleetAttributesRequest req)
        {
             JsonResponseModel<UpdateFleetAttributesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateFleetAttributes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateFleetAttributesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（UpdateFleetAttributes）用于更新服务器舰队属性。
        /// </summary>
        /// <param name="req"><see cref="UpdateFleetAttributesRequest"/></param>
        /// <returns><see cref="UpdateFleetAttributesResponse"/></returns>
        public UpdateFleetAttributesResponse UpdateFleetAttributesSync(UpdateFleetAttributesRequest req)
        {
             JsonResponseModel<UpdateFleetAttributesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateFleetAttributes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateFleetAttributesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（UpdateFleetCapacity）用于更新服务器舰队容量配置。
        /// </summary>
        /// <param name="req"><see cref="UpdateFleetCapacityRequest"/></param>
        /// <returns><see cref="UpdateFleetCapacityResponse"/></returns>
        public async Task<UpdateFleetCapacityResponse> UpdateFleetCapacity(UpdateFleetCapacityRequest req)
        {
             JsonResponseModel<UpdateFleetCapacityResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateFleetCapacity");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateFleetCapacityResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（UpdateFleetCapacity）用于更新服务器舰队容量配置。
        /// </summary>
        /// <param name="req"><see cref="UpdateFleetCapacityRequest"/></param>
        /// <returns><see cref="UpdateFleetCapacityResponse"/></returns>
        public UpdateFleetCapacityResponse UpdateFleetCapacitySync(UpdateFleetCapacityRequest req)
        {
             JsonResponseModel<UpdateFleetCapacityResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateFleetCapacity");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateFleetCapacityResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（UpdateFleetName）用于更新服务器舰队名称。
        /// </summary>
        /// <param name="req"><see cref="UpdateFleetNameRequest"/></param>
        /// <returns><see cref="UpdateFleetNameResponse"/></returns>
        public async Task<UpdateFleetNameResponse> UpdateFleetName(UpdateFleetNameRequest req)
        {
             JsonResponseModel<UpdateFleetNameResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateFleetName");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateFleetNameResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（UpdateFleetName）用于更新服务器舰队名称。
        /// </summary>
        /// <param name="req"><see cref="UpdateFleetNameRequest"/></param>
        /// <returns><see cref="UpdateFleetNameResponse"/></returns>
        public UpdateFleetNameResponse UpdateFleetNameSync(UpdateFleetNameRequest req)
        {
             JsonResponseModel<UpdateFleetNameResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateFleetName");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateFleetNameResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（UpdateFleetPortSettings）用于更新服务器舰队安全组。
        /// </summary>
        /// <param name="req"><see cref="UpdateFleetPortSettingsRequest"/></param>
        /// <returns><see cref="UpdateFleetPortSettingsResponse"/></returns>
        public async Task<UpdateFleetPortSettingsResponse> UpdateFleetPortSettings(UpdateFleetPortSettingsRequest req)
        {
             JsonResponseModel<UpdateFleetPortSettingsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateFleetPortSettings");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateFleetPortSettingsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（UpdateFleetPortSettings）用于更新服务器舰队安全组。
        /// </summary>
        /// <param name="req"><see cref="UpdateFleetPortSettingsRequest"/></param>
        /// <returns><see cref="UpdateFleetPortSettingsResponse"/></returns>
        public UpdateFleetPortSettingsResponse UpdateFleetPortSettingsSync(UpdateFleetPortSettingsRequest req)
        {
             JsonResponseModel<UpdateFleetPortSettingsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateFleetPortSettings");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateFleetPortSettingsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（UpdateGameServerSession）用于更新游戏服务器会话。
        /// </summary>
        /// <param name="req"><see cref="UpdateGameServerSessionRequest"/></param>
        /// <returns><see cref="UpdateGameServerSessionResponse"/></returns>
        public async Task<UpdateGameServerSessionResponse> UpdateGameServerSession(UpdateGameServerSessionRequest req)
        {
             JsonResponseModel<UpdateGameServerSessionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateGameServerSession");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateGameServerSessionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（UpdateGameServerSession）用于更新游戏服务器会话。
        /// </summary>
        /// <param name="req"><see cref="UpdateGameServerSessionRequest"/></param>
        /// <returns><see cref="UpdateGameServerSessionResponse"/></returns>
        public UpdateGameServerSessionResponse UpdateGameServerSessionSync(UpdateGameServerSessionRequest req)
        {
             JsonResponseModel<UpdateGameServerSessionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateGameServerSession");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateGameServerSessionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（UpdateGameServerSessionQueue）用于修改游戏服务器会话队列。
        /// </summary>
        /// <param name="req"><see cref="UpdateGameServerSessionQueueRequest"/></param>
        /// <returns><see cref="UpdateGameServerSessionQueueResponse"/></returns>
        public async Task<UpdateGameServerSessionQueueResponse> UpdateGameServerSessionQueue(UpdateGameServerSessionQueueRequest req)
        {
             JsonResponseModel<UpdateGameServerSessionQueueResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateGameServerSessionQueue");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateGameServerSessionQueueResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（UpdateGameServerSessionQueue）用于修改游戏服务器会话队列。
        /// </summary>
        /// <param name="req"><see cref="UpdateGameServerSessionQueueRequest"/></param>
        /// <returns><see cref="UpdateGameServerSessionQueueResponse"/></returns>
        public UpdateGameServerSessionQueueResponse UpdateGameServerSessionQueueSync(UpdateGameServerSessionQueueRequest req)
        {
             JsonResponseModel<UpdateGameServerSessionQueueResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateGameServerSessionQueue");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateGameServerSessionQueueResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（UpdateRuntimeConfiguration）用于更新服务器舰队配置。
        /// </summary>
        /// <param name="req"><see cref="UpdateRuntimeConfigurationRequest"/></param>
        /// <returns><see cref="UpdateRuntimeConfigurationResponse"/></returns>
        public async Task<UpdateRuntimeConfigurationResponse> UpdateRuntimeConfiguration(UpdateRuntimeConfigurationRequest req)
        {
             JsonResponseModel<UpdateRuntimeConfigurationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateRuntimeConfiguration");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateRuntimeConfigurationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（UpdateRuntimeConfiguration）用于更新服务器舰队配置。
        /// </summary>
        /// <param name="req"><see cref="UpdateRuntimeConfigurationRequest"/></param>
        /// <returns><see cref="UpdateRuntimeConfigurationResponse"/></returns>
        public UpdateRuntimeConfigurationResponse UpdateRuntimeConfigurationSync(UpdateRuntimeConfigurationRequest req)
        {
             JsonResponseModel<UpdateRuntimeConfigurationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateRuntimeConfiguration");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateRuntimeConfigurationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
