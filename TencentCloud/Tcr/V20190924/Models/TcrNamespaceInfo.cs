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

namespace TencentCloud.Tcr.V20190924.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TcrNamespaceInfo : AbstractModel
    {
        
        /// <summary>
        /// 命名空间名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("CreationTime")]
        public string CreationTime{ get; set; }

        /// <summary>
        /// 访问级别
        /// </summary>
        [JsonProperty("Public")]
        public bool? Public{ get; set; }

        /// <summary>
        /// 命名空间的Id
        /// </summary>
        [JsonProperty("NamespaceId")]
        public long? NamespaceId{ get; set; }

        /// <summary>
        /// 实例云标签
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TagSpecification")]
        public TagSpecification TagSpecification{ get; set; }

        /// <summary>
        /// 命名空间元数据
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Metadata")]
        public KeyValueString[] Metadata{ get; set; }

        /// <summary>
        /// 漏洞白名单列表
        /// </summary>
        [JsonProperty("CVEWhitelistItems")]
        public CVEWhitelistItem[] CVEWhitelistItems{ get; set; }

        /// <summary>
        /// 扫描级别，true为自动，false为手动
        /// </summary>
        [JsonProperty("AutoScan")]
        public bool? AutoScan{ get; set; }

        /// <summary>
        /// 安全阻断级别，true为开启，false为关闭
        /// </summary>
        [JsonProperty("PreventVUL")]
        public bool? PreventVUL{ get; set; }

        /// <summary>
        /// 阻断漏洞等级，目前仅支持low、medium、high, 为""时表示没有设置
        /// </summary>
        [JsonProperty("Severity")]
        public string Severity{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "CreationTime", this.CreationTime);
            this.SetParamSimple(map, prefix + "Public", this.Public);
            this.SetParamSimple(map, prefix + "NamespaceId", this.NamespaceId);
            this.SetParamObj(map, prefix + "TagSpecification.", this.TagSpecification);
            this.SetParamArrayObj(map, prefix + "Metadata.", this.Metadata);
            this.SetParamArrayObj(map, prefix + "CVEWhitelistItems.", this.CVEWhitelistItems);
            this.SetParamSimple(map, prefix + "AutoScan", this.AutoScan);
            this.SetParamSimple(map, prefix + "PreventVUL", this.PreventVUL);
            this.SetParamSimple(map, prefix + "Severity", this.Severity);
        }
    }
}

