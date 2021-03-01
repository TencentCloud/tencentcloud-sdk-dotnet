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

namespace TencentCloud.Ie.V20200304.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class HiddenMarkInfo : AbstractModel
    {
        
        /// <summary>
        /// 数字水印路径,，如果不从Cos拉取水印，则必填
        /// </summary>
        [JsonProperty("Path")]
        public string Path{ get; set; }

        /// <summary>
        /// 数字水印频率，可选值：[1,256]，默认值为30
        /// </summary>
        [JsonProperty("Frequency")]
        public long? Frequency{ get; set; }

        /// <summary>
        /// 数字水印强度，可选值：[32,128]，默认值为64
        /// </summary>
        [JsonProperty("Strength")]
        public long? Strength{ get; set; }

        /// <summary>
        /// 数字水印的Cos 信息，从Cos上拉取图片水印时必填。
        /// </summary>
        [JsonProperty("CosInfo")]
        public CosInfo CosInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Path", this.Path);
            this.SetParamSimple(map, prefix + "Frequency", this.Frequency);
            this.SetParamSimple(map, prefix + "Strength", this.Strength);
            this.SetParamObj(map, prefix + "CosInfo.", this.CosInfo);
        }
    }
}

