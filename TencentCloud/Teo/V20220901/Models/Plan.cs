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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Plan : AbstractModel
    {
        
        /// <summary>
        /// 套餐类型。取值有：
        /// <li>plan-trial: 试用版套餐；</li>
        /// <li>plan-personal: 个人版套餐；</li>
        /// <li>plan-basic: 基础版套餐；</li>
        /// <li>plan-standard: 标准版套餐；</li>
        /// <li>plan-enterprise-v2: 企业版套餐；</li>
        /// <li>plan-enterprise-model-a: 企业版 Model A 套餐。</li>
        /// <li>plan-enterprise: 旧企业版套餐。</li>
        /// </summary>
        [JsonProperty("PlanType")]
        public string PlanType{ get; set; }

        /// <summary>
        /// 套餐 ID。形如 edgeone-2y041pblwaxe。
        /// </summary>
        [JsonProperty("PlanId")]
        public string PlanId{ get; set; }

        /// <summary>
        /// 服务区域，取值有：
        /// <li>mainland: 中国大陆；</li>
        /// <li>overseas: 全球（不包括中国大陆)；</li>
        /// <li>global: 全球（包括中国大陆)。</li>
        /// </summary>
        [JsonProperty("Area")]
        public string Area{ get; set; }

        /// <summary>
        /// 套餐状态，取值有：
        /// <li>normal：正常状态；</li>
        /// <li>expiring-soon：即将到期状态；</li>
        /// <li>expired：到期状态；</li>
        /// <li>isolated：隔离状态；</li>
        /// <li>overdue-isolated：欠费隔离状态。</li>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 付费类型，取值有：
        /// <li>0: 后付费；</li>
        /// <li>1: 预付费。</li>
        /// </summary>
        [JsonProperty("PayMode")]
        public long? PayMode{ get; set; }

        /// <summary>
        /// 套餐绑定的站点信息，包括站点id和站点名称，站点状态。
        /// </summary>
        [JsonProperty("ZonesInfo")]
        public ZoneInfo[] ZonesInfo{ get; set; }

        /// <summary>
        /// 套餐内智能加速请求数规格，单位：次。
        /// </summary>
        [JsonProperty("SmartRequestCapacity")]
        public long? SmartRequestCapacity{ get; set; }

        /// <summary>
        /// 套餐内VAU规格，单位：个。
        /// </summary>
        [JsonProperty("VAUCapacity")]
        public long? VAUCapacity{ get; set; }

        /// <summary>
        /// 套餐内内容加速流量规格，单位：字节。
        /// </summary>
        [JsonProperty("AccTrafficCapacity")]
        public long? AccTrafficCapacity{ get; set; }

        /// <summary>
        /// 套餐内智能加速流量规格，单位：字节。
        /// </summary>
        [JsonProperty("SmartTrafficCapacity")]
        public long? SmartTrafficCapacity{ get; set; }

        /// <summary>
        /// 套餐内DDoS防护流量规格，单位：字节。
        /// </summary>
        [JsonProperty("DDoSTrafficCapacity")]
        public long? DDoSTrafficCapacity{ get; set; }

        /// <summary>
        /// 套餐内安全流量规格，单位：字节。
        /// </summary>
        [JsonProperty("SecTrafficCapacity")]
        public long? SecTrafficCapacity{ get; set; }

        /// <summary>
        /// 套餐内安全请求数规格，单位：次。
        /// </summary>
        [JsonProperty("SecRequestCapacity")]
        public long? SecRequestCapacity{ get; set; }

        /// <summary>
        /// 套餐内四层加速流量规格，单位：字节。
        /// </summary>
        [JsonProperty("L4TrafficCapacity")]
        public long? L4TrafficCapacity{ get; set; }

        /// <summary>
        /// 套餐内中国大陆网络优化流量规格，单位：字节。
        /// </summary>
        [JsonProperty("CrossMLCTrafficCapacity")]
        public long? CrossMLCTrafficCapacity{ get; set; }

        /// <summary>
        /// 套餐是否允许绑定新站点，取值有：
        /// <li>true: 允许绑定新站点；</li>
        /// <li>false: 不允许绑定新站点。</li>
        /// </summary>
        [JsonProperty("Bindable")]
        public string Bindable{ get; set; }

        /// <summary>
        /// 套餐生效时间。
        /// </summary>
        [JsonProperty("EnabledTime")]
        public string EnabledTime{ get; set; }

        /// <summary>
        /// 套餐过期时间。
        /// </summary>
        [JsonProperty("ExpiredTime")]
        public string ExpiredTime{ get; set; }

        /// <summary>
        /// 套餐所支持的功能，取值有：<li>ContentAcceleration：内容加速功能；</li><li>SmartAcceleration：智能加速功能；</li><li>L4：四层加速功能；</li><li>Waf：高级 Web 防护；</li><li>QUIC：QUIC功能；</li><li>CrossMLC：中国大陆网络优化功能；</li><li>ProcessMedia：媒体处理功能；</li><li>L4DDoS：四层DDoS防护功能；</li>L7DDoS功能只会出现以下所有规格中的一项<li>L7DDoS.CM30G；七层DDoS防护功能-中国大陆30G保底带宽规格；</li><li>L7DDoS.CM60G；七层DDoS防护功能-中国大陆60G保底带宽规格；</li><li>L7DDoS.CM100G；七层DDoS防护功能-中国大陆100G保底带宽规格；</li><li>L7DDoS.Anycast300G；七层DDoS防护功能-中国大陆以外Anycast300G保底带宽规格；</li><li>L7DDoS.AnycastUnlimited；七层DDoS防护功能-中国大陆以外Anycast无上限全力防护规格；</li><li>L7DDoS.CM30G_Anycast300G；七层DDoS防护功能-中国大陆30G保底带宽规格，中国大陆以外Anycast300G保底带宽规格；</li><li>L7DDoS.CM60G_Anycast300G；七层DDoS防护功能-中国大陆60G保底带宽规格，中国大陆以外Anycast300G保底带宽规格；</li><li>L7DDoS.CM100G_Anycast300G；七层DDoS防护功能-中国大陆100G保底带宽规格，中国大陆以外Anycast300G保底带宽规格；</li><li>L7DDoS.CM30G_AnycastUnlimited；七层DDoS防护功能-中国大陆30G保底带宽规格，中国大陆以外Anycast无上限全力防护规格；</li><li>L7DDoS.CM60G_AnycastUnlimited；七层DDoS防护功能-中国大陆60G保底带宽规格，中国大陆以外Anycast无上限全力防护规格；</li><li>L7DDoS.CM100G_AnycastUnlimited；七层DDoS防护功能-中国大陆100G保底带宽规格，中国大陆以外Anycast无上限全力防护规格；</li>
        /// </summary>
        [JsonProperty("Features")]
        public string[] Features{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PlanType", this.PlanType);
            this.SetParamSimple(map, prefix + "PlanId", this.PlanId);
            this.SetParamSimple(map, prefix + "Area", this.Area);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "PayMode", this.PayMode);
            this.SetParamArrayObj(map, prefix + "ZonesInfo.", this.ZonesInfo);
            this.SetParamSimple(map, prefix + "SmartRequestCapacity", this.SmartRequestCapacity);
            this.SetParamSimple(map, prefix + "VAUCapacity", this.VAUCapacity);
            this.SetParamSimple(map, prefix + "AccTrafficCapacity", this.AccTrafficCapacity);
            this.SetParamSimple(map, prefix + "SmartTrafficCapacity", this.SmartTrafficCapacity);
            this.SetParamSimple(map, prefix + "DDoSTrafficCapacity", this.DDoSTrafficCapacity);
            this.SetParamSimple(map, prefix + "SecTrafficCapacity", this.SecTrafficCapacity);
            this.SetParamSimple(map, prefix + "SecRequestCapacity", this.SecRequestCapacity);
            this.SetParamSimple(map, prefix + "L4TrafficCapacity", this.L4TrafficCapacity);
            this.SetParamSimple(map, prefix + "CrossMLCTrafficCapacity", this.CrossMLCTrafficCapacity);
            this.SetParamSimple(map, prefix + "Bindable", this.Bindable);
            this.SetParamSimple(map, prefix + "EnabledTime", this.EnabledTime);
            this.SetParamSimple(map, prefix + "ExpiredTime", this.ExpiredTime);
            this.SetParamArraySimple(map, prefix + "Features.", this.Features);
        }
    }
}

