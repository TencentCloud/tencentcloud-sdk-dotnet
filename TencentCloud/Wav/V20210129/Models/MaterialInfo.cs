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

    public class MaterialInfo : AbstractModel
    {
        
        /// <summary>
        /// 素材id
        /// </summary>
        [JsonProperty("MaterialId")]
        public ulong? MaterialId{ get; set; }

        /// <summary>
        /// 素材名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MaterialName")]
        public string MaterialName{ get; set; }

        /// <summary>
        /// 素材状态, -1: 删除 0: 启用 1: 禁用
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MaterialId", this.MaterialId);
            this.SetParamSimple(map, prefix + "MaterialName", this.MaterialName);
            this.SetParamSimple(map, prefix + "Status", this.Status);
        }
    }
}

