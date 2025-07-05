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

namespace TencentCloud.Vpc.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class FlowLogStorage : AbstractModel
    {
        
        /// <summary>
        /// 存储实例Id，当流日志存储类型为ckafka时，必填。
        /// </summary>
        [JsonProperty("StorageId")]
        public string StorageId{ get; set; }

        /// <summary>
        /// 主题Id，当流日志存储类型为ckafka时，必填。
        /// </summary>
        [JsonProperty("StorageTopic")]
        public string StorageTopic{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StorageId", this.StorageId);
            this.SetParamSimple(map, prefix + "StorageTopic", this.StorageTopic);
        }
    }
}

