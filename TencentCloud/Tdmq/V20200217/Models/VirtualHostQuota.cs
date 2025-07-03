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

    public class VirtualHostQuota : AbstractModel
    {
        
        /// <summary>
        /// 允许创建最大vhost数
        /// </summary>
        [JsonProperty("MaxVirtualHost")]
        public long? MaxVirtualHost{ get; set; }

        /// <summary>
        /// 已创建vhost数
        /// </summary>
        [JsonProperty("UsedVirtualHost")]
        public long? UsedVirtualHost{ get; set; }

        /// <summary>
        /// 单个 vhost 下允许的最大连接数
        /// </summary>
        [JsonProperty("MaxConnectionPerVhost")]
        public long? MaxConnectionPerVhost{ get; set; }

        /// <summary>
        /// 单个 vhost 下允许的最大交换机数
        /// </summary>
        [JsonProperty("MaxExchangePerVhost")]
        public long? MaxExchangePerVhost{ get; set; }

        /// <summary>
        /// 单个 vhost 下允许的最大队列机数
        /// </summary>
        [JsonProperty("MaxQueuePerVhost")]
        public long? MaxQueuePerVhost{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MaxVirtualHost", this.MaxVirtualHost);
            this.SetParamSimple(map, prefix + "UsedVirtualHost", this.UsedVirtualHost);
            this.SetParamSimple(map, prefix + "MaxConnectionPerVhost", this.MaxConnectionPerVhost);
            this.SetParamSimple(map, prefix + "MaxExchangePerVhost", this.MaxExchangePerVhost);
            this.SetParamSimple(map, prefix + "MaxQueuePerVhost", this.MaxQueuePerVhost);
        }
    }
}

