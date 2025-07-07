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

    public class SubmitHunyuanTo3DJobRequest : AbstractModel
    {
        
        /// <summary>
        /// 文生3D，3D内容的描述，中文正向提示词。
        /// 最多支持200个 utf-8 字符。
        /// 文生3D, image、image_url和 prompt必填其一，且prompt和image/image_url不能同时存在。
        /// </summary>
        [JsonProperty("Prompt")]
        public string Prompt{ get; set; }

        /// <summary>
        /// 输入图 Base64 数据。
        /// 大小：单边分辨率要求不小于128，不大于5000。大小不超过8m（base64编码后会大30%左右，建议实际输入图片不超过6m）
        /// 格式：jpg，png，jpeg，webp。
        /// ImageBase64、ImageUrl和 Prompt必填其一，且Prompt和ImageBase64/ImageUrl不能同时存在。
        /// </summary>
        [JsonProperty("ImageBase64")]
        public string ImageBase64{ get; set; }

        /// <summary>
        /// 输入图Url。
        /// 大小：单边分辨率要求不小于128，不大于5000。大小不超过8m（base64编码后会大30%左右，建议实际输入图片不超过6m）
        /// 格式：jpg，png，jpeg，webp。
        /// ImageBase64/ImageUrl和 Prompt必填其一，且Prompt和ImageBase64/ImageUrl不能同时存在。
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
        /// ●图片大小限制：编码后大小不可超过8M。
        /// ●图片分辨率限制：单边分辨率小于5000且大于128。
        /// ●支持图片格式：支持jpg或png
        /// </summary>
        [JsonProperty("MultiViewImages")]
        public ViewImage[] MultiViewImages{ get; set; }

        /// <summary>
        /// 生成模型的格式，仅限制生成一种格式。
        /// 生成模型文件组默认返回obj格式。
        /// 可选值：OBJ，GLB，STL，USDZ，FBX，MP4。
        /// </summary>
        [JsonProperty("ResultFormat")]
        public string ResultFormat{ get; set; }

        /// <summary>
        /// 是否开启 PBR材质生成，默认 false。
        /// </summary>
        [JsonProperty("EnablePBR")]
        public bool? EnablePBR{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Prompt", this.Prompt);
            this.SetParamSimple(map, prefix + "ImageBase64", this.ImageBase64);
            this.SetParamSimple(map, prefix + "ImageUrl", this.ImageUrl);
            this.SetParamArrayObj(map, prefix + "MultiViewImages.", this.MultiViewImages);
            this.SetParamSimple(map, prefix + "ResultFormat", this.ResultFormat);
            this.SetParamSimple(map, prefix + "EnablePBR", this.EnablePBR);
        }
    }
}

