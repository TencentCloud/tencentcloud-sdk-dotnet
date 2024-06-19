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

namespace TencentCloud.Lke.V20231130.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DocumentRecognizeInfo : AbstractModel
    {
        
        /// <summary>
        /// 输入PDF文件的页码，从1开始。输入图片的话值始终为1
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PageNumber")]
        public long? PageNumber{ get; set; }

        /// <summary>
        /// 旋转角度
        /// 
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Angle")]
        public long? Angle{ get; set; }

        /// <summary>
        /// AI算法识别处理后的图片高度
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Height")]
        public long? Height{ get; set; }

        /// <summary>
        /// AI算法识别处理后的图片宽度
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Width")]
        public long? Width{ get; set; }

        /// <summary>
        /// 图片的原始高度，输入PDF文件则表示单页PDF转图片之后的图片高度
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OriginHeight")]
        public long? OriginHeight{ get; set; }

        /// <summary>
        /// 图片的原始宽度，输入PDF文件则表示单页PDF转图片之后的图片宽度
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OriginWidth")]
        public long? OriginWidth{ get; set; }

        /// <summary>
        /// 文档元素信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Elements")]
        public DocumentElement[] Elements{ get; set; }

        /// <summary>
        /// 旋转角度
        /// 
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RotatedAngle")]
        public float? RotatedAngle{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PageNumber", this.PageNumber);
            this.SetParamSimple(map, prefix + "Angle", this.Angle);
            this.SetParamSimple(map, prefix + "Height", this.Height);
            this.SetParamSimple(map, prefix + "Width", this.Width);
            this.SetParamSimple(map, prefix + "OriginHeight", this.OriginHeight);
            this.SetParamSimple(map, prefix + "OriginWidth", this.OriginWidth);
            this.SetParamArrayObj(map, prefix + "Elements.", this.Elements);
            this.SetParamSimple(map, prefix + "RotatedAngle", this.RotatedAngle);
        }
    }
}

