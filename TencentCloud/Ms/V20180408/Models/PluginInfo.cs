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

namespace TencentCloud.Ms.V20180408.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PluginInfo : AbstractModel
    {
        
        /// <summary>
        /// 插件类型，分别为 1-通知栏广告，2-积分墙广告，3-banner广告，4- 悬浮窗图标广告，5-精品推荐列表广告, 6-插播广告
        /// </summary>
        [JsonProperty("PluginType")]
        public ulong? PluginType{ get; set; }

        /// <summary>
        /// 插件名称
        /// </summary>
        [JsonProperty("PluginName")]
        public string PluginName{ get; set; }

        /// <summary>
        /// 插件描述
        /// </summary>
        [JsonProperty("PluginDesc")]
        public string PluginDesc{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PluginType", this.PluginType);
            this.SetParamSimple(map, prefix + "PluginName", this.PluginName);
            this.SetParamSimple(map, prefix + "PluginDesc", this.PluginDesc);
        }
    }
}

