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

namespace TencentCloud.Tcbr.V20220217
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Tcbr.V20220217.Models;

   public class TcbrClient : AbstractClient{

       private const string endpoint = "tcbr.tencentcloudapi.com";
       private const string version = "2022-02-17";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public TcbrClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public TcbrClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 创建云托管环境，并开通资源。
        /// </summary>
        /// <param name="req"><see cref="CreateCloudRunEnvRequest"/></param>
        /// <returns><see cref="CreateCloudRunEnvResponse"/></returns>
        public async Task<CreateCloudRunEnvResponse> CreateCloudRunEnv(CreateCloudRunEnvRequest req)
        {
             JsonResponseModel<CreateCloudRunEnvResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateCloudRunEnv");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCloudRunEnvResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建云托管环境，并开通资源。
        /// </summary>
        /// <param name="req"><see cref="CreateCloudRunEnvRequest"/></param>
        /// <returns><see cref="CreateCloudRunEnvResponse"/></returns>
        public CreateCloudRunEnvResponse CreateCloudRunEnvSync(CreateCloudRunEnvRequest req)
        {
             JsonResponseModel<CreateCloudRunEnvResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateCloudRunEnv");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCloudRunEnvResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建云托管服务接口
        /// </summary>
        /// <param name="req"><see cref="CreateCloudRunServerRequest"/></param>
        /// <returns><see cref="CreateCloudRunServerResponse"/></returns>
        public async Task<CreateCloudRunServerResponse> CreateCloudRunServer(CreateCloudRunServerRequest req)
        {
             JsonResponseModel<CreateCloudRunServerResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateCloudRunServer");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCloudRunServerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建云托管服务接口
        /// </summary>
        /// <param name="req"><see cref="CreateCloudRunServerRequest"/></param>
        /// <returns><see cref="CreateCloudRunServerResponse"/></returns>
        public CreateCloudRunServerResponse CreateCloudRunServerSync(CreateCloudRunServerRequest req)
        {
             JsonResponseModel<CreateCloudRunServerResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateCloudRunServer");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCloudRunServerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取环境列表，含环境下的各个资源信息。尤其是各资源的唯一标识，是请求各资源的关键参数
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudRunEnvsRequest"/></param>
        /// <returns><see cref="DescribeCloudRunEnvsResponse"/></returns>
        public async Task<DescribeCloudRunEnvsResponse> DescribeCloudRunEnvs(DescribeCloudRunEnvsRequest req)
        {
             JsonResponseModel<DescribeCloudRunEnvsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCloudRunEnvs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCloudRunEnvsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取环境列表，含环境下的各个资源信息。尤其是各资源的唯一标识，是请求各资源的关键参数
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudRunEnvsRequest"/></param>
        /// <returns><see cref="DescribeCloudRunEnvsResponse"/></returns>
        public DescribeCloudRunEnvsResponse DescribeCloudRunEnvsSync(DescribeCloudRunEnvsRequest req)
        {
             JsonResponseModel<DescribeCloudRunEnvsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCloudRunEnvs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCloudRunEnvsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询云托管服务详情
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudRunServerDetailRequest"/></param>
        /// <returns><see cref="DescribeCloudRunServerDetailResponse"/></returns>
        public async Task<DescribeCloudRunServerDetailResponse> DescribeCloudRunServerDetail(DescribeCloudRunServerDetailRequest req)
        {
             JsonResponseModel<DescribeCloudRunServerDetailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCloudRunServerDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCloudRunServerDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询云托管服务详情
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudRunServerDetailRequest"/></param>
        /// <returns><see cref="DescribeCloudRunServerDetailResponse"/></returns>
        public DescribeCloudRunServerDetailResponse DescribeCloudRunServerDetailSync(DescribeCloudRunServerDetailRequest req)
        {
             JsonResponseModel<DescribeCloudRunServerDetailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCloudRunServerDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCloudRunServerDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询云托管服务列表接口
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudRunServersRequest"/></param>
        /// <returns><see cref="DescribeCloudRunServersResponse"/></returns>
        public async Task<DescribeCloudRunServersResponse> DescribeCloudRunServers(DescribeCloudRunServersRequest req)
        {
             JsonResponseModel<DescribeCloudRunServersResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCloudRunServers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCloudRunServersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询云托管服务列表接口
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudRunServersRequest"/></param>
        /// <returns><see cref="DescribeCloudRunServersResponse"/></returns>
        public DescribeCloudRunServersResponse DescribeCloudRunServersSync(DescribeCloudRunServersRequest req)
        {
             JsonResponseModel<DescribeCloudRunServersResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCloudRunServers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCloudRunServersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询环境基础信息
        /// </summary>
        /// <param name="req"><see cref="DescribeEnvBaseInfoRequest"/></param>
        /// <returns><see cref="DescribeEnvBaseInfoResponse"/></returns>
        public async Task<DescribeEnvBaseInfoResponse> DescribeEnvBaseInfo(DescribeEnvBaseInfoRequest req)
        {
             JsonResponseModel<DescribeEnvBaseInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeEnvBaseInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEnvBaseInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询环境基础信息
        /// </summary>
        /// <param name="req"><see cref="DescribeEnvBaseInfoRequest"/></param>
        /// <returns><see cref="DescribeEnvBaseInfoResponse"/></returns>
        public DescribeEnvBaseInfoResponse DescribeEnvBaseInfoSync(DescribeEnvBaseInfoRequest req)
        {
             JsonResponseModel<DescribeEnvBaseInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeEnvBaseInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEnvBaseInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询服务管理任务信息
        /// </summary>
        /// <param name="req"><see cref="DescribeServerManageTaskRequest"/></param>
        /// <returns><see cref="DescribeServerManageTaskResponse"/></returns>
        public async Task<DescribeServerManageTaskResponse> DescribeServerManageTask(DescribeServerManageTaskRequest req)
        {
             JsonResponseModel<DescribeServerManageTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeServerManageTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeServerManageTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询服务管理任务信息
        /// </summary>
        /// <param name="req"><see cref="DescribeServerManageTaskRequest"/></param>
        /// <returns><see cref="DescribeServerManageTaskResponse"/></returns>
        public DescribeServerManageTaskResponse DescribeServerManageTaskSync(DescribeServerManageTaskRequest req)
        {
             JsonResponseModel<DescribeServerManageTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeServerManageTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeServerManageTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 操作发布单
        /// </summary>
        /// <param name="req"><see cref="OperateServerManageRequest"/></param>
        /// <returns><see cref="OperateServerManageResponse"/></returns>
        public async Task<OperateServerManageResponse> OperateServerManage(OperateServerManageRequest req)
        {
             JsonResponseModel<OperateServerManageResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "OperateServerManage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<OperateServerManageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 操作发布单
        /// </summary>
        /// <param name="req"><see cref="OperateServerManageRequest"/></param>
        /// <returns><see cref="OperateServerManageResponse"/></returns>
        public OperateServerManageResponse OperateServerManageSync(OperateServerManageRequest req)
        {
             JsonResponseModel<OperateServerManageResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "OperateServerManage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<OperateServerManageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 灰度发布
        /// </summary>
        /// <param name="req"><see cref="ReleaseGrayRequest"/></param>
        /// <returns><see cref="ReleaseGrayResponse"/></returns>
        public async Task<ReleaseGrayResponse> ReleaseGray(ReleaseGrayRequest req)
        {
             JsonResponseModel<ReleaseGrayResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ReleaseGray");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ReleaseGrayResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 灰度发布
        /// </summary>
        /// <param name="req"><see cref="ReleaseGrayRequest"/></param>
        /// <returns><see cref="ReleaseGrayResponse"/></returns>
        public ReleaseGrayResponse ReleaseGraySync(ReleaseGrayRequest req)
        {
             JsonResponseModel<ReleaseGrayResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ReleaseGray");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ReleaseGrayResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新云托管服务
        /// </summary>
        /// <param name="req"><see cref="UpdateCloudRunServerRequest"/></param>
        /// <returns><see cref="UpdateCloudRunServerResponse"/></returns>
        public async Task<UpdateCloudRunServerResponse> UpdateCloudRunServer(UpdateCloudRunServerRequest req)
        {
             JsonResponseModel<UpdateCloudRunServerResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateCloudRunServer");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateCloudRunServerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新云托管服务
        /// </summary>
        /// <param name="req"><see cref="UpdateCloudRunServerRequest"/></param>
        /// <returns><see cref="UpdateCloudRunServerResponse"/></returns>
        public UpdateCloudRunServerResponse UpdateCloudRunServerSync(UpdateCloudRunServerRequest req)
        {
             JsonResponseModel<UpdateCloudRunServerResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateCloudRunServer");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateCloudRunServerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
