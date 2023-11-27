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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyLogKafkaDeliverTypeRequest : AbstractModel
    {
        
        /// <summary>
        /// 安全模块类型 1: 入侵检测 2: 漏洞管理 3: 基线管理 4: 高级防御 5:客户端相关 6: 资产指纹
        /// </summary>
        [JsonProperty("SecurityType")]
        public ulong? SecurityType{ get; set; }

        /// <summary>
        /// 安全模块下的日志类型，
        /// </summary>
        [JsonProperty("LogType")]
        public ulong?[] LogType{ get; set; }

        /// <summary>
        /// 投递开关 0关闭 1开启
        /// </summary>
        [JsonProperty("Switch")]
        public ulong? Switch{ get; set; }

        /// <summary>
        /// kafka topic id
        /// </summary>
        [JsonProperty("TopicId")]
        public string TopicId{ get; set; }

        /// <summary>
        /// kafka topic name
        /// </summary>
        [JsonProperty("TopicName")]
        public string TopicName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SecurityType", this.SecurityType);
            this.SetParamArraySimple(map, prefix + "LogType.", this.LogType);
            this.SetParamSimple(map, prefix + "Switch", this.Switch);
            this.SetParamSimple(map, prefix + "TopicId", this.TopicId);
            this.SetParamSimple(map, prefix + "TopicName", this.TopicName);
        }
    }
}

