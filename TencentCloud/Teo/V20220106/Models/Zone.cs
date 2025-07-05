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

namespace TencentCloud.Teo.V20220106.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Zone : AbstractModel
    {
        
        /// <summary>
        /// 站点ID。
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// 站点名称。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 站点当前使用的 NS 列表。
        /// </summary>
        [JsonProperty("OriginalNameServers")]
        public string[] OriginalNameServers{ get; set; }

        /// <summary>
        /// 腾讯云分配的 NS 列表。
        /// </summary>
        [JsonProperty("NameServers")]
        public string[] NameServers{ get; set; }

        /// <summary>
        /// 站点状态，取值有：
        /// <li> active：NS 已切换； </li>
        /// <li> pending：NS 未切换；</li>
        /// <li> moved：NS 已切走；</li>
        /// <li> deactivated：被封禁。 </li>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 站点接入方式，取值有
        /// <li> full：NS 接入； </li>
        /// <li> partial：CNAME 接入。</li>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 站点是否关闭。
        /// </summary>
        [JsonProperty("Paused")]
        public bool? Paused{ get; set; }

        /// <summary>
        /// 是否开启cname加速，取值有：
        /// <li> enabled：开启；</li>
        /// <li> disabled：关闭。</li>
        /// </summary>
        [JsonProperty("CnameSpeedUp")]
        public string CnameSpeedUp{ get; set; }

        /// <summary>
        /// cname 接入状态，取值有：
        /// <li> finished：站点已验证；</li>
        /// <li> pending：站点验证中。</li>
        /// </summary>
        [JsonProperty("CnameStatus")]
        public string CnameStatus{ get; set; }

        /// <summary>
        /// 资源标签列表。
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// 计费资源列表。
        /// </summary>
        [JsonProperty("Resources")]
        public Resource[] Resources{ get; set; }

        /// <summary>
        /// 站点创建时间。
        /// </summary>
        [JsonProperty("CreatedOn")]
        public string CreatedOn{ get; set; }

        /// <summary>
        /// 站点修改时间。
        /// </summary>
        [JsonProperty("ModifiedOn")]
        public string ModifiedOn{ get; set; }

        /// <summary>
        /// 站点接入地域，取值为：
        /// <li> global：全球；</li>
        /// <li> mainland：中国大陆；</li>
        /// <li> overseas：境外区域。</li>
        /// </summary>
        [JsonProperty("Area")]
        public string Area{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamArraySimple(map, prefix + "OriginalNameServers.", this.OriginalNameServers);
            this.SetParamArraySimple(map, prefix + "NameServers.", this.NameServers);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Paused", this.Paused);
            this.SetParamSimple(map, prefix + "CnameSpeedUp", this.CnameSpeedUp);
            this.SetParamSimple(map, prefix + "CnameStatus", this.CnameStatus);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamArrayObj(map, prefix + "Resources.", this.Resources);
            this.SetParamSimple(map, prefix + "CreatedOn", this.CreatedOn);
            this.SetParamSimple(map, prefix + "ModifiedOn", this.ModifiedOn);
            this.SetParamSimple(map, prefix + "Area", this.Area);
        }
    }
}

