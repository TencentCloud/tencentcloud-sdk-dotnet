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

    public class ProvinceDetail : AbstractModel
    {
        
        /// <summary>
        /// 可用率
        /// </summary>
        [JsonProperty("AvgAvailRatio")]
        public float? AvgAvailRatio{ get; set; }

        /// <summary>
        /// 省份名称
        /// </summary>
        [JsonProperty("ProvinceName")]
        public string ProvinceName{ get; set; }

        /// <summary>
        /// 省份英文名称
        /// </summary>
        [JsonProperty("Mapkey")]
        public string Mapkey{ get; set; }

        /// <summary>
        /// 统计时间点
        /// </summary>
        [JsonProperty("TimeStamp")]
        public string TimeStamp{ get; set; }

        /// <summary>
        /// 分运营商可用率
        /// </summary>
        [JsonProperty("IspDetail")]
        public IspDetail[] IspDetail{ get; set; }

        /// <summary>
        /// 平均耗时，单位毫秒
        /// </summary>
        [JsonProperty("AvgTime")]
        public float? AvgTime{ get; set; }

        /// <summary>
        /// 省份
        /// </summary>
        [JsonProperty("Province")]
        public string Province{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AvgAvailRatio", this.AvgAvailRatio);
            this.SetParamSimple(map, prefix + "ProvinceName", this.ProvinceName);
            this.SetParamSimple(map, prefix + "Mapkey", this.Mapkey);
            this.SetParamSimple(map, prefix + "TimeStamp", this.TimeStamp);
            this.SetParamArrayObj(map, prefix + "IspDetail.", this.IspDetail);
            this.SetParamSimple(map, prefix + "AvgTime", this.AvgTime);
            this.SetParamSimple(map, prefix + "Province", this.Province);
        }
    }
}

