/*
 * Copyright (c) 2018 Tencent. All Rights Reserved.
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

namespace TencentCloud.Cvd.V20201104
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Cvd.V20201104.Models;

   public class CvdClient : AbstractClient{

       private const string endpoint = "cvd.tencentcloudapi.com";
       private const string version = "2020-11-04";
       private const string sdkVersion = "SDK_NET_3.0.1528";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public CvdClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public CvdClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 安全组批量关联云桌面
        /// </summary>
        /// <param name="req"><see cref="AssociateSecurityGroupRequest"/></param>
        /// <returns><see cref="AssociateSecurityGroupResponse"/></returns>
        public Task<AssociateSecurityGroupResponse> AssociateSecurityGroup(AssociateSecurityGroupRequest req)
        {
            return InternalRequestAsync<AssociateSecurityGroupResponse>(req, "AssociateSecurityGroup");
        }

        /// <summary>
        /// 安全组批量关联云桌面
        /// </summary>
        /// <param name="req"><see cref="AssociateSecurityGroupRequest"/></param>
        /// <returns><see cref="AssociateSecurityGroupResponse"/></returns>
        public AssociateSecurityGroupResponse AssociateSecurityGroupSync(AssociateSecurityGroupRequest req)
        {
            return InternalRequestAsync<AssociateSecurityGroupResponse>(req, "AssociateSecurityGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 绑定桌面
        /// </summary>
        /// <param name="req"><see cref="BindInstancesRequest"/></param>
        /// <returns><see cref="BindInstancesResponse"/></returns>
        public Task<BindInstancesResponse> BindInstances(BindInstancesRequest req)
        {
            return InternalRequestAsync<BindInstancesResponse>(req, "BindInstances");
        }

        /// <summary>
        /// 绑定桌面
        /// </summary>
        /// <param name="req"><see cref="BindInstancesRequest"/></param>
        /// <returns><see cref="BindInstancesResponse"/></returns>
        public BindInstancesResponse BindInstancesSync(BindInstancesRequest req)
        {
            return InternalRequestAsync<BindInstancesResponse>(req, "BindInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建批量脚本任务
        /// </summary>
        /// <param name="req"><see cref="CreateCommandTaskRequest"/></param>
        /// <returns><see cref="CreateCommandTaskResponse"/></returns>
        public Task<CreateCommandTaskResponse> CreateCommandTask(CreateCommandTaskRequest req)
        {
            return InternalRequestAsync<CreateCommandTaskResponse>(req, "CreateCommandTask");
        }

        /// <summary>
        /// 创建批量脚本任务
        /// </summary>
        /// <param name="req"><see cref="CreateCommandTaskRequest"/></param>
        /// <returns><see cref="CreateCommandTaskResponse"/></returns>
        public CreateCommandTaskResponse CreateCommandTaskSync(CreateCommandTaskRequest req)
        {
            return InternalRequestAsync<CreateCommandTaskResponse>(req, "CreateCommandTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 实例新增数据盘
        /// </summary>
        /// <param name="req"><see cref="CreateDataDiskRequest"/></param>
        /// <returns><see cref="CreateDataDiskResponse"/></returns>
        public Task<CreateDataDiskResponse> CreateDataDisk(CreateDataDiskRequest req)
        {
            return InternalRequestAsync<CreateDataDiskResponse>(req, "CreateDataDisk");
        }

        /// <summary>
        /// 实例新增数据盘
        /// </summary>
        /// <param name="req"><see cref="CreateDataDiskRequest"/></param>
        /// <returns><see cref="CreateDataDiskResponse"/></returns>
        public CreateDataDiskResponse CreateDataDiskSync(CreateDataDiskRequest req)
        {
            return InternalRequestAsync<CreateDataDiskResponse>(req, "CreateDataDisk")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 新建域名访问控制策略
        /// </summary>
        /// <param name="req"><see cref="CreateDomainControlPolicyRequest"/></param>
        /// <returns><see cref="CreateDomainControlPolicyResponse"/></returns>
        public Task<CreateDomainControlPolicyResponse> CreateDomainControlPolicy(CreateDomainControlPolicyRequest req)
        {
            return InternalRequestAsync<CreateDomainControlPolicyResponse>(req, "CreateDomainControlPolicy");
        }

        /// <summary>
        /// 新建域名访问控制策略
        /// </summary>
        /// <param name="req"><see cref="CreateDomainControlPolicyRequest"/></param>
        /// <returns><see cref="CreateDomainControlPolicyResponse"/></returns>
        public CreateDomainControlPolicyResponse CreateDomainControlPolicySync(CreateDomainControlPolicyRequest req)
        {
            return InternalRequestAsync<CreateDomainControlPolicyResponse>(req, "CreateDomainControlPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建自定义镜像。
        /// </summary>
        /// <param name="req"><see cref="CreateImageRequest"/></param>
        /// <returns><see cref="CreateImageResponse"/></returns>
        public Task<CreateImageResponse> CreateImage(CreateImageRequest req)
        {
            return InternalRequestAsync<CreateImageResponse>(req, "CreateImage");
        }

        /// <summary>
        /// 创建自定义镜像。
        /// </summary>
        /// <param name="req"><see cref="CreateImageRequest"/></param>
        /// <returns><see cref="CreateImageResponse"/></returns>
        public CreateImageResponse CreateImageSync(CreateImageRequest req)
        {
            return InternalRequestAsync<CreateImageResponse>(req, "CreateImage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建云桌面实例
        /// </summary>
        /// <param name="req"><see cref="CreateInstancesRequest"/></param>
        /// <returns><see cref="CreateInstancesResponse"/></returns>
        public Task<CreateInstancesResponse> CreateInstances(CreateInstancesRequest req)
        {
            return InternalRequestAsync<CreateInstancesResponse>(req, "CreateInstances");
        }

        /// <summary>
        /// 创建云桌面实例
        /// </summary>
        /// <param name="req"><see cref="CreateInstancesRequest"/></param>
        /// <returns><see cref="CreateInstancesResponse"/></returns>
        public CreateInstancesResponse CreateInstancesSync(CreateInstancesRequest req)
        {
            return InternalRequestAsync<CreateInstancesResponse>(req, "CreateInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建策略
        /// </summary>
        /// <param name="req"><see cref="CreatePolicyRequest"/></param>
        /// <returns><see cref="CreatePolicyResponse"/></returns>
        public Task<CreatePolicyResponse> CreatePolicy(CreatePolicyRequest req)
        {
            return InternalRequestAsync<CreatePolicyResponse>(req, "CreatePolicy");
        }

        /// <summary>
        /// 创建策略
        /// </summary>
        /// <param name="req"><see cref="CreatePolicyRequest"/></param>
        /// <returns><see cref="CreatePolicyResponse"/></returns>
        public CreatePolicyResponse CreatePolicySync(CreatePolicyRequest req)
        {
            return InternalRequestAsync<CreatePolicyResponse>(req, "CreatePolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除命令任务
        /// </summary>
        /// <param name="req"><see cref="DeleteCommandTasksRequest"/></param>
        /// <returns><see cref="DeleteCommandTasksResponse"/></returns>
        public Task<DeleteCommandTasksResponse> DeleteCommandTasks(DeleteCommandTasksRequest req)
        {
            return InternalRequestAsync<DeleteCommandTasksResponse>(req, "DeleteCommandTasks");
        }

        /// <summary>
        /// 删除命令任务
        /// </summary>
        /// <param name="req"><see cref="DeleteCommandTasksRequest"/></param>
        /// <returns><see cref="DeleteCommandTasksResponse"/></returns>
        public DeleteCommandTasksResponse DeleteCommandTasksSync(DeleteCommandTasksRequest req)
        {
            return InternalRequestAsync<DeleteCommandTasksResponse>(req, "DeleteCommandTasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除域名访问控制策略
        /// </summary>
        /// <param name="req"><see cref="DeleteDomainControlPolicyRequest"/></param>
        /// <returns><see cref="DeleteDomainControlPolicyResponse"/></returns>
        public Task<DeleteDomainControlPolicyResponse> DeleteDomainControlPolicy(DeleteDomainControlPolicyRequest req)
        {
            return InternalRequestAsync<DeleteDomainControlPolicyResponse>(req, "DeleteDomainControlPolicy");
        }

        /// <summary>
        /// 删除域名访问控制策略
        /// </summary>
        /// <param name="req"><see cref="DeleteDomainControlPolicyRequest"/></param>
        /// <returns><see cref="DeleteDomainControlPolicyResponse"/></returns>
        public DeleteDomainControlPolicyResponse DeleteDomainControlPolicySync(DeleteDomainControlPolicyRequest req)
        {
            return InternalRequestAsync<DeleteDomainControlPolicyResponse>(req, "DeleteDomainControlPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于删除一个或多个自定义镜像。单次最大删除5个。
        /// </summary>
        /// <param name="req"><see cref="DeleteImagesRequest"/></param>
        /// <returns><see cref="DeleteImagesResponse"/></returns>
        public Task<DeleteImagesResponse> DeleteImages(DeleteImagesRequest req)
        {
            return InternalRequestAsync<DeleteImagesResponse>(req, "DeleteImages");
        }

        /// <summary>
        /// 用于删除一个或多个自定义镜像。单次最大删除5个。
        /// </summary>
        /// <param name="req"><see cref="DeleteImagesRequest"/></param>
        /// <returns><see cref="DeleteImagesResponse"/></returns>
        public DeleteImagesResponse DeleteImagesSync(DeleteImagesRequest req)
        {
            return InternalRequestAsync<DeleteImagesResponse>(req, "DeleteImages")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 拉取命令任务详情
        /// </summary>
        /// <param name="req"><see cref="DescribeCommandTasksRequest"/></param>
        /// <returns><see cref="DescribeCommandTasksResponse"/></returns>
        public Task<DescribeCommandTasksResponse> DescribeCommandTasks(DescribeCommandTasksRequest req)
        {
            return InternalRequestAsync<DescribeCommandTasksResponse>(req, "DescribeCommandTasks");
        }

        /// <summary>
        /// 拉取命令任务详情
        /// </summary>
        /// <param name="req"><see cref="DescribeCommandTasksRequest"/></param>
        /// <returns><see cref="DescribeCommandTasksResponse"/></returns>
        public DescribeCommandTasksResponse DescribeCommandTasksSync(DescribeCommandTasksRequest req)
        {
            return InternalRequestAsync<DescribeCommandTasksResponse>(req, "DescribeCommandTasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取云桌面镜像详细信息
        /// </summary>
        /// <param name="req"><see cref="DescribeImagesRequest"/></param>
        /// <returns><see cref="DescribeImagesResponse"/></returns>
        public Task<DescribeImagesResponse> DescribeImages(DescribeImagesRequest req)
        {
            return InternalRequestAsync<DescribeImagesResponse>(req, "DescribeImages");
        }

        /// <summary>
        /// 获取云桌面镜像详细信息
        /// </summary>
        /// <param name="req"><see cref="DescribeImagesRequest"/></param>
        /// <returns><see cref="DescribeImagesResponse"/></returns>
        public DescribeImagesResponse DescribeImagesSync(DescribeImagesRequest req)
        {
            return InternalRequestAsync<DescribeImagesResponse>(req, "DescribeImages")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取指定实例的登录Fetch信息
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceFetchMsgRequest"/></param>
        /// <returns><see cref="DescribeInstanceFetchMsgResponse"/></returns>
        public Task<DescribeInstanceFetchMsgResponse> DescribeInstanceFetchMsg(DescribeInstanceFetchMsgRequest req)
        {
            return InternalRequestAsync<DescribeInstanceFetchMsgResponse>(req, "DescribeInstanceFetchMsg");
        }

        /// <summary>
        /// 获取指定实例的登录Fetch信息
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceFetchMsgRequest"/></param>
        /// <returns><see cref="DescribeInstanceFetchMsgResponse"/></returns>
        public DescribeInstanceFetchMsgResponse DescribeInstanceFetchMsgSync(DescribeInstanceFetchMsgRequest req)
        {
            return InternalRequestAsync<DescribeInstanceFetchMsgResponse>(req, "DescribeInstanceFetchMsg")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取实例磁盘分区监控数据
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceGraphDataRequest"/></param>
        /// <returns><see cref="DescribeInstanceGraphDataResponse"/></returns>
        public Task<DescribeInstanceGraphDataResponse> DescribeInstanceGraphData(DescribeInstanceGraphDataRequest req)
        {
            return InternalRequestAsync<DescribeInstanceGraphDataResponse>(req, "DescribeInstanceGraphData");
        }

        /// <summary>
        /// 获取实例磁盘分区监控数据
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceGraphDataRequest"/></param>
        /// <returns><see cref="DescribeInstanceGraphDataResponse"/></returns>
        public DescribeInstanceGraphDataResponse DescribeInstanceGraphDataSync(DescribeInstanceGraphDataRequest req)
        {
            return InternalRequestAsync<DescribeInstanceGraphDataResponse>(req, "DescribeInstanceGraphData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取指定实例的登录login信息
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceLoginMsgRequest"/></param>
        /// <returns><see cref="DescribeInstanceLoginMsgResponse"/></returns>
        public Task<DescribeInstanceLoginMsgResponse> DescribeInstanceLoginMsg(DescribeInstanceLoginMsgRequest req)
        {
            return InternalRequestAsync<DescribeInstanceLoginMsgResponse>(req, "DescribeInstanceLoginMsg");
        }

        /// <summary>
        /// 获取指定实例的登录login信息
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceLoginMsgRequest"/></param>
        /// <returns><see cref="DescribeInstanceLoginMsgResponse"/></returns>
        public DescribeInstanceLoginMsgResponse DescribeInstanceLoginMsgSync(DescribeInstanceLoginMsgRequest req)
        {
            return InternalRequestAsync<DescribeInstanceLoginMsgResponse>(req, "DescribeInstanceLoginMsg")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询实例监控数据
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceMonitorDataRequest"/></param>
        /// <returns><see cref="DescribeInstanceMonitorDataResponse"/></returns>
        public Task<DescribeInstanceMonitorDataResponse> DescribeInstanceMonitorData(DescribeInstanceMonitorDataRequest req)
        {
            return InternalRequestAsync<DescribeInstanceMonitorDataResponse>(req, "DescribeInstanceMonitorData");
        }

        /// <summary>
        /// 查询实例监控数据
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceMonitorDataRequest"/></param>
        /// <returns><see cref="DescribeInstanceMonitorDataResponse"/></returns>
        public DescribeInstanceMonitorDataResponse DescribeInstanceMonitorDataSync(DescribeInstanceMonitorDataRequest req)
        {
            return InternalRequestAsync<DescribeInstanceMonitorDataResponse>(req, "DescribeInstanceMonitorData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取用户在各个区域云桌面实例个数
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceRegionDistributionRequest"/></param>
        /// <returns><see cref="DescribeInstanceRegionDistributionResponse"/></returns>
        public Task<DescribeInstanceRegionDistributionResponse> DescribeInstanceRegionDistribution(DescribeInstanceRegionDistributionRequest req)
        {
            return InternalRequestAsync<DescribeInstanceRegionDistributionResponse>(req, "DescribeInstanceRegionDistribution");
        }

        /// <summary>
        /// 获取用户在各个区域云桌面实例个数
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceRegionDistributionRequest"/></param>
        /// <returns><see cref="DescribeInstanceRegionDistributionResponse"/></returns>
        public DescribeInstanceRegionDistributionResponse DescribeInstanceRegionDistributionSync(DescribeInstanceRegionDistributionRequest req)
        {
            return InternalRequestAsync<DescribeInstanceRegionDistributionResponse>(req, "DescribeInstanceRegionDistribution")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取云桌面实例详细信息
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesRequest"/></param>
        /// <returns><see cref="DescribeInstancesResponse"/></returns>
        public Task<DescribeInstancesResponse> DescribeInstances(DescribeInstancesRequest req)
        {
            return InternalRequestAsync<DescribeInstancesResponse>(req, "DescribeInstances");
        }

        /// <summary>
        /// 获取云桌面实例详细信息
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesRequest"/></param>
        /// <returns><see cref="DescribeInstancesResponse"/></returns>
        public DescribeInstancesResponse DescribeInstancesSync(DescribeInstancesRequest req)
        {
            return InternalRequestAsync<DescribeInstancesResponse>(req, "DescribeInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取桌面实例绑定状态
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesBindStatusRequest"/></param>
        /// <returns><see cref="DescribeInstancesBindStatusResponse"/></returns>
        public Task<DescribeInstancesBindStatusResponse> DescribeInstancesBindStatus(DescribeInstancesBindStatusRequest req)
        {
            return InternalRequestAsync<DescribeInstancesBindStatusResponse>(req, "DescribeInstancesBindStatus");
        }

        /// <summary>
        /// 获取桌面实例绑定状态
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesBindStatusRequest"/></param>
        /// <returns><see cref="DescribeInstancesBindStatusResponse"/></returns>
        public DescribeInstancesBindStatusResponse DescribeInstancesBindStatusSync(DescribeInstancesBindStatusRequest req)
        {
            return InternalRequestAsync<DescribeInstancesBindStatusResponse>(req, "DescribeInstancesBindStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取桌面实例状态
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesStatusRequest"/></param>
        /// <returns><see cref="DescribeInstancesStatusResponse"/></returns>
        public Task<DescribeInstancesStatusResponse> DescribeInstancesStatus(DescribeInstancesStatusRequest req)
        {
            return InternalRequestAsync<DescribeInstancesStatusResponse>(req, "DescribeInstancesStatus");
        }

        /// <summary>
        /// 获取桌面实例状态
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesStatusRequest"/></param>
        /// <returns><see cref="DescribeInstancesStatusResponse"/></returns>
        public DescribeInstancesStatusResponse DescribeInstancesStatusSync(DescribeInstancesStatusRequest req)
        {
            return InternalRequestAsync<DescribeInstancesStatusResponse>(req, "DescribeInstancesStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询脚本任务执行的详细情况。
        /// </summary>
        /// <param name="req"><see cref="DescribeInvocationDetailRequest"/></param>
        /// <returns><see cref="DescribeInvocationDetailResponse"/></returns>
        public Task<DescribeInvocationDetailResponse> DescribeInvocationDetail(DescribeInvocationDetailRequest req)
        {
            return InternalRequestAsync<DescribeInvocationDetailResponse>(req, "DescribeInvocationDetail");
        }

        /// <summary>
        /// 查询脚本任务执行的详细情况。
        /// </summary>
        /// <param name="req"><see cref="DescribeInvocationDetailRequest"/></param>
        /// <returns><see cref="DescribeInvocationDetailResponse"/></returns>
        public DescribeInvocationDetailResponse DescribeInvocationDetailSync(DescribeInvocationDetailRequest req)
        {
            return InternalRequestAsync<DescribeInvocationDetailResponse>(req, "DescribeInvocationDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询指定云桌面上的任务列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeInvocationsRequest"/></param>
        /// <returns><see cref="DescribeInvocationsResponse"/></returns>
        public Task<DescribeInvocationsResponse> DescribeInvocations(DescribeInvocationsRequest req)
        {
            return InternalRequestAsync<DescribeInvocationsResponse>(req, "DescribeInvocations");
        }

        /// <summary>
        /// 查询指定云桌面上的任务列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeInvocationsRequest"/></param>
        /// <returns><see cref="DescribeInvocationsResponse"/></returns>
        public DescribeInvocationsResponse DescribeInvocationsSync(DescribeInvocationsRequest req)
        {
            return InternalRequestAsync<DescribeInvocationsResponse>(req, "DescribeInvocations")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 拉取租户策略列表 
        /// </summary>
        /// <param name="req"><see cref="DescribePolicyDetailRequest"/></param>
        /// <returns><see cref="DescribePolicyDetailResponse"/></returns>
        public Task<DescribePolicyDetailResponse> DescribePolicyDetail(DescribePolicyDetailRequest req)
        {
            return InternalRequestAsync<DescribePolicyDetailResponse>(req, "DescribePolicyDetail");
        }

        /// <summary>
        /// 拉取租户策略列表 
        /// </summary>
        /// <param name="req"><see cref="DescribePolicyDetailRequest"/></param>
        /// <returns><see cref="DescribePolicyDetailResponse"/></returns>
        public DescribePolicyDetailResponse DescribePolicyDetailSync(DescribePolicyDetailRequest req)
        {
            return InternalRequestAsync<DescribePolicyDetailResponse>(req, "DescribePolicyDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 拉取云桌面关联的安全组信息
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityGroupsRequest"/></param>
        /// <returns><see cref="DescribeSecurityGroupsResponse"/></returns>
        public Task<DescribeSecurityGroupsResponse> DescribeSecurityGroups(DescribeSecurityGroupsRequest req)
        {
            return InternalRequestAsync<DescribeSecurityGroupsResponse>(req, "DescribeSecurityGroups");
        }

        /// <summary>
        /// 拉取云桌面关联的安全组信息
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityGroupsRequest"/></param>
        /// <returns><see cref="DescribeSecurityGroupsResponse"/></returns>
        public DescribeSecurityGroupsResponse DescribeSecurityGroupsSync(DescribeSecurityGroupsRequest req)
        {
            return InternalRequestAsync<DescribeSecurityGroupsResponse>(req, "DescribeSecurityGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 拉取快照列表
        /// </summary>
        /// <param name="req"><see cref="DescribeSnapshotsRequest"/></param>
        /// <returns><see cref="DescribeSnapshotsResponse"/></returns>
        public Task<DescribeSnapshotsResponse> DescribeSnapshots(DescribeSnapshotsRequest req)
        {
            return InternalRequestAsync<DescribeSnapshotsResponse>(req, "DescribeSnapshots");
        }

        /// <summary>
        /// 拉取快照列表
        /// </summary>
        /// <param name="req"><see cref="DescribeSnapshotsRequest"/></param>
        /// <returns><see cref="DescribeSnapshotsResponse"/></returns>
        public DescribeSnapshotsResponse DescribeSnapshotsSync(DescribeSnapshotsRequest req)
        {
            return InternalRequestAsync<DescribeSnapshotsResponse>(req, "DescribeSnapshots")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 拉取实例使用时长详情
        /// </summary>
        /// <param name="req"><see cref="DescribeUsageRequest"/></param>
        /// <returns><see cref="DescribeUsageResponse"/></returns>
        public Task<DescribeUsageResponse> DescribeUsage(DescribeUsageRequest req)
        {
            return InternalRequestAsync<DescribeUsageResponse>(req, "DescribeUsage");
        }

        /// <summary>
        /// 拉取实例使用时长详情
        /// </summary>
        /// <param name="req"><see cref="DescribeUsageRequest"/></param>
        /// <returns><see cref="DescribeUsageResponse"/></returns>
        public DescribeUsageResponse DescribeUsageSync(DescribeUsageRequest req)
        {
            return InternalRequestAsync<DescribeUsageResponse>(req, "DescribeUsage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 拉取用户列表
        /// </summary>
        /// <param name="req"><see cref="DescribeUsersRequest"/></param>
        /// <returns><see cref="DescribeUsersResponse"/></returns>
        public Task<DescribeUsersResponse> DescribeUsers(DescribeUsersRequest req)
        {
            return InternalRequestAsync<DescribeUsersResponse>(req, "DescribeUsers");
        }

        /// <summary>
        /// 拉取用户列表
        /// </summary>
        /// <param name="req"><see cref="DescribeUsersRequest"/></param>
        /// <returns><see cref="DescribeUsersResponse"/></returns>
        public DescribeUsersResponse DescribeUsersSync(DescribeUsersRequest req)
        {
            return InternalRequestAsync<DescribeUsersResponse>(req, "DescribeUsers")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 安全组批量解关联云桌面
        /// </summary>
        /// <param name="req"><see cref="DisassociateSecurityGroupRequest"/></param>
        /// <returns><see cref="DisassociateSecurityGroupResponse"/></returns>
        public Task<DisassociateSecurityGroupResponse> DisassociateSecurityGroup(DisassociateSecurityGroupRequest req)
        {
            return InternalRequestAsync<DisassociateSecurityGroupResponse>(req, "DisassociateSecurityGroup");
        }

        /// <summary>
        /// 安全组批量解关联云桌面
        /// </summary>
        /// <param name="req"><see cref="DisassociateSecurityGroupRequest"/></param>
        /// <returns><see cref="DisassociateSecurityGroupResponse"/></returns>
        public DisassociateSecurityGroupResponse DisassociateSecurityGroupSync(DisassociateSecurityGroupRequest req)
        {
            return InternalRequestAsync<DisassociateSecurityGroupResponse>(req, "DisassociateSecurityGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 实例硬盘扩容
        /// </summary>
        /// <param name="req"><see cref="ModifyDiskConfigurationRequest"/></param>
        /// <returns><see cref="ModifyDiskConfigurationResponse"/></returns>
        public Task<ModifyDiskConfigurationResponse> ModifyDiskConfiguration(ModifyDiskConfigurationRequest req)
        {
            return InternalRequestAsync<ModifyDiskConfigurationResponse>(req, "ModifyDiskConfiguration");
        }

        /// <summary>
        /// 实例硬盘扩容
        /// </summary>
        /// <param name="req"><see cref="ModifyDiskConfigurationRequest"/></param>
        /// <returns><see cref="ModifyDiskConfigurationResponse"/></returns>
        public ModifyDiskConfigurationResponse ModifyDiskConfigurationSync(ModifyDiskConfigurationRequest req)
        {
            return InternalRequestAsync<ModifyDiskConfigurationResponse>(req, "ModifyDiskConfiguration")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改镜像属性
        /// </summary>
        /// <param name="req"><see cref="ModifyImageAttrsRequest"/></param>
        /// <returns><see cref="ModifyImageAttrsResponse"/></returns>
        public Task<ModifyImageAttrsResponse> ModifyImageAttrs(ModifyImageAttrsRequest req)
        {
            return InternalRequestAsync<ModifyImageAttrsResponse>(req, "ModifyImageAttrs");
        }

        /// <summary>
        /// 修改镜像属性
        /// </summary>
        /// <param name="req"><see cref="ModifyImageAttrsRequest"/></param>
        /// <returns><see cref="ModifyImageAttrsResponse"/></returns>
        public ModifyImageAttrsResponse ModifyImageAttrsSync(ModifyImageAttrsRequest req)
        {
            return InternalRequestAsync<ModifyImageAttrsResponse>(req, "ModifyImageAttrs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改桌面实例属性
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceBasicAttributeRequest"/></param>
        /// <returns><see cref="ModifyInstanceBasicAttributeResponse"/></returns>
        public Task<ModifyInstanceBasicAttributeResponse> ModifyInstanceBasicAttribute(ModifyInstanceBasicAttributeRequest req)
        {
            return InternalRequestAsync<ModifyInstanceBasicAttributeResponse>(req, "ModifyInstanceBasicAttribute");
        }

        /// <summary>
        /// 修改桌面实例属性
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceBasicAttributeRequest"/></param>
        /// <returns><see cref="ModifyInstanceBasicAttributeResponse"/></returns>
        public ModifyInstanceBasicAttributeResponse ModifyInstanceBasicAttributeSync(ModifyInstanceBasicAttributeRequest req)
        {
            return InternalRequestAsync<ModifyInstanceBasicAttributeResponse>(req, "ModifyInstanceBasicAttribute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 调整实例机型配置
        /// </summary>
        /// <param name="req"><see cref="ModifyInstancesTypeRequest"/></param>
        /// <returns><see cref="ModifyInstancesTypeResponse"/></returns>
        public Task<ModifyInstancesTypeResponse> ModifyInstancesType(ModifyInstancesTypeRequest req)
        {
            return InternalRequestAsync<ModifyInstancesTypeResponse>(req, "ModifyInstancesType");
        }

        /// <summary>
        /// 调整实例机型配置
        /// </summary>
        /// <param name="req"><see cref="ModifyInstancesTypeRequest"/></param>
        /// <returns><see cref="ModifyInstancesTypeResponse"/></returns>
        public ModifyInstancesTypeResponse ModifyInstancesTypeSync(ModifyInstancesTypeRequest req)
        {
            return InternalRequestAsync<ModifyInstancesTypeResponse>(req, "ModifyInstancesType")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 调整实例私有网络
        /// </summary>
        /// <param name="req"><see cref="ModifyInstancesVpcRequest"/></param>
        /// <returns><see cref="ModifyInstancesVpcResponse"/></returns>
        public Task<ModifyInstancesVpcResponse> ModifyInstancesVpc(ModifyInstancesVpcRequest req)
        {
            return InternalRequestAsync<ModifyInstancesVpcResponse>(req, "ModifyInstancesVpc");
        }

        /// <summary>
        /// 调整实例私有网络
        /// </summary>
        /// <param name="req"><see cref="ModifyInstancesVpcRequest"/></param>
        /// <returns><see cref="ModifyInstancesVpcResponse"/></returns>
        public ModifyInstancesVpcResponse ModifyInstancesVpcSync(ModifyInstancesVpcRequest req)
        {
            return InternalRequestAsync<ModifyInstancesVpcResponse>(req, "ModifyInstancesVpc")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 重启实例
        /// </summary>
        /// <param name="req"><see cref="RebootInstancesRequest"/></param>
        /// <returns><see cref="RebootInstancesResponse"/></returns>
        public Task<RebootInstancesResponse> RebootInstances(RebootInstancesRequest req)
        {
            return InternalRequestAsync<RebootInstancesResponse>(req, "RebootInstances");
        }

        /// <summary>
        /// 重启实例
        /// </summary>
        /// <param name="req"><see cref="RebootInstancesRequest"/></param>
        /// <returns><see cref="RebootInstancesResponse"/></returns>
        public RebootInstancesResponse RebootInstancesSync(RebootInstancesRequest req)
        {
            return InternalRequestAsync<RebootInstancesResponse>(req, "RebootInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 卸载实例数据盘
        /// </summary>
        /// <param name="req"><see cref="RemoveDataDisksRequest"/></param>
        /// <returns><see cref="RemoveDataDisksResponse"/></returns>
        public Task<RemoveDataDisksResponse> RemoveDataDisks(RemoveDataDisksRequest req)
        {
            return InternalRequestAsync<RemoveDataDisksResponse>(req, "RemoveDataDisks");
        }

        /// <summary>
        /// 卸载实例数据盘
        /// </summary>
        /// <param name="req"><see cref="RemoveDataDisksRequest"/></param>
        /// <returns><see cref="RemoveDataDisksResponse"/></returns>
        public RemoveDataDisksResponse RemoveDataDisksSync(RemoveDataDisksRequest req)
        {
            return InternalRequestAsync<RemoveDataDisksResponse>(req, "RemoveDataDisks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除策略
        /// </summary>
        /// <param name="req"><see cref="RemovePolicyRequest"/></param>
        /// <returns><see cref="RemovePolicyResponse"/></returns>
        public Task<RemovePolicyResponse> RemovePolicy(RemovePolicyRequest req)
        {
            return InternalRequestAsync<RemovePolicyResponse>(req, "RemovePolicy");
        }

        /// <summary>
        /// 删除策略
        /// </summary>
        /// <param name="req"><see cref="RemovePolicyRequest"/></param>
        /// <returns><see cref="RemovePolicyResponse"/></returns>
        public RemovePolicyResponse RemovePolicySync(RemovePolicyRequest req)
        {
            return InternalRequestAsync<RemovePolicyResponse>(req, "RemovePolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 实例续费
        /// </summary>
        /// <param name="req"><see cref="RenewInstancesRequest"/></param>
        /// <returns><see cref="RenewInstancesResponse"/></returns>
        public Task<RenewInstancesResponse> RenewInstances(RenewInstancesRequest req)
        {
            return InternalRequestAsync<RenewInstancesResponse>(req, "RenewInstances");
        }

        /// <summary>
        /// 实例续费
        /// </summary>
        /// <param name="req"><see cref="RenewInstancesRequest"/></param>
        /// <returns><see cref="RenewInstancesResponse"/></returns>
        public RenewInstancesResponse RenewInstancesSync(RenewInstancesRequest req)
        {
            return InternalRequestAsync<RenewInstancesResponse>(req, "RenewInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 实例重置
        /// </summary>
        /// <param name="req"><see cref="ResetInstancesRequest"/></param>
        /// <returns><see cref="ResetInstancesResponse"/></returns>
        public Task<ResetInstancesResponse> ResetInstances(ResetInstancesRequest req)
        {
            return InternalRequestAsync<ResetInstancesResponse>(req, "ResetInstances");
        }

        /// <summary>
        /// 实例重置
        /// </summary>
        /// <param name="req"><see cref="ResetInstancesRequest"/></param>
        /// <returns><see cref="ResetInstancesResponse"/></returns>
        public ResetInstancesResponse ResetInstancesSync(ResetInstancesRequest req)
        {
            return InternalRequestAsync<ResetInstancesResponse>(req, "ResetInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 在指定的云桌面实例上执行脚本任务。
        /// </summary>
        /// <param name="req"><see cref="RunCommandRequest"/></param>
        /// <returns><see cref="RunCommandResponse"/></returns>
        public Task<RunCommandResponse> RunCommand(RunCommandRequest req)
        {
            return InternalRequestAsync<RunCommandResponse>(req, "RunCommand");
        }

        /// <summary>
        /// 在指定的云桌面实例上执行脚本任务。
        /// </summary>
        /// <param name="req"><see cref="RunCommandRequest"/></param>
        /// <returns><see cref="RunCommandResponse"/></returns>
        public RunCommandResponse RunCommandSync(RunCommandRequest req)
        {
            return InternalRequestAsync<RunCommandResponse>(req, "RunCommand")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 开启实例
        /// </summary>
        /// <param name="req"><see cref="StartInstancesRequest"/></param>
        /// <returns><see cref="StartInstancesResponse"/></returns>
        public Task<StartInstancesResponse> StartInstances(StartInstancesRequest req)
        {
            return InternalRequestAsync<StartInstancesResponse>(req, "StartInstances");
        }

        /// <summary>
        /// 开启实例
        /// </summary>
        /// <param name="req"><see cref="StartInstancesRequest"/></param>
        /// <returns><see cref="StartInstancesResponse"/></returns>
        public StartInstancesResponse StartInstancesSync(StartInstancesRequest req)
        {
            return InternalRequestAsync<StartInstancesResponse>(req, "StartInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 停止命令任务
        /// </summary>
        /// <param name="req"><see cref="StopCommandTasksRequest"/></param>
        /// <returns><see cref="StopCommandTasksResponse"/></returns>
        public Task<StopCommandTasksResponse> StopCommandTasks(StopCommandTasksRequest req)
        {
            return InternalRequestAsync<StopCommandTasksResponse>(req, "StopCommandTasks");
        }

        /// <summary>
        /// 停止命令任务
        /// </summary>
        /// <param name="req"><see cref="StopCommandTasksRequest"/></param>
        /// <returns><see cref="StopCommandTasksResponse"/></returns>
        public StopCommandTasksResponse StopCommandTasksSync(StopCommandTasksRequest req)
        {
            return InternalRequestAsync<StopCommandTasksResponse>(req, "StopCommandTasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 关闭实例
        /// </summary>
        /// <param name="req"><see cref="StopInstancesRequest"/></param>
        /// <returns><see cref="StopInstancesResponse"/></returns>
        public Task<StopInstancesResponse> StopInstances(StopInstancesRequest req)
        {
            return InternalRequestAsync<StopInstancesResponse>(req, "StopInstances");
        }

        /// <summary>
        /// 关闭实例
        /// </summary>
        /// <param name="req"><see cref="StopInstancesRequest"/></param>
        /// <returns><see cref="StopInstancesResponse"/></returns>
        public StopInstancesResponse StopInstancesSync(StopInstancesRequest req)
        {
            return InternalRequestAsync<StopInstancesResponse>(req, "StopInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 停止脚本任务的执行。
        /// </summary>
        /// <param name="req"><see cref="StopInvocationRequest"/></param>
        /// <returns><see cref="StopInvocationResponse"/></returns>
        public Task<StopInvocationResponse> StopInvocation(StopInvocationRequest req)
        {
            return InternalRequestAsync<StopInvocationResponse>(req, "StopInvocation");
        }

        /// <summary>
        /// 停止脚本任务的执行。
        /// </summary>
        /// <param name="req"><see cref="StopInvocationRequest"/></param>
        /// <returns><see cref="StopInvocationResponse"/></returns>
        public StopInvocationResponse StopInvocationSync(StopInvocationRequest req)
        {
            return InternalRequestAsync<StopInvocationResponse>(req, "StopInvocation")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 注销或者断开机器当前会话
        /// </summary>
        /// <param name="req"><see cref="StopSessionRequest"/></param>
        /// <returns><see cref="StopSessionResponse"/></returns>
        public Task<StopSessionResponse> StopSession(StopSessionRequest req)
        {
            return InternalRequestAsync<StopSessionResponse>(req, "StopSession");
        }

        /// <summary>
        /// 注销或者断开机器当前会话
        /// </summary>
        /// <param name="req"><see cref="StopSessionRequest"/></param>
        /// <returns><see cref="StopSessionResponse"/></returns>
        public StopSessionResponse StopSessionSync(StopSessionRequest req)
        {
            return InternalRequestAsync<StopSessionResponse>(req, "StopSession")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 主动退还、销毁退还实例。 
        /// <li>包年包月实例首次调用本接口，且参数DestroyImmediately为false时，实例进入隔离期，再次调用本接口，实例将被销毁，且不可恢复。</li>
        /// <li>包年包月实例，如果参数DestroyImmediately为true来调用此接口，则实例将被直接销毁，且不可恢复。</li>
        /// <li>按量计费实例调用本接口将被直接销毁，且不可恢复。</li>
        /// </summary>
        /// <param name="req"><see cref="TerminateInstancesRequest"/></param>
        /// <returns><see cref="TerminateInstancesResponse"/></returns>
        public Task<TerminateInstancesResponse> TerminateInstances(TerminateInstancesRequest req)
        {
            return InternalRequestAsync<TerminateInstancesResponse>(req, "TerminateInstances");
        }

        /// <summary>
        /// 主动退还、销毁退还实例。 
        /// <li>包年包月实例首次调用本接口，且参数DestroyImmediately为false时，实例进入隔离期，再次调用本接口，实例将被销毁，且不可恢复。</li>
        /// <li>包年包月实例，如果参数DestroyImmediately为true来调用此接口，则实例将被直接销毁，且不可恢复。</li>
        /// <li>按量计费实例调用本接口将被直接销毁，且不可恢复。</li>
        /// </summary>
        /// <param name="req"><see cref="TerminateInstancesRequest"/></param>
        /// <returns><see cref="TerminateInstancesResponse"/></returns>
        public TerminateInstancesResponse TerminateInstancesSync(TerminateInstancesRequest req)
        {
            return InternalRequestAsync<TerminateInstancesResponse>(req, "TerminateInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 解除用户和机器绑定关系
        /// </summary>
        /// <param name="req"><see cref="UnbindInstancesRequest"/></param>
        /// <returns><see cref="UnbindInstancesResponse"/></returns>
        public Task<UnbindInstancesResponse> UnbindInstances(UnbindInstancesRequest req)
        {
            return InternalRequestAsync<UnbindInstancesResponse>(req, "UnbindInstances");
        }

        /// <summary>
        /// 解除用户和机器绑定关系
        /// </summary>
        /// <param name="req"><see cref="UnbindInstancesRequest"/></param>
        /// <returns><see cref="UnbindInstancesResponse"/></returns>
        public UnbindInstancesResponse UnbindInstancesSync(UnbindInstancesRequest req)
        {
            return InternalRequestAsync<UnbindInstancesResponse>(req, "UnbindInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新策略
        /// </summary>
        /// <param name="req"><see cref="UpdatePolicyRequest"/></param>
        /// <returns><see cref="UpdatePolicyResponse"/></returns>
        public Task<UpdatePolicyResponse> UpdatePolicy(UpdatePolicyRequest req)
        {
            return InternalRequestAsync<UpdatePolicyResponse>(req, "UpdatePolicy");
        }

        /// <summary>
        /// 更新策略
        /// </summary>
        /// <param name="req"><see cref="UpdatePolicyRequest"/></param>
        /// <returns><see cref="UpdatePolicyResponse"/></returns>
        public UpdatePolicyResponse UpdatePolicySync(UpdatePolicyRequest req)
        {
            return InternalRequestAsync<UpdatePolicyResponse>(req, "UpdatePolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
