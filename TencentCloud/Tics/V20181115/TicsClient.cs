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

namespace TencentCloud.Tics.V20181115
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Tics.V20181115.Models;

   public class TicsClient : AbstractClient{

       private const string endpoint = "tics.tencentcloudapi.com";
       private const string version = "2018-11-15";
       private const string sdkVersion = "SDK_NET_3.0.1113";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public TicsClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public TicsClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 提供域名相关的基础信息以及与攻击事件（团伙、家族）、恶意文件等相关联信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeDomainInfoRequest"/></param>
        /// <returns><see cref="DescribeDomainInfoResponse"/></returns>
        public Task<DescribeDomainInfoResponse> DescribeDomainInfo(DescribeDomainInfoRequest req)
        {
            return InternalRequestAsync<DescribeDomainInfoResponse>(req, "DescribeDomainInfo");
        }

        /// <summary>
        /// 提供域名相关的基础信息以及与攻击事件（团伙、家族）、恶意文件等相关联信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeDomainInfoRequest"/></param>
        /// <returns><see cref="DescribeDomainInfoResponse"/></returns>
        public DescribeDomainInfoResponse DescribeDomainInfoSync(DescribeDomainInfoRequest req)
        {
            return InternalRequestAsync<DescribeDomainInfoResponse>(req, "DescribeDomainInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 提供文件相关的基础信息以及与攻击事件（团伙、家族）、恶意文件等相关联信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeFileInfoRequest"/></param>
        /// <returns><see cref="DescribeFileInfoResponse"/></returns>
        public Task<DescribeFileInfoResponse> DescribeFileInfo(DescribeFileInfoRequest req)
        {
            return InternalRequestAsync<DescribeFileInfoResponse>(req, "DescribeFileInfo");
        }

        /// <summary>
        /// 提供文件相关的基础信息以及与攻击事件（团伙、家族）、恶意文件等相关联信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeFileInfoRequest"/></param>
        /// <returns><see cref="DescribeFileInfoResponse"/></returns>
        public DescribeFileInfoResponse DescribeFileInfoSync(DescribeFileInfoRequest req)
        {
            return InternalRequestAsync<DescribeFileInfoResponse>(req, "DescribeFileInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 提供IP相关的基础信息以及与攻击事件（团伙、家族）、恶意文件等相关联信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeIpInfoRequest"/></param>
        /// <returns><see cref="DescribeIpInfoResponse"/></returns>
        public Task<DescribeIpInfoResponse> DescribeIpInfo(DescribeIpInfoRequest req)
        {
            return InternalRequestAsync<DescribeIpInfoResponse>(req, "DescribeIpInfo");
        }

        /// <summary>
        /// 提供IP相关的基础信息以及与攻击事件（团伙、家族）、恶意文件等相关联信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeIpInfoRequest"/></param>
        /// <returns><see cref="DescribeIpInfoResponse"/></returns>
        public DescribeIpInfoResponse DescribeIpInfoSync(DescribeIpInfoRequest req)
        {
            return InternalRequestAsync<DescribeIpInfoResponse>(req, "DescribeIpInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 提供IP和域名相关威胁情报信息查询，这些信息可以辅助检测失陷主机、帮助SIEM/SOC等系统做研判决策、帮助运营团队对设备报警的编排处理。
        /// </summary>
        /// <param name="req"><see cref="DescribeThreatInfoRequest"/></param>
        /// <returns><see cref="DescribeThreatInfoResponse"/></returns>
        public Task<DescribeThreatInfoResponse> DescribeThreatInfo(DescribeThreatInfoRequest req)
        {
            return InternalRequestAsync<DescribeThreatInfoResponse>(req, "DescribeThreatInfo");
        }

        /// <summary>
        /// 提供IP和域名相关威胁情报信息查询，这些信息可以辅助检测失陷主机、帮助SIEM/SOC等系统做研判决策、帮助运营团队对设备报警的编排处理。
        /// </summary>
        /// <param name="req"><see cref="DescribeThreatInfoRequest"/></param>
        /// <returns><see cref="DescribeThreatInfoResponse"/></returns>
        public DescribeThreatInfoResponse DescribeThreatInfoSync(DescribeThreatInfoRequest req)
        {
            return InternalRequestAsync<DescribeThreatInfoResponse>(req, "DescribeThreatInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
