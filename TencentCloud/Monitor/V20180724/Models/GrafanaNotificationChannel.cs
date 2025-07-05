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

namespace TencentCloud.Monitor.V20180724.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class GrafanaNotificationChannel : AbstractModel
    {
        
        /// <summary>
        /// 渠道 ID
        /// </summary>
        [JsonProperty("ChannelId")]
        public string ChannelId{ get; set; }

        /// <summary>
        /// 渠道名
        /// </summary>
        [JsonProperty("ChannelName")]
        public string ChannelName{ get; set; }

        /// <summary>
        /// 告警通道模板 ID 数组
        /// </summary>
        [JsonProperty("Receivers")]
        public string[] Receivers{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("CreatedAt")]
        public string CreatedAt{ get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [JsonProperty("UpdatedAt")]
        public string UpdatedAt{ get; set; }

        /// <summary>
        /// 默认生效组织，已废弃，请使用 OrganizationIds
        /// </summary>
        [JsonProperty("OrgId")]
        public string OrgId{ get; set; }

        /// <summary>
        /// 额外生效组织，已废弃，请使用 OrganizationIds
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExtraOrgIds")]
        public string[] ExtraOrgIds{ get; set; }

        /// <summary>
        /// 生效组织，已废弃，请使用 OrganizationIds
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OrgIds")]
        public string[] OrgIds{ get; set; }

        /// <summary>
        /// 告警渠道的所有生效组织
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OrganizationIds")]
        public string[] OrganizationIds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ChannelId", this.ChannelId);
            this.SetParamSimple(map, prefix + "ChannelName", this.ChannelName);
            this.SetParamArraySimple(map, prefix + "Receivers.", this.Receivers);
            this.SetParamSimple(map, prefix + "CreatedAt", this.CreatedAt);
            this.SetParamSimple(map, prefix + "UpdatedAt", this.UpdatedAt);
            this.SetParamSimple(map, prefix + "OrgId", this.OrgId);
            this.SetParamArraySimple(map, prefix + "ExtraOrgIds.", this.ExtraOrgIds);
            this.SetParamArraySimple(map, prefix + "OrgIds.", this.OrgIds);
            this.SetParamArraySimple(map, prefix + "OrganizationIds.", this.OrganizationIds);
        }
    }
}

