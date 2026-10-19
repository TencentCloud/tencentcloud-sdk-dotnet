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

    public class CreateNotebookImageRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>镜像信息</p>
        /// </summary>
        [JsonProperty("ImageInfo")]
        public ImageInfo ImageInfo{ get; set; }

        /// <summary>
        /// <p>notebook id</p>
        /// </summary>
        [JsonProperty("NotebookId")]
        public string NotebookId{ get; set; }

        /// <summary>
        /// <p>TI工作空间ID</p><p>使用非默认空间必须填写工作空间ID，使用默认空间无需填写工作空间ID。</p>
        /// </summary>
        [JsonProperty("TiProjectId")]
        public string TiProjectId{ get; set; }

        /// <summary>
        /// <p>要保存的kernel数组</p>
        /// </summary>
        [JsonProperty("Kernels")]
        public string[] Kernels{ get; set; }

        /// <summary>
        /// <p>是否保存到镜像中心</p>
        /// </summary>
        [JsonProperty("RegisterToImageCenter")]
        public bool? RegisterToImageCenter{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "ImageInfo.", this.ImageInfo);
            this.SetParamSimple(map, prefix + "NotebookId", this.NotebookId);
            this.SetParamSimple(map, prefix + "TiProjectId", this.TiProjectId);
            this.SetParamArraySimple(map, prefix + "Kernels.", this.Kernels);
            this.SetParamSimple(map, prefix + "RegisterToImageCenter", this.RegisterToImageCenter);
        }
    }
}

