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

    public class PlanInfo : AbstractModel
    {
        
        /// <summary>
        /// 结算货币类型，取值有：
        /// <li> CNY ：人民币结算； </li>
        /// <li> USD ：美元结算。</li>
        /// </summary>
        [JsonProperty("Currency")]
        public string Currency{ get; set; }

        /// <summary>
        /// 套餐所含流量，该流量数值为安全加速流量，内容加速流量和智能加速流量的总和（单位：字节）。
        /// </summary>
        [JsonProperty("Flux")]
        public ulong? Flux{ get; set; }

        /// <summary>
        /// 结算周期，取值有：
        /// <li> y ：按年结算； </li>
        /// <li> m ：按月结算；</li>
        /// <li> h ：按小时结算； </li>
        /// <li> M ：按分钟结算；</li>
        /// <li> s ：按秒结算。 </li>
        /// </summary>
        [JsonProperty("Frequency")]
        public string Frequency{ get; set; }

        /// <summary>
        /// 套餐类型，取值有：
        /// <li> sta ：全球内容分发网络（不包括中国大陆）标准版套餐； </li>
        /// <li> sta_with_bot ：全球内容分发网络（不包括中国大陆）标准版套餐附带bot管理；</li>
        /// <li> sta_cm ：中国大陆内容分发网络标准版套餐； </li>
        /// <li> sta_cm_with_bot ：中国大陆内容分发网络标准版套餐附带bot管理；</li>
        /// <li> sta_global ：全球内容分发网络（包括中国大陆）标准版套餐； </li>
        /// <li> sta_global_with_bot ：全球内容分发网络（包括中国大陆）标准版套餐附带bot管理；</li>
        /// <li> ent ：全球内容分发网络（不包括中国大陆）企业版套餐； </li>
        /// <li> ent_with_bot ： 全球内容分发网络（不包括中国大陆）企业版套餐附带bot管理；</li>
        /// <li> ent_cm ：中国大陆内容分发网络企业版套餐； </li>
        /// <li> ent_cm_with_bot ：中国大陆内容分发网络企业版套餐附带bot管理；</li>
        /// <li> ent_global ：全球内容分发网络（包括中国大陆）企业版套餐； </li>
        /// <li> ent_global_with_bot ：全球内容分发网络（包括中国大陆）企业版套餐附带bot管理。</li>
        /// </summary>
        [JsonProperty("PlanType")]
        public string PlanType{ get; set; }

        /// <summary>
        /// 套餐价格（单位：分）。
        /// </summary>
        [JsonProperty("Price")]
        public float? Price{ get; set; }

        /// <summary>
        /// 套餐所含请求次数，该请求次数为安全加速请求次数。（单位：次）。
        /// </summary>
        [JsonProperty("Request")]
        public ulong? Request{ get; set; }

        /// <summary>
        /// 套餐所能绑定的站点个数。
        /// </summary>
        [JsonProperty("SiteNumber")]
        public ulong? SiteNumber{ get; set; }

        /// <summary>
        /// 套餐加速区域类型，取值有：
        /// <li> mainland ：中国大陆； </li>
        /// <li> overseas ：全球（不包括中国大陆）；</li>
        /// <li> global ：全球（包括中国大陆）。 </li>
        /// </summary>
        [JsonProperty("Area")]
        public string Area{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Currency", this.Currency);
            this.SetParamSimple(map, prefix + "Flux", this.Flux);
            this.SetParamSimple(map, prefix + "Frequency", this.Frequency);
            this.SetParamSimple(map, prefix + "PlanType", this.PlanType);
            this.SetParamSimple(map, prefix + "Price", this.Price);
            this.SetParamSimple(map, prefix + "Request", this.Request);
            this.SetParamSimple(map, prefix + "SiteNumber", this.SiteNumber);
            this.SetParamSimple(map, prefix + "Area", this.Area);
        }
    }
}

