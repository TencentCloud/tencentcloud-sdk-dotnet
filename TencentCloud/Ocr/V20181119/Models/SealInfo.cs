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

    public class SealInfo : AbstractModel
    {
        
        /// <summary>
        /// 印章主体内容
        /// </summary>
        [JsonProperty("SealBody")]
        public string SealBody{ get; set; }

        /// <summary>
        /// 印章坐标
        /// </summary>
        [JsonProperty("Location")]
        public Rect Location{ get; set; }

        /// <summary>
        /// 印章其它文本内容
        /// </summary>
        [JsonProperty("OtherTexts")]
        public string[] OtherTexts{ get; set; }

        /// <summary>
        /// 印章类型，表示为:
        /// 圆形印章：0
        /// 椭圆形印章：1
        /// 方形印章：2
        /// 菱形印章：3
        /// 三角形印章：4
        /// </summary>
        [JsonProperty("SealShape")]
        public string SealShape{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SealBody", this.SealBody);
            this.SetParamObj(map, prefix + "Location.", this.Location);
            this.SetParamArraySimple(map, prefix + "OtherTexts.", this.OtherTexts);
            this.SetParamSimple(map, prefix + "SealShape", this.SealShape);
        }
    }
}

