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

namespace TencentCloud.Vm.V20200709
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Vm.V20200709.Models;

   public class VmClient : AbstractClient{

       private const string endpoint = "vm.tencentcloudapi.com";
       private const string version = "2020-07-09";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public VmClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public VmClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 取消任务
        /// </summary>
        /// <param name="req"><see cref="CancelTaskRequest"/></param>
        /// <returns><see cref="CancelTaskResponse"/></returns>
        public async Task<CancelTaskResponse> CancelTask(CancelTaskRequest req)
        {
             JsonResponseModel<CancelTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CancelTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CancelTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 取消任务
        /// </summary>
        /// <param name="req"><see cref="CancelTaskRequest"/></param>
        /// <returns><see cref="CancelTaskResponse"/></returns>
        public CancelTaskResponse CancelTaskSync(CancelTaskRequest req)
        {
             JsonResponseModel<CancelTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CancelTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CancelTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建业务配置，1个账号最多可以创建20个配置，可定义音频审核的场景，如色情、谩骂等，
        /// 
        /// 在创建业务配置之前，你需要以下步骤：
        /// 1. 开通COS存储捅功能，新建存储桶，例如 cms_segments，用来存储 视频转换过程中生成对音频和图片。
        /// 2. 然后在COS控制台，授权天御内容安全主账号 对 cms_segments 存储桶对读写权限。具体授权操作，参考https://cloud.tencent.com/document/product/436/38648
        /// </summary>
        /// <param name="req"><see cref="CreateBizConfigRequest"/></param>
        /// <returns><see cref="CreateBizConfigResponse"/></returns>
        public async Task<CreateBizConfigResponse> CreateBizConfig(CreateBizConfigRequest req)
        {
             JsonResponseModel<CreateBizConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateBizConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateBizConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建业务配置，1个账号最多可以创建20个配置，可定义音频审核的场景，如色情、谩骂等，
        /// 
        /// 在创建业务配置之前，你需要以下步骤：
        /// 1. 开通COS存储捅功能，新建存储桶，例如 cms_segments，用来存储 视频转换过程中生成对音频和图片。
        /// 2. 然后在COS控制台，授权天御内容安全主账号 对 cms_segments 存储桶对读写权限。具体授权操作，参考https://cloud.tencent.com/document/product/436/38648
        /// </summary>
        /// <param name="req"><see cref="CreateBizConfigRequest"/></param>
        /// <returns><see cref="CreateBizConfigResponse"/></returns>
        public CreateBizConfigResponse CreateBizConfigSync(CreateBizConfigRequest req)
        {
             JsonResponseModel<CreateBizConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateBizConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateBizConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 通过URL或存储桶创建审核任务
        /// </summary>
        /// <param name="req"><see cref="CreateVideoModerationTaskRequest"/></param>
        /// <returns><see cref="CreateVideoModerationTaskResponse"/></returns>
        public async Task<CreateVideoModerationTaskResponse> CreateVideoModerationTask(CreateVideoModerationTaskRequest req)
        {
             JsonResponseModel<CreateVideoModerationTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateVideoModerationTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateVideoModerationTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 通过URL或存储桶创建审核任务
        /// </summary>
        /// <param name="req"><see cref="CreateVideoModerationTaskRequest"/></param>
        /// <returns><see cref="CreateVideoModerationTaskResponse"/></returns>
        public CreateVideoModerationTaskResponse CreateVideoModerationTaskSync(CreateVideoModerationTaskRequest req)
        {
             JsonResponseModel<CreateVideoModerationTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateVideoModerationTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateVideoModerationTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查看任务详情DescribeTaskDetail 
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskDetailRequest"/></param>
        /// <returns><see cref="DescribeTaskDetailResponse"/></returns>
        public async Task<DescribeTaskDetailResponse> DescribeTaskDetail(DescribeTaskDetailRequest req)
        {
             JsonResponseModel<DescribeTaskDetailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTaskDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTaskDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查看任务详情DescribeTaskDetail 
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskDetailRequest"/></param>
        /// <returns><see cref="DescribeTaskDetailResponse"/></returns>
        public DescribeTaskDetailResponse DescribeTaskDetailSync(DescribeTaskDetailRequest req)
        {
             JsonResponseModel<DescribeTaskDetailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTaskDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTaskDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 控制台识别统计
        /// </summary>
        /// <param name="req"><see cref="DescribeVideoStatRequest"/></param>
        /// <returns><see cref="DescribeVideoStatResponse"/></returns>
        public async Task<DescribeVideoStatResponse> DescribeVideoStat(DescribeVideoStatRequest req)
        {
             JsonResponseModel<DescribeVideoStatResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeVideoStat");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVideoStatResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 控制台识别统计
        /// </summary>
        /// <param name="req"><see cref="DescribeVideoStatRequest"/></param>
        /// <returns><see cref="DescribeVideoStatResponse"/></returns>
        public DescribeVideoStatResponse DescribeVideoStatSync(DescribeVideoStatRequest req)
        {
             JsonResponseModel<DescribeVideoStatResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeVideoStat");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVideoStatResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
