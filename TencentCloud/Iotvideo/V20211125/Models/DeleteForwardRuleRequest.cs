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

namespace TencentCloud.Iotvideo.V20211125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DeleteForwardRuleRequest : AbstractModel
    {
        
        /// <summary>
        /// 产品ID
        /// </summary>
        [JsonProperty("ProductID")]
        public string ProductID{ get; set; }

        /// <summary>
        /// 控制台Skey
        /// </summary>
        [JsonProperty("Skey")]
        public string Skey{ get; set; }

        /// <summary>
        /// 队列类型
        /// </summary>
        [JsonProperty("QueueType")]
        public ulong? QueueType{ get; set; }

        /// <summary>
        /// 队列名称
        /// </summary>
        [JsonProperty("QueueName")]
        public string QueueName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProductID", this.ProductID);
            this.SetParamSimple(map, prefix + "Skey", this.Skey);
            this.SetParamSimple(map, prefix + "QueueType", this.QueueType);
            this.SetParamSimple(map, prefix + "QueueName", this.QueueName);
        }
    }
}

