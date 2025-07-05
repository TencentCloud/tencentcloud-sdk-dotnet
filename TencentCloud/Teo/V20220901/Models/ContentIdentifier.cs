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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ContentIdentifier : AbstractModel
    {
        
        /// <summary>
        /// 内容标识符 ID。
        /// </summary>
        [JsonProperty("ContentId")]
        public string ContentId{ get; set; }

        /// <summary>
        /// 内容标识符描述。
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 被规则引擎引用的次数。
        /// </summary>
        [JsonProperty("ReferenceCount")]
        public long? ReferenceCount{ get; set; }

        /// <summary>
        /// 绑定的套餐 ID。
        /// </summary>
        [JsonProperty("PlanId")]
        public string PlanId{ get; set; }

        /// <summary>
        /// 绑定的标签。
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// 内容标识符状态，取值有：
        /// <li> active：已生效； </li>
        /// <li> deleted：已删除。</li>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 创建时间，时间为世界标准时间（UTC）， 遵循 ISO 8601 标准的日期和时间格式。
        /// </summary>
        [JsonProperty("CreatedOn")]
        public string CreatedOn{ get; set; }

        /// <summary>
        /// 最新一次更新时间，时间为世界标准时间（UTC）， 遵循 ISO 8601 标准的日期和时间格式。
        /// </summary>
        [JsonProperty("ModifiedOn")]
        public string ModifiedOn{ get; set; }

        /// <summary>
        /// 删除时间，状态非 deleted 时候为空；时间为世界标准时间（UTC）， 遵循 ISO 8601 标准的日期和时间格式。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DeletedOn")]
        public string DeletedOn{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ContentId", this.ContentId);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "ReferenceCount", this.ReferenceCount);
            this.SetParamSimple(map, prefix + "PlanId", this.PlanId);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "CreatedOn", this.CreatedOn);
            this.SetParamSimple(map, prefix + "ModifiedOn", this.ModifiedOn);
            this.SetParamSimple(map, prefix + "DeletedOn", this.DeletedOn);
        }
    }
}

