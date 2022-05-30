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

namespace TencentCloud.Ckafka.V20190819.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SendMessageRequest : AbstractModel
    {
        
        /// <summary>
        /// DataHub接入ID
        /// </summary>
        [JsonProperty("DataHubId")]
        public string DataHubId{ get; set; }

        /// <summary>
        /// 发送消息内容(单次请求最多500条)
        /// </summary>
        [JsonProperty("Message")]
        public BatchContent[] Message{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DataHubId", this.DataHubId);
            this.SetParamArrayObj(map, prefix + "Message.", this.Message);
        }
    }
}

