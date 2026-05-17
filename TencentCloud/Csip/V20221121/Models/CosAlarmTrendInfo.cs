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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CosAlarmTrendInfo : AbstractModel
    {
        
        /// <summary>
        /// 当前日期字符串格式
        /// </summary>
        [JsonProperty("CurrentDateStr")]
        public string CurrentDateStr{ get; set; }

        /// <summary>
        /// 当前日期总数
        /// </summary>
        [JsonProperty("CurrentDayCount")]
        public long? CurrentDayCount{ get; set; }

        /// <summary>
        /// 当天告警分类详情
        /// </summary>
        [JsonProperty("CurrentDayOverView")]
        public CosRiskInfo[] CurrentDayOverView{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CurrentDateStr", this.CurrentDateStr);
            this.SetParamSimple(map, prefix + "CurrentDayCount", this.CurrentDayCount);
            this.SetParamArrayObj(map, prefix + "CurrentDayOverView.", this.CurrentDayOverView);
        }
    }
}

