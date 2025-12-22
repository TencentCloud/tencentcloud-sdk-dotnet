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

namespace TencentCloud.Ai3d.V20250513.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SubmitHunyuanTo3DProJobRequest : AbstractModel
    {
        
        /// <summary>
        /// 文生3D，3D内容的描述，中文正向提示词。
        /// 最多支持1024个 utf-8 字符。
        /// ImageBase64、ImageUrl和 Prompt必填其一，且Prompt和ImageBase64/ImageUrl不能同时存在。
        /// </summary>
        [JsonProperty("Prompt")]
        public string Prompt{ get; set; }

        /// <summary>
        /// 输入图 Base64 数据。
        /// 大小: 单边分辨率要求不小于128，不大于5000，大小≤6m (因base64编码后会大30%左右)
        /// 格式: jpg，png，jpeg，webp.
        /// lmageBase64、lmageUr和 Prompt必填其一，且Prompt和lmageBase64/mageUr不能同时存在。
        /// </summary>
        [JsonProperty("ImageBase64")]
        public string ImageBase64{ get; set; }

        /// <summary>
        /// 输入图Url
        /// 大小: 单边分辨率要求不小于128，不大于5000，大小≤8m
        /// 格式: jpg，png，jpeg，webp.
        /// lmageBase64、lmageUr和 Prompt必填其一，且Prompt和lmageBase64/mageUr不能同时存在。
        /// </summary>
        [JsonProperty("ImageUrl")]
        public string ImageUrl{ get; set; }

        /// <summary>
        /// 多视角的模型图片，视角参考值：
        /// left：左视图；
        /// right：右视图；
        /// back：后视图；
        /// 
        /// 每个视角仅限制一张图片。
        /// ●图片大小限制：编码后所有图片大小总和不可超过8M。（base64编码下图片大小总和不超过6M，因base64编码后图片大小会大30%左右）
        /// ●图片分辨率限制：单边分辨率小于5000且大于128。
        /// ●支持图片格式：支持jpg或png
        /// </summary>
        [JsonProperty("MultiViewImages")]
        public ViewImage[] MultiViewImages{ get; set; }

        /// <summary>
        /// 是否开启 PBR材质生成，默认 false。
        /// </summary>
        [JsonProperty("EnablePBR")]
        public bool? EnablePBR{ get; set; }

        /// <summary>
        /// 生成3D模型的面数，默认值为500000。
        /// 可支持生成面数范围，参考值：40000-1500000。
        /// </summary>
        [JsonProperty("FaceCount")]
        public long? FaceCount{ get; set; }

        /// <summary>
        /// 生成任务类型，默认Normal，参考值：
        /// Normal：可生成带纹理的几何模型。
        /// LowPoly：可生成智能减面后的模型。
        /// Geometry：可生成不带纹理的几何模型（白模），选择此任务时，EnablePBR参数不生效。
        /// Sketch：可输入草图或线稿图生成模型，此模式下prompt和ImageUrl/ImageBase64可一起输入。
        /// </summary>
        [JsonProperty("GenerateType")]
        public string GenerateType{ get; set; }

        /// <summary>
        /// 该参数仅在GenerateType中选择LowPoly模式可生效。
        /// 
        /// 多边形类型，表示模型的表面由几边形网格构成，默认为triangle,参考值:
        /// triangle: 三角形面。
        /// quadrilateral: 四边形面与三角形面混合生成。
        /// </summary>
        [JsonProperty("PolygonType")]
        public string PolygonType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Prompt", this.Prompt);
            this.SetParamSimple(map, prefix + "ImageBase64", this.ImageBase64);
            this.SetParamSimple(map, prefix + "ImageUrl", this.ImageUrl);
            this.SetParamArrayObj(map, prefix + "MultiViewImages.", this.MultiViewImages);
            this.SetParamSimple(map, prefix + "EnablePBR", this.EnablePBR);
            this.SetParamSimple(map, prefix + "FaceCount", this.FaceCount);
            this.SetParamSimple(map, prefix + "GenerateType", this.GenerateType);
            this.SetParamSimple(map, prefix + "PolygonType", this.PolygonType);
        }
    }
}

