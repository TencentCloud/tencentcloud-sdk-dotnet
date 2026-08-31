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

    public class SubmitHunyuan3DTaskRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>文生 3D 的提示词</p><p>入参限制：最长 1024 utf-8 字符</p>
        /// </summary>
        [JsonProperty("Prompt")]
        public string Prompt{ get; set; }

        /// <summary>
        /// <p>图生 3D 的图片 URL（http/https）</p>
        /// </summary>
        [JsonProperty("ImageUrl")]
        public string ImageUrl{ get; set; }

        /// <summary>
        /// <p>多视角图生 3D，至少 2 张，且必须包含 front 视角</p>
        /// </summary>
        [JsonProperty("MultiViewImages")]
        public ViewImage[] MultiViewImages{ get; set; }

        /// <summary>
        /// <p>生成类型</p><p>枚举值：</p><ul><li>Normal： 生成完整 3D 资产（几何 + 纹理）</li><li>Geometry： 只生成几何体（无纹理，输出速度更快）</li><li>Texture： 只生成纹理（需要传 MeshUrl）</li></ul><p>默认值：Normal</p>
        /// </summary>
        [JsonProperty("GenerateType")]
        public string GenerateType{ get; set; }

        /// <summary>
        /// <p>已有 3D 模型的 URL（仅支持 .glb / .obj）。传了 MeshUrl → 强制 GenerateType=Texture（贴纹理场景）</p>
        /// </summary>
        [JsonProperty("MeshUrl")]
        public string MeshUrl{ get; set; }

        /// <summary>
        /// <p>是否输出 PBR 材质</p><p>默认值：false</p>
        /// </summary>
        [JsonProperty("EnablePBR")]
        public bool? EnablePBR{ get; set; }

        /// <summary>
        /// <p>面片数，范围 [3000, 1500000]。仅 Normal / Geometry 分支生效</p><p>取值范围：[3000, 1500000]</p><p>默认值：500000</p>
        /// </summary>
        [JsonProperty("FaceCount")]
        public ulong? FaceCount{ get; set; }

        /// <summary>
        /// <p>是否保留 UV 展开</p><p>默认值：false</p>
        /// </summary>
        [JsonProperty("KeepUV")]
        public bool? KeepUV{ get; set; }

        /// <summary>
        /// <p>除默认返回的 obj + glb 外，附加输出的一种格式。当前仅支持 FBX</p>
        /// </summary>
        [JsonProperty("ResultFormat")]
        public string ResultFormat{ get; set; }

        /// <summary>
        /// <p>随机种子，同一 Seed 输入下结果可复现</p>
        /// </summary>
        [JsonProperty("Seed")]
        public ulong? Seed{ get; set; }

        /// <summary>
        /// <p>风格控制词</p>
        /// </summary>
        [JsonProperty("Style")]
        public string Style{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Prompt", this.Prompt);
            this.SetParamSimple(map, prefix + "ImageUrl", this.ImageUrl);
            this.SetParamArrayObj(map, prefix + "MultiViewImages.", this.MultiViewImages);
            this.SetParamSimple(map, prefix + "GenerateType", this.GenerateType);
            this.SetParamSimple(map, prefix + "MeshUrl", this.MeshUrl);
            this.SetParamSimple(map, prefix + "EnablePBR", this.EnablePBR);
            this.SetParamSimple(map, prefix + "FaceCount", this.FaceCount);
            this.SetParamSimple(map, prefix + "KeepUV", this.KeepUV);
            this.SetParamSimple(map, prefix + "ResultFormat", this.ResultFormat);
            this.SetParamSimple(map, prefix + "Seed", this.Seed);
            this.SetParamSimple(map, prefix + "Style", this.Style);
        }
    }
}

