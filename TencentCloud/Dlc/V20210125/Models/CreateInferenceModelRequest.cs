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

    public class CreateInferenceModelRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>模型名称（最长 256）</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>模型类型（如 LLM、Embedding、Reranker、ASR、TTS 等）</p>
        /// </summary>
        [JsonProperty("ModelType")]
        public string ModelType{ get; set; }

        /// <summary>
        /// <p>初始版本号（必填，如 v1、v1.5）</p>
        /// </summary>
        [JsonProperty("InitialVersion")]
        public string InitialVersion{ get; set; }

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
        /// <p>模型参数量（如 7B、1.5B）</p>
        /// </summary>
        [JsonProperty("ParameterSize")]
        public string ParameterSize{ get; set; }

        /// <summary>
        /// <p>模型标签列表</p>
        /// </summary>
        [JsonProperty("Tags")]
        public string[] Tags{ get; set; }

        /// <summary>
        /// <p>模型存储 URI（可选，如 cos://bucket-name/models/name/）</p>
        /// </summary>
        [JsonProperty("StorageUri")]
        public string StorageUri{ get; set; }

        /// <summary>
        /// <p>是否使用用户自带存储桶（默认 false 表示平台托管）</p>
        /// </summary>
        [JsonProperty("UseCustomStorage")]
        public bool? UseCustomStorage{ get; set; }

        /// <summary>
        /// <p>任务类型列表（如 [&quot;Text Generation&quot;, &quot;Embedding&quot;]）</p>
        /// </summary>
        [JsonProperty("Tasks")]
        public string[] Tasks{ get; set; }

        /// <summary>
        /// <p>模型 UID（可选，前端预先生成的 UID，不传则后端自动生成）</p>
        /// </summary>
        [JsonProperty("ModelUid")]
        public string ModelUid{ get; set; }

        /// <summary>
        /// <p>系统标签列表（TagKey-TagValue）</p>
        /// </summary>
        [JsonProperty("ResourceTags")]
        public Tag[] ResourceTags{ get; set; }

        /// <summary>
        /// <p>模型文件来源于goosefs</p>
        /// </summary>
        [JsonProperty("GooseFSConfig")]
        public GooseFSConfig GooseFSConfig{ get; set; }

        /// <summary>
        /// <p>模型上传来源类型</p><p>枚举值：</p><ul><li>Local： 本地上传</li><li>COS： COS上传</li><li>CFS： CFS上传</li><li>CFSTurbo： CFSTurbo上传</li><li>GooseFS： GooseFS上传</li></ul>
        /// </summary>
        [JsonProperty("StorageType")]
        public string StorageType{ get; set; }

        /// <summary>
        /// <p>模型来源标识（如 train-checkpoint=训练 Checkpoint 注册；空=普通上传等无注册元信息链路）</p>
        /// </summary>
        [JsonProperty("ModelSource")]
        public string ModelSource{ get; set; }

        /// <summary>
        /// <p>注册元信息（携带即注册语义：storageUri 为训练产物根，零拷贝引用）</p>
        /// </summary>
        [JsonProperty("RegisterMeta")]
        public RegisterMeta RegisterMeta{ get; set; }

        /// <summary>
        /// <p>产物文件树（可选，仅注册语义下有意义；结构同 GetModelFiles 响应 FileNode）</p>
        /// </summary>
        [JsonProperty("FileList")]
        public FileNode[] FileList{ get; set; }

        /// <summary>
        /// <p>LoRA 基座模型 UID（仅 ModelCategory=LoRA 时有值）</p>
        /// </summary>
        [JsonProperty("BaseModelUid")]
        public string BaseModelUid{ get; set; }

        /// <summary>
        /// <p>LoRA 基座模型版本 UID（仅 ModelCategory=LoRA 且创建时指定了基座版本时有值）</p>
        /// </summary>
        [JsonProperty("BaseModelVersionUid")]
        public string BaseModelVersionUid{ get; set; }

        /// <summary>
        /// <p>模型类别：Base=普通（基座）模型；LoRA=LoRA Adapter 系列（各版本为 Adapter）</p>
        /// </summary>
        [JsonProperty("ModelCategory")]
        public string ModelCategory{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "ModelType", this.ModelType);
            this.SetParamSimple(map, prefix + "InitialVersion", this.InitialVersion);
            this.SetParamSimple(map, prefix + "Provider", this.Provider);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "ParameterSize", this.ParameterSize);
            this.SetParamArraySimple(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "StorageUri", this.StorageUri);
            this.SetParamSimple(map, prefix + "UseCustomStorage", this.UseCustomStorage);
            this.SetParamArraySimple(map, prefix + "Tasks.", this.Tasks);
            this.SetParamSimple(map, prefix + "ModelUid", this.ModelUid);
            this.SetParamArrayObj(map, prefix + "ResourceTags.", this.ResourceTags);
            this.SetParamObj(map, prefix + "GooseFSConfig.", this.GooseFSConfig);
            this.SetParamSimple(map, prefix + "StorageType", this.StorageType);
            this.SetParamSimple(map, prefix + "ModelSource", this.ModelSource);
            this.SetParamObj(map, prefix + "RegisterMeta.", this.RegisterMeta);
            this.SetParamArrayObj(map, prefix + "FileList.", this.FileList);
            this.SetParamSimple(map, prefix + "BaseModelUid", this.BaseModelUid);
            this.SetParamSimple(map, prefix + "BaseModelVersionUid", this.BaseModelVersionUid);
            this.SetParamSimple(map, prefix + "ModelCategory", this.ModelCategory);
        }
    }
}

