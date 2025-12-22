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

namespace TencentCloud.Cls.V20201016.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateConsumerGroupRequest : AbstractModel
    {
        
        /// <summary>
        /// 创建的消费者组标识
        /// 限制： 字母数字下划线，不允许数字开头，长度限制256
        /// </summary>
        [JsonProperty("ConsumerGroup")]
        public string ConsumerGroup{ get; set; }

        /// <summary>
        /// 消费者心跳超时时间（秒）
        /// </summary>
        [JsonProperty("Timeout")]
        public ulong? Timeout{ get; set; }

        /// <summary>
        /// 创建的消费者组包含的日志主题列表
        /// </summary>
        [JsonProperty("Topics")]
        public string[] Topics{ get; set; }

        /// <summary>
        /// 日志集Id（日志主题所属的日志集）
        /// </summary>
        [JsonProperty("LogsetId")]
        public string LogsetId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ConsumerGroup", this.ConsumerGroup);
            this.SetParamSimple(map, prefix + "Timeout", this.Timeout);
            this.SetParamArraySimple(map, prefix + "Topics.", this.Topics);
            this.SetParamSimple(map, prefix + "LogsetId", this.LogsetId);
        }
    }
}

