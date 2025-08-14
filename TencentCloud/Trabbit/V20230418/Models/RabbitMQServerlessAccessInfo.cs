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

namespace TencentCloud.Trabbit.V20230418.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RabbitMQServerlessAccessInfo : AbstractModel
    {
        
        /// <summary>
        /// 公网域名
        /// </summary>
        [JsonProperty("PublicAccessEndpoint")]
        public string PublicAccessEndpoint{ get; set; }

        /// <summary>
        /// 公网状态
        /// </summary>
        [JsonProperty("PublicDataStreamStatus")]
        public string PublicDataStreamStatus{ get; set; }

        /// <summary>
        /// 公网CLB实例ID
        /// </summary>
        [JsonProperty("PublicClbId")]
        public string PublicClbId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PublicAccessEndpoint", this.PublicAccessEndpoint);
            this.SetParamSimple(map, prefix + "PublicDataStreamStatus", this.PublicDataStreamStatus);
            this.SetParamSimple(map, prefix + "PublicClbId", this.PublicClbId);
        }
    }
}

