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

namespace TencentCloud.Rum.V20210622.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeUserJourneySanKeyRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>应用id</p>
        /// </summary>
        [JsonProperty("AppId")]
        public string AppId{ get; set; }

        /// <summary>
        /// <p>开始时间</p>
        /// </summary>
        [JsonProperty("StartTime")]
        public long? StartTime{ get; set; }

        /// <summary>
        /// <p>结束时间</p>
        /// </summary>
        [JsonProperty("EndTime")]
        public long? EndTime{ get; set; }

        /// <summary>
        /// <p>平台</p>
        /// </summary>
        [JsonProperty("Platform")]
        public string Platform{ get; set; }

        /// <summary>
        /// <p>过滤条件</p>
        /// </summary>
        [JsonProperty("Filters")]
        public string Filters{ get; set; }

        /// <summary>
        /// <p>每一步骤的数量</p>
        /// </summary>
        [JsonProperty("TopPagesPerStep")]
        public long? TopPagesPerStep{ get; set; }

        /// <summary>
        /// <p>每一个节点最小的会话数量</p>
        /// </summary>
        [JsonProperty("MinSessionThreshold")]
        public long? MinSessionThreshold{ get; set; }

        /// <summary>
        /// <p>开始页面</p>
        /// </summary>
        [JsonProperty("StartPage")]
        public string StartPage{ get; set; }

        /// <summary>
        /// <p>结束页面</p>
        /// </summary>
        [JsonProperty("EndPage")]
        public string EndPage{ get; set; }

        /// <summary>
        /// <p>是否有挣扎事件</p>
        /// </summary>
        [JsonProperty("HasStruggle")]
        public bool? HasStruggle{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "Platform", this.Platform);
            this.SetParamSimple(map, prefix + "Filters", this.Filters);
            this.SetParamSimple(map, prefix + "TopPagesPerStep", this.TopPagesPerStep);
            this.SetParamSimple(map, prefix + "MinSessionThreshold", this.MinSessionThreshold);
            this.SetParamSimple(map, prefix + "StartPage", this.StartPage);
            this.SetParamSimple(map, prefix + "EndPage", this.EndPage);
            this.SetParamSimple(map, prefix + "HasStruggle", this.HasStruggle);
        }
    }
}

