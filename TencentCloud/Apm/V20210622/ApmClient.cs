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

namespace TencentCloud.Apm.V20210622
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Apm.V20210622.Models;

   public class ApmClient : AbstractClient{

       private const string endpoint = "apm.tencentcloudapi.com";
       private const string version = "2021-06-22";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public ApmClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public ApmClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 业务购买APM实例，调用该接口创建
        /// </summary>
        /// <param name="req"><see cref="CreateApmInstanceRequest"/></param>
        /// <returns><see cref="CreateApmInstanceResponse"/></returns>
        public async Task<CreateApmInstanceResponse> CreateApmInstance(CreateApmInstanceRequest req)
        {
             JsonResponseModel<CreateApmInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateApmInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateApmInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 业务购买APM实例，调用该接口创建
        /// </summary>
        /// <param name="req"><see cref="CreateApmInstanceRequest"/></param>
        /// <returns><see cref="CreateApmInstanceResponse"/></returns>
        public CreateApmInstanceResponse CreateApmInstanceSync(CreateApmInstanceRequest req)
        {
             JsonResponseModel<CreateApmInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateApmInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateApmInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取Apm Agent信息
        /// </summary>
        /// <param name="req"><see cref="DescribeApmAgentRequest"/></param>
        /// <returns><see cref="DescribeApmAgentResponse"/></returns>
        public async Task<DescribeApmAgentResponse> DescribeApmAgent(DescribeApmAgentRequest req)
        {
             JsonResponseModel<DescribeApmAgentResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeApmAgent");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeApmAgentResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取Apm Agent信息
        /// </summary>
        /// <param name="req"><see cref="DescribeApmAgentRequest"/></param>
        /// <returns><see cref="DescribeApmAgentResponse"/></returns>
        public DescribeApmAgentResponse DescribeApmAgentSync(DescribeApmAgentRequest req)
        {
             JsonResponseModel<DescribeApmAgentResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeApmAgent");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeApmAgentResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// APM实例列表拉取
        /// </summary>
        /// <param name="req"><see cref="DescribeApmInstancesRequest"/></param>
        /// <returns><see cref="DescribeApmInstancesResponse"/></returns>
        public async Task<DescribeApmInstancesResponse> DescribeApmInstances(DescribeApmInstancesRequest req)
        {
             JsonResponseModel<DescribeApmInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeApmInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeApmInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// APM实例列表拉取
        /// </summary>
        /// <param name="req"><see cref="DescribeApmInstancesRequest"/></param>
        /// <returns><see cref="DescribeApmInstancesResponse"/></returns>
        public DescribeApmInstancesResponse DescribeApmInstancesSync(DescribeApmInstancesRequest req)
        {
             JsonResponseModel<DescribeApmInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeApmInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeApmInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取指标数据通用接口。用户根据需要上送请求参数，返回对应的指标数据。
        /// 接口调用频率限制为：20次/秒，1200次/分钟。单请求的数据点数限制为1440个。
        /// </summary>
        /// <param name="req"><see cref="DescribeGeneralMetricDataRequest"/></param>
        /// <returns><see cref="DescribeGeneralMetricDataResponse"/></returns>
        public async Task<DescribeGeneralMetricDataResponse> DescribeGeneralMetricData(DescribeGeneralMetricDataRequest req)
        {
             JsonResponseModel<DescribeGeneralMetricDataResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeGeneralMetricData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeGeneralMetricDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取指标数据通用接口。用户根据需要上送请求参数，返回对应的指标数据。
        /// 接口调用频率限制为：20次/秒，1200次/分钟。单请求的数据点数限制为1440个。
        /// </summary>
        /// <param name="req"><see cref="DescribeGeneralMetricDataRequest"/></param>
        /// <returns><see cref="DescribeGeneralMetricDataResponse"/></returns>
        public DescribeGeneralMetricDataResponse DescribeGeneralMetricDataSync(DescribeGeneralMetricDataRequest req)
        {
             JsonResponseModel<DescribeGeneralMetricDataResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeGeneralMetricData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeGeneralMetricDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 拉取通用指标列表
        /// </summary>
        /// <param name="req"><see cref="DescribeMetricRecordsRequest"/></param>
        /// <returns><see cref="DescribeMetricRecordsResponse"/></returns>
        public async Task<DescribeMetricRecordsResponse> DescribeMetricRecords(DescribeMetricRecordsRequest req)
        {
             JsonResponseModel<DescribeMetricRecordsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeMetricRecords");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMetricRecordsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 拉取通用指标列表
        /// </summary>
        /// <param name="req"><see cref="DescribeMetricRecordsRequest"/></param>
        /// <returns><see cref="DescribeMetricRecordsResponse"/></returns>
        public DescribeMetricRecordsResponse DescribeMetricRecordsSync(DescribeMetricRecordsRequest req)
        {
             JsonResponseModel<DescribeMetricRecordsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeMetricRecords");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMetricRecordsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 服务概览数据拉取
        /// </summary>
        /// <param name="req"><see cref="DescribeServiceOverviewRequest"/></param>
        /// <returns><see cref="DescribeServiceOverviewResponse"/></returns>
        public async Task<DescribeServiceOverviewResponse> DescribeServiceOverview(DescribeServiceOverviewRequest req)
        {
             JsonResponseModel<DescribeServiceOverviewResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeServiceOverview");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeServiceOverviewResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 服务概览数据拉取
        /// </summary>
        /// <param name="req"><see cref="DescribeServiceOverviewRequest"/></param>
        /// <returns><see cref="DescribeServiceOverviewResponse"/></returns>
        public DescribeServiceOverviewResponse DescribeServiceOverviewSync(DescribeServiceOverviewRequest req)
        {
             JsonResponseModel<DescribeServiceOverviewResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeServiceOverview");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeServiceOverviewResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
