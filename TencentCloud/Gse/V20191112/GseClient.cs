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
        /// 本接口（AttachCcnInstances）用于关联云联网实例
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
        /// 本接口（AttachCcnInstances）用于关联云联网实例
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
        /// 本接口（CreateAlias）用于创建别名
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
        /// 本接口（CreateAlias）用于创建别名
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
        /// 通过获取上传cos的临时秘钥，将文件上传至cos，然后将生成包的zip名称下发给[CreateAsset](https://tcloud-dev.oa.com/document/product/1139/46582?!preview&!document=1)完成接口创建。上传文件至 cos支持俩种方式：
        /// 
        ///  a.获取预签名， cos 调用上传 （小的文件 5G以内， 前端 1G 以内）  
        ///   1). [GetUploadCredentials](https://tcloud-dev.oa.com/document/product/1139/39889?!preview&!document=1)  
        ///   2). 使用 cos API 上传 （cos sdk ）  
        ///  b.新的方式，适用场景，（大文件）  
        ///   1). [GetUploadCredentials](https://tcloud-dev.oa.com/document/product/1139/39889?!preview&!document=1) （获取上传 bucket  第一次调用需要，后续可以不用调用 ）  
        ///   2). GetUploadFederationToken（获取临时密钥）  
        ///   3). 分块上传 API （cos sdk 有集成 upload_file）  
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
        /// 通过获取上传cos的临时秘钥，将文件上传至cos，然后将生成包的zip名称下发给[CreateAsset](https://tcloud-dev.oa.com/document/product/1139/46582?!preview&!document=1)完成接口创建。上传文件至 cos支持俩种方式：
        /// 
        ///  a.获取预签名， cos 调用上传 （小的文件 5G以内， 前端 1G 以内）  
        ///   1). [GetUploadCredentials](https://tcloud-dev.oa.com/document/product/1139/39889?!preview&!document=1)  
        ///   2). 使用 cos API 上传 （cos sdk ）  
        ///  b.新的方式，适用场景，（大文件）  
        ///   1). [GetUploadCredentials](https://tcloud-dev.oa.com/document/product/1139/39889?!preview&!document=1) （获取上传 bucket  第一次调用需要，后续可以不用调用 ）  
        ///   2). GetUploadFederationToken（获取临时密钥）  
        ///   3). 分块上传 API （cos sdk 有集成 upload_file）  
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
        /// 本接口（CreateGameServerSession）用于创建游戏服务会话
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
        /// 本接口（CreateGameServerSession）用于创建游戏服务会话
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
        /// 本接口（DeleteAlias）用于删除别名
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
        /// 本接口（DeleteAlias）用于删除别名
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
        /// 本接口（DeleteAsset）用于删除生成包
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
        /// 本接口（DeleteAsset）用于删除生成包
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
        /// 本接口（DeleteFleet）用于删除服务器舰队
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
        /// 本接口（DeleteFleet）用于删除服务器舰队
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
        /// 本接口（DeleteScalingPolicy）用于删除扩缩容配置
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
        /// 本接口（DeleteScalingPolicy）用于删除扩缩容配置
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
        /// 本接口（DescribeAlias）用于获取别名详情
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
        /// 本接口（DescribeAlias）用于获取别名详情
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
        /// 本接口（DescribeAsset）获取生成包信息
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
        /// 本接口（DescribeAsset）获取生成包信息
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
        /// 本接口（DescribeAssets）用于获取生成包列表
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
        /// 本接口（DescribeAssets）用于获取生成包列表
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
        /// 本接口（DescribeCcnInstances）用于查询云联网实例
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
        /// 本接口（DescribeCcnInstances）用于查询云联网实例
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
        /// 本接口（DescribeFleetAttributes）用于查询服务器舰队属性
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
        /// 本接口（DescribeFleetAttributes）用于查询服务器舰队属性
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
        /// 本接口（DescribeFleetEvents）用于查询部署服务器舰队相关的事件列表
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
        /// 本接口（DescribeFleetEvents）用于查询部署服务器舰队相关的事件列表
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
        /// 本接口（DescribeFleetPortSettings）用于获取服务器舰队安全组信息
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
        /// 本接口（DescribeFleetPortSettings）用于获取服务器舰队安全组信息
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
        /// 本接口（DescribeFleetUtilization）用于查询服务器舰队的利用率信息
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
        /// 本接口（DescribeFleetUtilization）用于查询服务器舰队的利用率信息
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
        /// 本接口（DescribeGameServerSessionDetails）用于查询游戏服务器会话详情列表
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
        /// 本接口（DescribeGameServerSessionDetails）用于查询游戏服务器会话详情列表
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
        /// 本接口（DescribeGameServerSessionPlacement）用于查询游戏服务器会话的放置
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
        /// 本接口（DescribeGameServerSessionPlacement）用于查询游戏服务器会话的放置
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
        /// 本接口（DescribeGameServerSessionQueues）用于查询游戏服务器会话队列
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
        /// 本接口（DescribeGameServerSessionQueues）用于查询游戏服务器会话队列
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
        /// 本接口（DescribeGameServerSessions）用于查询游戏服务器会话列表
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
        /// 本接口（DescribeGameServerSessions）用于查询游戏服务器会话列表
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
        /// 本接口（DescribeInstanceTypes）用于获取服务器实例类型列表
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
        /// 本接口（DescribeInstanceTypes）用于获取服务器实例类型列表
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
        /// 本接口（DescribeInstances）用于查询服务器实例列表
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
        /// 本接口（DescribeInstances）用于查询服务器实例列表
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
        /// 本接口（DescribePlayerSessions）用于获取玩家会话列表
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
        /// 本接口（DescribePlayerSessions）用于获取玩家会话列表
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
        /// 本接口（DescribeRuntimeConfiguration）用于获取服务器舰队运行配置
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
        /// 本接口（DescribeRuntimeConfiguration）用于获取服务器舰队运行配置
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
        /// 本接口（DescribeScalingPolicies）用于查询服务部署的动态扩缩容配置
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
        /// 本接口（DescribeScalingPolicies）用于查询服务部署的动态扩缩容配置
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
        /// 本接口（DescribeUserQuota）获取用户单个模块配额
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
        /// 本接口（DescribeUserQuota）获取用户单个模块配额
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
        /// 本接口（DetachCcnInstances）用于解关联云联网实例
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
        /// 本接口（DetachCcnInstances）用于解关联云联网实例
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
        /// 本接口（GetGameServerSessionLogUrl）用于获取游戏服务器会话的日志URL
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
        /// 本接口（GetGameServerSessionLogUrl）用于获取游戏服务器会话的日志URL
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
        /// 本接口（GetInstanceAccess）用于获取实例登录所需要的凭据
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
        /// 本接口（GetInstanceAccess）用于获取实例登录所需要的凭据
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
        /// 详细描述：通过[GetUploadCredentials](https://tcloud-dev.oa.com/document/product/1139/39889?!preview&!document=1)接口获取临时秘钥后，使用http put请求将数据上传至cos，然后将生成的生成包zip名称下发给[CreateAsset](https://tcloud-dev.oa.com/document/product/1139/46582?!preview&!document=1)接口进行asset创建
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
        /// 详细描述：通过[GetUploadCredentials](https://tcloud-dev.oa.com/document/product/1139/39889?!preview&!document=1)接口获取临时秘钥后，使用http put请求将数据上传至cos，然后将生成的生成包zip名称下发给[CreateAsset](https://tcloud-dev.oa.com/document/product/1139/46582?!preview&!document=1)接口进行asset创建
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
        /// 本接口（GetUploadFederationToken）用于 获取生成包上传所需要的临时密钥
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
        /// 本接口（GetUploadFederationToken）用于 获取生成包上传所需要的临时密钥
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
        /// 本接口（JoinGameServerSession）用于加入游戏服务器会话
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
        /// 本接口（JoinGameServerSession）用于加入游戏服务器会话
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
        /// 本接口（ListAliases）用于检索帐户下的所有别名
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
        /// 本接口（ListAliases）用于检索帐户下的所有别名
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
        /// 本接口（ListFleets）用于获取服务器舰队列表
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
        /// 本接口（ListFleets）用于获取服务器舰队列表
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
        /// 本接口（PutScalingPolicy）用于设置动态扩缩容配置
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
        /// 本接口（PutScalingPolicy）用于设置动态扩缩容配置
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
        /// 本接口（ResolveAlias）用于获取别名当前指向的fleetId
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
        /// 本接口（ResolveAlias）用于获取别名当前指向的fleetId
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
        /// 本接口（SearchGameServerSessions）用于搜索游戏服务器会话列表
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
        /// 本接口（SearchGameServerSessions）用于搜索游戏服务器会话列表
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
        /// 设置服务器权重
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
        /// 设置服务器权重
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
        /// 本接口（StartFleetActions）用于启用服务器舰队自动扩缩容
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
        /// 本接口（StartFleetActions）用于启用服务器舰队自动扩缩容
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
        /// 本接口（StartGameServerSessionPlacement）用于开始放置游戏服务器会话
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
        /// 本接口（StartGameServerSessionPlacement）用于开始放置游戏服务器会话
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
        /// 本接口（StartMatchPlacement）用于开始匹配放置游戏服务器会话
        /// </summary>
        /// <param name="req"><see cref="StartMatchPlacementRequest"/></param>
        /// <returns><see cref="StartMatchPlacementResponse"/></returns>
        public async Task<StartMatchPlacementResponse> StartMatchPlacement(StartMatchPlacementRequest req)
        {
             JsonResponseModel<StartMatchPlacementResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "StartMatchPlacement");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StartMatchPlacementResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（StartMatchPlacement）用于开始匹配放置游戏服务器会话
        /// </summary>
        /// <param name="req"><see cref="StartMatchPlacementRequest"/></param>
        /// <returns><see cref="StartMatchPlacementResponse"/></returns>
        public StartMatchPlacementResponse StartMatchPlacementSync(StartMatchPlacementRequest req)
        {
             JsonResponseModel<StartMatchPlacementResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "StartMatchPlacement");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StartMatchPlacementResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（StopFleetActions）用于停止服务器舰队自动扩缩容，改为手动扩缩容
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
        /// 本接口（StopFleetActions）用于停止服务器舰队自动扩缩容，改为手动扩缩容
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
        /// 本接口（StopGameServerSessionPlacement）用于停止放置游戏服务器会话
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
        /// 本接口（StopGameServerSessionPlacement）用于停止放置游戏服务器会话
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
        /// 本接口（UpdateAlias）用于更新别名的属性
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
        /// 本接口（UpdateAlias）用于更新别名的属性
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
        /// 本接口（UpdateAsset）用于修改生成包信息
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
        /// 本接口（UpdateAsset）用于修改生成包信息
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
        /// 本接口（UpdateFleetAttributes）用于更新服务器舰队属性
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
        /// 本接口（UpdateFleetAttributes）用于更新服务器舰队属性
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
        /// 本接口（UpdateFleetPortSettings）用于更新服务器舰队安全组
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
        /// 本接口（UpdateFleetPortSettings）用于更新服务器舰队安全组
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
        /// 本接口（UpdateGameServerSession）用于更新游戏服务器会话
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
        /// 本接口（UpdateGameServerSession）用于更新游戏服务器会话
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
        /// 本接口（UpdateRuntimeConfiguration）用于更新服务器舰队配置
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
        /// 本接口（UpdateRuntimeConfiguration）用于更新服务器舰队配置
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
