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

namespace TencentCloud.Evt.V20250217.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PutEventRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>插件ID</p>
        /// </summary>
        [JsonProperty("PluginId")]
        public string PluginId{ get; set; }

        /// <summary>
        /// <p>需要推送的事件数据内容，格式为json，字段定义需要与事件中的定义一致</p>
        /// </summary>
        [JsonProperty("Data")]
        public string Data{ get; set; }

        /// <summary>
        /// <p>数据推送来源，会在生成的单据中展示数据来源</p>
        /// </summary>
        [JsonProperty("Source")]
        public string Source{ get; set; }

        /// <summary>
        /// <p>可以接受当前消息的Uin</p>
        /// </summary>
        [JsonProperty("TargetUin")]
        public ulong? TargetUin{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PluginId", this.PluginId);
            this.SetParamSimple(map, prefix + "Data", this.Data);
            this.SetParamSimple(map, prefix + "Source", this.Source);
            this.SetParamSimple(map, prefix + "TargetUin", this.TargetUin);
        }
    }
}

