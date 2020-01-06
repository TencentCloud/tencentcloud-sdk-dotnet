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

    public class TextArithmetic : AbstractModel
    {
        
        /// <summary>
        /// 识别出的文本行内容
        /// </summary>
        [JsonProperty("DetectedText")]
        public string DetectedText{ get; set; }

        /// <summary>
        /// 算式运算结果
        /// </summary>
        [JsonProperty("Result")]
        public bool? Result{ get; set; }

        /// <summary>
        /// 保留字段，暂不支持
        /// </summary>
        [JsonProperty("Confidence")]
        public long? Confidence{ get; set; }

        /// <summary>
        /// 原图文本行坐标，以四个顶点坐标表示（保留字段，暂不支持）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Polygon")]
        public Coord[] Polygon{ get; set; }

        /// <summary>
        /// 保留字段，暂不支持
        /// </summary>
        [JsonProperty("AdvancedInfo")]
        public string AdvancedInfo{ get; set; }

        /// <summary>
        /// 文本行旋转纠正之后在图像中的像素坐标，表示为（左上角x, 左上角y，宽width，高height）
        /// </summary>
        [JsonProperty("ItemCoord")]
        public ItemCoord ItemCoord{ get; set; }

        /// <summary>
        /// 算式题型编号：
        /// ‘1’: 加减乘除四则
        /// ‘2’: 加减乘除已知结果求运算因子
        /// ‘3’: 判断大小
        /// ‘4’: 约等于估算
        /// ‘5’: 带余数除法
        /// ‘6’: 分数四则运算
        /// ‘7’: 单位换算
        /// ‘8’: 竖式加减法
        /// ‘9’: 竖式乘除法
        /// ‘10’: 脱式计算
        /// ‘11’: 解方程
        /// </summary>
        [JsonProperty("ExpressionType")]
        public string ExpressionType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DetectedText", this.DetectedText);
            this.SetParamSimple(map, prefix + "Result", this.Result);
            this.SetParamSimple(map, prefix + "Confidence", this.Confidence);
            this.SetParamArrayObj(map, prefix + "Polygon.", this.Polygon);
            this.SetParamSimple(map, prefix + "AdvancedInfo", this.AdvancedInfo);
            this.SetParamObj(map, prefix + "ItemCoord.", this.ItemCoord);
            this.SetParamSimple(map, prefix + "ExpressionType", this.ExpressionType);
        }
    }
}

