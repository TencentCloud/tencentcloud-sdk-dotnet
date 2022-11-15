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

namespace TencentCloud.Gme.V20180711
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Gme.V20180711.Models;

   public class GmeClient : AbstractClient{

       private const string endpoint = "gme.tencentcloudapi.com";
       private const string version = "2018-07-11";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public GmeClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public GmeClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 用于创建年龄语音识别任务的接口，请求频率10次/秒。该接口目前通过白名单开放试用，如有需求，请提交工单申请。
        /// </br>
        /// <h4><b>接口功能说明：</b></h4>
        /// <li>支持对语音文件进行检测，判断是否为未成年人。</li>
        /// <li>支持批量提交检测子任务。检测子任务列表最多支持100个。</li>
        /// </br>
        /// <h4><b>音频文件限制说明：</b></h4>
        /// <li>音频文件大小限制：10 M</li>
        /// <li>音频文件时长限制：3分钟</li>
        /// <li>音频文件格式支持的类型：.wav、.m4a、.amr、.mp3、.aac、.wma、.ogg</li>
        /// </br>
        /// </summary>
        /// <param name="req"><see cref="CreateAgeDetectTaskRequest"/></param>
        /// <returns><see cref="CreateAgeDetectTaskResponse"/></returns>
        public async Task<CreateAgeDetectTaskResponse> CreateAgeDetectTask(CreateAgeDetectTaskRequest req)
        {
             JsonResponseModel<CreateAgeDetectTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateAgeDetectTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAgeDetectTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于创建年龄语音识别任务的接口，请求频率10次/秒。该接口目前通过白名单开放试用，如有需求，请提交工单申请。
        /// </br>
        /// <h4><b>接口功能说明：</b></h4>
        /// <li>支持对语音文件进行检测，判断是否为未成年人。</li>
        /// <li>支持批量提交检测子任务。检测子任务列表最多支持100个。</li>
        /// </br>
        /// <h4><b>音频文件限制说明：</b></h4>
        /// <li>音频文件大小限制：10 M</li>
        /// <li>音频文件时长限制：3分钟</li>
        /// <li>音频文件格式支持的类型：.wav、.m4a、.amr、.mp3、.aac、.wma、.ogg</li>
        /// </br>
        /// </summary>
        /// <param name="req"><see cref="CreateAgeDetectTaskRequest"/></param>
        /// <returns><see cref="CreateAgeDetectTaskResponse"/></returns>
        public CreateAgeDetectTaskResponse CreateAgeDetectTaskSync(CreateAgeDetectTaskRequest req)
        {
             JsonResponseModel<CreateAgeDetectTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateAgeDetectTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAgeDetectTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(CreateApp)用于创建一个GME应用。
        /// </summary>
        /// <param name="req"><see cref="CreateAppRequest"/></param>
        /// <returns><see cref="CreateAppResponse"/></returns>
        public async Task<CreateAppResponse> CreateApp(CreateAppRequest req)
        {
             JsonResponseModel<CreateAppResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateApp");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAppResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(CreateApp)用于创建一个GME应用。
        /// </summary>
        /// <param name="req"><see cref="CreateAppRequest"/></param>
        /// <returns><see cref="CreateAppResponse"/></returns>
        public CreateAppResponse CreateAppSync(CreateAppRequest req)
        {
             JsonResponseModel<CreateAppResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateApp");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAppResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用户使用该接口可以创建语音消息转文本自学习模型，以供识别调用
        /// </summary>
        /// <param name="req"><see cref="CreateCustomizationRequest"/></param>
        /// <returns><see cref="CreateCustomizationResponse"/></returns>
        public async Task<CreateCustomizationResponse> CreateCustomization(CreateCustomizationRequest req)
        {
             JsonResponseModel<CreateCustomizationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateCustomization");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCustomizationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用户使用该接口可以创建语音消息转文本自学习模型，以供识别调用
        /// </summary>
        /// <param name="req"><see cref="CreateCustomizationRequest"/></param>
        /// <returns><see cref="CreateCustomizationResponse"/></returns>
        public CreateCustomizationResponse CreateCustomizationSync(CreateCustomizationRequest req)
        {
             JsonResponseModel<CreateCustomizationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateCustomization");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCustomizationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 新增自定义送检用户
        /// </summary>
        /// <param name="req"><see cref="CreateScanUserRequest"/></param>
        /// <returns><see cref="CreateScanUserResponse"/></returns>
        public async Task<CreateScanUserResponse> CreateScanUser(CreateScanUserRequest req)
        {
             JsonResponseModel<CreateScanUserResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateScanUser");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateScanUserResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 新增自定义送检用户
        /// </summary>
        /// <param name="req"><see cref="CreateScanUserRequest"/></param>
        /// <returns><see cref="CreateScanUserResponse"/></returns>
        public CreateScanUserResponse CreateScanUserSync(CreateScanUserRequest req)
        {
             JsonResponseModel<CreateScanUserResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateScanUser");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateScanUserResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用户通过该接口可以删除语音消息转文本自学习模型
        /// </summary>
        /// <param name="req"><see cref="DeleteCustomizationRequest"/></param>
        /// <returns><see cref="DeleteCustomizationResponse"/></returns>
        public async Task<DeleteCustomizationResponse> DeleteCustomization(DeleteCustomizationRequest req)
        {
             JsonResponseModel<DeleteCustomizationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteCustomization");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteCustomizationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用户通过该接口可以删除语音消息转文本自学习模型
        /// </summary>
        /// <param name="req"><see cref="DeleteCustomizationRequest"/></param>
        /// <returns><see cref="DeleteCustomizationResponse"/></returns>
        public DeleteCustomizationResponse DeleteCustomizationSync(DeleteCustomizationRequest req)
        {
             JsonResponseModel<DeleteCustomizationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteCustomization");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteCustomizationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DeleteRoomMember)用户删除房间或者剔除房间内用户
        /// </summary>
        /// <param name="req"><see cref="DeleteRoomMemberRequest"/></param>
        /// <returns><see cref="DeleteRoomMemberResponse"/></returns>
        public async Task<DeleteRoomMemberResponse> DeleteRoomMember(DeleteRoomMemberRequest req)
        {
             JsonResponseModel<DeleteRoomMemberResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteRoomMember");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteRoomMemberResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DeleteRoomMember)用户删除房间或者剔除房间内用户
        /// </summary>
        /// <param name="req"><see cref="DeleteRoomMemberRequest"/></param>
        /// <returns><see cref="DeleteRoomMemberResponse"/></returns>
        public DeleteRoomMemberResponse DeleteRoomMemberSync(DeleteRoomMemberRequest req)
        {
             JsonResponseModel<DeleteRoomMemberResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteRoomMember");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteRoomMemberResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除自定义送检用户
        /// </summary>
        /// <param name="req"><see cref="DeleteScanUserRequest"/></param>
        /// <returns><see cref="DeleteScanUserResponse"/></returns>
        public async Task<DeleteScanUserResponse> DeleteScanUser(DeleteScanUserRequest req)
        {
             JsonResponseModel<DeleteScanUserResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteScanUser");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteScanUserResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除自定义送检用户
        /// </summary>
        /// <param name="req"><see cref="DeleteScanUserRequest"/></param>
        /// <returns><see cref="DeleteScanUserResponse"/></returns>
        public DeleteScanUserResponse DeleteScanUserSync(DeleteScanUserRequest req)
        {
             JsonResponseModel<DeleteScanUserResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteScanUser");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteScanUserResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询年龄语音识别任务结果，请求频率10次/秒。该接口目前通过白名单开放试用，如有需求，请提交工单申请。
        /// </summary>
        /// <param name="req"><see cref="DescribeAgeDetectTaskRequest"/></param>
        /// <returns><see cref="DescribeAgeDetectTaskResponse"/></returns>
        public async Task<DescribeAgeDetectTaskResponse> DescribeAgeDetectTask(DescribeAgeDetectTaskRequest req)
        {
             JsonResponseModel<DescribeAgeDetectTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAgeDetectTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAgeDetectTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询年龄语音识别任务结果，请求频率10次/秒。该接口目前通过白名单开放试用，如有需求，请提交工单申请。
        /// </summary>
        /// <param name="req"><see cref="DescribeAgeDetectTaskRequest"/></param>
        /// <returns><see cref="DescribeAgeDetectTaskResponse"/></returns>
        public DescribeAgeDetectTaskResponse DescribeAgeDetectTaskSync(DescribeAgeDetectTaskRequest req)
        {
             JsonResponseModel<DescribeAgeDetectTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAgeDetectTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAgeDetectTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DescribeAppStatistics)用于获取某个GME应用的用量数据。包括实时语音，语音消息及转文本，语音分析等。最长查询周期为最近60天。
        /// </summary>
        /// <param name="req"><see cref="DescribeAppStatisticsRequest"/></param>
        /// <returns><see cref="DescribeAppStatisticsResponse"/></returns>
        public async Task<DescribeAppStatisticsResponse> DescribeAppStatistics(DescribeAppStatisticsRequest req)
        {
             JsonResponseModel<DescribeAppStatisticsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAppStatistics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAppStatisticsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DescribeAppStatistics)用于获取某个GME应用的用量数据。包括实时语音，语音消息及转文本，语音分析等。最长查询周期为最近60天。
        /// </summary>
        /// <param name="req"><see cref="DescribeAppStatisticsRequest"/></param>
        /// <returns><see cref="DescribeAppStatisticsResponse"/></returns>
        public DescribeAppStatisticsResponse DescribeAppStatisticsSync(DescribeAppStatisticsRequest req)
        {
             JsonResponseModel<DescribeAppStatisticsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAppStatistics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAppStatisticsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DescribeApplicationData)用于获取数据详情信息，最多可拉取最近90天的数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeApplicationDataRequest"/></param>
        /// <returns><see cref="DescribeApplicationDataResponse"/></returns>
        public async Task<DescribeApplicationDataResponse> DescribeApplicationData(DescribeApplicationDataRequest req)
        {
             JsonResponseModel<DescribeApplicationDataResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeApplicationData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeApplicationDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DescribeApplicationData)用于获取数据详情信息，最多可拉取最近90天的数据。
        /// </summary>
        /// <param name="req"><see cref="DescribeApplicationDataRequest"/></param>
        /// <returns><see cref="DescribeApplicationDataResponse"/></returns>
        public DescribeApplicationDataResponse DescribeApplicationDataSync(DescribeApplicationDataRequest req)
        {
             JsonResponseModel<DescribeApplicationDataResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeApplicationData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeApplicationDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取用户自定义送检信息
        /// </summary>
        /// <param name="req"><see cref="DescribeRealtimeScanConfigRequest"/></param>
        /// <returns><see cref="DescribeRealtimeScanConfigResponse"/></returns>
        public async Task<DescribeRealtimeScanConfigResponse> DescribeRealtimeScanConfig(DescribeRealtimeScanConfigRequest req)
        {
             JsonResponseModel<DescribeRealtimeScanConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRealtimeScanConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRealtimeScanConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取用户自定义送检信息
        /// </summary>
        /// <param name="req"><see cref="DescribeRealtimeScanConfigRequest"/></param>
        /// <returns><see cref="DescribeRealtimeScanConfigResponse"/></returns>
        public DescribeRealtimeScanConfigResponse DescribeRealtimeScanConfigSync(DescribeRealtimeScanConfigRequest req)
        {
             JsonResponseModel<DescribeRealtimeScanConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRealtimeScanConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRealtimeScanConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取房间内用户信息
        /// </summary>
        /// <param name="req"><see cref="DescribeRoomInfoRequest"/></param>
        /// <returns><see cref="DescribeRoomInfoResponse"/></returns>
        public async Task<DescribeRoomInfoResponse> DescribeRoomInfo(DescribeRoomInfoRequest req)
        {
             JsonResponseModel<DescribeRoomInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRoomInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRoomInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取房间内用户信息
        /// </summary>
        /// <param name="req"><see cref="DescribeRoomInfoRequest"/></param>
        /// <returns><see cref="DescribeRoomInfoResponse"/></returns>
        public DescribeRoomInfoResponse DescribeRoomInfoSync(DescribeRoomInfoRequest req)
        {
             JsonResponseModel<DescribeRoomInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRoomInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRoomInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DescribeScanResultList)用于查询语音检测结果，查询任务列表最多支持100个。
        /// <p style="color:red">如果在提交语音检测任务时未设置 Callback 字段，则需要通过本接口获取检测结果</p>
        /// </summary>
        /// <param name="req"><see cref="DescribeScanResultListRequest"/></param>
        /// <returns><see cref="DescribeScanResultListResponse"/></returns>
        public async Task<DescribeScanResultListResponse> DescribeScanResultList(DescribeScanResultListRequest req)
        {
             JsonResponseModel<DescribeScanResultListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeScanResultList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeScanResultListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(DescribeScanResultList)用于查询语音检测结果，查询任务列表最多支持100个。
        /// <p style="color:red">如果在提交语音检测任务时未设置 Callback 字段，则需要通过本接口获取检测结果</p>
        /// </summary>
        /// <param name="req"><see cref="DescribeScanResultListRequest"/></param>
        /// <returns><see cref="DescribeScanResultListResponse"/></returns>
        public DescribeScanResultListResponse DescribeScanResultListSync(DescribeScanResultListRequest req)
        {
             JsonResponseModel<DescribeScanResultListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeScanResultList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeScanResultListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 拉取用户在房间得进出时间
        /// </summary>
        /// <param name="req"><see cref="DescribeUserInAndOutTimeRequest"/></param>
        /// <returns><see cref="DescribeUserInAndOutTimeResponse"/></returns>
        public async Task<DescribeUserInAndOutTimeResponse> DescribeUserInAndOutTime(DescribeUserInAndOutTimeRequest req)
        {
             JsonResponseModel<DescribeUserInAndOutTimeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeUserInAndOutTime");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUserInAndOutTimeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 拉取用户在房间得进出时间
        /// </summary>
        /// <param name="req"><see cref="DescribeUserInAndOutTimeRequest"/></param>
        /// <returns><see cref="DescribeUserInAndOutTimeResponse"/></returns>
        public DescribeUserInAndOutTimeResponse DescribeUserInAndOutTimeSync(DescribeUserInAndOutTimeRequest req)
        {
             JsonResponseModel<DescribeUserInAndOutTimeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeUserInAndOutTime");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUserInAndOutTimeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询语音消息转文本自学习模型列表
        /// </summary>
        /// <param name="req"><see cref="GetCustomizationListRequest"/></param>
        /// <returns><see cref="GetCustomizationListResponse"/></returns>
        public async Task<GetCustomizationListResponse> GetCustomizationList(GetCustomizationListRequest req)
        {
             JsonResponseModel<GetCustomizationListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetCustomizationList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetCustomizationListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询语音消息转文本自学习模型列表
        /// </summary>
        /// <param name="req"><see cref="GetCustomizationListRequest"/></param>
        /// <returns><see cref="GetCustomizationListResponse"/></returns>
        public GetCustomizationListResponse GetCustomizationListSync(GetCustomizationListRequest req)
        {
             JsonResponseModel<GetCustomizationListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetCustomizationList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetCustomizationListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(ModifyAppStatus)用于修改应用总开关状态。
        /// </summary>
        /// <param name="req"><see cref="ModifyAppStatusRequest"/></param>
        /// <returns><see cref="ModifyAppStatusResponse"/></returns>
        public async Task<ModifyAppStatusResponse> ModifyAppStatus(ModifyAppStatusRequest req)
        {
             JsonResponseModel<ModifyAppStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyAppStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAppStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(ModifyAppStatus)用于修改应用总开关状态。
        /// </summary>
        /// <param name="req"><see cref="ModifyAppStatusRequest"/></param>
        /// <returns><see cref="ModifyAppStatusResponse"/></returns>
        public ModifyAppStatusResponse ModifyAppStatusSync(ModifyAppStatusRequest req)
        {
             JsonResponseModel<ModifyAppStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyAppStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAppStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用户通过该接口可以更新语音消息转文本自学习模型。
        /// </summary>
        /// <param name="req"><see cref="ModifyCustomizationRequest"/></param>
        /// <returns><see cref="ModifyCustomizationResponse"/></returns>
        public async Task<ModifyCustomizationResponse> ModifyCustomization(ModifyCustomizationRequest req)
        {
             JsonResponseModel<ModifyCustomizationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyCustomization");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCustomizationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用户通过该接口可以更新语音消息转文本自学习模型。
        /// </summary>
        /// <param name="req"><see cref="ModifyCustomizationRequest"/></param>
        /// <returns><see cref="ModifyCustomizationResponse"/></returns>
        public ModifyCustomizationResponse ModifyCustomizationSync(ModifyCustomizationRequest req)
        {
             JsonResponseModel<ModifyCustomizationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyCustomization");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCustomizationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 通过该接口，用户可以修改语音消息转文本自学习模型状态，上下线自学习模型
        /// </summary>
        /// <param name="req"><see cref="ModifyCustomizationStateRequest"/></param>
        /// <returns><see cref="ModifyCustomizationStateResponse"/></returns>
        public async Task<ModifyCustomizationStateResponse> ModifyCustomizationState(ModifyCustomizationStateRequest req)
        {
             JsonResponseModel<ModifyCustomizationStateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyCustomizationState");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCustomizationStateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 通过该接口，用户可以修改语音消息转文本自学习模型状态，上下线自学习模型
        /// </summary>
        /// <param name="req"><see cref="ModifyCustomizationStateRequest"/></param>
        /// <returns><see cref="ModifyCustomizationStateResponse"/></returns>
        public ModifyCustomizationStateResponse ModifyCustomizationStateSync(ModifyCustomizationStateRequest req)
        {
             JsonResponseModel<ModifyCustomizationStateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyCustomizationState");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCustomizationStateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改用户麦克风状态。
        /// </summary>
        /// <param name="req"><see cref="ModifyUserMicStatusRequest"/></param>
        /// <returns><see cref="ModifyUserMicStatusResponse"/></returns>
        public async Task<ModifyUserMicStatusResponse> ModifyUserMicStatus(ModifyUserMicStatusRequest req)
        {
             JsonResponseModel<ModifyUserMicStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyUserMicStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyUserMicStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改用户麦克风状态。
        /// </summary>
        /// <param name="req"><see cref="ModifyUserMicStatusRequest"/></param>
        /// <returns><see cref="ModifyUserMicStatusResponse"/></returns>
        public ModifyUserMicStatusResponse ModifyUserMicStatusSync(ModifyUserMicStatusRequest req)
        {
             JsonResponseModel<ModifyUserMicStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyUserMicStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyUserMicStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(ScanVoice)用于提交语音检测任务，检测任务列表最多支持100个。使用前请您登录[控制台 - 服务配置](https://console.cloud.tencent.com/gamegme/conf)开启语音内容安全服务。
        /// </br></br>
        /// 
        /// <h4><b>功能试用说明：</b></h4>
        /// <li>打开前往<a href="https://console.cloud.tencent.com/gamegme/tryout">控制台 - 产品试用</a>免费试用语音内容安全服务。</li>
        /// </br>
        /// 
        /// <h4><b>接口功能说明：</b></h4>
        /// <li>支持对语音流或语音文件进行检测，判断其中是否包含违规内容。</li>
        /// <li>支持设置回调地址 Callback 获取检测结果，同时支持通过接口(查询语音检测结果)主动轮询获取检测结果。</li>
        /// <li>支持场景输入，包括：谩骂、色情等场景</li>
        /// <li>支持批量提交检测任务。检测任务列表最多支持100个。</li>
        /// </br>
        /// <h4><b>音频文件限制说明：</b></h4>
        /// <li>音频文件大小限制：100 M</li>
        /// <li>音频文件时长限制：30分钟</li>
        /// <li>音频文件格式支持的类型：.wav、.m4a、.amr、.mp3、.aac、.wma、.ogg</li>
        /// </br>
        /// <h4><b>语音流限制说明：</b></h4>
        /// <li>语音流格式支持的类型：.m3u8、.flv</li>
        /// <li>语音流支持的传输协议：RTMP、HTTP、HTTPS</li>
        /// <li>语音流时长限制：4小时</li>
        /// <li>支持音视频流分离并对音频流进行分析</li>
        /// </br>
        /// <h4 id="Label_Value"><b>Scenes 与 Label 参数说明：</b></h4>
        /// <p>提交语音检测任务时，需要指定 Scenes 场景参数，<font color="red">目前要求您设置 Scenes 参数值为：["default"]</font>；而在检测结果中，则包含请求时指定的场景，以及对应类型的检测结果。</p>
        /// <table>
        /// <thread>
        /// <tr>
        /// <th>场景</th>
        /// <th>描述</th>
        /// <th>Label</th>
        /// </tr>
        /// </thread>
        /// <tbody>
        /// <tr>
        /// <td>语音检测</td>
        /// <td>语音检测的检测类型</td>
        /// <td>
        /// <p>normal:正常文本</p>
        /// <p>porn:色情</p>
        /// <p>abuse:谩骂</p>
        /// <p>ad :广告</p>
        /// <p>illegal :违法</p>
        /// <p>moan :呻吟</p>
        /// <p>customized:自定义词库</p>
        /// </td>
        /// </tr>
        /// </tbody>
        /// </table>
        /// </br>
        /// <h4 id="Callback_Declare"><b>回调相关说明：</b></h4>
        /// <li>如果在请求参数中指定了回调地址参数 Callback，即一个 HTTP(S) 协议接口的 URL，则需要支持 POST 方法，传输数据编码采用 UTF-8。</li>
        /// <li>在推送回调数据后，接收到的 HTTP 状态码为 200 时，表示推送成功。</li>
        /// <li>HTTP 头参数说明：</li>
        /// <table>
        /// <thread>
        /// <tr>
        /// <th>名称</th>
        /// <th>类型</th>
        /// <th>是否必需</th>
        /// <th>描述</th>
        /// </tr>
        /// </thread>
        /// <tbody>
        /// <tr>
        /// <td>Signatue</td>
        /// <td>string</td>
        /// <td>是</td>
        /// <td>签名，具体见<a href="#Callback_Signatue">签名生成说明</a></td>
        /// </tr>
        /// </tbody>
        /// </table>
        /// <ul  id="Callback_Signatue">
        /// 	<li>签名生成说明：</li>
        /// 	<ul>
        /// 		<li>使用 HMAC-SH1 算法, 最终结果做 BASE64 编码;</li>
        /// 		<li>签名原文串为 POST+body 的整个json内容(长度以 Content-Length 为准);</li>
        /// 		<li>签名key为应用的 SecretKey，可以通过控制台查看。</li>
        /// 	</ul>
        /// </ul>
        /// 
        /// <li>回调示例如下<font color="red">（详细字段说明见结构：
        /// <a href="https://cloud.tencent.com/document/api/607/35375#DescribeScanResult" target="_blank">DescribeScanResult</a>）</font>：</li>
        /// <pre><code>{
        /// 	"Code": 0,
        /// 	"DataId": "1400000000_test_data_id",
        /// 	"ScanFinishTime": 1566720906,
        /// 	"HitFlag": true,
        /// 	"Live": false,
        /// 	"Msg": "",
        /// 	"ScanPiece": [{
        /// 		"DumpUrl": "",
        /// 		"HitFlag": true,
        /// 		"MainType": "abuse",
        /// 		"RoomId": "123",
        /// 		"OpenId": "xxx",
        /// 		"Info":"",
        /// 		"Offset": 0,
        /// 		"Duration": 3400,
        /// 		"PieceStartTime":1574684231,
        /// 		"ScanDetail": [{
        /// 			"EndTime": 1110,
        /// 			"KeyWord": "xxx",
        /// 			"Label": "abuse",
        /// 			"Rate": "90.00",
        /// 			"StartTime": 1110
        /// 		}, {
        /// 			"EndTime": 1380,
        /// 			"KeyWord": "xxx",
        /// 			"Label": "abuse",
        /// 			"Rate": "90.00",
        /// 			"StartTime": 930
        /// 		}, {
        /// 			"EndTime": 1560,
        /// 			"KeyWord": "xxx",
        /// 			"Label": "abuse",
        /// 			"Rate": "90.00",
        /// 			"StartTime": 930
        /// 		}, {
        /// 			"EndTime": 2820,
        /// 			"KeyWord": "xxx",
        /// 			"Label": "abuse",
        /// 			"Rate": "90.00",
        /// 			"StartTime": 2490
        /// 		}]
        /// 	}],
        /// 	"ScanStartTime": 1566720905,
        /// 	"Scenes": [
        /// 		"default"
        /// 	],
        /// 	"Status": "Success",
        /// 	"TaskId": "xxx",
        /// 	"Url": "https://xxx/xxx.m4a"
        /// }
        /// </code></pre>
        /// </summary>
        /// <param name="req"><see cref="ScanVoiceRequest"/></param>
        /// <returns><see cref="ScanVoiceResponse"/></returns>
        public async Task<ScanVoiceResponse> ScanVoice(ScanVoiceRequest req)
        {
             JsonResponseModel<ScanVoiceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ScanVoice");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ScanVoiceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口(ScanVoice)用于提交语音检测任务，检测任务列表最多支持100个。使用前请您登录[控制台 - 服务配置](https://console.cloud.tencent.com/gamegme/conf)开启语音内容安全服务。
        /// </br></br>
        /// 
        /// <h4><b>功能试用说明：</b></h4>
        /// <li>打开前往<a href="https://console.cloud.tencent.com/gamegme/tryout">控制台 - 产品试用</a>免费试用语音内容安全服务。</li>
        /// </br>
        /// 
        /// <h4><b>接口功能说明：</b></h4>
        /// <li>支持对语音流或语音文件进行检测，判断其中是否包含违规内容。</li>
        /// <li>支持设置回调地址 Callback 获取检测结果，同时支持通过接口(查询语音检测结果)主动轮询获取检测结果。</li>
        /// <li>支持场景输入，包括：谩骂、色情等场景</li>
        /// <li>支持批量提交检测任务。检测任务列表最多支持100个。</li>
        /// </br>
        /// <h4><b>音频文件限制说明：</b></h4>
        /// <li>音频文件大小限制：100 M</li>
        /// <li>音频文件时长限制：30分钟</li>
        /// <li>音频文件格式支持的类型：.wav、.m4a、.amr、.mp3、.aac、.wma、.ogg</li>
        /// </br>
        /// <h4><b>语音流限制说明：</b></h4>
        /// <li>语音流格式支持的类型：.m3u8、.flv</li>
        /// <li>语音流支持的传输协议：RTMP、HTTP、HTTPS</li>
        /// <li>语音流时长限制：4小时</li>
        /// <li>支持音视频流分离并对音频流进行分析</li>
        /// </br>
        /// <h4 id="Label_Value"><b>Scenes 与 Label 参数说明：</b></h4>
        /// <p>提交语音检测任务时，需要指定 Scenes 场景参数，<font color="red">目前要求您设置 Scenes 参数值为：["default"]</font>；而在检测结果中，则包含请求时指定的场景，以及对应类型的检测结果。</p>
        /// <table>
        /// <thread>
        /// <tr>
        /// <th>场景</th>
        /// <th>描述</th>
        /// <th>Label</th>
        /// </tr>
        /// </thread>
        /// <tbody>
        /// <tr>
        /// <td>语音检测</td>
        /// <td>语音检测的检测类型</td>
        /// <td>
        /// <p>normal:正常文本</p>
        /// <p>porn:色情</p>
        /// <p>abuse:谩骂</p>
        /// <p>ad :广告</p>
        /// <p>illegal :违法</p>
        /// <p>moan :呻吟</p>
        /// <p>customized:自定义词库</p>
        /// </td>
        /// </tr>
        /// </tbody>
        /// </table>
        /// </br>
        /// <h4 id="Callback_Declare"><b>回调相关说明：</b></h4>
        /// <li>如果在请求参数中指定了回调地址参数 Callback，即一个 HTTP(S) 协议接口的 URL，则需要支持 POST 方法，传输数据编码采用 UTF-8。</li>
        /// <li>在推送回调数据后，接收到的 HTTP 状态码为 200 时，表示推送成功。</li>
        /// <li>HTTP 头参数说明：</li>
        /// <table>
        /// <thread>
        /// <tr>
        /// <th>名称</th>
        /// <th>类型</th>
        /// <th>是否必需</th>
        /// <th>描述</th>
        /// </tr>
        /// </thread>
        /// <tbody>
        /// <tr>
        /// <td>Signatue</td>
        /// <td>string</td>
        /// <td>是</td>
        /// <td>签名，具体见<a href="#Callback_Signatue">签名生成说明</a></td>
        /// </tr>
        /// </tbody>
        /// </table>
        /// <ul  id="Callback_Signatue">
        /// 	<li>签名生成说明：</li>
        /// 	<ul>
        /// 		<li>使用 HMAC-SH1 算法, 最终结果做 BASE64 编码;</li>
        /// 		<li>签名原文串为 POST+body 的整个json内容(长度以 Content-Length 为准);</li>
        /// 		<li>签名key为应用的 SecretKey，可以通过控制台查看。</li>
        /// 	</ul>
        /// </ul>
        /// 
        /// <li>回调示例如下<font color="red">（详细字段说明见结构：
        /// <a href="https://cloud.tencent.com/document/api/607/35375#DescribeScanResult" target="_blank">DescribeScanResult</a>）</font>：</li>
        /// <pre><code>{
        /// 	"Code": 0,
        /// 	"DataId": "1400000000_test_data_id",
        /// 	"ScanFinishTime": 1566720906,
        /// 	"HitFlag": true,
        /// 	"Live": false,
        /// 	"Msg": "",
        /// 	"ScanPiece": [{
        /// 		"DumpUrl": "",
        /// 		"HitFlag": true,
        /// 		"MainType": "abuse",
        /// 		"RoomId": "123",
        /// 		"OpenId": "xxx",
        /// 		"Info":"",
        /// 		"Offset": 0,
        /// 		"Duration": 3400,
        /// 		"PieceStartTime":1574684231,
        /// 		"ScanDetail": [{
        /// 			"EndTime": 1110,
        /// 			"KeyWord": "xxx",
        /// 			"Label": "abuse",
        /// 			"Rate": "90.00",
        /// 			"StartTime": 1110
        /// 		}, {
        /// 			"EndTime": 1380,
        /// 			"KeyWord": "xxx",
        /// 			"Label": "abuse",
        /// 			"Rate": "90.00",
        /// 			"StartTime": 930
        /// 		}, {
        /// 			"EndTime": 1560,
        /// 			"KeyWord": "xxx",
        /// 			"Label": "abuse",
        /// 			"Rate": "90.00",
        /// 			"StartTime": 930
        /// 		}, {
        /// 			"EndTime": 2820,
        /// 			"KeyWord": "xxx",
        /// 			"Label": "abuse",
        /// 			"Rate": "90.00",
        /// 			"StartTime": 2490
        /// 		}]
        /// 	}],
        /// 	"ScanStartTime": 1566720905,
        /// 	"Scenes": [
        /// 		"default"
        /// 	],
        /// 	"Status": "Success",
        /// 	"TaskId": "xxx",
        /// 	"Url": "https://xxx/xxx.m4a"
        /// }
        /// </code></pre>
        /// </summary>
        /// <param name="req"><see cref="ScanVoiceRequest"/></param>
        /// <returns><see cref="ScanVoiceResponse"/></returns>
        public ScanVoiceResponse ScanVoiceSync(ScanVoiceRequest req)
        {
             JsonResponseModel<ScanVoiceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ScanVoice");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ScanVoiceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新自定义送检房间号
        /// </summary>
        /// <param name="req"><see cref="UpdateScanRoomsRequest"/></param>
        /// <returns><see cref="UpdateScanRoomsResponse"/></returns>
        public async Task<UpdateScanRoomsResponse> UpdateScanRooms(UpdateScanRoomsRequest req)
        {
             JsonResponseModel<UpdateScanRoomsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateScanRooms");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateScanRoomsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新自定义送检房间号
        /// </summary>
        /// <param name="req"><see cref="UpdateScanRoomsRequest"/></param>
        /// <returns><see cref="UpdateScanRoomsResponse"/></returns>
        public UpdateScanRoomsResponse UpdateScanRoomsSync(UpdateScanRoomsRequest req)
        {
             JsonResponseModel<UpdateScanRoomsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateScanRooms");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateScanRoomsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新自定义送检用户号
        /// </summary>
        /// <param name="req"><see cref="UpdateScanUsersRequest"/></param>
        /// <returns><see cref="UpdateScanUsersResponse"/></returns>
        public async Task<UpdateScanUsersResponse> UpdateScanUsers(UpdateScanUsersRequest req)
        {
             JsonResponseModel<UpdateScanUsersResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateScanUsers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateScanUsersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新自定义送检用户号
        /// </summary>
        /// <param name="req"><see cref="UpdateScanUsersRequest"/></param>
        /// <returns><see cref="UpdateScanUsersResponse"/></returns>
        public UpdateScanUsersResponse UpdateScanUsersSync(UpdateScanUsersRequest req)
        {
             JsonResponseModel<UpdateScanUsersResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateScanUsers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateScanUsersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
