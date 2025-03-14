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

namespace TencentCloud.Dts.V20180330
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Dts.V20180330.Models;

   public class DtsClient : AbstractClient{

       private const string endpoint = "dts.tencentcloudapi.com";
       private const string version = "2018-03-30";
       private const string sdkVersion = "SDK_NET_3.0.1200";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public DtsClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public DtsClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 本接口用于配置数据订阅，只有在未配置状态的订阅实例才能调用此接口。
        /// </summary>
        /// <param name="req"><see cref="ActivateSubscribeRequest"/></param>
        /// <returns><see cref="ActivateSubscribeResponse"/></returns>
        public Task<ActivateSubscribeResponse> ActivateSubscribe(ActivateSubscribeRequest req)
        {
            return InternalRequestAsync<ActivateSubscribeResponse>(req, "ActivateSubscribe");
        }

        /// <summary>
        /// 本接口用于配置数据订阅，只有在未配置状态的订阅实例才能调用此接口。
        /// </summary>
        /// <param name="req"><see cref="ActivateSubscribeRequest"/></param>
        /// <returns><see cref="ActivateSubscribeResponse"/></returns>
        public ActivateSubscribeResponse ActivateSubscribeSync(ActivateSubscribeRequest req)
        {
            return InternalRequestAsync<ActivateSubscribeResponse>(req, "ActivateSubscribe")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（CompleteMigrateJob）用于完成数据迁移任务。
        /// 选择采用增量迁移方式的任务, 需要在迁移进度进入准备完成阶段后, 调用本接口, 停止迁移增量数据。
        /// 通过DescribeMigrateJobs接口查询到任务的状态为准备完成（status=8）时，此时可以调用本接口完成迁移任务。
        /// </summary>
        /// <param name="req"><see cref="CompleteMigrateJobRequest"/></param>
        /// <returns><see cref="CompleteMigrateJobResponse"/></returns>
        public Task<CompleteMigrateJobResponse> CompleteMigrateJob(CompleteMigrateJobRequest req)
        {
            return InternalRequestAsync<CompleteMigrateJobResponse>(req, "CompleteMigrateJob");
        }

        /// <summary>
        /// 本接口（CompleteMigrateJob）用于完成数据迁移任务。
        /// 选择采用增量迁移方式的任务, 需要在迁移进度进入准备完成阶段后, 调用本接口, 停止迁移增量数据。
        /// 通过DescribeMigrateJobs接口查询到任务的状态为准备完成（status=8）时，此时可以调用本接口完成迁移任务。
        /// </summary>
        /// <param name="req"><see cref="CompleteMigrateJobRequest"/></param>
        /// <returns><see cref="CompleteMigrateJobResponse"/></returns>
        public CompleteMigrateJobResponse CompleteMigrateJobSync(CompleteMigrateJobRequest req)
        {
            return InternalRequestAsync<CompleteMigrateJobResponse>(req, "CompleteMigrateJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建校验迁移任务
        /// 在开始迁移前, 必须调用本接口创建校验, 且校验成功后才能开始迁移. 校验的结果可以通过DescribeMigrateCheckJob查看.
        /// 校验成功后,迁移任务若有修改, 则必须重新创建校验并通过后, 才能开始迁移.
        /// 
        /// 如果是金融区链路, 请使用域名: https://dts.ap-shenzhen-fsi.tencentcloudapi.com
        /// </summary>
        /// <param name="req"><see cref="CreateMigrateCheckJobRequest"/></param>
        /// <returns><see cref="CreateMigrateCheckJobResponse"/></returns>
        public Task<CreateMigrateCheckJobResponse> CreateMigrateCheckJob(CreateMigrateCheckJobRequest req)
        {
            return InternalRequestAsync<CreateMigrateCheckJobResponse>(req, "CreateMigrateCheckJob");
        }

        /// <summary>
        /// 创建校验迁移任务
        /// 在开始迁移前, 必须调用本接口创建校验, 且校验成功后才能开始迁移. 校验的结果可以通过DescribeMigrateCheckJob查看.
        /// 校验成功后,迁移任务若有修改, 则必须重新创建校验并通过后, 才能开始迁移.
        /// 
        /// 如果是金融区链路, 请使用域名: https://dts.ap-shenzhen-fsi.tencentcloudapi.com
        /// </summary>
        /// <param name="req"><see cref="CreateMigrateCheckJobRequest"/></param>
        /// <returns><see cref="CreateMigrateCheckJobResponse"/></returns>
        public CreateMigrateCheckJobResponse CreateMigrateCheckJobSync(CreateMigrateCheckJobRequest req)
        {
            return InternalRequestAsync<CreateMigrateCheckJobResponse>(req, "CreateMigrateCheckJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（CreateMigrateJob）用于创建数据迁移任务。
        /// 
        /// 如果是金融区链路, 请使用域名: dts.ap-shenzhen-fsi.tencentcloudapi.com
        /// </summary>
        /// <param name="req"><see cref="CreateMigrateJobRequest"/></param>
        /// <returns><see cref="CreateMigrateJobResponse"/></returns>
        public Task<CreateMigrateJobResponse> CreateMigrateJob(CreateMigrateJobRequest req)
        {
            return InternalRequestAsync<CreateMigrateJobResponse>(req, "CreateMigrateJob");
        }

        /// <summary>
        /// 本接口（CreateMigrateJob）用于创建数据迁移任务。
        /// 
        /// 如果是金融区链路, 请使用域名: dts.ap-shenzhen-fsi.tencentcloudapi.com
        /// </summary>
        /// <param name="req"><see cref="CreateMigrateJobRequest"/></param>
        /// <returns><see cref="CreateMigrateJobResponse"/></returns>
        public CreateMigrateJobResponse CreateMigrateJobSync(CreateMigrateJobRequest req)
        {
            return InternalRequestAsync<CreateMigrateJobResponse>(req, "CreateMigrateJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(CreateSubscribe)用于创建一个数据订阅实例。
        /// </summary>
        /// <param name="req"><see cref="CreateSubscribeRequest"/></param>
        /// <returns><see cref="CreateSubscribeResponse"/></returns>
        public Task<CreateSubscribeResponse> CreateSubscribe(CreateSubscribeRequest req)
        {
            return InternalRequestAsync<CreateSubscribeResponse>(req, "CreateSubscribe");
        }

        /// <summary>
        /// 本接口(CreateSubscribe)用于创建一个数据订阅实例。
        /// </summary>
        /// <param name="req"><see cref="CreateSubscribeRequest"/></param>
        /// <returns><see cref="CreateSubscribeResponse"/></returns>
        public CreateSubscribeResponse CreateSubscribeSync(CreateSubscribeRequest req)
        {
            return InternalRequestAsync<CreateSubscribeResponse>(req, "CreateSubscribe")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DeleteMigrationJob）用于删除数据迁移任务。当通过DescribeMigrateJobs接口查询到任务的状态为：检验中（status=3）、运行中（status=7）、准备完成（status=8）、撤销中（status=11）或者完成中（status=12）时，不允许删除任务。
        /// </summary>
        /// <param name="req"><see cref="DeleteMigrateJobRequest"/></param>
        /// <returns><see cref="DeleteMigrateJobResponse"/></returns>
        public Task<DeleteMigrateJobResponse> DeleteMigrateJob(DeleteMigrateJobRequest req)
        {
            return InternalRequestAsync<DeleteMigrateJobResponse>(req, "DeleteMigrateJob");
        }

        /// <summary>
        /// 本接口（DeleteMigrationJob）用于删除数据迁移任务。当通过DescribeMigrateJobs接口查询到任务的状态为：检验中（status=3）、运行中（status=7）、准备完成（status=8）、撤销中（status=11）或者完成中（status=12）时，不允许删除任务。
        /// </summary>
        /// <param name="req"><see cref="DeleteMigrateJobRequest"/></param>
        /// <returns><see cref="DeleteMigrateJobResponse"/></returns>
        public DeleteMigrateJobResponse DeleteMigrateJobSync(DeleteMigrateJobRequest req)
        {
            return InternalRequestAsync<DeleteMigrateJobResponse>(req, "DeleteMigrateJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeAsyncRequestInfo）用于查询任务执行结果
        /// </summary>
        /// <param name="req"><see cref="DescribeAsyncRequestInfoRequest"/></param>
        /// <returns><see cref="DescribeAsyncRequestInfoResponse"/></returns>
        public Task<DescribeAsyncRequestInfoResponse> DescribeAsyncRequestInfo(DescribeAsyncRequestInfoRequest req)
        {
            return InternalRequestAsync<DescribeAsyncRequestInfoResponse>(req, "DescribeAsyncRequestInfo");
        }

        /// <summary>
        /// 本接口（DescribeAsyncRequestInfo）用于查询任务执行结果
        /// </summary>
        /// <param name="req"><see cref="DescribeAsyncRequestInfoRequest"/></param>
        /// <returns><see cref="DescribeAsyncRequestInfoResponse"/></returns>
        public DescribeAsyncRequestInfoResponse DescribeAsyncRequestInfoSync(DescribeAsyncRequestInfoRequest req)
        {
            return InternalRequestAsync<DescribeAsyncRequestInfoResponse>(req, "DescribeAsyncRequestInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用于创建校验后,获取校验的结果. 能查询到当前校验的状态和进度. 
        /// 若通过校验, 则可调用'StartMigrateJob' 开始迁移.
        /// 若未通过校验, 则能查询到校验失败的原因. 请按照报错, 通过'ModifyMigrateJob'修改迁移配置或是调整源/目标实例的相关参数.
        /// </summary>
        /// <param name="req"><see cref="DescribeMigrateCheckJobRequest"/></param>
        /// <returns><see cref="DescribeMigrateCheckJobResponse"/></returns>
        public Task<DescribeMigrateCheckJobResponse> DescribeMigrateCheckJob(DescribeMigrateCheckJobRequest req)
        {
            return InternalRequestAsync<DescribeMigrateCheckJobResponse>(req, "DescribeMigrateCheckJob");
        }

        /// <summary>
        /// 本接口用于创建校验后,获取校验的结果. 能查询到当前校验的状态和进度. 
        /// 若通过校验, 则可调用'StartMigrateJob' 开始迁移.
        /// 若未通过校验, 则能查询到校验失败的原因. 请按照报错, 通过'ModifyMigrateJob'修改迁移配置或是调整源/目标实例的相关参数.
        /// </summary>
        /// <param name="req"><see cref="DescribeMigrateCheckJobRequest"/></param>
        /// <returns><see cref="DescribeMigrateCheckJobResponse"/></returns>
        public DescribeMigrateCheckJobResponse DescribeMigrateCheckJobSync(DescribeMigrateCheckJobRequest req)
        {
            return InternalRequestAsync<DescribeMigrateCheckJobResponse>(req, "DescribeMigrateCheckJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询数据迁移任务.
        /// 如果是金融区链路, 请使用域名: https://dts.ap-shenzhen-fsi.tencentcloudapi.com
        /// </summary>
        /// <param name="req"><see cref="DescribeMigrateJobsRequest"/></param>
        /// <returns><see cref="DescribeMigrateJobsResponse"/></returns>
        public Task<DescribeMigrateJobsResponse> DescribeMigrateJobs(DescribeMigrateJobsRequest req)
        {
            return InternalRequestAsync<DescribeMigrateJobsResponse>(req, "DescribeMigrateJobs");
        }

        /// <summary>
        /// 查询数据迁移任务.
        /// 如果是金融区链路, 请使用域名: https://dts.ap-shenzhen-fsi.tencentcloudapi.com
        /// </summary>
        /// <param name="req"><see cref="DescribeMigrateJobsRequest"/></param>
        /// <returns><see cref="DescribeMigrateJobsResponse"/></returns>
        public DescribeMigrateJobsResponse DescribeMigrateJobsSync(DescribeMigrateJobsRequest req)
        {
            return InternalRequestAsync<DescribeMigrateJobsResponse>(req, "DescribeMigrateJobs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeSubscribeConf）用于查询订阅实例配置
        /// </summary>
        /// <param name="req"><see cref="DescribeSubscribeConfRequest"/></param>
        /// <returns><see cref="DescribeSubscribeConfResponse"/></returns>
        public Task<DescribeSubscribeConfResponse> DescribeSubscribeConf(DescribeSubscribeConfRequest req)
        {
            return InternalRequestAsync<DescribeSubscribeConfResponse>(req, "DescribeSubscribeConf");
        }

        /// <summary>
        /// 本接口（DescribeSubscribeConf）用于查询订阅实例配置
        /// </summary>
        /// <param name="req"><see cref="DescribeSubscribeConfRequest"/></param>
        /// <returns><see cref="DescribeSubscribeConfResponse"/></returns>
        public DescribeSubscribeConfResponse DescribeSubscribeConfSync(DescribeSubscribeConfRequest req)
        {
            return InternalRequestAsync<DescribeSubscribeConfResponse>(req, "DescribeSubscribeConf")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(DescribeSubscribes)获取数据订阅实例信息列表，默认分页，每次返回20条
        /// </summary>
        /// <param name="req"><see cref="DescribeSubscribesRequest"/></param>
        /// <returns><see cref="DescribeSubscribesResponse"/></returns>
        public Task<DescribeSubscribesResponse> DescribeSubscribes(DescribeSubscribesRequest req)
        {
            return InternalRequestAsync<DescribeSubscribesResponse>(req, "DescribeSubscribes");
        }

        /// <summary>
        /// 本接口(DescribeSubscribes)获取数据订阅实例信息列表，默认分页，每次返回20条
        /// </summary>
        /// <param name="req"><see cref="DescribeSubscribesRequest"/></param>
        /// <returns><see cref="DescribeSubscribesResponse"/></returns>
        public DescribeSubscribesResponse DescribeSubscribesSync(DescribeSubscribesRequest req)
        {
            return InternalRequestAsync<DescribeSubscribesResponse>(req, "DescribeSubscribes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（IsolateSubscribe）用于隔离小时计费的订阅实例。调用后，订阅实例将不能使用，同时停止计费。
        /// </summary>
        /// <param name="req"><see cref="IsolateSubscribeRequest"/></param>
        /// <returns><see cref="IsolateSubscribeResponse"/></returns>
        public Task<IsolateSubscribeResponse> IsolateSubscribe(IsolateSubscribeRequest req)
        {
            return InternalRequestAsync<IsolateSubscribeResponse>(req, "IsolateSubscribe");
        }

        /// <summary>
        /// 本接口（IsolateSubscribe）用于隔离小时计费的订阅实例。调用后，订阅实例将不能使用，同时停止计费。
        /// </summary>
        /// <param name="req"><see cref="IsolateSubscribeRequest"/></param>
        /// <returns><see cref="IsolateSubscribeResponse"/></returns>
        public IsolateSubscribeResponse IsolateSubscribeSync(IsolateSubscribeRequest req)
        {
            return InternalRequestAsync<IsolateSubscribeResponse>(req, "IsolateSubscribe")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ModifyMigrateJob）用于修改数据迁移任务。
        /// 当迁移任务处于下述状态时，允许调用本接口修改迁移任务：迁移创建中（status=1）、 校验成功(status=4)、校验失败(status=5)、迁移失败(status=10)。但源实例、目标实例类型和目标实例地域不允许修改。
        /// 
        /// 如果是金融区链路, 请使用域名: dts.ap-shenzhen-fsi.tencentcloudapi.com
        /// </summary>
        /// <param name="req"><see cref="ModifyMigrateJobRequest"/></param>
        /// <returns><see cref="ModifyMigrateJobResponse"/></returns>
        public Task<ModifyMigrateJobResponse> ModifyMigrateJob(ModifyMigrateJobRequest req)
        {
            return InternalRequestAsync<ModifyMigrateJobResponse>(req, "ModifyMigrateJob");
        }

        /// <summary>
        /// 本接口（ModifyMigrateJob）用于修改数据迁移任务。
        /// 当迁移任务处于下述状态时，允许调用本接口修改迁移任务：迁移创建中（status=1）、 校验成功(status=4)、校验失败(status=5)、迁移失败(status=10)。但源实例、目标实例类型和目标实例地域不允许修改。
        /// 
        /// 如果是金融区链路, 请使用域名: dts.ap-shenzhen-fsi.tencentcloudapi.com
        /// </summary>
        /// <param name="req"><see cref="ModifyMigrateJobRequest"/></param>
        /// <returns><see cref="ModifyMigrateJobResponse"/></returns>
        public ModifyMigrateJobResponse ModifyMigrateJobSync(ModifyMigrateJobRequest req)
        {
            return InternalRequestAsync<ModifyMigrateJobResponse>(req, "ModifyMigrateJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改订阅实例自动续费标识
        /// </summary>
        /// <param name="req"><see cref="ModifySubscribeAutoRenewFlagRequest"/></param>
        /// <returns><see cref="ModifySubscribeAutoRenewFlagResponse"/></returns>
        public Task<ModifySubscribeAutoRenewFlagResponse> ModifySubscribeAutoRenewFlag(ModifySubscribeAutoRenewFlagRequest req)
        {
            return InternalRequestAsync<ModifySubscribeAutoRenewFlagResponse>(req, "ModifySubscribeAutoRenewFlag");
        }

        /// <summary>
        /// 修改订阅实例自动续费标识
        /// </summary>
        /// <param name="req"><see cref="ModifySubscribeAutoRenewFlagRequest"/></param>
        /// <returns><see cref="ModifySubscribeAutoRenewFlagResponse"/></returns>
        public ModifySubscribeAutoRenewFlagResponse ModifySubscribeAutoRenewFlagSync(ModifySubscribeAutoRenewFlagRequest req)
        {
            return InternalRequestAsync<ModifySubscribeAutoRenewFlagResponse>(req, "ModifySubscribeAutoRenewFlag")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(ModifySubscribeConsumeTime)用于修改数据订阅通道的消费时间点
        /// </summary>
        /// <param name="req"><see cref="ModifySubscribeConsumeTimeRequest"/></param>
        /// <returns><see cref="ModifySubscribeConsumeTimeResponse"/></returns>
        public Task<ModifySubscribeConsumeTimeResponse> ModifySubscribeConsumeTime(ModifySubscribeConsumeTimeRequest req)
        {
            return InternalRequestAsync<ModifySubscribeConsumeTimeResponse>(req, "ModifySubscribeConsumeTime");
        }

        /// <summary>
        /// 本接口(ModifySubscribeConsumeTime)用于修改数据订阅通道的消费时间点
        /// </summary>
        /// <param name="req"><see cref="ModifySubscribeConsumeTimeRequest"/></param>
        /// <returns><see cref="ModifySubscribeConsumeTimeResponse"/></returns>
        public ModifySubscribeConsumeTimeResponse ModifySubscribeConsumeTimeSync(ModifySubscribeConsumeTimeRequest req)
        {
            return InternalRequestAsync<ModifySubscribeConsumeTimeResponse>(req, "ModifySubscribeConsumeTime")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(ModifySubscribeName)用于修改数据订阅实例的名称
        /// </summary>
        /// <param name="req"><see cref="ModifySubscribeNameRequest"/></param>
        /// <returns><see cref="ModifySubscribeNameResponse"/></returns>
        public Task<ModifySubscribeNameResponse> ModifySubscribeName(ModifySubscribeNameRequest req)
        {
            return InternalRequestAsync<ModifySubscribeNameResponse>(req, "ModifySubscribeName");
        }

        /// <summary>
        /// 本接口(ModifySubscribeName)用于修改数据订阅实例的名称
        /// </summary>
        /// <param name="req"><see cref="ModifySubscribeNameRequest"/></param>
        /// <returns><see cref="ModifySubscribeNameResponse"/></returns>
        public ModifySubscribeNameResponse ModifySubscribeNameSync(ModifySubscribeNameRequest req)
        {
            return InternalRequestAsync<ModifySubscribeNameResponse>(req, "ModifySubscribeName")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(ModifySubscribeObjects)用于修改数据订阅通道的订阅规则
        /// </summary>
        /// <param name="req"><see cref="ModifySubscribeObjectsRequest"/></param>
        /// <returns><see cref="ModifySubscribeObjectsResponse"/></returns>
        public Task<ModifySubscribeObjectsResponse> ModifySubscribeObjects(ModifySubscribeObjectsRequest req)
        {
            return InternalRequestAsync<ModifySubscribeObjectsResponse>(req, "ModifySubscribeObjects");
        }

        /// <summary>
        /// 本接口(ModifySubscribeObjects)用于修改数据订阅通道的订阅规则
        /// </summary>
        /// <param name="req"><see cref="ModifySubscribeObjectsRequest"/></param>
        /// <returns><see cref="ModifySubscribeObjectsResponse"/></returns>
        public ModifySubscribeObjectsResponse ModifySubscribeObjectsSync(ModifySubscribeObjectsRequest req)
        {
            return InternalRequestAsync<ModifySubscribeObjectsResponse>(req, "ModifySubscribeObjects")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(ModifySubscribeVipVport)用于修改数据订阅实例的IP和端口号
        /// </summary>
        /// <param name="req"><see cref="ModifySubscribeVipVportRequest"/></param>
        /// <returns><see cref="ModifySubscribeVipVportResponse"/></returns>
        public Task<ModifySubscribeVipVportResponse> ModifySubscribeVipVport(ModifySubscribeVipVportRequest req)
        {
            return InternalRequestAsync<ModifySubscribeVipVportResponse>(req, "ModifySubscribeVipVport");
        }

        /// <summary>
        /// 本接口(ModifySubscribeVipVport)用于修改数据订阅实例的IP和端口号
        /// </summary>
        /// <param name="req"><see cref="ModifySubscribeVipVportRequest"/></param>
        /// <returns><see cref="ModifySubscribeVipVportResponse"/></returns>
        public ModifySubscribeVipVportResponse ModifySubscribeVipVportSync(ModifySubscribeVipVportRequest req)
        {
            return InternalRequestAsync<ModifySubscribeVipVportResponse>(req, "ModifySubscribeVipVport")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（OfflineIsolatedSubscribe）用于下线已隔离的数据订阅实例
        /// </summary>
        /// <param name="req"><see cref="OfflineIsolatedSubscribeRequest"/></param>
        /// <returns><see cref="OfflineIsolatedSubscribeResponse"/></returns>
        public Task<OfflineIsolatedSubscribeResponse> OfflineIsolatedSubscribe(OfflineIsolatedSubscribeRequest req)
        {
            return InternalRequestAsync<OfflineIsolatedSubscribeResponse>(req, "OfflineIsolatedSubscribe");
        }

        /// <summary>
        /// 本接口（OfflineIsolatedSubscribe）用于下线已隔离的数据订阅实例
        /// </summary>
        /// <param name="req"><see cref="OfflineIsolatedSubscribeRequest"/></param>
        /// <returns><see cref="OfflineIsolatedSubscribeResponse"/></returns>
        public OfflineIsolatedSubscribeResponse OfflineIsolatedSubscribeSync(OfflineIsolatedSubscribeRequest req)
        {
            return InternalRequestAsync<OfflineIsolatedSubscribeResponse>(req, "OfflineIsolatedSubscribe")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(ResetSubscribe)用于重置数据订阅实例，已经激活的数据订阅实例，重置后可以使用ActivateSubscribe接口绑定其他的数据库实例
        /// </summary>
        /// <param name="req"><see cref="ResetSubscribeRequest"/></param>
        /// <returns><see cref="ResetSubscribeResponse"/></returns>
        public Task<ResetSubscribeResponse> ResetSubscribe(ResetSubscribeRequest req)
        {
            return InternalRequestAsync<ResetSubscribeResponse>(req, "ResetSubscribe");
        }

        /// <summary>
        /// 本接口(ResetSubscribe)用于重置数据订阅实例，已经激活的数据订阅实例，重置后可以使用ActivateSubscribe接口绑定其他的数据库实例
        /// </summary>
        /// <param name="req"><see cref="ResetSubscribeRequest"/></param>
        /// <returns><see cref="ResetSubscribeResponse"/></returns>
        public ResetSubscribeResponse ResetSubscribeSync(ResetSubscribeRequest req)
        {
            return InternalRequestAsync<ResetSubscribeResponse>(req, "ResetSubscribe")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（StartMigrationJob）用于启动迁移任务。非定时迁移任务会在调用后立即开始迁移，定时任务则会开始倒计时。
        /// 调用此接口前，请务必先使用CreateMigrateCheckJob校验数据迁移任务，并通过DescribeMigrateJobs接口查询到任务状态为校验通过（status=4）时，才能启动数据迁移任务。
        /// </summary>
        /// <param name="req"><see cref="StartMigrateJobRequest"/></param>
        /// <returns><see cref="StartMigrateJobResponse"/></returns>
        public Task<StartMigrateJobResponse> StartMigrateJob(StartMigrateJobRequest req)
        {
            return InternalRequestAsync<StartMigrateJobResponse>(req, "StartMigrateJob");
        }

        /// <summary>
        /// 本接口（StartMigrationJob）用于启动迁移任务。非定时迁移任务会在调用后立即开始迁移，定时任务则会开始倒计时。
        /// 调用此接口前，请务必先使用CreateMigrateCheckJob校验数据迁移任务，并通过DescribeMigrateJobs接口查询到任务状态为校验通过（status=4）时，才能启动数据迁移任务。
        /// </summary>
        /// <param name="req"><see cref="StartMigrateJobRequest"/></param>
        /// <returns><see cref="StartMigrateJobResponse"/></returns>
        public StartMigrateJobResponse StartMigrateJobSync(StartMigrateJobRequest req)
        {
            return InternalRequestAsync<StartMigrateJobResponse>(req, "StartMigrateJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（StopMigrateJob）用于撤销数据迁移任务。
        /// 在迁移过程中允许调用该接口撤销迁移, 撤销迁移的任务会失败。通过DescribeMigrateJobs接口查询到任务状态为运行中（status=7）或准备完成（status=8）时，才能撤销数据迁移任务。
        /// </summary>
        /// <param name="req"><see cref="StopMigrateJobRequest"/></param>
        /// <returns><see cref="StopMigrateJobResponse"/></returns>
        public Task<StopMigrateJobResponse> StopMigrateJob(StopMigrateJobRequest req)
        {
            return InternalRequestAsync<StopMigrateJobResponse>(req, "StopMigrateJob");
        }

        /// <summary>
        /// 本接口（StopMigrateJob）用于撤销数据迁移任务。
        /// 在迁移过程中允许调用该接口撤销迁移, 撤销迁移的任务会失败。通过DescribeMigrateJobs接口查询到任务状态为运行中（status=7）或准备完成（status=8）时，才能撤销数据迁移任务。
        /// </summary>
        /// <param name="req"><see cref="StopMigrateJobRequest"/></param>
        /// <returns><see cref="StopMigrateJobResponse"/></returns>
        public StopMigrateJobResponse StopMigrateJobSync(StopMigrateJobRequest req)
        {
            return InternalRequestAsync<StopMigrateJobResponse>(req, "StopMigrateJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
