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

namespace TencentCloud.Ie.V20200304
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Ie.V20200304.Models;

   public class IeClient : AbstractClient{

       private const string endpoint = "ie.tencentcloudapi.com";
       private const string version = "2020-03-04";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public IeClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public IeClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 创建智能编辑任务，可以同时选择视频标签识别、分类识别、智能拆条、智能集锦、智能封面和片头片尾识别中的一项或者多项能力。
        /// </summary>
        /// <param name="req"><see cref="CreateEditingTaskRequest"/></param>
        /// <returns><see cref="CreateEditingTaskResponse"/></returns>
        public async Task<CreateEditingTaskResponse> CreateEditingTask(CreateEditingTaskRequest req)
        {
             JsonResponseModel<CreateEditingTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateEditingTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateEditingTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建智能编辑任务，可以同时选择视频标签识别、分类识别、智能拆条、智能集锦、智能封面和片头片尾识别中的一项或者多项能力。
        /// </summary>
        /// <param name="req"><see cref="CreateEditingTaskRequest"/></param>
        /// <returns><see cref="CreateEditingTaskResponse"/></returns>
        public CreateEditingTaskResponse CreateEditingTaskSync(CreateEditingTaskRequest req)
        {
             JsonResponseModel<CreateEditingTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateEditingTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateEditingTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取智能编辑任务结果。
        /// </summary>
        /// <param name="req"><see cref="DescribeEditingTaskResultRequest"/></param>
        /// <returns><see cref="DescribeEditingTaskResultResponse"/></returns>
        public async Task<DescribeEditingTaskResultResponse> DescribeEditingTaskResult(DescribeEditingTaskResultRequest req)
        {
             JsonResponseModel<DescribeEditingTaskResultResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeEditingTaskResult");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEditingTaskResultResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取智能编辑任务结果。
        /// </summary>
        /// <param name="req"><see cref="DescribeEditingTaskResultRequest"/></param>
        /// <returns><see cref="DescribeEditingTaskResultResponse"/></returns>
        public DescribeEditingTaskResultResponse DescribeEditingTaskResultSync(DescribeEditingTaskResultRequest req)
        {
             JsonResponseModel<DescribeEditingTaskResultResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeEditingTaskResult");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEditingTaskResultResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
