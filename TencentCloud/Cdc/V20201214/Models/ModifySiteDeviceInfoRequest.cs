/*
 * Copyright (c) 2018-2025 Tencent. All Rights Reserved.
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

namespace TencentCloud.Cdc.V20201214.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifySiteDeviceInfoRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>机房ID</p>
        /// </summary>
        [JsonProperty("SiteId")]
        public string SiteId{ get; set; }

        /// <summary>
        /// <p>您将使用光纤类型将CDC设备连接到网络。有单模和多模两种选项。</p>
        /// </summary>
        [JsonProperty("FiberType")]
        public string FiberType{ get; set; }

        /// <summary>
        /// <p>您将CDC连接到网络时采用的光学标准。此字段取决于上行链路速度、光纤类型和到上游设备的距离。</p>
        /// </summary>
        [JsonProperty("OpticalStandard")]
        public string OpticalStandard{ get; set; }

        /// <summary>
        /// <p>电源连接器类型</p>
        /// </summary>
        [JsonProperty("PowerConnectors")]
        public string PowerConnectors{ get; set; }

        /// <summary>
        /// <p>从机架上方还是下方供电。取值范围：["UP","DOWN"]</p>
        /// </summary>
        [JsonProperty("PowerFeedDrop")]
        public string PowerFeedDrop{ get; set; }

        /// <summary>
        /// <p>最大承重(KG)</p>
        /// </summary>
        [JsonProperty("MaxWeight")]
        public long? MaxWeight{ get; set; }

        /// <summary>
        /// <p>功耗(KW)</p>
        /// </summary>
        [JsonProperty("PowerDrawKva")]
        public long? PowerDrawKva{ get; set; }

        /// <summary>
        /// <p>网络到腾讯云Region区域的上行链路速度(Gbps)</p>
        /// </summary>
        [JsonProperty("UplinkSpeedGbps")]
        public long? UplinkSpeedGbps{ get; set; }

        /// <summary>
        /// <p>将CDC连接到网络时，每台CDC网络设备(每个机架 2 台设备)使用的上行链路数量。</p>
        /// </summary>
        [JsonProperty("UplinkCount")]
        public long? UplinkCount{ get; set; }

        /// <summary>
        /// <p>是否满足下面环境条件：1、场地没有材料要求或验收标准会影响 CDC 设备配送和安装。2、确定的机架位置包含:温度范围为 41 到 104°F (5 到 40°C)。湿度范围为 10°F (-12°C)和 8% RH (相对湿度)到 70°F(21°C)和 80% RH。机架位置的气流方向为从前向后，且应具有足够的 CFM (每分钟立方英尺)，散热功率须达到CDC运行功率值的 145.8 倍以上。</p>
        /// </summary>
        [JsonProperty("ConditionRequirement")]
        public bool? ConditionRequirement{ get; set; }

        /// <summary>
        /// <p>是否满足下面的尺寸条件：您的装货站台可以容纳一个机架箱(高 x 宽 x 深 = 94" x 54" x 48")。您可以提供从机架(高 x 宽 x 深 = 80" x 24" x 48")交货地点到机架最终安置位置的明确通道。测量深度时，应包括站台、走廊通道、门、转弯、坡道、货梯，并将其他通道限制考虑在内。在最终的 CDC安置位置，前部间隙可以为 48" 或更大，后部间隙可以为 24" 或更大。</p>
        /// </summary>
        [JsonProperty("DimensionRequirement")]
        public bool? DimensionRequirement{ get; set; }

        /// <summary>
        /// <p>是否提供冗余的上游设备(交换机或路由器)，以便实现网络出口的高可用。</p>
        /// </summary>
        [JsonProperty("RedundantNetworking")]
        public bool? RedundantNetworking{ get; set; }

        /// <summary>
        /// <p>是否需要腾讯云团队协助完成机架支撑工作</p>
        /// </summary>
        [JsonProperty("NeedHelp")]
        public bool? NeedHelp{ get; set; }

        /// <summary>
        /// <p>是否电源冗余</p>
        /// </summary>
        [JsonProperty("RedundantPower")]
        public bool? RedundantPower{ get; set; }

        /// <summary>
        /// <p>上游断路器是否具备</p>
        /// </summary>
        [JsonProperty("BreakerRequirement")]
        public bool? BreakerRequirement{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SiteId", this.SiteId);
            this.SetParamSimple(map, prefix + "FiberType", this.FiberType);
            this.SetParamSimple(map, prefix + "OpticalStandard", this.OpticalStandard);
            this.SetParamSimple(map, prefix + "PowerConnectors", this.PowerConnectors);
            this.SetParamSimple(map, prefix + "PowerFeedDrop", this.PowerFeedDrop);
            this.SetParamSimple(map, prefix + "MaxWeight", this.MaxWeight);
            this.SetParamSimple(map, prefix + "PowerDrawKva", this.PowerDrawKva);
            this.SetParamSimple(map, prefix + "UplinkSpeedGbps", this.UplinkSpeedGbps);
            this.SetParamSimple(map, prefix + "UplinkCount", this.UplinkCount);
            this.SetParamSimple(map, prefix + "ConditionRequirement", this.ConditionRequirement);
            this.SetParamSimple(map, prefix + "DimensionRequirement", this.DimensionRequirement);
            this.SetParamSimple(map, prefix + "RedundantNetworking", this.RedundantNetworking);
            this.SetParamSimple(map, prefix + "NeedHelp", this.NeedHelp);
            this.SetParamSimple(map, prefix + "RedundantPower", this.RedundantPower);
            this.SetParamSimple(map, prefix + "BreakerRequirement", this.BreakerRequirement);
        }
    }
}

