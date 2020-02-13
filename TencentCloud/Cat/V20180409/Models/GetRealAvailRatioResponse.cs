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

namespace TencentCloud.Cat.V20180409.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class GetRealAvailRatioResponse : AbstractModel
    {
        
        /// <summary>
        /// 国内平均可用率
        /// </summary>
        [JsonProperty("AvgAvailRatio")]
        public float? AvgAvailRatio{ get; set; }

        /// <summary>
        /// 各省份最低可用率
        /// </summary>
        [JsonProperty("LowestAvailRatio")]
        public float? LowestAvailRatio{ get; set; }

        /// <summary>
        /// 可用率最低的省份
        /// </summary>
        [JsonProperty("LowestProvince")]
        public string LowestProvince{ get; set; }

        /// <summary>
        /// 可用率最低的运营商
        /// </summary>
        [JsonProperty("LowestIsp")]
        public string LowestIsp{ get; set; }

        /// <summary>
        /// 分省份的可用率数据
        /// </summary>
        [JsonProperty("ProvinceData")]
        public ProvinceDetail[] ProvinceData{ get; set; }

        /// <summary>
        /// 国内平均耗时，单位毫秒
        /// </summary>
        [JsonProperty("AvgTime")]
        public float? AvgTime{ get; set; }

        /// <summary>
        /// 国外平均可用率
        /// </summary>
        [JsonProperty("AvgAvailRatio2")]
        public float? AvgAvailRatio2{ get; set; }

        /// <summary>
        /// 国外平均耗时，单位毫秒
        /// </summary>
        [JsonProperty("AvgTime2")]
        public float? AvgTime2{ get; set; }

        /// <summary>
        /// 国外最低可用率
        /// </summary>
        [JsonProperty("LowestAvailRatio2")]
        public float? LowestAvailRatio2{ get; set; }

        /// <summary>
        /// 国外可用率最低的区域
        /// </summary>
        [JsonProperty("LowestProvince2")]
        public string LowestProvince2{ get; set; }

        /// <summary>
        /// 国外可用率最低的运营商
        /// </summary>
        [JsonProperty("LowestIsp2")]
        public string LowestIsp2{ get; set; }

        /// <summary>
        /// 国外分区域的可用率数据
        /// </summary>
        [JsonProperty("ProvinceData2")]
        public ProvinceDetail[] ProvinceData2{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AvgAvailRatio", this.AvgAvailRatio);
            this.SetParamSimple(map, prefix + "LowestAvailRatio", this.LowestAvailRatio);
            this.SetParamSimple(map, prefix + "LowestProvince", this.LowestProvince);
            this.SetParamSimple(map, prefix + "LowestIsp", this.LowestIsp);
            this.SetParamArrayObj(map, prefix + "ProvinceData.", this.ProvinceData);
            this.SetParamSimple(map, prefix + "AvgTime", this.AvgTime);
            this.SetParamSimple(map, prefix + "AvgAvailRatio2", this.AvgAvailRatio2);
            this.SetParamSimple(map, prefix + "AvgTime2", this.AvgTime2);
            this.SetParamSimple(map, prefix + "LowestAvailRatio2", this.LowestAvailRatio2);
            this.SetParamSimple(map, prefix + "LowestProvince2", this.LowestProvince2);
            this.SetParamSimple(map, prefix + "LowestIsp2", this.LowestIsp2);
            this.SetParamArrayObj(map, prefix + "ProvinceData2.", this.ProvinceData2);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

