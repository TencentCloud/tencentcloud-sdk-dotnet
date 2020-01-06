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

    public class ShopDayTrafficInfo : AbstractModel
    {
        
        /// <summary>
        /// 日期
        /// </summary>
        [JsonProperty("Date")]
        public string Date{ get; set; }

        /// <summary>
        /// 客流量
        /// </summary>
        [JsonProperty("DayTrafficTotalCount")]
        public ulong? DayTrafficTotalCount{ get; set; }

        /// <summary>
        /// 性别年龄分组下的客流信息
        /// </summary>
        [JsonProperty("GenderAgeTrafficDetailSet")]
        public GenderAgeTrafficDetail[] GenderAgeTrafficDetailSet{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Date", this.Date);
            this.SetParamSimple(map, prefix + "DayTrafficTotalCount", this.DayTrafficTotalCount);
            this.SetParamArrayObj(map, prefix + "GenderAgeTrafficDetailSet.", this.GenderAgeTrafficDetailSet);
        }
    }
}

