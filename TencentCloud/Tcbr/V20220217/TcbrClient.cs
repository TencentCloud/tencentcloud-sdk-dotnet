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

namespace TencentCloud.Tcbr.V20220217
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Tcbr.V20220217.Models;

   public class TcbrClient : AbstractClient{

       private const string endpoint = "tcbr.tencentcloudapi.com";
       private const string version = "2022-02-17";
       private const string sdkVersion = "SDK_NET_3.0.1134";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public TcbrClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public TcbrClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 创建云托管环境，并开通资源。
        /// </summary>
        /// <param name="req"><see cref="CreateCloudRunEnvRequest"/></param>
        /// <returns><see cref="CreateCloudRunEnvResponse"/></returns>
        public Task<CreateCloudRunEnvResponse> CreateCloudRunEnv(CreateCloudRunEnvRequest req)
        {
            return InternalRequestAsync<CreateCloudRunEnvResponse>(req, "CreateCloudRunEnv");
        }

        /// <summary>
        /// 创建云托管环境，并开通资源。
        /// </summary>
        /// <param name="req"><see cref="CreateCloudRunEnvRequest"/></param>
        /// <returns><see cref="CreateCloudRunEnvResponse"/></returns>
        public CreateCloudRunEnvResponse CreateCloudRunEnvSync(CreateCloudRunEnvRequest req)
        {
            return InternalRequestAsync<CreateCloudRunEnvResponse>(req, "CreateCloudRunEnv")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建云托管服务接口
        /// </summary>
        /// <param name="req"><see cref="CreateCloudRunServerRequest"/></param>
        /// <returns><see cref="CreateCloudRunServerResponse"/></returns>
        public Task<CreateCloudRunServerResponse> CreateCloudRunServer(CreateCloudRunServerRequest req)
        {
            return InternalRequestAsync<CreateCloudRunServerResponse>(req, "CreateCloudRunServer");
        }

        /// <summary>
        /// 创建云托管服务接口
        /// </summary>
        /// <param name="req"><see cref="CreateCloudRunServerRequest"/></param>
        /// <returns><see cref="CreateCloudRunServerResponse"/></returns>
        public CreateCloudRunServerResponse CreateCloudRunServerSync(CreateCloudRunServerRequest req)
        {
            return InternalRequestAsync<CreateCloudRunServerResponse>(req, "CreateCloudRunServer")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取环境列表，含环境下的各个资源信息。尤其是各资源的唯一标识，是请求各资源的关键参数
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudRunEnvsRequest"/></param>
        /// <returns><see cref="DescribeCloudRunEnvsResponse"/></returns>
        public Task<DescribeCloudRunEnvsResponse> DescribeCloudRunEnvs(DescribeCloudRunEnvsRequest req)
        {
            return InternalRequestAsync<DescribeCloudRunEnvsResponse>(req, "DescribeCloudRunEnvs");
        }

        /// <summary>
        /// 获取环境列表，含环境下的各个资源信息。尤其是各资源的唯一标识，是请求各资源的关键参数
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudRunEnvsRequest"/></param>
        /// <returns><see cref="DescribeCloudRunEnvsResponse"/></returns>
        public DescribeCloudRunEnvsResponse DescribeCloudRunEnvsSync(DescribeCloudRunEnvsRequest req)
        {
            return InternalRequestAsync<DescribeCloudRunEnvsResponse>(req, "DescribeCloudRunEnvs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询云托管服务详情
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudRunServerDetailRequest"/></param>
        /// <returns><see cref="DescribeCloudRunServerDetailResponse"/></returns>
        public Task<DescribeCloudRunServerDetailResponse> DescribeCloudRunServerDetail(DescribeCloudRunServerDetailRequest req)
        {
            return InternalRequestAsync<DescribeCloudRunServerDetailResponse>(req, "DescribeCloudRunServerDetail");
        }

        /// <summary>
        /// 查询云托管服务详情
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudRunServerDetailRequest"/></param>
        /// <returns><see cref="DescribeCloudRunServerDetailResponse"/></returns>
        public DescribeCloudRunServerDetailResponse DescribeCloudRunServerDetailSync(DescribeCloudRunServerDetailRequest req)
        {
            return InternalRequestAsync<DescribeCloudRunServerDetailResponse>(req, "DescribeCloudRunServerDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询云托管服务列表接口
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudRunServersRequest"/></param>
        /// <returns><see cref="DescribeCloudRunServersResponse"/></returns>
        public Task<DescribeCloudRunServersResponse> DescribeCloudRunServers(DescribeCloudRunServersRequest req)
        {
            return InternalRequestAsync<DescribeCloudRunServersResponse>(req, "DescribeCloudRunServers");
        }

        /// <summary>
        /// 查询云托管服务列表接口
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudRunServersRequest"/></param>
        /// <returns><see cref="DescribeCloudRunServersResponse"/></returns>
        public DescribeCloudRunServersResponse DescribeCloudRunServersSync(DescribeCloudRunServersRequest req)
        {
            return InternalRequestAsync<DescribeCloudRunServersResponse>(req, "DescribeCloudRunServers")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询环境基础信息
        /// </summary>
        /// <param name="req"><see cref="DescribeEnvBaseInfoRequest"/></param>
        /// <returns><see cref="DescribeEnvBaseInfoResponse"/></returns>
        public Task<DescribeEnvBaseInfoResponse> DescribeEnvBaseInfo(DescribeEnvBaseInfoRequest req)
        {
            return InternalRequestAsync<DescribeEnvBaseInfoResponse>(req, "DescribeEnvBaseInfo");
        }

        /// <summary>
        /// 查询环境基础信息
        /// </summary>
        /// <param name="req"><see cref="DescribeEnvBaseInfoRequest"/></param>
        /// <returns><see cref="DescribeEnvBaseInfoResponse"/></returns>
        public DescribeEnvBaseInfoResponse DescribeEnvBaseInfoSync(DescribeEnvBaseInfoRequest req)
        {
            return InternalRequestAsync<DescribeEnvBaseInfoResponse>(req, "DescribeEnvBaseInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询服务管理任务信息
        /// </summary>
        /// <param name="req"><see cref="DescribeServerManageTaskRequest"/></param>
        /// <returns><see cref="DescribeServerManageTaskResponse"/></returns>
        public Task<DescribeServerManageTaskResponse> DescribeServerManageTask(DescribeServerManageTaskRequest req)
        {
            return InternalRequestAsync<DescribeServerManageTaskResponse>(req, "DescribeServerManageTask");
        }

        /// <summary>
        /// 查询服务管理任务信息
        /// </summary>
        /// <param name="req"><see cref="DescribeServerManageTaskRequest"/></param>
        /// <returns><see cref="DescribeServerManageTaskResponse"/></returns>
        public DescribeServerManageTaskResponse DescribeServerManageTaskSync(DescribeServerManageTaskRequest req)
        {
            return InternalRequestAsync<DescribeServerManageTaskResponse>(req, "DescribeServerManageTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 操作发布单
        /// </summary>
        /// <param name="req"><see cref="OperateServerManageRequest"/></param>
        /// <returns><see cref="OperateServerManageResponse"/></returns>
        public Task<OperateServerManageResponse> OperateServerManage(OperateServerManageRequest req)
        {
            return InternalRequestAsync<OperateServerManageResponse>(req, "OperateServerManage");
        }

        /// <summary>
        /// 操作发布单
        /// </summary>
        /// <param name="req"><see cref="OperateServerManageRequest"/></param>
        /// <returns><see cref="OperateServerManageResponse"/></returns>
        public OperateServerManageResponse OperateServerManageSync(OperateServerManageRequest req)
        {
            return InternalRequestAsync<OperateServerManageResponse>(req, "OperateServerManage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 灰度发布
        /// </summary>
        /// <param name="req"><see cref="ReleaseGrayRequest"/></param>
        /// <returns><see cref="ReleaseGrayResponse"/></returns>
        public Task<ReleaseGrayResponse> ReleaseGray(ReleaseGrayRequest req)
        {
            return InternalRequestAsync<ReleaseGrayResponse>(req, "ReleaseGray");
        }

        /// <summary>
        /// 灰度发布
        /// </summary>
        /// <param name="req"><see cref="ReleaseGrayRequest"/></param>
        /// <returns><see cref="ReleaseGrayResponse"/></returns>
        public ReleaseGrayResponse ReleaseGraySync(ReleaseGrayRequest req)
        {
            return InternalRequestAsync<ReleaseGrayResponse>(req, "ReleaseGray")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新云托管服务
        /// </summary>
        /// <param name="req"><see cref="UpdateCloudRunServerRequest"/></param>
        /// <returns><see cref="UpdateCloudRunServerResponse"/></returns>
        public Task<UpdateCloudRunServerResponse> UpdateCloudRunServer(UpdateCloudRunServerRequest req)
        {
            return InternalRequestAsync<UpdateCloudRunServerResponse>(req, "UpdateCloudRunServer");
        }

        /// <summary>
        /// 更新云托管服务
        /// </summary>
        /// <param name="req"><see cref="UpdateCloudRunServerRequest"/></param>
        /// <returns><see cref="UpdateCloudRunServerResponse"/></returns>
        public UpdateCloudRunServerResponse UpdateCloudRunServerSync(UpdateCloudRunServerRequest req)
        {
            return InternalRequestAsync<UpdateCloudRunServerResponse>(req, "UpdateCloudRunServer")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
