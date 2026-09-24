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

namespace TencentCloud.Rce.V20260130
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Rce.V20260130.Models;

   public class RceClient : AbstractClient{

       private const string endpoint = "rce.tencentcloudapi.com";
       private const string version = "2026-01-30";
       private const string sdkVersion = "SDK_NET_3.0.1512";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public RceClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public RceClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 基于设备端SDK 采集设备指纹 token和IP进行风险识别，提供设备、环境、行为等维度给出的综合风险评估（包含决策结果、风险评分、风险标签）和设备以及 IP 的基础信息。
        /// </summary>
        /// <param name="req"><see cref="AssessDeviceRiskPremiumProRequest"/></param>
        /// <returns><see cref="AssessDeviceRiskPremiumProResponse"/></returns>
        public Task<AssessDeviceRiskPremiumProResponse> AssessDeviceRiskPremiumPro(AssessDeviceRiskPremiumProRequest req)
        {
            return InternalRequestAsync<AssessDeviceRiskPremiumProResponse>(req, "AssessDeviceRiskPremiumPro");
        }

        /// <summary>
        /// 基于设备端SDK 采集设备指纹 token和IP进行风险识别，提供设备、环境、行为等维度给出的综合风险评估（包含决策结果、风险评分、风险标签）和设备以及 IP 的基础信息。
        /// </summary>
        /// <param name="req"><see cref="AssessDeviceRiskPremiumProRequest"/></param>
        /// <returns><see cref="AssessDeviceRiskPremiumProResponse"/></returns>
        public AssessDeviceRiskPremiumProResponse AssessDeviceRiskPremiumProSync(AssessDeviceRiskPremiumProRequest req)
        {
            return InternalRequestAsync<AssessDeviceRiskPremiumProResponse>(req, "AssessDeviceRiskPremiumPro")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 基于设备端SDK 采集设备指纹 token和IP进行风险识别，提供设备维度的风险标签和设备基础信息，以及 IP 的地理位置和网络信息。
        /// </summary>
        /// <param name="req"><see cref="AssessDeviceRiskProRequest"/></param>
        /// <returns><see cref="AssessDeviceRiskProResponse"/></returns>
        public Task<AssessDeviceRiskProResponse> AssessDeviceRiskPro(AssessDeviceRiskProRequest req)
        {
            return InternalRequestAsync<AssessDeviceRiskProResponse>(req, "AssessDeviceRiskPro");
        }

        /// <summary>
        /// 基于设备端SDK 采集设备指纹 token和IP进行风险识别，提供设备维度的风险标签和设备基础信息，以及 IP 的地理位置和网络信息。
        /// </summary>
        /// <param name="req"><see cref="AssessDeviceRiskProRequest"/></param>
        /// <returns><see cref="AssessDeviceRiskProResponse"/></returns>
        public AssessDeviceRiskProResponse AssessDeviceRiskProSync(AssessDeviceRiskProRequest req)
        {
            return InternalRequestAsync<AssessDeviceRiskProResponse>(req, "AssessDeviceRiskPro")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 基于传入的客户端IP进行风险识别，提供环境的风险评估（包含风险等级、风险标签）以及IP的地理位置和网络信息。
        /// </summary>
        /// <param name="req"><see cref="AssessEnvironmentRiskRequest"/></param>
        /// <returns><see cref="AssessEnvironmentRiskResponse"/></returns>
        public Task<AssessEnvironmentRiskResponse> AssessEnvironmentRisk(AssessEnvironmentRiskRequest req)
        {
            return InternalRequestAsync<AssessEnvironmentRiskResponse>(req, "AssessEnvironmentRisk");
        }

        /// <summary>
        /// 基于传入的客户端IP进行风险识别，提供环境的风险评估（包含风险等级、风险标签）以及IP的地理位置和网络信息。
        /// </summary>
        /// <param name="req"><see cref="AssessEnvironmentRiskRequest"/></param>
        /// <returns><see cref="AssessEnvironmentRiskResponse"/></returns>
        public AssessEnvironmentRiskResponse AssessEnvironmentRiskSync(AssessEnvironmentRiskRequest req)
        {
            return InternalRequestAsync<AssessEnvironmentRiskResponse>(req, "AssessEnvironmentRisk")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 事件风险评估。用于实时获取事件的风险信息，您可以在业务的关键事件中获取到我们根据设备风险、环境风险、账号风险、行为风险以及历史上报的事件信息评估出来的风险决策结果、风险评分和风险标签等。
        /// </summary>
        /// <param name="req"><see cref="AssessRiskRequest"/></param>
        /// <returns><see cref="AssessRiskResponse"/></returns>
        public Task<AssessRiskResponse> AssessRisk(AssessRiskRequest req)
        {
            return InternalRequestAsync<AssessRiskResponse>(req, "AssessRisk");
        }

        /// <summary>
        /// 事件风险评估。用于实时获取事件的风险信息，您可以在业务的关键事件中获取到我们根据设备风险、环境风险、账号风险、行为风险以及历史上报的事件信息评估出来的风险决策结果、风险评分和风险标签等。
        /// </summary>
        /// <param name="req"><see cref="AssessRiskRequest"/></param>
        /// <returns><see cref="AssessRiskResponse"/></returns>
        public AssessRiskResponse AssessRiskSync(AssessRiskRequest req)
        {
            return InternalRequestAsync<AssessRiskResponse>(req, "AssessRisk")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 事件信息上报。用于上报您业务中无需实时决策的事件，我们会通过引擎计算、机器学习挖掘风险特征用于实时事件风险评估。
        /// </summary>
        /// <param name="req"><see cref="ReportEventRequest"/></param>
        /// <returns><see cref="ReportEventResponse"/></returns>
        public Task<ReportEventResponse> ReportEvent(ReportEventRequest req)
        {
            return InternalRequestAsync<ReportEventResponse>(req, "ReportEvent");
        }

        /// <summary>
        /// 事件信息上报。用于上报您业务中无需实时决策的事件，我们会通过引擎计算、机器学习挖掘风险特征用于实时事件风险评估。
        /// </summary>
        /// <param name="req"><see cref="ReportEventRequest"/></param>
        /// <returns><see cref="ReportEventResponse"/></returns>
        public ReportEventResponse ReportEventSync(ReportEventRequest req)
        {
            return InternalRequestAsync<ReportEventResponse>(req, "ReportEvent")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
