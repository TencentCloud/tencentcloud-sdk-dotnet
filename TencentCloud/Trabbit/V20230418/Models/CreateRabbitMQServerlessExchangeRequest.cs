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

    public class CreateRabbitMQServerlessExchangeRequest : AbstractModel
    {
        
        /// <summary>
        /// 实例Id
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// VHost参数
        /// </summary>
        [JsonProperty("VirtualHost")]
        public string VirtualHost{ get; set; }

        /// <summary>
        /// exchange 名称
        /// </summary>
        [JsonProperty("ExchangeName")]
        public string ExchangeName{ get; set; }

        /// <summary>
        /// exchange 类型, 支持 "fanout","direct","topic","headers"
        /// </summary>
        [JsonProperty("ExchangeType")]
        public string ExchangeType{ get; set; }

        /// <summary>
        /// exchange 备注
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// 是否为持久化 exchange, 当集群重启时,将会清除所有该字段为"false"的 exchange
        /// </summary>
        [JsonProperty("Durable")]
        public bool? Durable{ get; set; }

        /// <summary>
        /// 是否自动删除该 exchange, 如果为 "true", 当解绑所有当前 exchange 上的路由关系时, 该 exchange 将会被自动删除
        /// </summary>
        [JsonProperty("AutoDelete")]
        public bool? AutoDelete{ get; set; }

        /// <summary>
        /// 是否为内部 exchange, 如果为 "true", 则无法直接投递消息到该 exchange, 需要在路由设置中通过其他 exchange 进行转发
        /// </summary>
        [JsonProperty("Internal")]
        public bool? Internal{ get; set; }

        /// <summary>
        /// 替代 exchange, 如果消息无法发送到当前 exchange, 就会发送到该替代 exchange
        /// </summary>
        [JsonProperty("AlternateExchange")]
        public string AlternateExchange{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "VirtualHost", this.VirtualHost);
            this.SetParamSimple(map, prefix + "ExchangeName", this.ExchangeName);
            this.SetParamSimple(map, prefix + "ExchangeType", this.ExchangeType);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "Durable", this.Durable);
            this.SetParamSimple(map, prefix + "AutoDelete", this.AutoDelete);
            this.SetParamSimple(map, prefix + "Internal", this.Internal);
            this.SetParamSimple(map, prefix + "AlternateExchange", this.AlternateExchange);
        }
    }
}

