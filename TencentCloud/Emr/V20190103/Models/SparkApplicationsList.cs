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

namespace TencentCloud.Emr.V20190103.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SparkApplicationsList : AbstractModel
    {
        
        /// <summary>
        /// 应用id
        /// </summary>
        [JsonProperty("ID")]
        public string ID{ get; set; }

        /// <summary>
        /// 应用名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 用户
        /// </summary>
        [JsonProperty("User")]
        public string User{ get; set; }

        /// <summary>
        /// 起始时间
        /// </summary>
        [JsonProperty("StartTime")]
        public long? StartTime{ get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        [JsonProperty("EndTime")]
        public long? EndTime{ get; set; }

        /// <summary>
        /// 持续时间
        /// </summary>
        [JsonProperty("Duration")]
        public long? Duration{ get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        [JsonProperty("State")]
        public string State{ get; set; }

        /// <summary>
        /// 类型
        /// </summary>
        [JsonProperty("ApplicationType")]
        public string ApplicationType{ get; set; }

        /// <summary>
        /// 核数*秒
        /// </summary>
        [JsonProperty("CoreSeconds")]
        public long? CoreSeconds{ get; set; }

        /// <summary>
        /// 内存MB*秒
        /// </summary>
        [JsonProperty("MemorySeconds")]
        public string MemorySeconds{ get; set; }

        /// <summary>
        /// 洞察结果
        /// </summary>
        [JsonProperty("Insight")]
        public string Insight{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ID", this.ID);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "User", this.User);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "Duration", this.Duration);
            this.SetParamSimple(map, prefix + "State", this.State);
            this.SetParamSimple(map, prefix + "ApplicationType", this.ApplicationType);
            this.SetParamSimple(map, prefix + "CoreSeconds", this.CoreSeconds);
            this.SetParamSimple(map, prefix + "MemorySeconds", this.MemorySeconds);
            this.SetParamSimple(map, prefix + "Insight", this.Insight);
        }
    }
}

