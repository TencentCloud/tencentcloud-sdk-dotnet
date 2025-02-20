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

namespace TencentCloud.Trabbit.V20230418.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeRabbitMQServerlessExchangeDetailResponse : AbstractModel
    {
        
        /// <summary>
        /// exchange 名
        /// </summary>
        [JsonProperty("ExchangeName")]
        public string ExchangeName{ get; set; }

        /// <summary>
        /// 备注说明
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// 是否为持久化 exchange, 当集群重启时, 将会清除所有该字段为 "false" 的 exchange
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
        /// 替代 exchange, 如果消息没有匹配当前 exchange 绑定的所有 queue 或 exchange, 就会发送到该替代 exchange
        /// </summary>
        [JsonProperty("AlternateExchange")]
        public string AlternateExchange{ get; set; }

        /// <summary>
        /// exchange 类型, 支持 "fanout","direct","topic","headers"
        /// </summary>
        [JsonProperty("ExchangeType")]
        public string ExchangeType{ get; set; }

        /// <summary>
        /// VHost参数
        /// </summary>
        [JsonProperty("VirtualHost")]
        public string VirtualHost{ get; set; }

        /// <summary>
        /// exchange 创建者, "system":"系统创建", "user":"用户创建"
        /// </summary>
        [JsonProperty("ExchangeCreator")]
        public string ExchangeCreator{ get; set; }

        /// <summary>
        /// 扩展参数 key-value 字符串
        /// </summary>
        [JsonProperty("Arguments")]
        public string Arguments{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ExchangeName", this.ExchangeName);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "Durable", this.Durable);
            this.SetParamSimple(map, prefix + "AutoDelete", this.AutoDelete);
            this.SetParamSimple(map, prefix + "Internal", this.Internal);
            this.SetParamSimple(map, prefix + "AlternateExchange", this.AlternateExchange);
            this.SetParamSimple(map, prefix + "ExchangeType", this.ExchangeType);
            this.SetParamSimple(map, prefix + "VirtualHost", this.VirtualHost);
            this.SetParamSimple(map, prefix + "ExchangeCreator", this.ExchangeCreator);
            this.SetParamSimple(map, prefix + "Arguments", this.Arguments);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

