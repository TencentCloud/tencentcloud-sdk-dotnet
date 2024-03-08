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

    public class RocketMQMessageTrack : AbstractModel
    {
        
        /// <summary>
        /// 消费者组
        /// </summary>
        [JsonProperty("Group")]
        public string Group{ get; set; }

        /// <summary>
        /// 消费状态,
        /// CONSUMED: 已消费
        /// CONSUMED_BUT_FILTERED: 已过滤
        /// NOT_CONSUME: 未消费
        /// ENTER_RETRY: 进入重试队列
        /// ENTER_DLQ: 进入死信队列
        /// UNKNOWN: 查询不到消费状态
        /// </summary>
        [JsonProperty("ConsumeStatus")]
        public string ConsumeStatus{ get; set; }

        /// <summary>
        /// 消息track类型
        /// </summary>
        [JsonProperty("TrackType")]
        public string TrackType{ get; set; }

        /// <summary>
        /// 异常信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExceptionDesc")]
        public string ExceptionDesc{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Group", this.Group);
            this.SetParamSimple(map, prefix + "ConsumeStatus", this.ConsumeStatus);
            this.SetParamSimple(map, prefix + "TrackType", this.TrackType);
            this.SetParamSimple(map, prefix + "ExceptionDesc", this.ExceptionDesc);
        }
    }
}

