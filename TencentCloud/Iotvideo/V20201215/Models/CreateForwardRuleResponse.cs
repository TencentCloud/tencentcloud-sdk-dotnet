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

namespace TencentCloud.Iotvideo.V20201215.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateForwardRuleResponse : AbstractModel
    {
        
        /// <summary>
        /// 腾讯云账号
        /// </summary>
        [JsonProperty("Endpoint")]
        public string Endpoint{ get; set; }

        /// <summary>
        /// 队列名
        /// </summary>
        [JsonProperty("QueueName")]
        public string QueueName{ get; set; }

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
        /// 结果
        /// </summary>
        [JsonProperty("Result")]
        public ulong? Result{ get; set; }

        /// <summary>
        /// 角色名称
        /// </summary>
        [JsonProperty("RoleName")]
        public string RoleName{ get; set; }

        /// <summary>
        /// 角色ID
        /// </summary>
        [JsonProperty("RoleID")]
        public ulong? RoleID{ get; set; }

        /// <summary>
        /// 队列区
        /// </summary>
        [JsonProperty("QueueRegion")]
        public string QueueRegion{ get; set; }

        /// <summary>
        /// 消息队列的类型。 0：CMQ，1：Ckafka
        /// </summary>
        [JsonProperty("QueueType")]
        public ulong? QueueType{ get; set; }

        /// <summary>
        /// 实例id， 目前只有Ckafka会用到
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 实例名称，目前只有Ckafka会用到
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// 错误消息
        /// </summary>
        [JsonProperty("ErrMsg")]
        public string ErrMsg{ get; set; }

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
            this.SetParamSimple(map, prefix + "Endpoint", this.Endpoint);
            this.SetParamSimple(map, prefix + "QueueName", this.QueueName);
            this.SetParamSimple(map, prefix + "ProductID", this.ProductID);
            this.SetParamSimple(map, prefix + "MsgType", this.MsgType);
            this.SetParamSimple(map, prefix + "Result", this.Result);
            this.SetParamSimple(map, prefix + "RoleName", this.RoleName);
            this.SetParamSimple(map, prefix + "RoleID", this.RoleID);
            this.SetParamSimple(map, prefix + "QueueRegion", this.QueueRegion);
            this.SetParamSimple(map, prefix + "QueueType", this.QueueType);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "ErrMsg", this.ErrMsg);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

