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

namespace TencentCloud.Habo.V20181203
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Habo.V20181203.Models;

   public class HaboClient : AbstractClient{

       private const string endpoint = "habo.tencentcloudapi.com";
       private const string version = "2018-12-03";
       private const string sdkVersion = "SDK_NET_3.0.1133";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public HaboClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public HaboClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 查询指定md5样本是否分析完成，并获取分析日志下载地址。
        /// </summary>
        /// <param name="req"><see cref="DescribeStatusRequest"/></param>
        /// <returns><see cref="DescribeStatusResponse"/></returns>
        public Task<DescribeStatusResponse> DescribeStatus(DescribeStatusRequest req)
        {
            return InternalRequestAsync<DescribeStatusResponse>(req, "DescribeStatus");
        }

        /// <summary>
        /// 查询指定md5样本是否分析完成，并获取分析日志下载地址。
        /// </summary>
        /// <param name="req"><see cref="DescribeStatusRequest"/></param>
        /// <returns><see cref="DescribeStatusResponse"/></returns>
        public DescribeStatusResponse DescribeStatusSync(DescribeStatusRequest req)
        {
            return InternalRequestAsync<DescribeStatusResponse>(req, "DescribeStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 上传样本到哈勃进行分析，异步生成分析日志。
        /// </summary>
        /// <param name="req"><see cref="StartAnalyseRequest"/></param>
        /// <returns><see cref="StartAnalyseResponse"/></returns>
        public Task<StartAnalyseResponse> StartAnalyse(StartAnalyseRequest req)
        {
            return InternalRequestAsync<StartAnalyseResponse>(req, "StartAnalyse");
        }

        /// <summary>
        /// 上传样本到哈勃进行分析，异步生成分析日志。
        /// </summary>
        /// <param name="req"><see cref="StartAnalyseRequest"/></param>
        /// <returns><see cref="StartAnalyseResponse"/></returns>
        public StartAnalyseResponse StartAnalyseSync(StartAnalyseRequest req)
        {
            return InternalRequestAsync<StartAnalyseResponse>(req, "StartAnalyse")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
