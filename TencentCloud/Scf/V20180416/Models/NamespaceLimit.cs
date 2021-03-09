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

namespace TencentCloud.Scf.V20180416.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class NamespaceLimit : AbstractModel
    {
        
        /// <summary>
        /// 函数总数
        /// </summary>
        [JsonProperty("FunctionsCount")]
        public long? FunctionsCount{ get; set; }

        /// <summary>
        /// Trigger信息
        /// </summary>
        [JsonProperty("Trigger")]
        public TriggerCount Trigger{ get; set; }

        /// <summary>
        /// Namespace名称
        /// </summary>
        [JsonProperty("Namespace")]
        public string Namespace{ get; set; }

        /// <summary>
        /// 并发量
        /// </summary>
        [JsonProperty("ConcurrentExecutions")]
        public long? ConcurrentExecutions{ get; set; }

        /// <summary>
        /// Timeout限制
        /// </summary>
        [JsonProperty("TimeoutLimit")]
        public long? TimeoutLimit{ get; set; }

        /// <summary>
        /// 测试事件限制
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TestModelLimit")]
        public long? TestModelLimit{ get; set; }

        /// <summary>
        /// 初始化超时限制
        /// </summary>
        [JsonProperty("InitTimeoutLimit")]
        public long? InitTimeoutLimit{ get; set; }

        /// <summary>
        /// 异步重试次数限制
        /// </summary>
        [JsonProperty("RetryNumLimit")]
        public long? RetryNumLimit{ get; set; }

        /// <summary>
        /// 异步重试消息保留时间下限
        /// </summary>
        [JsonProperty("MinMsgTTL")]
        public long? MinMsgTTL{ get; set; }

        /// <summary>
        /// 异步重试消息保留时间上限
        /// </summary>
        [JsonProperty("MaxMsgTTL")]
        public long? MaxMsgTTL{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FunctionsCount", this.FunctionsCount);
            this.SetParamObj(map, prefix + "Trigger.", this.Trigger);
            this.SetParamSimple(map, prefix + "Namespace", this.Namespace);
            this.SetParamSimple(map, prefix + "ConcurrentExecutions", this.ConcurrentExecutions);
            this.SetParamSimple(map, prefix + "TimeoutLimit", this.TimeoutLimit);
            this.SetParamSimple(map, prefix + "TestModelLimit", this.TestModelLimit);
            this.SetParamSimple(map, prefix + "InitTimeoutLimit", this.InitTimeoutLimit);
            this.SetParamSimple(map, prefix + "RetryNumLimit", this.RetryNumLimit);
            this.SetParamSimple(map, prefix + "MinMsgTTL", this.MinMsgTTL);
            this.SetParamSimple(map, prefix + "MaxMsgTTL", this.MaxMsgTTL);
        }
    }
}

