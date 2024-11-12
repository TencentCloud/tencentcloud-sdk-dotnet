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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class VulDefenceOverview : AbstractModel
    {
        
        /// <summary>
        /// 防御开关：0 关闭 1 开启
        /// </summary>
        [JsonProperty("Enable")]
        public long? Enable{ get; set; }

        /// <summary>
        /// 已开启防御主机数
        /// </summary>
        [JsonProperty("DefendHostCount")]
        public long? DefendHostCount{ get; set; }

        /// <summary>
        /// 插件异常数
        /// </summary>
        [JsonProperty("ExceptionCount")]
        public long? ExceptionCount{ get; set; }

        /// <summary>
        /// 每日攻击趋势
        /// </summary>
        [JsonProperty("AttackCounts")]
        public long?[] AttackCounts{ get; set; }

        /// <summary>
        /// 每日防御趋势
        /// </summary>
        [JsonProperty("DefendCounts")]
        public long?[] DefendCounts{ get; set; }

        /// <summary>
        /// 日期
        /// </summary>
        [JsonProperty("Date")]
        public string[] Date{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Enable", this.Enable);
            this.SetParamSimple(map, prefix + "DefendHostCount", this.DefendHostCount);
            this.SetParamSimple(map, prefix + "ExceptionCount", this.ExceptionCount);
            this.SetParamArraySimple(map, prefix + "AttackCounts.", this.AttackCounts);
            this.SetParamArraySimple(map, prefix + "DefendCounts.", this.DefendCounts);
            this.SetParamArraySimple(map, prefix + "Date.", this.Date);
        }
    }
}

