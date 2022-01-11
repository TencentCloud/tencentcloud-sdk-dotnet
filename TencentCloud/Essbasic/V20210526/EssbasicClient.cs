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

namespace TencentCloud.Essbasic.V20210526
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Essbasic.V20210526.Models;

   public class EssbasicClient : AbstractClient{

       private const string endpoint = "essbasic.tencentcloudapi.com";
       private const string version = "2021-05-26";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public EssbasicClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public EssbasicClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 此接口（CreateConsoleLoginUrl）用于创建电子签控制台登录链接。若企业未激活，调用同步企业信息、同步经办人信息
        /// </summary>
        /// <param name="req"><see cref="CreateConsoleLoginUrlRequest"/></param>
        /// <returns><see cref="CreateConsoleLoginUrlResponse"/></returns>
        public async Task<CreateConsoleLoginUrlResponse> CreateConsoleLoginUrl(CreateConsoleLoginUrlRequest req)
        {
             JsonResponseModel<CreateConsoleLoginUrlResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateConsoleLoginUrl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateConsoleLoginUrlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口（CreateConsoleLoginUrl）用于创建电子签控制台登录链接。若企业未激活，调用同步企业信息、同步经办人信息
        /// </summary>
        /// <param name="req"><see cref="CreateConsoleLoginUrlRequest"/></param>
        /// <returns><see cref="CreateConsoleLoginUrlResponse"/></returns>
        public CreateConsoleLoginUrlResponse CreateConsoleLoginUrlSync(CreateConsoleLoginUrlRequest req)
        {
             JsonResponseModel<CreateConsoleLoginUrlResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateConsoleLoginUrl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateConsoleLoginUrlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 接口（CreateFlowsByTemplates）用于使用多个模板批量创建流程。当前可批量发起合同（流程）数量最大为20个。
        /// </summary>
        /// <param name="req"><see cref="CreateFlowsByTemplatesRequest"/></param>
        /// <returns><see cref="CreateFlowsByTemplatesResponse"/></returns>
        public async Task<CreateFlowsByTemplatesResponse> CreateFlowsByTemplates(CreateFlowsByTemplatesRequest req)
        {
             JsonResponseModel<CreateFlowsByTemplatesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateFlowsByTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateFlowsByTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 接口（CreateFlowsByTemplates）用于使用多个模板批量创建流程。当前可批量发起合同（流程）数量最大为20个。
        /// </summary>
        /// <param name="req"><see cref="CreateFlowsByTemplatesRequest"/></param>
        /// <returns><see cref="CreateFlowsByTemplatesResponse"/></returns>
        public CreateFlowsByTemplatesResponse CreateFlowsByTemplatesSync(CreateFlowsByTemplatesRequest req)
        {
             JsonResponseModel<CreateFlowsByTemplatesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateFlowsByTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateFlowsByTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建参与者签署短链
        /// </summary>
        /// <param name="req"><see cref="CreateSignUrlsRequest"/></param>
        /// <returns><see cref="CreateSignUrlsResponse"/></returns>
        public async Task<CreateSignUrlsResponse> CreateSignUrls(CreateSignUrlsRequest req)
        {
             JsonResponseModel<CreateSignUrlsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateSignUrls");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSignUrlsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建参与者签署短链
        /// </summary>
        /// <param name="req"><see cref="CreateSignUrlsRequest"/></param>
        /// <returns><see cref="CreateSignUrlsResponse"/></returns>
        public CreateSignUrlsResponse CreateSignUrlsSync(CreateSignUrlsRequest req)
        {
             JsonResponseModel<CreateSignUrlsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateSignUrls");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSignUrlsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口（DescribeFlowDetailInfo）用于查询合同(流程)的详细信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeFlowDetailInfoRequest"/></param>
        /// <returns><see cref="DescribeFlowDetailInfoResponse"/></returns>
        public async Task<DescribeFlowDetailInfoResponse> DescribeFlowDetailInfo(DescribeFlowDetailInfoRequest req)
        {
             JsonResponseModel<DescribeFlowDetailInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeFlowDetailInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeFlowDetailInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口（DescribeFlowDetailInfo）用于查询合同(流程)的详细信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeFlowDetailInfoRequest"/></param>
        /// <returns><see cref="DescribeFlowDetailInfoResponse"/></returns>
        public DescribeFlowDetailInfoResponse DescribeFlowDetailInfoSync(DescribeFlowDetailInfoRequest req)
        {
             JsonResponseModel<DescribeFlowDetailInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeFlowDetailInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeFlowDetailInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据流程信息批量获取资源下载链接
        /// </summary>
        /// <param name="req"><see cref="DescribeResourceUrlsByFlowsRequest"/></param>
        /// <returns><see cref="DescribeResourceUrlsByFlowsResponse"/></returns>
        public async Task<DescribeResourceUrlsByFlowsResponse> DescribeResourceUrlsByFlows(DescribeResourceUrlsByFlowsRequest req)
        {
             JsonResponseModel<DescribeResourceUrlsByFlowsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeResourceUrlsByFlows");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeResourceUrlsByFlowsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据流程信息批量获取资源下载链接
        /// </summary>
        /// <param name="req"><see cref="DescribeResourceUrlsByFlowsRequest"/></param>
        /// <returns><see cref="DescribeResourceUrlsByFlowsResponse"/></returns>
        public DescribeResourceUrlsByFlowsResponse DescribeResourceUrlsByFlowsSync(DescribeResourceUrlsByFlowsRequest req)
        {
             JsonResponseModel<DescribeResourceUrlsByFlowsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeResourceUrlsByFlows");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeResourceUrlsByFlowsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 通过此接口（DescribeTemplates）查询该企业在电子签渠道版中配置的有效模板列表
        /// </summary>
        /// <param name="req"><see cref="DescribeTemplatesRequest"/></param>
        /// <returns><see cref="DescribeTemplatesResponse"/></returns>
        public async Task<DescribeTemplatesResponse> DescribeTemplates(DescribeTemplatesRequest req)
        {
             JsonResponseModel<DescribeTemplatesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 通过此接口（DescribeTemplates）查询该企业在电子签渠道版中配置的有效模板列表
        /// </summary>
        /// <param name="req"><see cref="DescribeTemplatesRequest"/></param>
        /// <returns><see cref="DescribeTemplatesResponse"/></returns>
        public DescribeTemplatesResponse DescribeTemplatesSync(DescribeTemplatesRequest req)
        {
             JsonResponseModel<DescribeTemplatesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口（DescribeUsage）用于获取渠道所有合作企业流量消耗情况。
        ///  注: 此接口每日限频2次，若要扩大限制次数,请提前与客服经理或邮件至e-contract@tencent.com进行联系。
        /// </summary>
        /// <param name="req"><see cref="DescribeUsageRequest"/></param>
        /// <returns><see cref="DescribeUsageResponse"/></returns>
        public async Task<DescribeUsageResponse> DescribeUsage(DescribeUsageRequest req)
        {
             JsonResponseModel<DescribeUsageResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeUsage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUsageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口（DescribeUsage）用于获取渠道所有合作企业流量消耗情况。
        ///  注: 此接口每日限频2次，若要扩大限制次数,请提前与客服经理或邮件至e-contract@tencent.com进行联系。
        /// </summary>
        /// <param name="req"><see cref="DescribeUsageRequest"/></param>
        /// <returns><see cref="DescribeUsageResponse"/></returns>
        public DescribeUsageResponse DescribeUsageSync(DescribeUsageRequest req)
        {
             JsonResponseModel<DescribeUsageResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeUsage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUsageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口（GetDownloadFlowUrl）用于创建电子签批量下载确认页面链接，支持客户合同（流程）按照自定义文件夹形式 分类下载。
        /// 当前接口限制最多合同（流程）50个.
        /// </summary>
        /// <param name="req"><see cref="GetDownloadFlowUrlRequest"/></param>
        /// <returns><see cref="GetDownloadFlowUrlResponse"/></returns>
        public async Task<GetDownloadFlowUrlResponse> GetDownloadFlowUrl(GetDownloadFlowUrlRequest req)
        {
             JsonResponseModel<GetDownloadFlowUrlResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetDownloadFlowUrl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetDownloadFlowUrlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口（GetDownloadFlowUrl）用于创建电子签批量下载确认页面链接，支持客户合同（流程）按照自定义文件夹形式 分类下载。
        /// 当前接口限制最多合同（流程）50个.
        /// </summary>
        /// <param name="req"><see cref="GetDownloadFlowUrlRequest"/></param>
        /// <returns><see cref="GetDownloadFlowUrlResponse"/></returns>
        public GetDownloadFlowUrlResponse GetDownloadFlowUrlSync(GetDownloadFlowUrlRequest req)
        {
             JsonResponseModel<GetDownloadFlowUrlResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetDownloadFlowUrl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetDownloadFlowUrlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口（OperateChannelTemplate）用于渠道侧将模板库中的模板对合作企业进行查询和设置, 其中包括可见性的修改以及对合作企业的设置.
        /// 1、同步标识=select时：
        /// 返回渠道侧模板库当前模板的属性.
        /// 2、同步标识=update或者delete时：
        /// 对渠道子客进行模板库中模板授权,修改操作
        /// </summary>
        /// <param name="req"><see cref="OperateChannelTemplateRequest"/></param>
        /// <returns><see cref="OperateChannelTemplateResponse"/></returns>
        public async Task<OperateChannelTemplateResponse> OperateChannelTemplate(OperateChannelTemplateRequest req)
        {
             JsonResponseModel<OperateChannelTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "OperateChannelTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<OperateChannelTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口（OperateChannelTemplate）用于渠道侧将模板库中的模板对合作企业进行查询和设置, 其中包括可见性的修改以及对合作企业的设置.
        /// 1、同步标识=select时：
        /// 返回渠道侧模板库当前模板的属性.
        /// 2、同步标识=update或者delete时：
        /// 对渠道子客进行模板库中模板授权,修改操作
        /// </summary>
        /// <param name="req"><see cref="OperateChannelTemplateRequest"/></param>
        /// <returns><see cref="OperateChannelTemplateResponse"/></returns>
        public OperateChannelTemplateResponse OperateChannelTemplateSync(OperateChannelTemplateRequest req)
        {
             JsonResponseModel<OperateChannelTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "OperateChannelTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<OperateChannelTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口 (PrepareFlows) 用于创建待发起文件
        /// 用户通过该接口进入流程发起的确认页面，进行发起信息二次确认， 如果确认则进行正常发起。
        /// 目前该接口只支持B2C。
        /// </summary>
        /// <param name="req"><see cref="PrepareFlowsRequest"/></param>
        /// <returns><see cref="PrepareFlowsResponse"/></returns>
        public async Task<PrepareFlowsResponse> PrepareFlows(PrepareFlowsRequest req)
        {
             JsonResponseModel<PrepareFlowsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "PrepareFlows");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<PrepareFlowsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口 (PrepareFlows) 用于创建待发起文件
        /// 用户通过该接口进入流程发起的确认页面，进行发起信息二次确认， 如果确认则进行正常发起。
        /// 目前该接口只支持B2C。
        /// </summary>
        /// <param name="req"><see cref="PrepareFlowsRequest"/></param>
        /// <returns><see cref="PrepareFlowsResponse"/></returns>
        public PrepareFlowsResponse PrepareFlowsSync(PrepareFlowsRequest req)
        {
             JsonResponseModel<PrepareFlowsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "PrepareFlows");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<PrepareFlowsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口（SyncProxyOrganization）用于同步渠道侧企业信息
        /// </summary>
        /// <param name="req"><see cref="SyncProxyOrganizationRequest"/></param>
        /// <returns><see cref="SyncProxyOrganizationResponse"/></returns>
        public async Task<SyncProxyOrganizationResponse> SyncProxyOrganization(SyncProxyOrganizationRequest req)
        {
             JsonResponseModel<SyncProxyOrganizationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SyncProxyOrganization");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SyncProxyOrganizationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口（SyncProxyOrganization）用于同步渠道侧企业信息
        /// </summary>
        /// <param name="req"><see cref="SyncProxyOrganizationRequest"/></param>
        /// <returns><see cref="SyncProxyOrganizationResponse"/></returns>
        public SyncProxyOrganizationResponse SyncProxyOrganizationSync(SyncProxyOrganizationRequest req)
        {
             JsonResponseModel<SyncProxyOrganizationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SyncProxyOrganization");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SyncProxyOrganizationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口（SyncProxyOrganizationOperators）用于同步渠道合作企业经办人列表
        /// </summary>
        /// <param name="req"><see cref="SyncProxyOrganizationOperatorsRequest"/></param>
        /// <returns><see cref="SyncProxyOrganizationOperatorsResponse"/></returns>
        public async Task<SyncProxyOrganizationOperatorsResponse> SyncProxyOrganizationOperators(SyncProxyOrganizationOperatorsRequest req)
        {
             JsonResponseModel<SyncProxyOrganizationOperatorsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SyncProxyOrganizationOperators");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SyncProxyOrganizationOperatorsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口（SyncProxyOrganizationOperators）用于同步渠道合作企业经办人列表
        /// </summary>
        /// <param name="req"><see cref="SyncProxyOrganizationOperatorsRequest"/></param>
        /// <returns><see cref="SyncProxyOrganizationOperatorsResponse"/></returns>
        public SyncProxyOrganizationOperatorsResponse SyncProxyOrganizationOperatorsSync(SyncProxyOrganizationOperatorsRequest req)
        {
             JsonResponseModel<SyncProxyOrganizationOperatorsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SyncProxyOrganizationOperators");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SyncProxyOrganizationOperatorsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
