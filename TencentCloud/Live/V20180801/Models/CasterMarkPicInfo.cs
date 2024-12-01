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

namespace TencentCloud.Live.V20180801.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CasterMarkPicInfo : AbstractModel
    {
        
        /// <summary>
        /// 水印图片Index。
        /// </summary>
        [JsonProperty("MarkPicIndex")]
        public long? MarkPicIndex{ get; set; }

        /// <summary>
        /// 注：该字段已废弃。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MarkPicId")]
        public long? MarkPicId{ get; set; }

        /// <summary>
        /// 水印图片在输出时的宽度。
        /// 当该值为大于1的整数值时，单位为像素，允许范围[1,1920]。 
        /// 当该值为小于1大于0的小数时，单位为百分比，表示水印在最终画面上所占的比例值。
        /// </summary>
        [JsonProperty("MarkPicWidth")]
        public float? MarkPicWidth{ get; set; }

        /// <summary>
        /// 水印图片在输出时的高度。
        /// 当该值为大于1的整数值时，单位为像素，允许范围[1,1080]。 
        /// 当该值为小于1大于0的小数时，单位为百分比，表示水印在输出上所占的比例值。
        /// </summary>
        [JsonProperty("MarkPicHeight")]
        public float? MarkPicHeight{ get; set; }

        /// <summary>
        /// 水印图片在输出时的X轴坐标。
        /// 当该值为大于1的整数值时，单位为像素，允许范围[1,1920]。 
        /// 当该值为小于1大于0的小数时，单位为百分比，表示水印在最终画面上x坐标所占的比例值。
        /// </summary>
        [JsonProperty("MarkPicLocationX")]
        public float? MarkPicLocationX{ get; set; }

        /// <summary>
        /// 水印图片在输出时的Y坐标。
        /// 当该值为大于1的整数值时，单位为像素，允许范围[1,1080]。 
        /// 当该值为小于1大于0的小数时，单位为百分比，表示水印在最终画面Y坐标上所占的比例值。
        /// </summary>
        [JsonProperty("MarkPicLocationY")]
        public float? MarkPicLocationY{ get; set; }

        /// <summary>
        /// 水印地址。
        /// 最大长度256字符，且url需以jpg、jpeg、png、bmp、gif后缀结尾。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MarkPicUrl")]
        public string MarkPicUrl{ get; set; }

        /// <summary>
        /// 水印描述。
        /// 最大允许长度为256。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 是否启用了等比例缩放。
        /// 注：该字段仅做状态保存，无实际效果。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsEqualProportion")]
        public bool? IsEqualProportion{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MarkPicIndex", this.MarkPicIndex);
            this.SetParamSimple(map, prefix + "MarkPicId", this.MarkPicId);
            this.SetParamSimple(map, prefix + "MarkPicWidth", this.MarkPicWidth);
            this.SetParamSimple(map, prefix + "MarkPicHeight", this.MarkPicHeight);
            this.SetParamSimple(map, prefix + "MarkPicLocationX", this.MarkPicLocationX);
            this.SetParamSimple(map, prefix + "MarkPicLocationY", this.MarkPicLocationY);
            this.SetParamSimple(map, prefix + "MarkPicUrl", this.MarkPicUrl);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "IsEqualProportion", this.IsEqualProportion);
        }
    }
}

