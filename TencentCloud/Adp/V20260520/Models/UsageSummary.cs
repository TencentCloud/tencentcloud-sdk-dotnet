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

namespace TencentCloud.Adp.V20260520.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UsageSummary : AbstractModel
    {
        
        /// <summary>
        /// <p>MODEL 域专属</p>
        /// </summary>
        [JsonProperty("Model")]
        public ModelUsageSummary Model{ get; set; }

        /// <summary>
        /// <p>PLATFORM 域专属</p>
        /// </summary>
        [JsonProperty("Platform")]
        public PlatformUsageSummary Platform{ get; set; }

        /// <summary>
        /// <p>PLUGIN 域专属</p>
        /// </summary>
        [JsonProperty("Plugin")]
        public PluginUsageSummary Plugin{ get; set; }

        /// <summary>
        /// <p>来源 ID；CORP 视图=space_id（企业视图按 space 分组），SPACE 视图=app_id（uint64 字符串），APP 视图=app_id</p>
        /// </summary>
        [JsonProperty("SourceId")]
        public string SourceId{ get; set; }

        /// <summary>
        /// <p>来源名称；CORP 视图=space_name，SPACE 视图=app_name，APP 视图=app_name</p>
        /// </summary>
        [JsonProperty("SourceName")]
        public string SourceName{ get; set; }

        /// <summary>
        /// <p>视图类型，决定 SourceId/SourceName 的业务含义</p><table><tbody><tr><td>枚举项</td><td>枚举值</td><td>描述</td></tr><tr><td>VIEW_TYPE_UNSPECIFIED</td><td>0</td><td>未指定（无效值，请求勿传）</td></tr><tr><td>VIEW_TYPE_CORP</td><td>1</td><td>企业视图</td></tr><tr><td>VIEW_TYPE_SPACE</td><td>2</td><td>空间视图</td></tr><tr><td>VIEW_TYPE_APP</td><td>3</td><td>应用视图</td></tr></tbody></table>
        /// </summary>
        [JsonProperty("ViewType")]
        public long? ViewType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Model.", this.Model);
            this.SetParamObj(map, prefix + "Platform.", this.Platform);
            this.SetParamObj(map, prefix + "Plugin.", this.Plugin);
            this.SetParamSimple(map, prefix + "SourceId", this.SourceId);
            this.SetParamSimple(map, prefix + "SourceName", this.SourceName);
            this.SetParamSimple(map, prefix + "ViewType", this.ViewType);
        }
    }
}

