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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class BaselineItem : AbstractModel
    {
        
        /// <summary>
        /// 项Id
        /// </summary>
        [JsonProperty("ItemId")]
        public long? ItemId{ get; set; }

        /// <summary>
        /// 项名称
        /// </summary>
        [JsonProperty("ItemName")]
        public string ItemName{ get; set; }

        /// <summary>
        /// 检测项分类
        /// </summary>
        [JsonProperty("CategoryId")]
        public long? CategoryId{ get; set; }

        /// <summary>
        /// 项描述
        /// </summary>
        [JsonProperty("ItemDesc")]
        public string ItemDesc{ get; set; }

        /// <summary>
        /// 修复方法
        /// </summary>
        [JsonProperty("FixMethod")]
        public string FixMethod{ get; set; }

        /// <summary>
        /// 所属规则
        /// </summary>
        [JsonProperty("RuleName")]
        public string RuleName{ get; set; }

        /// <summary>
        /// 检测结果描述
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DetectResultDesc")]
        public string DetectResultDesc{ get; set; }

        /// <summary>
        /// 危险等级
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Level")]
        public long? Level{ get; set; }

        /// <summary>
        /// 检测状态：0 未通过，1：忽略，3：通过，5：检测中
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DetectStatus")]
        public long? DetectStatus{ get; set; }

        /// <summary>
        /// 主机ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HostId")]
        public string HostId{ get; set; }

        /// <summary>
        /// 主机名
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HostName")]
        public string HostName{ get; set; }

        /// <summary>
        /// 主机IP
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HostIp")]
        public string HostIp{ get; set; }

        /// <summary>
        /// 外网IP
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("WanIp")]
        public string WanIp{ get; set; }

        /// <summary>
        /// 第一次出现时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FirstTime")]
        public string FirstTime{ get; set; }

        /// <summary>
        /// 最近出现时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LastTime")]
        public string LastTime{ get; set; }

        /// <summary>
        /// 是否可以修复
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CanBeFixed")]
        public long? CanBeFixed{ get; set; }

        /// <summary>
        /// 主机安全uuid
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Uuid")]
        public string Uuid{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ItemId", this.ItemId);
            this.SetParamSimple(map, prefix + "ItemName", this.ItemName);
            this.SetParamSimple(map, prefix + "CategoryId", this.CategoryId);
            this.SetParamSimple(map, prefix + "ItemDesc", this.ItemDesc);
            this.SetParamSimple(map, prefix + "FixMethod", this.FixMethod);
            this.SetParamSimple(map, prefix + "RuleName", this.RuleName);
            this.SetParamSimple(map, prefix + "DetectResultDesc", this.DetectResultDesc);
            this.SetParamSimple(map, prefix + "Level", this.Level);
            this.SetParamSimple(map, prefix + "DetectStatus", this.DetectStatus);
            this.SetParamSimple(map, prefix + "HostId", this.HostId);
            this.SetParamSimple(map, prefix + "HostName", this.HostName);
            this.SetParamSimple(map, prefix + "HostIp", this.HostIp);
            this.SetParamSimple(map, prefix + "WanIp", this.WanIp);
            this.SetParamSimple(map, prefix + "FirstTime", this.FirstTime);
            this.SetParamSimple(map, prefix + "LastTime", this.LastTime);
            this.SetParamSimple(map, prefix + "CanBeFixed", this.CanBeFixed);
            this.SetParamSimple(map, prefix + "Uuid", this.Uuid);
        }
    }
}

