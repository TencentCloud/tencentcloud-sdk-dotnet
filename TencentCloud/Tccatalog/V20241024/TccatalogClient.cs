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

namespace TencentCloud.Tccatalog.V20241024
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Tccatalog.V20241024.Models;

   public class TccatalogClient : AbstractClient{

       private const string endpoint = "tccatalog.tencentcloudapi.com";
       private const string version = "2024-10-24";
       private const string sdkVersion = "SDK_NET_3.0.1170";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public TccatalogClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public TccatalogClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 接受终端节点连接
        /// </summary>
        /// <param name="req"><see cref="AcceptTccVpcEndPointConnectRequest"/></param>
        /// <returns><see cref="AcceptTccVpcEndPointConnectResponse"/></returns>
        public Task<AcceptTccVpcEndPointConnectResponse> AcceptTccVpcEndPointConnect(AcceptTccVpcEndPointConnectRequest req)
        {
            return InternalRequestAsync<AcceptTccVpcEndPointConnectResponse>(req, "AcceptTccVpcEndPointConnect");
        }

        /// <summary>
        /// 接受终端节点连接
        /// </summary>
        /// <param name="req"><see cref="AcceptTccVpcEndPointConnectRequest"/></param>
        /// <returns><see cref="AcceptTccVpcEndPointConnectResponse"/></returns>
        public AcceptTccVpcEndPointConnectResponse AcceptTccVpcEndPointConnectSync(AcceptTccVpcEndPointConnectRequest req)
        {
            return InternalRequestAsync<AcceptTccVpcEndPointConnectResponse>(req, "AcceptTccVpcEndPointConnect")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 绑定终端节点服务白名单用户
        /// </summary>
        /// <param name="req"><see cref="BindTccVpcEndPointServiceWhiteListRequest"/></param>
        /// <returns><see cref="BindTccVpcEndPointServiceWhiteListResponse"/></returns>
        public Task<BindTccVpcEndPointServiceWhiteListResponse> BindTccVpcEndPointServiceWhiteList(BindTccVpcEndPointServiceWhiteListRequest req)
        {
            return InternalRequestAsync<BindTccVpcEndPointServiceWhiteListResponse>(req, "BindTccVpcEndPointServiceWhiteList");
        }

        /// <summary>
        /// 绑定终端节点服务白名单用户
        /// </summary>
        /// <param name="req"><see cref="BindTccVpcEndPointServiceWhiteListRequest"/></param>
        /// <returns><see cref="BindTccVpcEndPointServiceWhiteListResponse"/></returns>
        public BindTccVpcEndPointServiceWhiteListResponse BindTccVpcEndPointServiceWhiteListSync(BindTccVpcEndPointServiceWhiteListRequest req)
        {
            return InternalRequestAsync<BindTccVpcEndPointServiceWhiteListResponse>(req, "BindTccVpcEndPointServiceWhiteList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取Tcc数据目录详情
        /// </summary>
        /// <param name="req"><see cref="DescribeTccCatalogRequest"/></param>
        /// <returns><see cref="DescribeTccCatalogResponse"/></returns>
        public Task<DescribeTccCatalogResponse> DescribeTccCatalog(DescribeTccCatalogRequest req)
        {
            return InternalRequestAsync<DescribeTccCatalogResponse>(req, "DescribeTccCatalog");
        }

        /// <summary>
        /// 获取Tcc数据目录详情
        /// </summary>
        /// <param name="req"><see cref="DescribeTccCatalogRequest"/></param>
        /// <returns><see cref="DescribeTccCatalogResponse"/></returns>
        public DescribeTccCatalogResponse DescribeTccCatalogSync(DescribeTccCatalogRequest req)
        {
            return InternalRequestAsync<DescribeTccCatalogResponse>(req, "DescribeTccCatalog")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取Tcc数据目录列表
        /// </summary>
        /// <param name="req"><see cref="DescribeTccCatalogsRequest"/></param>
        /// <returns><see cref="DescribeTccCatalogsResponse"/></returns>
        public Task<DescribeTccCatalogsResponse> DescribeTccCatalogs(DescribeTccCatalogsRequest req)
        {
            return InternalRequestAsync<DescribeTccCatalogsResponse>(req, "DescribeTccCatalogs");
        }

        /// <summary>
        /// 获取Tcc数据目录列表
        /// </summary>
        /// <param name="req"><see cref="DescribeTccCatalogsRequest"/></param>
        /// <returns><see cref="DescribeTccCatalogsResponse"/></returns>
        public DescribeTccCatalogsResponse DescribeTccCatalogsSync(DescribeTccCatalogsRequest req)
        {
            return InternalRequestAsync<DescribeTccCatalogsResponse>(req, "DescribeTccCatalogs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
