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

namespace TencentCloud.Solar.V20181011.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ActivityInfo : AbstractModel
    {
        
        /// <summary>
        /// 活动使用模板id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TemplateId")]
        public string TemplateId{ get; set; }

        /// <summary>
        /// 活动标题
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ActivityTitle")]
        public string ActivityTitle{ get; set; }

        /// <summary>
        /// 活动描述
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ActivityDesc")]
        public string ActivityDesc{ get; set; }

        /// <summary>
        /// 活动封面地址
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ActivityCover")]
        public string ActivityCover{ get; set; }

        /// <summary>
        /// 活动类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ActivityType")]
        public string ActivityType{ get; set; }

        /// <summary>
        /// 活动id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ActivityId")]
        public string ActivityId{ get; set; }

        /// <summary>
        /// 活动模板自定义配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PersonalConfig")]
        public string PersonalConfig{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TemplateId", this.TemplateId);
            this.SetParamSimple(map, prefix + "ActivityTitle", this.ActivityTitle);
            this.SetParamSimple(map, prefix + "ActivityDesc", this.ActivityDesc);
            this.SetParamSimple(map, prefix + "ActivityCover", this.ActivityCover);
            this.SetParamSimple(map, prefix + "ActivityType", this.ActivityType);
            this.SetParamSimple(map, prefix + "ActivityId", this.ActivityId);
            this.SetParamSimple(map, prefix + "PersonalConfig", this.PersonalConfig);
        }
    }
}

