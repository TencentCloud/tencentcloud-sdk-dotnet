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

namespace TencentCloud.Dbbrain.V20210527.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SlowLogAgg : AbstractModel
    {
        
        /// <summary>
        /// 命令模板。
        /// </summary>
        [JsonProperty("Cmd")]
        public string Cmd{ get; set; }

        /// <summary>
        /// 命令详情。
        /// </summary>
        [JsonProperty("Detail")]
        public string Detail{ get; set; }

        /// <summary>
        /// 执行次数。
        /// </summary>
        [JsonProperty("ExecTimes")]
        public long? ExecTimes{ get; set; }

        /// <summary>
        /// 总耗时。单位：s
        /// </summary>
        [JsonProperty("QueryTime")]
        public float? QueryTime{ get; set; }

        /// <summary>
        /// 平均执行时间。单位：s
        /// </summary>
        [JsonProperty("QueryTimeAvg")]
        public float? QueryTimeAvg{ get; set; }

        /// <summary>
        /// 最大执行时间。单位：s
        /// </summary>
        [JsonProperty("QueryTimeMax")]
        public float? QueryTimeMax{ get; set; }

        /// <summary>
        /// 最小执行时间。单位：s
        /// </summary>
        [JsonProperty("QueryTimeMin")]
        public float? QueryTimeMin{ get; set; }

        /// <summary>
        /// 总耗时占比。单位：%
        /// </summary>
        [JsonProperty("QueryTimeRatio")]
        public float? QueryTimeRatio{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Cmd", this.Cmd);
            this.SetParamSimple(map, prefix + "Detail", this.Detail);
            this.SetParamSimple(map, prefix + "ExecTimes", this.ExecTimes);
            this.SetParamSimple(map, prefix + "QueryTime", this.QueryTime);
            this.SetParamSimple(map, prefix + "QueryTimeAvg", this.QueryTimeAvg);
            this.SetParamSimple(map, prefix + "QueryTimeMax", this.QueryTimeMax);
            this.SetParamSimple(map, prefix + "QueryTimeMin", this.QueryTimeMin);
            this.SetParamSimple(map, prefix + "QueryTimeRatio", this.QueryTimeRatio);
        }
    }
}

