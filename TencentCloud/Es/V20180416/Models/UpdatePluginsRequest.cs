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

namespace TencentCloud.Es.V20180416.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UpdatePluginsRequest : AbstractModel
    {
        
        /// <summary>
        /// 实例ID
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 需要安装的插件名列表
        /// </summary>
        [JsonProperty("InstallPluginList")]
        public string[] InstallPluginList{ get; set; }

        /// <summary>
        /// 需要卸载的插件名列表
        /// </summary>
        [JsonProperty("RemovePluginList")]
        public string[] RemovePluginList{ get; set; }

        /// <summary>
        /// 是否强制重启，默认值false
        /// </summary>
        [JsonProperty("ForceRestart")]
        public bool? ForceRestart{ get; set; }

        /// <summary>
        /// 是否重新安装，默认值false
        /// </summary>
        [JsonProperty("ForceUpdate")]
        public bool? ForceUpdate{ get; set; }

        /// <summary>
        /// 0：系统插件
        /// </summary>
        [JsonProperty("PluginType")]
        public ulong? PluginType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamArraySimple(map, prefix + "InstallPluginList.", this.InstallPluginList);
            this.SetParamArraySimple(map, prefix + "RemovePluginList.", this.RemovePluginList);
            this.SetParamSimple(map, prefix + "ForceRestart", this.ForceRestart);
            this.SetParamSimple(map, prefix + "ForceUpdate", this.ForceUpdate);
            this.SetParamSimple(map, prefix + "PluginType", this.PluginType);
        }
    }
}

