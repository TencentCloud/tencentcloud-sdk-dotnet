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
       private const string sdkVersion = "SDK_NET_3.0.1147";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public BmaClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
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
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 添加仿冒链接（举报）
        /// </summary>
        /// <param name="req"><see cref="CreateBPFakeURLRequest"/></param>
        /// <returns><see cref="CreateBPFakeURLResponse"/></returns>
        public Task<CreateBPFakeURLResponse> CreateBPFakeURL(CreateBPFakeURLRequest req)
        {
            return InternalRequestAsync<CreateBPFakeURLResponse>(req, "CreateBPFakeURL");
        }

        /// <summary>
        /// 添加仿冒链接（举报）
        /// </summary>
        /// <param name="req"><see cref="CreateBPFakeURLRequest"/></param>
        /// <returns><see cref="CreateBPFakeURLResponse"/></returns>
        public CreateBPFakeURLResponse CreateBPFakeURLSync(CreateBPFakeURLRequest req)
        {
            return InternalRequestAsync<CreateBPFakeURLResponse>(req, "CreateBPFakeURL")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 添加误报工单
        /// </summary>
        /// <param name="req"><see cref="CreateBPFalseTicketRequest"/></param>
        /// <returns><see cref="CreateBPFalseTicketResponse"/></returns>
        public Task<CreateBPFalseTicketResponse> CreateBPFalseTicket(CreateBPFalseTicketRequest req)
        {
            return InternalRequestAsync<CreateBPFalseTicketResponse>(req, "CreateBPFalseTicket");
        }

        /// <summary>
        /// 添加误报工单
        /// </summary>
        /// <param name="req"><see cref="CreateBPFalseTicketRequest"/></param>
        /// <returns><see cref="CreateBPFalseTicketResponse"/></returns>
        public CreateBPFalseTicketResponse CreateBPFalseTicketSync(CreateBPFalseTicketRequest req)
        {
            return InternalRequestAsync<CreateBPFalseTicketResponse>(req, "CreateBPFalseTicket")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 添加下线材料
        /// </summary>
        /// <param name="req"><see cref="CreateBPOfflineAttachmentRequest"/></param>
        /// <returns><see cref="CreateBPOfflineAttachmentResponse"/></returns>
        public Task<CreateBPOfflineAttachmentResponse> CreateBPOfflineAttachment(CreateBPOfflineAttachmentRequest req)
        {
            return InternalRequestAsync<CreateBPOfflineAttachmentResponse>(req, "CreateBPOfflineAttachment");
        }

        /// <summary>
        /// 添加下线材料
        /// </summary>
        /// <param name="req"><see cref="CreateBPOfflineAttachmentRequest"/></param>
        /// <returns><see cref="CreateBPOfflineAttachmentResponse"/></returns>
        public CreateBPOfflineAttachmentResponse CreateBPOfflineAttachmentSync(CreateBPOfflineAttachmentRequest req)
        {
            return InternalRequestAsync<CreateBPOfflineAttachmentResponse>(req, "CreateBPOfflineAttachment")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 添加下线工单
        /// </summary>
        /// <param name="req"><see cref="CreateBPOfflineTicketRequest"/></param>
        /// <returns><see cref="CreateBPOfflineTicketResponse"/></returns>
        public Task<CreateBPOfflineTicketResponse> CreateBPOfflineTicket(CreateBPOfflineTicketRequest req)
        {
            return InternalRequestAsync<CreateBPOfflineTicketResponse>(req, "CreateBPOfflineTicket");
        }

        /// <summary>
        /// 添加下线工单
        /// </summary>
        /// <param name="req"><see cref="CreateBPOfflineTicketRequest"/></param>
        /// <returns><see cref="CreateBPOfflineTicketResponse"/></returns>
        public CreateBPOfflineTicketResponse CreateBPOfflineTicketSync(CreateBPOfflineTicketRequest req)
        {
            return InternalRequestAsync<CreateBPOfflineTicketResponse>(req, "CreateBPOfflineTicket")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 添加保护网站
        /// </summary>
        /// <param name="req"><see cref="CreateBPProtectURLsRequest"/></param>
        /// <returns><see cref="CreateBPProtectURLsResponse"/></returns>
        public Task<CreateBPProtectURLsResponse> CreateBPProtectURLs(CreateBPProtectURLsRequest req)
        {
            return InternalRequestAsync<CreateBPProtectURLsResponse>(req, "CreateBPProtectURLs");
        }

        /// <summary>
        /// 添加保护网站
        /// </summary>
        /// <param name="req"><see cref="CreateBPProtectURLsRequest"/></param>
        /// <returns><see cref="CreateBPProtectURLsResponse"/></returns>
        public CreateBPProtectURLsResponse CreateBPProtectURLsSync(CreateBPProtectURLsRequest req)
        {
            return InternalRequestAsync<CreateBPProtectURLsResponse>(req, "CreateBPProtectURLs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 新建协查处置
        /// </summary>
        /// <param name="req"><see cref="CreateCRBlockRequest"/></param>
        /// <returns><see cref="CreateCRBlockResponse"/></returns>
        public Task<CreateCRBlockResponse> CreateCRBlock(CreateCRBlockRequest req)
        {
            return InternalRequestAsync<CreateCRBlockResponse>(req, "CreateCRBlock");
        }

        /// <summary>
        /// 新建协查处置
        /// </summary>
        /// <param name="req"><see cref="CreateCRBlockRequest"/></param>
        /// <returns><see cref="CreateCRBlockResponse"/></returns>
        public CreateCRBlockResponse CreateCRBlockSync(CreateCRBlockRequest req)
        {
            return InternalRequestAsync<CreateCRBlockResponse>(req, "CreateCRBlock")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用于企业认证，新接入用户必须认证后才可以进行后续操作（个人认证和企业认证二选一），只需认证一次即可
        /// </summary>
        /// <param name="req"><see cref="CreateCRCompanyVerifyRequest"/></param>
        /// <returns><see cref="CreateCRCompanyVerifyResponse"/></returns>
        public Task<CreateCRCompanyVerifyResponse> CreateCRCompanyVerify(CreateCRCompanyVerifyRequest req)
        {
            return InternalRequestAsync<CreateCRCompanyVerifyResponse>(req, "CreateCRCompanyVerify");
        }

        /// <summary>
        /// 本接口用于企业认证，新接入用户必须认证后才可以进行后续操作（个人认证和企业认证二选一），只需认证一次即可
        /// </summary>
        /// <param name="req"><see cref="CreateCRCompanyVerifyRequest"/></param>
        /// <returns><see cref="CreateCRCompanyVerifyResponse"/></returns>
        public CreateCRCompanyVerifyResponse CreateCRCompanyVerifySync(CreateCRCompanyVerifyRequest req)
        {
            return InternalRequestAsync<CreateCRCompanyVerifyResponse>(req, "CreateCRCompanyVerify")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 新建过程取证码
        /// </summary>
        /// <param name="req"><see cref="CreateCRDesktopCodeRequest"/></param>
        /// <returns><see cref="CreateCRDesktopCodeResponse"/></returns>
        public Task<CreateCRDesktopCodeResponse> CreateCRDesktopCode(CreateCRDesktopCodeRequest req)
        {
            return InternalRequestAsync<CreateCRDesktopCodeResponse>(req, "CreateCRDesktopCode");
        }

        /// <summary>
        /// 新建过程取证码
        /// </summary>
        /// <param name="req"><see cref="CreateCRDesktopCodeRequest"/></param>
        /// <returns><see cref="CreateCRDesktopCodeResponse"/></returns>
        public CreateCRDesktopCodeResponse CreateCRDesktopCodeSync(CreateCRDesktopCodeRequest req)
        {
            return InternalRequestAsync<CreateCRDesktopCodeResponse>(req, "CreateCRDesktopCode")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 版权保护-新建发函接口
        /// </summary>
        /// <param name="req"><see cref="CreateCRRightRequest"/></param>
        /// <returns><see cref="CreateCRRightResponse"/></returns>
        public Task<CreateCRRightResponse> CreateCRRight(CreateCRRightRequest req)
        {
            return InternalRequestAsync<CreateCRRightResponse>(req, "CreateCRRight");
        }

        /// <summary>
        /// 版权保护-新建发函接口
        /// </summary>
        /// <param name="req"><see cref="CreateCRRightRequest"/></param>
        /// <returns><see cref="CreateCRRightResponse"/></returns>
        public CreateCRRightResponse CreateCRRightSync(CreateCRRightRequest req)
        {
            return InternalRequestAsync<CreateCRRightResponse>(req, "CreateCRRight")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 权属文件添加
        /// </summary>
        /// <param name="req"><see cref="CreateCRRightFileRequest"/></param>
        /// <returns><see cref="CreateCRRightFileResponse"/></returns>
        public Task<CreateCRRightFileResponse> CreateCRRightFile(CreateCRRightFileRequest req)
        {
            return InternalRequestAsync<CreateCRRightFileResponse>(req, "CreateCRRightFile");
        }

        /// <summary>
        /// 权属文件添加
        /// </summary>
        /// <param name="req"><see cref="CreateCRRightFileRequest"/></param>
        /// <returns><see cref="CreateCRRightFileResponse"/></returns>
        public CreateCRRightFileResponse CreateCRRightFileSync(CreateCRRightFileRequest req)
        {
            return InternalRequestAsync<CreateCRRightFileResponse>(req, "CreateCRRightFile")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 举报侵权链接
        /// </summary>
        /// <param name="req"><see cref="CreateCRTortRequest"/></param>
        /// <returns><see cref="CreateCRTortResponse"/></returns>
        public Task<CreateCRTortResponse> CreateCRTort(CreateCRTortRequest req)
        {
            return InternalRequestAsync<CreateCRTortResponse>(req, "CreateCRTort");
        }

        /// <summary>
        /// 举报侵权链接
        /// </summary>
        /// <param name="req"><see cref="CreateCRTortRequest"/></param>
        /// <returns><see cref="CreateCRTortResponse"/></returns>
        public CreateCRTortResponse CreateCRTortSync(CreateCRTortRequest req)
        {
            return InternalRequestAsync<CreateCRTortResponse>(req, "CreateCRTort")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用于个人认证，新接入用户必须认证后才可以进行后续操作（个人认证和企业认证二选一），只需认证一次即可
        /// </summary>
        /// <param name="req"><see cref="CreateCRUserVerifyRequest"/></param>
        /// <returns><see cref="CreateCRUserVerifyResponse"/></returns>
        public Task<CreateCRUserVerifyResponse> CreateCRUserVerify(CreateCRUserVerifyRequest req)
        {
            return InternalRequestAsync<CreateCRUserVerifyResponse>(req, "CreateCRUserVerify");
        }

        /// <summary>
        /// 本接口用于个人认证，新接入用户必须认证后才可以进行后续操作（个人认证和企业认证二选一），只需认证一次即可
        /// </summary>
        /// <param name="req"><see cref="CreateCRUserVerifyRequest"/></param>
        /// <returns><see cref="CreateCRUserVerifyResponse"/></returns>
        public CreateCRUserVerifyResponse CreateCRUserVerifySync(CreateCRUserVerifyRequest req)
        {
            return InternalRequestAsync<CreateCRUserVerifyResponse>(req, "CreateCRUserVerify")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 新建作品
        /// </summary>
        /// <param name="req"><see cref="CreateCRWorkRequest"/></param>
        /// <returns><see cref="CreateCRWorkResponse"/></returns>
        public Task<CreateCRWorkResponse> CreateCRWork(CreateCRWorkRequest req)
        {
            return InternalRequestAsync<CreateCRWorkResponse>(req, "CreateCRWork");
        }

        /// <summary>
        /// 新建作品
        /// </summary>
        /// <param name="req"><see cref="CreateCRWorkRequest"/></param>
        /// <returns><see cref="CreateCRWorkResponse"/></returns>
        public CreateCRWorkResponse CreateCRWorkSync(CreateCRWorkRequest req)
        {
            return InternalRequestAsync<CreateCRWorkResponse>(req, "CreateCRWork")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询企业信息
        /// </summary>
        /// <param name="req"><see cref="DescribeBPCompanyInfoRequest"/></param>
        /// <returns><see cref="DescribeBPCompanyInfoResponse"/></returns>
        public Task<DescribeBPCompanyInfoResponse> DescribeBPCompanyInfo(DescribeBPCompanyInfoRequest req)
        {
            return InternalRequestAsync<DescribeBPCompanyInfoResponse>(req, "DescribeBPCompanyInfo");
        }

        /// <summary>
        /// 查询企业信息
        /// </summary>
        /// <param name="req"><see cref="DescribeBPCompanyInfoRequest"/></param>
        /// <returns><see cref="DescribeBPCompanyInfoResponse"/></returns>
        public DescribeBPCompanyInfoResponse DescribeBPCompanyInfoSync(DescribeBPCompanyInfoRequest req)
        {
            return InternalRequestAsync<DescribeBPCompanyInfoResponse>(req, "DescribeBPCompanyInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询仿冒链接
        /// </summary>
        /// <param name="req"><see cref="DescribeBPFakeURLsRequest"/></param>
        /// <returns><see cref="DescribeBPFakeURLsResponse"/></returns>
        public Task<DescribeBPFakeURLsResponse> DescribeBPFakeURLs(DescribeBPFakeURLsRequest req)
        {
            return InternalRequestAsync<DescribeBPFakeURLsResponse>(req, "DescribeBPFakeURLs");
        }

        /// <summary>
        /// 查询仿冒链接
        /// </summary>
        /// <param name="req"><see cref="DescribeBPFakeURLsRequest"/></param>
        /// <returns><see cref="DescribeBPFakeURLsResponse"/></returns>
        public DescribeBPFakeURLsResponse DescribeBPFakeURLsSync(DescribeBPFakeURLsRequest req)
        {
            return InternalRequestAsync<DescribeBPFakeURLsResponse>(req, "DescribeBPFakeURLs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询保护网站
        /// </summary>
        /// <param name="req"><see cref="DescribeBPProtectURLsRequest"/></param>
        /// <returns><see cref="DescribeBPProtectURLsResponse"/></returns>
        public Task<DescribeBPProtectURLsResponse> DescribeBPProtectURLs(DescribeBPProtectURLsRequest req)
        {
            return InternalRequestAsync<DescribeBPProtectURLsResponse>(req, "DescribeBPProtectURLs");
        }

        /// <summary>
        /// 查询保护网站
        /// </summary>
        /// <param name="req"><see cref="DescribeBPProtectURLsRequest"/></param>
        /// <returns><see cref="DescribeBPProtectURLsResponse"/></returns>
        public DescribeBPProtectURLsResponse DescribeBPProtectURLsSync(DescribeBPProtectURLsRequest req)
        {
            return InternalRequestAsync<DescribeBPProtectURLsResponse>(req, "DescribeBPProtectURLs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询举报列表
        /// </summary>
        /// <param name="req"><see cref="DescribeBPReportFakeURLsRequest"/></param>
        /// <returns><see cref="DescribeBPReportFakeURLsResponse"/></returns>
        public Task<DescribeBPReportFakeURLsResponse> DescribeBPReportFakeURLs(DescribeBPReportFakeURLsRequest req)
        {
            return InternalRequestAsync<DescribeBPReportFakeURLsResponse>(req, "DescribeBPReportFakeURLs");
        }

        /// <summary>
        /// 查询举报列表
        /// </summary>
        /// <param name="req"><see cref="DescribeBPReportFakeURLsRequest"/></param>
        /// <returns><see cref="DescribeBPReportFakeURLsResponse"/></returns>
        public DescribeBPReportFakeURLsResponse DescribeBPReportFakeURLsSync(DescribeBPReportFakeURLsRequest req)
        {
            return InternalRequestAsync<DescribeBPReportFakeURLsResponse>(req, "DescribeBPReportFakeURLs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 版权保护-查询作品监测详情接口
        /// </summary>
        /// <param name="req"><see cref="DescribeCRMonitorDetailRequest"/></param>
        /// <returns><see cref="DescribeCRMonitorDetailResponse"/></returns>
        public Task<DescribeCRMonitorDetailResponse> DescribeCRMonitorDetail(DescribeCRMonitorDetailRequest req)
        {
            return InternalRequestAsync<DescribeCRMonitorDetailResponse>(req, "DescribeCRMonitorDetail");
        }

        /// <summary>
        /// 版权保护-查询作品监测详情接口
        /// </summary>
        /// <param name="req"><see cref="DescribeCRMonitorDetailRequest"/></param>
        /// <returns><see cref="DescribeCRMonitorDetailResponse"/></returns>
        public DescribeCRMonitorDetailResponse DescribeCRMonitorDetailSync(DescribeCRMonitorDetailRequest req)
        {
            return InternalRequestAsync<DescribeCRMonitorDetailResponse>(req, "DescribeCRMonitorDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 版权保护-查询监测列表接口
        /// </summary>
        /// <param name="req"><see cref="DescribeCRMonitorsRequest"/></param>
        /// <returns><see cref="DescribeCRMonitorsResponse"/></returns>
        public Task<DescribeCRMonitorsResponse> DescribeCRMonitors(DescribeCRMonitorsRequest req)
        {
            return InternalRequestAsync<DescribeCRMonitorsResponse>(req, "DescribeCRMonitors");
        }

        /// <summary>
        /// 版权保护-查询监测列表接口
        /// </summary>
        /// <param name="req"><see cref="DescribeCRMonitorsRequest"/></param>
        /// <returns><see cref="DescribeCRMonitorsResponse"/></returns>
        public DescribeCRMonitorsResponse DescribeCRMonitorsSync(DescribeCRMonitorsRequest req)
        {
            return InternalRequestAsync<DescribeCRMonitorsResponse>(req, "DescribeCRMonitors")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询取证详情
        /// </summary>
        /// <param name="req"><see cref="DescribeCRObtainDetailRequest"/></param>
        /// <returns><see cref="DescribeCRObtainDetailResponse"/></returns>
        public Task<DescribeCRObtainDetailResponse> DescribeCRObtainDetail(DescribeCRObtainDetailRequest req)
        {
            return InternalRequestAsync<DescribeCRObtainDetailResponse>(req, "DescribeCRObtainDetail");
        }

        /// <summary>
        /// 查询取证详情
        /// </summary>
        /// <param name="req"><see cref="DescribeCRObtainDetailRequest"/></param>
        /// <returns><see cref="DescribeCRObtainDetailResponse"/></returns>
        public DescribeCRObtainDetailResponse DescribeCRObtainDetailSync(DescribeCRObtainDetailRequest req)
        {
            return InternalRequestAsync<DescribeCRObtainDetailResponse>(req, "DescribeCRObtainDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询作品基本信息
        /// </summary>
        /// <param name="req"><see cref="DescribeCRWorkInfoRequest"/></param>
        /// <returns><see cref="DescribeCRWorkInfoResponse"/></returns>
        public Task<DescribeCRWorkInfoResponse> DescribeCRWorkInfo(DescribeCRWorkInfoRequest req)
        {
            return InternalRequestAsync<DescribeCRWorkInfoResponse>(req, "DescribeCRWorkInfo");
        }

        /// <summary>
        /// 查询作品基本信息
        /// </summary>
        /// <param name="req"><see cref="DescribeCRWorkInfoRequest"/></param>
        /// <returns><see cref="DescribeCRWorkInfoResponse"/></returns>
        public DescribeCRWorkInfoResponse DescribeCRWorkInfoSync(DescribeCRWorkInfoRequest req)
        {
            return InternalRequestAsync<DescribeCRWorkInfoResponse>(req, "DescribeCRWorkInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改下线材料
        /// </summary>
        /// <param name="req"><see cref="ModifyBPOfflineAttachmentRequest"/></param>
        /// <returns><see cref="ModifyBPOfflineAttachmentResponse"/></returns>
        public Task<ModifyBPOfflineAttachmentResponse> ModifyBPOfflineAttachment(ModifyBPOfflineAttachmentRequest req)
        {
            return InternalRequestAsync<ModifyBPOfflineAttachmentResponse>(req, "ModifyBPOfflineAttachment");
        }

        /// <summary>
        /// 修改下线材料
        /// </summary>
        /// <param name="req"><see cref="ModifyBPOfflineAttachmentRequest"/></param>
        /// <returns><see cref="ModifyBPOfflineAttachmentResponse"/></returns>
        public ModifyBPOfflineAttachmentResponse ModifyBPOfflineAttachmentSync(ModifyBPOfflineAttachmentRequest req)
        {
            return InternalRequestAsync<ModifyBPOfflineAttachmentResponse>(req, "ModifyBPOfflineAttachment")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 协查处置申请
        /// </summary>
        /// <param name="req"><see cref="ModifyCRBlockStatusRequest"/></param>
        /// <returns><see cref="ModifyCRBlockStatusResponse"/></returns>
        public Task<ModifyCRBlockStatusResponse> ModifyCRBlockStatus(ModifyCRBlockStatusRequest req)
        {
            return InternalRequestAsync<ModifyCRBlockStatusResponse>(req, "ModifyCRBlockStatus");
        }

        /// <summary>
        /// 协查处置申请
        /// </summary>
        /// <param name="req"><see cref="ModifyCRBlockStatusRequest"/></param>
        /// <returns><see cref="ModifyCRBlockStatusResponse"/></returns>
        public ModifyCRBlockStatusResponse ModifyCRBlockStatusSync(ModifyCRBlockStatusRequest req)
        {
            return InternalRequestAsync<ModifyCRBlockStatusResponse>(req, "ModifyCRBlockStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 开启/关闭监测
        /// </summary>
        /// <param name="req"><see cref="ModifyCRMonitorRequest"/></param>
        /// <returns><see cref="ModifyCRMonitorResponse"/></returns>
        public Task<ModifyCRMonitorResponse> ModifyCRMonitor(ModifyCRMonitorRequest req)
        {
            return InternalRequestAsync<ModifyCRMonitorResponse>(req, "ModifyCRMonitor");
        }

        /// <summary>
        /// 开启/关闭监测
        /// </summary>
        /// <param name="req"><see cref="ModifyCRMonitorRequest"/></param>
        /// <returns><see cref="ModifyCRMonitorResponse"/></returns>
        public ModifyCRMonitorResponse ModifyCRMonitorSync(ModifyCRMonitorRequest req)
        {
            return InternalRequestAsync<ModifyCRMonitorResponse>(req, "ModifyCRMonitor")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 取证申请
        /// </summary>
        /// <param name="req"><see cref="ModifyCRObtainStatusRequest"/></param>
        /// <returns><see cref="ModifyCRObtainStatusResponse"/></returns>
        public Task<ModifyCRObtainStatusResponse> ModifyCRObtainStatus(ModifyCRObtainStatusRequest req)
        {
            return InternalRequestAsync<ModifyCRObtainStatusResponse>(req, "ModifyCRObtainStatus");
        }

        /// <summary>
        /// 取证申请
        /// </summary>
        /// <param name="req"><see cref="ModifyCRObtainStatusRequest"/></param>
        /// <returns><see cref="ModifyCRObtainStatusResponse"/></returns>
        public ModifyCRObtainStatusResponse ModifyCRObtainStatusSync(ModifyCRObtainStatusRequest req)
        {
            return InternalRequestAsync<ModifyCRObtainStatusResponse>(req, "ModifyCRObtainStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 发函申请
        /// </summary>
        /// <param name="req"><see cref="ModifyCRRightStatusRequest"/></param>
        /// <returns><see cref="ModifyCRRightStatusResponse"/></returns>
        public Task<ModifyCRRightStatusResponse> ModifyCRRightStatus(ModifyCRRightStatusRequest req)
        {
            return InternalRequestAsync<ModifyCRRightStatusResponse>(req, "ModifyCRRightStatus");
        }

        /// <summary>
        /// 发函申请
        /// </summary>
        /// <param name="req"><see cref="ModifyCRRightStatusRequest"/></param>
        /// <returns><see cref="ModifyCRRightStatusResponse"/></returns>
        public ModifyCRRightStatusResponse ModifyCRRightStatusSync(ModifyCRRightStatusRequest req)
        {
            return InternalRequestAsync<ModifyCRRightStatusResponse>(req, "ModifyCRRightStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改白名单列表
        /// </summary>
        /// <param name="req"><see cref="ModifyCRWhiteListRequest"/></param>
        /// <returns><see cref="ModifyCRWhiteListResponse"/></returns>
        public Task<ModifyCRWhiteListResponse> ModifyCRWhiteList(ModifyCRWhiteListRequest req)
        {
            return InternalRequestAsync<ModifyCRWhiteListResponse>(req, "ModifyCRWhiteList");
        }

        /// <summary>
        /// 修改白名单列表
        /// </summary>
        /// <param name="req"><see cref="ModifyCRWhiteListRequest"/></param>
        /// <returns><see cref="ModifyCRWhiteListResponse"/></returns>
        public ModifyCRWhiteListResponse ModifyCRWhiteListSync(ModifyCRWhiteListRequest req)
        {
            return InternalRequestAsync<ModifyCRWhiteListResponse>(req, "ModifyCRWhiteList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新作品
        /// </summary>
        /// <param name="req"><see cref="UpdateCRWorkRequest"/></param>
        /// <returns><see cref="UpdateCRWorkResponse"/></returns>
        public Task<UpdateCRWorkResponse> UpdateCRWork(UpdateCRWorkRequest req)
        {
            return InternalRequestAsync<UpdateCRWorkResponse>(req, "UpdateCRWork");
        }

        /// <summary>
        /// 更新作品
        /// </summary>
        /// <param name="req"><see cref="UpdateCRWorkRequest"/></param>
        /// <returns><see cref="UpdateCRWorkResponse"/></returns>
        public UpdateCRWorkResponse UpdateCRWorkSync(UpdateCRWorkRequest req)
        {
            return InternalRequestAsync<UpdateCRWorkResponse>(req, "UpdateCRWork")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
