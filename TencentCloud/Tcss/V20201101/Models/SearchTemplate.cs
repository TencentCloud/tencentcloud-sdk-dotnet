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

namespace TencentCloud.Tcss.V20201101.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SearchTemplate : AbstractModel
    {
        
        /// <summary>
        /// 检索名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 检索索引类型
        /// </summary>
        [JsonProperty("LogType")]
        public string LogType{ get; set; }

        /// <summary>
        /// 检索语句
        /// </summary>
        [JsonProperty("Condition")]
        public string Condition{ get; set; }

        /// <summary>
        /// 时间范围
        /// </summary>
        [JsonProperty("TimeRange")]
        public string TimeRange{ get; set; }

        /// <summary>
        /// 转换的检索语句内容
        /// </summary>
        [JsonProperty("Query")]
        public string Query{ get; set; }

        /// <summary>
        /// 检索方式。输入框检索：standard,过滤，检索：simple
        /// </summary>
        [JsonProperty("Flag")]
        public string Flag{ get; set; }

        /// <summary>
        /// 展示数据
        /// </summary>
        [JsonProperty("DisplayData")]
        public string DisplayData{ get; set; }

        /// <summary>
        /// 规则ID
        /// </summary>
        [JsonProperty("Id")]
        public ulong? Id{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "LogType", this.LogType);
            this.SetParamSimple(map, prefix + "Condition", this.Condition);
            this.SetParamSimple(map, prefix + "TimeRange", this.TimeRange);
            this.SetParamSimple(map, prefix + "Query", this.Query);
            this.SetParamSimple(map, prefix + "Flag", this.Flag);
            this.SetParamSimple(map, prefix + "DisplayData", this.DisplayData);
            this.SetParamSimple(map, prefix + "Id", this.Id);
        }
    }
}

