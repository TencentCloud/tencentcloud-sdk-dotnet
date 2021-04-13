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

namespace TencentCloud.Ecm.V20190719.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MonthNetwork : AbstractModel
    {
        
        /// <summary>
        /// 节点zone信息
        /// </summary>
        [JsonProperty("ZoneInfo")]
        public ZoneInfo ZoneInfo{ get; set; }

        /// <summary>
        /// 带宽月份 示例"202103"
        /// </summary>
        [JsonProperty("Month")]
        public string Month{ get; set; }

        /// <summary>
        /// 带宽包id 格式如"bwp-xxxxxxxx"
        /// </summary>
        [JsonProperty("BandwidthPkgId")]
        public string BandwidthPkgId{ get; set; }

        /// <summary>
        /// 运营商简称 取值范围"CUCC;CTCC;CMCC"
        /// </summary>
        [JsonProperty("Isp")]
        public string Isp{ get; set; }

        /// <summary>
        /// 入网带宽包峰值,取值范围0.0-xxx.xxx
        /// </summary>
        [JsonProperty("TrafficMaxIn")]
        public float? TrafficMaxIn{ get; set; }

        /// <summary>
        /// 出网带宽包峰值,取值范围0.0-xxx.xxx
        /// </summary>
        [JsonProperty("TrafficMaxOut")]
        public float? TrafficMaxOut{ get; set; }

        /// <summary>
        /// 计费带宽,取值范围0.0-xxx.xxx
        /// </summary>
        [JsonProperty("FeeTraffic")]
        public float? FeeTraffic{ get; set; }

        /// <summary>
        /// 月计费带宽起始时间 格式"yyyy-mm-dd HH:mm:ss"
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 月计费带宽结束时间 格式"yyyy-mm-dd HH:mm:ss"
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 月计费带宽实际有效天数 整形必须大于等于0
        /// </summary>
        [JsonProperty("EffectiveDays")]
        public long? EffectiveDays{ get; set; }

        /// <summary>
        /// 指定月份的实际天数 实例 30
        /// </summary>
        [JsonProperty("MonthDays")]
        public long? MonthDays{ get; set; }

        /// <summary>
        /// 有效天占比 保留小数点后四位0.2134
        /// </summary>
        [JsonProperty("EffectiveDaysRate")]
        public float? EffectiveDaysRate{ get; set; }

        /// <summary>
        /// 计费带宽包类型 实例"Address","LoadBalance","AddressIpv6"
        /// </summary>
        [JsonProperty("BandwidthPkgType")]
        public string BandwidthPkgType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "ZoneInfo.", this.ZoneInfo);
            this.SetParamSimple(map, prefix + "Month", this.Month);
            this.SetParamSimple(map, prefix + "BandwidthPkgId", this.BandwidthPkgId);
            this.SetParamSimple(map, prefix + "Isp", this.Isp);
            this.SetParamSimple(map, prefix + "TrafficMaxIn", this.TrafficMaxIn);
            this.SetParamSimple(map, prefix + "TrafficMaxOut", this.TrafficMaxOut);
            this.SetParamSimple(map, prefix + "FeeTraffic", this.FeeTraffic);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "EffectiveDays", this.EffectiveDays);
            this.SetParamSimple(map, prefix + "MonthDays", this.MonthDays);
            this.SetParamSimple(map, prefix + "EffectiveDaysRate", this.EffectiveDaysRate);
            this.SetParamSimple(map, prefix + "BandwidthPkgType", this.BandwidthPkgType);
        }
    }
}

