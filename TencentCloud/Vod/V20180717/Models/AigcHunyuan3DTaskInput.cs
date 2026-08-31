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

namespace TencentCloud.Vod.V20180717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AigcHunyuan3DTaskInput : AbstractModel
    {
        
        /// <summary>
        /// <p>生成 3D 的参考图片信息。</p>
        /// </summary>
        [JsonProperty("ImageInfos")]
        public AigcHunyuan3DReferenceImageInfo[] ImageInfos{ get; set; }

        /// <summary>
        /// <p>用于生成 3D 模型的多视角图片信息。</p><p>数组长度必须在2-8之间，且必须包含 front 视角。</p>
        /// </summary>
        [JsonProperty("MultiViewImageInfos")]
        public AigcHunyuan3DMultiViewImageInfo[] MultiViewImageInfos{ get; set; }

        /// <summary>
        /// <p>生成 3D 模型的提示词。</p>
        /// </summary>
        [JsonProperty("Prompt")]
        public string Prompt{ get; set; }

        /// <summary>
        /// <p>生成类型。</p><p>枚举值：</p><ul><li>Normal： 生成完整 3D 资产（几何 + 纹理）；</li><li>Geometry： 只生成几何体（无纹理，输出速度更快）；</li><li>Texture： 只生成纹理（需要填写 MeshInfos）</li></ul>
        /// </summary>
        [JsonProperty("GenerateType")]
        public string GenerateType{ get; set; }

        /// <summary>
        /// <p>用于生成 3D 模型的参考 3D 模型。</p>
        /// </summary>
        [JsonProperty("MeshInfos")]
        public AigcHunyuan3DMeshInfo[] MeshInfos{ get; set; }

        /// <summary>
        /// <p>是否开启输出 PBR 材质。</p><p>枚举值：</p><ul><li>Enabled： 开启；</li><li>Disabled： 关闭。</li></ul>
        /// </summary>
        [JsonProperty("EnablePBR")]
        public string EnablePBR{ get; set; }

        /// <summary>
        /// <p>面片数。仅 GenerateType 取值为 Normal  和 Geometry 时生效。</p>
        /// </summary>
        [JsonProperty("FaceCount")]
        public long? FaceCount{ get; set; }

        /// <summary>
        /// <p>是否保留 UV 展开。</p><p>枚举值：</p><ul><li>Enabled： 保留；</li><li>Disabled： 不保留。</li></ul>
        /// </summary>
        [JsonProperty("KeepUV")]
        public string KeepUV{ get; set; }

        /// <summary>
        /// <p>结果格式。除默认返回的 obj 和 glb 外，附加输出的一种格式。</p><p>枚举值：</p><ul><li>FBX： FBX 格式文件。</li></ul>
        /// </summary>
        [JsonProperty("ResultFormat")]
        public string ResultFormat{ get; set; }

        /// <summary>
        /// <p>随机种子，同一 Seed 输入下结果可复现。</p>
        /// </summary>
        [JsonProperty("Seed")]
        public long? Seed{ get; set; }

        /// <summary>
        /// <p>风格控制词。</p>
        /// </summary>
        [JsonProperty("Style")]
        public string Style{ get; set; }

        /// <summary>
        /// <p>任务的输出媒体文件配置。</p>
        /// </summary>
        [JsonProperty("OutputConfig")]
        public AigcHunyuan3DOutputConfig OutputConfig{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "ImageInfos.", this.ImageInfos);
            this.SetParamArrayObj(map, prefix + "MultiViewImageInfos.", this.MultiViewImageInfos);
            this.SetParamSimple(map, prefix + "Prompt", this.Prompt);
            this.SetParamSimple(map, prefix + "GenerateType", this.GenerateType);
            this.SetParamArrayObj(map, prefix + "MeshInfos.", this.MeshInfos);
            this.SetParamSimple(map, prefix + "EnablePBR", this.EnablePBR);
            this.SetParamSimple(map, prefix + "FaceCount", this.FaceCount);
            this.SetParamSimple(map, prefix + "KeepUV", this.KeepUV);
            this.SetParamSimple(map, prefix + "ResultFormat", this.ResultFormat);
            this.SetParamSimple(map, prefix + "Seed", this.Seed);
            this.SetParamSimple(map, prefix + "Style", this.Style);
            this.SetParamObj(map, prefix + "OutputConfig.", this.OutputConfig);
        }
    }
}

