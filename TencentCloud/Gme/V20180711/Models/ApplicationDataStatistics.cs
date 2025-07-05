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

namespace TencentCloud.Gme.V20180711.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ApplicationDataStatistics : AbstractModel
    {
        
        /// <summary>
        /// 应用ID
        /// </summary>
        [JsonProperty("BizId")]
        public ulong? BizId{ get; set; }

        /// <summary>
        /// Dau统计项数目
        /// </summary>
        [JsonProperty("DauDataNum")]
        public ulong? DauDataNum{ get; set; }

        /// <summary>
        /// 大陆地区Dau统计数据，单位人
        /// </summary>
        [JsonProperty("DauDataMainland")]
        public StatisticsItem[] DauDataMainland{ get; set; }

        /// <summary>
        /// 海外地区Dau统计数据，单位人
        /// </summary>
        [JsonProperty("DauDataOversea")]
        public StatisticsItem[] DauDataOversea{ get; set; }

        /// <summary>
        /// 大陆和海外地区Dau统计数据汇总，单位人
        /// </summary>
        [JsonProperty("DauDataSum")]
        public StatisticsItem[] DauDataSum{ get; set; }

        /// <summary>
        /// 实时语音时长统计项数目
        /// </summary>
        [JsonProperty("DurationDataNum")]
        public ulong? DurationDataNum{ get; set; }

        /// <summary>
        /// 大陆地区实时语音时长统计数据，单位分钟
        /// </summary>
        [JsonProperty("DurationDataMainland")]
        public StatisticsItem[] DurationDataMainland{ get; set; }

        /// <summary>
        /// 海外地区实时语音时长统计数据，单位分钟
        /// </summary>
        [JsonProperty("DurationDataOversea")]
        public StatisticsItem[] DurationDataOversea{ get; set; }

        /// <summary>
        /// 大陆和海外地区实时语音时长统计数据汇总，单位分钟
        /// </summary>
        [JsonProperty("DurationDataSum")]
        public StatisticsItem[] DurationDataSum{ get; set; }

        /// <summary>
        /// Pcu统计项数目
        /// </summary>
        [JsonProperty("PcuDataNum")]
        public ulong? PcuDataNum{ get; set; }

        /// <summary>
        /// 大陆地区Pcu统计数据，单位人
        /// </summary>
        [JsonProperty("PcuDataMainland")]
        public StatisticsItem[] PcuDataMainland{ get; set; }

        /// <summary>
        /// 海外地区Pcu统计数据，单位人
        /// </summary>
        [JsonProperty("PcuDataOversea")]
        public StatisticsItem[] PcuDataOversea{ get; set; }

        /// <summary>
        /// 大陆和海外地区Pcu统计数据汇总，单位人
        /// </summary>
        [JsonProperty("PcuDataSum")]
        public StatisticsItem[] PcuDataSum{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BizId", this.BizId);
            this.SetParamSimple(map, prefix + "DauDataNum", this.DauDataNum);
            this.SetParamArrayObj(map, prefix + "DauDataMainland.", this.DauDataMainland);
            this.SetParamArrayObj(map, prefix + "DauDataOversea.", this.DauDataOversea);
            this.SetParamArrayObj(map, prefix + "DauDataSum.", this.DauDataSum);
            this.SetParamSimple(map, prefix + "DurationDataNum", this.DurationDataNum);
            this.SetParamArrayObj(map, prefix + "DurationDataMainland.", this.DurationDataMainland);
            this.SetParamArrayObj(map, prefix + "DurationDataOversea.", this.DurationDataOversea);
            this.SetParamArrayObj(map, prefix + "DurationDataSum.", this.DurationDataSum);
            this.SetParamSimple(map, prefix + "PcuDataNum", this.PcuDataNum);
            this.SetParamArrayObj(map, prefix + "PcuDataMainland.", this.PcuDataMainland);
            this.SetParamArrayObj(map, prefix + "PcuDataOversea.", this.PcuDataOversea);
            this.SetParamArrayObj(map, prefix + "PcuDataSum.", this.PcuDataSum);
        }
    }
}

