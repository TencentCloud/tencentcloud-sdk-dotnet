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

namespace TencentCloud.Aiart.V20221229.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class LogoParam : AbstractModel
    {
        
        /// <summary>
        /// 水印url
        /// </summary>
        [JsonProperty("LogoUrl")]
        public string LogoUrl{ get; set; }

        /// <summary>
        /// 水印base64，url和base64二选一传入
        /// </summary>
        [JsonProperty("LogoImage")]
        public string LogoImage{ get; set; }

        /// <summary>
        /// 水印图片位于融合结果图中的坐标，将按照坐标对标识图片进行位置和大小的拉伸匹配
        /// </summary>
        [JsonProperty("LogoRect")]
        public LogoRect LogoRect{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LogoUrl", this.LogoUrl);
            this.SetParamSimple(map, prefix + "LogoImage", this.LogoImage);
            this.SetParamObj(map, prefix + "LogoRect.", this.LogoRect);
        }
    }
}

