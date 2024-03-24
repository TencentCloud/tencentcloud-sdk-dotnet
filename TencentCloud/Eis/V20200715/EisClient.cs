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

namespace TencentCloud.Eis.V20200715
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Eis.V20200715.Models;

   public class EisClient : AbstractClient{

       private const string endpoint = "eis.tencentcloudapi.com";
       private const string version = "2020-07-15";
       private const string sdkVersion = "SDK_NET_3.0.971";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public EisClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public EisClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 获取连接器配置参数
        /// </summary>
        /// <param name="req"><see cref="DescribeEisConnectorConfigRequest"/></param>
        /// <returns><see cref="DescribeEisConnectorConfigResponse"/></returns>
        public Task<DescribeEisConnectorConfigResponse> DescribeEisConnectorConfig(DescribeEisConnectorConfigRequest req)
        {
            return InternalRequestAsync<DescribeEisConnectorConfigResponse>(req, "DescribeEisConnectorConfig");
        }

        /// <summary>
        /// 获取连接器配置参数
        /// </summary>
        /// <param name="req"><see cref="DescribeEisConnectorConfigRequest"/></param>
        /// <returns><see cref="DescribeEisConnectorConfigResponse"/></returns>
        public DescribeEisConnectorConfigResponse DescribeEisConnectorConfigSync(DescribeEisConnectorConfigRequest req)
        {
            return InternalRequestAsync<DescribeEisConnectorConfigResponse>(req, "DescribeEisConnectorConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取连接器操作列表
        /// </summary>
        /// <param name="req"><see cref="ListEisConnectorOperationsRequest"/></param>
        /// <returns><see cref="ListEisConnectorOperationsResponse"/></returns>
        public Task<ListEisConnectorOperationsResponse> ListEisConnectorOperations(ListEisConnectorOperationsRequest req)
        {
            return InternalRequestAsync<ListEisConnectorOperationsResponse>(req, "ListEisConnectorOperations");
        }

        /// <summary>
        /// 获取连接器操作列表
        /// </summary>
        /// <param name="req"><see cref="ListEisConnectorOperationsRequest"/></param>
        /// <returns><see cref="ListEisConnectorOperationsResponse"/></returns>
        public ListEisConnectorOperationsResponse ListEisConnectorOperationsSync(ListEisConnectorOperationsRequest req)
        {
            return InternalRequestAsync<ListEisConnectorOperationsResponse>(req, "ListEisConnectorOperations")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 连接器列表
        /// </summary>
        /// <param name="req"><see cref="ListEisConnectorsRequest"/></param>
        /// <returns><see cref="ListEisConnectorsResponse"/></returns>
        public Task<ListEisConnectorsResponse> ListEisConnectors(ListEisConnectorsRequest req)
        {
            return InternalRequestAsync<ListEisConnectorsResponse>(req, "ListEisConnectors");
        }

        /// <summary>
        /// 连接器列表
        /// </summary>
        /// <param name="req"><see cref="ListEisConnectorsRequest"/></param>
        /// <returns><see cref="ListEisConnectorsResponse"/></returns>
        public ListEisConnectorsResponse ListEisConnectorsSync(ListEisConnectorsRequest req)
        {
            return InternalRequestAsync<ListEisConnectorsResponse>(req, "ListEisConnectors")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
