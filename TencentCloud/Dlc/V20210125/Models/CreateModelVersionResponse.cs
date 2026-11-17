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

namespace TencentCloud.Dlc.V20210125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateModelVersionResponse : AbstractModel
    {
        
        /// <summary>
        /// <p>版本ID</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VersionId")]
        public string VersionId{ get; set; }

        /// <summary>
        /// <p>关联的模型ID</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ModelId")]
        public string ModelId{ get; set; }

        /// <summary>
        /// <p>该版本的存储 URI</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StorageUri")]
        public string StorageUri{ get; set; }

        /// <summary>
        /// <p>版本说明</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>创建时间（毫秒时间戳）</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CreateTime")]
        public long? CreateTime{ get; set; }

        /// <summary>
        /// <p>更新时间（毫秒时间戳）</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UpdateTime")]
        public long? UpdateTime{ get; set; }

        /// <summary>
        /// <p>关联的推理服务列表</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LinkedServices")]
        public LinkedServiceInfo[] LinkedServices{ get; set; }

        /// <summary>
        /// <p>模型版本号</p>
        /// </summary>
        [JsonProperty("Version")]
        public string Version{ get; set; }

        /// <summary>
        /// <p>是否使用用户自带存储桶（true=用户自带桶，false=平台托管）</p>
        /// </summary>
        [JsonProperty("UseCustomStorage")]
        public bool? UseCustomStorage{ get; set; }

        /// <summary>
        /// <p>注册元信息（仅注册语义创建的版本有值，与创建请求 RegisterMeta 结构一致）</p>
        /// </summary>
        [JsonProperty("RegisterMeta")]
        public RegisterMeta RegisterMeta{ get; set; }

        /// <summary>
        /// <p>版本业务唯一标识；LoRA 模型版本挂载到部署时以此引用</p>
        /// </summary>
        [JsonProperty("VersionUid")]
        public string VersionUid{ get; set; }

        /// <summary>
        /// <p>LoRA Adapter 元信息（仅 LoRA 模型版本有值，解析自 adapter_config.json）</p>
        /// </summary>
        [JsonProperty("LoraMeta")]
        public LoraVersionMeta LoraMeta{ get; set; }

        /// <summary>
        /// <p>LoRA pool 异步导入状态（Importing/Ready/Failed；NULL=就绪），未就绪不能挂载</p>
        /// </summary>
        [JsonProperty("PoolImportStatus")]
        public string PoolImportStatus{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "VersionId", this.VersionId);
            this.SetParamSimple(map, prefix + "ModelId", this.ModelId);
            this.SetParamSimple(map, prefix + "StorageUri", this.StorageUri);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamArrayObj(map, prefix + "LinkedServices.", this.LinkedServices);
            this.SetParamSimple(map, prefix + "Version", this.Version);
            this.SetParamSimple(map, prefix + "UseCustomStorage", this.UseCustomStorage);
            this.SetParamObj(map, prefix + "RegisterMeta.", this.RegisterMeta);
            this.SetParamSimple(map, prefix + "VersionUid", this.VersionUid);
            this.SetParamObj(map, prefix + "LoraMeta.", this.LoraMeta);
            this.SetParamSimple(map, prefix + "PoolImportStatus", this.PoolImportStatus);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

