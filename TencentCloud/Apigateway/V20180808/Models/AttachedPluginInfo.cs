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

namespace TencentCloud.Apigateway.V20180808.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AttachedPluginInfo : AbstractModel
    {
        
        /// <summary>
        /// 插件ID。
        /// </summary>
        [JsonProperty("PluginId")]
        public string PluginId{ get; set; }

        /// <summary>
        /// 环境信息。
        /// </summary>
        [JsonProperty("Environment")]
        public string Environment{ get; set; }

        /// <summary>
        /// 绑定时间。
        /// </summary>
        [JsonProperty("AttachedTime")]
        public string AttachedTime{ get; set; }

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
        /// 插件描述。
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 插件定义语句。
        /// </summary>
        [JsonProperty("PluginData")]
        public string PluginData{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PluginId", this.PluginId);
            this.SetParamSimple(map, prefix + "Environment", this.Environment);
            this.SetParamSimple(map, prefix + "AttachedTime", this.AttachedTime);
            this.SetParamSimple(map, prefix + "PluginName", this.PluginName);
            this.SetParamSimple(map, prefix + "PluginType", this.PluginType);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "PluginData", this.PluginData);
        }
    }
}

