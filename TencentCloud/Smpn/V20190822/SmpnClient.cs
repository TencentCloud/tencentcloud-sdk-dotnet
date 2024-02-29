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

namespace TencentCloud.Smpn.V20190822
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Smpn.V20190822.Models;

   public class SmpnClient : AbstractClient{

       private const string endpoint = "smpn.tencentcloudapi.com";
       private const string version = "2019-08-22";
       private const string sdkVersion = "SDK_NET_3.0.954";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public SmpnClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public SmpnClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 企业号码认证
        /// </summary>
        /// <param name="req"><see cref="CreateSmpnEpaRequest"/></param>
        /// <returns><see cref="CreateSmpnEpaResponse"/></returns>
        public Task<CreateSmpnEpaResponse> CreateSmpnEpa(CreateSmpnEpaRequest req)
        {
            return InternalRequestAsync<CreateSmpnEpaResponse>(req, "CreateSmpnEpa");
        }

        /// <summary>
        /// 企业号码认证
        /// </summary>
        /// <param name="req"><see cref="CreateSmpnEpaRequest"/></param>
        /// <returns><see cref="CreateSmpnEpaResponse"/></returns>
        public CreateSmpnEpaResponse CreateSmpnEpaSync(CreateSmpnEpaRequest req)
        {
            return InternalRequestAsync<CreateSmpnEpaResponse>(req, "CreateSmpnEpa")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询号码的标记和标记次数
        /// </summary>
        /// <param name="req"><see cref="DescribeSmpnChpRequest"/></param>
        /// <returns><see cref="DescribeSmpnChpResponse"/></returns>
        public Task<DescribeSmpnChpResponse> DescribeSmpnChp(DescribeSmpnChpRequest req)
        {
            return InternalRequestAsync<DescribeSmpnChpResponse>(req, "DescribeSmpnChp");
        }

        /// <summary>
        /// 查询号码的标记和标记次数
        /// </summary>
        /// <param name="req"><see cref="DescribeSmpnChpRequest"/></param>
        /// <returns><see cref="DescribeSmpnChpResponse"/></returns>
        public DescribeSmpnChpResponse DescribeSmpnChpSync(DescribeSmpnChpRequest req)
        {
            return InternalRequestAsync<DescribeSmpnChpResponse>(req, "DescribeSmpnChp")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 虚假号码识别
        /// </summary>
        /// <param name="req"><see cref="DescribeSmpnFnrRequest"/></param>
        /// <returns><see cref="DescribeSmpnFnrResponse"/></returns>
        public Task<DescribeSmpnFnrResponse> DescribeSmpnFnr(DescribeSmpnFnrRequest req)
        {
            return InternalRequestAsync<DescribeSmpnFnrResponse>(req, "DescribeSmpnFnr");
        }

        /// <summary>
        /// 虚假号码识别
        /// </summary>
        /// <param name="req"><see cref="DescribeSmpnFnrRequest"/></param>
        /// <returns><see cref="DescribeSmpnFnrResponse"/></returns>
        public DescribeSmpnFnrResponse DescribeSmpnFnrSync(DescribeSmpnFnrRequest req)
        {
            return InternalRequestAsync<DescribeSmpnFnrResponse>(req, "DescribeSmpnFnr")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 号码营销监控
        /// </summary>
        /// <param name="req"><see cref="DescribeSmpnMhmRequest"/></param>
        /// <returns><see cref="DescribeSmpnMhmResponse"/></returns>
        public Task<DescribeSmpnMhmResponse> DescribeSmpnMhm(DescribeSmpnMhmRequest req)
        {
            return InternalRequestAsync<DescribeSmpnMhmResponse>(req, "DescribeSmpnMhm");
        }

        /// <summary>
        /// 号码营销监控
        /// </summary>
        /// <param name="req"><see cref="DescribeSmpnMhmRequest"/></param>
        /// <returns><see cref="DescribeSmpnMhmResponse"/></returns>
        public DescribeSmpnMhmResponse DescribeSmpnMhmSync(DescribeSmpnMhmRequest req)
        {
            return InternalRequestAsync<DescribeSmpnMhmResponse>(req, "DescribeSmpnMhm")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询号码恶意标记等级
        /// </summary>
        /// <param name="req"><see cref="DescribeSmpnMrlRequest"/></param>
        /// <returns><see cref="DescribeSmpnMrlResponse"/></returns>
        public Task<DescribeSmpnMrlResponse> DescribeSmpnMrl(DescribeSmpnMrlRequest req)
        {
            return InternalRequestAsync<DescribeSmpnMrlResponse>(req, "DescribeSmpnMrl");
        }

        /// <summary>
        /// 查询号码恶意标记等级
        /// </summary>
        /// <param name="req"><see cref="DescribeSmpnMrlRequest"/></param>
        /// <returns><see cref="DescribeSmpnMrlResponse"/></returns>
        public DescribeSmpnMrlResponse DescribeSmpnMrlSync(DescribeSmpnMrlRequest req)
        {
            return InternalRequestAsync<DescribeSmpnMrlResponse>(req, "DescribeSmpnMrl")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
