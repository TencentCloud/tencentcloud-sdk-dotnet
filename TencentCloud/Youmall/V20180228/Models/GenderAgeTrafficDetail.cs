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

namespace TencentCloud.Youmall.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class GenderAgeTrafficDetail : AbstractModel
    {
        
        /// <summary>
        /// 性别: 0男1女
        /// </summary>
        [JsonProperty("Gender")]
        public ulong? Gender{ get; set; }

        /// <summary>
        /// 年龄区间，枚举值：0-17、18-23、24-30、31-40、41-50、51-60、>60
        /// </summary>
        [JsonProperty("AgeGap")]
        public string AgeGap{ get; set; }

        /// <summary>
        /// 客流量
        /// </summary>
        [JsonProperty("TrafficCount")]
        public ulong? TrafficCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Gender", this.Gender);
            this.SetParamSimple(map, prefix + "AgeGap", this.AgeGap);
            this.SetParamSimple(map, prefix + "TrafficCount", this.TrafficCount);
        }
    }
}

