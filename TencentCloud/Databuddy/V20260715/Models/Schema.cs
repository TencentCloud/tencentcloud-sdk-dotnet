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

namespace TencentCloud.Databuddy.V20260715.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Schema : AbstractModel
    {
        
        /// <summary>
        /// <p>schema名称</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>描述。注意：此字段可能返回null，表示取不到有效值</p>
        /// </summary>
        [JsonProperty("Comment")]
        public string Comment{ get; set; }

        /// <summary>
        /// <p>属性。注意：此字段可能返回null，表示取不到有效值</p>
        /// </summary>
        [JsonProperty("Properties")]
        public KVPair[] Properties{ get; set; }

        /// <summary>
        /// <p>审计信息。注意：此字段可能返回null，表示取不到有效值</p>
        /// </summary>
        [JsonProperty("Audit")]
        public Audit Audit{ get; set; }

        /// <summary>
        /// <p>owner信息</p>
        /// </summary>
        [JsonProperty("MetaOwner")]
        public MetaOwner MetaOwner{ get; set; }

        /// <summary>
        /// <p>资产全局唯一ID，通过WedataAssetUIDUtils.generateUID生成</p>
        /// </summary>
        [JsonProperty("AssetGuid")]
        public string AssetGuid{ get; set; }

        /// <summary>
        /// <p>当前用户对该schema的权限信息。注意：此字段可能返回null，请求中未开启FetchPermissions时不返回</p>
        /// </summary>
        [JsonProperty("PermissionDetail")]
        public PermissionDetail PermissionDetail{ get; set; }

        /// <summary>
        /// <p>标签信息列表。注意：此字段可能返回null，请求中未开启FetchTags时不返回</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Tags")]
        public CommonTagInfo[] Tags{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Comment", this.Comment);
            this.SetParamArrayObj(map, prefix + "Properties.", this.Properties);
            this.SetParamObj(map, prefix + "Audit.", this.Audit);
            this.SetParamObj(map, prefix + "MetaOwner.", this.MetaOwner);
            this.SetParamSimple(map, prefix + "AssetGuid", this.AssetGuid);
            this.SetParamObj(map, prefix + "PermissionDetail.", this.PermissionDetail);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
        }
    }
}

