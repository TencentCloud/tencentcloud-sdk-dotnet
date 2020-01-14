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

namespace TencentCloud.Msp.V20180319
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Msp.V20180319.Models;

   public class MspClient : AbstractClient{

       private const string endpoint = "msp.tencentcloudapi.com";
       private const string version = "2018-03-19";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public MspClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public MspClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 取消注册迁移任务
        /// </summary>
        /// <param name="req"><see cref="DeregisterMigrationTaskRequest"/></param>
        /// <returns><see cref="DeregisterMigrationTaskResponse"/></returns>
        public async Task<DeregisterMigrationTaskResponse> DeregisterMigrationTask(DeregisterMigrationTaskRequest req)
        {
             JsonResponseModel<DeregisterMigrationTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeregisterMigrationTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeregisterMigrationTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DeregisterMigrationTask接口的同步版本，取消注册迁移任务
        /// </summary>
        /// <param name="req">参考<see cref="DeregisterMigrationTaskRequest"/></param>
        /// <returns>参考<see cref="DeregisterMigrationTaskResponse"/>实例</returns>
        public DeregisterMigrationTaskResponse DeregisterMigrationTaskSync(DeregisterMigrationTaskRequest req)
        {
             JsonResponseModel<DeregisterMigrationTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeregisterMigrationTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeregisterMigrationTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取指定迁移任务详情
        /// </summary>
        /// <param name="req"><see cref="DescribeMigrationTaskRequest"/></param>
        /// <returns><see cref="DescribeMigrationTaskResponse"/></returns>
        public async Task<DescribeMigrationTaskResponse> DescribeMigrationTask(DescribeMigrationTaskRequest req)
        {
             JsonResponseModel<DescribeMigrationTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeMigrationTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMigrationTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeMigrationTask接口的同步版本，获取指定迁移任务详情
        /// </summary>
        /// <param name="req">参考<see cref="DescribeMigrationTaskRequest"/></param>
        /// <returns>参考<see cref="DescribeMigrationTaskResponse"/>实例</returns>
        public DescribeMigrationTaskResponse DescribeMigrationTaskSync(DescribeMigrationTaskRequest req)
        {
             JsonResponseModel<DescribeMigrationTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeMigrationTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMigrationTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取迁移项目名称列表
        /// </summary>
        /// <param name="req"><see cref="ListMigrationProjectRequest"/></param>
        /// <returns><see cref="ListMigrationProjectResponse"/></returns>
        public async Task<ListMigrationProjectResponse> ListMigrationProject(ListMigrationProjectRequest req)
        {
             JsonResponseModel<ListMigrationProjectResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ListMigrationProject");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListMigrationProjectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ListMigrationProject接口的同步版本，获取迁移项目名称列表
        /// </summary>
        /// <param name="req">参考<see cref="ListMigrationProjectRequest"/></param>
        /// <returns>参考<see cref="ListMigrationProjectResponse"/>实例</returns>
        public ListMigrationProjectResponse ListMigrationProjectSync(ListMigrationProjectRequest req)
        {
             JsonResponseModel<ListMigrationProjectResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ListMigrationProject");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListMigrationProjectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取迁移任务列表
        /// </summary>
        /// <param name="req"><see cref="ListMigrationTaskRequest"/></param>
        /// <returns><see cref="ListMigrationTaskResponse"/></returns>
        public async Task<ListMigrationTaskResponse> ListMigrationTask(ListMigrationTaskRequest req)
        {
             JsonResponseModel<ListMigrationTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ListMigrationTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListMigrationTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ListMigrationTask接口的同步版本，获取迁移任务列表
        /// </summary>
        /// <param name="req">参考<see cref="ListMigrationTaskRequest"/></param>
        /// <returns>参考<see cref="ListMigrationTaskResponse"/>实例</returns>
        public ListMigrationTaskResponse ListMigrationTaskSync(ListMigrationTaskRequest req)
        {
             JsonResponseModel<ListMigrationTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ListMigrationTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListMigrationTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更改迁移任务所属项目
        /// </summary>
        /// <param name="req"><see cref="ModifyMigrationTaskBelongToProjectRequest"/></param>
        /// <returns><see cref="ModifyMigrationTaskBelongToProjectResponse"/></returns>
        public async Task<ModifyMigrationTaskBelongToProjectResponse> ModifyMigrationTaskBelongToProject(ModifyMigrationTaskBelongToProjectRequest req)
        {
             JsonResponseModel<ModifyMigrationTaskBelongToProjectResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyMigrationTaskBelongToProject");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyMigrationTaskBelongToProjectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ModifyMigrationTaskBelongToProject接口的同步版本，更改迁移任务所属项目
        /// </summary>
        /// <param name="req">参考<see cref="ModifyMigrationTaskBelongToProjectRequest"/></param>
        /// <returns>参考<see cref="ModifyMigrationTaskBelongToProjectResponse"/>实例</returns>
        public ModifyMigrationTaskBelongToProjectResponse ModifyMigrationTaskBelongToProjectSync(ModifyMigrationTaskBelongToProjectRequest req)
        {
             JsonResponseModel<ModifyMigrationTaskBelongToProjectResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyMigrationTaskBelongToProject");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyMigrationTaskBelongToProjectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新迁移任务状态
        /// </summary>
        /// <param name="req"><see cref="ModifyMigrationTaskStatusRequest"/></param>
        /// <returns><see cref="ModifyMigrationTaskStatusResponse"/></returns>
        public async Task<ModifyMigrationTaskStatusResponse> ModifyMigrationTaskStatus(ModifyMigrationTaskStatusRequest req)
        {
             JsonResponseModel<ModifyMigrationTaskStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyMigrationTaskStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyMigrationTaskStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ModifyMigrationTaskStatus接口的同步版本，更新迁移任务状态
        /// </summary>
        /// <param name="req">参考<see cref="ModifyMigrationTaskStatusRequest"/></param>
        /// <returns>参考<see cref="ModifyMigrationTaskStatusResponse"/>实例</returns>
        public ModifyMigrationTaskStatusResponse ModifyMigrationTaskStatusSync(ModifyMigrationTaskStatusRequest req)
        {
             JsonResponseModel<ModifyMigrationTaskStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyMigrationTaskStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyMigrationTaskStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 注册迁移任务
        /// </summary>
        /// <param name="req"><see cref="RegisterMigrationTaskRequest"/></param>
        /// <returns><see cref="RegisterMigrationTaskResponse"/></returns>
        public async Task<RegisterMigrationTaskResponse> RegisterMigrationTask(RegisterMigrationTaskRequest req)
        {
             JsonResponseModel<RegisterMigrationTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RegisterMigrationTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RegisterMigrationTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// RegisterMigrationTask接口的同步版本，注册迁移任务
        /// </summary>
        /// <param name="req">参考<see cref="RegisterMigrationTaskRequest"/></param>
        /// <returns>参考<see cref="RegisterMigrationTaskResponse"/>实例</returns>
        public RegisterMigrationTaskResponse RegisterMigrationTaskSync(RegisterMigrationTaskRequest req)
        {
             JsonResponseModel<RegisterMigrationTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RegisterMigrationTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RegisterMigrationTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
