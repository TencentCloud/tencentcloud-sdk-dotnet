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

namespace TencentCloud.Zj.V20190121
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Zj.V20190121.Models;

   public class ZjClient : AbstractClient{

       private const string endpoint = "zj.tencentcloudapi.com";
       private const string version = "2019-01-21";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public ZjClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public ZjClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 添加短信人群包信息
        /// </summary>
        /// <param name="req"><see cref="AddCrowdPackInfoRequest"/></param>
        /// <returns><see cref="AddCrowdPackInfoResponse"/></returns>
        public async Task<AddCrowdPackInfoResponse> AddCrowdPackInfo(AddCrowdPackInfoRequest req)
        {
             JsonResponseModel<AddCrowdPackInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AddCrowdPackInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddCrowdPackInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 添加短信人群包信息
        /// </summary>
        /// <param name="req"><see cref="AddCrowdPackInfoRequest"/></param>
        /// <returns><see cref="AddCrowdPackInfoResponse"/></returns>
        public AddCrowdPackInfoResponse AddCrowdPackInfoSync(AddCrowdPackInfoRequest req)
        {
             JsonResponseModel<AddCrowdPackInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AddCrowdPackInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddCrowdPackInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建普通短信签名信息
        /// </summary>
        /// <param name="req"><see cref="AddSmsSignRequest"/></param>
        /// <returns><see cref="AddSmsSignResponse"/></returns>
        public async Task<AddSmsSignResponse> AddSmsSign(AddSmsSignRequest req)
        {
             JsonResponseModel<AddSmsSignResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AddSmsSign");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddSmsSignResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建普通短信签名信息
        /// </summary>
        /// <param name="req"><see cref="AddSmsSignRequest"/></param>
        /// <returns><see cref="AddSmsSignResponse"/></returns>
        public AddSmsSignResponse AddSmsSignSync(AddSmsSignRequest req)
        {
             JsonResponseModel<AddSmsSignResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AddSmsSign");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddSmsSignResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据短信标题、模板内容等创建短信模板
        /// </summary>
        /// <param name="req"><see cref="AddSmsTemplateRequest"/></param>
        /// <returns><see cref="AddSmsTemplateResponse"/></returns>
        public async Task<AddSmsTemplateResponse> AddSmsTemplate(AddSmsTemplateRequest req)
        {
             JsonResponseModel<AddSmsTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AddSmsTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddSmsTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据短信标题、模板内容等创建短信模板
        /// </summary>
        /// <param name="req"><see cref="AddSmsTemplateRequest"/></param>
        /// <returns><see cref="AddSmsTemplateResponse"/></returns>
        public AddSmsTemplateResponse AddSmsTemplateSync(AddSmsTemplateRequest req)
        {
             JsonResponseModel<AddSmsTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AddSmsTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddSmsTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 取消短信推送活动
        /// </summary>
        /// <param name="req"><see cref="CancelCampaignRequest"/></param>
        /// <returns><see cref="CancelCampaignResponse"/></returns>
        public async Task<CancelCampaignResponse> CancelCampaign(CancelCampaignRequest req)
        {
             JsonResponseModel<CancelCampaignResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CancelCampaign");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CancelCampaignResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 取消短信推送活动
        /// </summary>
        /// <param name="req"><see cref="CancelCampaignRequest"/></param>
        /// <returns><see cref="CancelCampaignResponse"/></returns>
        public CancelCampaignResponse CancelCampaignSync(CancelCampaignRequest req)
        {
             JsonResponseModel<CancelCampaignResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CancelCampaign");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CancelCampaignResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建短信推送活动
        /// </summary>
        /// <param name="req"><see cref="CreateCampaignRequest"/></param>
        /// <returns><see cref="CreateCampaignResponse"/></returns>
        public async Task<CreateCampaignResponse> CreateCampaign(CreateCampaignRequest req)
        {
             JsonResponseModel<CreateCampaignResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateCampaign");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCampaignResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建短信推送活动
        /// </summary>
        /// <param name="req"><see cref="CreateCampaignRequest"/></param>
        /// <returns><see cref="CreateCampaignResponse"/></returns>
        public CreateCampaignResponse CreateCampaignSync(CreateCampaignRequest req)
        {
             JsonResponseModel<CreateCampaignResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateCampaign");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCampaignResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建超级短信的素材样例内容
        /// </summary>
        /// <param name="req"><see cref="CreateMmsInstanceRequest"/></param>
        /// <returns><see cref="CreateMmsInstanceResponse"/></returns>
        public async Task<CreateMmsInstanceResponse> CreateMmsInstance(CreateMmsInstanceRequest req)
        {
             JsonResponseModel<CreateMmsInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateMmsInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateMmsInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建超级短信的素材样例内容
        /// </summary>
        /// <param name="req"><see cref="CreateMmsInstanceRequest"/></param>
        /// <returns><see cref="CreateMmsInstanceResponse"/></returns>
        public CreateMmsInstanceResponse CreateMmsInstanceSync(CreateMmsInstanceRequest req)
        {
             JsonResponseModel<CreateMmsInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateMmsInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateMmsInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除人群包
        /// </summary>
        /// <param name="req"><see cref="DelCrowdPackRequest"/></param>
        /// <returns><see cref="DelCrowdPackResponse"/></returns>
        public async Task<DelCrowdPackResponse> DelCrowdPack(DelCrowdPackRequest req)
        {
             JsonResponseModel<DelCrowdPackResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DelCrowdPack");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DelCrowdPackResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除人群包
        /// </summary>
        /// <param name="req"><see cref="DelCrowdPackRequest"/></param>
        /// <returns><see cref="DelCrowdPackResponse"/></returns>
        public DelCrowdPackResponse DelCrowdPackSync(DelCrowdPackRequest req)
        {
             JsonResponseModel<DelCrowdPackResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DelCrowdPack");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DelCrowdPackResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除短信模板
        /// </summary>
        /// <param name="req"><see cref="DelTemplateRequest"/></param>
        /// <returns><see cref="DelTemplateResponse"/></returns>
        public async Task<DelTemplateResponse> DelTemplate(DelTemplateRequest req)
        {
             JsonResponseModel<DelTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DelTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DelTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除短信模板
        /// </summary>
        /// <param name="req"><see cref="DelTemplateRequest"/></param>
        /// <returns><see cref="DelTemplateResponse"/></returns>
        public DelTemplateResponse DelTemplateSync(DelTemplateRequest req)
        {
             JsonResponseModel<DelTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DelTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DelTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除超级短信样例
        /// </summary>
        /// <param name="req"><see cref="DeleteMmsInstanceRequest"/></param>
        /// <returns><see cref="DeleteMmsInstanceResponse"/></returns>
        public async Task<DeleteMmsInstanceResponse> DeleteMmsInstance(DeleteMmsInstanceRequest req)
        {
             JsonResponseModel<DeleteMmsInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteMmsInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteMmsInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除超级短信样例
        /// </summary>
        /// <param name="req"><see cref="DeleteMmsInstanceRequest"/></param>
        /// <returns><see cref="DeleteMmsInstanceResponse"/></returns>
        public DeleteMmsInstanceResponse DeleteMmsInstanceSync(DeleteMmsInstanceRequest req)
        {
             JsonResponseModel<DeleteMmsInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteMmsInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteMmsInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取彩信实例信息
        /// </summary>
        /// <param name="req"><see cref="DescribeMmsInstanceInfoRequest"/></param>
        /// <returns><see cref="DescribeMmsInstanceInfoResponse"/></returns>
        public async Task<DescribeMmsInstanceInfoResponse> DescribeMmsInstanceInfo(DescribeMmsInstanceInfoRequest req)
        {
             JsonResponseModel<DescribeMmsInstanceInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeMmsInstanceInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMmsInstanceInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取彩信实例信息
        /// </summary>
        /// <param name="req"><see cref="DescribeMmsInstanceInfoRequest"/></param>
        /// <returns><see cref="DescribeMmsInstanceInfoResponse"/></returns>
        public DescribeMmsInstanceInfoResponse DescribeMmsInstanceInfoSync(DescribeMmsInstanceInfoRequest req)
        {
             JsonResponseModel<DescribeMmsInstanceInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeMmsInstanceInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMmsInstanceInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取彩信实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribeMmsInstanceListRequest"/></param>
        /// <returns><see cref="DescribeMmsInstanceListResponse"/></returns>
        public async Task<DescribeMmsInstanceListResponse> DescribeMmsInstanceList(DescribeMmsInstanceListRequest req)
        {
             JsonResponseModel<DescribeMmsInstanceListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeMmsInstanceList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMmsInstanceListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取彩信实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribeMmsInstanceListRequest"/></param>
        /// <returns><see cref="DescribeMmsInstanceListResponse"/></returns>
        public DescribeMmsInstanceListResponse DescribeMmsInstanceListSync(DescribeMmsInstanceListRequest req)
        {
             JsonResponseModel<DescribeMmsInstanceListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeMmsInstanceList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMmsInstanceListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取短信超短活动统计数据
        /// </summary>
        /// <param name="req"><see cref="DescribeSmsCampaignStatisticsRequest"/></param>
        /// <returns><see cref="DescribeSmsCampaignStatisticsResponse"/></returns>
        public async Task<DescribeSmsCampaignStatisticsResponse> DescribeSmsCampaignStatistics(DescribeSmsCampaignStatisticsRequest req)
        {
             JsonResponseModel<DescribeSmsCampaignStatisticsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSmsCampaignStatistics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSmsCampaignStatisticsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取短信超短活动统计数据
        /// </summary>
        /// <param name="req"><see cref="DescribeSmsCampaignStatisticsRequest"/></param>
        /// <returns><see cref="DescribeSmsCampaignStatisticsResponse"/></returns>
        public DescribeSmsCampaignStatisticsResponse DescribeSmsCampaignStatisticsSync(DescribeSmsCampaignStatisticsRequest req)
        {
             JsonResponseModel<DescribeSmsCampaignStatisticsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSmsCampaignStatistics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSmsCampaignStatisticsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取普通短信签名信息
        /// </summary>
        /// <param name="req"><see cref="DescribeSmsSignListRequest"/></param>
        /// <returns><see cref="DescribeSmsSignListResponse"/></returns>
        public async Task<DescribeSmsSignListResponse> DescribeSmsSignList(DescribeSmsSignListRequest req)
        {
             JsonResponseModel<DescribeSmsSignListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSmsSignList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSmsSignListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取普通短信签名信息
        /// </summary>
        /// <param name="req"><see cref="DescribeSmsSignListRequest"/></param>
        /// <returns><see cref="DescribeSmsSignListResponse"/></returns>
        public DescribeSmsSignListResponse DescribeSmsSignListSync(DescribeSmsSignListRequest req)
        {
             JsonResponseModel<DescribeSmsSignListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSmsSignList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSmsSignListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取模板信息
        /// </summary>
        /// <param name="req"><see cref="DescribeSmsTemplateListRequest"/></param>
        /// <returns><see cref="DescribeSmsTemplateListResponse"/></returns>
        public async Task<DescribeSmsTemplateListResponse> DescribeSmsTemplateList(DescribeSmsTemplateListRequest req)
        {
             JsonResponseModel<DescribeSmsTemplateListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSmsTemplateList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSmsTemplateListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取模板信息
        /// </summary>
        /// <param name="req"><see cref="DescribeSmsTemplateListRequest"/></param>
        /// <returns><see cref="DescribeSmsTemplateListResponse"/></returns>
        public DescribeSmsTemplateListResponse DescribeSmsTemplateListSync(DescribeSmsTemplateListRequest req)
        {
             JsonResponseModel<DescribeSmsTemplateListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSmsTemplateList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSmsTemplateListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取人群包列表接口
        /// </summary>
        /// <param name="req"><see cref="GetCrowdPackListRequest"/></param>
        /// <returns><see cref="GetCrowdPackListResponse"/></returns>
        public async Task<GetCrowdPackListResponse> GetCrowdPackList(GetCrowdPackListRequest req)
        {
             JsonResponseModel<GetCrowdPackListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetCrowdPackList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetCrowdPackListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取人群包列表接口
        /// </summary>
        /// <param name="req"><see cref="GetCrowdPackListRequest"/></param>
        /// <returns><see cref="GetCrowdPackListResponse"/></returns>
        public GetCrowdPackListResponse GetCrowdPackListSync(GetCrowdPackListRequest req)
        {
             JsonResponseModel<GetCrowdPackListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetCrowdPackList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetCrowdPackListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取短信人群包cos上传需要的信息
        /// </summary>
        /// <param name="req"><see cref="GetCrowdUploadInfoRequest"/></param>
        /// <returns><see cref="GetCrowdUploadInfoResponse"/></returns>
        public async Task<GetCrowdUploadInfoResponse> GetCrowdUploadInfo(GetCrowdUploadInfoRequest req)
        {
             JsonResponseModel<GetCrowdUploadInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetCrowdUploadInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetCrowdUploadInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取短信人群包cos上传需要的信息
        /// </summary>
        /// <param name="req"><see cref="GetCrowdUploadInfoRequest"/></param>
        /// <returns><see cref="GetCrowdUploadInfoResponse"/></returns>
        public GetCrowdUploadInfoResponse GetCrowdUploadInfoSync(GetCrowdUploadInfoRequest req)
        {
             JsonResponseModel<GetCrowdUploadInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetCrowdUploadInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetCrowdUploadInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取账号短信额度配置信息
        /// </summary>
        /// <param name="req"><see cref="GetSmsAmountInfoRequest"/></param>
        /// <returns><see cref="GetSmsAmountInfoResponse"/></returns>
        public async Task<GetSmsAmountInfoResponse> GetSmsAmountInfo(GetSmsAmountInfoRequest req)
        {
             JsonResponseModel<GetSmsAmountInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetSmsAmountInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetSmsAmountInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取账号短信额度配置信息
        /// </summary>
        /// <param name="req"><see cref="GetSmsAmountInfoRequest"/></param>
        /// <returns><see cref="GetSmsAmountInfoResponse"/></returns>
        public GetSmsAmountInfoResponse GetSmsAmountInfoSync(GetSmsAmountInfoRequest req)
        {
             JsonResponseModel<GetSmsAmountInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetSmsAmountInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetSmsAmountInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取短信活动状态信息
        /// </summary>
        /// <param name="req"><see cref="GetSmsCampaignStatusRequest"/></param>
        /// <returns><see cref="GetSmsCampaignStatusResponse"/></returns>
        public async Task<GetSmsCampaignStatusResponse> GetSmsCampaignStatus(GetSmsCampaignStatusRequest req)
        {
             JsonResponseModel<GetSmsCampaignStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetSmsCampaignStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetSmsCampaignStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取短信活动状态信息
        /// </summary>
        /// <param name="req"><see cref="GetSmsCampaignStatusRequest"/></param>
        /// <returns><see cref="GetSmsCampaignStatusResponse"/></returns>
        public GetSmsCampaignStatusResponse GetSmsCampaignStatusSync(GetSmsCampaignStatusRequest req)
        {
             JsonResponseModel<GetSmsCampaignStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetSmsCampaignStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetSmsCampaignStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 对未审核或者审核未通过的短信模板内容进行编辑修改
        /// </summary>
        /// <param name="req"><see cref="ModifySmsTemplateRequest"/></param>
        /// <returns><see cref="ModifySmsTemplateResponse"/></returns>
        public async Task<ModifySmsTemplateResponse> ModifySmsTemplate(ModifySmsTemplateRequest req)
        {
             JsonResponseModel<ModifySmsTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifySmsTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifySmsTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 对未审核或者审核未通过的短信模板内容进行编辑修改
        /// </summary>
        /// <param name="req"><see cref="ModifySmsTemplateRequest"/></param>
        /// <returns><see cref="ModifySmsTemplateResponse"/></returns>
        public ModifySmsTemplateResponse ModifySmsTemplateSync(ModifySmsTemplateRequest req)
        {
             JsonResponseModel<ModifySmsTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifySmsTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifySmsTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 推送超级短信
        /// </summary>
        /// <param name="req"><see cref="PushMmsContentRequest"/></param>
        /// <returns><see cref="PushMmsContentResponse"/></returns>
        public async Task<PushMmsContentResponse> PushMmsContent(PushMmsContentRequest req)
        {
             JsonResponseModel<PushMmsContentResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "PushMmsContent");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<PushMmsContentResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 推送超级短信
        /// </summary>
        /// <param name="req"><see cref="PushMmsContentRequest"/></param>
        /// <returns><see cref="PushMmsContentResponse"/></returns>
        public PushMmsContentResponse PushMmsContentSync(PushMmsContentRequest req)
        {
             JsonResponseModel<PushMmsContentResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "PushMmsContent");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<PushMmsContentResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 发送短信
        /// </summary>
        /// <param name="req"><see cref="SendSmsRequest"/></param>
        /// <returns><see cref="SendSmsResponse"/></returns>
        public async Task<SendSmsResponse> SendSms(SendSmsRequest req)
        {
             JsonResponseModel<SendSmsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SendSms");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SendSmsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 发送短信
        /// </summary>
        /// <param name="req"><see cref="SendSmsRequest"/></param>
        /// <returns><see cref="SendSmsResponse"/></returns>
        public SendSmsResponse SendSmsSync(SendSmsRequest req)
        {
             JsonResponseModel<SendSmsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SendSms");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SendSmsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
