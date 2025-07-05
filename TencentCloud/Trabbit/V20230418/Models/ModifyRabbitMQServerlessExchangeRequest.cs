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

    public class ModifyRabbitMQServerlessExchangeRequest : AbstractModel
    {
        
        /// <summary>
        /// 实例 id
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// vhost 参数
        /// </summary>
        [JsonProperty("VirtualHost")]
        public string VirtualHost{ get; set; }

        /// <summary>
        /// exchange 名称
        /// </summary>
        [JsonProperty("ExchangeName")]
        public string ExchangeName{ get; set; }

        /// <summary>
        /// 备注信息
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "VirtualHost", this.VirtualHost);
            this.SetParamSimple(map, prefix + "ExchangeName", this.ExchangeName);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
        }
    }
}

