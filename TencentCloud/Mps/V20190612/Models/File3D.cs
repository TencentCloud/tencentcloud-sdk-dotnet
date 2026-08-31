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

namespace TencentCloud.Mps.V20190612.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class File3D : AbstractModel
    {
        
        /// <summary>
        /// <p>文件类型，OBJ / GLB / FBX / STL / USDZ</p><p>枚举值：</p><ul><li>OBJ： 3D 通用交换格式</li><li>GLB： glTF 2.0 二进制（&quot;3D 界的 JPEG&quot;）</li><li>FBX： Autodesk 影视/游戏工业标准</li><li>STL： 3D 打印/CAD 三角面片</li><li>USDZ： Pixar/Apple 打包场景描述</li></ul>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// <p>文件下载 URL（临时签名，TTL 一般 24h）</p>
        /// </summary>
        [JsonProperty("Url")]
        public string Url{ get; set; }

        /// <summary>
        /// <p>预览图 URL（若有）</p>
        /// </summary>
        [JsonProperty("PreviewImageUrl")]
        public string PreviewImageUrl{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Url", this.Url);
            this.SetParamSimple(map, prefix + "PreviewImageUrl", this.PreviewImageUrl);
        }
    }
}

