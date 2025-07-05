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

    public class RaspRuleVul : AbstractModel
    {
        
        /// <summary>
        /// 漏洞id
        /// </summary>
        [JsonProperty("VulVulsID")]
        public ulong? VulVulsID{ get; set; }

        /// <summary>
        /// 漏洞名称
        /// </summary>
        [JsonProperty("VulVulsName")]
        public string VulVulsName{ get; set; }

        /// <summary>
        /// cve_id
        /// </summary>
        [JsonProperty("CveID")]
        public string CveID{ get; set; }

        /// <summary>
        /// 漏洞防御类型，从漏洞表富化， 1:支持组件漏洞防御，组件漏洞没有正则加白。2:支持正则防御
        /// </summary>
        [JsonProperty("SupportDefense")]
        public ulong? SupportDefense{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "VulVulsID", this.VulVulsID);
            this.SetParamSimple(map, prefix + "VulVulsName", this.VulVulsName);
            this.SetParamSimple(map, prefix + "CveID", this.CveID);
            this.SetParamSimple(map, prefix + "SupportDefense", this.SupportDefense);
        }
    }
}

