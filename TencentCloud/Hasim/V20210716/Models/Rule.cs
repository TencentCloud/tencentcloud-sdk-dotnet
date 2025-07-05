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

namespace TencentCloud.Hasim.V20210716.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Rule : AbstractModel
    {
        
        /// <summary>
        /// 规则名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 规则ID
        /// </summary>
        [JsonProperty("ID")]
        public long? ID{ get; set; }

        /// <summary>
        /// 创建时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CreatedAt")]
        public string CreatedAt{ get; set; }

        /// <summary>
        /// 更新时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UpdatedAt")]
        public string UpdatedAt{ get; set; }

        /// <summary>
        /// 删除时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DeletedAt")]
        public string DeletedAt{ get; set; }

        /// <summary>
        /// 规则类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Type")]
        public long? Type{ get; set; }

        /// <summary>
        /// 是否激活
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsActive")]
        public bool? IsActive{ get; set; }

        /// <summary>
        /// 触发动作：1 邮件 2 API请求 5 停卡 6 地图标识为盲点
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Notice")]
        public long? Notice{ get; set; }

        /// <summary>
        /// 邮箱
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Email")]
        public string Email{ get; set; }

        /// <summary>
        /// 回调API地址
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Url")]
        public string Url{ get; set; }

        /// <summary>
        /// 用量类：用量阈值,单位MB
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DataThreshold")]
        public long? DataThreshold{ get; set; }

        /// <summary>
        /// 行政区类型：1. 省份 2. 城市 3. 区
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("District")]
        public long? District{ get; set; }

        /// <summary>
        /// 移动距离阈值，单位KM
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Distance")]
        public long? Distance{ get; set; }

        /// <summary>
        /// 信号强度阈值(-dbm）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SignalStrength")]
        public long? SignalStrength{ get; set; }

        /// <summary>
        /// 盲点阈值天数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LostDay")]
        public long? LostDay{ get; set; }

        /// <summary>
        /// 绑定的标签ID集合
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TagIDs")]
        public ulong?[] TagIDs{ get; set; }

        /// <summary>
        /// 绑定的资费计划
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SalePlan")]
        public string SalePlan{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "ID", this.ID);
            this.SetParamSimple(map, prefix + "CreatedAt", this.CreatedAt);
            this.SetParamSimple(map, prefix + "UpdatedAt", this.UpdatedAt);
            this.SetParamSimple(map, prefix + "DeletedAt", this.DeletedAt);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "IsActive", this.IsActive);
            this.SetParamSimple(map, prefix + "Notice", this.Notice);
            this.SetParamSimple(map, prefix + "Email", this.Email);
            this.SetParamSimple(map, prefix + "Url", this.Url);
            this.SetParamSimple(map, prefix + "DataThreshold", this.DataThreshold);
            this.SetParamSimple(map, prefix + "District", this.District);
            this.SetParamSimple(map, prefix + "Distance", this.Distance);
            this.SetParamSimple(map, prefix + "SignalStrength", this.SignalStrength);
            this.SetParamSimple(map, prefix + "LostDay", this.LostDay);
            this.SetParamArraySimple(map, prefix + "TagIDs.", this.TagIDs);
            this.SetParamSimple(map, prefix + "SalePlan", this.SalePlan);
        }
    }
}

