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

namespace TencentCloud.Ocr.V20181119.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class QuestionInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>旋转角度</p>
        /// </summary>
        [JsonProperty("Angle")]
        public float? Angle{ get; set; }

        /// <summary>
        /// <p>预处理后图片高度</p><p>单位：px</p>
        /// </summary>
        [JsonProperty("Height")]
        public long? Height{ get; set; }

        /// <summary>
        /// <p>预处理后图片宽度</p><p>单位：px</p>
        /// </summary>
        [JsonProperty("Width")]
        public long? Width{ get; set; }

        /// <summary>
        /// <p>文档元素</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ResultList")]
        public ResultList[] ResultList{ get; set; }

        /// <summary>
        /// <p>输入图片高度</p><p>单位：px</p>
        /// </summary>
        [JsonProperty("OrgHeight")]
        public long? OrgHeight{ get; set; }

        /// <summary>
        /// <p>输入图片宽度</p><p>单位：px</p>
        /// </summary>
        [JsonProperty("OrgWidth")]
        public long? OrgWidth{ get; set; }

        /// <summary>
        /// <p>废弃字段</p>
        /// </summary>
        [JsonProperty("ImageBase64")]
        public string ImageBase64{ get; set; }

        /// <summary>
        /// <p>预处理后的图片URL,如果开启了图像切边矫正，后续的坐标都是基于当前图片返回的坐标</p>
        /// </summary>
        [JsonProperty("ReturnImageUrl")]
        public string ReturnImageUrl{ get; set; }

        /// <summary>
        /// <p>【批改 API 专属特性】图片类型预判别（常规作业 / 非作业图片 / 无作答痕迹），仅 ModelType = yuanbao_correction_model 时生效。其他模型类型不支持该能力。</p>
        /// </summary>
        [JsonProperty("ClassName")]
        public string ClassName{ get; set; }

        /// <summary>
        /// <p>文档所在页</p>
        /// </summary>
        [JsonProperty("PageIndex")]
        public long? PageIndex{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Angle", this.Angle);
            this.SetParamSimple(map, prefix + "Height", this.Height);
            this.SetParamSimple(map, prefix + "Width", this.Width);
            this.SetParamArrayObj(map, prefix + "ResultList.", this.ResultList);
            this.SetParamSimple(map, prefix + "OrgHeight", this.OrgHeight);
            this.SetParamSimple(map, prefix + "OrgWidth", this.OrgWidth);
            this.SetParamSimple(map, prefix + "ImageBase64", this.ImageBase64);
            this.SetParamSimple(map, prefix + "ReturnImageUrl", this.ReturnImageUrl);
            this.SetParamSimple(map, prefix + "ClassName", this.ClassName);
            this.SetParamSimple(map, prefix + "PageIndex", this.PageIndex);
        }
    }
}

