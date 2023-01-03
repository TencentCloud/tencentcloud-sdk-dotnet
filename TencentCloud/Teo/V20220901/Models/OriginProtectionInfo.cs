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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class OriginProtectionInfo : AbstractModel
    {
        
        /// <summary>
        /// 站点ID。
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// 域名列表。
        /// </summary>
        [JsonProperty("Hosts")]
        public string[] Hosts{ get; set; }

        /// <summary>
        /// 代理ID列表。
        /// </summary>
        [JsonProperty("ProxyIds")]
        public string[] ProxyIds{ get; set; }

        /// <summary>
        /// 当前版本的IP白名单。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CurrentIPWhitelist")]
        public IPWhitelist CurrentIPWhitelist{ get; set; }

        /// <summary>
        /// 该站点是否需要更新源站白名单，取值有：
        /// <li>true ：需要更新IP白名单 ；</li>
        /// <li>false ：无需更新IP白名单。</li>
        /// </summary>
        [JsonProperty("NeedUpdate")]
        public bool? NeedUpdate{ get; set; }

        /// <summary>
        /// 源站防护状态，取值有：
        /// <li>online ：源站防护启用中 ；</li>
        /// <li>offline ：源站防护已停用 ；</li>
        /// <li>nonactivate ：源站防护未激活，仅在从未使用过源站防护功能的站点调用中返回。</li>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 站点套餐是否支持源站防护，取值有：
        /// <li>true ：支持 ；</li>
        /// <li>false ：不支持。</li>
        /// </summary>
        [JsonProperty("PlanSupport")]
        public bool? PlanSupport{ get; set; }

        /// <summary>
        /// 最新IP白名单与当前IP白名单的对比。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DiffIPWhitelist")]
        public DiffIPWhitelist DiffIPWhitelist{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamArraySimple(map, prefix + "Hosts.", this.Hosts);
            this.SetParamArraySimple(map, prefix + "ProxyIds.", this.ProxyIds);
            this.SetParamObj(map, prefix + "CurrentIPWhitelist.", this.CurrentIPWhitelist);
            this.SetParamSimple(map, prefix + "NeedUpdate", this.NeedUpdate);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "PlanSupport", this.PlanSupport);
            this.SetParamObj(map, prefix + "DiffIPWhitelist.", this.DiffIPWhitelist);
        }
    }
}

