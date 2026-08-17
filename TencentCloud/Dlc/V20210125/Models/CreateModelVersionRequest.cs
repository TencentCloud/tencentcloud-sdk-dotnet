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

    public class CreateModelVersionRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>模型UID</p>
        /// </summary>
        [JsonProperty("ModelUid")]
        public string ModelUid{ get; set; }

        /// <summary>
        /// <p>模型版本号</p>
        /// </summary>
        [JsonProperty("ModelVersion")]
        public string ModelVersion{ get; set; }

        /// <summary>
        /// <p>版本说明</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>该版本的存储 URI（可选，如 cos://bucket-name/models/name/v2/）</p>
        /// </summary>
        [JsonProperty("StorageUri")]
        public string StorageUri{ get; set; }

        /// <summary>
        /// <p>是否使用用户自带存储桶（默认 false 表示平台托管）</p>
        /// </summary>
        [JsonProperty("UseCustomStorage")]
        public bool? UseCustomStorage{ get; set; }

        /// <summary>
        /// <p>创建模型时，模型从goosfe里面选取，则需要传递该参数</p>
        /// </summary>
        [JsonProperty("GooseFSConfig")]
        public GooseFSConfig GooseFSConfig{ get; set; }

        /// <summary>
        /// <p>模型上传路径类型</p><p>枚举值：</p><ul><li>LOCAL： 本地上传</li><li>CFS： CFS上传</li><li>COS： COS上传</li><li>CFSTurbo： CFSTurbo上传</li><li>GooseFS： GooseFS上传</li></ul><p>选择cos、cfs、cfstrubo则必须要传storageuri，选择local时不能传递goosefsconfig</p>
        /// </summary>
        [JsonProperty("StorageType")]
        public string StorageType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ModelUid", this.ModelUid);
            this.SetParamSimple(map, prefix + "ModelVersion", this.ModelVersion);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "StorageUri", this.StorageUri);
            this.SetParamSimple(map, prefix + "UseCustomStorage", this.UseCustomStorage);
            this.SetParamObj(map, prefix + "GooseFSConfig.", this.GooseFSConfig);
            this.SetParamSimple(map, prefix + "StorageType", this.StorageType);
        }
    }
}

