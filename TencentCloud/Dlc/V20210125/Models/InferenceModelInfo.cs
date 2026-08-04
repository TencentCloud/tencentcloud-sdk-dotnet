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

    public class InferenceModelInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>Model ID</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ModelId")]
        public string ModelId{ get; set; }

        /// <summary>
        /// <p>模型业务唯一标识</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ModelUid")]
        public string ModelUid{ get; set; }

        /// <summary>
        /// <p>模型名称</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>模型提供方</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Provider")]
        public string Provider{ get; set; }

        /// <summary>
        /// <p>模型描述</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>模型类型</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ModelType")]
        public string ModelType{ get; set; }

        /// <summary>
        /// <p>支持的引擎</p>
        /// </summary>
        [JsonProperty("SupportedEngines")]
        public string[] SupportedEngines{ get; set; }

        /// <summary>
        /// <p>参数量</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ParameterSize")]
        public string ParameterSize{ get; set; }

        /// <summary>
        /// <p>模型标签</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Tags")]
        public string[] Tags{ get; set; }

        /// <summary>
        /// <p>最新版本号</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LatestVersion")]
        public string LatestVersion{ get; set; }

        /// <summary>
        /// <p>版本总数</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VersionCount")]
        public long? VersionCount{ get; set; }

        /// <summary>
        /// <p>关联的推理服务数量</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ServiceCount")]
        public long? ServiceCount{ get; set; }

        /// <summary>
        /// <p>是否有存储（内置模型和用户上传模型均为 true）</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HasStorage")]
        public bool? HasStorage{ get; set; }

        /// <summary>
        /// <p>存储地域</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StorageRegion")]
        public string StorageRegion{ get; set; }

        /// <summary>
        /// <p>是否使用用户自带存储桶</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HasCustomStorage")]
        public bool? HasCustomStorage{ get; set; }

        /// <summary>
        /// <p>存储后端类型（如 COS、GOOSEFS、CFSTURBO）</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StorageType")]
        public string StorageType{ get; set; }

        /// <summary>
        /// <p>是否是内置模型</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BuiltIn")]
        public bool? BuiltIn{ get; set; }

        /// <summary>
        /// <p>任务类型列表</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Tasks")]
        public string[] Tasks{ get; set; }

        /// <summary>
        /// <p>云账户的 APP ID</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AppId")]
        public long? AppId{ get; set; }

        /// <summary>
        /// <p>云账户的 UIN</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Uin")]
        public string Uin{ get; set; }

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
        /// <p>云账户的 Sub UIN</p>
        /// </summary>
        [JsonProperty("SubAccountUin")]
        public string SubAccountUin{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ModelId", this.ModelId);
            this.SetParamSimple(map, prefix + "ModelUid", this.ModelUid);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Provider", this.Provider);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "ModelType", this.ModelType);
            this.SetParamArraySimple(map, prefix + "SupportedEngines.", this.SupportedEngines);
            this.SetParamSimple(map, prefix + "ParameterSize", this.ParameterSize);
            this.SetParamArraySimple(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "LatestVersion", this.LatestVersion);
            this.SetParamSimple(map, prefix + "VersionCount", this.VersionCount);
            this.SetParamSimple(map, prefix + "ServiceCount", this.ServiceCount);
            this.SetParamSimple(map, prefix + "HasStorage", this.HasStorage);
            this.SetParamSimple(map, prefix + "StorageRegion", this.StorageRegion);
            this.SetParamSimple(map, prefix + "HasCustomStorage", this.HasCustomStorage);
            this.SetParamSimple(map, prefix + "StorageType", this.StorageType);
            this.SetParamSimple(map, prefix + "BuiltIn", this.BuiltIn);
            this.SetParamArraySimple(map, prefix + "Tasks.", this.Tasks);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "Uin", this.Uin);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "SubAccountUin", this.SubAccountUin);
        }
    }
}

