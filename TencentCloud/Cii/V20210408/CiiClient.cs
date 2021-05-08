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

namespace TencentCloud.Cii.V20210408
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Cii.V20210408.Models;

   public class CiiClient : AbstractClient{

       private const string endpoint = "cii.tencentcloudapi.com";
       private const string version = "2021-04-08";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public CiiClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public CiiClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 基于提供的客户及保单信息，启动结构化识别任务。
        /// </summary>
        /// <param name="req"><see cref="CreateStructureTaskRequest"/></param>
        /// <returns><see cref="CreateStructureTaskResponse"/></returns>
        public async Task<CreateStructureTaskResponse> CreateStructureTask(CreateStructureTaskRequest req)
        {
             JsonResponseModel<CreateStructureTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateStructureTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateStructureTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 基于提供的客户及保单信息，启动结构化识别任务。
        /// </summary>
        /// <param name="req"><see cref="CreateStructureTaskRequest"/></param>
        /// <returns><see cref="CreateStructureTaskResponse"/></returns>
        public CreateStructureTaskResponse CreateStructureTaskSync(CreateStructureTaskRequest req)
        {
             JsonResponseModel<CreateStructureTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateStructureTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateStructureTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 结构化对比查询接口，对比结构化复核前后数据差异，查询识别正确率，召回率。
        /// </summary>
        /// <param name="req"><see cref="DescribeStructCompareDataRequest"/></param>
        /// <returns><see cref="DescribeStructCompareDataResponse"/></returns>
        public async Task<DescribeStructCompareDataResponse> DescribeStructCompareData(DescribeStructCompareDataRequest req)
        {
             JsonResponseModel<DescribeStructCompareDataResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeStructCompareData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeStructCompareDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 结构化对比查询接口，对比结构化复核前后数据差异，查询识别正确率，召回率。
        /// </summary>
        /// <param name="req"><see cref="DescribeStructCompareDataRequest"/></param>
        /// <returns><see cref="DescribeStructCompareDataResponse"/></returns>
        public DescribeStructCompareDataResponse DescribeStructCompareDataSync(DescribeStructCompareDataRequest req)
        {
             JsonResponseModel<DescribeStructCompareDataResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeStructCompareData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeStructCompareDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 依据任务ID获取结构化结果接口。
        /// </summary>
        /// <param name="req"><see cref="DescribeStructureTaskResultRequest"/></param>
        /// <returns><see cref="DescribeStructureTaskResultResponse"/></returns>
        public async Task<DescribeStructureTaskResultResponse> DescribeStructureTaskResult(DescribeStructureTaskResultRequest req)
        {
             JsonResponseModel<DescribeStructureTaskResultResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeStructureTaskResult");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeStructureTaskResultResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 依据任务ID获取结构化结果接口。
        /// </summary>
        /// <param name="req"><see cref="DescribeStructureTaskResultRequest"/></param>
        /// <returns><see cref="DescribeStructureTaskResultResponse"/></returns>
        public DescribeStructureTaskResultResponse DescribeStructureTaskResultSync(DescribeStructureTaskResultRequest req)
        {
             JsonResponseModel<DescribeStructureTaskResultResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeStructureTaskResult");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeStructureTaskResultResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
