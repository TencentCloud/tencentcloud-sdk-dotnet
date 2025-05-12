/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

namespace TencentCloud.Hunyuan.V20230901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SubmitHunyuanTo3DJobRequest : AbstractModel
    {
        
        /// <summary>
        /// 3D内容的描述，中文正向提示词。最多支持200个 utf-8 字符，ImageBase64、ImageUrl和 Prompt必填其一，且Prompt和ImageBase64/ImageUrl不能同时存在。
        /// </summary>
        [JsonProperty("Prompt")]
        public string Prompt{ get; set; }

        /// <summary>
        /// 输入图 Base64 数据。
        /// 大小：单边分辨率要求不小于50，不大于5000。大小不超过8m（base64编码后会大30%左右，建议实际输入图片不超过6m）
        /// 格式：jpg，png，jpeg，webp。
        /// ImageBase64、ImageUrl和 Prompt必填其一，且Prompt和ImageBase64/ImageUrl不能同时存在。
        /// </summary>
        [JsonProperty("ImageBase64")]
        public string ImageBase64{ get; set; }

        /// <summary>
        /// 输入图Url。
        /// 大小：单边分辨率要求不小于50，不大于5000。大小不超过8m（base64编码后会大30%左右，建议实际输入图片不超过6m）
        /// 格式：jpg，png，jpeg，webp。
        /// ImageBase64/ImageUrl和 Prompt必填其一，且Prompt和ImageBase64/ImageUrl不能同时存在。
        /// </summary>
        [JsonProperty("ImageUrl")]
        public string ImageUrl{ get; set; }

        /// <summary>
        /// 生成数量。默认1，当前限制只能为1。
        /// </summary>
        [JsonProperty("Num")]
        public long? Num{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Prompt", this.Prompt);
            this.SetParamSimple(map, prefix + "ImageBase64", this.ImageBase64);
            this.SetParamSimple(map, prefix + "ImageUrl", this.ImageUrl);
            this.SetParamSimple(map, prefix + "Num", this.Num);
        }
    }
}

