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

namespace TencentCloud.Bdrc.V20260330.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DiskCopyPairForCvm : AbstractModel
    {
        
        /// <summary>
        /// 云硬盘复制对ID
        /// </summary>
        [JsonProperty("CopyPairId")]
        public string CopyPairId{ get; set; }

        /// <summary>
        /// 云硬盘复制对名称
        /// </summary>
        [JsonProperty("CopyPairName")]
        public string CopyPairName{ get; set; }

        /// <summary>
        /// 生产端云硬盘ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SourceResourceId")]
        public string SourceResourceId{ get; set; }

        /// <summary>
        /// 容灾端云硬盘ID（延迟创建模式且 CVM 未真实创建时被脱敏为空字符串）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TargetResourceId")]
        public string TargetResourceId{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CopyPairId", this.CopyPairId);
            this.SetParamSimple(map, prefix + "CopyPairName", this.CopyPairName);
            this.SetParamSimple(map, prefix + "SourceResourceId", this.SourceResourceId);
            this.SetParamSimple(map, prefix + "TargetResourceId", this.TargetResourceId);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
        }
    }
}

