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

    public class GetInferenceModelResponse : AbstractModel
    {
        
        /// <summary>
        /// <p>模型ID</p>
        /// </summary>
        [JsonProperty("ModelId")]
        public string ModelId{ get; set; }

        /// <summary>
        /// <p>模型UID</p>
        /// </summary>
        [JsonProperty("ModelUid")]
        public string ModelUid{ get; set; }

        /// <summary>
        /// <p>模型名称</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>模型提供方</p>
        /// </summary>
        [JsonProperty("Provider")]
        public string Provider{ get; set; }

        /// <summary>
        /// <p>模型描述</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>模型类型</p>
        /// </summary>
        [JsonProperty("ModelType")]
        public string ModelType{ get; set; }

        /// <summary>
        /// <p>模型参数量</p>
        /// </summary>
        [JsonProperty("ParameterSize")]
        public string ParameterSize{ get; set; }

        /// <summary>
        /// <p>模型标签列表</p>
        /// </summary>
        [JsonProperty("Tags")]
        public string[] Tags{ get; set; }

        /// <summary>
        /// <p>最新版本号</p>
        /// </summary>
        [JsonProperty("LatestVersion")]
        public string LatestVersion{ get; set; }

        /// <summary>
        /// <p>版本总数</p>
        /// </summary>
        [JsonProperty("VersionCount")]
        public long? VersionCount{ get; set; }

        /// <summary>
        /// <p>关联的推理服务数量</p>
        /// </summary>
        [JsonProperty("ServiceCount")]
        public long? ServiceCount{ get; set; }

        /// <summary>
        /// <p>是否有存储</p>
        /// </summary>
        [JsonProperty("HasStorage")]
        public bool? HasStorage{ get; set; }

        /// <summary>
        /// <p>存储地域</p>
        /// </summary>
        [JsonProperty("StorageRegion")]
        public string StorageRegion{ get; set; }

        /// <summary>
        /// <p>是否使用用户自带存储桶</p>
        /// </summary>
        [JsonProperty("HasCustomStorage")]
        public bool? HasCustomStorage{ get; set; }

        /// <summary>
        /// <p>存储后端类型</p>
        /// </summary>
        [JsonProperty("StorageType")]
        public string StorageType{ get; set; }

        /// <summary>
        /// <p>是否内置模型</p>
        /// </summary>
        [JsonProperty("BuiltIn")]
        public bool? BuiltIn{ get; set; }

        /// <summary>
        /// <p>任务类型列表</p>
        /// </summary>
        [JsonProperty("Tasks")]
        public string[] Tasks{ get; set; }

        /// <summary>
        /// <p>模型支持的推理引擎列表</p>
        /// </summary>
        [JsonProperty("SupportedEngines")]
        public string[] SupportedEngines{ get; set; }

        /// <summary>
        /// <p>UIN</p>
        /// </summary>
        [JsonProperty("Uin")]
        public string Uin{ get; set; }

        /// <summary>
        /// <p>APPID</p>
        /// </summary>
        [JsonProperty("AppId")]
        public long? AppId{ get; set; }

        /// <summary>
        /// <p>创建时间</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public long? CreateTime{ get; set; }

        /// <summary>
        /// <p>更新时间</p>
        /// </summary>
        [JsonProperty("UpdateTime")]
        public long? UpdateTime{ get; set; }

        /// <summary>
        /// <p>Sub UIN</p>
        /// </summary>
        [JsonProperty("SubAccountUin")]
        public string SubAccountUin{ get; set; }

        /// <summary>
        /// <p>系统标签列表（TagKey-TagValue）</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ResourceTags")]
        public Tag[] ResourceTags{ get; set; }

        /// <summary>
        /// <p>模型类别：Base=普通（基座）模型；LoRA=LoRA Adapter 系列（各版本为 Adapter）</p>
        /// </summary>
        [JsonProperty("ModelCategory")]
        public string ModelCategory{ get; set; }

        /// <summary>
        /// <p>LoRA 基座模型 UID（仅 ModelCategory=LoRA 时有值）</p>
        /// </summary>
        [JsonProperty("BaseModelUid")]
        public string BaseModelUid{ get; set; }

        /// <summary>
        /// <p>最新版本的全局唯一标识（VersionUid）。CreateInferenceModel 返回时即初始版本的 VersionUid</p>
        /// </summary>
        [JsonProperty("LatestVersionUid")]
        public string LatestVersionUid{ get; set; }

        /// <summary>
        /// <p>LoRA 基座模型版本 UID（仅 ModelCategory=LoRA 且创建时指定了基座版本时有值）</p>
        /// </summary>
        [JsonProperty("BaseModelVersionUid")]
        public string BaseModelVersionUid{ get; set; }

        /// <summary>
        /// <p>LoRA 基座模型名称（仅 ModelCategory=LoRA 且基座存在时有值；列表展示「基座模型及版本」用）</p>
        /// </summary>
        [JsonProperty("BaseModelName")]
        public string BaseModelName{ get; set; }

        /// <summary>
        /// <p>LoRA 基座模型版本号（如 v2；仅 ModelCategory=LoRA 且创建时指定了基座版本时有值）</p>
        /// </summary>
        [JsonProperty("BaseModelVersion")]
        public string BaseModelVersion{ get; set; }

        /// <summary>
        /// <p>模型来源标识（如 train-checkpoint=训练 Checkpoint 注册；空=普通上传等无注册元信息链路）</p>
        /// </summary>
        [JsonProperty("ModelSource")]
        public string ModelSource{ get; set; }

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
            this.SetParamSimple(map, prefix + "ModelId", this.ModelId);
            this.SetParamSimple(map, prefix + "ModelUid", this.ModelUid);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Provider", this.Provider);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "ModelType", this.ModelType);
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
            this.SetParamArraySimple(map, prefix + "SupportedEngines.", this.SupportedEngines);
            this.SetParamSimple(map, prefix + "Uin", this.Uin);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "SubAccountUin", this.SubAccountUin);
            this.SetParamArrayObj(map, prefix + "ResourceTags.", this.ResourceTags);
            this.SetParamSimple(map, prefix + "ModelCategory", this.ModelCategory);
            this.SetParamSimple(map, prefix + "BaseModelUid", this.BaseModelUid);
            this.SetParamSimple(map, prefix + "LatestVersionUid", this.LatestVersionUid);
            this.SetParamSimple(map, prefix + "BaseModelVersionUid", this.BaseModelVersionUid);
            this.SetParamSimple(map, prefix + "BaseModelName", this.BaseModelName);
            this.SetParamSimple(map, prefix + "BaseModelVersion", this.BaseModelVersion);
            this.SetParamSimple(map, prefix + "ModelSource", this.ModelSource);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

