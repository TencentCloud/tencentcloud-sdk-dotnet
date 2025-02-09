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

namespace TencentCloud.Ioa.V20220601
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Ioa.V20220601.Models;

   public class IoaClient : AbstractClient{

       private const string endpoint = "ioa.tencentcloudapi.com";
       private const string version = "2022-06-01";
       private const string sdkVersion = "SDK_NET_3.0.1176";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public IoaClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public IoaClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 创建终端自定义分组，私有化调用path为：/capi/Assets/Device/CreateDeviceVirtualGroup
        /// </summary>
        /// <param name="req"><see cref="CreateDeviceVirtualGroupRequest"/></param>
        /// <returns><see cref="CreateDeviceVirtualGroupResponse"/></returns>
        public Task<CreateDeviceVirtualGroupResponse> CreateDeviceVirtualGroup(CreateDeviceVirtualGroupRequest req)
        {
            return InternalRequestAsync<CreateDeviceVirtualGroupResponse>(req, "CreateDeviceVirtualGroup");
        }

        /// <summary>
        /// 创建终端自定义分组，私有化调用path为：/capi/Assets/Device/CreateDeviceVirtualGroup
        /// </summary>
        /// <param name="req"><see cref="CreateDeviceVirtualGroupRequest"/></param>
        /// <returns><see cref="CreateDeviceVirtualGroupResponse"/></returns>
        public CreateDeviceVirtualGroupResponse CreateDeviceVirtualGroupSync(CreateDeviceVirtualGroupRequest req)
        {
            return InternalRequestAsync<CreateDeviceVirtualGroupResponse>(req, "CreateDeviceVirtualGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 以分页的方式查询账号分组列表，私有化调用path为：/capi/Assets/DescribeAccountGroups
        /// </summary>
        /// <param name="req"><see cref="DescribeAccountGroupsRequest"/></param>
        /// <returns><see cref="DescribeAccountGroupsResponse"/></returns>
        public Task<DescribeAccountGroupsResponse> DescribeAccountGroups(DescribeAccountGroupsRequest req)
        {
            return InternalRequestAsync<DescribeAccountGroupsResponse>(req, "DescribeAccountGroups");
        }

        /// <summary>
        /// 以分页的方式查询账号分组列表，私有化调用path为：/capi/Assets/DescribeAccountGroups
        /// </summary>
        /// <param name="req"><see cref="DescribeAccountGroupsRequest"/></param>
        /// <returns><see cref="DescribeAccountGroupsResponse"/></returns>
        public DescribeAccountGroupsResponse DescribeAccountGroupsSync(DescribeAccountGroupsRequest req)
        {
            return InternalRequestAsync<DescribeAccountGroupsResponse>(req, "DescribeAccountGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询满足条件的终端数据详情，私有化调用path为：/capi/Assets/Device/DescribeDevices
        /// </summary>
        /// <param name="req"><see cref="DescribeDevicesRequest"/></param>
        /// <returns><see cref="DescribeDevicesResponse"/></returns>
        public Task<DescribeDevicesResponse> DescribeDevices(DescribeDevicesRequest req)
        {
            return InternalRequestAsync<DescribeDevicesResponse>(req, "DescribeDevices");
        }

        /// <summary>
        /// 查询满足条件的终端数据详情，私有化调用path为：/capi/Assets/Device/DescribeDevices
        /// </summary>
        /// <param name="req"><see cref="DescribeDevicesRequest"/></param>
        /// <returns><see cref="DescribeDevicesResponse"/></returns>
        public DescribeDevicesResponse DescribeDevicesSync(DescribeDevicesRequest req)
        {
            return InternalRequestAsync<DescribeDevicesResponse>(req, "DescribeDevices")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取账号列表，支持分页，模糊搜索，私有化调用path为：/capi/Assets/Account/DescribeLocalAccounts
        /// </summary>
        /// <param name="req"><see cref="DescribeLocalAccountsRequest"/></param>
        /// <returns><see cref="DescribeLocalAccountsResponse"/></returns>
        public Task<DescribeLocalAccountsResponse> DescribeLocalAccounts(DescribeLocalAccountsRequest req)
        {
            return InternalRequestAsync<DescribeLocalAccountsResponse>(req, "DescribeLocalAccounts");
        }

        /// <summary>
        /// 获取账号列表，支持分页，模糊搜索，私有化调用path为：/capi/Assets/Account/DescribeLocalAccounts
        /// </summary>
        /// <param name="req"><see cref="DescribeLocalAccountsRequest"/></param>
        /// <returns><see cref="DescribeLocalAccountsResponse"/></returns>
        public DescribeLocalAccountsResponse DescribeLocalAccountsSync(DescribeLocalAccountsRequest req)
        {
            return InternalRequestAsync<DescribeLocalAccountsResponse>(req, "DescribeLocalAccounts")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询账号根分组详情。对应“用户与授权管理”里内置不可见的全网根账号组，所有新建的目录，都挂在该全网根账号组下。
        /// </summary>
        /// <param name="req"><see cref="DescribeRootAccountGroupRequest"/></param>
        /// <returns><see cref="DescribeRootAccountGroupResponse"/></returns>
        public Task<DescribeRootAccountGroupResponse> DescribeRootAccountGroup(DescribeRootAccountGroupRequest req)
        {
            return InternalRequestAsync<DescribeRootAccountGroupResponse>(req, "DescribeRootAccountGroup");
        }

        /// <summary>
        /// 查询账号根分组详情。对应“用户与授权管理”里内置不可见的全网根账号组，所有新建的目录，都挂在该全网根账号组下。
        /// </summary>
        /// <param name="req"><see cref="DescribeRootAccountGroupRequest"/></param>
        /// <returns><see cref="DescribeRootAccountGroupResponse"/></returns>
        public DescribeRootAccountGroupResponse DescribeRootAccountGroupSync(DescribeRootAccountGroupRequest req)
        {
            return InternalRequestAsync<DescribeRootAccountGroupResponse>(req, "DescribeRootAccountGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
