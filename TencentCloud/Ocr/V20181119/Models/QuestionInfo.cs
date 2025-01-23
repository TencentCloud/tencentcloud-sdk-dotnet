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

namespace TencentCloud.Ocr.V20181119.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class QuestionInfo : AbstractModel
    {
        
        /// <summary>
        /// 旋转角度
        /// </summary>
        [JsonProperty("Angle")]
        public float? Angle{ get; set; }

        /// <summary>
        /// 预处理后图片高度
        /// </summary>
        [JsonProperty("Height")]
        public long? Height{ get; set; }

        /// <summary>
        /// 预处理后图片宽度
        /// </summary>
        [JsonProperty("Width")]
        public long? Width{ get; set; }

        /// <summary>
        /// 文档元素
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ResultList")]
        public ResultList[] ResultList{ get; set; }

        /// <summary>
        /// 输入图片高度
        /// </summary>
        [JsonProperty("OrgHeight")]
        public long? OrgHeight{ get; set; }

        /// <summary>
        /// 输入图片宽度
        /// </summary>
        [JsonProperty("OrgWidth")]
        public long? OrgWidth{ get; set; }

        /// <summary>
        /// 预处理后的图片base64编码
        /// </summary>
        [JsonProperty("ImageBase64")]
        public string ImageBase64{ get; set; }


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
        }
    }
}

