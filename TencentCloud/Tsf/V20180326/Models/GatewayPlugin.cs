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

namespace TencentCloud.Tsf.V20180326.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class GatewayPlugin : AbstractModel
    {
        
        /// <summary>
        /// <p>网关插件id</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// <p>插件名称</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>插件类型</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// <p>插件描述</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>创建时间</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CreatedTime")]
        public string CreatedTime{ get; set; }

        /// <summary>
        /// <p>更新时间</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UpdatedTime")]
        public string UpdatedTime{ get; set; }

        /// <summary>
        /// <p>发布状态</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>是否禁用删除</p>
        /// </summary>
        [JsonProperty("DeleteDisabled")]
        public bool? DeleteDisabled{ get; set; }

        /// <summary>
        /// <p>禁用原因</p>
        /// </summary>
        [JsonProperty("DeleteDisabledReason")]
        public string DeleteDisabledReason{ get; set; }

        /// <summary>
        /// <p>是否不可绑定</p><p>枚举值：</p><ul><li>true： 禁止绑定</li><li>false： 允许绑定</li></ul>
        /// </summary>
        [JsonProperty("BindDisabled")]
        public bool? BindDisabled{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "CreatedTime", this.CreatedTime);
            this.SetParamSimple(map, prefix + "UpdatedTime", this.UpdatedTime);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "DeleteDisabled", this.DeleteDisabled);
            this.SetParamSimple(map, prefix + "DeleteDisabledReason", this.DeleteDisabledReason);
            this.SetParamSimple(map, prefix + "BindDisabled", this.BindDisabled);
        }
    }
}

