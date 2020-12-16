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

namespace TencentCloud.Ams.V20200608.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TrendCount : AbstractModel
    {
        
        /// <summary>
        /// 总调用量
        /// </summary>
        [JsonProperty("TotalCount")]
        public long? TotalCount{ get; set; }

        /// <summary>
        /// 总调用时长
        /// </summary>
        [JsonProperty("TotalHour")]
        public long? TotalHour{ get; set; }

        /// <summary>
        /// 通过量
        /// </summary>
        [JsonProperty("PassCount")]
        public long? PassCount{ get; set; }

        /// <summary>
        /// 通过时长
        /// </summary>
        [JsonProperty("PassHour")]
        public long? PassHour{ get; set; }

        /// <summary>
        /// 违规量
        /// </summary>
        [JsonProperty("EvilCount")]
        public long? EvilCount{ get; set; }

        /// <summary>
        /// 违规时长
        /// </summary>
        [JsonProperty("EvilHour")]
        public long? EvilHour{ get; set; }

        /// <summary>
        /// 疑似违规量
        /// </summary>
        [JsonProperty("SuspectCount")]
        public long? SuspectCount{ get; set; }

        /// <summary>
        /// 疑似违规时长
        /// </summary>
        [JsonProperty("SuspectHour")]
        public long? SuspectHour{ get; set; }

        /// <summary>
        /// 日期
        /// </summary>
        [JsonProperty("Date")]
        public string Date{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TotalCount", this.TotalCount);
            this.SetParamSimple(map, prefix + "TotalHour", this.TotalHour);
            this.SetParamSimple(map, prefix + "PassCount", this.PassCount);
            this.SetParamSimple(map, prefix + "PassHour", this.PassHour);
            this.SetParamSimple(map, prefix + "EvilCount", this.EvilCount);
            this.SetParamSimple(map, prefix + "EvilHour", this.EvilHour);
            this.SetParamSimple(map, prefix + "SuspectCount", this.SuspectCount);
            this.SetParamSimple(map, prefix + "SuspectHour", this.SuspectHour);
            this.SetParamSimple(map, prefix + "Date", this.Date);
        }
    }
}

