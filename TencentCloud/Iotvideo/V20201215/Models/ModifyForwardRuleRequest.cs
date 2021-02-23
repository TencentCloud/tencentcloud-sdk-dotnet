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

namespace TencentCloud.Iotvideo.V20201215.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyForwardRuleRequest : AbstractModel
    {
        
        /// <summary>
        /// 产品ID
        /// </summary>
        [JsonProperty("ProductID")]
        public string ProductID{ get; set; }

        /// <summary>
        /// 消息类型
        /// </summary>
        [JsonProperty("MsgType")]
        public ulong? MsgType{ get; set; }

        /// <summary>
        /// 控制台Skey
        /// </summary>
        [JsonProperty("Skey")]
        public string Skey{ get; set; }

        /// <summary>
        /// 队列区域
        /// </summary>
        [JsonProperty("QueueRegion")]
        public string QueueRegion{ get; set; }

        /// <summary>
        /// 队列类型
        /// </summary>
        [JsonProperty("QueueType")]
        public ulong? QueueType{ get; set; }

        /// <summary>
        /// 临时密钥
        /// </summary>
        [JsonProperty("Consecretid")]
        public string Consecretid{ get; set; }

        /// <summary>
        /// 实例ID
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 实例名称
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// 队列或主题ID
        /// </summary>
        [JsonProperty("QueueID")]
        public string QueueID{ get; set; }

        /// <summary>
        /// 队列或主题名称
        /// </summary>
        [JsonProperty("QueueName")]
        public string QueueName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProductID", this.ProductID);
            this.SetParamSimple(map, prefix + "MsgType", this.MsgType);
            this.SetParamSimple(map, prefix + "Skey", this.Skey);
            this.SetParamSimple(map, prefix + "QueueRegion", this.QueueRegion);
            this.SetParamSimple(map, prefix + "QueueType", this.QueueType);
            this.SetParamSimple(map, prefix + "Consecretid", this.Consecretid);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "QueueID", this.QueueID);
            this.SetParamSimple(map, prefix + "QueueName", this.QueueName);
        }
    }
}

