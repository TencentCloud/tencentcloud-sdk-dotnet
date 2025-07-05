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

namespace TencentCloud.Tcr.V20190924.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyNamespaceRequest : AbstractModel
    {
        
        /// <summary>
        /// 实例Id
        /// </summary>
        [JsonProperty("RegistryId")]
        public string RegistryId{ get; set; }

        /// <summary>
        /// 命名空间名称
        /// </summary>
        [JsonProperty("NamespaceName")]
        public string NamespaceName{ get; set; }

        /// <summary>
        /// 访问级别，True为公开，False为私有
        /// </summary>
        [JsonProperty("IsPublic")]
        public bool? IsPublic{ get; set; }

        /// <summary>
        /// 扫描级别，True为自动，False为手动
        /// </summary>
        [JsonProperty("IsAutoScan")]
        public bool? IsAutoScan{ get; set; }

        /// <summary>
        /// 阻断开关，True为开放，False为关闭
        /// </summary>
        [JsonProperty("IsPreventVUL")]
        public bool? IsPreventVUL{ get; set; }

        /// <summary>
        /// 阻断漏洞等级，目前仅支持 low、medium、high
        /// </summary>
        [JsonProperty("Severity")]
        public string Severity{ get; set; }

        /// <summary>
        /// 漏洞白名单列表
        /// </summary>
        [JsonProperty("CVEWhitelistItems")]
        public CVEWhitelistItem[] CVEWhitelistItems{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RegistryId", this.RegistryId);
            this.SetParamSimple(map, prefix + "NamespaceName", this.NamespaceName);
            this.SetParamSimple(map, prefix + "IsPublic", this.IsPublic);
            this.SetParamSimple(map, prefix + "IsAutoScan", this.IsAutoScan);
            this.SetParamSimple(map, prefix + "IsPreventVUL", this.IsPreventVUL);
            this.SetParamSimple(map, prefix + "Severity", this.Severity);
            this.SetParamArrayObj(map, prefix + "CVEWhitelistItems.", this.CVEWhitelistItems);
        }
    }
}

