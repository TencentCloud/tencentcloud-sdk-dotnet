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

namespace TencentCloud.Apigateway.V20180808.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Plugin : AbstractModel
    {
        
        /// <summary>
        /// 插件ID。
        /// </summary>
        [JsonProperty("PluginId")]
        public string PluginId{ get; set; }

        /// <summary>
        /// 插件名称。
        /// </summary>
        [JsonProperty("PluginName")]
        public string PluginName{ get; set; }

        /// <summary>
        /// 插件类型。
        /// </summary>
        [JsonProperty("PluginType")]
        public string PluginType{ get; set; }

        /// <summary>
        /// 插件定义语句。
        /// </summary>
        [JsonProperty("PluginData")]
        public string PluginData{ get; set; }

        /// <summary>
        /// 插件描述。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 插件创建时间。按照 ISO8601 标准表示，并且使用 UTC 时间。格式为：YYYY-MM-DDThh:mm:ssZ。
        /// </summary>
        [JsonProperty("CreatedTime")]
        public string CreatedTime{ get; set; }

        /// <summary>
        /// 插件修改时间。按照 ISO8601 标准表示，并且使用 UTC 时间。格式为：YYYY-MM-DDThh:mm:ssZ。
        /// </summary>
        [JsonProperty("ModifiedTime")]
        public string ModifiedTime{ get; set; }

        /// <summary>
        /// 插件绑定的API总数。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AttachedApiTotalCount")]
        public long? AttachedApiTotalCount{ get; set; }

        /// <summary>
        /// 插件绑定的API信息。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AttachedApis")]
        public AttachedApiInfo[] AttachedApis{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PluginId", this.PluginId);
            this.SetParamSimple(map, prefix + "PluginName", this.PluginName);
            this.SetParamSimple(map, prefix + "PluginType", this.PluginType);
            this.SetParamSimple(map, prefix + "PluginData", this.PluginData);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "CreatedTime", this.CreatedTime);
            this.SetParamSimple(map, prefix + "ModifiedTime", this.ModifiedTime);
            this.SetParamSimple(map, prefix + "AttachedApiTotalCount", this.AttachedApiTotalCount);
            this.SetParamArrayObj(map, prefix + "AttachedApis.", this.AttachedApis);
        }
    }
}

