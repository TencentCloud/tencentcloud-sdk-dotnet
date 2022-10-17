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

    public class CreateUploadUrlResponse : AbstractModel
    {
        
        /// <summary>
        /// 用于上传内容的链接，使用HTTP PUT方法上传。
        /// </summary>
        [JsonProperty("UploadUrl")]
        public string UploadUrl{ get; set; }

        /// <summary>
        /// 完成上传后将该链接用于后续需要传入资源URL的地方。
        /// </summary>
        [JsonProperty("ResourceUrl")]
        public string ResourceUrl{ get; set; }

        /// <summary>
        /// 上传和下载链接过期时间点，10位unix时间戳。
        /// </summary>
        [JsonProperty("ExpiredTimestamp")]
        public long? ExpiredTimestamp{ get; set; }

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
            this.SetParamSimple(map, prefix + "UploadUrl", this.UploadUrl);
            this.SetParamSimple(map, prefix + "ResourceUrl", this.ResourceUrl);
            this.SetParamSimple(map, prefix + "ExpiredTimestamp", this.ExpiredTimestamp);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

