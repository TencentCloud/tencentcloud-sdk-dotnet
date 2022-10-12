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

namespace TencentCloud.Bma.V20210624
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Bma.V20210624.Models;

   public class BmaClient : AbstractClient{

       private const string endpoint = "bma.tencentcloudapi.com";
       private const string version = "2021-06-24";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public BmaClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public BmaClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 添加仿冒链接（举报）
        /// </summary>
        /// <param name="req"><see cref="CreateBPFakeURLRequest"/></param>
        /// <returns><see cref="CreateBPFakeURLResponse"/></returns>
        public async Task<CreateBPFakeURLResponse> CreateBPFakeURL(CreateBPFakeURLRequest req)
        {
             JsonResponseModel<CreateBPFakeURLResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateBPFakeURL");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateBPFakeURLResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 添加仿冒链接（举报）
        /// </summary>
        /// <param name="req"><see cref="CreateBPFakeURLRequest"/></param>
        /// <returns><see cref="CreateBPFakeURLResponse"/></returns>
        public CreateBPFakeURLResponse CreateBPFakeURLSync(CreateBPFakeURLRequest req)
        {
             JsonResponseModel<CreateBPFakeURLResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateBPFakeURL");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateBPFakeURLResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 添加误报工单
        /// </summary>
        /// <param name="req"><see cref="CreateBPFalseTicketRequest"/></param>
        /// <returns><see cref="CreateBPFalseTicketResponse"/></returns>
        public async Task<CreateBPFalseTicketResponse> CreateBPFalseTicket(CreateBPFalseTicketRequest req)
        {
             JsonResponseModel<CreateBPFalseTicketResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateBPFalseTicket");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateBPFalseTicketResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 添加误报工单
        /// </summary>
        /// <param name="req"><see cref="CreateBPFalseTicketRequest"/></param>
        /// <returns><see cref="CreateBPFalseTicketResponse"/></returns>
        public CreateBPFalseTicketResponse CreateBPFalseTicketSync(CreateBPFalseTicketRequest req)
        {
             JsonResponseModel<CreateBPFalseTicketResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateBPFalseTicket");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateBPFalseTicketResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 添加下线材料
        /// </summary>
        /// <param name="req"><see cref="CreateBPOfflineAttachmentRequest"/></param>
        /// <returns><see cref="CreateBPOfflineAttachmentResponse"/></returns>
        public async Task<CreateBPOfflineAttachmentResponse> CreateBPOfflineAttachment(CreateBPOfflineAttachmentRequest req)
        {
             JsonResponseModel<CreateBPOfflineAttachmentResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateBPOfflineAttachment");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateBPOfflineAttachmentResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 添加下线材料
        /// </summary>
        /// <param name="req"><see cref="CreateBPOfflineAttachmentRequest"/></param>
        /// <returns><see cref="CreateBPOfflineAttachmentResponse"/></returns>
        public CreateBPOfflineAttachmentResponse CreateBPOfflineAttachmentSync(CreateBPOfflineAttachmentRequest req)
        {
             JsonResponseModel<CreateBPOfflineAttachmentResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateBPOfflineAttachment");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateBPOfflineAttachmentResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 添加下线工单
        /// </summary>
        /// <param name="req"><see cref="CreateBPOfflineTicketRequest"/></param>
        /// <returns><see cref="CreateBPOfflineTicketResponse"/></returns>
        public async Task<CreateBPOfflineTicketResponse> CreateBPOfflineTicket(CreateBPOfflineTicketRequest req)
        {
             JsonResponseModel<CreateBPOfflineTicketResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateBPOfflineTicket");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateBPOfflineTicketResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 添加下线工单
        /// </summary>
        /// <param name="req"><see cref="CreateBPOfflineTicketRequest"/></param>
        /// <returns><see cref="CreateBPOfflineTicketResponse"/></returns>
        public CreateBPOfflineTicketResponse CreateBPOfflineTicketSync(CreateBPOfflineTicketRequest req)
        {
             JsonResponseModel<CreateBPOfflineTicketResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateBPOfflineTicket");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateBPOfflineTicketResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 添加保护网站
        /// </summary>
        /// <param name="req"><see cref="CreateBPProtectURLsRequest"/></param>
        /// <returns><see cref="CreateBPProtectURLsResponse"/></returns>
        public async Task<CreateBPProtectURLsResponse> CreateBPProtectURLs(CreateBPProtectURLsRequest req)
        {
             JsonResponseModel<CreateBPProtectURLsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateBPProtectURLs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateBPProtectURLsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 添加保护网站
        /// </summary>
        /// <param name="req"><see cref="CreateBPProtectURLsRequest"/></param>
        /// <returns><see cref="CreateBPProtectURLsResponse"/></returns>
        public CreateBPProtectURLsResponse CreateBPProtectURLsSync(CreateBPProtectURLsRequest req)
        {
             JsonResponseModel<CreateBPProtectURLsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateBPProtectURLs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateBPProtectURLsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 新建拦截
        /// </summary>
        /// <param name="req"><see cref="CreateCRBlockRequest"/></param>
        /// <returns><see cref="CreateCRBlockResponse"/></returns>
        public async Task<CreateCRBlockResponse> CreateCRBlock(CreateCRBlockRequest req)
        {
             JsonResponseModel<CreateCRBlockResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateCRBlock");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCRBlockResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 新建拦截
        /// </summary>
        /// <param name="req"><see cref="CreateCRBlockRequest"/></param>
        /// <returns><see cref="CreateCRBlockResponse"/></returns>
        public CreateCRBlockResponse CreateCRBlockSync(CreateCRBlockRequest req)
        {
             JsonResponseModel<CreateCRBlockResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateCRBlock");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCRBlockResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于企业认证，新接入用户必须认证后才可以进行后续操作（个人认证和企业认证二选一），只需认证一次即可
        /// </summary>
        /// <param name="req"><see cref="CreateCRCompanyVerifyRequest"/></param>
        /// <returns><see cref="CreateCRCompanyVerifyResponse"/></returns>
        public async Task<CreateCRCompanyVerifyResponse> CreateCRCompanyVerify(CreateCRCompanyVerifyRequest req)
        {
             JsonResponseModel<CreateCRCompanyVerifyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateCRCompanyVerify");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCRCompanyVerifyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于企业认证，新接入用户必须认证后才可以进行后续操作（个人认证和企业认证二选一），只需认证一次即可
        /// </summary>
        /// <param name="req"><see cref="CreateCRCompanyVerifyRequest"/></param>
        /// <returns><see cref="CreateCRCompanyVerifyResponse"/></returns>
        public CreateCRCompanyVerifyResponse CreateCRCompanyVerifySync(CreateCRCompanyVerifyRequest req)
        {
             JsonResponseModel<CreateCRCompanyVerifyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateCRCompanyVerify");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCRCompanyVerifyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 版权保护-新建发函接口
        /// </summary>
        /// <param name="req"><see cref="CreateCRRightRequest"/></param>
        /// <returns><see cref="CreateCRRightResponse"/></returns>
        public async Task<CreateCRRightResponse> CreateCRRight(CreateCRRightRequest req)
        {
             JsonResponseModel<CreateCRRightResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateCRRight");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCRRightResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 版权保护-新建发函接口
        /// </summary>
        /// <param name="req"><see cref="CreateCRRightRequest"/></param>
        /// <returns><see cref="CreateCRRightResponse"/></returns>
        public CreateCRRightResponse CreateCRRightSync(CreateCRRightRequest req)
        {
             JsonResponseModel<CreateCRRightResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateCRRight");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCRRightResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 权属文件添加
        /// </summary>
        /// <param name="req"><see cref="CreateCRRightFileRequest"/></param>
        /// <returns><see cref="CreateCRRightFileResponse"/></returns>
        public async Task<CreateCRRightFileResponse> CreateCRRightFile(CreateCRRightFileRequest req)
        {
             JsonResponseModel<CreateCRRightFileResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateCRRightFile");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCRRightFileResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 权属文件添加
        /// </summary>
        /// <param name="req"><see cref="CreateCRRightFileRequest"/></param>
        /// <returns><see cref="CreateCRRightFileResponse"/></returns>
        public CreateCRRightFileResponse CreateCRRightFileSync(CreateCRRightFileRequest req)
        {
             JsonResponseModel<CreateCRRightFileResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateCRRightFile");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCRRightFileResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 举报侵权链接
        /// </summary>
        /// <param name="req"><see cref="CreateCRTortRequest"/></param>
        /// <returns><see cref="CreateCRTortResponse"/></returns>
        public async Task<CreateCRTortResponse> CreateCRTort(CreateCRTortRequest req)
        {
             JsonResponseModel<CreateCRTortResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateCRTort");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCRTortResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 举报侵权链接
        /// </summary>
        /// <param name="req"><see cref="CreateCRTortRequest"/></param>
        /// <returns><see cref="CreateCRTortResponse"/></returns>
        public CreateCRTortResponse CreateCRTortSync(CreateCRTortRequest req)
        {
             JsonResponseModel<CreateCRTortResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateCRTort");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCRTortResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于个人认证，新接入用户必须认证后才可以进行后续操作（个人认证和企业认证二选一），只需认证一次即可
        /// </summary>
        /// <param name="req"><see cref="CreateCRUserVerifyRequest"/></param>
        /// <returns><see cref="CreateCRUserVerifyResponse"/></returns>
        public async Task<CreateCRUserVerifyResponse> CreateCRUserVerify(CreateCRUserVerifyRequest req)
        {
             JsonResponseModel<CreateCRUserVerifyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateCRUserVerify");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCRUserVerifyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于个人认证，新接入用户必须认证后才可以进行后续操作（个人认证和企业认证二选一），只需认证一次即可
        /// </summary>
        /// <param name="req"><see cref="CreateCRUserVerifyRequest"/></param>
        /// <returns><see cref="CreateCRUserVerifyResponse"/></returns>
        public CreateCRUserVerifyResponse CreateCRUserVerifySync(CreateCRUserVerifyRequest req)
        {
             JsonResponseModel<CreateCRUserVerifyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateCRUserVerify");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCRUserVerifyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 新建作品
        /// </summary>
        /// <param name="req"><see cref="CreateCRWorkRequest"/></param>
        /// <returns><see cref="CreateCRWorkResponse"/></returns>
        public async Task<CreateCRWorkResponse> CreateCRWork(CreateCRWorkRequest req)
        {
             JsonResponseModel<CreateCRWorkResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateCRWork");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCRWorkResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 新建作品
        /// </summary>
        /// <param name="req"><see cref="CreateCRWorkRequest"/></param>
        /// <returns><see cref="CreateCRWorkResponse"/></returns>
        public CreateCRWorkResponse CreateCRWorkSync(CreateCRWorkRequest req)
        {
             JsonResponseModel<CreateCRWorkResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateCRWork");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCRWorkResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询企业信息
        /// </summary>
        /// <param name="req"><see cref="DescribeBPCompanyInfoRequest"/></param>
        /// <returns><see cref="DescribeBPCompanyInfoResponse"/></returns>
        public async Task<DescribeBPCompanyInfoResponse> DescribeBPCompanyInfo(DescribeBPCompanyInfoRequest req)
        {
             JsonResponseModel<DescribeBPCompanyInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBPCompanyInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBPCompanyInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询企业信息
        /// </summary>
        /// <param name="req"><see cref="DescribeBPCompanyInfoRequest"/></param>
        /// <returns><see cref="DescribeBPCompanyInfoResponse"/></returns>
        public DescribeBPCompanyInfoResponse DescribeBPCompanyInfoSync(DescribeBPCompanyInfoRequest req)
        {
             JsonResponseModel<DescribeBPCompanyInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBPCompanyInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBPCompanyInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询仿冒链接
        /// </summary>
        /// <param name="req"><see cref="DescribeBPFakeURLsRequest"/></param>
        /// <returns><see cref="DescribeBPFakeURLsResponse"/></returns>
        public async Task<DescribeBPFakeURLsResponse> DescribeBPFakeURLs(DescribeBPFakeURLsRequest req)
        {
             JsonResponseModel<DescribeBPFakeURLsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBPFakeURLs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBPFakeURLsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询仿冒链接
        /// </summary>
        /// <param name="req"><see cref="DescribeBPFakeURLsRequest"/></param>
        /// <returns><see cref="DescribeBPFakeURLsResponse"/></returns>
        public DescribeBPFakeURLsResponse DescribeBPFakeURLsSync(DescribeBPFakeURLsRequest req)
        {
             JsonResponseModel<DescribeBPFakeURLsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBPFakeURLs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBPFakeURLsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询保护网站
        /// </summary>
        /// <param name="req"><see cref="DescribeBPProtectURLsRequest"/></param>
        /// <returns><see cref="DescribeBPProtectURLsResponse"/></returns>
        public async Task<DescribeBPProtectURLsResponse> DescribeBPProtectURLs(DescribeBPProtectURLsRequest req)
        {
             JsonResponseModel<DescribeBPProtectURLsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBPProtectURLs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBPProtectURLsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询保护网站
        /// </summary>
        /// <param name="req"><see cref="DescribeBPProtectURLsRequest"/></param>
        /// <returns><see cref="DescribeBPProtectURLsResponse"/></returns>
        public DescribeBPProtectURLsResponse DescribeBPProtectURLsSync(DescribeBPProtectURLsRequest req)
        {
             JsonResponseModel<DescribeBPProtectURLsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBPProtectURLs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBPProtectURLsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询举报列表
        /// </summary>
        /// <param name="req"><see cref="DescribeBPReportFakeURLsRequest"/></param>
        /// <returns><see cref="DescribeBPReportFakeURLsResponse"/></returns>
        public async Task<DescribeBPReportFakeURLsResponse> DescribeBPReportFakeURLs(DescribeBPReportFakeURLsRequest req)
        {
             JsonResponseModel<DescribeBPReportFakeURLsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBPReportFakeURLs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBPReportFakeURLsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询举报列表
        /// </summary>
        /// <param name="req"><see cref="DescribeBPReportFakeURLsRequest"/></param>
        /// <returns><see cref="DescribeBPReportFakeURLsResponse"/></returns>
        public DescribeBPReportFakeURLsResponse DescribeBPReportFakeURLsSync(DescribeBPReportFakeURLsRequest req)
        {
             JsonResponseModel<DescribeBPReportFakeURLsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBPReportFakeURLs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBPReportFakeURLsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 版权保护-查询作品监测详情接口
        /// </summary>
        /// <param name="req"><see cref="DescribeCRMonitorDetailRequest"/></param>
        /// <returns><see cref="DescribeCRMonitorDetailResponse"/></returns>
        public async Task<DescribeCRMonitorDetailResponse> DescribeCRMonitorDetail(DescribeCRMonitorDetailRequest req)
        {
             JsonResponseModel<DescribeCRMonitorDetailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCRMonitorDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCRMonitorDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 版权保护-查询作品监测详情接口
        /// </summary>
        /// <param name="req"><see cref="DescribeCRMonitorDetailRequest"/></param>
        /// <returns><see cref="DescribeCRMonitorDetailResponse"/></returns>
        public DescribeCRMonitorDetailResponse DescribeCRMonitorDetailSync(DescribeCRMonitorDetailRequest req)
        {
             JsonResponseModel<DescribeCRMonitorDetailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCRMonitorDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCRMonitorDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 版权保护-查询监测列表接口
        /// </summary>
        /// <param name="req"><see cref="DescribeCRMonitorsRequest"/></param>
        /// <returns><see cref="DescribeCRMonitorsResponse"/></returns>
        public async Task<DescribeCRMonitorsResponse> DescribeCRMonitors(DescribeCRMonitorsRequest req)
        {
             JsonResponseModel<DescribeCRMonitorsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCRMonitors");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCRMonitorsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 版权保护-查询监测列表接口
        /// </summary>
        /// <param name="req"><see cref="DescribeCRMonitorsRequest"/></param>
        /// <returns><see cref="DescribeCRMonitorsResponse"/></returns>
        public DescribeCRMonitorsResponse DescribeCRMonitorsSync(DescribeCRMonitorsRequest req)
        {
             JsonResponseModel<DescribeCRMonitorsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCRMonitors");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCRMonitorsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询作品基本信息
        /// </summary>
        /// <param name="req"><see cref="DescribeCRWorkInfoRequest"/></param>
        /// <returns><see cref="DescribeCRWorkInfoResponse"/></returns>
        public async Task<DescribeCRWorkInfoResponse> DescribeCRWorkInfo(DescribeCRWorkInfoRequest req)
        {
             JsonResponseModel<DescribeCRWorkInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCRWorkInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCRWorkInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询作品基本信息
        /// </summary>
        /// <param name="req"><see cref="DescribeCRWorkInfoRequest"/></param>
        /// <returns><see cref="DescribeCRWorkInfoResponse"/></returns>
        public DescribeCRWorkInfoResponse DescribeCRWorkInfoSync(DescribeCRWorkInfoRequest req)
        {
             JsonResponseModel<DescribeCRWorkInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCRWorkInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCRWorkInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改下线材料
        /// </summary>
        /// <param name="req"><see cref="ModifyBPOfflineAttachmentRequest"/></param>
        /// <returns><see cref="ModifyBPOfflineAttachmentResponse"/></returns>
        public async Task<ModifyBPOfflineAttachmentResponse> ModifyBPOfflineAttachment(ModifyBPOfflineAttachmentRequest req)
        {
             JsonResponseModel<ModifyBPOfflineAttachmentResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyBPOfflineAttachment");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyBPOfflineAttachmentResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改下线材料
        /// </summary>
        /// <param name="req"><see cref="ModifyBPOfflineAttachmentRequest"/></param>
        /// <returns><see cref="ModifyBPOfflineAttachmentResponse"/></returns>
        public ModifyBPOfflineAttachmentResponse ModifyBPOfflineAttachmentSync(ModifyBPOfflineAttachmentRequest req)
        {
             JsonResponseModel<ModifyBPOfflineAttachmentResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyBPOfflineAttachment");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyBPOfflineAttachmentResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 拦截申请
        /// </summary>
        /// <param name="req"><see cref="ModifyCRBlockStatusRequest"/></param>
        /// <returns><see cref="ModifyCRBlockStatusResponse"/></returns>
        public async Task<ModifyCRBlockStatusResponse> ModifyCRBlockStatus(ModifyCRBlockStatusRequest req)
        {
             JsonResponseModel<ModifyCRBlockStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyCRBlockStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCRBlockStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 拦截申请
        /// </summary>
        /// <param name="req"><see cref="ModifyCRBlockStatusRequest"/></param>
        /// <returns><see cref="ModifyCRBlockStatusResponse"/></returns>
        public ModifyCRBlockStatusResponse ModifyCRBlockStatusSync(ModifyCRBlockStatusRequest req)
        {
             JsonResponseModel<ModifyCRBlockStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyCRBlockStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCRBlockStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 开启/关闭监测
        /// </summary>
        /// <param name="req"><see cref="ModifyCRMonitorRequest"/></param>
        /// <returns><see cref="ModifyCRMonitorResponse"/></returns>
        public async Task<ModifyCRMonitorResponse> ModifyCRMonitor(ModifyCRMonitorRequest req)
        {
             JsonResponseModel<ModifyCRMonitorResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyCRMonitor");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCRMonitorResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 开启/关闭监测
        /// </summary>
        /// <param name="req"><see cref="ModifyCRMonitorRequest"/></param>
        /// <returns><see cref="ModifyCRMonitorResponse"/></returns>
        public ModifyCRMonitorResponse ModifyCRMonitorSync(ModifyCRMonitorRequest req)
        {
             JsonResponseModel<ModifyCRMonitorResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyCRMonitor");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCRMonitorResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 取证申请
        /// </summary>
        /// <param name="req"><see cref="ModifyCRObtainStatusRequest"/></param>
        /// <returns><see cref="ModifyCRObtainStatusResponse"/></returns>
        public async Task<ModifyCRObtainStatusResponse> ModifyCRObtainStatus(ModifyCRObtainStatusRequest req)
        {
             JsonResponseModel<ModifyCRObtainStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyCRObtainStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCRObtainStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 取证申请
        /// </summary>
        /// <param name="req"><see cref="ModifyCRObtainStatusRequest"/></param>
        /// <returns><see cref="ModifyCRObtainStatusResponse"/></returns>
        public ModifyCRObtainStatusResponse ModifyCRObtainStatusSync(ModifyCRObtainStatusRequest req)
        {
             JsonResponseModel<ModifyCRObtainStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyCRObtainStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCRObtainStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 发函申请
        /// </summary>
        /// <param name="req"><see cref="ModifyCRRightStatusRequest"/></param>
        /// <returns><see cref="ModifyCRRightStatusResponse"/></returns>
        public async Task<ModifyCRRightStatusResponse> ModifyCRRightStatus(ModifyCRRightStatusRequest req)
        {
             JsonResponseModel<ModifyCRRightStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyCRRightStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCRRightStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 发函申请
        /// </summary>
        /// <param name="req"><see cref="ModifyCRRightStatusRequest"/></param>
        /// <returns><see cref="ModifyCRRightStatusResponse"/></returns>
        public ModifyCRRightStatusResponse ModifyCRRightStatusSync(ModifyCRRightStatusRequest req)
        {
             JsonResponseModel<ModifyCRRightStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyCRRightStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCRRightStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改白名单列表
        /// </summary>
        /// <param name="req"><see cref="ModifyCRWhiteListRequest"/></param>
        /// <returns><see cref="ModifyCRWhiteListResponse"/></returns>
        public async Task<ModifyCRWhiteListResponse> ModifyCRWhiteList(ModifyCRWhiteListRequest req)
        {
             JsonResponseModel<ModifyCRWhiteListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyCRWhiteList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCRWhiteListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改白名单列表
        /// </summary>
        /// <param name="req"><see cref="ModifyCRWhiteListRequest"/></param>
        /// <returns><see cref="ModifyCRWhiteListResponse"/></returns>
        public ModifyCRWhiteListResponse ModifyCRWhiteListSync(ModifyCRWhiteListRequest req)
        {
             JsonResponseModel<ModifyCRWhiteListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyCRWhiteList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCRWhiteListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新作品
        /// </summary>
        /// <param name="req"><see cref="UpdateCRWorkRequest"/></param>
        /// <returns><see cref="UpdateCRWorkResponse"/></returns>
        public async Task<UpdateCRWorkResponse> UpdateCRWork(UpdateCRWorkRequest req)
        {
             JsonResponseModel<UpdateCRWorkResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateCRWork");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateCRWorkResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新作品
        /// </summary>
        /// <param name="req"><see cref="UpdateCRWorkRequest"/></param>
        /// <returns><see cref="UpdateCRWorkResponse"/></returns>
        public UpdateCRWorkResponse UpdateCRWorkSync(UpdateCRWorkRequest req)
        {
             JsonResponseModel<UpdateCRWorkResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateCRWork");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateCRWorkResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
