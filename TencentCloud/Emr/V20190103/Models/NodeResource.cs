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

namespace TencentCloud.Emr.V20190103.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class NodeResource : AbstractModel
    {
        
        /// <summary>
        /// <p>配置Id</p>
        /// </summary>
        [JsonProperty("ResourceConfigId")]
        public ulong? ResourceConfigId{ get; set; }

        /// <summary>
        /// <p>Resource</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Resource")]
        public Resource Resource{ get; set; }

        /// <summary>
        /// <p>创建时间</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// <p>更新时间</p>
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// <p>是否默认配置,DEFAULT,BACKUP</p>
        /// </summary>
        [JsonProperty("IsDefault")]
        public string IsDefault{ get; set; }

        /// <summary>
        /// <p>该类型剩余</p>
        /// </summary>
        [JsonProperty("MaxResourceNum")]
        public ulong? MaxResourceNum{ get; set; }

        /// <summary>
        /// <p>支持的包销时长</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PrepaidUnderwritePeriods")]
        public long?[] PrepaidUnderwritePeriods{ get; set; }

        /// <summary>
        /// <p>配额数量</p>
        /// </summary>
        [JsonProperty("QuotaNum")]
        public long? QuotaNum{ get; set; }

        /// <summary>
        /// <p>配额单位</p>
        /// </summary>
        [JsonProperty("QuotaUnit")]
        public string QuotaUnit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ResourceConfigId", this.ResourceConfigId);
            this.SetParamObj(map, prefix + "Resource.", this.Resource);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "IsDefault", this.IsDefault);
            this.SetParamSimple(map, prefix + "MaxResourceNum", this.MaxResourceNum);
            this.SetParamArraySimple(map, prefix + "PrepaidUnderwritePeriods.", this.PrepaidUnderwritePeriods);
            this.SetParamSimple(map, prefix + "QuotaNum", this.QuotaNum);
            this.SetParamSimple(map, prefix + "QuotaUnit", this.QuotaUnit);
        }
    }
}

