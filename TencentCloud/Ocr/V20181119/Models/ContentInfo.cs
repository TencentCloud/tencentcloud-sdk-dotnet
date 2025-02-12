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

    public class ContentInfo : AbstractModel
    {
        
        /// <summary>
        /// 字段内容
        /// </summary>
        [JsonProperty("Content")]
        public string Content{ get; set; }

        /// <summary>
        /// 结果置信度
        /// </summary>
        [JsonProperty("Confidence")]
        public long? Confidence{ get; set; }

        /// <summary>
        /// 字段是否不完整（value内容）
        /// 0 字段正常
        /// 1 字段不完整
        /// </summary>
        [JsonProperty("IsInComplete")]
        public long? IsInComplete{ get; set; }

        /// <summary>
        /// 字段反光（value内容）
        /// 0 字段正常
        /// 1 字段有反光
        /// </summary>
        [JsonProperty("IsReflect")]
        public long? IsReflect{ get; set; }

        /// <summary>
        /// 字段是否不完整（key内容）
        /// 0 字段正常
        /// 1 字段不完整
        /// </summary>
        [JsonProperty("IsKeyInComplete")]
        public long? IsKeyInComplete{ get; set; }

        /// <summary>
        /// 字段反光（key内容）
        /// 0 字段正常
        /// 1 字段有反光
        /// </summary>
        [JsonProperty("IsKeyReflect")]
        public long? IsKeyReflect{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Content", this.Content);
            this.SetParamSimple(map, prefix + "Confidence", this.Confidence);
            this.SetParamSimple(map, prefix + "IsInComplete", this.IsInComplete);
            this.SetParamSimple(map, prefix + "IsReflect", this.IsReflect);
            this.SetParamSimple(map, prefix + "IsKeyInComplete", this.IsKeyInComplete);
            this.SetParamSimple(map, prefix + "IsKeyReflect", this.IsKeyReflect);
        }
    }
}

