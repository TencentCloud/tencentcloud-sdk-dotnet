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

namespace TencentCloud.Faceid.V20180301.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class GenerateReflectSequenceResponse : AbstractModel
    {
        
        /// <summary>
        /// 光线序列的资源链接，下载后透传给SDK即可开始核身。
        /// </summary>
        [JsonProperty("ReflectSequenceUrl")]
        public string ReflectSequenceUrl{ get; set; }

        /// <summary>
        /// 光线序列的资源MD5值，用于校验改序列是否被篡改。
        /// </summary>
        [JsonProperty("ReflectSequenceMd5")]
        public string ReflectSequenceMd5{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ReflectSequenceUrl", this.ReflectSequenceUrl);
            this.SetParamSimple(map, prefix + "ReflectSequenceMd5", this.ReflectSequenceMd5);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

