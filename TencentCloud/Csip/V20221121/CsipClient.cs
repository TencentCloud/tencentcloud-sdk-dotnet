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

namespace TencentCloud.Csip.V20221121
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Csip.V20221121.Models;

   public class CsipClient : AbstractClient{

       private const string endpoint = "csip.tencentcloudapi.com";
       private const string version = "2022-11-21";
       private const string sdkVersion = "SDK_NET_3.0.995";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public CsipClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public CsipClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// csip角色授权绑定接口
        /// </summary>
        /// <param name="req"><see cref="AddNewBindRoleUserRequest"/></param>
        /// <returns><see cref="AddNewBindRoleUserResponse"/></returns>
        public Task<AddNewBindRoleUserResponse> AddNewBindRoleUser(AddNewBindRoleUserRequest req)
        {
            return InternalRequestAsync<AddNewBindRoleUserResponse>(req, "AddNewBindRoleUser");
        }

        /// <summary>
        /// csip角色授权绑定接口
        /// </summary>
        /// <param name="req"><see cref="AddNewBindRoleUserRequest"/></param>
        /// <returns><see cref="AddNewBindRoleUserResponse"/></returns>
        public AddNewBindRoleUserResponse AddNewBindRoleUserSync(AddNewBindRoleUserRequest req)
        {
            return InternalRequestAsync<AddNewBindRoleUserResponse>(req, "AddNewBindRoleUser")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建域名、ip相关信息
        /// </summary>
        /// <param name="req"><see cref="CreateDomainAndIpRequest"/></param>
        /// <returns><see cref="CreateDomainAndIpResponse"/></returns>
        public Task<CreateDomainAndIpResponse> CreateDomainAndIp(CreateDomainAndIpRequest req)
        {
            return InternalRequestAsync<CreateDomainAndIpResponse>(req, "CreateDomainAndIp");
        }

        /// <summary>
        /// 创建域名、ip相关信息
        /// </summary>
        /// <param name="req"><see cref="CreateDomainAndIpRequest"/></param>
        /// <returns><see cref="CreateDomainAndIpResponse"/></returns>
        public CreateDomainAndIpResponse CreateDomainAndIpSync(CreateDomainAndIpRequest req)
        {
            return InternalRequestAsync<CreateDomainAndIpResponse>(req, "CreateDomainAndIp")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建风险中心扫描任务
        /// </summary>
        /// <param name="req"><see cref="CreateRiskCenterScanTaskRequest"/></param>
        /// <returns><see cref="CreateRiskCenterScanTaskResponse"/></returns>
        public Task<CreateRiskCenterScanTaskResponse> CreateRiskCenterScanTask(CreateRiskCenterScanTaskRequest req)
        {
            return InternalRequestAsync<CreateRiskCenterScanTaskResponse>(req, "CreateRiskCenterScanTask");
        }

        /// <summary>
        /// 创建风险中心扫描任务
        /// </summary>
        /// <param name="req"><see cref="CreateRiskCenterScanTaskRequest"/></param>
        /// <returns><see cref="CreateRiskCenterScanTaskResponse"/></returns>
        public CreateRiskCenterScanTaskResponse CreateRiskCenterScanTaskSync(CreateRiskCenterScanTaskRequest req)
        {
            return InternalRequestAsync<CreateRiskCenterScanTaskResponse>(req, "CreateRiskCenterScanTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除域名和ip请求
        /// </summary>
        /// <param name="req"><see cref="DeleteDomainAndIpRequest"/></param>
        /// <returns><see cref="DeleteDomainAndIpResponse"/></returns>
        public Task<DeleteDomainAndIpResponse> DeleteDomainAndIp(DeleteDomainAndIpRequest req)
        {
            return InternalRequestAsync<DeleteDomainAndIpResponse>(req, "DeleteDomainAndIp");
        }

        /// <summary>
        /// 删除域名和ip请求
        /// </summary>
        /// <param name="req"><see cref="DeleteDomainAndIpRequest"/></param>
        /// <returns><see cref="DeleteDomainAndIpResponse"/></returns>
        public DeleteDomainAndIpResponse DeleteDomainAndIpSync(DeleteDomainAndIpRequest req)
        {
            return InternalRequestAsync<DeleteDomainAndIpResponse>(req, "DeleteDomainAndIp")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除风险中心扫描任务
        /// </summary>
        /// <param name="req"><see cref="DeleteRiskScanTaskRequest"/></param>
        /// <returns><see cref="DeleteRiskScanTaskResponse"/></returns>
        public Task<DeleteRiskScanTaskResponse> DeleteRiskScanTask(DeleteRiskScanTaskRequest req)
        {
            return InternalRequestAsync<DeleteRiskScanTaskResponse>(req, "DeleteRiskScanTask");
        }

        /// <summary>
        /// 删除风险中心扫描任务
        /// </summary>
        /// <param name="req"><see cref="DeleteRiskScanTaskRequest"/></param>
        /// <returns><see cref="DeleteRiskScanTaskResponse"/></returns>
        public DeleteRiskScanTaskResponse DeleteRiskScanTaskSync(DeleteRiskScanTaskRequest req)
        {
            return InternalRequestAsync<DeleteRiskScanTaskResponse>(req, "DeleteRiskScanTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 告警中心全量告警列表接口
        /// </summary>
        /// <param name="req"><see cref="DescribeAlertListRequest"/></param>
        /// <returns><see cref="DescribeAlertListResponse"/></returns>
        public Task<DescribeAlertListResponse> DescribeAlertList(DescribeAlertListRequest req)
        {
            return InternalRequestAsync<DescribeAlertListResponse>(req, "DescribeAlertList");
        }

        /// <summary>
        /// 告警中心全量告警列表接口
        /// </summary>
        /// <param name="req"><see cref="DescribeAlertListRequest"/></param>
        /// <returns><see cref="DescribeAlertListResponse"/></returns>
        public DescribeAlertListResponse DescribeAlertListSync(DescribeAlertListRequest req)
        {
            return InternalRequestAsync<DescribeAlertListResponse>(req, "DescribeAlertList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取资产视角的漏洞风险列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetViewVulRiskListRequest"/></param>
        /// <returns><see cref="DescribeAssetViewVulRiskListResponse"/></returns>
        public Task<DescribeAssetViewVulRiskListResponse> DescribeAssetViewVulRiskList(DescribeAssetViewVulRiskListRequest req)
        {
            return InternalRequestAsync<DescribeAssetViewVulRiskListResponse>(req, "DescribeAssetViewVulRiskList");
        }

        /// <summary>
        /// 获取资产视角的漏洞风险列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetViewVulRiskListRequest"/></param>
        /// <returns><see cref="DescribeAssetViewVulRiskListResponse"/></returns>
        public DescribeAssetViewVulRiskListResponse DescribeAssetViewVulRiskListSync(DescribeAssetViewVulRiskListRequest req)
        {
            return InternalRequestAsync<DescribeAssetViewVulRiskListResponse>(req, "DescribeAssetViewVulRiskList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// cvm详情
        /// </summary>
        /// <param name="req"><see cref="DescribeCVMAssetInfoRequest"/></param>
        /// <returns><see cref="DescribeCVMAssetInfoResponse"/></returns>
        public Task<DescribeCVMAssetInfoResponse> DescribeCVMAssetInfo(DescribeCVMAssetInfoRequest req)
        {
            return InternalRequestAsync<DescribeCVMAssetInfoResponse>(req, "DescribeCVMAssetInfo");
        }

        /// <summary>
        /// cvm详情
        /// </summary>
        /// <param name="req"><see cref="DescribeCVMAssetInfoRequest"/></param>
        /// <returns><see cref="DescribeCVMAssetInfoResponse"/></returns>
        public DescribeCVMAssetInfoResponse DescribeCVMAssetInfoSync(DescribeCVMAssetInfoRequest req)
        {
            return InternalRequestAsync<DescribeCVMAssetInfoResponse>(req, "DescribeCVMAssetInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// cvm列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCVMAssetsRequest"/></param>
        /// <returns><see cref="DescribeCVMAssetsResponse"/></returns>
        public Task<DescribeCVMAssetsResponse> DescribeCVMAssets(DescribeCVMAssetsRequest req)
        {
            return InternalRequestAsync<DescribeCVMAssetsResponse>(req, "DescribeCVMAssets");
        }

        /// <summary>
        /// cvm列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCVMAssetsRequest"/></param>
        /// <returns><see cref="DescribeCVMAssetsResponse"/></returns>
        public DescribeCVMAssetsResponse DescribeCVMAssetsSync(DescribeCVMAssetsRequest req)
        {
            return InternalRequestAsync<DescribeCVMAssetsResponse>(req, "DescribeCVMAssets")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 集群pod列表
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterPodAssetsRequest"/></param>
        /// <returns><see cref="DescribeClusterPodAssetsResponse"/></returns>
        public Task<DescribeClusterPodAssetsResponse> DescribeClusterPodAssets(DescribeClusterPodAssetsRequest req)
        {
            return InternalRequestAsync<DescribeClusterPodAssetsResponse>(req, "DescribeClusterPodAssets");
        }

        /// <summary>
        /// 集群pod列表
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterPodAssetsRequest"/></param>
        /// <returns><see cref="DescribeClusterPodAssetsResponse"/></returns>
        public DescribeClusterPodAssetsResponse DescribeClusterPodAssetsSync(DescribeClusterPodAssetsRequest req)
        {
            return InternalRequestAsync<DescribeClusterPodAssetsResponse>(req, "DescribeClusterPodAssets")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// db资产详情
        /// </summary>
        /// <param name="req"><see cref="DescribeDbAssetInfoRequest"/></param>
        /// <returns><see cref="DescribeDbAssetInfoResponse"/></returns>
        public Task<DescribeDbAssetInfoResponse> DescribeDbAssetInfo(DescribeDbAssetInfoRequest req)
        {
            return InternalRequestAsync<DescribeDbAssetInfoResponse>(req, "DescribeDbAssetInfo");
        }

        /// <summary>
        /// db资产详情
        /// </summary>
        /// <param name="req"><see cref="DescribeDbAssetInfoRequest"/></param>
        /// <returns><see cref="DescribeDbAssetInfoResponse"/></returns>
        public DescribeDbAssetInfoResponse DescribeDbAssetInfoSync(DescribeDbAssetInfoRequest req)
        {
            return InternalRequestAsync<DescribeDbAssetInfoResponse>(req, "DescribeDbAssetInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 数据库资产列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDbAssetsRequest"/></param>
        /// <returns><see cref="DescribeDbAssetsResponse"/></returns>
        public Task<DescribeDbAssetsResponse> DescribeDbAssets(DescribeDbAssetsRequest req)
        {
            return InternalRequestAsync<DescribeDbAssetsResponse>(req, "DescribeDbAssets");
        }

        /// <summary>
        /// 数据库资产列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDbAssetsRequest"/></param>
        /// <returns><see cref="DescribeDbAssetsResponse"/></returns>
        public DescribeDbAssetsResponse DescribeDbAssetsSync(DescribeDbAssetsRequest req)
        {
            return InternalRequestAsync<DescribeDbAssetsResponse>(req, "DescribeDbAssets")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 域名列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDomainAssetsRequest"/></param>
        /// <returns><see cref="DescribeDomainAssetsResponse"/></returns>
        public Task<DescribeDomainAssetsResponse> DescribeDomainAssets(DescribeDomainAssetsRequest req)
        {
            return InternalRequestAsync<DescribeDomainAssetsResponse>(req, "DescribeDomainAssets");
        }

        /// <summary>
        /// 域名列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDomainAssetsRequest"/></param>
        /// <returns><see cref="DescribeDomainAssetsResponse"/></returns>
        public DescribeDomainAssetsResponse DescribeDomainAssetsSync(DescribeDomainAssetsRequest req)
        {
            return InternalRequestAsync<DescribeDomainAssetsResponse>(req, "DescribeDomainAssets")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取网关列表
        /// </summary>
        /// <param name="req"><see cref="DescribeGatewayAssetsRequest"/></param>
        /// <returns><see cref="DescribeGatewayAssetsResponse"/></returns>
        public Task<DescribeGatewayAssetsResponse> DescribeGatewayAssets(DescribeGatewayAssetsRequest req)
        {
            return InternalRequestAsync<DescribeGatewayAssetsResponse>(req, "DescribeGatewayAssets");
        }

        /// <summary>
        /// 获取网关列表
        /// </summary>
        /// <param name="req"><see cref="DescribeGatewayAssetsRequest"/></param>
        /// <returns><see cref="DescribeGatewayAssetsResponse"/></returns>
        public DescribeGatewayAssetsResponse DescribeGatewayAssetsSync(DescribeGatewayAssetsRequest req)
        {
            return InternalRequestAsync<DescribeGatewayAssetsResponse>(req, "DescribeGatewayAssets")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询clb监听器列表
        /// </summary>
        /// <param name="req"><see cref="DescribeListenerListRequest"/></param>
        /// <returns><see cref="DescribeListenerListResponse"/></returns>
        public Task<DescribeListenerListResponse> DescribeListenerList(DescribeListenerListRequest req)
        {
            return InternalRequestAsync<DescribeListenerListResponse>(req, "DescribeListenerList");
        }

        /// <summary>
        /// 查询clb监听器列表
        /// </summary>
        /// <param name="req"><see cref="DescribeListenerListRequest"/></param>
        /// <returns><see cref="DescribeListenerListResponse"/></returns>
        public DescribeListenerListResponse DescribeListenerListSync(DescribeListenerListRequest req)
        {
            return InternalRequestAsync<DescribeListenerListResponse>(req, "DescribeListenerList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取网卡列表
        /// </summary>
        /// <param name="req"><see cref="DescribeNICAssetsRequest"/></param>
        /// <returns><see cref="DescribeNICAssetsResponse"/></returns>
        public Task<DescribeNICAssetsResponse> DescribeNICAssets(DescribeNICAssetsRequest req)
        {
            return InternalRequestAsync<DescribeNICAssetsResponse>(req, "DescribeNICAssets");
        }

        /// <summary>
        /// 获取网卡列表
        /// </summary>
        /// <param name="req"><see cref="DescribeNICAssetsRequest"/></param>
        /// <returns><see cref="DescribeNICAssetsResponse"/></returns>
        public DescribeNICAssetsResponse DescribeNICAssetsSync(DescribeNICAssetsRequest req)
        {
            return InternalRequestAsync<DescribeNICAssetsResponse>(req, "DescribeNICAssets")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询集团账号用户列表
        /// </summary>
        /// <param name="req"><see cref="DescribeOrganizationUserInfoRequest"/></param>
        /// <returns><see cref="DescribeOrganizationUserInfoResponse"/></returns>
        public Task<DescribeOrganizationUserInfoResponse> DescribeOrganizationUserInfo(DescribeOrganizationUserInfoRequest req)
        {
            return InternalRequestAsync<DescribeOrganizationUserInfoResponse>(req, "DescribeOrganizationUserInfo");
        }

        /// <summary>
        /// 查询集团账号用户列表
        /// </summary>
        /// <param name="req"><see cref="DescribeOrganizationUserInfoRequest"/></param>
        /// <returns><see cref="DescribeOrganizationUserInfoResponse"/></returns>
        public DescribeOrganizationUserInfoResponse DescribeOrganizationUserInfoSync(DescribeOrganizationUserInfoRequest req)
        {
            return InternalRequestAsync<DescribeOrganizationUserInfoResponse>(req, "DescribeOrganizationUserInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// ip公网列表
        /// </summary>
        /// <param name="req"><see cref="DescribePublicIpAssetsRequest"/></param>
        /// <returns><see cref="DescribePublicIpAssetsResponse"/></returns>
        public Task<DescribePublicIpAssetsResponse> DescribePublicIpAssets(DescribePublicIpAssetsRequest req)
        {
            return InternalRequestAsync<DescribePublicIpAssetsResponse>(req, "DescribePublicIpAssets");
        }

        /// <summary>
        /// ip公网列表
        /// </summary>
        /// <param name="req"><see cref="DescribePublicIpAssetsRequest"/></param>
        /// <returns><see cref="DescribePublicIpAssetsResponse"/></returns>
        public DescribePublicIpAssetsResponse DescribePublicIpAssetsSync(DescribePublicIpAssetsRequest req)
        {
            return InternalRequestAsync<DescribePublicIpAssetsResponse>(req, "DescribePublicIpAssets")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取资产视角的配置风险列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRiskCenterAssetViewCFGRiskListRequest"/></param>
        /// <returns><see cref="DescribeRiskCenterAssetViewCFGRiskListResponse"/></returns>
        public Task<DescribeRiskCenterAssetViewCFGRiskListResponse> DescribeRiskCenterAssetViewCFGRiskList(DescribeRiskCenterAssetViewCFGRiskListRequest req)
        {
            return InternalRequestAsync<DescribeRiskCenterAssetViewCFGRiskListResponse>(req, "DescribeRiskCenterAssetViewCFGRiskList");
        }

        /// <summary>
        /// 获取资产视角的配置风险列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRiskCenterAssetViewCFGRiskListRequest"/></param>
        /// <returns><see cref="DescribeRiskCenterAssetViewCFGRiskListResponse"/></returns>
        public DescribeRiskCenterAssetViewCFGRiskListResponse DescribeRiskCenterAssetViewCFGRiskListSync(DescribeRiskCenterAssetViewCFGRiskListRequest req)
        {
            return InternalRequestAsync<DescribeRiskCenterAssetViewCFGRiskListResponse>(req, "DescribeRiskCenterAssetViewCFGRiskList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取资产视角的端口风险列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRiskCenterAssetViewPortRiskListRequest"/></param>
        /// <returns><see cref="DescribeRiskCenterAssetViewPortRiskListResponse"/></returns>
        public Task<DescribeRiskCenterAssetViewPortRiskListResponse> DescribeRiskCenterAssetViewPortRiskList(DescribeRiskCenterAssetViewPortRiskListRequest req)
        {
            return InternalRequestAsync<DescribeRiskCenterAssetViewPortRiskListResponse>(req, "DescribeRiskCenterAssetViewPortRiskList");
        }

        /// <summary>
        /// 获取资产视角的端口风险列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRiskCenterAssetViewPortRiskListRequest"/></param>
        /// <returns><see cref="DescribeRiskCenterAssetViewPortRiskListResponse"/></returns>
        public DescribeRiskCenterAssetViewPortRiskListResponse DescribeRiskCenterAssetViewPortRiskListSync(DescribeRiskCenterAssetViewPortRiskListRequest req)
        {
            return InternalRequestAsync<DescribeRiskCenterAssetViewPortRiskListResponse>(req, "DescribeRiskCenterAssetViewPortRiskList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取资产视角的漏洞风险列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRiskCenterAssetViewVULRiskListRequest"/></param>
        /// <returns><see cref="DescribeRiskCenterAssetViewVULRiskListResponse"/></returns>
        public Task<DescribeRiskCenterAssetViewVULRiskListResponse> DescribeRiskCenterAssetViewVULRiskList(DescribeRiskCenterAssetViewVULRiskListRequest req)
        {
            return InternalRequestAsync<DescribeRiskCenterAssetViewVULRiskListResponse>(req, "DescribeRiskCenterAssetViewVULRiskList");
        }

        /// <summary>
        /// 获取资产视角的漏洞风险列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRiskCenterAssetViewVULRiskListRequest"/></param>
        /// <returns><see cref="DescribeRiskCenterAssetViewVULRiskListResponse"/></returns>
        public DescribeRiskCenterAssetViewVULRiskListResponse DescribeRiskCenterAssetViewVULRiskListSync(DescribeRiskCenterAssetViewVULRiskListRequest req)
        {
            return InternalRequestAsync<DescribeRiskCenterAssetViewVULRiskListResponse>(req, "DescribeRiskCenterAssetViewVULRiskList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取资产视角的弱口令风险列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRiskCenterAssetViewWeakPasswordRiskListRequest"/></param>
        /// <returns><see cref="DescribeRiskCenterAssetViewWeakPasswordRiskListResponse"/></returns>
        public Task<DescribeRiskCenterAssetViewWeakPasswordRiskListResponse> DescribeRiskCenterAssetViewWeakPasswordRiskList(DescribeRiskCenterAssetViewWeakPasswordRiskListRequest req)
        {
            return InternalRequestAsync<DescribeRiskCenterAssetViewWeakPasswordRiskListResponse>(req, "DescribeRiskCenterAssetViewWeakPasswordRiskList");
        }

        /// <summary>
        /// 获取资产视角的弱口令风险列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRiskCenterAssetViewWeakPasswordRiskListRequest"/></param>
        /// <returns><see cref="DescribeRiskCenterAssetViewWeakPasswordRiskListResponse"/></returns>
        public DescribeRiskCenterAssetViewWeakPasswordRiskListResponse DescribeRiskCenterAssetViewWeakPasswordRiskListSync(DescribeRiskCenterAssetViewWeakPasswordRiskListRequest req)
        {
            return InternalRequestAsync<DescribeRiskCenterAssetViewWeakPasswordRiskListResponse>(req, "DescribeRiskCenterAssetViewWeakPasswordRiskList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取端口视角的端口风险列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRiskCenterPortViewPortRiskListRequest"/></param>
        /// <returns><see cref="DescribeRiskCenterPortViewPortRiskListResponse"/></returns>
        public Task<DescribeRiskCenterPortViewPortRiskListResponse> DescribeRiskCenterPortViewPortRiskList(DescribeRiskCenterPortViewPortRiskListRequest req)
        {
            return InternalRequestAsync<DescribeRiskCenterPortViewPortRiskListResponse>(req, "DescribeRiskCenterPortViewPortRiskList");
        }

        /// <summary>
        /// 获取端口视角的端口风险列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRiskCenterPortViewPortRiskListRequest"/></param>
        /// <returns><see cref="DescribeRiskCenterPortViewPortRiskListResponse"/></returns>
        public DescribeRiskCenterPortViewPortRiskListResponse DescribeRiskCenterPortViewPortRiskListSync(DescribeRiskCenterPortViewPortRiskListRequest req)
        {
            return InternalRequestAsync<DescribeRiskCenterPortViewPortRiskListResponse>(req, "DescribeRiskCenterPortViewPortRiskList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取风险服务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRiskCenterServerRiskListRequest"/></param>
        /// <returns><see cref="DescribeRiskCenterServerRiskListResponse"/></returns>
        public Task<DescribeRiskCenterServerRiskListResponse> DescribeRiskCenterServerRiskList(DescribeRiskCenterServerRiskListRequest req)
        {
            return InternalRequestAsync<DescribeRiskCenterServerRiskListResponse>(req, "DescribeRiskCenterServerRiskList");
        }

        /// <summary>
        /// 获取风险服务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRiskCenterServerRiskListRequest"/></param>
        /// <returns><see cref="DescribeRiskCenterServerRiskListResponse"/></returns>
        public DescribeRiskCenterServerRiskListResponse DescribeRiskCenterServerRiskListSync(DescribeRiskCenterServerRiskListRequest req)
        {
            return InternalRequestAsync<DescribeRiskCenterServerRiskListResponse>(req, "DescribeRiskCenterServerRiskList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取漏洞视角的漏洞风险列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRiskCenterVULViewVULRiskListRequest"/></param>
        /// <returns><see cref="DescribeRiskCenterVULViewVULRiskListResponse"/></returns>
        public Task<DescribeRiskCenterVULViewVULRiskListResponse> DescribeRiskCenterVULViewVULRiskList(DescribeRiskCenterVULViewVULRiskListRequest req)
        {
            return InternalRequestAsync<DescribeRiskCenterVULViewVULRiskListResponse>(req, "DescribeRiskCenterVULViewVULRiskList");
        }

        /// <summary>
        /// 获取漏洞视角的漏洞风险列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRiskCenterVULViewVULRiskListRequest"/></param>
        /// <returns><see cref="DescribeRiskCenterVULViewVULRiskListResponse"/></returns>
        public DescribeRiskCenterVULViewVULRiskListResponse DescribeRiskCenterVULViewVULRiskListSync(DescribeRiskCenterVULViewVULRiskListRequest req)
        {
            return InternalRequestAsync<DescribeRiskCenterVULViewVULRiskListResponse>(req, "DescribeRiskCenterVULViewVULRiskList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取内容风险列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRiskCenterWebsiteRiskListRequest"/></param>
        /// <returns><see cref="DescribeRiskCenterWebsiteRiskListResponse"/></returns>
        public Task<DescribeRiskCenterWebsiteRiskListResponse> DescribeRiskCenterWebsiteRiskList(DescribeRiskCenterWebsiteRiskListRequest req)
        {
            return InternalRequestAsync<DescribeRiskCenterWebsiteRiskListResponse>(req, "DescribeRiskCenterWebsiteRiskList");
        }

        /// <summary>
        /// 获取内容风险列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRiskCenterWebsiteRiskListRequest"/></param>
        /// <returns><see cref="DescribeRiskCenterWebsiteRiskListResponse"/></returns>
        public DescribeRiskCenterWebsiteRiskListResponse DescribeRiskCenterWebsiteRiskListSync(DescribeRiskCenterWebsiteRiskListRequest req)
        {
            return InternalRequestAsync<DescribeRiskCenterWebsiteRiskListResponse>(req, "DescribeRiskCenterWebsiteRiskList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取扫描报告列表
        /// </summary>
        /// <param name="req"><see cref="DescribeScanReportListRequest"/></param>
        /// <returns><see cref="DescribeScanReportListResponse"/></returns>
        public Task<DescribeScanReportListResponse> DescribeScanReportList(DescribeScanReportListRequest req)
        {
            return InternalRequestAsync<DescribeScanReportListResponse>(req, "DescribeScanReportList");
        }

        /// <summary>
        /// 获取扫描报告列表
        /// </summary>
        /// <param name="req"><see cref="DescribeScanReportListRequest"/></param>
        /// <returns><see cref="DescribeScanReportListResponse"/></returns>
        public DescribeScanReportListResponse DescribeScanReportListSync(DescribeScanReportListRequest req)
        {
            return InternalRequestAsync<DescribeScanReportListResponse>(req, "DescribeScanReportList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取扫描任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeScanTaskListRequest"/></param>
        /// <returns><see cref="DescribeScanTaskListResponse"/></returns>
        public Task<DescribeScanTaskListResponse> DescribeScanTaskList(DescribeScanTaskListRequest req)
        {
            return InternalRequestAsync<DescribeScanTaskListResponse>(req, "DescribeScanTaskList");
        }

        /// <summary>
        /// 获取扫描任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeScanTaskListRequest"/></param>
        /// <returns><see cref="DescribeScanTaskListResponse"/></returns>
        public DescribeScanTaskListResponse DescribeScanTaskListSync(DescribeScanTaskListRequest req)
        {
            return InternalRequestAsync<DescribeScanTaskListResponse>(req, "DescribeScanTaskList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 立体防护中心查询漏洞信息
        /// </summary>
        /// <param name="req"><see cref="DescribeSearchBugInfoRequest"/></param>
        /// <returns><see cref="DescribeSearchBugInfoResponse"/></returns>
        public Task<DescribeSearchBugInfoResponse> DescribeSearchBugInfo(DescribeSearchBugInfoRequest req)
        {
            return InternalRequestAsync<DescribeSearchBugInfoResponse>(req, "DescribeSearchBugInfo");
        }

        /// <summary>
        /// 立体防护中心查询漏洞信息
        /// </summary>
        /// <param name="req"><see cref="DescribeSearchBugInfoRequest"/></param>
        /// <returns><see cref="DescribeSearchBugInfoResponse"/></returns>
        public DescribeSearchBugInfoResponse DescribeSearchBugInfoSync(DescribeSearchBugInfoRequest req)
        {
            return InternalRequestAsync<DescribeSearchBugInfoResponse>(req, "DescribeSearchBugInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取子网列表
        /// </summary>
        /// <param name="req"><see cref="DescribeSubnetAssetsRequest"/></param>
        /// <returns><see cref="DescribeSubnetAssetsResponse"/></returns>
        public Task<DescribeSubnetAssetsResponse> DescribeSubnetAssets(DescribeSubnetAssetsRequest req)
        {
            return InternalRequestAsync<DescribeSubnetAssetsResponse>(req, "DescribeSubnetAssets");
        }

        /// <summary>
        /// 获取子网列表
        /// </summary>
        /// <param name="req"><see cref="DescribeSubnetAssetsRequest"/></param>
        /// <returns><see cref="DescribeSubnetAssetsResponse"/></returns>
        public DescribeSubnetAssetsResponse DescribeSubnetAssetsSync(DescribeSubnetAssetsRequest req)
        {
            return InternalRequestAsync<DescribeSubnetAssetsResponse>(req, "DescribeSubnetAssets")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取任务扫描报告列表
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskLogListRequest"/></param>
        /// <returns><see cref="DescribeTaskLogListResponse"/></returns>
        public Task<DescribeTaskLogListResponse> DescribeTaskLogList(DescribeTaskLogListRequest req)
        {
            return InternalRequestAsync<DescribeTaskLogListResponse>(req, "DescribeTaskLogList");
        }

        /// <summary>
        /// 获取任务扫描报告列表
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskLogListRequest"/></param>
        /// <returns><see cref="DescribeTaskLogListResponse"/></returns>
        public DescribeTaskLogListResponse DescribeTaskLogListSync(DescribeTaskLogListRequest req)
        {
            return InternalRequestAsync<DescribeTaskLogListResponse>(req, "DescribeTaskLogList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取报告下载的临时链接
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskLogURLRequest"/></param>
        /// <returns><see cref="DescribeTaskLogURLResponse"/></returns>
        public Task<DescribeTaskLogURLResponse> DescribeTaskLogURL(DescribeTaskLogURLRequest req)
        {
            return InternalRequestAsync<DescribeTaskLogURLResponse>(req, "DescribeTaskLogURL");
        }

        /// <summary>
        /// 获取报告下载的临时链接
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskLogURLRequest"/></param>
        /// <returns><see cref="DescribeTaskLogURLResponse"/></returns>
        public DescribeTaskLogURLResponse DescribeTaskLogURLSync(DescribeTaskLogURLRequest req)
        {
            return InternalRequestAsync<DescribeTaskLogURLResponse>(req, "DescribeTaskLogURL")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询TOP攻击信息
        /// </summary>
        /// <param name="req"><see cref="DescribeTopAttackInfoRequest"/></param>
        /// <returns><see cref="DescribeTopAttackInfoResponse"/></returns>
        public Task<DescribeTopAttackInfoResponse> DescribeTopAttackInfo(DescribeTopAttackInfoRequest req)
        {
            return InternalRequestAsync<DescribeTopAttackInfoResponse>(req, "DescribeTopAttackInfo");
        }

        /// <summary>
        /// 查询TOP攻击信息
        /// </summary>
        /// <param name="req"><see cref="DescribeTopAttackInfoRequest"/></param>
        /// <returns><see cref="DescribeTopAttackInfoResponse"/></returns>
        public DescribeTopAttackInfoResponse DescribeTopAttackInfoSync(DescribeTopAttackInfoRequest req)
        {
            return InternalRequestAsync<DescribeTopAttackInfoResponse>(req, "DescribeTopAttackInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询漏洞风险高级配置
        /// </summary>
        /// <param name="req"><see cref="DescribeVULRiskAdvanceCFGListRequest"/></param>
        /// <returns><see cref="DescribeVULRiskAdvanceCFGListResponse"/></returns>
        public Task<DescribeVULRiskAdvanceCFGListResponse> DescribeVULRiskAdvanceCFGList(DescribeVULRiskAdvanceCFGListRequest req)
        {
            return InternalRequestAsync<DescribeVULRiskAdvanceCFGListResponse>(req, "DescribeVULRiskAdvanceCFGList");
        }

        /// <summary>
        /// 查询漏洞风险高级配置
        /// </summary>
        /// <param name="req"><see cref="DescribeVULRiskAdvanceCFGListRequest"/></param>
        /// <returns><see cref="DescribeVULRiskAdvanceCFGListResponse"/></returns>
        public DescribeVULRiskAdvanceCFGListResponse DescribeVULRiskAdvanceCFGListSync(DescribeVULRiskAdvanceCFGListRequest req)
        {
            return InternalRequestAsync<DescribeVULRiskAdvanceCFGListResponse>(req, "DescribeVULRiskAdvanceCFGList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取vpc列表
        /// </summary>
        /// <param name="req"><see cref="DescribeVpcAssetsRequest"/></param>
        /// <returns><see cref="DescribeVpcAssetsResponse"/></returns>
        public Task<DescribeVpcAssetsResponse> DescribeVpcAssets(DescribeVpcAssetsRequest req)
        {
            return InternalRequestAsync<DescribeVpcAssetsResponse>(req, "DescribeVpcAssets");
        }

        /// <summary>
        /// 获取vpc列表
        /// </summary>
        /// <param name="req"><see cref="DescribeVpcAssetsRequest"/></param>
        /// <returns><see cref="DescribeVpcAssetsResponse"/></returns>
        public DescribeVpcAssetsResponse DescribeVpcAssetsSync(DescribeVpcAssetsRequest req)
        {
            return InternalRequestAsync<DescribeVpcAssetsResponse>(req, "DescribeVpcAssets")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改集团账号状态
        /// </summary>
        /// <param name="req"><see cref="ModifyOrganizationAccountStatusRequest"/></param>
        /// <returns><see cref="ModifyOrganizationAccountStatusResponse"/></returns>
        public Task<ModifyOrganizationAccountStatusResponse> ModifyOrganizationAccountStatus(ModifyOrganizationAccountStatusRequest req)
        {
            return InternalRequestAsync<ModifyOrganizationAccountStatusResponse>(req, "ModifyOrganizationAccountStatus");
        }

        /// <summary>
        /// 修改集团账号状态
        /// </summary>
        /// <param name="req"><see cref="ModifyOrganizationAccountStatusRequest"/></param>
        /// <returns><see cref="ModifyOrganizationAccountStatusResponse"/></returns>
        public ModifyOrganizationAccountStatusResponse ModifyOrganizationAccountStatusSync(ModifyOrganizationAccountStatusRequest req)
        {
            return InternalRequestAsync<ModifyOrganizationAccountStatusResponse>(req, "ModifyOrganizationAccountStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改风险中心风险状态
        /// </summary>
        /// <param name="req"><see cref="ModifyRiskCenterRiskStatusRequest"/></param>
        /// <returns><see cref="ModifyRiskCenterRiskStatusResponse"/></returns>
        public Task<ModifyRiskCenterRiskStatusResponse> ModifyRiskCenterRiskStatus(ModifyRiskCenterRiskStatusRequest req)
        {
            return InternalRequestAsync<ModifyRiskCenterRiskStatusResponse>(req, "ModifyRiskCenterRiskStatus");
        }

        /// <summary>
        /// 修改风险中心风险状态
        /// </summary>
        /// <param name="req"><see cref="ModifyRiskCenterRiskStatusRequest"/></param>
        /// <returns><see cref="ModifyRiskCenterRiskStatusResponse"/></returns>
        public ModifyRiskCenterRiskStatusResponse ModifyRiskCenterRiskStatusSync(ModifyRiskCenterRiskStatusRequest req)
        {
            return InternalRequestAsync<ModifyRiskCenterRiskStatusResponse>(req, "ModifyRiskCenterRiskStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改风险中心扫描任务
        /// </summary>
        /// <param name="req"><see cref="ModifyRiskCenterScanTaskRequest"/></param>
        /// <returns><see cref="ModifyRiskCenterScanTaskResponse"/></returns>
        public Task<ModifyRiskCenterScanTaskResponse> ModifyRiskCenterScanTask(ModifyRiskCenterScanTaskRequest req)
        {
            return InternalRequestAsync<ModifyRiskCenterScanTaskResponse>(req, "ModifyRiskCenterScanTask");
        }

        /// <summary>
        /// 修改风险中心扫描任务
        /// </summary>
        /// <param name="req"><see cref="ModifyRiskCenterScanTaskRequest"/></param>
        /// <returns><see cref="ModifyRiskCenterScanTaskResponse"/></returns>
        public ModifyRiskCenterScanTaskResponse ModifyRiskCenterScanTaskSync(ModifyRiskCenterScanTaskRequest req)
        {
            return InternalRequestAsync<ModifyRiskCenterScanTaskResponse>(req, "ModifyRiskCenterScanTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 停止扫风险中心扫描任务
        /// </summary>
        /// <param name="req"><see cref="StopRiskCenterTaskRequest"/></param>
        /// <returns><see cref="StopRiskCenterTaskResponse"/></returns>
        public Task<StopRiskCenterTaskResponse> StopRiskCenterTask(StopRiskCenterTaskRequest req)
        {
            return InternalRequestAsync<StopRiskCenterTaskResponse>(req, "StopRiskCenterTask");
        }

        /// <summary>
        /// 停止扫风险中心扫描任务
        /// </summary>
        /// <param name="req"><see cref="StopRiskCenterTaskRequest"/></param>
        /// <returns><see cref="StopRiskCenterTaskResponse"/></returns>
        public StopRiskCenterTaskResponse StopRiskCenterTaskSync(StopRiskCenterTaskRequest req)
        {
            return InternalRequestAsync<StopRiskCenterTaskResponse>(req, "StopRiskCenterTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
