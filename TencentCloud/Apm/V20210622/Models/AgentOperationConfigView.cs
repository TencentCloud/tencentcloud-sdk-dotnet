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

namespace TencentCloud.Apm.V20210622.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AgentOperationConfigView : AbstractModel
    {
        
        /// <summary>
        /// 当前接口配置是否开启了接口白名单配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RetentionValid")]
        public bool? RetentionValid{ get; set; }

        /// <summary>
        /// RetentionValid为false时生效，接口配置中的黑名单配置，配置中的接口不采集
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IgnoreOperation")]
        public string IgnoreOperation{ get; set; }

        /// <summary>
        /// RetentionValid为true时生效，接口配置中的白名单配置，仅采集配置中的接口
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RetentionOperation")]
        public string RetentionOperation{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RetentionValid", this.RetentionValid);
            this.SetParamSimple(map, prefix + "IgnoreOperation", this.IgnoreOperation);
            this.SetParamSimple(map, prefix + "RetentionOperation", this.RetentionOperation);
        }
    }
}

