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

namespace TencentCloud.Tione.V20211111.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MaterialInfo : AbstractModel
    {
        
        /// <summary>
        /// 存储类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StorageType")]
        public string StorageType{ get; set; }

        /// <summary>
        /// Cos存储信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CosPathInfo")]
        public CosPathInfo CosPathInfo{ get; set; }

        /// <summary>
        /// 物料名，支持Code、Model
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MaterialName")]
        public string MaterialName{ get; set; }

        /// <summary>
        /// 物料类型，支持PreSet(预置)、 Custom(自定义)
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MaterialType")]
        public string MaterialType{ get; set; }

        /// <summary>
        /// 训练任务挂载路径
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MountPath")]
        public string MountPath{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StorageType", this.StorageType);
            this.SetParamObj(map, prefix + "CosPathInfo.", this.CosPathInfo);
            this.SetParamSimple(map, prefix + "MaterialName", this.MaterialName);
            this.SetParamSimple(map, prefix + "MaterialType", this.MaterialType);
            this.SetParamSimple(map, prefix + "MountPath", this.MountPath);
        }
    }
}

