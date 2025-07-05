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

namespace TencentCloud.Wav.V20210129.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class LicenseInfo : AbstractModel
    {
        
        /// <summary>
        /// license编号
        /// </summary>
        [JsonProperty("License")]
        public string License{ get; set; }

        /// <summary>
        /// license版本；1-基础版，2-标准版，3-增值版
        /// </summary>
        [JsonProperty("LicenseEdition")]
        public long? LicenseEdition{ get; set; }

        /// <summary>
        /// 生效开始时间, 格式yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonProperty("ResourceStartTime")]
        public string ResourceStartTime{ get; set; }

        /// <summary>
        /// 生效结束时间, 格式yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonProperty("ResourceEndTime")]
        public string ResourceEndTime{ get; set; }

        /// <summary>
        /// 隔离截止时间, 格式yyyy-MM-dd HH:mm:ss
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsolationDeadline")]
        public string IsolationDeadline{ get; set; }

        /// <summary>
        /// 资源计划销毁时间, 格式yyyy-MM-dd HH:mm:ss
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DestroyTime")]
        public string DestroyTime{ get; set; }

        /// <summary>
        /// 资源状态，1.正常，2.隔离，3.销毁
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 扩展信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Extra")]
        public string Extra{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "License", this.License);
            this.SetParamSimple(map, prefix + "LicenseEdition", this.LicenseEdition);
            this.SetParamSimple(map, prefix + "ResourceStartTime", this.ResourceStartTime);
            this.SetParamSimple(map, prefix + "ResourceEndTime", this.ResourceEndTime);
            this.SetParamSimple(map, prefix + "IsolationDeadline", this.IsolationDeadline);
            this.SetParamSimple(map, prefix + "DestroyTime", this.DestroyTime);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Extra", this.Extra);
        }
    }
}

