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

namespace TencentCloud.Mongodb.V20190725.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SlowLogPattern : AbstractModel
    {
        
        /// <summary>
        /// 慢日志输出格式：库名.表名.命令。
        /// </summary>
        [JsonProperty("Pattern")]
        public string Pattern{ get; set; }

        /// <summary>
        /// 记录慢日志时所带的queryHash 值，标识一类查询。
        /// </summary>
        [JsonProperty("QueryHash")]
        public string QueryHash{ get; set; }

        /// <summary>
        /// 最大执行时间。单位：毫秒。
        /// </summary>
        [JsonProperty("MaxTime")]
        public ulong? MaxTime{ get; set; }

        /// <summary>
        /// 平均执行时间。单位：毫秒。
        /// </summary>
        [JsonProperty("AverageTime")]
        public ulong? AverageTime{ get; set; }

        /// <summary>
        /// 慢日志条数。
        /// </summary>
        [JsonProperty("Total")]
        public ulong? Total{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Pattern", this.Pattern);
            this.SetParamSimple(map, prefix + "QueryHash", this.QueryHash);
            this.SetParamSimple(map, prefix + "MaxTime", this.MaxTime);
            this.SetParamSimple(map, prefix + "AverageTime", this.AverageTime);
            this.SetParamSimple(map, prefix + "Total", this.Total);
        }
    }
}

