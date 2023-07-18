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

namespace TencentCloud.Goosefs.V20220519
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Goosefs.V20220519.Models;

   public class GoosefsClient : AbstractClient{

       private const string endpoint = "goosefs.tencentcloudapi.com";
       private const string version = "2022-05-19";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public GoosefsClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public GoosefsClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 创建数据流通任务,包括从将文件系统的数据上传到存储桶下, 以及从存储桶下载到文件系统里。
        /// </summary>
        /// <param name="req"><see cref="CreateDataRepositoryTaskRequest"/></param>
        /// <returns><see cref="CreateDataRepositoryTaskResponse"/></returns>
        public async Task<CreateDataRepositoryTaskResponse> CreateDataRepositoryTask(CreateDataRepositoryTaskRequest req)
        {
             JsonResponseModel<CreateDataRepositoryTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateDataRepositoryTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDataRepositoryTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建数据流通任务,包括从将文件系统的数据上传到存储桶下, 以及从存储桶下载到文件系统里。
        /// </summary>
        /// <param name="req"><see cref="CreateDataRepositoryTaskRequest"/></param>
        /// <returns><see cref="CreateDataRepositoryTaskResponse"/></returns>
        public CreateDataRepositoryTaskResponse CreateDataRepositoryTaskSync(CreateDataRepositoryTaskRequest req)
        {
             JsonResponseModel<CreateDataRepositoryTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateDataRepositoryTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDataRepositoryTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询GooseFS集群客户端凭证
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterClientTokenRequest"/></param>
        /// <returns><see cref="DescribeClusterClientTokenResponse"/></returns>
        public async Task<DescribeClusterClientTokenResponse> DescribeClusterClientToken(DescribeClusterClientTokenRequest req)
        {
             JsonResponseModel<DescribeClusterClientTokenResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeClusterClientToken");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClusterClientTokenResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询GooseFS集群客户端凭证
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterClientTokenRequest"/></param>
        /// <returns><see cref="DescribeClusterClientTokenResponse"/></returns>
        public DescribeClusterClientTokenResponse DescribeClusterClientTokenSync(DescribeClusterClientTokenRequest req)
        {
             JsonResponseModel<DescribeClusterClientTokenResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeClusterClientToken");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClusterClientTokenResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询GooseFS集群角色凭证
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterRoleTokenRequest"/></param>
        /// <returns><see cref="DescribeClusterRoleTokenResponse"/></returns>
        public async Task<DescribeClusterRoleTokenResponse> DescribeClusterRoleToken(DescribeClusterRoleTokenRequest req)
        {
             JsonResponseModel<DescribeClusterRoleTokenResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeClusterRoleToken");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClusterRoleTokenResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询GooseFS集群角色凭证
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterRoleTokenRequest"/></param>
        /// <returns><see cref="DescribeClusterRoleTokenResponse"/></returns>
        public DescribeClusterRoleTokenResponse DescribeClusterRoleTokenSync(DescribeClusterRoleTokenRequest req)
        {
             JsonResponseModel<DescribeClusterRoleTokenResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeClusterRoleToken");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClusterRoleTokenResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询GooseFS集群角色
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterRolesRequest"/></param>
        /// <returns><see cref="DescribeClusterRolesResponse"/></returns>
        public async Task<DescribeClusterRolesResponse> DescribeClusterRoles(DescribeClusterRolesRequest req)
        {
             JsonResponseModel<DescribeClusterRolesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeClusterRoles");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClusterRolesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询GooseFS集群角色
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterRolesRequest"/></param>
        /// <returns><see cref="DescribeClusterRolesResponse"/></returns>
        public DescribeClusterRolesResponse DescribeClusterRolesSync(DescribeClusterRolesRequest req)
        {
             JsonResponseModel<DescribeClusterRolesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeClusterRoles");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClusterRolesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取数据流通任务实时状态，用作客户端控制
        /// </summary>
        /// <param name="req"><see cref="DescribeDataRepositoryTaskStatusRequest"/></param>
        /// <returns><see cref="DescribeDataRepositoryTaskStatusResponse"/></returns>
        public async Task<DescribeDataRepositoryTaskStatusResponse> DescribeDataRepositoryTaskStatus(DescribeDataRepositoryTaskStatusRequest req)
        {
             JsonResponseModel<DescribeDataRepositoryTaskStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDataRepositoryTaskStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDataRepositoryTaskStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取数据流通任务实时状态，用作客户端控制
        /// </summary>
        /// <param name="req"><see cref="DescribeDataRepositoryTaskStatusRequest"/></param>
        /// <returns><see cref="DescribeDataRepositoryTaskStatusResponse"/></returns>
        public DescribeDataRepositoryTaskStatusResponse DescribeDataRepositoryTaskStatusSync(DescribeDataRepositoryTaskStatusRequest req)
        {
             JsonResponseModel<DescribeDataRepositoryTaskStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDataRepositoryTaskStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDataRepositoryTaskStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
