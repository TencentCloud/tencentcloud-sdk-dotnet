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

    public class AMQPClusterRecentStats : AbstractModel
    {
        
        /// <summary>
        /// Queue数量
        /// </summary>
        [JsonProperty("QueueNum")]
        public ulong? QueueNum{ get; set; }

        /// <summary>
        /// 消息生产数
        /// </summary>
        [JsonProperty("ProducedMsgNum")]
        public ulong? ProducedMsgNum{ get; set; }

        /// <summary>
        /// 消息堆积数
        /// </summary>
        [JsonProperty("AccumulativeMsgNum")]
        public ulong? AccumulativeMsgNum{ get; set; }

        /// <summary>
        /// Exchange数量
        /// </summary>
        [JsonProperty("ExchangeNum")]
        public ulong? ExchangeNum{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "QueueNum", this.QueueNum);
            this.SetParamSimple(map, prefix + "ProducedMsgNum", this.ProducedMsgNum);
            this.SetParamSimple(map, prefix + "AccumulativeMsgNum", this.AccumulativeMsgNum);
            this.SetParamSimple(map, prefix + "ExchangeNum", this.ExchangeNum);
        }
    }
}

