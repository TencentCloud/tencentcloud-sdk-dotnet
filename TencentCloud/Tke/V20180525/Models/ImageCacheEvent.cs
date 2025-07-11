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

namespace TencentCloud.Tke.V20180525.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ImageCacheEvent : AbstractModel
    {
        
        /// <summary>
        /// 镜像缓存Id
        /// </summary>
        [JsonProperty("ImageCacheId")]
        public string ImageCacheId{ get; set; }

        /// <summary>
        /// 事件类型, Normal或者Warning
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 事件原因简述
        /// </summary>
        [JsonProperty("Reason")]
        public string Reason{ get; set; }

        /// <summary>
        /// 事件原因详述
        /// </summary>
        [JsonProperty("Message")]
        public string Message{ get; set; }

        /// <summary>
        /// 事件第一次出现时间
        /// </summary>
        [JsonProperty("FirstTimestamp")]
        public string FirstTimestamp{ get; set; }

        /// <summary>
        /// 事件最后一次出现时间
        /// </summary>
        [JsonProperty("LastTimestamp")]
        public string LastTimestamp{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ImageCacheId", this.ImageCacheId);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Reason", this.Reason);
            this.SetParamSimple(map, prefix + "Message", this.Message);
            this.SetParamSimple(map, prefix + "FirstTimestamp", this.FirstTimestamp);
            this.SetParamSimple(map, prefix + "LastTimestamp", this.LastTimestamp);
        }
    }
}

