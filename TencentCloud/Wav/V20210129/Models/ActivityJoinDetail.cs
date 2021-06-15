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

namespace TencentCloud.Wav.V20210129.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ActivityJoinDetail : AbstractModel
    {
        
        /// <summary>
        /// 活动id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ActivityId")]
        public long? ActivityId{ get; set; }

        /// <summary>
        /// 活动名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ActivityName")]
        public string ActivityName{ get; set; }

        /// <summary>
        /// 销售姓名
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SalesName")]
        public string SalesName{ get; set; }

        /// <summary>
        /// 销售电话
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SalesPhone")]
        public string SalesPhone{ get; set; }

        /// <summary>
        /// 参与id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("JoinId")]
        public long? JoinId{ get; set; }

        /// <summary>
        /// 活码id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LiveCodeId")]
        public long? LiveCodeId{ get; set; }

        /// <summary>
        /// 用户电话
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UserPhone")]
        public string UserPhone{ get; set; }

        /// <summary>
        /// 用户姓名
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UserName")]
        public string UserName{ get; set; }

        /// <summary>
        /// 活动数据
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ActivityData")]
        public string ActivityData{ get; set; }

        /// <summary>
        /// 线索id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LeadId")]
        public long? LeadId{ get; set; }

        /// <summary>
        /// 参与时间戳，单位：秒
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("JoinTime")]
        public long? JoinTime{ get; set; }

        /// <summary>
        /// 线索是否是重复创建， 0 ：新建、 1：合并、 2：重复， 默认为0
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Duplicate")]
        public long? Duplicate{ get; set; }

        /// <summary>
        /// 重复线索id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DuplicateLeadId")]
        public long? DuplicateLeadId{ get; set; }

        /// <summary>
        /// 是否为参与多次活动， 1：参与一次、2、参与多次，默认为0
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("JoinState")]
        public long? JoinState{ get; set; }

        /// <summary>
        /// 创建时间戳，单位：秒
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CreateTime")]
        public long? CreateTime{ get; set; }

        /// <summary>
        /// 更新时间戳，单位：秒
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UpdateTime")]
        public long? UpdateTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ActivityId", this.ActivityId);
            this.SetParamSimple(map, prefix + "ActivityName", this.ActivityName);
            this.SetParamSimple(map, prefix + "SalesName", this.SalesName);
            this.SetParamSimple(map, prefix + "SalesPhone", this.SalesPhone);
            this.SetParamSimple(map, prefix + "JoinId", this.JoinId);
            this.SetParamSimple(map, prefix + "LiveCodeId", this.LiveCodeId);
            this.SetParamSimple(map, prefix + "UserPhone", this.UserPhone);
            this.SetParamSimple(map, prefix + "UserName", this.UserName);
            this.SetParamSimple(map, prefix + "ActivityData", this.ActivityData);
            this.SetParamSimple(map, prefix + "LeadId", this.LeadId);
            this.SetParamSimple(map, prefix + "JoinTime", this.JoinTime);
            this.SetParamSimple(map, prefix + "Duplicate", this.Duplicate);
            this.SetParamSimple(map, prefix + "DuplicateLeadId", this.DuplicateLeadId);
            this.SetParamSimple(map, prefix + "JoinState", this.JoinState);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
        }
    }
}

