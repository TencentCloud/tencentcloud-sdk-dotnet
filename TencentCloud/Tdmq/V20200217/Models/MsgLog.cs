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

namespace TencentCloud.Tdmq.V20200217.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MsgLog : AbstractModel
    {
        
        /// <summary>
        /// 消息ID。
        /// </summary>
        [JsonProperty("MsgId")]
        public string MsgId{ get; set; }

        /// <summary>
        /// 生产者名称。
        /// </summary>
        [JsonProperty("ProducerName")]
        public string ProducerName{ get; set; }

        /// <summary>
        /// 生产时间。
        /// </summary>
        [JsonProperty("ProduceTime")]
        public string ProduceTime{ get; set; }

        /// <summary>
        /// 生产客户端地址。
        /// </summary>
        [JsonProperty("ProducerAddr")]
        public string ProducerAddr{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MsgId", this.MsgId);
            this.SetParamSimple(map, prefix + "ProducerName", this.ProducerName);
            this.SetParamSimple(map, prefix + "ProduceTime", this.ProduceTime);
            this.SetParamSimple(map, prefix + "ProducerAddr", this.ProducerAddr);
        }
    }
}

