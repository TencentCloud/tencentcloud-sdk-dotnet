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

namespace TencentCloud.Ags.V20250920.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UpdateSandboxInstanceRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>沙箱实例ID</p>
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 手动设置实例还需运行多久，如 5m、300s、1h。未传入时保持原设置；传入后从本次设置开始重新计时。仅正在运行、且未设置为永久运行的实例可修改。修改时不会缩短已获得的自动续期时间。
        /// </summary>
        [JsonProperty("Timeout")]
        public string Timeout{ get; set; }

        /// <summary>
        /// 实例元数据。
        /// </summary>
        [JsonProperty("Metadata")]
        public MetadataVar[] Metadata{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "Timeout", this.Timeout);
            this.SetParamArrayObj(map, prefix + "Metadata.", this.Metadata);
        }
    }
}

