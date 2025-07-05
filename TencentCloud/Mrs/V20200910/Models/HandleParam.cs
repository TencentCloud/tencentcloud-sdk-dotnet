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

namespace TencentCloud.Mrs.V20200910.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class HandleParam : AbstractModel
    {
        
        /// <summary>
        /// ocr引擎
        /// </summary>
        [JsonProperty("OcrEngineType")]
        public long? OcrEngineType{ get; set; }

        /// <summary>
        /// 是否返回分行文本内容
        /// </summary>
        [JsonProperty("IsReturnText")]
        public bool? IsReturnText{ get; set; }

        /// <summary>
        /// 顺时针旋转角度
        /// </summary>
        [JsonProperty("RotateTheAngle")]
        public float? RotateTheAngle{ get; set; }

        /// <summary>
        /// 自动适配方向,仅支持优图引擎
        /// </summary>
        [JsonProperty("AutoFitDirection")]
        public bool? AutoFitDirection{ get; set; }

        /// <summary>
        /// 坐标优化
        /// </summary>
        [JsonProperty("AutoOptimizeCoordinate")]
        public bool? AutoOptimizeCoordinate{ get; set; }

        /// <summary>
        /// 是否开启图片压缩，开启时imageOriginalSize必须正确填写
        /// </summary>
        [JsonProperty("IsScale")]
        public bool? IsScale{ get; set; }

        /// <summary>
        /// 原始图片大小(单位byes),用来判断该图片是否需要压缩
        /// </summary>
        [JsonProperty("ImageOriginalSize")]
        public ulong? ImageOriginalSize{ get; set; }

        /// <summary>
        /// 采用后台默认值(2048Kb)
        /// </summary>
        [JsonProperty("ScaleTargetSize")]
        public ulong? ScaleTargetSize{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "OcrEngineType", this.OcrEngineType);
            this.SetParamSimple(map, prefix + "IsReturnText", this.IsReturnText);
            this.SetParamSimple(map, prefix + "RotateTheAngle", this.RotateTheAngle);
            this.SetParamSimple(map, prefix + "AutoFitDirection", this.AutoFitDirection);
            this.SetParamSimple(map, prefix + "AutoOptimizeCoordinate", this.AutoOptimizeCoordinate);
            this.SetParamSimple(map, prefix + "IsScale", this.IsScale);
            this.SetParamSimple(map, prefix + "ImageOriginalSize", this.ImageOriginalSize);
            this.SetParamSimple(map, prefix + "ScaleTargetSize", this.ScaleTargetSize);
        }
    }
}

